
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_AnswerWApi
 表名:vQuestionnaire_Answer(01120020)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:12
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
public static class clsvQuestionnaire_AnswerWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionID(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionnaire_Answer.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionnaire_Answer.QuestionID);
objvQuestionnaire_AnswerEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.QuestionID) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.QuestionID, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.QuestionID] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetAnswerIndex(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, int intAnswerIndex, string strComparisonOp="")
	{
objvQuestionnaire_AnswerEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.AnswerIndex) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.AnswerIndex, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.AnswerIndex] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetAnswerContent(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strAnswerContent, string strComparisonOp="")
	{
objvQuestionnaire_AnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.AnswerContent) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.AnswerContent, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.AnswerContent] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetProvider(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strProvider, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strProvider, 18, convQuestionnaire_Answer.Provider);
objvQuestionnaire_AnswerEN.Provider = strProvider; //提供者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.Provider) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.Provider, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.Provider] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetScore(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, double dblScore, string strComparisonOp="")
	{
objvQuestionnaire_AnswerEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.Score) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.Score, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.Score] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionIndex(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, int intQuestionIndex, string strComparisonOp="")
	{
objvQuestionnaire_AnswerEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.QuestionIndex) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.QuestionIndex, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.QuestionIndex] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionName(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionName, convQuestionnaire_Answer.QuestionName);
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convQuestionnaire_Answer.QuestionName);
objvQuestionnaire_AnswerEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.QuestionName) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.QuestionName, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.QuestionName] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetChapterId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire_Answer.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire_Answer.ChapterId);
objvQuestionnaire_AnswerEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.ChapterId) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.ChapterId, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.ChapterId] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetSectionId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire_Answer.SectionId);
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire_Answer.SectionId);
objvQuestionnaire_AnswerEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.SectionId) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.SectionId, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.SectionId] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetChapterName(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire_Answer.ChapterName);
objvQuestionnaire_AnswerEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.ChapterName) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.ChapterName, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.ChapterName] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetSectionName(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strSectionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire_Answer.SectionName);
objvQuestionnaire_AnswerEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.SectionName) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.SectionName, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.SectionName] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetChapterName_Sim(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convQuestionnaire_Answer.ChapterName_Sim);
objvQuestionnaire_AnswerEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.ChapterName_Sim) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.ChapterName_Sim, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.ChapterName_Sim] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetSectionName_Sim(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strSectionName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSectionName_Sim, 10, convQuestionnaire_Answer.SectionName_Sim);
objvQuestionnaire_AnswerEN.SectionName_Sim = strSectionName_Sim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.SectionName_Sim) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.SectionName_Sim, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.SectionName_Sim] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionTypeId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire_Answer.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire_Answer.QuestionTypeId);
objvQuestionnaire_AnswerEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.QuestionTypeId) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetGridTitle(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionnaire_Answer.GridTitle);
objvQuestionnaire_AnswerEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.GridTitle) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.GridTitle, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.GridTitle] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetAnswerModeId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convQuestionnaire_Answer.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convQuestionnaire_Answer.AnswerModeId);
objvQuestionnaire_AnswerEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.AnswerModeId) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.AnswerModeId, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.AnswerModeId] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionnaireSetId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convQuestionnaire_Answer.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convQuestionnaire_Answer.QuestionnaireSetId);
objvQuestionnaire_AnswerEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.QuestionnaireSetId) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.QuestionnaireSetId, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.QuestionnaireSetId] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetRoleId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convQuestionnaire_Answer.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convQuestionnaire_Answer.RoleId);
objvQuestionnaire_AnswerEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.RoleId) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.RoleId, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.RoleId] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetIsShow(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, bool bolIsShow, string strComparisonOp="")
	{
objvQuestionnaire_AnswerEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.IsShow) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.IsShow, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.IsShow] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire_AnswerEN objvQuestionnaire_Answer_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.QuestionID, objvQuestionnaire_Answer_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Answer.AnswerIndex, objvQuestionnaire_Answer_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.Provider) == true)
{
string strComparisonOp_Provider = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.Provider];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.Provider, objvQuestionnaire_Answer_Cond.Provider, strComparisonOp_Provider);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.Score) == true)
{
string strComparisonOp_Score = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Answer.Score, objvQuestionnaire_Answer_Cond.Score, strComparisonOp_Score);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Answer.QuestionIndex, objvQuestionnaire_Answer_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.QuestionName, objvQuestionnaire_Answer_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.ChapterId, objvQuestionnaire_Answer_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.SectionId) == true)
{
string strComparisonOp_SectionId = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.SectionId, objvQuestionnaire_Answer_Cond.SectionId, strComparisonOp_SectionId);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.ChapterName, objvQuestionnaire_Answer_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.SectionName) == true)
{
string strComparisonOp_SectionName = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.SectionName, objvQuestionnaire_Answer_Cond.SectionName, strComparisonOp_SectionName);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.ChapterName_Sim, objvQuestionnaire_Answer_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.SectionName_Sim) == true)
{
string strComparisonOp_SectionName_Sim = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.SectionName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.SectionName_Sim, objvQuestionnaire_Answer_Cond.SectionName_Sim, strComparisonOp_SectionName_Sim);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.QuestionTypeId, objvQuestionnaire_Answer_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.GridTitle, objvQuestionnaire_Answer_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.AnswerModeId, objvQuestionnaire_Answer_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.QuestionnaireSetId, objvQuestionnaire_Answer_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.RoleId) == true)
{
string strComparisonOp_RoleId = objvQuestionnaire_Answer_Cond.dicFldComparisonOp[convQuestionnaire_Answer.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.RoleId, objvQuestionnaire_Answer_Cond.RoleId, strComparisonOp_RoleId);
}
if (objvQuestionnaire_Answer_Cond.IsUpdated(convQuestionnaire_Answer.IsShow) == true)
{
if (objvQuestionnaire_Answer_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Answer.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Answer.IsShow);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// vQuestionnaire_Answer(vQuestionnaire_Answer)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire_AnswerWApi
{
private static readonly string mstrApiControllerName = "vQuestionnaire_AnswerApi";

 public clsvQuestionnaire_AnswerWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_AnswerEN GetObjByQuestionID(string strQuestionID)
{
string strAction = "GetObjByQuestionID";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionnaire_AnswerEN = JsonConvert.DeserializeObject<clsvQuestionnaire_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire_AnswerEN;
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
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_AnswerEN GetObjByQuestionID_WA_Cache(string strQuestionID)
{
string strAction = "GetObjByQuestionID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionnaire_AnswerEN = JsonConvert.DeserializeObject<clsvQuestionnaire_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire_AnswerEN;
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
public static clsvQuestionnaire_AnswerEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = null;
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
objvQuestionnaire_AnswerEN = JsonConvert.DeserializeObject<clsvQuestionnaire_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire_AnswerEN;
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
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire_AnswerEN GetObjByQuestionID_Cache(string strQuestionID)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName_S);
List<clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLst_Sel =
from objvQuestionnaire_AnswerEN in arrvQuestionnaire_AnswerObjLst_Cache
where objvQuestionnaire_AnswerEN.QuestionID == strQuestionID
select objvQuestionnaire_AnswerEN;
if (arrvQuestionnaire_AnswerObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire_AnswerEN obj = clsvQuestionnaire_AnswerWApi.GetObjByQuestionID(strQuestionID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionnaire_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionnaire_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByQuestionIDLst(List<string> arrQuestionID)
{
 List<clsvQuestionnaire_AnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionnaire_AnswerEN> GetObjLstByQuestionIDLst_Cache(List<string> arrQuestionID)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName_S);
List<clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLst_Sel =
from objvQuestionnaire_AnswerEN in arrvQuestionnaire_AnswerObjLst_Cache
where arrQuestionID.Contains(objvQuestionnaire_AnswerEN.QuestionID)
select objvQuestionnaire_AnswerEN;
return arrvQuestionnaire_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByQuestionIDLst_WA_Cache(List<string> arrQuestionID)
{
 List<clsvQuestionnaire_AnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionnaire_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionnaire_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strQuestionID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID
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
 /// <param name = "objvQuestionnaire_AnswerENS">源对象</param>
 /// <param name = "objvQuestionnaire_AnswerENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENS, clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENT)
{
try
{
objvQuestionnaire_AnswerENT.QuestionID = objvQuestionnaire_AnswerENS.QuestionID; //题目ID
objvQuestionnaire_AnswerENT.AnswerIndex = objvQuestionnaire_AnswerENS.AnswerIndex; //问答序号
objvQuestionnaire_AnswerENT.AnswerContent = objvQuestionnaire_AnswerENS.AnswerContent; //答案内容
objvQuestionnaire_AnswerENT.Provider = objvQuestionnaire_AnswerENS.Provider; //提供者
objvQuestionnaire_AnswerENT.Score = objvQuestionnaire_AnswerENS.Score; //得分
objvQuestionnaire_AnswerENT.QuestionIndex = objvQuestionnaire_AnswerENS.QuestionIndex; //题目序号
objvQuestionnaire_AnswerENT.QuestionName = objvQuestionnaire_AnswerENS.QuestionName; //题目名称
objvQuestionnaire_AnswerENT.ChapterId = objvQuestionnaire_AnswerENS.ChapterId; //章Id
objvQuestionnaire_AnswerENT.SectionId = objvQuestionnaire_AnswerENS.SectionId; //节Id
objvQuestionnaire_AnswerENT.ChapterName = objvQuestionnaire_AnswerENS.ChapterName; //章名
objvQuestionnaire_AnswerENT.SectionName = objvQuestionnaire_AnswerENS.SectionName; //节名
objvQuestionnaire_AnswerENT.ChapterName_Sim = objvQuestionnaire_AnswerENS.ChapterName_Sim; //章名简称
objvQuestionnaire_AnswerENT.SectionName_Sim = objvQuestionnaire_AnswerENS.SectionName_Sim; //节名简称
objvQuestionnaire_AnswerENT.QuestionTypeId = objvQuestionnaire_AnswerENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_AnswerENT.GridTitle = objvQuestionnaire_AnswerENS.GridTitle; //表格标题
objvQuestionnaire_AnswerENT.AnswerModeId = objvQuestionnaire_AnswerENS.AnswerModeId; //答案模式Id
objvQuestionnaire_AnswerENT.QuestionnaireSetId = objvQuestionnaire_AnswerENS.QuestionnaireSetId; //问卷集ID
objvQuestionnaire_AnswerENT.RoleId = objvQuestionnaire_AnswerENS.RoleId; //角色Id
objvQuestionnaire_AnswerENT.IsShow = objvQuestionnaire_AnswerENS.IsShow; //是否启用
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
public static DataTable ToDataTable(List<clsvQuestionnaire_AnswerEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionnaire_AnswerEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionnaire_AnswerEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionnaire_AnswerEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionnaire_AnswerEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionnaire_AnswerEN.AttributeName)
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
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionID");
//if (arrvQuestionnaire_AnswerObjLst_Cache == null)
//{
//arrvQuestionnaire_AnswerObjLst_Cache = await clsvQuestionnaire_AnswerWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName_S);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName_S);
List<clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionnaire_AnswerObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionnaire_AnswerEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionnaire_Answer.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Answer.AnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.Provider, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convQuestionnaire_Answer.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire_Answer.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.SectionId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.SectionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.SectionName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire_Answer.IsShow, Type.GetType("System.Boolean"));
foreach (clsvQuestionnaire_AnswerEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionnaire_Answer.QuestionID] = objInFor[convQuestionnaire_Answer.QuestionID];
objDR[convQuestionnaire_Answer.AnswerIndex] = objInFor[convQuestionnaire_Answer.AnswerIndex];
objDR[convQuestionnaire_Answer.AnswerContent] = objInFor[convQuestionnaire_Answer.AnswerContent];
objDR[convQuestionnaire_Answer.Provider] = objInFor[convQuestionnaire_Answer.Provider];
objDR[convQuestionnaire_Answer.Score] = objInFor[convQuestionnaire_Answer.Score];
objDR[convQuestionnaire_Answer.QuestionIndex] = objInFor[convQuestionnaire_Answer.QuestionIndex];
objDR[convQuestionnaire_Answer.QuestionName] = objInFor[convQuestionnaire_Answer.QuestionName];
objDR[convQuestionnaire_Answer.ChapterId] = objInFor[convQuestionnaire_Answer.ChapterId];
objDR[convQuestionnaire_Answer.SectionId] = objInFor[convQuestionnaire_Answer.SectionId];
objDR[convQuestionnaire_Answer.ChapterName] = objInFor[convQuestionnaire_Answer.ChapterName];
objDR[convQuestionnaire_Answer.SectionName] = objInFor[convQuestionnaire_Answer.SectionName];
objDR[convQuestionnaire_Answer.ChapterName_Sim] = objInFor[convQuestionnaire_Answer.ChapterName_Sim];
objDR[convQuestionnaire_Answer.SectionName_Sim] = objInFor[convQuestionnaire_Answer.SectionName_Sim];
objDR[convQuestionnaire_Answer.QuestionTypeId] = objInFor[convQuestionnaire_Answer.QuestionTypeId];
objDR[convQuestionnaire_Answer.GridTitle] = objInFor[convQuestionnaire_Answer.GridTitle];
objDR[convQuestionnaire_Answer.AnswerModeId] = objInFor[convQuestionnaire_Answer.AnswerModeId];
objDR[convQuestionnaire_Answer.QuestionnaireSetId] = objInFor[convQuestionnaire_Answer.QuestionnaireSetId];
objDR[convQuestionnaire_Answer.RoleId] = objInFor[convQuestionnaire_Answer.RoleId];
objDR[convQuestionnaire_Answer.IsShow] = objInFor[convQuestionnaire_Answer.IsShow];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}