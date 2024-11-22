
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_AnswerWApi
 表名:vqa_Answer(01120635)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:03
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
public static class clsvqa_AnswerWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetAnswerId(this clsvqa_AnswerEN objvqa_AnswerEN, string strAnswerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerId, 10, convqa_Answer.AnswerId);
clsCheckSql.CheckFieldForeignKey(strAnswerId, 10, convqa_Answer.AnswerId);
objvqa_AnswerEN.AnswerId = strAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.AnswerId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.AnswerId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.AnswerId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsId(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, convqa_Answer.QuestionsId);
clsCheckSql.CheckFieldLen(strQuestionsId, 8, convqa_Answer.QuestionsId);
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, convqa_Answer.QuestionsId);
objvqa_AnswerEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.QuestionsId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.QuestionsId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.QuestionsId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetAnswerContent(this clsvqa_AnswerEN objvqa_AnswerEN, string strAnswerContent, string strComparisonOp="")
	{
objvqa_AnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.AnswerContent) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.AnswerContent, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.AnswerContent] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN Setscore(this clsvqa_AnswerEN objvqa_AnswerEN, float fltscore, string strComparisonOp="")
	{
objvqa_AnswerEN.score = fltscore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.score) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.score, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.score] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetScoreType(this clsvqa_AnswerEN objvqa_AnswerEN, string strScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strScoreType, 1, convqa_Answer.ScoreType);
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, convqa_Answer.ScoreType);
objvqa_AnswerEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.ScoreType) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.ScoreType, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.ScoreType] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetIsRight(this clsvqa_AnswerEN objvqa_AnswerEN, bool bolIsRight, string strComparisonOp="")
	{
objvqa_AnswerEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.IsRight) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.IsRight, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.IsRight] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetParentId(this clsvqa_AnswerEN objvqa_AnswerEN, string strParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentId, 10, convqa_Answer.ParentId);
clsCheckSql.CheckFieldForeignKey(strParentId, 10, convqa_Answer.ParentId);
objvqa_AnswerEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.ParentId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.ParentId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.ParentId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetVoteCount(this clsvqa_AnswerEN objvqa_AnswerEN, int intVoteCount, string strComparisonOp="")
	{
objvqa_AnswerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.VoteCount) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.VoteCount, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.VoteCount] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetUpdUser(this clsvqa_AnswerEN objvqa_AnswerEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convqa_Answer.UpdUser);
objvqa_AnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.UpdUser) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.UpdUser, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.UpdUser] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetUserName(this clsvqa_AnswerEN objvqa_AnswerEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convqa_Answer.UserName);
objvqa_AnswerEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.UserName) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.UserName, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.UserName] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetUpdDate(this clsvqa_AnswerEN objvqa_AnswerEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Answer.UpdDate);
objvqa_AnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.UpdDate) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.UpdDate, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.UpdDate] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetMemo(this clsvqa_AnswerEN objvqa_AnswerEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Answer.Memo);
objvqa_AnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.Memo) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.Memo, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.Memo] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN Setqa_PaperId(this clsvqa_AnswerEN objvqa_AnswerEN, string strqa_PaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqa_PaperId, 8, convqa_Answer.qa_PaperId);
clsCheckSql.CheckFieldForeignKey(strqa_PaperId, 8, convqa_Answer.qa_PaperId);
objvqa_AnswerEN.qa_PaperId = strqa_PaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.qa_PaperId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.qa_PaperId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.qa_PaperId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsContent(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convqa_Answer.QuestionsContent);
objvqa_AnswerEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.QuestionsContent) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.QuestionsContent, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.QuestionsContent] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetPaperId(this clsvqa_AnswerEN objvqa_AnswerEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Answer.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Answer.PaperId);
objvqa_AnswerEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.PaperId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.PaperId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.PaperId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsTypeId(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, convqa_Answer.QuestionsTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, convqa_Answer.QuestionsTypeId);
objvqa_AnswerEN.QuestionsTypeId = strQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.QuestionsTypeId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.QuestionsTypeId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.QuestionsTypeId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsTypeName(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convqa_Answer.QuestionsTypeName);
objvqa_AnswerEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.QuestionsTypeName) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.QuestionsTypeName, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.QuestionsTypeName] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetIsRecommend(this clsvqa_AnswerEN objvqa_AnswerEN, bool bolIsRecommend, string strComparisonOp="")
	{
objvqa_AnswerEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.IsRecommend) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.IsRecommend, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.IsRecommend] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetTopicId(this clsvqa_AnswerEN objvqa_AnswerEN, string strTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicId, 8, convqa_Answer.TopicId);
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convqa_Answer.TopicId);
objvqa_AnswerEN.TopicId = strTopicId; //主题编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.TopicId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.TopicId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.TopicId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetAnswerTypeId(this clsvqa_AnswerEN objvqa_AnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convqa_Answer.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convqa_Answer.AnswerTypeId);
objvqa_AnswerEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.AnswerTypeId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.AnswerTypeId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.AnswerTypeId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetIsSubmit(this clsvqa_AnswerEN objvqa_AnswerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvqa_AnswerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.IsSubmit) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.IsSubmit, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.IsSubmit] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetAnswerCount(this clsvqa_AnswerEN objvqa_AnswerEN, int intAnswerCount, string strComparisonOp="")
	{
objvqa_AnswerEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.AnswerCount) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.AnswerCount, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.AnswerCount] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetPaperTitle(this clsvqa_AnswerEN objvqa_AnswerEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Answer.PaperTitle);
objvqa_AnswerEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.PaperTitle) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.PaperTitle, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.PaperTitle] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestUserName(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestUserName, 30, convqa_Answer.QuestUserName);
objvqa_AnswerEN.QuestUserName = strQuestUserName; //QuestUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.QuestUserName) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.QuestUserName, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.QuestUserName] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetAppraiseCount(this clsvqa_AnswerEN objvqa_AnswerEN, int intAppraiseCount, string strComparisonOp="")
	{
objvqa_AnswerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.AppraiseCount) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.AppraiseCount, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.AppraiseCount] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetStuScore(this clsvqa_AnswerEN objvqa_AnswerEN, float fltStuScore, string strComparisonOp="")
	{
objvqa_AnswerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.StuScore) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.StuScore, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.StuScore] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetTeaScore(this clsvqa_AnswerEN objvqa_AnswerEN, float fltTeaScore, string strComparisonOp="")
	{
objvqa_AnswerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.TeaScore) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.TeaScore, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.TeaScore] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN SetUserId(this clsvqa_AnswerEN objvqa_AnswerEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convqa_Answer.UserId);
objvqa_AnswerEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.UserId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.UserId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.UserId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_AnswerEN Setid_CurrEduCls(this clsvqa_AnswerEN objvqa_AnswerEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convqa_Answer.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convqa_Answer.id_CurrEduCls);
objvqa_AnswerEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.id_CurrEduCls) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.id_CurrEduCls, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.id_CurrEduCls] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_AnswerEN objvqa_Answer_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.AnswerId) == true)
{
string strComparisonOp_AnswerId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.AnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.AnswerId, objvqa_Answer_Cond.AnswerId, strComparisonOp_AnswerId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.QuestionsId) == true)
{
string strComparisonOp_QuestionsId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsId, objvqa_Answer_Cond.QuestionsId, strComparisonOp_QuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.score) == true)
{
string strComparisonOp_score = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.score];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.score, objvqa_Answer_Cond.score, strComparisonOp_score);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.ScoreType) == true)
{
string strComparisonOp_ScoreType = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.ScoreType, objvqa_Answer_Cond.ScoreType, strComparisonOp_ScoreType);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.IsRight) == true)
{
if (objvqa_Answer_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Answer.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Answer.IsRight);
}
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.ParentId) == true)
{
string strComparisonOp_ParentId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.ParentId, objvqa_Answer_Cond.ParentId, strComparisonOp_ParentId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.VoteCount) == true)
{
string strComparisonOp_VoteCount = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.VoteCount, objvqa_Answer_Cond.VoteCount, strComparisonOp_VoteCount);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UpdUser, objvqa_Answer_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.UserName) == true)
{
string strComparisonOp_UserName = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UserName, objvqa_Answer_Cond.UserName, strComparisonOp_UserName);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UpdDate, objvqa_Answer_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.Memo) == true)
{
string strComparisonOp_Memo = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.Memo, objvqa_Answer_Cond.Memo, strComparisonOp_Memo);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.qa_PaperId) == true)
{
string strComparisonOp_qa_PaperId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.qa_PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.qa_PaperId, objvqa_Answer_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.QuestionsContent) == true)
{
string strComparisonOp_QuestionsContent = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsContent, objvqa_Answer_Cond.QuestionsContent, strComparisonOp_QuestionsContent);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.PaperId) == true)
{
string strComparisonOp_PaperId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.PaperId, objvqa_Answer_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.QuestionsTypeId) == true)
{
string strComparisonOp_QuestionsTypeId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsTypeId, objvqa_Answer_Cond.QuestionsTypeId, strComparisonOp_QuestionsTypeId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.QuestionsTypeName) == true)
{
string strComparisonOp_QuestionsTypeName = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsTypeName, objvqa_Answer_Cond.QuestionsTypeName, strComparisonOp_QuestionsTypeName);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.IsRecommend) == true)
{
if (objvqa_Answer_Cond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Answer.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Answer.IsRecommend);
}
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.TopicId) == true)
{
string strComparisonOp_TopicId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.TopicId, objvqa_Answer_Cond.TopicId, strComparisonOp_TopicId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.AnswerTypeId, objvqa_Answer_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.IsSubmit) == true)
{
if (objvqa_Answer_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Answer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Answer.IsSubmit);
}
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.AnswerCount) == true)
{
string strComparisonOp_AnswerCount = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.AnswerCount, objvqa_Answer_Cond.AnswerCount, strComparisonOp_AnswerCount);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.PaperTitle, objvqa_Answer_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.QuestUserName) == true)
{
string strComparisonOp_QuestUserName = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.QuestUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestUserName, objvqa_Answer_Cond.QuestUserName, strComparisonOp_QuestUserName);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.AppraiseCount) == true)
{
string strComparisonOp_AppraiseCount = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.AppraiseCount, objvqa_Answer_Cond.AppraiseCount, strComparisonOp_AppraiseCount);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.StuScore) == true)
{
string strComparisonOp_StuScore = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.StuScore, objvqa_Answer_Cond.StuScore, strComparisonOp_StuScore);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.TeaScore) == true)
{
string strComparisonOp_TeaScore = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.TeaScore, objvqa_Answer_Cond.TeaScore, strComparisonOp_TeaScore);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.UserId) == true)
{
string strComparisonOp_UserId = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UserId, objvqa_Answer_Cond.UserId, strComparisonOp_UserId);
}
if (objvqa_Answer_Cond.IsUpdated(convqa_Answer.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvqa_Answer_Cond.dicFldComparisonOp[convqa_Answer.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.id_CurrEduCls, objvqa_Answer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v答疑回答(vqa_Answer)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvqa_AnswerWApi
{
private static readonly string mstrApiControllerName = "vqa_AnswerApi";

 public clsvqa_AnswerWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_AnswerEN GetObjByAnswerId(string strAnswerId)
{
string strAction = "GetObjByAnswerId";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_AnswerEN objvqa_AnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerId"] = strAnswerId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvqa_AnswerEN = JsonConvert.DeserializeObject<clsvqa_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objvqa_AnswerEN;
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
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_AnswerEN GetObjByAnswerId_WA_Cache(string strAnswerId, string strTopicId)
{
string strAction = "GetObjByAnswerId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_AnswerEN objvqa_AnswerEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerId"] = strAnswerId,
["TopicId"] = strTopicId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvqa_AnswerEN = JsonConvert.DeserializeObject<clsvqa_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objvqa_AnswerEN;
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
public static clsvqa_AnswerEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_AnswerEN objvqa_AnswerEN = null;
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
objvqa_AnswerEN = JsonConvert.DeserializeObject<clsvqa_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objvqa_AnswerEN;
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
 /// <param name = "strAnswerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_AnswerEN GetObjByAnswerId_Cache(string strAnswerId, string strTopicId)
{
if (string.IsNullOrEmpty(strAnswerId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName_S, strTopicId);
List<clsvqa_AnswerEN> arrvqa_AnswerObjLst_Cache = GetObjLst_Cache(strTopicId);
IEnumerable <clsvqa_AnswerEN> arrvqa_AnswerObjLst_Sel =
from objvqa_AnswerEN in arrvqa_AnswerObjLst_Cache
where objvqa_AnswerEN.AnswerId == strAnswerId
select objvqa_AnswerEN;
if (arrvqa_AnswerObjLst_Sel.Count() == 0)
{
   clsvqa_AnswerEN obj = clsvqa_AnswerWApi.GetObjByAnswerId(strAnswerId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvqa_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLst(string strWhereCond)
{
 List<clsvqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_AnswerEN> GetObjLstByAnswerIdLst(List<string> arrAnswerId)
{
 List<clsvqa_AnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strAnswerId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvqa_AnswerEN> GetObjLstByAnswerIdLst_Cache(List<string> arrAnswerId, string strTopicId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName_S, strTopicId);
List<clsvqa_AnswerEN> arrvqa_AnswerObjLst_Cache = GetObjLst_Cache(strTopicId);
IEnumerable <clsvqa_AnswerEN> arrvqa_AnswerObjLst_Sel =
from objvqa_AnswerEN in arrvqa_AnswerObjLst_Cache
where arrAnswerId.Contains(objvqa_AnswerEN.AnswerId)
select objvqa_AnswerEN;
return arrvqa_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstByAnswerIdLst_WA_Cache(List<string> arrAnswerId, string strTopicId)
{
 List<clsvqa_AnswerEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TopicId"] = strTopicId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_AnswerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvqa_AnswerEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strAnswerId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerId"] = strAnswerId
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
 /// <param name = "objvqa_AnswerENS">源对象</param>
 /// <param name = "objvqa_AnswerENT">目标对象</param>
 public static void CopyTo(clsvqa_AnswerEN objvqa_AnswerENS, clsvqa_AnswerEN objvqa_AnswerENT)
{
try
{
objvqa_AnswerENT.AnswerId = objvqa_AnswerENS.AnswerId; //回答Id
objvqa_AnswerENT.QuestionsId = objvqa_AnswerENS.QuestionsId; //提问Id
objvqa_AnswerENT.AnswerContent = objvqa_AnswerENS.AnswerContent; //答案内容
objvqa_AnswerENT.score = objvqa_AnswerENS.score; //评分
objvqa_AnswerENT.ScoreType = objvqa_AnswerENS.ScoreType; //评分类型
objvqa_AnswerENT.IsRight = objvqa_AnswerENS.IsRight; //是否正确
objvqa_AnswerENT.ParentId = objvqa_AnswerENS.ParentId; //父节点Id
objvqa_AnswerENT.VoteCount = objvqa_AnswerENS.VoteCount; //点赞计数
objvqa_AnswerENT.UpdUser = objvqa_AnswerENS.UpdUser; //修改人
objvqa_AnswerENT.UserName = objvqa_AnswerENS.UserName; //用户名
objvqa_AnswerENT.UpdDate = objvqa_AnswerENS.UpdDate; //修改日期
objvqa_AnswerENT.Memo = objvqa_AnswerENS.Memo; //备注
objvqa_AnswerENT.qa_PaperId = objvqa_AnswerENS.qa_PaperId; //论文答疑Id
objvqa_AnswerENT.QuestionsContent = objvqa_AnswerENS.QuestionsContent; //提问内容
objvqa_AnswerENT.PaperId = objvqa_AnswerENS.PaperId; //论文Id
objvqa_AnswerENT.QuestionsTypeId = objvqa_AnswerENS.QuestionsTypeId; //问题类型Id
objvqa_AnswerENT.QuestionsTypeName = objvqa_AnswerENS.QuestionsTypeName; //问题类型名称
objvqa_AnswerENT.IsRecommend = objvqa_AnswerENS.IsRecommend; //是否推荐
objvqa_AnswerENT.TopicId = objvqa_AnswerENS.TopicId; //主题编号
objvqa_AnswerENT.AnswerTypeId = objvqa_AnswerENS.AnswerTypeId; //答案类型ID
objvqa_AnswerENT.IsSubmit = objvqa_AnswerENS.IsSubmit; //是否提交
objvqa_AnswerENT.AnswerCount = objvqa_AnswerENS.AnswerCount; //回答计数
objvqa_AnswerENT.PaperTitle = objvqa_AnswerENS.PaperTitle; //论文标题
objvqa_AnswerENT.QuestUserName = objvqa_AnswerENS.QuestUserName; //QuestUserName
objvqa_AnswerENT.AppraiseCount = objvqa_AnswerENS.AppraiseCount; //评论数
objvqa_AnswerENT.StuScore = objvqa_AnswerENS.StuScore; //学生平均分
objvqa_AnswerENT.TeaScore = objvqa_AnswerENS.TeaScore; //教师评分
objvqa_AnswerENT.UserId = objvqa_AnswerENS.UserId; //用户ID
objvqa_AnswerENT.id_CurrEduCls = objvqa_AnswerENS.id_CurrEduCls; //当前教学班流水号
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
public static DataTable ToDataTable(List<clsvqa_AnswerEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvqa_AnswerEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvqa_AnswerEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvqa_AnswerEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvqa_AnswerEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvqa_AnswerEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_AnswerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_AnswerWApi没有刷新缓存机制(clsqa_AnswerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsWApi没有刷新缓存机制(clsqa_QuestionsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsTypeWApi没有刷新缓存机制(clsqa_QuestionsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerId");
//if (arrvqa_AnswerObjLst_Cache == null)
//{
//arrvqa_AnswerObjLst_Cache = await clsvqa_AnswerWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strTopicId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName_S, strTopicId);
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
public static List<clsvqa_AnswerEN> GetObjLst_Cache(string strTopicId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName_S, strTopicId);
List<clsvqa_AnswerEN> arrvqa_AnswerObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("TopicId='{0}'", strTopicId)); });
return arrvqa_AnswerObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvqa_AnswerEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convqa_Answer.AnswerId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.QuestionsId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.AnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.score, Type.GetType("System.Single"));
objDT.Columns.Add(convqa_Answer.ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Answer.ParentId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.VoteCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Answer.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.qa_PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.QuestionsContent, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.QuestionsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.QuestionsTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.IsRecommend, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Answer.TopicId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Answer.AnswerCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Answer.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.QuestUserName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.AppraiseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Answer.StuScore, Type.GetType("System.Single"));
objDT.Columns.Add(convqa_Answer.TeaScore, Type.GetType("System.Single"));
objDT.Columns.Add(convqa_Answer.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Answer.id_CurrEduCls, Type.GetType("System.String"));
foreach (clsvqa_AnswerEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convqa_Answer.AnswerId] = objInFor[convqa_Answer.AnswerId];
objDR[convqa_Answer.QuestionsId] = objInFor[convqa_Answer.QuestionsId];
objDR[convqa_Answer.AnswerContent] = objInFor[convqa_Answer.AnswerContent];
objDR[convqa_Answer.score] = objInFor[convqa_Answer.score];
objDR[convqa_Answer.ScoreType] = objInFor[convqa_Answer.ScoreType];
objDR[convqa_Answer.IsRight] = objInFor[convqa_Answer.IsRight];
objDR[convqa_Answer.ParentId] = objInFor[convqa_Answer.ParentId];
objDR[convqa_Answer.VoteCount] = objInFor[convqa_Answer.VoteCount];
objDR[convqa_Answer.UpdUser] = objInFor[convqa_Answer.UpdUser];
objDR[convqa_Answer.UserName] = objInFor[convqa_Answer.UserName];
objDR[convqa_Answer.UpdDate] = objInFor[convqa_Answer.UpdDate];
objDR[convqa_Answer.Memo] = objInFor[convqa_Answer.Memo];
objDR[convqa_Answer.qa_PaperId] = objInFor[convqa_Answer.qa_PaperId];
objDR[convqa_Answer.QuestionsContent] = objInFor[convqa_Answer.QuestionsContent];
objDR[convqa_Answer.PaperId] = objInFor[convqa_Answer.PaperId];
objDR[convqa_Answer.QuestionsTypeId] = objInFor[convqa_Answer.QuestionsTypeId];
objDR[convqa_Answer.QuestionsTypeName] = objInFor[convqa_Answer.QuestionsTypeName];
objDR[convqa_Answer.IsRecommend] = objInFor[convqa_Answer.IsRecommend];
objDR[convqa_Answer.TopicId] = objInFor[convqa_Answer.TopicId];
objDR[convqa_Answer.AnswerTypeId] = objInFor[convqa_Answer.AnswerTypeId];
objDR[convqa_Answer.IsSubmit] = objInFor[convqa_Answer.IsSubmit];
objDR[convqa_Answer.AnswerCount] = objInFor[convqa_Answer.AnswerCount];
objDR[convqa_Answer.PaperTitle] = objInFor[convqa_Answer.PaperTitle];
objDR[convqa_Answer.QuestUserName] = objInFor[convqa_Answer.QuestUserName];
objDR[convqa_Answer.AppraiseCount] = objInFor[convqa_Answer.AppraiseCount];
objDR[convqa_Answer.StuScore] = objInFor[convqa_Answer.StuScore];
objDR[convqa_Answer.TeaScore] = objInFor[convqa_Answer.TeaScore];
objDR[convqa_Answer.UserId] = objInFor[convqa_Answer.UserId];
objDR[convqa_Answer.id_CurrEduCls] = objInFor[convqa_Answer.id_CurrEduCls];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}