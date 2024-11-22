
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointLikeLogWApi
 表名:vPaperSubViewpointLikeLog(01120563)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:44
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
public static class clsvPaperSubViewpointLikeLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetPaperSubViewpointLikeLogId(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, long lngPaperSubViewpointLikeLogId, string strComparisonOp="")
	{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = lngPaperSubViewpointLikeLogId; //PaperSubViewpointLikeLogId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetUpdDate(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSubViewpointLikeLog.UpdDate);
objvPaperSubViewpointLikeLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.UpdDate) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.UpdDate, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdDate] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetMemo(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperSubViewpointLikeLog.Memo);
objvPaperSubViewpointLikeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.Memo) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.Memo, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.Memo] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetRWTitle(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strRWTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRWTitle, 50, convPaperSubViewpointLikeLog.RWTitle);
objvPaperSubViewpointLikeLogEN.RWTitle = strRWTitle; //读写标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.RWTitle) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.RWTitle, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.RWTitle] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetSubViewpointContent(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strSubViewpointContent, string strComparisonOp="")
	{
objvPaperSubViewpointLikeLogEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.SubViewpointContent) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.SubViewpointContent, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.SubViewpointContent] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetExplainContent(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strExplainContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, convPaperSubViewpointLikeLog.ExplainContent);
objvPaperSubViewpointLikeLogEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.ExplainContent) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.ExplainContent, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.ExplainContent] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetPaperRWId(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strPaperRWId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, convPaperSubViewpointLikeLog.PaperRWId);
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, convPaperSubViewpointLikeLog.PaperRWId);
objvPaperSubViewpointLikeLogEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.PaperRWId) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.PaperRWId, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperRWId] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetSubViewpointId(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, long lngSubViewpointId, string strComparisonOp="")
	{
objvPaperSubViewpointLikeLogEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.SubViewpointId) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.SubViewpointId, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.SubViewpointId] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetUpdUser(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperSubViewpointLikeLog.UpdUser);
objvPaperSubViewpointLikeLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.UpdUser) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.UpdUser, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdUser] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId) == true)
{
string strComparisonOp_PaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, objvPaperSubViewpointLikeLog_Cond.PaperSubViewpointLikeLogId, strComparisonOp_PaperSubViewpointLikeLogId);
}
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.UpdDate, objvPaperSubViewpointLikeLog_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.Memo) == true)
{
string strComparisonOp_Memo = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.Memo, objvPaperSubViewpointLikeLog_Cond.Memo, strComparisonOp_Memo);
}
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.RWTitle) == true)
{
string strComparisonOp_RWTitle = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.RWTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.RWTitle, objvPaperSubViewpointLikeLog_Cond.RWTitle, strComparisonOp_RWTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.ExplainContent) == true)
{
string strComparisonOp_ExplainContent = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.ExplainContent, objvPaperSubViewpointLikeLog_Cond.ExplainContent, strComparisonOp_ExplainContent);
}
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.PaperRWId) == true)
{
string strComparisonOp_PaperRWId = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.PaperRWId, objvPaperSubViewpointLikeLog_Cond.PaperRWId, strComparisonOp_PaperRWId);
}
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.SubViewpointId) == true)
{
string strComparisonOp_SubViewpointId = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointLikeLog.SubViewpointId, objvPaperSubViewpointLikeLog_Cond.SubViewpointId, strComparisonOp_SubViewpointId);
}
if (objvPaperSubViewpointLikeLog_Cond.IsUpdated(convPaperSubViewpointLikeLog.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvPaperSubViewpointLikeLog_Cond.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.UpdUser, objvPaperSubViewpointLikeLog_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v子观点点赞表(vPaperSubViewpointLikeLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSubViewpointLikeLogWApi
{
private static readonly string mstrApiControllerName = "vPaperSubViewpointLikeLogApi";

 public clsvPaperSubViewpointLikeLogWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetObjByPaperSubViewpointLikeLogId(long lngPaperSubViewpointLikeLogId)
{
string strAction = "GetObjByPaperSubViewpointLikeLogId";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointLikeLogId"] = lngPaperSubViewpointLikeLogId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperSubViewpointLikeLogEN = JsonConvert.DeserializeObject<clsvPaperSubViewpointLikeLogEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSubViewpointLikeLogEN;
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
 /// <param name = "lngPaperSubViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetObjByPaperSubViewpointLikeLogId_WA_Cache(long lngPaperSubViewpointLikeLogId)
{
string strAction = "GetObjByPaperSubViewpointLikeLogId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointLikeLogId"] = lngPaperSubViewpointLikeLogId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperSubViewpointLikeLogEN = JsonConvert.DeserializeObject<clsvPaperSubViewpointLikeLogEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSubViewpointLikeLogEN;
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
public static clsvPaperSubViewpointLikeLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = null;
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
objvPaperSubViewpointLikeLogEN = JsonConvert.DeserializeObject<clsvPaperSubViewpointLikeLogEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSubViewpointLikeLogEN;
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
 /// <param name = "lngPaperSubViewpointLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetObjByPaperSubViewpointLikeLogId_Cache(long lngPaperSubViewpointLikeLogId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName_S);
List<clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLst_Sel =
from objvPaperSubViewpointLikeLogEN in arrvPaperSubViewpointLikeLogObjLst_Cache
where objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId
select objvPaperSubViewpointLikeLogEN;
if (arrvPaperSubViewpointLikeLogObjLst_Sel.Count() == 0)
{
   clsvPaperSubViewpointLikeLogEN obj = clsvPaperSubViewpointLikeLogWApi.GetObjByPaperSubViewpointLikeLogId(lngPaperSubViewpointLikeLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPaperSubViewpointLikeLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLst(string strWhereCond)
{
 List<clsvPaperSubViewpointLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPaperSubViewpointLikeLogIdLst(List<long> arrPaperSubViewpointLikeLogId)
{
 List<clsvPaperSubViewpointLikeLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperSubViewpointLikeLogIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperSubViewpointLikeLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPaperSubViewpointLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPaperSubViewpointLikeLogEN> GetObjLstByPaperSubViewpointLikeLogIdLst_Cache(List<long> arrPaperSubViewpointLikeLogId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName_S);
List<clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLst_Sel =
from objvPaperSubViewpointLikeLogEN in arrvPaperSubViewpointLikeLogObjLst_Cache
where arrPaperSubViewpointLikeLogId.Contains(objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId)
select objvPaperSubViewpointLikeLogEN;
return arrvPaperSubViewpointLikeLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPaperSubViewpointLikeLogIdLst_WA_Cache(List<long> arrPaperSubViewpointLikeLogId)
{
 List<clsvPaperSubViewpointLikeLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperSubViewpointLikeLogIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperSubViewpointLikeLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPaperSubViewpointLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPaperSubViewpointLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPaperSubViewpointLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPaperSubViewpointLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngPaperSubViewpointLikeLogId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointLikeLogId"] = lngPaperSubViewpointLikeLogId.ToString()
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
 /// <param name = "objvPaperSubViewpointLikeLogENS">源对象</param>
 /// <param name = "objvPaperSubViewpointLikeLogENT">目标对象</param>
 public static void CopyTo(clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENS, clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENT)
{
try
{
objvPaperSubViewpointLikeLogENT.PaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogENS.PaperSubViewpointLikeLogId; //PaperSubViewpointLikeLogId
objvPaperSubViewpointLikeLogENT.UpdDate = objvPaperSubViewpointLikeLogENS.UpdDate; //修改日期
objvPaperSubViewpointLikeLogENT.Memo = objvPaperSubViewpointLikeLogENS.Memo; //备注
objvPaperSubViewpointLikeLogENT.RWTitle = objvPaperSubViewpointLikeLogENS.RWTitle; //读写标题
objvPaperSubViewpointLikeLogENT.SubViewpointContent = objvPaperSubViewpointLikeLogENS.SubViewpointContent; //详情内容
objvPaperSubViewpointLikeLogENT.ExplainContent = objvPaperSubViewpointLikeLogENS.ExplainContent; //说明内容
objvPaperSubViewpointLikeLogENT.PaperRWId = objvPaperSubViewpointLikeLogENS.PaperRWId; //课文阅读
objvPaperSubViewpointLikeLogENT.SubViewpointId = objvPaperSubViewpointLikeLogENS.SubViewpointId; //子观点Id
objvPaperSubViewpointLikeLogENT.UpdUser = objvPaperSubViewpointLikeLogENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsvPaperSubViewpointLikeLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPaperSubViewpointLikeLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPaperSubViewpointLikeLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPaperSubViewpointLikeLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPaperSubViewpointLikeLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPaperSubViewpointLikeLogEN.AttributeName)
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
if (clsPaperSubViewpointWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointWApi没有刷新缓存机制(clsPaperSubViewpointWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperSubViewpointLikeLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointLikeLogWApi没有刷新缓存机制(clsPaperSubViewpointLikeLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubViewpointLikeLogId");
//if (arrvPaperSubViewpointLikeLogObjLst_Cache == null)
//{
//arrvPaperSubViewpointLikeLogObjLst_Cache = await clsvPaperSubViewpointLikeLogWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName_S);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName_S);
List<clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperSubViewpointLikeLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPaperSubViewpointLikeLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.RWTitle, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.SubViewpointContent, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.ExplainContent, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.PaperRWId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.SubViewpointId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPaperSubViewpointLikeLog.UpdUser, Type.GetType("System.String"));
foreach (clsvPaperSubViewpointLikeLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId] = objInFor[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId];
objDR[convPaperSubViewpointLikeLog.UpdDate] = objInFor[convPaperSubViewpointLikeLog.UpdDate];
objDR[convPaperSubViewpointLikeLog.Memo] = objInFor[convPaperSubViewpointLikeLog.Memo];
objDR[convPaperSubViewpointLikeLog.RWTitle] = objInFor[convPaperSubViewpointLikeLog.RWTitle];
objDR[convPaperSubViewpointLikeLog.SubViewpointContent] = objInFor[convPaperSubViewpointLikeLog.SubViewpointContent];
objDR[convPaperSubViewpointLikeLog.ExplainContent] = objInFor[convPaperSubViewpointLikeLog.ExplainContent];
objDR[convPaperSubViewpointLikeLog.PaperRWId] = objInFor[convPaperSubViewpointLikeLog.PaperRWId];
objDR[convPaperSubViewpointLikeLog.SubViewpointId] = objInFor[convPaperSubViewpointLikeLog.SubViewpointId];
objDR[convPaperSubViewpointLikeLog.UpdUser] = objInFor[convPaperSubViewpointLikeLog.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}