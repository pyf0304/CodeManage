
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeMasterLevelWApi
 表名:KnowledgeMasterLevel(01120891)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:37
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
public static class clsKnowledgeMasterLevelWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterLevelEN SetMasterLevelId(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, string strMasterLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMasterLevelId, 10, conKnowledgeMasterLevel.MasterLevelId);
clsCheckSql.CheckFieldForeignKey(strMasterLevelId, 10, conKnowledgeMasterLevel.MasterLevelId);
objKnowledgeMasterLevelEN.MasterLevelId = strMasterLevelId; //结构Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterLevelEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterLevel.MasterLevelId) == false)
{
objKnowledgeMasterLevelEN.dicFldComparisonOp.Add(conKnowledgeMasterLevel.MasterLevelId, strComparisonOp);
}
else
{
objKnowledgeMasterLevelEN.dicFldComparisonOp[conKnowledgeMasterLevel.MasterLevelId] = strComparisonOp;
}
}
return objKnowledgeMasterLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterLevelEN SetMasterLevelName(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, string strMasterLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMasterLevelName, conKnowledgeMasterLevel.MasterLevelName);
clsCheckSql.CheckFieldLen(strMasterLevelName, 50, conKnowledgeMasterLevel.MasterLevelName);
objKnowledgeMasterLevelEN.MasterLevelName = strMasterLevelName; //掌握等级
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterLevelEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterLevel.MasterLevelName) == false)
{
objKnowledgeMasterLevelEN.dicFldComparisonOp.Add(conKnowledgeMasterLevel.MasterLevelName, strComparisonOp);
}
else
{
objKnowledgeMasterLevelEN.dicFldComparisonOp[conKnowledgeMasterLevel.MasterLevelName] = strComparisonOp;
}
}
return objKnowledgeMasterLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterLevelEN SetLevelMinValue(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, int intLevelMinValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intLevelMinValue, conKnowledgeMasterLevel.LevelMinValue);
objKnowledgeMasterLevelEN.LevelMinValue = intLevelMinValue; //最小值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterLevelEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterLevel.LevelMinValue) == false)
{
objKnowledgeMasterLevelEN.dicFldComparisonOp.Add(conKnowledgeMasterLevel.LevelMinValue, strComparisonOp);
}
else
{
objKnowledgeMasterLevelEN.dicFldComparisonOp[conKnowledgeMasterLevel.LevelMinValue] = strComparisonOp;
}
}
return objKnowledgeMasterLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterLevelEN SetLevelMaxValue(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, int intLevelMaxValue, string strComparisonOp="")
	{
objKnowledgeMasterLevelEN.LevelMaxValue = intLevelMaxValue; //最大值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterLevelEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterLevel.LevelMaxValue) == false)
{
objKnowledgeMasterLevelEN.dicFldComparisonOp.Add(conKnowledgeMasterLevel.LevelMaxValue, strComparisonOp);
}
else
{
objKnowledgeMasterLevelEN.dicFldComparisonOp[conKnowledgeMasterLevel.LevelMaxValue] = strComparisonOp;
}
}
return objKnowledgeMasterLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterLevelEN SetUpdDate(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conKnowledgeMasterLevel.UpdDate);
objKnowledgeMasterLevelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterLevelEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterLevel.UpdDate) == false)
{
objKnowledgeMasterLevelEN.dicFldComparisonOp.Add(conKnowledgeMasterLevel.UpdDate, strComparisonOp);
}
else
{
objKnowledgeMasterLevelEN.dicFldComparisonOp[conKnowledgeMasterLevel.UpdDate] = strComparisonOp;
}
}
return objKnowledgeMasterLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterLevelEN SetUpdUser(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conKnowledgeMasterLevel.UpdUser);
objKnowledgeMasterLevelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterLevelEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterLevel.UpdUser) == false)
{
objKnowledgeMasterLevelEN.dicFldComparisonOp.Add(conKnowledgeMasterLevel.UpdUser, strComparisonOp);
}
else
{
objKnowledgeMasterLevelEN.dicFldComparisonOp[conKnowledgeMasterLevel.UpdUser] = strComparisonOp;
}
}
return objKnowledgeMasterLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsKnowledgeMasterLevelEN SetMemo(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conKnowledgeMasterLevel.Memo);
objKnowledgeMasterLevelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objKnowledgeMasterLevelEN.dicFldComparisonOp.ContainsKey(conKnowledgeMasterLevel.Memo) == false)
{
objKnowledgeMasterLevelEN.dicFldComparisonOp.Add(conKnowledgeMasterLevel.Memo, strComparisonOp);
}
else
{
objKnowledgeMasterLevelEN.dicFldComparisonOp[conKnowledgeMasterLevel.Memo] = strComparisonOp;
}
}
return objKnowledgeMasterLevelEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevel_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objKnowledgeMasterLevel_Cond.IsUpdated(conKnowledgeMasterLevel.MasterLevelId) == true)
{
string strComparisonOp_MasterLevelId = objKnowledgeMasterLevel_Cond.dicFldComparisonOp[conKnowledgeMasterLevel.MasterLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterLevel.MasterLevelId, objKnowledgeMasterLevel_Cond.MasterLevelId, strComparisonOp_MasterLevelId);
}
if (objKnowledgeMasterLevel_Cond.IsUpdated(conKnowledgeMasterLevel.MasterLevelName) == true)
{
string strComparisonOp_MasterLevelName = objKnowledgeMasterLevel_Cond.dicFldComparisonOp[conKnowledgeMasterLevel.MasterLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterLevel.MasterLevelName, objKnowledgeMasterLevel_Cond.MasterLevelName, strComparisonOp_MasterLevelName);
}
if (objKnowledgeMasterLevel_Cond.IsUpdated(conKnowledgeMasterLevel.LevelMinValue) == true)
{
string strComparisonOp_LevelMinValue = objKnowledgeMasterLevel_Cond.dicFldComparisonOp[conKnowledgeMasterLevel.LevelMinValue];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeMasterLevel.LevelMinValue, objKnowledgeMasterLevel_Cond.LevelMinValue, strComparisonOp_LevelMinValue);
}
if (objKnowledgeMasterLevel_Cond.IsUpdated(conKnowledgeMasterLevel.LevelMaxValue) == true)
{
string strComparisonOp_LevelMaxValue = objKnowledgeMasterLevel_Cond.dicFldComparisonOp[conKnowledgeMasterLevel.LevelMaxValue];
strWhereCond += string.Format(" And {0} {2} {1}", conKnowledgeMasterLevel.LevelMaxValue, objKnowledgeMasterLevel_Cond.LevelMaxValue, strComparisonOp_LevelMaxValue);
}
if (objKnowledgeMasterLevel_Cond.IsUpdated(conKnowledgeMasterLevel.UpdDate) == true)
{
string strComparisonOp_UpdDate = objKnowledgeMasterLevel_Cond.dicFldComparisonOp[conKnowledgeMasterLevel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterLevel.UpdDate, objKnowledgeMasterLevel_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objKnowledgeMasterLevel_Cond.IsUpdated(conKnowledgeMasterLevel.UpdUser) == true)
{
string strComparisonOp_UpdUser = objKnowledgeMasterLevel_Cond.dicFldComparisonOp[conKnowledgeMasterLevel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterLevel.UpdUser, objKnowledgeMasterLevel_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objKnowledgeMasterLevel_Cond.IsUpdated(conKnowledgeMasterLevel.Memo) == true)
{
string strComparisonOp_Memo = objKnowledgeMasterLevel_Cond.dicFldComparisonOp[conKnowledgeMasterLevel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conKnowledgeMasterLevel.Memo, objKnowledgeMasterLevel_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
 if (string.IsNullOrEmpty(objKnowledgeMasterLevelEN.MasterLevelId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objKnowledgeMasterLevelEN.sf_UpdFldSetStr = objKnowledgeMasterLevelEN.getsf_UpdFldSetStr();
clsKnowledgeMasterLevelWApi.CheckPropertyNew(objKnowledgeMasterLevelEN); 
bool bolResult = clsKnowledgeMasterLevelWApi.UpdateRecord(objKnowledgeMasterLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterLevelWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--KnowledgeMasterLevel(知识点掌握度), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_MasterLevelName(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objKnowledgeMasterLevelEN == null) return "";
if (objKnowledgeMasterLevelEN.MasterLevelId == null || objKnowledgeMasterLevelEN.MasterLevelId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MasterLevelName = '{0}'", objKnowledgeMasterLevelEN.MasterLevelName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MasterLevelId !=  '{0}'", objKnowledgeMasterLevelEN.MasterLevelId);
 sbCondition.AppendFormat(" and MasterLevelName = '{0}'", objKnowledgeMasterLevelEN.MasterLevelName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objKnowledgeMasterLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
try
{
 if (string.IsNullOrEmpty(objKnowledgeMasterLevelEN.MasterLevelId) == true || clsKnowledgeMasterLevelWApi.IsExist(objKnowledgeMasterLevelEN.MasterLevelId) == true)
 {
     objKnowledgeMasterLevelEN.MasterLevelId = clsKnowledgeMasterLevelWApi.GetMaxStrId();
 }
clsKnowledgeMasterLevelWApi.CheckPropertyNew(objKnowledgeMasterLevelEN); 
bool bolResult = clsKnowledgeMasterLevelWApi.AddNewRecord(objKnowledgeMasterLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterLevelWApi.ReFreshCache();
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
 /// <param name = "objKnowledgeMasterLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
try
{
clsKnowledgeMasterLevelWApi.CheckPropertyNew(objKnowledgeMasterLevelEN); 
string strMasterLevelId = clsKnowledgeMasterLevelWApi.AddNewRecordWithMaxId(objKnowledgeMasterLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterLevelWApi.ReFreshCache();
return strMasterLevelId;
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
 /// <param name = "objKnowledgeMasterLevelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, string strWhereCond)
{
try
{
clsKnowledgeMasterLevelWApi.CheckPropertyNew(objKnowledgeMasterLevelEN); 
bool bolResult = clsKnowledgeMasterLevelWApi.UpdateWithCondition(objKnowledgeMasterLevelEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterLevelWApi.ReFreshCache();
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
 /// 知识点掌握度(KnowledgeMasterLevel)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsKnowledgeMasterLevelWApi
{
private static readonly string mstrApiControllerName = "KnowledgeMasterLevelApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsKnowledgeMasterLevelWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MasterLevelId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点掌握度]...","0");
List<clsKnowledgeMasterLevelEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MasterLevelId";
objDDL.DataTextField="MasterLevelName";
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
public static void BindCbo_MasterLevelId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conKnowledgeMasterLevel.MasterLevelId); 
List<clsKnowledgeMasterLevelEN> arrObjLst = clsKnowledgeMasterLevelWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN = new clsKnowledgeMasterLevelEN()
{
MasterLevelId = "0",
MasterLevelName = "选[知识点掌握度]..."
};
arrObjLst.Insert(0, objKnowledgeMasterLevelEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conKnowledgeMasterLevel.MasterLevelId;
objComboBox.DisplayMember = conKnowledgeMasterLevel.MasterLevelName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
if (!Object.Equals(null, objKnowledgeMasterLevelEN.MasterLevelId) && GetStrLen(objKnowledgeMasterLevelEN.MasterLevelId) > 10)
{
 throw new Exception("字段[结构Id]的长度不能超过10!");
}
if (!Object.Equals(null, objKnowledgeMasterLevelEN.MasterLevelName) && GetStrLen(objKnowledgeMasterLevelEN.MasterLevelName) > 50)
{
 throw new Exception("字段[掌握等级]的长度不能超过50!");
}
if (!Object.Equals(null, objKnowledgeMasterLevelEN.UpdDate) && GetStrLen(objKnowledgeMasterLevelEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeMasterLevelEN.UpdUser) && GetStrLen(objKnowledgeMasterLevelEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objKnowledgeMasterLevelEN.Memo) && GetStrLen(objKnowledgeMasterLevelEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objKnowledgeMasterLevelEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMasterLevelId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeMasterLevelEN GetObjByMasterLevelId(string strMasterLevelId)
{
string strAction = "GetObjByMasterLevelId";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MasterLevelId"] = strMasterLevelId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objKnowledgeMasterLevelEN = JsonConvert.DeserializeObject<clsKnowledgeMasterLevelEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeMasterLevelEN;
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
 /// <param name = "strMasterLevelId">表关键字</param>
 /// <returns>表对象</returns>
public static clsKnowledgeMasterLevelEN GetObjByMasterLevelId_WA_Cache(string strMasterLevelId)
{
string strAction = "GetObjByMasterLevelId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MasterLevelId"] = strMasterLevelId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objKnowledgeMasterLevelEN = JsonConvert.DeserializeObject<clsKnowledgeMasterLevelEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeMasterLevelEN;
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
public static clsKnowledgeMasterLevelEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN = null;
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
objKnowledgeMasterLevelEN = JsonConvert.DeserializeObject<clsKnowledgeMasterLevelEN>((string)jobjReturn["ReturnObj"]);
return objKnowledgeMasterLevelEN;
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
 /// <param name = "strMasterLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsKnowledgeMasterLevelEN GetObjByMasterLevelId_Cache(string strMasterLevelId)
{
if (string.IsNullOrEmpty(strMasterLevelId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterLevelEN._CurrTabName_S);
List<clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Sel =
from objKnowledgeMasterLevelEN in arrKnowledgeMasterLevelObjLst_Cache
where objKnowledgeMasterLevelEN.MasterLevelId == strMasterLevelId
select objKnowledgeMasterLevelEN;
if (arrKnowledgeMasterLevelObjLst_Sel.Count() == 0)
{
   clsKnowledgeMasterLevelEN obj = clsKnowledgeMasterLevelWApi.GetObjByMasterLevelId(strMasterLevelId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrKnowledgeMasterLevelObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMasterLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMasterLevelNameByMasterLevelId_Cache(string strMasterLevelId)
{
if (string.IsNullOrEmpty(strMasterLevelId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterLevelEN._CurrTabName_S);
List<clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Sel1 =
from objKnowledgeMasterLevelEN in arrKnowledgeMasterLevelObjLst_Cache
where objKnowledgeMasterLevelEN.MasterLevelId == strMasterLevelId
select objKnowledgeMasterLevelEN;
List <clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Sel = new List<clsKnowledgeMasterLevelEN>();
foreach (clsKnowledgeMasterLevelEN obj in arrKnowledgeMasterLevelObjLst_Sel1)
{
arrKnowledgeMasterLevelObjLst_Sel.Add(obj);
}
if (arrKnowledgeMasterLevelObjLst_Sel.Count > 0)
{
return arrKnowledgeMasterLevelObjLst_Sel[0].MasterLevelName;
}
string strErrMsgForGetObjById = string.Format("在KnowledgeMasterLevel对象缓存列表中,找不到记录[MasterLevelId = {0}](函数:{1})", strMasterLevelId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsKnowledgeMasterLevelBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMasterLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMasterLevelId_Cache(string strMasterLevelId)
{
if (string.IsNullOrEmpty(strMasterLevelId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterLevelEN._CurrTabName_S);
List<clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Sel1 =
from objKnowledgeMasterLevelEN in arrKnowledgeMasterLevelObjLst_Cache
where objKnowledgeMasterLevelEN.MasterLevelId == strMasterLevelId
select objKnowledgeMasterLevelEN;
List <clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Sel = new List<clsKnowledgeMasterLevelEN>();
foreach (clsKnowledgeMasterLevelEN obj in arrKnowledgeMasterLevelObjLst_Sel1)
{
arrKnowledgeMasterLevelObjLst_Sel.Add(obj);
}
if (arrKnowledgeMasterLevelObjLst_Sel.Count > 0)
{
return arrKnowledgeMasterLevelObjLst_Sel[0].MasterLevelName;
}
string strErrMsgForGetObjById = string.Format("在KnowledgeMasterLevel对象缓存列表中,找不到记录的相关名称[MasterLevelId = {0}](函数:{1})", strMasterLevelId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsKnowledgeMasterLevelBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeMasterLevelEN> GetObjLst(string strWhereCond)
{
 List<clsKnowledgeMasterLevelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterLevelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterLevelEN> GetObjLstByMasterLevelIdLst(List<string> arrMasterLevelId)
{
 List<clsKnowledgeMasterLevelEN> arrObjLst = null; 
string strAction = "GetObjLstByMasterLevelIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMasterLevelId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterLevelEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strMasterLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsKnowledgeMasterLevelEN> GetObjLstByMasterLevelIdLst_Cache(List<string> arrMasterLevelId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsKnowledgeMasterLevelEN._CurrTabName_S);
List<clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Sel =
from objKnowledgeMasterLevelEN in arrKnowledgeMasterLevelObjLst_Cache
where arrMasterLevelId.Contains(objKnowledgeMasterLevelEN.MasterLevelId)
select objKnowledgeMasterLevelEN;
return arrKnowledgeMasterLevelObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsKnowledgeMasterLevelEN> GetObjLstByMasterLevelIdLst_WA_Cache(List<string> arrMasterLevelId)
{
 List<clsKnowledgeMasterLevelEN> arrObjLst = null; 
string strAction = "GetObjLstByMasterLevelIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMasterLevelId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterLevelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterLevelEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsKnowledgeMasterLevelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterLevelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterLevelEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsKnowledgeMasterLevelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterLevelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterLevelEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsKnowledgeMasterLevelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterLevelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsKnowledgeMasterLevelEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsKnowledgeMasterLevelEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsKnowledgeMasterLevelEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strMasterLevelId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN = clsKnowledgeMasterLevelWApi.GetObjByMasterLevelId(strMasterLevelId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strMasterLevelId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKnowledgeMasterLevelWApi.ReFreshCache();
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
public static int DelKnowledgeMasterLevels(List<string> arrMasterLevelId)
{
string strAction = "DelKnowledgeMasterLevels";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMasterLevelId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsKnowledgeMasterLevelWApi.ReFreshCache();
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
public static int DelKnowledgeMasterLevelsByCond(string strWhereCond)
{
string strAction = "DelKnowledgeMasterLevelsByCond";
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
public static bool AddNewRecord(clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterLevelEN>(objKnowledgeMasterLevelEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterLevelWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterLevelEN>(objKnowledgeMasterLevelEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsKnowledgeMasterLevelWApi.ReFreshCache();
var strMasterLevelId = (string)jobjReturn["ReturnStr"];
return strMasterLevelId;
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
public static bool UpdateRecord(clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN)
{
if (string.IsNullOrEmpty(objKnowledgeMasterLevelEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeMasterLevelEN.MasterLevelId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterLevelEN>(objKnowledgeMasterLevelEN);
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
 /// <param name = "objKnowledgeMasterLevelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsKnowledgeMasterLevelEN objKnowledgeMasterLevelEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objKnowledgeMasterLevelEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeMasterLevelEN.MasterLevelId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objKnowledgeMasterLevelEN.MasterLevelId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsKnowledgeMasterLevelEN>(objKnowledgeMasterLevelEN);
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
public static bool IsExist(string strMasterLevelId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MasterLevelId"] = strMasterLevelId
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
 /// <param name = "objKnowledgeMasterLevelENS">源对象</param>
 /// <param name = "objKnowledgeMasterLevelENT">目标对象</param>
 public static void CopyTo(clsKnowledgeMasterLevelEN objKnowledgeMasterLevelENS, clsKnowledgeMasterLevelEN objKnowledgeMasterLevelENT)
{
try
{
objKnowledgeMasterLevelENT.MasterLevelId = objKnowledgeMasterLevelENS.MasterLevelId; //结构Id
objKnowledgeMasterLevelENT.MasterLevelName = objKnowledgeMasterLevelENS.MasterLevelName; //掌握等级
objKnowledgeMasterLevelENT.LevelMinValue = objKnowledgeMasterLevelENS.LevelMinValue; //最小值
objKnowledgeMasterLevelENT.LevelMaxValue = objKnowledgeMasterLevelENS.LevelMaxValue; //最大值
objKnowledgeMasterLevelENT.UpdDate = objKnowledgeMasterLevelENS.UpdDate; //修改日期
objKnowledgeMasterLevelENT.UpdUser = objKnowledgeMasterLevelENS.UpdUser; //修改人
objKnowledgeMasterLevelENT.Memo = objKnowledgeMasterLevelENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsKnowledgeMasterLevelEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsKnowledgeMasterLevelEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsKnowledgeMasterLevelEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsKnowledgeMasterLevelEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsKnowledgeMasterLevelEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsKnowledgeMasterLevelEN.AttributeName)
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
if (clsKnowledgeMasterLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsKnowledgeMasterLevelWApi没有刷新缓存机制(clsKnowledgeMasterLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MasterLevelId");
//if (arrKnowledgeMasterLevelObjLst_Cache == null)
//{
//arrKnowledgeMasterLevelObjLst_Cache = await clsKnowledgeMasterLevelWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsKnowledgeMasterLevelEN._CurrTabName_S);
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
if (clsKnowledgeMasterLevelWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsKnowledgeMasterLevelEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsKnowledgeMasterLevelWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsKnowledgeMasterLevelEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsKnowledgeMasterLevelEN._CurrTabName_S);
List<clsKnowledgeMasterLevelEN> arrKnowledgeMasterLevelObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrKnowledgeMasterLevelObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsKnowledgeMasterLevelEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conKnowledgeMasterLevel.MasterLevelId, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterLevel.MasterLevelName, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterLevel.LevelMinValue, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeMasterLevel.LevelMaxValue, Type.GetType("System.Int32"));
objDT.Columns.Add(conKnowledgeMasterLevel.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterLevel.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conKnowledgeMasterLevel.Memo, Type.GetType("System.String"));
foreach (clsKnowledgeMasterLevelEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conKnowledgeMasterLevel.MasterLevelId] = objInFor[conKnowledgeMasterLevel.MasterLevelId];
objDR[conKnowledgeMasterLevel.MasterLevelName] = objInFor[conKnowledgeMasterLevel.MasterLevelName];
objDR[conKnowledgeMasterLevel.LevelMinValue] = objInFor[conKnowledgeMasterLevel.LevelMinValue];
objDR[conKnowledgeMasterLevel.LevelMaxValue] = objInFor[conKnowledgeMasterLevel.LevelMaxValue];
objDR[conKnowledgeMasterLevel.UpdDate] = objInFor[conKnowledgeMasterLevel.UpdDate];
objDR[conKnowledgeMasterLevel.UpdUser] = objInFor[conKnowledgeMasterLevel.UpdUser];
objDR[conKnowledgeMasterLevel.Memo] = objInFor[conKnowledgeMasterLevel.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 知识点掌握度(KnowledgeMasterLevel)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4KnowledgeMasterLevel : clsCommFun4BL
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
clsKnowledgeMasterLevelWApi.ReFreshThisCache();
}
}

}