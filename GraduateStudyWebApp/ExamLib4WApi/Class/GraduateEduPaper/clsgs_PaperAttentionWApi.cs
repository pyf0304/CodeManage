
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperAttentionWApi
 表名:gs_PaperAttention(01120748)
 生成代码版本:2021.08.17.1
 生成日期:2021/08/20 02:36:07
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:WA_访问层(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
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
public static class clsgs_PaperAttentionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperAttentionEN SetPaperAttentionId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, long lngPaperAttentionId, string strComparisonOp="")
	{
objgs_PaperAttentionEN.PaperAttentionId = lngPaperAttentionId; //论文收藏Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.PaperAttentionId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.PaperAttentionId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.PaperAttentionId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperAttentionEN SetPaperId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_PaperAttention.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_PaperAttention.PaperId);
objgs_PaperAttentionEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.PaperId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.PaperId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.PaperId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperAttentionEN SetUserId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, congs_PaperAttention.UserId);
objgs_PaperAttentionEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.UserId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.UserId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.UserId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperAttentionEN SetPaperGroupId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strPaperGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperGroupId, 8, congs_PaperAttention.PaperGroupId);
clsCheckSql.CheckFieldForeignKey(strPaperGroupId, 8, congs_PaperAttention.PaperGroupId);
objgs_PaperAttentionEN.PaperGroupId = strPaperGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.PaperGroupId) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.PaperGroupId, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.PaperGroupId] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperAttentionEN SetUpdUser(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, congs_PaperAttention.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_PaperAttention.UpdUser);
objgs_PaperAttentionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.UpdUser) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.UpdUser, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.UpdUser] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperAttentionEN SetUpdDate(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_PaperAttention.UpdDate);
objgs_PaperAttentionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.UpdDate) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.UpdDate, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.UpdDate] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsgs_PaperAttentionEN SetMeno(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strMeno, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMeno, 2000, congs_PaperAttention.Meno);
objgs_PaperAttentionEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperAttentionEN.dicFldComparisonOp.ContainsKey(congs_PaperAttention.Meno) == false)
{
objgs_PaperAttentionEN.dicFldComparisonOp.Add(congs_PaperAttention.Meno, strComparisonOp);
}
else
{
objgs_PaperAttentionEN.dicFldComparisonOp[congs_PaperAttention.Meno] = strComparisonOp;
}
}
return objgs_PaperAttentionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_PaperAttentionEN objgs_PaperAttention_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperAttention_Cond.IsUpdated(congs_PaperAttention.PaperAttentionId) == true)
{
string strComparisonOp_PaperAttentionId = objgs_PaperAttention_Cond.dicFldComparisonOp[congs_PaperAttention.PaperAttentionId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperAttention.PaperAttentionId, objgs_PaperAttention_Cond.PaperAttentionId, strComparisonOp_PaperAttentionId);
}
if (objgs_PaperAttention_Cond.IsUpdated(congs_PaperAttention.PaperId) == true)
{
string strComparisonOp_PaperId = objgs_PaperAttention_Cond.dicFldComparisonOp[congs_PaperAttention.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.PaperId, objgs_PaperAttention_Cond.PaperId, strComparisonOp_PaperId);
}
if (objgs_PaperAttention_Cond.IsUpdated(congs_PaperAttention.UserId) == true)
{
string strComparisonOp_UserId = objgs_PaperAttention_Cond.dicFldComparisonOp[congs_PaperAttention.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.UserId, objgs_PaperAttention_Cond.UserId, strComparisonOp_UserId);
}
if (objgs_PaperAttention_Cond.IsUpdated(congs_PaperAttention.PaperGroupId) == true)
{
string strComparisonOp_PaperGroupId = objgs_PaperAttention_Cond.dicFldComparisonOp[congs_PaperAttention.PaperGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.PaperGroupId, objgs_PaperAttention_Cond.PaperGroupId, strComparisonOp_PaperGroupId);
}
if (objgs_PaperAttention_Cond.IsUpdated(congs_PaperAttention.UpdUser) == true)
{
string strComparisonOp_UpdUser = objgs_PaperAttention_Cond.dicFldComparisonOp[congs_PaperAttention.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.UpdUser, objgs_PaperAttention_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objgs_PaperAttention_Cond.IsUpdated(congs_PaperAttention.UpdDate) == true)
{
string strComparisonOp_UpdDate = objgs_PaperAttention_Cond.dicFldComparisonOp[congs_PaperAttention.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.UpdDate, objgs_PaperAttention_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objgs_PaperAttention_Cond.IsUpdated(congs_PaperAttention.Meno) == true)
{
string strComparisonOp_Meno = objgs_PaperAttention_Cond.dicFldComparisonOp[congs_PaperAttention.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperAttention.Meno, objgs_PaperAttention_Cond.Meno, strComparisonOp_Meno);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
 if (objgs_PaperAttentionEN.PaperAttentionId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objgs_PaperAttentionEN.sf_UpdFldSetStr = objgs_PaperAttentionEN.getsf_UpdFldSetStr();
clsgs_PaperAttentionWApi.CheckPropertyNew(objgs_PaperAttentionEN); 
bool bolResult = clsgs_PaperAttentionWApi.UpdateRecord(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionWApi.ReFreshCache(objgs_PaperAttentionEN.UserId);
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
 /// 检查唯一性(Uniqueness)--gs_PaperAttention(论文关注), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PaperId_UserId(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperAttentionEN == null) return "";
if (objgs_PaperAttentionEN.PaperAttentionId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_PaperAttentionEN.PaperId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objgs_PaperAttentionEN.UserId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PaperAttentionId !=  {0}", objgs_PaperAttentionEN.PaperAttentionId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objgs_PaperAttentionEN.PaperId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objgs_PaperAttentionEN.UserId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_PaperAttentionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
try
{
clsgs_PaperAttentionWApi.CheckPropertyNew(objgs_PaperAttentionEN); 
bool bolResult = clsgs_PaperAttentionWApi.AddNewRecord(objgs_PaperAttentionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionWApi.ReFreshCache(objgs_PaperAttentionEN.UserId);
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
 /// <param name = "objgs_PaperAttentionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strWhereCond)
{
try
{
clsgs_PaperAttentionWApi.CheckPropertyNew(objgs_PaperAttentionEN); 
bool bolResult = clsgs_PaperAttentionWApi.UpdateWithCondition(objgs_PaperAttentionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionWApi.ReFreshCache(objgs_PaperAttentionEN.UserId);
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
 /// 论文关注(gs_PaperAttention)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsgs_PaperAttentionWApi
{
private static readonly string mstrApiControllerName = "gs_PaperAttentionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsgs_PaperAttentionWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
if (!Object.Equals(null, objgs_PaperAttentionEN.PaperId) && GetStrLen(objgs_PaperAttentionEN.PaperId) > 8)
{
 throw new Exception("字段[论文Id]的长度不能超过8!");
}
if (!Object.Equals(null, objgs_PaperAttentionEN.UserId) && GetStrLen(objgs_PaperAttentionEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objgs_PaperAttentionEN.PaperGroupId) && GetStrLen(objgs_PaperAttentionEN.PaperGroupId) > 8)
{
 throw new Exception("字段[组Id]的长度不能超过8!");
}
if (!Object.Equals(null, objgs_PaperAttentionEN.UpdUser) && GetStrLen(objgs_PaperAttentionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objgs_PaperAttentionEN.UpdDate) && GetStrLen(objgs_PaperAttentionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objgs_PaperAttentionEN.Meno) && GetStrLen(objgs_PaperAttentionEN.Meno) > 2000)
{
 throw new Exception("字段[备注]的长度不能超过2000!");
}
 objgs_PaperAttentionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperAttentionEN GetObjByPaperAttentionId(long lngPaperAttentionId)
{
string strAction = "GetObjByPaperAttentionId";
string strErrMsg = string.Empty;
string strResult = "";
clsgs_PaperAttentionEN objgs_PaperAttentionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAttentionId"] = lngPaperAttentionId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objgs_PaperAttentionEN = JsonConvert.DeserializeObject<clsgs_PaperAttentionEN>((string)jobjReturn["ReturnObj"]);
return objgs_PaperAttentionEN;
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
 /// <param name = "lngPaperAttentionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperAttentionEN GetObjByPaperAttentionId_WA_Cache(long lngPaperAttentionId, string strUserId)
{
string strAction = "GetObjByPaperAttentionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsgs_PaperAttentionEN objgs_PaperAttentionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAttentionId"] = lngPaperAttentionId.ToString(),
["UserId"] = strUserId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objgs_PaperAttentionEN = JsonConvert.DeserializeObject<clsgs_PaperAttentionEN>((string)jobjReturn["ReturnObj"]);
return objgs_PaperAttentionEN;
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
public static clsgs_PaperAttentionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsgs_PaperAttentionEN objgs_PaperAttentionEN = null;
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
objgs_PaperAttentionEN = JsonConvert.DeserializeObject<clsgs_PaperAttentionEN>((string)jobjReturn["ReturnObj"]);
return objgs_PaperAttentionEN;
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperAttentionEN GetObjByPaperAttentionId_Cache(long lngPaperAttentionId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName_S, strUserId);
List<clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLst_Cache = GetObjLst_Cache(strUserId);
IEnumerable <clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLst_Sel =
from objgs_PaperAttentionEN in arrgs_PaperAttentionObjLst_Cache
where objgs_PaperAttentionEN.PaperAttentionId == lngPaperAttentionId
select objgs_PaperAttentionEN;
if (arrgs_PaperAttentionObjLst_Sel.Count() == 0)
{
   clsgs_PaperAttentionEN obj = clsgs_PaperAttentionWApi.GetObjByPaperAttentionId(lngPaperAttentionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrgs_PaperAttentionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLst(string strWhereCond)
{
 List<clsgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst(List<long> arrPaperAttentionId)
{
 List<clsgs_PaperAttentionEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperAttentionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperAttentionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPaperAttentionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst_Cache(List<long> arrPaperAttentionId, string strUserId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName_S, strUserId);
List<clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLst_Cache = GetObjLst_Cache(strUserId);
IEnumerable <clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLst_Sel =
from objgs_PaperAttentionEN in arrgs_PaperAttentionObjLst_Cache
where arrPaperAttentionId.Contains(objgs_PaperAttentionEN.PaperAttentionId)
select objgs_PaperAttentionEN;
return arrgs_PaperAttentionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLstByPaperAttentionIdLst_WA_Cache(List<long> arrPaperAttentionId, string strUserId)
{
 List<clsgs_PaperAttentionEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperAttentionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["UserId"] = strUserId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperAttentionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperAttentionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperAttentionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperAttentionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsgs_PaperAttentionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsgs_PaperAttentionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsgs_PaperAttentionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngPaperAttentionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsgs_PaperAttentionEN objgs_PaperAttentionEN = clsgs_PaperAttentionWApi.GetObjByPaperAttentionId(lngPaperAttentionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngPaperAttentionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsgs_PaperAttentionWApi.ReFreshCache(objgs_PaperAttentionEN.UserId);
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
public static int Delgs_PaperAttentions(List<string> arrPaperAttentionId)
{
string strAction = "Delgs_PaperAttentions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperAttentionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsgs_PaperAttentionEN objgs_PaperAttentionEN = clsgs_PaperAttentionWApi.GetObjByPaperAttentionId(long.Parse(arrPaperAttentionId[0]));
clsgs_PaperAttentionWApi.ReFreshCache(objgs_PaperAttentionEN.UserId);
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
public static int Delgs_PaperAttentionsByCond(string strWhereCond)
{
string strAction = "Delgs_PaperAttentionsByCond";
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
public static bool AddNewRecord(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperAttentionEN>(objgs_PaperAttentionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionWApi.ReFreshCache(objgs_PaperAttentionEN.UserId);
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
 /// <param name = "objgs_PaperAttentionEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperAttentionEN>(objgs_PaperAttentionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperAttentionWApi.ReFreshCache(objgs_PaperAttentionEN.UserId);
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
public static bool UpdateRecord(clsgs_PaperAttentionEN objgs_PaperAttentionEN)
{
if (string.IsNullOrEmpty(objgs_PaperAttentionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objgs_PaperAttentionEN.PaperAttentionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperAttentionEN>(objgs_PaperAttentionEN);
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
 /// <param name = "objgs_PaperAttentionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsgs_PaperAttentionEN objgs_PaperAttentionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objgs_PaperAttentionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objgs_PaperAttentionEN.PaperAttentionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objgs_PaperAttentionEN.PaperAttentionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsgs_PaperAttentionEN>(objgs_PaperAttentionEN);
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
public static bool IsExist(long lngPaperAttentionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAttentionId"] = lngPaperAttentionId.ToString()
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
 /// <param name = "objgs_PaperAttentionENS">源对象</param>
 /// <param name = "objgs_PaperAttentionENT">目标对象</param>
 public static void CopyTo(clsgs_PaperAttentionEN objgs_PaperAttentionENS, clsgs_PaperAttentionEN objgs_PaperAttentionENT)
{
try
{
objgs_PaperAttentionENT.PaperAttentionId = objgs_PaperAttentionENS.PaperAttentionId; //论文收藏Id
objgs_PaperAttentionENT.PaperId = objgs_PaperAttentionENS.PaperId; //论文Id
objgs_PaperAttentionENT.UserId = objgs_PaperAttentionENS.UserId; //用户ID
objgs_PaperAttentionENT.PaperGroupId = objgs_PaperAttentionENS.PaperGroupId; //组Id
objgs_PaperAttentionENT.UpdUser = objgs_PaperAttentionENS.UpdUser; //修改人
objgs_PaperAttentionENT.UpdDate = objgs_PaperAttentionENS.UpdDate; //修改日期
objgs_PaperAttentionENT.Meno = objgs_PaperAttentionENS.Meno; //备注
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
public static DataTable ToDataTable(List<clsgs_PaperAttentionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsgs_PaperAttentionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsgs_PaperAttentionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsgs_PaperAttentionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsgs_PaperAttentionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsgs_PaperAttentionEN.AttributeName)
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
if (clsgs_PaperAttentionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperAttentionWApi没有刷新缓存机制(clsgs_PaperAttentionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperAttentionId");
//if (arrgs_PaperAttentionObjLst_Cache == null)
//{
//arrgs_PaperAttentionObjLst_Cache = await clsgs_PaperAttentionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName_S, strUserId);
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
public static void ReFreshCache(string strUserId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsgs_PaperAttentionWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName_S, strUserId);
CacheHelper.Remove(strKey);
clsgs_PaperAttentionWApi.objCommFun4BL.ReFreshCache(strUserId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperAttentionEN> GetObjLst_Cache(string strUserId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsgs_PaperAttentionEN._CurrTabName_S, strUserId);
List<clsgs_PaperAttentionEN> arrgs_PaperAttentionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("UserId='{0}'", strUserId)); });
return arrgs_PaperAttentionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsgs_PaperAttentionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(congs_PaperAttention.PaperAttentionId, Type.GetType("System.Int64"));
objDT.Columns.Add(congs_PaperAttention.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperAttention.UserId, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperAttention.PaperGroupId, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperAttention.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperAttention.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(congs_PaperAttention.Meno, Type.GetType("System.String"));
foreach (clsgs_PaperAttentionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[congs_PaperAttention.PaperAttentionId] = objInFor[congs_PaperAttention.PaperAttentionId];
objDR[congs_PaperAttention.PaperId] = objInFor[congs_PaperAttention.PaperId];
objDR[congs_PaperAttention.UserId] = objInFor[congs_PaperAttention.UserId];
objDR[congs_PaperAttention.PaperGroupId] = objInFor[congs_PaperAttention.PaperGroupId];
objDR[congs_PaperAttention.UpdUser] = objInFor[congs_PaperAttention.UpdUser];
objDR[congs_PaperAttention.UpdDate] = objInFor[congs_PaperAttention.UpdDate];
objDR[congs_PaperAttention.Meno] = objInFor[congs_PaperAttention.Meno];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 论文关注(gs_PaperAttention)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4gs_PaperAttention : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strUserId)
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
clsgs_PaperAttentionWApi.ReFreshThisCache(strUserId);
clsvgs_PaperAttentionWApi.ReFreshThisCache(strUserId);
}
}

}