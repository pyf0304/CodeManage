
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRsPoliticsWApi
 表名:RsPolitics(01120110)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:04
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
public static class clsRsPoliticsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRsPoliticsEN Setid_Politics(this clsRsPoliticsEN objRsPoliticsEN, string strid_Politics, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Politics, 4, conRsPolitics.id_Politics);
clsCheckSql.CheckFieldForeignKey(strid_Politics, 4, conRsPolitics.id_Politics);
objRsPoliticsEN.id_Politics = strid_Politics; //政治面貌流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRsPoliticsEN.dicFldComparisonOp.ContainsKey(conRsPolitics.id_Politics) == false)
{
objRsPoliticsEN.dicFldComparisonOp.Add(conRsPolitics.id_Politics, strComparisonOp);
}
else
{
objRsPoliticsEN.dicFldComparisonOp[conRsPolitics.id_Politics] = strComparisonOp;
}
}
return objRsPoliticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRsPoliticsEN SetPoliticsID(this clsRsPoliticsEN objRsPoliticsEN, string strPoliticsID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsID, conRsPolitics.PoliticsID);
clsCheckSql.CheckFieldLen(strPoliticsID, 4, conRsPolitics.PoliticsID);
objRsPoliticsEN.PoliticsID = strPoliticsID; //政治面貌ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRsPoliticsEN.dicFldComparisonOp.ContainsKey(conRsPolitics.PoliticsID) == false)
{
objRsPoliticsEN.dicFldComparisonOp.Add(conRsPolitics.PoliticsID, strComparisonOp);
}
else
{
objRsPoliticsEN.dicFldComparisonOp[conRsPolitics.PoliticsID] = strComparisonOp;
}
}
return objRsPoliticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRsPoliticsEN SetPoliticsName(this clsRsPoliticsEN objRsPoliticsEN, string strPoliticsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPoliticsName, conRsPolitics.PoliticsName);
clsCheckSql.CheckFieldLen(strPoliticsName, 30, conRsPolitics.PoliticsName);
objRsPoliticsEN.PoliticsName = strPoliticsName; //政治面貌
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRsPoliticsEN.dicFldComparisonOp.ContainsKey(conRsPolitics.PoliticsName) == false)
{
objRsPoliticsEN.dicFldComparisonOp.Add(conRsPolitics.PoliticsName, strComparisonOp);
}
else
{
objRsPoliticsEN.dicFldComparisonOp[conRsPolitics.PoliticsName] = strComparisonOp;
}
}
return objRsPoliticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRsPoliticsEN SetPoliticsID_NGB(this clsRsPoliticsEN objRsPoliticsEN, string strPoliticsID_NGB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsID_NGB, 10, conRsPolitics.PoliticsID_NGB);
objRsPoliticsEN.PoliticsID_NGB = strPoliticsID_NGB; //PoliticsID_NGB
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRsPoliticsEN.dicFldComparisonOp.ContainsKey(conRsPolitics.PoliticsID_NGB) == false)
{
objRsPoliticsEN.dicFldComparisonOp.Add(conRsPolitics.PoliticsID_NGB, strComparisonOp);
}
else
{
objRsPoliticsEN.dicFldComparisonOp[conRsPolitics.PoliticsID_NGB] = strComparisonOp;
}
}
return objRsPoliticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRsPoliticsEN SetPoliticsRecruitID(this clsRsPoliticsEN objRsPoliticsEN, string strPoliticsRecruitID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPoliticsRecruitID, 2, conRsPolitics.PoliticsRecruitID);
clsCheckSql.CheckFieldForeignKey(strPoliticsRecruitID, 2, conRsPolitics.PoliticsRecruitID);
objRsPoliticsEN.PoliticsRecruitID = strPoliticsRecruitID; //PoliticsRecruitID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRsPoliticsEN.dicFldComparisonOp.ContainsKey(conRsPolitics.PoliticsRecruitID) == false)
{
objRsPoliticsEN.dicFldComparisonOp.Add(conRsPolitics.PoliticsRecruitID, strComparisonOp);
}
else
{
objRsPoliticsEN.dicFldComparisonOp[conRsPolitics.PoliticsRecruitID] = strComparisonOp;
}
}
return objRsPoliticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRsPoliticsEN SetModifyDate(this clsRsPoliticsEN objRsPoliticsEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conRsPolitics.ModifyDate);
objRsPoliticsEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRsPoliticsEN.dicFldComparisonOp.ContainsKey(conRsPolitics.ModifyDate) == false)
{
objRsPoliticsEN.dicFldComparisonOp.Add(conRsPolitics.ModifyDate, strComparisonOp);
}
else
{
objRsPoliticsEN.dicFldComparisonOp[conRsPolitics.ModifyDate] = strComparisonOp;
}
}
return objRsPoliticsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsRsPoliticsEN SetModifyUserID(this clsRsPoliticsEN objRsPoliticsEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conRsPolitics.ModifyUserID);
objRsPoliticsEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objRsPoliticsEN.dicFldComparisonOp.ContainsKey(conRsPolitics.ModifyUserID) == false)
{
objRsPoliticsEN.dicFldComparisonOp.Add(conRsPolitics.ModifyUserID, strComparisonOp);
}
else
{
objRsPoliticsEN.dicFldComparisonOp[conRsPolitics.ModifyUserID] = strComparisonOp;
}
}
return objRsPoliticsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsRsPoliticsEN objRsPolitics_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objRsPolitics_Cond.IsUpdated(conRsPolitics.id_Politics) == true)
{
string strComparisonOp_id_Politics = objRsPolitics_Cond.dicFldComparisonOp[conRsPolitics.id_Politics];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRsPolitics.id_Politics, objRsPolitics_Cond.id_Politics, strComparisonOp_id_Politics);
}
if (objRsPolitics_Cond.IsUpdated(conRsPolitics.PoliticsID) == true)
{
string strComparisonOp_PoliticsID = objRsPolitics_Cond.dicFldComparisonOp[conRsPolitics.PoliticsID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRsPolitics.PoliticsID, objRsPolitics_Cond.PoliticsID, strComparisonOp_PoliticsID);
}
if (objRsPolitics_Cond.IsUpdated(conRsPolitics.PoliticsName) == true)
{
string strComparisonOp_PoliticsName = objRsPolitics_Cond.dicFldComparisonOp[conRsPolitics.PoliticsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRsPolitics.PoliticsName, objRsPolitics_Cond.PoliticsName, strComparisonOp_PoliticsName);
}
if (objRsPolitics_Cond.IsUpdated(conRsPolitics.PoliticsID_NGB) == true)
{
string strComparisonOp_PoliticsID_NGB = objRsPolitics_Cond.dicFldComparisonOp[conRsPolitics.PoliticsID_NGB];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRsPolitics.PoliticsID_NGB, objRsPolitics_Cond.PoliticsID_NGB, strComparisonOp_PoliticsID_NGB);
}
if (objRsPolitics_Cond.IsUpdated(conRsPolitics.PoliticsRecruitID) == true)
{
string strComparisonOp_PoliticsRecruitID = objRsPolitics_Cond.dicFldComparisonOp[conRsPolitics.PoliticsRecruitID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRsPolitics.PoliticsRecruitID, objRsPolitics_Cond.PoliticsRecruitID, strComparisonOp_PoliticsRecruitID);
}
if (objRsPolitics_Cond.IsUpdated(conRsPolitics.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objRsPolitics_Cond.dicFldComparisonOp[conRsPolitics.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRsPolitics.ModifyDate, objRsPolitics_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objRsPolitics_Cond.IsUpdated(conRsPolitics.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objRsPolitics_Cond.dicFldComparisonOp[conRsPolitics.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conRsPolitics.ModifyUserID, objRsPolitics_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objRsPoliticsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsRsPoliticsEN objRsPoliticsEN)
{
 if (string.IsNullOrEmpty(objRsPoliticsEN.id_Politics) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objRsPoliticsEN.sf_UpdFldSetStr = objRsPoliticsEN.getsf_UpdFldSetStr();
clsRsPoliticsWApi.CheckPropertyNew(objRsPoliticsEN); 
bool bolResult = clsRsPoliticsWApi.UpdateRecord(objRsPoliticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRsPoliticsWApi.ReFreshCache();
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
 /// <param name = "objRsPoliticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsRsPoliticsEN objRsPoliticsEN)
{
 if (string.IsNullOrEmpty(objRsPoliticsEN.id_Politics) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsRsPoliticsWApi.IsExist(objRsPoliticsEN.id_Politics) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objRsPoliticsEN.id_Politics, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsRsPoliticsWApi.CheckPropertyNew(objRsPoliticsEN); 
bool bolResult = clsRsPoliticsWApi.AddNewRecord(objRsPoliticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRsPoliticsWApi.ReFreshCache();
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
 /// <param name = "objRsPoliticsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsRsPoliticsEN objRsPoliticsEN)
{
try
{
clsRsPoliticsWApi.CheckPropertyNew(objRsPoliticsEN); 
string strid_Politics = clsRsPoliticsWApi.AddNewRecordWithMaxId(objRsPoliticsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRsPoliticsWApi.ReFreshCache();
return strid_Politics;
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
 /// <param name = "objRsPoliticsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsRsPoliticsEN objRsPoliticsEN, string strWhereCond)
{
try
{
clsRsPoliticsWApi.CheckPropertyNew(objRsPoliticsEN); 
bool bolResult = clsRsPoliticsWApi.UpdateWithCondition(objRsPoliticsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRsPoliticsWApi.ReFreshCache();
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
 /// 政治面貌(RsPolitics)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsRsPoliticsWApi
{
private static readonly string mstrApiControllerName = "RsPoliticsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsRsPoliticsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_Politics(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[政治面貌]...","0");
List<clsRsPoliticsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_Politics";
objDDL.DataTextField="PoliticsName";
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
public static void BindCbo_id_Politics(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conRsPolitics.id_Politics); 
List<clsRsPoliticsEN> arrObjLst = clsRsPoliticsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsRsPoliticsEN objRsPoliticsEN = new clsRsPoliticsEN()
{
id_Politics = "0",
PoliticsName = "选[政治面貌]..."
};
arrObjLst.Insert(0, objRsPoliticsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conRsPolitics.id_Politics;
objComboBox.DisplayMember = conRsPolitics.PoliticsName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsRsPoliticsEN objRsPoliticsEN)
{
if (!Object.Equals(null, objRsPoliticsEN.id_Politics) && GetStrLen(objRsPoliticsEN.id_Politics) > 4)
{
 throw new Exception("字段[政治面貌流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objRsPoliticsEN.PoliticsID) && GetStrLen(objRsPoliticsEN.PoliticsID) > 4)
{
 throw new Exception("字段[政治面貌ID]的长度不能超过4!");
}
if (!Object.Equals(null, objRsPoliticsEN.PoliticsName) && GetStrLen(objRsPoliticsEN.PoliticsName) > 30)
{
 throw new Exception("字段[政治面貌]的长度不能超过30!");
}
if (!Object.Equals(null, objRsPoliticsEN.PoliticsID_NGB) && GetStrLen(objRsPoliticsEN.PoliticsID_NGB) > 10)
{
 throw new Exception("字段[PoliticsID_NGB]的长度不能超过10!");
}
if (!Object.Equals(null, objRsPoliticsEN.PoliticsRecruitID) && GetStrLen(objRsPoliticsEN.PoliticsRecruitID) > 2)
{
 throw new Exception("字段[PoliticsRecruitID]的长度不能超过2!");
}
if (!Object.Equals(null, objRsPoliticsEN.ModifyDate) && GetStrLen(objRsPoliticsEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objRsPoliticsEN.ModifyUserID) && GetStrLen(objRsPoliticsEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
 objRsPoliticsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_Politics">表关键字</param>
 /// <returns>表对象</returns>
public static clsRsPoliticsEN GetObjByid_Politics(string strid_Politics)
{
string strAction = "GetObjByid_Politics";
string strErrMsg = string.Empty;
string strResult = "";
clsRsPoliticsEN objRsPoliticsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Politics"] = strid_Politics
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objRsPoliticsEN = JsonConvert.DeserializeObject<clsRsPoliticsEN>((string)jobjReturn["ReturnObj"]);
return objRsPoliticsEN;
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
 /// <param name = "strid_Politics">表关键字</param>
 /// <returns>表对象</returns>
public static clsRsPoliticsEN GetObjByid_Politics_WA_Cache(string strid_Politics)
{
string strAction = "GetObjByid_Politics_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsRsPoliticsEN objRsPoliticsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Politics"] = strid_Politics
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objRsPoliticsEN = JsonConvert.DeserializeObject<clsRsPoliticsEN>((string)jobjReturn["ReturnObj"]);
return objRsPoliticsEN;
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
public static clsRsPoliticsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsRsPoliticsEN objRsPoliticsEN = null;
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
objRsPoliticsEN = JsonConvert.DeserializeObject<clsRsPoliticsEN>((string)jobjReturn["ReturnObj"]);
return objRsPoliticsEN;
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
 /// <param name = "strid_Politics">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsRsPoliticsEN GetObjByid_Politics_Cache(string strid_Politics)
{
if (string.IsNullOrEmpty(strid_Politics) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsRsPoliticsEN._CurrTabName_S);
List<clsRsPoliticsEN> arrRsPoliticsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRsPoliticsEN> arrRsPoliticsObjLst_Sel =
from objRsPoliticsEN in arrRsPoliticsObjLst_Cache
where objRsPoliticsEN.id_Politics == strid_Politics
select objRsPoliticsEN;
if (arrRsPoliticsObjLst_Sel.Count() == 0)
{
   clsRsPoliticsEN obj = clsRsPoliticsWApi.GetObjByid_Politics(strid_Politics);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrRsPoliticsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Politics">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPoliticsNameByid_Politics_Cache(string strid_Politics)
{
if (string.IsNullOrEmpty(strid_Politics) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsRsPoliticsEN._CurrTabName_S);
List<clsRsPoliticsEN> arrRsPoliticsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRsPoliticsEN> arrRsPoliticsObjLst_Sel1 =
from objRsPoliticsEN in arrRsPoliticsObjLst_Cache
where objRsPoliticsEN.id_Politics == strid_Politics
select objRsPoliticsEN;
List <clsRsPoliticsEN> arrRsPoliticsObjLst_Sel = new List<clsRsPoliticsEN>();
foreach (clsRsPoliticsEN obj in arrRsPoliticsObjLst_Sel1)
{
arrRsPoliticsObjLst_Sel.Add(obj);
}
if (arrRsPoliticsObjLst_Sel.Count > 0)
{
return arrRsPoliticsObjLst_Sel[0].PoliticsName;
}
string strErrMsgForGetObjById = string.Format("在RsPolitics对象缓存列表中,找不到记录[id_Politics = {0}](函数:{1})", strid_Politics, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsRsPoliticsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Politics">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_Politics_Cache(string strid_Politics)
{
if (string.IsNullOrEmpty(strid_Politics) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsRsPoliticsEN._CurrTabName_S);
List<clsRsPoliticsEN> arrRsPoliticsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRsPoliticsEN> arrRsPoliticsObjLst_Sel1 =
from objRsPoliticsEN in arrRsPoliticsObjLst_Cache
where objRsPoliticsEN.id_Politics == strid_Politics
select objRsPoliticsEN;
List <clsRsPoliticsEN> arrRsPoliticsObjLst_Sel = new List<clsRsPoliticsEN>();
foreach (clsRsPoliticsEN obj in arrRsPoliticsObjLst_Sel1)
{
arrRsPoliticsObjLst_Sel.Add(obj);
}
if (arrRsPoliticsObjLst_Sel.Count > 0)
{
return arrRsPoliticsObjLst_Sel[0].PoliticsName;
}
string strErrMsgForGetObjById = string.Format("在RsPolitics对象缓存列表中,找不到记录的相关名称[id_Politics = {0}](函数:{1})", strid_Politics, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsRsPoliticsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRsPoliticsEN> GetObjLst(string strWhereCond)
{
 List<clsRsPoliticsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRsPoliticsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsRsPoliticsEN> GetObjLstById_PoliticsLst(List<string> arrId_Politics)
{
 List<clsRsPoliticsEN> arrObjLst = null; 
string strAction = "GetObjLstById_PoliticsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Politics);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsRsPoliticsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_Politics">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsRsPoliticsEN> GetObjLstById_PoliticsLst_Cache(List<string> arrId_Politics)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsRsPoliticsEN._CurrTabName_S);
List<clsRsPoliticsEN> arrRsPoliticsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsRsPoliticsEN> arrRsPoliticsObjLst_Sel =
from objRsPoliticsEN in arrRsPoliticsObjLst_Cache
where arrId_Politics.Contains(objRsPoliticsEN.id_Politics)
select objRsPoliticsEN;
return arrRsPoliticsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsRsPoliticsEN> GetObjLstById_PoliticsLst_WA_Cache(List<string> arrId_Politics)
{
 List<clsRsPoliticsEN> arrObjLst = null; 
string strAction = "GetObjLstById_PoliticsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Politics);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsRsPoliticsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsRsPoliticsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsRsPoliticsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRsPoliticsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsRsPoliticsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsRsPoliticsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRsPoliticsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsRsPoliticsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsRsPoliticsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRsPoliticsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsRsPoliticsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsRsPoliticsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsRsPoliticsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_Politics)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsRsPoliticsEN objRsPoliticsEN = clsRsPoliticsWApi.GetObjByid_Politics(strid_Politics);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_Politics.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsRsPoliticsWApi.ReFreshCache();
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
public static int DelRsPoliticss(List<string> arrid_Politics)
{
string strAction = "DelRsPoliticss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_Politics);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsRsPoliticsWApi.ReFreshCache();
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
public static int DelRsPoliticssByCond(string strWhereCond)
{
string strAction = "DelRsPoliticssByCond";
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
public static bool AddNewRecord(clsRsPoliticsEN objRsPoliticsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRsPoliticsEN>(objRsPoliticsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRsPoliticsWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsRsPoliticsEN objRsPoliticsEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRsPoliticsEN>(objRsPoliticsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsRsPoliticsWApi.ReFreshCache();
var strid_Politics = (string)jobjReturn["ReturnStr"];
return strid_Politics;
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
public static bool UpdateRecord(clsRsPoliticsEN objRsPoliticsEN)
{
if (string.IsNullOrEmpty(objRsPoliticsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objRsPoliticsEN.id_Politics, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRsPoliticsEN>(objRsPoliticsEN);
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
 /// <param name = "objRsPoliticsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsRsPoliticsEN objRsPoliticsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objRsPoliticsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objRsPoliticsEN.id_Politics, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objRsPoliticsEN.id_Politics, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsRsPoliticsEN>(objRsPoliticsEN);
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
public static bool IsExist(string strid_Politics)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Politics"] = strid_Politics
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
 /// <param name = "objRsPoliticsENS">源对象</param>
 /// <param name = "objRsPoliticsENT">目标对象</param>
 public static void CopyTo(clsRsPoliticsEN objRsPoliticsENS, clsRsPoliticsEN objRsPoliticsENT)
{
try
{
objRsPoliticsENT.id_Politics = objRsPoliticsENS.id_Politics; //政治面貌流水号
objRsPoliticsENT.PoliticsID = objRsPoliticsENS.PoliticsID; //政治面貌ID
objRsPoliticsENT.PoliticsName = objRsPoliticsENS.PoliticsName; //政治面貌
objRsPoliticsENT.PoliticsID_NGB = objRsPoliticsENS.PoliticsID_NGB; //PoliticsID_NGB
objRsPoliticsENT.PoliticsRecruitID = objRsPoliticsENS.PoliticsRecruitID; //PoliticsRecruitID
objRsPoliticsENT.ModifyDate = objRsPoliticsENS.ModifyDate; //修改日期
objRsPoliticsENT.ModifyUserID = objRsPoliticsENS.ModifyUserID; //修改人
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
public static DataTable ToDataTable(List<clsRsPoliticsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsRsPoliticsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsRsPoliticsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsRsPoliticsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsRsPoliticsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsRsPoliticsEN.AttributeName)
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
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_Politics");
//if (arrRsPoliticsObjLst_Cache == null)
//{
//arrRsPoliticsObjLst_Cache = await clsRsPoliticsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsRsPoliticsEN._CurrTabName_S);
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
if (clsRsPoliticsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsRsPoliticsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsRsPoliticsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsRsPoliticsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsRsPoliticsEN._CurrTabName_S);
List<clsRsPoliticsEN> arrRsPoliticsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrRsPoliticsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsRsPoliticsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conRsPolitics.id_Politics, Type.GetType("System.String"));
objDT.Columns.Add(conRsPolitics.PoliticsID, Type.GetType("System.String"));
objDT.Columns.Add(conRsPolitics.PoliticsName, Type.GetType("System.String"));
objDT.Columns.Add(conRsPolitics.PoliticsID_NGB, Type.GetType("System.String"));
objDT.Columns.Add(conRsPolitics.PoliticsRecruitID, Type.GetType("System.String"));
objDT.Columns.Add(conRsPolitics.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conRsPolitics.ModifyUserID, Type.GetType("System.String"));
foreach (clsRsPoliticsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conRsPolitics.id_Politics] = objInFor[conRsPolitics.id_Politics];
objDR[conRsPolitics.PoliticsID] = objInFor[conRsPolitics.PoliticsID];
objDR[conRsPolitics.PoliticsName] = objInFor[conRsPolitics.PoliticsName];
objDR[conRsPolitics.PoliticsID_NGB] = objInFor[conRsPolitics.PoliticsID_NGB];
objDR[conRsPolitics.PoliticsRecruitID] = objInFor[conRsPolitics.PoliticsRecruitID];
objDR[conRsPolitics.ModifyDate] = objInFor[conRsPolitics.ModifyDate];
objDR[conRsPolitics.ModifyUserID] = objInFor[conRsPolitics.ModifyUserID];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 政治面貌(RsPolitics)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4RsPolitics : clsCommFun4BL
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
clsRsPoliticsWApi.ReFreshThisCache();
}
}

}