
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectAppRelaWApi
 表名:vCMProjectAppRela(00050634)
 * 版本:2024.09.08.1(服务器:WIN-SRV103-116)
 日期:2024/09/08 10:33:33
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
public static class  clsvCMProjectAppRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "lngCMProjectAppRelaId">Cm工程应用关系Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetCMProjectAppRelaId(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, long lngCMProjectAppRelaId, string strComparisonOp="")
	{
objvCMProjectAppRelaEN.CMProjectAppRelaId = lngCMProjectAppRelaId; //Cm工程应用关系Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.CMProjectAppRelaId) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.CMProjectAppRelaId, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.CMProjectAppRelaId] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetPrjId(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProjectAppRela.PrjId);
objvCMProjectAppRelaEN.PrjId = strPrjId; //工程ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.PrjId) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.PrjId, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.PrjId] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjName">工程名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetPrjName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMProjectAppRela.PrjName);
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMProjectAppRela.PrjName);
objvCMProjectAppRelaEN.PrjName = strPrjName; //工程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.PrjName) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.PrjName, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.PrjName] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetMemo(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProjectAppRela.Memo);
objvCMProjectAppRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.Memo) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.Memo, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.Memo] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetUpdDate(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProjectAppRela.UpdDate);
objvCMProjectAppRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.UpdDate) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.UpdDate, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.UpdDate] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeName">应用程序类型名称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetApplicationTypeName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convCMProjectAppRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convCMProjectAppRela.ApplicationTypeName);
objvCMProjectAppRelaEN.ApplicationTypeName = strApplicationTypeName; //应用程序类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.ApplicationTypeName) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.ApplicationTypeName, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeName] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeENName">应用类型英文名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetApplicationTypeENName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convCMProjectAppRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convCMProjectAppRela.ApplicationTypeENName);
objvCMProjectAppRelaEN.ApplicationTypeENName = strApplicationTypeENName; //应用类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.ApplicationTypeENName) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.ApplicationTypeENName, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeENName] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strApplicationTypeSimName">应用程序类型简称</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetApplicationTypeSimName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMProjectAppRela.ApplicationTypeSimName);
objvCMProjectAppRelaEN.ApplicationTypeSimName = strApplicationTypeSimName; //应用程序类型简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.ApplicationTypeSimName) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.ApplicationTypeSimName, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeSimName] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjName">CM工程名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetCmPrjName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strCmPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProjectAppRela.CmPrjName);
objvCMProjectAppRelaEN.CmPrjName = strCmPrjName; //CM工程名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.CmPrjName) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.CmPrjName, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.CmPrjName] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intApplicationTypeId">应用程序类型ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetApplicationTypeId(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convCMProjectAppRela.ApplicationTypeId);
objvCMProjectAppRelaEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.ApplicationTypeId) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.ApplicationTypeId, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeId] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strCmPrjId">CM工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetCmPrjId(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProjectAppRela.CmPrjId);
objvCMProjectAppRelaEN.CmPrjId = strCmPrjId; //CM工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.CmPrjId) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.CmPrjId, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.CmPrjId] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetUpdUser(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMProjectAppRela.UpdUser);
objvCMProjectAppRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.UpdUser) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.UpdUser, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.UpdUser] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intOrderNum">序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetOrderNum(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convCMProjectAppRela.OrderNum);
objvCMProjectAppRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.OrderNum) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.OrderNum, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.OrderNum] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "intAppOrderNum">AppOrderNum</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetAppOrderNum(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, int intAppOrderNum, string strComparisonOp="")
	{
objvCMProjectAppRelaEN.AppOrderNum = intAppOrderNum; //AppOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.AppOrderNum) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.AppOrderNum, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.AppOrderNum] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "bolAppIsVisible">AppIsVisible</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetAppIsVisible(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, bool bolAppIsVisible, string strComparisonOp="")
	{
objvCMProjectAppRelaEN.AppIsVisible = bolAppIsVisible; //AppIsVisible
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCMProjectAppRelaEN.dicFldComparisonOp.ContainsKey(convCMProjectAppRela.AppIsVisible) == false)
{
objvCMProjectAppRelaEN.dicFldComparisonOp.Add(convCMProjectAppRela.AppIsVisible, strComparisonOp);
}
else
{
objvCMProjectAppRelaEN.dicFldComparisonOp[convCMProjectAppRela.AppIsVisible] = strComparisonOp;
}
}
return objvCMProjectAppRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCMProjectAppRelaEN objvCMProjectAppRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.CMProjectAppRelaId) == true)
{
string strComparisonOpCMProjectAppRelaId = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.CMProjectAppRelaId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectAppRela.CMProjectAppRelaId, objvCMProjectAppRelaCond.CMProjectAppRelaId, strComparisonOpCMProjectAppRelaId);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.PrjId) == true)
{
string strComparisonOpPrjId = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.PrjId, objvCMProjectAppRelaCond.PrjId, strComparisonOpPrjId);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.PrjName) == true)
{
string strComparisonOpPrjName = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.PrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.PrjName, objvCMProjectAppRelaCond.PrjName, strComparisonOpPrjName);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.Memo) == true)
{
string strComparisonOpMemo = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.Memo, objvCMProjectAppRelaCond.Memo, strComparisonOpMemo);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.UpdDate, objvCMProjectAppRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.ApplicationTypeName) == true)
{
string strComparisonOpApplicationTypeName = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.ApplicationTypeName, objvCMProjectAppRelaCond.ApplicationTypeName, strComparisonOpApplicationTypeName);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.ApplicationTypeENName) == true)
{
string strComparisonOpApplicationTypeENName = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.ApplicationTypeENName, objvCMProjectAppRelaCond.ApplicationTypeENName, strComparisonOpApplicationTypeENName);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.ApplicationTypeSimName) == true)
{
string strComparisonOpApplicationTypeSimName = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeSimName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.ApplicationTypeSimName, objvCMProjectAppRelaCond.ApplicationTypeSimName, strComparisonOpApplicationTypeSimName);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.CmPrjName) == true)
{
string strComparisonOpCmPrjName = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.CmPrjName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.CmPrjName, objvCMProjectAppRelaCond.CmPrjName, strComparisonOpCmPrjName);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectAppRela.ApplicationTypeId, objvCMProjectAppRelaCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.CmPrjId, objvCMProjectAppRelaCond.CmPrjId, strComparisonOpCmPrjId);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCMProjectAppRela.UpdUser, objvCMProjectAppRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectAppRela.OrderNum, objvCMProjectAppRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.AppOrderNum) == true)
{
string strComparisonOpAppOrderNum = objvCMProjectAppRelaCond.dicFldComparisonOp[convCMProjectAppRela.AppOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCMProjectAppRela.AppOrderNum, objvCMProjectAppRelaCond.AppOrderNum, strComparisonOpAppOrderNum);
}
if (objvCMProjectAppRelaCond.IsUpdated(convCMProjectAppRela.AppIsVisible) == true)
{
if (objvCMProjectAppRelaCond.AppIsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCMProjectAppRela.AppIsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCMProjectAppRela.AppIsVisible);
}
}
 return strWhereCond;
}

 /// <summary>
 /// 获取唯一性条件串--vCMProjectAppRela(vCMProjectAppRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvCMProjectAppRelaEN == null) return "";
