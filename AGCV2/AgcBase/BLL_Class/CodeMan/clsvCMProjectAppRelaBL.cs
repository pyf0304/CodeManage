
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectAppRelaBL
 表名:vCMProjectAppRela(00050634)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:46:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsvCMProjectAppRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectAppRelaEN GetObj(this K_CMProjectAppRelaId_vCMProjectAppRela myKey)
{
clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = clsvCMProjectAppRelaBL.vCMProjectAppRelaDA.GetObjByCMProjectAppRelaId(myKey.Value);
return objvCMProjectAppRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetPrjId(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convCMProjectAppRela.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convCMProjectAppRela.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convCMProjectAppRela.PrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetPrjName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strPrjName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjName, convCMProjectAppRela.PrjName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjName, 30, convCMProjectAppRela.PrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetMemo(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCMProjectAppRela.Memo);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetUpdDate(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCMProjectAppRela.UpdDate);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetApplicationTypeName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strApplicationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeName, convCMProjectAppRela.ApplicationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeName, 30, convCMProjectAppRela.ApplicationTypeName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetApplicationTypeENName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strApplicationTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strApplicationTypeENName, convCMProjectAppRela.ApplicationTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeENName, 30, convCMProjectAppRela.ApplicationTypeENName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetApplicationTypeSimName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strApplicationTypeSimName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplicationTypeSimName, 30, convCMProjectAppRela.ApplicationTypeSimName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetCmPrjName(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strCmPrjName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjName, 50, convCMProjectAppRela.CmPrjName);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetCmPrjId(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convCMProjectAppRela.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convCMProjectAppRela.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convCMProjectAppRela.CmPrjId);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetUpdUser(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCMProjectAppRela.UpdUser);
}
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCMProjectAppRelaEN SetAppOrderNum(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN, int? intAppOrderNum, string strComparisonOp="")
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
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要设置字段值的实体对象</param>
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaENS">源对象</param>
 /// <param name = "objvCMProjectAppRelaENT">目标对象</param>
 public static void CopyTo(this clsvCMProjectAppRelaEN objvCMProjectAppRelaENS, clsvCMProjectAppRelaEN objvCMProjectAppRelaENT)
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
 /// <param name = "objvCMProjectAppRelaENS">源对象</param>
 /// <returns>目标对象=>clsvCMProjectAppRelaEN:objvCMProjectAppRelaENT</returns>
 public static clsvCMProjectAppRelaEN CopyTo(this clsvCMProjectAppRelaEN objvCMProjectAppRelaENS)
{
try
{
 clsvCMProjectAppRelaEN objvCMProjectAppRelaENT = new clsvCMProjectAppRelaEN()
{
CMProjectAppRelaId = objvCMProjectAppRelaENS.CMProjectAppRelaId, //Cm工程应用关系Id
PrjId = objvCMProjectAppRelaENS.PrjId, //工程ID
PrjName = objvCMProjectAppRelaENS.PrjName, //工程名称
Memo = objvCMProjectAppRelaENS.Memo, //说明
UpdDate = objvCMProjectAppRelaENS.UpdDate, //修改日期
ApplicationTypeName = objvCMProjectAppRelaENS.ApplicationTypeName, //应用程序类型名称
ApplicationTypeENName = objvCMProjectAppRelaENS.ApplicationTypeENName, //应用类型英文名
ApplicationTypeSimName = objvCMProjectAppRelaENS.ApplicationTypeSimName, //应用程序类型简称
CmPrjName = objvCMProjectAppRelaENS.CmPrjName, //CM工程名
ApplicationTypeId = objvCMProjectAppRelaENS.ApplicationTypeId, //应用程序类型ID
CmPrjId = objvCMProjectAppRelaENS.CmPrjId, //CM工程Id
UpdUser = objvCMProjectAppRelaENS.UpdUser, //修改者
OrderNum = objvCMProjectAppRelaENS.OrderNum, //序号
AppOrderNum = objvCMProjectAppRelaENS.AppOrderNum, //AppOrderNum
AppIsVisible = objvCMProjectAppRelaENS.AppIsVisible, //AppIsVisible
};
 return objvCMProjectAppRelaENT;
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
public static void CheckProperty4Condition(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
 clsvCMProjectAppRelaBL.vCMProjectAppRelaDA.CheckProperty4Condition(objvCMProjectAppRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
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
 /// 检查唯一性(Uniqueness)--vCMProjectAppRela(vCMProjectAppRela), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvCMProjectAppRelaEN == null) return true;
if (objvCMProjectAppRelaEN.CMProjectAppRelaId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCMProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCMProjectAppRelaEN.CmPrjId);
if (clsvCMProjectAppRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("CMProjectAppRelaId !=  {0}", objvCMProjectAppRelaEN.CMProjectAppRelaId);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCMProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCMProjectAppRelaEN.CmPrjId);
if (clsvCMProjectAppRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vCMProjectAppRela(vCMProjectAppRela), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCMProjectAppRela
{
public virtual bool UpdRelaTabDate(long lngCMProjectAppRelaId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCMProjectAppRela(vCMProjectAppRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCMProjectAppRelaBL
{
public static RelatedActions_vCMProjectAppRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCMProjectAppRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCMProjectAppRelaDA vCMProjectAppRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCMProjectAppRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCMProjectAppRelaBL()
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
if (string.IsNullOrEmpty(clsvCMProjectAppRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMProjectAppRelaEN._ConnectString);
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
public static DataTable GetDataTable_vCMProjectAppRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCMProjectAppRelaDA.GetDataTable_vCMProjectAppRela(strWhereCond);
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
objDT = vCMProjectAppRelaDA.GetDataTable(strWhereCond);
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
objDT = vCMProjectAppRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCMProjectAppRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCMProjectAppRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCMProjectAppRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vCMProjectAppRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCMProjectAppRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCMProjectAppRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCMProjectAppRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLst(List<long> arrCMProjectAppRelaIdLst)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCMProjectAppRelaIdLst);
 string strWhereCond = string.Format("CMProjectAppRelaId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCMProjectAppRelaIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCMProjectAppRelaEN> GetObjLstByCMProjectAppRelaIdLstCache(List<long> arrCMProjectAppRelaIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLst_Sel =
arrvCMProjectAppRelaObjLstCache
.Where(x => arrCMProjectAppRelaIdLst.Contains(x.CMProjectAppRelaId));
return arrvCMProjectAppRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLst(string strWhereCond)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
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
public static List<clsvCMProjectAppRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCMProjectAppRelaEN> GetSubObjLstCache(clsvCMProjectAppRelaEN objvCMProjectAppRelaCond)
{
 string strPrjId = objvCMProjectAppRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCMProjectAppRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCMProjectAppRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectAppRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProjectAppRela.AttributeName)
{
if (objvCMProjectAppRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectAppRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectAppRelaCond[strFldName].ToString());
}
else
{
if (objvCMProjectAppRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectAppRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectAppRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectAppRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectAppRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectAppRelaCond[strFldName]));
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
public static List<clsvCMProjectAppRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
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
public static List<clsvCMProjectAppRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
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
List<clsvCMProjectAppRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCMProjectAppRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCMProjectAppRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
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
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
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
public static List<clsvCMProjectAppRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCMProjectAppRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
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
public static List<clsvCMProjectAppRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCMProjectAppRelaEN.CMProjectAppRelaId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCMProjectAppRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCMProjectAppRela(ref clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
bool bolResult = vCMProjectAppRelaDA.GetvCMProjectAppRela(ref objvCMProjectAppRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCMProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = vCMProjectAppRelaDA.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
return objvCMProjectAppRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCMProjectAppRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = vCMProjectAppRelaDA.GetFirstObj(strWhereCond);
 return objvCMProjectAppRelaEN;
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
public static clsvCMProjectAppRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = vCMProjectAppRelaDA.GetObjByDataRow(objRow);
 return objvCMProjectAppRelaEN;
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
public static clsvCMProjectAppRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = vCMProjectAppRelaDA.GetObjByDataRow(objRow);
 return objvCMProjectAppRelaEN;
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
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <param name = "lstvCMProjectAppRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectAppRelaEN GetObjByCMProjectAppRelaIdFromList(long lngCMProjectAppRelaId, List<clsvCMProjectAppRelaEN> lstvCMProjectAppRelaObjLst)
{
foreach (clsvCMProjectAppRelaEN objvCMProjectAppRelaEN in lstvCMProjectAppRelaObjLst)
{
if (objvCMProjectAppRelaEN.CMProjectAppRelaId == lngCMProjectAppRelaId)
{
return objvCMProjectAppRelaEN;
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
 long lngCMProjectAppRelaId;
 try
 {
 lngCMProjectAppRelaId = new clsvCMProjectAppRelaDA().GetFirstID(strWhereCond);
 return lngCMProjectAppRelaId;
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
 arrList = vCMProjectAppRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vCMProjectAppRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngCMProjectAppRelaId)
{
//检测记录是否存在
bool bolIsExist = vCMProjectAppRelaDA.IsExist(lngCMProjectAppRelaId);
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
 bolIsExist = clsvCMProjectAppRelaDA.IsExistTable();
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
 bolIsExist = vCMProjectAppRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvCMProjectAppRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
try
{
objvCMProjectAppRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCMProjectAppRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCMProjectAppRela.CMProjectAppRelaId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = objvCMProjectAppRelaEN.CMProjectAppRelaId; //Cm工程应用关系Id
}
if (arrFldSet.Contains(convCMProjectAppRela.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.PrjId = objvCMProjectAppRelaEN.PrjId; //工程ID
}
if (arrFldSet.Contains(convCMProjectAppRela.PrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.PrjName = objvCMProjectAppRelaEN.PrjName; //工程名称
}
if (arrFldSet.Contains(convCMProjectAppRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.Memo = objvCMProjectAppRelaEN.Memo == "[null]" ? null :  objvCMProjectAppRelaEN.Memo; //说明
}
if (arrFldSet.Contains(convCMProjectAppRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.UpdDate = objvCMProjectAppRelaEN.UpdDate == "[null]" ? null :  objvCMProjectAppRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convCMProjectAppRela.ApplicationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.ApplicationTypeName = objvCMProjectAppRelaEN.ApplicationTypeName; //应用程序类型名称
}
if (arrFldSet.Contains(convCMProjectAppRela.ApplicationTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.ApplicationTypeENName = objvCMProjectAppRelaEN.ApplicationTypeENName; //应用类型英文名
}
if (arrFldSet.Contains(convCMProjectAppRela.ApplicationTypeSimName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.ApplicationTypeSimName = objvCMProjectAppRelaEN.ApplicationTypeSimName == "[null]" ? null :  objvCMProjectAppRelaEN.ApplicationTypeSimName; //应用程序类型简称
}
if (arrFldSet.Contains(convCMProjectAppRela.CmPrjName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.CmPrjName = objvCMProjectAppRelaEN.CmPrjName == "[null]" ? null :  objvCMProjectAppRelaEN.CmPrjName; //CM工程名
}
if (arrFldSet.Contains(convCMProjectAppRela.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.ApplicationTypeId = objvCMProjectAppRelaEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convCMProjectAppRela.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.CmPrjId = objvCMProjectAppRelaEN.CmPrjId; //CM工程Id
}
if (arrFldSet.Contains(convCMProjectAppRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.UpdUser = objvCMProjectAppRelaEN.UpdUser == "[null]" ? null :  objvCMProjectAppRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convCMProjectAppRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.OrderNum = objvCMProjectAppRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convCMProjectAppRela.AppOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.AppOrderNum = objvCMProjectAppRelaEN.AppOrderNum; //AppOrderNum
}
if (arrFldSet.Contains(convCMProjectAppRela.AppIsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvCMProjectAppRelaEN.AppIsVisible = objvCMProjectAppRelaEN.AppIsVisible; //AppIsVisible
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
 /// <param name = "objvCMProjectAppRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
try
{
if (objvCMProjectAppRelaEN.Memo == "[null]") objvCMProjectAppRelaEN.Memo = null; //说明
if (objvCMProjectAppRelaEN.UpdDate == "[null]") objvCMProjectAppRelaEN.UpdDate = null; //修改日期
if (objvCMProjectAppRelaEN.ApplicationTypeSimName == "[null]") objvCMProjectAppRelaEN.ApplicationTypeSimName = null; //应用程序类型简称
if (objvCMProjectAppRelaEN.CmPrjName == "[null]") objvCMProjectAppRelaEN.CmPrjName = null; //CM工程名
if (objvCMProjectAppRelaEN.UpdUser == "[null]") objvCMProjectAppRelaEN.UpdUser = null; //修改者
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
public static void CheckProperty4Condition(clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
 vCMProjectAppRelaDA.CheckProperty4Condition(objvCMProjectAppRelaEN);
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
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectBL没有刷新缓存机制(clsCMProjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCMProjectAppRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMProjectAppRelaBL没有刷新缓存机制(clsCMProjectAppRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CMProjectAppRelaId");
//if (arrvCMProjectAppRelaObjLstCache == null)
//{
//arrvCMProjectAppRelaObjLstCache = vCMProjectAppRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCMProjectAppRelaEN GetObjByCMProjectAppRelaIdCache(long lngCMProjectAppRelaId, string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLst_Sel =
arrvCMProjectAppRelaObjLstCache
.Where(x=> x.CMProjectAppRelaId == lngCMProjectAppRelaId 
);
if (arrvCMProjectAppRelaObjLst_Sel.Count() == 0)
{
   clsvCMProjectAppRelaEN obj = clsvCMProjectAppRelaBL.GetObjByCMProjectAppRelaId(lngCMProjectAppRelaId);
   if (obj != null)
 {
if (obj.PrjId == strPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngCMProjectAppRelaId, strPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCMProjectAppRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetAllvCMProjectAppRelaObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = GetObjLstCache(strPrjId); 
return arrvCMProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCMProjectAppRelaEN> GetObjLstCache(string strPrjId)
{

if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确!(In {1})", strPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvCMProjectAppRelaEN> arrvCMProjectAppRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCMProjectAppRelaObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCMProjectAppRelaEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvCMProjectAppRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCMProjectAppRelaEN._RefreshTimeLst.Count == 0) return "";
return clsvCMProjectAppRelaEN._RefreshTimeLst[clsvCMProjectAppRelaEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vCMProjectAppRela(vCMProjectAppRela)
 /// 唯一性条件:ApplicationTypeId_CmPrjId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
//检测记录是否存在
string strResult = vCMProjectAppRelaDA.GetUniCondStr(objvCMProjectAppRelaEN);
return strResult;
}


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
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngCMProjectAppRelaId, string strPrjId)
{
if (strInFldName != convCMProjectAppRela.CMProjectAppRelaId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCMProjectAppRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCMProjectAppRela.AttributeName));
throw new Exception(strMsg);
}
var objvCMProjectAppRela = clsvCMProjectAppRelaBL.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, strPrjId);
if (objvCMProjectAppRela == null) return "";
return objvCMProjectAppRela[strOutFldName].ToString();
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
int intRecCount = clsvCMProjectAppRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvCMProjectAppRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCMProjectAppRelaDA.GetRecCount();
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
int intRecCount = clsvCMProjectAppRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCMProjectAppRelaEN objvCMProjectAppRelaCond)
{
 string strPrjId = objvCMProjectAppRelaCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCMProjectAppRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCMProjectAppRelaEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvCMProjectAppRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCMProjectAppRela.AttributeName)
{
if (objvCMProjectAppRelaCond.IsUpdated(strFldName) == false) continue;
if (objvCMProjectAppRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectAppRelaCond[strFldName].ToString());
}
else
{
if (objvCMProjectAppRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCMProjectAppRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCMProjectAppRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCMProjectAppRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCMProjectAppRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCMProjectAppRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCMProjectAppRelaCond[strFldName]));
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
 List<string> arrList = clsvCMProjectAppRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectAppRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCMProjectAppRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}