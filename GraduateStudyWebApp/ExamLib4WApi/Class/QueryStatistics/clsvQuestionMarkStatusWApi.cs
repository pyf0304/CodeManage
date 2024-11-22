
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionMarkStatusWApi
 表名:vQuestionMarkStatus(01120216)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:50
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计
 模块英文名:QueryStatistics
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
public static class clsvQuestionMarkStatusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN Setid_CurrEduCls(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convQuestionMarkStatus.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convQuestionMarkStatus.id_CurrEduCls);
objvQuestionMarkStatusEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.id_CurrEduCls) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.id_CurrEduCls, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.id_CurrEduCls] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetEduClsName(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convQuestionMarkStatus.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convQuestionMarkStatus.EduClsName);
objvQuestionMarkStatusEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.EduClsName) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.EduClsName, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.EduClsName] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetCourseId(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionMarkStatus.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionMarkStatus.CourseId);
objvQuestionMarkStatusEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.CourseId) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.CourseId, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.CourseId] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetCourseName(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionMarkStatus.CourseName);
objvQuestionMarkStatusEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.CourseName) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.CourseName, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.CourseName] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetCurrStuNum(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, int intCurrStuNum, string strComparisonOp="")
	{
objvQuestionMarkStatusEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.CurrStuNum) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.CurrStuNum, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.CurrStuNum] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetSubmitedNum(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, int intSubmitedNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSubmitedNum, convQuestionMarkStatus.SubmitedNum);
objvQuestionMarkStatusEN.SubmitedNum = intSubmitedNum; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.SubmitedNum) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.SubmitedNum, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.SubmitedNum] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetAllQuestionNum(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, int intAllQuestionNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAllQuestionNum, convQuestionMarkStatus.AllQuestionNum);
objvQuestionMarkStatusEN.AllQuestionNum = intAllQuestionNum; //所有题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.AllQuestionNum) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.AllQuestionNum, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.AllQuestionNum] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetAllStuQuestionNum(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, int intAllStuQuestionNum, string strComparisonOp="")
	{
objvQuestionMarkStatusEN.AllStuQuestionNum = intAllStuQuestionNum; //所有学生作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.AllStuQuestionNum) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.AllStuQuestionNum, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.AllStuQuestionNum] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetMarkedNum(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, int intMarkedNum, string strComparisonOp="")
	{
objvQuestionMarkStatusEN.MarkedNum = intMarkedNum; //已批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.MarkedNum) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.MarkedNum, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.MarkedNum] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionMarkStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionMarkStatusEN SetNoMarkNum(this clsvQuestionMarkStatusEN objvQuestionMarkStatusEN, int intNoMarkNum, string strComparisonOp="")
	{
objvQuestionMarkStatusEN.NoMarkNum = intNoMarkNum; //未批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionMarkStatusEN.dicFldComparisonOp.ContainsKey(convQuestionMarkStatus.NoMarkNum) == false)
{
objvQuestionMarkStatusEN.dicFldComparisonOp.Add(convQuestionMarkStatus.NoMarkNum, strComparisonOp);
}
else
{
objvQuestionMarkStatusEN.dicFldComparisonOp[convQuestionMarkStatus.NoMarkNum] = strComparisonOp;
}
}
return objvQuestionMarkStatusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionMarkStatusEN objvQuestionMarkStatus_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionMarkStatus.id_CurrEduCls, objvQuestionMarkStatus_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionMarkStatus.EduClsName, objvQuestionMarkStatus_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionMarkStatus.CourseId, objvQuestionMarkStatus_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.CourseName) == true)
{
string strComparisonOp_CourseName = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionMarkStatus.CourseName, objvQuestionMarkStatus_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionMarkStatus.CurrStuNum, objvQuestionMarkStatus_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.SubmitedNum) == true)
{
string strComparisonOp_SubmitedNum = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.SubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionMarkStatus.SubmitedNum, objvQuestionMarkStatus_Cond.SubmitedNum, strComparisonOp_SubmitedNum);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.AllQuestionNum) == true)
{
string strComparisonOp_AllQuestionNum = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.AllQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionMarkStatus.AllQuestionNum, objvQuestionMarkStatus_Cond.AllQuestionNum, strComparisonOp_AllQuestionNum);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.AllStuQuestionNum) == true)
{
string strComparisonOp_AllStuQuestionNum = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.AllStuQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionMarkStatus.AllStuQuestionNum, objvQuestionMarkStatus_Cond.AllStuQuestionNum, strComparisonOp_AllStuQuestionNum);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.MarkedNum) == true)
{
string strComparisonOp_MarkedNum = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.MarkedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionMarkStatus.MarkedNum, objvQuestionMarkStatus_Cond.MarkedNum, strComparisonOp_MarkedNum);
}
if (objvQuestionMarkStatus_Cond.IsUpdated(convQuestionMarkStatus.NoMarkNum) == true)
{
string strComparisonOp_NoMarkNum = objvQuestionMarkStatus_Cond.dicFldComparisonOp[convQuestionMarkStatus.NoMarkNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionMarkStatus.NoMarkNum, objvQuestionMarkStatus_Cond.NoMarkNum, strComparisonOp_NoMarkNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目打分状态(vQuestionMarkStatus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionMarkStatusWApi
{
private static readonly string mstrApiControllerName = "vQuestionMarkStatusApi";

 public clsvQuestionMarkStatusWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionMarkStatusEN GetObjByid_CurrEduCls(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionMarkStatusEN objvQuestionMarkStatusEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionMarkStatusEN = JsonConvert.DeserializeObject<clsvQuestionMarkStatusEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionMarkStatusEN;
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
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionMarkStatusEN GetObjByid_CurrEduCls_WA_Cache(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionMarkStatusEN objvQuestionMarkStatusEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionMarkStatusEN = JsonConvert.DeserializeObject<clsvQuestionMarkStatusEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionMarkStatusEN;
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
public static clsvQuestionMarkStatusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionMarkStatusEN objvQuestionMarkStatusEN = null;
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
objvQuestionMarkStatusEN = JsonConvert.DeserializeObject<clsvQuestionMarkStatusEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionMarkStatusEN;
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionMarkStatusEN GetObjByid_CurrEduCls_Cache(string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionMarkStatusEN._CurrTabName_S);
List<clsvQuestionMarkStatusEN> arrvQuestionMarkStatusObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionMarkStatusEN> arrvQuestionMarkStatusObjLst_Sel =
from objvQuestionMarkStatusEN in arrvQuestionMarkStatusObjLst_Cache
where objvQuestionMarkStatusEN.id_CurrEduCls == strid_CurrEduCls
select objvQuestionMarkStatusEN;
if (arrvQuestionMarkStatusObjLst_Sel.Count() == 0)
{
   clsvQuestionMarkStatusEN obj = clsvQuestionMarkStatusWApi.GetObjByid_CurrEduCls(strid_CurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionMarkStatusObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionMarkStatusEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionMarkStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionMarkStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionMarkStatusEN> GetObjLstById_CurrEduClsLst(List<string> arrId_CurrEduCls)
{
 List<clsvQuestionMarkStatusEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionMarkStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionMarkStatusEN> GetObjLstById_CurrEduClsLst_Cache(List<string> arrId_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionMarkStatusEN._CurrTabName_S);
List<clsvQuestionMarkStatusEN> arrvQuestionMarkStatusObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionMarkStatusEN> arrvQuestionMarkStatusObjLst_Sel =
from objvQuestionMarkStatusEN in arrvQuestionMarkStatusObjLst_Cache
where arrId_CurrEduCls.Contains(objvQuestionMarkStatusEN.id_CurrEduCls)
select objvQuestionMarkStatusEN;
return arrvQuestionMarkStatusObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionMarkStatusEN> GetObjLstById_CurrEduClsLst_WA_Cache(List<string> arrId_CurrEduCls)
{
 List<clsvQuestionMarkStatusEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionMarkStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionMarkStatusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionMarkStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionMarkStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionMarkStatusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionMarkStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionMarkStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionMarkStatusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionMarkStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionMarkStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionMarkStatusEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionMarkStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionMarkStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_CurrEduCls)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
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
 /// <param name = "objvQuestionMarkStatusENS">源对象</param>
 /// <param name = "objvQuestionMarkStatusENT">目标对象</param>
 public static void CopyTo(clsvQuestionMarkStatusEN objvQuestionMarkStatusENS, clsvQuestionMarkStatusEN objvQuestionMarkStatusENT)
{
try
{
objvQuestionMarkStatusENT.id_CurrEduCls = objvQuestionMarkStatusENS.id_CurrEduCls; //当前教学班流水号
objvQuestionMarkStatusENT.EduClsName = objvQuestionMarkStatusENS.EduClsName; //教学班名称
objvQuestionMarkStatusENT.CourseId = objvQuestionMarkStatusENS.CourseId; //课程Id
objvQuestionMarkStatusENT.CourseName = objvQuestionMarkStatusENS.CourseName; //课程名称
objvQuestionMarkStatusENT.CurrStuNum = objvQuestionMarkStatusENS.CurrStuNum; //当前学生数
objvQuestionMarkStatusENT.SubmitedNum = objvQuestionMarkStatusENS.SubmitedNum; //提交作业数
objvQuestionMarkStatusENT.AllQuestionNum = objvQuestionMarkStatusENS.AllQuestionNum; //所有题目数
objvQuestionMarkStatusENT.AllStuQuestionNum = objvQuestionMarkStatusENS.AllStuQuestionNum; //所有学生作业数
objvQuestionMarkStatusENT.MarkedNum = objvQuestionMarkStatusENS.MarkedNum; //已批改数
objvQuestionMarkStatusENT.NoMarkNum = objvQuestionMarkStatusENS.NoMarkNum; //未批改数
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
public static DataTable ToDataTable(List<clsvQuestionMarkStatusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionMarkStatusEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionMarkStatusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionMarkStatusEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionMarkStatusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionMarkStatusEN.AttributeName)
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
if (clsQuestionMarkStatusWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionMarkStatusWApi没有刷新缓存机制(clsQuestionMarkStatusWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_EduClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_EduClsTypeWApi没有刷新缓存机制(clsgs_EduClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingSolutionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionWApi没有刷新缓存机制(clsTeachingSolutionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CurrEduCls");
//if (arrvQuestionMarkStatusObjLst_Cache == null)
//{
//arrvQuestionMarkStatusObjLst_Cache = await clsvQuestionMarkStatusWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQuestionMarkStatusEN._CurrTabName_S);
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
public static List<clsvQuestionMarkStatusEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionMarkStatusEN._CurrTabName_S);
List<clsvQuestionMarkStatusEN> arrvQuestionMarkStatusObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionMarkStatusObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionMarkStatusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionMarkStatus.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionMarkStatus.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionMarkStatus.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionMarkStatus.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionMarkStatus.CurrStuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionMarkStatus.SubmitedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionMarkStatus.AllQuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionMarkStatus.AllStuQuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionMarkStatus.MarkedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionMarkStatus.NoMarkNum, Type.GetType("System.Int32"));
foreach (clsvQuestionMarkStatusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionMarkStatus.id_CurrEduCls] = objInFor[convQuestionMarkStatus.id_CurrEduCls];
objDR[convQuestionMarkStatus.EduClsName] = objInFor[convQuestionMarkStatus.EduClsName];
objDR[convQuestionMarkStatus.CourseId] = objInFor[convQuestionMarkStatus.CourseId];
objDR[convQuestionMarkStatus.CourseName] = objInFor[convQuestionMarkStatus.CourseName];
objDR[convQuestionMarkStatus.CurrStuNum] = objInFor[convQuestionMarkStatus.CurrStuNum];
objDR[convQuestionMarkStatus.SubmitedNum] = objInFor[convQuestionMarkStatus.SubmitedNum];
objDR[convQuestionMarkStatus.AllQuestionNum] = objInFor[convQuestionMarkStatus.AllQuestionNum];
objDR[convQuestionMarkStatus.AllStuQuestionNum] = objInFor[convQuestionMarkStatus.AllStuQuestionNum];
objDR[convQuestionMarkStatus.MarkedNum] = objInFor[convQuestionMarkStatus.MarkedNum];
objDR[convQuestionMarkStatus.NoMarkNum] = objInFor[convQuestionMarkStatus.NoMarkNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}