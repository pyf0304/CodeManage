
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBrowseInfoStatistWApi
 表名:BrowseInfoStatist(01120469)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:56
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:实习记录
 模块英文名:PracticeRecord
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
public static class clsBrowseInfoStatistWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN Setid_BrowseInfoStatist(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, long lngid_BrowseInfoStatist, string strComparisonOp="")
	{
objBrowseInfoStatistEN.id_BrowseInfoStatist = lngid_BrowseInfoStatist; //浏览信息统计流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.id_BrowseInfoStatist) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.id_BrowseInfoStatist, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.id_BrowseInfoStatist] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN Setid_User(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strid_User, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_User, conBrowseInfoStatist.id_User);
clsCheckSql.CheckFieldLen(strid_User, 50, conBrowseInfoStatist.id_User);
objBrowseInfoStatistEN.id_User = strid_User; //用户流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.id_User) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.id_User, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.id_User] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN Setid_SystemModule(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strid_SystemModule, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SystemModule, conBrowseInfoStatist.id_SystemModule);
clsCheckSql.CheckFieldLen(strid_SystemModule, 4, conBrowseInfoStatist.id_SystemModule);
clsCheckSql.CheckFieldForeignKey(strid_SystemModule, 4, conBrowseInfoStatist.id_SystemModule);
objBrowseInfoStatistEN.id_SystemModule = strid_SystemModule; //系统模块流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.id_SystemModule) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.id_SystemModule, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.id_SystemModule] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN SetClassResourceID(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strClassResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassResourceID, conBrowseInfoStatist.ClassResourceID);
clsCheckSql.CheckFieldLen(strClassResourceID, 8, conBrowseInfoStatist.ClassResourceID);
clsCheckSql.CheckFieldForeignKey(strClassResourceID, 8, conBrowseInfoStatist.ClassResourceID);
objBrowseInfoStatistEN.ClassResourceID = strClassResourceID; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.ClassResourceID) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.ClassResourceID, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.ClassResourceID] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN SetBrowseInfoStatistDate(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strBrowseInfoStatistDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBrowseInfoStatistDate, 8, conBrowseInfoStatist.BrowseInfoStatistDate);
clsCheckSql.CheckFieldForeignKey(strBrowseInfoStatistDate, 8, conBrowseInfoStatist.BrowseInfoStatistDate);
objBrowseInfoStatistEN.BrowseInfoStatistDate = strBrowseInfoStatistDate; //浏览日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.BrowseInfoStatistDate) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.BrowseInfoStatistDate, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.BrowseInfoStatistDate] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN SetBrowseInfoStatistTime(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strBrowseInfoStatistTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBrowseInfoStatistTime, 6, conBrowseInfoStatist.BrowseInfoStatistTime);
clsCheckSql.CheckFieldForeignKey(strBrowseInfoStatistTime, 6, conBrowseInfoStatist.BrowseInfoStatistTime);
objBrowseInfoStatistEN.BrowseInfoStatistTime = strBrowseInfoStatistTime; //浏览时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.BrowseInfoStatistTime) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.BrowseInfoStatistTime, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.BrowseInfoStatistTime] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN SetBrowseTypeId(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strBrowseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBrowseTypeId, 4, conBrowseInfoStatist.BrowseTypeId);
clsCheckSql.CheckFieldForeignKey(strBrowseTypeId, 4, conBrowseInfoStatist.BrowseTypeId);
objBrowseInfoStatistEN.BrowseTypeId = strBrowseTypeId; //BrowseTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.BrowseTypeId) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.BrowseTypeId, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.BrowseTypeId] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsBrowseInfoStatistEN SetBrowseSpendTime(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, float fltBrowseSpendTime, string strComparisonOp="")
	{
objBrowseInfoStatistEN.BrowseSpendTime = fltBrowseSpendTime; //浏览花费时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(conBrowseInfoStatist.BrowseSpendTime) == false)
{
objBrowseInfoStatistEN.dicFldComparisonOp.Add(conBrowseInfoStatist.BrowseSpendTime, strComparisonOp);
}
else
{
objBrowseInfoStatistEN.dicFldComparisonOp[conBrowseInfoStatist.BrowseSpendTime] = strComparisonOp;
}
}
return objBrowseInfoStatistEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsBrowseInfoStatistEN objBrowseInfoStatist_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.id_BrowseInfoStatist) == true)
{
string strComparisonOp_id_BrowseInfoStatist = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.id_BrowseInfoStatist];
strWhereCond += string.Format(" And {0} {2} {1}", conBrowseInfoStatist.id_BrowseInfoStatist, objBrowseInfoStatist_Cond.id_BrowseInfoStatist, strComparisonOp_id_BrowseInfoStatist);
}
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.id_User) == true)
{
string strComparisonOp_id_User = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.id_User];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBrowseInfoStatist.id_User, objBrowseInfoStatist_Cond.id_User, strComparisonOp_id_User);
}
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.id_SystemModule) == true)
{
string strComparisonOp_id_SystemModule = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.id_SystemModule];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBrowseInfoStatist.id_SystemModule, objBrowseInfoStatist_Cond.id_SystemModule, strComparisonOp_id_SystemModule);
}
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.ClassResourceID) == true)
{
string strComparisonOp_ClassResourceID = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.ClassResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBrowseInfoStatist.ClassResourceID, objBrowseInfoStatist_Cond.ClassResourceID, strComparisonOp_ClassResourceID);
}
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.BrowseInfoStatistDate) == true)
{
string strComparisonOp_BrowseInfoStatistDate = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.BrowseInfoStatistDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBrowseInfoStatist.BrowseInfoStatistDate, objBrowseInfoStatist_Cond.BrowseInfoStatistDate, strComparisonOp_BrowseInfoStatistDate);
}
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.BrowseInfoStatistTime) == true)
{
string strComparisonOp_BrowseInfoStatistTime = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.BrowseInfoStatistTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBrowseInfoStatist.BrowseInfoStatistTime, objBrowseInfoStatist_Cond.BrowseInfoStatistTime, strComparisonOp_BrowseInfoStatistTime);
}
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.BrowseTypeId) == true)
{
string strComparisonOp_BrowseTypeId = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.BrowseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBrowseInfoStatist.BrowseTypeId, objBrowseInfoStatist_Cond.BrowseTypeId, strComparisonOp_BrowseTypeId);
}
if (objBrowseInfoStatist_Cond.IsUpdated(conBrowseInfoStatist.BrowseSpendTime) == true)
{
string strComparisonOp_BrowseSpendTime = objBrowseInfoStatist_Cond.dicFldComparisonOp[conBrowseInfoStatist.BrowseSpendTime];
strWhereCond += string.Format(" And {0} {2} {1}", conBrowseInfoStatist.BrowseSpendTime, objBrowseInfoStatist_Cond.BrowseSpendTime, strComparisonOp_BrowseSpendTime);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsBrowseInfoStatistEN objBrowseInfoStatistEN)
{
 if (objBrowseInfoStatistEN.id_BrowseInfoStatist == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objBrowseInfoStatistEN.sf_UpdFldSetStr = objBrowseInfoStatistEN.getsf_UpdFldSetStr();
clsBrowseInfoStatistWApi.CheckPropertyNew(objBrowseInfoStatistEN); 
bool bolResult = clsBrowseInfoStatistWApi.UpdateRecord(objBrowseInfoStatistEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBrowseInfoStatistWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--BrowseInfoStatist(浏览信息统计), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_User_id_SystemModule_BrowseTypeId(this clsBrowseInfoStatistEN objBrowseInfoStatistEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objBrowseInfoStatistEN == null) return "";
if (objBrowseInfoStatistEN.id_BrowseInfoStatist == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_User = '{0}'", objBrowseInfoStatistEN.id_User);
 sbCondition.AppendFormat(" and id_SystemModule = '{0}'", objBrowseInfoStatistEN.id_SystemModule);
 sbCondition.AppendFormat(" and BrowseTypeId = '{0}'", objBrowseInfoStatistEN.BrowseTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_BrowseInfoStatist !=  {0}", objBrowseInfoStatistEN.id_BrowseInfoStatist);
 sbCondition.AppendFormat(" and id_User = '{0}'", objBrowseInfoStatistEN.id_User);
 sbCondition.AppendFormat(" and id_SystemModule = '{0}'", objBrowseInfoStatistEN.id_SystemModule);
 sbCondition.AppendFormat(" and BrowseTypeId = '{0}'", objBrowseInfoStatistEN.BrowseTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsBrowseInfoStatistEN objBrowseInfoStatistEN)
{
try
{
clsBrowseInfoStatistWApi.CheckPropertyNew(objBrowseInfoStatistEN); 
bool bolResult = clsBrowseInfoStatistWApi.AddNewRecord(objBrowseInfoStatistEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBrowseInfoStatistWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strWhereCond)
{
try
{
clsBrowseInfoStatistWApi.CheckPropertyNew(objBrowseInfoStatistEN); 
bool bolResult = clsBrowseInfoStatistWApi.UpdateWithCondition(objBrowseInfoStatistEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBrowseInfoStatistWApi.ReFreshCache();
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
 /// 浏览信息统计(BrowseInfoStatist)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsBrowseInfoStatistWApi
{
private static readonly string mstrApiControllerName = "BrowseInfoStatistApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsBrowseInfoStatistWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsBrowseInfoStatistEN objBrowseInfoStatistEN)
{
if (!Object.Equals(null, objBrowseInfoStatistEN.id_User) && GetStrLen(objBrowseInfoStatistEN.id_User) > 50)
{
 throw new Exception("字段[用户流水号]的长度不能超过50!");
}
if (!Object.Equals(null, objBrowseInfoStatistEN.id_SystemModule) && GetStrLen(objBrowseInfoStatistEN.id_SystemModule) > 4)
{
 throw new Exception("字段[系统模块流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objBrowseInfoStatistEN.ClassResourceID) && GetStrLen(objBrowseInfoStatistEN.ClassResourceID) > 8)
{
 throw new Exception("字段[资源流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objBrowseInfoStatistEN.BrowseInfoStatistDate) && GetStrLen(objBrowseInfoStatistEN.BrowseInfoStatistDate) > 8)
{
 throw new Exception("字段[浏览日期]的长度不能超过8!");
}
if (!Object.Equals(null, objBrowseInfoStatistEN.BrowseInfoStatistTime) && GetStrLen(objBrowseInfoStatistEN.BrowseInfoStatistTime) > 6)
{
 throw new Exception("字段[浏览时间]的长度不能超过6!");
}
if (!Object.Equals(null, objBrowseInfoStatistEN.BrowseTypeId) && GetStrLen(objBrowseInfoStatistEN.BrowseTypeId) > 4)
{
 throw new Exception("字段[BrowseTypeId]的长度不能超过4!");
}
 objBrowseInfoStatistEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_BrowseInfoStatist">表关键字</param>
 /// <returns>表对象</returns>
public static clsBrowseInfoStatistEN GetObjByid_BrowseInfoStatist(long lngid_BrowseInfoStatist)
{
string strAction = "GetObjByid_BrowseInfoStatist";
string strErrMsg = string.Empty;
string strResult = "";
clsBrowseInfoStatistEN objBrowseInfoStatistEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_BrowseInfoStatist"] = lngid_BrowseInfoStatist.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objBrowseInfoStatistEN = JsonConvert.DeserializeObject<clsBrowseInfoStatistEN>((string)jobjReturn["ReturnObj"]);
return objBrowseInfoStatistEN;
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
 /// <param name = "lngid_BrowseInfoStatist">表关键字</param>
 /// <returns>表对象</returns>
public static clsBrowseInfoStatistEN GetObjByid_BrowseInfoStatist_WA_Cache(long lngid_BrowseInfoStatist)
{
string strAction = "GetObjByid_BrowseInfoStatist_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsBrowseInfoStatistEN objBrowseInfoStatistEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_BrowseInfoStatist"] = lngid_BrowseInfoStatist.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objBrowseInfoStatistEN = JsonConvert.DeserializeObject<clsBrowseInfoStatistEN>((string)jobjReturn["ReturnObj"]);
return objBrowseInfoStatistEN;
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
public static clsBrowseInfoStatistEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsBrowseInfoStatistEN objBrowseInfoStatistEN = null;
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
objBrowseInfoStatistEN = JsonConvert.DeserializeObject<clsBrowseInfoStatistEN>((string)jobjReturn["ReturnObj"]);
return objBrowseInfoStatistEN;
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
 /// <param name = "lngid_BrowseInfoStatist">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsBrowseInfoStatistEN GetObjByid_BrowseInfoStatist_Cache(long lngid_BrowseInfoStatist)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsBrowseInfoStatistEN._CurrTabName_S);
List<clsBrowseInfoStatistEN> arrBrowseInfoStatistObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsBrowseInfoStatistEN> arrBrowseInfoStatistObjLst_Sel =
from objBrowseInfoStatistEN in arrBrowseInfoStatistObjLst_Cache
where objBrowseInfoStatistEN.id_BrowseInfoStatist == lngid_BrowseInfoStatist
select objBrowseInfoStatistEN;
if (arrBrowseInfoStatistObjLst_Sel.Count() == 0)
{
   clsBrowseInfoStatistEN obj = clsBrowseInfoStatistWApi.GetObjByid_BrowseInfoStatist(lngid_BrowseInfoStatist);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrBrowseInfoStatistObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsBrowseInfoStatistEN> GetObjLst(string strWhereCond)
{
 List<clsBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsBrowseInfoStatistEN> GetObjLstById_BrowseInfoStatistLst(List<long> arrId_BrowseInfoStatist)
{
 List<clsBrowseInfoStatistEN> arrObjLst = null; 
string strAction = "GetObjLstById_BrowseInfoStatistLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_BrowseInfoStatist);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_BrowseInfoStatist">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsBrowseInfoStatistEN> GetObjLstById_BrowseInfoStatistLst_Cache(List<long> arrId_BrowseInfoStatist)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsBrowseInfoStatistEN._CurrTabName_S);
List<clsBrowseInfoStatistEN> arrBrowseInfoStatistObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsBrowseInfoStatistEN> arrBrowseInfoStatistObjLst_Sel =
from objBrowseInfoStatistEN in arrBrowseInfoStatistObjLst_Cache
where arrId_BrowseInfoStatist.Contains(objBrowseInfoStatistEN.id_BrowseInfoStatist)
select objBrowseInfoStatistEN;
return arrBrowseInfoStatistObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsBrowseInfoStatistEN> GetObjLstById_BrowseInfoStatistLst_WA_Cache(List<long> arrId_BrowseInfoStatist)
{
 List<clsBrowseInfoStatistEN> arrObjLst = null; 
string strAction = "GetObjLstById_BrowseInfoStatistLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_BrowseInfoStatist);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsBrowseInfoStatistEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsBrowseInfoStatistEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsBrowseInfoStatistEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsBrowseInfoStatistEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_BrowseInfoStatist)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsBrowseInfoStatistEN objBrowseInfoStatistEN = clsBrowseInfoStatistWApi.GetObjByid_BrowseInfoStatist(lngid_BrowseInfoStatist);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_BrowseInfoStatist.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsBrowseInfoStatistWApi.ReFreshCache();
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
public static int DelBrowseInfoStatists(List<string> arrid_BrowseInfoStatist)
{
string strAction = "DelBrowseInfoStatists";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_BrowseInfoStatist);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsBrowseInfoStatistWApi.ReFreshCache();
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
public static int DelBrowseInfoStatistsByCond(string strWhereCond)
{
string strAction = "DelBrowseInfoStatistsByCond";
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
public static bool AddNewRecord(clsBrowseInfoStatistEN objBrowseInfoStatistEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsBrowseInfoStatistEN>(objBrowseInfoStatistEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBrowseInfoStatistWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objBrowseInfoStatistEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsBrowseInfoStatistEN objBrowseInfoStatistEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsBrowseInfoStatistEN>(objBrowseInfoStatistEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBrowseInfoStatistWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsBrowseInfoStatistEN objBrowseInfoStatistEN)
{
if (string.IsNullOrEmpty(objBrowseInfoStatistEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objBrowseInfoStatistEN.id_BrowseInfoStatist, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsBrowseInfoStatistEN>(objBrowseInfoStatistEN);
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
 /// <param name = "objBrowseInfoStatistEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsBrowseInfoStatistEN objBrowseInfoStatistEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objBrowseInfoStatistEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objBrowseInfoStatistEN.id_BrowseInfoStatist, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objBrowseInfoStatistEN.id_BrowseInfoStatist, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsBrowseInfoStatistEN>(objBrowseInfoStatistEN);
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
public static bool IsExist(long lngid_BrowseInfoStatist)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_BrowseInfoStatist"] = lngid_BrowseInfoStatist.ToString()
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
 /// <param name = "objBrowseInfoStatistENS">源对象</param>
 /// <param name = "objBrowseInfoStatistENT">目标对象</param>
 public static void CopyTo(clsBrowseInfoStatistEN objBrowseInfoStatistENS, clsBrowseInfoStatistEN objBrowseInfoStatistENT)
{
try
{
objBrowseInfoStatistENT.id_BrowseInfoStatist = objBrowseInfoStatistENS.id_BrowseInfoStatist; //浏览信息统计流水号
objBrowseInfoStatistENT.id_User = objBrowseInfoStatistENS.id_User; //用户流水号
objBrowseInfoStatistENT.id_SystemModule = objBrowseInfoStatistENS.id_SystemModule; //系统模块流水号
objBrowseInfoStatistENT.ClassResourceID = objBrowseInfoStatistENS.ClassResourceID; //资源流水号
objBrowseInfoStatistENT.BrowseInfoStatistDate = objBrowseInfoStatistENS.BrowseInfoStatistDate; //浏览日期
objBrowseInfoStatistENT.BrowseInfoStatistTime = objBrowseInfoStatistENS.BrowseInfoStatistTime; //浏览时间
objBrowseInfoStatistENT.BrowseTypeId = objBrowseInfoStatistENS.BrowseTypeId; //BrowseTypeId
objBrowseInfoStatistENT.BrowseSpendTime = objBrowseInfoStatistENS.BrowseSpendTime; //浏览花费时间
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
public static DataTable ToDataTable(List<clsBrowseInfoStatistEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsBrowseInfoStatistEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsBrowseInfoStatistEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsBrowseInfoStatistEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsBrowseInfoStatistEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsBrowseInfoStatistEN.AttributeName)
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
if (clsBrowseInfoStatistWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsBrowseInfoStatistWApi没有刷新缓存机制(clsBrowseInfoStatistWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_BrowseInfoStatist");
//if (arrBrowseInfoStatistObjLst_Cache == null)
//{
//arrBrowseInfoStatistObjLst_Cache = await clsBrowseInfoStatistWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsBrowseInfoStatistEN._CurrTabName_S);
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
if (clsBrowseInfoStatistWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsBrowseInfoStatistEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsBrowseInfoStatistWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsBrowseInfoStatistEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsBrowseInfoStatistEN._CurrTabName_S);
List<clsBrowseInfoStatistEN> arrBrowseInfoStatistObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrBrowseInfoStatistObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsBrowseInfoStatistEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conBrowseInfoStatist.id_BrowseInfoStatist, Type.GetType("System.Int64"));
objDT.Columns.Add(conBrowseInfoStatist.id_User, Type.GetType("System.String"));
objDT.Columns.Add(conBrowseInfoStatist.id_SystemModule, Type.GetType("System.String"));
objDT.Columns.Add(conBrowseInfoStatist.ClassResourceID, Type.GetType("System.String"));
objDT.Columns.Add(conBrowseInfoStatist.BrowseInfoStatistDate, Type.GetType("System.String"));
objDT.Columns.Add(conBrowseInfoStatist.BrowseInfoStatistTime, Type.GetType("System.String"));
objDT.Columns.Add(conBrowseInfoStatist.BrowseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conBrowseInfoStatist.BrowseSpendTime, Type.GetType("System.Single"));
foreach (clsBrowseInfoStatistEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conBrowseInfoStatist.id_BrowseInfoStatist] = objInFor[conBrowseInfoStatist.id_BrowseInfoStatist];
objDR[conBrowseInfoStatist.id_User] = objInFor[conBrowseInfoStatist.id_User];
objDR[conBrowseInfoStatist.id_SystemModule] = objInFor[conBrowseInfoStatist.id_SystemModule];
objDR[conBrowseInfoStatist.ClassResourceID] = objInFor[conBrowseInfoStatist.ClassResourceID];
objDR[conBrowseInfoStatist.BrowseInfoStatistDate] = objInFor[conBrowseInfoStatist.BrowseInfoStatistDate];
objDR[conBrowseInfoStatist.BrowseInfoStatistTime] = objInFor[conBrowseInfoStatist.BrowseInfoStatistTime];
objDR[conBrowseInfoStatist.BrowseTypeId] = objInFor[conBrowseInfoStatist.BrowseTypeId];
objDR[conBrowseInfoStatist.BrowseSpendTime] = objInFor[conBrowseInfoStatist.BrowseSpendTime];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 浏览信息统计(BrowseInfoStatist)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4BrowseInfoStatist : clsCommFun4BL
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
clsBrowseInfoStatistWApi.ReFreshThisCache();
}
}

}