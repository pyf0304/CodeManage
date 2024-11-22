﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserDefaPrjDataBaseBL
 表名:vUserDefaPrjDataBase(00050275)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:53:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvUserDefaPrjDataBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserDefaPrjDataBaseEN GetObj(this K_mId_vUserDefaPrjDataBase myKey)
{
clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = clsvUserDefaPrjDataBaseBL.vUserDefaPrjDataBaseDA.GetObjBymId(myKey.Value);
return objvUserDefaPrjDataBaseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetmId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, long lngmId, string strComparisonOp="")
	{
objvUserDefaPrjDataBaseEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.mId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.mId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.mId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convUserDefaPrjDataBase.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convUserDefaPrjDataBase.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convUserDefaPrjDataBase.PrjId);
}
objvUserDefaPrjDataBaseEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convUserDefaPrjDataBase.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convUserDefaPrjDataBase.PrjName);
}
objvUserDefaPrjDataBaseEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUserId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convUserDefaPrjDataBase.UserId);
}
objvUserDefaPrjDataBaseEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UserId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UserId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UserId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUserName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convUserDefaPrjDataBase.UserName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convUserDefaPrjDataBase.UserName);
}
objvUserDefaPrjDataBaseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UserName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UserName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UserName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjDataBaseId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjDataBaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjDataBaseId, convUserDefaPrjDataBase.PrjDataBaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseId, 4, convUserDefaPrjDataBase.PrjDataBaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjDataBaseId, 4, convUserDefaPrjDataBase.PrjDataBaseId);
}
objvUserDefaPrjDataBaseEN.PrjDataBaseId = strPrjDataBaseId; //项目数据库Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjDataBaseId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjDataBaseId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetPrjDataBaseName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strPrjDataBaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjDataBaseName, 50, convUserDefaPrjDataBase.PrjDataBaseName);
}
objvUserDefaPrjDataBaseEN.PrjDataBaseName = strPrjDataBaseName; //项目数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.PrjDataBaseName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.PrjDataBaseName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetDataBaseName(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strDataBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataBaseName, convUserDefaPrjDataBase.DataBaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseName, 50, convUserDefaPrjDataBase.DataBaseName);
}
objvUserDefaPrjDataBaseEN.DataBaseName = strDataBaseName; //数据库名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.DataBaseName) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.DataBaseName, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseName] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetIpAddress(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIpAddress, convUserDefaPrjDataBase.IpAddress);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIpAddress, 25, convUserDefaPrjDataBase.IpAddress);
}
objvUserDefaPrjDataBaseEN.IpAddress = strIpAddress; //服务器
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.IpAddress) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.IpAddress, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.IpAddress] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetDataBaseUserId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strDataBaseUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataBaseUserId, 30, convUserDefaPrjDataBase.DataBaseUserId);
}
objvUserDefaPrjDataBaseEN.DataBaseUserId = strDataBaseUserId; //数据库的用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.DataBaseUserId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.DataBaseUserId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseUserId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUpdUserId(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convUserDefaPrjDataBase.UpdUserId);
}
objvUserDefaPrjDataBaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UpdUserId) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UpdUserId, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UpdUserId] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetUpdDate(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserDefaPrjDataBase.UpdDate);
}
objvUserDefaPrjDataBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.UpdDate) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.UpdDate, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.UpdDate] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvUserDefaPrjDataBaseEN SetMemo(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserDefaPrjDataBase.Memo);
}
objvUserDefaPrjDataBaseEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserDefaPrjDataBaseEN.dicFldComparisonOp.ContainsKey(convUserDefaPrjDataBase.Memo) == false)
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp.Add(convUserDefaPrjDataBase.Memo, strComparisonOp);
}
else
{
objvUserDefaPrjDataBaseEN.dicFldComparisonOp[convUserDefaPrjDataBase.Memo] = strComparisonOp;
}
}
return objvUserDefaPrjDataBaseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseENS">源对象</param>
 /// <param name = "objvUserDefaPrjDataBaseENT">目标对象</param>
 public static void CopyTo(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENS, clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENT)
{
try
{
objvUserDefaPrjDataBaseENT.mId = objvUserDefaPrjDataBaseENS.mId; //mId
objvUserDefaPrjDataBaseENT.PrjId = objvUserDefaPrjDataBaseENS.PrjId; //工程ID
objvUserDefaPrjDataBaseENT.PrjName = objvUserDefaPrjDataBaseENS.PrjName; //工程名称
objvUserDefaPrjDataBaseENT.UserId = objvUserDefaPrjDataBaseENS.UserId; //用户Id
objvUserDefaPrjDataBaseENT.UserName = objvUserDefaPrjDataBaseENS.UserName; //用户名
objvUserDefaPrjDataBaseENT.PrjDataBaseId = objvUserDefaPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objvUserDefaPrjDataBaseENT.PrjDataBaseName = objvUserDefaPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objvUserDefaPrjDataBaseENT.DataBaseName = objvUserDefaPrjDataBaseENS.DataBaseName; //数据库名
objvUserDefaPrjDataBaseENT.IpAddress = objvUserDefaPrjDataBaseENS.IpAddress; //服务器
objvUserDefaPrjDataBaseENT.DataBaseUserId = objvUserDefaPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objvUserDefaPrjDataBaseENT.UpdUserId = objvUserDefaPrjDataBaseENS.UpdUserId; //修改用户Id
objvUserDefaPrjDataBaseENT.UpdDate = objvUserDefaPrjDataBaseENS.UpdDate; //修改日期
objvUserDefaPrjDataBaseENT.Memo = objvUserDefaPrjDataBaseENS.Memo; //说明
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
 /// <param name = "objvUserDefaPrjDataBaseENS">源对象</param>
 /// <returns>目标对象=>clsvUserDefaPrjDataBaseEN:objvUserDefaPrjDataBaseENT</returns>
 public static clsvUserDefaPrjDataBaseEN CopyTo(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENS)
{
try
{
 clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENT = new clsvUserDefaPrjDataBaseEN()
{
mId = objvUserDefaPrjDataBaseENS.mId, //mId
PrjId = objvUserDefaPrjDataBaseENS.PrjId, //工程ID
PrjName = objvUserDefaPrjDataBaseENS.PrjName, //工程名称
UserId = objvUserDefaPrjDataBaseENS.UserId, //用户Id
UserName = objvUserDefaPrjDataBaseENS.UserName, //用户名
PrjDataBaseId = objvUserDefaPrjDataBaseENS.PrjDataBaseId, //项目数据库Id
PrjDataBaseName = objvUserDefaPrjDataBaseENS.PrjDataBaseName, //项目数据库名
DataBaseName = objvUserDefaPrjDataBaseENS.DataBaseName, //数据库名
IpAddress = objvUserDefaPrjDataBaseENS.IpAddress, //服务器
DataBaseUserId = objvUserDefaPrjDataBaseENS.DataBaseUserId, //数据库的用户ID
UpdUserId = objvUserDefaPrjDataBaseENS.UpdUserId, //修改用户Id
UpdDate = objvUserDefaPrjDataBaseENS.UpdDate, //修改日期
Memo = objvUserDefaPrjDataBaseENS.Memo, //说明
};
 return objvUserDefaPrjDataBaseENT;
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
public static void CheckProperty4Condition(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN)
{
 clsvUserDefaPrjDataBaseBL.vUserDefaPrjDataBaseDA.CheckProperty4Condition(objvUserDefaPrjDataBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.mId) == true)
{
string strComparisonOpmId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convUserDefaPrjDataBase.mId, objvUserDefaPrjDataBaseCond.mId, strComparisonOpmId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjId) == true)
{
string strComparisonOpPrjId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjId, objvUserDefaPrjDataBaseCond.PrjId, strComparisonOpPrjId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjName) == true)
{
string strComparisonOpPrjName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjName, objvUserDefaPrjDataBaseCond.PrjName, strComparisonOpPrjName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UserId) == true)
{
string strComparisonOpUserId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UserId, objvUserDefaPrjDataBaseCond.UserId, strComparisonOpUserId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UserName) == true)
{
string strComparisonOpUserName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UserName, objvUserDefaPrjDataBaseCond.UserName, strComparisonOpUserName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjDataBaseId) == true)
{
string strComparisonOpPrjDataBaseId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjDataBaseId, objvUserDefaPrjDataBaseCond.PrjDataBaseId, strComparisonOpPrjDataBaseId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.PrjDataBaseName) == true)
{
string strComparisonOpPrjDataBaseName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.PrjDataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.PrjDataBaseName, objvUserDefaPrjDataBaseCond.PrjDataBaseName, strComparisonOpPrjDataBaseName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.DataBaseName) == true)
{
string strComparisonOpDataBaseName = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.DataBaseName, objvUserDefaPrjDataBaseCond.DataBaseName, strComparisonOpDataBaseName);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.IpAddress) == true)
{
string strComparisonOpIpAddress = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.IpAddress, objvUserDefaPrjDataBaseCond.IpAddress, strComparisonOpIpAddress);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.DataBaseUserId) == true)
{
string strComparisonOpDataBaseUserId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.DataBaseUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.DataBaseUserId, objvUserDefaPrjDataBaseCond.DataBaseUserId, strComparisonOpDataBaseUserId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UpdUserId, objvUserDefaPrjDataBaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.UpdDate, objvUserDefaPrjDataBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvUserDefaPrjDataBaseCond.IsUpdated(convUserDefaPrjDataBase.Memo) == true)
{
string strComparisonOpMemo = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[convUserDefaPrjDataBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserDefaPrjDataBase.Memo, objvUserDefaPrjDataBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vUserDefaPrjDataBase
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户默认数据库(vUserDefaPrjDataBase)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvUserDefaPrjDataBaseBL
{
public static RelatedActions_vUserDefaPrjDataBase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvUserDefaPrjDataBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvUserDefaPrjDataBaseDA vUserDefaPrjDataBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvUserDefaPrjDataBaseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvUserDefaPrjDataBaseBL()
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
if (string.IsNullOrEmpty(clsvUserDefaPrjDataBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserDefaPrjDataBaseEN._ConnectString);
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
public static DataTable GetDataTable_vUserDefaPrjDataBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vUserDefaPrjDataBaseDA.GetDataTable_vUserDefaPrjDataBase(strWhereCond);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTable(strWhereCond);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTable_Top(objTopPara);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vUserDefaPrjDataBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
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
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvUserDefaPrjDataBaseEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvUserDefaPrjDataBaseEN._CurrTabName);
List<clsvUserDefaPrjDataBaseEN> arrvUserDefaPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvUserDefaPrjDataBaseEN> arrvUserDefaPrjDataBaseObjLst_Sel =
arrvUserDefaPrjDataBaseObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvUserDefaPrjDataBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserDefaPrjDataBaseEN> GetObjLst(string strWhereCond)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvUserDefaPrjDataBaseEN> GetSubObjLstCache(clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseCond)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserDefaPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserDefaPrjDataBase.AttributeName)
{
if (objvUserDefaPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objvUserDefaPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserDefaPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objvUserDefaPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserDefaPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserDefaPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserDefaPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserDefaPrjDataBaseCond[strFldName]));
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
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
List<clsvUserDefaPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvUserDefaPrjDataBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserDefaPrjDataBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvUserDefaPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
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
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
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
public static List<clsvUserDefaPrjDataBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
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
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLst = new List<clsvUserDefaPrjDataBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = new clsvUserDefaPrjDataBaseEN();
try
{
objvUserDefaPrjDataBaseEN.mId = Int32.Parse(objRow[convUserDefaPrjDataBase.mId].ToString().Trim()); //mId
objvUserDefaPrjDataBaseEN.PrjId = objRow[convUserDefaPrjDataBase.PrjId].ToString().Trim(); //工程ID
objvUserDefaPrjDataBaseEN.PrjName = objRow[convUserDefaPrjDataBase.PrjName].ToString().Trim(); //工程名称
objvUserDefaPrjDataBaseEN.UserId = objRow[convUserDefaPrjDataBase.UserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UserId].ToString().Trim(); //用户Id
objvUserDefaPrjDataBaseEN.UserName = objRow[convUserDefaPrjDataBase.UserName].ToString().Trim(); //用户名
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objRow[convUserDefaPrjDataBase.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objRow[convUserDefaPrjDataBase.PrjDataBaseName] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvUserDefaPrjDataBaseEN.DataBaseName = objRow[convUserDefaPrjDataBase.DataBaseName].ToString().Trim(); //数据库名
objvUserDefaPrjDataBaseEN.IpAddress = objRow[convUserDefaPrjDataBase.IpAddress].ToString().Trim(); //服务器
objvUserDefaPrjDataBaseEN.DataBaseUserId = objRow[convUserDefaPrjDataBase.DataBaseUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.DataBaseUserId].ToString().Trim(); //数据库的用户ID
objvUserDefaPrjDataBaseEN.UpdUserId = objRow[convUserDefaPrjDataBase.UpdUserId] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdUserId].ToString().Trim(); //修改用户Id
objvUserDefaPrjDataBaseEN.UpdDate = objRow[convUserDefaPrjDataBase.UpdDate] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.UpdDate].ToString().Trim(); //修改日期
objvUserDefaPrjDataBaseEN.Memo = objRow[convUserDefaPrjDataBase.Memo] == DBNull.Value ? null : objRow[convUserDefaPrjDataBase.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvUserDefaPrjDataBaseEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvUserDefaPrjDataBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvUserDefaPrjDataBase(ref clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN)
{
bool bolResult = vUserDefaPrjDataBaseDA.GetvUserDefaPrjDataBase(ref objvUserDefaPrjDataBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserDefaPrjDataBaseEN GetObjBymId(long lngmId)
{
clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = vUserDefaPrjDataBaseDA.GetObjBymId(lngmId);
return objvUserDefaPrjDataBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvUserDefaPrjDataBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = vUserDefaPrjDataBaseDA.GetFirstObj(strWhereCond);
 return objvUserDefaPrjDataBaseEN;
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
public static clsvUserDefaPrjDataBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = vUserDefaPrjDataBaseDA.GetObjByDataRow(objRow);
 return objvUserDefaPrjDataBaseEN;
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
public static clsvUserDefaPrjDataBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN = vUserDefaPrjDataBaseDA.GetObjByDataRow(objRow);
 return objvUserDefaPrjDataBaseEN;
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
 /// <param name = "lstvUserDefaPrjDataBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserDefaPrjDataBaseEN GetObjBymIdFromList(long lngmId, List<clsvUserDefaPrjDataBaseEN> lstvUserDefaPrjDataBaseObjLst)
{
foreach (clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN in lstvUserDefaPrjDataBaseObjLst)
{
if (objvUserDefaPrjDataBaseEN.mId == lngmId)
{
return objvUserDefaPrjDataBaseEN;
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
 lngmId = new clsvUserDefaPrjDataBaseDA().GetFirstID(strWhereCond);
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
 arrList = vUserDefaPrjDataBaseDA.GetID(strWhereCond);
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
bool bolIsExist = vUserDefaPrjDataBaseDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vUserDefaPrjDataBaseDA.IsExist(lngmId);
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
 bolIsExist = clsvUserDefaPrjDataBaseDA.IsExistTable();
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
 bolIsExist = vUserDefaPrjDataBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objvUserDefaPrjDataBaseENS">源对象</param>
 /// <param name = "objvUserDefaPrjDataBaseENT">目标对象</param>
 public static void CopyTo(clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENS, clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseENT)
{
try
{
objvUserDefaPrjDataBaseENT.mId = objvUserDefaPrjDataBaseENS.mId; //mId
objvUserDefaPrjDataBaseENT.PrjId = objvUserDefaPrjDataBaseENS.PrjId; //工程ID
objvUserDefaPrjDataBaseENT.PrjName = objvUserDefaPrjDataBaseENS.PrjName; //工程名称
objvUserDefaPrjDataBaseENT.UserId = objvUserDefaPrjDataBaseENS.UserId; //用户Id
objvUserDefaPrjDataBaseENT.UserName = objvUserDefaPrjDataBaseENS.UserName; //用户名
objvUserDefaPrjDataBaseENT.PrjDataBaseId = objvUserDefaPrjDataBaseENS.PrjDataBaseId; //项目数据库Id
objvUserDefaPrjDataBaseENT.PrjDataBaseName = objvUserDefaPrjDataBaseENS.PrjDataBaseName; //项目数据库名
objvUserDefaPrjDataBaseENT.DataBaseName = objvUserDefaPrjDataBaseENS.DataBaseName; //数据库名
objvUserDefaPrjDataBaseENT.IpAddress = objvUserDefaPrjDataBaseENS.IpAddress; //服务器
objvUserDefaPrjDataBaseENT.DataBaseUserId = objvUserDefaPrjDataBaseENS.DataBaseUserId; //数据库的用户ID
objvUserDefaPrjDataBaseENT.UpdUserId = objvUserDefaPrjDataBaseENS.UpdUserId; //修改用户Id
objvUserDefaPrjDataBaseENT.UpdDate = objvUserDefaPrjDataBaseENS.UpdDate; //修改日期
objvUserDefaPrjDataBaseENT.Memo = objvUserDefaPrjDataBaseENS.Memo; //说明
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
 /// <param name = "objvUserDefaPrjDataBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN)
{
try
{
objvUserDefaPrjDataBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvUserDefaPrjDataBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convUserDefaPrjDataBase.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.mId = objvUserDefaPrjDataBaseEN.mId; //mId
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.PrjId = objvUserDefaPrjDataBaseEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.PrjName = objvUserDefaPrjDataBaseEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.UserId = objvUserDefaPrjDataBaseEN.UserId == "[null]" ? null :  objvUserDefaPrjDataBaseEN.UserId; //用户Id
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.UserName = objvUserDefaPrjDataBaseEN.UserName; //用户名
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.PrjDataBaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.PrjDataBaseId = objvUserDefaPrjDataBaseEN.PrjDataBaseId; //项目数据库Id
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.PrjDataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.PrjDataBaseName = objvUserDefaPrjDataBaseEN.PrjDataBaseName == "[null]" ? null :  objvUserDefaPrjDataBaseEN.PrjDataBaseName; //项目数据库名
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.DataBaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.DataBaseName = objvUserDefaPrjDataBaseEN.DataBaseName; //数据库名
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.IpAddress, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.IpAddress = objvUserDefaPrjDataBaseEN.IpAddress; //服务器
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.DataBaseUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.DataBaseUserId = objvUserDefaPrjDataBaseEN.DataBaseUserId == "[null]" ? null :  objvUserDefaPrjDataBaseEN.DataBaseUserId; //数据库的用户ID
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.UpdUserId = objvUserDefaPrjDataBaseEN.UpdUserId == "[null]" ? null :  objvUserDefaPrjDataBaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.UpdDate = objvUserDefaPrjDataBaseEN.UpdDate == "[null]" ? null :  objvUserDefaPrjDataBaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convUserDefaPrjDataBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvUserDefaPrjDataBaseEN.Memo = objvUserDefaPrjDataBaseEN.Memo == "[null]" ? null :  objvUserDefaPrjDataBaseEN.Memo; //说明
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
 /// <param name = "objvUserDefaPrjDataBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN)
{
try
{
if (objvUserDefaPrjDataBaseEN.UserId == "[null]") objvUserDefaPrjDataBaseEN.UserId = null; //用户Id
if (objvUserDefaPrjDataBaseEN.PrjDataBaseName == "[null]") objvUserDefaPrjDataBaseEN.PrjDataBaseName = null; //项目数据库名
if (objvUserDefaPrjDataBaseEN.DataBaseUserId == "[null]") objvUserDefaPrjDataBaseEN.DataBaseUserId = null; //数据库的用户ID
if (objvUserDefaPrjDataBaseEN.UpdUserId == "[null]") objvUserDefaPrjDataBaseEN.UpdUserId = null; //修改用户Id
if (objvUserDefaPrjDataBaseEN.UpdDate == "[null]") objvUserDefaPrjDataBaseEN.UpdDate = null; //修改日期
if (objvUserDefaPrjDataBaseEN.Memo == "[null]") objvUserDefaPrjDataBaseEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseEN)
{
 vUserDefaPrjDataBaseDA.CheckProperty4Condition(objvUserDefaPrjDataBaseEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsProjectsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjDataBaseBL没有刷新缓存机制(clsPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserDefaPrjDataBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserDefaPrjDataBaseBL没有刷新缓存机制(clsUserDefaPrjDataBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvUserDefaPrjDataBaseObjLstCache == null)
//{
//arrvUserDefaPrjDataBaseObjLstCache = vUserDefaPrjDataBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserDefaPrjDataBaseEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvUserDefaPrjDataBaseEN._CurrTabName);
List<clsvUserDefaPrjDataBaseEN> arrvUserDefaPrjDataBaseObjLstCache = GetObjLstCache();
IEnumerable <clsvUserDefaPrjDataBaseEN> arrvUserDefaPrjDataBaseObjLst_Sel =
arrvUserDefaPrjDataBaseObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvUserDefaPrjDataBaseObjLst_Sel.Count() == 0)
{
   clsvUserDefaPrjDataBaseEN obj = clsvUserDefaPrjDataBaseBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvUserDefaPrjDataBaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserDefaPrjDataBaseEN> GetAllvUserDefaPrjDataBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsvUserDefaPrjDataBaseEN> arrvUserDefaPrjDataBaseObjLstCache = GetObjLstCache(); 
return arrvUserDefaPrjDataBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvUserDefaPrjDataBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvUserDefaPrjDataBaseEN._CurrTabName);
List<clsvUserDefaPrjDataBaseEN> arrvUserDefaPrjDataBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvUserDefaPrjDataBaseObjLstCache;
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
string strKey = string.Format("{0}", clsvUserDefaPrjDataBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvUserDefaPrjDataBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvUserDefaPrjDataBaseEN._RefreshTimeLst.Count == 0) return "";
return clsvUserDefaPrjDataBaseEN._RefreshTimeLst[clsvUserDefaPrjDataBaseEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convUserDefaPrjDataBase.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convUserDefaPrjDataBase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convUserDefaPrjDataBase.AttributeName));
throw new Exception(strMsg);
}
var objvUserDefaPrjDataBase = clsvUserDefaPrjDataBaseBL.GetObjBymIdCache(lngmId);
if (objvUserDefaPrjDataBase == null) return "";
return objvUserDefaPrjDataBase[strOutFldName].ToString();
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
int intRecCount = clsvUserDefaPrjDataBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsvUserDefaPrjDataBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvUserDefaPrjDataBaseDA.GetRecCount();
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
int intRecCount = clsvUserDefaPrjDataBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvUserDefaPrjDataBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvUserDefaPrjDataBaseEN objvUserDefaPrjDataBaseCond)
{
List<clsvUserDefaPrjDataBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvUserDefaPrjDataBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convUserDefaPrjDataBase.AttributeName)
{
if (objvUserDefaPrjDataBaseCond.IsUpdated(strFldName) == false) continue;
if (objvUserDefaPrjDataBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserDefaPrjDataBaseCond[strFldName].ToString());
}
else
{
if (objvUserDefaPrjDataBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvUserDefaPrjDataBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvUserDefaPrjDataBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvUserDefaPrjDataBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvUserDefaPrjDataBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvUserDefaPrjDataBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvUserDefaPrjDataBaseCond[strFldName]));
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
 List<string> arrList = clsvUserDefaPrjDataBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vUserDefaPrjDataBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vUserDefaPrjDataBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}