
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentInfo_JTWApi
 表名:StudentInfo_JT(01120245)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:59
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
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
public static class clsStudentInfo_JTWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN Setid_StudentInfo(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, conStudentInfo_JT.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, conStudentInfo_JT.id_StudentInfo);
objStudentInfo_JTEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.id_StudentInfo) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.id_StudentInfo, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.id_StudentInfo] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN SetSiteName(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSiteName, 100, conStudentInfo_JT.SiteName);
objStudentInfo_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.SiteName) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.SiteName, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.SiteName] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN SetManagedDepartmentId(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, conStudentInfo_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, conStudentInfo_JT.ManagedDepartmentId);
objStudentInfo_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.ManagedDepartmentId) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN SetJobCategoryId(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, conStudentInfo_JT.JobCategoryId);
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, conStudentInfo_JT.JobCategoryId);
objStudentInfo_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.JobCategoryId) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.JobCategoryId, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.JobCategoryId] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN SetUserId(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, conStudentInfo_JT.UserId);
objStudentInfo_JTEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.UserId) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.UserId, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.UserId] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN SetUpdDate(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conStudentInfo_JT.UpdDate);
objStudentInfo_JTEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.UpdDate) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.UpdDate, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.UpdDate] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN SetUpdUser(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conStudentInfo_JT.UpdUser);
objStudentInfo_JTEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.UpdUser) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.UpdUser, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.UpdUser] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsStudentInfo_JTEN SetMemo(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conStudentInfo_JT.Memo);
objStudentInfo_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(conStudentInfo_JT.Memo) == false)
{
objStudentInfo_JTEN.dicFldComparisonOp.Add(conStudentInfo_JT.Memo, strComparisonOp);
}
else
{
objStudentInfo_JTEN.dicFldComparisonOp[conStudentInfo_JT.Memo] = strComparisonOp;
}
}
return objStudentInfo_JTEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsStudentInfo_JTEN objStudentInfo_JT_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.id_StudentInfo, objStudentInfo_JT_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.SiteName) == true)
{
string strComparisonOp_SiteName = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.SiteName, objStudentInfo_JT_Cond.SiteName, strComparisonOp_SiteName);
}
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.ManagedDepartmentId) == true)
{
string strComparisonOp_ManagedDepartmentId = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.ManagedDepartmentId, objStudentInfo_JT_Cond.ManagedDepartmentId, strComparisonOp_ManagedDepartmentId);
}
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.JobCategoryId) == true)
{
string strComparisonOp_JobCategoryId = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.JobCategoryId, objStudentInfo_JT_Cond.JobCategoryId, strComparisonOp_JobCategoryId);
}
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.UserId) == true)
{
string strComparisonOp_UserId = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.UserId, objStudentInfo_JT_Cond.UserId, strComparisonOp_UserId);
}
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.UpdDate) == true)
{
string strComparisonOp_UpdDate = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.UpdDate, objStudentInfo_JT_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.UpdUser) == true)
{
string strComparisonOp_UpdUser = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.UpdUser, objStudentInfo_JT_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objStudentInfo_JT_Cond.IsUpdated(conStudentInfo_JT.Memo) == true)
{
string strComparisonOp_Memo = objStudentInfo_JT_Cond.dicFldComparisonOp[conStudentInfo_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conStudentInfo_JT.Memo, objStudentInfo_JT_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objStudentInfo_JTEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsStudentInfo_JTEN objStudentInfo_JTEN)
{
 if (string.IsNullOrEmpty(objStudentInfo_JTEN.id_StudentInfo) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objStudentInfo_JTEN.sf_UpdFldSetStr = objStudentInfo_JTEN.getsf_UpdFldSetStr();
clsStudentInfo_JTWApi.CheckPropertyNew(objStudentInfo_JTEN); 
bool bolResult = clsStudentInfo_JTWApi.UpdateRecord(objStudentInfo_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfo_JTWApi.ReFreshCache();
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
 /// <param name = "objStudentInfo_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsStudentInfo_JTEN objStudentInfo_JTEN)
{
 if (string.IsNullOrEmpty(objStudentInfo_JTEN.id_StudentInfo) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsStudentInfo_JTWApi.IsExist(objStudentInfo_JTEN.id_StudentInfo) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objStudentInfo_JTEN.id_StudentInfo, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsStudentInfo_JTWApi.CheckPropertyNew(objStudentInfo_JTEN); 
bool bolResult = clsStudentInfo_JTWApi.AddNewRecord(objStudentInfo_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfo_JTWApi.ReFreshCache();
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
 /// <param name = "objStudentInfo_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsStudentInfo_JTEN objStudentInfo_JTEN)
{
try
{
clsStudentInfo_JTWApi.CheckPropertyNew(objStudentInfo_JTEN); 
string strid_StudentInfo = clsStudentInfo_JTWApi.AddNewRecordWithMaxId(objStudentInfo_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfo_JTWApi.ReFreshCache();
return strid_StudentInfo;
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
 /// <param name = "objStudentInfo_JTEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsStudentInfo_JTEN objStudentInfo_JTEN, string strWhereCond)
{
try
{
clsStudentInfo_JTWApi.CheckPropertyNew(objStudentInfo_JTEN); 
bool bolResult = clsStudentInfo_JTWApi.UpdateWithCondition(objStudentInfo_JTEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfo_JTWApi.ReFreshCache();
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
 /// 学生基本信息_JT(StudentInfo_JT)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsStudentInfo_JTWApi
{
private static readonly string mstrApiControllerName = "StudentInfo_JTApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsStudentInfo_JTWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsStudentInfo_JTEN objStudentInfo_JTEN)
{
if (!Object.Equals(null, objStudentInfo_JTEN.id_StudentInfo) && GetStrLen(objStudentInfo_JTEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objStudentInfo_JTEN.SiteName) && GetStrLen(objStudentInfo_JTEN.SiteName) > 100)
{
 throw new Exception("字段[工地名称]的长度不能超过100!");
}
if (!Object.Equals(null, objStudentInfo_JTEN.ManagedDepartmentId) && GetStrLen(objStudentInfo_JTEN.ManagedDepartmentId) > 4)
{
 throw new Exception("字段[管理的部门Id]的长度不能超过4!");
}
if (!Object.Equals(null, objStudentInfo_JTEN.JobCategoryId) && GetStrLen(objStudentInfo_JTEN.JobCategoryId) > 2)
{
 throw new Exception("字段[岗位类别Id]的长度不能超过2!");
}
if (!Object.Equals(null, objStudentInfo_JTEN.UserId) && GetStrLen(objStudentInfo_JTEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfo_JTEN.UpdDate) && GetStrLen(objStudentInfo_JTEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfo_JTEN.UpdUser) && GetStrLen(objStudentInfo_JTEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objStudentInfo_JTEN.Memo) && GetStrLen(objStudentInfo_JTEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objStudentInfo_JTEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentInfo_JTEN GetObjByid_StudentInfo(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsStudentInfo_JTEN objStudentInfo_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objStudentInfo_JTEN = JsonConvert.DeserializeObject<clsStudentInfo_JTEN>((string)jobjReturn["ReturnObj"]);
return objStudentInfo_JTEN;
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
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsStudentInfo_JTEN GetObjByid_StudentInfo_WA_Cache(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsStudentInfo_JTEN objStudentInfo_JTEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objStudentInfo_JTEN = JsonConvert.DeserializeObject<clsStudentInfo_JTEN>((string)jobjReturn["ReturnObj"]);
return objStudentInfo_JTEN;
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
public static clsStudentInfo_JTEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsStudentInfo_JTEN objStudentInfo_JTEN = null;
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
objStudentInfo_JTEN = JsonConvert.DeserializeObject<clsStudentInfo_JTEN>((string)jobjReturn["ReturnObj"]);
return objStudentInfo_JTEN;
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsStudentInfo_JTEN GetObjByid_StudentInfo_Cache(string strid_StudentInfo)
{
if (string.IsNullOrEmpty(strid_StudentInfo) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsStudentInfo_JTEN._CurrTabName_S);
List<clsStudentInfo_JTEN> arrStudentInfo_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentInfo_JTEN> arrStudentInfo_JTObjLst_Sel =
from objStudentInfo_JTEN in arrStudentInfo_JTObjLst_Cache
where objStudentInfo_JTEN.id_StudentInfo == strid_StudentInfo
select objStudentInfo_JTEN;
if (arrStudentInfo_JTObjLst_Sel.Count() == 0)
{
   clsStudentInfo_JTEN obj = clsStudentInfo_JTWApi.GetObjByid_StudentInfo(strid_StudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrStudentInfo_JTObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentInfo_JTEN> GetObjLst(string strWhereCond)
{
 List<clsStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfo_JTEN> GetObjLstById_StudentInfoLst(List<string> arrId_StudentInfo)
{
 List<clsStudentInfo_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_StudentInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsStudentInfo_JTEN> GetObjLstById_StudentInfoLst_Cache(List<string> arrId_StudentInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsStudentInfo_JTEN._CurrTabName_S);
List<clsStudentInfo_JTEN> arrStudentInfo_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsStudentInfo_JTEN> arrStudentInfo_JTObjLst_Sel =
from objStudentInfo_JTEN in arrStudentInfo_JTObjLst_Cache
where arrId_StudentInfo.Contains(objStudentInfo_JTEN.id_StudentInfo)
select objStudentInfo_JTEN;
return arrStudentInfo_JTObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsStudentInfo_JTEN> GetObjLstById_StudentInfoLst_WA_Cache(List<string> arrId_StudentInfo)
{
 List<clsStudentInfo_JTEN> arrObjLst = null; 
string strAction = "GetObjLstById_StudentInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_StudentInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfo_JTEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfo_JTEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfo_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsStudentInfo_JTEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_StudentInfo)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsStudentInfo_JTEN objStudentInfo_JTEN = clsStudentInfo_JTWApi.GetObjByid_StudentInfo(strid_StudentInfo);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_StudentInfo.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsStudentInfo_JTWApi.ReFreshCache();
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
public static int DelStudentInfo_JTs(List<string> arrid_StudentInfo)
{
string strAction = "DelStudentInfo_JTs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_StudentInfo);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsStudentInfo_JTWApi.ReFreshCache();
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
public static int DelStudentInfo_JTsByCond(string strWhereCond)
{
string strAction = "DelStudentInfo_JTsByCond";
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
public static bool AddNewRecord(clsStudentInfo_JTEN objStudentInfo_JTEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfo_JTEN>(objStudentInfo_JTEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfo_JTWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsStudentInfo_JTEN objStudentInfo_JTEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfo_JTEN>(objStudentInfo_JTEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsStudentInfo_JTWApi.ReFreshCache();
var strid_StudentInfo = (string)jobjReturn["ReturnStr"];
return strid_StudentInfo;
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
public static bool UpdateRecord(clsStudentInfo_JTEN objStudentInfo_JTEN)
{
if (string.IsNullOrEmpty(objStudentInfo_JTEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStudentInfo_JTEN.id_StudentInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfo_JTEN>(objStudentInfo_JTEN);
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
 /// <param name = "objStudentInfo_JTEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsStudentInfo_JTEN objStudentInfo_JTEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objStudentInfo_JTEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStudentInfo_JTEN.id_StudentInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objStudentInfo_JTEN.id_StudentInfo, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsStudentInfo_JTEN>(objStudentInfo_JTEN);
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
public static bool IsExist(string strid_StudentInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_StudentInfo"] = strid_StudentInfo
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
 /// <param name = "objStudentInfo_JTENS">源对象</param>
 /// <param name = "objStudentInfo_JTENT">目标对象</param>
 public static void CopyTo(clsStudentInfo_JTEN objStudentInfo_JTENS, clsStudentInfo_JTEN objStudentInfo_JTENT)
{
try
{
objStudentInfo_JTENT.id_StudentInfo = objStudentInfo_JTENS.id_StudentInfo; //学生流水号
objStudentInfo_JTENT.SiteName = objStudentInfo_JTENS.SiteName; //工地名称
objStudentInfo_JTENT.ManagedDepartmentId = objStudentInfo_JTENS.ManagedDepartmentId; //管理的部门Id
objStudentInfo_JTENT.JobCategoryId = objStudentInfo_JTENS.JobCategoryId; //岗位类别Id
objStudentInfo_JTENT.UserId = objStudentInfo_JTENS.UserId; //用户ID
objStudentInfo_JTENT.UpdDate = objStudentInfo_JTENS.UpdDate; //修改日期
objStudentInfo_JTENT.UpdUser = objStudentInfo_JTENS.UpdUser; //修改人
objStudentInfo_JTENT.Memo = objStudentInfo_JTENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsStudentInfo_JTEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsStudentInfo_JTEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsStudentInfo_JTEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsStudentInfo_JTEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsStudentInfo_JTEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsStudentInfo_JTEN.AttributeName)
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
if (clsStudentInfo_JTWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfo_JTWApi没有刷新缓存机制(clsStudentInfo_JTWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_StudentInfo");
//if (arrStudentInfo_JTObjLst_Cache == null)
//{
//arrStudentInfo_JTObjLst_Cache = await clsStudentInfo_JTWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsStudentInfo_JTEN._CurrTabName_S);
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
if (clsStudentInfo_JTWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsStudentInfo_JTEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsStudentInfo_JTWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsStudentInfo_JTEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsStudentInfo_JTEN._CurrTabName_S);
List<clsStudentInfo_JTEN> arrStudentInfo_JTObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrStudentInfo_JTObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsStudentInfo_JTEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conStudentInfo_JT.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo_JT.SiteName, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo_JT.ManagedDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo_JT.JobCategoryId, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo_JT.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo_JT.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo_JT.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conStudentInfo_JT.Memo, Type.GetType("System.String"));
foreach (clsStudentInfo_JTEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conStudentInfo_JT.id_StudentInfo] = objInFor[conStudentInfo_JT.id_StudentInfo];
objDR[conStudentInfo_JT.SiteName] = objInFor[conStudentInfo_JT.SiteName];
objDR[conStudentInfo_JT.ManagedDepartmentId] = objInFor[conStudentInfo_JT.ManagedDepartmentId];
objDR[conStudentInfo_JT.JobCategoryId] = objInFor[conStudentInfo_JT.JobCategoryId];
objDR[conStudentInfo_JT.UserId] = objInFor[conStudentInfo_JT.UserId];
objDR[conStudentInfo_JT.UpdDate] = objInFor[conStudentInfo_JT.UpdDate];
objDR[conStudentInfo_JT.UpdUser] = objInFor[conStudentInfo_JT.UpdUser];
objDR[conStudentInfo_JT.Memo] = objInFor[conStudentInfo_JT.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生基本信息_JT(StudentInfo_JT)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4StudentInfo_JT : clsCommFun4BL
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
clsStudentInfo_JTWApi.ReFreshThisCache();
clsvStudentInfo_JTWApi.ReFreshThisCache();
}
}

}