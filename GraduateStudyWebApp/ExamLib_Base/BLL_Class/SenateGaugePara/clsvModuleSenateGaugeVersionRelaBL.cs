
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvModuleSenateGaugeVersionRelaBL
 表名:vModuleSenateGaugeVersionRela(01120461)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
public static class  clsvModuleSenateGaugeVersionRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetObj(this K_mId_vModuleSenateGaugeVersionRela myKey)
{
clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = clsvModuleSenateGaugeVersionRelaBL.vModuleSenateGaugeVersionRelaDA.GetObjBymId(myKey.Value);
return objvModuleSenateGaugeVersionRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetmId(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, long lngmId, string strComparisonOp="")
	{
objvModuleSenateGaugeVersionRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.mId) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.mId, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.mId] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetFuncModuleId(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convModuleSenateGaugeVersionRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convModuleSenateGaugeVersionRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convModuleSenateGaugeVersionRela.FuncModuleId);
}
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.FuncModuleId) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.FuncModuleId, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.FuncModuleId] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetFuncModuleName(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convModuleSenateGaugeVersionRela.FuncModuleName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convModuleSenateGaugeVersionRela.FuncModuleName);
}
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.FuncModuleName) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.FuncModuleName, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.FuncModuleName] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetOrderNum(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objvModuleSenateGaugeVersionRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.OrderNum) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.OrderNum, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.OrderNum] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetIdSenateGaugeVersion(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convModuleSenateGaugeVersionRela.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convModuleSenateGaugeVersionRela.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convModuleSenateGaugeVersionRela.IdSenateGaugeVersion);
}
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.IdSenateGaugeVersion) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetsenateGaugeVersionID(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convModuleSenateGaugeVersionRela.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convModuleSenateGaugeVersionRela.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convModuleSenateGaugeVersionRela.senateGaugeVersionID);
}
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.senateGaugeVersionID) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.senateGaugeVersionID, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionID] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetsenateGaugeVersionName(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convModuleSenateGaugeVersionRela.senateGaugeVersionName);
}
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.senateGaugeVersionName) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.senateGaugeVersionName, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionName] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetsenateGaugeVersionTtlScore(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore);
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetIsUse(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, bool bolIsUse, string strComparisonOp="")
	{
objvModuleSenateGaugeVersionRelaEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.IsUse) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.IsUse, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.IsUse] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetUserTypeId(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convModuleSenateGaugeVersionRela.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convModuleSenateGaugeVersionRela.UserTypeId);
}
objvModuleSenateGaugeVersionRelaEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.UserTypeId) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.UserTypeId, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.UserTypeId] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaENS">源对象</param>
 /// <param name = "objvModuleSenateGaugeVersionRelaENT">目标对象</param>
 public static void CopyTo(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaENS, clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaENT)
{
try
{
objvModuleSenateGaugeVersionRelaENT.mId = objvModuleSenateGaugeVersionRelaENS.mId; //mId
objvModuleSenateGaugeVersionRelaENT.FuncModuleId = objvModuleSenateGaugeVersionRelaENS.FuncModuleId; //功能模块Id
objvModuleSenateGaugeVersionRelaENT.FuncModuleName = objvModuleSenateGaugeVersionRelaENS.FuncModuleName; //功能模块名称
objvModuleSenateGaugeVersionRelaENT.OrderNum = objvModuleSenateGaugeVersionRelaENS.OrderNum; //序号
objvModuleSenateGaugeVersionRelaENT.IdSenateGaugeVersion = objvModuleSenateGaugeVersionRelaENS.IdSenateGaugeVersion; //评价量表版本流水号
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionID = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionID; //评价量表版本ID
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionName = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionName; //评价量表版本名称
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionTtlScore = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvModuleSenateGaugeVersionRelaENT.IsUse = objvModuleSenateGaugeVersionRelaENS.IsUse; //是否使用
objvModuleSenateGaugeVersionRelaENT.UserTypeId = objvModuleSenateGaugeVersionRelaENS.UserTypeId; //用户类型Id
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
 /// <param name = "objvModuleSenateGaugeVersionRelaENS">源对象</param>
 /// <returns>目标对象=>clsvModuleSenateGaugeVersionRelaEN:objvModuleSenateGaugeVersionRelaENT</returns>
 public static clsvModuleSenateGaugeVersionRelaEN CopyTo(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaENS)
{
try
{
 clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaENT = new clsvModuleSenateGaugeVersionRelaEN()
{
mId = objvModuleSenateGaugeVersionRelaENS.mId, //mId
FuncModuleId = objvModuleSenateGaugeVersionRelaENS.FuncModuleId, //功能模块Id
FuncModuleName = objvModuleSenateGaugeVersionRelaENS.FuncModuleName, //功能模块名称
OrderNum = objvModuleSenateGaugeVersionRelaENS.OrderNum, //序号
IdSenateGaugeVersion = objvModuleSenateGaugeVersionRelaENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionTtlScore, //评价量表版本总分
IsUse = objvModuleSenateGaugeVersionRelaENS.IsUse, //是否使用
UserTypeId = objvModuleSenateGaugeVersionRelaENS.UserTypeId, //用户类型Id
};
 return objvModuleSenateGaugeVersionRelaENT;
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
public static void CheckProperty4Condition(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN)
{
 clsvModuleSenateGaugeVersionRelaBL.vModuleSenateGaugeVersionRelaDA.CheckProperty4Condition(objvModuleSenateGaugeVersionRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.mId) == true)
{
string strComparisonOpmId = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleSenateGaugeVersionRela.mId, objvModuleSenateGaugeVersionRelaCond.mId, strComparisonOpmId);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.FuncModuleId, objvModuleSenateGaugeVersionRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.FuncModuleName, objvModuleSenateGaugeVersionRelaCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleSenateGaugeVersionRela.OrderNum, objvModuleSenateGaugeVersionRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.IdSenateGaugeVersion, objvModuleSenateGaugeVersionRelaCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.senateGaugeVersionID, objvModuleSenateGaugeVersionRelaCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.senateGaugeVersionName, objvModuleSenateGaugeVersionRelaCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore, objvModuleSenateGaugeVersionRelaCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.IsUse) == true)
{
if (objvModuleSenateGaugeVersionRelaCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convModuleSenateGaugeVersionRela.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convModuleSenateGaugeVersionRela.IsUse);
}
}
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(convModuleSenateGaugeVersionRela.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.UserTypeId, objvModuleSenateGaugeVersionRelaCond.UserTypeId, strComparisonOpUserTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vModuleSenateGaugeVersionRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v模块默认评价版本设置(vModuleSenateGaugeVersionRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvModuleSenateGaugeVersionRelaBL
{
public static RelatedActions_vModuleSenateGaugeVersionRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvModuleSenateGaugeVersionRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvModuleSenateGaugeVersionRelaDA vModuleSenateGaugeVersionRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvModuleSenateGaugeVersionRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvModuleSenateGaugeVersionRelaBL()
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
if (string.IsNullOrEmpty(clsvModuleSenateGaugeVersionRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvModuleSenateGaugeVersionRelaEN._ConnectString);
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
public static DataTable GetDataTable_vModuleSenateGaugeVersionRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTable_vModuleSenateGaugeVersionRela(strWhereCond);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTable(strWhereCond);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vModuleSenateGaugeVersionRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
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
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName);
List<clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLst_Sel =
arrvModuleSenateGaugeVersionRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvModuleSenateGaugeVersionRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLst(string strWhereCond)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvModuleSenateGaugeVersionRelaEN> GetSubObjLstCache(clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaCond)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleSenateGaugeVersionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convModuleSenateGaugeVersionRela.AttributeName)
{
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleSenateGaugeVersionRelaCond[strFldName].ToString());
}
else
{
if (objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleSenateGaugeVersionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvModuleSenateGaugeVersionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvModuleSenateGaugeVersionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvModuleSenateGaugeVersionRelaCond[strFldName]));
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
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
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
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
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = new List<clsvModuleSenateGaugeVersionRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = new clsvModuleSenateGaugeVersionRelaEN();
try
{
objvModuleSenateGaugeVersionRelaEN.mId = Int32.Parse(objRow[convModuleSenateGaugeVersionRela.mId].ToString().Trim()); //mId
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objRow[convModuleSenateGaugeVersionRela.FuncModuleId].ToString().Trim(); //功能模块Id
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objRow[convModuleSenateGaugeVersionRela.FuncModuleName].ToString().Trim(); //功能模块名称
objvModuleSenateGaugeVersionRelaEN.OrderNum = objRow[convModuleSenateGaugeVersionRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convModuleSenateGaugeVersionRela.OrderNum].ToString().Trim()); //序号
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objRow[convModuleSenateGaugeVersionRela.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvModuleSenateGaugeVersionRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convModuleSenateGaugeVersionRela.IsUse].ToString().Trim()); //是否使用
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objRow[convModuleSenateGaugeVersionRela.UserTypeId] == DBNull.Value ? null : objRow[convModuleSenateGaugeVersionRela.UserTypeId].ToString().Trim(); //用户类型Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvModuleSenateGaugeVersionRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvModuleSenateGaugeVersionRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvModuleSenateGaugeVersionRela(ref clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN)
{
bool bolResult = vModuleSenateGaugeVersionRelaDA.GetvModuleSenateGaugeVersionRela(ref objvModuleSenateGaugeVersionRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetObjBymId(long lngmId)
{
clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = vModuleSenateGaugeVersionRelaDA.GetObjBymId(lngmId);
return objvModuleSenateGaugeVersionRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = vModuleSenateGaugeVersionRelaDA.GetFirstObj(strWhereCond);
 return objvModuleSenateGaugeVersionRelaEN;
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
public static clsvModuleSenateGaugeVersionRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = vModuleSenateGaugeVersionRelaDA.GetObjByDataRow(objRow);
 return objvModuleSenateGaugeVersionRelaEN;
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
public static clsvModuleSenateGaugeVersionRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = vModuleSenateGaugeVersionRelaDA.GetObjByDataRow(objRow);
 return objvModuleSenateGaugeVersionRelaEN;
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
 /// <param name = "lstvModuleSenateGaugeVersionRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetObjBymIdFromList(long lngmId, List<clsvModuleSenateGaugeVersionRelaEN> lstvModuleSenateGaugeVersionRelaObjLst)
{
foreach (clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN in lstvModuleSenateGaugeVersionRelaObjLst)
{
if (objvModuleSenateGaugeVersionRelaEN.mId == lngmId)
{
return objvModuleSenateGaugeVersionRelaEN;
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
 lngmId = new clsvModuleSenateGaugeVersionRelaDA().GetFirstID(strWhereCond);
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
 arrList = vModuleSenateGaugeVersionRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vModuleSenateGaugeVersionRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vModuleSenateGaugeVersionRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvModuleSenateGaugeVersionRelaDA.IsExistTable();
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
 bolIsExist = vModuleSenateGaugeVersionRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvModuleSenateGaugeVersionRelaENS">源对象</param>
 /// <param name = "objvModuleSenateGaugeVersionRelaENT">目标对象</param>
 public static void CopyTo(clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaENS, clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaENT)
{
try
{
objvModuleSenateGaugeVersionRelaENT.mId = objvModuleSenateGaugeVersionRelaENS.mId; //mId
objvModuleSenateGaugeVersionRelaENT.FuncModuleId = objvModuleSenateGaugeVersionRelaENS.FuncModuleId; //功能模块Id
objvModuleSenateGaugeVersionRelaENT.FuncModuleName = objvModuleSenateGaugeVersionRelaENS.FuncModuleName; //功能模块名称
objvModuleSenateGaugeVersionRelaENT.OrderNum = objvModuleSenateGaugeVersionRelaENS.OrderNum; //序号
objvModuleSenateGaugeVersionRelaENT.IdSenateGaugeVersion = objvModuleSenateGaugeVersionRelaENS.IdSenateGaugeVersion; //评价量表版本流水号
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionID = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionID; //评价量表版本ID
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionName = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionName; //评价量表版本名称
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionTtlScore = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvModuleSenateGaugeVersionRelaENT.IsUse = objvModuleSenateGaugeVersionRelaENS.IsUse; //是否使用
objvModuleSenateGaugeVersionRelaENT.UserTypeId = objvModuleSenateGaugeVersionRelaENS.UserTypeId; //用户类型Id
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
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN)
{
try
{
objvModuleSenateGaugeVersionRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvModuleSenateGaugeVersionRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.mId = objvModuleSenateGaugeVersionRelaEN.mId; //mId
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.FuncModuleId = objvModuleSenateGaugeVersionRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.FuncModuleName = objvModuleSenateGaugeVersionRelaEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.OrderNum = objvModuleSenateGaugeVersionRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion = objvModuleSenateGaugeVersionRelaEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID = objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName == "[null]" ? null :  objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore = objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.IsUse = objvModuleSenateGaugeVersionRelaEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convModuleSenateGaugeVersionRela.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvModuleSenateGaugeVersionRelaEN.UserTypeId = objvModuleSenateGaugeVersionRelaEN.UserTypeId == "[null]" ? null :  objvModuleSenateGaugeVersionRelaEN.UserTypeId; //用户类型Id
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
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN)
{
try
{
if (objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName == "[null]") objvModuleSenateGaugeVersionRelaEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvModuleSenateGaugeVersionRelaEN.UserTypeId == "[null]") objvModuleSenateGaugeVersionRelaEN.UserTypeId = null; //用户类型Id
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
public static void CheckProperty4Condition(clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN)
{
 vModuleSenateGaugeVersionRelaDA.CheckProperty4Condition(objvModuleSenateGaugeVersionRelaEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsModuleSenateGaugeVersionRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsModuleSenateGaugeVersionRelaBL没有刷新缓存机制(clsModuleSenateGaugeVersionRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvModuleSenateGaugeVersionRelaObjLstCache == null)
//{
//arrvModuleSenateGaugeVersionRelaObjLstCache = vModuleSenateGaugeVersionRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName);
List<clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLst_Sel =
arrvModuleSenateGaugeVersionRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvModuleSenateGaugeVersionRelaObjLst_Sel.Count() == 0)
{
   clsvModuleSenateGaugeVersionRelaEN obj = clsvModuleSenateGaugeVersionRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvModuleSenateGaugeVersionRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetAllvModuleSenateGaugeVersionRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLstCache = GetObjLstCache(); 
return arrvModuleSenateGaugeVersionRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName);
List<clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvModuleSenateGaugeVersionRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convModuleSenateGaugeVersionRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convModuleSenateGaugeVersionRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convModuleSenateGaugeVersionRela.AttributeName));
throw new Exception(strMsg);
}
var objvModuleSenateGaugeVersionRela = clsvModuleSenateGaugeVersionRelaBL.GetObjBymIdCache(lngmId);
if (objvModuleSenateGaugeVersionRela == null) return "";
return objvModuleSenateGaugeVersionRela[strOutFldName].ToString();
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
int intRecCount = clsvModuleSenateGaugeVersionRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvModuleSenateGaugeVersionRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvModuleSenateGaugeVersionRelaDA.GetRecCount();
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
int intRecCount = clsvModuleSenateGaugeVersionRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaCond)
{
List<clsvModuleSenateGaugeVersionRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvModuleSenateGaugeVersionRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convModuleSenateGaugeVersionRela.AttributeName)
{
if (objvModuleSenateGaugeVersionRelaCond.IsUpdated(strFldName) == false) continue;
if (objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleSenateGaugeVersionRelaCond[strFldName].ToString());
}
else
{
if (objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvModuleSenateGaugeVersionRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvModuleSenateGaugeVersionRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvModuleSenateGaugeVersionRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvModuleSenateGaugeVersionRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvModuleSenateGaugeVersionRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvModuleSenateGaugeVersionRelaCond[strFldName]));
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
 List<string> arrList = clsvModuleSenateGaugeVersionRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vModuleSenateGaugeVersionRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vModuleSenateGaugeVersionRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}