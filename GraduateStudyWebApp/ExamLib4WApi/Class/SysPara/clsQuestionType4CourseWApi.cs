
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionType4CourseWApi
 表名:QuestionType4Course(01120339)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:41
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
public static class clsQuestionType4CourseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetQuestionTypeId4Course(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, conQuestionType4Course.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, conQuestionType4Course.QuestionTypeId4Course);
objQuestionType4CourseEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.QuestionTypeId4Course) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.QuestionTypeId4Course, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.QuestionTypeId4Course] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetQuestionTypeName4Course(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strQuestionTypeName4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeName4Course, conQuestionType4Course.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeName4Course, 30, conQuestionType4Course.QuestionTypeName4Course);
objQuestionType4CourseEN.QuestionTypeName4Course = strQuestionTypeName4Course; //题目类型名4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.QuestionTypeName4Course) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.QuestionTypeName4Course, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.QuestionTypeName4Course] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetCourseId(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionType4Course.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionType4Course.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionType4Course.CourseId);
objQuestionType4CourseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.CourseId) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.CourseId, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.CourseId] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetOrderNum(this clsQuestionType4CourseEN objQuestionType4CourseEN, int intOrderNum, string strComparisonOp="")
	{
objQuestionType4CourseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.OrderNum) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.OrderNum, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.OrderNum] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetIsUse(this clsQuestionType4CourseEN objQuestionType4CourseEN, bool bolIsUse, string strComparisonOp="")
	{
objQuestionType4CourseEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.IsUse) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.IsUse, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.IsUse] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetUpdDate(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionType4Course.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionType4Course.UpdDate);
objQuestionType4CourseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.UpdDate) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.UpdDate, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.UpdDate] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetUpdUser(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionType4Course.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionType4Course.UpdUser);
objQuestionType4CourseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.UpdUser) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.UpdUser, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.UpdUser] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionType4CourseEN SetMemo(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionType4Course.Memo);
objQuestionType4CourseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionType4CourseEN.dicFldComparisonOp.ContainsKey(conQuestionType4Course.Memo) == false)
{
objQuestionType4CourseEN.dicFldComparisonOp.Add(conQuestionType4Course.Memo, strComparisonOp);
}
else
{
objQuestionType4CourseEN.dicFldComparisonOp[conQuestionType4Course.Memo] = strComparisonOp;
}
}
return objQuestionType4CourseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionType4CourseEN objQuestionType4Course_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objQuestionType4Course_Cond.dicFldComparisonOp[conQuestionType4Course.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.QuestionTypeId4Course, objQuestionType4Course_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.QuestionTypeName4Course) == true)
{
string strComparisonOp_QuestionTypeName4Course = objQuestionType4Course_Cond.dicFldComparisonOp[conQuestionType4Course.QuestionTypeName4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.QuestionTypeName4Course, objQuestionType4Course_Cond.QuestionTypeName4Course, strComparisonOp_QuestionTypeName4Course);
}
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.CourseId) == true)
{
string strComparisonOp_CourseId = objQuestionType4Course_Cond.dicFldComparisonOp[conQuestionType4Course.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.CourseId, objQuestionType4Course_Cond.CourseId, strComparisonOp_CourseId);
}
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.OrderNum) == true)
{
string strComparisonOp_OrderNum = objQuestionType4Course_Cond.dicFldComparisonOp[conQuestionType4Course.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionType4Course.OrderNum, objQuestionType4Course_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.IsUse) == true)
{
if (objQuestionType4Course_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionType4Course.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionType4Course.IsUse);
}
}
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQuestionType4Course_Cond.dicFldComparisonOp[conQuestionType4Course.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.UpdDate, objQuestionType4Course_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQuestionType4Course_Cond.dicFldComparisonOp[conQuestionType4Course.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.UpdUser, objQuestionType4Course_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQuestionType4Course_Cond.IsUpdated(conQuestionType4Course.Memo) == true)
{
string strComparisonOp_Memo = objQuestionType4Course_Cond.dicFldComparisonOp[conQuestionType4Course.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType4Course.Memo, objQuestionType4Course_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionType4CourseEN.sf_UpdFldSetStr = objQuestionType4CourseEN.getsf_UpdFldSetStr();
clsQuestionType4CourseWApi.CheckPropertyNew(objQuestionType4CourseEN); 
bool bolResult = clsQuestionType4CourseWApi.UpdateRecord(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseWApi.ReFreshCache();
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 if (string.IsNullOrEmpty(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionType4CourseWApi.IsExist(objQuestionType4CourseEN.QuestionTypeId4Course) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objQuestionType4CourseEN.QuestionTypeId4Course, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQuestionType4CourseWApi.CheckPropertyNew(objQuestionType4CourseEN); 
bool bolResult = clsQuestionType4CourseWApi.AddNewRecord(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseWApi.ReFreshCache();
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionType4CourseEN objQuestionType4CourseEN)
{
try
{
clsQuestionType4CourseWApi.CheckPropertyNew(objQuestionType4CourseEN); 
string strQuestionTypeId4Course = clsQuestionType4CourseWApi.AddNewRecordWithMaxId(objQuestionType4CourseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseWApi.ReFreshCache();
return strQuestionTypeId4Course;
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
 /// <param name = "objQuestionType4CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionType4CourseEN objQuestionType4CourseEN, string strWhereCond)
{
try
{
clsQuestionType4CourseWApi.CheckPropertyNew(objQuestionType4CourseEN); 
bool bolResult = clsQuestionType4CourseWApi.UpdateWithCondition(objQuestionType4CourseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseWApi.ReFreshCache();
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
 /// 题目类型4课程(QuestionType4Course)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionType4CourseWApi
{
private static readonly string mstrApiControllerName = "QuestionType4CourseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsQuestionType4CourseWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionTypeId4Course(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目类型4课程]...","0");
List<clsQuestionType4CourseEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionTypeId4Course";
objDDL.DataTextField="QuestionTypeName4Course";
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
public static void BindCbo_QuestionTypeId4Course(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionType4Course.QuestionTypeId4Course); 
List<clsQuestionType4CourseEN> arrObjLst = clsQuestionType4CourseWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN()
{
QuestionTypeId4Course = "0",
QuestionTypeName4Course = "选[题目类型4课程]..."
};
arrObjLst.Insert(0, objQuestionType4CourseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionType4Course.QuestionTypeId4Course;
objComboBox.DisplayMember = conQuestionType4Course.QuestionTypeName4Course;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
if (!Object.Equals(null, objQuestionType4CourseEN.QuestionTypeId4Course) && GetStrLen(objQuestionType4CourseEN.QuestionTypeId4Course) > 8)
{
 throw new Exception("字段[题目类型Id4课程]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionType4CourseEN.QuestionTypeName4Course) && GetStrLen(objQuestionType4CourseEN.QuestionTypeName4Course) > 30)
{
 throw new Exception("字段[题目类型名4课程]的长度不能超过30!");
}
if (!Object.Equals(null, objQuestionType4CourseEN.CourseId) && GetStrLen(objQuestionType4CourseEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionType4CourseEN.UpdDate) && GetStrLen(objQuestionType4CourseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionType4CourseEN.UpdUser) && GetStrLen(objQuestionType4CourseEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionType4CourseEN.Memo) && GetStrLen(objQuestionType4CourseEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQuestionType4CourseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionType4CourseEN GetObjByQuestionTypeId4Course(string strQuestionTypeId4Course)
{
string strAction = "GetObjByQuestionTypeId4Course";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionType4CourseEN objQuestionType4CourseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId4Course"] = strQuestionTypeId4Course
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionType4CourseEN = JsonConvert.DeserializeObject<clsQuestionType4CourseEN>((string)jobjReturn["ReturnObj"]);
return objQuestionType4CourseEN;
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
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionType4CourseEN GetObjByQuestionTypeId4Course_WA_Cache(string strQuestionTypeId4Course)
{
string strAction = "GetObjByQuestionTypeId4Course_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionType4CourseEN objQuestionType4CourseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId4Course"] = strQuestionTypeId4Course
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionType4CourseEN = JsonConvert.DeserializeObject<clsQuestionType4CourseEN>((string)jobjReturn["ReturnObj"]);
return objQuestionType4CourseEN;
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
public static clsQuestionType4CourseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionType4CourseEN objQuestionType4CourseEN = null;
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
objQuestionType4CourseEN = JsonConvert.DeserializeObject<clsQuestionType4CourseEN>((string)jobjReturn["ReturnObj"]);
return objQuestionType4CourseEN;
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
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionType4CourseEN GetObjByQuestionTypeId4Course_Cache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName_S);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel =
from objQuestionType4CourseEN in arrQuestionType4CourseObjLst_Cache
where objQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course
select objQuestionType4CourseEN;
if (arrQuestionType4CourseObjLst_Sel.Count() == 0)
{
   clsQuestionType4CourseEN obj = clsQuestionType4CourseWApi.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionType4CourseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeName4CourseByQuestionTypeId4Course_Cache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName_S);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel1 =
from objQuestionType4CourseEN in arrQuestionType4CourseObjLst_Cache
where objQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course
select objQuestionType4CourseEN;
List <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel = new List<clsQuestionType4CourseEN>();
foreach (clsQuestionType4CourseEN obj in arrQuestionType4CourseObjLst_Sel1)
{
arrQuestionType4CourseObjLst_Sel.Add(obj);
}
if (arrQuestionType4CourseObjLst_Sel.Count > 0)
{
return arrQuestionType4CourseObjLst_Sel[0].QuestionTypeName4Course;
}
string strErrMsgForGetObjById = string.Format("在QuestionType4Course对象缓存列表中,找不到记录[QuestionTypeId4Course = {0}](函数:{1})", strQuestionTypeId4Course, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionType4CourseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeId4Course_Cache(string strQuestionTypeId4Course)
{
if (string.IsNullOrEmpty(strQuestionTypeId4Course) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName_S);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel1 =
from objQuestionType4CourseEN in arrQuestionType4CourseObjLst_Cache
where objQuestionType4CourseEN.QuestionTypeId4Course == strQuestionTypeId4Course
select objQuestionType4CourseEN;
List <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel = new List<clsQuestionType4CourseEN>();
foreach (clsQuestionType4CourseEN obj in arrQuestionType4CourseObjLst_Sel1)
{
arrQuestionType4CourseObjLst_Sel.Add(obj);
}
if (arrQuestionType4CourseObjLst_Sel.Count > 0)
{
return arrQuestionType4CourseObjLst_Sel[0].QuestionTypeName4Course;
}
string strErrMsgForGetObjById = string.Format("在QuestionType4Course对象缓存列表中,找不到记录的相关名称[QuestionTypeId4Course = {0}](函数:{1})", strQuestionTypeId4Course, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionType4CourseBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionType4CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst(List<string> arrQuestionTypeId4Course)
{
 List<clsQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeId4CourseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId4Course);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionTypeId4Course">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst_Cache(List<string> arrQuestionTypeId4Course)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName_S);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Sel =
from objQuestionType4CourseEN in arrQuestionType4CourseObjLst_Cache
where arrQuestionTypeId4Course.Contains(objQuestionType4CourseEN.QuestionTypeId4Course)
select objQuestionType4CourseEN;
return arrQuestionType4CourseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLstByQuestionTypeId4CourseLst_WA_Cache(List<string> arrQuestionTypeId4Course)
{
 List<clsQuestionType4CourseEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeId4CourseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId4Course);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionType4CourseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionType4CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionType4CourseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionType4CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionType4CourseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionType4CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionType4CourseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionType4CourseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionType4CourseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strQuestionTypeId4Course)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQuestionType4CourseEN objQuestionType4CourseEN = clsQuestionType4CourseWApi.GetObjByQuestionTypeId4Course(strQuestionTypeId4Course);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQuestionTypeId4Course.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionType4CourseWApi.ReFreshCache();
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
public static int DelQuestionType4Courses(List<string> arrQuestionTypeId4Course)
{
string strAction = "DelQuestionType4Courses";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId4Course);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionType4CourseWApi.ReFreshCache();
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
public static int DelQuestionType4CoursesByCond(string strWhereCond)
{
string strAction = "DelQuestionType4CoursesByCond";
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
public static bool AddNewRecord(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionType4CourseEN>(objQuestionType4CourseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionType4CourseEN>(objQuestionType4CourseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionType4CourseWApi.ReFreshCache();
var strQuestionTypeId4Course = (string)jobjReturn["ReturnStr"];
return strQuestionTypeId4Course;
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
public static bool UpdateRecord(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
if (string.IsNullOrEmpty(objQuestionType4CourseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionType4CourseEN.QuestionTypeId4Course, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionType4CourseEN>(objQuestionType4CourseEN);
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
 /// <param name = "objQuestionType4CourseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionType4CourseEN objQuestionType4CourseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionType4CourseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionType4CourseEN.QuestionTypeId4Course, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionType4CourseEN.QuestionTypeId4Course, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionType4CourseEN>(objQuestionType4CourseEN);
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
public static bool IsExist(string strQuestionTypeId4Course)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId4Course"] = strQuestionTypeId4Course
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
 /// <param name = "objQuestionType4CourseENS">源对象</param>
 /// <param name = "objQuestionType4CourseENT">目标对象</param>
 public static void CopyTo(clsQuestionType4CourseEN objQuestionType4CourseENS, clsQuestionType4CourseEN objQuestionType4CourseENT)
{
try
{
objQuestionType4CourseENT.QuestionTypeId4Course = objQuestionType4CourseENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionType4CourseENT.QuestionTypeName4Course = objQuestionType4CourseENS.QuestionTypeName4Course; //题目类型名4课程
objQuestionType4CourseENT.CourseId = objQuestionType4CourseENS.CourseId; //课程Id
objQuestionType4CourseENT.OrderNum = objQuestionType4CourseENS.OrderNum; //序号
objQuestionType4CourseENT.IsUse = objQuestionType4CourseENS.IsUse; //是否使用
objQuestionType4CourseENT.UpdDate = objQuestionType4CourseENS.UpdDate; //修改日期
objQuestionType4CourseENT.UpdUser = objQuestionType4CourseENS.UpdUser; //修改人
objQuestionType4CourseENT.Memo = objQuestionType4CourseENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQuestionType4CourseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionType4CourseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionType4CourseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionType4CourseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionType4CourseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionType4CourseEN.AttributeName)
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
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId4Course");
//if (arrQuestionType4CourseObjLst_Cache == null)
//{
//arrQuestionType4CourseObjLst_Cache = await clsQuestionType4CourseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName_S);
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
if (clsQuestionType4CourseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsQuestionType4CourseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionType4CourseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsQuestionType4CourseEN._CurrTabName_S);
List<clsQuestionType4CourseEN> arrQuestionType4CourseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionType4CourseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionType4CourseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionType4Course.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType4Course.QuestionTypeName4Course, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType4Course.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType4Course.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionType4Course.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionType4Course.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType4Course.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType4Course.Memo, Type.GetType("System.String"));
foreach (clsQuestionType4CourseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionType4Course.QuestionTypeId4Course] = objInFor[conQuestionType4Course.QuestionTypeId4Course];
objDR[conQuestionType4Course.QuestionTypeName4Course] = objInFor[conQuestionType4Course.QuestionTypeName4Course];
objDR[conQuestionType4Course.CourseId] = objInFor[conQuestionType4Course.CourseId];
objDR[conQuestionType4Course.OrderNum] = objInFor[conQuestionType4Course.OrderNum];
objDR[conQuestionType4Course.IsUse] = objInFor[conQuestionType4Course.IsUse];
objDR[conQuestionType4Course.UpdDate] = objInFor[conQuestionType4Course.UpdDate];
objDR[conQuestionType4Course.UpdUser] = objInFor[conQuestionType4Course.UpdUser];
objDR[conQuestionType4Course.Memo] = objInFor[conQuestionType4Course.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 题目类型4课程(QuestionType4Course)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QuestionType4Course : clsCommFun4BL
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
clsQuestionType4CourseWApi.ReFreshThisCache();
clsvQuestionType4CourseWApi.ReFreshThisCache();
}
}

}