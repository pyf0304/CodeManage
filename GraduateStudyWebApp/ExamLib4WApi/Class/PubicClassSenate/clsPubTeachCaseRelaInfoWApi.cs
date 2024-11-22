
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubTeachCaseRelaInfoWApi
 表名:PubTeachCaseRelaInfo(01120409)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:49
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩
 模块英文名:PubicClassSenate
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
public static class clsPubTeachCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubTeachCaseRelaInfoEN Setid_PubTeachCaseRelaInfo(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, long lngid_PubTeachCaseRelaInfo, string strComparisonOp="")
	{
objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo = lngid_PubTeachCaseRelaInfo; //公开课案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo) == false)
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo, strComparisonOp);
}
else
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo] = strComparisonOp;
}
}
return objPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubTeachCaseRelaInfoEN Setid_PubClassCase(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, string strid_PubClassCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubClassCase, conPubTeachCaseRelaInfo.id_PubClassCase);
clsCheckSql.CheckFieldLen(strid_PubClassCase, 8, conPubTeachCaseRelaInfo.id_PubClassCase);
clsCheckSql.CheckFieldForeignKey(strid_PubClassCase, 8, conPubTeachCaseRelaInfo.id_PubClassCase);
objPubTeachCaseRelaInfoEN.id_PubClassCase = strid_PubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conPubTeachCaseRelaInfo.id_PubClassCase) == false)
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conPubTeachCaseRelaInfo.id_PubClassCase, strComparisonOp);
}
else
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_PubClassCase] = strComparisonOp;
}
}
return objPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubTeachCaseRelaInfoEN Setid_PubTeachCaseRelaInfoType(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, string strid_PubTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_PubTeachCaseRelaInfoType, conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(strid_PubTeachCaseRelaInfoType, 4, conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_PubTeachCaseRelaInfoType, 4, conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType);
objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfoType = strid_PubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType) == false)
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubTeachCaseRelaInfoEN Setid_Resource(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, conPubTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, conPubTeachCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, conPubTeachCaseRelaInfo.id_Resource);
objPubTeachCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conPubTeachCaseRelaInfo.id_Resource) == false)
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conPubTeachCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubTeachCaseRelaInfoEN SetIsVisible(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objPubTeachCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conPubTeachCaseRelaInfo.IsVisible) == false)
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conPubTeachCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp[conPubTeachCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubTeachCaseRelaInfoEN SetMemo(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPubTeachCaseRelaInfo.Memo);
objPubTeachCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conPubTeachCaseRelaInfo.Memo) == false)
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conPubTeachCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp[conPubTeachCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objPubTeachCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsPubTeachCaseRelaInfoEN SetBrowseCount(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objPubTeachCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubTeachCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(conPubTeachCaseRelaInfo.BrowseCount) == false)
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp.Add(conPubTeachCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objPubTeachCaseRelaInfoEN.dicFldComparisonOp[conPubTeachCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objPubTeachCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubTeachCaseRelaInfo_Cond.IsUpdated(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_PubTeachCaseRelaInfo = objPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo, objPubTeachCaseRelaInfo_Cond.id_PubTeachCaseRelaInfo, strComparisonOp_id_PubTeachCaseRelaInfo);
}
if (objPubTeachCaseRelaInfo_Cond.IsUpdated(conPubTeachCaseRelaInfo.id_PubClassCase) == true)
{
string strComparisonOp_id_PubClassCase = objPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_PubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubTeachCaseRelaInfo.id_PubClassCase, objPubTeachCaseRelaInfo_Cond.id_PubClassCase, strComparisonOp_id_PubClassCase);
}
if (objPubTeachCaseRelaInfo_Cond.IsUpdated(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_PubTeachCaseRelaInfoType = objPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType, objPubTeachCaseRelaInfo_Cond.id_PubTeachCaseRelaInfoType, strComparisonOp_id_PubTeachCaseRelaInfoType);
}
if (objPubTeachCaseRelaInfo_Cond.IsUpdated(conPubTeachCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[conPubTeachCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubTeachCaseRelaInfo.id_Resource, objPubTeachCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objPubTeachCaseRelaInfo_Cond.IsUpdated(conPubTeachCaseRelaInfo.IsVisible) == true)
{
if (objPubTeachCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubTeachCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubTeachCaseRelaInfo.IsVisible);
}
}
if (objPubTeachCaseRelaInfo_Cond.IsUpdated(conPubTeachCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[conPubTeachCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubTeachCaseRelaInfo.Memo, objPubTeachCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
if (objPubTeachCaseRelaInfo_Cond.IsUpdated(conPubTeachCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objPubTeachCaseRelaInfo_Cond.dicFldComparisonOp[conPubTeachCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubTeachCaseRelaInfo.BrowseCount, objPubTeachCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN)
{
 if (objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objPubTeachCaseRelaInfoEN.sf_UpdFldSetStr = objPubTeachCaseRelaInfoEN.getsf_UpdFldSetStr();
clsPubTeachCaseRelaInfoWApi.CheckPropertyNew(objPubTeachCaseRelaInfoEN); 
bool bolResult = clsPubTeachCaseRelaInfoWApi.UpdateRecord(objPubTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubTeachCaseRelaInfoWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--PubTeachCaseRelaInfo(公开课案例相关信息), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_PubClassCase_id_Resource(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objPubTeachCaseRelaInfoEN == null) return "";
if (objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_PubClassCase = '{0}'", objPubTeachCaseRelaInfoEN.id_PubClassCase);
 sbCondition.AppendFormat(" and id_Resource = '{0}'", objPubTeachCaseRelaInfoEN.id_Resource);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_PubTeachCaseRelaInfo !=  {0}", objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo);
 sbCondition.AppendFormat(" and id_PubClassCase = '{0}'", objPubTeachCaseRelaInfoEN.id_PubClassCase);
 sbCondition.AppendFormat(" and id_Resource = '{0}'", objPubTeachCaseRelaInfoEN.id_Resource);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubTeachCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN)
{
try
{
clsPubTeachCaseRelaInfoWApi.CheckPropertyNew(objPubTeachCaseRelaInfoEN); 
bool bolResult = clsPubTeachCaseRelaInfoWApi.AddNewRecord(objPubTeachCaseRelaInfoEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubTeachCaseRelaInfoWApi.ReFreshCache();
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
 /// <param name = "objPubTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, string strWhereCond)
{
try
{
clsPubTeachCaseRelaInfoWApi.CheckPropertyNew(objPubTeachCaseRelaInfoEN); 
bool bolResult = clsPubTeachCaseRelaInfoWApi.UpdateWithCondition(objPubTeachCaseRelaInfoEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubTeachCaseRelaInfoWApi.ReFreshCache();
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
 /// 公开课案例相关信息(PubTeachCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsPubTeachCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "PubTeachCaseRelaInfoApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsPubTeachCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN)
{
if (!Object.Equals(null, objPubTeachCaseRelaInfoEN.id_PubClassCase) && GetStrLen(objPubTeachCaseRelaInfoEN.id_PubClassCase) > 8)
{
 throw new Exception("字段[案例流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfoType) && GetStrLen(objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfoType) > 4)
{
 throw new Exception("字段[公开课案例相关信息类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objPubTeachCaseRelaInfoEN.id_Resource) && GetStrLen(objPubTeachCaseRelaInfoEN.id_Resource) > 8)
{
 throw new Exception("字段[资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objPubTeachCaseRelaInfoEN.Memo) && GetStrLen(objPubTeachCaseRelaInfoEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objPubTeachCaseRelaInfoEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_PubTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubTeachCaseRelaInfoEN GetObjByid_PubTeachCaseRelaInfo(long lngid_PubTeachCaseRelaInfo)
{
string strAction = "GetObjByid_PubTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubTeachCaseRelaInfo"] = lngid_PubTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsPubTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objPubTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_PubTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubTeachCaseRelaInfoEN GetObjByid_PubTeachCaseRelaInfo_WA_Cache(long lngid_PubTeachCaseRelaInfo)
{
string strAction = "GetObjByid_PubTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubTeachCaseRelaInfo"] = lngid_PubTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objPubTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsPubTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objPubTeachCaseRelaInfoEN;
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
public static clsPubTeachCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN = null;
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
objPubTeachCaseRelaInfoEN = JsonConvert.DeserializeObject<clsPubTeachCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objPubTeachCaseRelaInfoEN;
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
 /// <param name = "lngid_PubTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubTeachCaseRelaInfoEN GetObjByid_PubTeachCaseRelaInfo_Cache(long lngid_PubTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPubTeachCaseRelaInfoEN._CurrTabName_S);
List<clsPubTeachCaseRelaInfoEN> arrPubTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubTeachCaseRelaInfoEN> arrPubTeachCaseRelaInfoObjLst_Sel =
from objPubTeachCaseRelaInfoEN in arrPubTeachCaseRelaInfoObjLst_Cache
where objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo == lngid_PubTeachCaseRelaInfo
select objPubTeachCaseRelaInfoEN;
if (arrPubTeachCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsPubTeachCaseRelaInfoEN obj = clsPubTeachCaseRelaInfoWApi.GetObjByid_PubTeachCaseRelaInfo(lngid_PubTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrPubTeachCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubTeachCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubTeachCaseRelaInfoEN> GetObjLstById_PubTeachCaseRelaInfoLst(List<long> arrId_PubTeachCaseRelaInfo)
{
 List<clsPubTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubTeachCaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_PubTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsPubTeachCaseRelaInfoEN> GetObjLstById_PubTeachCaseRelaInfoLst_Cache(List<long> arrId_PubTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsPubTeachCaseRelaInfoEN._CurrTabName_S);
List<clsPubTeachCaseRelaInfoEN> arrPubTeachCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsPubTeachCaseRelaInfoEN> arrPubTeachCaseRelaInfoObjLst_Sel =
from objPubTeachCaseRelaInfoEN in arrPubTeachCaseRelaInfoObjLst_Cache
where arrId_PubTeachCaseRelaInfo.Contains(objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo)
select objPubTeachCaseRelaInfoEN;
return arrPubTeachCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubTeachCaseRelaInfoEN> GetObjLstById_PubTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_PubTeachCaseRelaInfo)
{
 List<clsPubTeachCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_PubTeachCaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PubTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubTeachCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubTeachCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubTeachCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsPubTeachCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsPubTeachCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsPubTeachCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_PubTeachCaseRelaInfo)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN = clsPubTeachCaseRelaInfoWApi.GetObjByid_PubTeachCaseRelaInfo(lngid_PubTeachCaseRelaInfo);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_PubTeachCaseRelaInfo.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubTeachCaseRelaInfoWApi.ReFreshCache();
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
public static int DelPubTeachCaseRelaInfos(List<string> arrid_PubTeachCaseRelaInfo)
{
string strAction = "DelPubTeachCaseRelaInfos";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_PubTeachCaseRelaInfo);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsPubTeachCaseRelaInfoWApi.ReFreshCache();
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
public static int DelPubTeachCaseRelaInfosByCond(string strWhereCond)
{
string strAction = "DelPubTeachCaseRelaInfosByCond";
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
public static bool AddNewRecord(clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubTeachCaseRelaInfoEN>(objPubTeachCaseRelaInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubTeachCaseRelaInfoWApi.ReFreshCache();
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
 /// <param name = "objPubTeachCaseRelaInfoEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubTeachCaseRelaInfoEN>(objPubTeachCaseRelaInfoEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubTeachCaseRelaInfoWApi.ReFreshCache();
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
public static bool UpdateRecord(clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN)
{
if (string.IsNullOrEmpty(objPubTeachCaseRelaInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubTeachCaseRelaInfoEN>(objPubTeachCaseRelaInfoEN);
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
 /// <param name = "objPubTeachCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objPubTeachCaseRelaInfoEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objPubTeachCaseRelaInfoEN.id_PubTeachCaseRelaInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsPubTeachCaseRelaInfoEN>(objPubTeachCaseRelaInfoEN);
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
public static bool IsExist(long lngid_PubTeachCaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_PubTeachCaseRelaInfo"] = lngid_PubTeachCaseRelaInfo.ToString()
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
 /// <param name = "objPubTeachCaseRelaInfoENS">源对象</param>
 /// <param name = "objPubTeachCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoENS, clsPubTeachCaseRelaInfoEN objPubTeachCaseRelaInfoENT)
{
try
{
objPubTeachCaseRelaInfoENT.id_PubTeachCaseRelaInfo = objPubTeachCaseRelaInfoENS.id_PubTeachCaseRelaInfo; //公开课案例相关信息流水号
objPubTeachCaseRelaInfoENT.id_PubClassCase = objPubTeachCaseRelaInfoENS.id_PubClassCase; //案例流水号
objPubTeachCaseRelaInfoENT.id_PubTeachCaseRelaInfoType = objPubTeachCaseRelaInfoENS.id_PubTeachCaseRelaInfoType; //公开课案例相关信息类型流水号
objPubTeachCaseRelaInfoENT.id_Resource = objPubTeachCaseRelaInfoENS.id_Resource; //资源流水号
objPubTeachCaseRelaInfoENT.IsVisible = objPubTeachCaseRelaInfoENS.IsVisible; //是否显示
objPubTeachCaseRelaInfoENT.Memo = objPubTeachCaseRelaInfoENS.Memo; //备注
objPubTeachCaseRelaInfoENT.BrowseCount = objPubTeachCaseRelaInfoENS.BrowseCount; //浏览次数
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
public static DataTable ToDataTable(List<clsPubTeachCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsPubTeachCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsPubTeachCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsPubTeachCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsPubTeachCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsPubTeachCaseRelaInfoEN.AttributeName)
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
if (clsPubTeachCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubTeachCaseRelaInfoWApi没有刷新缓存机制(clsPubTeachCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_PubTeachCaseRelaInfo");
//if (arrPubTeachCaseRelaInfoObjLst_Cache == null)
//{
//arrPubTeachCaseRelaInfoObjLst_Cache = await clsPubTeachCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsPubTeachCaseRelaInfoEN._CurrTabName_S);
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
if (clsPubTeachCaseRelaInfoWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubTeachCaseRelaInfoEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsPubTeachCaseRelaInfoWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubTeachCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsPubTeachCaseRelaInfoEN._CurrTabName_S);
List<clsPubTeachCaseRelaInfoEN> arrPubTeachCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubTeachCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsPubTeachCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(conPubTeachCaseRelaInfo.id_PubClassCase, Type.GetType("System.String"));
objDT.Columns.Add(conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(conPubTeachCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(conPubTeachCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conPubTeachCaseRelaInfo.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conPubTeachCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
foreach (clsPubTeachCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo] = objInFor[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfo];
objDR[conPubTeachCaseRelaInfo.id_PubClassCase] = objInFor[conPubTeachCaseRelaInfo.id_PubClassCase];
objDR[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType] = objInFor[conPubTeachCaseRelaInfo.id_PubTeachCaseRelaInfoType];
objDR[conPubTeachCaseRelaInfo.id_Resource] = objInFor[conPubTeachCaseRelaInfo.id_Resource];
objDR[conPubTeachCaseRelaInfo.IsVisible] = objInFor[conPubTeachCaseRelaInfo.IsVisible];
objDR[conPubTeachCaseRelaInfo.Memo] = objInFor[conPubTeachCaseRelaInfo.Memo];
objDR[conPubTeachCaseRelaInfo.BrowseCount] = objInFor[conPubTeachCaseRelaInfo.BrowseCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 公开课案例相关信息(PubTeachCaseRelaInfo)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4PubTeachCaseRelaInfo : clsCommFun4BL
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
clsPubTeachCaseRelaInfoWApi.ReFreshThisCache();
}
}

}