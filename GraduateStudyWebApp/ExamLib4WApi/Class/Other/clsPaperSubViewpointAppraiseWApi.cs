
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPaperSubViewpointAppraiseWApi
 表名:PaperSubViewpointAppraise(01120561)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:08
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他
 模块英文名:Other
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
public static class clsPaperSubViewpointAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetPaperSubViewpointAppraiseId(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, long lngPaperSubViewpointAppraiseId, string strComparisonOp="")
	{
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = lngPaperSubViewpointAppraiseId; //子观点评价Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetAppraiseScore(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, float fltAppraiseScore, string strComparisonOp="")
	{
objPaperSubViewpointAppraiseEN.AppraiseScore = fltAppraiseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.AppraiseScore) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.AppraiseScore, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseScore] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetAppraiseContent(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, conPaperSubViewpointAppraise.AppraiseContent);
objPaperSubViewpointAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.AppraiseContent) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.AppraiseContent, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseContent] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetUpdDate(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPaperSubViewpointAppraise.UpdDate);
objPaperSubViewpointAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.UpdDate) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.UpdDate, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdDate] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetMeno(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strMeno, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMeno, 2000, conPaperSubViewpointAppraise.Meno);
objPaperSubViewpointAppraiseEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.Meno) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.Meno, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.Meno] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetSubViewpointId(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, long lngSubViewpointId, string strComparisonOp="")
	{
objPaperSubViewpointAppraiseEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.SubViewpointId) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.SubViewpointId, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.SubViewpointId] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPaperSubViewpointAppraiseEN SetUpdUser(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conPaperSubViewpointAppraise.UpdUser);
objPaperSubViewpointAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(conPaperSubViewpointAppraise.UpdUser) == false)
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(conPaperSubViewpointAppraise.UpdUser, strComparisonOp);
}
else
{
objPaperSubViewpointAppraiseEN.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdUser] = strComparisonOp;
}
}
return objPaperSubViewpointAppraiseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPaperSubViewpointAppraise_Cond.IsUpdated(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == true)
{
string strComparisonOp_PaperSubViewpointAppraiseId = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, objPaperSubViewpointAppraise_Cond.PaperSubViewpointAppraiseId, strComparisonOp_PaperSubViewpointAppraiseId);
}
if (objPaperSubViewpointAppraise_Cond.IsUpdated(conPaperSubViewpointAppraise.AppraiseScore) == true)
{
string strComparisonOp_AppraiseScore = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseScore];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpointAppraise.AppraiseScore, objPaperSubViewpointAppraise_Cond.AppraiseScore, strComparisonOp_AppraiseScore);
}
if (objPaperSubViewpointAppraise_Cond.IsUpdated(conPaperSubViewpointAppraise.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[conPaperSubViewpointAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.AppraiseContent, objPaperSubViewpointAppraise_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objPaperSubViewpointAppraise_Cond.IsUpdated(conPaperSubViewpointAppraise.UpdDate) == true)
{
string strComparisonOp_UpdDate = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.UpdDate, objPaperSubViewpointAppraise_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objPaperSubViewpointAppraise_Cond.IsUpdated(conPaperSubViewpointAppraise.Meno) == true)
{
string strComparisonOp_Meno = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[conPaperSubViewpointAppraise.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.Meno, objPaperSubViewpointAppraise_Cond.Meno, strComparisonOp_Meno);
}
if (objPaperSubViewpointAppraise_Cond.IsUpdated(conPaperSubViewpointAppraise.SubViewpointId) == true)
{
string strComparisonOp_SubViewpointId = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[conPaperSubViewpointAppraise.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", conPaperSubViewpointAppraise.SubViewpointId, objPaperSubViewpointAppraise_Cond.SubViewpointId, strComparisonOp_SubViewpointId);
}
if (objPaperSubViewpointAppraise_Cond.IsUpdated(conPaperSubViewpointAppraise.UpdUser) == true)
{
string strComparisonOp_UpdUser = objPaperSubViewpointAppraise_Cond.dicFldComparisonOp[conPaperSubViewpointAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPaperSubViewpointAppraise.UpdUser, objPaperSubViewpointAppraise_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
 if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr = objPaperSubViewpointAppraiseEN.getsf_UpdFldSetStr();
clsPaperSubViewpointAppraiseWApi.CheckPropertyNew(objPaperSubViewpointAppraiseEN); 
bool bolResult = clsPaperSubViewpointAppraiseWApi.UpdateRecord(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--PaperSubViewpointAppraise(子观点评论表), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PaperSubViewpointAppraiseId_SuvViewpointId(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPaperSubViewpointAppraiseEN == null) return "";
if (objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
 sbCondition.AppendFormat(" and SubViewpointId = '{0}'", objPaperSubViewpointAppraiseEN.SubViewpointId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperSubViewpointAppraiseId !=  {0}", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
 sbCondition.AppendFormat(" and PaperSubViewpointAppraiseId = '{0}'", objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId);
 sbCondition.AppendFormat(" and SubViewpointId = '{0}'", objPaperSubViewpointAppraiseEN.SubViewpointId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
try
{
clsPaperSubViewpointAppraiseWApi.CheckPropertyNew(objPaperSubViewpointAppraiseEN); 
bool bolResult = clsPaperSubViewpointAppraiseWApi.AddNewRecord(objPaperSubViewpointAppraiseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strWhereCond)
{
try
{
clsPaperSubViewpointAppraiseWApi.CheckPropertyNew(objPaperSubViewpointAppraiseEN); 
bool bolResult = clsPaperSubViewpointAppraiseWApi.UpdateWithCondition(objPaperSubViewpointAppraiseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseWApi.ReFreshCache();
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
 /// 子观点评论表(PaperSubViewpointAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPaperSubViewpointAppraiseWApi
{
private static readonly string mstrApiControllerName = "PaperSubViewpointAppraiseApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsPaperSubViewpointAppraiseWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
if (!Object.Equals(null, objPaperSubViewpointAppraiseEN.AppraiseContent) && GetStrLen(objPaperSubViewpointAppraiseEN.AppraiseContent) > 2000)
{
 throw new Exception("字段[评议内容]的长度不能超过2000!");
}
if (!Object.Equals(null, objPaperSubViewpointAppraiseEN.UpdDate) && GetStrLen(objPaperSubViewpointAppraiseEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objPaperSubViewpointAppraiseEN.Meno) && GetStrLen(objPaperSubViewpointAppraiseEN.Meno) > 2000)
{
 throw new Exception("字段[备注]的长度不能超过2000!");
}
if (!Object.Equals(null, objPaperSubViewpointAppraiseEN.UpdUser) && GetStrLen(objPaperSubViewpointAppraiseEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
 objPaperSubViewpointAppraiseEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId(long lngPaperSubViewpointAppraiseId)
{
string strAction = "GetObjByPaperSubViewpointAppraiseId";
string strErrMsg = string.Empty;
string strResult = "";
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointAppraiseId"] = lngPaperSubViewpointAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPaperSubViewpointAppraiseEN = JsonConvert.DeserializeObject<clsPaperSubViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objPaperSubViewpointAppraiseEN;
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
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId_WA_Cache(long lngPaperSubViewpointAppraiseId)
{
string strAction = "GetObjByPaperSubViewpointAppraiseId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointAppraiseId"] = lngPaperSubViewpointAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPaperSubViewpointAppraiseEN = JsonConvert.DeserializeObject<clsPaperSubViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objPaperSubViewpointAppraiseEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsPaperSubViewpointAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = null;
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
objPaperSubViewpointAppraiseEN = JsonConvert.DeserializeObject<clsPaperSubViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objPaperSubViewpointAppraiseEN;
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
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId_Cache(long lngPaperSubViewpointAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName_S);
List<clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLst_Sel =
from objPaperSubViewpointAppraiseEN in arrPaperSubViewpointAppraiseObjLst_Cache
where objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId
select objPaperSubViewpointAppraiseEN;
if (arrPaperSubViewpointAppraiseObjLst_Sel.Count() == 0)
{
   clsPaperSubViewpointAppraiseEN obj = clsPaperSubViewpointAppraiseWApi.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPaperSubViewpointAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst(List<long> arrPaperSubViewpointAppraiseId)
{
 List<clsPaperSubViewpointAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperSubViewpointAppraiseIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperSubViewpointAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst_Cache(List<long> arrPaperSubViewpointAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName_S);
List<clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLst_Sel =
from objPaperSubViewpointAppraiseEN in arrPaperSubViewpointAppraiseObjLst_Cache
where arrPaperSubViewpointAppraiseId.Contains(objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId)
select objPaperSubViewpointAppraiseEN;
return arrPaperSubViewpointAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst_WA_Cache(List<long> arrPaperSubViewpointAppraiseId)
{
 List<clsPaperSubViewpointAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperSubViewpointAppraiseIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperSubViewpointAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPaperSubViewpointAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPaperSubViewpointAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngPaperSubViewpointAppraiseId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN = clsPaperSubViewpointAppraiseWApi.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngPaperSubViewpointAppraiseId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPaperSubViewpointAppraiseWApi.ReFreshCache();
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
public static int DelPaperSubViewpointAppraises(List<string> arrPaperSubViewpointAppraiseId)
{
string strAction = "DelPaperSubViewpointAppraises";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperSubViewpointAppraiseId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPaperSubViewpointAppraiseWApi.ReFreshCache();
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
public static int DelPaperSubViewpointAppraisesByCond(string strWhereCond)
{
string strAction = "DelPaperSubViewpointAppraisesByCond";
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
public static bool AddNewRecord(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPaperSubViewpointAppraiseEN>(objPaperSubViewpointAppraiseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objPaperSubViewpointAppraiseEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPaperSubViewpointAppraiseEN>(objPaperSubViewpointAppraiseEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPaperSubViewpointAppraiseWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN)
{
if (string.IsNullOrEmpty(objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPaperSubViewpointAppraiseEN>(objPaperSubViewpointAppraiseEN);
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
 /// <param name = "objPaperSubViewpointAppraiseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPaperSubViewpointAppraiseEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPaperSubViewpointAppraiseEN>(objPaperSubViewpointAppraiseEN);
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
public static bool IsExist(long lngPaperSubViewpointAppraiseId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointAppraiseId"] = lngPaperSubViewpointAppraiseId.ToString()
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
 /// <param name = "objPaperSubViewpointAppraiseENS">源对象</param>
 /// <param name = "objPaperSubViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENS, clsPaperSubViewpointAppraiseEN objPaperSubViewpointAppraiseENT)
{
try
{
objPaperSubViewpointAppraiseENT.PaperSubViewpointAppraiseId = objPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId; //子观点评价Id
objPaperSubViewpointAppraiseENT.AppraiseScore = objPaperSubViewpointAppraiseENS.AppraiseScore; //打分
objPaperSubViewpointAppraiseENT.AppraiseContent = objPaperSubViewpointAppraiseENS.AppraiseContent; //评议内容
objPaperSubViewpointAppraiseENT.UpdDate = objPaperSubViewpointAppraiseENS.UpdDate; //修改日期
objPaperSubViewpointAppraiseENT.Meno = objPaperSubViewpointAppraiseENS.Meno; //备注
objPaperSubViewpointAppraiseENT.SubViewpointId = objPaperSubViewpointAppraiseENS.SubViewpointId; //子观点Id
objPaperSubViewpointAppraiseENT.UpdUser = objPaperSubViewpointAppraiseENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsPaperSubViewpointAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPaperSubViewpointAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPaperSubViewpointAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPaperSubViewpointAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPaperSubViewpointAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPaperSubViewpointAppraiseEN.AttributeName)
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
if (clsPaperSubViewpointAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointAppraiseWApi没有刷新缓存机制(clsPaperSubViewpointAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubViewpointAppraiseId");
//if (arrPaperSubViewpointAppraiseObjLst_Cache == null)
//{
//arrPaperSubViewpointAppraiseObjLst_Cache = await clsPaperSubViewpointAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName_S);
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
if (clsPaperSubViewpointAppraiseWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsPaperSubViewpointAppraiseWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPaperSubViewpointAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsPaperSubViewpointAppraiseEN._CurrTabName_S);
List<clsPaperSubViewpointAppraiseEN> arrPaperSubViewpointAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPaperSubViewpointAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPaperSubViewpointAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, Type.GetType("System.Int64"));
objDT.Columns.Add(conPaperSubViewpointAppraise.AppraiseScore, Type.GetType("System.Single"));
objDT.Columns.Add(conPaperSubViewpointAppraise.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(conPaperSubViewpointAppraise.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conPaperSubViewpointAppraise.Meno, Type.GetType("System.String"));
objDT.Columns.Add(conPaperSubViewpointAppraise.SubViewpointId, Type.GetType("System.Int64"));
objDT.Columns.Add(conPaperSubViewpointAppraise.UpdUser, Type.GetType("System.String"));
foreach (clsPaperSubViewpointAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId] = objInFor[conPaperSubViewpointAppraise.PaperSubViewpointAppraiseId];
objDR[conPaperSubViewpointAppraise.AppraiseScore] = objInFor[conPaperSubViewpointAppraise.AppraiseScore];
objDR[conPaperSubViewpointAppraise.AppraiseContent] = objInFor[conPaperSubViewpointAppraise.AppraiseContent];
objDR[conPaperSubViewpointAppraise.UpdDate] = objInFor[conPaperSubViewpointAppraise.UpdDate];
objDR[conPaperSubViewpointAppraise.Meno] = objInFor[conPaperSubViewpointAppraise.Meno];
objDR[conPaperSubViewpointAppraise.SubViewpointId] = objInFor[conPaperSubViewpointAppraise.SubViewpointId];
objDR[conPaperSubViewpointAppraise.UpdUser] = objInFor[conPaperSubViewpointAppraise.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 子观点评论表(PaperSubViewpointAppraise)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4PaperSubViewpointAppraise : clsCommFun4BL
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
clsPaperSubViewpointAppraiseWApi.ReFreshThisCache();
clsvPaperSubViewpointAppraiseWApi.ReFreshThisCache();
}
}

}