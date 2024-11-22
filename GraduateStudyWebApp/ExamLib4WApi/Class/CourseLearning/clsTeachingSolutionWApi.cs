
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingSolutionWApi
 表名:TeachingSolution(01120137)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:01
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsTeachingSolutionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN SetTeachingSolutionId(this clsTeachingSolutionEN objTeachingSolutionEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conTeachingSolution.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conTeachingSolution.TeachingSolutionId);
objTeachingSolutionEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.TeachingSolutionId) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.TeachingSolutionId, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.TeachingSolutionId] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN SetTeachingSolutionName(this clsTeachingSolutionEN objTeachingSolutionEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionName, conTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, conTeachingSolution.TeachingSolutionName);
objTeachingSolutionEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.TeachingSolutionName) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.TeachingSolutionName, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.TeachingSolutionName] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN SetCourseId(this clsTeachingSolutionEN objTeachingSolutionEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conTeachingSolution.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conTeachingSolution.CourseId);
objTeachingSolutionEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.CourseId) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.CourseId, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.CourseId] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN Setid_Teacher(this clsTeachingSolutionEN objTeachingSolutionEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Teacher, conTeachingSolution.id_Teacher);
clsCheckSql.CheckFieldLen(strid_Teacher, 8, conTeachingSolution.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, conTeachingSolution.id_Teacher);
objTeachingSolutionEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.id_Teacher) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.id_Teacher, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.id_Teacher] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN SetBriefIntroduction(this clsTeachingSolutionEN objTeachingSolutionEN, string strBriefIntroduction, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBriefIntroduction, 8000, conTeachingSolution.BriefIntroduction);
objTeachingSolutionEN.BriefIntroduction = strBriefIntroduction; //简介
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.BriefIntroduction) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.BriefIntroduction, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.BriefIntroduction] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN SetUpdDate(this clsTeachingSolutionEN objTeachingSolutionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conTeachingSolution.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachingSolution.UpdDate);
objTeachingSolutionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.UpdDate) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.UpdDate, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.UpdDate] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN SetUpdUser(this clsTeachingSolutionEN objTeachingSolutionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conTeachingSolution.UpdUser);
objTeachingSolutionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.UpdUser) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.UpdUser, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.UpdUser] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingSolutionEN SetMemo(this clsTeachingSolutionEN objTeachingSolutionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachingSolution.Memo);
objTeachingSolutionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingSolutionEN.dicFldComparisonOp.ContainsKey(conTeachingSolution.Memo) == false)
{
objTeachingSolutionEN.dicFldComparisonOp.Add(conTeachingSolution.Memo, strComparisonOp);
}
else
{
objTeachingSolutionEN.dicFldComparisonOp[conTeachingSolution.Memo] = strComparisonOp;
}
}
return objTeachingSolutionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachingSolutionEN objTeachingSolution_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.TeachingSolutionId, objTeachingSolution_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.TeachingSolutionName, objTeachingSolution_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.CourseId) == true)
{
string strComparisonOp_CourseId = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.CourseId, objTeachingSolution_Cond.CourseId, strComparisonOp_CourseId);
}
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.id_Teacher, objTeachingSolution_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.BriefIntroduction) == true)
{
string strComparisonOp_BriefIntroduction = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.BriefIntroduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.BriefIntroduction, objTeachingSolution_Cond.BriefIntroduction, strComparisonOp_BriefIntroduction);
}
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.UpdDate) == true)
{
string strComparisonOp_UpdDate = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.UpdDate, objTeachingSolution_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.UpdUser) == true)
{
string strComparisonOp_UpdUser = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.UpdUser, objTeachingSolution_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objTeachingSolution_Cond.IsUpdated(conTeachingSolution.Memo) == true)
{
string strComparisonOp_Memo = objTeachingSolution_Cond.dicFldComparisonOp[conTeachingSolution.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingSolution.Memo, objTeachingSolution_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingSolutionEN objTeachingSolutionEN)
{
 if (string.IsNullOrEmpty(objTeachingSolutionEN.TeachingSolutionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTeachingSolutionEN.sf_UpdFldSetStr = objTeachingSolutionEN.getsf_UpdFldSetStr();
clsTeachingSolutionWApi.CheckPropertyNew(objTeachingSolutionEN); 
bool bolResult = clsTeachingSolutionWApi.UpdateRecord(objTeachingSolutionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
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
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachingSolutionEN objTeachingSolutionEN)
{
 if (string.IsNullOrEmpty(objTeachingSolutionEN.TeachingSolutionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachingSolutionWApi.IsExist(objTeachingSolutionEN.TeachingSolutionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTeachingSolutionEN.TeachingSolutionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTeachingSolutionWApi.CheckPropertyNew(objTeachingSolutionEN); 
bool bolResult = clsTeachingSolutionWApi.AddNewRecord(objTeachingSolutionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
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
 /// <param name = "objTeachingSolutionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeachingSolutionEN objTeachingSolutionEN)
{
try
{
clsTeachingSolutionWApi.CheckPropertyNew(objTeachingSolutionEN); 
string strTeachingSolutionId = clsTeachingSolutionWApi.AddNewRecordWithMaxId(objTeachingSolutionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
return strTeachingSolutionId;
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
 /// <param name = "objTeachingSolutionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingSolutionEN objTeachingSolutionEN, string strWhereCond)
{
try
{
clsTeachingSolutionWApi.CheckPropertyNew(objTeachingSolutionEN); 
bool bolResult = clsTeachingSolutionWApi.UpdateWithCondition(objTeachingSolutionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
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
 /// 教学方案(TeachingSolution)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTeachingSolutionWApi
{
private static readonly string mstrApiControllerName = "TeachingSolutionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsTeachingSolutionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TeachingSolutionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[教学方案]...","0");
List<clsTeachingSolutionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TeachingSolutionId";
objDDL.DataTextField="TeachingSolutionName";
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
public static void BindCbo_TeachingSolutionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conTeachingSolution.TeachingSolutionId); 
List<clsTeachingSolutionEN> arrObjLst = clsTeachingSolutionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsTeachingSolutionEN objTeachingSolutionEN = new clsTeachingSolutionEN()
{
TeachingSolutionId = "0",
TeachingSolutionName = "选[教学方案]..."
};
arrObjLst.Insert(0, objTeachingSolutionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conTeachingSolution.TeachingSolutionId;
objComboBox.DisplayMember = conTeachingSolution.TeachingSolutionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTeachingSolutionEN objTeachingSolutionEN)
{
if (!Object.Equals(null, objTeachingSolutionEN.TeachingSolutionId) && GetStrLen(objTeachingSolutionEN.TeachingSolutionId) > 8)
{
 throw new Exception("字段[教学方案Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingSolutionEN.TeachingSolutionName) && GetStrLen(objTeachingSolutionEN.TeachingSolutionName) > 100)
{
 throw new Exception("字段[教学方案名称]的长度不能超过100!");
}
if (!Object.Equals(null, objTeachingSolutionEN.CourseId) && GetStrLen(objTeachingSolutionEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingSolutionEN.id_Teacher) && GetStrLen(objTeachingSolutionEN.id_Teacher) > 8)
{
 throw new Exception("字段[教师流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingSolutionEN.BriefIntroduction) && GetStrLen(objTeachingSolutionEN.BriefIntroduction) > 8000)
{
 throw new Exception("字段[简介]的长度不能超过8000!");
}
if (!Object.Equals(null, objTeachingSolutionEN.UpdDate) && GetStrLen(objTeachingSolutionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingSolutionEN.UpdUser) && GetStrLen(objTeachingSolutionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingSolutionEN.Memo) && GetStrLen(objTeachingSolutionEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objTeachingSolutionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingSolutionEN GetObjByTeachingSolutionId(string strTeachingSolutionId)
{
string strAction = "GetObjByTeachingSolutionId";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingSolutionEN objTeachingSolutionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingSolutionId"] = strTeachingSolutionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objTeachingSolutionEN = JsonConvert.DeserializeObject<clsTeachingSolutionEN>((string)jobjReturn["ReturnObj"]);
return objTeachingSolutionEN;
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
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingSolutionEN GetObjByTeachingSolutionId_WA_Cache(string strTeachingSolutionId, string strCourseId)
{
string strAction = "GetObjByTeachingSolutionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingSolutionEN objTeachingSolutionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingSolutionId"] = strTeachingSolutionId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objTeachingSolutionEN = JsonConvert.DeserializeObject<clsTeachingSolutionEN>((string)jobjReturn["ReturnObj"]);
return objTeachingSolutionEN;
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
public static clsTeachingSolutionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingSolutionEN objTeachingSolutionEN = null;
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
objTeachingSolutionEN = JsonConvert.DeserializeObject<clsTeachingSolutionEN>((string)jobjReturn["ReturnObj"]);
return objTeachingSolutionEN;
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
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachingSolutionEN GetObjByTeachingSolutionId_Cache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsTeachingSolutionEN> arrTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsTeachingSolutionEN> arrTeachingSolutionObjLst_Sel =
from objTeachingSolutionEN in arrTeachingSolutionObjLst_Cache
where objTeachingSolutionEN.TeachingSolutionId == strTeachingSolutionId
select objTeachingSolutionEN;
if (arrTeachingSolutionObjLst_Sel.Count() == 0)
{
   clsTeachingSolutionEN obj = clsTeachingSolutionWApi.GetObjByTeachingSolutionId(strTeachingSolutionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTeachingSolutionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingSolutionNameByTeachingSolutionId_Cache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsTeachingSolutionEN> arrTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsTeachingSolutionEN> arrTeachingSolutionObjLst_Sel1 =
from objTeachingSolutionEN in arrTeachingSolutionObjLst_Cache
where objTeachingSolutionEN.TeachingSolutionId == strTeachingSolutionId
select objTeachingSolutionEN;
List <clsTeachingSolutionEN> arrTeachingSolutionObjLst_Sel = new List<clsTeachingSolutionEN>();
foreach (clsTeachingSolutionEN obj in arrTeachingSolutionObjLst_Sel1)
{
arrTeachingSolutionObjLst_Sel.Add(obj);
}
if (arrTeachingSolutionObjLst_Sel.Count > 0)
{
return arrTeachingSolutionObjLst_Sel[0].TeachingSolutionName;
}
string strErrMsgForGetObjById = string.Format("在TeachingSolution对象缓存列表中,找不到记录[TeachingSolutionId = {0}](函数:{1})", strTeachingSolutionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeachingSolutionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTeachingSolutionId_Cache(string strTeachingSolutionId, string strCourseId)
{
if (string.IsNullOrEmpty(strTeachingSolutionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsTeachingSolutionEN> arrTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsTeachingSolutionEN> arrTeachingSolutionObjLst_Sel1 =
from objTeachingSolutionEN in arrTeachingSolutionObjLst_Cache
where objTeachingSolutionEN.TeachingSolutionId == strTeachingSolutionId
select objTeachingSolutionEN;
List <clsTeachingSolutionEN> arrTeachingSolutionObjLst_Sel = new List<clsTeachingSolutionEN>();
foreach (clsTeachingSolutionEN obj in arrTeachingSolutionObjLst_Sel1)
{
arrTeachingSolutionObjLst_Sel.Add(obj);
}
if (arrTeachingSolutionObjLst_Sel.Count > 0)
{
return arrTeachingSolutionObjLst_Sel[0].TeachingSolutionName;
}
string strErrMsgForGetObjById = string.Format("在TeachingSolution对象缓存列表中,找不到记录的相关名称[TeachingSolutionId = {0}](函数:{1})", strTeachingSolutionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsTeachingSolutionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingSolutionEN> GetObjLst(string strWhereCond)
{
 List<clsTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingSolutionEN> GetObjLstByTeachingSolutionIdLst(List<string> arrTeachingSolutionId)
{
 List<clsTeachingSolutionEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingSolutionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingSolutionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strTeachingSolutionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsTeachingSolutionEN> GetObjLstByTeachingSolutionIdLst_Cache(List<string> arrTeachingSolutionId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsTeachingSolutionEN> arrTeachingSolutionObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsTeachingSolutionEN> arrTeachingSolutionObjLst_Sel =
from objTeachingSolutionEN in arrTeachingSolutionObjLst_Cache
where arrTeachingSolutionId.Contains(objTeachingSolutionEN.TeachingSolutionId)
select objTeachingSolutionEN;
return arrTeachingSolutionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingSolutionEN> GetObjLstByTeachingSolutionIdLst_WA_Cache(List<string> arrTeachingSolutionId, string strCourseId)
{
 List<clsTeachingSolutionEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingSolutionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingSolutionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingSolutionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingSolutionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingSolutionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingSolutionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsTeachingSolutionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingSolutionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strTeachingSolutionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsTeachingSolutionEN objTeachingSolutionEN = clsTeachingSolutionWApi.GetObjByTeachingSolutionId(strTeachingSolutionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strTeachingSolutionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
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
public static int DelTeachingSolutions(List<string> arrTeachingSolutionId)
{
string strAction = "DelTeachingSolutions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingSolutionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsTeachingSolutionEN objTeachingSolutionEN = clsTeachingSolutionWApi.GetObjByTeachingSolutionId(arrTeachingSolutionId[0]);
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
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
public static int DelTeachingSolutionsByCond(string strWhereCond)
{
string strAction = "DelTeachingSolutionsByCond";
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
public static bool AddNewRecord(clsTeachingSolutionEN objTeachingSolutionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingSolutionEN>(objTeachingSolutionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
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
public static string AddNewRecordWithMaxId(clsTeachingSolutionEN objTeachingSolutionEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingSolutionEN>(objTeachingSolutionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingSolutionWApi.ReFreshCache(objTeachingSolutionEN.CourseId);
var strTeachingSolutionId = (string)jobjReturn["ReturnStr"];
return strTeachingSolutionId;
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
public static bool UpdateRecord(clsTeachingSolutionEN objTeachingSolutionEN)
{
if (string.IsNullOrEmpty(objTeachingSolutionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingSolutionEN.TeachingSolutionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingSolutionEN>(objTeachingSolutionEN);
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
 /// <param name = "objTeachingSolutionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTeachingSolutionEN objTeachingSolutionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTeachingSolutionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingSolutionEN.TeachingSolutionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingSolutionEN.TeachingSolutionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingSolutionEN>(objTeachingSolutionEN);
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
public static bool IsExist(string strTeachingSolutionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingSolutionId"] = strTeachingSolutionId
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
 /// <param name = "objTeachingSolutionENS">源对象</param>
 /// <param name = "objTeachingSolutionENT">目标对象</param>
 public static void CopyTo(clsTeachingSolutionEN objTeachingSolutionENS, clsTeachingSolutionEN objTeachingSolutionENT)
{
try
{
objTeachingSolutionENT.TeachingSolutionId = objTeachingSolutionENS.TeachingSolutionId; //教学方案Id
objTeachingSolutionENT.TeachingSolutionName = objTeachingSolutionENS.TeachingSolutionName; //教学方案名称
objTeachingSolutionENT.CourseId = objTeachingSolutionENS.CourseId; //课程Id
objTeachingSolutionENT.id_Teacher = objTeachingSolutionENS.id_Teacher; //教师流水号
objTeachingSolutionENT.BriefIntroduction = objTeachingSolutionENS.BriefIntroduction; //简介
objTeachingSolutionENT.UpdDate = objTeachingSolutionENS.UpdDate; //修改日期
objTeachingSolutionENT.UpdUser = objTeachingSolutionENS.UpdUser; //修改人
objTeachingSolutionENT.Memo = objTeachingSolutionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsTeachingSolutionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTeachingSolutionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTeachingSolutionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTeachingSolutionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTeachingSolutionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTeachingSolutionEN.AttributeName)
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
if (clsTeachingSolutionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionWApi没有刷新缓存机制(clsTeachingSolutionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TeachingSolutionId");
//if (arrTeachingSolutionObjLst_Cache == null)
//{
//arrTeachingSolutionObjLst_Cache = await clsTeachingSolutionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsTeachingSolutionEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsTeachingSolutionWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsTeachingSolutionEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsTeachingSolutionWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingSolutionEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsTeachingSolutionEN._CurrTabName_S, strCourseId);
List<clsTeachingSolutionEN> arrTeachingSolutionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrTeachingSolutionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTeachingSolutionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTeachingSolution.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingSolution.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingSolution.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingSolution.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingSolution.BriefIntroduction, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingSolution.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingSolution.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingSolution.Memo, Type.GetType("System.String"));
foreach (clsTeachingSolutionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTeachingSolution.TeachingSolutionId] = objInFor[conTeachingSolution.TeachingSolutionId];
objDR[conTeachingSolution.TeachingSolutionName] = objInFor[conTeachingSolution.TeachingSolutionName];
objDR[conTeachingSolution.CourseId] = objInFor[conTeachingSolution.CourseId];
objDR[conTeachingSolution.id_Teacher] = objInFor[conTeachingSolution.id_Teacher];
objDR[conTeachingSolution.BriefIntroduction] = objInFor[conTeachingSolution.BriefIntroduction];
objDR[conTeachingSolution.UpdDate] = objInFor[conTeachingSolution.UpdDate];
objDR[conTeachingSolution.UpdUser] = objInFor[conTeachingSolution.UpdUser];
objDR[conTeachingSolution.Memo] = objInFor[conTeachingSolution.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教学方案(TeachingSolution)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4TeachingSolution : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsTeachingSolutionWApi.ReFreshThisCache(strCourseId);
clsvTeachingSolutionWApi.ReFreshThisCache(strCourseId);
}
}

}