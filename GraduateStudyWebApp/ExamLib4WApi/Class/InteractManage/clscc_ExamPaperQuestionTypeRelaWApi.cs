
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperQuestionTypeRelaWApi
 表名:cc_ExamPaperQuestionTypeRela(01120237)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:32
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clscc_ExamPaperQuestionTypeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetId_ExamPaperQuestionTypeRela(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, long lngId_ExamPaperQuestionTypeRela, string strComparisonOp="")
	{
objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela = lngId_ExamPaperQuestionTypeRela; //Id_ExamPaperQuestionTypeRela
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetCourseExamPaperId(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseExamPaperId, concc_ExamPaperQuestionTypeRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_ExamPaperQuestionTypeRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_ExamPaperQuestionTypeRela.CourseExamPaperId);
objcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.CourseExamPaperId) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetScores(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, double dblScores, string strComparisonOp="")
	{
objcc_ExamPaperQuestionTypeRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.Scores) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.Scores, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.Scores] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetQuestionTypeId(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId, concc_ExamPaperQuestionTypeRela.QuestionTypeId);
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, concc_ExamPaperQuestionTypeRela.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, concc_ExamPaperQuestionTypeRela.QuestionTypeId);
objcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.QuestionTypeId) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.QuestionTypeId, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.QuestionTypeId] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetChapterId(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, concc_ExamPaperQuestionTypeRela.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, concc_ExamPaperQuestionTypeRela.ChapterId);
objcc_ExamPaperQuestionTypeRelaEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.ChapterId) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.ChapterId, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.ChapterId] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetNeedQuestionNum(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, int intNeedQuestionNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intNeedQuestionNum, concc_ExamPaperQuestionTypeRela.NeedQuestionNum);
objcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = intNeedQuestionNum; //需要题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.NeedQuestionNum) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.NeedQuestionNum, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.NeedQuestionNum] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetPerScore(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, double dblPerScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblPerScore, concc_ExamPaperQuestionTypeRela.PerScore);
objcc_ExamPaperQuestionTypeRelaEN.PerScore = dblPerScore; //每题分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.PerScore) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.PerScore, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.PerScore] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetOrderNum(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, int intOrderNum, string strComparisonOp="")
	{
objcc_ExamPaperQuestionTypeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.OrderNum) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.OrderNum, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.OrderNum] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetUpdDate(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_ExamPaperQuestionTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_ExamPaperQuestionTypeRela.UpdDate);
objcc_ExamPaperQuestionTypeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.UpdDate) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.UpdDate, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.UpdDate] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetUpdUserId(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_ExamPaperQuestionTypeRela.UpdUserId);
objcc_ExamPaperQuestionTypeRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.UpdUserId) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.UpdUserId, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.UpdUserId] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_ExamPaperQuestionTypeRelaEN SetMemo(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExamPaperQuestionTypeRela.Memo);
objcc_ExamPaperQuestionTypeRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperQuestionTypeRela.Memo) == false)
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp.Add(concc_ExamPaperQuestionTypeRela.Memo, strComparisonOp);
}
else
{
objcc_ExamPaperQuestionTypeRelaEN.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.Memo] = strComparisonOp;
}
}
return objcc_ExamPaperQuestionTypeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela) == true)
{
string strComparisonOp_Id_ExamPaperQuestionTypeRela = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela, objcc_ExamPaperQuestionTypeRela_Cond.Id_ExamPaperQuestionTypeRela, strComparisonOp_Id_ExamPaperQuestionTypeRela);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperQuestionTypeRela.CourseExamPaperId, objcc_ExamPaperQuestionTypeRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.Scores) == true)
{
string strComparisonOp_Scores = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperQuestionTypeRela.Scores, objcc_ExamPaperQuestionTypeRela_Cond.Scores, strComparisonOp_Scores);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperQuestionTypeRela.QuestionTypeId, objcc_ExamPaperQuestionTypeRela_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.ChapterId) == true)
{
string strComparisonOp_ChapterId = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperQuestionTypeRela.ChapterId, objcc_ExamPaperQuestionTypeRela_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.NeedQuestionNum) == true)
{
string strComparisonOp_NeedQuestionNum = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.NeedQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperQuestionTypeRela.NeedQuestionNum, objcc_ExamPaperQuestionTypeRela_Cond.NeedQuestionNum, strComparisonOp_NeedQuestionNum);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.PerScore) == true)
{
string strComparisonOp_PerScore = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.PerScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperQuestionTypeRela.PerScore, objcc_ExamPaperQuestionTypeRela_Cond.PerScore, strComparisonOp_PerScore);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperQuestionTypeRela.OrderNum, objcc_ExamPaperQuestionTypeRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperQuestionTypeRela.UpdDate, objcc_ExamPaperQuestionTypeRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperQuestionTypeRela.UpdUserId, objcc_ExamPaperQuestionTypeRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_ExamPaperQuestionTypeRela_Cond.IsUpdated(concc_ExamPaperQuestionTypeRela.Memo) == true)
{
string strComparisonOp_Memo = objcc_ExamPaperQuestionTypeRela_Cond.dicFldComparisonOp[concc_ExamPaperQuestionTypeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperQuestionTypeRela.Memo, objcc_ExamPaperQuestionTypeRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN)
{
 if (objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_ExamPaperQuestionTypeRelaEN.sf_UpdFldSetStr = objcc_ExamPaperQuestionTypeRelaEN.getsf_UpdFldSetStr();
clscc_ExamPaperQuestionTypeRelaWApi.CheckPropertyNew(objcc_ExamPaperQuestionTypeRelaEN); 
bool bolResult = clscc_ExamPaperQuestionTypeRelaWApi.UpdateRecord(objcc_ExamPaperQuestionTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--cc_ExamPaperQuestionTypeRela(考卷题型关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CourseExamPaperId_QuestionTypeId(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperQuestionTypeRelaEN == null) return "";
if (objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and QuestionTypeId = '{0}'", objcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_ExamPaperQuestionTypeRela !=  {0}", objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and QuestionTypeId = '{0}'", objcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN)
{
try
{
clscc_ExamPaperQuestionTypeRelaWApi.CheckPropertyNew(objcc_ExamPaperQuestionTypeRelaEN); 
bool bolResult = clscc_ExamPaperQuestionTypeRelaWApi.AddNewRecord(objcc_ExamPaperQuestionTypeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshCache();
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
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strWhereCond)
{
try
{
clscc_ExamPaperQuestionTypeRelaWApi.CheckPropertyNew(objcc_ExamPaperQuestionTypeRelaEN); 
bool bolResult = clscc_ExamPaperQuestionTypeRelaWApi.UpdateWithCondition(objcc_ExamPaperQuestionTypeRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshCache();
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
 /// 考卷题型关系(cc_ExamPaperQuestionTypeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_ExamPaperQuestionTypeRelaWApi
{
private static readonly string mstrApiControllerName = "cc_ExamPaperQuestionTypeRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_ExamPaperQuestionTypeRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN)
{
if (!Object.Equals(null, objcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId) && GetStrLen(objcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId) && GetStrLen(objcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId) > 2)
{
 throw new Exception("字段[题目类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_ExamPaperQuestionTypeRelaEN.ChapterId) && GetStrLen(objcc_ExamPaperQuestionTypeRelaEN.ChapterId) > 8)
{
 throw new Exception("字段[章Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_ExamPaperQuestionTypeRelaEN.UpdDate) && GetStrLen(objcc_ExamPaperQuestionTypeRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperQuestionTypeRelaEN.UpdUserId) && GetStrLen(objcc_ExamPaperQuestionTypeRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_ExamPaperQuestionTypeRelaEN.Memo) && GetStrLen(objcc_ExamPaperQuestionTypeRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_ExamPaperQuestionTypeRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_ExamPaperQuestionTypeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperQuestionTypeRelaEN GetObjById_ExamPaperQuestionTypeRela(long lngId_ExamPaperQuestionTypeRela)
{
string strAction = "GetObjById_ExamPaperQuestionTypeRela";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperQuestionTypeRela"] = lngId_ExamPaperQuestionTypeRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperQuestionTypeRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperQuestionTypeRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperQuestionTypeRelaEN;
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
 /// <param name = "lngId_ExamPaperQuestionTypeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperQuestionTypeRelaEN GetObjById_ExamPaperQuestionTypeRela_WA_Cache(long lngId_ExamPaperQuestionTypeRela)
{
string strAction = "GetObjById_ExamPaperQuestionTypeRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperQuestionTypeRela"] = lngId_ExamPaperQuestionTypeRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_ExamPaperQuestionTypeRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperQuestionTypeRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperQuestionTypeRelaEN;
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
public static clscc_ExamPaperQuestionTypeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN = null;
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
objcc_ExamPaperQuestionTypeRelaEN = JsonConvert.DeserializeObject<clscc_ExamPaperQuestionTypeRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_ExamPaperQuestionTypeRelaEN;
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
 /// <param name = "lngId_ExamPaperQuestionTypeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperQuestionTypeRelaEN GetObjById_ExamPaperQuestionTypeRela_Cache(long lngId_ExamPaperQuestionTypeRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_ExamPaperQuestionTypeRelaEN._CurrTabName_S);
List<clscc_ExamPaperQuestionTypeRelaEN> arrcc_ExamPaperQuestionTypeRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_ExamPaperQuestionTypeRelaEN> arrcc_ExamPaperQuestionTypeRelaObjLst_Sel =
from objcc_ExamPaperQuestionTypeRelaEN in arrcc_ExamPaperQuestionTypeRelaObjLst_Cache
where objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela == lngId_ExamPaperQuestionTypeRela
select objcc_ExamPaperQuestionTypeRelaEN;
if (arrcc_ExamPaperQuestionTypeRelaObjLst_Sel.Count() == 0)
{
   clscc_ExamPaperQuestionTypeRelaEN obj = clscc_ExamPaperQuestionTypeRelaWApi.GetObjById_ExamPaperQuestionTypeRela(lngId_ExamPaperQuestionTypeRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_ExamPaperQuestionTypeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetObjLst(string strWhereCond)
{
 List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetObjLstById_ExamPaperQuestionTypeRelaLst(List<long> arrId_ExamPaperQuestionTypeRela)
{
 List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperQuestionTypeRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperQuestionTypeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_ExamPaperQuestionTypeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_ExamPaperQuestionTypeRelaEN> GetObjLstById_ExamPaperQuestionTypeRelaLst_Cache(List<long> arrId_ExamPaperQuestionTypeRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_ExamPaperQuestionTypeRelaEN._CurrTabName_S);
List<clscc_ExamPaperQuestionTypeRelaEN> arrcc_ExamPaperQuestionTypeRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_ExamPaperQuestionTypeRelaEN> arrcc_ExamPaperQuestionTypeRelaObjLst_Sel =
from objcc_ExamPaperQuestionTypeRelaEN in arrcc_ExamPaperQuestionTypeRelaObjLst_Cache
where arrId_ExamPaperQuestionTypeRela.Contains(objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela)
select objcc_ExamPaperQuestionTypeRelaEN;
return arrcc_ExamPaperQuestionTypeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetObjLstById_ExamPaperQuestionTypeRelaLst_WA_Cache(List<long> arrId_ExamPaperQuestionTypeRela)
{
 List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_ExamPaperQuestionTypeRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperQuestionTypeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_ExamPaperQuestionTypeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_ExamPaperQuestionTypeRela)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN = clscc_ExamPaperQuestionTypeRelaWApi.GetObjById_ExamPaperQuestionTypeRela(lngId_ExamPaperQuestionTypeRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_ExamPaperQuestionTypeRela.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshCache();
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
public static int Delcc_ExamPaperQuestionTypeRelas(List<string> arrId_ExamPaperQuestionTypeRela)
{
string strAction = "Delcc_ExamPaperQuestionTypeRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_ExamPaperQuestionTypeRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshCache();
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
public static int Delcc_ExamPaperQuestionTypeRelasByCond(string strWhereCond)
{
string strAction = "Delcc_ExamPaperQuestionTypeRelasByCond";
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
public static bool AddNewRecord(clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperQuestionTypeRelaEN>(objcc_ExamPaperQuestionTypeRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshCache();
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
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperQuestionTypeRelaEN>(objcc_ExamPaperQuestionTypeRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN)
{
if (string.IsNullOrEmpty(objcc_ExamPaperQuestionTypeRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperQuestionTypeRelaEN>(objcc_ExamPaperQuestionTypeRelaEN);
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
 /// <param name = "objcc_ExamPaperQuestionTypeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_ExamPaperQuestionTypeRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_ExamPaperQuestionTypeRelaEN.Id_ExamPaperQuestionTypeRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_ExamPaperQuestionTypeRelaEN>(objcc_ExamPaperQuestionTypeRelaEN);
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
public static bool IsExist(long lngId_ExamPaperQuestionTypeRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_ExamPaperQuestionTypeRela"] = lngId_ExamPaperQuestionTypeRela.ToString()
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
 /// <param name = "objcc_ExamPaperQuestionTypeRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperQuestionTypeRelaENT">目标对象</param>
 public static void CopyTo(clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaENS, clscc_ExamPaperQuestionTypeRelaEN objcc_ExamPaperQuestionTypeRelaENT)
{
try
{
objcc_ExamPaperQuestionTypeRelaENT.Id_ExamPaperQuestionTypeRela = objcc_ExamPaperQuestionTypeRelaENS.Id_ExamPaperQuestionTypeRela; //Id_ExamPaperQuestionTypeRela
objcc_ExamPaperQuestionTypeRelaENT.CourseExamPaperId = objcc_ExamPaperQuestionTypeRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperQuestionTypeRelaENT.Scores = objcc_ExamPaperQuestionTypeRelaENS.Scores; //分值
objcc_ExamPaperQuestionTypeRelaENT.QuestionTypeId = objcc_ExamPaperQuestionTypeRelaENS.QuestionTypeId; //题目类型Id
objcc_ExamPaperQuestionTypeRelaENT.ChapterId = objcc_ExamPaperQuestionTypeRelaENS.ChapterId; //章Id
objcc_ExamPaperQuestionTypeRelaENT.NeedQuestionNum = objcc_ExamPaperQuestionTypeRelaENS.NeedQuestionNum; //需要题目数
objcc_ExamPaperQuestionTypeRelaENT.PerScore = objcc_ExamPaperQuestionTypeRelaENS.PerScore; //每题分值
objcc_ExamPaperQuestionTypeRelaENT.OrderNum = objcc_ExamPaperQuestionTypeRelaENS.OrderNum; //序号
objcc_ExamPaperQuestionTypeRelaENT.UpdDate = objcc_ExamPaperQuestionTypeRelaENS.UpdDate; //修改日期
objcc_ExamPaperQuestionTypeRelaENT.UpdUserId = objcc_ExamPaperQuestionTypeRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperQuestionTypeRelaENT.Memo = objcc_ExamPaperQuestionTypeRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_ExamPaperQuestionTypeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_ExamPaperQuestionTypeRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_ExamPaperQuestionTypeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_ExamPaperQuestionTypeRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_ExamPaperQuestionTypeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_ExamPaperQuestionTypeRelaEN.AttributeName)
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
if (clscc_ExamPaperQuestionTypeRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperQuestionTypeRelaWApi没有刷新缓存机制(clscc_ExamPaperQuestionTypeRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_ExamPaperQuestionTypeRela");
//if (arrcc_ExamPaperQuestionTypeRelaObjLst_Cache == null)
//{
//arrcc_ExamPaperQuestionTypeRelaObjLst_Cache = await clscc_ExamPaperQuestionTypeRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_ExamPaperQuestionTypeRelaEN._CurrTabName_S);
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
if (clscc_ExamPaperQuestionTypeRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_ExamPaperQuestionTypeRelaEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_ExamPaperQuestionTypeRelaWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperQuestionTypeRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_ExamPaperQuestionTypeRelaEN._CurrTabName_S);
List<clscc_ExamPaperQuestionTypeRelaEN> arrcc_ExamPaperQuestionTypeRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_ExamPaperQuestionTypeRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_ExamPaperQuestionTypeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.NeedQuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.PerScore, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_ExamPaperQuestionTypeRela.Memo, Type.GetType("System.String"));
foreach (clscc_ExamPaperQuestionTypeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela] = objInFor[concc_ExamPaperQuestionTypeRela.Id_ExamPaperQuestionTypeRela];
objDR[concc_ExamPaperQuestionTypeRela.CourseExamPaperId] = objInFor[concc_ExamPaperQuestionTypeRela.CourseExamPaperId];
objDR[concc_ExamPaperQuestionTypeRela.Scores] = objInFor[concc_ExamPaperQuestionTypeRela.Scores];
objDR[concc_ExamPaperQuestionTypeRela.QuestionTypeId] = objInFor[concc_ExamPaperQuestionTypeRela.QuestionTypeId];
objDR[concc_ExamPaperQuestionTypeRela.ChapterId] = objInFor[concc_ExamPaperQuestionTypeRela.ChapterId];
objDR[concc_ExamPaperQuestionTypeRela.NeedQuestionNum] = objInFor[concc_ExamPaperQuestionTypeRela.NeedQuestionNum];
objDR[concc_ExamPaperQuestionTypeRela.PerScore] = objInFor[concc_ExamPaperQuestionTypeRela.PerScore];
objDR[concc_ExamPaperQuestionTypeRela.OrderNum] = objInFor[concc_ExamPaperQuestionTypeRela.OrderNum];
objDR[concc_ExamPaperQuestionTypeRela.UpdDate] = objInFor[concc_ExamPaperQuestionTypeRela.UpdDate];
objDR[concc_ExamPaperQuestionTypeRela.UpdUserId] = objInFor[concc_ExamPaperQuestionTypeRela.UpdUserId];
objDR[concc_ExamPaperQuestionTypeRela.Memo] = objInFor[concc_ExamPaperQuestionTypeRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 考卷题型关系(cc_ExamPaperQuestionTypeRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_ExamPaperQuestionTypeRela : clsCommFun4BL
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
clscc_ExamPaperQuestionTypeRelaWApi.ReFreshThisCache();
clsvcc_ExamPaperQuestionTypeRelaWApi.ReFreshThisCache();
}
}

}