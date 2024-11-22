
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRelaWApi
 表名:cc_PaperStuBatchQuesRela(01120240)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:37
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
public static class clscc_PaperStuBatchQuesRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetId_PaperStuBatchQuesRela(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, long lngId_PaperStuBatchQuesRela, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela = lngId_PaperStuBatchQuesRela; //学生批次题目关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetId_PaperStuBatch(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strId_PaperStuBatch, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_PaperStuBatch, concc_PaperStuBatchQuesRela.Id_PaperStuBatch);
clsCheckSql.CheckFieldLen(strId_PaperStuBatch, 10, concc_PaperStuBatchQuesRela.Id_PaperStuBatch);
clsCheckSql.CheckFieldForeignKey(strId_PaperStuBatch, 10, concc_PaperStuBatchQuesRela.Id_PaperStuBatch);
objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatch = strId_PaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Id_PaperStuBatch) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Id_PaperStuBatch, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Id_PaperStuBatch] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetQuestionID(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, concc_PaperStuBatchQuesRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, concc_PaperStuBatchQuesRela.QuestionID);
objcc_PaperStuBatchQuesRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.QuestionID) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.QuestionID, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionID] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetQuestionIndex4Batch(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, int intQuestionIndex4Batch, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.QuestionIndex4Batch = intQuestionIndex4Batch; //题序号4批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.QuestionIndex4Batch) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.QuestionIndex4Batch, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetScores(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, double dblScores, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Scores) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Scores, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Scores] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetScore(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, double dblScore, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Score) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Score, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Score] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetStuAnswerText(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strStuAnswerText, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.StuAnswerText = strStuAnswerText; //学生回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.StuAnswerText) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.StuAnswerText, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.StuAnswerText] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_PaperStuBatchQuesRela.AnswerDate);
objcc_PaperStuBatchQuesRelaEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerIP(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_PaperStuBatchQuesRela.AnswerIP);
objcc_PaperStuBatchQuesRelaEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerIP) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerIP, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerIP] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerModeId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, concc_PaperStuBatchQuesRela.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, concc_PaperStuBatchQuesRela.AnswerModeId);
objcc_PaperStuBatchQuesRelaEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerModeId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerModeId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerModeId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerMultiOptions(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, concc_PaperStuBatchQuesRela.AnswerMultiOptions);
objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerMultiOptions) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerMultiOptions, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerMultiOptions] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerOptionId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, concc_PaperStuBatchQuesRela.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, concc_PaperStuBatchQuesRela.AnswerOptionId);
objcc_PaperStuBatchQuesRelaEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerOptionId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerOptionId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerOptionId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetAnswerTime(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_PaperStuBatchQuesRela.AnswerTime);
objcc_PaperStuBatchQuesRelaEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.AnswerTime) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.AnswerTime, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerTime] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetApplySendBackDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strApplySendBackDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strApplySendBackDate, 14, concc_PaperStuBatchQuesRela.ApplySendBackDate);
objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate = strApplySendBackDate; //申请退回日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.ApplySendBackDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.ApplySendBackDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ApplySendBackDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetComment(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strComment, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Comment) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Comment, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Comment] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsAccessKnowledge(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsAccessKnowledge) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsAccessKnowledge, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsAccessKnowledge] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsApplySendBack(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsApplySendBack, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsApplySendBack = bolIsApplySendBack; //是否申请退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsApplySendBack) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsApplySendBack, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsApplySendBack] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsInErrorQuestion(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsInErrorQuestion, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsInErrorQuestion = bolIsInErrorQuestion; //是否进入错题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsInErrorQuestion) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsInErrorQuestion, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsInErrorQuestion] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsLook(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsLook, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsLook = bolIsLook; //是否查看
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsLook) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsLook, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsLook] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsMarking(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsMarking) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsMarking, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsMarking] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsNotProcessTimeout(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsNotProcessTimeout, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsNotProcessTimeout = bolIsNotProcessTimeout; //是否不处理超时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsNotProcessTimeout) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsNotProcessTimeout, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsNotProcessTimeout] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsPublish(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsPublish, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsPublish = bolIsPublish; //是否发布
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsPublish) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsPublish, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsPublish] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsRight(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsRight, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsRight) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsRight, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsRight] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsSave(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsSave) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsSave, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsSave] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsSendBack(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsSendBack, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsSendBack = bolIsSendBack; //是否退回
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsSendBack) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsSendBack, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsSendBack] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetIsSubmit(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.IsSubmit) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.IsSubmit, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.IsSubmit] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetMarkDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strMarkDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_PaperStuBatchQuesRela.MarkDate);
objcc_PaperStuBatchQuesRelaEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.MarkDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.MarkDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetMarkerId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_PaperStuBatchQuesRela.MarkerId);
objcc_PaperStuBatchQuesRelaEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.MarkerId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.MarkerId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkerId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetOperateTime(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strOperateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_PaperStuBatchQuesRela.OperateTime);
objcc_PaperStuBatchQuesRelaEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.OperateTime) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.OperateTime, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.OperateTime] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetRealFinishDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_PaperStuBatchQuesRela.RealFinishDate);
objcc_PaperStuBatchQuesRelaEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.RealFinishDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.RealFinishDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.RealFinishDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetWorkTypeId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strWorkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWorkTypeId, 2, concc_PaperStuBatchQuesRela.WorkTypeId);
clsCheckSql.CheckFieldForeignKey(strWorkTypeId, 2, concc_PaperStuBatchQuesRela.WorkTypeId);
objcc_PaperStuBatchQuesRelaEN.WorkTypeId = strWorkTypeId; //作业类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.WorkTypeId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.WorkTypeId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.WorkTypeId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetSchoolYear(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_PaperStuBatchQuesRela.SchoolYear);
objcc_PaperStuBatchQuesRelaEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.SchoolYear) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.SchoolYear, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolYear] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetSchoolTerm(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_PaperStuBatchQuesRela.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_PaperStuBatchQuesRela.SchoolTerm);
objcc_PaperStuBatchQuesRelaEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.SchoolTerm) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.SchoolTerm, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolTerm] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetErrMsg(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 200, concc_PaperStuBatchQuesRela.ErrMsg);
objcc_PaperStuBatchQuesRelaEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.ErrMsg) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.ErrMsg, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ErrMsg] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetCourseId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_PaperStuBatchQuesRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_PaperStuBatchQuesRela.CourseId);
objcc_PaperStuBatchQuesRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.CourseId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.CourseId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.CourseId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetUpdDate(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_PaperStuBatchQuesRela.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_PaperStuBatchQuesRela.UpdDate);
objcc_PaperStuBatchQuesRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.UpdDate) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.UpdDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetUpdUserId(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_PaperStuBatchQuesRela.UpdUserId);
objcc_PaperStuBatchQuesRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.UpdUserId) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.UpdUserId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdUserId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PaperStuBatchQuesRelaEN SetMemo(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_PaperStuBatchQuesRela.Memo);
objcc_PaperStuBatchQuesRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela.Memo) == false)
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela.Memo, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRelaEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Memo] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela) == true)
{
string strComparisonOp_Id_PaperStuBatchQuesRela = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela, objcc_PaperStuBatchQuesRela_Cond.Id_PaperStuBatchQuesRela, strComparisonOp_Id_PaperStuBatchQuesRela);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.Id_PaperStuBatch) == true)
{
string strComparisonOp_Id_PaperStuBatch = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Id_PaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.Id_PaperStuBatch, objcc_PaperStuBatchQuesRela_Cond.Id_PaperStuBatch, strComparisonOp_Id_PaperStuBatch);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.QuestionID, objcc_PaperStuBatchQuesRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.QuestionIndex4Batch) == true)
{
string strComparisonOp_QuestionIndex4Batch = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.QuestionIndex4Batch];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.QuestionIndex4Batch, objcc_PaperStuBatchQuesRela_Cond.QuestionIndex4Batch, strComparisonOp_QuestionIndex4Batch);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.Scores) == true)
{
string strComparisonOp_Scores = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.Scores, objcc_PaperStuBatchQuesRela_Cond.Scores, strComparisonOp_Scores);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.Score) == true)
{
string strComparisonOp_Score = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela.Score, objcc_PaperStuBatchQuesRela_Cond.Score, strComparisonOp_Score);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerDate, objcc_PaperStuBatchQuesRela_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerIP, objcc_PaperStuBatchQuesRela_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerModeId, objcc_PaperStuBatchQuesRela_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerMultiOptions) == true)
{
string strComparisonOp_AnswerMultiOptions = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerMultiOptions, objcc_PaperStuBatchQuesRela_Cond.AnswerMultiOptions, strComparisonOp_AnswerMultiOptions);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerOptionId, objcc_PaperStuBatchQuesRela_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.AnswerTime, objcc_PaperStuBatchQuesRela_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.ApplySendBackDate) == true)
{
string strComparisonOp_ApplySendBackDate = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ApplySendBackDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.ApplySendBackDate, objcc_PaperStuBatchQuesRela_Cond.ApplySendBackDate, strComparisonOp_ApplySendBackDate);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsAccessKnowledge) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsAccessKnowledge);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsApplySendBack) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsApplySendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsApplySendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsApplySendBack);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsInErrorQuestion) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsInErrorQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsInErrorQuestion);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsLook) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsLook == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsLook);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsLook);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsMarking) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsMarking);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsNotProcessTimeout) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsNotProcessTimeout == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsNotProcessTimeout);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsPublish) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsPublish == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsPublish);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsPublish);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsRight) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsRight);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsSave) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsSave);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsSendBack) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsSendBack == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsSendBack);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsSendBack);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.IsSubmit) == true)
{
if (objcc_PaperStuBatchQuesRela_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_PaperStuBatchQuesRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_PaperStuBatchQuesRela.IsSubmit);
}
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.MarkDate) == true)
{
string strComparisonOp_MarkDate = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.MarkDate, objcc_PaperStuBatchQuesRela_Cond.MarkDate, strComparisonOp_MarkDate);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.MarkerId) == true)
{
string strComparisonOp_MarkerId = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.MarkerId, objcc_PaperStuBatchQuesRela_Cond.MarkerId, strComparisonOp_MarkerId);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.OperateTime) == true)
{
string strComparisonOp_OperateTime = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.OperateTime, objcc_PaperStuBatchQuesRela_Cond.OperateTime, strComparisonOp_OperateTime);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.RealFinishDate) == true)
{
string strComparisonOp_RealFinishDate = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.RealFinishDate, objcc_PaperStuBatchQuesRela_Cond.RealFinishDate, strComparisonOp_RealFinishDate);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.WorkTypeId) == true)
{
string strComparisonOp_WorkTypeId = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.WorkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.WorkTypeId, objcc_PaperStuBatchQuesRela_Cond.WorkTypeId, strComparisonOp_WorkTypeId);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.SchoolYear, objcc_PaperStuBatchQuesRela_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.SchoolTerm, objcc_PaperStuBatchQuesRela_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.ErrMsg) == true)
{
string strComparisonOp_ErrMsg = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.ErrMsg, objcc_PaperStuBatchQuesRela_Cond.ErrMsg, strComparisonOp_ErrMsg);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.CourseId, objcc_PaperStuBatchQuesRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.UpdDate, objcc_PaperStuBatchQuesRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.UpdUserId, objcc_PaperStuBatchQuesRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_PaperStuBatchQuesRela_Cond.IsUpdated(concc_PaperStuBatchQuesRela.Memo) == true)
{
string strComparisonOp_Memo = objcc_PaperStuBatchQuesRela_Cond.dicFldComparisonOp[concc_PaperStuBatchQuesRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela.Memo, objcc_PaperStuBatchQuesRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
 if (objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_PaperStuBatchQuesRelaEN.sf_UpdFldSetStr = objcc_PaperStuBatchQuesRelaEN.getsf_UpdFldSetStr();
clscc_PaperStuBatchQuesRelaWApi.CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN); 
bool bolResult = clscc_PaperStuBatchQuesRelaWApi.UpdateRecord(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--cc_PaperStuBatchQuesRela(学生批次题目关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionID_Id_PaperStuBatch(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_PaperStuBatchQuesRelaEN == null) return "";
if (objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_PaperStuBatchQuesRelaEN.QuestionID);
 sbCondition.AppendFormat(" and Id_PaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatch);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("Id_PaperStuBatchQuesRela !=  {0}", objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objcc_PaperStuBatchQuesRelaEN.QuestionID);
 sbCondition.AppendFormat(" and Id_PaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatch);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
try
{
clscc_PaperStuBatchQuesRelaWApi.CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN); 
bool bolResult = clscc_PaperStuBatchQuesRelaWApi.AddNewRecord(objcc_PaperStuBatchQuesRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaWApi.ReFreshCache();
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strWhereCond)
{
try
{
clscc_PaperStuBatchQuesRelaWApi.CheckPropertyNew(objcc_PaperStuBatchQuesRelaEN); 
bool bolResult = clscc_PaperStuBatchQuesRelaWApi.UpdateWithCondition(objcc_PaperStuBatchQuesRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaWApi.ReFreshCache();
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
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_PaperStuBatchQuesRelaWApi
{
private static readonly string mstrApiControllerName = "cc_PaperStuBatchQuesRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_PaperStuBatchQuesRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatch) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatch) > 10)
{
 throw new Exception("字段[学生试卷批次流水号]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.QuestionID) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.AnswerDate) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.AnswerDate) > 8)
{
 throw new Exception("字段[回答日期]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.AnswerIP) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.AnswerIP) > 30)
{
 throw new Exception("字段[回答IP]的长度不能超过30!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.AnswerModeId) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.AnswerModeId) > 4)
{
 throw new Exception("字段[答案模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.AnswerMultiOptions) > 300)
{
 throw new Exception("字段[多选项答案]的长度不能超过300!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.AnswerOptionId) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.AnswerOptionId) > 8)
{
 throw new Exception("字段[回答选项Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.AnswerTime) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.AnswerTime) > 10)
{
 throw new Exception("字段[回答时间]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.ApplySendBackDate) > 14)
{
 throw new Exception("字段[申请退回日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.MarkDate) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.MarkDate) > 14)
{
 throw new Exception("字段[打分日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.MarkerId) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.MarkerId) > 20)
{
 throw new Exception("字段[打分者]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.OperateTime) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.OperateTime) > 14)
{
 throw new Exception("字段[操作时间]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.RealFinishDate) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.RealFinishDate) > 14)
{
 throw new Exception("字段[实际完成日期]的长度不能超过14!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.WorkTypeId) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.WorkTypeId) > 2)
{
 throw new Exception("字段[作业类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.SchoolYear) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.SchoolYear) > 10)
{
 throw new Exception("字段[学年]的长度不能超过10!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.SchoolTerm) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.SchoolTerm) > 1)
{
 throw new Exception("字段[学期]的长度不能超过1!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.ErrMsg) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.ErrMsg) > 200)
{
 throw new Exception("字段[错误信息]的长度不能超过200!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.CourseId) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.UpdDate) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.UpdUserId) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_PaperStuBatchQuesRelaEN.Memo) && GetStrLen(objcc_PaperStuBatchQuesRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_PaperStuBatchQuesRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId_PaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetObjById_PaperStuBatchQuesRela(long lngId_PaperStuBatchQuesRela)
{
string strAction = "GetObjById_PaperStuBatchQuesRela";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_PaperStuBatchQuesRelaEN = JsonConvert.DeserializeObject<clscc_PaperStuBatchQuesRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_PaperStuBatchQuesRelaEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetObjById_PaperStuBatchQuesRela_WA_Cache(long lngId_PaperStuBatchQuesRela)
{
string strAction = "GetObjById_PaperStuBatchQuesRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_PaperStuBatchQuesRelaEN = JsonConvert.DeserializeObject<clscc_PaperStuBatchQuesRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_PaperStuBatchQuesRelaEN;
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
public static clscc_PaperStuBatchQuesRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = null;
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
objcc_PaperStuBatchQuesRelaEN = JsonConvert.DeserializeObject<clscc_PaperStuBatchQuesRelaEN>((string)jobjReturn["ReturnObj"]);
return objcc_PaperStuBatchQuesRelaEN;
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
 /// <param name = "lngId_PaperStuBatchQuesRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PaperStuBatchQuesRelaEN GetObjById_PaperStuBatchQuesRela_Cache(long lngId_PaperStuBatchQuesRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName_S);
List<clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLst_Sel =
from objcc_PaperStuBatchQuesRelaEN in arrcc_PaperStuBatchQuesRelaObjLst_Cache
where objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela == lngId_PaperStuBatchQuesRela
select objcc_PaperStuBatchQuesRelaEN;
if (arrcc_PaperStuBatchQuesRelaObjLst_Sel.Count() == 0)
{
   clscc_PaperStuBatchQuesRelaEN obj = clscc_PaperStuBatchQuesRelaWApi.GetObjById_PaperStuBatchQuesRela(lngId_PaperStuBatchQuesRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_PaperStuBatchQuesRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLst(string strWhereCond)
{
 List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstById_PaperStuBatchQuesRelaLst(List<long> arrId_PaperStuBatchQuesRela)
{
 List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngId_PaperStuBatchQuesRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_PaperStuBatchQuesRelaEN> GetObjLstById_PaperStuBatchQuesRelaLst_Cache(List<long> arrId_PaperStuBatchQuesRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName_S);
List<clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLst_Sel =
from objcc_PaperStuBatchQuesRelaEN in arrcc_PaperStuBatchQuesRelaObjLst_Cache
where arrId_PaperStuBatchQuesRela.Contains(objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela)
select objcc_PaperStuBatchQuesRelaEN;
return arrcc_PaperStuBatchQuesRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstById_PaperStuBatchQuesRelaLst_WA_Cache(List<long> arrId_PaperStuBatchQuesRela)
{
 List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_PaperStuBatchQuesRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_PaperStuBatchQuesRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PaperStuBatchQuesRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngId_PaperStuBatchQuesRela)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN = clscc_PaperStuBatchQuesRelaWApi.GetObjById_PaperStuBatchQuesRela(lngId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngId_PaperStuBatchQuesRela.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_PaperStuBatchQuesRelaWApi.ReFreshCache();
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
public static int Delcc_PaperStuBatchQuesRelas(List<string> arrId_PaperStuBatchQuesRela)
{
string strAction = "Delcc_PaperStuBatchQuesRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_PaperStuBatchQuesRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_PaperStuBatchQuesRelaWApi.ReFreshCache();
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
public static int Delcc_PaperStuBatchQuesRelasByCond(string strWhereCond)
{
string strAction = "Delcc_PaperStuBatchQuesRelasByCond";
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
public static bool AddNewRecord(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PaperStuBatchQuesRelaEN>(objcc_PaperStuBatchQuesRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaWApi.ReFreshCache();
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PaperStuBatchQuesRelaEN>(objcc_PaperStuBatchQuesRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN)
{
if (string.IsNullOrEmpty(objcc_PaperStuBatchQuesRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PaperStuBatchQuesRelaEN>(objcc_PaperStuBatchQuesRelaEN);
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
 /// <param name = "objcc_PaperStuBatchQuesRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_PaperStuBatchQuesRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PaperStuBatchQuesRelaEN.Id_PaperStuBatchQuesRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PaperStuBatchQuesRelaEN>(objcc_PaperStuBatchQuesRelaEN);
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
public static bool IsExist(long lngId_PaperStuBatchQuesRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_PaperStuBatchQuesRela"] = lngId_PaperStuBatchQuesRela.ToString()
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
 /// <param name = "objcc_PaperStuBatchQuesRelaENS">源对象</param>
 /// <param name = "objcc_PaperStuBatchQuesRelaENT">目标对象</param>
 public static void CopyTo(clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENS, clscc_PaperStuBatchQuesRelaEN objcc_PaperStuBatchQuesRelaENT)
{
try
{
objcc_PaperStuBatchQuesRelaENT.Id_PaperStuBatchQuesRela = objcc_PaperStuBatchQuesRelaENS.Id_PaperStuBatchQuesRela; //学生批次题目关系流水号
objcc_PaperStuBatchQuesRelaENT.Id_PaperStuBatch = objcc_PaperStuBatchQuesRelaENS.Id_PaperStuBatch; //学生试卷批次流水号
objcc_PaperStuBatchQuesRelaENT.QuestionID = objcc_PaperStuBatchQuesRelaENS.QuestionID; //题目ID
objcc_PaperStuBatchQuesRelaENT.QuestionIndex4Batch = objcc_PaperStuBatchQuesRelaENS.QuestionIndex4Batch; //题序号4批次
objcc_PaperStuBatchQuesRelaENT.Scores = objcc_PaperStuBatchQuesRelaENS.Scores; //分值
objcc_PaperStuBatchQuesRelaENT.Score = objcc_PaperStuBatchQuesRelaENS.Score; //得分
objcc_PaperStuBatchQuesRelaENT.StuAnswerText = objcc_PaperStuBatchQuesRelaENS.StuAnswerText; //学生回答文本
objcc_PaperStuBatchQuesRelaENT.AnswerDate = objcc_PaperStuBatchQuesRelaENS.AnswerDate; //回答日期
objcc_PaperStuBatchQuesRelaENT.AnswerIP = objcc_PaperStuBatchQuesRelaENS.AnswerIP; //回答IP
objcc_PaperStuBatchQuesRelaENT.AnswerModeId = objcc_PaperStuBatchQuesRelaENS.AnswerModeId; //答案模式Id
objcc_PaperStuBatchQuesRelaENT.AnswerMultiOptions = objcc_PaperStuBatchQuesRelaENS.AnswerMultiOptions; //多选项答案
objcc_PaperStuBatchQuesRelaENT.AnswerOptionId = objcc_PaperStuBatchQuesRelaENS.AnswerOptionId; //回答选项Id
objcc_PaperStuBatchQuesRelaENT.AnswerTime = objcc_PaperStuBatchQuesRelaENS.AnswerTime; //回答时间
objcc_PaperStuBatchQuesRelaENT.ApplySendBackDate = objcc_PaperStuBatchQuesRelaENS.ApplySendBackDate; //申请退回日期
objcc_PaperStuBatchQuesRelaENT.Comment = objcc_PaperStuBatchQuesRelaENS.Comment; //批注
objcc_PaperStuBatchQuesRelaENT.IsAccessKnowledge = objcc_PaperStuBatchQuesRelaENS.IsAccessKnowledge; //是否处理知识点
objcc_PaperStuBatchQuesRelaENT.IsApplySendBack = objcc_PaperStuBatchQuesRelaENS.IsApplySendBack; //是否申请退回
objcc_PaperStuBatchQuesRelaENT.IsInErrorQuestion = objcc_PaperStuBatchQuesRelaENS.IsInErrorQuestion; //是否进入错题
objcc_PaperStuBatchQuesRelaENT.IsLook = objcc_PaperStuBatchQuesRelaENS.IsLook; //是否查看
objcc_PaperStuBatchQuesRelaENT.IsMarking = objcc_PaperStuBatchQuesRelaENS.IsMarking; //是否批阅
objcc_PaperStuBatchQuesRelaENT.IsNotProcessTimeout = objcc_PaperStuBatchQuesRelaENS.IsNotProcessTimeout; //是否不处理超时
objcc_PaperStuBatchQuesRelaENT.IsPublish = objcc_PaperStuBatchQuesRelaENS.IsPublish; //是否发布
objcc_PaperStuBatchQuesRelaENT.IsRight = objcc_PaperStuBatchQuesRelaENS.IsRight; //是否正确
objcc_PaperStuBatchQuesRelaENT.IsSave = objcc_PaperStuBatchQuesRelaENS.IsSave; //是否保存
objcc_PaperStuBatchQuesRelaENT.IsSendBack = objcc_PaperStuBatchQuesRelaENS.IsSendBack; //是否退回
objcc_PaperStuBatchQuesRelaENT.IsSubmit = objcc_PaperStuBatchQuesRelaENS.IsSubmit; //是否提交
objcc_PaperStuBatchQuesRelaENT.MarkDate = objcc_PaperStuBatchQuesRelaENS.MarkDate; //打分日期
objcc_PaperStuBatchQuesRelaENT.MarkerId = objcc_PaperStuBatchQuesRelaENS.MarkerId; //打分者
objcc_PaperStuBatchQuesRelaENT.OperateTime = objcc_PaperStuBatchQuesRelaENS.OperateTime; //操作时间
objcc_PaperStuBatchQuesRelaENT.RealFinishDate = objcc_PaperStuBatchQuesRelaENS.RealFinishDate; //实际完成日期
objcc_PaperStuBatchQuesRelaENT.WorkTypeId = objcc_PaperStuBatchQuesRelaENS.WorkTypeId; //作业类型Id
objcc_PaperStuBatchQuesRelaENT.SchoolYear = objcc_PaperStuBatchQuesRelaENS.SchoolYear; //学年
objcc_PaperStuBatchQuesRelaENT.SchoolTerm = objcc_PaperStuBatchQuesRelaENS.SchoolTerm; //学期
objcc_PaperStuBatchQuesRelaENT.ErrMsg = objcc_PaperStuBatchQuesRelaENS.ErrMsg; //错误信息
objcc_PaperStuBatchQuesRelaENT.CourseId = objcc_PaperStuBatchQuesRelaENS.CourseId; //课程Id
objcc_PaperStuBatchQuesRelaENT.UpdDate = objcc_PaperStuBatchQuesRelaENS.UpdDate; //修改日期
objcc_PaperStuBatchQuesRelaENT.UpdUserId = objcc_PaperStuBatchQuesRelaENS.UpdUserId; //修改用户Id
objcc_PaperStuBatchQuesRelaENT.Memo = objcc_PaperStuBatchQuesRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_PaperStuBatchQuesRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_PaperStuBatchQuesRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_PaperStuBatchQuesRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_PaperStuBatchQuesRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_PaperStuBatchQuesRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_PaperStuBatchQuesRelaEN.AttributeName)
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
if (clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperStuBatchQuesRelaWApi没有刷新缓存机制(clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_PaperStuBatchQuesRela");
//if (arrcc_PaperStuBatchQuesRelaObjLst_Cache == null)
//{
//arrcc_PaperStuBatchQuesRelaObjLst_Cache = await clscc_PaperStuBatchQuesRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName_S);
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
if (clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_PaperStuBatchQuesRelaWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PaperStuBatchQuesRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRelaEN._CurrTabName_S);
List<clscc_PaperStuBatchQuesRelaEN> arrcc_PaperStuBatchQuesRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_PaperStuBatchQuesRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_PaperStuBatchQuesRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.Id_PaperStuBatch, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.QuestionIndex4Batch, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.Scores, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.StuAnswerText, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.AnswerMultiOptions, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.ApplySendBackDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.Comment, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsApplySendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsInErrorQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsLook, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsNotProcessTimeout, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsPublish, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsSave, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsSendBack, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.MarkDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.OperateTime, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.RealFinishDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.WorkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PaperStuBatchQuesRela.Memo, Type.GetType("System.String"));
foreach (clscc_PaperStuBatchQuesRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela] = objInFor[concc_PaperStuBatchQuesRela.Id_PaperStuBatchQuesRela];
objDR[concc_PaperStuBatchQuesRela.Id_PaperStuBatch] = objInFor[concc_PaperStuBatchQuesRela.Id_PaperStuBatch];
objDR[concc_PaperStuBatchQuesRela.QuestionID] = objInFor[concc_PaperStuBatchQuesRela.QuestionID];
objDR[concc_PaperStuBatchQuesRela.QuestionIndex4Batch] = objInFor[concc_PaperStuBatchQuesRela.QuestionIndex4Batch];
objDR[concc_PaperStuBatchQuesRela.Scores] = objInFor[concc_PaperStuBatchQuesRela.Scores];
objDR[concc_PaperStuBatchQuesRela.Score] = objInFor[concc_PaperStuBatchQuesRela.Score];
objDR[concc_PaperStuBatchQuesRela.StuAnswerText] = objInFor[concc_PaperStuBatchQuesRela.StuAnswerText];
objDR[concc_PaperStuBatchQuesRela.AnswerDate] = objInFor[concc_PaperStuBatchQuesRela.AnswerDate];
objDR[concc_PaperStuBatchQuesRela.AnswerIP] = objInFor[concc_PaperStuBatchQuesRela.AnswerIP];
objDR[concc_PaperStuBatchQuesRela.AnswerModeId] = objInFor[concc_PaperStuBatchQuesRela.AnswerModeId];
objDR[concc_PaperStuBatchQuesRela.AnswerMultiOptions] = objInFor[concc_PaperStuBatchQuesRela.AnswerMultiOptions];
objDR[concc_PaperStuBatchQuesRela.AnswerOptionId] = objInFor[concc_PaperStuBatchQuesRela.AnswerOptionId];
objDR[concc_PaperStuBatchQuesRela.AnswerTime] = objInFor[concc_PaperStuBatchQuesRela.AnswerTime];
objDR[concc_PaperStuBatchQuesRela.ApplySendBackDate] = objInFor[concc_PaperStuBatchQuesRela.ApplySendBackDate];
objDR[concc_PaperStuBatchQuesRela.Comment] = objInFor[concc_PaperStuBatchQuesRela.Comment];
objDR[concc_PaperStuBatchQuesRela.IsAccessKnowledge] = objInFor[concc_PaperStuBatchQuesRela.IsAccessKnowledge];
objDR[concc_PaperStuBatchQuesRela.IsApplySendBack] = objInFor[concc_PaperStuBatchQuesRela.IsApplySendBack];
objDR[concc_PaperStuBatchQuesRela.IsInErrorQuestion] = objInFor[concc_PaperStuBatchQuesRela.IsInErrorQuestion];
objDR[concc_PaperStuBatchQuesRela.IsLook] = objInFor[concc_PaperStuBatchQuesRela.IsLook];
objDR[concc_PaperStuBatchQuesRela.IsMarking] = objInFor[concc_PaperStuBatchQuesRela.IsMarking];
objDR[concc_PaperStuBatchQuesRela.IsNotProcessTimeout] = objInFor[concc_PaperStuBatchQuesRela.IsNotProcessTimeout];
objDR[concc_PaperStuBatchQuesRela.IsPublish] = objInFor[concc_PaperStuBatchQuesRela.IsPublish];
objDR[concc_PaperStuBatchQuesRela.IsRight] = objInFor[concc_PaperStuBatchQuesRela.IsRight];
objDR[concc_PaperStuBatchQuesRela.IsSave] = objInFor[concc_PaperStuBatchQuesRela.IsSave];
objDR[concc_PaperStuBatchQuesRela.IsSendBack] = objInFor[concc_PaperStuBatchQuesRela.IsSendBack];
objDR[concc_PaperStuBatchQuesRela.IsSubmit] = objInFor[concc_PaperStuBatchQuesRela.IsSubmit];
objDR[concc_PaperStuBatchQuesRela.MarkDate] = objInFor[concc_PaperStuBatchQuesRela.MarkDate];
objDR[concc_PaperStuBatchQuesRela.MarkerId] = objInFor[concc_PaperStuBatchQuesRela.MarkerId];
objDR[concc_PaperStuBatchQuesRela.OperateTime] = objInFor[concc_PaperStuBatchQuesRela.OperateTime];
objDR[concc_PaperStuBatchQuesRela.RealFinishDate] = objInFor[concc_PaperStuBatchQuesRela.RealFinishDate];
objDR[concc_PaperStuBatchQuesRela.WorkTypeId] = objInFor[concc_PaperStuBatchQuesRela.WorkTypeId];
objDR[concc_PaperStuBatchQuesRela.SchoolYear] = objInFor[concc_PaperStuBatchQuesRela.SchoolYear];
objDR[concc_PaperStuBatchQuesRela.SchoolTerm] = objInFor[concc_PaperStuBatchQuesRela.SchoolTerm];
objDR[concc_PaperStuBatchQuesRela.ErrMsg] = objInFor[concc_PaperStuBatchQuesRela.ErrMsg];
objDR[concc_PaperStuBatchQuesRela.CourseId] = objInFor[concc_PaperStuBatchQuesRela.CourseId];
objDR[concc_PaperStuBatchQuesRela.UpdDate] = objInFor[concc_PaperStuBatchQuesRela.UpdDate];
objDR[concc_PaperStuBatchQuesRela.UpdUserId] = objInFor[concc_PaperStuBatchQuesRela.UpdUserId];
objDR[concc_PaperStuBatchQuesRela.Memo] = objInFor[concc_PaperStuBatchQuesRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 学生批次题目关系(cc_PaperStuBatchQuesRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_PaperStuBatchQuesRela : clsCommFun4BL
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
clscc_PaperStuBatchQuesRelaWApi.ReFreshThisCache();
clsvcc_PaperStuBatchQuesRelaWApi.ReFreshThisCache();
clsvcc_PaperStuBatchQuesRela_JTWApi.ReFreshThisCache();
}
}

}