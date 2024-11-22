
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysVoteBL
 表名:vSysVote(01120633)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvSysVoteBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngVoteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysVoteEN GetObj(this K_VoteId_vSysVote myKey)
{
clsvSysVoteEN objvSysVoteEN = clsvSysVoteBL.vSysVoteDA.GetObjByVoteId(myKey.Value);
return objvSysVoteEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetTableKey(this clsvSysVoteEN objvSysVoteEN, string strTableKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableKey, 20, convSysVote.TableKey);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetPubParentId(this clsvSysVoteEN objvSysVoteEN, string strPubParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubParentId, 20, convSysVote.PubParentId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetVoteTypeId(this clsvSysVoteEN objvSysVoteEN, string strVoteTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTypeId, 2, convSysVote.VoteTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVoteTypeId, 2, convSysVote.VoteTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetVoteTypeName(this clsvSysVoteEN objvSysVoteEN, string strVoteTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTypeName, 100, convSysVote.VoteTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetUpdUser(this clsvSysVoteEN objvSysVoteEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSysVote.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetVoteTable(this clsvSysVoteEN objvSysVoteEN, string strVoteTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTable, 100, convSysVote.VoteTable);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetUpdDate(this clsvSysVoteEN objvSysVoteEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSysVote.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetVoteTableId(this clsvSysVoteEN objvSysVoteEN, string strVoteTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTableId, 50, convSysVote.VoteTableId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetMemo(this clsvSysVoteEN objvSysVoteEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSysVote.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSysVoteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSysVoteEN SetIdCurrEduCls(this clsvSysVoteEN objvSysVoteEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convSysVote.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convSysVote.IdCurrEduCls);
}
objvSysVoteEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSysVoteEN.dicFldComparisonOp.ContainsKey(convSysVote.IdCurrEduCls) == false)
{
objvSysVoteEN.dicFldComparisonOp.Add(convSysVote.IdCurrEduCls, strComparisonOp);
}
else
{
objvSysVoteEN.dicFldComparisonOp[convSysVote.IdCurrEduCls] = strComparisonOp;
}
}
return objvSysVoteEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSysVoteENS">源对象</param>
 /// <param name = "objvSysVoteENT">目标对象</param>
 public static void CopyTo(this clsvSysVoteEN objvSysVoteENS, clsvSysVoteEN objvSysVoteENT)
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
objvSysVoteENT.IdCurrEduCls = objvSysVoteENS.IdCurrEduCls; //教学班流水号
objvSysVoteENT.LikedUserId = objvSysVoteENS.LikedUserId; //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvSysVoteENS">源对象</param>
 /// <returns>目标对象=>clsvSysVoteEN:objvSysVoteENT</returns>
 public static clsvSysVoteEN CopyTo(this clsvSysVoteEN objvSysVoteENS)
{
try
{
 clsvSysVoteEN objvSysVoteENT = new clsvSysVoteEN()
{
VoteId = objvSysVoteENS.VoteId, //点赞Id
TableKey = objvSysVoteENS.TableKey, //表主键
PubParentId = objvSysVoteENS.PubParentId, //公共父Id
VoteTypeId = objvSysVoteENS.VoteTypeId, //点赞类型Id
VoteTypeName = objvSysVoteENS.VoteTypeName, //点赞类型名称
UpdUser = objvSysVoteENS.UpdUser, //修改人
VoteTable = objvSysVoteENS.VoteTable, //点赞表
UpdDate = objvSysVoteENS.UpdDate, //修改日期
VoteTableId = objvSysVoteENS.VoteTableId, //点赞表Id
Memo = objvSysVoteENS.Memo, //备注
IdCurrEduCls = objvSysVoteENS.IdCurrEduCls, //教学班流水号
LikedUserId = objvSysVoteENS.LikedUserId, //被点赞用户Id
};
 return objvSysVoteENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvSysVoteEN objvSysVoteEN)
{
 clsvSysVoteBL.vSysVoteDA.CheckProperty4Condition(objvSysVoteEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSysVoteEN objvSysVoteCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSysVoteCond.IsUpdated(convSysVote.VoteId) == true)
{
string strComparisonOpVoteId = objvSysVoteCond.dicFldComparisonOp[convSysVote.VoteId];
strWhereCond += string.Format(" And {0} {2} {1}", convSysVote.VoteId, objvSysVoteCond.VoteId, strComparisonOpVoteId);
}
if (objvSysVoteCond.IsUpdated(convSysVote.TableKey) == true)
{
string strComparisonOpTableKey = objvSysVoteCond.dicFldComparisonOp[convSysVote.TableKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.TableKey, objvSysVoteCond.TableKey, strComparisonOpTableKey);
}
if (objvSysVoteCond.IsUpdated(convSysVote.PubParentId) == true)
{
string strComparisonOpPubParentId = objvSysVoteCond.dicFldComparisonOp[convSysVote.PubParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.PubParentId, objvSysVoteCond.PubParentId, strComparisonOpPubParentId);
}
if (objvSysVoteCond.IsUpdated(convSysVote.VoteTypeId) == true)
{
string strComparisonOpVoteTypeId = objvSysVoteCond.dicFldComparisonOp[convSysVote.VoteTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTypeId, objvSysVoteCond.VoteTypeId, strComparisonOpVoteTypeId);
}
if (objvSysVoteCond.IsUpdated(convSysVote.VoteTypeName) == true)
{
string strComparisonOpVoteTypeName = objvSysVoteCond.dicFldComparisonOp[convSysVote.VoteTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTypeName, objvSysVoteCond.VoteTypeName, strComparisonOpVoteTypeName);
}
if (objvSysVoteCond.IsUpdated(convSysVote.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSysVoteCond.dicFldComparisonOp[convSysVote.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.UpdUser, objvSysVoteCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSysVoteCond.IsUpdated(convSysVote.VoteTable) == true)
{
string strComparisonOpVoteTable = objvSysVoteCond.dicFldComparisonOp[convSysVote.VoteTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTable, objvSysVoteCond.VoteTable, strComparisonOpVoteTable);
}
if (objvSysVoteCond.IsUpdated(convSysVote.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSysVoteCond.dicFldComparisonOp[convSysVote.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.UpdDate, objvSysVoteCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSysVoteCond.IsUpdated(convSysVote.VoteTableId) == true)
{
string strComparisonOpVoteTableId = objvSysVoteCond.dicFldComparisonOp[convSysVote.VoteTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.VoteTableId, objvSysVoteCond.VoteTableId, strComparisonOpVoteTableId);
}
if (objvSysVoteCond.IsUpdated(convSysVote.Memo) == true)
{
string strComparisonOpMemo = objvSysVoteCond.dicFldComparisonOp[convSysVote.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.Memo, objvSysVoteCond.Memo, strComparisonOpMemo);
}
if (objvSysVoteCond.IsUpdated(convSysVote.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvSysVoteCond.dicFldComparisonOp[convSysVote.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.IdCurrEduCls, objvSysVoteCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvSysVoteCond.IsUpdated(convSysVote.LikedUserId) == true)
{
string strComparisonOpLikedUserId = objvSysVoteCond.dicFldComparisonOp[convSysVote.LikedUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSysVote.LikedUserId, objvSysVoteCond.LikedUserId, strComparisonOpLikedUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSysVote
{
public virtual bool UpdRelaTabDate(long lngVoteId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v系统点赞视图(vSysVote)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSysVoteBL
{
public static RelatedActions_vSysVote relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSysVoteDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSysVoteDA vSysVoteDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSysVoteDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSysVoteBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvSysVoteEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysVoteEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vSysVote(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTable_vSysVote(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vSysVoteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrVoteIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstByVoteIdLst(List<long> arrVoteIdLst)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrVoteIdLst);
 string strWhereCond = string.Format("VoteId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrVoteIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSysVoteEN> GetObjLstByVoteIdLstCache(List<long> arrVoteIdLst)
{
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName);
List<clsvSysVoteEN> arrvSysVoteObjLstCache = GetObjLstCache();
IEnumerable <clsvSysVoteEN> arrvSysVoteObjLst_Sel =
arrvSysVoteObjLstCache
.Where(x => arrVoteIdLst.Contains(x.VoteId));
return arrvSysVoteObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLst(string strWhereCond)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSysVoteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSysVoteEN> GetSubObjLstCache(clsvSysVoteEN objvSysVoteCond)
{
List<clsvSysVoteEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysVoteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysVote.AttributeName)
{
if (objvSysVoteCond.IsUpdated(strFldName) == false) continue;
if (objvSysVoteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysVoteCond[strFldName].ToString());
}
else
{
if (objvSysVoteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysVoteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysVoteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysVoteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysVoteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysVoteCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvSysVoteEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSysVoteEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSysVoteEN> arrObjLst = new List<clsvSysVoteEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysVoteEN objvSysVoteEN = new clsvSysVoteEN();
try
{
objvSysVoteEN.VoteId = Int32.Parse(objRow[convSysVote.VoteId].ToString().Trim()); //点赞Id
objvSysVoteEN.TableKey = objRow[convSysVote.TableKey] == DBNull.Value ? null : objRow[convSysVote.TableKey].ToString().Trim(); //表主键
objvSysVoteEN.PubParentId = objRow[convSysVote.PubParentId] == DBNull.Value ? null : objRow[convSysVote.PubParentId].ToString().Trim(); //公共父Id
objvSysVoteEN.VoteTypeId = objRow[convSysVote.VoteTypeId] == DBNull.Value ? null : objRow[convSysVote.VoteTypeId].ToString().Trim(); //点赞类型Id
objvSysVoteEN.VoteTypeName = objRow[convSysVote.VoteTypeName] == DBNull.Value ? null : objRow[convSysVote.VoteTypeName].ToString().Trim(); //点赞类型名称
objvSysVoteEN.UpdUser = objRow[convSysVote.UpdUser] == DBNull.Value ? null : objRow[convSysVote.UpdUser].ToString().Trim(); //修改人
objvSysVoteEN.VoteTable = objRow[convSysVote.VoteTable] == DBNull.Value ? null : objRow[convSysVote.VoteTable].ToString().Trim(); //点赞表
objvSysVoteEN.UpdDate = objRow[convSysVote.UpdDate] == DBNull.Value ? null : objRow[convSysVote.UpdDate].ToString().Trim(); //修改日期
objvSysVoteEN.VoteTableId = objRow[convSysVote.VoteTableId] == DBNull.Value ? null : objRow[convSysVote.VoteTableId].ToString().Trim(); //点赞表Id
objvSysVoteEN.Memo = objRow[convSysVote.Memo] == DBNull.Value ? null : objRow[convSysVote.Memo].ToString().Trim(); //备注
objvSysVoteEN.IdCurrEduCls = objRow[convSysVote.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysVote.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysVoteEN.LikedUserId = objRow[convSysVote.LikedUserId] == DBNull.Value ? null : objRow[convSysVote.LikedUserId].ToString().Trim(); //被点赞用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSysVoteEN.VoteId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSysVoteEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSysVoteEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSysVote(ref clsvSysVoteEN objvSysVoteEN)
{
bool bolResult = vSysVoteDA.GetvSysVote(ref objvSysVoteEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngVoteId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSysVoteEN GetObjByVoteId(long lngVoteId)
{
clsvSysVoteEN objvSysVoteEN = vSysVoteDA.GetObjByVoteId(lngVoteId);
return objvSysVoteEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSysVoteEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSysVoteEN objvSysVoteEN = vSysVoteDA.GetFirstObj(strWhereCond);
 return objvSysVoteEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvSysVoteEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSysVoteEN objvSysVoteEN = vSysVoteDA.GetObjByDataRow(objRow);
 return objvSysVoteEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvSysVoteEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSysVoteEN objvSysVoteEN = vSysVoteDA.GetObjByDataRow(objRow);
 return objvSysVoteEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "lngVoteId">所给的关键字</param>
 /// <param name = "lstvSysVoteObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysVoteEN GetObjByVoteIdFromList(long lngVoteId, List<clsvSysVoteEN> lstvSysVoteObjLst)
{
foreach (clsvSysVoteEN objvSysVoteEN in lstvSysVoteObjLst)
{
if (objvSysVoteEN.VoteId == lngVoteId)
{
return objvSysVoteEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngVoteId;
 try
 {
 lngVoteId = new clsvSysVoteDA().GetFirstID(strWhereCond);
 return lngVoteId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vSysVoteDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vSysVoteDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngVoteId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngVoteId)
{
//检测记录是否存在
bool bolIsExist = vSysVoteDA.IsExist(lngVoteId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvSysVoteDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vSysVoteDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
objvSysVoteENT.IdCurrEduCls = objvSysVoteENS.IdCurrEduCls; //教学班流水号
objvSysVoteENT.LikedUserId = objvSysVoteENS.LikedUserId; //被点赞用户Id
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvSysVoteEN">源简化对象</param>
 public static void SetUpdFlag(clsvSysVoteEN objvSysVoteEN)
{
try
{
objvSysVoteEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSysVoteEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSysVote.VoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.VoteId = objvSysVoteEN.VoteId; //点赞Id
}
if (arrFldSet.Contains(convSysVote.TableKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.TableKey = objvSysVoteEN.TableKey == "[null]" ? null :  objvSysVoteEN.TableKey; //表主键
}
if (arrFldSet.Contains(convSysVote.PubParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.PubParentId = objvSysVoteEN.PubParentId == "[null]" ? null :  objvSysVoteEN.PubParentId; //公共父Id
}
if (arrFldSet.Contains(convSysVote.VoteTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.VoteTypeId = objvSysVoteEN.VoteTypeId == "[null]" ? null :  objvSysVoteEN.VoteTypeId; //点赞类型Id
}
if (arrFldSet.Contains(convSysVote.VoteTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.VoteTypeName = objvSysVoteEN.VoteTypeName == "[null]" ? null :  objvSysVoteEN.VoteTypeName; //点赞类型名称
}
if (arrFldSet.Contains(convSysVote.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.UpdUser = objvSysVoteEN.UpdUser == "[null]" ? null :  objvSysVoteEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSysVote.VoteTable, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.VoteTable = objvSysVoteEN.VoteTable == "[null]" ? null :  objvSysVoteEN.VoteTable; //点赞表
}
if (arrFldSet.Contains(convSysVote.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.UpdDate = objvSysVoteEN.UpdDate == "[null]" ? null :  objvSysVoteEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSysVote.VoteTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.VoteTableId = objvSysVoteEN.VoteTableId == "[null]" ? null :  objvSysVoteEN.VoteTableId; //点赞表Id
}
if (arrFldSet.Contains(convSysVote.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.Memo = objvSysVoteEN.Memo == "[null]" ? null :  objvSysVoteEN.Memo; //备注
}
if (arrFldSet.Contains(convSysVote.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.IdCurrEduCls = objvSysVoteEN.IdCurrEduCls == "[null]" ? null :  objvSysVoteEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convSysVote.LikedUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSysVoteEN.LikedUserId = objvSysVoteEN.LikedUserId == "[null]" ? null :  objvSysVoteEN.LikedUserId; //被点赞用户Id
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvSysVoteEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSysVoteEN objvSysVoteEN)
{
try
{
if (objvSysVoteEN.TableKey == "[null]") objvSysVoteEN.TableKey = null; //表主键
if (objvSysVoteEN.PubParentId == "[null]") objvSysVoteEN.PubParentId = null; //公共父Id
if (objvSysVoteEN.VoteTypeId == "[null]") objvSysVoteEN.VoteTypeId = null; //点赞类型Id
if (objvSysVoteEN.VoteTypeName == "[null]") objvSysVoteEN.VoteTypeName = null; //点赞类型名称
if (objvSysVoteEN.UpdUser == "[null]") objvSysVoteEN.UpdUser = null; //修改人
if (objvSysVoteEN.VoteTable == "[null]") objvSysVoteEN.VoteTable = null; //点赞表
if (objvSysVoteEN.UpdDate == "[null]") objvSysVoteEN.UpdDate = null; //修改日期
if (objvSysVoteEN.VoteTableId == "[null]") objvSysVoteEN.VoteTableId = null; //点赞表Id
if (objvSysVoteEN.Memo == "[null]") objvSysVoteEN.Memo = null; //备注
if (objvSysVoteEN.IdCurrEduCls == "[null]") objvSysVoteEN.IdCurrEduCls = null; //教学班流水号
if (objvSysVoteEN.LikedUserId == "[null]") objvSysVoteEN.LikedUserId = null; //被点赞用户Id
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvSysVoteEN objvSysVoteEN)
{
 vSysVoteDA.CheckProperty4Condition(objvSysVoteEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsSysVoteTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysVoteTypeBL没有刷新缓存机制(clsSysVoteTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysVoteBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysVoteBL没有刷新缓存机制(clsSysVoteBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VoteId");
//if (arrvSysVoteObjLstCache == null)
//{
//arrvSysVoteObjLstCache = vSysVoteDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngVoteId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSysVoteEN GetObjByVoteIdCache(long lngVoteId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName);
List<clsvSysVoteEN> arrvSysVoteObjLstCache = GetObjLstCache();
IEnumerable <clsvSysVoteEN> arrvSysVoteObjLst_Sel =
arrvSysVoteObjLstCache
.Where(x=> x.VoteId == lngVoteId 
);
if (arrvSysVoteObjLst_Sel.Count() == 0)
{
   clsvSysVoteEN obj = clsvSysVoteBL.GetObjByVoteId(lngVoteId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSysVoteObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysVoteEN> GetAllvSysVoteObjLstCache()
{
//获取缓存中的对象列表
List<clsvSysVoteEN> arrvSysVoteObjLstCache = GetObjLstCache(); 
return arrvSysVoteObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSysVoteEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName);
List<clsvSysVoteEN> arrvSysVoteObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSysVoteObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvSysVoteEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngVoteId)
{
if (strInFldName != convSysVote.VoteId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSysVote.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSysVote.AttributeName));
throw new Exception(strMsg);
}
var objvSysVote = clsvSysVoteBL.GetObjByVoteIdCache(lngVoteId);
if (objvSysVote == null) return "";
return objvSysVote[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvSysVoteDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvSysVoteDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSysVoteDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvSysVoteDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSysVoteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSysVoteEN objvSysVoteCond)
{
List<clsvSysVoteEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSysVoteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSysVote.AttributeName)
{
if (objvSysVoteCond.IsUpdated(strFldName) == false) continue;
if (objvSysVoteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysVoteCond[strFldName].ToString());
}
else
{
if (objvSysVoteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSysVoteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSysVoteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSysVoteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSysVoteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSysVoteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSysVoteCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvSysVoteDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vSysVoteDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vSysVoteDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}