
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperLikeLogWApi
 表名:vPaperLikeLog(01120570)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:15
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
public static class clsvPaperLikeLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetPaperLikeLogId(this clsvPaperLikeLogEN objvPaperLikeLogEN, long lngPaperLikeLogId, string strComparisonOp="")
	{
objvPaperLikeLogEN.PaperLikeLogId = lngPaperLikeLogId; //论文点赞表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.PaperLikeLogId) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.PaperLikeLogId, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.PaperLikeLogId] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetPaperId(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperLikeLog.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperLikeLog.PaperId);
objvPaperLikeLogEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.PaperId) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.PaperId, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.PaperId] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetUpdUser(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convPaperLikeLog.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperLikeLog.UpdUser);
objvPaperLikeLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.UpdUser) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.UpdUser, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.UpdUser] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetUpdDate(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperLikeLog.UpdDate);
objvPaperLikeLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.UpdDate) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.UpdDate, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.UpdDate] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetMemo(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperLikeLog.Memo);
objvPaperLikeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.Memo) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.Memo, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.Memo] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetPaperName(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperName, 500, convPaperLikeLog.PaperName);
objvPaperLikeLogEN.PaperName = strPaperName; //主题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.PaperName) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.PaperName, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.PaperName] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetPaperTitle(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperLikeLog.PaperTitle);
objvPaperLikeLogEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.PaperTitle) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.PaperTitle, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.PaperTitle] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetAuthor(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperLikeLog.Author);
objvPaperLikeLogEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.Author) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.Author, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.Author] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetKeyword(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperLikeLog.Keyword);
objvPaperLikeLogEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.Keyword) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.Keyword, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.Keyword] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetBrowseNumber(this clsvPaperLikeLogEN objvPaperLikeLogEN, int intBrowseNumber, string strComparisonOp="")
	{
objvPaperLikeLogEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.BrowseNumber) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.BrowseNumber, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.BrowseNumber] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperLikeLogEN SetUserName(this clsvPaperLikeLogEN objvPaperLikeLogEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convPaperLikeLog.UserName);
objvPaperLikeLogEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperLikeLog.UserName) == false)
{
objvPaperLikeLogEN.dicFldComparisonOp.Add(convPaperLikeLog.UserName, strComparisonOp);
}
else
{
objvPaperLikeLogEN.dicFldComparisonOp[convPaperLikeLog.UserName] = strComparisonOp;
}
}
return objvPaperLikeLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperLikeLogEN objvPaperLikeLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.PaperLikeLogId) == true)
{
string strComparisonOp_PaperLikeLogId = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.PaperLikeLogId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperLikeLog.PaperLikeLogId, objvPaperLikeLog_Cond.PaperLikeLogId, strComparisonOp_PaperLikeLogId);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.PaperId) == true)
{
string strComparisonOp_PaperId = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.PaperId, objvPaperLikeLog_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.UpdUser, objvPaperLikeLog_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.UpdDate, objvPaperLikeLog_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.Memo) == true)
{
string strComparisonOp_Memo = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.Memo, objvPaperLikeLog_Cond.Memo, strComparisonOp_Memo);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.PaperName) == true)
{
string strComparisonOp_PaperName = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.PaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.PaperName, objvPaperLikeLog_Cond.PaperName, strComparisonOp_PaperName);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.PaperTitle, objvPaperLikeLog_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.Author) == true)
{
string strComparisonOp_Author = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.Author, objvPaperLikeLog_Cond.Author, strComparisonOp_Author);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.Keyword) == true)
{
string strComparisonOp_Keyword = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.Keyword, objvPaperLikeLog_Cond.Keyword, strComparisonOp_Keyword);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.BrowseNumber) == true)
{
string strComparisonOp_BrowseNumber = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperLikeLog.BrowseNumber, objvPaperLikeLog_Cond.BrowseNumber, strComparisonOp_BrowseNumber);
}
if (objvPaperLikeLog_Cond.IsUpdated(convPaperLikeLog.UserName) == true)
{
string strComparisonOp_UserName = objvPaperLikeLog_Cond.dicFldComparisonOp[convPaperLikeLog.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperLikeLog.UserName, objvPaperLikeLog_Cond.UserName, strComparisonOp_UserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v论文点赞表(vPaperLikeLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPaperLikeLogWApi
{
private static readonly string mstrApiControllerName = "vPaperLikeLogApi";

 public clsvPaperLikeLogWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperLikeLogEN GetObjByPaperLikeLogId(long lngPaperLikeLogId)
{
string strAction = "GetObjByPaperLikeLogId";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperLikeLogEN objvPaperLikeLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperLikeLogId"] = lngPaperLikeLogId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperLikeLogEN = JsonConvert.DeserializeObject<clsvPaperLikeLogEN>((string)jobjReturn["ReturnObj"]);
return objvPaperLikeLogEN;
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
 /// <param name = "lngPaperLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperLikeLogEN GetObjByPaperLikeLogId_WA_Cache(long lngPaperLikeLogId)
{
string strAction = "GetObjByPaperLikeLogId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperLikeLogEN objvPaperLikeLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperLikeLogId"] = lngPaperLikeLogId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperLikeLogEN = JsonConvert.DeserializeObject<clsvPaperLikeLogEN>((string)jobjReturn["ReturnObj"]);
return objvPaperLikeLogEN;
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
public static clsvPaperLikeLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperLikeLogEN objvPaperLikeLogEN = null;
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
objvPaperLikeLogEN = JsonConvert.DeserializeObject<clsvPaperLikeLogEN>((string)jobjReturn["ReturnObj"]);
return objvPaperLikeLogEN;
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
 /// <param name = "lngPaperLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperLikeLogEN GetObjByPaperLikeLogId_Cache(long lngPaperLikeLogId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName_S);
List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperLikeLogEN> arrvPaperLikeLogObjLst_Sel =
from objvPaperLikeLogEN in arrvPaperLikeLogObjLst_Cache
where objvPaperLikeLogEN.PaperLikeLogId == lngPaperLikeLogId
select objvPaperLikeLogEN;
if (arrvPaperLikeLogObjLst_Sel.Count() == 0)
{
   clsvPaperLikeLogEN obj = clsvPaperLikeLogWApi.GetObjByPaperLikeLogId(lngPaperLikeLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPaperLikeLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperLikeLogEN> GetObjLst(string strWhereCond)
{
 List<clsvPaperLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperLikeLogEN> GetObjLstByPaperLikeLogIdLst(List<long> arrPaperLikeLogId)
{
 List<clsvPaperLikeLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperLikeLogIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperLikeLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPaperLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPaperLikeLogEN> GetObjLstByPaperLikeLogIdLst_Cache(List<long> arrPaperLikeLogId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName_S);
List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperLikeLogEN> arrvPaperLikeLogObjLst_Sel =
from objvPaperLikeLogEN in arrvPaperLikeLogObjLst_Cache
where arrPaperLikeLogId.Contains(objvPaperLikeLogEN.PaperLikeLogId)
select objvPaperLikeLogEN;
return arrvPaperLikeLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperLikeLogEN> GetObjLstByPaperLikeLogIdLst_WA_Cache(List<long> arrPaperLikeLogId)
{
 List<clsvPaperLikeLogEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperLikeLogIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperLikeLogId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperLikeLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPaperLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperLikeLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPaperLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperLikeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPaperLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperLikeLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPaperLikeLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperLikeLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngPaperLikeLogId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperLikeLogId"] = lngPaperLikeLogId.ToString()
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
 /// <param name = "objvPaperLikeLogENS">源对象</param>
 /// <param name = "objvPaperLikeLogENT">目标对象</param>
 public static void CopyTo(clsvPaperLikeLogEN objvPaperLikeLogENS, clsvPaperLikeLogEN objvPaperLikeLogENT)
{
try
{
objvPaperLikeLogENT.PaperLikeLogId = objvPaperLikeLogENS.PaperLikeLogId; //论文点赞表Id
objvPaperLikeLogENT.PaperId = objvPaperLikeLogENS.PaperId; //论文Id
objvPaperLikeLogENT.UpdUser = objvPaperLikeLogENS.UpdUser; //修改人
objvPaperLikeLogENT.UpdDate = objvPaperLikeLogENS.UpdDate; //修改日期
objvPaperLikeLogENT.Memo = objvPaperLikeLogENS.Memo; //备注
objvPaperLikeLogENT.PaperName = objvPaperLikeLogENS.PaperName; //主题名称
objvPaperLikeLogENT.PaperTitle = objvPaperLikeLogENS.PaperTitle; //论文标题
objvPaperLikeLogENT.Author = objvPaperLikeLogENS.Author; //作者
objvPaperLikeLogENT.Keyword = objvPaperLikeLogENS.Keyword; //关键字
objvPaperLikeLogENT.BrowseNumber = objvPaperLikeLogENS.BrowseNumber; //浏览量
objvPaperLikeLogENT.UserName = objvPaperLikeLogENS.UserName; //用户名
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
public static DataTable ToDataTable(List<clsvPaperLikeLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPaperLikeLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPaperLikeLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPaperLikeLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPaperLikeLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPaperLikeLogEN.AttributeName)
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
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperLikeLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperLikeLogWApi没有刷新缓存机制(clsPaperLikeLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperLikeLogId");
//if (arrvPaperLikeLogObjLst_Cache == null)
//{
//arrvPaperLikeLogObjLst_Cache = await clsvPaperLikeLogWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName_S);
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
public static List<clsvPaperLikeLogEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPaperLikeLogEN._CurrTabName_S);
List<clsvPaperLikeLogEN> arrvPaperLikeLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperLikeLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPaperLikeLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPaperLikeLog.PaperLikeLogId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPaperLikeLog.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.PaperName, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.Author, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convPaperLikeLog.BrowseNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperLikeLog.UserName, Type.GetType("System.String"));
foreach (clsvPaperLikeLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPaperLikeLog.PaperLikeLogId] = objInFor[convPaperLikeLog.PaperLikeLogId];
objDR[convPaperLikeLog.PaperId] = objInFor[convPaperLikeLog.PaperId];
objDR[convPaperLikeLog.UpdUser] = objInFor[convPaperLikeLog.UpdUser];
objDR[convPaperLikeLog.UpdDate] = objInFor[convPaperLikeLog.UpdDate];
objDR[convPaperLikeLog.Memo] = objInFor[convPaperLikeLog.Memo];
objDR[convPaperLikeLog.PaperName] = objInFor[convPaperLikeLog.PaperName];
objDR[convPaperLikeLog.PaperTitle] = objInFor[convPaperLikeLog.PaperTitle];
objDR[convPaperLikeLog.Author] = objInFor[convPaperLikeLog.Author];
objDR[convPaperLikeLog.Keyword] = objInFor[convPaperLikeLog.Keyword];
objDR[convPaperLikeLog.BrowseNumber] = objInFor[convPaperLikeLog.BrowseNumber];
objDR[convPaperLikeLog.UserName] = objInFor[convPaperLikeLog.UserName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}