
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeVersionBL
 表名:vSenateGaugeVersion(01120480)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:32
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
public static class  clsvSenateGaugeVersionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeVersionEN GetObj(this K_IdSenateGaugeVersion_vSenateGaugeVersion myKey)
{
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = clsvSenateGaugeVersionBL.vSenateGaugeVersionDA.GetObjByIdSenateGaugeVersion(myKey.Value);
return objvSenateGaugeVersionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetIdSenateGaugeVersion(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convSenateGaugeVersion.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convSenateGaugeVersion.IdSenateGaugeVersion);
}
objvSenateGaugeVersionEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.IdSenateGaugeVersion) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetsenateGaugeVersionID(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convSenateGaugeVersion.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGaugeVersion.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGaugeVersion.senateGaugeVersionID);
}
objvSenateGaugeVersionEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.senateGaugeVersionID) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.senateGaugeVersionID, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionID] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetsenateGaugeVersionName(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionName, convSenateGaugeVersion.senateGaugeVersionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGaugeVersion.senateGaugeVersionName);
}
objvSenateGaugeVersionEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.senateGaugeVersionName) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.senateGaugeVersionName, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionName] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetsenateGaugeVersionMemo(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGaugeVersion.senateGaugeVersionMemo);
}
objvSenateGaugeVersionEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.senateGaugeVersionMemo) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetsenateGaugeVersionTtlScore(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convSenateGaugeVersion.senateGaugeVersionTtlScore);
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.senateGaugeVersionTtlScore) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetSkillTypeID(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strSkillTypeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convSenateGaugeVersion.SkillTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convSenateGaugeVersion.SkillTypeID);
}
objvSenateGaugeVersionEN.SkillTypeID = strSkillTypeID; //技能类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.SkillTypeID) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.SkillTypeID, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.SkillTypeID] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetSkillTypeName(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strSkillTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convSenateGaugeVersion.SkillTypeName);
}
objvSenateGaugeVersionEN.SkillTypeName = strSkillTypeName; //技能类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.SkillTypeName) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.SkillTypeName, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.SkillTypeName] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetIdSkillType(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strIdSkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSkillType, convSenateGaugeVersion.IdSkillType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, convSenateGaugeVersion.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, convSenateGaugeVersion.IdSkillType);
}
objvSenateGaugeVersionEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.IdSkillType) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.IdSkillType, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.IdSkillType] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetVersionNo(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, int? intVersionNo, string strComparisonOp="")
	{
objvSenateGaugeVersionEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.VersionNo) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.VersionNo, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.VersionNo] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetIsUse(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, bool bolIsUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUse, convSenateGaugeVersion.IsUse);
objvSenateGaugeVersionEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.IsUse) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.IsUse, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.IsUse] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUserTypeId(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserTypeId, convSenateGaugeVersion.UserTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convSenateGaugeVersion.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convSenateGaugeVersion.UserTypeId);
}
objvSenateGaugeVersionEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.UserTypeId) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.UserTypeId, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.UserTypeId] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUserTypeName(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convSenateGaugeVersion.UserTypeName);
}
objvSenateGaugeVersionEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.UserTypeName) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.UserTypeName, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.UserTypeName] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetSenateGaugeNum(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, int? intSenateGaugeNum, string strComparisonOp="")
	{
objvSenateGaugeVersionEN.SenateGaugeNum = intSenateGaugeNum; //SenateGaugeNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.SenateGaugeNum) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.SenateGaugeNum, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.SenateGaugeNum] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetCalaTotalScore(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, float? fltCalaTotalScore, string strComparisonOp="")
	{
objvSenateGaugeVersionEN.CalaTotalScore = fltCalaTotalScore; //CalaTotalScore
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.CalaTotalScore) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.CalaTotalScore, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.CalaTotalScore] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUpdDate(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGaugeVersion.UpdDate);
}
objvSenateGaugeVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.UpdDate) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.UpdDate, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.UpdDate] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUpdUserId(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGaugeVersion.UpdUserId);
}
objvSenateGaugeVersionEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.UpdUserId) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.UpdUserId, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.UpdUserId] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(this clsvSenateGaugeVersionEN objvSenateGaugeVersionENS, clsvSenateGaugeVersionEN objvSenateGaugeVersionENT)
{
try
{
objvSenateGaugeVersionENT.IdSenateGaugeVersion = objvSenateGaugeVersionENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeVersionENT.senateGaugeVersionID = objvSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeVersionENT.senateGaugeVersionName = objvSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeVersionENT.senateGaugeVersionMemo = objvSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeVersionENT.SkillTypeID = objvSenateGaugeVersionENS.SkillTypeID; //技能类型ID
objvSenateGaugeVersionENT.SkillTypeName = objvSenateGaugeVersionENS.SkillTypeName; //技能类型名称
objvSenateGaugeVersionENT.IdSkillType = objvSenateGaugeVersionENS.IdSkillType; //技能类型流水号
objvSenateGaugeVersionENT.VersionNo = objvSenateGaugeVersionENS.VersionNo; //版本号
objvSenateGaugeVersionENT.IsUse = objvSenateGaugeVersionENS.IsUse; //是否使用
objvSenateGaugeVersionENT.UserTypeId = objvSenateGaugeVersionENS.UserTypeId; //用户类型Id
objvSenateGaugeVersionENT.UserTypeName = objvSenateGaugeVersionENS.UserTypeName; //用户类型名称
objvSenateGaugeVersionENT.SenateGaugeNum = objvSenateGaugeVersionENS.SenateGaugeNum; //SenateGaugeNum
objvSenateGaugeVersionENT.CalaTotalScore = objvSenateGaugeVersionENS.CalaTotalScore; //CalaTotalScore
objvSenateGaugeVersionENT.UpdDate = objvSenateGaugeVersionENS.UpdDate; //修改日期
objvSenateGaugeVersionENT.UpdUserId = objvSenateGaugeVersionENS.UpdUserId; //修改用户Id
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
 /// <param name = "objvSenateGaugeVersionENS">源对象</param>
 /// <returns>目标对象=>clsvSenateGaugeVersionEN:objvSenateGaugeVersionENT</returns>
 public static clsvSenateGaugeVersionEN CopyTo(this clsvSenateGaugeVersionEN objvSenateGaugeVersionENS)
{
try
{
 clsvSenateGaugeVersionEN objvSenateGaugeVersionENT = new clsvSenateGaugeVersionEN()
{
IdSenateGaugeVersion = objvSenateGaugeVersionENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objvSenateGaugeVersionENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvSenateGaugeVersionENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionMemo = objvSenateGaugeVersionENS.senateGaugeVersionMemo, //评价量表版本说明
senateGaugeVersionTtlScore = objvSenateGaugeVersionENS.senateGaugeVersionTtlScore, //评价量表版本总分
SkillTypeID = objvSenateGaugeVersionENS.SkillTypeID, //技能类型ID
SkillTypeName = objvSenateGaugeVersionENS.SkillTypeName, //技能类型名称
IdSkillType = objvSenateGaugeVersionENS.IdSkillType, //技能类型流水号
VersionNo = objvSenateGaugeVersionENS.VersionNo, //版本号
IsUse = objvSenateGaugeVersionENS.IsUse, //是否使用
UserTypeId = objvSenateGaugeVersionENS.UserTypeId, //用户类型Id
UserTypeName = objvSenateGaugeVersionENS.UserTypeName, //用户类型名称
SenateGaugeNum = objvSenateGaugeVersionENS.SenateGaugeNum, //SenateGaugeNum
CalaTotalScore = objvSenateGaugeVersionENS.CalaTotalScore, //CalaTotalScore
UpdDate = objvSenateGaugeVersionENS.UpdDate, //修改日期
UpdUserId = objvSenateGaugeVersionENS.UpdUserId, //修改用户Id
};
 return objvSenateGaugeVersionENT;
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
public static void CheckProperty4Condition(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN)
{
 clsvSenateGaugeVersionBL.vSenateGaugeVersionDA.CheckProperty4Condition(objvSenateGaugeVersionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeVersionEN objvSenateGaugeVersionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.IdSenateGaugeVersion, objvSenateGaugeVersionCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.senateGaugeVersionID, objvSenateGaugeVersionCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.senateGaugeVersionName, objvSenateGaugeVersionCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionMemo) == true)
{
string strComparisonOpsenateGaugeVersionMemo = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.senateGaugeVersionMemo, objvSenateGaugeVersionCond.senateGaugeVersionMemo, strComparisonOpsenateGaugeVersionMemo);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.senateGaugeVersionTtlScore, objvSenateGaugeVersionCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.SkillTypeID) == true)
{
string strComparisonOpSkillTypeID = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.SkillTypeID, objvSenateGaugeVersionCond.SkillTypeID, strComparisonOpSkillTypeID);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.SkillTypeName) == true)
{
string strComparisonOpSkillTypeName = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.SkillTypeName, objvSenateGaugeVersionCond.SkillTypeName, strComparisonOpSkillTypeName);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.IdSkillType, objvSenateGaugeVersionCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.VersionNo) == true)
{
string strComparisonOpVersionNo = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.VersionNo, objvSenateGaugeVersionCond.VersionNo, strComparisonOpVersionNo);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.IsUse) == true)
{
if (objvSenateGaugeVersionCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeVersion.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeVersion.IsUse);
}
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UserTypeId, objvSenateGaugeVersionCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UserTypeName, objvSenateGaugeVersionCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.SenateGaugeNum) == true)
{
string strComparisonOpSenateGaugeNum = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.SenateGaugeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.SenateGaugeNum, objvSenateGaugeVersionCond.SenateGaugeNum, strComparisonOpSenateGaugeNum);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.CalaTotalScore) == true)
{
string strComparisonOpCalaTotalScore = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.CalaTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.CalaTotalScore, objvSenateGaugeVersionCond.CalaTotalScore, strComparisonOpCalaTotalScore);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UpdDate, objvSenateGaugeVersionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSenateGaugeVersionCond.IsUpdated(convSenateGaugeVersion.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSenateGaugeVersionCond.dicFldComparisonOp[convSenateGaugeVersion.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UpdUserId, objvSenateGaugeVersionCond.UpdUserId, strComparisonOpUpdUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSenateGaugeVersion
{
public virtual bool UpdRelaTabDate(string strIdSenateGaugeVersion, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v评价量规版本(vSenateGaugeVersion)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeVersionBL
{
public static RelatedActions_vSenateGaugeVersion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSenateGaugeVersionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSenateGaugeVersionDA vSenateGaugeVersionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSenateGaugeVersionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSenateGaugeVersionBL()
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
if (string.IsNullOrEmpty(clsvSenateGaugeVersionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSenateGaugeVersionEN._ConnectString);
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
public static DataTable GetDataTable_vSenateGaugeVersion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSenateGaugeVersionDA.GetDataTable_vSenateGaugeVersion(strWhereCond);
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
objDT = vSenateGaugeVersionDA.GetDataTable(strWhereCond);
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
objDT = vSenateGaugeVersionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSenateGaugeVersionDA.GetDataTable_Top(objTopPara);
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
objDT = vSenateGaugeVersionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLstByIdSenateGaugeVersionLst(List<string> arrIdSenateGaugeVersionLst)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSenateGaugeVersionLst, true);
 string strWhereCond = string.Format("IdSenateGaugeVersion in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSenateGaugeVersionEN> GetObjLstByIdSenateGaugeVersionLstCache(List<string> arrIdSenateGaugeVersionLst)
{
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel =
arrvSenateGaugeVersionObjLstCache
.Where(x => arrIdSenateGaugeVersionLst.Contains(x.IdSenateGaugeVersion));
return arrvSenateGaugeVersionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLst(string strWhereCond)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
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
public static List<clsvSenateGaugeVersionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSenateGaugeVersionEN> GetSubObjLstCache(clsvSenateGaugeVersionEN objvSenateGaugeVersionCond)
{
List<clsvSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGaugeVersion.AttributeName)
{
if (objvSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeVersionCond[strFldName]));
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
public static List<clsvSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
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
public static List<clsvSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
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
List<clsvSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
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
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
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
public static List<clsvSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
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
public static List<clsvSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeVersionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSenateGaugeVersion(ref clsvSenateGaugeVersionEN objvSenateGaugeVersionEN)
{
bool bolResult = vSenateGaugeVersionDA.GetvSenateGaugeVersion(ref objvSenateGaugeVersionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeVersionEN GetObjByIdSenateGaugeVersion(string strIdSenateGaugeVersion)
{
if (strIdSenateGaugeVersion.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSenateGaugeVersion]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSenateGaugeVersion]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = vSenateGaugeVersionDA.GetObjByIdSenateGaugeVersion(strIdSenateGaugeVersion);
return objvSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSenateGaugeVersionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = vSenateGaugeVersionDA.GetFirstObj(strWhereCond);
 return objvSenateGaugeVersionEN;
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
public static clsvSenateGaugeVersionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = vSenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objvSenateGaugeVersionEN;
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
public static clsvSenateGaugeVersionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = vSenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objvSenateGaugeVersionEN;
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
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <param name = "lstvSenateGaugeVersionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeVersionEN GetObjByIdSenateGaugeVersionFromList(string strIdSenateGaugeVersion, List<clsvSenateGaugeVersionEN> lstvSenateGaugeVersionObjLst)
{
foreach (clsvSenateGaugeVersionEN objvSenateGaugeVersionEN in lstvSenateGaugeVersionObjLst)
{
if (objvSenateGaugeVersionEN.IdSenateGaugeVersion == strIdSenateGaugeVersion)
{
return objvSenateGaugeVersionEN;
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
 string strIdSenateGaugeVersion;
 try
 {
 strIdSenateGaugeVersion = new clsvSenateGaugeVersionDA().GetFirstID(strWhereCond);
 return strIdSenateGaugeVersion;
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
 arrList = vSenateGaugeVersionDA.GetID(strWhereCond);
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
bool bolIsExist = vSenateGaugeVersionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSenateGaugeVersion]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSenateGaugeVersionDA.IsExist(strIdSenateGaugeVersion);
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
 bolIsExist = clsvSenateGaugeVersionDA.IsExistTable();
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
 bolIsExist = vSenateGaugeVersionDA.IsExistTable(strTabName);
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
 /// <param name = "objvSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeVersionEN objvSenateGaugeVersionENS, clsvSenateGaugeVersionEN objvSenateGaugeVersionENT)
{
try
{
objvSenateGaugeVersionENT.IdSenateGaugeVersion = objvSenateGaugeVersionENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeVersionENT.senateGaugeVersionID = objvSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeVersionENT.senateGaugeVersionName = objvSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeVersionENT.senateGaugeVersionMemo = objvSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeVersionENT.SkillTypeID = objvSenateGaugeVersionENS.SkillTypeID; //技能类型ID
objvSenateGaugeVersionENT.SkillTypeName = objvSenateGaugeVersionENS.SkillTypeName; //技能类型名称
objvSenateGaugeVersionENT.IdSkillType = objvSenateGaugeVersionENS.IdSkillType; //技能类型流水号
objvSenateGaugeVersionENT.VersionNo = objvSenateGaugeVersionENS.VersionNo; //版本号
objvSenateGaugeVersionENT.IsUse = objvSenateGaugeVersionENS.IsUse; //是否使用
objvSenateGaugeVersionENT.UserTypeId = objvSenateGaugeVersionENS.UserTypeId; //用户类型Id
objvSenateGaugeVersionENT.UserTypeName = objvSenateGaugeVersionENS.UserTypeName; //用户类型名称
objvSenateGaugeVersionENT.SenateGaugeNum = objvSenateGaugeVersionENS.SenateGaugeNum; //SenateGaugeNum
objvSenateGaugeVersionENT.CalaTotalScore = objvSenateGaugeVersionENS.CalaTotalScore; //CalaTotalScore
objvSenateGaugeVersionENT.UpdDate = objvSenateGaugeVersionENS.UpdDate; //修改日期
objvSenateGaugeVersionENT.UpdUserId = objvSenateGaugeVersionENS.UpdUserId; //修改用户Id
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
 /// <param name = "objvSenateGaugeVersionEN">源简化对象</param>
 public static void SetUpdFlag(clsvSenateGaugeVersionEN objvSenateGaugeVersionEN)
{
try
{
objvSenateGaugeVersionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSenateGaugeVersionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSenateGaugeVersion.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objvSenateGaugeVersionEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convSenateGaugeVersion.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.senateGaugeVersionID = objvSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convSenateGaugeVersion.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.senateGaugeVersionName = objvSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convSenateGaugeVersion.senateGaugeVersionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objvSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]" ? null :  objvSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
}
if (arrFldSet.Contains(convSenateGaugeVersion.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = objvSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convSenateGaugeVersion.SkillTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.SkillTypeID = objvSenateGaugeVersionEN.SkillTypeID == "[null]" ? null :  objvSenateGaugeVersionEN.SkillTypeID; //技能类型ID
}
if (arrFldSet.Contains(convSenateGaugeVersion.SkillTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.SkillTypeName = objvSenateGaugeVersionEN.SkillTypeName == "[null]" ? null :  objvSenateGaugeVersionEN.SkillTypeName; //技能类型名称
}
if (arrFldSet.Contains(convSenateGaugeVersion.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.IdSkillType = objvSenateGaugeVersionEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(convSenateGaugeVersion.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.VersionNo = objvSenateGaugeVersionEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convSenateGaugeVersion.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.IsUse = objvSenateGaugeVersionEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convSenateGaugeVersion.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.UserTypeId = objvSenateGaugeVersionEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convSenateGaugeVersion.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.UserTypeName = objvSenateGaugeVersionEN.UserTypeName == "[null]" ? null :  objvSenateGaugeVersionEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convSenateGaugeVersion.SenateGaugeNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.SenateGaugeNum = objvSenateGaugeVersionEN.SenateGaugeNum; //SenateGaugeNum
}
if (arrFldSet.Contains(convSenateGaugeVersion.CalaTotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.CalaTotalScore = objvSenateGaugeVersionEN.CalaTotalScore; //CalaTotalScore
}
if (arrFldSet.Contains(convSenateGaugeVersion.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.UpdDate = objvSenateGaugeVersionEN.UpdDate == "[null]" ? null :  objvSenateGaugeVersionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSenateGaugeVersion.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeVersionEN.UpdUserId = objvSenateGaugeVersionEN.UpdUserId == "[null]" ? null :  objvSenateGaugeVersionEN.UpdUserId; //修改用户Id
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
 /// <param name = "objvSenateGaugeVersionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSenateGaugeVersionEN objvSenateGaugeVersionEN)
{
try
{
if (objvSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]") objvSenateGaugeVersionEN.senateGaugeVersionMemo = null; //评价量表版本说明
if (objvSenateGaugeVersionEN.SkillTypeID == "[null]") objvSenateGaugeVersionEN.SkillTypeID = null; //技能类型ID
if (objvSenateGaugeVersionEN.SkillTypeName == "[null]") objvSenateGaugeVersionEN.SkillTypeName = null; //技能类型名称
if (objvSenateGaugeVersionEN.UserTypeName == "[null]") objvSenateGaugeVersionEN.UserTypeName = null; //用户类型名称
if (objvSenateGaugeVersionEN.UpdDate == "[null]") objvSenateGaugeVersionEN.UpdDate = null; //修改日期
if (objvSenateGaugeVersionEN.UpdUserId == "[null]") objvSenateGaugeVersionEN.UpdUserId = null; //修改用户Id
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
public static void CheckProperty4Condition(clsvSenateGaugeVersionEN objvSenateGaugeVersionEN)
{
 vSenateGaugeVersionDA.CheckProperty4Condition(objvSenateGaugeVersionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdSenateGaugeVersion(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSenateGaugeVersion.IdSenateGaugeVersion); 
List<clsvSenateGaugeVersionEN> arrObjLst = clsvSenateGaugeVersionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN()
{
IdSenateGaugeVersion = "0",
senateGaugeVersionName = "选[v评价量规版本]..."
};
arrObjLst.Insert(0, objvSenateGaugeVersionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convSenateGaugeVersion.IdSenateGaugeVersion;
objComboBox.DisplayMember = convSenateGaugeVersion.senateGaugeVersionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdSenateGaugeVersion(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v评价量规版本]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convSenateGaugeVersion.IdSenateGaugeVersion); 
IEnumerable<clsvSenateGaugeVersionEN> arrObjLst = clsvSenateGaugeVersionBL.GetObjLst(strCondition);
objDDL.DataValueField = convSenateGaugeVersion.IdSenateGaugeVersion;
objDDL.DataTextField = convSenateGaugeVersion.senateGaugeVersionName;
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
public static void BindDdl_IdSenateGaugeVersionCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v评价量规版本]...","0");
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst = GetAllvSenateGaugeVersionObjLstCache(); 
objDDL.DataValueField = convSenateGaugeVersion.IdSenateGaugeVersion;
objDDL.DataTextField = convSenateGaugeVersion.senateGaugeVersionName;
objDDL.DataSource = arrvSenateGaugeVersionObjLst;
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
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSenateGaugeVersion");
//if (arrvSenateGaugeVersionObjLstCache == null)
//{
//arrvSenateGaugeVersionObjLstCache = vSenateGaugeVersionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeVersionEN GetObjByIdSenateGaugeVersionCache(string strIdSenateGaugeVersion)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel =
arrvSenateGaugeVersionObjLstCache
.Where(x=> x.IdSenateGaugeVersion == strIdSenateGaugeVersion 
);
if (arrvSenateGaugeVersionObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeVersionEN obj = clsvSenateGaugeVersionBL.GetObjByIdSenateGaugeVersion(strIdSenateGaugeVersion);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSenateGaugeVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeVersionNameByIdSenateGaugeVersionCache(string strIdSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsvSenateGaugeVersionEN objvSenateGaugeVersion = GetObjByIdSenateGaugeVersionCache(strIdSenateGaugeVersion);
if (objvSenateGaugeVersion == null) return "";
return objvSenateGaugeVersion.senateGaugeVersionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSenateGaugeVersionCache(string strIdSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsvSenateGaugeVersionEN objvSenateGaugeVersion = GetObjByIdSenateGaugeVersionCache(strIdSenateGaugeVersion);
if (objvSenateGaugeVersion == null) return "";
return objvSenateGaugeVersion.senateGaugeVersionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetAllvSenateGaugeVersionObjLstCache()
{
//获取缓存中的对象列表
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLstCache = GetObjLstCache(); 
return arrvSenateGaugeVersionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeVersionObjLstCache;
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
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdSenateGaugeVersion)
{
if (strInFldName != convSenateGaugeVersion.IdSenateGaugeVersion)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSenateGaugeVersion.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSenateGaugeVersion.AttributeName));
throw new Exception(strMsg);
}
var objvSenateGaugeVersion = clsvSenateGaugeVersionBL.GetObjByIdSenateGaugeVersionCache(strIdSenateGaugeVersion);
if (objvSenateGaugeVersion == null) return "";
return objvSenateGaugeVersion[strOutFldName].ToString();
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
int intRecCount = clsvSenateGaugeVersionDA.GetRecCount(strTabName);
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
int intRecCount = clsvSenateGaugeVersionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSenateGaugeVersionDA.GetRecCount();
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
int intRecCount = clsvSenateGaugeVersionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSenateGaugeVersionEN objvSenateGaugeVersionCond)
{
List<clsvSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGaugeVersion.AttributeName)
{
if (objvSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeVersionCond[strFldName]));
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
 List<string> arrList = clsvSenateGaugeVersionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeVersionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeVersionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}