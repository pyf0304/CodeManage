
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzSchool_PsWApi
 表名:XzSchool_Ps(01120102)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:03
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
public static class clsXzSchool_PsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN Setid_School_Ps(this clsXzSchool_PsEN objXzSchool_PsEN, string strid_School_Ps, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School_Ps, 4, conXzSchool_Ps.id_School_Ps);
clsCheckSql.CheckFieldForeignKey(strid_School_Ps, 4, conXzSchool_Ps.id_School_Ps);
objXzSchool_PsEN.id_School_Ps = strid_School_Ps; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.id_School_Ps) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.id_School_Ps, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.id_School_Ps] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN SetSchoolId(this clsXzSchool_PsEN objXzSchool_PsEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, conXzSchool_Ps.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, conXzSchool_Ps.SchoolId);
objXzSchool_PsEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.SchoolId) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.SchoolId, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.SchoolId] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN SetSchoolName(this clsXzSchool_PsEN objXzSchool_PsEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, conXzSchool_Ps.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, conXzSchool_Ps.SchoolName);
objXzSchool_PsEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.SchoolName) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.SchoolName, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.SchoolName] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN SetOrderNum(this clsXzSchool_PsEN objXzSchool_PsEN, int intOrderNum, string strComparisonOp="")
	{
objXzSchool_PsEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.OrderNum) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.OrderNum, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.OrderNum] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN SetIsVisible(this clsXzSchool_PsEN objXzSchool_PsEN, bool bolIsVisible, string strComparisonOp="")
	{
objXzSchool_PsEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.IsVisible) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.IsVisible, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.IsVisible] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN SetUpdDate(this clsXzSchool_PsEN objXzSchool_PsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conXzSchool_Ps.UpdDate);
objXzSchool_PsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.UpdDate) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.UpdDate, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.UpdDate] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN SetUpdUserId(this clsXzSchool_PsEN objXzSchool_PsEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conXzSchool_Ps.UpdUserId);
objXzSchool_PsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.UpdUserId) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.UpdUserId, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.UpdUserId] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzSchool_PsEN SetMemo(this clsXzSchool_PsEN objXzSchool_PsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzSchool_Ps.Memo);
objXzSchool_PsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzSchool_PsEN.dicFldComparisonOp.ContainsKey(conXzSchool_Ps.Memo) == false)
{
objXzSchool_PsEN.dicFldComparisonOp.Add(conXzSchool_Ps.Memo, strComparisonOp);
}
else
{
objXzSchool_PsEN.dicFldComparisonOp[conXzSchool_Ps.Memo] = strComparisonOp;
}
}
return objXzSchool_PsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzSchool_PsEN objXzSchool_Ps_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.id_School_Ps) == true)
{
string strComparisonOp_id_School_Ps = objXzSchool_Ps_Cond.dicFldComparisonOp[conXzSchool_Ps.id_School_Ps];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.id_School_Ps, objXzSchool_Ps_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
}
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.SchoolId) == true)
{
string strComparisonOp_SchoolId = objXzSchool_Ps_Cond.dicFldComparisonOp[conXzSchool_Ps.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.SchoolId, objXzSchool_Ps_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.SchoolName) == true)
{
string strComparisonOp_SchoolName = objXzSchool_Ps_Cond.dicFldComparisonOp[conXzSchool_Ps.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.SchoolName, objXzSchool_Ps_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.OrderNum) == true)
{
string strComparisonOp_OrderNum = objXzSchool_Ps_Cond.dicFldComparisonOp[conXzSchool_Ps.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conXzSchool_Ps.OrderNum, objXzSchool_Ps_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.IsVisible) == true)
{
if (objXzSchool_Ps_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzSchool_Ps.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzSchool_Ps.IsVisible);
}
}
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.UpdDate) == true)
{
string strComparisonOp_UpdDate = objXzSchool_Ps_Cond.dicFldComparisonOp[conXzSchool_Ps.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.UpdDate, objXzSchool_Ps_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objXzSchool_Ps_Cond.dicFldComparisonOp[conXzSchool_Ps.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.UpdUserId, objXzSchool_Ps_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objXzSchool_Ps_Cond.IsUpdated(conXzSchool_Ps.Memo) == true)
{
string strComparisonOp_Memo = objXzSchool_Ps_Cond.dicFldComparisonOp[conXzSchool_Ps.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzSchool_Ps.Memo, objXzSchool_Ps_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzSchool_PsEN objXzSchool_PsEN)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.id_School_Ps) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzSchool_PsEN.sf_UpdFldSetStr = objXzSchool_PsEN.getsf_UpdFldSetStr();
clsXzSchool_PsWApi.CheckPropertyNew(objXzSchool_PsEN); 
bool bolResult = clsXzSchool_PsWApi.UpdateRecord(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsWApi.ReFreshCache();
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzSchool_PsEN objXzSchool_PsEN)
{
 if (string.IsNullOrEmpty(objXzSchool_PsEN.id_School_Ps) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzSchool_PsWApi.IsExist(objXzSchool_PsEN.id_School_Ps) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objXzSchool_PsEN.id_School_Ps, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsXzSchool_PsWApi.CheckPropertyNew(objXzSchool_PsEN); 
bool bolResult = clsXzSchool_PsWApi.AddNewRecord(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsWApi.ReFreshCache();
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
 /// <param name = "objXzSchool_PsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzSchool_PsEN objXzSchool_PsEN)
{
try
{
clsXzSchool_PsWApi.CheckPropertyNew(objXzSchool_PsEN); 
string strid_School_Ps = clsXzSchool_PsWApi.AddNewRecordWithMaxId(objXzSchool_PsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsWApi.ReFreshCache();
return strid_School_Ps;
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
 /// <param name = "objXzSchool_PsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzSchool_PsEN objXzSchool_PsEN, string strWhereCond)
{
try
{
clsXzSchool_PsWApi.CheckPropertyNew(objXzSchool_PsEN); 
bool bolResult = clsXzSchool_PsWApi.UpdateWithCondition(objXzSchool_PsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsWApi.ReFreshCache();
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
 /// 学校_Ps(XzSchool_Ps)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzSchool_PsWApi
{
private static readonly string mstrApiControllerName = "XzSchool_PsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsXzSchool_PsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_School_Ps(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学校_Ps]...","0");
List<clsXzSchool_PsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_School_Ps";
objDDL.DataTextField="SchoolName";
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
public static void BindCbo_id_School_Ps(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzSchool_Ps.id_School_Ps); 
List<clsXzSchool_PsEN> arrObjLst = clsXzSchool_PsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzSchool_PsEN objXzSchool_PsEN = new clsXzSchool_PsEN()
{
id_School_Ps = "0",
SchoolName = "选[学校_Ps]..."
};
arrObjLst.Insert(0, objXzSchool_PsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzSchool_Ps.id_School_Ps;
objComboBox.DisplayMember = conXzSchool_Ps.SchoolName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzSchool_PsEN objXzSchool_PsEN)
{
if (!Object.Equals(null, objXzSchool_PsEN.id_School_Ps) && GetStrLen(objXzSchool_PsEN.id_School_Ps) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzSchool_PsEN.SchoolId) && GetStrLen(objXzSchool_PsEN.SchoolId) > 10)
{
 throw new Exception("字段[学校编号]的长度不能超过10!");
}
if (!Object.Equals(null, objXzSchool_PsEN.SchoolName) && GetStrLen(objXzSchool_PsEN.SchoolName) > 50)
{
 throw new Exception("字段[学校名称]的长度不能超过50!");
}
if (!Object.Equals(null, objXzSchool_PsEN.UpdDate) && GetStrLen(objXzSchool_PsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objXzSchool_PsEN.UpdUserId) && GetStrLen(objXzSchool_PsEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objXzSchool_PsEN.Memo) && GetStrLen(objXzSchool_PsEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objXzSchool_PsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_School_Ps">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchool_PsEN GetObjByid_School_Ps(string strid_School_Ps)
{
string strAction = "GetObjByid_School_Ps";
string strErrMsg = string.Empty;
string strResult = "";
clsXzSchool_PsEN objXzSchool_PsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School_Ps"] = strid_School_Ps
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzSchool_PsEN = JsonConvert.DeserializeObject<clsXzSchool_PsEN>((string)jobjReturn["ReturnObj"]);
return objXzSchool_PsEN;
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
 /// <param name = "strid_School_Ps">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzSchool_PsEN GetObjByid_School_Ps_WA_Cache(string strid_School_Ps)
{
string strAction = "GetObjByid_School_Ps_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsXzSchool_PsEN objXzSchool_PsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School_Ps"] = strid_School_Ps
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzSchool_PsEN = JsonConvert.DeserializeObject<clsXzSchool_PsEN>((string)jobjReturn["ReturnObj"]);
return objXzSchool_PsEN;
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
public static clsXzSchool_PsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsXzSchool_PsEN objXzSchool_PsEN = null;
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
objXzSchool_PsEN = JsonConvert.DeserializeObject<clsXzSchool_PsEN>((string)jobjReturn["ReturnObj"]);
return objXzSchool_PsEN;
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
 /// <param name = "strid_School_Ps">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzSchool_PsEN GetObjByid_School_Ps_Cache(string strid_School_Ps)
{
if (string.IsNullOrEmpty(strid_School_Ps) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName_S);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel =
from objXzSchool_PsEN in arrXzSchool_PsObjLst_Cache
where objXzSchool_PsEN.id_School_Ps == strid_School_Ps
select objXzSchool_PsEN;
if (arrXzSchool_PsObjLst_Sel.Count() == 0)
{
   clsXzSchool_PsEN obj = clsXzSchool_PsWApi.GetObjByid_School_Ps(strid_School_Ps);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzSchool_PsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School_Ps">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSchoolNameByid_School_Ps_Cache(string strid_School_Ps)
{
if (string.IsNullOrEmpty(strid_School_Ps) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName_S);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel1 =
from objXzSchool_PsEN in arrXzSchool_PsObjLst_Cache
where objXzSchool_PsEN.id_School_Ps == strid_School_Ps
select objXzSchool_PsEN;
List <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel = new List<clsXzSchool_PsEN>();
foreach (clsXzSchool_PsEN obj in arrXzSchool_PsObjLst_Sel1)
{
arrXzSchool_PsObjLst_Sel.Add(obj);
}
if (arrXzSchool_PsObjLst_Sel.Count > 0)
{
return arrXzSchool_PsObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在XzSchool_Ps对象缓存列表中,找不到记录[id_School_Ps = {0}](函数:{1})", strid_School_Ps, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzSchool_PsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_School_Ps">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_School_Ps_Cache(string strid_School_Ps)
{
if (string.IsNullOrEmpty(strid_School_Ps) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName_S);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel1 =
from objXzSchool_PsEN in arrXzSchool_PsObjLst_Cache
where objXzSchool_PsEN.id_School_Ps == strid_School_Ps
select objXzSchool_PsEN;
List <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel = new List<clsXzSchool_PsEN>();
foreach (clsXzSchool_PsEN obj in arrXzSchool_PsObjLst_Sel1)
{
arrXzSchool_PsObjLst_Sel.Add(obj);
}
if (arrXzSchool_PsObjLst_Sel.Count > 0)
{
return arrXzSchool_PsObjLst_Sel[0].SchoolName;
}
string strErrMsgForGetObjById = string.Format("在XzSchool_Ps对象缓存列表中,找不到记录的相关名称[id_School_Ps = {0}](函数:{1})", strid_School_Ps, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzSchool_PsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLst(string strWhereCond)
{
 List<clsXzSchool_PsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchool_PsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzSchool_PsEN> GetObjLstById_School_PsLst(List<string> arrId_School_Ps)
{
 List<clsXzSchool_PsEN> arrObjLst = null; 
string strAction = "GetObjLstById_School_PsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_School_Ps);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchool_PsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_School_Ps">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsXzSchool_PsEN> GetObjLstById_School_PsLst_Cache(List<string> arrId_School_Ps)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName_S);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzSchool_PsEN> arrXzSchool_PsObjLst_Sel =
from objXzSchool_PsEN in arrXzSchool_PsObjLst_Cache
where arrId_School_Ps.Contains(objXzSchool_PsEN.id_School_Ps)
select objXzSchool_PsEN;
return arrXzSchool_PsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLstById_School_PsLst_WA_Cache(List<string> arrId_School_Ps)
{
 List<clsXzSchool_PsEN> arrObjLst = null; 
string strAction = "GetObjLstById_School_PsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_School_Ps);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchool_PsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzSchool_PsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzSchool_PsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchool_PsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzSchool_PsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzSchool_PsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchool_PsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzSchool_PsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzSchool_PsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchool_PsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzSchool_PsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsXzSchool_PsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzSchool_PsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_School_Ps)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsXzSchool_PsEN objXzSchool_PsEN = clsXzSchool_PsWApi.GetObjByid_School_Ps(strid_School_Ps);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_School_Ps.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzSchool_PsWApi.ReFreshCache();
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
public static int DelXzSchool_Pss(List<string> arrid_School_Ps)
{
string strAction = "DelXzSchool_Pss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_School_Ps);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzSchool_PsWApi.ReFreshCache();
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
public static int DelXzSchool_PssByCond(string strWhereCond)
{
string strAction = "DelXzSchool_PssByCond";
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
public static bool AddNewRecord(clsXzSchool_PsEN objXzSchool_PsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchool_PsEN>(objXzSchool_PsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsXzSchool_PsEN objXzSchool_PsEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchool_PsEN>(objXzSchool_PsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzSchool_PsWApi.ReFreshCache();
var strid_School_Ps = (string)jobjReturn["ReturnStr"];
return strid_School_Ps;
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
public static bool UpdateRecord(clsXzSchool_PsEN objXzSchool_PsEN)
{
if (string.IsNullOrEmpty(objXzSchool_PsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzSchool_PsEN.id_School_Ps, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchool_PsEN>(objXzSchool_PsEN);
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
 /// <param name = "objXzSchool_PsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzSchool_PsEN objXzSchool_PsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzSchool_PsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzSchool_PsEN.id_School_Ps, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzSchool_PsEN.id_School_Ps, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzSchool_PsEN>(objXzSchool_PsEN);
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
public static bool IsExist(string strid_School_Ps)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_School_Ps"] = strid_School_Ps
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
 /// <param name = "objXzSchool_PsENS">源对象</param>
 /// <param name = "objXzSchool_PsENT">目标对象</param>
 public static void CopyTo(clsXzSchool_PsEN objXzSchool_PsENS, clsXzSchool_PsEN objXzSchool_PsENT)
{
try
{
objXzSchool_PsENT.id_School_Ps = objXzSchool_PsENS.id_School_Ps; //学校流水号
objXzSchool_PsENT.SchoolId = objXzSchool_PsENS.SchoolId; //学校编号
objXzSchool_PsENT.SchoolName = objXzSchool_PsENS.SchoolName; //学校名称
objXzSchool_PsENT.OrderNum = objXzSchool_PsENS.OrderNum; //序号
objXzSchool_PsENT.IsVisible = objXzSchool_PsENS.IsVisible; //是否显示
objXzSchool_PsENT.UpdDate = objXzSchool_PsENS.UpdDate; //修改日期
objXzSchool_PsENT.UpdUserId = objXzSchool_PsENS.UpdUserId; //修改用户Id
objXzSchool_PsENT.Memo = objXzSchool_PsENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsXzSchool_PsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzSchool_PsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzSchool_PsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzSchool_PsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzSchool_PsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzSchool_PsEN.AttributeName)
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
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_School_Ps");
//if (arrXzSchool_PsObjLst_Cache == null)
//{
//arrXzSchool_PsObjLst_Cache = await clsXzSchool_PsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName_S);
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
if (clsXzSchool_PsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzSchool_PsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzSchool_PsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsXzSchool_PsEN._CurrTabName_S);
List<clsXzSchool_PsEN> arrXzSchool_PsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzSchool_PsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzSchool_PsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzSchool_Ps.id_School_Ps, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool_Ps.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool_Ps.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool_Ps.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conXzSchool_Ps.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzSchool_Ps.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool_Ps.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conXzSchool_Ps.Memo, Type.GetType("System.String"));
foreach (clsXzSchool_PsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzSchool_Ps.id_School_Ps] = objInFor[conXzSchool_Ps.id_School_Ps];
objDR[conXzSchool_Ps.SchoolId] = objInFor[conXzSchool_Ps.SchoolId];
objDR[conXzSchool_Ps.SchoolName] = objInFor[conXzSchool_Ps.SchoolName];
objDR[conXzSchool_Ps.OrderNum] = objInFor[conXzSchool_Ps.OrderNum];
objDR[conXzSchool_Ps.IsVisible] = objInFor[conXzSchool_Ps.IsVisible];
objDR[conXzSchool_Ps.UpdDate] = objInFor[conXzSchool_Ps.UpdDate];
objDR[conXzSchool_Ps.UpdUserId] = objInFor[conXzSchool_Ps.UpdUserId];
objDR[conXzSchool_Ps.Memo] = objInFor[conXzSchool_Ps.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学校_Ps(XzSchool_Ps)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4XzSchool_Ps : clsCommFun4BL
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
clsXzSchool_PsWApi.ReFreshThisCache();
}
}

}