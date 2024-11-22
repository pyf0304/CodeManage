
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelationWApi
 表名:cc_WorkStuRelation(01120145)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:05
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
public static class clscc_WorkStuRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetId_WorkStuRelation(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, long lngId_WorkStuRelation, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.Id_WorkStuRelation = lngId_WorkStuRelation; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Id_WorkStuRelation) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Id_WorkStuRelation, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Id_WorkStuRelation] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN Setid_CurrEduCls(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, concc_WorkStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, concc_WorkStuRelation.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, concc_WorkStuRelation.id_CurrEduCls);
objcc_WorkStuRelationEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.id_CurrEduCls) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.id_CurrEduCls, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.id_CurrEduCls] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetQuestionID(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, concc_WorkStuRelation.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_WorkStuRelation.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_WorkStuRelation.QuestionID);
objcc_WorkStuRelationEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.QuestionID) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.QuestionID, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.QuestionID] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetScores(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, double dblScores, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Scores) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Scores, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Scores] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetSpecifyCompletionDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strSpecifyCompletionDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSpecifyCompletionDate, concc_WorkStuRelation.SpecifyCompletionDate);
clsCheckSql.CheckFieldLen(strSpecifyCompletionDate, 14, concc_WorkStuRelation.SpecifyCompletionDate);
objcc_WorkStuRelationEN.SpecifyCompletionDate = strSpecifyCompletionDate; //指定完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.SpecifyCompletionDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.SpecifyCompletionDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.SpecifyCompletionDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN Setid_StudentInfo(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, concc_WorkStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, concc_WorkStuRelation.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, concc_WorkStuRelation.id_StudentInfo);
objcc_WorkStuRelationEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.id_StudentInfo) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.id_StudentInfo, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.id_StudentInfo] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerModeId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, concc_WorkStuRelation.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, concc_WorkStuRelation.AnswerModeId);
objcc_WorkStuRelationEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerModeId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerModeId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerModeId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerOptionId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, concc_WorkStuRelation.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, concc_WorkStuRelation.AnswerOptionId);
objcc_WorkStuRelationEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerOptionId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerOptionId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerOptionId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerMultiOptions(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, concc_WorkStuRelation.AnswerMultiOptions);
objcc_WorkStuRelationEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerMultiOptions) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerMultiOptions, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerMultiOptions] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerBoolResult(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolAnswerBoolResult, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.AnswerBoolResult = bolAnswerBoolResult; //答案布尔结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerBoolResult) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerBoolResult, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerBoolResult] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetStuAnswerText(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strStuAnswerText, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.StuAnswerText) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.StuAnswerText, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.StuAnswerText] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsPublish(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsPublish) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsPublish, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsPublish] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsLook(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsLook, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsLook) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsLook, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsLook] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsSave(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsSave) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsSave, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsSave] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsSubmit(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsSubmit) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsSubmit, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsSubmit] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetApplySendBackDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strApplySendBackDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, concc_WorkStuRelation.ApplySendBackDate);
objcc_WorkStuRelationEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.ApplySendBackDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.ApplySendBackDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.ApplySendBackDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsApplySendBack(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsApplySendBack) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsApplySendBack, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsApplySendBack] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetRealFinishDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_WorkStuRelation.RealFinishDate);
objcc_WorkStuRelationEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.RealFinishDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.RealFinishDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.RealFinishDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetOperateTime(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_WorkStuRelation.OperateTime);
objcc_WorkStuRelationEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.OperateTime) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.OperateTime, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.OperateTime] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetScore(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, double dblScore, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Score) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Score, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Score] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetComment(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strComment, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Comment) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Comment, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Comment] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsMarking(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsMarking) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsMarking, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsMarking] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetMarkerId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_WorkStuRelation.MarkerId);
objcc_WorkStuRelationEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.MarkerId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.MarkerId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.MarkerId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetMarkDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_WorkStuRelation.MarkDate);
objcc_WorkStuRelationEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.MarkDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.MarkDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.MarkDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsSendBack(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsSendBack, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsSendBack) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsSendBack, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsSendBack] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsInErrorQuestion(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsInErrorQuestion) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsInErrorQuestion, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsInErrorQuestion] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetWorkTypeId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkTypeId, concc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_WorkStuRelation.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_WorkStuRelation.WorkTypeId);
objcc_WorkStuRelationEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.WorkTypeId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.WorkTypeId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.WorkTypeId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerIP(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_WorkStuRelation.AnswerIP);
objcc_WorkStuRelationEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerIP) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerIP, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerIP] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_WorkStuRelation.AnswerDate);
objcc_WorkStuRelationEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetAnswerTime(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_WorkStuRelation.AnswerTime);
objcc_WorkStuRelationEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.AnswerTime) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.AnswerTime, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.AnswerTime] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetCourseExamPaperId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_WorkStuRelation.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_WorkStuRelation.CourseExamPaperId);
objcc_WorkStuRelationEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.CourseExamPaperId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsRight(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsRight, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsRight) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsRight, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsRight] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsAccessKnowledge(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsAccessKnowledge) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsAccessKnowledge, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsAccessKnowledge] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetIsNotProcessTimeout(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objcc_WorkStuRelationEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.IsNotProcessTimeout) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.IsNotProcessTimeout, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.IsNotProcessTimeout] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetSchoolYear(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_WorkStuRelation.SchoolYear);
objcc_WorkStuRelationEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.SchoolYear) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.SchoolYear, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.SchoolYear] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetSchoolTerm(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_WorkStuRelation.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_WorkStuRelation.SchoolTerm);
objcc_WorkStuRelationEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.SchoolTerm) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.SchoolTerm, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.SchoolTerm] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetErrMsg(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 200, concc_WorkStuRelation.ErrMsg);
objcc_WorkStuRelationEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.ErrMsg) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.ErrMsg, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.ErrMsg] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetCourseId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_WorkStuRelation.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_WorkStuRelation.CourseId);
objcc_WorkStuRelationEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.CourseId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.CourseId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.CourseId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetUpdDate(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_WorkStuRelation.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkStuRelation.UpdDate);
objcc_WorkStuRelationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.UpdDate) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.UpdDate, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.UpdDate] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetUpdUserId(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_WorkStuRelation.UpdUserId);
objcc_WorkStuRelationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.UpdUserId) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.UpdUserId, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.UpdUserId] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkStuRelationEN SetMemo(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkStuRelation.Memo);
objcc_WorkStuRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelationEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation.Memo) == false)
{
objcc_WorkStuRelationEN.dicFldComparisonOp.Add(concc_WorkStuRelation.Memo, strComparisonOp);
}
else
{
objcc_WorkStuRelationEN.dicFldComparisonOp[concc_WorkStuRelation.Memo] = strComparisonOp;
}
}
return objcc_WorkStuRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkStuRelationEN objcc_WorkStuRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.Id_WorkStuRelation) == true)
{
string strComparisonOp_Id_WorkStuRelation = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.Id_WorkStuRelation];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation.Id_WorkStuRelation, objcc_WorkStuRelation_Cond.Id_WorkStuRelation, strComparisonOp_Id_WorkStuRelation);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.id_CurrEduCls, objcc_WorkStuRelation_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.QuestionID, objcc_WorkStuRelation_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.Scores) == true)
{
string strComparisonOp_Scores = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation.Scores, objcc_WorkStuRelation_Cond.Scores, strComparisonOp_Scores);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.SpecifyCompletionDate) == true)
{
string strComparisonOp_SpecifyCompletionDate = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.SpecifyCompletionDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.SpecifyCompletionDate, objcc_WorkStuRelation_Cond.SpecifyCompletionDate, strComparisonOp_SpecifyCompletionDate);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.id_StudentInfo, objcc_WorkStuRelation_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerModeId, objcc_WorkStuRelation_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerOptionId, objcc_WorkStuRelation_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerMultiOptions, objcc_WorkStuRelation_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.AnswerBoolResult) == true)
{
if (objcc_WorkStuRelation_Cond.AnswerBoolResult == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.AnswerBoolResult);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.AnswerBoolResult);
}
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsPublish) == true)
{
if (objcc_WorkStuRelation_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsPublish);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsLook) == true)
{
if (objcc_WorkStuRelation_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsLook);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsSave) == true)
{
if (objcc_WorkStuRelation_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsSave);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsSubmit) == true)
{
if (objcc_WorkStuRelation_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsSubmit);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.ApplySendBackDate) == true)
{
string strComparisonOp_ApplySendBackDate = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.ApplySendBackDate, objcc_WorkStuRelation_Cond.ApplySendBackDate, strComparisonOp_ApplySendBackDate);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsApplySendBack) == true)
{
if (objcc_WorkStuRelation_Cond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsApplySendBack);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.RealFinishDate, objcc_WorkStuRelation_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.OperateTime) == true)
{
string strComparisonOp_OperateTime = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.OperateTime, objcc_WorkStuRelation_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.Score) == true)
{
string strComparisonOp_Score = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.Score];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation.Score, objcc_WorkStuRelation_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsMarking) == true)
{
if (objcc_WorkStuRelation_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsMarking);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.MarkerId) == true)
{
string strComparisonOp_MarkerId = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.MarkerId, objcc_WorkStuRelation_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.MarkDate) == true)
{
string strComparisonOp_MarkDate = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.MarkDate, objcc_WorkStuRelation_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsSendBack) == true)
{
if (objcc_WorkStuRelation_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsSendBack);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsInErrorQuestion) == true)
{
if (objcc_WorkStuRelation_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsInErrorQuestion);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.WorkTypeId, objcc_WorkStuRelation_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerIP, objcc_WorkStuRelation_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerDate, objcc_WorkStuRelation_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.AnswerTime, objcc_WorkStuRelation_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.CourseExamPaperId, objcc_WorkStuRelation_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsRight) == true)
{
if (objcc_WorkStuRelation_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsRight);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsAccessKnowledge) == true)
{
if (objcc_WorkStuRelation_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsAccessKnowledge);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.IsNotProcessTimeout) == true)
{
if (objcc_WorkStuRelation_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_WorkStuRelation.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_WorkStuRelation.IsNotProcessTimeout);
}
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.SchoolYear, objcc_WorkStuRelation_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.SchoolTerm, objcc_WorkStuRelation_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.ErrMsg) == true)
{
string strComparisonOp_ErrMsg = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.ErrMsg, objcc_WorkStuRelation_Cond.ErrMsg, strComparisonOp_ErrMsg);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.CourseId, objcc_WorkStuRelation_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.UpdDate, objcc_WorkStuRelation_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.UpdUserId, objcc_WorkStuRelation_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_WorkStuRelation_Cond.IsUpdated(concc_WorkStuRelation.Memo) == true)
{
string strComparisonOp_Memo = objcc_WorkStuRelation_Cond.dicFldComparisonOp[concc_WorkStuRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation.Memo, objcc_WorkStuRelation_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
 if (objcc_WorkStuRelationEN.Id_WorkStuRelation == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_WorkStuRelationEN.sf_UpdFldSetStr = objcc_WorkStuRelationEN.getsf_UpdFldSetStr();
clscc_WorkStuRelationWApi.CheckPropertyNew(objcc_WorkStuRelationEN); 
bool bolResult = clscc_WorkStuRelationWApi.UpdateRecord(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--cc_WorkStuRelation(作业与学生关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_CurrEduCls_QuestionID_id_StudentInfo(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelationEN == null) return "";
if (objcc_WorkStuRelationEN.Id_WorkStuRelation == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_WorkStuRelationEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkStuRelationEN.QuestionID);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelationEN.id_StudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_WorkStuRelation !=  {0}", objcc_WorkStuRelationEN.Id_WorkStuRelation);
 sbCondition.AppendFormat(" and id_CurrEduCls = '{0}'", objcc_WorkStuRelationEN.id_CurrEduCls);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_WorkStuRelationEN.QuestionID);
 sbCondition.AppendFormat(" and id_StudentInfo = '{0}'", objcc_WorkStuRelationEN.id_StudentInfo);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkStuRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
try
{
clscc_WorkStuRelationWApi.CheckPropertyNew(objcc_WorkStuRelationEN); 
bool bolResult = clscc_WorkStuRelationWApi.AddNewRecord(objcc_WorkStuRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strWhereCond)
{
try
{
clscc_WorkStuRelationWApi.CheckPropertyNew(objcc_WorkStuRelationEN); 
bool bolResult = clscc_WorkStuRelationWApi.UpdateWithCondition(objcc_WorkStuRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationWApi.ReFreshCache();
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
 /// 作业与学生关系(cc_WorkStuRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelationWApi
{
private static readonly string mstrApiControllerName = "cc_WorkStuRelationApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_WorkStuRelationWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
if (!Object.Equals(null, objcc_WorkStuRelationEN.id_CurrEduCls) && GetStrLen(objcc_WorkStuRelationEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.QuestionID) && GetStrLen(objcc_WorkStuRelationEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.SpecifyCompletionDate) && GetStrLen(objcc_WorkStuRelationEN.SpecifyCompletionDate) > 14)
{
 throw new Exception("字段[指定完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.id_StudentInfo) && GetStrLen(objcc_WorkStuRelationEN.id_StudentInfo) > 8)
{
 throw new Exception("字段[学生流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.AnswerModeId) && GetStrLen(objcc_WorkStuRelationEN.AnswerModeId) > 4)
{
 throw new Exception("字段[答案模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.AnswerOptionId) && GetStrLen(objcc_WorkStuRelationEN.AnswerOptionId) > 8)
{
 throw new Exception("字段[回答选项Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.AnswerMultiOptions) && GetStrLen(objcc_WorkStuRelationEN.AnswerMultiOptions) > 300)
{
 throw new Exception("字段[多选项答案]的长度不能超过300!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.ApplySendBackDate) && GetStrLen(objcc_WorkStuRelationEN.ApplySendBackDate) > 14)
{
 throw new Exception("字段[申请退回日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.RealFinishDate) && GetStrLen(objcc_WorkStuRelationEN.RealFinishDate) > 14)
{
 throw new Exception("字段[实际完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.OperateTime) && GetStrLen(objcc_WorkStuRelationEN.OperateTime) > 14)
{
 throw new Exception("字段[操作时间]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.MarkerId) && GetStrLen(objcc_WorkStuRelationEN.MarkerId) > 20)
{
 throw new Exception("字段[打分者]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.MarkDate) && GetStrLen(objcc_WorkStuRelationEN.MarkDate) > 14)
{
 throw new Exception("字段[打分日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.WorkTypeId) && GetStrLen(objcc_WorkStuRelationEN.WorkTypeId) > 2)
{
 throw new Exception("字段[作业类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.AnswerIP) && GetStrLen(objcc_WorkStuRelationEN.AnswerIP) > 30)
{
 throw new Exception("字段[回答IP]的长度不能超过30!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.AnswerDate) && GetStrLen(objcc_WorkStuRelationEN.AnswerDate) > 8)
{
 throw new Exception("字段[回答日期]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.AnswerTime) && GetStrLen(objcc_WorkStuRelationEN.AnswerTime) > 10)
{
 throw new Exception("字段[回答时间]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.CourseExamPaperId) && GetStrLen(objcc_WorkStuRelationEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.SchoolYear) && GetStrLen(objcc_WorkStuRelationEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.SchoolTerm) && GetStrLen(objcc_WorkStuRelationEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.ErrMsg) && GetStrLen(objcc_WorkStuRelationEN.ErrMsg) > 200)
{
 throw new Exception("字段[错误信息]的长度不能超过200!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.CourseId) && GetStrLen(objcc_WorkStuRelationEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.UpdDate) && GetStrLen(objcc_WorkStuRelationEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.UpdUserId) && GetStrLen(objcc_WorkStuRelationEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkStuRelationEN.Memo) && GetStrLen(objcc_WorkStuRelationEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_WorkStuRelationEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_WorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelationEN GetObjById_WorkStuRelation(long lngId_WorkStuRelation)
{
string strAction = "GetObjById_WorkStuRelation";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelationEN objcc_WorkStuRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkStuRelationEN = JsonConvert.DeserializeObject<clscc_WorkStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelationEN;
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
 /// <param name = "lngId_WorkStuRelation">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelationEN GetObjById_WorkStuRelation_WA_Cache(long lngId_WorkStuRelation)
{
string strAction = "GetObjById_WorkStuRelation_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelationEN objcc_WorkStuRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkStuRelationEN = JsonConvert.DeserializeObject<clscc_WorkStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelationEN;
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
public static clscc_WorkStuRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkStuRelationEN objcc_WorkStuRelationEN = null;
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
objcc_WorkStuRelationEN = JsonConvert.DeserializeObject<clscc_WorkStuRelationEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkStuRelationEN;
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
 /// <param name = "lngId_WorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelationEN GetObjById_WorkStuRelation_Cache(long lngId_WorkStuRelation)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName_S);
List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst_Sel =
from objcc_WorkStuRelationEN in arrcc_WorkStuRelationObjLst_Cache
where objcc_WorkStuRelationEN.Id_WorkStuRelation == lngId_WorkStuRelation
select objcc_WorkStuRelationEN;
if (arrcc_WorkStuRelationObjLst_Sel.Count() == 0)
{
   clscc_WorkStuRelationEN obj = clscc_WorkStuRelationWApi.GetObjById_WorkStuRelation(lngId_WorkStuRelation);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_WorkStuRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLst(string strWhereCond)
{
 List<clscc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelationEN> GetObjLstById_WorkStuRelationLst(List<long> arrId_WorkStuRelation)
{
 List<clscc_WorkStuRelationEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelationLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_WorkStuRelation">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_WorkStuRelationEN> GetObjLstById_WorkStuRelationLst_Cache(List<long> arrId_WorkStuRelation)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName_S);
List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst_Sel =
from objcc_WorkStuRelationEN in arrcc_WorkStuRelationObjLst_Cache
where arrId_WorkStuRelation.Contains(objcc_WorkStuRelationEN.Id_WorkStuRelation)
select objcc_WorkStuRelationEN;
return arrcc_WorkStuRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLstById_WorkStuRelationLst_WA_Cache(List<long> arrId_WorkStuRelation)
{
 List<clscc_WorkStuRelationEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkStuRelationLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkStuRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_WorkStuRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkStuRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_WorkStuRelation)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_WorkStuRelationEN objcc_WorkStuRelationEN = clscc_WorkStuRelationWApi.GetObjById_WorkStuRelation(lngId_WorkStuRelation);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_WorkStuRelation.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkStuRelationWApi.ReFreshCache();
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
public static int Delcc_WorkStuRelations(List<string> arrId_WorkStuRelation)
{
string strAction = "Delcc_WorkStuRelations";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_WorkStuRelation);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkStuRelationWApi.ReFreshCache();
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
public static int Delcc_WorkStuRelationsByCond(string strWhereCond)
{
string strAction = "Delcc_WorkStuRelationsByCond";
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
public static bool AddNewRecord(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelationEN>(objcc_WorkStuRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkStuRelationEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelationEN>(objcc_WorkStuRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelationWApi.ReFreshCache();
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
public static bool UpdateRecord(clscc_WorkStuRelationEN objcc_WorkStuRelationEN)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelationEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelationEN.Id_WorkStuRelation, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelationEN>(objcc_WorkStuRelationEN);
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
 /// <param name = "objcc_WorkStuRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_WorkStuRelationEN objcc_WorkStuRelationEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_WorkStuRelationEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelationEN.Id_WorkStuRelation, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkStuRelationEN.Id_WorkStuRelation, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkStuRelationEN>(objcc_WorkStuRelationEN);
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
public static bool IsExist(long lngId_WorkStuRelation)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_WorkStuRelation"] = lngId_WorkStuRelation.ToString()
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
 /// <param name = "objcc_WorkStuRelationENS">源对象</param>
 /// <param name = "objcc_WorkStuRelationENT">目标对象</param>
 public static void CopyTo(clscc_WorkStuRelationEN objcc_WorkStuRelationENS, clscc_WorkStuRelationEN objcc_WorkStuRelationENT)
{
try
{
objcc_WorkStuRelationENT.Id_WorkStuRelation = objcc_WorkStuRelationENS.Id_WorkStuRelation; //流水号
objcc_WorkStuRelationENT.id_CurrEduCls = objcc_WorkStuRelationENS.id_CurrEduCls; //当前教学班流水号
objcc_WorkStuRelationENT.QuestionID = objcc_WorkStuRelationENS.QuestionID; //题目ID
objcc_WorkStuRelationENT.Scores = objcc_WorkStuRelationENS.Scores; //分值
objcc_WorkStuRelationENT.SpecifyCompletionDate = objcc_WorkStuRelationENS.SpecifyCompletionDate; //指定完成日期
objcc_WorkStuRelationENT.id_StudentInfo = objcc_WorkStuRelationENS.id_StudentInfo; //学生流水号
objcc_WorkStuRelationENT.AnswerModeId = objcc_WorkStuRelationENS.AnswerModeId; //答案模式Id
objcc_WorkStuRelationENT.AnswerOptionId = objcc_WorkStuRelationENS.AnswerOptionId; //回答选项Id
objcc_WorkStuRelationENT.AnswerMultiOptions = objcc_WorkStuRelationENS.AnswerMultiOptions; //多选项答案
objcc_WorkStuRelationENT.AnswerBoolResult = objcc_WorkStuRelationENS.AnswerBoolResult; //答案布尔结果
objcc_WorkStuRelationENT.StuAnswerText = objcc_WorkStuRelationENS.StuAnswerText; //学生回答文本
objcc_WorkStuRelationENT.IsPublish = objcc_WorkStuRelationENS.IsPublish; //是否发布
objcc_WorkStuRelationENT.IsLook = objcc_WorkStuRelationENS.IsLook; //是否查看
objcc_WorkStuRelationENT.IsSave = objcc_WorkStuRelationENS.IsSave; //是否保存
objcc_WorkStuRelationENT.IsSubmit = objcc_WorkStuRelationENS.IsSubmit; //是否提交
objcc_WorkStuRelationENT.ApplySendBackDate = objcc_WorkStuRelationENS.ApplySendBackDate; //申请退回日期
objcc_WorkStuRelationENT.IsApplySendBack = objcc_WorkStuRelationENS.IsApplySendBack; //是否申请退回
objcc_WorkStuRelationENT.RealFinishDate = objcc_WorkStuRelationENS.RealFinishDate; //实际完成日期
objcc_WorkStuRelationENT.OperateTime = objcc_WorkStuRelationENS.OperateTime; //操作时间
objcc_WorkStuRelationENT.Score = objcc_WorkStuRelationENS.Score; //得分
objcc_WorkStuRelationENT.Comment = objcc_WorkStuRelationENS.Comment; //批注
objcc_WorkStuRelationENT.IsMarking = objcc_WorkStuRelationENS.IsMarking; //是否批阅
objcc_WorkStuRelationENT.MarkerId = objcc_WorkStuRelationENS.MarkerId; //打分者
objcc_WorkStuRelationENT.MarkDate = objcc_WorkStuRelationENS.MarkDate; //打分日期
objcc_WorkStuRelationENT.IsSendBack = objcc_WorkStuRelationENS.IsSendBack; //是否退回
objcc_WorkStuRelationENT.IsInErrorQuestion = objcc_WorkStuRelationENS.IsInErrorQuestion; //是否进入错题
objcc_WorkStuRelationENT.WorkTypeId = objcc_WorkStuRelationENS.WorkTypeId; //作业类型Id
objcc_WorkStuRelationENT.AnswerIP = objcc_WorkStuRelationENS.AnswerIP; //回答IP
objcc_WorkStuRelationENT.AnswerDate = objcc_WorkStuRelationENS.AnswerDate; //回答日期
objcc_WorkStuRelationENT.AnswerTime = objcc_WorkStuRelationENS.AnswerTime; //回答时间
objcc_WorkStuRelationENT.CourseExamPaperId = objcc_WorkStuRelationENS.CourseExamPaperId; //考卷流水号
objcc_WorkStuRelationENT.IsRight = objcc_WorkStuRelationENS.IsRight; //是否正确
objcc_WorkStuRelationENT.IsAccessKnowledge = objcc_WorkStuRelationENS.IsAccessKnowledge; //是否处理知识点
objcc_WorkStuRelationENT.IsNotProcessTimeout = objcc_WorkStuRelationENS.IsNotProcessTimeout; //是否不处理超时
objcc_WorkStuRelationENT.SchoolYear = objcc_WorkStuRelationENS.SchoolYear; //学年
objcc_WorkStuRelationENT.SchoolTerm = objcc_WorkStuRelationENS.SchoolTerm; //学期
objcc_WorkStuRelationENT.ErrMsg = objcc_WorkStuRelationENS.ErrMsg; //错误信息
objcc_WorkStuRelationENT.CourseId = objcc_WorkStuRelationENS.CourseId; //课程Id
objcc_WorkStuRelationENT.UpdDate = objcc_WorkStuRelationENS.UpdDate; //修改日期
objcc_WorkStuRelationENT.UpdUserId = objcc_WorkStuRelationENS.UpdUserId; //修改用户Id
objcc_WorkStuRelationENT.Memo = objcc_WorkStuRelationENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_WorkStuRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_WorkStuRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_WorkStuRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_WorkStuRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_WorkStuRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_WorkStuRelationEN.AttributeName)
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
if (clscc_WorkStuRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelationWApi没有刷新缓存机制(clscc_WorkStuRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_WorkStuRelation");
//if (arrcc_WorkStuRelationObjLst_Cache == null)
//{
//arrcc_WorkStuRelationObjLst_Cache = await clscc_WorkStuRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName_S);
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
if (clscc_WorkStuRelationWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_WorkStuRelationWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelationEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkStuRelationEN._CurrTabName_S);
List<clscc_WorkStuRelationEN> arrcc_WorkStuRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkStuRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_WorkStuRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_WorkStuRelation.Id_WorkStuRelation, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_WorkStuRelation.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_WorkStuRelation.SpecifyCompletionDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.AnswerBoolResult, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.ApplySendBackDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.IsApplySendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_WorkStuRelation.Comment, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_WorkStuRelation.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_WorkStuRelation.Memo, Type.GetType("System.String"));
foreach (clscc_WorkStuRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_WorkStuRelation.Id_WorkStuRelation] = objInFor[concc_WorkStuRelation.Id_WorkStuRelation];
objDR[concc_WorkStuRelation.id_CurrEduCls] = objInFor[concc_WorkStuRelation.id_CurrEduCls];
objDR[concc_WorkStuRelation.QuestionID] = objInFor[concc_WorkStuRelation.QuestionID];
objDR[concc_WorkStuRelation.Scores] = objInFor[concc_WorkStuRelation.Scores];
objDR[concc_WorkStuRelation.SpecifyCompletionDate] = objInFor[concc_WorkStuRelation.SpecifyCompletionDate];
objDR[concc_WorkStuRelation.id_StudentInfo] = objInFor[concc_WorkStuRelation.id_StudentInfo];
objDR[concc_WorkStuRelation.AnswerModeId] = objInFor[concc_WorkStuRelation.AnswerModeId];
objDR[concc_WorkStuRelation.AnswerOptionId] = objInFor[concc_WorkStuRelation.AnswerOptionId];
objDR[concc_WorkStuRelation.AnswerMultiOptions] = objInFor[concc_WorkStuRelation.AnswerMultiOptions];
objDR[concc_WorkStuRelation.AnswerBoolResult] = objInFor[concc_WorkStuRelation.AnswerBoolResult];
objDR[concc_WorkStuRelation.StuAnswerText] = objInFor[concc_WorkStuRelation.StuAnswerText];
objDR[concc_WorkStuRelation.IsPublish] = objInFor[concc_WorkStuRelation.IsPublish];
objDR[concc_WorkStuRelation.IsLook] = objInFor[concc_WorkStuRelation.IsLook];
objDR[concc_WorkStuRelation.IsSave] = objInFor[concc_WorkStuRelation.IsSave];
objDR[concc_WorkStuRelation.IsSubmit] = objInFor[concc_WorkStuRelation.IsSubmit];
objDR[concc_WorkStuRelation.ApplySendBackDate] = objInFor[concc_WorkStuRelation.ApplySendBackDate];
objDR[concc_WorkStuRelation.IsApplySendBack] = objInFor[concc_WorkStuRelation.IsApplySendBack];
objDR[concc_WorkStuRelation.RealFinishDate] = objInFor[concc_WorkStuRelation.RealFinishDate];
objDR[concc_WorkStuRelation.OperateTime] = objInFor[concc_WorkStuRelation.OperateTime];
objDR[concc_WorkStuRelation.Score] = objInFor[concc_WorkStuRelation.Score];
objDR[concc_WorkStuRelation.Comment] = objInFor[concc_WorkStuRelation.Comment];
objDR[concc_WorkStuRelation.IsMarking] = objInFor[concc_WorkStuRelation.IsMarking];
objDR[concc_WorkStuRelation.MarkerId] = objInFor[concc_WorkStuRelation.MarkerId];
objDR[concc_WorkStuRelation.MarkDate] = objInFor[concc_WorkStuRelation.MarkDate];
objDR[concc_WorkStuRelation.IsSendBack] = objInFor[concc_WorkStuRelation.IsSendBack];
objDR[concc_WorkStuRelation.IsInErrorQuestion] = objInFor[concc_WorkStuRelation.IsInErrorQuestion];
objDR[concc_WorkStuRelation.WorkTypeId] = objInFor[concc_WorkStuRelation.WorkTypeId];
objDR[concc_WorkStuRelation.AnswerIP] = objInFor[concc_WorkStuRelation.AnswerIP];
objDR[concc_WorkStuRelation.AnswerDate] = objInFor[concc_WorkStuRelation.AnswerDate];
objDR[concc_WorkStuRelation.AnswerTime] = objInFor[concc_WorkStuRelation.AnswerTime];
objDR[concc_WorkStuRelation.CourseExamPaperId] = objInFor[concc_WorkStuRelation.CourseExamPaperId];
objDR[concc_WorkStuRelation.IsRight] = objInFor[concc_WorkStuRelation.IsRight];
objDR[concc_WorkStuRelation.IsAccessKnowledge] = objInFor[concc_WorkStuRelation.IsAccessKnowledge];
objDR[concc_WorkStuRelation.IsNotProcessTimeout] = objInFor[concc_WorkStuRelation.IsNotProcessTimeout];
objDR[concc_WorkStuRelation.SchoolYear] = objInFor[concc_WorkStuRelation.SchoolYear];
objDR[concc_WorkStuRelation.SchoolTerm] = objInFor[concc_WorkStuRelation.SchoolTerm];
objDR[concc_WorkStuRelation.ErrMsg] = objInFor[concc_WorkStuRelation.ErrMsg];
objDR[concc_WorkStuRelation.CourseId] = objInFor[concc_WorkStuRelation.CourseId];
objDR[concc_WorkStuRelation.UpdDate] = objInFor[concc_WorkStuRelation.UpdDate];
objDR[concc_WorkStuRelation.UpdUserId] = objInFor[concc_WorkStuRelation.UpdUserId];
objDR[concc_WorkStuRelation.Memo] = objInFor[concc_WorkStuRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 作业与学生关系(cc_WorkStuRelation)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_WorkStuRelation : clsCommFun4BL
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
clscc_WorkStuRelationWApi.ReFreshThisCache();
clsvcc_WorkStuRelationWApi.ReFreshThisCache();
clsvcc_WorkStuRelation4AppWApi.ReFreshThisCache();
}
}

}