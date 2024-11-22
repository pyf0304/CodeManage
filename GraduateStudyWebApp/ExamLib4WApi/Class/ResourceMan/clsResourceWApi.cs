
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceWApi
 表名:Resource(01120320)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:07
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理
 模块英文名:ResourceMan
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
public static class clsResourceWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN Setid_Resource(this clsResourceEN objResourceEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Resource, 8, conResource.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, conResource.id_Resource);
objResourceEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.id_Resource) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.id_Resource, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.id_Resource] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetResourceID(this clsResourceEN objResourceEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceID, conResource.ResourceID);
clsCheckSql.CheckFieldLen(strResourceID, 8, conResource.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, conResource.ResourceID);
objResourceEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.ResourceID) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.ResourceID, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.ResourceID] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetResourceName(this clsResourceEN objResourceEN, string strResourceName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceName, conResource.ResourceName);
clsCheckSql.CheckFieldLen(strResourceName, 100, conResource.ResourceName);
objResourceEN.ResourceName = strResourceName; //资源名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.ResourceName) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.ResourceName, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.ResourceName] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetSaveMode(this clsResourceEN objResourceEN, bool bolSaveMode, string strComparisonOp="")
	{
objResourceEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.SaveMode) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.SaveMode, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.SaveMode] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN Setid_FtpResource(this clsResourceEN objResourceEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, conResource.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, conResource.id_FtpResource);
objResourceEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.id_FtpResource) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.id_FtpResource, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.id_FtpResource] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN Setid_File(this clsResourceEN objResourceEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, conResource.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, conResource.id_File);
objResourceEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.id_File) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.id_File, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.id_File] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN Setid_ResourceType(this clsResourceEN objResourceEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ResourceType, conResource.id_ResourceType);
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, conResource.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, conResource.id_ResourceType);
objResourceEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.id_ResourceType) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.id_ResourceType, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.id_ResourceType] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetUpdDate(this clsResourceEN objResourceEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conResource.UpdDate);
objResourceEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.UpdDate) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.UpdDate, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.UpdDate] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetUpdTime(this clsResourceEN objResourceEN, string strUpdTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdTime, 6, conResource.UpdTime);
objResourceEN.UpdTime = strUpdTime; //UpdTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.UpdTime) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.UpdTime, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.UpdTime] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetMemo(this clsResourceEN objResourceEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conResource.Memo);
objResourceEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.Memo) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.Memo, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.Memo] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetFuncModuleId(this clsResourceEN objResourceEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conResource.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conResource.FuncModuleId);
objResourceEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.FuncModuleId) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.FuncModuleId, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.FuncModuleId] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetCheckDate(this clsResourceEN objResourceEN, string strCheckDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckDate, 20, conResource.CheckDate);
objResourceEN.CheckDate = strCheckDate; //检查日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.CheckDate) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.CheckDate, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.CheckDate] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetCheckUser(this clsResourceEN objResourceEN, string strCheckUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckUser, 18, conResource.CheckUser);
objResourceEN.CheckUser = strCheckUser; //检查用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.CheckUser) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.CheckUser, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.CheckUser] = strComparisonOp;
}
}
return objResourceEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsResourceEN SetCheckResult(this clsResourceEN objResourceEN, string strCheckResult, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckResult, 1000, conResource.CheckResult);
objResourceEN.CheckResult = strCheckResult; //检查结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceEN.dicFldComparisonOp.ContainsKey(conResource.CheckResult) == false)
{
objResourceEN.dicFldComparisonOp.Add(conResource.CheckResult, strComparisonOp);
}
else
{
objResourceEN.dicFldComparisonOp[conResource.CheckResult] = strComparisonOp;
}
}
return objResourceEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsResourceEN objResource_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objResource_Cond.IsUpdated(conResource.id_Resource) == true)
{
string strComparisonOp_id_Resource = objResource_Cond.dicFldComparisonOp[conResource.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.id_Resource, objResource_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objResource_Cond.IsUpdated(conResource.ResourceID) == true)
{
string strComparisonOp_ResourceID = objResource_Cond.dicFldComparisonOp[conResource.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.ResourceID, objResource_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objResource_Cond.IsUpdated(conResource.ResourceName) == true)
{
string strComparisonOp_ResourceName = objResource_Cond.dicFldComparisonOp[conResource.ResourceName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.ResourceName, objResource_Cond.ResourceName, strComparisonOp_ResourceName);
}
if (objResource_Cond.IsUpdated(conResource.SaveMode) == true)
{
if (objResource_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conResource.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conResource.SaveMode);
}
}
if (objResource_Cond.IsUpdated(conResource.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objResource_Cond.dicFldComparisonOp[conResource.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.id_FtpResource, objResource_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objResource_Cond.IsUpdated(conResource.id_File) == true)
{
string strComparisonOp_id_File = objResource_Cond.dicFldComparisonOp[conResource.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.id_File, objResource_Cond.id_File, strComparisonOp_id_File);
}
if (objResource_Cond.IsUpdated(conResource.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objResource_Cond.dicFldComparisonOp[conResource.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.id_ResourceType, objResource_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objResource_Cond.IsUpdated(conResource.UpdDate) == true)
{
string strComparisonOp_UpdDate = objResource_Cond.dicFldComparisonOp[conResource.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.UpdDate, objResource_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objResource_Cond.IsUpdated(conResource.UpdTime) == true)
{
string strComparisonOp_UpdTime = objResource_Cond.dicFldComparisonOp[conResource.UpdTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.UpdTime, objResource_Cond.UpdTime, strComparisonOp_UpdTime);
}
if (objResource_Cond.IsUpdated(conResource.Memo) == true)
{
string strComparisonOp_Memo = objResource_Cond.dicFldComparisonOp[conResource.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.Memo, objResource_Cond.Memo, strComparisonOp_Memo);
}
if (objResource_Cond.IsUpdated(conResource.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objResource_Cond.dicFldComparisonOp[conResource.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.FuncModuleId, objResource_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objResource_Cond.IsUpdated(conResource.CheckDate) == true)
{
string strComparisonOp_CheckDate = objResource_Cond.dicFldComparisonOp[conResource.CheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.CheckDate, objResource_Cond.CheckDate, strComparisonOp_CheckDate);
}
if (objResource_Cond.IsUpdated(conResource.CheckUser) == true)
{
string strComparisonOp_CheckUser = objResource_Cond.dicFldComparisonOp[conResource.CheckUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.CheckUser, objResource_Cond.CheckUser, strComparisonOp_CheckUser);
}
if (objResource_Cond.IsUpdated(conResource.CheckResult) == true)
{
string strComparisonOp_CheckResult = objResource_Cond.dicFldComparisonOp[conResource.CheckResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResource.CheckResult, objResource_Cond.CheckResult, strComparisonOp_CheckResult);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResourceEN objResourceEN)
{
 if (string.IsNullOrEmpty(objResourceEN.id_Resource) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objResourceEN.sf_UpdFldSetStr = objResourceEN.getsf_UpdFldSetStr();
clsResourceWApi.CheckPropertyNew(objResourceEN); 
bool bolResult = clsResourceWApi.UpdateRecord(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--Resource(资源), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objResourceEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_ResourceID(this clsResourceEN objResourceEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objResourceEN == null) return "";
if (objResourceEN.id_Resource == null || objResourceEN.id_Resource == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ResourceID = '{0}'", objResourceEN.ResourceID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_Resource !=  '{0}'", objResourceEN.id_Resource);
 sbCondition.AppendFormat(" and ResourceID = '{0}'", objResourceEN.ResourceID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsResourceEN objResourceEN)
{
try
{
 if (string.IsNullOrEmpty(objResourceEN.id_Resource) == true || clsResourceWApi.IsExist(objResourceEN.id_Resource) == true)
 {
     objResourceEN.id_Resource = clsResourceWApi.GetMaxStrId();
 }
clsResourceWApi.CheckPropertyNew(objResourceEN); 
bool bolResult = clsResourceWApi.AddNewRecord(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceWApi.ReFreshCache();
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsResourceEN objResourceEN)
{
try
{
clsResourceWApi.CheckPropertyNew(objResourceEN); 
string strid_Resource = clsResourceWApi.AddNewRecordWithMaxId(objResourceEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceWApi.ReFreshCache();
return strid_Resource;
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
 /// <param name = "objResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResourceEN objResourceEN, string strWhereCond)
{
try
{
clsResourceWApi.CheckPropertyNew(objResourceEN); 
bool bolResult = clsResourceWApi.UpdateWithCondition(objResourceEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceWApi.ReFreshCache();
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
 /// 资源(Resource)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsResourceWApi
{
private static readonly string mstrApiControllerName = "ResourceApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsResourceWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_Resource(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[资源]...","0");
List<clsResourceEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_Resource";
objDDL.DataTextField="ResourceName";
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
public static void BindCbo_id_Resource(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conResource.id_Resource); 
List<clsResourceEN> arrObjLst = clsResourceWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsResourceEN objResourceEN = new clsResourceEN()
{
id_Resource = "0",
ResourceName = "选[资源]..."
};
arrObjLst.Insert(0, objResourceEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conResource.id_Resource;
objComboBox.DisplayMember = conResource.ResourceName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsResourceEN objResourceEN)
{
if (!Object.Equals(null, objResourceEN.id_Resource) && GetStrLen(objResourceEN.id_Resource) > 8)
{
 throw new Exception("字段[资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objResourceEN.ResourceID) && GetStrLen(objResourceEN.ResourceID) > 8)
{
 throw new Exception("字段[资源ID]的长度不能超过8!");
}
if (!Object.Equals(null, objResourceEN.ResourceName) && GetStrLen(objResourceEN.ResourceName) > 100)
{
 throw new Exception("字段[资源名称]的长度不能超过100!");
}
if (!Object.Equals(null, objResourceEN.id_FtpResource) && GetStrLen(objResourceEN.id_FtpResource) > 8)
{
 throw new Exception("字段[FTP资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objResourceEN.id_File) && GetStrLen(objResourceEN.id_File) > 8)
{
 throw new Exception("字段[文件流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objResourceEN.id_ResourceType) && GetStrLen(objResourceEN.id_ResourceType) > 4)
{
 throw new Exception("字段[资源类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objResourceEN.UpdDate) && GetStrLen(objResourceEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objResourceEN.UpdTime) && GetStrLen(objResourceEN.UpdTime) > 6)
{
 throw new Exception("字段[UpdTime]的长度不能超过6!");
}
if (!Object.Equals(null, objResourceEN.Memo) && GetStrLen(objResourceEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objResourceEN.FuncModuleId) && GetStrLen(objResourceEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objResourceEN.CheckDate) && GetStrLen(objResourceEN.CheckDate) > 20)
{
 throw new Exception("字段[检查日期]的长度不能超过20!");
}
if (!Object.Equals(null, objResourceEN.CheckUser) && GetStrLen(objResourceEN.CheckUser) > 18)
{
 throw new Exception("字段[检查用户Id]的长度不能超过18!");
}
if (!Object.Equals(null, objResourceEN.CheckResult) && GetStrLen(objResourceEN.CheckResult) > 1000)
{
 throw new Exception("字段[检查结果]的长度不能超过1000!");
}
 objResourceEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_Resource">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceEN GetObjByid_Resource(string strid_Resource)
{
string strAction = "GetObjByid_Resource";
string strErrMsg = string.Empty;
string strResult = "";
clsResourceEN objResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Resource"] = strid_Resource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objResourceEN = JsonConvert.DeserializeObject<clsResourceEN>((string)jobjReturn["ReturnObj"]);
return objResourceEN;
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
 /// <param name = "strid_Resource">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceEN GetObjByid_Resource_WA_Cache(string strid_Resource)
{
string strAction = "GetObjByid_Resource_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsResourceEN objResourceEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Resource"] = strid_Resource
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objResourceEN = JsonConvert.DeserializeObject<clsResourceEN>((string)jobjReturn["ReturnObj"]);
return objResourceEN;
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
public static clsResourceEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsResourceEN objResourceEN = null;
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
objResourceEN = JsonConvert.DeserializeObject<clsResourceEN>((string)jobjReturn["ReturnObj"]);
return objResourceEN;
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
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResourceEN GetObjByid_Resource_Cache(string strid_Resource)
{
if (string.IsNullOrEmpty(strid_Resource) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceEN._CurrTabName_S);
List<clsResourceEN> arrResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceEN> arrResourceObjLst_Sel =
from objResourceEN in arrResourceObjLst_Cache
where objResourceEN.id_Resource == strid_Resource
select objResourceEN;
if (arrResourceObjLst_Sel.Count() == 0)
{
   clsResourceEN obj = clsResourceWApi.GetObjByid_Resource(strid_Resource);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrResourceObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetResourceNameByid_Resource_Cache(string strid_Resource)
{
if (string.IsNullOrEmpty(strid_Resource) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceEN._CurrTabName_S);
List<clsResourceEN> arrResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceEN> arrResourceObjLst_Sel1 =
from objResourceEN in arrResourceObjLst_Cache
where objResourceEN.id_Resource == strid_Resource
select objResourceEN;
List <clsResourceEN> arrResourceObjLst_Sel = new List<clsResourceEN>();
foreach (clsResourceEN obj in arrResourceObjLst_Sel1)
{
arrResourceObjLst_Sel.Add(obj);
}
if (arrResourceObjLst_Sel.Count > 0)
{
return arrResourceObjLst_Sel[0].ResourceName;
}
string strErrMsgForGetObjById = string.Format("在Resource对象缓存列表中,找不到记录[id_Resource = {0}](函数:{1})", strid_Resource, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsResourceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_Resource_Cache(string strid_Resource)
{
if (string.IsNullOrEmpty(strid_Resource) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceEN._CurrTabName_S);
List<clsResourceEN> arrResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceEN> arrResourceObjLst_Sel1 =
from objResourceEN in arrResourceObjLst_Cache
where objResourceEN.id_Resource == strid_Resource
select objResourceEN;
List <clsResourceEN> arrResourceObjLst_Sel = new List<clsResourceEN>();
foreach (clsResourceEN obj in arrResourceObjLst_Sel1)
{
arrResourceObjLst_Sel.Add(obj);
}
if (arrResourceObjLst_Sel.Count > 0)
{
return arrResourceObjLst_Sel[0].ResourceName;
}
string strErrMsgForGetObjById = string.Format("在Resource对象缓存列表中,找不到记录的相关名称[id_Resource = {0}](函数:{1})", strid_Resource, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsResourceBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceEN> GetObjLst(string strWhereCond)
{
 List<clsResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceEN> GetObjLstById_ResourceLst(List<string> arrId_Resource)
{
 List<clsResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_ResourceLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Resource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_Resource">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsResourceEN> GetObjLstById_ResourceLst_Cache(List<string> arrId_Resource)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsResourceEN._CurrTabName_S);
List<clsResourceEN> arrResourceObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsResourceEN> arrResourceObjLst_Sel =
from objResourceEN in arrResourceObjLst_Cache
where arrId_Resource.Contains(objResourceEN.id_Resource)
select objResourceEN;
return arrResourceObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceEN> GetObjLstById_ResourceLst_WA_Cache(List<string> arrId_Resource)
{
 List<clsResourceEN> arrObjLst = null; 
string strAction = "GetObjLstById_ResourceLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Resource);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsResourceEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsResourceEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsResourceEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_Resource)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsResourceEN objResourceEN = clsResourceWApi.GetObjByid_Resource(strid_Resource);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_Resource.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsResourceWApi.ReFreshCache();
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
public static int DelResources(List<string> arrid_Resource)
{
string strAction = "DelResources";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_Resource);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsResourceWApi.ReFreshCache();
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
public static int DelResourcesByCond(string strWhereCond)
{
string strAction = "DelResourcesByCond";
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
public static bool AddNewRecord(clsResourceEN objResourceEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceEN>(objResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsResourceEN objResourceEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceEN>(objResourceEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceWApi.ReFreshCache();
var strid_Resource = (string)jobjReturn["ReturnStr"];
return strid_Resource;
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
public static bool UpdateRecord(clsResourceEN objResourceEN)
{
if (string.IsNullOrEmpty(objResourceEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objResourceEN.id_Resource, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceEN>(objResourceEN);
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
 /// <param name = "objResourceEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsResourceEN objResourceEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objResourceEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objResourceEN.id_Resource, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objResourceEN.id_Resource, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsResourceEN>(objResourceEN);
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
public static bool IsExist(string strid_Resource)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_Resource"] = strid_Resource
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
 /// <param name = "objResourceENS">源对象</param>
 /// <param name = "objResourceENT">目标对象</param>
 public static void CopyTo(clsResourceEN objResourceENS, clsResourceEN objResourceENT)
{
try
{
objResourceENT.id_Resource = objResourceENS.id_Resource; //资源流水号
objResourceENT.ResourceID = objResourceENS.ResourceID; //资源ID
objResourceENT.ResourceName = objResourceENS.ResourceName; //资源名称
objResourceENT.SaveMode = objResourceENS.SaveMode; //文件存放方式
objResourceENT.id_FtpResource = objResourceENS.id_FtpResource; //FTP资源流水号
objResourceENT.id_File = objResourceENS.id_File; //文件流水号
objResourceENT.id_ResourceType = objResourceENS.id_ResourceType; //资源类型流水号
objResourceENT.UpdDate = objResourceENS.UpdDate; //修改日期
objResourceENT.UpdTime = objResourceENS.UpdTime; //UpdTime
objResourceENT.Memo = objResourceENS.Memo; //备注
objResourceENT.FuncModuleId = objResourceENS.FuncModuleId; //功能模块Id
objResourceENT.CheckDate = objResourceENS.CheckDate; //检查日期
objResourceENT.CheckUser = objResourceENS.CheckUser; //检查用户Id
objResourceENT.CheckResult = objResourceENS.CheckResult; //检查结果
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
public static DataTable ToDataTable(List<clsResourceEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsResourceEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsResourceEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsResourceEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsResourceEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsResourceEN.AttributeName)
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
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_Resource");
//if (arrResourceObjLst_Cache == null)
//{
//arrResourceObjLst_Cache = await clsResourceWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsResourceEN._CurrTabName_S);
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
if (clsResourceWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsResourceEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsResourceWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResourceEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsResourceEN._CurrTabName_S);
List<clsResourceEN> arrResourceObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrResourceObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsResourceEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conResource.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(conResource.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(conResource.ResourceName, Type.GetType("System.String"));
objDT.Columns.Add(conResource.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(conResource.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(conResource.id_File, Type.GetType("System.String"));
objDT.Columns.Add(conResource.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(conResource.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conResource.UpdTime, Type.GetType("System.String"));
objDT.Columns.Add(conResource.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conResource.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conResource.CheckDate, Type.GetType("System.String"));
objDT.Columns.Add(conResource.CheckUser, Type.GetType("System.String"));
objDT.Columns.Add(conResource.CheckResult, Type.GetType("System.String"));
foreach (clsResourceEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conResource.id_Resource] = objInFor[conResource.id_Resource];
objDR[conResource.ResourceID] = objInFor[conResource.ResourceID];
objDR[conResource.ResourceName] = objInFor[conResource.ResourceName];
objDR[conResource.SaveMode] = objInFor[conResource.SaveMode];
objDR[conResource.id_FtpResource] = objInFor[conResource.id_FtpResource];
objDR[conResource.id_File] = objInFor[conResource.id_File];
objDR[conResource.id_ResourceType] = objInFor[conResource.id_ResourceType];
objDR[conResource.UpdDate] = objInFor[conResource.UpdDate];
objDR[conResource.UpdTime] = objInFor[conResource.UpdTime];
objDR[conResource.Memo] = objInFor[conResource.Memo];
objDR[conResource.FuncModuleId] = objInFor[conResource.FuncModuleId];
objDR[conResource.CheckDate] = objInFor[conResource.CheckDate];
objDR[conResource.CheckUser] = objInFor[conResource.CheckUser];
objDR[conResource.CheckResult] = objInFor[conResource.CheckResult];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 资源(Resource)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4Resource : clsCommFun4BL
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
clsResourceWApi.ReFreshThisCache();
}
}

}