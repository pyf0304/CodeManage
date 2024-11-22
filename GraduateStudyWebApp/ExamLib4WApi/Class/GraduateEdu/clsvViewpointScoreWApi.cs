
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewpointScoreWApi
 表名:vViewpointScore(01120609)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:00
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养
 模块英文名:GraduateEdu
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
public static class clsvViewpointScoreWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointScoreId(this clsvViewpointScoreEN objvViewpointScoreEN, long lngViewpointScoreId, string strComparisonOp="")
	{
objvViewpointScoreEN.ViewpointScoreId = lngViewpointScoreId; //评分Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointScoreId) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointScoreId, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointScoreId] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointScore(this clsvViewpointScoreEN objvViewpointScoreEN, float fltViewpointScore, string strComparisonOp="")
	{
objvViewpointScoreEN.ViewpointScore = fltViewpointScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointScore) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointScore, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointScore] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointId(this clsvViewpointScoreEN objvViewpointScoreEN, string strViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convViewpointScore.ViewpointId);
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convViewpointScore.ViewpointId);
objvViewpointScoreEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointId) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointId, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointId] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetUpdDate(this clsvViewpointScoreEN objvViewpointScoreEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convViewpointScore.UpdDate);
objvViewpointScoreEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.UpdDate) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.UpdDate, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.UpdDate] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetUpdUserId(this clsvViewpointScoreEN objvViewpointScoreEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convViewpointScore.UpdUserId);
objvViewpointScoreEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.UpdUserId) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.UpdUserId, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.UpdUserId] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetMemo(this clsvViewpointScoreEN objvViewpointScoreEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convViewpointScore.Memo);
objvViewpointScoreEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.Memo) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.Memo, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.Memo] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetUserName(this clsvViewpointScoreEN objvViewpointScoreEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convViewpointScore.UserName);
objvViewpointScoreEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.UserName) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.UserName, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.UserName] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointName(this clsvViewpointScoreEN objvViewpointScoreEN, string strViewpointName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convViewpointScore.ViewpointName);
objvViewpointScoreEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointName) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointName, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointName] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetViewpointContent(this clsvViewpointScoreEN objvViewpointScoreEN, string strViewpointContent, string strComparisonOp="")
	{
objvViewpointScoreEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.ViewpointContent) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.ViewpointContent, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.ViewpointContent] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvViewpointScoreEN SetReason(this clsvViewpointScoreEN objvViewpointScoreEN, string strReason, string strComparisonOp="")
	{
objvViewpointScoreEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvViewpointScoreEN.dicFldComparisonOp.ContainsKey(convViewpointScore.Reason) == false)
{
objvViewpointScoreEN.dicFldComparisonOp.Add(convViewpointScore.Reason, strComparisonOp);
}
else
{
objvViewpointScoreEN.dicFldComparisonOp[convViewpointScore.Reason] = strComparisonOp;
}
}
return objvViewpointScoreEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvViewpointScoreEN objvViewpointScore_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.ViewpointScoreId) == true)
{
string strComparisonOp_ViewpointScoreId = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.ViewpointScoreId];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointScore.ViewpointScoreId, objvViewpointScore_Cond.ViewpointScoreId, strComparisonOp_ViewpointScoreId);
}
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.ViewpointScore) == true)
{
string strComparisonOp_ViewpointScore = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.ViewpointScore];
strWhereCond += string.Format(" And {0} {2} {1}", convViewpointScore.ViewpointScore, objvViewpointScore_Cond.ViewpointScore, strComparisonOp_ViewpointScore);
}
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.ViewpointId) == true)
{
string strComparisonOp_ViewpointId = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.ViewpointId, objvViewpointScore_Cond.ViewpointId, strComparisonOp_ViewpointId);
}
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.UpdDate, objvViewpointScore_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.UpdUserId, objvViewpointScore_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.Memo) == true)
{
string strComparisonOp_Memo = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.Memo, objvViewpointScore_Cond.Memo, strComparisonOp_Memo);
}
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.UserName) == true)
{
string strComparisonOp_UserName = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.UserName, objvViewpointScore_Cond.UserName, strComparisonOp_UserName);
}
if (objvViewpointScore_Cond.IsUpdated(convViewpointScore.ViewpointName) == true)
{
string strComparisonOp_ViewpointName = objvViewpointScore_Cond.dicFldComparisonOp[convViewpointScore.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convViewpointScore.ViewpointName, objvViewpointScore_Cond.ViewpointName, strComparisonOp_ViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vViewpointScore(vViewpointScore), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvViewpointScoreEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ViewpointScoreId_ViewpointId(this clsvViewpointScoreEN objvViewpointScoreEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvViewpointScoreEN == null) return "";
if (objvViewpointScoreEN.ViewpointScoreId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objvViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointScoreEN.ViewpointId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ViewpointScoreId !=  {0}", objvViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointScoreId = '{0}'", objvViewpointScoreEN.ViewpointScoreId);
 sbCondition.AppendFormat(" and ViewpointId = '{0}'", objvViewpointScoreEN.ViewpointId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vViewpointScore(vViewpointScore)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvViewpointScoreWApi
{
private static readonly string mstrApiControllerName = "vViewpointScoreApi";

 public clsvViewpointScoreWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngViewpointScoreId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointScoreEN GetObjByViewpointScoreId(long lngViewpointScoreId)
{
string strAction = "GetObjByViewpointScoreId";
string strErrMsg = string.Empty;
string strResult = "";
clsvViewpointScoreEN objvViewpointScoreEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ViewpointScoreId"] = lngViewpointScoreId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvViewpointScoreEN = JsonConvert.DeserializeObject<clsvViewpointScoreEN>((string)jobjReturn["ReturnObj"]);
return objvViewpointScoreEN;
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
 /// <param name = "lngViewpointScoreId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvViewpointScoreEN GetObjByViewpointScoreId_WA_Cache(long lngViewpointScoreId)
{
string strAction = "GetObjByViewpointScoreId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvViewpointScoreEN objvViewpointScoreEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ViewpointScoreId"] = lngViewpointScoreId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvViewpointScoreEN = JsonConvert.DeserializeObject<clsvViewpointScoreEN>((string)jobjReturn["ReturnObj"]);
return objvViewpointScoreEN;
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
public static clsvViewpointScoreEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvViewpointScoreEN objvViewpointScoreEN = null;
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
objvViewpointScoreEN = JsonConvert.DeserializeObject<clsvViewpointScoreEN>((string)jobjReturn["ReturnObj"]);
return objvViewpointScoreEN;
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
 /// <param name = "lngViewpointScoreId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvViewpointScoreEN GetObjByViewpointScoreId_Cache(long lngViewpointScoreId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName_S);
List<clsvViewpointScoreEN> arrvViewpointScoreObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvViewpointScoreEN> arrvViewpointScoreObjLst_Sel =
from objvViewpointScoreEN in arrvViewpointScoreObjLst_Cache
where objvViewpointScoreEN.ViewpointScoreId == lngViewpointScoreId
select objvViewpointScoreEN;
if (arrvViewpointScoreObjLst_Sel.Count() == 0)
{
   clsvViewpointScoreEN obj = clsvViewpointScoreWApi.GetObjByViewpointScoreId(lngViewpointScoreId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvViewpointScoreObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointScoreEN> GetObjLst(string strWhereCond)
{
 List<clsvViewpointScoreEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointScoreEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointScoreEN> GetObjLstByViewpointScoreIdLst(List<long> arrViewpointScoreId)
{
 List<clsvViewpointScoreEN> arrObjLst = null; 
string strAction = "GetObjLstByViewpointScoreIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewpointScoreId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointScoreEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngViewpointScoreId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvViewpointScoreEN> GetObjLstByViewpointScoreIdLst_Cache(List<long> arrViewpointScoreId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName_S);
List<clsvViewpointScoreEN> arrvViewpointScoreObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvViewpointScoreEN> arrvViewpointScoreObjLst_Sel =
from objvViewpointScoreEN in arrvViewpointScoreObjLst_Cache
where arrViewpointScoreId.Contains(objvViewpointScoreEN.ViewpointScoreId)
select objvViewpointScoreEN;
return arrvViewpointScoreObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvViewpointScoreEN> GetObjLstByViewpointScoreIdLst_WA_Cache(List<long> arrViewpointScoreId)
{
 List<clsvViewpointScoreEN> arrObjLst = null; 
string strAction = "GetObjLstByViewpointScoreIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrViewpointScoreId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointScoreEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointScoreEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvViewpointScoreEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointScoreEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointScoreEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvViewpointScoreEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointScoreEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointScoreEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvViewpointScoreEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointScoreEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvViewpointScoreEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvViewpointScoreEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvViewpointScoreEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngViewpointScoreId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ViewpointScoreId"] = lngViewpointScoreId.ToString()
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
 /// <param name = "objvViewpointScoreENS">源对象</param>
 /// <param name = "objvViewpointScoreENT">目标对象</param>
 public static void CopyTo(clsvViewpointScoreEN objvViewpointScoreENS, clsvViewpointScoreEN objvViewpointScoreENT)
{
try
{
objvViewpointScoreENT.ViewpointScoreId = objvViewpointScoreENS.ViewpointScoreId; //评分Id
objvViewpointScoreENT.ViewpointScore = objvViewpointScoreENS.ViewpointScore; //评分
objvViewpointScoreENT.ViewpointId = objvViewpointScoreENS.ViewpointId; //观点Id
objvViewpointScoreENT.UpdDate = objvViewpointScoreENS.UpdDate; //修改日期
objvViewpointScoreENT.UpdUserId = objvViewpointScoreENS.UpdUserId; //修改用户Id
objvViewpointScoreENT.Memo = objvViewpointScoreENS.Memo; //备注
objvViewpointScoreENT.UserName = objvViewpointScoreENS.UserName; //用户名
objvViewpointScoreENT.ViewpointName = objvViewpointScoreENS.ViewpointName; //观点名称
objvViewpointScoreENT.ViewpointContent = objvViewpointScoreENS.ViewpointContent; //观点内容
objvViewpointScoreENT.Reason = objvViewpointScoreENS.Reason; //理由
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
public static DataTable ToDataTable(List<clsvViewpointScoreEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvViewpointScoreEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvViewpointScoreEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvViewpointScoreEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvViewpointScoreEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvViewpointScoreEN.AttributeName)
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
if (clsViewpointScoreWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointScoreWApi没有刷新缓存机制(clsViewpointScoreWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ViewpointScoreId");
//if (arrvViewpointScoreObjLst_Cache == null)
//{
//arrvViewpointScoreObjLst_Cache = await clsvViewpointScoreWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName_S);
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
public static List<clsvViewpointScoreEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvViewpointScoreEN._CurrTabName_S);
List<clsvViewpointScoreEN> arrvViewpointScoreObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvViewpointScoreObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvViewpointScoreEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convViewpointScore.ViewpointScoreId, Type.GetType("System.Int64"));
objDT.Columns.Add(convViewpointScore.ViewpointScore, Type.GetType("System.Single"));
objDT.Columns.Add(convViewpointScore.ViewpointId, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointScore.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointScore.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointScore.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointScore.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointScore.ViewpointName, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointScore.ViewpointContent, Type.GetType("System.String"));
objDT.Columns.Add(convViewpointScore.Reason, Type.GetType("System.String"));
foreach (clsvViewpointScoreEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convViewpointScore.ViewpointScoreId] = objInFor[convViewpointScore.ViewpointScoreId];
objDR[convViewpointScore.ViewpointScore] = objInFor[convViewpointScore.ViewpointScore];
objDR[convViewpointScore.ViewpointId] = objInFor[convViewpointScore.ViewpointId];
objDR[convViewpointScore.UpdDate] = objInFor[convViewpointScore.UpdDate];
objDR[convViewpointScore.UpdUserId] = objInFor[convViewpointScore.UpdUserId];
objDR[convViewpointScore.Memo] = objInFor[convViewpointScore.Memo];
objDR[convViewpointScore.UserName] = objInFor[convViewpointScore.UserName];
objDR[convViewpointScore.ViewpointName] = objInFor[convViewpointScore.ViewpointName];
objDR[convViewpointScore.ViewpointContent] = objInFor[convViewpointScore.ViewpointContent];
objDR[convViewpointScore.Reason] = objInFor[convViewpointScore.Reason];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}