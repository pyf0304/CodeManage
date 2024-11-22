
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswerWApi
 表名:Answer(01120002)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:14
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsAnswerWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetAnswerID(this clsAnswerEN objAnswerEN, long lngAnswerID, string strComparisonOp="")
	{
objAnswerEN.AnswerID = lngAnswerID; //问答ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerID) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerID, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerID] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetQuestionID(this clsAnswerEN objAnswerEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, conAnswer.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, conAnswer.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conAnswer.QuestionID);
objAnswerEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.QuestionID) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.QuestionID, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.QuestionID] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetAnswerIndex(this clsAnswerEN objAnswerEN, int intAnswerIndex, string strComparisonOp="")
	{
objAnswerEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerIndex) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerIndex, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerIndex] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetAnswerOptionId(this clsAnswerEN objAnswerEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, conAnswer.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, conAnswer.AnswerOptionId);
objAnswerEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerOptionId) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerOptionId, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerOptionId] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetAnswerMultiOptions(this clsAnswerEN objAnswerEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, conAnswer.AnswerMultiOptions);
objAnswerEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerMultiOptions) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerMultiOptions, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerMultiOptions] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetIsAutoCorrect(this clsAnswerEN objAnswerEN, bool bolIsAutoCorrect, string strComparisonOp="")
	{
objAnswerEN.IsAutoCorrect = bolIsAutoCorrect; //是否支持自动批改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.IsAutoCorrect) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.IsAutoCorrect, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.IsAutoCorrect] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetAnswerFillInBlank(this clsAnswerEN objAnswerEN, string strAnswerFillInBlank, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerFillInBlank, 1000, conAnswer.AnswerFillInBlank);
objAnswerEN.AnswerFillInBlank = strAnswerFillInBlank; //填空题答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerFillInBlank) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerFillInBlank, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerFillInBlank] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetAnswerTrueOrFalse(this clsAnswerEN objAnswerEN, bool bolAnswerTrueOrFalse, string strComparisonOp="")
	{
objAnswerEN.AnswerTrueOrFalse = bolAnswerTrueOrFalse; //判断题答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerTrueOrFalse) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerTrueOrFalse, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerTrueOrFalse] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetProvider(this clsAnswerEN objAnswerEN, string strProvider, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProvider, 18, conAnswer.Provider);
objAnswerEN.Provider = strProvider; //提供者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.Provider) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.Provider, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.Provider] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetScore(this clsAnswerEN objAnswerEN, double dblScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblScore, conAnswer.Score);
objAnswerEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.Score) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.Score, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.Score] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetIsShow(this clsAnswerEN objAnswerEN, bool bolIsShow, string strComparisonOp="")
	{
objAnswerEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.IsShow) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.IsShow, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.IsShow] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetCourseId(this clsAnswerEN objAnswerEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conAnswer.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conAnswer.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conAnswer.CourseId);
objAnswerEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.CourseId) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.CourseId, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.CourseId] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetUpdDate(this clsAnswerEN objAnswerEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conAnswer.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAnswer.UpdDate);
objAnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.UpdDate) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.UpdDate, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.UpdDate] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetUpdUser(this clsAnswerEN objAnswerEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conAnswer.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conAnswer.UpdUser);
objAnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.UpdUser) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.UpdUser, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.UpdUser] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetMemo(this clsAnswerEN objAnswerEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAnswer.Memo);
objAnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.Memo) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.Memo, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.Memo] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswerEN SetAnswerContent(this clsAnswerEN objAnswerEN, string strAnswerContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerContent, 8000, conAnswer.AnswerContent);
objAnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerContent) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerContent, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerContent] = strComparisonOp;
}
}
return objAnswerEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAnswerEN objAnswer_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAnswer_Cond.IsUpdated(conAnswer.AnswerID) == true)
{
string strComparisonOp_AnswerID = objAnswer_Cond.dicFldComparisonOp[conAnswer.AnswerID];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer.AnswerID, objAnswer_Cond.AnswerID, strComparisonOp_AnswerID);
}
if (objAnswer_Cond.IsUpdated(conAnswer.QuestionID) == true)
{
string strComparisonOp_QuestionID = objAnswer_Cond.dicFldComparisonOp[conAnswer.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.QuestionID, objAnswer_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objAnswer_Cond.IsUpdated(conAnswer.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objAnswer_Cond.dicFldComparisonOp[conAnswer.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer.AnswerIndex, objAnswer_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objAnswer_Cond.IsUpdated(conAnswer.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objAnswer_Cond.dicFldComparisonOp[conAnswer.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerOptionId, objAnswer_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objAnswer_Cond.IsUpdated(conAnswer.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objAnswer_Cond.dicFldComparisonOp[conAnswer.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerMultiOptions, objAnswer_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
if (objAnswer_Cond.IsUpdated(conAnswer.IsAutoCorrect) == true)
{
if (objAnswer_Cond.IsAutoCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer.IsAutoCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer.IsAutoCorrect);
}
}
if (objAnswer_Cond.IsUpdated(conAnswer.AnswerFillInBlank) == true)
{
string strComparisonOp_AnswerFillInBlank = objAnswer_Cond.dicFldComparisonOp[conAnswer.AnswerFillInBlank];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerFillInBlank, objAnswer_Cond.AnswerFillInBlank, strComparisonOp_AnswerFillInBlank);
}
if (objAnswer_Cond.IsUpdated(conAnswer.AnswerTrueOrFalse) == true)
{
if (objAnswer_Cond.AnswerTrueOrFalse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer.AnswerTrueOrFalse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer.AnswerTrueOrFalse);
}
}
if (objAnswer_Cond.IsUpdated(conAnswer.Provider) == true)
{
string strComparisonOp_Provider = objAnswer_Cond.dicFldComparisonOp[conAnswer.Provider];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.Provider, objAnswer_Cond.Provider, strComparisonOp_Provider);
}
if (objAnswer_Cond.IsUpdated(conAnswer.Score) == true)
{
string strComparisonOp_Score = objAnswer_Cond.dicFldComparisonOp[conAnswer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer.Score, objAnswer_Cond.Score, strComparisonOp_Score);
}
if (objAnswer_Cond.IsUpdated(conAnswer.IsShow) == true)
{
if (objAnswer_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer.IsShow);
}
}
if (objAnswer_Cond.IsUpdated(conAnswer.CourseId) == true)
{
string strComparisonOp_CourseId = objAnswer_Cond.dicFldComparisonOp[conAnswer.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.CourseId, objAnswer_Cond.CourseId, strComparisonOp_CourseId);
}
if (objAnswer_Cond.IsUpdated(conAnswer.UpdDate) == true)
{
string strComparisonOp_UpdDate = objAnswer_Cond.dicFldComparisonOp[conAnswer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.UpdDate, objAnswer_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objAnswer_Cond.IsUpdated(conAnswer.UpdUser) == true)
{
string strComparisonOp_UpdUser = objAnswer_Cond.dicFldComparisonOp[conAnswer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.UpdUser, objAnswer_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objAnswer_Cond.IsUpdated(conAnswer.Memo) == true)
{
string strComparisonOp_Memo = objAnswer_Cond.dicFldComparisonOp[conAnswer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.Memo, objAnswer_Cond.Memo, strComparisonOp_Memo);
}
if (objAnswer_Cond.IsUpdated(conAnswer.AnswerContent) == true)
{
string strComparisonOp_AnswerContent = objAnswer_Cond.dicFldComparisonOp[conAnswer.AnswerContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerContent, objAnswer_Cond.AnswerContent, strComparisonOp_AnswerContent);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAnswerEN objAnswerEN)
{
 if (objAnswerEN.AnswerID == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objAnswerEN.sf_UpdFldSetStr = objAnswerEN.getsf_UpdFldSetStr();
clsAnswerWApi.CheckPropertyNew(objAnswerEN); 
bool bolResult = clsAnswerWApi.UpdateRecord(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerWApi.ReFreshCache(objAnswerEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--Answer(答案), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_AnswerID(this clsAnswerEN objAnswerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAnswerEN == null) return "";
if (objAnswerEN.AnswerID == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerID = '{0}'", objAnswerEN.AnswerID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerID !=  {0}", objAnswerEN.AnswerID);
 sbCondition.AppendFormat(" and AnswerID = '{0}'", objAnswerEN.AnswerID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAnswerEN objAnswerEN)
{
try
{
clsAnswerWApi.CheckPropertyNew(objAnswerEN); 
bool bolResult = clsAnswerWApi.AddNewRecord(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerWApi.ReFreshCache(objAnswerEN.CourseId);
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
 /// <param name = "objAnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAnswerEN objAnswerEN, string strWhereCond)
{
try
{
clsAnswerWApi.CheckPropertyNew(objAnswerEN); 
bool bolResult = clsAnswerWApi.UpdateWithCondition(objAnswerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerWApi.ReFreshCache(objAnswerEN.CourseId);
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
 /// 答案(Answer)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsAnswerWApi
{
private static readonly string mstrApiControllerName = "AnswerApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsAnswerWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsAnswerEN objAnswerEN)
{
if (!Object.Equals(null, objAnswerEN.QuestionID) && GetStrLen(objAnswerEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objAnswerEN.AnswerOptionId) && GetStrLen(objAnswerEN.AnswerOptionId) > 8)
{
 throw new Exception("字段[回答选项Id]的长度不能超过8!");
}
if (!Object.Equals(null, objAnswerEN.AnswerMultiOptions) && GetStrLen(objAnswerEN.AnswerMultiOptions) > 300)
{
 throw new Exception("字段[多选项答案]的长度不能超过300!");
}
if (!Object.Equals(null, objAnswerEN.AnswerFillInBlank) && GetStrLen(objAnswerEN.AnswerFillInBlank) > 1000)
{
 throw new Exception("字段[填空题答案]的长度不能超过1000!");
}
if (!Object.Equals(null, objAnswerEN.Provider) && GetStrLen(objAnswerEN.Provider) > 18)
{
 throw new Exception("字段[提供者]的长度不能超过18!");
}
if (!Object.Equals(null, objAnswerEN.CourseId) && GetStrLen(objAnswerEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objAnswerEN.UpdDate) && GetStrLen(objAnswerEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objAnswerEN.UpdUser) && GetStrLen(objAnswerEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objAnswerEN.Memo) && GetStrLen(objAnswerEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objAnswerEN.AnswerContent) && GetStrLen(objAnswerEN.AnswerContent) > 8000)
{
 throw new Exception("字段[答案内容]的长度不能超过8000!");
}
 objAnswerEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAnswerID">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswerEN GetObjByAnswerID(long lngAnswerID)
{
string strAction = "GetObjByAnswerID";
string strErrMsg = string.Empty;
string strResult = "";
clsAnswerEN objAnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerID"] = lngAnswerID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objAnswerEN = JsonConvert.DeserializeObject<clsAnswerEN>((string)jobjReturn["ReturnObj"]);
return objAnswerEN;
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
 /// <param name = "lngAnswerID">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswerEN GetObjByAnswerID_WA_Cache(long lngAnswerID, string strCourseId)
{
string strAction = "GetObjByAnswerID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsAnswerEN objAnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerID"] = lngAnswerID.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objAnswerEN = JsonConvert.DeserializeObject<clsAnswerEN>((string)jobjReturn["ReturnObj"]);
return objAnswerEN;
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
public static clsAnswerEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsAnswerEN objAnswerEN = null;
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
objAnswerEN = JsonConvert.DeserializeObject<clsAnswerEN>((string)jobjReturn["ReturnObj"]);
return objAnswerEN;
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
 /// <param name = "lngAnswerID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAnswerEN GetObjByAnswerID_Cache(long lngAnswerID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName_S, strCourseId);
List<clsAnswerEN> arrAnswerObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsAnswerEN> arrAnswerObjLst_Sel =
from objAnswerEN in arrAnswerObjLst_Cache
where objAnswerEN.AnswerID == lngAnswerID
select objAnswerEN;
if (arrAnswerObjLst_Sel.Count() == 0)
{
   clsAnswerEN obj = clsAnswerWApi.GetObjByAnswerID(lngAnswerID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrAnswerObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswerEN> GetObjLst(string strWhereCond)
{
 List<clsAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswerEN> GetObjLstByAnswerIDLst(List<long> arrAnswerID)
{
 List<clsAnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngAnswerID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsAnswerEN> GetObjLstByAnswerIDLst_Cache(List<long> arrAnswerID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName_S, strCourseId);
List<clsAnswerEN> arrAnswerObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsAnswerEN> arrAnswerObjLst_Sel =
from objAnswerEN in arrAnswerObjLst_Cache
where arrAnswerID.Contains(objAnswerEN.AnswerID)
select objAnswerEN;
return arrAnswerObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswerEN> GetObjLstByAnswerIDLst_WA_Cache(List<long> arrAnswerID, string strCourseId)
{
 List<clsAnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswerEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswerEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsAnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngAnswerID)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsAnswerEN objAnswerEN = clsAnswerWApi.GetObjByAnswerID(lngAnswerID);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngAnswerID.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsAnswerWApi.ReFreshCache(objAnswerEN.CourseId);
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
public static int DelAnswers(List<string> arrAnswerID)
{
string strAction = "DelAnswers";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerID);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsAnswerEN objAnswerEN = clsAnswerWApi.GetObjByAnswerID(long.Parse(arrAnswerID[0]));
clsAnswerWApi.ReFreshCache(objAnswerEN.CourseId);
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
public static int DelAnswersByCond(string strWhereCond)
{
string strAction = "DelAnswersByCond";
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
public static bool AddNewRecord(clsAnswerEN objAnswerEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswerEN>(objAnswerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerWApi.ReFreshCache(objAnswerEN.CourseId);
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
 /// <param name = "objAnswerEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsAnswerEN objAnswerEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswerEN>(objAnswerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerWApi.ReFreshCache(objAnswerEN.CourseId);
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
public static bool UpdateRecord(clsAnswerEN objAnswerEN)
{
if (string.IsNullOrEmpty(objAnswerEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAnswerEN.AnswerID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswerEN>(objAnswerEN);
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
 /// <param name = "objAnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsAnswerEN objAnswerEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objAnswerEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAnswerEN.AnswerID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAnswerEN.AnswerID, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswerEN>(objAnswerEN);
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
public static bool IsExist(long lngAnswerID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerID"] = lngAnswerID.ToString()
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
 /// <param name = "objAnswerENS">源对象</param>
 /// <param name = "objAnswerENT">目标对象</param>
 public static void CopyTo(clsAnswerEN objAnswerENS, clsAnswerEN objAnswerENT)
{
try
{
objAnswerENT.AnswerID = objAnswerENS.AnswerID; //问答ID
objAnswerENT.QuestionID = objAnswerENS.QuestionID; //题目ID
objAnswerENT.AnswerIndex = objAnswerENS.AnswerIndex; //问答序号
objAnswerENT.AnswerOptionId = objAnswerENS.AnswerOptionId; //回答选项Id
objAnswerENT.AnswerMultiOptions = objAnswerENS.AnswerMultiOptions; //多选项答案
objAnswerENT.IsAutoCorrect = objAnswerENS.IsAutoCorrect; //是否支持自动批改
objAnswerENT.AnswerFillInBlank = objAnswerENS.AnswerFillInBlank; //填空题答案
objAnswerENT.AnswerTrueOrFalse = objAnswerENS.AnswerTrueOrFalse; //判断题答案
objAnswerENT.Provider = objAnswerENS.Provider; //提供者
objAnswerENT.Score = objAnswerENS.Score; //得分
objAnswerENT.IsShow = objAnswerENS.IsShow; //是否启用
objAnswerENT.CourseId = objAnswerENS.CourseId; //课程Id
objAnswerENT.UpdDate = objAnswerENS.UpdDate; //修改日期
objAnswerENT.UpdUser = objAnswerENS.UpdUser; //修改人
objAnswerENT.Memo = objAnswerENS.Memo; //备注
objAnswerENT.AnswerContent = objAnswerENS.AnswerContent; //答案内容
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
public static DataTable ToDataTable(List<clsAnswerEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsAnswerEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsAnswerEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsAnswerEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsAnswerEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsAnswerEN.AttributeName)
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
if (clsAnswerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerWApi没有刷新缓存机制(clsAnswerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerID");
//if (arrAnswerObjLst_Cache == null)
//{
//arrAnswerObjLst_Cache = await clsAnswerWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName_S, strCourseId);
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
if (clsAnswerWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsAnswerWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAnswerEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName_S, strCourseId);
List<clsAnswerEN> arrAnswerObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrAnswerObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsAnswerEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conAnswer.AnswerID, Type.GetType("System.Int64"));
objDT.Columns.Add(conAnswer.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conAnswer.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.IsAutoCorrect, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAnswer.AnswerFillInBlank, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.AnswerTrueOrFalse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAnswer.Provider, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(conAnswer.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAnswer.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer.AnswerContent, Type.GetType("System.String"));
foreach (clsAnswerEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conAnswer.AnswerID] = objInFor[conAnswer.AnswerID];
objDR[conAnswer.QuestionID] = objInFor[conAnswer.QuestionID];
objDR[conAnswer.AnswerIndex] = objInFor[conAnswer.AnswerIndex];
objDR[conAnswer.AnswerOptionId] = objInFor[conAnswer.AnswerOptionId];
objDR[conAnswer.AnswerMultiOptions] = objInFor[conAnswer.AnswerMultiOptions];
objDR[conAnswer.IsAutoCorrect] = objInFor[conAnswer.IsAutoCorrect];
objDR[conAnswer.AnswerFillInBlank] = objInFor[conAnswer.AnswerFillInBlank];
objDR[conAnswer.AnswerTrueOrFalse] = objInFor[conAnswer.AnswerTrueOrFalse];
objDR[conAnswer.Provider] = objInFor[conAnswer.Provider];
objDR[conAnswer.Score] = objInFor[conAnswer.Score];
objDR[conAnswer.IsShow] = objInFor[conAnswer.IsShow];
objDR[conAnswer.CourseId] = objInFor[conAnswer.CourseId];
objDR[conAnswer.UpdDate] = objInFor[conAnswer.UpdDate];
objDR[conAnswer.UpdUser] = objInFor[conAnswer.UpdUser];
objDR[conAnswer.Memo] = objInFor[conAnswer.Memo];
objDR[conAnswer.AnswerContent] = objInFor[conAnswer.AnswerContent];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 答案(Answer)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4Answer : clsCommFun4BLV2
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
clsAnswerWApi.ReFreshThisCache(strCourseId);
clsvAnswerWApi.ReFreshThisCache(strCourseId);
}
}

}