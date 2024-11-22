﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFeatureRequirementWApi
 表名:CMFeatureRequirement(00050520)
 * 版本:2024.09.08.1(服务器:WIN-SRV103-116)
 日期:2024/09/08 10:33:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
 框架-层名:WA_访问层(CS)(WA_Access,0045)
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
using AGC.Entity;

namespace AGC4WApi
{
/// <summary>
/// 静态类
/// </summary>
public static class  clsCMFeatureRequirementWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetmId(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, long lngmId, string strComparisonOp="")
	{
objCMFeatureRequirementEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.mId) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.mId, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.mId] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmFeatureId">功能Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetCmFeatureId(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strCmFeatureId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFeatureId, conCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldLen(strCmFeatureId, 8, conCMFeatureRequirement.CmFeatureId);
clsCheckSql.CheckFieldForeignKey(strCmFeatureId, 8, conCMFeatureRequirement.CmFeatureId);
objCMFeatureRequirementEN.CmFeatureId = strCmFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.CmFeatureId) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.CmFeatureId, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.CmFeatureId] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strReqId">需求Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetReqId(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strReqId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReqId, conCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldLen(strReqId, 8, conCMFeatureRequirement.ReqId);
clsCheckSql.CheckFieldForeignKey(strReqId, 8, conCMFeatureRequirement.ReqId);
objCMFeatureRequirementEN.ReqId = strReqId; //需求Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.ReqId) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.ReqId, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.ReqId] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetOrderNum(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conCMFeatureRequirement.OrderNum);
objCMFeatureRequirementEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.OrderNum) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.OrderNum, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.OrderNum] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetPrjId(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conCMFeatureRequirement.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conCMFeatureRequirement.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conCMFeatureRequirement.PrjId);
objCMFeatureRequirementEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.PrjId) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.PrjId, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.PrjId] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetUpdDate(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMFeatureRequirement.UpdDate);
objCMFeatureRequirementEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.UpdDate) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.UpdDate, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.UpdDate] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetUpdUser(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMFeatureRequirement.UpdUser);
objCMFeatureRequirementEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.UpdUser) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.UpdUser, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.UpdUser] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetMemo(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMFeatureRequirement.Memo);
objCMFeatureRequirementEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.Memo) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.Memo, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.Memo] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToServer">是否同步到Server</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetIsSynchToServer(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, bool bolIsSynchToServer, string strComparisonOp="")
	{
objCMFeatureRequirementEN.IsSynchToServer = bolIsSynchToServer; //是否同步到Server
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.IsSynchToServer) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.IsSynchToServer, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.IsSynchToServer] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerDate">同步到Server日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetSynchToServerDate(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strSynchToServerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerDate, 20, conCMFeatureRequirement.SynchToServerDate);
objCMFeatureRequirementEN.SynchToServerDate = strSynchToServerDate; //同步到Server日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.SynchToServerDate) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.SynchToServerDate, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.SynchToServerDate] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToServerUser">同步到Server用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetSynchToServerUser(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strSynchToServerUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToServerUser, 20, conCMFeatureRequirement.SynchToServerUser);
objCMFeatureRequirementEN.SynchToServerUser = strSynchToServerUser; //同步到Server用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.SynchToServerUser) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.SynchToServerUser, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.SynchToServerUser] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsSynchToClient">是否同步到Client</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetIsSynchToClient(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, bool bolIsSynchToClient, string strComparisonOp="")
	{
objCMFeatureRequirementEN.IsSynchToClient = bolIsSynchToClient; //是否同步到Client
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.IsSynchToClient) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.IsSynchToClient, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.IsSynchToClient] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientDate">同步到Client库日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetSynchToClientDate(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strSynchToClientDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientDate, 20, conCMFeatureRequirement.SynchToClientDate);
objCMFeatureRequirementEN.SynchToClientDate = strSynchToClientDate; //同步到Client库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.SynchToClientDate) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.SynchToClientDate, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.SynchToClientDate] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynchToClientUser">同步到Client库用户</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetSynchToClientUser(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strSynchToClientUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToClientUser, 20, conCMFeatureRequirement.SynchToClientUser);
objCMFeatureRequirementEN.SynchToClientUser = strSynchToClientUser; //同步到Client库用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.SynchToClientUser) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.SynchToClientUser, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.SynchToClientUser] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要设置字段值的实体对象</param>
 /// <param name = "strSynSource">同步来源</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMFeatureRequirementEN SetSynSource(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strSynSource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynSource, 50, conCMFeatureRequirement.SynSource);
