
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointAppraiseWApi
 表名:vViewpointAppraise(01120610)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:48
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
public static class clsvViewpointAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetUserName(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convViewpointAppraise.UserName);
objvViewpointAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.UserName) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.UserName, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.UserName] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointAppraiseId(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, long lngViewpointAppraiseId, string strComparisonOp="")
	{
objvViewpointAppraiseEN.ViewpointAppraiseId = lngViewpointAppraiseId; //观点评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointAppraiseId) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointAppraiseId, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointAppraiseId] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointId(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpointAppraise.ViewpointId);
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpointAppraise.ViewpointId);
objvViewpointAppraiseEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointId) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointId, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointId] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetAppraiseContent(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convViewpointAppraise.AppraiseContent);
objvViewpointAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.AppraiseContent) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetUpdDate(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpointAppraise.UpdDate);
objvViewpointAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.UpdDate) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.UpdDate, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.UpdDate] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetMemo(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewpointAppraise.Memo);
objvViewpointAppraiseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.Memo) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.Memo, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.Memo] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointName(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strViewpointName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpointAppraise.ViewpointName);
objvViewpointAppraiseEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointName) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointName, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointName] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetViewpointContent(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strViewpointContent, string strComparisonOp="")
	{
objvViewpointAppraiseEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.ViewpointContent) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.ViewpointContent, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.ViewpointContent] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetReason(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strReason, string strComparisonOp="")
	{
objvViewpointAppraiseEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.Reason) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.Reason, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.Reason] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointAppraiseEN SetUpdUser(this clsvViewpointAppraiseEN objvViewpointAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convViewpointAppraise.UpdUser);
objvViewpointAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convViewpointAppraise.UpdUser) == false)
{
objvViewpointAppraiseEN.dicFldComparisonOp.Add(convViewpointAppraise.UpdUser, strComparisonOp);
}
else
{
objvViewpointAppraiseEN.dicFldComparisonOp[convViewpointAppraise.UpdUser] = strComparisonOp;
}
}
return objvViewpointAppraiseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointAppraiseEN objvViewpointAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.UserName) == true)
{
string strComparisonOp_UserName = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.UserName, objvViewpointAppraise_Cond.UserName, strComparisonOp_UserName);
}
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.ViewpointAppraiseId) == true)
{
string strComparisonOp_ViewpointAppraiseId = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.ViewpointAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointAppraise.ViewpointAppraiseId, objvViewpointAppraise_Cond.ViewpointAppraiseId, strComparisonOp_ViewpointAppraiseId);
}
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.ViewpointId) == true)
{
string strComparisonOp_ViewpointId = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.ViewpointId, objvViewpointAppraise_Cond.ViewpointId, strComparisonOp_ViewpointId);
}
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.AppraiseContent, objvViewpointAppraise_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.UpdDate, objvViewpointAppraise_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.Memo) == true)
{
string strComparisonOp_Memo = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.Memo, objvViewpointAppraise_Cond.Memo, strComparisonOp_Memo);
}
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.ViewpointName) == true)
{
string strComparisonOp_ViewpointName = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.ViewpointName, objvViewpointAppraise_Cond.ViewpointName, strComparisonOp_ViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvViewpointAppraise_Cond.IsUpdated(convViewpointAppraise.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvViewpointAppraise_Cond.dicFldComparisonOp[convViewpointAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointAppraise.UpdUser, objvViewpointAppraise_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vViewpointAppraise(vViewpointAppraise), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvViewpointAppraiseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ViewpointAppraiseId_ViewpointId(this clsvViewpointAppraiseEN objvViewpointAppraiseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointAppraiseEN == null) return "";
if (objvViewpointAppraiseEN.ViewpointAppraiseId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.ViewpointId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointAppraiseId !=  {0}", objvViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.ViewpointAppraiseId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.ViewpointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vViewpointAppraise(vViewpointAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointAppraiseWApi
{
private static readonly string mstrApiControllerName = "vViewpointAppraiseApi";

 public clsvViewpointAppraiseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointAppraiseEN GetObjByViewpointAppraiseId(long lngViewpointAppraiseId)
{
string strAction = "GetObjByViewpointAppraiseId";
string strErrMsg = string.Empty;
string strResult = "";
clsvViewpointAppraiseEN objvViewpointAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ViewpointAppraiseId"] = lngViewpointAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvViewpointAppraiseEN = JsonConvert.DeserializeObject<clsvViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvViewpointAppraiseEN;
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
 /// <param name = "lngViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointAppraiseEN GetObjByViewpointAppraiseId_WA_Cache(long lngViewpointAppraiseId)
{
string strAction = "GetObjByViewpointAppraiseId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvViewpointAppraiseEN objvViewpointAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ViewpointAppraiseId"] = lngViewpointAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvViewpointAppraiseEN = JsonConvert.DeserializeObject<clsvViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvViewpointAppraiseEN;
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
public static clsvViewpointAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvViewpointAppraiseEN objvViewpointAppraiseEN = null;
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
objvViewpointAppraiseEN = JsonConvert.DeserializeObject<clsvViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvViewpointAppraiseEN;
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
 /// <param name = "lngViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointAppraiseEN GetObjByViewpointAppraiseId_Cache(long lngViewpointAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName_S);
List<clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLst_Sel =
from objvViewpointAppraiseEN in arrvViewpointAppraiseObjLst_Cache
where objvViewpointAppraiseEN.ViewpointAppraiseId == lngViewpointAppraiseId
select objvViewpointAppraiseEN;
if (arrvViewpointAppraiseObjLst_Sel.Count() == 0)
{
   clsvViewpointAppraiseEN obj = clsvViewpointAppraiseWApi.GetObjByViewpointAppraiseId(lngViewpointAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewpointAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsvViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointAppraiseEN> GetObjLstByViewpointAppraiseIdLst(List<long> arrViewpointAppraiseId)
{
 List<clsvViewpointAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByViewpointAppraiseIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewpointAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvViewpointAppraiseEN> GetObjLstByViewpointAppraiseIdLst_Cache(List<long> arrViewpointAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName_S);
List<clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLst_Sel =
from objvViewpointAppraiseEN in arrvViewpointAppraiseObjLst_Cache
where arrViewpointAppraiseId.Contains(objvViewpointAppraiseEN.ViewpointAppraiseId)
select objvViewpointAppraiseEN;
return arrvViewpointAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointAppraiseEN> GetObjLstByViewpointAppraiseIdLst_WA_Cache(List<long> arrViewpointAppraiseId)
{
 List<clsvViewpointAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByViewpointAppraiseIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewpointAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngViewpointAppraiseId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ViewpointAppraiseId"] = lngViewpointAppraiseId.ToString()
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
 /// <param name = "objvViewpointAppraiseENS">源对象</param>
 /// <param name = "objvViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(clsvViewpointAppraiseEN objvViewpointAppraiseENS, clsvViewpointAppraiseEN objvViewpointAppraiseENT)
{
try
{
objvViewpointAppraiseENT.UserName = objvViewpointAppraiseENS.UserName; //用户名
objvViewpointAppraiseENT.ViewpointAppraiseId = objvViewpointAppraiseENS.ViewpointAppraiseId; //观点评论Id
objvViewpointAppraiseENT.ViewpointId = objvViewpointAppraiseENS.ViewpointId; //观点Id
objvViewpointAppraiseENT.AppraiseContent = objvViewpointAppraiseENS.AppraiseContent; //评议内容
objvViewpointAppraiseENT.UpdDate = objvViewpointAppraiseENS.UpdDate; //修改日期
objvViewpointAppraiseENT.Memo = objvViewpointAppraiseENS.Memo; //备注
objvViewpointAppraiseENT.ViewpointName = objvViewpointAppraiseENS.ViewpointName; //观点名称
objvViewpointAppraiseENT.ViewpointContent = objvViewpointAppraiseENS.ViewpointContent; //观点内容
objvViewpointAppraiseENT.Reason = objvViewpointAppraiseENS.Reason; //理由
objvViewpointAppraiseENT.UpdUser = objvViewpointAppraiseENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsvViewpointAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewpointAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewpointAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewpointAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewpointAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewpointAppraiseEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointWApi没有刷新缓存机制(clsViewpointWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointAppraiseWApi没有刷新缓存机制(clsViewpointAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointAppraiseId");
//if (arrvViewpointAppraiseObjLst_Cache == null)
//{
//arrvViewpointAppraiseObjLst_Cache = await clsvViewpointAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName_S);
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
public static List<clsvViewpointAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvViewpointAppraiseEN._CurrTabName_S);
List<clsvViewpointAppraiseEN> arrvViewpointAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvViewpointAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewpointAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewpointAppraise.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.ViewpointAppraiseId, Type.GetType("System.Int64"));
objDT.Columns.Add(convViewpointAppraise.ViewpointId, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.ViewpointName, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.ViewpointContent, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.Reason, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointAppraise.UpdUser, Type.GetType("System.String"));
foreach (clsvViewpointAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewpointAppraise.UserName] = objInFor[convViewpointAppraise.UserName];
objDR[convViewpointAppraise.ViewpointAppraiseId] = objInFor[convViewpointAppraise.ViewpointAppraiseId];
objDR[convViewpointAppraise.ViewpointId] = objInFor[convViewpointAppraise.ViewpointId];
objDR[convViewpointAppraise.AppraiseContent] = objInFor[convViewpointAppraise.AppraiseContent];
objDR[convViewpointAppraise.UpdDate] = objInFor[convViewpointAppraise.UpdDate];
objDR[convViewpointAppraise.Memo] = objInFor[convViewpointAppraise.Memo];
objDR[convViewpointAppraise.ViewpointName] = objInFor[convViewpointAppraise.ViewpointName];
objDR[convViewpointAppraise.ViewpointContent] = objInFor[convViewpointAppraise.ViewpointContent];
objDR[convViewpointAppraise.Reason] = objInFor[convViewpointAppraise.Reason];
objDR[convViewpointAppraise.UpdUser] = objInFor[convViewpointAppraise.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}