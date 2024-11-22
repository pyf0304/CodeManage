﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectDatabaseRelBL
 表名:vProjectDatabaseRel(00050193)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:07:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvProjectDatabaseRelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProjectDatabaseRelEN GetObj(this K_mId_vProjectDatabaseRel myKey)
{
clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = clsvProjectDatabaseRelBL.vProjectDatabaseRelDA.GetObjBymId(myKey.Value);
return objvProjectDatabaseRelEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetmId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, long lngmId, string strComparisonOp="")
	{
objvProjectDatabaseRelEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.mId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.mId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.mId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convProjectDatabaseRel.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convProjectDatabaseRel.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convProjectDatabaseRel.PrjId);
}
objvProjectDatabaseRelEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convProjectDatabaseRel.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convProjectDatabaseRel.PrjName);
}
objvProjectDatabaseRelEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetIpAddress(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, convProjectDatabaseRel.IpAddress);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 25, convProjectDatabaseRel.IpAddress);
}
objvProjectDatabaseRelEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.IpAddress) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.IpAddress, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.IpAddress] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjDataBaseId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convProjectDatabaseRel.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convProjectDatabaseRel.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convProjectDatabaseRel.PrjDataBaseId);
}
objvProjectDatabaseRelEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjDataBaseId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjDataBaseId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetPrjDataBaseName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strPrjDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convProjectDatabaseRel.PrjDataBaseName);
}
objvProjectDatabaseRelEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.PrjDataBaseName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.PrjDataBaseName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseName, convProjectDatabaseRel.DataBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convProjectDatabaseRel.DataBaseName);
}
objvProjectDatabaseRelEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBasePwd(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBasePwd, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBasePwd, 30, convProjectDatabaseRel.DataBasePwd);
}
objvProjectDatabaseRelEN.DataBasePwd = strDataBasePwd; //数据库的用户口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBasePwd) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBasePwd, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBasePwd] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseUserId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convProjectDatabaseRel.DataBaseUserId);
}
objvProjectDatabaseRelEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseUserId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseUserId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseUserId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDatabaseOwner(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDatabaseOwner, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDatabaseOwner, 30, convProjectDatabaseRel.DatabaseOwner);
}
objvProjectDatabaseRelEN.DatabaseOwner = strDatabaseOwner; //数据库拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DatabaseOwner) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DatabaseOwner, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DatabaseOwner] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseTypeId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseTypeId, convProjectDatabaseRel.DataBaseTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeId, 2, convProjectDatabaseRel.DataBaseTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataBaseTypeId, 2, convProjectDatabaseRel.DataBaseTypeId);
}
objvProjectDatabaseRelEN.DataBaseTypeId = strDataBaseTypeId; //数据库类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseTypeId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseTypeId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetDataBaseTypeName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strDataBaseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseTypeName, 30, convProjectDatabaseRel.DataBaseTypeName);
}
objvProjectDatabaseRelEN.DataBaseTypeName = strDataBaseTypeName; //数据库类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.DataBaseTypeName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.DataBaseTypeName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetSid(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strSid, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSid, convProjectDatabaseRel.Sid);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSid, 50, convProjectDatabaseRel.Sid);
}
objvProjectDatabaseRelEN.Sid = strSid; //SID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.Sid) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.Sid, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.Sid] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetTableSpace(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strTableSpace, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableSpace, 50, convProjectDatabaseRel.TableSpace);
}
objvProjectDatabaseRelEN.TableSpace = strTableSpace; //表空间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.TableSpace) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.TableSpace, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.TableSpace] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetUseStateId(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strUseStateId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateId, 4, convProjectDatabaseRel.UseStateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUseStateId, 4, convProjectDatabaseRel.UseStateId);
}
objvProjectDatabaseRelEN.UseStateId = strUseStateId; //使用状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.UseStateId) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.UseStateId, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.UseStateId] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvProjectDatabaseRelEN SetUseStateName(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN, string strUseStateName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseStateName, 30, convProjectDatabaseRel.UseStateName);
}
objvProjectDatabaseRelEN.UseStateName = strUseStateName; //使用状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvProjectDatabaseRelEN.dicFldComparisonOp.ContainsKey(convProjectDatabaseRel.UseStateName) == false)
{
objvProjectDatabaseRelEN.dicFldComparisonOp.Add(convProjectDatabaseRel.UseStateName, strComparisonOp);
}
else
{
objvProjectDatabaseRelEN.dicFldComparisonOp[convProjectDatabaseRel.UseStateName] = strComparisonOp;
}
}
return objvProjectDatabaseRelEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelENS">源对象</param>
 /// <param name = "objvProjectDatabaseRelENT">目标对象</param>
 public static void CopyTo(this clsvProjectDatabaseRelEN objvProjectDatabaseRelENS, clsvProjectDatabaseRelEN objvProjectDatabaseRelENT)
{
try
{
objvProjectDatabaseRelENT.mId = objvProjectDatabaseRelENS.mId; //mId
objvProjectDatabaseRelENT.PrjId = objvProjectDatabaseRelENS.PrjId; //工程ID
objvProjectDatabaseRelENT.PrjName = objvProjectDatabaseRelENS.PrjName; //工程名称
objvProjectDatabaseRelENT.IpAddress = objvProjectDatabaseRelENS.IpAddress; //服务器
objvProjectDatabaseRelENT.PrjDataBaseId = objvProjectDatabaseRelENS.PrjDataBaseId; //项目数据库Id
objvProjectDatabaseRelENT.PrjDataBaseName = objvProjectDatabaseRelENS.PrjDataBaseName; //项目数据库名
objvProjectDatabaseRelENT.DataBaseName = objvProjectDatabaseRelENS.DataBaseName; //数据库名
objvProjectDatabaseRelENT.DataBasePwd = objvProjectDatabaseRelENS.DataBasePwd; //数据库的用户口令
objvProjectDatabaseRelENT.DataBaseUserId = objvProjectDatabaseRelENS.DataBaseUserId; //数据库的用户ID
objvProjectDatabaseRelENT.DatabaseOwner = objvProjectDatabaseRelENS.DatabaseOwner; //数据库拥有者
objvProjectDatabaseRelENT.DataBaseTypeId = objvProjectDatabaseRelENS.DataBaseTypeId; //数据库类型ID
objvProjectDatabaseRelENT.DataBaseTypeName = objvProjectDatabaseRelENS.DataBaseTypeName; //数据库类型名
objvProjectDatabaseRelENT.Sid = objvProjectDatabaseRelENS.Sid; //SID
objvProjectDatabaseRelENT.TableSpace = objvProjectDatabaseRelENS.TableSpace; //表空间
objvProjectDatabaseRelENT.UseStateId = objvProjectDatabaseRelENS.UseStateId; //使用状态Id
objvProjectDatabaseRelENT.UseStateName = objvProjectDatabaseRelENS.UseStateName; //使用状态名称
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
 /// <param name = "objvProjectDatabaseRelENS">源对象</param>
 /// <returns>目标对象=>clsvProjectDatabaseRelEN:objvProjectDatabaseRelENT</returns>
 public static clsvProjectDatabaseRelEN CopyTo(this clsvProjectDatabaseRelEN objvProjectDatabaseRelENS)
{
try
{
 clsvProjectDatabaseRelEN objvProjectDatabaseRelENT = new clsvProjectDatabaseRelEN()
{
mId = objvProjectDatabaseRelENS.mId, //mId
PrjId = objvProjectDatabaseRelENS.PrjId, //工程ID
PrjName = objvProjectDatabaseRelENS.PrjName, //工程名称
IpAddress = objvProjectDatabaseRelENS.IpAddress, //服务器
PrjDataBaseId = objvProjectDatabaseRelENS.PrjDataBaseId, //项目数据库Id
PrjDataBaseName = objvProjectDatabaseRelENS.PrjDataBaseName, //项目数据库名
DataBaseName = objvProjectDatabaseRelENS.DataBaseName, //数据库名
DataBasePwd = objvProjectDatabaseRelENS.DataBasePwd, //数据库的用户口令
DataBaseUserId = objvProjectDatabaseRelENS.DataBaseUserId, //数据库的用户ID
DatabaseOwner = objvProjectDatabaseRelENS.DatabaseOwner, //数据库拥有者
DataBaseTypeId = objvProjectDatabaseRelENS.DataBaseTypeId, //数据库类型ID
DataBaseTypeName = objvProjectDatabaseRelENS.DataBaseTypeName, //数据库类型名
Sid = objvProjectDatabaseRelENS.Sid, //SID
TableSpace = objvProjectDatabaseRelENS.TableSpace, //表空间
UseStateId = objvProjectDatabaseRelENS.UseStateId, //使用状态Id
UseStateName = objvProjectDatabaseRelENS.UseStateName, //使用状态名称
};
 return objvProjectDatabaseRelENT;
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
public static void CheckProperty4Condition(this clsvProjectDatabaseRelEN objvProjectDatabaseRelEN)
{
 clsvProjectDatabaseRelBL.vProjectDatabaseRelDA.CheckProperty4Condition(objvProjectDatabaseRelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvProjectDatabaseRelEN objvProjectDatabaseRelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.mId) == true)
{
string strComparisonOpmId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convProjectDatabaseRel.mId, objvProjectDatabaseRelCond.mId, strComparisonOpmId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjId) == true)
{
string strComparisonOpPrjId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjId, objvProjectDatabaseRelCond.PrjId, strComparisonOpPrjId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjName) == true)
{
string strComparisonOpPrjName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjName, objvProjectDatabaseRelCond.PrjName, strComparisonOpPrjName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.IpAddress) == true)
{
string strComparisonOpIpAddress = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.IpAddress, objvProjectDatabaseRelCond.IpAddress, strComparisonOpIpAddress);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjDataBaseId, objvProjectDatabaseRelCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.PrjDataBaseName, objvProjectDatabaseRelCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseName, objvProjectDatabaseRelCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBasePwd) == true)
{
string strComparisonOpDataBasePwd = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBasePwd];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBasePwd, objvProjectDatabaseRelCond.DataBasePwd, strComparisonOpDataBasePwd);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseUserId, objvProjectDatabaseRelCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DatabaseOwner) == true)
{
string strComparisonOpDatabaseOwner = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DatabaseOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DatabaseOwner, objvProjectDatabaseRelCond.DatabaseOwner, strComparisonOpDatabaseOwner);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseTypeId) == true)
{
string strComparisonOpDataBaseTypeId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseTypeId, objvProjectDatabaseRelCond.DataBaseTypeId, strComparisonOpDataBaseTypeId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.DataBaseTypeName) == true)
{
string strComparisonOpDataBaseTypeName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.DataBaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.DataBaseTypeName, objvProjectDatabaseRelCond.DataBaseTypeName, strComparisonOpDataBaseTypeName);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.Sid) == true)
{
string strComparisonOpSid = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.Sid];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.Sid, objvProjectDatabaseRelCond.Sid, strComparisonOpSid);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.TableSpace) == true)
{
string strComparisonOpTableSpace = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.TableSpace];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.TableSpace, objvProjectDatabaseRelCond.TableSpace, strComparisonOpTableSpace);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.UseStateId) == true)
{
string strComparisonOpUseStateId = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.UseStateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.UseStateId, objvProjectDatabaseRelCond.UseStateId, strComparisonOpUseStateId);
}
if (objvProjectDatabaseRelCond.IsUpdated(convProjectDatabaseRel.UseStateName) == true)
{
string strComparisonOpUseStateName = objvProjectDatabaseRelCond.dicFldComparisonOp[convProjectDatabaseRel.UseStateName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convProjectDatabaseRel.UseStateName, objvProjectDatabaseRelCond.UseStateName, strComparisonOpUseStateName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vProjectDatabaseRel
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程数据库关系(vProjectDatabaseRel)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvProjectDatabaseRelBL
{
public static RelatedActions_vProjectDatabaseRel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvProjectDatabaseRelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvProjectDatabaseRelDA vProjectDatabaseRelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvProjectDatabaseRelDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvProjectDatabaseRelBL()
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
if (string.IsNullOrEmpty(clsvProjectDatabaseRelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvProjectDatabaseRelEN._ConnectString);
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
public static DataTable GetDataTable_vProjectDatabaseRel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vProjectDatabaseRelDA.GetDataTable_vProjectDatabaseRel(strWhereCond);
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
objDT = vProjectDatabaseRelDA.GetDataTable(strWhereCond);
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
objDT = vProjectDatabaseRelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vProjectDatabaseRelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vProjectDatabaseRelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vProjectDatabaseRelDA.GetDataTable_Top(objTopPara);
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
objDT = vProjectDatabaseRelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vProjectDatabaseRelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vProjectDatabaseRelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvProjectDatabaseRelEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvProjectDatabaseRelEN._CurrTabName);
List<clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLst_Sel =
arrvProjectDatabaseRelObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvProjectDatabaseRelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetObjLst(string strWhereCond)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
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
public static List<clsvProjectDatabaseRelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvProjectDatabaseRelEN> GetSubObjLstCache(clsvProjectDatabaseRelEN objvProjectDatabaseRelCond)
{
List<clsvProjectDatabaseRelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectDatabaseRelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convProjectDatabaseRel.AttributeName)
{
if (objvProjectDatabaseRelCond.IsUpdated(strFldName) == false) continue;
if (objvProjectDatabaseRelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectDatabaseRelCond[strFldName].ToString());
}
else
{
if (objvProjectDatabaseRelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvProjectDatabaseRelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectDatabaseRelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvProjectDatabaseRelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvProjectDatabaseRelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvProjectDatabaseRelCond[strFldName]));
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
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
List<clsvProjectDatabaseRelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvProjectDatabaseRelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvProjectDatabaseRelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
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
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
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
public static List<clsvProjectDatabaseRelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
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
public static List<clsvProjectDatabaseRelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvProjectDatabaseRelEN> arrObjLst = new List<clsvProjectDatabaseRelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = new clsvProjectDatabaseRelEN();
try
{
objvProjectDatabaseRelEN.mId = Int32.Parse(objRow[convProjectDatabaseRel.mId].ToString().Trim()); //mId
objvProjectDatabaseRelEN.PrjId = objRow[convProjectDatabaseRel.PrjId].ToString().Trim(); //工程ID
objvProjectDatabaseRelEN.PrjName = objRow[convProjectDatabaseRel.PrjName].ToString().Trim(); //工程名称
objvProjectDatabaseRelEN.IpAddress = objRow[convProjectDatabaseRel.IpAddress].ToString().Trim(); //服务器
objvProjectDatabaseRelEN.PrjDataBaseId = objRow[convProjectDatabaseRel.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvProjectDatabaseRelEN.PrjDataBaseName = objRow[convProjectDatabaseRel.PrjDataBaseName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvProjectDatabaseRelEN.DataBaseName = objRow[convProjectDatabaseRel.DataBaseName].ToString().Trim(); //数据库名
objvProjectDatabaseRelEN.DataBasePwd = objRow[convProjectDatabaseRel.DataBasePwd] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBasePwd].ToString().Trim(); //数据库的用户口令
objvProjectDatabaseRelEN.DataBaseUserId = objRow[convProjectDatabaseRel.DataBaseUserId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvProjectDatabaseRelEN.DatabaseOwner = objRow[convProjectDatabaseRel.DatabaseOwner] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DatabaseOwner].ToString().Trim(); //数据库拥有者
objvProjectDatabaseRelEN.DataBaseTypeId = objRow[convProjectDatabaseRel.DataBaseTypeId].ToString().Trim(); //数据库类型ID
objvProjectDatabaseRelEN.DataBaseTypeName = objRow[convProjectDatabaseRel.DataBaseTypeName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.DataBaseTypeName].ToString().Trim(); //数据库类型名
objvProjectDatabaseRelEN.Sid = objRow[convProjectDatabaseRel.Sid].ToString().Trim(); //SID
objvProjectDatabaseRelEN.TableSpace = objRow[convProjectDatabaseRel.TableSpace] == DBNull.Value ? null : objRow[convProjectDatabaseRel.TableSpace].ToString().Trim(); //表空间
objvProjectDatabaseRelEN.UseStateId = objRow[convProjectDatabaseRel.UseStateId] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateId].ToString().Trim(); //使用状态Id
objvProjectDatabaseRelEN.UseStateName = objRow[convProjectDatabaseRel.UseStateName] == DBNull.Value ? null : objRow[convProjectDatabaseRel.UseStateName].ToString().Trim(); //使用状态名称
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvProjectDatabaseRelEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvProjectDatabaseRelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvProjectDatabaseRel(ref clsvProjectDatabaseRelEN objvProjectDatabaseRelEN)
{
bool bolResult = vProjectDatabaseRelDA.GetvProjectDatabaseRel(ref objvProjectDatabaseRelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvProjectDatabaseRelEN GetObjBymId(long lngmId)
{
clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = vProjectDatabaseRelDA.GetObjBymId(lngmId);
return objvProjectDatabaseRelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvProjectDatabaseRelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = vProjectDatabaseRelDA.GetFirstObj(strWhereCond);
 return objvProjectDatabaseRelEN;
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
public static clsvProjectDatabaseRelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = vProjectDatabaseRelDA.GetObjByDataRow(objRow);
 return objvProjectDatabaseRelEN;
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
public static clsvProjectDatabaseRelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvProjectDatabaseRelEN objvProjectDatabaseRelEN = vProjectDatabaseRelDA.GetObjByDataRow(objRow);
 return objvProjectDatabaseRelEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvProjectDatabaseRelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvProjectDatabaseRelEN GetObjBymIdFromList(long lngmId, List<clsvProjectDatabaseRelEN> lstvProjectDatabaseRelObjLst)
{
foreach (clsvProjectDatabaseRelEN objvProjectDatabaseRelEN in lstvProjectDatabaseRelObjLst)
{
if (objvProjectDatabaseRelEN.mId == lngmId)
{
return objvProjectDatabaseRelEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvProjectDatabaseRelDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vProjectDatabaseRelDA.GetID(strWhereCond);
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
bool bolIsExist = vProjectDatabaseRelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vProjectDatabaseRelDA.IsExist(lngmId);
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
 bolIsExist = clsvProjectDatabaseRelDA.IsExistTable();
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
 bolIsExist = vProjectDatabaseRelDA.IsExistTable(strTabName);
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
 /// <param name = "objvProjectDatabaseRelENS">源对象</param>
 /// <param name = "objvProjectDatabaseRelENT">目标对象</param>
 public static void CopyTo(clsvProjectDatabaseRelEN objvProjectDatabaseRelENS, clsvProjectDatabaseRelEN objvProjectDatabaseRelENT)
{
try
{
objvProjectDatabaseRelENT.mId = objvProjectDatabaseRelENS.mId; //mId
objvProjectDatabaseRelENT.PrjId = objvProjectDatabaseRelENS.PrjId; //工程ID
objvProjectDatabaseRelENT.PrjName = objvProjectDatabaseRelENS.PrjName; //工程名称
objvProjectDatabaseRelENT.IpAddress = objvProjectDatabaseRelENS.IpAddress; //服务器
objvProjectDatabaseRelENT.PrjDataBaseId = objvProjectDatabaseRelENS.PrjDataBaseId; //项目数据库Id
objvProjectDatabaseRelENT.PrjDataBaseName = objvProjectDatabaseRelENS.PrjDataBaseName; //项目数据库名
objvProjectDatabaseRelENT.DataBaseName = objvProjectDatabaseRelENS.DataBaseName; //数据库名
objvProjectDatabaseRelENT.DataBasePwd = objvProjectDatabaseRelENS.DataBasePwd; //数据库的用户口令
objvProjectDatabaseRelENT.DataBaseUserId = objvProjectDatabaseRelENS.DataBaseUserId; //数据库的用户ID
objvProjectDatabaseRelENT.DatabaseOwner = objvProjectDatabaseRelENS.DatabaseOwner; //数据库拥有者
objvProjectDatabaseRelENT.DataBaseTypeId = objvProjectDatabaseRelENS.DataBaseTypeId; //数据库类型ID
objvProjectDatabaseRelENT.DataBaseTypeName = objvProjectDatabaseRelENS.DataBaseTypeName; //数据库类型名
objvProjectDatabaseRelENT.Sid = objvProjectDatabaseRelENS.Sid; //SID
objvProjectDatabaseRelENT.TableSpace = objvProjectDatabaseRelENS.TableSpace; //表空间
objvProjectDatabaseRelENT.UseStateId = objvProjectDatabaseRelENS.UseStateId; //使用状态Id
objvProjectDatabaseRelENT.UseStateName = objvProjectDatabaseRelENS.UseStateName; //使用状态名称
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
 /// <param name = "objvProjectDatabaseRelEN">源简化对象</param>
 public static void SetUpdFlag(clsvProjectDatabaseRelEN objvProjectDatabaseRelEN)
{
try
{
objvProjectDatabaseRelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvProjectDatabaseRelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convProjectDatabaseRel.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.mId = objvProjectDatabaseRelEN.mId; //mId
}
if (arrFldSet.Contains(convProjectDatabaseRel.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.PrjId = objvProjectDatabaseRelEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convProjectDatabaseRel.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.PrjName = objvProjectDatabaseRelEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convProjectDatabaseRel.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.IpAddress = objvProjectDatabaseRelEN.IpAddress; //服务器
}
if (arrFldSet.Contains(convProjectDatabaseRel.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.PrjDataBaseId = objvProjectDatabaseRelEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(convProjectDatabaseRel.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.PrjDataBaseName = objvProjectDatabaseRelEN.PrjDataBaseName == "[null]" ? null :  objvProjectDatabaseRelEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(convProjectDatabaseRel.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.DataBaseName = objvProjectDatabaseRelEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convProjectDatabaseRel.DataBasePwd, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.DataBasePwd = objvProjectDatabaseRelEN.DataBasePwd == "[null]" ? null :  objvProjectDatabaseRelEN.DataBasePwd; //数据库的用户口令
}
if (arrFldSet.Contains(convProjectDatabaseRel.DataBaseUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.DataBaseUserId = objvProjectDatabaseRelEN.DataBaseUserId == "[null]" ? null :  objvProjectDatabaseRelEN.DataBaseUserId; //数据库的用户ID
}
if (arrFldSet.Contains(convProjectDatabaseRel.DatabaseOwner, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.DatabaseOwner = objvProjectDatabaseRelEN.DatabaseOwner == "[null]" ? null :  objvProjectDatabaseRelEN.DatabaseOwner; //数据库拥有者
}
if (arrFldSet.Contains(convProjectDatabaseRel.DataBaseTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.DataBaseTypeId = objvProjectDatabaseRelEN.DataBaseTypeId; //数据库类型ID
}
if (arrFldSet.Contains(convProjectDatabaseRel.DataBaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.DataBaseTypeName = objvProjectDatabaseRelEN.DataBaseTypeName == "[null]" ? null :  objvProjectDatabaseRelEN.DataBaseTypeName; //数据库类型名
}
if (arrFldSet.Contains(convProjectDatabaseRel.Sid, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.Sid = objvProjectDatabaseRelEN.Sid; //SID
}
if (arrFldSet.Contains(convProjectDatabaseRel.TableSpace, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.TableSpace = objvProjectDatabaseRelEN.TableSpace == "[null]" ? null :  objvProjectDatabaseRelEN.TableSpace; //表空间
}
if (arrFldSet.Contains(convProjectDatabaseRel.UseStateId, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.UseStateId = objvProjectDatabaseRelEN.UseStateId == "[null]" ? null :  objvProjectDatabaseRelEN.UseStateId; //使用状态Id
}
if (arrFldSet.Contains(convProjectDatabaseRel.UseStateName, new clsStrCompareIgnoreCase())  ==  true)
{
objvProjectDatabaseRelEN.UseStateName = objvProjectDatabaseRelEN.UseStateName == "[null]" ? null :  objvProjectDatabaseRelEN.UseStateName; //使用状态名称
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
 /// <param name = "objvProjectDatabaseRelEN">源简化对象</param>
 public static void AccessFldValueNull(clsvProjectDatabaseRelEN objvProjectDatabaseRelEN)
{
try
{
if (objvProjectDatabaseRelEN.PrjDataBaseName == "[null]") objvProjectDatabaseRelEN.PrjDataBaseName = null; //项目数据库名
if (objvProjectDatabaseRelEN.DataBasePwd == "[null]") objvProjectDatabaseRelEN.DataBasePwd = null; //数据库的用户口令
if (objvProjectDatabaseRelEN.DataBaseUserId == "[null]") objvProjectDatabaseRelEN.DataBaseUserId = null; //数据库的用户ID
if (objvProjectDatabaseRelEN.DatabaseOwner == "[null]") objvProjectDatabaseRelEN.DatabaseOwner = null; //数据库拥有者
if (objvProjectDatabaseRelEN.DataBaseTypeName == "[null]") objvProjectDatabaseRelEN.DataBaseTypeName = null; //数据库类型名
if (objvProjectDatabaseRelEN.TableSpace == "[null]") objvProjectDatabaseRelEN.TableSpace = null; //表空间
if (objvProjectDatabaseRelEN.UseStateId == "[null]") objvProjectDatabaseRelEN.UseStateId = null; //使用状态Id
if (objvProjectDatabaseRelEN.UseStateName == "[null]") objvProjectDatabaseRelEN.UseStateName = null; //使用状态名称
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
public static void CheckProperty4Condition(clsvProjectDatabaseRelEN objvProjectDatabaseRelEN)
{
 vProjectDatabaseRelDA.CheckProperty4Condition(objvProjectDatabaseRelEN);
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
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectDatabaseRelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectDatabaseRelBL没有刷新缓存机制(clsProjectDatabaseRelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDataBaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDataBaseTypeBL没有刷新缓存机制(clsDataBaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjDataBaseBL没有刷新缓存机制(clsPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUseStateBL没有刷新缓存机制(clsUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvProjectDatabaseRelObjLstCache == null)
//{
//arrvProjectDatabaseRelObjLstCache = vProjectDatabaseRelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvProjectDatabaseRelEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvProjectDatabaseRelEN._CurrTabName);
List<clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLst_Sel =
arrvProjectDatabaseRelObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvProjectDatabaseRelObjLst_Sel.Count() == 0)
{
   clsvProjectDatabaseRelEN obj = clsvProjectDatabaseRelBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvProjectDatabaseRelObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetAllvProjectDatabaseRelObjLstCache()
{
//获取缓存中的对象列表
List<clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLstCache = GetObjLstCache(); 
return arrvProjectDatabaseRelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvProjectDatabaseRelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvProjectDatabaseRelEN._CurrTabName);
List<clsvProjectDatabaseRelEN> arrvProjectDatabaseRelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvProjectDatabaseRelObjLstCache;
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
string strKey = string.Format("{0}", clsvProjectDatabaseRelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvProjectDatabaseRelEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvProjectDatabaseRelEN._RefreshTimeLst.Count == 0) return "";
return clsvProjectDatabaseRelEN._RefreshTimeLst[clsvProjectDatabaseRelEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-10-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convProjectDatabaseRel.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convProjectDatabaseRel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convProjectDatabaseRel.AttributeName));
throw new Exception(strMsg);
}
var objvProjectDatabaseRel = clsvProjectDatabaseRelBL.GetObjBymIdCache(lngmId);
if (objvProjectDatabaseRel == null) return "";
return objvProjectDatabaseRel[strOutFldName].ToString();
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
int intRecCount = clsvProjectDatabaseRelDA.GetRecCount(strTabName);
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
int intRecCount = clsvProjectDatabaseRelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvProjectDatabaseRelDA.GetRecCount();
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
int intRecCount = clsvProjectDatabaseRelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvProjectDatabaseRelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvProjectDatabaseRelEN objvProjectDatabaseRelCond)
{
List<clsvProjectDatabaseRelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvProjectDatabaseRelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convProjectDatabaseRel.AttributeName)
{
if (objvProjectDatabaseRelCond.IsUpdated(strFldName) == false) continue;
if (objvProjectDatabaseRelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectDatabaseRelCond[strFldName].ToString());
}
else
{
if (objvProjectDatabaseRelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvProjectDatabaseRelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvProjectDatabaseRelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvProjectDatabaseRelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvProjectDatabaseRelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvProjectDatabaseRelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvProjectDatabaseRelCond[strFldName]));
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
 List<string> arrList = clsvProjectDatabaseRelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vProjectDatabaseRelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vProjectDatabaseRelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}