
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLikeLogTtlWApi
 表名:vVideoLikeLogTtl(01120292)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:28
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsvVideoLikeLogTtlWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLikeLogTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLikeLogTtlEN SetId_Case(this clsvVideoLikeLogTtlEN objvVideoLikeLogTtlEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Case, 8, convVideoLikeLogTtl.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, convVideoLikeLogTtl.Id_Case);
objvVideoLikeLogTtlEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLikeLogTtlEN.dicFldComparisonOp.ContainsKey(convVideoLikeLogTtl.Id_Case) == false)
{
objvVideoLikeLogTtlEN.dicFldComparisonOp.Add(convVideoLikeLogTtl.Id_Case, strComparisonOp);
}
else
{
objvVideoLikeLogTtlEN.dicFldComparisonOp[convVideoLikeLogTtl.Id_Case] = strComparisonOp;
}
}
return objvVideoLikeLogTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLikeLogTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLikeLogTtlEN SetFuncModuleId(this clsvVideoLikeLogTtlEN objvVideoLikeLogTtlEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLikeLogTtl.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLikeLogTtl.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLikeLogTtl.FuncModuleId);
objvVideoLikeLogTtlEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLikeLogTtlEN.dicFldComparisonOp.ContainsKey(convVideoLikeLogTtl.FuncModuleId) == false)
{
objvVideoLikeLogTtlEN.dicFldComparisonOp.Add(convVideoLikeLogTtl.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLikeLogTtlEN.dicFldComparisonOp[convVideoLikeLogTtl.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLikeLogTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLikeLogTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLikeLogTtlEN SetLikeNum(this clsvVideoLikeLogTtlEN objvVideoLikeLogTtlEN, int intLikeNum, string strComparisonOp="")
	{
objvVideoLikeLogTtlEN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLikeLogTtlEN.dicFldComparisonOp.ContainsKey(convVideoLikeLogTtl.LikeNum) == false)
{
objvVideoLikeLogTtlEN.dicFldComparisonOp.Add(convVideoLikeLogTtl.LikeNum, strComparisonOp);
}
else
{
objvVideoLikeLogTtlEN.dicFldComparisonOp[convVideoLikeLogTtl.LikeNum] = strComparisonOp;
}
}
return objvVideoLikeLogTtlEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLikeLogTtlEN objvVideoLikeLogTtl_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLikeLogTtl_Cond.IsUpdated(convVideoLikeLogTtl.Id_Case) == true)
{
string strComparisonOp_Id_Case = objvVideoLikeLogTtl_Cond.dicFldComparisonOp[convVideoLikeLogTtl.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLikeLogTtl.Id_Case, objvVideoLikeLogTtl_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objvVideoLikeLogTtl_Cond.IsUpdated(convVideoLikeLogTtl.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoLikeLogTtl_Cond.dicFldComparisonOp[convVideoLikeLogTtl.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLikeLogTtl.FuncModuleId, objvVideoLikeLogTtl_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoLikeLogTtl_Cond.IsUpdated(convVideoLikeLogTtl.LikeNum) == true)
{
string strComparisonOp_LikeNum = objvVideoLikeLogTtl_Cond.dicFldComparisonOp[convVideoLikeLogTtl.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLikeLogTtl.LikeNum, objvVideoLikeLogTtl_Cond.LikeNum, strComparisonOp_LikeNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频点赞日志汇总(vVideoLikeLogTtl)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLikeLogTtlWApi
{
private static readonly string mstrApiControllerName = "vVideoLikeLogTtlApi";

 public clsvVideoLikeLogTtlWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_Case">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLikeLogTtlEN GetObjById_Case(string strId_Case)
{
string strAction = "GetObjById_Case";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLikeLogTtlEN objvVideoLikeLogTtlEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Case"] = strId_Case
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoLikeLogTtlEN = JsonConvert.DeserializeObject<clsvVideoLikeLogTtlEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLikeLogTtlEN;
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
 /// <param name = "strId_Case">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLikeLogTtlEN GetObjById_Case_WA_Cache(string strId_Case)
{
string strAction = "GetObjById_Case_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLikeLogTtlEN objvVideoLikeLogTtlEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Case"] = strId_Case
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoLikeLogTtlEN = JsonConvert.DeserializeObject<clsvVideoLikeLogTtlEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLikeLogTtlEN;
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
public static clsvVideoLikeLogTtlEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLikeLogTtlEN objvVideoLikeLogTtlEN = null;
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
objvVideoLikeLogTtlEN = JsonConvert.DeserializeObject<clsvVideoLikeLogTtlEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLikeLogTtlEN;
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
 /// <param name = "strId_Case">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoLikeLogTtlEN GetObjById_Case_Cache(string strId_Case)
{
if (string.IsNullOrEmpty(strId_Case) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLikeLogTtlEN._CurrTabName_S);
List<clsvVideoLikeLogTtlEN> arrvVideoLikeLogTtlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLikeLogTtlEN> arrvVideoLikeLogTtlObjLst_Sel =
from objvVideoLikeLogTtlEN in arrvVideoLikeLogTtlObjLst_Cache
where objvVideoLikeLogTtlEN.Id_Case == strId_Case
select objvVideoLikeLogTtlEN;
if (arrvVideoLikeLogTtlObjLst_Sel.Count() == 0)
{
   clsvVideoLikeLogTtlEN obj = clsvVideoLikeLogTtlWApi.GetObjById_Case(strId_Case);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLikeLogTtlObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLikeLogTtlEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLikeLogTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLikeLogTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLikeLogTtlEN> GetObjLstById_CaseLst(List<string> arrId_Case)
{
 List<clsvVideoLikeLogTtlEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Case);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLikeLogTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_Case">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvVideoLikeLogTtlEN> GetObjLstById_CaseLst_Cache(List<string> arrId_Case)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLikeLogTtlEN._CurrTabName_S);
List<clsvVideoLikeLogTtlEN> arrvVideoLikeLogTtlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLikeLogTtlEN> arrvVideoLikeLogTtlObjLst_Sel =
from objvVideoLikeLogTtlEN in arrvVideoLikeLogTtlObjLst_Cache
where arrId_Case.Contains(objvVideoLikeLogTtlEN.Id_Case)
select objvVideoLikeLogTtlEN;
return arrvVideoLikeLogTtlObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLikeLogTtlEN> GetObjLstById_CaseLst_WA_Cache(List<string> arrId_Case)
{
 List<clsvVideoLikeLogTtlEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Case);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLikeLogTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLikeLogTtlEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLikeLogTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLikeLogTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLikeLogTtlEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLikeLogTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLikeLogTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLikeLogTtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLikeLogTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLikeLogTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLikeLogTtlEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLikeLogTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLikeLogTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strId_Case)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Case"] = strId_Case
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
 /// <param name = "objvVideoLikeLogTtlENS">源对象</param>
 /// <param name = "objvVideoLikeLogTtlENT">目标对象</param>
 public static void CopyTo(clsvVideoLikeLogTtlEN objvVideoLikeLogTtlENS, clsvVideoLikeLogTtlEN objvVideoLikeLogTtlENT)
{
try
{
objvVideoLikeLogTtlENT.Id_Case = objvVideoLikeLogTtlENS.Id_Case; //案例流水号
objvVideoLikeLogTtlENT.FuncModuleId = objvVideoLikeLogTtlENS.FuncModuleId; //功能模块Id
objvVideoLikeLogTtlENT.LikeNum = objvVideoLikeLogTtlENS.LikeNum; //点赞数
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
public static DataTable ToDataTable(List<clsvVideoLikeLogTtlEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLikeLogTtlEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLikeLogTtlEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLikeLogTtlEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLikeLogTtlEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLikeLogTtlEN.AttributeName)
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
if (clsVideoLikeLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLikeLogWApi没有刷新缓存机制(clsVideoLikeLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_Case");
//if (arrvVideoLikeLogTtlObjLst_Cache == null)
//{
//arrvVideoLikeLogTtlObjLst_Cache = await clsvVideoLikeLogTtlWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLikeLogTtlEN._CurrTabName_S);
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
public static List<clsvVideoLikeLogTtlEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLikeLogTtlEN._CurrTabName_S);
List<clsvVideoLikeLogTtlEN> arrvVideoLikeLogTtlObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLikeLogTtlObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLikeLogTtlEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLikeLogTtl.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLikeLogTtl.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLikeLogTtl.LikeNum, Type.GetType("System.Int32"));
foreach (clsvVideoLikeLogTtlEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLikeLogTtl.Id_Case] = objInFor[convVideoLikeLogTtl.Id_Case];
objDR[convVideoLikeLogTtl.FuncModuleId] = objInFor[convVideoLikeLogTtl.FuncModuleId];
objDR[convVideoLikeLogTtl.LikeNum] = objInFor[convVideoLikeLogTtl.LikeNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}