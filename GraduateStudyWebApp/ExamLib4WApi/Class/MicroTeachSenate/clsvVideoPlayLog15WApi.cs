
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoPlayLog15WApi
 表名:vVideoPlayLog15(01120299)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:45
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
public static class clsvVideoPlayLog15WApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN Setid_VideoPlayLog(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, long lngid_VideoPlayLog, string strComparisonOp="")
	{
objvVideoPlayLog15EN.id_VideoPlayLog = lngid_VideoPlayLog; //视频播放日志流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.id_VideoPlayLog) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.id_VideoPlayLog, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.id_VideoPlayLog] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetFuncModuleId(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoPlayLog15.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoPlayLog15.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoPlayLog15.FuncModuleId);
objvVideoPlayLog15EN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.FuncModuleId) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.FuncModuleId, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.FuncModuleId] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetFuncModuleName_Sim(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convVideoPlayLog15.FuncModuleName_Sim);
objvVideoPlayLog15EN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.FuncModuleName_Sim) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetId_Case(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strId_Case, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Case, convVideoPlayLog15.Id_Case);
clsCheckSql.CheckFieldLen(strId_Case, 8, convVideoPlayLog15.Id_Case);
clsCheckSql.CheckFieldForeignKey(strId_Case, 8, convVideoPlayLog15.Id_Case);
objvVideoPlayLog15EN.Id_Case = strId_Case; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.Id_Case) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.Id_Case, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.Id_Case] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetVideoLibName(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoPlayLog15.VideoLibName);
objvVideoPlayLog15EN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.VideoLibName) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.VideoLibName, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.VideoLibName] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetVideoUrl(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strVideoUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, convVideoPlayLog15.VideoUrl);
objvVideoPlayLog15EN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.VideoUrl) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.VideoUrl, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.VideoUrl] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetCoverPicUrl(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strCoverPicUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCoverPicUrl, 1000, convVideoPlayLog15.CoverPicUrl);
objvVideoPlayLog15EN.CoverPicUrl = strCoverPicUrl; //封面Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.CoverPicUrl) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.CoverPicUrl, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.CoverPicUrl] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetLikeNum(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, int intLikeNum, string strComparisonOp="")
	{
objvVideoPlayLog15EN.LikeNum = intLikeNum; //点赞数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.LikeNum) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.LikeNum, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.LikeNum] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetPlayNum(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, int intPlayNum, string strComparisonOp="")
	{
objvVideoPlayLog15EN.PlayNum = intPlayNum; //播放数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.PlayNum) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.PlayNum, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.PlayNum] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetUserId(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convVideoPlayLog15.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convVideoPlayLog15.UserId);
objvVideoPlayLog15EN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.UserId) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.UserId, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.UserId] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetPlayDate(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strPlayDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPlayDate, 20, convVideoPlayLog15.PlayDate);
objvVideoPlayLog15EN.PlayDate = strPlayDate; //播放日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.PlayDate) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.PlayDate, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.PlayDate] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoPlayLog15EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoPlayLog15EN SetMemo(this clsvVideoPlayLog15EN objvVideoPlayLog15EN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoPlayLog15.Memo);
objvVideoPlayLog15EN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoPlayLog15EN.dicFldComparisonOp.ContainsKey(convVideoPlayLog15.Memo) == false)
{
objvVideoPlayLog15EN.dicFldComparisonOp.Add(convVideoPlayLog15.Memo, strComparisonOp);
}
else
{
objvVideoPlayLog15EN.dicFldComparisonOp[convVideoPlayLog15.Memo] = strComparisonOp;
}
}
return objvVideoPlayLog15EN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoPlayLog15EN objvVideoPlayLog15_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.id_VideoPlayLog) == true)
{
string strComparisonOp_id_VideoPlayLog = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.id_VideoPlayLog];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog15.id_VideoPlayLog, objvVideoPlayLog15_Cond.id_VideoPlayLog, strComparisonOp_id_VideoPlayLog);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.FuncModuleId, objvVideoPlayLog15_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.FuncModuleName_Sim, objvVideoPlayLog15_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.Id_Case) == true)
{
string strComparisonOp_Id_Case = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.Id_Case];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.Id_Case, objvVideoPlayLog15_Cond.Id_Case, strComparisonOp_Id_Case);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.VideoLibName, objvVideoPlayLog15_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.VideoUrl) == true)
{
string strComparisonOp_VideoUrl = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.VideoUrl, objvVideoPlayLog15_Cond.VideoUrl, strComparisonOp_VideoUrl);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.CoverPicUrl) == true)
{
string strComparisonOp_CoverPicUrl = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.CoverPicUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.CoverPicUrl, objvVideoPlayLog15_Cond.CoverPicUrl, strComparisonOp_CoverPicUrl);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.LikeNum) == true)
{
string strComparisonOp_LikeNum = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.LikeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog15.LikeNum, objvVideoPlayLog15_Cond.LikeNum, strComparisonOp_LikeNum);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.PlayNum) == true)
{
string strComparisonOp_PlayNum = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.PlayNum];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoPlayLog15.PlayNum, objvVideoPlayLog15_Cond.PlayNum, strComparisonOp_PlayNum);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.UserId) == true)
{
string strComparisonOp_UserId = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.UserId, objvVideoPlayLog15_Cond.UserId, strComparisonOp_UserId);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.PlayDate) == true)
{
string strComparisonOp_PlayDate = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.PlayDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.PlayDate, objvVideoPlayLog15_Cond.PlayDate, strComparisonOp_PlayDate);
}
if (objvVideoPlayLog15_Cond.IsUpdated(convVideoPlayLog15.Memo) == true)
{
string strComparisonOp_Memo = objvVideoPlayLog15_Cond.dicFldComparisonOp[convVideoPlayLog15.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoPlayLog15.Memo, objvVideoPlayLog15_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频播放日志表15(vVideoPlayLog15)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoPlayLog15WApi
{
private static readonly string mstrApiControllerName = "vVideoPlayLog15Api";

 public clsvVideoPlayLog15WApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_VideoPlayLog">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoPlayLog15EN GetObjByid_VideoPlayLog(long lngid_VideoPlayLog)
{
string strAction = "GetObjByid_VideoPlayLog";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoPlayLog15EN objvVideoPlayLog15EN = null;
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
objvVideoPlayLog15EN = JsonConvert.DeserializeObject<clsvVideoPlayLog15EN>((string)jobjReturn["ReturnObj"]);
return objvVideoPlayLog15EN;
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
public static clsvVideoPlayLog15EN GetObjByid_VideoPlayLog_WA_Cache(long lngid_VideoPlayLog)
{
string strAction = "GetObjByid_VideoPlayLog_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoPlayLog15EN objvVideoPlayLog15EN = null;
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
objvVideoPlayLog15EN = JsonConvert.DeserializeObject<clsvVideoPlayLog15EN>((string)jobjReturn["ReturnObj"]);
return objvVideoPlayLog15EN;
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
public static clsvVideoPlayLog15EN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoPlayLog15EN objvVideoPlayLog15EN = null;
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
objvVideoPlayLog15EN = JsonConvert.DeserializeObject<clsvVideoPlayLog15EN>((string)jobjReturn["ReturnObj"]);
return objvVideoPlayLog15EN;
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
public static clsvVideoPlayLog15EN GetObjByid_VideoPlayLog_Cache(long lngid_VideoPlayLog)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName_S);
List<clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLst_Sel =
from objvVideoPlayLog15EN in arrvVideoPlayLog15ObjLst_Cache
where objvVideoPlayLog15EN.id_VideoPlayLog == lngid_VideoPlayLog
select objvVideoPlayLog15EN;
if (arrvVideoPlayLog15ObjLst_Sel.Count() == 0)
{
   clsvVideoPlayLog15EN obj = clsvVideoPlayLog15WApi.GetObjByid_VideoPlayLog(lngid_VideoPlayLog);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoPlayLog15ObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetObjLst(string strWhereCond)
{
 List<clsvVideoPlayLog15EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLog15EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLog15EN> GetObjLstById_VideoPlayLogLst(List<long> arrId_VideoPlayLog)
{
 List<clsvVideoPlayLog15EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLog15EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoPlayLog15EN> GetObjLstById_VideoPlayLogLst_Cache(List<long> arrId_VideoPlayLog)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName_S);
List<clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLst_Sel =
from objvVideoPlayLog15EN in arrvVideoPlayLog15ObjLst_Cache
where arrId_VideoPlayLog.Contains(objvVideoPlayLog15EN.id_VideoPlayLog)
select objvVideoPlayLog15EN;
return arrvVideoPlayLog15ObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoPlayLog15EN> GetObjLstById_VideoPlayLogLst_WA_Cache(List<long> arrId_VideoPlayLog)
{
 List<clsvVideoPlayLog15EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLog15EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLog15EN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoPlayLog15EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLog15EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLog15EN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoPlayLog15EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLog15EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLog15EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoPlayLog15EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLog15EN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoPlayLog15EN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoPlayLog15EN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoPlayLog15EN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoPlayLog15ENS">源对象</param>
 /// <param name = "objvVideoPlayLog15ENT">目标对象</param>
 public static void CopyTo(clsvVideoPlayLog15EN objvVideoPlayLog15ENS, clsvVideoPlayLog15EN objvVideoPlayLog15ENT)
{
try
{
objvVideoPlayLog15ENT.id_VideoPlayLog = objvVideoPlayLog15ENS.id_VideoPlayLog; //视频播放日志流水号
objvVideoPlayLog15ENT.FuncModuleId = objvVideoPlayLog15ENS.FuncModuleId; //功能模块Id
objvVideoPlayLog15ENT.FuncModuleName_Sim = objvVideoPlayLog15ENS.FuncModuleName_Sim; //功能模块简称
objvVideoPlayLog15ENT.Id_Case = objvVideoPlayLog15ENS.Id_Case; //案例流水号
objvVideoPlayLog15ENT.VideoLibName = objvVideoPlayLog15ENS.VideoLibName; //视频名称
objvVideoPlayLog15ENT.VideoUrl = objvVideoPlayLog15ENS.VideoUrl; //视频Url
objvVideoPlayLog15ENT.CoverPicUrl = objvVideoPlayLog15ENS.CoverPicUrl; //封面Url
objvVideoPlayLog15ENT.LikeNum = objvVideoPlayLog15ENS.LikeNum; //点赞数
objvVideoPlayLog15ENT.PlayNum = objvVideoPlayLog15ENS.PlayNum; //播放数
objvVideoPlayLog15ENT.UserId = objvVideoPlayLog15ENS.UserId; //用户ID
objvVideoPlayLog15ENT.PlayDate = objvVideoPlayLog15ENS.PlayDate; //播放日期
objvVideoPlayLog15ENT.Memo = objvVideoPlayLog15ENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvVideoPlayLog15EN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoPlayLog15EN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoPlayLog15EN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoPlayLog15EN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoPlayLog15EN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoPlayLog15EN.AttributeName)
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
//if (arrvVideoPlayLog15ObjLst_Cache == null)
//{
//arrvVideoPlayLog15ObjLst_Cache = await clsvVideoPlayLog15WApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName_S);
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
public static List<clsvVideoPlayLog15EN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoPlayLog15EN._CurrTabName_S);
List<clsvVideoPlayLog15EN> arrvVideoPlayLog15ObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoPlayLog15ObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoPlayLog15EN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoPlayLog15.id_VideoPlayLog, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoPlayLog15.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.Id_Case, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.VideoUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.CoverPicUrl, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.LikeNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoPlayLog15.PlayNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoPlayLog15.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.PlayDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoPlayLog15.Memo, Type.GetType("System.String"));
foreach (clsvVideoPlayLog15EN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoPlayLog15.id_VideoPlayLog] = objInFor[convVideoPlayLog15.id_VideoPlayLog];
objDR[convVideoPlayLog15.FuncModuleId] = objInFor[convVideoPlayLog15.FuncModuleId];
objDR[convVideoPlayLog15.FuncModuleName_Sim] = objInFor[convVideoPlayLog15.FuncModuleName_Sim];
objDR[convVideoPlayLog15.Id_Case] = objInFor[convVideoPlayLog15.Id_Case];
objDR[convVideoPlayLog15.VideoLibName] = objInFor[convVideoPlayLog15.VideoLibName];
objDR[convVideoPlayLog15.VideoUrl] = objInFor[convVideoPlayLog15.VideoUrl];
objDR[convVideoPlayLog15.CoverPicUrl] = objInFor[convVideoPlayLog15.CoverPicUrl];
objDR[convVideoPlayLog15.LikeNum] = objInFor[convVideoPlayLog15.LikeNum];
objDR[convVideoPlayLog15.PlayNum] = objInFor[convVideoPlayLog15.PlayNum];
objDR[convVideoPlayLog15.UserId] = objInFor[convVideoPlayLog15.UserId];
objDR[convVideoPlayLog15.PlayDate] = objInFor[convVideoPlayLog15.PlayDate];
objDR[convVideoPlayLog15.Memo] = objInFor[convVideoPlayLog15.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}