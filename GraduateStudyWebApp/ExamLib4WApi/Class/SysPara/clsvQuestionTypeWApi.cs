
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionTypeWApi
 表名:vQuestionType(01120114)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:49
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
public static class clsvQuestionTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetQuestionTypeId(this clsvQuestionTypeEN objvQuestionTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionType.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionType.QuestionTypeId);
objvQuestionTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.QuestionTypeId) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetQuestionTypeName(this clsvQuestionTypeEN objvQuestionTypeEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionType.QuestionTypeName);
objvQuestionTypeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.QuestionTypeName) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetDefaAnswerModeId(this clsvQuestionTypeEN objvQuestionTypeEN, string strDefaAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaAnswerModeId, 4, convQuestionType.DefaAnswerModeId);
clsCheckSql.CheckFieldForeignKey(strDefaAnswerModeId, 4, convQuestionType.DefaAnswerModeId);
objvQuestionTypeEN.DefaAnswerModeId = strDefaAnswerModeId; //默认答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.DefaAnswerModeId) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.DefaAnswerModeId, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.DefaAnswerModeId] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetAnswerModeName(this clsvQuestionTypeEN objvQuestionTypeEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convQuestionType.AnswerModeName);
objvQuestionTypeEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.AnswerModeName) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.AnswerModeName, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.AnswerModeName] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetDefaAnswerTypeId(this clsvQuestionTypeEN objvQuestionTypeEN, string strDefaAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaAnswerTypeId, 2, convQuestionType.DefaAnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strDefaAnswerTypeId, 2, convQuestionType.DefaAnswerTypeId);
objvQuestionTypeEN.DefaAnswerTypeId = strDefaAnswerTypeId; //默认答案类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.DefaAnswerTypeId) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.DefaAnswerTypeId, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.DefaAnswerTypeId] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetAnswerTypeName(this clsvQuestionTypeEN objvQuestionTypeEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convQuestionType.AnswerTypeName);
objvQuestionTypeEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.AnswerTypeName) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.AnswerTypeName, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.AnswerTypeName] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetOrderNum(this clsvQuestionTypeEN objvQuestionTypeEN, int intOrderNum, string strComparisonOp="")
	{
objvQuestionTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.OrderNum) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.OrderNum, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.OrderNum] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetIsUse(this clsvQuestionTypeEN objvQuestionTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objvQuestionTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.IsUse) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.IsUse, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.IsUse] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetUpdDate(this clsvQuestionTypeEN objvQuestionTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionType.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionType.UpdDate);
objvQuestionTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.UpdDate) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.UpdDate, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.UpdDate] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetUpdUser(this clsvQuestionTypeEN objvQuestionTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionType.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionType.UpdUser);
objvQuestionTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.UpdUser) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.UpdUser, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.UpdUser] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionTypeEN SetMemo(this clsvQuestionTypeEN objvQuestionTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionType.Memo);
objvQuestionTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.Memo) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.Memo, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.Memo] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionTypeEN objvQuestionType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionType_Cond.IsUpdated(convQuestionType.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.QuestionTypeId, objvQuestionType_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.QuestionTypeName, objvQuestionType_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.DefaAnswerModeId) == true)
{
string strComparisonOp_DefaAnswerModeId = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.DefaAnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.DefaAnswerModeId, objvQuestionType_Cond.DefaAnswerModeId, strComparisonOp_DefaAnswerModeId);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.AnswerModeName, objvQuestionType_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.DefaAnswerTypeId) == true)
{
string strComparisonOp_DefaAnswerTypeId = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.DefaAnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.DefaAnswerTypeId, objvQuestionType_Cond.DefaAnswerTypeId, strComparisonOp_DefaAnswerTypeId);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.AnswerTypeName, objvQuestionType_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionType.OrderNum, objvQuestionType_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.IsUse) == true)
{
if (objvQuestionType_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionType.IsUse);
}
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.UpdDate, objvQuestionType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.UpdUser, objvQuestionType_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQuestionType_Cond.IsUpdated(convQuestionType.Memo) == true)
{
string strComparisonOp_Memo = objvQuestionType_Cond.dicFldComparisonOp[convQuestionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.Memo, objvQuestionType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目类型(vQuestionType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionTypeWApi
{
private static readonly string mstrApiControllerName = "vQuestionTypeApi";

 public clsvQuestionTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目类型]...","0");
List<clsvQuestionTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionTypeId";
objDDL.DataTextField="QuestionTypeName";
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
public static void BindCbo_QuestionTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionType.QuestionTypeId); 
List<clsvQuestionTypeEN> arrObjLst = clsvQuestionTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN()
{
QuestionTypeId = "0",
QuestionTypeName = "选[v题目类型]..."
};
arrObjLst.Insert(0, objvQuestionTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionType.QuestionTypeId;
objComboBox.DisplayMember = convQuestionType.QuestionTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionTypeEN GetObjByQuestionTypeId(string strQuestionTypeId)
{
string strAction = "GetObjByQuestionTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionTypeEN objvQuestionTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionTypeEN = JsonConvert.DeserializeObject<clsvQuestionTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionTypeEN;
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
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionTypeEN GetObjByQuestionTypeId_WA_Cache(string strQuestionTypeId)
{
string strAction = "GetObjByQuestionTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionTypeEN objvQuestionTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionTypeEN = JsonConvert.DeserializeObject<clsvQuestionTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionTypeEN;
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
public static clsvQuestionTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionTypeEN objvQuestionTypeEN = null;
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
objvQuestionTypeEN = JsonConvert.DeserializeObject<clsvQuestionTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionTypeEN;
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionTypeEN GetObjByQuestionTypeId_Cache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName_S);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel =
from objvQuestionTypeEN in arrvQuestionTypeObjLst_Cache
where objvQuestionTypeEN.QuestionTypeId == strQuestionTypeId
select objvQuestionTypeEN;
if (arrvQuestionTypeObjLst_Sel.Count() == 0)
{
   clsvQuestionTypeEN obj = clsvQuestionTypeWApi.GetObjByQuestionTypeId(strQuestionTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeNameByQuestionTypeId_Cache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName_S);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel1 =
from objvQuestionTypeEN in arrvQuestionTypeObjLst_Cache
where objvQuestionTypeEN.QuestionTypeId == strQuestionTypeId
select objvQuestionTypeEN;
List <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel = new List<clsvQuestionTypeEN>();
foreach (clsvQuestionTypeEN obj in arrvQuestionTypeObjLst_Sel1)
{
arrvQuestionTypeObjLst_Sel.Add(obj);
}
if (arrvQuestionTypeObjLst_Sel.Count > 0)
{
return arrvQuestionTypeObjLst_Sel[0].QuestionTypeName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionType对象缓存列表中,找不到记录[QuestionTypeId = {0}](函数:{1})", strQuestionTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeId_Cache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName_S);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel1 =
from objvQuestionTypeEN in arrvQuestionTypeObjLst_Cache
where objvQuestionTypeEN.QuestionTypeId == strQuestionTypeId
select objvQuestionTypeEN;
List <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel = new List<clsvQuestionTypeEN>();
foreach (clsvQuestionTypeEN obj in arrvQuestionTypeObjLst_Sel1)
{
arrvQuestionTypeObjLst_Sel.Add(obj);
}
if (arrvQuestionTypeObjLst_Sel.Count > 0)
{
return arrvQuestionTypeObjLst_Sel[0].QuestionTypeName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionType对象缓存列表中,找不到记录的相关名称[QuestionTypeId = {0}](函数:{1})", strQuestionTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionTypeEN> GetObjLstByQuestionTypeIdLst(List<string> arrQuestionTypeId)
{
 List<clsvQuestionTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionTypeEN> GetObjLstByQuestionTypeIdLst_Cache(List<string> arrQuestionTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName_S);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel =
from objvQuestionTypeEN in arrvQuestionTypeObjLst_Cache
where arrQuestionTypeId.Contains(objvQuestionTypeEN.QuestionTypeId)
select objvQuestionTypeEN;
return arrvQuestionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionTypeEN> GetObjLstByQuestionTypeIdLst_WA_Cache(List<string> arrQuestionTypeId)
{
 List<clsvQuestionTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strQuestionTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
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
 /// <param name = "objvQuestionTypeENS">源对象</param>
 /// <param name = "objvQuestionTypeENT">目标对象</param>
 public static void CopyTo(clsvQuestionTypeEN objvQuestionTypeENS, clsvQuestionTypeEN objvQuestionTypeENT)
{
try
{
objvQuestionTypeENT.QuestionTypeId = objvQuestionTypeENS.QuestionTypeId; //题目类型Id
objvQuestionTypeENT.QuestionTypeName = objvQuestionTypeENS.QuestionTypeName; //题目类型名
objvQuestionTypeENT.DefaAnswerModeId = objvQuestionTypeENS.DefaAnswerModeId; //默认答案模式Id
objvQuestionTypeENT.AnswerModeName = objvQuestionTypeENS.AnswerModeName; //答案模式名称
objvQuestionTypeENT.DefaAnswerTypeId = objvQuestionTypeENS.DefaAnswerTypeId; //默认答案类型Id
objvQuestionTypeENT.AnswerTypeName = objvQuestionTypeENS.AnswerTypeName; //答案类型名
objvQuestionTypeENT.OrderNum = objvQuestionTypeENS.OrderNum; //序号
objvQuestionTypeENT.IsUse = objvQuestionTypeENS.IsUse; //是否使用
objvQuestionTypeENT.UpdDate = objvQuestionTypeENS.UpdDate; //修改日期
objvQuestionTypeENT.UpdUser = objvQuestionTypeENS.UpdUser; //修改人
objvQuestionTypeENT.Memo = objvQuestionTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQuestionTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionTypeEN.AttributeName)
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
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId");
//if (arrvQuestionTypeObjLst_Cache == null)
//{
//arrvQuestionTypeObjLst_Cache = await clsvQuestionTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName_S);
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
public static List<clsvQuestionTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName_S);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionType.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.DefaAnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.DefaAnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionType.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionType.Memo, Type.GetType("System.String"));
foreach (clsvQuestionTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionType.QuestionTypeId] = objInFor[convQuestionType.QuestionTypeId];
objDR[convQuestionType.QuestionTypeName] = objInFor[convQuestionType.QuestionTypeName];
objDR[convQuestionType.DefaAnswerModeId] = objInFor[convQuestionType.DefaAnswerModeId];
objDR[convQuestionType.AnswerModeName] = objInFor[convQuestionType.AnswerModeName];
objDR[convQuestionType.DefaAnswerTypeId] = objInFor[convQuestionType.DefaAnswerTypeId];
objDR[convQuestionType.AnswerTypeName] = objInFor[convQuestionType.AnswerTypeName];
objDR[convQuestionType.OrderNum] = objInFor[convQuestionType.OrderNum];
objDR[convQuestionType.IsUse] = objInFor[convQuestionType.IsUse];
objDR[convQuestionType.UpdDate] = objInFor[convQuestionType.UpdDate];
objDR[convQuestionType.UpdUser] = objInFor[convQuestionType.UpdUser];
objDR[convQuestionType.Memo] = objInFor[convQuestionType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}