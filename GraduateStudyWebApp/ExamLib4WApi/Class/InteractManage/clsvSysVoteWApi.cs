
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysVoteWApi
 表名:vSysVote(01120633)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:11
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
public static class clsvSysVoteWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetVoteId(this clsvSysVoteEN objvSysVoteEN, long lngVoteId, string strComparisonOp="")
	{
objvSysVoteEN.VoteId = lngVoteId; //点赞Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.VoteId) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.VoteId, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.VoteId] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetTableKey(this clsvSysVoteEN objvSysVoteEN, string strTableKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableKey, 20, convSysVote.TableKey);
objvSysVoteEN.TableKey = strTableKey; //表主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.TableKey) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.TableKey, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.TableKey] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetPubParentId(this clsvSysVoteEN objvSysVoteEN, string strPubParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPubParentId, 20, convSysVote.PubParentId);
objvSysVoteEN.PubParentId = strPubParentId; //公共父Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.PubParentId) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.PubParentId, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.PubParentId] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetVoteTypeId(this clsvSysVoteEN objvSysVoteEN, string strVoteTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVoteTypeId, 2, convSysVote.VoteTypeId);
clsCheckSql.CheckFieldForeignKey(strVoteTypeId, 2, convSysVote.VoteTypeId);
objvSysVoteEN.VoteTypeId = strVoteTypeId; //点赞类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.VoteTypeId) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.VoteTypeId, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.VoteTypeId] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetVoteTypeName(this clsvSysVoteEN objvSysVoteEN, string strVoteTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVoteTypeName, 100, convSysVote.VoteTypeName);
objvSysVoteEN.VoteTypeName = strVoteTypeName; //点赞类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.VoteTypeName) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.VoteTypeName, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.VoteTypeName] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetUpdUser(this clsvSysVoteEN objvSysVoteEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysVote.UpdUser);
objvSysVoteEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.UpdUser) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.UpdUser, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.UpdUser] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetVoteTable(this clsvSysVoteEN objvSysVoteEN, string strVoteTable, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVoteTable, 100, convSysVote.VoteTable);
objvSysVoteEN.VoteTable = strVoteTable; //点赞表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.VoteTable) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.VoteTable, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.VoteTable] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetUpdDate(this clsvSysVoteEN objvSysVoteEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysVote.UpdDate);
objvSysVoteEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.UpdDate) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.UpdDate, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.UpdDate] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetVoteTableId(this clsvSysVoteEN objvSysVoteEN, string strVoteTableId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVoteTableId, 50, convSysVote.VoteTableId);
objvSysVoteEN.VoteTableId = strVoteTableId; //点赞表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.VoteTableId) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.VoteTableId, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.VoteTableId] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetMemo(this clsvSysVoteEN objvSysVoteEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysVote.Memo);
objvSysVoteEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.Memo) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.Memo, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.Memo] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN Setid_CurrEduCls(this clsvSysVoteEN objvSysVoteEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convSysVote.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convSysVote.id_CurrEduCls);
objvSysVoteEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.id_CurrEduCls) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.id_CurrEduCls, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.id_CurrEduCls] = strComparisonOp;
}
}
return objvSysVoteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSysVoteEN SetUserId(this clsvSysVoteEN objvSysVoteEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convSysVote.UserId);
objvSysVoteEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.UserId) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.UserId, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.UserId] = strComparisonOp;
}
}
return objvSysVoteEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysVoteEN objvSysVote_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysVote_Cond.IsUpdated(convSysVote.VoteId) == true)
{
string strComparisonOp_VoteId = objvSysVote_Cond.dicFldComparisonOp[convSysVote.VoteId];
strWhereCond += string.Format(" And {0} {2} {1}", convSysVote.VoteId, objvSysVote_Cond.VoteId, strComparisonOp_VoteId);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.TableKey) == true)
{
string strComparisonOp_TableKey = objvSysVote_Cond.dicFldComparisonOp[convSysVote.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.TableKey, objvSysVote_Cond.TableKey, strComparisonOp_TableKey);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.PubParentId) == true)
{
string strComparisonOp_PubParentId = objvSysVote_Cond.dicFldComparisonOp[convSysVote.PubParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.PubParentId, objvSysVote_Cond.PubParentId, strComparisonOp_PubParentId);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.VoteTypeId) == true)
{
string strComparisonOp_VoteTypeId = objvSysVote_Cond.dicFldComparisonOp[convSysVote.VoteTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTypeId, objvSysVote_Cond.VoteTypeId, strComparisonOp_VoteTypeId);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.VoteTypeName) == true)
{
string strComparisonOp_VoteTypeName = objvSysVote_Cond.dicFldComparisonOp[convSysVote.VoteTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTypeName, objvSysVote_Cond.VoteTypeName, strComparisonOp_VoteTypeName);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvSysVote_Cond.dicFldComparisonOp[convSysVote.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.UpdUser, objvSysVote_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.VoteTable) == true)
{
string strComparisonOp_VoteTable = objvSysVote_Cond.dicFldComparisonOp[convSysVote.VoteTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTable, objvSysVote_Cond.VoteTable, strComparisonOp_VoteTable);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvSysVote_Cond.dicFldComparisonOp[convSysVote.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.UpdDate, objvSysVote_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.VoteTableId) == true)
{
string strComparisonOp_VoteTableId = objvSysVote_Cond.dicFldComparisonOp[convSysVote.VoteTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTableId, objvSysVote_Cond.VoteTableId, strComparisonOp_VoteTableId);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.Memo) == true)
{
string strComparisonOp_Memo = objvSysVote_Cond.dicFldComparisonOp[convSysVote.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.Memo, objvSysVote_Cond.Memo, strComparisonOp_Memo);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvSysVote_Cond.dicFldComparisonOp[convSysVote.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.id_CurrEduCls, objvSysVote_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvSysVote_Cond.IsUpdated(convSysVote.UserId) == true)
{
string strComparisonOp_UserId = objvSysVote_Cond.dicFldComparisonOp[convSysVote.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.UserId, objvSysVote_Cond.UserId, strComparisonOp_UserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v系统点赞视图(vSysVote)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSysVoteWApi
{
private static readonly string mstrApiControllerName = "vSysVoteApi";

 public clsvSysVoteWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngVoteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysVoteEN GetObjByVoteId(long lngVoteId)
{
string strAction = "GetObjByVoteId";
string strErrMsg = string.Empty;
string strResult = "";
clsvSysVoteEN objvSysVoteEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["VoteId"] = lngVoteId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSysVoteEN = JsonConvert.DeserializeObject<clsvSysVoteEN>((string)jobjReturn["ReturnObj"]);
return objvSysVoteEN;
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
 /// <param name = "lngVoteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysVoteEN GetObjByVoteId_WA_Cache(long lngVoteId)
{
string strAction = "GetObjByVoteId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSysVoteEN objvSysVoteEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["VoteId"] = lngVoteId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSysVoteEN = JsonConvert.DeserializeObject<clsvSysVoteEN>((string)jobjReturn["ReturnObj"]);
return objvSysVoteEN;
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
public static clsvSysVoteEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSysVoteEN objvSysVoteEN = null;
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
objvSysVoteEN = JsonConvert.DeserializeObject<clsvSysVoteEN>((string)jobjReturn["ReturnObj"]);
return objvSysVoteEN;
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
 /// <param name = "lngVoteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysVoteEN GetObjByVoteId_Cache(long lngVoteId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName_S);
List<clsvSysVoteEN> arrvSysVoteObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSysVoteEN> arrvSysVoteObjLst_Sel =
from objvSysVoteEN in arrvSysVoteObjLst_Cache
where objvSysVoteEN.VoteId == lngVoteId
select objvSysVoteEN;
if (arrvSysVoteObjLst_Sel.Count() == 0)
{
   clsvSysVoteEN obj = clsvSysVoteWApi.GetObjByVoteId(lngVoteId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSysVoteObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLst(string strWhereCond)
{
 List<clsvSysVoteEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysVoteEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSysVoteEN> GetObjLstByVoteIdLst(List<long> arrVoteId)
{
 List<clsvSysVoteEN> arrObjLst = null; 
string strAction = "GetObjLstByVoteIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrVoteId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysVoteEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngVoteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvSysVoteEN> GetObjLstByVoteIdLst_Cache(List<long> arrVoteId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName_S);
List<clsvSysVoteEN> arrvSysVoteObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSysVoteEN> arrvSysVoteObjLst_Sel =
from objvSysVoteEN in arrvSysVoteObjLst_Cache
where arrVoteId.Contains(objvSysVoteEN.VoteId)
select objvSysVoteEN;
return arrvSysVoteObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstByVoteIdLst_WA_Cache(List<long> arrVoteId)
{
 List<clsvSysVoteEN> arrObjLst = null; 
string strAction = "GetObjLstByVoteIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrVoteId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysVoteEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSysVoteEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSysVoteEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysVoteEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSysVoteEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSysVoteEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysVoteEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSysVoteEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSysVoteEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysVoteEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSysVoteEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSysVoteEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSysVoteEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngVoteId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["VoteId"] = lngVoteId.ToString()
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
 /// <param name = "objvSysVoteENS">源对象</param>
 /// <param name = "objvSysVoteENT">目标对象</param>
 public static void CopyTo(clsvSysVoteEN objvSysVoteENS, clsvSysVoteEN objvSysVoteENT)
{
try
{
objvSysVoteENT.VoteId = objvSysVoteENS.VoteId; //点赞Id
objvSysVoteENT.TableKey = objvSysVoteENS.TableKey; //表主键
objvSysVoteENT.PubParentId = objvSysVoteENS.PubParentId; //公共父Id
objvSysVoteENT.VoteTypeId = objvSysVoteENS.VoteTypeId; //点赞类型Id
objvSysVoteENT.VoteTypeName = objvSysVoteENS.VoteTypeName; //点赞类型名称
objvSysVoteENT.UpdUser = objvSysVoteENS.UpdUser; //修改人
objvSysVoteENT.VoteTable = objvSysVoteENS.VoteTable; //点赞表
objvSysVoteENT.UpdDate = objvSysVoteENS.UpdDate; //修改日期
objvSysVoteENT.VoteTableId = objvSysVoteENS.VoteTableId; //点赞表Id
objvSysVoteENT.Memo = objvSysVoteENS.Memo; //备注
objvSysVoteENT.id_CurrEduCls = objvSysVoteENS.id_CurrEduCls; //当前教学班流水号
objvSysVoteENT.UserId = objvSysVoteENS.UserId; //用户ID
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
public static DataTable ToDataTable(List<clsvSysVoteEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSysVoteEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSysVoteEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSysVoteEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSysVoteEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSysVoteEN.AttributeName)
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
if (clsSysVoteTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysVoteTypeWApi没有刷新缓存机制(clsSysVoteTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysVoteWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysVoteWApi没有刷新缓存机制(clsSysVoteWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VoteId");
//if (arrvSysVoteObjLst_Cache == null)
//{
//arrvSysVoteObjLst_Cache = await clsvSysVoteWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName_S);
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
public static List<clsvSysVoteEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName_S);
List<clsvSysVoteEN> arrvSysVoteObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSysVoteObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSysVoteEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSysVote.VoteId, Type.GetType("System.Int64"));
objDT.Columns.Add(convSysVote.TableKey, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.PubParentId, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.VoteTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.VoteTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.VoteTable, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.VoteTableId, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convSysVote.UserId, Type.GetType("System.String"));
foreach (clsvSysVoteEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSysVote.VoteId] = objInFor[convSysVote.VoteId];
objDR[convSysVote.TableKey] = objInFor[convSysVote.TableKey];
objDR[convSysVote.PubParentId] = objInFor[convSysVote.PubParentId];
objDR[convSysVote.VoteTypeId] = objInFor[convSysVote.VoteTypeId];
objDR[convSysVote.VoteTypeName] = objInFor[convSysVote.VoteTypeName];
objDR[convSysVote.UpdUser] = objInFor[convSysVote.UpdUser];
objDR[convSysVote.VoteTable] = objInFor[convSysVote.VoteTable];
objDR[convSysVote.UpdDate] = objInFor[convSysVote.UpdDate];
objDR[convSysVote.VoteTableId] = objInFor[convSysVote.VoteTableId];
objDR[convSysVote.Memo] = objInFor[convSysVote.Memo];
objDR[convSysVote.id_CurrEduCls] = objInFor[convSysVote.id_CurrEduCls];
objDR[convSysVote.UserId] = objInFor[convSysVote.UserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}