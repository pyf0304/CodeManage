
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClientVersionWApi
 表名:ClientVersion(01120276)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:05
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsClientVersionWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetClientVersionId(this clsClientVersionEN objClientVersionEN, string strClientVersionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClientVersionId, 8, conClientVersion.ClientVersionId);
clsCheckSql.CheckFieldForeignKey(strClientVersionId, 8, conClientVersion.ClientVersionId);
objClientVersionEN.ClientVersionId = strClientVersionId; //客户端版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.ClientVersionId) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.ClientVersionId, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.ClientVersionId] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetClientVersionTypeId(this clsClientVersionEN objClientVersionEN, string strClientVersionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClientVersionTypeId, conClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, conClientVersion.ClientVersionTypeId);
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, conClientVersion.ClientVersionTypeId);
objClientVersionEN.ClientVersionTypeId = strClientVersionTypeId; //客户端版本类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.ClientVersionTypeId) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.ClientVersionTypeId, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.ClientVersionTypeId] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetVersionDescription(this clsClientVersionEN objClientVersionEN, string strVersionDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVersionDescription, 1000, conClientVersion.VersionDescription);
objClientVersionEN.VersionDescription = strVersionDescription; //版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionDescription) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionDescription, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionDescription] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetVersionNumber(this clsClientVersionEN objClientVersionEN, string strVersionNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionNumber, conClientVersion.VersionNumber);
clsCheckSql.CheckFieldLen(strVersionNumber, 50, conClientVersion.VersionNumber);
objClientVersionEN.VersionNumber = strVersionNumber; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionNumber) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionNumber, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionNumber] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetVersionState(this clsClientVersionEN objClientVersionEN, bool bolVersionState, string strComparisonOp="")
	{
objClientVersionEN.VersionState = bolVersionState; //版本状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionState) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionState, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionState] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetVersionUrl(this clsClientVersionEN objClientVersionEN, string strVersionUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionUrl, conClientVersion.VersionUrl);
clsCheckSql.CheckFieldLen(strVersionUrl, 500, conClientVersion.VersionUrl);
objClientVersionEN.VersionUrl = strVersionUrl; //版本文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionUrl) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionUrl, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionUrl] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetVersionCode(this clsClientVersionEN objClientVersionEN, string strVersionCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionCode, conClientVersion.VersionCode);
clsCheckSql.CheckFieldLen(strVersionCode, 50, conClientVersion.VersionCode);
objClientVersionEN.VersionCode = strVersionCode; //VersionCode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionCode) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionCode, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionCode] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetPrjId(this clsClientVersionEN objClientVersionEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPrjId, 4, conClientVersion.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conClientVersion.PrjId);
objClientVersionEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.PrjId) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.PrjId, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.PrjId] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetUpdDate(this clsClientVersionEN objClientVersionEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conClientVersion.UpdDate);
objClientVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.UpdDate) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.UpdDate, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.UpdDate] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetUpdUser(this clsClientVersionEN objClientVersionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conClientVersion.UpdUser);
objClientVersionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.UpdUser) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.UpdUser, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.UpdUser] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsClientVersionEN SetMemo(this clsClientVersionEN objClientVersionEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conClientVersion.Memo);
objClientVersionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.Memo) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.Memo, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.Memo] = strComparisonOp;
}
}
return objClientVersionEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsClientVersionEN objClientVersion_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objClientVersion_Cond.IsUpdated(conClientVersion.ClientVersionId) == true)
{
string strComparisonOp_ClientVersionId = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.ClientVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.ClientVersionId, objClientVersion_Cond.ClientVersionId, strComparisonOp_ClientVersionId);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.ClientVersionTypeId) == true)
{
string strComparisonOp_ClientVersionTypeId = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.ClientVersionTypeId, objClientVersion_Cond.ClientVersionTypeId, strComparisonOp_ClientVersionTypeId);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.VersionDescription) == true)
{
string strComparisonOp_VersionDescription = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.VersionDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionDescription, objClientVersion_Cond.VersionDescription, strComparisonOp_VersionDescription);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.VersionNumber) == true)
{
string strComparisonOp_VersionNumber = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.VersionNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionNumber, objClientVersion_Cond.VersionNumber, strComparisonOp_VersionNumber);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.VersionState) == true)
{
if (objClientVersion_Cond.VersionState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClientVersion.VersionState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClientVersion.VersionState);
}
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.VersionUrl) == true)
{
string strComparisonOp_VersionUrl = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.VersionUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionUrl, objClientVersion_Cond.VersionUrl, strComparisonOp_VersionUrl);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.VersionCode) == true)
{
string strComparisonOp_VersionCode = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.VersionCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionCode, objClientVersion_Cond.VersionCode, strComparisonOp_VersionCode);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.PrjId) == true)
{
string strComparisonOp_PrjId = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.PrjId, objClientVersion_Cond.PrjId, strComparisonOp_PrjId);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.UpdDate) == true)
{
string strComparisonOp_UpdDate = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.UpdDate, objClientVersion_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.UpdUser) == true)
{
string strComparisonOp_UpdUser = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.UpdUser, objClientVersion_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objClientVersion_Cond.IsUpdated(conClientVersion.Memo) == true)
{
string strComparisonOp_Memo = objClientVersion_Cond.dicFldComparisonOp[conClientVersion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.Memo, objClientVersion_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objClientVersionEN.sf_UpdFldSetStr = objClientVersionEN.getsf_UpdFldSetStr();
clsClientVersionWApi.CheckPropertyNew(objClientVersionEN); 
bool bolResult = clsClientVersionWApi.UpdateRecord(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionWApi.ReFreshCache();
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClientVersionWApi.IsExist(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objClientVersionEN.ClientVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsClientVersionWApi.CheckPropertyNew(objClientVersionEN); 
bool bolResult = clsClientVersionWApi.AddNewRecord(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionWApi.ReFreshCache();
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsClientVersionEN objClientVersionEN)
{
try
{
clsClientVersionWApi.CheckPropertyNew(objClientVersionEN); 
string strClientVersionId = clsClientVersionWApi.AddNewRecordWithMaxId(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionWApi.ReFreshCache();
return strClientVersionId;
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
 /// <param name = "objClientVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClientVersionEN objClientVersionEN, string strWhereCond)
{
try
{
clsClientVersionWApi.CheckPropertyNew(objClientVersionEN); 
bool bolResult = clsClientVersionWApi.UpdateWithCondition(objClientVersionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionWApi.ReFreshCache();
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
 /// 客户端版本(ClientVersion)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsClientVersionWApi
{
private static readonly string mstrApiControllerName = "ClientVersionApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsClientVersionWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsClientVersionEN objClientVersionEN)
{
if (!Object.Equals(null, objClientVersionEN.ClientVersionId) && GetStrLen(objClientVersionEN.ClientVersionId) > 8)
{
 throw new Exception("字段[客户端版本Id]的长度不能超过8!");
}
if (!Object.Equals(null, objClientVersionEN.ClientVersionTypeId) && GetStrLen(objClientVersionEN.ClientVersionTypeId) > 8)
{
 throw new Exception("字段[客户端版本类型Id]的长度不能超过8!");
}
if (!Object.Equals(null, objClientVersionEN.VersionDescription) && GetStrLen(objClientVersionEN.VersionDescription) > 1000)
{
 throw new Exception("字段[版本说明]的长度不能超过1000!");
}
if (!Object.Equals(null, objClientVersionEN.VersionNumber) && GetStrLen(objClientVersionEN.VersionNumber) > 50)
{
 throw new Exception("字段[版本号]的长度不能超过50!");
}
if (!Object.Equals(null, objClientVersionEN.VersionUrl) && GetStrLen(objClientVersionEN.VersionUrl) > 500)
{
 throw new Exception("字段[版本文件]的长度不能超过500!");
}
if (!Object.Equals(null, objClientVersionEN.VersionCode) && GetStrLen(objClientVersionEN.VersionCode) > 50)
{
 throw new Exception("字段[VersionCode]的长度不能超过50!");
}
if (!Object.Equals(null, objClientVersionEN.PrjId) && GetStrLen(objClientVersionEN.PrjId) > 4)
{
 throw new Exception("字段[PrjId]的长度不能超过4!");
}
if (!Object.Equals(null, objClientVersionEN.UpdDate) && GetStrLen(objClientVersionEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objClientVersionEN.UpdUser) && GetStrLen(objClientVersionEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objClientVersionEN.Memo) && GetStrLen(objClientVersionEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objClientVersionEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClientVersionEN GetObjByClientVersionId(string strClientVersionId)
{
string strAction = "GetObjByClientVersionId";
string strErrMsg = string.Empty;
string strResult = "";
clsClientVersionEN objClientVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClientVersionId"] = strClientVersionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objClientVersionEN = JsonConvert.DeserializeObject<clsClientVersionEN>((string)jobjReturn["ReturnObj"]);
return objClientVersionEN;
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
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClientVersionEN GetObjByClientVersionId_WA_Cache(string strClientVersionId)
{
string strAction = "GetObjByClientVersionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsClientVersionEN objClientVersionEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClientVersionId"] = strClientVersionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objClientVersionEN = JsonConvert.DeserializeObject<clsClientVersionEN>((string)jobjReturn["ReturnObj"]);
return objClientVersionEN;
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
public static clsClientVersionEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsClientVersionEN objClientVersionEN = null;
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
objClientVersionEN = JsonConvert.DeserializeObject<clsClientVersionEN>((string)jobjReturn["ReturnObj"]);
return objClientVersionEN;
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
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClientVersionEN GetObjByClientVersionId_Cache(string strClientVersionId)
{
if (string.IsNullOrEmpty(strClientVersionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName_S);
List<clsClientVersionEN> arrClientVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClientVersionEN> arrClientVersionObjLst_Sel =
from objClientVersionEN in arrClientVersionObjLst_Cache
where objClientVersionEN.ClientVersionId == strClientVersionId
select objClientVersionEN;
if (arrClientVersionObjLst_Sel.Count() == 0)
{
   clsClientVersionEN obj = clsClientVersionWApi.GetObjByClientVersionId(strClientVersionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrClientVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClientVersionEN> GetObjLst(string strWhereCond)
{
 List<clsClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClientVersionEN> GetObjLstByClientVersionIdLst(List<string> arrClientVersionId)
{
 List<clsClientVersionEN> arrObjLst = null; 
string strAction = "GetObjLstByClientVersionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrClientVersionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsClientVersionEN> GetObjLstByClientVersionIdLst_Cache(List<string> arrClientVersionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName_S);
List<clsClientVersionEN> arrClientVersionObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsClientVersionEN> arrClientVersionObjLst_Sel =
from objClientVersionEN in arrClientVersionObjLst_Cache
where arrClientVersionId.Contains(objClientVersionEN.ClientVersionId)
select objClientVersionEN;
return arrClientVersionObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClientVersionEN> GetObjLstByClientVersionIdLst_WA_Cache(List<string> arrClientVersionId)
{
 List<clsClientVersionEN> arrObjLst = null; 
string strAction = "GetObjLstByClientVersionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrClientVersionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClientVersionEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClientVersionEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClientVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsClientVersionEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsClientVersionEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsClientVersionEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strClientVersionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsClientVersionEN objClientVersionEN = clsClientVersionWApi.GetObjByClientVersionId(strClientVersionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strClientVersionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsClientVersionWApi.ReFreshCache();
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
public static int DelClientVersions(List<string> arrClientVersionId)
{
string strAction = "DelClientVersions";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrClientVersionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsClientVersionWApi.ReFreshCache();
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
public static int DelClientVersionsByCond(string strWhereCond)
{
string strAction = "DelClientVersionsByCond";
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
public static bool AddNewRecord(clsClientVersionEN objClientVersionEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClientVersionEN>(objClientVersionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsClientVersionEN objClientVersionEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClientVersionEN>(objClientVersionEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionWApi.ReFreshCache();
var strClientVersionId = (string)jobjReturn["ReturnStr"];
return strClientVersionId;
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
public static bool UpdateRecord(clsClientVersionEN objClientVersionEN)
{
if (string.IsNullOrEmpty(objClientVersionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClientVersionEN.ClientVersionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClientVersionEN>(objClientVersionEN);
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
 /// <param name = "objClientVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsClientVersionEN objClientVersionEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objClientVersionEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClientVersionEN.ClientVersionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objClientVersionEN.ClientVersionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsClientVersionEN>(objClientVersionEN);
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
public static bool IsExist(string strClientVersionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["ClientVersionId"] = strClientVersionId
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
 /// <param name = "objClientVersionENS">源对象</param>
 /// <param name = "objClientVersionENT">目标对象</param>
 public static void CopyTo(clsClientVersionEN objClientVersionENS, clsClientVersionEN objClientVersionENT)
{
try
{
objClientVersionENT.ClientVersionId = objClientVersionENS.ClientVersionId; //客户端版本Id
objClientVersionENT.ClientVersionTypeId = objClientVersionENS.ClientVersionTypeId; //客户端版本类型Id
objClientVersionENT.VersionDescription = objClientVersionENS.VersionDescription; //版本说明
objClientVersionENT.VersionNumber = objClientVersionENS.VersionNumber; //版本号
objClientVersionENT.VersionState = objClientVersionENS.VersionState; //版本状态
objClientVersionENT.VersionUrl = objClientVersionENS.VersionUrl; //版本文件
objClientVersionENT.VersionCode = objClientVersionENS.VersionCode; //VersionCode
objClientVersionENT.PrjId = objClientVersionENS.PrjId; //PrjId
objClientVersionENT.UpdDate = objClientVersionENS.UpdDate; //修改日期
objClientVersionENT.UpdUser = objClientVersionENS.UpdUser; //修改人
objClientVersionENT.Memo = objClientVersionENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsClientVersionEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsClientVersionEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsClientVersionEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsClientVersionEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsClientVersionEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsClientVersionEN.AttributeName)
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
if (clsClientVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsClientVersionWApi没有刷新缓存机制(clsClientVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClientVersionId");
//if (arrClientVersionObjLst_Cache == null)
//{
//arrClientVersionObjLst_Cache = await clsClientVersionWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName_S);
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
if (clsClientVersionWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsClientVersionWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClientVersionEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName_S);
List<clsClientVersionEN> arrClientVersionObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrClientVersionObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsClientVersionEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conClientVersion.ClientVersionId, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.ClientVersionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.VersionDescription, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.VersionNumber, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.VersionState, Type.GetType("System.Boolean"));
objDT.Columns.Add(conClientVersion.VersionUrl, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.VersionCode, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conClientVersion.Memo, Type.GetType("System.String"));
foreach (clsClientVersionEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conClientVersion.ClientVersionId] = objInFor[conClientVersion.ClientVersionId];
objDR[conClientVersion.ClientVersionTypeId] = objInFor[conClientVersion.ClientVersionTypeId];
objDR[conClientVersion.VersionDescription] = objInFor[conClientVersion.VersionDescription];
objDR[conClientVersion.VersionNumber] = objInFor[conClientVersion.VersionNumber];
objDR[conClientVersion.VersionState] = objInFor[conClientVersion.VersionState];
objDR[conClientVersion.VersionUrl] = objInFor[conClientVersion.VersionUrl];
objDR[conClientVersion.VersionCode] = objInFor[conClientVersion.VersionCode];
objDR[conClientVersion.PrjId] = objInFor[conClientVersion.PrjId];
objDR[conClientVersion.UpdDate] = objInFor[conClientVersion.UpdDate];
objDR[conClientVersion.UpdUser] = objInFor[conClientVersion.UpdUser];
objDR[conClientVersion.Memo] = objInFor[conClientVersion.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 客户端版本(ClientVersion)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4ClientVersion : clsCommFun4BL
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
clsClientVersionWApi.ReFreshThisCache();
}
}

}