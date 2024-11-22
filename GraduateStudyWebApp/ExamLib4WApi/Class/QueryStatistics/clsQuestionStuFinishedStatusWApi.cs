
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionStuFinishedStatusWApi
 表名:QuestionStuFinishedStatus(01120217)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:34
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
public static class clsQuestionStuFinishedStatusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN SetmId(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, long lngmId, string strComparisonOp="")
	{
objQuestionStuFinishedStatusEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.mId) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.mId, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.mId] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN Setid_CurrEduCls(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, conQuestionStuFinishedStatus.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conQuestionStuFinishedStatus.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conQuestionStuFinishedStatus.id_CurrEduCls);
objQuestionStuFinishedStatusEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.id_CurrEduCls) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.id_CurrEduCls, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.id_CurrEduCls] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN Setid_StudentInfo(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, conQuestionStuFinishedStatus.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, conQuestionStuFinishedStatus.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, conQuestionStuFinishedStatus.id_StudentInfo);
objQuestionStuFinishedStatusEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.id_StudentInfo) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.id_StudentInfo, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.id_StudentInfo] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN SetSubmitedNum(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, int intSubmitedNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSubmitedNum, conQuestionStuFinishedStatus.SubmitedNum);
objQuestionStuFinishedStatusEN.SubmitedNum = intSubmitedNum; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.SubmitedNum) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.SubmitedNum, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.SubmitedNum] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN SetAllQuestionNum(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, int intAllQuestionNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAllQuestionNum, conQuestionStuFinishedStatus.AllQuestionNum);
objQuestionStuFinishedStatusEN.AllQuestionNum = intAllQuestionNum; //所有题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.AllQuestionNum) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.AllQuestionNum, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.AllQuestionNum] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN SetMarkedNum(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, int intMarkedNum, string strComparisonOp="")
	{
objQuestionStuFinishedStatusEN.MarkedNum = intMarkedNum; //已批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.MarkedNum) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.MarkedNum, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.MarkedNum] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN SetNoMarkNum(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, int intNoMarkNum, string strComparisonOp="")
	{
objQuestionStuFinishedStatusEN.NoMarkNum = intNoMarkNum; //未批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.NoMarkNum) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.NoMarkNum, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.NoMarkNum] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionStuFinishedStatusEN SetNoSubmitedNum(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, int intNoSubmitedNum, string strComparisonOp="")
	{
objQuestionStuFinishedStatusEN.NoSubmitedNum = intNoSubmitedNum; //未提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(conQuestionStuFinishedStatus.NoSubmitedNum) == false)
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(conQuestionStuFinishedStatus.NoSubmitedNum, strComparisonOp);
}
else
{
objQuestionStuFinishedStatusEN.dicFldComparisonOp[conQuestionStuFinishedStatus.NoSubmitedNum] = strComparisonOp;
}
}
return objQuestionStuFinishedStatusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatus_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.mId) == true)
{
string strComparisonOp_mId = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionStuFinishedStatus.mId, objQuestionStuFinishedStatus_Cond.mId, strComparisonOp_mId);
}
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionStuFinishedStatus.id_CurrEduCls, objQuestionStuFinishedStatus_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionStuFinishedStatus.id_StudentInfo, objQuestionStuFinishedStatus_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.SubmitedNum) == true)
{
string strComparisonOp_SubmitedNum = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.SubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionStuFinishedStatus.SubmitedNum, objQuestionStuFinishedStatus_Cond.SubmitedNum, strComparisonOp_SubmitedNum);
}
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.AllQuestionNum) == true)
{
string strComparisonOp_AllQuestionNum = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.AllQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionStuFinishedStatus.AllQuestionNum, objQuestionStuFinishedStatus_Cond.AllQuestionNum, strComparisonOp_AllQuestionNum);
}
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.MarkedNum) == true)
{
string strComparisonOp_MarkedNum = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.MarkedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionStuFinishedStatus.MarkedNum, objQuestionStuFinishedStatus_Cond.MarkedNum, strComparisonOp_MarkedNum);
}
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.NoMarkNum) == true)
{
string strComparisonOp_NoMarkNum = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.NoMarkNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionStuFinishedStatus.NoMarkNum, objQuestionStuFinishedStatus_Cond.NoMarkNum, strComparisonOp_NoMarkNum);
}
if (objQuestionStuFinishedStatus_Cond.IsUpdated(conQuestionStuFinishedStatus.NoSubmitedNum) == true)
{
string strComparisonOp_NoSubmitedNum = objQuestionStuFinishedStatus_Cond.dicFldComparisonOp[conQuestionStuFinishedStatus.NoSubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionStuFinishedStatus.NoSubmitedNum, objQuestionStuFinishedStatus_Cond.NoSubmitedNum, strComparisonOp_NoSubmitedNum);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN)
{
 if (objQuestionStuFinishedStatusEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionStuFinishedStatusEN.sf_UpdFldSetStr = objQuestionStuFinishedStatusEN.getsf_UpdFldSetStr();
clsQuestionStuFinishedStatusWApi.CheckPropertyNew(objQuestionStuFinishedStatusEN); 
bool bolResult = clsQuestionStuFinishedStatusWApi.UpdateRecord(objQuestionStuFinishedStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionStuFinishedStatusWApi.ReFreshCache(objQuestionStuFinishedStatusEN.id_CurrEduCls);
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
 /// 检查唯一性(Uniqueness)--QuestionStuFinishedStatus(题目学生完成状态), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_id_StudentInfo(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionStuFinishedStatusEN == null) return "";
if (objQuestionStuFinishedStatusEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objQuestionStuFinishedStatusEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objQuestionStuFinishedStatusEN.id_StudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objQuestionStuFinishedStatusEN.mId);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objQuestionStuFinishedStatusEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objQuestionStuFinishedStatusEN.id_StudentInfo);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionStuFinishedStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN)
{
try
{
clsQuestionStuFinishedStatusWApi.CheckPropertyNew(objQuestionStuFinishedStatusEN); 
bool bolResult = clsQuestionStuFinishedStatusWApi.AddNewRecord(objQuestionStuFinishedStatusEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionStuFinishedStatusWApi.ReFreshCache(objQuestionStuFinishedStatusEN.id_CurrEduCls);
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
 /// <param name = "objQuestionStuFinishedStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, string strWhereCond)
{
try
{
clsQuestionStuFinishedStatusWApi.CheckPropertyNew(objQuestionStuFinishedStatusEN); 
bool bolResult = clsQuestionStuFinishedStatusWApi.UpdateWithCondition(objQuestionStuFinishedStatusEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionStuFinishedStatusWApi.ReFreshCache(objQuestionStuFinishedStatusEN.id_CurrEduCls);
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
 /// 题目学生完成状态(QuestionStuFinishedStatus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionStuFinishedStatusWApi
{
private static readonly string mstrApiControllerName = "QuestionStuFinishedStatusApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsQuestionStuFinishedStatusWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN)
{
if (!Object.Equals(null, objQuestionStuFinishedStatusEN.id_CurrEduCls) && GetStrLen(objQuestionStuFinishedStatusEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionStuFinishedStatusEN.id_StudentInfo) && GetStrLen(objQuestionStuFinishedStatusEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
 objQuestionStuFinishedStatusEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionStuFinishedStatusEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN = null;
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
objQuestionStuFinishedStatusEN = JsonConvert.DeserializeObject<clsQuestionStuFinishedStatusEN>((string)jobjReturn["ReturnObj"]);
return objQuestionStuFinishedStatusEN;
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
public static clsQuestionStuFinishedStatusEN GetObjBymId_WA_Cache(long lngmId, string strid_CurrEduCls)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionStuFinishedStatusEN = JsonConvert.DeserializeObject<clsQuestionStuFinishedStatusEN>((string)jobjReturn["ReturnObj"]);
return objQuestionStuFinishedStatusEN;
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
public static clsQuestionStuFinishedStatusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN = null;
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
objQuestionStuFinishedStatusEN = JsonConvert.DeserializeObject<clsQuestionStuFinishedStatusEN>((string)jobjReturn["ReturnObj"]);
return objQuestionStuFinishedStatusEN;
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
public static clsQuestionStuFinishedStatusEN GetObjBymId_Cache(long lngmId, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionStuFinishedStatusEN._CurrTabName_S, strid_CurrEduCls);
List<clsQuestionStuFinishedStatusEN> arrQuestionStuFinishedStatusObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsQuestionStuFinishedStatusEN> arrQuestionStuFinishedStatusObjLst_Sel =
from objQuestionStuFinishedStatusEN in arrQuestionStuFinishedStatusObjLst_Cache
where objQuestionStuFinishedStatusEN.mId == lngmId
select objQuestionStuFinishedStatusEN;
if (arrQuestionStuFinishedStatusObjLst_Sel.Count() == 0)
{
   clsQuestionStuFinishedStatusEN obj = clsQuestionStuFinishedStatusWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionStuFinishedStatusObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionStuFinishedStatusEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionStuFinishedStatusEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsQuestionStuFinishedStatusEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionStuFinishedStatusEN._CurrTabName_S, strid_CurrEduCls);
List<clsQuestionStuFinishedStatusEN> arrQuestionStuFinishedStatusObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsQuestionStuFinishedStatusEN> arrQuestionStuFinishedStatusObjLst_Sel =
from objQuestionStuFinishedStatusEN in arrQuestionStuFinishedStatusObjLst_Cache
where arrMId.Contains(objQuestionStuFinishedStatusEN.mId)
select objQuestionStuFinishedStatusEN;
return arrQuestionStuFinishedStatusObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionStuFinishedStatusEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strid_CurrEduCls)
{
 List<clsQuestionStuFinishedStatusEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionStuFinishedStatusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionStuFinishedStatusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionStuFinishedStatusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionStuFinishedStatusEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN = clsQuestionStuFinishedStatusWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionStuFinishedStatusWApi.ReFreshCache(objQuestionStuFinishedStatusEN.id_CurrEduCls);
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
public static int DelQuestionStuFinishedStatuss(List<string> arrmId)
{
string strAction = "DelQuestionStuFinishedStatuss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN = clsQuestionStuFinishedStatusWApi.GetObjBymId(long.Parse(arrmId[0]));
clsQuestionStuFinishedStatusWApi.ReFreshCache(objQuestionStuFinishedStatusEN.id_CurrEduCls);
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
public static int DelQuestionStuFinishedStatussByCond(string strWhereCond)
{
string strAction = "DelQuestionStuFinishedStatussByCond";
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
public static bool AddNewRecord(clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionStuFinishedStatusEN>(objQuestionStuFinishedStatusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionStuFinishedStatusWApi.ReFreshCache(objQuestionStuFinishedStatusEN.id_CurrEduCls);
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
 /// <param name = "objQuestionStuFinishedStatusEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionStuFinishedStatusEN>(objQuestionStuFinishedStatusEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionStuFinishedStatusWApi.ReFreshCache(objQuestionStuFinishedStatusEN.id_CurrEduCls);
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
public static bool UpdateRecord(clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN)
{
if (string.IsNullOrEmpty(objQuestionStuFinishedStatusEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionStuFinishedStatusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionStuFinishedStatusEN>(objQuestionStuFinishedStatusEN);
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
 /// <param name = "objQuestionStuFinishedStatusEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionStuFinishedStatusEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionStuFinishedStatusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionStuFinishedStatusEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionStuFinishedStatusEN>(objQuestionStuFinishedStatusEN);
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
 /// <param name = "objQuestionStuFinishedStatusENS">源对象</param>
 /// <param name = "objQuestionStuFinishedStatusENT">目标对象</param>
 public static void CopyTo(clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusENS, clsQuestionStuFinishedStatusEN objQuestionStuFinishedStatusENT)
{
try
{
objQuestionStuFinishedStatusENT.mId = objQuestionStuFinishedStatusENS.mId; //mId
objQuestionStuFinishedStatusENT.id_CurrEduCls = objQuestionStuFinishedStatusENS.id_CurrEduCls; //当前教学班流水号
objQuestionStuFinishedStatusENT.id_StudentInfo = objQuestionStuFinishedStatusENS.id_StudentInfo; //学生流水号
objQuestionStuFinishedStatusENT.SubmitedNum = objQuestionStuFinishedStatusENS.SubmitedNum; //提交作业数
objQuestionStuFinishedStatusENT.AllQuestionNum = objQuestionStuFinishedStatusENS.AllQuestionNum; //所有题目数
objQuestionStuFinishedStatusENT.MarkedNum = objQuestionStuFinishedStatusENS.MarkedNum; //已批改数
objQuestionStuFinishedStatusENT.NoMarkNum = objQuestionStuFinishedStatusENS.NoMarkNum; //未批改数
objQuestionStuFinishedStatusENT.NoSubmitedNum = objQuestionStuFinishedStatusENS.NoSubmitedNum; //未提交作业数
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
public static DataTable ToDataTable(List<clsQuestionStuFinishedStatusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionStuFinishedStatusEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionStuFinishedStatusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionStuFinishedStatusEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionStuFinishedStatusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionStuFinishedStatusEN.AttributeName)
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
if (clsQuestionStuFinishedStatusWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionStuFinishedStatusWApi没有刷新缓存机制(clsQuestionStuFinishedStatusWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrQuestionStuFinishedStatusObjLst_Cache == null)
//{
//arrQuestionStuFinishedStatusObjLst_Cache = await clsQuestionStuFinishedStatusWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strid_CurrEduCls = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsQuestionStuFinishedStatusEN._CurrTabName_S, strid_CurrEduCls);
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
public static void ReFreshCache(string strid_CurrEduCls)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQuestionStuFinishedStatusWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQuestionStuFinishedStatusEN._CurrTabName_S, strid_CurrEduCls);
CacheHelper.Remove(strKey);
clsQuestionStuFinishedStatusWApi.objCommFun4BL.ReFreshCache(strid_CurrEduCls);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionStuFinishedStatusEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsQuestionStuFinishedStatusEN._CurrTabName_S, strid_CurrEduCls);
List<clsQuestionStuFinishedStatusEN> arrQuestionStuFinishedStatusObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrQuestionStuFinishedStatusObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionStuFinishedStatusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionStuFinishedStatus.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conQuestionStuFinishedStatus.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionStuFinishedStatus.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionStuFinishedStatus.SubmitedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionStuFinishedStatus.AllQuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionStuFinishedStatus.MarkedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionStuFinishedStatus.NoMarkNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionStuFinishedStatus.NoSubmitedNum, Type.GetType("System.Int32"));
foreach (clsQuestionStuFinishedStatusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionStuFinishedStatus.mId] = objInFor[conQuestionStuFinishedStatus.mId];
objDR[conQuestionStuFinishedStatus.id_CurrEduCls] = objInFor[conQuestionStuFinishedStatus.id_CurrEduCls];
objDR[conQuestionStuFinishedStatus.id_StudentInfo] = objInFor[conQuestionStuFinishedStatus.id_StudentInfo];
objDR[conQuestionStuFinishedStatus.SubmitedNum] = objInFor[conQuestionStuFinishedStatus.SubmitedNum];
objDR[conQuestionStuFinishedStatus.AllQuestionNum] = objInFor[conQuestionStuFinishedStatus.AllQuestionNum];
objDR[conQuestionStuFinishedStatus.MarkedNum] = objInFor[conQuestionStuFinishedStatus.MarkedNum];
objDR[conQuestionStuFinishedStatus.NoMarkNum] = objInFor[conQuestionStuFinishedStatus.NoMarkNum];
objDR[conQuestionStuFinishedStatus.NoSubmitedNum] = objInFor[conQuestionStuFinishedStatus.NoSubmitedNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 题目学生完成状态(QuestionStuFinishedStatus)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QuestionStuFinishedStatus : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strid_CurrEduCls)
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
clsQuestionStuFinishedStatusWApi.ReFreshThisCache(strid_CurrEduCls);
clsvQuestionStuFinishedStatusWApi.ReFreshThisCache(strid_CurrEduCls);
}
}

}