
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeVersionWApi
 表名:vSenateGaugeVersion(01120480)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:48
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数
 模块英文名:SenateGaugePara
 框架-层名:WA_访问层_CS(WA_Access)
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
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvSenateGaugeVersionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN Setid_SenateGaugeVersion(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convSenateGaugeVersion.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convSenateGaugeVersion.id_SenateGaugeVersion);
objvSenateGaugeVersionEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.id_SenateGaugeVersion) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetsenateGaugeVersionID(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGaugeVersion.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetsenateGaugeVersionName(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionName, convSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGaugeVersion.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetsenateGaugeVersionMemo(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGaugeVersion.senateGaugeVersionMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetSkillTypeID(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strSkillTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeID, 4, convSenateGaugeVersion.SkillTypeID);
clsCheckSql.CheckFieldForeignKey(strSkillTypeID, 4, convSenateGaugeVersion.SkillTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetSkillTypeName(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strSkillTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSkillTypeName, 50, convSenateGaugeVersion.SkillTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN Setid_SkillType(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SkillType, convSenateGaugeVersion.id_SkillType);
clsCheckSql.CheckFieldLen(strid_SkillType, 4, convSenateGaugeVersion.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, convSenateGaugeVersion.id_SkillType);
objvSenateGaugeVersionEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(convSenateGaugeVersion.id_SkillType) == false)
{
objvSenateGaugeVersionEN.dicFldComparisonOp.Add(convSenateGaugeVersion.id_SkillType, strComparisonOp);
}
else
{
objvSenateGaugeVersionEN.dicFldComparisonOp[convSenateGaugeVersion.id_SkillType] = strComparisonOp;
}
}
return objvSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetVersionNo(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, int intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUserTypeId(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserTypeId, convSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convSenateGaugeVersion.UserTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUserTypeName(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convSenateGaugeVersion.UserTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetSenateGaugeNum(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, int intSenateGaugeNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetCalaTotalScore(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, float fltCalaTotalScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUpdDate(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGaugeVersion.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeVersionEN SetUpdUserId(this clsvSenateGaugeVersionEN objvSenateGaugeVersionEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGaugeVersion.UpdUserId);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeVersionEN objvSenateGaugeVersion_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.id_SenateGaugeVersion, objvSenateGaugeVersion_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.senateGaugeVersionID, objvSenateGaugeVersion_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.senateGaugeVersionName, objvSenateGaugeVersion_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionMemo) == true)
{
string strComparisonOp_senateGaugeVersionMemo = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.senateGaugeVersionMemo, objvSenateGaugeVersion_Cond.senateGaugeVersionMemo, strComparisonOp_senateGaugeVersionMemo);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.senateGaugeVersionTtlScore, objvSenateGaugeVersion_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.SkillTypeID) == true)
{
string strComparisonOp_SkillTypeID = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.SkillTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.SkillTypeID, objvSenateGaugeVersion_Cond.SkillTypeID, strComparisonOp_SkillTypeID);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.SkillTypeName) == true)
{
string strComparisonOp_SkillTypeName = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.SkillTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.SkillTypeName, objvSenateGaugeVersion_Cond.SkillTypeName, strComparisonOp_SkillTypeName);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.id_SkillType, objvSenateGaugeVersion_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.VersionNo, objvSenateGaugeVersion_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.IsUse) == true)
{
if (objvSenateGaugeVersion_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeVersion.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeVersion.IsUse);
}
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UserTypeId, objvSenateGaugeVersion_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UserTypeName, objvSenateGaugeVersion_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.SenateGaugeNum) == true)
{
string strComparisonOp_SenateGaugeNum = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.SenateGaugeNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.SenateGaugeNum, objvSenateGaugeVersion_Cond.SenateGaugeNum, strComparisonOp_SenateGaugeNum);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.CalaTotalScore) == true)
{
string strComparisonOp_CalaTotalScore = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.CalaTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeVersion.CalaTotalScore, objvSenateGaugeVersion_Cond.CalaTotalScore, strComparisonOp_CalaTotalScore);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UpdDate, objvSenateGaugeVersion_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvSenateGaugeVersion_Cond.IsUpdated(convSenateGaugeVersion.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvSenateGaugeVersion_Cond.dicFldComparisonOp[convSenateGaugeVersion.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeVersion.UpdUserId, objvSenateGaugeVersion_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v评价量规版本(vSenateGaugeVersion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeVersionWApi
{
private static readonly string mstrApiControllerName = "vSenateGaugeVersionApi";

 public clsvSenateGaugeVersionWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_SenateGaugeVersion(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v评价量规版本]...","0");
List<clsvSenateGaugeVersionEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_SenateGaugeVersion";
objDDL.DataTextField="senateGaugeVersionName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_SenateGaugeVersion(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convSenateGaugeVersion.id_SenateGaugeVersion); 
List<clsvSenateGaugeVersionEN> arrObjLst = clsvSenateGaugeVersionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN()
{
id_SenateGaugeVersion = "0",
senateGaugeVersionName = "选[v评价量规版本]..."
};
arrObjLst.Insert(0, objvSenateGaugeVersionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convSenateGaugeVersion.id_SenateGaugeVersion;
objComboBox.DisplayMember = convSenateGaugeVersion.senateGaugeVersionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeVersionEN GetObjByid_SenateGaugeVersion(string strid_SenateGaugeVersion)
{
string strAction = "GetObjByid_SenateGaugeVersion";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeVersion"] = strid_SenateGaugeVersion
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsvSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeVersionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeVersionEN GetObjByid_SenateGaugeVersion_WA_Cache(string strid_SenateGaugeVersion)
{
string strAction = "GetObjByid_SenateGaugeVersion_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeVersion"] = strid_SenateGaugeVersion
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsvSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeVersionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvSenateGaugeVersionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsvSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeVersionEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeVersionEN GetObjByid_SenateGaugeVersion_Cache(string strid_SenateGaugeVersion)
{
if (string.IsNullOrEmpty(strid_SenateGaugeVersion) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName_S);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel =
from objvSenateGaugeVersionEN in arrvSenateGaugeVersionObjLst_Cache
where objvSenateGaugeVersionEN.id_SenateGaugeVersion == strid_SenateGaugeVersion
select objvSenateGaugeVersionEN;
if (arrvSenateGaugeVersionObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeVersionEN obj = clsvSenateGaugeVersionWApi.GetObjByid_SenateGaugeVersion(strid_SenateGaugeVersion);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSenateGaugeVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeVersionNameByid_SenateGaugeVersion_Cache(string strid_SenateGaugeVersion)
{
if (string.IsNullOrEmpty(strid_SenateGaugeVersion) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName_S);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel1 =
from objvSenateGaugeVersionEN in arrvSenateGaugeVersionObjLst_Cache
where objvSenateGaugeVersionEN.id_SenateGaugeVersion == strid_SenateGaugeVersion
select objvSenateGaugeVersionEN;
List <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel = new List<clsvSenateGaugeVersionEN>();
foreach (clsvSenateGaugeVersionEN obj in arrvSenateGaugeVersionObjLst_Sel1)
{
arrvSenateGaugeVersionObjLst_Sel.Add(obj);
}
if (arrvSenateGaugeVersionObjLst_Sel.Count > 0)
{
return arrvSenateGaugeVersionObjLst_Sel[0].senateGaugeVersionName;
}
string strErrMsgForGetObjById = string.Format("在vSenateGaugeVersion对象缓存列表中,找不到记录[id_SenateGaugeVersion = {0}](函数:{1})", strid_SenateGaugeVersion, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvSenateGaugeVersionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_SenateGaugeVersion_Cache(string strid_SenateGaugeVersion)
{
if (string.IsNullOrEmpty(strid_SenateGaugeVersion) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName_S);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel1 =
from objvSenateGaugeVersionEN in arrvSenateGaugeVersionObjLst_Cache
where objvSenateGaugeVersionEN.id_SenateGaugeVersion == strid_SenateGaugeVersion
select objvSenateGaugeVersionEN;
List <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel = new List<clsvSenateGaugeVersionEN>();
foreach (clsvSenateGaugeVersionEN obj in arrvSenateGaugeVersionObjLst_Sel1)
{
arrvSenateGaugeVersionObjLst_Sel.Add(obj);
}
if (arrvSenateGaugeVersionObjLst_Sel.Count > 0)
{
return arrvSenateGaugeVersionObjLst_Sel[0].senateGaugeVersionName;
}
string strErrMsgForGetObjById = string.Format("在vSenateGaugeVersion对象缓存列表中,找不到记录的相关名称[id_SenateGaugeVersion = {0}](函数:{1})", strid_SenateGaugeVersion, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvSenateGaugeVersionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLst(string strWhereCond)
{
 List<clsvSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLstById_SenateGaugeVersionLst(List<string> arrId_SenateGaugeVersion)
{
 List<clsvSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLstById_SenateGaugeVersionLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SenateGaugeVersion);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvSenateGaugeVersionEN> GetObjLstById_SenateGaugeVersionLst_Cache(List<string> arrId_SenateGaugeVersion)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName_S);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Sel =
from objvSenateGaugeVersionEN in arrvSenateGaugeVersionObjLst_Cache
where arrId_SenateGaugeVersion.Contains(objvSenateGaugeVersionEN.id_SenateGaugeVersion)
select objvSenateGaugeVersionEN;
return arrvSenateGaugeVersionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLstById_SenateGaugeVersionLst_WA_Cache(List<string> arrId_SenateGaugeVersion)
{
 List<clsvSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLstById_SenateGaugeVersionLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SenateGaugeVersion);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsvSenateGaugeVersionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static List<clsvSenateGaugeVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeVersionEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
public static bool IsExist(string strid_SenateGaugeVersion)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeVersion"] = strid_SenateGaugeVersion
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
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
 /// <param name = "objvSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeVersionEN objvSenateGaugeVersionENS, clsvSenateGaugeVersionEN objvSenateGaugeVersionENT)
{
try
{
objvSenateGaugeVersionENT.id_SenateGaugeVersion = objvSenateGaugeVersionENS.id_SenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeVersionENT.senateGaugeVersionID = objvSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeVersionENT.senateGaugeVersionName = objvSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeVersionENT.senateGaugeVersionMemo = objvSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeVersionENT.SkillTypeID = objvSenateGaugeVersionENS.SkillTypeID; //技能类型ID
objvSenateGaugeVersionENT.SkillTypeName = objvSenateGaugeVersionENS.SkillTypeName; //技能类型名称
objvSenateGaugeVersionENT.id_SkillType = objvSenateGaugeVersionENS.id_SkillType; //技能类型流水号
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
public static DataTable ToDataTable(List<clsvSenateGaugeVersionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSenateGaugeVersionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSenateGaugeVersionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSenateGaugeVersionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSenateGaugeVersionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSenateGaugeVersionEN.AttributeName)
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
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_SenateGaugeVersion");
//if (arrvSenateGaugeVersionObjLst_Cache == null)
//{
//arrvSenateGaugeVersionObjLst_Cache = await clsvSenateGaugeVersionWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName_S);
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
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeVersionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeVersionEN._CurrTabName_S);
List<clsvSenateGaugeVersionEN> arrvSenateGaugeVersionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeVersionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSenateGaugeVersionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSenateGaugeVersion.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.senateGaugeVersionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGaugeVersion.SkillTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.SkillTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeVersion.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSenateGaugeVersion.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.SenateGaugeNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeVersion.CalaTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGaugeVersion.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeVersion.UpdUserId, Type.GetType("System.String"));
foreach (clsvSenateGaugeVersionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSenateGaugeVersion.id_SenateGaugeVersion] = objInFor[convSenateGaugeVersion.id_SenateGaugeVersion];
objDR[convSenateGaugeVersion.senateGaugeVersionID] = objInFor[convSenateGaugeVersion.senateGaugeVersionID];
objDR[convSenateGaugeVersion.senateGaugeVersionName] = objInFor[convSenateGaugeVersion.senateGaugeVersionName];
objDR[convSenateGaugeVersion.senateGaugeVersionMemo] = objInFor[convSenateGaugeVersion.senateGaugeVersionMemo];
objDR[convSenateGaugeVersion.senateGaugeVersionTtlScore] = objInFor[convSenateGaugeVersion.senateGaugeVersionTtlScore];
objDR[convSenateGaugeVersion.SkillTypeID] = objInFor[convSenateGaugeVersion.SkillTypeID];
objDR[convSenateGaugeVersion.SkillTypeName] = objInFor[convSenateGaugeVersion.SkillTypeName];
objDR[convSenateGaugeVersion.id_SkillType] = objInFor[convSenateGaugeVersion.id_SkillType];
objDR[convSenateGaugeVersion.VersionNo] = objInFor[convSenateGaugeVersion.VersionNo];
objDR[convSenateGaugeVersion.IsUse] = objInFor[convSenateGaugeVersion.IsUse];
objDR[convSenateGaugeVersion.UserTypeId] = objInFor[convSenateGaugeVersion.UserTypeId];
objDR[convSenateGaugeVersion.UserTypeName] = objInFor[convSenateGaugeVersion.UserTypeName];
objDR[convSenateGaugeVersion.SenateGaugeNum] = objInFor[convSenateGaugeVersion.SenateGaugeNum];
objDR[convSenateGaugeVersion.CalaTotalScore] = objInFor[convSenateGaugeVersion.CalaTotalScore];
objDR[convSenateGaugeVersion.UpdDate] = objInFor[convSenateGaugeVersion.UpdDate];
objDR[convSenateGaugeVersion.UpdUserId] = objInFor[convSenateGaugeVersion.UpdUserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}