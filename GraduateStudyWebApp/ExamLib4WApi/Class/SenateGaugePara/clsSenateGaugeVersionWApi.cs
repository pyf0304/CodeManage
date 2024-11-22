
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeVersionWApi
 表名:SenateGaugeVersion(01120297)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:41
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
public static class clsSenateGaugeVersionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN Setid_SenateGaugeVersion(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conSenateGaugeVersion.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conSenateGaugeVersion.id_SenateGaugeVersion);
objSenateGaugeVersionEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.id_SenateGaugeVersion) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionID(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, conSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, conSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, conSenateGaugeVersion.senateGaugeVersionID);
objSenateGaugeVersionEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionID) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionID, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionID] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionName(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionName, conSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, conSenateGaugeVersion.senateGaugeVersionName);
objSenateGaugeVersionEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionName) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionName, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionName] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionTtlScore(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, conSenateGaugeVersion.senateGaugeVersionTtlScore);
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionTtlScore) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetIsUse(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUse, conSenateGaugeVersion.IsUse);
objSenateGaugeVersionEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.IsUse) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.IsUse, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.IsUse] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetVersionNo(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, int intVersionNo, string strComparisonOp="")
	{
objSenateGaugeVersionEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.VersionNo) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.VersionNo, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.VersionNo] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN Setid_SkillType(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strid_SkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SkillType, conSenateGaugeVersion.id_SkillType);
clsCheckSql.CheckFieldLen(strid_SkillType, 4, conSenateGaugeVersion.id_SkillType);
clsCheckSql.CheckFieldForeignKey(strid_SkillType, 4, conSenateGaugeVersion.id_SkillType);
objSenateGaugeVersionEN.id_SkillType = strid_SkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.id_SkillType) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.id_SkillType, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.id_SkillType] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetUserTypeId(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserTypeId, conSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conSenateGaugeVersion.UserTypeId);
objSenateGaugeVersionEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.UserTypeId) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.UserTypeId, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.UserTypeId] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetUpdDate(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGaugeVersion.UpdDate);
objSenateGaugeVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.UpdDate) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetUpdUserId(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGaugeVersion.UpdUserId);
objSenateGaugeVersionEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.UpdUserId) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionMemo(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, conSenateGaugeVersion.senateGaugeVersionMemo);
objSenateGaugeVersionEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionMemo) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeVersionEN objSenateGaugeVersion_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.id_SenateGaugeVersion, objSenateGaugeVersion_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.senateGaugeVersionID, objSenateGaugeVersion_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.senateGaugeVersionName, objSenateGaugeVersion_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeVersion.senateGaugeVersionTtlScore, objSenateGaugeVersion_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.IsUse) == true)
{
if (objSenateGaugeVersion_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSenateGaugeVersion.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSenateGaugeVersion.IsUse);
}
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.VersionNo) == true)
{
string strComparisonOp_VersionNo = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeVersion.VersionNo, objSenateGaugeVersion_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.id_SkillType) == true)
{
string strComparisonOp_id_SkillType = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.id_SkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.id_SkillType, objSenateGaugeVersion_Cond.id_SkillType, strComparisonOp_id_SkillType);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.UserTypeId, objSenateGaugeVersion_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.UpdDate) == true)
{
string strComparisonOp_UpdDate = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.UpdDate, objSenateGaugeVersion_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.UpdUserId, objSenateGaugeVersion_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objSenateGaugeVersion_Cond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionMemo) == true)
{
string strComparisonOp_senateGaugeVersionMemo = objSenateGaugeVersion_Cond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.senateGaugeVersionMemo, objSenateGaugeVersion_Cond.senateGaugeVersionMemo, strComparisonOp_senateGaugeVersionMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.id_SenateGaugeVersion) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSenateGaugeVersionEN.sf_UpdFldSetStr = objSenateGaugeVersionEN.getsf_UpdFldSetStr();
clsSenateGaugeVersionWApi.CheckPropertyNew(objSenateGaugeVersionEN); 
bool bolResult = clsSenateGaugeVersionWApi.UpdateRecord(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.id_SenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeVersionWApi.IsExist(objSenateGaugeVersionEN.id_SenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeVersionEN.id_SenateGaugeVersion, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsSenateGaugeVersionWApi.CheckPropertyNew(objSenateGaugeVersionEN); 
bool bolResult = clsSenateGaugeVersionWApi.AddNewRecord(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
try
{
clsSenateGaugeVersionWApi.CheckPropertyNew(objSenateGaugeVersionEN); 
string strid_SenateGaugeVersion = clsSenateGaugeVersionWApi.AddNewRecordWithMaxId(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionWApi.ReFreshCache();
return strid_SenateGaugeVersion;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strWhereCond)
{
try
{
clsSenateGaugeVersionWApi.CheckPropertyNew(objSenateGaugeVersionEN); 
bool bolResult = clsSenateGaugeVersionWApi.UpdateWithCondition(objSenateGaugeVersionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionWApi.ReFreshCache();
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
 /// 评价量规版本(SenateGaugeVersion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeVersionWApi
{
private static readonly string mstrApiControllerName = "SenateGaugeVersionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsSenateGaugeVersionWApi()
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价量规版本]...","0");
List<clsSenateGaugeVersionEN> arrObjLst = GetObjLst("1=1");
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
string strCondition = string.Format("1 =1 Order By {0}", conSenateGaugeVersion.id_SenateGaugeVersion); 
List<clsSenateGaugeVersionEN> arrObjLst = clsSenateGaugeVersionWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN()
{
id_SenateGaugeVersion = "0",
senateGaugeVersionName = "选[评价量规版本]..."
};
arrObjLst.Insert(0, objSenateGaugeVersionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSenateGaugeVersion.id_SenateGaugeVersion;
objComboBox.DisplayMember = conSenateGaugeVersion.senateGaugeVersionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
if (!Object.Equals(null, objSenateGaugeVersionEN.id_SenateGaugeVersion) && GetStrLen(objSenateGaugeVersionEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeVersionEN.senateGaugeVersionID) && GetStrLen(objSenateGaugeVersionEN.senateGaugeVersionID) > 4)
{
 throw new Exception("字段[评价量表版本ID]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeVersionEN.senateGaugeVersionName) && GetStrLen(objSenateGaugeVersionEN.senateGaugeVersionName) > 200)
{
 throw new Exception("字段[评价量表版本名称]的长度不能超过200!");
}
if (!Object.Equals(null, objSenateGaugeVersionEN.id_SkillType) && GetStrLen(objSenateGaugeVersionEN.id_SkillType) > 4)
{
 throw new Exception("字段[技能类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeVersionEN.UserTypeId) && GetStrLen(objSenateGaugeVersionEN.UserTypeId) > 2)
{
 throw new Exception("字段[用户类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSenateGaugeVersionEN.UpdDate) && GetStrLen(objSenateGaugeVersionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeVersionEN.UpdUserId) && GetStrLen(objSenateGaugeVersionEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeVersionEN.senateGaugeVersionMemo) && GetStrLen(objSenateGaugeVersionEN.senateGaugeVersionMemo) > 1000)
{
 throw new Exception("字段[评价量表版本说明]的长度不能超过1000!");
}
 objSenateGaugeVersionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_SenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeVersionEN GetObjByid_SenateGaugeVersion(string strid_SenateGaugeVersion)
{
string strAction = "GetObjByid_SenateGaugeVersion";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeVersionEN objSenateGaugeVersionEN = null;
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
objSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeVersionEN;
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
public static clsSenateGaugeVersionEN GetObjByid_SenateGaugeVersion_WA_Cache(string strid_SenateGaugeVersion)
{
string strAction = "GetObjByid_SenateGaugeVersion_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeVersionEN objSenateGaugeVersionEN = null;
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
objSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeVersionEN;
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
public static clsSenateGaugeVersionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeVersionEN objSenateGaugeVersionEN = null;
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
objSenateGaugeVersionEN = JsonConvert.DeserializeObject<clsSenateGaugeVersionEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeVersionEN;
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
public static clsSenateGaugeVersionEN GetObjByid_SenateGaugeVersion_Cache(string strid_SenateGaugeVersion)
{
if (string.IsNullOrEmpty(strid_SenateGaugeVersion) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName_S);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel =
from objSenateGaugeVersionEN in arrSenateGaugeVersionObjLst_Cache
where objSenateGaugeVersionEN.id_SenateGaugeVersion == strid_SenateGaugeVersion
select objSenateGaugeVersionEN;
if (arrSenateGaugeVersionObjLst_Sel.Count() == 0)
{
   clsSenateGaugeVersionEN obj = clsSenateGaugeVersionWApi.GetObjByid_SenateGaugeVersion(strid_SenateGaugeVersion);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSenateGaugeVersionObjLst_Sel.First();
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
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName_S);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel1 =
from objSenateGaugeVersionEN in arrSenateGaugeVersionObjLst_Cache
where objSenateGaugeVersionEN.id_SenateGaugeVersion == strid_SenateGaugeVersion
select objSenateGaugeVersionEN;
List <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel = new List<clsSenateGaugeVersionEN>();
foreach (clsSenateGaugeVersionEN obj in arrSenateGaugeVersionObjLst_Sel1)
{
arrSenateGaugeVersionObjLst_Sel.Add(obj);
}
if (arrSenateGaugeVersionObjLst_Sel.Count > 0)
{
return arrSenateGaugeVersionObjLst_Sel[0].senateGaugeVersionName;
}
string strErrMsgForGetObjById = string.Format("在SenateGaugeVersion对象缓存列表中,找不到记录[id_SenateGaugeVersion = {0}](函数:{1})", strid_SenateGaugeVersion, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeVersionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
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
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName_S);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel1 =
from objSenateGaugeVersionEN in arrSenateGaugeVersionObjLst_Cache
where objSenateGaugeVersionEN.id_SenateGaugeVersion == strid_SenateGaugeVersion
select objSenateGaugeVersionEN;
List <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel = new List<clsSenateGaugeVersionEN>();
foreach (clsSenateGaugeVersionEN obj in arrSenateGaugeVersionObjLst_Sel1)
{
arrSenateGaugeVersionObjLst_Sel.Add(obj);
}
if (arrSenateGaugeVersionObjLst_Sel.Count > 0)
{
return arrSenateGaugeVersionObjLst_Sel[0].senateGaugeVersionName;
}
string strErrMsgForGetObjById = string.Format("在SenateGaugeVersion对象缓存列表中,找不到记录的相关名称[id_SenateGaugeVersion = {0}](函数:{1})", strid_SenateGaugeVersion, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeVersionBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLst(string strWhereCond)
{
 List<clsSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeVersionEN> GetObjLstById_SenateGaugeVersionLst(List<string> arrId_SenateGaugeVersion)
{
 List<clsSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsSenateGaugeVersionEN> GetObjLstById_SenateGaugeVersionLst_Cache(List<string> arrId_SenateGaugeVersion)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName_S);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel =
from objSenateGaugeVersionEN in arrSenateGaugeVersionObjLst_Cache
where arrId_SenateGaugeVersion.Contains(objSenateGaugeVersionEN.id_SenateGaugeVersion)
select objSenateGaugeVersionEN;
return arrSenateGaugeVersionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLstById_SenateGaugeVersionLst_WA_Cache(List<string> arrId_SenateGaugeVersion)
{
 List<clsSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeVersionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeVersionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeVersionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strid_SenateGaugeVersion)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsSenateGaugeVersionEN objSenateGaugeVersionEN = clsSenateGaugeVersionWApi.GetObjByid_SenateGaugeVersion(strid_SenateGaugeVersion);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_SenateGaugeVersion.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeVersionWApi.ReFreshCache();
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
public static int DelSenateGaugeVersions(List<string> arrid_SenateGaugeVersion)
{
string strAction = "DelSenateGaugeVersions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_SenateGaugeVersion);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeVersionWApi.ReFreshCache();
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
public static int DelSenateGaugeVersionsByCond(string strWhereCond)
{
string strAction = "DelSenateGaugeVersionsByCond";
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
public static bool AddNewRecord(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeVersionEN>(objSenateGaugeVersionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeVersionEN>(objSenateGaugeVersionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionWApi.ReFreshCache();
var strid_SenateGaugeVersion = (string)jobjReturn["ReturnStr"];
return strid_SenateGaugeVersion;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
if (string.IsNullOrEmpty(objSenateGaugeVersionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeVersionEN.id_SenateGaugeVersion, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeVersionEN>(objSenateGaugeVersionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// <param name = "objSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSenateGaugeVersionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeVersionEN.id_SenateGaugeVersion, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeVersionEN.id_SenateGaugeVersion, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeVersionEN>(objSenateGaugeVersionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <param name = "objSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeVersionEN objSenateGaugeVersionENS, clsSenateGaugeVersionEN objSenateGaugeVersionENT)
{
try
{
objSenateGaugeVersionENT.id_SenateGaugeVersion = objSenateGaugeVersionENS.id_SenateGaugeVersion; //评价量表版本流水号
objSenateGaugeVersionENT.senateGaugeVersionID = objSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objSenateGaugeVersionENT.senateGaugeVersionName = objSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objSenateGaugeVersionENT.senateGaugeVersionTtlScore = objSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objSenateGaugeVersionENT.IsUse = objSenateGaugeVersionENS.IsUse; //是否使用
objSenateGaugeVersionENT.VersionNo = objSenateGaugeVersionENS.VersionNo; //版本号
objSenateGaugeVersionENT.id_SkillType = objSenateGaugeVersionENS.id_SkillType; //技能类型流水号
objSenateGaugeVersionENT.UserTypeId = objSenateGaugeVersionENS.UserTypeId; //用户类型Id
objSenateGaugeVersionENT.UpdDate = objSenateGaugeVersionENS.UpdDate; //修改日期
objSenateGaugeVersionENT.UpdUserId = objSenateGaugeVersionENS.UpdUserId; //修改用户Id
objSenateGaugeVersionENT.senateGaugeVersionMemo = objSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
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
public static DataTable ToDataTable(List<clsSenateGaugeVersionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSenateGaugeVersionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSenateGaugeVersionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSenateGaugeVersionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSenateGaugeVersionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSenateGaugeVersionEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_SenateGaugeVersion");
//if (arrSenateGaugeVersionObjLst_Cache == null)
//{
//arrSenateGaugeVersionObjLst_Cache = await clsSenateGaugeVersionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName_S);
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
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsSenateGaugeVersionWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsSenateGaugeVersionWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName_S);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeVersionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSenateGaugeVersionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSenateGaugeVersion.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeVersion.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeVersion.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeVersion.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(conSenateGaugeVersion.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conSenateGaugeVersion.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(conSenateGaugeVersion.id_SkillType, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeVersion.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeVersion.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeVersion.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeVersion.senateGaugeVersionMemo, Type.GetType("System.String"));
foreach (clsSenateGaugeVersionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSenateGaugeVersion.id_SenateGaugeVersion] = objInFor[conSenateGaugeVersion.id_SenateGaugeVersion];
objDR[conSenateGaugeVersion.senateGaugeVersionID] = objInFor[conSenateGaugeVersion.senateGaugeVersionID];
objDR[conSenateGaugeVersion.senateGaugeVersionName] = objInFor[conSenateGaugeVersion.senateGaugeVersionName];
objDR[conSenateGaugeVersion.senateGaugeVersionTtlScore] = objInFor[conSenateGaugeVersion.senateGaugeVersionTtlScore];
objDR[conSenateGaugeVersion.IsUse] = objInFor[conSenateGaugeVersion.IsUse];
objDR[conSenateGaugeVersion.VersionNo] = objInFor[conSenateGaugeVersion.VersionNo];
objDR[conSenateGaugeVersion.id_SkillType] = objInFor[conSenateGaugeVersion.id_SkillType];
objDR[conSenateGaugeVersion.UserTypeId] = objInFor[conSenateGaugeVersion.UserTypeId];
objDR[conSenateGaugeVersion.UpdDate] = objInFor[conSenateGaugeVersion.UpdDate];
objDR[conSenateGaugeVersion.UpdUserId] = objInFor[conSenateGaugeVersion.UpdUserId];
objDR[conSenateGaugeVersion.senateGaugeVersionMemo] = objInFor[conSenateGaugeVersion.senateGaugeVersionMemo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 评价量规版本(SenateGaugeVersion)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4SenateGaugeVersion : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsSenateGaugeVersionWApi.ReFreshThisCache();
}
}

}