if (objvCMProjectAppRelaEN.CMProjectAppRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCMProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCMProjectAppRelaEN.CmPrjId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("CMProjectAppRelaId !=  {0}", objvCMProjectAppRelaEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCMProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCMProjectAppRelaEN.CmPrjId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// vCMProjectAppRela(vCMProjectAppRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectAppRelaWApi
{
private static readonly string mstrApiControllerName = "vCMProjectAppRelaApi";

 public clsvCMProjectAppRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
string strAction = "GetObjByCMProjectAppRelaId";
clsvCMProjectAppRelaEN objvCMProjectAppRelaEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngCMProjectAppRelaId"] = lngCMProjectAppRelaId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvCMProjectAppRelaEN = JsonConvert.DeserializeObject<clsvCMProjectAppRelaEN>(strJson);
return objvCMProjectAppRelaEN;
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
public static clsvCMProjectAppRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvCMProjectAppRelaEN objvCMProjectAppRelaEN;
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
objvCMProjectAppRelaEN = JsonConvert.DeserializeObject<clsvCMProjectAppRelaEN>(strJson);
return objvCMProjectAppRelaEN;
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
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectAppRelaEN GetObjByCMProjectAppRelaIdCache(long lngCMProjectAppRelaId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLst_Sel =
from objvCMProjectAppRelaEN in arrvCMProjectAppRelaObjLstCache
where objvCMProjectAppRelaEN.CMProjectAppRelaId == lngCMProjectAppRelaId 
select objvCMProjectAppRelaEN;
if (arrvCMProjectAppRelaObjLst_Sel.Count() == 0)
{
   clsvCMProjectAppRelaEN obj = clsvCMProjectAppRelaWApi.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCMProjectAppRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectAppRelaEN>>(strJson);
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
 /// <param name = "arrCMProjectAppRelaId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLst(List<long> arrCMProjectAppRelaId)
{
 List<clsvCMProjectAppRelaEN> arrObjLst; 
string strAction = "GetObjLstByCMProjectAppRelaIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrCMProjectAppRelaId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectAppRelaEN>>(strJson);
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
 /// <param name = "arrCMProjectAppRelaId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLstCache(List<long> arrCMProjectAppRelaId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLst_Sel =
from objvCMProjectAppRelaEN in arrvCMProjectAppRelaObjLstCache
where arrCMProjectAppRelaId.Contains(objvCMProjectAppRelaEN.CMProjectAppRelaId)
select objvCMProjectAppRelaEN;
return arrvCMProjectAppRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectAppRelaEN>>(strJson);
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
public static List<clsvCMProjectAppRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectAppRelaEN>>(strJson);
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
public static List<clsvCMProjectAppRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectAppRelaEN>>(strJson);
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
public static List<clsvCMProjectAppRelaEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvCMProjectAppRelaEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCMProjectAppRelaEN>>(strJson);
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
public static bool IsExist(long lngCMProjectAppRelaId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngCMProjectAppRelaId"] = lngCMProjectAppRelaId.ToString()
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaENS">源对象</param>
 /// <param name = "objvCMProjectAppRelaENT">目标对象</param>
 public static void CopyTo(clsvCMProjectAppRelaEN objvCMProjectAppRelaENS, clsvCMProjectAppRelaEN objvCMProjectAppRelaENT)
{
try
{
objvCMProjectAppRelaENT.CMProjectAppRelaId = objvCMProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvCMProjectAppRelaENT.PrjId = objvCMProjectAppRelaENS.PrjId; //工程ID
objvCMProjectAppRelaENT.PrjName = objvCMProjectAppRelaENS.PrjName; //工程名称
objvCMProjectAppRelaENT.Memo = objvCMProjectAppRelaENS.Memo; //说明
objvCMProjectAppRelaENT.UpdDate = objvCMProjectAppRelaENS.UpdDate; //修改日期
objvCMProjectAppRelaENT.ApplicationTypeName = objvCMProjectAppRelaENS.ApplicationTypeName; //应用程序类型名称
objvCMProjectAppRelaENT.ApplicationTypeENName = objvCMProjectAppRelaENS.ApplicationTypeENName; //应用类型英文名
objvCMProjectAppRelaENT.ApplicationTypeSimName = objvCMProjectAppRelaENS.ApplicationTypeSimName; //应用程序类型简称
objvCMProjectAppRelaENT.CmPrjName = objvCMProjectAppRelaENS.CmPrjName; //CM工程名
objvCMProjectAppRelaENT.ApplicationTypeId = objvCMProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objvCMProjectAppRelaENT.CmPrjId = objvCMProjectAppRelaENS.CmPrjId; //CM工程Id
objvCMProjectAppRelaENT.UpdUser = objvCMProjectAppRelaENS.UpdUser; //修改者
objvCMProjectAppRelaENT.OrderNum = objvCMProjectAppRelaENS.OrderNum; //序号
objvCMProjectAppRelaENT.AppOrderNum = objvCMProjectAppRelaENS.AppOrderNum; //AppOrderNum
objvCMProjectAppRelaENT.AppIsVisible = objvCMProjectAppRelaENS.AppIsVisible; //AppIsVisible
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
public static DataTable ToDataTable(List<clsvCMProjectAppRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCMProjectAppRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCMProjectAppRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCMProjectAppRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCMProjectAppRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCMProjectAppRelaEN.AttributeName)
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
string strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLstCache(string strPrjId)
{
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvCMProjectAppRelaEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvCMProjectAppRelaEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convCMProjectAppRela.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvCMProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvCMProjectAppRelaEN> arrObjLst_P)
{
var strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvCMProjectAppRelaObjLstCache = CacheHelper.Get<List<clsvCMProjectAppRelaEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvCMProjectAppRelaObjLstCache = CacheHelper.Get<List<clsvCMProjectAppRelaEN>>(strKey);
}
return arrvCMProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCMProjectAppRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCMProjectAppRela.CMProjectAppRelaId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCMProjectAppRela.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.PrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.ApplicationTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.ApplicationTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.ApplicationTypeSimName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.CmPrjName, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.ApplicationTypeId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectAppRela.CmPrjId, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCMProjectAppRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectAppRela.AppOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convCMProjectAppRela.AppIsVisible, Type.GetType("System.Boolean"));
foreach (clsvCMProjectAppRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCMProjectAppRela.CMProjectAppRelaId] = objInFor[convCMProjectAppRela.CMProjectAppRelaId];
objDR[convCMProjectAppRela.PrjId] = objInFor[convCMProjectAppRela.PrjId];
objDR[convCMProjectAppRela.PrjName] = objInFor[convCMProjectAppRela.PrjName];
objDR[convCMProjectAppRela.Memo] = objInFor[convCMProjectAppRela.Memo];
objDR[convCMProjectAppRela.UpdDate] = objInFor[convCMProjectAppRela.UpdDate];
objDR[convCMProjectAppRela.ApplicationTypeName] = objInFor[convCMProjectAppRela.ApplicationTypeName];
objDR[convCMProjectAppRela.ApplicationTypeENName] = objInFor[convCMProjectAppRela.ApplicationTypeENName];
objDR[convCMProjectAppRela.ApplicationTypeSimName] = objInFor[convCMProjectAppRela.ApplicationTypeSimName];
objDR[convCMProjectAppRela.CmPrjName] = objInFor[convCMProjectAppRela.CmPrjName];
objDR[convCMProjectAppRela.ApplicationTypeId] = objInFor[convCMProjectAppRela.ApplicationTypeId];
objDR[convCMProjectAppRela.CmPrjId] = objInFor[convCMProjectAppRela.CmPrjId];
objDR[convCMProjectAppRela.UpdUser] = objInFor[convCMProjectAppRela.UpdUser];
objDR[convCMProjectAppRela.OrderNum] = objInFor[convCMProjectAppRela.OrderNum];
objDR[convCMProjectAppRela.AppOrderNum] = objInFor[convCMProjectAppRela.AppOrderNum];
objDR[convCMProjectAppRela.AppIsVisible] = objInFor[convCMProjectAppRela.AppIsVisible];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}