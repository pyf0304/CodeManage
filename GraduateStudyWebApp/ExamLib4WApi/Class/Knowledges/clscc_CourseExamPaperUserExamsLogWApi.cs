
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseExamPaperUserExamsLogWApi
 表名:cc_CourseExamPaperUserExamsLog(01120091)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:30
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
public static class clscc_CourseExamPaperUserExamsLogWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetmId(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, long lngmId, string strComparisonOp="")
	{
objcc_CourseExamPaperUserExamsLogEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.mId) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.mId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.mId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetCourseExamPaperId(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_CourseExamPaperUserExamsLog.CourseExamPaperId);
objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.CourseExamPaperId) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetQuestionID(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_CourseExamPaperUserExamsLog.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_CourseExamPaperUserExamsLog.QuestionID);
objcc_CourseExamPaperUserExamsLogEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.QuestionID) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.QuestionID, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.QuestionID] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetIsTrue(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, bool bolIsTrue, string strComparisonOp="")
	{
objcc_CourseExamPaperUserExamsLogEN.IsTrue = bolIsTrue; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.IsTrue) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.IsTrue, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.IsTrue] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetScore(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, double dblScore, string strComparisonOp="")
	{
objcc_CourseExamPaperUserExamsLogEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.Score) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.Score, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.Score] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetCourseId(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_CourseExamPaperUserExamsLog.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_CourseExamPaperUserExamsLog.CourseId);
objcc_CourseExamPaperUserExamsLogEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.CourseId) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.CourseId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.CourseId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetQuestionAnswerIds(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strQuestionAnswerIds, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionAnswerIds, 255, concc_CourseExamPaperUserExamsLog.QuestionAnswerIds);
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds = strQuestionAnswerIds; //答案Ids
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetQuestionAnswerContent(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strQuestionAnswerContent, string strComparisonOp="")
	{
objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerContent = strQuestionAnswerContent; //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetIsShow(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, bool bolIsShow, string strComparisonOp="")
	{
objcc_CourseExamPaperUserExamsLogEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.IsShow) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.IsShow, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.IsShow] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetCreateTime(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateTime, 16, concc_CourseExamPaperUserExamsLog.CreateTime);
objcc_CourseExamPaperUserExamsLogEN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.CreateTime) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.CreateTime, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.CreateTime] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_CourseExamPaperUserExamsLogEN SetUserId(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, concc_CourseExamPaperUserExamsLog.UserId);
objcc_CourseExamPaperUserExamsLogEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.ContainsKey(concc_CourseExamPaperUserExamsLog.UserId) == false)
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp.Add(concc_CourseExamPaperUserExamsLog.UserId, strComparisonOp);
}
else
{
objcc_CourseExamPaperUserExamsLogEN.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.UserId] = strComparisonOp;
}
}
return objcc_CourseExamPaperUserExamsLogEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLog_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.mId) == true)
{
string strComparisonOp_mId = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserExamsLog.mId, objcc_CourseExamPaperUserExamsLog_Cond.mId, strComparisonOp_mId);
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserExamsLog.CourseExamPaperId, objcc_CourseExamPaperUserExamsLog_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserExamsLog.QuestionID, objcc_CourseExamPaperUserExamsLog_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.IsTrue) == true)
{
if (objcc_CourseExamPaperUserExamsLog_Cond.IsTrue == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaperUserExamsLog.IsTrue);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaperUserExamsLog.IsTrue);
}
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.Score) == true)
{
string strComparisonOp_Score = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.Score];
strWhereCond += string.Format(" And {0} {2} {1}", concc_CourseExamPaperUserExamsLog.Score, objcc_CourseExamPaperUserExamsLog_Cond.Score, strComparisonOp_Score);
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserExamsLog.CourseId, objcc_CourseExamPaperUserExamsLog_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds) == true)
{
string strComparisonOp_QuestionAnswerIds = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserExamsLog.QuestionAnswerIds, objcc_CourseExamPaperUserExamsLog_Cond.QuestionAnswerIds, strComparisonOp_QuestionAnswerIds);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.IsShow) == true)
{
if (objcc_CourseExamPaperUserExamsLog_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_CourseExamPaperUserExamsLog.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_CourseExamPaperUserExamsLog.IsShow);
}
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.CreateTime) == true)
{
string strComparisonOp_CreateTime = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserExamsLog.CreateTime, objcc_CourseExamPaperUserExamsLog_Cond.CreateTime, strComparisonOp_CreateTime);
}
if (objcc_CourseExamPaperUserExamsLog_Cond.IsUpdated(concc_CourseExamPaperUserExamsLog.UserId) == true)
{
string strComparisonOp_UserId = objcc_CourseExamPaperUserExamsLog_Cond.dicFldComparisonOp[concc_CourseExamPaperUserExamsLog.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_CourseExamPaperUserExamsLog.UserId, objcc_CourseExamPaperUserExamsLog_Cond.UserId, strComparisonOp_UserId);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
 if (objcc_CourseExamPaperUserExamsLogEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_CourseExamPaperUserExamsLogEN.sf_UpdFldSetStr = objcc_CourseExamPaperUserExamsLogEN.getsf_UpdFldSetStr();
clscc_CourseExamPaperUserExamsLogWApi.CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN); 
bool bolResult = clscc_CourseExamPaperUserExamsLogWApi.UpdateRecord(objcc_CourseExamPaperUserExamsLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserExamsLogWApi.ReFreshCache(objcc_CourseExamPaperUserExamsLogEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--cc_CourseExamPaperUserExamsLog(学生考卷答题记录), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseExamPaperId_UserId_QuestionID(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_CourseExamPaperUserExamsLogEN == null) return "";
if (objcc_CourseExamPaperUserExamsLogEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserExamsLogEN.UserId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_CourseExamPaperUserExamsLogEN.QuestionID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_CourseExamPaperUserExamsLogEN.mId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objcc_CourseExamPaperUserExamsLogEN.UserId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_CourseExamPaperUserExamsLogEN.QuestionID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
try
{
clscc_CourseExamPaperUserExamsLogWApi.CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN); 
bool bolResult = clscc_CourseExamPaperUserExamsLogWApi.AddNewRecord(objcc_CourseExamPaperUserExamsLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserExamsLogWApi.ReFreshCache(objcc_CourseExamPaperUserExamsLogEN.CourseId);
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strWhereCond)
{
try
{
clscc_CourseExamPaperUserExamsLogWApi.CheckPropertyNew(objcc_CourseExamPaperUserExamsLogEN); 
bool bolResult = clscc_CourseExamPaperUserExamsLogWApi.UpdateWithCondition(objcc_CourseExamPaperUserExamsLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserExamsLogWApi.ReFreshCache(objcc_CourseExamPaperUserExamsLogEN.CourseId);
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
 /// 学生考卷答题记录(cc_CourseExamPaperUserExamsLog)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_CourseExamPaperUserExamsLogWApi
{
private static readonly string mstrApiControllerName = "cc_CourseExamPaperUserExamsLogApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clscc_CourseExamPaperUserExamsLogWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
if (!Object.Equals(null, objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId) && GetStrLen(objcc_CourseExamPaperUserExamsLogEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperUserExamsLogEN.QuestionID) && GetStrLen(objcc_CourseExamPaperUserExamsLogEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperUserExamsLogEN.CourseId) && GetStrLen(objcc_CourseExamPaperUserExamsLogEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds) && GetStrLen(objcc_CourseExamPaperUserExamsLogEN.QuestionAnswerIds) > 255)
{
 throw new Exception("字段[答案Ids]的长度不能超过255!");
}
if (!Object.Equals(null, objcc_CourseExamPaperUserExamsLogEN.CreateTime) && GetStrLen(objcc_CourseExamPaperUserExamsLogEN.CreateTime) > 16)
{
 throw new Exception("字段[建立时间]的长度不能超过16!");
}
if (!Object.Equals(null, objcc_CourseExamPaperUserExamsLogEN.UserId) && GetStrLen(objcc_CourseExamPaperUserExamsLogEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
 objcc_CourseExamPaperUserExamsLogEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_CourseExamPaperUserExamsLogEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = null;
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
objcc_CourseExamPaperUserExamsLogEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperUserExamsLogEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperUserExamsLogEN;
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
public static clscc_CourseExamPaperUserExamsLogEN GetObjBymId_WA_Cache(long lngmId, string strCourseId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = null;
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
objcc_CourseExamPaperUserExamsLogEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperUserExamsLogEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperUserExamsLogEN;
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
public static clscc_CourseExamPaperUserExamsLogEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = null;
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
objcc_CourseExamPaperUserExamsLogEN = JsonConvert.DeserializeObject<clscc_CourseExamPaperUserExamsLogEN>((string)jobjReturn["ReturnObj"]);
return objcc_CourseExamPaperUserExamsLogEN;
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
public static clscc_CourseExamPaperUserExamsLogEN GetObjBymId_Cache(long lngmId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserExamsLogEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperUserExamsLogEN> arrcc_CourseExamPaperUserExamsLogObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserExamsLogEN> arrcc_CourseExamPaperUserExamsLogObjLst_Sel =
from objcc_CourseExamPaperUserExamsLogEN in arrcc_CourseExamPaperUserExamsLogObjLst_Cache
where objcc_CourseExamPaperUserExamsLogEN.mId == lngmId
select objcc_CourseExamPaperUserExamsLogEN;
if (arrcc_CourseExamPaperUserExamsLogObjLst_Sel.Count() == 0)
{
   clscc_CourseExamPaperUserExamsLogEN obj = clscc_CourseExamPaperUserExamsLogWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_CourseExamPaperUserExamsLogObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperUserExamsLogEN> GetObjLst(string strWhereCond)
{
 List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserExamsLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserExamsLogEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserExamsLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clscc_CourseExamPaperUserExamsLogEN> GetObjLstByMIdLst_Cache(List<long> arrMId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserExamsLogEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperUserExamsLogEN> arrcc_CourseExamPaperUserExamsLogObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clscc_CourseExamPaperUserExamsLogEN> arrcc_CourseExamPaperUserExamsLogObjLst_Sel =
from objcc_CourseExamPaperUserExamsLogEN in arrcc_CourseExamPaperUserExamsLogObjLst_Cache
where arrMId.Contains(objcc_CourseExamPaperUserExamsLogEN.mId)
select objcc_CourseExamPaperUserExamsLogEN;
return arrcc_CourseExamPaperUserExamsLogObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_CourseExamPaperUserExamsLogEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId, string strCourseId)
{
 List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserExamsLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserExamsLogEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserExamsLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserExamsLogEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserExamsLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserExamsLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserExamsLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_CourseExamPaperUserExamsLogEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_CourseExamPaperUserExamsLogEN>>((string)jobjReturn["ReturnObjLst"]);
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
 clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = clscc_CourseExamPaperUserExamsLogWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_CourseExamPaperUserExamsLogWApi.ReFreshCache(objcc_CourseExamPaperUserExamsLogEN.CourseId);
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
public static int Delcc_CourseExamPaperUserExamsLogs(List<string> arrmId)
{
string strAction = "Delcc_CourseExamPaperUserExamsLogs";
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
 clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN = clscc_CourseExamPaperUserExamsLogWApi.GetObjBymId(long.Parse(arrmId[0]));
clscc_CourseExamPaperUserExamsLogWApi.ReFreshCache(objcc_CourseExamPaperUserExamsLogEN.CourseId);
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
public static int Delcc_CourseExamPaperUserExamsLogsByCond(string strWhereCond)
{
string strAction = "Delcc_CourseExamPaperUserExamsLogsByCond";
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
public static bool AddNewRecord(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserExamsLogEN>(objcc_CourseExamPaperUserExamsLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserExamsLogWApi.ReFreshCache(objcc_CourseExamPaperUserExamsLogEN.CourseId);
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserExamsLogEN>(objcc_CourseExamPaperUserExamsLogEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_CourseExamPaperUserExamsLogWApi.ReFreshCache(objcc_CourseExamPaperUserExamsLogEN.CourseId);
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
public static bool UpdateRecord(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperUserExamsLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperUserExamsLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserExamsLogEN>(objcc_CourseExamPaperUserExamsLogEN);
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_CourseExamPaperUserExamsLogEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperUserExamsLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_CourseExamPaperUserExamsLogEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_CourseExamPaperUserExamsLogEN>(objcc_CourseExamPaperUserExamsLogEN);
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
 /// <param name = "objcc_CourseExamPaperUserExamsLogENS">源对象</param>
 /// <param name = "objcc_CourseExamPaperUserExamsLogENT">目标对象</param>
 public static void CopyTo(clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogENS, clscc_CourseExamPaperUserExamsLogEN objcc_CourseExamPaperUserExamsLogENT)
{
try
{
objcc_CourseExamPaperUserExamsLogENT.mId = objcc_CourseExamPaperUserExamsLogENS.mId; //mId
objcc_CourseExamPaperUserExamsLogENT.CourseExamPaperId = objcc_CourseExamPaperUserExamsLogENS.CourseExamPaperId; //考卷流水号
objcc_CourseExamPaperUserExamsLogENT.QuestionID = objcc_CourseExamPaperUserExamsLogENS.QuestionID; //题目ID
objcc_CourseExamPaperUserExamsLogENT.IsTrue = objcc_CourseExamPaperUserExamsLogENS.IsTrue; //是否正确
objcc_CourseExamPaperUserExamsLogENT.Score = objcc_CourseExamPaperUserExamsLogENS.Score; //得分
objcc_CourseExamPaperUserExamsLogENT.CourseId = objcc_CourseExamPaperUserExamsLogENS.CourseId; //课程Id
objcc_CourseExamPaperUserExamsLogENT.QuestionAnswerIds = objcc_CourseExamPaperUserExamsLogENS.QuestionAnswerIds; //答案Ids
objcc_CourseExamPaperUserExamsLogENT.QuestionAnswerContent = objcc_CourseExamPaperUserExamsLogENS.QuestionAnswerContent; //(填空题、解答题、判断题、简答题、问答题、思考题)回答内容
objcc_CourseExamPaperUserExamsLogENT.IsShow = objcc_CourseExamPaperUserExamsLogENS.IsShow; //是否启用
objcc_CourseExamPaperUserExamsLogENT.CreateTime = objcc_CourseExamPaperUserExamsLogENS.CreateTime; //建立时间
objcc_CourseExamPaperUserExamsLogENT.UserId = objcc_CourseExamPaperUserExamsLogENS.UserId; //用户ID
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
public static DataTable ToDataTable(List<clscc_CourseExamPaperUserExamsLogEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_CourseExamPaperUserExamsLogEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_CourseExamPaperUserExamsLogEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_CourseExamPaperUserExamsLogEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_CourseExamPaperUserExamsLogEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_CourseExamPaperUserExamsLogEN.AttributeName)
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
if (clscc_CourseExamPaperUserExamsLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseExamPaperUserExamsLogWApi没有刷新缓存机制(clscc_CourseExamPaperUserExamsLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_CourseExamPaperUserExamsLogObjLst_Cache == null)
//{
//arrcc_CourseExamPaperUserExamsLogObjLst_Cache = await clscc_CourseExamPaperUserExamsLogWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserExamsLogEN._CurrTabName_S, strCourseId);
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
if (clscc_CourseExamPaperUserExamsLogWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserExamsLogEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clscc_CourseExamPaperUserExamsLogWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_CourseExamPaperUserExamsLogEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_CourseExamPaperUserExamsLogEN._CurrTabName_S, strCourseId);
List<clscc_CourseExamPaperUserExamsLogEN> arrcc_CourseExamPaperUserExamsLogObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrcc_CourseExamPaperUserExamsLogObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_CourseExamPaperUserExamsLogEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.IsTrue, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerIds, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.QuestionAnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.CreateTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_CourseExamPaperUserExamsLog.UserId, Type.GetType("System.String"));
foreach (clscc_CourseExamPaperUserExamsLogEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_CourseExamPaperUserExamsLog.mId] = objInFor[concc_CourseExamPaperUserExamsLog.mId];
objDR[concc_CourseExamPaperUserExamsLog.CourseExamPaperId] = objInFor[concc_CourseExamPaperUserExamsLog.CourseExamPaperId];
objDR[concc_CourseExamPaperUserExamsLog.QuestionID] = objInFor[concc_CourseExamPaperUserExamsLog.QuestionID];
objDR[concc_CourseExamPaperUserExamsLog.IsTrue] = objInFor[concc_CourseExamPaperUserExamsLog.IsTrue];
objDR[concc_CourseExamPaperUserExamsLog.Score] = objInFor[concc_CourseExamPaperUserExamsLog.Score];
objDR[concc_CourseExamPaperUserExamsLog.CourseId] = objInFor[concc_CourseExamPaperUserExamsLog.CourseId];
objDR[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds] = objInFor[concc_CourseExamPaperUserExamsLog.QuestionAnswerIds];
objDR[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent] = objInFor[concc_CourseExamPaperUserExamsLog.QuestionAnswerContent];
objDR[concc_CourseExamPaperUserExamsLog.IsShow] = objInFor[concc_CourseExamPaperUserExamsLog.IsShow];
objDR[concc_CourseExamPaperUserExamsLog.CreateTime] = objInFor[concc_CourseExamPaperUserExamsLog.CreateTime];
objDR[concc_CourseExamPaperUserExamsLog.UserId] = objInFor[concc_CourseExamPaperUserExamsLog.UserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生考卷答题记录(cc_CourseExamPaperUserExamsLog)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_CourseExamPaperUserExamsLog : clsCommFun4BLV2
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
clscc_CourseExamPaperUserExamsLogWApi.ReFreshThisCache(strCourseId);
}
}

}