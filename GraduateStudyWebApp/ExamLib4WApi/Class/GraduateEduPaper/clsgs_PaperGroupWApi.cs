
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperGroupWApi
 表名:gs_PaperGroup(01120749)
 生成代码版本:2021.08.17.1
 生成日期:2021/08/20 02:36:57
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsgs_PaperGroupWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperGroupEN SetPaperGroupId(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strPaperGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperGroupId, 8, congs_PaperGroup.PaperGroupId);
clsCheckSql.CheckFieldForeignKey(strPaperGroupId, 8, congs_PaperGroup.PaperGroupId);
objgs_PaperGroupEN.PaperGroupId = strPaperGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.PaperGroupId) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.PaperGroupId, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.PaperGroupId] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperGroupEN SetPaperGroupName(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strPaperGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperGroupName, 50, congs_PaperGroup.PaperGroupName);
objgs_PaperGroupEN.PaperGroupName = strPaperGroupName; //组名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.PaperGroupName) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.PaperGroupName, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.PaperGroupName] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperGroupEN SetUpdUser(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, congs_PaperGroup.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_PaperGroup.UpdUser);
objgs_PaperGroupEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.UpdUser) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.UpdUser, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.UpdUser] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperGroupEN SetUpdDate(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_PaperGroup.UpdDate);
objgs_PaperGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.UpdDate) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.UpdDate, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.UpdDate] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperGroupEN SetMeno(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strMeno, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMeno, 2000, congs_PaperGroup.Meno);
objgs_PaperGroupEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperGroupEN.dicFldComparisonOp.ContainsKey(congs_PaperGroup.Meno) == false)
{
objgs_PaperGroupEN.dicFldComparisonOp.Add(congs_PaperGroup.Meno, strComparisonOp);
}
else
{
objgs_PaperGroupEN.dicFldComparisonOp[congs_PaperGroup.Meno] = strComparisonOp;
}
}
return objgs_PaperGroupEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_PaperGroupEN objgs_PaperGroup_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperGroup_Cond.IsUpdated(congs_PaperGroup.PaperGroupId) == true)
{
string strComparisonOp_PaperGroupId = objgs_PaperGroup_Cond.dicFldComparisonOp[congs_PaperGroup.PaperGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.PaperGroupId, objgs_PaperGroup_Cond.PaperGroupId, strComparisonOp_PaperGroupId);
}
if (objgs_PaperGroup_Cond.IsUpdated(congs_PaperGroup.PaperGroupName) == true)
{
string strComparisonOp_PaperGroupName = objgs_PaperGroup_Cond.dicFldComparisonOp[congs_PaperGroup.PaperGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.PaperGroupName, objgs_PaperGroup_Cond.PaperGroupName, strComparisonOp_PaperGroupName);
}
if (objgs_PaperGroup_Cond.IsUpdated(congs_PaperGroup.UpdUser) == true)
{
string strComparisonOp_UpdUser = objgs_PaperGroup_Cond.dicFldComparisonOp[congs_PaperGroup.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.UpdUser, objgs_PaperGroup_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objgs_PaperGroup_Cond.IsUpdated(congs_PaperGroup.UpdDate) == true)
{
string strComparisonOp_UpdDate = objgs_PaperGroup_Cond.dicFldComparisonOp[congs_PaperGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.UpdDate, objgs_PaperGroup_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objgs_PaperGroup_Cond.IsUpdated(congs_PaperGroup.Meno) == true)
{
string strComparisonOp_Meno = objgs_PaperGroup_Cond.dicFldComparisonOp[congs_PaperGroup.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperGroup.Meno, objgs_PaperGroup_Cond.Meno, strComparisonOp_Meno);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objgs_PaperGroupEN.sf_UpdFldSetStr = objgs_PaperGroupEN.getsf_UpdFldSetStr();
clsgs_PaperGroupWApi.CheckPropertyNew(objgs_PaperGroupEN); 
bool bolResult = clsgs_PaperGroupWApi.UpdateRecord(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
 /// 检查唯一性(Uniqueness)--gs_PaperGroup(论文分组), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PaperGroupName_UpdUser(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperGroupEN == null) return "";
if (objgs_PaperGroupEN.PaperGroupId == null || objgs_PaperGroupEN.PaperGroupId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.PaperGroupName);
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objgs_PaperGroupEN.UpdUser);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperGroupId !=  '{0}'", objgs_PaperGroupEN.PaperGroupId);
 sbCondition.AppendFormat(" and PaperGroupName = '{0}'", objgs_PaperGroupEN.PaperGroupName);
 sbCondition.AppendFormat(" and UpdUser = '{0}'", objgs_PaperGroupEN.UpdUser);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
try
{
 if (string.IsNullOrEmpty(objgs_PaperGroupEN.PaperGroupId) == true || clsgs_PaperGroupWApi.IsExist(objgs_PaperGroupEN.PaperGroupId) == true)
 {
     objgs_PaperGroupEN.PaperGroupId = clsgs_PaperGroupWApi.GetMaxStrId();
 }
clsgs_PaperGroupWApi.CheckPropertyNew(objgs_PaperGroupEN); 
bool bolResult = clsgs_PaperGroupWApi.AddNewRecord(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
 /// <param name = "objgs_PaperGroupEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_PaperGroupEN objgs_PaperGroupEN)
{
try
{
clsgs_PaperGroupWApi.CheckPropertyNew(objgs_PaperGroupEN); 
string strPaperGroupId = clsgs_PaperGroupWApi.AddNewRecordWithMaxId(objgs_PaperGroupEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
return strPaperGroupId;
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
 /// <param name = "objgs_PaperGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperGroupEN objgs_PaperGroupEN, string strWhereCond)
{
try
{
clsgs_PaperGroupWApi.CheckPropertyNew(objgs_PaperGroupEN); 
bool bolResult = clsgs_PaperGroupWApi.UpdateWithCondition(objgs_PaperGroupEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
 /// 论文分组(gs_PaperGroup)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsgs_PaperGroupWApi
{
private static readonly string mstrApiControllerName = "gs_PaperGroupApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsgs_PaperGroupWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PaperGroupId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文分组]...","0");
List<clsgs_PaperGroupEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="PaperGroupId";
objDDL.DataTextField="PaperGroupName";
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
public static void BindCbo_PaperGroupId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", congs_PaperGroup.PaperGroupId); 
List<clsgs_PaperGroupEN> arrObjLst = clsgs_PaperGroupWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsgs_PaperGroupEN objgs_PaperGroupEN = new clsgs_PaperGroupEN()
{
PaperGroupId = "0",
PaperGroupName = "选[论文分组]..."
};
arrObjLst.Insert(0, objgs_PaperGroupEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = congs_PaperGroup.PaperGroupId;
objComboBox.DisplayMember = congs_PaperGroup.PaperGroupName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
if (!Object.Equals(null, objgs_PaperGroupEN.PaperGroupId) && GetStrLen(objgs_PaperGroupEN.PaperGroupId) > 8)
{
 throw new Exception("字段[组Id]的长度不能超过8!");
}
if (!Object.Equals(null, objgs_PaperGroupEN.PaperGroupName) && GetStrLen(objgs_PaperGroupEN.PaperGroupName) > 50)
{
 throw new Exception("字段[组名]的长度不能超过50!");
}
if (!Object.Equals(null, objgs_PaperGroupEN.UpdUser) && GetStrLen(objgs_PaperGroupEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objgs_PaperGroupEN.UpdDate) && GetStrLen(objgs_PaperGroupEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objgs_PaperGroupEN.Meno) && GetStrLen(objgs_PaperGroupEN.Meno) > 2000)
{
 throw new Exception("字段[备注]的长度不能超过2000!");
}
 objgs_PaperGroupEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperGroupEN GetObjByPaperGroupId(string strPaperGroupId)
{
string strAction = "GetObjByPaperGroupId";
string strErrMsg = string.Empty;
string strResult = "";
clsgs_PaperGroupEN objgs_PaperGroupEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperGroupId"] = strPaperGroupId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objgs_PaperGroupEN = JsonConvert.DeserializeObject<clsgs_PaperGroupEN>((string)jobjReturn["ReturnObj"]);
return objgs_PaperGroupEN;
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
 /// <param name = "strPaperGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperGroupEN GetObjByPaperGroupId_WA_Cache(string strPaperGroupId, string strUpdUser)
{
string strAction = "GetObjByPaperGroupId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsgs_PaperGroupEN objgs_PaperGroupEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperGroupId"] = strPaperGroupId,
["UpdUser"] = strUpdUser
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objgs_PaperGroupEN = JsonConvert.DeserializeObject<clsgs_PaperGroupEN>((string)jobjReturn["ReturnObj"]);
return objgs_PaperGroupEN;
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
public static clsgs_PaperGroupEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsgs_PaperGroupEN objgs_PaperGroupEN = null;
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
objgs_PaperGroupEN = JsonConvert.DeserializeObject<clsgs_PaperGroupEN>((string)jobjReturn["ReturnObj"]);
return objgs_PaperGroupEN;
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
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperGroupEN GetObjByPaperGroupId_Cache(string strPaperGroupId, string strUpdUser)
{
if (string.IsNullOrEmpty(strPaperGroupId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName_S, strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Cache = GetObjLst_Cache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel =
from objgs_PaperGroupEN in arrgs_PaperGroupObjLst_Cache
where objgs_PaperGroupEN.PaperGroupId == strPaperGroupId
select objgs_PaperGroupEN;
if (arrgs_PaperGroupObjLst_Sel.Count() == 0)
{
   clsgs_PaperGroupEN obj = clsgs_PaperGroupWApi.GetObjByPaperGroupId(strPaperGroupId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrgs_PaperGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPaperGroupNameByPaperGroupId_Cache(string strPaperGroupId, string strUpdUser)
{
if (string.IsNullOrEmpty(strPaperGroupId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName_S, strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Cache = GetObjLst_Cache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel1 =
from objgs_PaperGroupEN in arrgs_PaperGroupObjLst_Cache
where objgs_PaperGroupEN.PaperGroupId == strPaperGroupId
select objgs_PaperGroupEN;
List <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel = new List<clsgs_PaperGroupEN>();
foreach (clsgs_PaperGroupEN obj in arrgs_PaperGroupObjLst_Sel1)
{
arrgs_PaperGroupObjLst_Sel.Add(obj);
}
if (arrgs_PaperGroupObjLst_Sel.Count > 0)
{
return arrgs_PaperGroupObjLst_Sel[0].PaperGroupName;
}
string strErrMsgForGetObjById = string.Format("在gs_PaperGroup对象缓存列表中,找不到记录[PaperGroupId = {0}](函数:{1})", strPaperGroupId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsgs_PaperGroupBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPaperGroupId_Cache(string strPaperGroupId, string strUpdUser)
{
if (string.IsNullOrEmpty(strPaperGroupId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName_S, strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Cache = GetObjLst_Cache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel1 =
from objgs_PaperGroupEN in arrgs_PaperGroupObjLst_Cache
where objgs_PaperGroupEN.PaperGroupId == strPaperGroupId
select objgs_PaperGroupEN;
List <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel = new List<clsgs_PaperGroupEN>();
foreach (clsgs_PaperGroupEN obj in arrgs_PaperGroupObjLst_Sel1)
{
arrgs_PaperGroupObjLst_Sel.Add(obj);
}
if (arrgs_PaperGroupObjLst_Sel.Count > 0)
{
return arrgs_PaperGroupObjLst_Sel[0].PaperGroupName;
}
string strErrMsgForGetObjById = string.Format("在gs_PaperGroup对象缓存列表中,找不到记录的相关名称[PaperGroupId = {0}](函数:{1})", strPaperGroupId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsgs_PaperGroupBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLst(string strWhereCond)
{
 List<clsgs_PaperGroupEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperGroupEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperGroupEN> GetObjLstByPaperGroupIdLst(List<string> arrPaperGroupId)
{
 List<clsgs_PaperGroupEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperGroupIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperGroupId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperGroupEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strPaperGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsgs_PaperGroupEN> GetObjLstByPaperGroupIdLst_Cache(List<string> arrPaperGroupId, string strUpdUser)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName_S, strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Cache = GetObjLst_Cache(strUpdUser);
IEnumerable <clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Sel =
from objgs_PaperGroupEN in arrgs_PaperGroupObjLst_Cache
where arrPaperGroupId.Contains(objgs_PaperGroupEN.PaperGroupId)
select objgs_PaperGroupEN;
return arrgs_PaperGroupObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLstByPaperGroupIdLst_WA_Cache(List<string> arrPaperGroupId, string strUpdUser)
{
 List<clsgs_PaperGroupEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperGroupIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UpdUser"] = strUpdUser
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperGroupId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperGroupEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperGroupEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsgs_PaperGroupEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperGroupEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperGroupEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsgs_PaperGroupEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperGroupEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsgs_PaperGroupEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperGroupEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperGroupEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsgs_PaperGroupEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperGroupEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strPaperGroupId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsgs_PaperGroupEN objgs_PaperGroupEN = clsgs_PaperGroupWApi.GetObjByPaperGroupId(strPaperGroupId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPaperGroupId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
public static int Delgs_PaperGroups(List<string> arrPaperGroupId)
{
string strAction = "Delgs_PaperGroups";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperGroupId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsgs_PaperGroupEN objgs_PaperGroupEN = clsgs_PaperGroupWApi.GetObjByPaperGroupId(arrPaperGroupId[0]);
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
public static int Delgs_PaperGroupsByCond(string strWhereCond)
{
string strAction = "Delgs_PaperGroupsByCond";
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
public static bool AddNewRecord(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperGroupEN>(objgs_PaperGroupEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
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
public static string AddNewRecordWithMaxId(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperGroupEN>(objgs_PaperGroupEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperGroupWApi.ReFreshCache(objgs_PaperGroupEN.UpdUser);
var strPaperGroupId = (string)jobjReturn["ReturnStr"];
return strPaperGroupId;
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
public static bool UpdateRecord(clsgs_PaperGroupEN objgs_PaperGroupEN)
{
if (string.IsNullOrEmpty(objgs_PaperGroupEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objgs_PaperGroupEN.PaperGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperGroupEN>(objgs_PaperGroupEN);
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
 /// <param name = "objgs_PaperGroupEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsgs_PaperGroupEN objgs_PaperGroupEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objgs_PaperGroupEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objgs_PaperGroupEN.PaperGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objgs_PaperGroupEN.PaperGroupId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperGroupEN>(objgs_PaperGroupEN);
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
public static bool IsExist(string strPaperGroupId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperGroupId"] = strPaperGroupId
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
 /// <param name = "objgs_PaperGroupENS">源对象</param>
 /// <param name = "objgs_PaperGroupENT">目标对象</param>
 public static void CopyTo(clsgs_PaperGroupEN objgs_PaperGroupENS, clsgs_PaperGroupEN objgs_PaperGroupENT)
{
try
{
objgs_PaperGroupENT.PaperGroupId = objgs_PaperGroupENS.PaperGroupId; //组Id
objgs_PaperGroupENT.PaperGroupName = objgs_PaperGroupENS.PaperGroupName; //组名
objgs_PaperGroupENT.UpdUser = objgs_PaperGroupENS.UpdUser; //修改人
objgs_PaperGroupENT.UpdDate = objgs_PaperGroupENS.UpdDate; //修改日期
objgs_PaperGroupENT.Meno = objgs_PaperGroupENS.Meno; //备注
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
public static DataTable ToDataTable(List<clsgs_PaperGroupEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsgs_PaperGroupEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsgs_PaperGroupEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsgs_PaperGroupEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsgs_PaperGroupEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsgs_PaperGroupEN.AttributeName)
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
if (clsgs_PaperGroupWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperGroupWApi没有刷新缓存机制(clsgs_PaperGroupWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperGroupId");
//if (arrgs_PaperGroupObjLst_Cache == null)
//{
//arrgs_PaperGroupObjLst_Cache = await clsgs_PaperGroupWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUpdUser = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName_S, strUpdUser);
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
public static void ReFreshCache(string strUpdUser)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsgs_PaperGroupWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName_S, strUpdUser);
CacheHelper.Remove(strKey);
clsgs_PaperGroupWApi.objCommFun4BL.ReFreshCache(strUpdUser);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperGroupEN> GetObjLst_Cache(string strUpdUser)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsgs_PaperGroupEN._CurrTabName_S, strUpdUser);
List<clsgs_PaperGroupEN> arrgs_PaperGroupObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("UpdUser='{0}'", strUpdUser)); });
return arrgs_PaperGroupObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsgs_PaperGroupEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(congs_PaperGroup.PaperGroupId, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperGroup.PaperGroupName, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperGroup.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperGroup.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperGroup.Meno, Type.GetType("System.String"));
foreach (clsgs_PaperGroupEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[congs_PaperGroup.PaperGroupId] = objInFor[congs_PaperGroup.PaperGroupId];
objDR[congs_PaperGroup.PaperGroupName] = objInFor[congs_PaperGroup.PaperGroupName];
objDR[congs_PaperGroup.UpdUser] = objInFor[congs_PaperGroup.UpdUser];
objDR[congs_PaperGroup.UpdDate] = objInFor[congs_PaperGroup.UpdDate];
objDR[congs_PaperGroup.Meno] = objInFor[congs_PaperGroup.Meno];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 论文分组(gs_PaperGroup)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4gs_PaperGroup : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUpdUser)
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
clsgs_PaperGroupWApi.ReFreshThisCache(strUpdUser);
}
}

}