
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeMasterTypeWApi
 表名:KnowledgeMasterType(01120893)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:13
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clsKnowledgeMasterTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterTypeEN SetMasterTypeId(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strMasterTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMasterTypeId, 1, conKnowledgeMasterType.MasterTypeId);
clsCheckSql.CheckFieldForeignKey(strMasterTypeId, 1, conKnowledgeMasterType.MasterTypeId);
objKnowledgeMasterTypeEN.MasterTypeId = strMasterTypeId; //掌握类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterType.MasterTypeId) == false)
{
objKnowledgeMasterTypeEN.dicFldComparisonOp.Add(conKnowledgeMasterType.MasterTypeId, strComparisonOp);
}
else
{
objKnowledgeMasterTypeEN.dicFldComparisonOp[conKnowledgeMasterType.MasterTypeId] = strComparisonOp;
}
}
return objKnowledgeMasterTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterTypeEN SetMasterTypeName(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strMasterTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMasterTypeName, conKnowledgeMasterType.MasterTypeName);
clsCheckSql.CheckFieldLen(strMasterTypeName, 50, conKnowledgeMasterType.MasterTypeName);
objKnowledgeMasterTypeEN.MasterTypeName = strMasterTypeName; //掌握类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterType.MasterTypeName) == false)
{
objKnowledgeMasterTypeEN.dicFldComparisonOp.Add(conKnowledgeMasterType.MasterTypeName, strComparisonOp);
}
else
{
objKnowledgeMasterTypeEN.dicFldComparisonOp[conKnowledgeMasterType.MasterTypeName] = strComparisonOp;
}
}
return objKnowledgeMasterTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterTypeEN SetMasterTypeENName(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strMasterTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMasterTypeENName, 50, conKnowledgeMasterType.MasterTypeENName);
objKnowledgeMasterTypeEN.MasterTypeENName = strMasterTypeENName; //掌握类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterType.MasterTypeENName) == false)
{
objKnowledgeMasterTypeEN.dicFldComparisonOp.Add(conKnowledgeMasterType.MasterTypeENName, strComparisonOp);
}
else
{
objKnowledgeMasterTypeEN.dicFldComparisonOp[conKnowledgeMasterType.MasterTypeENName] = strComparisonOp;
}
}
return objKnowledgeMasterTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterTypeEN SetUpdDate(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conKnowledgeMasterType.UpdDate);
objKnowledgeMasterTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterType.UpdDate) == false)
{
objKnowledgeMasterTypeEN.dicFldComparisonOp.Add(conKnowledgeMasterType.UpdDate, strComparisonOp);
}
else
{
objKnowledgeMasterTypeEN.dicFldComparisonOp[conKnowledgeMasterType.UpdDate] = strComparisonOp;
}
}
return objKnowledgeMasterTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterTypeEN SetUpdUser(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conKnowledgeMasterType.UpdUser);
objKnowledgeMasterTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterType.UpdUser) == false)
{
objKnowledgeMasterTypeEN.dicFldComparisonOp.Add(conKnowledgeMasterType.UpdUser, strComparisonOp);
}
else
{
objKnowledgeMasterTypeEN.dicFldComparisonOp[conKnowledgeMasterType.UpdUser] = strComparisonOp;
}
}
return objKnowledgeMasterTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterTypeEN SetMemo(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conKnowledgeMasterType.Memo);
objKnowledgeMasterTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterTypeEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterType.Memo) == false)
{
objKnowledgeMasterTypeEN.dicFldComparisonOp.Add(conKnowledgeMasterType.Memo, strComparisonOp);
}
else
{
objKnowledgeMasterTypeEN.dicFldComparisonOp[conKnowledgeMasterType.Memo] = strComparisonOp;
}
}
return objKnowledgeMasterTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsKnowledgeMasterTypeEN objKnowledgeMasterType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objKnowledgeMasterType_Cond.IsUpdated(conKnowledgeMasterType.MasterTypeId) == true)
{
string strComparisonOp_MasterTypeId = objKnowledgeMasterType_Cond.dicFldComparisonOp[conKnowledgeMasterType.MasterTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterType.MasterTypeId, objKnowledgeMasterType_Cond.MasterTypeId, strComparisonOp_MasterTypeId);
}
if (objKnowledgeMasterType_Cond.IsUpdated(conKnowledgeMasterType.MasterTypeName) == true)
{
string strComparisonOp_MasterTypeName = objKnowledgeMasterType_Cond.dicFldComparisonOp[conKnowledgeMasterType.MasterTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterType.MasterTypeName, objKnowledgeMasterType_Cond.MasterTypeName, strComparisonOp_MasterTypeName);
}
if (objKnowledgeMasterType_Cond.IsUpdated(conKnowledgeMasterType.MasterTypeENName) == true)
{
string strComparisonOp_MasterTypeENName = objKnowledgeMasterType_Cond.dicFldComparisonOp[conKnowledgeMasterType.MasterTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterType.MasterTypeENName, objKnowledgeMasterType_Cond.MasterTypeENName, strComparisonOp_MasterTypeENName);
}
if (objKnowledgeMasterType_Cond.IsUpdated(conKnowledgeMasterType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objKnowledgeMasterType_Cond.dicFldComparisonOp[conKnowledgeMasterType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterType.UpdDate, objKnowledgeMasterType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objKnowledgeMasterType_Cond.IsUpdated(conKnowledgeMasterType.UpdUser) == true)
{
string strComparisonOp_UpdUser = objKnowledgeMasterType_Cond.dicFldComparisonOp[conKnowledgeMasterType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterType.UpdUser, objKnowledgeMasterType_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objKnowledgeMasterType_Cond.IsUpdated(conKnowledgeMasterType.Memo) == true)
{
string strComparisonOp_Memo = objKnowledgeMasterType_Cond.dicFldComparisonOp[conKnowledgeMasterType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterType.Memo, objKnowledgeMasterType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
 if (string.IsNullOrEmpty(objKnowledgeMasterTypeEN.MasterTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objKnowledgeMasterTypeEN.sf_UpdFldSetStr = objKnowledgeMasterTypeEN.getsf_UpdFldSetStr();
clsKnowledgeMasterTypeWApi.CheckPropertyNew(objKnowledgeMasterTypeEN); 
bool bolResult = clsKnowledgeMasterTypeWApi.UpdateRecord(objKnowledgeMasterTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterTypeWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--KnowledgeMasterType(知识点掌握类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_MasterTypeName(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeMasterTypeEN == null) return "";
if (objKnowledgeMasterTypeEN.MasterTypeId == null || objKnowledgeMasterTypeEN.MasterTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MasterTypeName = '{0}'", objKnowledgeMasterTypeEN.MasterTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MasterTypeId !=  '{0}'", objKnowledgeMasterTypeEN.MasterTypeId);
 sbCondition.AppendFormat(" and MasterTypeName = '{0}'", objKnowledgeMasterTypeEN.MasterTypeName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
try
{
 if (string.IsNullOrEmpty(objKnowledgeMasterTypeEN.MasterTypeId) == true || clsKnowledgeMasterTypeWApi.IsExist(objKnowledgeMasterTypeEN.MasterTypeId) == true)
 {
     objKnowledgeMasterTypeEN.MasterTypeId = clsKnowledgeMasterTypeWApi.GetMaxStrId();
 }
clsKnowledgeMasterTypeWApi.CheckPropertyNew(objKnowledgeMasterTypeEN); 
bool bolResult = clsKnowledgeMasterTypeWApi.AddNewRecord(objKnowledgeMasterTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterTypeWApi.ReFreshCache();
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
 /// <param name = "objKnowledgeMasterTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
try
{
clsKnowledgeMasterTypeWApi.CheckPropertyNew(objKnowledgeMasterTypeEN); 
string strMasterTypeId = clsKnowledgeMasterTypeWApi.AddNewRecordWithMaxId(objKnowledgeMasterTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterTypeWApi.ReFreshCache();
return strMasterTypeId;
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
 /// <param name = "objKnowledgeMasterTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strWhereCond)
{
try
{
clsKnowledgeMasterTypeWApi.CheckPropertyNew(objKnowledgeMasterTypeEN); 
bool bolResult = clsKnowledgeMasterTypeWApi.UpdateWithCondition(objKnowledgeMasterTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterTypeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumKnowledgeMasterTypeWA
{
 /// <summary>
 /// 主观
 /// </summary>
public const string subjective_1 = "1";
 /// <summary>
 /// 客观
 /// </summary>
public const string objective_2 = "2";
}
 /// <summary>
 /// 知识点掌握类型(KnowledgeMasterType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsKnowledgeMasterTypeWApi
{
private static readonly string mstrApiControllerName = "KnowledgeMasterTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsKnowledgeMasterTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MasterTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点掌握类型]...","0");
List<clsKnowledgeMasterTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MasterTypeId";
objDDL.DataTextField="MasterTypeName";
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
public static void BindCbo_MasterTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conKnowledgeMasterType.MasterTypeId); 
List<clsKnowledgeMasterTypeEN> arrObjLst = clsKnowledgeMasterTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = new clsKnowledgeMasterTypeEN()
{
MasterTypeId = "0",
MasterTypeName = "选[知识点掌握类型]..."
};
arrObjLst.Insert(0, objKnowledgeMasterTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conKnowledgeMasterType.MasterTypeId;
objComboBox.DisplayMember = conKnowledgeMasterType.MasterTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
if (!Object.Equals(null, objKnowledgeMasterTypeEN.MasterTypeId) && GetStrLen(objKnowledgeMasterTypeEN.MasterTypeId) > 1)
{
 throw new Exception("字段[掌握类型Id]的长度不能超过1!");
}
if (!Object.Equals(null, objKnowledgeMasterTypeEN.MasterTypeName) && GetStrLen(objKnowledgeMasterTypeEN.MasterTypeName) > 50)
{
 throw new Exception("字段[掌握类型名]的长度不能超过50!");
}
if (!Object.Equals(null, objKnowledgeMasterTypeEN.MasterTypeENName) && GetStrLen(objKnowledgeMasterTypeEN.MasterTypeENName) > 50)
{
 throw new Exception("字段[掌握类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objKnowledgeMasterTypeEN.UpdDate) && GetStrLen(objKnowledgeMasterTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeMasterTypeEN.UpdUser) && GetStrLen(objKnowledgeMasterTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeMasterTypeEN.Memo) && GetStrLen(objKnowledgeMasterTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objKnowledgeMasterTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMasterTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeMasterTypeEN GetObjByMasterTypeId(string strMasterTypeId)
{
string strAction = "GetObjByMasterTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MasterTypeId"] = strMasterTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objKnowledgeMasterTypeEN = JsonConvert.DeserializeObject<clsKnowledgeMasterTypeEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeMasterTypeEN;
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
 /// <param name = "strMasterTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeMasterTypeEN GetObjByMasterTypeId_WA_Cache(string strMasterTypeId)
{
string strAction = "GetObjByMasterTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MasterTypeId"] = strMasterTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objKnowledgeMasterTypeEN = JsonConvert.DeserializeObject<clsKnowledgeMasterTypeEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeMasterTypeEN;
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
public static clsKnowledgeMasterTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = null;
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
objKnowledgeMasterTypeEN = JsonConvert.DeserializeObject<clsKnowledgeMasterTypeEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeMasterTypeEN;
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
 /// <param name = "strMasterTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsKnowledgeMasterTypeEN GetObjByMasterTypeId_Cache(string strMasterTypeId)
{
if (string.IsNullOrEmpty(strMasterTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterTypeEN._CurrTabName_S);
List<clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Sel =
from objKnowledgeMasterTypeEN in arrKnowledgeMasterTypeObjLst_Cache
where objKnowledgeMasterTypeEN.MasterTypeId == strMasterTypeId
select objKnowledgeMasterTypeEN;
if (arrKnowledgeMasterTypeObjLst_Sel.Count() == 0)
{
   clsKnowledgeMasterTypeEN obj = clsKnowledgeMasterTypeWApi.GetObjByMasterTypeId(strMasterTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrKnowledgeMasterTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMasterTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMasterTypeNameByMasterTypeId_Cache(string strMasterTypeId)
{
if (string.IsNullOrEmpty(strMasterTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterTypeEN._CurrTabName_S);
List<clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Sel1 =
from objKnowledgeMasterTypeEN in arrKnowledgeMasterTypeObjLst_Cache
where objKnowledgeMasterTypeEN.MasterTypeId == strMasterTypeId
select objKnowledgeMasterTypeEN;
List <clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Sel = new List<clsKnowledgeMasterTypeEN>();
foreach (clsKnowledgeMasterTypeEN obj in arrKnowledgeMasterTypeObjLst_Sel1)
{
arrKnowledgeMasterTypeObjLst_Sel.Add(obj);
}
if (arrKnowledgeMasterTypeObjLst_Sel.Count > 0)
{
return arrKnowledgeMasterTypeObjLst_Sel[0].MasterTypeName;
}
string strErrMsgForGetObjById = string.Format("在KnowledgeMasterType对象缓存列表中,找不到记录[MasterTypeId = {0}](函数:{1})", strMasterTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsKnowledgeMasterTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMasterTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMasterTypeId_Cache(string strMasterTypeId)
{
if (string.IsNullOrEmpty(strMasterTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterTypeEN._CurrTabName_S);
List<clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Sel1 =
from objKnowledgeMasterTypeEN in arrKnowledgeMasterTypeObjLst_Cache
where objKnowledgeMasterTypeEN.MasterTypeId == strMasterTypeId
select objKnowledgeMasterTypeEN;
List <clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Sel = new List<clsKnowledgeMasterTypeEN>();
foreach (clsKnowledgeMasterTypeEN obj in arrKnowledgeMasterTypeObjLst_Sel1)
{
arrKnowledgeMasterTypeObjLst_Sel.Add(obj);
}
if (arrKnowledgeMasterTypeObjLst_Sel.Count > 0)
{
return arrKnowledgeMasterTypeObjLst_Sel[0].MasterTypeName;
}
string strErrMsgForGetObjById = string.Format("在KnowledgeMasterType对象缓存列表中,找不到记录的相关名称[MasterTypeId = {0}](函数:{1})", strMasterTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsKnowledgeMasterTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeMasterTypeEN> GetObjLst(string strWhereCond)
{
 List<clsKnowledgeMasterTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterTypeEN> GetObjLstByMasterTypeIdLst(List<string> arrMasterTypeId)
{
 List<clsKnowledgeMasterTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByMasterTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMasterTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strMasterTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsKnowledgeMasterTypeEN> GetObjLstByMasterTypeIdLst_Cache(List<string> arrMasterTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterTypeEN._CurrTabName_S);
List<clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Sel =
from objKnowledgeMasterTypeEN in arrKnowledgeMasterTypeObjLst_Cache
where arrMasterTypeId.Contains(objKnowledgeMasterTypeEN.MasterTypeId)
select objKnowledgeMasterTypeEN;
return arrKnowledgeMasterTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeMasterTypeEN> GetObjLstByMasterTypeIdLst_WA_Cache(List<string> arrMasterTypeId)
{
 List<clsKnowledgeMasterTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByMasterTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMasterTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsKnowledgeMasterTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsKnowledgeMasterTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsKnowledgeMasterTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsKnowledgeMasterTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strMasterTypeId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN = clsKnowledgeMasterTypeWApi.GetObjByMasterTypeId(strMasterTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strMasterTypeId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKnowledgeMasterTypeWApi.ReFreshCache();
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
public static int DelKnowledgeMasterTypes(List<string> arrMasterTypeId)
{
string strAction = "DelKnowledgeMasterTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMasterTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKnowledgeMasterTypeWApi.ReFreshCache();
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
public static int DelKnowledgeMasterTypesByCond(string strWhereCond)
{
string strAction = "DelKnowledgeMasterTypesByCond";
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
public static bool AddNewRecord(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterTypeEN>(objKnowledgeMasterTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterTypeEN>(objKnowledgeMasterTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterTypeWApi.ReFreshCache();
var strMasterTypeId = (string)jobjReturn["ReturnStr"];
return strMasterTypeId;
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
public static bool UpdateRecord(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN)
{
if (string.IsNullOrEmpty(objKnowledgeMasterTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeMasterTypeEN.MasterTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterTypeEN>(objKnowledgeMasterTypeEN);
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
 /// <param name = "objKnowledgeMasterTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objKnowledgeMasterTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeMasterTypeEN.MasterTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeMasterTypeEN.MasterTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterTypeEN>(objKnowledgeMasterTypeEN);
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
public static bool IsExist(string strMasterTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MasterTypeId"] = strMasterTypeId
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
 /// <param name = "objKnowledgeMasterTypeENS">源对象</param>
 /// <param name = "objKnowledgeMasterTypeENT">目标对象</param>
 public static void CopyTo(clsKnowledgeMasterTypeEN objKnowledgeMasterTypeENS, clsKnowledgeMasterTypeEN objKnowledgeMasterTypeENT)
{
try
{
objKnowledgeMasterTypeENT.MasterTypeId = objKnowledgeMasterTypeENS.MasterTypeId; //掌握类型Id
objKnowledgeMasterTypeENT.MasterTypeName = objKnowledgeMasterTypeENS.MasterTypeName; //掌握类型名
objKnowledgeMasterTypeENT.MasterTypeENName = objKnowledgeMasterTypeENS.MasterTypeENName; //掌握类型英文名
objKnowledgeMasterTypeENT.UpdDate = objKnowledgeMasterTypeENS.UpdDate; //修改日期
objKnowledgeMasterTypeENT.UpdUser = objKnowledgeMasterTypeENS.UpdUser; //修改人
objKnowledgeMasterTypeENT.Memo = objKnowledgeMasterTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsKnowledgeMasterTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsKnowledgeMasterTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsKnowledgeMasterTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsKnowledgeMasterTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsKnowledgeMasterTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsKnowledgeMasterTypeEN.AttributeName)
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
if (clsKnowledgeMasterTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeMasterTypeWApi没有刷新缓存机制(clsKnowledgeMasterTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MasterTypeId");
//if (arrKnowledgeMasterTypeObjLst_Cache == null)
//{
//arrKnowledgeMasterTypeObjLst_Cache = await clsKnowledgeMasterTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsKnowledgeMasterTypeEN._CurrTabName_S);
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
if (clsKnowledgeMasterTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsKnowledgeMasterTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsKnowledgeMasterTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeMasterTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsKnowledgeMasterTypeEN._CurrTabName_S);
List<clsKnowledgeMasterTypeEN> arrKnowledgeMasterTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrKnowledgeMasterTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsKnowledgeMasterTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conKnowledgeMasterType.MasterTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterType.MasterTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterType.MasterTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterType.Memo, Type.GetType("System.String"));
foreach (clsKnowledgeMasterTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conKnowledgeMasterType.MasterTypeId] = objInFor[conKnowledgeMasterType.MasterTypeId];
objDR[conKnowledgeMasterType.MasterTypeName] = objInFor[conKnowledgeMasterType.MasterTypeName];
objDR[conKnowledgeMasterType.MasterTypeENName] = objInFor[conKnowledgeMasterType.MasterTypeENName];
objDR[conKnowledgeMasterType.UpdDate] = objInFor[conKnowledgeMasterType.UpdDate];
objDR[conKnowledgeMasterType.UpdUser] = objInFor[conKnowledgeMasterType.UpdUser];
objDR[conKnowledgeMasterType.Memo] = objInFor[conKnowledgeMasterType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 知识点掌握类型(KnowledgeMasterType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4KnowledgeMasterType : clsCommFun4BL
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
clsKnowledgeMasterTypeWApi.ReFreshThisCache();
}
}

}