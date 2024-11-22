
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvBrowseInfoStatistWApi
 表名:vBrowseInfoStatist(01120470)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:33
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
public static class clsvBrowseInfoStatistWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN Setid_BrowseInfoStatist(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, long lngid_BrowseInfoStatist, string strComparisonOp="")
	{
objvBrowseInfoStatistEN.id_BrowseInfoStatist = lngid_BrowseInfoStatist; //浏览信息统计流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.id_BrowseInfoStatist) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.id_BrowseInfoStatist, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.id_BrowseInfoStatist] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN SetSystemModuleName(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strSystemModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSystemModuleName, 100, convBrowseInfoStatist.SystemModuleName);
objvBrowseInfoStatistEN.SystemModuleName = strSystemModuleName; //系统模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.SystemModuleName) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.SystemModuleName, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.SystemModuleName] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN Setid_User(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strid_User, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_User, convBrowseInfoStatist.id_User);
clsCheckSql.CheckFieldLen(strid_User, 8, convBrowseInfoStatist.id_User);
clsCheckSql.CheckFieldForeignKey(strid_User, 8, convBrowseInfoStatist.id_User);
objvBrowseInfoStatistEN.id_User = strid_User; //id_User
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.id_User) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.id_User, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.id_User] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN Setid_SystemModule(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strid_SystemModule, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SystemModule, convBrowseInfoStatist.id_SystemModule);
clsCheckSql.CheckFieldLen(strid_SystemModule, 4, convBrowseInfoStatist.id_SystemModule);
clsCheckSql.CheckFieldForeignKey(strid_SystemModule, 4, convBrowseInfoStatist.id_SystemModule);
objvBrowseInfoStatistEN.id_SystemModule = strid_SystemModule; //系统模块流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.id_SystemModule) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.id_SystemModule, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.id_SystemModule] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN SetClassResourceID(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strClassResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassResourceID, convBrowseInfoStatist.ClassResourceID);
clsCheckSql.CheckFieldLen(strClassResourceID, 8, convBrowseInfoStatist.ClassResourceID);
clsCheckSql.CheckFieldForeignKey(strClassResourceID, 8, convBrowseInfoStatist.ClassResourceID);
objvBrowseInfoStatistEN.ClassResourceID = strClassResourceID; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.ClassResourceID) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.ClassResourceID, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.ClassResourceID] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN SetBrowseInfoStatistDate(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strBrowseInfoStatistDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBrowseInfoStatistDate, 8, convBrowseInfoStatist.BrowseInfoStatistDate);
clsCheckSql.CheckFieldForeignKey(strBrowseInfoStatistDate, 8, convBrowseInfoStatist.BrowseInfoStatistDate);
objvBrowseInfoStatistEN.BrowseInfoStatistDate = strBrowseInfoStatistDate; //浏览日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.BrowseInfoStatistDate) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.BrowseInfoStatistDate, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.BrowseInfoStatistDate] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN SetBrowseInfoStatistTime(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strBrowseInfoStatistTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBrowseInfoStatistTime, 6, convBrowseInfoStatist.BrowseInfoStatistTime);
clsCheckSql.CheckFieldForeignKey(strBrowseInfoStatistTime, 6, convBrowseInfoStatist.BrowseInfoStatistTime);
objvBrowseInfoStatistEN.BrowseInfoStatistTime = strBrowseInfoStatistTime; //浏览时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.BrowseInfoStatistTime) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.BrowseInfoStatistTime, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.BrowseInfoStatistTime] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN SetBrowseTypeId(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strBrowseTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBrowseTypeId, 4, convBrowseInfoStatist.BrowseTypeId);
clsCheckSql.CheckFieldForeignKey(strBrowseTypeId, 4, convBrowseInfoStatist.BrowseTypeId);
objvBrowseInfoStatistEN.BrowseTypeId = strBrowseTypeId; //BrowseTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.BrowseTypeId) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.BrowseTypeId, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.BrowseTypeId] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN SetBrowseSpendTime(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, float fltBrowseSpendTime, string strComparisonOp="")
	{
objvBrowseInfoStatistEN.BrowseSpendTime = fltBrowseSpendTime; //浏览花费时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.BrowseSpendTime) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.BrowseSpendTime, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.BrowseSpendTime] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvBrowseInfoStatistEN SetBrowseTypeName(this clsvBrowseInfoStatistEN objvBrowseInfoStatistEN, string strBrowseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBrowseTypeName, 100, convBrowseInfoStatist.BrowseTypeName);
objvBrowseInfoStatistEN.BrowseTypeName = strBrowseTypeName; //BrowseTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvBrowseInfoStatistEN.dicFldComparisonOp.ContainsKey(convBrowseInfoStatist.BrowseTypeName) == false)
{
objvBrowseInfoStatistEN.dicFldComparisonOp.Add(convBrowseInfoStatist.BrowseTypeName, strComparisonOp);
}
else
{
objvBrowseInfoStatistEN.dicFldComparisonOp[convBrowseInfoStatist.BrowseTypeName] = strComparisonOp;
}
}
return objvBrowseInfoStatistEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvBrowseInfoStatistEN objvBrowseInfoStatist_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.id_BrowseInfoStatist) == true)
{
string strComparisonOp_id_BrowseInfoStatist = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.id_BrowseInfoStatist];
strWhereCond += string.Format(" And {0} {2} {1}", convBrowseInfoStatist.id_BrowseInfoStatist, objvBrowseInfoStatist_Cond.id_BrowseInfoStatist, strComparisonOp_id_BrowseInfoStatist);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.SystemModuleName) == true)
{
string strComparisonOp_SystemModuleName = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.SystemModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.SystemModuleName, objvBrowseInfoStatist_Cond.SystemModuleName, strComparisonOp_SystemModuleName);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.id_User) == true)
{
string strComparisonOp_id_User = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.id_User];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.id_User, objvBrowseInfoStatist_Cond.id_User, strComparisonOp_id_User);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.id_SystemModule) == true)
{
string strComparisonOp_id_SystemModule = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.id_SystemModule];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.id_SystemModule, objvBrowseInfoStatist_Cond.id_SystemModule, strComparisonOp_id_SystemModule);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.ClassResourceID) == true)
{
string strComparisonOp_ClassResourceID = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.ClassResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.ClassResourceID, objvBrowseInfoStatist_Cond.ClassResourceID, strComparisonOp_ClassResourceID);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.BrowseInfoStatistDate) == true)
{
string strComparisonOp_BrowseInfoStatistDate = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.BrowseInfoStatistDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.BrowseInfoStatistDate, objvBrowseInfoStatist_Cond.BrowseInfoStatistDate, strComparisonOp_BrowseInfoStatistDate);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.BrowseInfoStatistTime) == true)
{
string strComparisonOp_BrowseInfoStatistTime = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.BrowseInfoStatistTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.BrowseInfoStatistTime, objvBrowseInfoStatist_Cond.BrowseInfoStatistTime, strComparisonOp_BrowseInfoStatistTime);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.BrowseTypeId) == true)
{
string strComparisonOp_BrowseTypeId = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.BrowseTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.BrowseTypeId, objvBrowseInfoStatist_Cond.BrowseTypeId, strComparisonOp_BrowseTypeId);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.BrowseSpendTime) == true)
{
string strComparisonOp_BrowseSpendTime = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.BrowseSpendTime];
strWhereCond += string.Format(" And {0} {2} {1}", convBrowseInfoStatist.BrowseSpendTime, objvBrowseInfoStatist_Cond.BrowseSpendTime, strComparisonOp_BrowseSpendTime);
}
if (objvBrowseInfoStatist_Cond.IsUpdated(convBrowseInfoStatist.BrowseTypeName) == true)
{
string strComparisonOp_BrowseTypeName = objvBrowseInfoStatist_Cond.dicFldComparisonOp[convBrowseInfoStatist.BrowseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convBrowseInfoStatist.BrowseTypeName, objvBrowseInfoStatist_Cond.BrowseTypeName, strComparisonOp_BrowseTypeName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v浏览信息统计(vBrowseInfoStatist)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvBrowseInfoStatistWApi
{
private static readonly string mstrApiControllerName = "vBrowseInfoStatistApi";

 public clsvBrowseInfoStatistWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_BrowseInfoStatist">表关键字</param>
 /// <returns>表对象</returns>
public static clsvBrowseInfoStatistEN GetObjByid_BrowseInfoStatist(long lngid_BrowseInfoStatist)
{
string strAction = "GetObjByid_BrowseInfoStatist";
string strErrMsg = string.Empty;
string strResult = "";
clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = null;
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
objvBrowseInfoStatistEN = JsonConvert.DeserializeObject<clsvBrowseInfoStatistEN>((string)jobjReturn["ReturnObj"]);
return objvBrowseInfoStatistEN;
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
public static clsvBrowseInfoStatistEN GetObjByid_BrowseInfoStatist_WA_Cache(long lngid_BrowseInfoStatist)
{
string strAction = "GetObjByid_BrowseInfoStatist_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = null;
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
objvBrowseInfoStatistEN = JsonConvert.DeserializeObject<clsvBrowseInfoStatistEN>((string)jobjReturn["ReturnObj"]);
return objvBrowseInfoStatistEN;
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
public static clsvBrowseInfoStatistEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvBrowseInfoStatistEN objvBrowseInfoStatistEN = null;
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
objvBrowseInfoStatistEN = JsonConvert.DeserializeObject<clsvBrowseInfoStatistEN>((string)jobjReturn["ReturnObj"]);
return objvBrowseInfoStatistEN;
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
public static clsvBrowseInfoStatistEN GetObjByid_BrowseInfoStatist_Cache(long lngid_BrowseInfoStatist)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvBrowseInfoStatistEN._CurrTabName_S);
List<clsvBrowseInfoStatistEN> arrvBrowseInfoStatistObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvBrowseInfoStatistEN> arrvBrowseInfoStatistObjLst_Sel =
from objvBrowseInfoStatistEN in arrvBrowseInfoStatistObjLst_Cache
where objvBrowseInfoStatistEN.id_BrowseInfoStatist == lngid_BrowseInfoStatist
select objvBrowseInfoStatistEN;
if (arrvBrowseInfoStatistObjLst_Sel.Count() == 0)
{
   clsvBrowseInfoStatistEN obj = clsvBrowseInfoStatistWApi.GetObjByid_BrowseInfoStatist(lngid_BrowseInfoStatist);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvBrowseInfoStatistObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvBrowseInfoStatistEN> GetObjLst(string strWhereCond)
{
 List<clsvBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvBrowseInfoStatistEN> GetObjLstById_BrowseInfoStatistLst(List<long> arrId_BrowseInfoStatist)
{
 List<clsvBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvBrowseInfoStatistEN> GetObjLstById_BrowseInfoStatistLst_Cache(List<long> arrId_BrowseInfoStatist)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvBrowseInfoStatistEN._CurrTabName_S);
List<clsvBrowseInfoStatistEN> arrvBrowseInfoStatistObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvBrowseInfoStatistEN> arrvBrowseInfoStatistObjLst_Sel =
from objvBrowseInfoStatistEN in arrvBrowseInfoStatistObjLst_Cache
where arrId_BrowseInfoStatist.Contains(objvBrowseInfoStatistEN.id_BrowseInfoStatist)
select objvBrowseInfoStatistEN;
return arrvBrowseInfoStatistObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvBrowseInfoStatistEN> GetObjLstById_BrowseInfoStatistLst_WA_Cache(List<long> arrId_BrowseInfoStatist)
{
 List<clsvBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvBrowseInfoStatistEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvBrowseInfoStatistEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvBrowseInfoStatistEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvBrowseInfoStatistEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvBrowseInfoStatistEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvBrowseInfoStatistEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvBrowseInfoStatistENS">源对象</param>
 /// <param name = "objvBrowseInfoStatistENT">目标对象</param>
 public static void CopyTo(clsvBrowseInfoStatistEN objvBrowseInfoStatistENS, clsvBrowseInfoStatistEN objvBrowseInfoStatistENT)
{
try
{
objvBrowseInfoStatistENT.id_BrowseInfoStatist = objvBrowseInfoStatistENS.id_BrowseInfoStatist; //浏览信息统计流水号
objvBrowseInfoStatistENT.SystemModuleName = objvBrowseInfoStatistENS.SystemModuleName; //系统模块名称
objvBrowseInfoStatistENT.id_User = objvBrowseInfoStatistENS.id_User; //id_User
objvBrowseInfoStatistENT.id_SystemModule = objvBrowseInfoStatistENS.id_SystemModule; //系统模块流水号
objvBrowseInfoStatistENT.ClassResourceID = objvBrowseInfoStatistENS.ClassResourceID; //资源流水号
objvBrowseInfoStatistENT.BrowseInfoStatistDate = objvBrowseInfoStatistENS.BrowseInfoStatistDate; //浏览日期
objvBrowseInfoStatistENT.BrowseInfoStatistTime = objvBrowseInfoStatistENS.BrowseInfoStatistTime; //浏览时间
objvBrowseInfoStatistENT.BrowseTypeId = objvBrowseInfoStatistENS.BrowseTypeId; //BrowseTypeId
objvBrowseInfoStatistENT.BrowseSpendTime = objvBrowseInfoStatistENS.BrowseSpendTime; //浏览花费时间
objvBrowseInfoStatistENT.BrowseTypeName = objvBrowseInfoStatistENS.BrowseTypeName; //BrowseTypeName
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
public static DataTable ToDataTable(List<clsvBrowseInfoStatistEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvBrowseInfoStatistEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvBrowseInfoStatistEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvBrowseInfoStatistEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvBrowseInfoStatistEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvBrowseInfoStatistEN.AttributeName)
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
if (clsBrowseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsBrowseTypeWApi没有刷新缓存机制(clsBrowseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSystemModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSystemModuleWApi没有刷新缓存机制(clsSystemModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_BrowseInfoStatist");
//if (arrvBrowseInfoStatistObjLst_Cache == null)
//{
//arrvBrowseInfoStatistObjLst_Cache = await clsvBrowseInfoStatistWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvBrowseInfoStatistEN._CurrTabName_S);
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
public static List<clsvBrowseInfoStatistEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvBrowseInfoStatistEN._CurrTabName_S);
List<clsvBrowseInfoStatistEN> arrvBrowseInfoStatistObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvBrowseInfoStatistObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvBrowseInfoStatistEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convBrowseInfoStatist.id_BrowseInfoStatist, Type.GetType("System.Int64"));
objDT.Columns.Add(convBrowseInfoStatist.SystemModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convBrowseInfoStatist.id_User, Type.GetType("System.String"));
objDT.Columns.Add(convBrowseInfoStatist.id_SystemModule, Type.GetType("System.String"));
objDT.Columns.Add(convBrowseInfoStatist.ClassResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convBrowseInfoStatist.BrowseInfoStatistDate, Type.GetType("System.String"));
objDT.Columns.Add(convBrowseInfoStatist.BrowseInfoStatistTime, Type.GetType("System.String"));
objDT.Columns.Add(convBrowseInfoStatist.BrowseTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convBrowseInfoStatist.BrowseSpendTime, Type.GetType("System.Single"));
objDT.Columns.Add(convBrowseInfoStatist.BrowseTypeName, Type.GetType("System.String"));
foreach (clsvBrowseInfoStatistEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convBrowseInfoStatist.id_BrowseInfoStatist] = objInFor[convBrowseInfoStatist.id_BrowseInfoStatist];
objDR[convBrowseInfoStatist.SystemModuleName] = objInFor[convBrowseInfoStatist.SystemModuleName];
objDR[convBrowseInfoStatist.id_User] = objInFor[convBrowseInfoStatist.id_User];
objDR[convBrowseInfoStatist.id_SystemModule] = objInFor[convBrowseInfoStatist.id_SystemModule];
objDR[convBrowseInfoStatist.ClassResourceID] = objInFor[convBrowseInfoStatist.ClassResourceID];
objDR[convBrowseInfoStatist.BrowseInfoStatistDate] = objInFor[convBrowseInfoStatist.BrowseInfoStatistDate];
objDR[convBrowseInfoStatist.BrowseInfoStatistTime] = objInFor[convBrowseInfoStatist.BrowseInfoStatistTime];
objDR[convBrowseInfoStatist.BrowseTypeId] = objInFor[convBrowseInfoStatist.BrowseTypeId];
objDR[convBrowseInfoStatist.BrowseSpendTime] = objInFor[convBrowseInfoStatist.BrowseSpendTime];
objDR[convBrowseInfoStatist.BrowseTypeName] = objInFor[convBrowseInfoStatist.BrowseTypeName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}