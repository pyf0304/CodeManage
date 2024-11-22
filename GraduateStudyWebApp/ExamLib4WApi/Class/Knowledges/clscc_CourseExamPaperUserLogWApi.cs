
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperUserLogWApi
 表名:cc_CourseExamPaperUserLog(01120090)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:54
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clscc_CourseExamPaperUserLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetmId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, long lngmId, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.mId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.mId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.mId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetCreateTime(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, DateTime dteCreateTime, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.CreateTime = dteCreateTime; //CreateTime
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.CreateTime) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.CreateTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.CreateTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetCourseExamPaperId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_CourseExamPaperUserLog.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_CourseExamPaperUserLog.CourseExamPaperId);
objcc_CourseExamPaperUserLogEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.CourseExamPaperId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetExamsTrueCount(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, int intExamsTrueCount, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.ExamsTrueCount = intExamsTrueCount; //正确题目数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.ExamsTrueCount) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.ExamsTrueCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsTrueCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetExamsFalseCount(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, int intExamsFalseCount, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.ExamsFalseCount = intExamsFalseCount; //错误题目数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.ExamsFalseCount) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.ExamsFalseCount, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsFalseCount] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetUserId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, concc_CourseExamPaperUserLog.UserId);
objcc_CourseExamPaperUserLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.UserId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.UserId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.UserId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetCourseId(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseExamPaperUserLog.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseExamPaperUserLog.CourseId);
objcc_CourseExamPaperUserLogEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.CourseId) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.CourseId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserLogEN SetTotalScore(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, double dblTotalScore, string strComparisonOp="")
	{
objcc_CourseExamPaperUserLogEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserLog.TotalScore) == false)
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserLog.TotalScore, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserLogEN.dicFldComparisonOp[concc_CourseExamPaperUserLog.TotalScore] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.mId) == true)
{
string strComparisonOp_mId = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.mId, objcc_CourseExamPaperUserLog_Cond.mId, strComparisonOp_mId);
}
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.CreateTime) == true)
{
string strComparisonOp_CreateTime = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.CreateTime, objcc_CourseExamPaperUserLog_Cond.CreateTime, strComparisonOp_CreateTime);
}
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.CourseExamPaperId, objcc_CourseExamPaperUserLog_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.ExamsTrueCount) == true)
{
string strComparisonOp_ExamsTrueCount = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsTrueCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.ExamsTrueCount, objcc_CourseExamPaperUserLog_Cond.ExamsTrueCount, strComparisonOp_ExamsTrueCount);
}
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.ExamsFalseCount) == true)
{
string strComparisonOp_ExamsFalseCount = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.ExamsFalseCount];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.ExamsFalseCount, objcc_CourseExamPaperUserLog_Cond.ExamsFalseCount, strComparisonOp_ExamsFalseCount);
}
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.UserId) == true)
{
string strComparisonOp_UserId = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.UserId, objcc_CourseExamPaperUserLog_Cond.UserId, strComparisonOp_UserId);
}
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserLog.CourseId, objcc_CourseExamPaperUserLog_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_CourseExamPaperUserLog_Cond.IsUpdated(concc_CourseExamPaperUserLog.TotalScore) == true)
{
string strComparisonOp_TotalScore = objcc_CourseExamPaperUserLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserLog.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserLog.TotalScore, objcc_CourseExamPaperUserLog_Cond.TotalScore, strComparisonOp_TotalScore);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
 if (objcc_CourseExamPaperUserLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseExamPaperUserLogEN.sf_UpdFldSetStr = objcc_CourseExamPaperUserLogEN.getsf_UpdFldSetStr();
clscc_CourseExamPaperUserLogWApi.CheckPropertyNew(objcc_CourseExamPaperUserLogEN); 
bool bolResult = clscc_CourseExamPaperUserLogWApi.UpdateRecord(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogWApi.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--cc_CourseExamPaperUserLog(学生答试卷日志), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_UserId_CourseExamPaperId_CreateTime(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperUserLogEN == null) return "";
if (objcc_CourseExamPaperUserLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserLogEN.UserId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and CreateTime = '{0}'", objcc_CourseExamPaperUserLogEN.CreateTime);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_CourseExamPaperUserLogEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserLogEN.UserId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserLogEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and CreateTime = '{0}'", objcc_CourseExamPaperUserLogEN.CreateTime);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
try
{
clscc_CourseExamPaperUserLogWApi.CheckPropertyNew(objcc_CourseExamPaperUserLogEN); 
bool bolResult = clscc_CourseExamPaperUserLogWApi.AddNewRecord(objcc_CourseExamPaperUserLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogWApi.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strWhereCond)
{
try
{
clscc_CourseExamPaperUserLogWApi.CheckPropertyNew(objcc_CourseExamPaperUserLogEN); 
bool bolResult = clscc_CourseExamPaperUserLogWApi.UpdateWithCondition(objcc_CourseExamPaperUserLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogWApi.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
 /// 学生答试卷日志(cc_CourseExamPaperUserLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseExamPaperUserLogWApi
{
private static readonly string mstrApiControllerName = "cc_CourseExamPaperUserLogApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_CourseExamPaperUserLogWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
if (!Object.Equals(null, objcc_CourseExamPaperUserLogEN.CourseExamPaperId) && GetStrLen(objcc_CourseExamPaperUserLogEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperUserLogEN.UserId) && GetStrLen(objcc_CourseExamPaperUserLogEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_CourseExamPaperUserLogEN.CourseId) && GetStrLen(objcc_CourseExamPaperUserLogEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
 objcc_CourseExamPaperUserLogEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperUserLogEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = null;
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
objcc_CourseExamPaperUserLogEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperUserLogEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperUserLogEN;
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
public static clscc_CourseExamPaperUserLogEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_CourseExamPaperUserLogEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperUserLogEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperUserLogEN;
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
public static clscc_CourseExamPaperUserLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = null;
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
objcc_CourseExamPaperUserLogEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperUserLogEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperUserLogEN;
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
public static clscc_CourseExamPaperUserLogEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLst_Sel =
from objcc_CourseExamPaperUserLogEN in arrcc_CourseExamPaperUserLogObjLst_Cache
where objcc_CourseExamPaperUserLogEN.mId == lngmId
select objcc_CourseExamPaperUserLogEN;
if (arrcc_CourseExamPaperUserLogObjLst_Sel.Count() == 0)
{
   clscc_CourseExamPaperUserLogEN obj = clscc_CourseExamPaperUserLogWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseExamPaperUserLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseExamPaperUserLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clscc_CourseExamPaperUserLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_CourseExamPaperUserLogEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLst_Sel =
from objcc_CourseExamPaperUserLogEN in arrcc_CourseExamPaperUserLogObjLst_Cache
where arrMId.Contains(objcc_CourseExamPaperUserLogEN.mId)
select objcc_CourseExamPaperUserLogEN;
return arrcc_CourseExamPaperUserLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clscc_CourseExamPaperUserLogEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseExamPaperUserLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseExamPaperUserLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperUserLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperUserLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = clscc_CourseExamPaperUserLogWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseExamPaperUserLogWApi.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
public static int Delcc_CourseExamPaperUserLogs(List<string> arrmId)
{
string strAction = "Delcc_CourseExamPaperUserLogs";
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
 clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN = clscc_CourseExamPaperUserLogWApi.GetObjBymId(long.Parse(arrmId[0]));
clscc_CourseExamPaperUserLogWApi.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
public static int Delcc_CourseExamPaperUserLogsByCond(string strWhereCond)
{
string strAction = "Delcc_CourseExamPaperUserLogsByCond";
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
public static bool AddNewRecord(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserLogEN>(objcc_CourseExamPaperUserLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogWApi.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserLogEN>(objcc_CourseExamPaperUserLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserLogWApi.ReFreshCache(objcc_CourseExamPaperUserLogEN.CourseId);
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
public static bool UpdateRecord(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperUserLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperUserLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserLogEN>(objcc_CourseExamPaperUserLogEN);
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
 /// <param name = "objcc_CourseExamPaperUserLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperUserLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperUserLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperUserLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserLogEN>(objcc_CourseExamPaperUserLogEN);
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
 /// <param name = "objcc_CourseExamPaperUserLogENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperUserLogENT">目标对象</param>
 public static void CopyTo(clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENS, clscc_CourseExamPaperUserLogEN objcc_CourseExamPaperUserLogENT)
{
try
{
objcc_CourseExamPaperUserLogENT.mId = objcc_CourseExamPaperUserLogENS.mId; //mId
objcc_CourseExamPaperUserLogENT.CreateTime = objcc_CourseExamPaperUserLogENS.CreateTime; //CreateTime
objcc_CourseExamPaperUserLogENT.CourseExamPaperId = objcc_CourseExamPaperUserLogENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperUserLogENT.ExamsTrueCount = objcc_CourseExamPaperUserLogENS.ExamsTrueCount; //正确题目数量
objcc_CourseExamPaperUserLogENT.ExamsFalseCount = objcc_CourseExamPaperUserLogENS.ExamsFalseCount; //错误题目数量
objcc_CourseExamPaperUserLogENT.UserId = objcc_CourseExamPaperUserLogENS.UserId; //用户ID
objcc_CourseExamPaperUserLogENT.CourseId = objcc_CourseExamPaperUserLogENS.CourseId; //课程Id
objcc_CourseExamPaperUserLogENT.TotalScore = objcc_CourseExamPaperUserLogENS.TotalScore; //总得分
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
public static DataTable ToDataTable(List<clscc_CourseExamPaperUserLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseExamPaperUserLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseExamPaperUserLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseExamPaperUserLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseExamPaperUserLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseExamPaperUserLogEN.AttributeName)
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
if (clscc_CourseExamPaperUserLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperUserLogWApi没有刷新缓存机制(clscc_CourseExamPaperUserLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_CourseExamPaperUserLogObjLst_Cache == null)
//{
//arrcc_CourseExamPaperUserLogObjLst_Cache = await clscc_CourseExamPaperUserLogWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clscc_CourseExamPaperUserLogWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperUserLogWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperUserLogEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserLogEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperUserLogEN> arrcc_CourseExamPaperUserLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_CourseExamPaperUserLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseExamPaperUserLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_CourseExamPaperUserLog.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_CourseExamPaperUserLog.CreateTime, Type.GetType("System.DateTime"));
objDT.Columns.Add(concc_CourseExamPaperUserLog.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserLog.ExamsTrueCount, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaperUserLog.ExamsFalseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_CourseExamPaperUserLog.UserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserLog.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserLog.TotalScore, Type.GetType("System.Decimal"));
foreach (clscc_CourseExamPaperUserLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_CourseExamPaperUserLog.mId] = objInFor[concc_CourseExamPaperUserLog.mId];
objDR[concc_CourseExamPaperUserLog.CreateTime] = objInFor[concc_CourseExamPaperUserLog.CreateTime];
objDR[concc_CourseExamPaperUserLog.CourseExamPaperId] = objInFor[concc_CourseExamPaperUserLog.CourseExamPaperId];
objDR[concc_CourseExamPaperUserLog.ExamsTrueCount] = objInFor[concc_CourseExamPaperUserLog.ExamsTrueCount];
objDR[concc_CourseExamPaperUserLog.ExamsFalseCount] = objInFor[concc_CourseExamPaperUserLog.ExamsFalseCount];
objDR[concc_CourseExamPaperUserLog.UserId] = objInFor[concc_CourseExamPaperUserLog.UserId];
objDR[concc_CourseExamPaperUserLog.CourseId] = objInFor[concc_CourseExamPaperUserLog.CourseId];
objDR[concc_CourseExamPaperUserLog.TotalScore] = objInFor[concc_CourseExamPaperUserLog.TotalScore];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生答试卷日志(cc_CourseExamPaperUserLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_CourseExamPaperUserLog : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clscc_CourseExamPaperUserLogWApi.ReFreshThisCache(strCourseId);
}
}

}