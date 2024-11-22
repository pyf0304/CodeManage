﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTab4RootFldWApi
 表名:FieldTab4RootFld(00050422)
 * 版本:2024.09.08.1(服务器:WIN-SRV103-116)
 日期:2024/09/08 10:34:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsFieldTab4RootFldWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetmId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, long lngmId, string strComparisonOp="")
	{
objFieldTab4RootFldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.mId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.mId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.mId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetTabId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, conFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, conFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, conFieldTab4RootFld.TabId);
objFieldTab4RootFldEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.TabId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.TabId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.TabId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetFldId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, conFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, conFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conFieldTab4RootFld.FldId);
objFieldTab4RootFldEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.FldId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.FldId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.FldId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsPrimaryKey">是否主键</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetIsPrimaryKey(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsPrimaryKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsPrimaryKey, conFieldTab4RootFld.IsPrimaryKey);
objFieldTab4RootFldEN.IsPrimaryKey = bolIsPrimaryKey; //是否主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.IsPrimaryKey) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.IsPrimaryKey, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.IsPrimaryKey] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsRootFld">是否根字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetIsRootFld(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, bool bolIsRootFld, string strComparisonOp="")
	{
objFieldTab4RootFldEN.IsRootFld = bolIsRootFld; //是否根字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.IsRootFld) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.IsRootFld, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.IsRootFld] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRoot4TabId">主根表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetRoot4TabId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strRoot4TabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoot4TabId, 8, conFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckFieldForeignKey(strRoot4TabId, 8, conFieldTab4RootFld.Root4TabId);
objFieldTab4RootFldEN.Root4TabId = strRoot4TabId; //主根表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.Root4TabId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.Root4TabId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.Root4TabId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootFldId">根字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetRootFldId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strRootFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRootFldId, 8, conFieldTab4RootFld.RootFldId);
clsCheckSql.CheckFieldForeignKey(strRootFldId, 8, conFieldTab4RootFld.RootFldId);
objFieldTab4RootFldEN.RootFldId = strRootFldId; //根字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.RootFldId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.RootFldId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.RootFldId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strRootTabId">根表Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetRootTabId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strRootTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRootTabId, 8, conFieldTab4RootFld.RootTabId);
clsCheckSql.CheckFieldForeignKey(strRootTabId, 8, conFieldTab4RootFld.RootTabId);
objFieldTab4RootFldEN.RootTabId = strRootTabId; //根表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.RootTabId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.RootTabId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.RootTabId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetPrjId(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conFieldTab4RootFld.PrjId);
objFieldTab4RootFldEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.PrjId) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.PrjId, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.PrjId] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetUpdUser(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFieldTab4RootFld.UpdUser);
objFieldTab4RootFldEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.UpdUser) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.UpdUser, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.UpdUser] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetUpdDate(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFieldTab4RootFld.UpdDate);
objFieldTab4RootFldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.UpdDate) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.UpdDate, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.UpdDate] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFieldTab4RootFldEN SetMemo(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFieldTab4RootFld.Memo);
objFieldTab4RootFldEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFieldTab4RootFldEN.dicFldComparisonOp.ContainsKey(conFieldTab4RootFld.Memo) == false)
{
objFieldTab4RootFldEN.dicFldComparisonOp.Add(conFieldTab4RootFld.Memo, strComparisonOp);
}
else
{
objFieldTab4RootFldEN.dicFldComparisonOp[conFieldTab4RootFld.Memo] = strComparisonOp;
}
}
return objFieldTab4RootFldEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFieldTab4RootFldEN objFieldTab4RootFldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.mId) == true)
{
string strComparisonOpmId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFieldTab4RootFld.mId, objFieldTab4RootFldCond.mId, strComparisonOpmId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.TabId) == true)
{
string strComparisonOpTabId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.TabId, objFieldTab4RootFldCond.TabId, strComparisonOpTabId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.FldId) == true)
{
string strComparisonOpFldId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.FldId, objFieldTab4RootFldCond.FldId, strComparisonOpFldId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.IsPrimaryKey) == true)
{
if (objFieldTab4RootFldCond.IsPrimaryKey == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab4RootFld.IsPrimaryKey);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab4RootFld.IsPrimaryKey);
}
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.IsRootFld) == true)
{
if (objFieldTab4RootFldCond.IsRootFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFieldTab4RootFld.IsRootFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFieldTab4RootFld.IsRootFld);
}
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.Root4TabId) == true)
{
string strComparisonOpRoot4TabId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.Root4TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.Root4TabId, objFieldTab4RootFldCond.Root4TabId, strComparisonOpRoot4TabId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.RootFldId) == true)
{
string strComparisonOpRootFldId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.RootFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.RootFldId, objFieldTab4RootFldCond.RootFldId, strComparisonOpRootFldId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.RootTabId) == true)
{
string strComparisonOpRootTabId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.RootTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.RootTabId, objFieldTab4RootFldCond.RootTabId, strComparisonOpRootTabId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.PrjId) == true)
{
string strComparisonOpPrjId = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.PrjId, objFieldTab4RootFldCond.PrjId, strComparisonOpPrjId);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.UpdUser) == true)
{
string strComparisonOpUpdUser = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.UpdUser, objFieldTab4RootFldCond.UpdUser, strComparisonOpUpdUser);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.UpdDate) == true)
{
string strComparisonOpUpdDate = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.UpdDate, objFieldTab4RootFldCond.UpdDate, strComparisonOpUpdDate);
}
if (objFieldTab4RootFldCond.IsUpdated(conFieldTab4RootFld.Memo) == true)
{
string strComparisonOpMemo = objFieldTab4RootFldCond.dicFldComparisonOp[conFieldTab4RootFld.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFieldTab4RootFld.Memo, objFieldTab4RootFldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 if (objFieldTab4RootFldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFieldTab4RootFldEN.sfUpdFldSetStr = objFieldTab4RootFldEN.getsfUpdFldSetStr();
clsFieldTab4RootFldWApi.CheckPropertyNew(objFieldTab4RootFldEN); 
bool bolResult = clsFieldTab4RootFldWApi.UpdateRecord(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldWApi.ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
 /// 获取唯一性条件串--FieldTab4RootFld(工程字段4RootFld), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TabId_FldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFieldTab4RootFldEN == null) return "";
if (objFieldTab4RootFldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objFieldTab4RootFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objFieldTab4RootFldEN.FldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFieldTab4RootFldEN.mId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objFieldTab4RootFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objFieldTab4RootFldEN.FldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
try
{
clsFieldTab4RootFldWApi.CheckPropertyNew(objFieldTab4RootFldEN); 
bool bolResult = clsFieldTab4RootFldWApi.AddNewRecord(objFieldTab4RootFldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldWApi.ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
 /// <param name = "objFieldTab4RootFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strWhereCond)
{
try
{
clsFieldTab4RootFldWApi.CheckPropertyNew(objFieldTab4RootFldEN); 
bool bolResult = clsFieldTab4RootFldWApi.UpdateWithCondition(objFieldTab4RootFldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldWApi.ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
 /// 工程字段4RootFld(FieldTab4RootFld)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFieldTab4RootFldWApi
{
private static readonly string mstrApiControllerName = "FieldTab4RootFldApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsFieldTab4RootFldWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
if (!Object.Equals(null, objFieldTab4RootFldEN.TabId) && GetStrLen(objFieldTab4RootFldEN.TabId) > 8)
{
 throw new Exception("字段[表ID]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.FldId) && GetStrLen(objFieldTab4RootFldEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.Root4TabId) && GetStrLen(objFieldTab4RootFldEN.Root4TabId) > 8)
{
 throw new Exception("字段[主根表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.RootFldId) && GetStrLen(objFieldTab4RootFldEN.RootFldId) > 8)
{
 throw new Exception("字段[根字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.RootTabId) && GetStrLen(objFieldTab4RootFldEN.RootTabId) > 8)
{
 throw new Exception("字段[根表Id]的长度不能超过8!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.PrjId) && GetStrLen(objFieldTab4RootFldEN.PrjId) > 4)
{
 throw new Exception("字段[工程ID]的长度不能超过4!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.UpdUser) && GetStrLen(objFieldTab4RootFldEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.UpdDate) && GetStrLen(objFieldTab4RootFldEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFieldTab4RootFldEN.Memo) && GetStrLen(objFieldTab4RootFldEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objFieldTab4RootFldEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFieldTab4RootFldEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
clsFieldTab4RootFldEN objFieldTab4RootFldEN;
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
objFieldTab4RootFldEN = JsonConvert.DeserializeObject<clsFieldTab4RootFldEN>(strJson);
return objFieldTab4RootFldEN;
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
public static clsFieldTab4RootFldEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsFieldTab4RootFldEN objFieldTab4RootFldEN;
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
objFieldTab4RootFldEN = JsonConvert.DeserializeObject<clsFieldTab4RootFldEN>(strJson);
return objFieldTab4RootFldEN;
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
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFieldTab4RootFldEN GetObjBymIdCache(long lngmId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLst_Sel =
from objFieldTab4RootFldEN in arrFieldTab4RootFldObjLstCache
where objFieldTab4RootFldEN.mId == lngmId 
select objFieldTab4RootFldEN;
if (arrFieldTab4RootFldObjLst_Sel.Count() == 0)
{
   clsFieldTab4RootFldEN obj = clsFieldTab4RootFldWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFieldTab4RootFldObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetObjLst(string strWhereCond)
{
 List<clsFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4RootFldEN>>(strJson);
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
public static List<clsFieldTab4RootFldEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4RootFldEN>>(strJson);
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

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsFieldTab4RootFldEN> GetObjLstByMIdLstCache(List<long> arrMId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLst_Sel =
from objFieldTab4RootFldEN in arrFieldTab4RootFldObjLstCache
where arrMId.Contains(objFieldTab4RootFldEN.mId)
select objFieldTab4RootFldEN;
return arrFieldTab4RootFldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4RootFldEN>>(strJson);
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
public static List<clsFieldTab4RootFldEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4RootFldEN>>(strJson);
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
public static List<clsFieldTab4RootFldEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4RootFldEN>>(strJson);
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
public static List<clsFieldTab4RootFldEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsFieldTab4RootFldEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFieldTab4RootFldEN>>(strJson);
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
 clsFieldTab4RootFldEN objFieldTab4RootFldEN = clsFieldTab4RootFldWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsFieldTab4RootFldWApi.ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
public static int DelFieldTab4RootFlds(List<string> arrmId)
{
string strAction = "DelFieldTab4RootFlds";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsFieldTab4RootFldEN objFieldTab4RootFldEN = clsFieldTab4RootFldWApi.GetObjBymId(long.Parse(arrmId[0]));
clsFieldTab4RootFldWApi.ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
public static int DelFieldTab4RootFldsByCond(string strWhereCond)
{
string strAction = "DelFieldTab4RootFldsByCond";
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
public static bool AddNewRecord(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4RootFldEN>(objFieldTab4RootFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldWApi.ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4RootFldEN>(objFieldTab4RootFldEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFieldTab4RootFldWApi.ReFreshCache(objFieldTab4RootFldEN.PrjId);
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
public static bool UpdateRecord(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
if (string.IsNullOrEmpty(objFieldTab4RootFldEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTab4RootFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4RootFldEN>(objFieldTab4RootFldEN);
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
 /// <param name = "objFieldTab4RootFldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFieldTab4RootFldEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTab4RootFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objFieldTab4RootFldEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFieldTab4RootFldEN>(objFieldTab4RootFldEN);
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
 /// <param name = "objFieldTab4RootFldENS">源对象</param>
 /// <param name = "objFieldTab4RootFldENT">目标对象</param>
 public static void CopyTo(clsFieldTab4RootFldEN objFieldTab4RootFldENS, clsFieldTab4RootFldEN objFieldTab4RootFldENT)
{
try
{
objFieldTab4RootFldENT.mId = objFieldTab4RootFldENS.mId; //mId
objFieldTab4RootFldENT.TabId = objFieldTab4RootFldENS.TabId; //表ID
objFieldTab4RootFldENT.FldId = objFieldTab4RootFldENS.FldId; //字段Id
objFieldTab4RootFldENT.IsPrimaryKey = objFieldTab4RootFldENS.IsPrimaryKey; //是否主键
objFieldTab4RootFldENT.IsRootFld = objFieldTab4RootFldENS.IsRootFld; //是否根字段
objFieldTab4RootFldENT.Root4TabId = objFieldTab4RootFldENS.Root4TabId; //主根表Id
objFieldTab4RootFldENT.RootFldId = objFieldTab4RootFldENS.RootFldId; //根字段Id
objFieldTab4RootFldENT.RootTabId = objFieldTab4RootFldENS.RootTabId; //根表Id
objFieldTab4RootFldENT.PrjId = objFieldTab4RootFldENS.PrjId; //工程ID
objFieldTab4RootFldENT.UpdUser = objFieldTab4RootFldENS.UpdUser; //修改者
objFieldTab4RootFldENT.UpdDate = objFieldTab4RootFldENS.UpdDate; //修改日期
objFieldTab4RootFldENT.Memo = objFieldTab4RootFldENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsFieldTab4RootFldEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFieldTab4RootFldEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFieldTab4RootFldEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFieldTab4RootFldEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFieldTab4RootFldEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFieldTab4RootFldEN.AttributeName)
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
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
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
if (clsFieldTab4RootFldWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsFieldTab4RootFldWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetObjLstCache(string strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsFieldTab4RootFldEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsFieldTab4RootFldEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conFieldTab4RootFld.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrFieldTab4RootFldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFieldTab4RootFldEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsFieldTab4RootFldEN> arrObjLst_P)
{
var strKey = string.Format("{0}_{1}", clsFieldTab4RootFldEN._CurrTabName, strPrjId);
List<clsFieldTab4RootFldEN> arrFieldTab4RootFldObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrFieldTab4RootFldObjLstCache = CacheHelper.Get<List<clsFieldTab4RootFldEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrFieldTab4RootFldObjLstCache = CacheHelper.Get<List<clsFieldTab4RootFldEN>>(strKey);
}
return arrFieldTab4RootFldObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFieldTab4RootFldEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFieldTab4RootFld.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conFieldTab4RootFld.TabId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.IsPrimaryKey, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab4RootFld.IsRootFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFieldTab4RootFld.Root4TabId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.RootFldId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.RootTabId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFieldTab4RootFld.Memo, Type.GetType("System.String"));
foreach (clsFieldTab4RootFldEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFieldTab4RootFld.mId] = objInFor[conFieldTab4RootFld.mId];
objDR[conFieldTab4RootFld.TabId] = objInFor[conFieldTab4RootFld.TabId];
objDR[conFieldTab4RootFld.FldId] = objInFor[conFieldTab4RootFld.FldId];
objDR[conFieldTab4RootFld.IsPrimaryKey] = objInFor[conFieldTab4RootFld.IsPrimaryKey];
objDR[conFieldTab4RootFld.IsRootFld] = objInFor[conFieldTab4RootFld.IsRootFld];
objDR[conFieldTab4RootFld.Root4TabId] = objInFor[conFieldTab4RootFld.Root4TabId];
objDR[conFieldTab4RootFld.RootFldId] = objInFor[conFieldTab4RootFld.RootFldId];
objDR[conFieldTab4RootFld.RootTabId] = objInFor[conFieldTab4RootFld.RootTabId];
objDR[conFieldTab4RootFld.PrjId] = objInFor[conFieldTab4RootFld.PrjId];
objDR[conFieldTab4RootFld.UpdUser] = objInFor[conFieldTab4RootFld.UpdUser];
objDR[conFieldTab4RootFld.UpdDate] = objInFor[conFieldTab4RootFld.UpdDate];
objDR[conFieldTab4RootFld.Memo] = objInFor[conFieldTab4RootFld.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 工程字段4RootFld(FieldTab4RootFld)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4FieldTab4RootFld : clsCommFun4BLV2
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
clsFieldTab4RootFldWApi.ReFreshThisCache(strPrjId);
}
}

}