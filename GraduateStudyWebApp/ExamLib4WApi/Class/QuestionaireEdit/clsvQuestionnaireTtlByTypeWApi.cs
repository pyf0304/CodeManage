
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaireTtlByTypeWApi
 表名:vQuestionnaireTtlByType(01120214)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:55
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsvQuestionnaireTtlByTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetQuestionTypeId(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaireTtlByType.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaireTtlByType.QuestionTypeId);
objvQuestionnaireTtlByTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.QuestionTypeId) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetQuestionTypeName(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionnaireTtlByType.QuestionTypeName);
objvQuestionnaireTtlByTypeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.QuestionTypeName) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetCourseId(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaireTtlByType.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaireTtlByType.CourseId);
objvQuestionnaireTtlByTypeEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.CourseId) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.CourseId, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.CourseId] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetQuestionNum(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, int intQuestionNum, string strComparisonOp="")
	{
objvQuestionnaireTtlByTypeEN.QuestionNum = intQuestionNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.QuestionNum) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.QuestionNum, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionNum] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaireTtlByTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaireTtlByTypeEN SetOrderNum(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN, int intOrderNum, string strComparisonOp="")
	{
objvQuestionnaireTtlByTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.ContainsKey(convQuestionnaireTtlByType.OrderNum) == false)
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp.Add(convQuestionnaireTtlByType.OrderNum, strComparisonOp);
}
else
{
objvQuestionnaireTtlByTypeEN.dicFldComparisonOp[convQuestionnaireTtlByType.OrderNum] = strComparisonOp;
}
}
return objvQuestionnaireTtlByTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaireTtlByType_Cond.IsUpdated(convQuestionnaireTtlByType.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvQuestionnaireTtlByType_Cond.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireTtlByType.QuestionTypeId, objvQuestionnaireTtlByType_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvQuestionnaireTtlByType_Cond.IsUpdated(convQuestionnaireTtlByType.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvQuestionnaireTtlByType_Cond.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireTtlByType.QuestionTypeName, objvQuestionnaireTtlByType_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvQuestionnaireTtlByType_Cond.IsUpdated(convQuestionnaireTtlByType.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionnaireTtlByType_Cond.dicFldComparisonOp[convQuestionnaireTtlByType.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaireTtlByType.CourseId, objvQuestionnaireTtlByType_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionnaireTtlByType_Cond.IsUpdated(convQuestionnaireTtlByType.QuestionNum) == true)
{
string strComparisonOp_QuestionNum = objvQuestionnaireTtlByType_Cond.dicFldComparisonOp[convQuestionnaireTtlByType.QuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaireTtlByType.QuestionNum, objvQuestionnaireTtlByType_Cond.QuestionNum, strComparisonOp_QuestionNum);
}
if (objvQuestionnaireTtlByType_Cond.IsUpdated(convQuestionnaireTtlByType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvQuestionnaireTtlByType_Cond.dicFldComparisonOp[convQuestionnaireTtlByType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaireTtlByType.OrderNum, objvQuestionnaireTtlByType_Cond.OrderNum, strComparisonOp_OrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vQuestionnaireTtlByType(vQuestionnaireTtlByType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaireTtlByTypeWApi
{
private static readonly string mstrApiControllerName = "vQuestionnaireTtlByTypeApi";

 public clsvQuestionnaireTtlByTypeWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetObjByQuestionTypeId(string strQuestionTypeId)
{
string strAction = "GetObjByQuestionTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionnaireTtlByTypeEN = JsonConvert.DeserializeObject<clsvQuestionnaireTtlByTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireTtlByTypeEN;
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
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetObjByQuestionTypeId_WA_Cache(string strQuestionTypeId)
{
string strAction = "GetObjByQuestionTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionnaireTtlByTypeEN = JsonConvert.DeserializeObject<clsvQuestionnaireTtlByTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireTtlByTypeEN;
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
public static clsvQuestionnaireTtlByTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeEN = null;
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
objvQuestionnaireTtlByTypeEN = JsonConvert.DeserializeObject<clsvQuestionnaireTtlByTypeEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaireTtlByTypeEN;
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaireTtlByTypeEN GetObjByQuestionTypeId_Cache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName_S);
List<clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLst_Sel =
from objvQuestionnaireTtlByTypeEN in arrvQuestionnaireTtlByTypeObjLst_Cache
where objvQuestionnaireTtlByTypeEN.QuestionTypeId == strQuestionTypeId
select objvQuestionnaireTtlByTypeEN;
if (arrvQuestionnaireTtlByTypeObjLst_Sel.Count() == 0)
{
   clsvQuestionnaireTtlByTypeEN obj = clsvQuestionnaireTtlByTypeWApi.GetObjByQuestionTypeId(strQuestionTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionnaireTtlByTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionnaireTtlByTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireTtlByTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByQuestionTypeIdLst(List<string> arrQuestionTypeId)
{
 List<clsvQuestionnaireTtlByTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireTtlByTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionnaireTtlByTypeEN> GetObjLstByQuestionTypeIdLst_Cache(List<string> arrQuestionTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName_S);
List<clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLst_Sel =
from objvQuestionnaireTtlByTypeEN in arrvQuestionnaireTtlByTypeObjLst_Cache
where arrQuestionTypeId.Contains(objvQuestionnaireTtlByTypeEN.QuestionTypeId)
select objvQuestionnaireTtlByTypeEN;
return arrvQuestionnaireTtlByTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByQuestionTypeIdLst_WA_Cache(List<string> arrQuestionTypeId)
{
 List<clsvQuestionnaireTtlByTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireTtlByTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionnaireTtlByTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireTtlByTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionnaireTtlByTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireTtlByTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaireTtlByTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireTtlByTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaireTtlByTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaireTtlByTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strQuestionTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
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
 /// <param name = "objvQuestionnaireTtlByTypeENS">源对象</param>
 /// <param name = "objvQuestionnaireTtlByTypeENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENS, clsvQuestionnaireTtlByTypeEN objvQuestionnaireTtlByTypeENT)
{
try
{
objvQuestionnaireTtlByTypeENT.QuestionTypeId = objvQuestionnaireTtlByTypeENS.QuestionTypeId; //题目类型Id
objvQuestionnaireTtlByTypeENT.QuestionTypeName = objvQuestionnaireTtlByTypeENS.QuestionTypeName; //题目类型名
objvQuestionnaireTtlByTypeENT.CourseId = objvQuestionnaireTtlByTypeENS.CourseId; //课程Id
objvQuestionnaireTtlByTypeENT.QuestionNum = objvQuestionnaireTtlByTypeENS.QuestionNum; //题目数
objvQuestionnaireTtlByTypeENT.OrderNum = objvQuestionnaireTtlByTypeENS.OrderNum; //序号
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
public static DataTable ToDataTable(List<clsvQuestionnaireTtlByTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionnaireTtlByTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionnaireTtlByTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionnaireTtlByTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionnaireTtlByTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionnaireTtlByTypeEN.AttributeName)
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
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId");
//if (arrvQuestionnaireTtlByTypeObjLst_Cache == null)
//{
//arrvQuestionnaireTtlByTypeObjLst_Cache = await clsvQuestionnaireTtlByTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName_S);
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
public static List<clsvQuestionnaireTtlByTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionnaireTtlByTypeEN._CurrTabName_S);
List<clsvQuestionnaireTtlByTypeEN> arrvQuestionnaireTtlByTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionnaireTtlByTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionnaireTtlByTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionnaireTtlByType.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireTtlByType.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireTtlByType.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaireTtlByType.QuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaireTtlByType.OrderNum, Type.GetType("System.Int32"));
foreach (clsvQuestionnaireTtlByTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionnaireTtlByType.QuestionTypeId] = objInFor[convQuestionnaireTtlByType.QuestionTypeId];
objDR[convQuestionnaireTtlByType.QuestionTypeName] = objInFor[convQuestionnaireTtlByType.QuestionTypeName];
objDR[convQuestionnaireTtlByType.CourseId] = objInFor[convQuestionnaireTtlByType.CourseId];
objDR[convQuestionnaireTtlByType.QuestionNum] = objInFor[convQuestionnaireTtlByType.QuestionNum];
objDR[convQuestionnaireTtlByType.OrderNum] = objInFor[convQuestionnaireTtlByType.OrderNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}