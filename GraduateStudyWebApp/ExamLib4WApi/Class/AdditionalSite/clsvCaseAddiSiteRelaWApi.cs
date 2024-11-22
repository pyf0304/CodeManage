
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseAddiSiteRelaWApi
 表名:vCaseAddiSiteRela(01120520)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:53
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:附加网站
 模块英文名:AdditionalSite
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
public static class clsvCaseAddiSiteRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetmId(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, long lngmId, string strComparisonOp="")
	{
objvCaseAddiSiteRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.mId) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.mId, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.mId] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetId_DecompressionFile(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, long lngId_DecompressionFile, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngId_DecompressionFile, convCaseAddiSiteRela.Id_DecompressionFile);
objvCaseAddiSiteRelaEN.Id_DecompressionFile = lngId_DecompressionFile; //解压缩文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.Id_DecompressionFile) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.Id_DecompressionFile, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.Id_DecompressionFile] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetFileName(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCaseAddiSiteRela.FileName);
objvCaseAddiSiteRelaEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.FileName) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.FileName, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.FileName] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetFuncModuleId(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCaseAddiSiteRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCaseAddiSiteRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCaseAddiSiteRela.FuncModuleId);
objvCaseAddiSiteRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.FuncModuleId) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.FuncModuleId, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.FuncModuleId] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetFuncModuleName(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convCaseAddiSiteRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCaseAddiSiteRela.FuncModuleName);
objvCaseAddiSiteRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.FuncModuleName) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.FuncModuleName, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.FuncModuleName] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetId_Case(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Case, convCaseAddiSiteRela.Id_Case);
clsCheckSql.CheckFieldLen(strId_Case, 8, convCaseAddiSiteRela.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, convCaseAddiSiteRela.Id_Case);
objvCaseAddiSiteRelaEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.Id_Case) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.Id_Case, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.Id_Case] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetUpdUser(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCaseAddiSiteRela.UpdUser);
objvCaseAddiSiteRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.UpdUser) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.UpdUser, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.UpdUser] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetUpdDate(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCaseAddiSiteRela.UpdDate);
objvCaseAddiSiteRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.UpdDate) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.UpdDate, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.UpdDate] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCaseAddiSiteRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCaseAddiSiteRelaEN SetMemo(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCaseAddiSiteRela.Memo);
objvCaseAddiSiteRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCaseAddiSiteRelaEN.dicFldComparisonOp.ContainsKey(convCaseAddiSiteRela.Memo) == false)
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp.Add(convCaseAddiSiteRela.Memo, strComparisonOp);
}
else
{
objvCaseAddiSiteRelaEN.dicFldComparisonOp[convCaseAddiSiteRela.Memo] = strComparisonOp;
}
}
return objvCaseAddiSiteRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCaseAddiSiteRelaEN objvCaseAddiSiteRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.mId) == true)
{
string strComparisonOp_mId = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseAddiSiteRela.mId, objvCaseAddiSiteRela_Cond.mId, strComparisonOp_mId);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.Id_DecompressionFile) == true)
{
string strComparisonOp_Id_DecompressionFile = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.Id_DecompressionFile];
strWhereCond += string.Format(" And {0} {2} {1}", convCaseAddiSiteRela.Id_DecompressionFile, objvCaseAddiSiteRela_Cond.Id_DecompressionFile, strComparisonOp_Id_DecompressionFile);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.FileName) == true)
{
string strComparisonOp_FileName = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela.FileName, objvCaseAddiSiteRela_Cond.FileName, strComparisonOp_FileName);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela.FuncModuleId, objvCaseAddiSiteRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela.FuncModuleName, objvCaseAddiSiteRela_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.Id_Case) == true)
{
string strComparisonOp_Id_Case = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela.Id_Case, objvCaseAddiSiteRela_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela.UpdUser, objvCaseAddiSiteRela_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela.UpdDate, objvCaseAddiSiteRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCaseAddiSiteRela_Cond.IsUpdated(convCaseAddiSiteRela.Memo) == true)
{
string strComparisonOp_Memo = objvCaseAddiSiteRela_Cond.dicFldComparisonOp[convCaseAddiSiteRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCaseAddiSiteRela.Memo, objvCaseAddiSiteRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v案例和附加网站关系(vCaseAddiSiteRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCaseAddiSiteRelaWApi
{
private static readonly string mstrApiControllerName = "vCaseAddiSiteRelaApi";

 public clsvCaseAddiSiteRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseAddiSiteRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseAddiSiteRelaEN = JsonConvert.DeserializeObject<clsvCaseAddiSiteRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseAddiSiteRelaEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCaseAddiSiteRelaEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCaseAddiSiteRelaEN = JsonConvert.DeserializeObject<clsvCaseAddiSiteRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseAddiSiteRelaEN;
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
public static clsvCaseAddiSiteRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaEN = null;
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
objvCaseAddiSiteRelaEN = JsonConvert.DeserializeObject<clsvCaseAddiSiteRelaEN>((string)jobjReturn["ReturnObj"]);
return objvCaseAddiSiteRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCaseAddiSiteRelaEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseAddiSiteRelaEN._CurrTabName_S);
List<clsvCaseAddiSiteRelaEN> arrvCaseAddiSiteRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseAddiSiteRelaEN> arrvCaseAddiSiteRelaObjLst_Sel =
from objvCaseAddiSiteRelaEN in arrvCaseAddiSiteRelaObjLst_Cache
where objvCaseAddiSiteRelaEN.mId == lngmId
select objvCaseAddiSiteRelaEN;
if (arrvCaseAddiSiteRelaObjLst_Sel.Count() == 0)
{
   clsvCaseAddiSiteRelaEN obj = clsvCaseAddiSiteRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCaseAddiSiteRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseAddiSiteRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvCaseAddiSiteRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCaseAddiSiteRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCaseAddiSiteRelaEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCaseAddiSiteRelaEN._CurrTabName_S);
List<clsvCaseAddiSiteRelaEN> arrvCaseAddiSiteRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCaseAddiSiteRelaEN> arrvCaseAddiSiteRelaObjLst_Sel =
from objvCaseAddiSiteRelaEN in arrvCaseAddiSiteRelaObjLst_Cache
where arrMId.Contains(objvCaseAddiSiteRelaEN.mId)
select objvCaseAddiSiteRelaEN;
return arrvCaseAddiSiteRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCaseAddiSiteRelaEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvCaseAddiSiteRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCaseAddiSiteRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCaseAddiSiteRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCaseAddiSiteRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCaseAddiSiteRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCaseAddiSiteRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCaseAddiSiteRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvCaseAddiSiteRelaENS">源对象</param>
 /// <param name = "objvCaseAddiSiteRelaENT">目标对象</param>
 public static void CopyTo(clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaENS, clsvCaseAddiSiteRelaEN objvCaseAddiSiteRelaENT)
{
try
{
objvCaseAddiSiteRelaENT.mId = objvCaseAddiSiteRelaENS.mId; //mId
objvCaseAddiSiteRelaENT.Id_DecompressionFile = objvCaseAddiSiteRelaENS.Id_DecompressionFile; //解压缩文件流水号
objvCaseAddiSiteRelaENT.FileName = objvCaseAddiSiteRelaENS.FileName; //文件名称
objvCaseAddiSiteRelaENT.FuncModuleId = objvCaseAddiSiteRelaENS.FuncModuleId; //功能模块Id
objvCaseAddiSiteRelaENT.FuncModuleName = objvCaseAddiSiteRelaENS.FuncModuleName; //功能模块名称
objvCaseAddiSiteRelaENT.Id_Case = objvCaseAddiSiteRelaENS.Id_Case; //案例流水号
objvCaseAddiSiteRelaENT.UpdUser = objvCaseAddiSiteRelaENS.UpdUser; //修改人
objvCaseAddiSiteRelaENT.UpdDate = objvCaseAddiSiteRelaENS.UpdDate; //修改日期
objvCaseAddiSiteRelaENT.Memo = objvCaseAddiSiteRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCaseAddiSiteRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCaseAddiSiteRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCaseAddiSiteRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCaseAddiSiteRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCaseAddiSiteRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCaseAddiSiteRelaEN.AttributeName)
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
if (clsCaseAddiSiteRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseAddiSiteRelaWApi没有刷新缓存机制(clsCaseAddiSiteRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDecompressionFileWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDecompressionFileWApi没有刷新缓存机制(clsDecompressionFileWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCaseAddiSiteRelaObjLst_Cache == null)
//{
//arrvCaseAddiSiteRelaObjLst_Cache = await clsvCaseAddiSiteRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCaseAddiSiteRelaEN._CurrTabName_S);
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
public static List<clsvCaseAddiSiteRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCaseAddiSiteRelaEN._CurrTabName_S);
List<clsvCaseAddiSiteRelaEN> arrvCaseAddiSiteRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCaseAddiSiteRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCaseAddiSiteRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCaseAddiSiteRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseAddiSiteRela.Id_DecompressionFile, Type.GetType("System.Int64"));
objDT.Columns.Add(convCaseAddiSiteRela.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCaseAddiSiteRela.Memo, Type.GetType("System.String"));
foreach (clsvCaseAddiSiteRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCaseAddiSiteRela.mId] = objInFor[convCaseAddiSiteRela.mId];
objDR[convCaseAddiSiteRela.Id_DecompressionFile] = objInFor[convCaseAddiSiteRela.Id_DecompressionFile];
objDR[convCaseAddiSiteRela.FileName] = objInFor[convCaseAddiSiteRela.FileName];
objDR[convCaseAddiSiteRela.FuncModuleId] = objInFor[convCaseAddiSiteRela.FuncModuleId];
objDR[convCaseAddiSiteRela.FuncModuleName] = objInFor[convCaseAddiSiteRela.FuncModuleName];
objDR[convCaseAddiSiteRela.Id_Case] = objInFor[convCaseAddiSiteRela.Id_Case];
objDR[convCaseAddiSiteRela.UpdUser] = objInFor[convCaseAddiSiteRela.UpdUser];
objDR[convCaseAddiSiteRela.UpdDate] = objInFor[convCaseAddiSiteRela.UpdDate];
objDR[convCaseAddiSiteRela.Memo] = objInFor[convCaseAddiSiteRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}