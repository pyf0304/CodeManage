
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvModuleSenateGaugeVersionRelaWApi
 表名:vModuleSenateGaugeVersionRela(01120461)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:46
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
public static class clsvModuleSenateGaugeVersionRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetFuncModuleId(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convModuleSenateGaugeVersionRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convModuleSenateGaugeVersionRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convModuleSenateGaugeVersionRela.FuncModuleId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetFuncModuleName(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleName, convModuleSenateGaugeVersionRela.FuncModuleName);
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convModuleSenateGaugeVersionRela.FuncModuleName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetOrderNum(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, int intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN Setid_SenateGaugeVersion(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convModuleSenateGaugeVersionRela.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convModuleSenateGaugeVersionRela.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convModuleSenateGaugeVersionRela.id_SenateGaugeVersion);
objvModuleSenateGaugeVersionRelaEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.ContainsKey(convModuleSenateGaugeVersionRela.id_SenateGaugeVersion) == false)
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp.Add(convModuleSenateGaugeVersionRela.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvModuleSenateGaugeVersionRelaEN.dicFldComparisonOp[convModuleSenateGaugeVersionRela.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvModuleSenateGaugeVersionRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetsenateGaugeVersionID(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convModuleSenateGaugeVersionRela.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convModuleSenateGaugeVersionRela.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convModuleSenateGaugeVersionRela.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetsenateGaugeVersionName(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convModuleSenateGaugeVersionRela.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvModuleSenateGaugeVersionRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvModuleSenateGaugeVersionRelaEN SetUserTypeId(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convModuleSenateGaugeVersionRela.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convModuleSenateGaugeVersionRela.UserTypeId);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.mId) == true)
{
string strComparisonOp_mId = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleSenateGaugeVersionRela.mId, objvModuleSenateGaugeVersionRela_Cond.mId, strComparisonOp_mId);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.FuncModuleId, objvModuleSenateGaugeVersionRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.FuncModuleName, objvModuleSenateGaugeVersionRela_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleSenateGaugeVersionRela.OrderNum, objvModuleSenateGaugeVersionRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.id_SenateGaugeVersion, objvModuleSenateGaugeVersionRela_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.senateGaugeVersionID, objvModuleSenateGaugeVersionRela_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.senateGaugeVersionName, objvModuleSenateGaugeVersionRela_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore, objvModuleSenateGaugeVersionRela_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.IsUse) == true)
{
if (objvModuleSenateGaugeVersionRela_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convModuleSenateGaugeVersionRela.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convModuleSenateGaugeVersionRela.IsUse);
}
}
if (objvModuleSenateGaugeVersionRela_Cond.IsUpdated(convModuleSenateGaugeVersionRela.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvModuleSenateGaugeVersionRela_Cond.dicFldComparisonOp[convModuleSenateGaugeVersionRela.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convModuleSenateGaugeVersionRela.UserTypeId, objvModuleSenateGaugeVersionRela_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v模块默认评价版本设置(vModuleSenateGaugeVersionRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvModuleSenateGaugeVersionRelaWApi
{
private static readonly string mstrApiControllerName = "vModuleSenateGaugeVersionRelaApi";

 public clsvModuleSenateGaugeVersionRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvModuleSenateGaugeVersionRelaEN = JsonConvert.DeserializeObject<clsvModuleSenateGaugeVersionRelaEN>((string)jobjReturn["ReturnObj"]);
return objvModuleSenateGaugeVersionRelaEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvModuleSenateGaugeVersionRelaEN = JsonConvert.DeserializeObject<clsvModuleSenateGaugeVersionRelaEN>((string)jobjReturn["ReturnObj"]);
return objvModuleSenateGaugeVersionRelaEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvModuleSenateGaugeVersionRelaEN objvModuleSenateGaugeVersionRelaEN = null;
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
objvModuleSenateGaugeVersionRelaEN = JsonConvert.DeserializeObject<clsvModuleSenateGaugeVersionRelaEN>((string)jobjReturn["ReturnObj"]);
return objvModuleSenateGaugeVersionRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvModuleSenateGaugeVersionRelaEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName_S);
List<clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLst_Sel =
from objvModuleSenateGaugeVersionRelaEN in arrvModuleSenateGaugeVersionRelaObjLst_Cache
where objvModuleSenateGaugeVersionRelaEN.mId == lngmId
select objvModuleSenateGaugeVersionRelaEN;
if (arrvModuleSenateGaugeVersionRelaObjLst_Sel.Count() == 0)
{
   clsvModuleSenateGaugeVersionRelaEN obj = clsvModuleSenateGaugeVersionRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvModuleSenateGaugeVersionRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleSenateGaugeVersionRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleSenateGaugeVersionRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName_S);
List<clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLst_Sel =
from objvModuleSenateGaugeVersionRelaEN in arrvModuleSenateGaugeVersionRelaObjLst_Cache
where arrMId.Contains(objvModuleSenateGaugeVersionRelaEN.mId)
select objvModuleSenateGaugeVersionRelaEN;
return arrvModuleSenateGaugeVersionRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleSenateGaugeVersionRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleSenateGaugeVersionRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleSenateGaugeVersionRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleSenateGaugeVersionRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvModuleSenateGaugeVersionRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
objvModuleSenateGaugeVersionRelaENT.id_SenateGaugeVersion = objvModuleSenateGaugeVersionRelaENS.id_SenateGaugeVersion; //评价量表版本流水号
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionID = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionID; //评价量表版本ID
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionName = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionName; //评价量表版本名称
objvModuleSenateGaugeVersionRelaENT.senateGaugeVersionTtlScore = objvModuleSenateGaugeVersionRelaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvModuleSenateGaugeVersionRelaENT.IsUse = objvModuleSenateGaugeVersionRelaENS.IsUse; //是否使用
objvModuleSenateGaugeVersionRelaENT.UserTypeId = objvModuleSenateGaugeVersionRelaENS.UserTypeId; //用户类型Id
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
public static DataTable ToDataTable(List<clsvModuleSenateGaugeVersionRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvModuleSenateGaugeVersionRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvModuleSenateGaugeVersionRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvModuleSenateGaugeVersionRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvModuleSenateGaugeVersionRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvModuleSenateGaugeVersionRelaEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsModuleSenateGaugeVersionRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsModuleSenateGaugeVersionRelaWApi没有刷新缓存机制(clsModuleSenateGaugeVersionRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvModuleSenateGaugeVersionRelaObjLst_Cache == null)
//{
//arrvModuleSenateGaugeVersionRelaObjLst_Cache = await clsvModuleSenateGaugeVersionRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName_S);
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
public static List<clsvModuleSenateGaugeVersionRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvModuleSenateGaugeVersionRelaEN._CurrTabName_S);
List<clsvModuleSenateGaugeVersionRelaEN> arrvModuleSenateGaugeVersionRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvModuleSenateGaugeVersionRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvModuleSenateGaugeVersionRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convModuleSenateGaugeVersionRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convModuleSenateGaugeVersionRela.UserTypeId, Type.GetType("System.String"));
foreach (clsvModuleSenateGaugeVersionRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convModuleSenateGaugeVersionRela.mId] = objInFor[convModuleSenateGaugeVersionRela.mId];
objDR[convModuleSenateGaugeVersionRela.FuncModuleId] = objInFor[convModuleSenateGaugeVersionRela.FuncModuleId];
objDR[convModuleSenateGaugeVersionRela.FuncModuleName] = objInFor[convModuleSenateGaugeVersionRela.FuncModuleName];
objDR[convModuleSenateGaugeVersionRela.OrderNum] = objInFor[convModuleSenateGaugeVersionRela.OrderNum];
objDR[convModuleSenateGaugeVersionRela.id_SenateGaugeVersion] = objInFor[convModuleSenateGaugeVersionRela.id_SenateGaugeVersion];
objDR[convModuleSenateGaugeVersionRela.senateGaugeVersionID] = objInFor[convModuleSenateGaugeVersionRela.senateGaugeVersionID];
objDR[convModuleSenateGaugeVersionRela.senateGaugeVersionName] = objInFor[convModuleSenateGaugeVersionRela.senateGaugeVersionName];
objDR[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore] = objInFor[convModuleSenateGaugeVersionRela.senateGaugeVersionTtlScore];
objDR[convModuleSenateGaugeVersionRela.IsUse] = objInFor[convModuleSenateGaugeVersionRela.IsUse];
objDR[convModuleSenateGaugeVersionRela.UserTypeId] = objInFor[convModuleSenateGaugeVersionRela.UserTypeId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}