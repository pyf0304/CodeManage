
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_WorkStuRelationTtlWApi
 表名:vcc_WorkStuRelationTtl(01120356)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:19
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsvcc_WorkStuRelationTtlWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN Setid_StudentInfo(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convcc_WorkStuRelationTtl.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convcc_WorkStuRelationTtl.id_StudentInfo);
objvcc_WorkStuRelationTtlEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.id_StudentInfo) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.id_StudentInfo, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.id_StudentInfo] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN Setid_CurrEduCls(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convcc_WorkStuRelationTtl.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convcc_WorkStuRelationTtl.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convcc_WorkStuRelationTtl.id_CurrEduCls);
objvcc_WorkStuRelationTtlEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.id_CurrEduCls) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.id_CurrEduCls, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.id_CurrEduCls] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetQuestionTypeId4Course(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convcc_WorkStuRelationTtl.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convcc_WorkStuRelationTtl.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convcc_WorkStuRelationTtl.QuestionTypeId4Course);
objvcc_WorkStuRelationTtlEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.QuestionTypeId4Course) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetQuestionTypeId(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_WorkStuRelationTtl.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_WorkStuRelationTtl.QuestionTypeId);
objvcc_WorkStuRelationTtlEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.QuestionTypeId) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_WorkStuRelationTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_WorkStuRelationTtlEN SetQuestionCount(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN, int intQuestionCount, string strComparisonOp="")
	{
objvcc_WorkStuRelationTtlEN.QuestionCount = intQuestionCount; //问题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.ContainsKey(convcc_WorkStuRelationTtl.QuestionCount) == false)
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp.Add(convcc_WorkStuRelationTtl.QuestionCount, strComparisonOp);
}
else
{
objvcc_WorkStuRelationTtlEN.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionCount] = strComparisonOp;
}
}
return objvcc_WorkStuRelationTtlEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtl_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_WorkStuRelationTtl_Cond.IsUpdated(convcc_WorkStuRelationTtl.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvcc_WorkStuRelationTtl_Cond.dicFldComparisonOp[convcc_WorkStuRelationTtl.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.id_StudentInfo, objvcc_WorkStuRelationTtl_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvcc_WorkStuRelationTtl_Cond.IsUpdated(convcc_WorkStuRelationTtl.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvcc_WorkStuRelationTtl_Cond.dicFldComparisonOp[convcc_WorkStuRelationTtl.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.id_CurrEduCls, objvcc_WorkStuRelationTtl_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvcc_WorkStuRelationTtl_Cond.IsUpdated(convcc_WorkStuRelationTtl.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvcc_WorkStuRelationTtl_Cond.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.QuestionTypeId4Course, objvcc_WorkStuRelationTtl_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
if (objvcc_WorkStuRelationTtl_Cond.IsUpdated(convcc_WorkStuRelationTtl.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_WorkStuRelationTtl_Cond.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_WorkStuRelationTtl.QuestionTypeId, objvcc_WorkStuRelationTtl_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_WorkStuRelationTtl_Cond.IsUpdated(convcc_WorkStuRelationTtl.QuestionCount) == true)
{
string strComparisonOp_QuestionCount = objvcc_WorkStuRelationTtl_Cond.dicFldComparisonOp[convcc_WorkStuRelationTtl.QuestionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_WorkStuRelationTtl.QuestionCount, objvcc_WorkStuRelationTtl_Cond.QuestionCount, strComparisonOp_QuestionCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vcc_WorkStuRelationTtl(vcc_WorkStuRelationTtl)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_WorkStuRelationTtlWApi
{
private static readonly string mstrApiControllerName = "vcc_WorkStuRelationTtlApi";

 public clsvcc_WorkStuRelationTtlWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetObjByid_StudentInfo(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelationTtlEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelationTtlEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelationTtlEN;
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
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetObjByid_StudentInfo_WA_Cache(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvcc_WorkStuRelationTtlEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelationTtlEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelationTtlEN;
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
public static clsvcc_WorkStuRelationTtlEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlEN = null;
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
objvcc_WorkStuRelationTtlEN = JsonConvert.DeserializeObject<clsvcc_WorkStuRelationTtlEN>((string)jobjReturn["ReturnObj"]);
return objvcc_WorkStuRelationTtlEN;
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_WorkStuRelationTtlEN GetObjByid_StudentInfo_Cache(string strid_StudentInfo)
{
if (string.IsNullOrEmpty(strid_StudentInfo) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName_S);
List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLst_Sel =
from objvcc_WorkStuRelationTtlEN in arrvcc_WorkStuRelationTtlObjLst_Cache
where objvcc_WorkStuRelationTtlEN.id_StudentInfo == strid_StudentInfo
select objvcc_WorkStuRelationTtlEN;
if (arrvcc_WorkStuRelationTtlObjLst_Sel.Count() == 0)
{
   clsvcc_WorkStuRelationTtlEN obj = clsvcc_WorkStuRelationTtlWApi.GetObjByid_StudentInfo(strid_StudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_WorkStuRelationTtlObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_WorkStuRelationTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstById_StudentInfoLst(List<string> arrId_StudentInfo)
{
 List<clsvcc_WorkStuRelationTtlEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvcc_WorkStuRelationTtlEN> GetObjLstById_StudentInfoLst_Cache(List<string> arrId_StudentInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName_S);
List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLst_Sel =
from objvcc_WorkStuRelationTtlEN in arrvcc_WorkStuRelationTtlObjLst_Cache
where arrId_StudentInfo.Contains(objvcc_WorkStuRelationTtlEN.id_StudentInfo)
select objvcc_WorkStuRelationTtlEN;
return arrvcc_WorkStuRelationTtlObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstById_StudentInfoLst_WA_Cache(List<string> arrId_StudentInfo)
{
 List<clsvcc_WorkStuRelationTtlEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_WorkStuRelationTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_WorkStuRelationTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelationTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_WorkStuRelationTtlEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_WorkStuRelationTtlEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_StudentInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
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
 /// <param name = "objvcc_WorkStuRelationTtlENS">源对象</param>
 /// <param name = "objvcc_WorkStuRelationTtlENT">目标对象</param>
 public static void CopyTo(clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENS, clsvcc_WorkStuRelationTtlEN objvcc_WorkStuRelationTtlENT)
{
try
{
objvcc_WorkStuRelationTtlENT.id_StudentInfo = objvcc_WorkStuRelationTtlENS.id_StudentInfo; //学生流水号
objvcc_WorkStuRelationTtlENT.id_CurrEduCls = objvcc_WorkStuRelationTtlENS.id_CurrEduCls; //当前教学班流水号
objvcc_WorkStuRelationTtlENT.QuestionTypeId4Course = objvcc_WorkStuRelationTtlENS.QuestionTypeId4Course; //题目类型Id4课程
objvcc_WorkStuRelationTtlENT.QuestionTypeId = objvcc_WorkStuRelationTtlENS.QuestionTypeId; //题目类型Id
objvcc_WorkStuRelationTtlENT.QuestionCount = objvcc_WorkStuRelationTtlENS.QuestionCount; //问题数
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
public static DataTable ToDataTable(List<clsvcc_WorkStuRelationTtlEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_WorkStuRelationTtlEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_WorkStuRelationTtlEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_WorkStuRelationTtlEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_WorkStuRelationTtlEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_WorkStuRelationTtlEN.AttributeName)
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
if (clscc_WorkStuRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelationWApi没有刷新缓存机制(clscc_WorkStuRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_WorkEduClsRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkEduClsRelaWApi没有刷新缓存机制(clscc_WorkEduClsRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsWorkTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsWorkTypeWApi没有刷新缓存机制(clsWorkTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_StudentInfo");
//if (arrvcc_WorkStuRelationTtlObjLst_Cache == null)
//{
//arrvcc_WorkStuRelationTtlObjLst_Cache = await clsvcc_WorkStuRelationTtlWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName_S);
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
public static List<clsvcc_WorkStuRelationTtlEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_WorkStuRelationTtlEN._CurrTabName_S);
List<clsvcc_WorkStuRelationTtlEN> arrvcc_WorkStuRelationTtlObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_WorkStuRelationTtlObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_WorkStuRelationTtlEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_WorkStuRelationTtl.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelationTtl.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelationTtl.QuestionTypeId4Course, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelationTtl.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_WorkStuRelationTtl.QuestionCount, Type.GetType("System.Int32"));
foreach (clsvcc_WorkStuRelationTtlEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_WorkStuRelationTtl.id_StudentInfo] = objInFor[convcc_WorkStuRelationTtl.id_StudentInfo];
objDR[convcc_WorkStuRelationTtl.id_CurrEduCls] = objInFor[convcc_WorkStuRelationTtl.id_CurrEduCls];
objDR[convcc_WorkStuRelationTtl.QuestionTypeId4Course] = objInFor[convcc_WorkStuRelationTtl.QuestionTypeId4Course];
objDR[convcc_WorkStuRelationTtl.QuestionTypeId] = objInFor[convcc_WorkStuRelationTtl.QuestionTypeId];
objDR[convcc_WorkStuRelationTtl.QuestionCount] = objInFor[convcc_WorkStuRelationTtl.QuestionCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}