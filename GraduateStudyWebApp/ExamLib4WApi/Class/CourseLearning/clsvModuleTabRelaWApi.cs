
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvModuleTabRelaWApi
 表名:vModuleTabRela(01120364)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvModuleTabRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetFuncModuleId(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convModuleTabRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convModuleTabRela.FuncModuleId);
objvModuleTabRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.FuncModuleId) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.FuncModuleId, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.FuncModuleId] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetFuncModuleName(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convModuleTabRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convModuleTabRela.FuncModuleName);
objvModuleTabRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.FuncModuleName) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.FuncModuleName, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.FuncModuleName] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetFuncModuleName_Sim(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convModuleTabRela.FuncModuleName_Sim);
objvModuleTabRelaEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.FuncModuleName_Sim) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetOrderNum(this clsvModuleTabRelaEN objvModuleTabRelaEN, int intOrderNum, string strComparisonOp="")
	{
objvModuleTabRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.OrderNum) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.OrderNum, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.OrderNum] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetCollegeTab(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strCollegeTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeTab, 50, convModuleTabRela.CollegeTab);
objvModuleTabRelaEN.CollegeTab = strCollegeTab; //学院表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.CollegeTab) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.CollegeTab, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.CollegeTab] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetMajorTab(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strMajorTab, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorTab, 50, convModuleTabRela.MajorTab);
objvModuleTabRelaEN.MajorTab = strMajorTab; //专业表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.MajorTab) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.MajorTab, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.MajorTab] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetUpdDate(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convModuleTabRela.UpdDate);
objvModuleTabRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.UpdDate) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.UpdDate, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.UpdDate] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetUpdUserId(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convModuleTabRela.UpdUserId);
objvModuleTabRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.UpdUserId) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.UpdUserId, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.UpdUserId] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleTabRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleTabRelaEN SetMemo(this clsvModuleTabRelaEN objvModuleTabRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convModuleTabRela.Memo);
objvModuleTabRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleTabRelaEN.dicFldComparisonOp.ContainsKey(convModuleTabRela.Memo) == false)
{
objvModuleTabRelaEN.dicFldComparisonOp.Add(convModuleTabRela.Memo, strComparisonOp);
}
else
{
objvModuleTabRelaEN.dicFldComparisonOp[convModuleTabRela.Memo] = strComparisonOp;
}
}
return objvModuleTabRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvModuleTabRelaEN objvModuleTabRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.FuncModuleId, objvModuleTabRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.FuncModuleName, objvModuleTabRela_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.FuncModuleName_Sim, objvModuleTabRela_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleTabRela.OrderNum, objvModuleTabRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.CollegeTab) == true)
{
string strComparisonOp_CollegeTab = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.CollegeTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.CollegeTab, objvModuleTabRela_Cond.CollegeTab, strComparisonOp_CollegeTab);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.MajorTab) == true)
{
string strComparisonOp_MajorTab = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.MajorTab];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.MajorTab, objvModuleTabRela_Cond.MajorTab, strComparisonOp_MajorTab);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.UpdDate, objvModuleTabRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.UpdUserId, objvModuleTabRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvModuleTabRela_Cond.IsUpdated(convModuleTabRela.Memo) == true)
{
string strComparisonOp_Memo = objvModuleTabRela_Cond.dicFldComparisonOp[convModuleTabRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleTabRela.Memo, objvModuleTabRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v模块表关系(vModuleTabRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvModuleTabRelaWApi
{
private static readonly string mstrApiControllerName = "vModuleTabRelaApi";

 public clsvModuleTabRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleTabRelaEN GetObjByFuncModuleId(string strFuncModuleId)
{
string strAction = "GetObjByFuncModuleId";
string strErrMsg = string.Empty;
string strResult = "";
clsvModuleTabRelaEN objvModuleTabRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FuncModuleId"] = strFuncModuleId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvModuleTabRelaEN = JsonConvert.DeserializeObject<clsvModuleTabRelaEN>((string)jobjReturn["ReturnObj"]);
return objvModuleTabRelaEN;
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
 /// <param name = "strFuncModuleId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleTabRelaEN GetObjByFuncModuleId_WA_Cache(string strFuncModuleId)
{
string strAction = "GetObjByFuncModuleId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvModuleTabRelaEN objvModuleTabRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FuncModuleId"] = strFuncModuleId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvModuleTabRelaEN = JsonConvert.DeserializeObject<clsvModuleTabRelaEN>((string)jobjReturn["ReturnObj"]);
return objvModuleTabRelaEN;
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
public static clsvModuleTabRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvModuleTabRelaEN objvModuleTabRelaEN = null;
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
objvModuleTabRelaEN = JsonConvert.DeserializeObject<clsvModuleTabRelaEN>((string)jobjReturn["ReturnObj"]);
return objvModuleTabRelaEN;
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
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvModuleTabRelaEN GetObjByFuncModuleId_Cache(string strFuncModuleId)
{
if (string.IsNullOrEmpty(strFuncModuleId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName_S);
List<clsvModuleTabRelaEN> arrvModuleTabRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvModuleTabRelaEN> arrvModuleTabRelaObjLst_Sel =
from objvModuleTabRelaEN in arrvModuleTabRelaObjLst_Cache
where objvModuleTabRelaEN.FuncModuleId == strFuncModuleId
select objvModuleTabRelaEN;
if (arrvModuleTabRelaObjLst_Sel.Count() == 0)
{
   clsvModuleTabRelaEN obj = clsvModuleTabRelaWApi.GetObjByFuncModuleId(strFuncModuleId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvModuleTabRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleTabRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvModuleTabRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleTabRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleTabRelaEN> GetObjLstByFuncModuleIdLst(List<string> arrFuncModuleId)
{
 List<clsvModuleTabRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByFuncModuleIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncModuleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleTabRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strFuncModuleId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvModuleTabRelaEN> GetObjLstByFuncModuleIdLst_Cache(List<string> arrFuncModuleId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName_S);
List<clsvModuleTabRelaEN> arrvModuleTabRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvModuleTabRelaEN> arrvModuleTabRelaObjLst_Sel =
from objvModuleTabRelaEN in arrvModuleTabRelaObjLst_Cache
where arrFuncModuleId.Contains(objvModuleTabRelaEN.FuncModuleId)
select objvModuleTabRelaEN;
return arrvModuleTabRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleTabRelaEN> GetObjLstByFuncModuleIdLst_WA_Cache(List<string> arrFuncModuleId)
{
 List<clsvModuleTabRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByFuncModuleIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFuncModuleId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleTabRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleTabRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvModuleTabRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleTabRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleTabRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvModuleTabRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleTabRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleTabRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvModuleTabRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleTabRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleTabRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvModuleTabRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleTabRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strFuncModuleId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FuncModuleId"] = strFuncModuleId
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
 /// <param name = "objvModuleTabRelaENS">源对象</param>
 /// <param name = "objvModuleTabRelaENT">目标对象</param>
 public static void CopyTo(clsvModuleTabRelaEN objvModuleTabRelaENS, clsvModuleTabRelaEN objvModuleTabRelaENT)
{
try
{
objvModuleTabRelaENT.FuncModuleId = objvModuleTabRelaENS.FuncModuleId; //功能模块Id
objvModuleTabRelaENT.FuncModuleName = objvModuleTabRelaENS.FuncModuleName; //功能模块名称
objvModuleTabRelaENT.FuncModuleName_Sim = objvModuleTabRelaENS.FuncModuleName_Sim; //功能模块简称
objvModuleTabRelaENT.OrderNum = objvModuleTabRelaENS.OrderNum; //序号
objvModuleTabRelaENT.CollegeTab = objvModuleTabRelaENS.CollegeTab; //学院表
objvModuleTabRelaENT.MajorTab = objvModuleTabRelaENS.MajorTab; //专业表
objvModuleTabRelaENT.UpdDate = objvModuleTabRelaENS.UpdDate; //修改日期
objvModuleTabRelaENT.UpdUserId = objvModuleTabRelaENS.UpdUserId; //修改用户Id
objvModuleTabRelaENT.Memo = objvModuleTabRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvModuleTabRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvModuleTabRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvModuleTabRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvModuleTabRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvModuleTabRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvModuleTabRelaEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsModuleTabRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsModuleTabRelaWApi没有刷新缓存机制(clsModuleTabRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleId");
//if (arrvModuleTabRelaObjLst_Cache == null)
//{
//arrvModuleTabRelaObjLst_Cache = await clsvModuleTabRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName_S);
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
public static List<clsvModuleTabRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvModuleTabRelaEN._CurrTabName_S);
List<clsvModuleTabRelaEN> arrvModuleTabRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvModuleTabRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvModuleTabRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convModuleTabRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convModuleTabRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convModuleTabRela.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convModuleTabRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convModuleTabRela.CollegeTab, Type.GetType("System.String"));
objDT.Columns.Add(convModuleTabRela.MajorTab, Type.GetType("System.String"));
objDT.Columns.Add(convModuleTabRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convModuleTabRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convModuleTabRela.Memo, Type.GetType("System.String"));
foreach (clsvModuleTabRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convModuleTabRela.FuncModuleId] = objInFor[convModuleTabRela.FuncModuleId];
objDR[convModuleTabRela.FuncModuleName] = objInFor[convModuleTabRela.FuncModuleName];
objDR[convModuleTabRela.FuncModuleName_Sim] = objInFor[convModuleTabRela.FuncModuleName_Sim];
objDR[convModuleTabRela.OrderNum] = objInFor[convModuleTabRela.OrderNum];
objDR[convModuleTabRela.CollegeTab] = objInFor[convModuleTabRela.CollegeTab];
objDR[convModuleTabRela.MajorTab] = objInFor[convModuleTabRela.MajorTab];
objDR[convModuleTabRela.UpdDate] = objInFor[convModuleTabRela.UpdDate];
objDR[convModuleTabRela.UpdUserId] = objInFor[convModuleTabRela.UpdUserId];
objDR[convModuleTabRela.Memo] = objInFor[convModuleTabRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}