objCMFeatureRequirementEN.SynSource = strSynSource; //同步来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMFeatureRequirementEN.dicFldComparisonOp.ContainsKey(conCMFeatureRequirement.SynSource) == false)
{
objCMFeatureRequirementEN.dicFldComparisonOp.Add(conCMFeatureRequirement.SynSource, strComparisonOp);
}
else
{
objCMFeatureRequirementEN.dicFldComparisonOp[conCMFeatureRequirement.SynSource] = strComparisonOp;
}
}
return objCMFeatureRequirementEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMFeatureRequirementEN objCMFeatureRequirementCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.mId) == true)
{
string strComparisonOpmId = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFeatureRequirement.mId, objCMFeatureRequirementCond.mId, strComparisonOpmId);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.CmFeatureId) == true)
{
string strComparisonOpCmFeatureId = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.CmFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.CmFeatureId, objCMFeatureRequirementCond.CmFeatureId, strComparisonOpCmFeatureId);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.ReqId) == true)
{
string strComparisonOpReqId = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.ReqId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.ReqId, objCMFeatureRequirementCond.ReqId, strComparisonOpReqId);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMFeatureRequirement.OrderNum, objCMFeatureRequirementCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.PrjId) == true)
{
string strComparisonOpPrjId = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.PrjId, objCMFeatureRequirementCond.PrjId, strComparisonOpPrjId);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.UpdDate, objCMFeatureRequirementCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.UpdUser, objCMFeatureRequirementCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.Memo) == true)
{
string strComparisonOpMemo = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.Memo, objCMFeatureRequirementCond.Memo, strComparisonOpMemo);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.IsSynchToServer) == true)
{
if (objCMFeatureRequirementCond.IsSynchToServer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFeatureRequirement.IsSynchToServer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFeatureRequirement.IsSynchToServer);
}
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.SynchToServerDate) == true)
{
string strComparisonOpSynchToServerDate = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.SynchToServerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.SynchToServerDate, objCMFeatureRequirementCond.SynchToServerDate, strComparisonOpSynchToServerDate);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.SynchToServerUser) == true)
{
string strComparisonOpSynchToServerUser = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.SynchToServerUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.SynchToServerUser, objCMFeatureRequirementCond.SynchToServerUser, strComparisonOpSynchToServerUser);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.IsSynchToClient) == true)
{
if (objCMFeatureRequirementCond.IsSynchToClient == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCMFeatureRequirement.IsSynchToClient);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCMFeatureRequirement.IsSynchToClient);
}
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.SynchToClientDate) == true)
{
string strComparisonOpSynchToClientDate = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.SynchToClientDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.SynchToClientDate, objCMFeatureRequirementCond.SynchToClientDate, strComparisonOpSynchToClientDate);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.SynchToClientUser) == true)
{
string strComparisonOpSynchToClientUser = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.SynchToClientUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.SynchToClientUser, objCMFeatureRequirementCond.SynchToClientUser, strComparisonOpSynchToClientUser);
}
if (objCMFeatureRequirementCond.IsUpdated(conCMFeatureRequirement.SynSource) == true)
{
string strComparisonOpSynSource = objCMFeatureRequirementCond.dicFldComparisonOp[conCMFeatureRequirement.SynSource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMFeatureRequirement.SynSource, objCMFeatureRequirementCond.SynSource, strComparisonOpSynSource);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
 if (objCMFeatureRequirementEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCMFeatureRequirementEN.sfUpdFldSetStr = objCMFeatureRequirementEN.getsfUpdFldSetStr();
clsCMFeatureRequirementWApi.CheckPropertyNew(objCMFeatureRequirementEN); 
bool bolResult = clsCMFeatureRequirementWApi.UpdateRecord(objCMFeatureRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 获取唯一性条件串--CMFeatureRequirement(CM功能需求关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CMFeatureId_ReqId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMFeatureRequirementEN == null) return "";
if (objCMFeatureRequirementEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFeatureId = '{0}'", objCMFeatureRequirementEN.CmFeatureId);
 sbCondition.AppendFormat(" and ReqId = '{0}'", objCMFeatureRequirementEN.ReqId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMFeatureRequirementEN.mId);
 sbCondition.AppendFormat(" and CmFeatureId = '{0}'", objCMFeatureRequirementEN.CmFeatureId);
 sbCondition.AppendFormat(" and ReqId = '{0}'", objCMFeatureRequirementEN.ReqId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
try
{
clsCMFeatureRequirementWApi.CheckPropertyNew(objCMFeatureRequirementEN); 
bool bolResult = clsCMFeatureRequirementWApi.AddNewRecord(objCMFeatureRequirementEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strWhereCond)
{
try
{
clsCMFeatureRequirementWApi.CheckPropertyNew(objCMFeatureRequirementEN); 
bool bolResult = clsCMFeatureRequirementWApi.UpdateWithCondition(objCMFeatureRequirementEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// CM功能需求关系(CMFeatureRequirement)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCMFeatureRequirementWApi
{
private static readonly string mstrApiControllerName = "CMFeatureRequirementApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsCMFeatureRequirementWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
if (!Object.Equals(null, objCMFeatureRequirementEN.CmFeatureId) && GetStrLen(objCMFeatureRequirementEN.CmFeatureId) > 8)
{
 throw new Exception("字段[功能Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.ReqId) && GetStrLen(objCMFeatureRequirementEN.ReqId) > 8)
{
 throw new Exception("字段[需求Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.PrjId) && GetStrLen(objCMFeatureRequirementEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.UpdDate) && GetStrLen(objCMFeatureRequirementEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.UpdUser) && GetStrLen(objCMFeatureRequirementEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.Memo) && GetStrLen(objCMFeatureRequirementEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.SynchToServerDate) && GetStrLen(objCMFeatureRequirementEN.SynchToServerDate) > 20)
{
 throw new Exception("字段[同步到Server日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.SynchToServerUser) && GetStrLen(objCMFeatureRequirementEN.SynchToServerUser) > 20)
{
 throw new Exception("字段[同步到Server用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.SynchToClientDate) && GetStrLen(objCMFeatureRequirementEN.SynchToClientDate) > 20)
{
 throw new Exception("字段[同步到Client库日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.SynchToClientUser) && GetStrLen(objCMFeatureRequirementEN.SynchToClientUser) > 20)
{
 throw new Exception("字段[同步到Client库用户]的长度不能超过20!");
}
if (!Object.Equals(null, objCMFeatureRequirementEN.SynSource) && GetStrLen(objCMFeatureRequirementEN.SynSource) > 50)
{
 throw new Exception("字段[同步来源]的长度不能超过50!");
}
 objCMFeatureRequirementEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMFeatureRequirementEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsCMFeatureRequirementEN objCMFeatureRequirementEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCMFeatureRequirementEN = JsonConvert.DeserializeObject<clsCMFeatureRequirementEN>(strJson);
return objCMFeatureRequirementEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var strReturnStr = (string)jobjReturn0["returnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static clsCMFeatureRequirementEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsCMFeatureRequirementEN objCMFeatureRequirementEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objCMFeatureRequirementEN = JsonConvert.DeserializeObject<clsCMFeatureRequirementEN>(strJson);
return objCMFeatureRequirementEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureRequirementEN> GetObjLst(string strWhereCond)
{
 List<clsCMFeatureRequirementEN> arrObjLst; 
string strAction = "GetObjLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureRequirementEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// <param name = "arrMId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureRequirementEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCMFeatureRequirementEN> arrObjLst; 
string strAction = "GetObjLstByMIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureRequirementEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMFeatureRequirementEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCMFeatureRequirementEN> arrObjLst; 
string strAction = "GetTopObjLst";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureRequirementEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsCMFeatureRequirementEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCMFeatureRequirementEN> arrObjLst; 
string strAction = "GetObjLstByRange";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureRequirementEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
public static List<clsCMFeatureRequirementEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCMFeatureRequirementEN> arrObjLst; 
string strAction = "GetObjLstByPager";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureRequirementEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPagerCache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsCMFeatureRequirementEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsCMFeatureRequirementEN> arrObjLst; 
string strAction = "GetObjLstByPagerCache";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsCMFeatureRequirementEN>>(strJson);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
try
{
 clsCMFeatureRequirementEN objCMFeatureRequirementEN = clsCMFeatureRequirementWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCMFeatureRequirements(List<string> arrmId)
{
string strAction = "DelCMFeatureRequirements";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelCMFeatureRequirementsByCond(string strWhereCond)
{
string strAction = "DelCMFeatureRequirementsByCond";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureRequirementEN>(objCMFeatureRequirementEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureRequirementEN>(objCMFeatureRequirementEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
var strReturnStr = (string)jobjReturn0["returnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsCMFeatureRequirementEN objCMFeatureRequirementEN)
{
if (string.IsNullOrEmpty(objCMFeatureRequirementEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFeatureRequirementEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureRequirementEN>(objCMFeatureRequirementEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCMFeatureRequirementEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCMFeatureRequirementEN objCMFeatureRequirementEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCMFeatureRequirementEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFeatureRequirementEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objCMFeatureRequirementEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCMFeatureRequirementEN>(objCMFeatureRequirementEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngmId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn0["returnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn0["returnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
var intReturnInt = (int)jobjReturn0["returnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objCMFeatureRequirementENS">源对象</param>
 /// <param name = "objCMFeatureRequirementENT">目标对象</param>
 public static void CopyTo(clsCMFeatureRequirementEN objCMFeatureRequirementENS, clsCMFeatureRequirementEN objCMFeatureRequirementENT)
{
try
{
objCMFeatureRequirementENT.mId = objCMFeatureRequirementENS.mId; //mId
objCMFeatureRequirementENT.CmFeatureId = objCMFeatureRequirementENS.CmFeatureId; //功能Id
objCMFeatureRequirementENT.ReqId = objCMFeatureRequirementENS.ReqId; //需求Id
objCMFeatureRequirementENT.OrderNum = objCMFeatureRequirementENS.OrderNum; //序号
objCMFeatureRequirementENT.PrjId = objCMFeatureRequirementENS.PrjId; //工程ID
objCMFeatureRequirementENT.UpdDate = objCMFeatureRequirementENS.UpdDate; //修改日期
objCMFeatureRequirementENT.UpdUser = objCMFeatureRequirementENS.UpdUser; //修改者
objCMFeatureRequirementENT.Memo = objCMFeatureRequirementENS.Memo; //说明
objCMFeatureRequirementENT.IsSynchToServer = objCMFeatureRequirementENS.IsSynchToServer; //是否同步到Server
objCMFeatureRequirementENT.SynchToServerDate = objCMFeatureRequirementENS.SynchToServerDate; //同步到Server日期
objCMFeatureRequirementENT.SynchToServerUser = objCMFeatureRequirementENS.SynchToServerUser; //同步到Server用户
objCMFeatureRequirementENT.IsSynchToClient = objCMFeatureRequirementENS.IsSynchToClient; //是否同步到Client
objCMFeatureRequirementENT.SynchToClientDate = objCMFeatureRequirementENS.SynchToClientDate; //同步到Client库日期
objCMFeatureRequirementENT.SynchToClientUser = objCMFeatureRequirementENS.SynchToClientUser; //同步到Client库用户
objCMFeatureRequirementENT.SynSource = objCMFeatureRequirementENS.SynSource; //同步来源
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
public static DataTable ToDataTable(List<clsCMFeatureRequirementEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCMFeatureRequirementEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCMFeatureRequirementEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCMFeatureRequirementEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCMFeatureRequirementEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCMFeatureRequirementEN.AttributeName)
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
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCMFeatureRequirementEN._CurrTabName, strPrjId);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strPrjId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsCMFeatureRequirementWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCMFeatureRequirementEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsCMFeatureRequirementWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}
//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCMFeatureRequirementEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCMFeatureRequirement.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCMFeatureRequirement.CmFeatureId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.ReqId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCMFeatureRequirement.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.IsSynchToServer, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFeatureRequirement.SynchToServerDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.SynchToServerUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.IsSynchToClient, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCMFeatureRequirement.SynchToClientDate, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.SynchToClientUser, Type.GetType("System.String"));
objDT.Columns.Add(conCMFeatureRequirement.SynSource, Type.GetType("System.String"));
foreach (clsCMFeatureRequirementEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCMFeatureRequirement.mId] = objInFor[conCMFeatureRequirement.mId];
objDR[conCMFeatureRequirement.CmFeatureId] = objInFor[conCMFeatureRequirement.CmFeatureId];
objDR[conCMFeatureRequirement.ReqId] = objInFor[conCMFeatureRequirement.ReqId];
objDR[conCMFeatureRequirement.OrderNum] = objInFor[conCMFeatureRequirement.OrderNum];
objDR[conCMFeatureRequirement.PrjId] = objInFor[conCMFeatureRequirement.PrjId];
objDR[conCMFeatureRequirement.UpdDate] = objInFor[conCMFeatureRequirement.UpdDate];
objDR[conCMFeatureRequirement.UpdUser] = objInFor[conCMFeatureRequirement.UpdUser];
objDR[conCMFeatureRequirement.Memo] = objInFor[conCMFeatureRequirement.Memo];
objDR[conCMFeatureRequirement.IsSynchToServer] = objInFor[conCMFeatureRequirement.IsSynchToServer];
objDR[conCMFeatureRequirement.SynchToServerDate] = objInFor[conCMFeatureRequirement.SynchToServerDate];
objDR[conCMFeatureRequirement.SynchToServerUser] = objInFor[conCMFeatureRequirement.SynchToServerUser];
objDR[conCMFeatureRequirement.IsSynchToClient] = objInFor[conCMFeatureRequirement.IsSynchToClient];
objDR[conCMFeatureRequirement.SynchToClientDate] = objInFor[conCMFeatureRequirement.SynchToClientDate];
objDR[conCMFeatureRequirement.SynchToClientUser] = objInFor[conCMFeatureRequirement.SynchToClientUser];
objDR[conCMFeatureRequirement.SynSource] = objInFor[conCMFeatureRequirement.SynSource];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// CM功能需求关系(CMFeatureRequirement)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4CMFeatureRequirement : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strPrjId)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMFeatureRequirementWApi.ReFreshThisCache(strPrjId);
}
}

}