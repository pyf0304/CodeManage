
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPubClassCaseSenateGaugeVersionBL
 表名:vPubClassCaseSenateGaugeVersion(01120505)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsvPubClassCaseSenateGaugeVersionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetObj(this K_IdPubClassCaseSenateGaugeVersion_vPubClassCaseSenateGaugeVersion myKey)
{
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = clsvPubClassCaseSenateGaugeVersionBL.vPubClassCaseSenateGaugeVersionDA.GetObjByIdPubClassCaseSenateGaugeVersion(myKey.Value);
return objvPubClassCaseSenateGaugeVersionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetIdPubClassCaseSenateGaugeVersion(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strIdPubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateGaugeVersion, 4, convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateGaugeVersion, 4, convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionID(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionName(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
}
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetVersionNo(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, int? intVersionNo, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.VersionNo) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.VersionNo, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.VersionNo] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetIsUse(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, bool bolIsUse, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.IsUse) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.IsUse, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.IsUse] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionTtlScore(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionMemo(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
}
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPubClassCaseSenateGaugeVersionEN SetSenateGaugeNum(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN, int? intSenateGaugeNum, string strComparisonOp="")
	{
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = intSenateGaugeNum; //SenateGaugeNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convPubClassCaseSenateGaugeVersion.SenateGaugeNum) == false)
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(convPubClassCaseSenateGaugeVersion.SenateGaugeNum, strComparisonOp);
}
else
{
objvPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] = strComparisonOp;
}
}
return objvPubClassCaseSenateGaugeVersionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENS, clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENT)
{
try
{
objvPubClassCaseSenateGaugeVersionENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionID = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionName = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseSenateGaugeVersionENT.VersionNo = objvPubClassCaseSenateGaugeVersionENS.VersionNo; //版本号
objvPubClassCaseSenateGaugeVersionENT.IsUse = objvPubClassCaseSenateGaugeVersionENS.IsUse; //是否使用
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvPubClassCaseSenateGaugeVersionENT.SenateGaugeNum = objvPubClassCaseSenateGaugeVersionENS.SenateGaugeNum; //SenateGaugeNum
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
 /// <param name = "objvPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <returns>目标对象=>clsvPubClassCaseSenateGaugeVersionEN:objvPubClassCaseSenateGaugeVersionENT</returns>
 public static clsvPubClassCaseSenateGaugeVersionEN CopyTo(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENS)
{
try
{
 clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENT = new clsvPubClassCaseSenateGaugeVersionEN()
{
IdPubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion, //公开课量表版本流水号
senateGaugeVersionID = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName, //评价量表版本名称
VersionNo = objvPubClassCaseSenateGaugeVersionENS.VersionNo, //版本号
IsUse = objvPubClassCaseSenateGaugeVersionENS.IsUse, //是否使用
senateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore, //评价量表版本总分
senateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo, //评价量表版本说明
SenateGaugeNum = objvPubClassCaseSenateGaugeVersionENS.SenateGaugeNum, //SenateGaugeNum
};
 return objvPubClassCaseSenateGaugeVersionENT;
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
public static void CheckProperty4Condition(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN)
{
 clsvPubClassCaseSenateGaugeVersionBL.vPubClassCaseSenateGaugeVersionDA.CheckProperty4Condition(objvPubClassCaseSenateGaugeVersionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOpIdPubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, objvPubClassCaseSenateGaugeVersionCond.IdPubClassCaseSenateGaugeVersion, strComparisonOpIdPubClassCaseSenateGaugeVersion);
}
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.senateGaugeVersionID, objvPubClassCaseSenateGaugeVersionCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.senateGaugeVersionName, objvPubClassCaseSenateGaugeVersionCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.VersionNo) == true)
{
string strComparisonOpVersionNo = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenateGaugeVersion.VersionNo, objvPubClassCaseSenateGaugeVersionCond.VersionNo, strComparisonOpVersionNo);
}
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.IsUse) == true)
{
if (objvPubClassCaseSenateGaugeVersionCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPubClassCaseSenateGaugeVersion.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPubClassCaseSenateGaugeVersion.IsUse);
}
}
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, objvPubClassCaseSenateGaugeVersionCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo) == true)
{
string strComparisonOpsenateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, objvPubClassCaseSenateGaugeVersionCond.senateGaugeVersionMemo, strComparisonOpsenateGaugeVersionMemo);
}
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(convPubClassCaseSenateGaugeVersion.SenateGaugeNum) == true)
{
string strComparisonOpSenateGaugeNum = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[convPubClassCaseSenateGaugeVersion.SenateGaugeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPubClassCaseSenateGaugeVersion.SenateGaugeNum, objvPubClassCaseSenateGaugeVersionCond.SenateGaugeNum, strComparisonOpSenateGaugeNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPubClassCaseSenateGaugeVersion
{
public virtual bool UpdRelaTabDate(string strIdPubClassCaseSenateGaugeVersion, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v公开课评价量规版本(vPubClassCaseSenateGaugeVersion)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPubClassCaseSenateGaugeVersionBL
{
public static RelatedActions_vPubClassCaseSenateGaugeVersion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPubClassCaseSenateGaugeVersionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPubClassCaseSenateGaugeVersionDA vPubClassCaseSenateGaugeVersionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPubClassCaseSenateGaugeVersionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPubClassCaseSenateGaugeVersionBL()
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
if (string.IsNullOrEmpty(clsvPubClassCaseSenateGaugeVersionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPubClassCaseSenateGaugeVersionEN._ConnectString);
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
public static DataTable GetDataTable_vPubClassCaseSenateGaugeVersion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTable_vPubClassCaseSenateGaugeVersion(strWhereCond);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTable_Top(objTopPara);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPubClassCaseSenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByIdPubClassCaseSenateGaugeVersionLst(List<string> arrIdPubClassCaseSenateGaugeVersionLst)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseSenateGaugeVersionLst, true);
 string strWhereCond = string.Format("IdPubClassCaseSenateGaugeVersion in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByIdPubClassCaseSenateGaugeVersionLstCache(List<string> arrIdPubClassCaseSenateGaugeVersionLst)
{
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel =
arrvPubClassCaseSenateGaugeVersionObjLstCache
.Where(x => arrIdPubClassCaseSenateGaugeVersionLst.Contains(x.IdPubClassCaseSenateGaugeVersion));
return arrvPubClassCaseSenateGaugeVersionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLst(string strWhereCond)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPubClassCaseSenateGaugeVersionEN> GetSubObjLstCache(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionCond)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseSenateGaugeVersion.AttributeName)
{
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateGaugeVersionCond[strFldName]));
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
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
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
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
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
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
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsvPubClassCaseSenateGaugeVersionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN();
try
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[convPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPubClassCaseSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPubClassCaseSenateGaugeVersion(ref clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN)
{
bool bolResult = vPubClassCaseSenateGaugeVersionDA.GetvPubClassCaseSenateGaugeVersion(ref objvPubClassCaseSenateGaugeVersionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersion(string strIdPubClassCaseSenateGaugeVersion)
{
if (strIdPubClassCaseSenateGaugeVersion.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdPubClassCaseSenateGaugeVersion]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdPubClassCaseSenateGaugeVersion]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = vPubClassCaseSenateGaugeVersionDA.GetObjByIdPubClassCaseSenateGaugeVersion(strIdPubClassCaseSenateGaugeVersion);
return objvPubClassCaseSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = vPubClassCaseSenateGaugeVersionDA.GetFirstObj(strWhereCond);
 return objvPubClassCaseSenateGaugeVersionEN;
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
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = vPubClassCaseSenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objvPubClassCaseSenateGaugeVersionEN;
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
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = vPubClassCaseSenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objvPubClassCaseSenateGaugeVersionEN;
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
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <param name = "lstvPubClassCaseSenateGaugeVersionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersionFromList(string strIdPubClassCaseSenateGaugeVersion, List<clsvPubClassCaseSenateGaugeVersionEN> lstvPubClassCaseSenateGaugeVersionObjLst)
{
foreach (clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN in lstvPubClassCaseSenateGaugeVersionObjLst)
{
if (objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion == strIdPubClassCaseSenateGaugeVersion)
{
return objvPubClassCaseSenateGaugeVersionEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdPubClassCaseSenateGaugeVersion;
 try
 {
 strIdPubClassCaseSenateGaugeVersion = new clsvPubClassCaseSenateGaugeVersionDA().GetFirstID(strWhereCond);
 return strIdPubClassCaseSenateGaugeVersion;
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
 arrList = vPubClassCaseSenateGaugeVersionDA.GetID(strWhereCond);
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
bool bolIsExist = vPubClassCaseSenateGaugeVersionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdPubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdPubClassCaseSenateGaugeVersion]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPubClassCaseSenateGaugeVersionDA.IsExist(strIdPubClassCaseSenateGaugeVersion);
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
 bolIsExist = clsvPubClassCaseSenateGaugeVersionDA.IsExistTable();
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
 bolIsExist = vPubClassCaseSenateGaugeVersionDA.IsExistTable(strTabName);
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
 /// <param name = "objvPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvPubClassCaseSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENS, clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionENT)
{
try
{
objvPubClassCaseSenateGaugeVersionENT.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionID = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionName = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvPubClassCaseSenateGaugeVersionENT.VersionNo = objvPubClassCaseSenateGaugeVersionENS.VersionNo; //版本号
objvPubClassCaseSenateGaugeVersionENT.IsUse = objvPubClassCaseSenateGaugeVersionENS.IsUse; //是否使用
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvPubClassCaseSenateGaugeVersionENT.senateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvPubClassCaseSenateGaugeVersionENT.SenateGaugeNum = objvPubClassCaseSenateGaugeVersionENS.SenateGaugeNum; //SenateGaugeNum
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
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">源简化对象</param>
 public static void SetUpdFlag(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN)
{
try
{
objvPubClassCaseSenateGaugeVersionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPubClassCaseSenateGaugeVersionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objvPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
}
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID == "[null]" ? null :  objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName == "[null]" ? null :  objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.VersionNo = objvPubClassCaseSenateGaugeVersionEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.IsUse = objvPubClassCaseSenateGaugeVersionEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]" ? null :  objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
}
if (arrFldSet.Contains(convPubClassCaseSenateGaugeVersion.SenateGaugeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum = objvPubClassCaseSenateGaugeVersionEN.SenateGaugeNum; //SenateGaugeNum
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
 /// <param name = "objvPubClassCaseSenateGaugeVersionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN)
{
try
{
if (objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID == "[null]") objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName == "[null]") objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]") objvPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = null; //评价量表版本说明
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
public static void CheckProperty4Condition(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN)
{
 vPubClassCaseSenateGaugeVersionDA.CheckProperty4Condition(objvPubClassCaseSenateGaugeVersionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdPubClassCaseSenateGaugeVersion(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion); 
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = clsvPubClassCaseSenateGaugeVersionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionEN = new clsvPubClassCaseSenateGaugeVersionEN()
{
IdPubClassCaseSenateGaugeVersion = "0",
senateGaugeVersionName = "选[v公开课评价量规版本]..."
};
arrObjLst.Insert(0, objvPubClassCaseSenateGaugeVersionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion;
objComboBox.DisplayMember = convPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdPubClassCaseSenateGaugeVersion(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v公开课评价量规版本]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion); 
IEnumerable<clsvPubClassCaseSenateGaugeVersionEN> arrObjLst = clsvPubClassCaseSenateGaugeVersionBL.GetObjLst(strCondition);
objDDL.DataValueField = convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion;
objDDL.DataTextField = convPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdPubClassCaseSenateGaugeVersionCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v公开课评价量规版本]...","0");
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst = GetAllvPubClassCaseSenateGaugeVersionObjLstCache(); 
objDDL.DataValueField = convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion;
objDDL.DataTextField = convPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
objDDL.DataSource = arrvPubClassCaseSenateGaugeVersionObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseSenateGaugeVersion");
//if (arrvPubClassCaseSenateGaugeVersionObjLstCache == null)
//{
//arrvPubClassCaseSenateGaugeVersionObjLstCache = vPubClassCaseSenateGaugeVersionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersionCache(string strIdPubClassCaseSenateGaugeVersion)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLst_Sel =
arrvPubClassCaseSenateGaugeVersionObjLstCache
.Where(x=> x.IdPubClassCaseSenateGaugeVersion == strIdPubClassCaseSenateGaugeVersion 
);
if (arrvPubClassCaseSenateGaugeVersionObjLst_Sel.Count() == 0)
{
   clsvPubClassCaseSenateGaugeVersionEN obj = clsvPubClassCaseSenateGaugeVersionBL.GetObjByIdPubClassCaseSenateGaugeVersion(strIdPubClassCaseSenateGaugeVersion);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPubClassCaseSenateGaugeVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeVersionNameByIdPubClassCaseSenateGaugeVersionCache(string strIdPubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersion = GetObjByIdPubClassCaseSenateGaugeVersionCache(strIdPubClassCaseSenateGaugeVersion);
if (objvPubClassCaseSenateGaugeVersion == null) return "";
return objvPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdPubClassCaseSenateGaugeVersionCache(string strIdPubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersion = GetObjByIdPubClassCaseSenateGaugeVersionCache(strIdPubClassCaseSenateGaugeVersion);
if (objvPubClassCaseSenateGaugeVersion == null) return "";
return objvPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetAllvPubClassCaseSenateGaugeVersionObjLstCache()
{
//获取缓存中的对象列表
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLstCache = GetObjLstCache(); 
return arrvPubClassCaseSenateGaugeVersionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPubClassCaseSenateGaugeVersionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName);
List<clsvPubClassCaseSenateGaugeVersionEN> arrvPubClassCaseSenateGaugeVersionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPubClassCaseSenateGaugeVersionObjLstCache;
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
string strKey = string.Format("{0}", clsvPubClassCaseSenateGaugeVersionEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdPubClassCaseSenateGaugeVersion)
{
if (strInFldName != convPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPubClassCaseSenateGaugeVersion.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPubClassCaseSenateGaugeVersion.AttributeName));
throw new Exception(strMsg);
}
var objvPubClassCaseSenateGaugeVersion = clsvPubClassCaseSenateGaugeVersionBL.GetObjByIdPubClassCaseSenateGaugeVersionCache(strIdPubClassCaseSenateGaugeVersion);
if (objvPubClassCaseSenateGaugeVersion == null) return "";
return objvPubClassCaseSenateGaugeVersion[strOutFldName].ToString();
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
int intRecCount = clsvPubClassCaseSenateGaugeVersionDA.GetRecCount(strTabName);
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
int intRecCount = clsvPubClassCaseSenateGaugeVersionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPubClassCaseSenateGaugeVersionDA.GetRecCount();
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
int intRecCount = clsvPubClassCaseSenateGaugeVersionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPubClassCaseSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPubClassCaseSenateGaugeVersionEN objvPubClassCaseSenateGaugeVersionCond)
{
List<clsvPubClassCaseSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPubClassCaseSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPubClassCaseSenateGaugeVersion.AttributeName)
{
if (objvPubClassCaseSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPubClassCaseSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPubClassCaseSenateGaugeVersionCond[strFldName]));
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
 List<string> arrList = clsvPubClassCaseSenateGaugeVersionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseSenateGaugeVersionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPubClassCaseSenateGaugeVersionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}