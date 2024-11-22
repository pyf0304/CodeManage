
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgesExamLibRelaWApi
 表名:cc_KnowledgesExamLibRela(01120140)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:47
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
public static class clscc_KnowledgesExamLibRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetmId(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, long lngmId, string strComparisonOp="")
	{
objcc_KnowledgesExamLibRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.mId) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.mId, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.mId] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetQuestionID(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_KnowledgesExamLibRela.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_KnowledgesExamLibRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_KnowledgesExamLibRela.QuestionID);
objcc_KnowledgesExamLibRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.QuestionID) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.QuestionID, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.QuestionID] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetCourseId(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_KnowledgesExamLibRela.CourseId);
objcc_KnowledgesExamLibRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.CourseId) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.CourseId, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.CourseId] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetPositiveCorrelation(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, double dblPositiveCorrelation, string strComparisonOp="")
	{
objcc_KnowledgesExamLibRelaEN.PositiveCorrelation = dblPositiveCorrelation; //正相关度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.PositiveCorrelation) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.PositiveCorrelation, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.PositiveCorrelation] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetCourseKnowledgeId(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeId, concc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.CourseKnowledgeId) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.CourseKnowledgeId, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.CourseKnowledgeId] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetNegativeCorrelation(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, double dblNegativeCorrelation, string strComparisonOp="")
	{
objcc_KnowledgesExamLibRelaEN.NegativeCorrelation = dblNegativeCorrelation; //负相关度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.NegativeCorrelation) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.NegativeCorrelation, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.NegativeCorrelation] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetUpdDate(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_KnowledgesExamLibRela.UpdDate);
objcc_KnowledgesExamLibRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.UpdDate) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.UpdDate, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.UpdDate] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetUpdUserId(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_KnowledgesExamLibRela.UpdUserId);
objcc_KnowledgesExamLibRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.UpdUserId) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.UpdUserId, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.UpdUserId] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_KnowledgesExamLibRelaEN SetMemo(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_KnowledgesExamLibRela.Memo);
objcc_KnowledgesExamLibRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.ContainsKey(concc_KnowledgesExamLibRela.Memo) == false)
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp.Add(concc_KnowledgesExamLibRela.Memo, strComparisonOp);
}
else
{
objcc_KnowledgesExamLibRelaEN.dicFldComparisonOp[concc_KnowledgesExamLibRela.Memo] = strComparisonOp;
}
}
return objcc_KnowledgesExamLibRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.mId) == true)
{
string strComparisonOp_mId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_KnowledgesExamLibRela.mId, objcc_KnowledgesExamLibRela_Cond.mId, strComparisonOp_mId);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgesExamLibRela.QuestionID, objcc_KnowledgesExamLibRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgesExamLibRela.CourseId, objcc_KnowledgesExamLibRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.PositiveCorrelation) == true)
{
string strComparisonOp_PositiveCorrelation = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.PositiveCorrelation];
strWhereCond += string.Format(" And {0} {2} {1}", concc_KnowledgesExamLibRela.PositiveCorrelation, objcc_KnowledgesExamLibRela_Cond.PositiveCorrelation, strComparisonOp_PositiveCorrelation);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgesExamLibRela.CourseKnowledgeId, objcc_KnowledgesExamLibRela_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.NegativeCorrelation) == true)
{
string strComparisonOp_NegativeCorrelation = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.NegativeCorrelation];
strWhereCond += string.Format(" And {0} {2} {1}", concc_KnowledgesExamLibRela.NegativeCorrelation, objcc_KnowledgesExamLibRela_Cond.NegativeCorrelation, strComparisonOp_NegativeCorrelation);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgesExamLibRela.UpdDate, objcc_KnowledgesExamLibRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgesExamLibRela.UpdUserId, objcc_KnowledgesExamLibRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_KnowledgesExamLibRela_Cond.IsUpdated(concc_KnowledgesExamLibRela.Memo) == true)
{
string strComparisonOp_Memo = objcc_KnowledgesExamLibRela_Cond.dicFldComparisonOp[concc_KnowledgesExamLibRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgesExamLibRela.Memo, objcc_KnowledgesExamLibRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
 if (objcc_KnowledgesExamLibRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr = objcc_KnowledgesExamLibRelaEN.getsf_UpdFldSetStr();
clscc_KnowledgesExamLibRelaWApi.CheckPropertyNew(objcc_KnowledgesExamLibRelaEN); 
bool bolResult = clscc_KnowledgesExamLibRelaWApi.UpdateRecord(objcc_KnowledgesExamLibRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgesExamLibRelaWApi.ReFreshCache(objcc_KnowledgesExamLibRelaEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--cc_KnowledgesExamLibRela(知识点习题关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseKnowledgeId_QuestionID(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_KnowledgesExamLibRelaEN == null) return "";
if (objcc_KnowledgesExamLibRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_KnowledgesExamLibRelaEN.QuestionID);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_KnowledgesExamLibRelaEN.mId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_KnowledgesExamLibRelaEN.QuestionID);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
try
{
clscc_KnowledgesExamLibRelaWApi.CheckPropertyNew(objcc_KnowledgesExamLibRelaEN); 
bool bolResult = clscc_KnowledgesExamLibRelaWApi.AddNewRecord(objcc_KnowledgesExamLibRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgesExamLibRelaWApi.ReFreshCache(objcc_KnowledgesExamLibRelaEN.CourseId);
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strWhereCond)
{
try
{
clscc_KnowledgesExamLibRelaWApi.CheckPropertyNew(objcc_KnowledgesExamLibRelaEN); 
bool bolResult = clscc_KnowledgesExamLibRelaWApi.UpdateWithCondition(objcc_KnowledgesExamLibRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgesExamLibRelaWApi.ReFreshCache(objcc_KnowledgesExamLibRelaEN.CourseId);
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
 /// 知识点习题关系(cc_KnowledgesExamLibRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_KnowledgesExamLibRelaWApi
{
private static readonly string mstrApiControllerName = "cc_KnowledgesExamLibRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_KnowledgesExamLibRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
if (!Object.Equals(null, objcc_KnowledgesExamLibRelaEN.QuestionID) && GetStrLen(objcc_KnowledgesExamLibRelaEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_KnowledgesExamLibRelaEN.CourseId) && GetStrLen(objcc_KnowledgesExamLibRelaEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId) && GetStrLen(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId) > 8)
{
 throw new Exception("字段[知识点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_KnowledgesExamLibRelaEN.UpdDate) && GetStrLen(objcc_KnowledgesExamLibRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_KnowledgesExamLibRelaEN.UpdUserId) && GetStrLen(objcc_KnowledgesExamLibRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_KnowledgesExamLibRelaEN.Memo) && GetStrLen(objcc_KnowledgesExamLibRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_KnowledgesExamLibRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_KnowledgesExamLibRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = null;
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
objcc_KnowledgesExamLibRelaEN = JsonConvert.DeserializeObject<clscc_KnowledgesExamLibRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_KnowledgesExamLibRelaEN;
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
public static clscc_KnowledgesExamLibRelaEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = null;
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
objcc_KnowledgesExamLibRelaEN = JsonConvert.DeserializeObject<clscc_KnowledgesExamLibRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_KnowledgesExamLibRelaEN;
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
public static clscc_KnowledgesExamLibRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = null;
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
objcc_KnowledgesExamLibRelaEN = JsonConvert.DeserializeObject<clscc_KnowledgesExamLibRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_KnowledgesExamLibRelaEN;
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
public static clscc_KnowledgesExamLibRelaEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
List<clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRelaObjLst_Sel =
from objcc_KnowledgesExamLibRelaEN in arrcc_KnowledgesExamLibRelaObjLst_Cache
where objcc_KnowledgesExamLibRelaEN.mId == lngmId
select objcc_KnowledgesExamLibRelaEN;
if (arrcc_KnowledgesExamLibRelaObjLst_Sel.Count() == 0)
{
   clscc_KnowledgesExamLibRelaEN obj = clscc_KnowledgesExamLibRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_KnowledgesExamLibRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgesExamLibRelaEN> GetObjLst(string strWhereCond)
{
 List<clscc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_KnowledgesExamLibRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clscc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_KnowledgesExamLibRelaEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
List<clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRelaObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRelaObjLst_Sel =
from objcc_KnowledgesExamLibRelaEN in arrcc_KnowledgesExamLibRelaObjLst_Cache
where arrMId.Contains(objcc_KnowledgesExamLibRelaEN.mId)
select objcc_KnowledgesExamLibRelaEN;
return arrcc_KnowledgesExamLibRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgesExamLibRelaEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clscc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_KnowledgesExamLibRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_KnowledgesExamLibRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_KnowledgesExamLibRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_KnowledgesExamLibRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_KnowledgesExamLibRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_KnowledgesExamLibRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = clscc_KnowledgesExamLibRelaWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_KnowledgesExamLibRelaWApi.ReFreshCache(objcc_KnowledgesExamLibRelaEN.CourseId);
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
public static int Delcc_KnowledgesExamLibRelas(List<string> arrmId)
{
string strAction = "Delcc_KnowledgesExamLibRelas";
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
 clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = clscc_KnowledgesExamLibRelaWApi.GetObjBymId(long.Parse(arrmId[0]));
clscc_KnowledgesExamLibRelaWApi.ReFreshCache(objcc_KnowledgesExamLibRelaEN.CourseId);
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
public static int Delcc_KnowledgesExamLibRelasByCond(string strWhereCond)
{
string strAction = "Delcc_KnowledgesExamLibRelasByCond";
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
public static bool AddNewRecord(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_KnowledgesExamLibRelaEN>(objcc_KnowledgesExamLibRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgesExamLibRelaWApi.ReFreshCache(objcc_KnowledgesExamLibRelaEN.CourseId);
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_KnowledgesExamLibRelaEN>(objcc_KnowledgesExamLibRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgesExamLibRelaWApi.ReFreshCache(objcc_KnowledgesExamLibRelaEN.CourseId);
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
public static bool UpdateRecord(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
if (string.IsNullOrEmpty(objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_KnowledgesExamLibRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_KnowledgesExamLibRelaEN>(objcc_KnowledgesExamLibRelaEN);
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_KnowledgesExamLibRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_KnowledgesExamLibRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_KnowledgesExamLibRelaEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_KnowledgesExamLibRelaEN>(objcc_KnowledgesExamLibRelaEN);
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
 /// <param name = "objcc_KnowledgesExamLibRelaENS">源对象</param>
 /// <param name = "objcc_KnowledgesExamLibRelaENT">目标对象</param>
 public static void CopyTo(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaENS, clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaENT)
{
try
{
objcc_KnowledgesExamLibRelaENT.mId = objcc_KnowledgesExamLibRelaENS.mId; //mId
objcc_KnowledgesExamLibRelaENT.QuestionID = objcc_KnowledgesExamLibRelaENS.QuestionID; //题目ID
objcc_KnowledgesExamLibRelaENT.CourseId = objcc_KnowledgesExamLibRelaENS.CourseId; //课程Id
objcc_KnowledgesExamLibRelaENT.PositiveCorrelation = objcc_KnowledgesExamLibRelaENS.PositiveCorrelation; //正相关度
objcc_KnowledgesExamLibRelaENT.CourseKnowledgeId = objcc_KnowledgesExamLibRelaENS.CourseKnowledgeId; //知识点Id
objcc_KnowledgesExamLibRelaENT.NegativeCorrelation = objcc_KnowledgesExamLibRelaENS.NegativeCorrelation; //负相关度
objcc_KnowledgesExamLibRelaENT.UpdDate = objcc_KnowledgesExamLibRelaENS.UpdDate; //修改日期
objcc_KnowledgesExamLibRelaENT.UpdUserId = objcc_KnowledgesExamLibRelaENS.UpdUserId; //修改用户Id
objcc_KnowledgesExamLibRelaENT.Memo = objcc_KnowledgesExamLibRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_KnowledgesExamLibRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_KnowledgesExamLibRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_KnowledgesExamLibRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_KnowledgesExamLibRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_KnowledgesExamLibRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_KnowledgesExamLibRelaEN.AttributeName)
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
if (clscc_KnowledgesExamLibRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_KnowledgesExamLibRelaWApi没有刷新缓存机制(clscc_KnowledgesExamLibRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_KnowledgesExamLibRelaObjLst_Cache == null)
//{
//arrcc_KnowledgesExamLibRelaObjLst_Cache = await clscc_KnowledgesExamLibRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clscc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
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
if (clscc_KnowledgesExamLibRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_KnowledgesExamLibRelaWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_KnowledgesExamLibRelaEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_KnowledgesExamLibRelaEN._CurrTabName_S, strCourseId);
List<clscc_KnowledgesExamLibRelaEN> arrcc_KnowledgesExamLibRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_KnowledgesExamLibRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_KnowledgesExamLibRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_KnowledgesExamLibRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.PositiveCorrelation, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.NegativeCorrelation, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_KnowledgesExamLibRela.Memo, Type.GetType("System.String"));
foreach (clscc_KnowledgesExamLibRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_KnowledgesExamLibRela.mId] = objInFor[concc_KnowledgesExamLibRela.mId];
objDR[concc_KnowledgesExamLibRela.QuestionID] = objInFor[concc_KnowledgesExamLibRela.QuestionID];
objDR[concc_KnowledgesExamLibRela.CourseId] = objInFor[concc_KnowledgesExamLibRela.CourseId];
objDR[concc_KnowledgesExamLibRela.PositiveCorrelation] = objInFor[concc_KnowledgesExamLibRela.PositiveCorrelation];
objDR[concc_KnowledgesExamLibRela.CourseKnowledgeId] = objInFor[concc_KnowledgesExamLibRela.CourseKnowledgeId];
objDR[concc_KnowledgesExamLibRela.NegativeCorrelation] = objInFor[concc_KnowledgesExamLibRela.NegativeCorrelation];
objDR[concc_KnowledgesExamLibRela.UpdDate] = objInFor[concc_KnowledgesExamLibRela.UpdDate];
objDR[concc_KnowledgesExamLibRela.UpdUserId] = objInFor[concc_KnowledgesExamLibRela.UpdUserId];
objDR[concc_KnowledgesExamLibRela.Memo] = objInFor[concc_KnowledgesExamLibRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 知识点习题关系(cc_KnowledgesExamLibRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_KnowledgesExamLibRela : clsCommFun4BLV2
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
clscc_KnowledgesExamLibRelaWApi.ReFreshThisCache(strCourseId);
clsvcc_KnowledgesExamLibRelaWApi.ReFreshThisCache(strCourseId);
}
}

}