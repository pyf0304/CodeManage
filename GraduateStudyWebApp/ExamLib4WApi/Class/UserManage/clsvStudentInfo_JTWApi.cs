
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvStudentInfo_JTWApi
 表名:vStudentInfo_JT(01120246)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:52
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
public static class clsvStudentInfo_JTWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN Setid_StudentInfo(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convStudentInfo_JT.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convStudentInfo_JT.id_StudentInfo);
objvStudentInfo_JTEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.id_StudentInfo) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.id_StudentInfo, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.id_StudentInfo] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetSiteName(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strSiteName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSiteName, convStudentInfo_JT.SiteName);
clsCheckSql.CheckFieldLen(strSiteName, 100, convStudentInfo_JT.SiteName);
objvStudentInfo_JTEN.SiteName = strSiteName; //工地名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.SiteName) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.SiteName, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.SiteName] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetManagedDepartmentId(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strManagedDepartmentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentId, convStudentInfo_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldLen(strManagedDepartmentId, 4, convStudentInfo_JT.ManagedDepartmentId);
clsCheckSql.CheckFieldForeignKey(strManagedDepartmentId, 4, convStudentInfo_JT.ManagedDepartmentId);
objvStudentInfo_JTEN.ManagedDepartmentId = strManagedDepartmentId; //管理的部门Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.ManagedDepartmentId) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.ManagedDepartmentId, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentId] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetManagedDepartmentName(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strManagedDepartmentName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strManagedDepartmentName, convStudentInfo_JT.ManagedDepartmentName);
clsCheckSql.CheckFieldLen(strManagedDepartmentName, 50, convStudentInfo_JT.ManagedDepartmentName);
objvStudentInfo_JTEN.ManagedDepartmentName = strManagedDepartmentName; //管理的部门名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.ManagedDepartmentName) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.ManagedDepartmentName, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentName] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetJobCategoryId(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strJobCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryId, convStudentInfo_JT.JobCategoryId);
clsCheckSql.CheckFieldLen(strJobCategoryId, 2, convStudentInfo_JT.JobCategoryId);
clsCheckSql.CheckFieldForeignKey(strJobCategoryId, 2, convStudentInfo_JT.JobCategoryId);
objvStudentInfo_JTEN.JobCategoryId = strJobCategoryId; //岗位类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.JobCategoryId) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.JobCategoryId, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.JobCategoryId] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetUserId(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convStudentInfo_JT.UserId);
objvStudentInfo_JTEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.UserId) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.UserId, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.UserId] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetJobCategoryName(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strJobCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJobCategoryName, convStudentInfo_JT.JobCategoryName);
clsCheckSql.CheckFieldLen(strJobCategoryName, 50, convStudentInfo_JT.JobCategoryName);
objvStudentInfo_JTEN.JobCategoryName = strJobCategoryName; //岗位类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.JobCategoryName) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.JobCategoryName, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.JobCategoryName] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetUpdDate(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convStudentInfo_JT.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convStudentInfo_JT.UpdDate);
objvStudentInfo_JTEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.UpdDate) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.UpdDate, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.UpdDate] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetUpdUser(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convStudentInfo_JT.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convStudentInfo_JT.UpdUser);
objvStudentInfo_JTEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.UpdUser) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.UpdUser, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.UpdUser] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvStudentInfo_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvStudentInfo_JTEN SetMemo(this clsvStudentInfo_JTEN objvStudentInfo_JTEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convStudentInfo_JT.Memo);
objvStudentInfo_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvStudentInfo_JTEN.dicFldComparisonOp.ContainsKey(convStudentInfo_JT.Memo) == false)
{
objvStudentInfo_JTEN.dicFldComparisonOp.Add(convStudentInfo_JT.Memo, strComparisonOp);
}
else
{
objvStudentInfo_JTEN.dicFldComparisonOp[convStudentInfo_JT.Memo] = strComparisonOp;
}
}
return objvStudentInfo_JTEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvStudentInfo_JTEN objvStudentInfo_JT_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.id_StudentInfo, objvStudentInfo_JT_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.SiteName) == true)
{
string strComparisonOp_SiteName = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.SiteName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.SiteName, objvStudentInfo_JT_Cond.SiteName, strComparisonOp_SiteName);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.ManagedDepartmentId) == true)
{
string strComparisonOp_ManagedDepartmentId = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.ManagedDepartmentId, objvStudentInfo_JT_Cond.ManagedDepartmentId, strComparisonOp_ManagedDepartmentId);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.ManagedDepartmentName) == true)
{
string strComparisonOp_ManagedDepartmentName = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.ManagedDepartmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.ManagedDepartmentName, objvStudentInfo_JT_Cond.ManagedDepartmentName, strComparisonOp_ManagedDepartmentName);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.JobCategoryId) == true)
{
string strComparisonOp_JobCategoryId = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.JobCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.JobCategoryId, objvStudentInfo_JT_Cond.JobCategoryId, strComparisonOp_JobCategoryId);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.UserId) == true)
{
string strComparisonOp_UserId = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.UserId, objvStudentInfo_JT_Cond.UserId, strComparisonOp_UserId);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.JobCategoryName) == true)
{
string strComparisonOp_JobCategoryName = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.JobCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.JobCategoryName, objvStudentInfo_JT_Cond.JobCategoryName, strComparisonOp_JobCategoryName);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.UpdDate, objvStudentInfo_JT_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.UpdUser, objvStudentInfo_JT_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvStudentInfo_JT_Cond.IsUpdated(convStudentInfo_JT.Memo) == true)
{
string strComparisonOp_Memo = objvStudentInfo_JT_Cond.dicFldComparisonOp[convStudentInfo_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convStudentInfo_JT.Memo, objvStudentInfo_JT_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v学生_JT(vStudentInfo_JT)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvStudentInfo_JTWApi
{
private static readonly string mstrApiControllerName = "vStudentInfo_JTApi";

 public clsvStudentInfo_JTWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_StudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvStudentInfo_JTEN GetObjByid_StudentInfo(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvStudentInfo_JTEN objvStudentInfo_JTEN = null;
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
objvStudentInfo_JTEN = JsonConvert.DeserializeObject<clsvStudentInfo_JTEN>((string)jobjReturn["ReturnObj"]);
return objvStudentInfo_JTEN;
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
public static clsvStudentInfo_JTEN GetObjByid_StudentInfo_WA_Cache(string strid_StudentInfo)
{
string strAction = "GetObjByid_StudentInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvStudentInfo_JTEN objvStudentInfo_JTEN = null;
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
objvStudentInfo_JTEN = JsonConvert.DeserializeObject<clsvStudentInfo_JTEN>((string)jobjReturn["ReturnObj"]);
return objvStudentInfo_JTEN;
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
public static clsvStudentInfo_JTEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvStudentInfo_JTEN objvStudentInfo_JTEN = null;
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
objvStudentInfo_JTEN = JsonConvert.DeserializeObject<clsvStudentInfo_JTEN>((string)jobjReturn["ReturnObj"]);
return objvStudentInfo_JTEN;
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
public static clsvStudentInfo_JTEN GetObjByid_StudentInfo_Cache(string strid_StudentInfo)
{
if (string.IsNullOrEmpty(strid_StudentInfo) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName_S);
List<clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLst_Sel =
from objvStudentInfo_JTEN in arrvStudentInfo_JTObjLst_Cache
where objvStudentInfo_JTEN.id_StudentInfo == strid_StudentInfo
select objvStudentInfo_JTEN;
if (arrvStudentInfo_JTObjLst_Sel.Count() == 0)
{
   clsvStudentInfo_JTEN obj = clsvStudentInfo_JTWApi.GetObjByid_StudentInfo(strid_StudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvStudentInfo_JTObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetObjLst(string strWhereCond)
{
 List<clsvStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfo_JTEN> GetObjLstById_StudentInfoLst(List<string> arrId_StudentInfo)
{
 List<clsvStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvStudentInfo_JTEN> GetObjLstById_StudentInfoLst_Cache(List<string> arrId_StudentInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName_S);
List<clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLst_Sel =
from objvStudentInfo_JTEN in arrvStudentInfo_JTObjLst_Cache
where arrId_StudentInfo.Contains(objvStudentInfo_JTEN.id_StudentInfo)
select objvStudentInfo_JTEN;
return arrvStudentInfo_JTObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvStudentInfo_JTEN> GetObjLstById_StudentInfoLst_WA_Cache(List<string> arrId_StudentInfo)
{
 List<clsvStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfo_JTEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfo_JTEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfo_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvStudentInfo_JTEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvStudentInfo_JTEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvStudentInfo_JTEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvStudentInfo_JTENS">源对象</param>
 /// <param name = "objvStudentInfo_JTENT">目标对象</param>
 public static void CopyTo(clsvStudentInfo_JTEN objvStudentInfo_JTENS, clsvStudentInfo_JTEN objvStudentInfo_JTENT)
{
try
{
objvStudentInfo_JTENT.id_StudentInfo = objvStudentInfo_JTENS.id_StudentInfo; //学生流水号
objvStudentInfo_JTENT.SiteName = objvStudentInfo_JTENS.SiteName; //工地名称
objvStudentInfo_JTENT.ManagedDepartmentId = objvStudentInfo_JTENS.ManagedDepartmentId; //管理的部门Id
objvStudentInfo_JTENT.ManagedDepartmentName = objvStudentInfo_JTENS.ManagedDepartmentName; //管理的部门名
objvStudentInfo_JTENT.JobCategoryId = objvStudentInfo_JTENS.JobCategoryId; //岗位类别Id
objvStudentInfo_JTENT.UserId = objvStudentInfo_JTENS.UserId; //用户ID
objvStudentInfo_JTENT.JobCategoryName = objvStudentInfo_JTENS.JobCategoryName; //岗位类别名
objvStudentInfo_JTENT.UpdDate = objvStudentInfo_JTENS.UpdDate; //修改日期
objvStudentInfo_JTENT.UpdUser = objvStudentInfo_JTENS.UpdUser; //修改人
objvStudentInfo_JTENT.Memo = objvStudentInfo_JTENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvStudentInfo_JTEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvStudentInfo_JTEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvStudentInfo_JTEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvStudentInfo_JTEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvStudentInfo_JTEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvStudentInfo_JTEN.AttributeName)
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
if (clsManagedDepartmentWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsManagedDepartmentWApi没有刷新缓存机制(clsManagedDepartmentWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsJobCategoryWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsJobCategoryWApi没有刷新缓存机制(clsJobCategoryWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfo_JTWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfo_JTWApi没有刷新缓存机制(clsStudentInfo_JTWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_StudentInfo");
//if (arrvStudentInfo_JTObjLst_Cache == null)
//{
//arrvStudentInfo_JTObjLst_Cache = await clsvStudentInfo_JTWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName_S);
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
public static List<clsvStudentInfo_JTEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvStudentInfo_JTEN._CurrTabName_S);
List<clsvStudentInfo_JTEN> arrvStudentInfo_JTObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvStudentInfo_JTObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvStudentInfo_JTEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convStudentInfo_JT.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.SiteName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.ManagedDepartmentId, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.ManagedDepartmentName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.JobCategoryId, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.JobCategoryName, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convStudentInfo_JT.Memo, Type.GetType("System.String"));
foreach (clsvStudentInfo_JTEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convStudentInfo_JT.id_StudentInfo] = objInFor[convStudentInfo_JT.id_StudentInfo];
objDR[convStudentInfo_JT.SiteName] = objInFor[convStudentInfo_JT.SiteName];
objDR[convStudentInfo_JT.ManagedDepartmentId] = objInFor[convStudentInfo_JT.ManagedDepartmentId];
objDR[convStudentInfo_JT.ManagedDepartmentName] = objInFor[convStudentInfo_JT.ManagedDepartmentName];
objDR[convStudentInfo_JT.JobCategoryId] = objInFor[convStudentInfo_JT.JobCategoryId];
objDR[convStudentInfo_JT.UserId] = objInFor[convStudentInfo_JT.UserId];
objDR[convStudentInfo_JT.JobCategoryName] = objInFor[convStudentInfo_JT.JobCategoryName];
objDR[convStudentInfo_JT.UpdDate] = objInFor[convStudentInfo_JT.UpdDate];
objDR[convStudentInfo_JT.UpdUser] = objInFor[convStudentInfo_JT.UpdUser];
objDR[convStudentInfo_JT.Memo] = objInFor[convStudentInfo_JT.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}