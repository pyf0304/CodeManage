
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCount2WApi
 表名:vPaperCount2(01120596)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:12
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
public static class clsvPaperCount2WApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetPaperId(this clsvPaperCount2EN objvPaperCount2EN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperCount2.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperCount2.PaperId);
objvPaperCount2EN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.PaperId) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.PaperId, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.PaperId] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetPcount(this clsvPaperCount2EN objvPaperCount2EN, int intPcount, string strComparisonOp="")
	{
objvPaperCount2EN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.Pcount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.Pcount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.Pcount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetOkCount(this clsvPaperCount2EN objvPaperCount2EN, int intOkCount, string strComparisonOp="")
	{
objvPaperCount2EN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.OkCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.OkCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.OkCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetAppraiseCount(this clsvPaperCount2EN objvPaperCount2EN, int intAppraiseCount, string strComparisonOp="")
	{
objvPaperCount2EN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.AppraiseCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.AppraiseCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.AppraiseCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetCollectionCount(this clsvPaperCount2EN objvPaperCount2EN, int intCollectionCount, string strComparisonOp="")
	{
objvPaperCount2EN.CollectionCount = intCollectionCount; //收藏数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.CollectionCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.CollectionCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.CollectionCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetDownloadCount(this clsvPaperCount2EN objvPaperCount2EN, int intDownloadCount, string strComparisonOp="")
	{
objvPaperCount2EN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.DownloadCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.DownloadCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.DownloadCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN Setscore(this clsvPaperCount2EN objvPaperCount2EN, float fltscore, string strComparisonOp="")
	{
objvPaperCount2EN.score = fltscore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.score) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.score, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.score] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetAttachmentCount(this clsvPaperCount2EN objvPaperCount2EN, int intAttachmentCount, string strComparisonOp="")
	{
objvPaperCount2EN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.AttachmentCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.AttachmentCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.AttachmentCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperCount2EN SetUpdUser(this clsvPaperCount2EN objvPaperCount2EN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperCount2.UpdUser);
objvPaperCount2EN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.UpdUser) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.UpdUser, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.UpdUser] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperCount2EN objvPaperCount2_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.PaperId) == true)
{
string strComparisonOp_PaperId = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount2.PaperId, objvPaperCount2_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.Pcount) == true)
{
string strComparisonOp_Pcount = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.Pcount, objvPaperCount2_Cond.Pcount, strComparisonOp_Pcount);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.OkCount) == true)
{
string strComparisonOp_OkCount = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.OkCount, objvPaperCount2_Cond.OkCount, strComparisonOp_OkCount);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.AppraiseCount) == true)
{
string strComparisonOp_AppraiseCount = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.AppraiseCount, objvPaperCount2_Cond.AppraiseCount, strComparisonOp_AppraiseCount);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.CollectionCount, objvPaperCount2_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.DownloadCount) == true)
{
string strComparisonOp_DownloadCount = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.DownloadCount, objvPaperCount2_Cond.DownloadCount, strComparisonOp_DownloadCount);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.score) == true)
{
string strComparisonOp_score = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.score];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.score, objvPaperCount2_Cond.score, strComparisonOp_score);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.AttachmentCount) == true)
{
string strComparisonOp_AttachmentCount = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.AttachmentCount, objvPaperCount2_Cond.AttachmentCount, strComparisonOp_AttachmentCount);
}
if (objvPaperCount2_Cond.IsUpdated(convPaperCount2.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvPaperCount2_Cond.dicFldComparisonOp[convPaperCount2.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount2.UpdUser, objvPaperCount2_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vPaperCount2(vPaperCount2)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPaperCount2WApi
{
private static readonly string mstrApiControllerName = "vPaperCount2Api";

 public clsvPaperCount2WApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCount2EN GetObjByPaperId(string strPaperId)
{
string strAction = "GetObjByPaperId";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperCount2EN objvPaperCount2EN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperId"] = strPaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperCount2EN = JsonConvert.DeserializeObject<clsvPaperCount2EN>((string)jobjReturn["ReturnObj"]);
return objvPaperCount2EN;
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
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCount2EN GetObjByPaperId_WA_Cache(string strPaperId)
{
string strAction = "GetObjByPaperId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperCount2EN objvPaperCount2EN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperId"] = strPaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperCount2EN = JsonConvert.DeserializeObject<clsvPaperCount2EN>((string)jobjReturn["ReturnObj"]);
return objvPaperCount2EN;
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
public static clsvPaperCount2EN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperCount2EN objvPaperCount2EN = null;
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
objvPaperCount2EN = JsonConvert.DeserializeObject<clsvPaperCount2EN>((string)jobjReturn["ReturnObj"]);
return objvPaperCount2EN;
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
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperCount2EN GetObjByPaperId_Cache(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName_S);
List<clsvPaperCount2EN> arrvPaperCount2ObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperCount2EN> arrvPaperCount2ObjLst_Sel =
from objvPaperCount2EN in arrvPaperCount2ObjLst_Cache
where objvPaperCount2EN.PaperId == strPaperId
select objvPaperCount2EN;
if (arrvPaperCount2ObjLst_Sel.Count() == 0)
{
   clsvPaperCount2EN obj = clsvPaperCount2WApi.GetObjByPaperId(strPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPaperCount2ObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCount2EN> GetObjLst(string strWhereCond)
{
 List<clsvPaperCount2EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperCount2EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperCount2EN> GetObjLstByPaperIdLst(List<string> arrPaperId)
{
 List<clsvPaperCount2EN> arrObjLst = null; 
string strAction = "GetObjLstByPaperIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperCount2EN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPaperCount2EN> GetObjLstByPaperIdLst_Cache(List<string> arrPaperId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName_S);
List<clsvPaperCount2EN> arrvPaperCount2ObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperCount2EN> arrvPaperCount2ObjLst_Sel =
from objvPaperCount2EN in arrvPaperCount2ObjLst_Cache
where arrPaperId.Contains(objvPaperCount2EN.PaperId)
select objvPaperCount2EN;
return arrvPaperCount2ObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCount2EN> GetObjLstByPaperIdLst_WA_Cache(List<string> arrPaperId)
{
 List<clsvPaperCount2EN> arrObjLst = null; 
string strAction = "GetObjLstByPaperIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperCount2EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperCount2EN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPaperCount2EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperCount2EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperCount2EN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPaperCount2EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperCount2EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperCount2EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPaperCount2EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperCount2EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperCount2EN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPaperCount2EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperCount2EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strPaperId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperId"] = strPaperId
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
 /// <param name = "objvPaperCount2ENS">源对象</param>
 /// <param name = "objvPaperCount2ENT">目标对象</param>
 public static void CopyTo(clsvPaperCount2EN objvPaperCount2ENS, clsvPaperCount2EN objvPaperCount2ENT)
{
try
{
objvPaperCount2ENT.PaperId = objvPaperCount2ENS.PaperId; //论文Id
objvPaperCount2ENT.Pcount = objvPaperCount2ENS.Pcount; //读写数
objvPaperCount2ENT.OkCount = objvPaperCount2ENS.OkCount; //点赞统计
objvPaperCount2ENT.AppraiseCount = objvPaperCount2ENS.AppraiseCount; //评论数
objvPaperCount2ENT.CollectionCount = objvPaperCount2ENS.CollectionCount; //收藏数
objvPaperCount2ENT.DownloadCount = objvPaperCount2ENS.DownloadCount; //下载数
objvPaperCount2ENT.score = objvPaperCount2ENS.score; //评分
objvPaperCount2ENT.AttachmentCount = objvPaperCount2ENS.AttachmentCount; //附件计数
objvPaperCount2ENT.UpdUser = objvPaperCount2ENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsvPaperCount2EN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPaperCount2EN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPaperCount2EN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPaperCount2EN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPaperCount2EN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPaperCount2EN.AttributeName)
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
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperId");
//if (arrvPaperCount2ObjLst_Cache == null)
//{
//arrvPaperCount2ObjLst_Cache = await clsvPaperCount2WApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName_S);
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
public static List<clsvPaperCount2EN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName_S);
List<clsvPaperCount2EN> arrvPaperCount2ObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperCount2ObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPaperCount2EN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPaperCount2.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperCount2.Pcount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperCount2.OkCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperCount2.AppraiseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperCount2.CollectionCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperCount2.DownloadCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperCount2.score, Type.GetType("System.Single"));
objDT.Columns.Add(convPaperCount2.AttachmentCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperCount2.UpdUser, Type.GetType("System.String"));
foreach (clsvPaperCount2EN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPaperCount2.PaperId] = objInFor[convPaperCount2.PaperId];
objDR[convPaperCount2.Pcount] = objInFor[convPaperCount2.Pcount];
objDR[convPaperCount2.OkCount] = objInFor[convPaperCount2.OkCount];
objDR[convPaperCount2.AppraiseCount] = objInFor[convPaperCount2.AppraiseCount];
objDR[convPaperCount2.CollectionCount] = objInFor[convPaperCount2.CollectionCount];
objDR[convPaperCount2.DownloadCount] = objInFor[convPaperCount2.DownloadCount];
objDR[convPaperCount2.score] = objInFor[convPaperCount2.score];
objDR[convPaperCount2.AttachmentCount] = objInFor[convPaperCount2.AttachmentCount];
objDR[convPaperCount2.UpdUser] = objInFor[convPaperCount2.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}