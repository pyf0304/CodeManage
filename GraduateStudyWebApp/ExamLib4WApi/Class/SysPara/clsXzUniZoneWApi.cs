
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzUniZoneWApi
 表名:XzUniZone(01120095)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:09
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
public static class clsXzUniZoneWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN Setid_UniZone(this clsXzUniZoneEN objXzUniZoneEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_UniZone, 4, conXzUniZone.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, conXzUniZone.id_UniZone);
objXzUniZoneEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.id_UniZone) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.id_UniZone, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.id_UniZone] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN SetUniZoneID(this clsXzUniZoneEN objXzUniZoneEN, string strUniZoneID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneID, 4, conXzUniZone.UniZoneID);
clsCheckSql.CheckFieldForeignKey(strUniZoneID, 4, conXzUniZone.UniZoneID);
objXzUniZoneEN.UniZoneID = strUniZoneID; //校区编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.UniZoneID) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.UniZoneID, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.UniZoneID] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN SetUniZoneDesc(this clsXzUniZoneEN objXzUniZoneEN, string strUniZoneDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, conXzUniZone.UniZoneDesc);
objXzUniZoneEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.UniZoneDesc) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.UniZoneDesc, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.UniZoneDesc] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN SetUniZoneDescA(this clsXzUniZoneEN objXzUniZoneEN, string strUniZoneDescA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUniZoneDescA, 20, conXzUniZone.UniZoneDescA);
objXzUniZoneEN.UniZoneDescA = strUniZoneDescA; //UniZoneDescA
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.UniZoneDescA) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.UniZoneDescA, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.UniZoneDescA] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN Setid_School(this clsXzUniZoneEN objXzUniZoneEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, conXzUniZone.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, conXzUniZone.id_School);
objXzUniZoneEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.id_School) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.id_School, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.id_School] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN Setid_Uni(this clsXzUniZoneEN objXzUniZoneEN, string strid_Uni, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_Uni, 4, conXzUniZone.id_Uni);
clsCheckSql.CheckFieldForeignKey(strid_Uni, 4, conXzUniZone.id_Uni);
objXzUniZoneEN.id_Uni = strid_Uni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.id_Uni) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.id_Uni, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.id_Uni] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN SetModifyUserID(this clsXzUniZoneEN objXzUniZoneEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, conXzUniZone.ModifyUserID);
objXzUniZoneEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.ModifyUserID) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.ModifyUserID, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.ModifyUserID] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN SetModifyDate(this clsXzUniZoneEN objXzUniZoneEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzUniZone.ModifyDate);
objXzUniZoneEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.ModifyDate) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.ModifyDate, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.ModifyDate] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzUniZoneEN SetMemo(this clsXzUniZoneEN objXzUniZoneEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzUniZone.Memo);
objXzUniZoneEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.Memo) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.Memo, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.Memo] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzUniZoneEN objXzUniZone_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.id_UniZone, objXzUniZone_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.UniZoneID) == true)
{
string strComparisonOp_UniZoneID = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.UniZoneID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.UniZoneID, objXzUniZone_Cond.UniZoneID, strComparisonOp_UniZoneID);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.UniZoneDesc) == true)
{
string strComparisonOp_UniZoneDesc = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.UniZoneDesc, objXzUniZone_Cond.UniZoneDesc, strComparisonOp_UniZoneDesc);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.UniZoneDescA) == true)
{
string strComparisonOp_UniZoneDescA = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.UniZoneDescA];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.UniZoneDescA, objXzUniZone_Cond.UniZoneDescA, strComparisonOp_UniZoneDescA);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.id_School) == true)
{
string strComparisonOp_id_School = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.id_School, objXzUniZone_Cond.id_School, strComparisonOp_id_School);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.id_Uni) == true)
{
string strComparisonOp_id_Uni = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.id_Uni];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.id_Uni, objXzUniZone_Cond.id_Uni, strComparisonOp_id_Uni);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.ModifyUserID, objXzUniZone_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.ModifyDate, objXzUniZone_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objXzUniZone_Cond.IsUpdated(conXzUniZone.Memo) == true)
{
string strComparisonOp_Memo = objXzUniZone_Cond.dicFldComparisonOp[conXzUniZone.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.Memo, objXzUniZone_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzUniZoneEN objXzUniZoneEN)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.id_UniZone) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objXzUniZoneEN.sf_UpdFldSetStr = objXzUniZoneEN.getsf_UpdFldSetStr();
clsXzUniZoneWApi.CheckPropertyNew(objXzUniZoneEN); 
bool bolResult = clsXzUniZoneWApi.UpdateRecord(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneWApi.ReFreshCache();
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzUniZoneEN objXzUniZoneEN)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.id_UniZone) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzUniZoneWApi.IsExist(objXzUniZoneEN.id_UniZone) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objXzUniZoneEN.id_UniZone, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsXzUniZoneWApi.CheckPropertyNew(objXzUniZoneEN); 
bool bolResult = clsXzUniZoneWApi.AddNewRecord(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneWApi.ReFreshCache();
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzUniZoneEN objXzUniZoneEN)
{
try
{
clsXzUniZoneWApi.CheckPropertyNew(objXzUniZoneEN); 
string strid_UniZone = clsXzUniZoneWApi.AddNewRecordWithMaxId(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneWApi.ReFreshCache();
return strid_UniZone;
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
 /// <param name = "objXzUniZoneEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzUniZoneEN objXzUniZoneEN, string strWhereCond)
{
try
{
clsXzUniZoneWApi.CheckPropertyNew(objXzUniZoneEN); 
bool bolResult = clsXzUniZoneWApi.UpdateWithCondition(objXzUniZoneEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneWApi.ReFreshCache();
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
 /// 校区(XzUniZone)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsXzUniZoneWApi
{
private static readonly string mstrApiControllerName = "XzUniZoneApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsXzUniZoneWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_UniZone(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[校区]...","0");
List<clsXzUniZoneEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_UniZone";
objDDL.DataTextField="UniZoneDesc";
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
public static void BindCbo_id_UniZone(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzUniZone.id_UniZone); 
List<clsXzUniZoneEN> arrObjLst = clsXzUniZoneWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN()
{
id_UniZone = "0",
UniZoneDesc = "选[校区]..."
};
arrObjLst.Insert(0, objXzUniZoneEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzUniZone.id_UniZone;
objComboBox.DisplayMember = conXzUniZone.UniZoneDesc;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsXzUniZoneEN objXzUniZoneEN)
{
if (!Object.Equals(null, objXzUniZoneEN.id_UniZone) && GetStrLen(objXzUniZoneEN.id_UniZone) > 4)
{
 throw new Exception("字段[校区流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzUniZoneEN.UniZoneID) && GetStrLen(objXzUniZoneEN.UniZoneID) > 4)
{
 throw new Exception("字段[校区编号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzUniZoneEN.UniZoneDesc) && GetStrLen(objXzUniZoneEN.UniZoneDesc) > 20)
{
 throw new Exception("字段[校区名称]的长度不能超过20!");
}
if (!Object.Equals(null, objXzUniZoneEN.UniZoneDescA) && GetStrLen(objXzUniZoneEN.UniZoneDescA) > 20)
{
 throw new Exception("字段[UniZoneDescA]的长度不能超过20!");
}
if (!Object.Equals(null, objXzUniZoneEN.id_School) && GetStrLen(objXzUniZoneEN.id_School) > 4)
{
 throw new Exception("字段[学校流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objXzUniZoneEN.id_Uni) && GetStrLen(objXzUniZoneEN.id_Uni) > 4)
{
 throw new Exception("字段[id_Uni]的长度不能超过4!");
}
if (!Object.Equals(null, objXzUniZoneEN.ModifyUserID) && GetStrLen(objXzUniZoneEN.ModifyUserID) > 18)
{
 throw new Exception("字段[修改人]的长度不能超过18!");
}
if (!Object.Equals(null, objXzUniZoneEN.ModifyDate) && GetStrLen(objXzUniZoneEN.ModifyDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objXzUniZoneEN.Memo) && GetStrLen(objXzUniZoneEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objXzUniZoneEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_UniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzUniZoneEN GetObjByid_UniZone(string strid_UniZone)
{
string strAction = "GetObjByid_UniZone";
string strErrMsg = string.Empty;
string strResult = "";
clsXzUniZoneEN objXzUniZoneEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_UniZone"] = strid_UniZone
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzUniZoneEN = JsonConvert.DeserializeObject<clsXzUniZoneEN>((string)jobjReturn["ReturnObj"]);
return objXzUniZoneEN;
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
 /// <param name = "strid_UniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzUniZoneEN GetObjByid_UniZone_WA_Cache(string strid_UniZone)
{
string strAction = "GetObjByid_UniZone_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsXzUniZoneEN objXzUniZoneEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_UniZone"] = strid_UniZone
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objXzUniZoneEN = JsonConvert.DeserializeObject<clsXzUniZoneEN>((string)jobjReturn["ReturnObj"]);
return objXzUniZoneEN;
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
public static clsXzUniZoneEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsXzUniZoneEN objXzUniZoneEN = null;
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
objXzUniZoneEN = JsonConvert.DeserializeObject<clsXzUniZoneEN>((string)jobjReturn["ReturnObj"]);
return objXzUniZoneEN;
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
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzUniZoneEN GetObjByid_UniZone_Cache(string strid_UniZone)
{
if (string.IsNullOrEmpty(strid_UniZone) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName_S);
List<clsXzUniZoneEN> arrXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel =
from objXzUniZoneEN in arrXzUniZoneObjLst_Cache
where objXzUniZoneEN.id_UniZone == strid_UniZone
select objXzUniZoneEN;
if (arrXzUniZoneObjLst_Sel.Count() == 0)
{
   clsXzUniZoneEN obj = clsXzUniZoneWApi.GetObjByid_UniZone(strid_UniZone);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrXzUniZoneObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUniZoneDescByid_UniZone_Cache(string strid_UniZone)
{
if (string.IsNullOrEmpty(strid_UniZone) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName_S);
List<clsXzUniZoneEN> arrXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel1 =
from objXzUniZoneEN in arrXzUniZoneObjLst_Cache
where objXzUniZoneEN.id_UniZone == strid_UniZone
select objXzUniZoneEN;
List <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel = new List<clsXzUniZoneEN>();
foreach (clsXzUniZoneEN obj in arrXzUniZoneObjLst_Sel1)
{
arrXzUniZoneObjLst_Sel.Add(obj);
}
if (arrXzUniZoneObjLst_Sel.Count > 0)
{
return arrXzUniZoneObjLst_Sel[0].UniZoneDesc;
}
string strErrMsgForGetObjById = string.Format("在XzUniZone对象缓存列表中,找不到记录[id_UniZone = {0}](函数:{1})", strid_UniZone, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzUniZoneBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_UniZone_Cache(string strid_UniZone)
{
if (string.IsNullOrEmpty(strid_UniZone) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName_S);
List<clsXzUniZoneEN> arrXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel1 =
from objXzUniZoneEN in arrXzUniZoneObjLst_Cache
where objXzUniZoneEN.id_UniZone == strid_UniZone
select objXzUniZoneEN;
List <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel = new List<clsXzUniZoneEN>();
foreach (clsXzUniZoneEN obj in arrXzUniZoneObjLst_Sel1)
{
arrXzUniZoneObjLst_Sel.Add(obj);
}
if (arrXzUniZoneObjLst_Sel.Count > 0)
{
return arrXzUniZoneObjLst_Sel[0].UniZoneDesc;
}
string strErrMsgForGetObjById = string.Format("在XzUniZone对象缓存列表中,找不到记录的相关名称[id_UniZone = {0}](函数:{1})", strid_UniZone, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsXzUniZoneBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLst(string strWhereCond)
{
 List<clsXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzUniZoneEN> GetObjLstById_UniZoneLst(List<string> arrId_UniZone)
{
 List<clsXzUniZoneEN> arrObjLst = null; 
string strAction = "GetObjLstById_UniZoneLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_UniZone);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_UniZone">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsXzUniZoneEN> GetObjLstById_UniZoneLst_Cache(List<string> arrId_UniZone)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName_S);
List<clsXzUniZoneEN> arrXzUniZoneObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel =
from objXzUniZoneEN in arrXzUniZoneObjLst_Cache
where arrId_UniZone.Contains(objXzUniZoneEN.id_UniZone)
select objXzUniZoneEN;
return arrXzUniZoneObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLstById_UniZoneLst_WA_Cache(List<string> arrId_UniZone)
{
 List<clsXzUniZoneEN> arrObjLst = null; 
string strAction = "GetObjLstById_UniZoneLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_UniZone);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzUniZoneEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzUniZoneEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzUniZoneEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsXzUniZoneEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsXzUniZoneEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsXzUniZoneEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_UniZone)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsXzUniZoneEN objXzUniZoneEN = clsXzUniZoneWApi.GetObjByid_UniZone(strid_UniZone);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_UniZone.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzUniZoneWApi.ReFreshCache();
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
public static int DelXzUniZones(List<string> arrid_UniZone)
{
string strAction = "DelXzUniZones";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_UniZone);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsXzUniZoneWApi.ReFreshCache();
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
public static int DelXzUniZonesByCond(string strWhereCond)
{
string strAction = "DelXzUniZonesByCond";
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
public static bool AddNewRecord(clsXzUniZoneEN objXzUniZoneEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzUniZoneEN>(objXzUniZoneEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsXzUniZoneEN objXzUniZoneEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzUniZoneEN>(objXzUniZoneEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneWApi.ReFreshCache();
var strid_UniZone = (string)jobjReturn["ReturnStr"];
return strid_UniZone;
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
public static bool UpdateRecord(clsXzUniZoneEN objXzUniZoneEN)
{
if (string.IsNullOrEmpty(objXzUniZoneEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzUniZoneEN.id_UniZone, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzUniZoneEN>(objXzUniZoneEN);
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
 /// <param name = "objXzUniZoneEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsXzUniZoneEN objXzUniZoneEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objXzUniZoneEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzUniZoneEN.id_UniZone, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objXzUniZoneEN.id_UniZone, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsXzUniZoneEN>(objXzUniZoneEN);
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
public static bool IsExist(string strid_UniZone)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_UniZone"] = strid_UniZone
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
 /// <param name = "objXzUniZoneENS">源对象</param>
 /// <param name = "objXzUniZoneENT">目标对象</param>
 public static void CopyTo(clsXzUniZoneEN objXzUniZoneENS, clsXzUniZoneEN objXzUniZoneENT)
{
try
{
objXzUniZoneENT.id_UniZone = objXzUniZoneENS.id_UniZone; //校区流水号
objXzUniZoneENT.UniZoneID = objXzUniZoneENS.UniZoneID; //校区编号
objXzUniZoneENT.UniZoneDesc = objXzUniZoneENS.UniZoneDesc; //校区名称
objXzUniZoneENT.UniZoneDescA = objXzUniZoneENS.UniZoneDescA; //UniZoneDescA
objXzUniZoneENT.id_School = objXzUniZoneENS.id_School; //学校流水号
objXzUniZoneENT.id_Uni = objXzUniZoneENS.id_Uni; //id_Uni
objXzUniZoneENT.ModifyUserID = objXzUniZoneENS.ModifyUserID; //修改人
objXzUniZoneENT.ModifyDate = objXzUniZoneENS.ModifyDate; //修改日期
objXzUniZoneENT.Memo = objXzUniZoneENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsXzUniZoneEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsXzUniZoneEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsXzUniZoneEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsXzUniZoneEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsXzUniZoneEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsXzUniZoneEN.AttributeName)
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
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_UniZone");
//if (arrXzUniZoneObjLst_Cache == null)
//{
//arrXzUniZoneObjLst_Cache = await clsXzUniZoneWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName_S);
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
if (clsXzUniZoneWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzUniZoneWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName_S);
List<clsXzUniZoneEN> arrXzUniZoneObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzUniZoneObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsXzUniZoneEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conXzUniZone.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.UniZoneID, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.UniZoneDesc, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.UniZoneDescA, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.id_School, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.id_Uni, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(conXzUniZone.Memo, Type.GetType("System.String"));
foreach (clsXzUniZoneEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conXzUniZone.id_UniZone] = objInFor[conXzUniZone.id_UniZone];
objDR[conXzUniZone.UniZoneID] = objInFor[conXzUniZone.UniZoneID];
objDR[conXzUniZone.UniZoneDesc] = objInFor[conXzUniZone.UniZoneDesc];
objDR[conXzUniZone.UniZoneDescA] = objInFor[conXzUniZone.UniZoneDescA];
objDR[conXzUniZone.id_School] = objInFor[conXzUniZone.id_School];
objDR[conXzUniZone.id_Uni] = objInFor[conXzUniZone.id_Uni];
objDR[conXzUniZone.ModifyUserID] = objInFor[conXzUniZone.ModifyUserID];
objDR[conXzUniZone.ModifyDate] = objInFor[conXzUniZone.ModifyDate];
objDR[conXzUniZone.Memo] = objInFor[conXzUniZone.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 校区(XzUniZone)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4XzUniZone : clsCommFun4BL
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
clsXzUniZoneWApi.ReFreshThisCache();
clsvXzUniZoneWApi.ReFreshThisCache();
}
}

}