
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoPlayLogWApi
 表名:vVideoPlayLog(01120302)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:21
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
public static class clsvVideoPlayLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN Setid_VideoPlayLog(this clsvVideoPlayLogEN objvVideoPlayLogEN, long lngid_VideoPlayLog, string strComparisonOp="")
	{
objvVideoPlayLogEN.id_VideoPlayLog = lngid_VideoPlayLog; //视频播放日志流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.id_VideoPlayLog) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.id_VideoPlayLog, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.id_VideoPlayLog] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetFuncModuleId(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoPlayLog.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoPlayLog.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoPlayLog.FuncModuleId);
objvVideoPlayLogEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.FuncModuleId) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.FuncModuleId, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.FuncModuleId] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetFuncModuleName_Sim(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convVideoPlayLog.FuncModuleName_Sim);
objvVideoPlayLogEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.FuncModuleName_Sim) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetId_Case(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Case, convVideoPlayLog.Id_Case);
clsCheckSql.CheckFieldLen(strId_Case, 8, convVideoPlayLog.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, convVideoPlayLog.Id_Case);
objvVideoPlayLogEN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.Id_Case) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.Id_Case, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.Id_Case] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetVideoLibName(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoPlayLog.VideoLibName);
objvVideoPlayLogEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.VideoLibName) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.VideoLibName, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.VideoLibName] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetVideoUrl(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoPlayLog.VideoUrl);
objvVideoPlayLogEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.VideoUrl) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.VideoUrl, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.VideoUrl] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetCoverPicUrl(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strCoverPicUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoPlayLog.CoverPicUrl);
objvVideoPlayLogEN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.CoverPicUrl) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetLikeNum(this clsvVideoPlayLogEN objvVideoPlayLogEN, int intLikeNum, string strComparisonOp="")
	{
objvVideoPlayLogEN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.LikeNum) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.LikeNum, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.LikeNum] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetPlayNum(this clsvVideoPlayLogEN objvVideoPlayLogEN, int intPlayNum, string strComparisonOp="")
	{
objvVideoPlayLogEN.PlayNum = intPlayNum; //播放数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.PlayNum) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.PlayNum, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.PlayNum] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetUserId(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoPlayLog.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convVideoPlayLog.UserId);
objvVideoPlayLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.UserId) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.UserId, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.UserId] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetPlayDate(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strPlayDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPlayDate, 20, convVideoPlayLog.PlayDate);
objvVideoPlayLogEN.PlayDate = strPlayDate; //播放日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.PlayDate) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.PlayDate, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.PlayDate] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLogEN SetMemo(this clsvVideoPlayLogEN objvVideoPlayLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoPlayLog.Memo);
objvVideoPlayLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLogEN.dicFldComparisonOp.ContainsKey(convVideoPlayLog.Memo) == false)
{
objvVideoPlayLogEN.dicFldComparisonOp.Add(convVideoPlayLog.Memo, strComparisonOp);
}
else
{
objvVideoPlayLogEN.dicFldComparisonOp[convVideoPlayLog.Memo] = strComparisonOp;
}
}
return objvVideoPlayLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoPlayLogEN objvVideoPlayLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.id_VideoPlayLog) == true)
{
string strComparisonOp_id_VideoPlayLog = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.id_VideoPlayLog];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog.id_VideoPlayLog, objvVideoPlayLog_Cond.id_VideoPlayLog, strComparisonOp_id_VideoPlayLog);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.FuncModuleId, objvVideoPlayLog_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.FuncModuleName_Sim, objvVideoPlayLog_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.Id_Case) == true)
{
string strComparisonOp_Id_Case = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.Id_Case, objvVideoPlayLog_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.VideoLibName, objvVideoPlayLog_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.VideoUrl, objvVideoPlayLog_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.CoverPicUrl) == true)
{
string strComparisonOp_CoverPicUrl = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.CoverPicUrl, objvVideoPlayLog_Cond.CoverPicUrl, strComparisonOp_CoverPicUrl);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.LikeNum) == true)
{
string strComparisonOp_LikeNum = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog.LikeNum, objvVideoPlayLog_Cond.LikeNum, strComparisonOp_LikeNum);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.PlayNum) == true)
{
string strComparisonOp_PlayNum = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.PlayNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog.PlayNum, objvVideoPlayLog_Cond.PlayNum, strComparisonOp_PlayNum);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.UserId) == true)
{
string strComparisonOp_UserId = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.UserId, objvVideoPlayLog_Cond.UserId, strComparisonOp_UserId);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.PlayDate) == true)
{
string strComparisonOp_PlayDate = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.PlayDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.PlayDate, objvVideoPlayLog_Cond.PlayDate, strComparisonOp_PlayDate);
}
if (objvVideoPlayLog_Cond.IsUpdated(convVideoPlayLog.Memo) == true)
{
string strComparisonOp_Memo = objvVideoPlayLog_Cond.dicFldComparisonOp[convVideoPlayLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog.Memo, objvVideoPlayLog_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频播放日志(vVideoPlayLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoPlayLogWApi
{
private static readonly string mstrApiControllerName = "vVideoPlayLogApi";

 public clsvVideoPlayLogWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_VideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoPlayLogEN GetObjByid_VideoPlayLog(long lngid_VideoPlayLog)
{
string strAction = "GetObjByid_VideoPlayLog";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoPlayLogEN objvVideoPlayLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_VideoPlayLog"] = lngid_VideoPlayLog.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoPlayLogEN = JsonConvert.DeserializeObject<clsvVideoPlayLogEN>((string)jobjReturn["ReturnObj"]);
return objvVideoPlayLogEN;
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
 /// <param name = "lngid_VideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoPlayLogEN GetObjByid_VideoPlayLog_WA_Cache(long lngid_VideoPlayLog)
{
string strAction = "GetObjByid_VideoPlayLog_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoPlayLogEN objvVideoPlayLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_VideoPlayLog"] = lngid_VideoPlayLog.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvVideoPlayLogEN = JsonConvert.DeserializeObject<clsvVideoPlayLogEN>((string)jobjReturn["ReturnObj"]);
return objvVideoPlayLogEN;
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
public static clsvVideoPlayLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoPlayLogEN objvVideoPlayLogEN = null;
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
objvVideoPlayLogEN = JsonConvert.DeserializeObject<clsvVideoPlayLogEN>((string)jobjReturn["ReturnObj"]);
return objvVideoPlayLogEN;
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
 /// <param name = "lngid_VideoPlayLog">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvVideoPlayLogEN GetObjByid_VideoPlayLog_Cache(long lngid_VideoPlayLog)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName_S);
List<clsvVideoPlayLogEN> arrvVideoPlayLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoPlayLogEN> arrvVideoPlayLogObjLst_Sel =
from objvVideoPlayLogEN in arrvVideoPlayLogObjLst_Cache
where objvVideoPlayLogEN.id_VideoPlayLog == lngid_VideoPlayLog
select objvVideoPlayLogEN;
if (arrvVideoPlayLogObjLst_Sel.Count() == 0)
{
   clsvVideoPlayLogEN obj = clsvVideoPlayLogWApi.GetObjByid_VideoPlayLog(lngid_VideoPlayLog);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoPlayLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLogEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoPlayLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLogEN> GetObjLstById_VideoPlayLogLst(List<long> arrId_VideoPlayLog)
{
 List<clsvVideoPlayLogEN> arrObjLst = null; 
string strAction = "GetObjLstById_VideoPlayLogLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoPlayLog);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_VideoPlayLog">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvVideoPlayLogEN> GetObjLstById_VideoPlayLogLst_Cache(List<long> arrId_VideoPlayLog)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName_S);
List<clsvVideoPlayLogEN> arrvVideoPlayLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoPlayLogEN> arrvVideoPlayLogObjLst_Sel =
from objvVideoPlayLogEN in arrvVideoPlayLogObjLst_Cache
where arrId_VideoPlayLog.Contains(objvVideoPlayLogEN.id_VideoPlayLog)
select objvVideoPlayLogEN;
return arrvVideoPlayLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLogEN> GetObjLstById_VideoPlayLogLst_WA_Cache(List<long> arrId_VideoPlayLog)
{
 List<clsvVideoPlayLogEN> arrObjLst = null; 
string strAction = "GetObjLstById_VideoPlayLogLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_VideoPlayLog);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoPlayLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoPlayLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoPlayLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoPlayLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_VideoPlayLog)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_VideoPlayLog"] = lngid_VideoPlayLog.ToString()
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
 /// <param name = "objvVideoPlayLogENS">源对象</param>
 /// <param name = "objvVideoPlayLogENT">目标对象</param>
 public static void CopyTo(clsvVideoPlayLogEN objvVideoPlayLogENS, clsvVideoPlayLogEN objvVideoPlayLogENT)
{
try
{
objvVideoPlayLogENT.id_VideoPlayLog = objvVideoPlayLogENS.id_VideoPlayLog; //视频播放日志流水号
objvVideoPlayLogENT.FuncModuleId = objvVideoPlayLogENS.FuncModuleId; //功能模块Id
objvVideoPlayLogENT.FuncModuleName_Sim = objvVideoPlayLogENS.FuncModuleName_Sim; //功能模块简称
objvVideoPlayLogENT.Id_Case = objvVideoPlayLogENS.Id_Case; //案例流水号
objvVideoPlayLogENT.VideoLibName = objvVideoPlayLogENS.VideoLibName; //视频名称
objvVideoPlayLogENT.VideoUrl = objvVideoPlayLogENS.VideoUrl; //视频Url
objvVideoPlayLogENT.CoverPicUrl = objvVideoPlayLogENS.CoverPicUrl; //封面Url
objvVideoPlayLogENT.LikeNum = objvVideoPlayLogENS.LikeNum; //点赞数
objvVideoPlayLogENT.PlayNum = objvVideoPlayLogENS.PlayNum; //播放数
objvVideoPlayLogENT.UserId = objvVideoPlayLogENS.UserId; //用户ID
objvVideoPlayLogENT.PlayDate = objvVideoPlayLogENS.PlayDate; //播放日期
objvVideoPlayLogENT.Memo = objvVideoPlayLogENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvVideoPlayLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoPlayLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoPlayLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoPlayLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoPlayLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoPlayLogEN.AttributeName)
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
if (clsVideoPlayLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoPlayLogWApi没有刷新缓存机制(clsVideoPlayLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibWApi没有刷新缓存机制(clsVideoLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeWApi没有刷新缓存机制(clsVideoLibTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsVideoLikeLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLikeLogWApi没有刷新缓存机制(clsVideoLikeLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_VideoPlayLog");
//if (arrvVideoPlayLogObjLst_Cache == null)
//{
//arrvVideoPlayLogObjLst_Cache = await clsvVideoPlayLogWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName_S);
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
public static List<clsvVideoPlayLogEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoPlayLogEN._CurrTabName_S);
List<clsvVideoPlayLogEN> arrvVideoPlayLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoPlayLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoPlayLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoPlayLog.id_VideoPlayLog, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoPlayLog.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.CoverPicUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.LikeNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoPlayLog.PlayNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoPlayLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.PlayDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog.Memo, Type.GetType("System.String"));
foreach (clsvVideoPlayLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoPlayLog.id_VideoPlayLog] = objInFor[convVideoPlayLog.id_VideoPlayLog];
objDR[convVideoPlayLog.FuncModuleId] = objInFor[convVideoPlayLog.FuncModuleId];
objDR[convVideoPlayLog.FuncModuleName_Sim] = objInFor[convVideoPlayLog.FuncModuleName_Sim];
objDR[convVideoPlayLog.Id_Case] = objInFor[convVideoPlayLog.Id_Case];
objDR[convVideoPlayLog.VideoLibName] = objInFor[convVideoPlayLog.VideoLibName];
objDR[convVideoPlayLog.VideoUrl] = objInFor[convVideoPlayLog.VideoUrl];
objDR[convVideoPlayLog.CoverPicUrl] = objInFor[convVideoPlayLog.CoverPicUrl];
objDR[convVideoPlayLog.LikeNum] = objInFor[convVideoPlayLog.LikeNum];
objDR[convVideoPlayLog.PlayNum] = objInFor[convVideoPlayLog.PlayNum];
objDR[convVideoPlayLog.UserId] = objInFor[convVideoPlayLog.UserId];
objDR[convVideoPlayLog.PlayDate] = objInFor[convVideoPlayLog.PlayDate];
objDR[convVideoPlayLog.Memo] = objInFor[convVideoPlayLog.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}