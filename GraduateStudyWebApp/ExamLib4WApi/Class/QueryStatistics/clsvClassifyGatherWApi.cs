
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassifyGatherWApi
 表名:vClassifyGather(01120015)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:53
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计
 模块英文名:QueryStatistics
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
public static class clsvClassifyGatherWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetClassifyGatherId(this clsvClassifyGatherEN objvClassifyGatherEN, string strClassifyGatherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClassifyGatherId, 4, convClassifyGather.ClassifyGatherId);
clsCheckSql.CheckFieldForeignKey(strClassifyGatherId, 4, convClassifyGather.ClassifyGatherId);
objvClassifyGatherEN.ClassifyGatherId = strClassifyGatherId; //分类统计Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.ClassifyGatherId) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.ClassifyGatherId, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.ClassifyGatherId] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetClassifyGatherName(this clsvClassifyGatherEN objvClassifyGatherEN, string strClassifyGatherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherName, convClassifyGather.ClassifyGatherName);
clsCheckSql.CheckFieldLen(strClassifyGatherName, 30, convClassifyGather.ClassifyGatherName);
objvClassifyGatherEN.ClassifyGatherName = strClassifyGatherName; //分类统计名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.ClassifyGatherName) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.ClassifyGatherName, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.ClassifyGatherName] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetQuestionnaireSetId(this clsvClassifyGatherEN objvClassifyGatherEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convClassifyGather.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convClassifyGather.QuestionnaireSetId);
objvClassifyGatherEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.QuestionnaireSetId) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.QuestionnaireSetId, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.QuestionnaireSetId] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetIsDefault(this clsvClassifyGatherEN objvClassifyGatherEN, bool bolIsDefault, string strComparisonOp="")
	{
objvClassifyGatherEN.IsDefault = bolIsDefault; //是否默认
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.IsDefault) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.IsDefault, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.IsDefault] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetQuestionnaireSetName(this clsvClassifyGatherEN objvClassifyGatherEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convClassifyGather.QuestionnaireSetName);
objvClassifyGatherEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.QuestionnaireSetName) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.QuestionnaireSetName, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.QuestionnaireSetName] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetUpdDate(this clsvClassifyGatherEN objvClassifyGatherEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convClassifyGather.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convClassifyGather.UpdDate);
objvClassifyGatherEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.UpdDate) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.UpdDate, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.UpdDate] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetUpdUser(this clsvClassifyGatherEN objvClassifyGatherEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convClassifyGather.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convClassifyGather.UpdUser);
objvClassifyGatherEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.UpdUser) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.UpdUser, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.UpdUser] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetMemo(this clsvClassifyGatherEN objvClassifyGatherEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convClassifyGather.Memo);
objvClassifyGatherEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.Memo) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.Memo, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.Memo] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvClassifyGatherEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvClassifyGatherEN SetClassifyGatherPeriod(this clsvClassifyGatherEN objvClassifyGatherEN, string strClassifyGatherPeriod, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherPeriod, convClassifyGather.ClassifyGatherPeriod);
clsCheckSql.CheckFieldLen(strClassifyGatherPeriod, 50, convClassifyGather.ClassifyGatherPeriod);
objvClassifyGatherEN.ClassifyGatherPeriod = strClassifyGatherPeriod; //分类统计时期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvClassifyGatherEN.dicFldComparisonOp.ContainsKey(convClassifyGather.ClassifyGatherPeriod) == false)
{
objvClassifyGatherEN.dicFldComparisonOp.Add(convClassifyGather.ClassifyGatherPeriod, strComparisonOp);
}
else
{
objvClassifyGatherEN.dicFldComparisonOp[convClassifyGather.ClassifyGatherPeriod] = strComparisonOp;
}
}
return objvClassifyGatherEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvClassifyGatherEN objvClassifyGather_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.ClassifyGatherId) == true)
{
string strComparisonOp_ClassifyGatherId = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.ClassifyGatherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.ClassifyGatherId, objvClassifyGather_Cond.ClassifyGatherId, strComparisonOp_ClassifyGatherId);
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.ClassifyGatherName) == true)
{
string strComparisonOp_ClassifyGatherName = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.ClassifyGatherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.ClassifyGatherName, objvClassifyGather_Cond.ClassifyGatherName, strComparisonOp_ClassifyGatherName);
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.QuestionnaireSetId, objvClassifyGather_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.IsDefault) == true)
{
if (objvClassifyGather_Cond.IsDefault == true)
{
strWhereCond += string.Format(" And {0} = '1'", convClassifyGather.IsDefault);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convClassifyGather.IsDefault);
}
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.QuestionnaireSetName) == true)
{
string strComparisonOp_QuestionnaireSetName = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.QuestionnaireSetName, objvClassifyGather_Cond.QuestionnaireSetName, strComparisonOp_QuestionnaireSetName);
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.UpdDate, objvClassifyGather_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.UpdUser, objvClassifyGather_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.Memo) == true)
{
string strComparisonOp_Memo = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.Memo, objvClassifyGather_Cond.Memo, strComparisonOp_Memo);
}
if (objvClassifyGather_Cond.IsUpdated(convClassifyGather.ClassifyGatherPeriod) == true)
{
string strComparisonOp_ClassifyGatherPeriod = objvClassifyGather_Cond.dicFldComparisonOp[convClassifyGather.ClassifyGatherPeriod];
strWhereCond += string.Format(" And {0} {2} '{1}'", convClassifyGather.ClassifyGatherPeriod, objvClassifyGather_Cond.ClassifyGatherPeriod, strComparisonOp_ClassifyGatherPeriod);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v分类汇总(vClassifyGather)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvClassifyGatherWApi
{
private static readonly string mstrApiControllerName = "vClassifyGatherApi";

 public clsvClassifyGatherWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ClassifyGatherId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v分类汇总]...","0");
List<clsvClassifyGatherEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="ClassifyGatherId";
objDDL.DataTextField="ClassifyGatherName";
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
public static void BindCbo_ClassifyGatherId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convClassifyGather.ClassifyGatherId); 
List<clsvClassifyGatherEN> arrObjLst = clsvClassifyGatherWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvClassifyGatherEN objvClassifyGatherEN = new clsvClassifyGatherEN()
{
ClassifyGatherId = "0",
ClassifyGatherName = "选[v分类汇总]..."
};
arrObjLst.Insert(0, objvClassifyGatherEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convClassifyGather.ClassifyGatherId;
objComboBox.DisplayMember = convClassifyGather.ClassifyGatherName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strClassifyGatherId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassifyGatherEN GetObjByClassifyGatherId(string strClassifyGatherId)
{
string strAction = "GetObjByClassifyGatherId";
string strErrMsg = string.Empty;
string strResult = "";
clsvClassifyGatherEN objvClassifyGatherEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClassifyGatherId"] = strClassifyGatherId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvClassifyGatherEN = JsonConvert.DeserializeObject<clsvClassifyGatherEN>((string)jobjReturn["ReturnObj"]);
return objvClassifyGatherEN;
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
 /// <param name = "strClassifyGatherId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvClassifyGatherEN GetObjByClassifyGatherId_WA_Cache(string strClassifyGatherId)
{
string strAction = "GetObjByClassifyGatherId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvClassifyGatherEN objvClassifyGatherEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClassifyGatherId"] = strClassifyGatherId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvClassifyGatherEN = JsonConvert.DeserializeObject<clsvClassifyGatherEN>((string)jobjReturn["ReturnObj"]);
return objvClassifyGatherEN;
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
public static clsvClassifyGatherEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvClassifyGatherEN objvClassifyGatherEN = null;
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
objvClassifyGatherEN = JsonConvert.DeserializeObject<clsvClassifyGatherEN>((string)jobjReturn["ReturnObj"]);
return objvClassifyGatherEN;
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
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvClassifyGatherEN GetObjByClassifyGatherId_Cache(string strClassifyGatherId)
{
if (string.IsNullOrEmpty(strClassifyGatherId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvClassifyGatherEN._CurrTabName_S);
List<clsvClassifyGatherEN> arrvClassifyGatherObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassifyGatherEN> arrvClassifyGatherObjLst_Sel =
from objvClassifyGatherEN in arrvClassifyGatherObjLst_Cache
where objvClassifyGatherEN.ClassifyGatherId == strClassifyGatherId
select objvClassifyGatherEN;
if (arrvClassifyGatherObjLst_Sel.Count() == 0)
{
   clsvClassifyGatherEN obj = clsvClassifyGatherWApi.GetObjByClassifyGatherId(strClassifyGatherId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvClassifyGatherObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetClassifyGatherNameByClassifyGatherId_Cache(string strClassifyGatherId)
{
if (string.IsNullOrEmpty(strClassifyGatherId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvClassifyGatherEN._CurrTabName_S);
List<clsvClassifyGatherEN> arrvClassifyGatherObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassifyGatherEN> arrvClassifyGatherObjLst_Sel1 =
from objvClassifyGatherEN in arrvClassifyGatherObjLst_Cache
where objvClassifyGatherEN.ClassifyGatherId == strClassifyGatherId
select objvClassifyGatherEN;
List <clsvClassifyGatherEN> arrvClassifyGatherObjLst_Sel = new List<clsvClassifyGatherEN>();
foreach (clsvClassifyGatherEN obj in arrvClassifyGatherObjLst_Sel1)
{
arrvClassifyGatherObjLst_Sel.Add(obj);
}
if (arrvClassifyGatherObjLst_Sel.Count > 0)
{
return arrvClassifyGatherObjLst_Sel[0].ClassifyGatherName;
}
string strErrMsgForGetObjById = string.Format("在vClassifyGather对象缓存列表中,找不到记录[ClassifyGatherId = {0}](函数:{1})", strClassifyGatherId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvClassifyGatherBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByClassifyGatherId_Cache(string strClassifyGatherId)
{
if (string.IsNullOrEmpty(strClassifyGatherId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvClassifyGatherEN._CurrTabName_S);
List<clsvClassifyGatherEN> arrvClassifyGatherObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassifyGatherEN> arrvClassifyGatherObjLst_Sel1 =
from objvClassifyGatherEN in arrvClassifyGatherObjLst_Cache
where objvClassifyGatherEN.ClassifyGatherId == strClassifyGatherId
select objvClassifyGatherEN;
List <clsvClassifyGatherEN> arrvClassifyGatherObjLst_Sel = new List<clsvClassifyGatherEN>();
foreach (clsvClassifyGatherEN obj in arrvClassifyGatherObjLst_Sel1)
{
arrvClassifyGatherObjLst_Sel.Add(obj);
}
if (arrvClassifyGatherObjLst_Sel.Count > 0)
{
return arrvClassifyGatherObjLst_Sel[0].ClassifyGatherName;
}
string strErrMsgForGetObjById = string.Format("在vClassifyGather对象缓存列表中,找不到记录的相关名称[ClassifyGatherId = {0}](函数:{1})", strClassifyGatherId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvClassifyGatherBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassifyGatherEN> GetObjLst(string strWhereCond)
{
 List<clsvClassifyGatherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherEN> GetObjLstByClassifyGatherIdLst(List<string> arrClassifyGatherId)
{
 List<clsvClassifyGatherEN> arrObjLst = null; 
string strAction = "GetObjLstByClassifyGatherIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrClassifyGatherId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strClassifyGatherId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvClassifyGatherEN> GetObjLstByClassifyGatherIdLst_Cache(List<string> arrClassifyGatherId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvClassifyGatherEN._CurrTabName_S);
List<clsvClassifyGatherEN> arrvClassifyGatherObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvClassifyGatherEN> arrvClassifyGatherObjLst_Sel =
from objvClassifyGatherEN in arrvClassifyGatherObjLst_Cache
where arrClassifyGatherId.Contains(objvClassifyGatherEN.ClassifyGatherId)
select objvClassifyGatherEN;
return arrvClassifyGatherObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvClassifyGatherEN> GetObjLstByClassifyGatherIdLst_WA_Cache(List<string> arrClassifyGatherId)
{
 List<clsvClassifyGatherEN> arrObjLst = null; 
string strAction = "GetObjLstByClassifyGatherIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrClassifyGatherId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvClassifyGatherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvClassifyGatherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvClassifyGatherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvClassifyGatherEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvClassifyGatherEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvClassifyGatherEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strClassifyGatherId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClassifyGatherId"] = strClassifyGatherId
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
 /// <param name = "objvClassifyGatherENS">源对象</param>
 /// <param name = "objvClassifyGatherENT">目标对象</param>
 public static void CopyTo(clsvClassifyGatherEN objvClassifyGatherENS, clsvClassifyGatherEN objvClassifyGatherENT)
{
try
{
objvClassifyGatherENT.ClassifyGatherId = objvClassifyGatherENS.ClassifyGatherId; //分类统计Id
objvClassifyGatherENT.ClassifyGatherName = objvClassifyGatherENS.ClassifyGatherName; //分类统计名称
objvClassifyGatherENT.QuestionnaireSetId = objvClassifyGatherENS.QuestionnaireSetId; //问卷集ID
objvClassifyGatherENT.IsDefault = objvClassifyGatherENS.IsDefault; //是否默认
objvClassifyGatherENT.QuestionnaireSetName = objvClassifyGatherENS.QuestionnaireSetName; //问卷集名
objvClassifyGatherENT.UpdDate = objvClassifyGatherENS.UpdDate; //修改日期
objvClassifyGatherENT.UpdUser = objvClassifyGatherENS.UpdUser; //修改人
objvClassifyGatherENT.Memo = objvClassifyGatherENS.Memo; //备注
objvClassifyGatherENT.ClassifyGatherPeriod = objvClassifyGatherENS.ClassifyGatherPeriod; //分类统计时期
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
public static DataTable ToDataTable(List<clsvClassifyGatherEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvClassifyGatherEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvClassifyGatherEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvClassifyGatherEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvClassifyGatherEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvClassifyGatherEN.AttributeName)
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
if (clsQuestionnaireSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetWApi没有刷新缓存机制(clsQuestionnaireSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsClassifyGatherWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyGatherWApi没有刷新缓存机制(clsClassifyGatherWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClassifyGatherId");
//if (arrvClassifyGatherObjLst_Cache == null)
//{
//arrvClassifyGatherObjLst_Cache = await clsvClassifyGatherWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvClassifyGatherEN._CurrTabName_S);
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
public static List<clsvClassifyGatherEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvClassifyGatherEN._CurrTabName_S);
List<clsvClassifyGatherEN> arrvClassifyGatherObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvClassifyGatherObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvClassifyGatherEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convClassifyGather.ClassifyGatherId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGather.ClassifyGatherName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGather.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGather.IsDefault, Type.GetType("System.Boolean"));
objDT.Columns.Add(convClassifyGather.QuestionnaireSetName, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGather.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGather.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGather.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convClassifyGather.ClassifyGatherPeriod, Type.GetType("System.String"));
foreach (clsvClassifyGatherEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convClassifyGather.ClassifyGatherId] = objInFor[convClassifyGather.ClassifyGatherId];
objDR[convClassifyGather.ClassifyGatherName] = objInFor[convClassifyGather.ClassifyGatherName];
objDR[convClassifyGather.QuestionnaireSetId] = objInFor[convClassifyGather.QuestionnaireSetId];
objDR[convClassifyGather.IsDefault] = objInFor[convClassifyGather.IsDefault];
objDR[convClassifyGather.QuestionnaireSetName] = objInFor[convClassifyGather.QuestionnaireSetName];
objDR[convClassifyGather.UpdDate] = objInFor[convClassifyGather.UpdDate];
objDR[convClassifyGather.UpdUser] = objInFor[convClassifyGather.UpdUser];
objDR[convClassifyGather.Memo] = objInFor[convClassifyGather.Memo];
objDR[convClassifyGather.ClassifyGatherPeriod] = objInFor[convClassifyGather.ClassifyGatherPeriod];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}