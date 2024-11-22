
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorDirectionWApi
 表名:XzMajorDirection(01120552)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:16
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护
 模块英文名:BaseInfo
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
public static class clsXzMajorDirectionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionId(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirectionId, 8, conXzMajorDirection.MajorDirectionId);
clsCheckSql.CheckFieldForeignKey(strMajorDirectionId, 8, conXzMajorDirection.MajorDirectionId);
objXzMajorDirectionEN.MajorDirectionId = strMajorDirectionId; //研究方向Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionId) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionId, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionId] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN Setid_XzMajor(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, conXzMajorDirection.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conXzMajorDirection.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conXzMajorDirection.id_XzMajor);
objXzMajorDirectionEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.id_XzMajor) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.id_XzMajor, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.id_XzMajor] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionName(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorDirectionName, conXzMajorDirection.MajorDirectionName);
clsCheckSql.CheckFieldLen(strMajorDirectionName, 100, conXzMajorDirection.MajorDirectionName);
objXzMajorDirectionEN.MajorDirectionName = strMajorDirectionName; //研究方向名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionName) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionName, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionName] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionENName(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirectionENName, 200, conXzMajorDirection.MajorDirectionENName);
objXzMajorDirectionEN.MajorDirectionENName = strMajorDirectionENName; //研究方向英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionENName) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionENName, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionENName] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetMajorDirectionExplain(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMajorDirectionExplain, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorDirectionExplain, 2000, conXzMajorDirection.MajorDirectionExplain);
objXzMajorDirectionEN.MajorDirectionExplain = strMajorDirectionExplain; //专业方向说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.MajorDirectionExplain) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.MajorDirectionExplain, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.MajorDirectionExplain] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetIsVisible(this clsXzMajorDirectionEN objXzMajorDirectionEN, bool bolIsVisible, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsVisible, conXzMajorDirection.IsVisible);
objXzMajorDirectionEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.IsVisible) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.IsVisible, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.IsVisible] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetUpdDate(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conXzMajorDirection.UpdDate);
objXzMajorDirectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.UpdDate) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.UpdDate, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.UpdDate] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetUpdUser(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conXzMajorDirection.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conXzMajorDirection.UpdUser);
objXzMajorDirectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.UpdUser) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.UpdUser, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.UpdUser] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorDirectionEN SetMemo(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzMajorDirection.Memo);
objXzMajorDirectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorDirectionEN.dicFldComparisonOp.ContainsKey(conXzMajorDirection.Memo) == false)
{
objXzMajorDirectionEN.dicFldComparisonOp.Add(conXzMajorDirection.Memo, strComparisonOp);
}
else
{
objXzMajorDirectionEN.dicFldComparisonOp[conXzMajorDirection.Memo] = strComparisonOp;
}
}
return objXzMajorDirectionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzMajorDirectionEN objXzMajorDirection_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.MajorDirectionId) == true)
{
string strComparisonOp_MajorDirectionId = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionId, objXzMajorDirection_Cond.MajorDirectionId, strComparisonOp_MajorDirectionId);
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.id_XzMajor, objXzMajorDirection_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.MajorDirectionName) == true)
{
string strComparisonOp_MajorDirectionName = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionName, objXzMajorDirection_Cond.MajorDirectionName, strComparisonOp_MajorDirectionName);
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.MajorDirectionENName) == true)
{
string strComparisonOp_MajorDirectionENName = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionENName, objXzMajorDirection_Cond.MajorDirectionENName, strComparisonOp_MajorDirectionENName);
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.MajorDirectionExplain) == true)
{
string strComparisonOp_MajorDirectionExplain = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.MajorDirectionExplain];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.MajorDirectionExplain, objXzMajorDirection_Cond.MajorDirectionExplain, strComparisonOp_MajorDirectionExplain);
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.IsVisible) == true)
{
if (objXzMajorDirection_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajorDirection.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajorDirection.IsVisible);
}
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.UpdDate) == true)
{
string strComparisonOp_UpdDate = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.UpdDate, objXzMajorDirection_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.UpdUser) == true)
{
string strComparisonOp_UpdUser = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.UpdUser, objXzMajorDirection_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objXzMajorDirection_Cond.IsUpdated(conXzMajorDirection.Memo) == true)
{
string strComparisonOp_Memo = objXzMajorDirection_Cond.dicFldComparisonOp[conXzMajorDirection.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajorDirection.Memo, objXzMajorDirection_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzMajorDirectionEN.sf_UpdFldSetStr = objXzMajorDirectionEN.getsf_UpdFldSetStr();
clsXzMajorDirectionWApi.CheckPropertyNew(objXzMajorDirectionEN); 
bool bolResult = clsXzMajorDirectionWApi.UpdateRecord(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--XzMajorDirection(专业方向), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_XzMajor_MajorDirectionName(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorDirectionEN == null) return "";
if (objXzMajorDirectionEN.MajorDirectionId == null || objXzMajorDirectionEN.MajorDirectionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_XzMajor = '{0}'", objXzMajorDirectionEN.id_XzMajor);
 sbCondition.AppendFormat(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.MajorDirectionName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MajorDirectionId !=  '{0}'", objXzMajorDirectionEN.MajorDirectionId);
 sbCondition.AppendFormat(" and id_XzMajor = '{0}'", objXzMajorDirectionEN.id_XzMajor);
 sbCondition.AppendFormat(" and MajorDirectionName = '{0}'", objXzMajorDirectionEN.MajorDirectionName);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
try
{
 if (string.IsNullOrEmpty(objXzMajorDirectionEN.MajorDirectionId) == true || clsXzMajorDirectionWApi.IsExist(objXzMajorDirectionEN.MajorDirectionId) == true)
 {
     objXzMajorDirectionEN.MajorDirectionId = clsXzMajorDirectionWApi.GetMaxStrId();
 }
clsXzMajorDirectionWApi.CheckPropertyNew(objXzMajorDirectionEN); 
bool bolResult = clsXzMajorDirectionWApi.AddNewRecord(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionWApi.ReFreshCache();
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
 /// <param name = "objXzMajorDirectionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzMajorDirectionEN objXzMajorDirectionEN)
{
try
{
clsXzMajorDirectionWApi.CheckPropertyNew(objXzMajorDirectionEN); 
string strMajorDirectionId = clsXzMajorDirectionWApi.AddNewRecordWithMaxId(objXzMajorDirectionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionWApi.ReFreshCache();
return strMajorDirectionId;
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
 /// <param name = "objXzMajorDirectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorDirectionEN objXzMajorDirectionEN, string strWhereCond)
{
try
{
clsXzMajorDirectionWApi.CheckPropertyNew(objXzMajorDirectionEN); 
bool bolResult = clsXzMajorDirectionWApi.UpdateWithCondition(objXzMajorDirectionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionWApi.ReFreshCache();
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
public class enumXzMajorDirectionWA
{
 /// <summary>
 /// testlyl
 /// </summary>
public const string testlyl_00000001 = "00000001";
 /// <summary>
 /// test0118
 /// </summary>
public const string test_00000003 = "00000003";
 /// <summary>
 /// 杨雪姣
 /// </summary>
public const string Lucy_00000004 = "00000004";
 /// <summary>
 /// 信息化教育
 /// </summary>
public const string Information Technology_00000005 = "00000005";
 /// <summary>
 /// 绩效培训
 /// </summary>
public const string _00000006 = "00000006";
 /// <summary>
 /// 网络方向
 /// </summary>
public const string _00000007 = "00000007";
 /// <summary>
 /// 数字媒体
 /// </summary>
public const string _00000008 = "00000008";
 /// <summary>
 /// 自适应学习与个性化学习
 /// </summary>
public const string Adaptive learning and personalized learning_00000009 = "00000009";
}
 /// <summary>
 /// 专业方向(XzMajorDirection)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzMajorDirectionWApi
{
private static readonly string mstrApiControllerName = "XzMajorDirectionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsXzMajorDirectionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_MajorDirectionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业方向]...","0");
List<clsXzMajorDirectionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="MajorDirectionId";
objDDL.DataTextField="MajorDirectionName";
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
public static void BindCbo_MajorDirectionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzMajorDirection.MajorDirectionId); 
List<clsXzMajorDirectionEN> arrObjLst = clsXzMajorDirectionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzMajorDirectionEN objXzMajorDirectionEN = new clsXzMajorDirectionEN()
{
MajorDirectionId = "0",
MajorDirectionName = "选[专业方向]..."
};
arrObjLst.Insert(0, objXzMajorDirectionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzMajorDirection.MajorDirectionId;
objComboBox.DisplayMember = conXzMajorDirection.MajorDirectionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
if (!Object.Equals(null, objXzMajorDirectionEN.MajorDirectionId) && GetStrLen(objXzMajorDirectionEN.MajorDirectionId) > 8)
{
 throw new Exception("字段[研究方向Id]的长度不能超过8!");
}
if (!Object.Equals(null, objXzMajorDirectionEN.id_XzMajor) && GetStrLen(objXzMajorDirectionEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objXzMajorDirectionEN.MajorDirectionName) && GetStrLen(objXzMajorDirectionEN.MajorDirectionName) > 100)
{
 throw new Exception("字段[研究方向名]的长度不能超过100!");
}
if (!Object.Equals(null, objXzMajorDirectionEN.MajorDirectionENName) && GetStrLen(objXzMajorDirectionEN.MajorDirectionENName) > 200)
{
 throw new Exception("字段[研究方向英文名]的长度不能超过200!");
}
if (!Object.Equals(null, objXzMajorDirectionEN.MajorDirectionExplain) && GetStrLen(objXzMajorDirectionEN.MajorDirectionExplain) > 2000)
{
 throw new Exception("字段[专业方向说明]的长度不能超过2000!");
}
if (!Object.Equals(null, objXzMajorDirectionEN.UpdDate) && GetStrLen(objXzMajorDirectionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objXzMajorDirectionEN.UpdUser) && GetStrLen(objXzMajorDirectionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objXzMajorDirectionEN.Memo) && GetStrLen(objXzMajorDirectionEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objXzMajorDirectionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorDirectionEN GetObjByMajorDirectionId(string strMajorDirectionId)
{
string strAction = "GetObjByMajorDirectionId";
string strErrMsg = string.Empty;
string strResult = "";
clsXzMajorDirectionEN objXzMajorDirectionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MajorDirectionId"] = strMajorDirectionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzMajorDirectionEN = JsonConvert.DeserializeObject<clsXzMajorDirectionEN>((string)jobjReturn["ReturnObj"]);
return objXzMajorDirectionEN;
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
 /// <param name = "strMajorDirectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorDirectionEN GetObjByMajorDirectionId_WA_Cache(string strMajorDirectionId)
{
string strAction = "GetObjByMajorDirectionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsXzMajorDirectionEN objXzMajorDirectionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MajorDirectionId"] = strMajorDirectionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzMajorDirectionEN = JsonConvert.DeserializeObject<clsXzMajorDirectionEN>((string)jobjReturn["ReturnObj"]);
return objXzMajorDirectionEN;
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
public static clsXzMajorDirectionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsXzMajorDirectionEN objXzMajorDirectionEN = null;
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
objXzMajorDirectionEN = JsonConvert.DeserializeObject<clsXzMajorDirectionEN>((string)jobjReturn["ReturnObj"]);
return objXzMajorDirectionEN;
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
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzMajorDirectionEN GetObjByMajorDirectionId_Cache(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName_S);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel =
from objXzMajorDirectionEN in arrXzMajorDirectionObjLst_Cache
where objXzMajorDirectionEN.MajorDirectionId == strMajorDirectionId
select objXzMajorDirectionEN;
if (arrXzMajorDirectionObjLst_Sel.Count() == 0)
{
   clsXzMajorDirectionEN obj = clsXzMajorDirectionWApi.GetObjByMajorDirectionId(strMajorDirectionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzMajorDirectionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMajorDirectionNameByMajorDirectionId_Cache(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName_S);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel1 =
from objXzMajorDirectionEN in arrXzMajorDirectionObjLst_Cache
where objXzMajorDirectionEN.MajorDirectionId == strMajorDirectionId
select objXzMajorDirectionEN;
List <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel = new List<clsXzMajorDirectionEN>();
foreach (clsXzMajorDirectionEN obj in arrXzMajorDirectionObjLst_Sel1)
{
arrXzMajorDirectionObjLst_Sel.Add(obj);
}
if (arrXzMajorDirectionObjLst_Sel.Count > 0)
{
return arrXzMajorDirectionObjLst_Sel[0].MajorDirectionName;
}
string strErrMsgForGetObjById = string.Format("在XzMajorDirection对象缓存列表中,找不到记录[MajorDirectionId = {0}](函数:{1})", strMajorDirectionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzMajorDirectionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByMajorDirectionId_Cache(string strMajorDirectionId)
{
if (string.IsNullOrEmpty(strMajorDirectionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName_S);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel1 =
from objXzMajorDirectionEN in arrXzMajorDirectionObjLst_Cache
where objXzMajorDirectionEN.MajorDirectionId == strMajorDirectionId
select objXzMajorDirectionEN;
List <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel = new List<clsXzMajorDirectionEN>();
foreach (clsXzMajorDirectionEN obj in arrXzMajorDirectionObjLst_Sel1)
{
arrXzMajorDirectionObjLst_Sel.Add(obj);
}
if (arrXzMajorDirectionObjLst_Sel.Count > 0)
{
return arrXzMajorDirectionObjLst_Sel[0].MajorDirectionName;
}
string strErrMsgForGetObjById = string.Format("在XzMajorDirection对象缓存列表中,找不到记录的相关名称[MajorDirectionId = {0}](函数:{1})", strMajorDirectionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzMajorDirectionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLst(string strWhereCond)
{
 List<clsXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst(List<string> arrMajorDirectionId)
{
 List<clsXzMajorDirectionEN> arrObjLst = null; 
string strAction = "GetObjLstByMajorDirectionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMajorDirectionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strMajorDirectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst_Cache(List<string> arrMajorDirectionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName_S);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Sel =
from objXzMajorDirectionEN in arrXzMajorDirectionObjLst_Cache
where arrMajorDirectionId.Contains(objXzMajorDirectionEN.MajorDirectionId)
select objXzMajorDirectionEN;
return arrXzMajorDirectionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLstByMajorDirectionIdLst_WA_Cache(List<string> arrMajorDirectionId)
{
 List<clsXzMajorDirectionEN> arrObjLst = null; 
string strAction = "GetObjLstByMajorDirectionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMajorDirectionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorDirectionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorDirectionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorDirectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzMajorDirectionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsXzMajorDirectionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzMajorDirectionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strMajorDirectionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsXzMajorDirectionEN objXzMajorDirectionEN = clsXzMajorDirectionWApi.GetObjByMajorDirectionId(strMajorDirectionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strMajorDirectionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzMajorDirectionWApi.ReFreshCache();
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
public static int DelXzMajorDirections(List<string> arrMajorDirectionId)
{
string strAction = "DelXzMajorDirections";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMajorDirectionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzMajorDirectionWApi.ReFreshCache();
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
public static int DelXzMajorDirectionsByCond(string strWhereCond)
{
string strAction = "DelXzMajorDirectionsByCond";
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
public static bool AddNewRecord(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorDirectionEN>(objXzMajorDirectionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorDirectionEN>(objXzMajorDirectionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorDirectionWApi.ReFreshCache();
var strMajorDirectionId = (string)jobjReturn["ReturnStr"];
return strMajorDirectionId;
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
public static bool UpdateRecord(clsXzMajorDirectionEN objXzMajorDirectionEN)
{
if (string.IsNullOrEmpty(objXzMajorDirectionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzMajorDirectionEN.MajorDirectionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorDirectionEN>(objXzMajorDirectionEN);
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
 /// <param name = "objXzMajorDirectionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzMajorDirectionEN objXzMajorDirectionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzMajorDirectionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzMajorDirectionEN.MajorDirectionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzMajorDirectionEN.MajorDirectionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzMajorDirectionEN>(objXzMajorDirectionEN);
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
public static bool IsExist(string strMajorDirectionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MajorDirectionId"] = strMajorDirectionId
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
 /// <param name = "objXzMajorDirectionENS">源对象</param>
 /// <param name = "objXzMajorDirectionENT">目标对象</param>
 public static void CopyTo(clsXzMajorDirectionEN objXzMajorDirectionENS, clsXzMajorDirectionEN objXzMajorDirectionENT)
{
try
{
objXzMajorDirectionENT.MajorDirectionId = objXzMajorDirectionENS.MajorDirectionId; //研究方向Id
objXzMajorDirectionENT.id_XzMajor = objXzMajorDirectionENS.id_XzMajor; //专业流水号
objXzMajorDirectionENT.MajorDirectionName = objXzMajorDirectionENS.MajorDirectionName; //研究方向名
objXzMajorDirectionENT.MajorDirectionENName = objXzMajorDirectionENS.MajorDirectionENName; //研究方向英文名
objXzMajorDirectionENT.MajorDirectionExplain = objXzMajorDirectionENS.MajorDirectionExplain; //专业方向说明
objXzMajorDirectionENT.IsVisible = objXzMajorDirectionENS.IsVisible; //是否显示
objXzMajorDirectionENT.UpdDate = objXzMajorDirectionENS.UpdDate; //修改日期
objXzMajorDirectionENT.UpdUser = objXzMajorDirectionENS.UpdUser; //修改人
objXzMajorDirectionENT.Memo = objXzMajorDirectionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsXzMajorDirectionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzMajorDirectionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzMajorDirectionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzMajorDirectionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzMajorDirectionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzMajorDirectionEN.AttributeName)
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
if (clsXzMajorDirectionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorDirectionWApi没有刷新缓存机制(clsXzMajorDirectionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MajorDirectionId");
//if (arrXzMajorDirectionObjLst_Cache == null)
//{
//arrXzMajorDirectionObjLst_Cache = await clsXzMajorDirectionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName_S);
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
if (clsXzMajorDirectionWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzMajorDirectionWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorDirectionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsXzMajorDirectionEN._CurrTabName_S);
List<clsXzMajorDirectionEN> arrXzMajorDirectionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzMajorDirectionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzMajorDirectionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzMajorDirection.MajorDirectionId, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajorDirection.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajorDirection.MajorDirectionName, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajorDirection.MajorDirectionENName, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajorDirection.MajorDirectionExplain, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajorDirection.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conXzMajorDirection.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajorDirection.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conXzMajorDirection.Memo, Type.GetType("System.String"));
foreach (clsXzMajorDirectionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzMajorDirection.MajorDirectionId] = objInFor[conXzMajorDirection.MajorDirectionId];
objDR[conXzMajorDirection.id_XzMajor] = objInFor[conXzMajorDirection.id_XzMajor];
objDR[conXzMajorDirection.MajorDirectionName] = objInFor[conXzMajorDirection.MajorDirectionName];
objDR[conXzMajorDirection.MajorDirectionENName] = objInFor[conXzMajorDirection.MajorDirectionENName];
objDR[conXzMajorDirection.MajorDirectionExplain] = objInFor[conXzMajorDirection.MajorDirectionExplain];
objDR[conXzMajorDirection.IsVisible] = objInFor[conXzMajorDirection.IsVisible];
objDR[conXzMajorDirection.UpdDate] = objInFor[conXzMajorDirection.UpdDate];
objDR[conXzMajorDirection.UpdUser] = objInFor[conXzMajorDirection.UpdUser];
objDR[conXzMajorDirection.Memo] = objInFor[conXzMajorDirection.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 专业方向(XzMajorDirection)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4XzMajorDirection : clsCommFun4BL
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
clsXzMajorDirectionWApi.ReFreshThisCache();
clsvXzMajorDirectionWApi.ReFreshThisCache();
}
}

}