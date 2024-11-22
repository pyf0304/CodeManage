
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerWApi
 表名:qa_Answer(01120641)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:40
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
public static class clsqa_AnswerWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetAnswerId(this clsqa_AnswerEN objqa_AnswerEN, string strAnswerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerId, 10, conqa_Answer.AnswerId);
clsCheckSql.CheckFieldForeignKey(strAnswerId, 10, conqa_Answer.AnswerId);
objqa_AnswerEN.AnswerId = strAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AnswerId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AnswerId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AnswerId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetQuestionsId(this clsqa_AnswerEN objqa_AnswerEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, conqa_Answer.QuestionsId);
clsCheckSql.CheckFieldLen(strQuestionsId, 8, conqa_Answer.QuestionsId);
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, conqa_Answer.QuestionsId);
objqa_AnswerEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.QuestionsId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.QuestionsId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.QuestionsId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetAnswerContent(this clsqa_AnswerEN objqa_AnswerEN, string strAnswerContent, string strComparisonOp="")
	{
objqa_AnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AnswerContent) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AnswerContent, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AnswerContent] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN Setscore(this clsqa_AnswerEN objqa_AnswerEN, float fltscore, string strComparisonOp="")
	{
objqa_AnswerEN.score = fltscore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.score) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.score, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.score] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetScoreType(this clsqa_AnswerEN objqa_AnswerEN, string strScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strScoreType, 1, conqa_Answer.ScoreType);
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, conqa_Answer.ScoreType);
objqa_AnswerEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.ScoreType) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.ScoreType, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.ScoreType] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetIsRight(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsRight, string strComparisonOp="")
	{
objqa_AnswerEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.IsRight) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.IsRight, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.IsRight] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetParentId(this clsqa_AnswerEN objqa_AnswerEN, string strParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentId, 10, conqa_Answer.ParentId);
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conqa_Answer.ParentId);
objqa_AnswerEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.ParentId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.ParentId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.ParentId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetVoteCount(this clsqa_AnswerEN objqa_AnswerEN, int intVoteCount, string strComparisonOp="")
	{
objqa_AnswerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.VoteCount) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.VoteCount, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.VoteCount] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetIsRecommend(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsRecommend, string strComparisonOp="")
	{
objqa_AnswerEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.IsRecommend) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.IsRecommend, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.IsRecommend] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetTopicId(this clsqa_AnswerEN objqa_AnswerEN, string strTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicId, 8, conqa_Answer.TopicId);
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conqa_Answer.TopicId);
objqa_AnswerEN.TopicId = strTopicId; //主题编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.TopicId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.TopicId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.TopicId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetAnswerTypeId(this clsqa_AnswerEN objqa_AnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conqa_Answer.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conqa_Answer.AnswerTypeId);
objqa_AnswerEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AnswerTypeId) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AnswerTypeId, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AnswerTypeId] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetIsSubmit(this clsqa_AnswerEN objqa_AnswerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objqa_AnswerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.IsSubmit) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.IsSubmit, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.IsSubmit] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetAppraiseCount(this clsqa_AnswerEN objqa_AnswerEN, int intAppraiseCount, string strComparisonOp="")
	{
objqa_AnswerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.AppraiseCount) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.AppraiseCount, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.AppraiseCount] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetStuScore(this clsqa_AnswerEN objqa_AnswerEN, float fltStuScore, string strComparisonOp="")
	{
objqa_AnswerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.StuScore) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.StuScore, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.StuScore] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetTeaScore(this clsqa_AnswerEN objqa_AnswerEN, float fltTeaScore, string strComparisonOp="")
	{
objqa_AnswerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.TeaScore) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.TeaScore, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.TeaScore] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetCreateDate(this clsqa_AnswerEN objqa_AnswerEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conqa_Answer.CreateDate);
objqa_AnswerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.CreateDate) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.CreateDate, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.CreateDate] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN Setid_CurrEduCls(this clsqa_AnswerEN objqa_AnswerEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conqa_Answer.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conqa_Answer.id_CurrEduCls);
objqa_AnswerEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.id_CurrEduCls) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.id_CurrEduCls, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.id_CurrEduCls] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetUpdUser(this clsqa_AnswerEN objqa_AnswerEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conqa_Answer.UpdUser);
objqa_AnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.UpdUser) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.UpdUser, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.UpdUser] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetUpdDate(this clsqa_AnswerEN objqa_AnswerEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_Answer.UpdDate);
objqa_AnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.UpdDate) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.UpdDate, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.UpdDate] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerEN SetMemo(this clsqa_AnswerEN objqa_AnswerEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_Answer.Memo);
objqa_AnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerEN.dicFldComparisonOp.ContainsKey(conqa_Answer.Memo) == false)
{
objqa_AnswerEN.dicFldComparisonOp.Add(conqa_Answer.Memo, strComparisonOp);
}
else
{
objqa_AnswerEN.dicFldComparisonOp[conqa_Answer.Memo] = strComparisonOp;
}
}
return objqa_AnswerEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_AnswerEN objqa_Answer_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.AnswerId) == true)
{
string strComparisonOp_AnswerId = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.AnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.AnswerId, objqa_Answer_Cond.AnswerId, strComparisonOp_AnswerId);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.QuestionsId) == true)
{
string strComparisonOp_QuestionsId = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.QuestionsId, objqa_Answer_Cond.QuestionsId, strComparisonOp_QuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.score) == true)
{
string strComparisonOp_score = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.score];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.score, objqa_Answer_Cond.score, strComparisonOp_score);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.ScoreType) == true)
{
string strComparisonOp_ScoreType = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.ScoreType, objqa_Answer_Cond.ScoreType, strComparisonOp_ScoreType);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.IsRight) == true)
{
if (objqa_Answer_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Answer.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Answer.IsRight);
}
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.ParentId) == true)
{
string strComparisonOp_ParentId = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.ParentId, objqa_Answer_Cond.ParentId, strComparisonOp_ParentId);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.VoteCount) == true)
{
string strComparisonOp_VoteCount = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.VoteCount, objqa_Answer_Cond.VoteCount, strComparisonOp_VoteCount);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.IsRecommend) == true)
{
if (objqa_Answer_Cond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Answer.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Answer.IsRecommend);
}
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.TopicId) == true)
{
string strComparisonOp_TopicId = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.TopicId, objqa_Answer_Cond.TopicId, strComparisonOp_TopicId);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.AnswerTypeId, objqa_Answer_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.IsSubmit) == true)
{
if (objqa_Answer_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Answer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Answer.IsSubmit);
}
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.AppraiseCount) == true)
{
string strComparisonOp_AppraiseCount = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.AppraiseCount, objqa_Answer_Cond.AppraiseCount, strComparisonOp_AppraiseCount);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.StuScore) == true)
{
string strComparisonOp_StuScore = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.StuScore, objqa_Answer_Cond.StuScore, strComparisonOp_StuScore);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.TeaScore) == true)
{
string strComparisonOp_TeaScore = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Answer.TeaScore, objqa_Answer_Cond.TeaScore, strComparisonOp_TeaScore);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.CreateDate) == true)
{
string strComparisonOp_CreateDate = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.CreateDate, objqa_Answer_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.id_CurrEduCls, objqa_Answer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.UpdUser) == true)
{
string strComparisonOp_UpdUser = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.UpdUser, objqa_Answer_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.UpdDate) == true)
{
string strComparisonOp_UpdDate = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.UpdDate, objqa_Answer_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objqa_Answer_Cond.IsUpdated(conqa_Answer.Memo) == true)
{
string strComparisonOp_Memo = objqa_Answer_Cond.dicFldComparisonOp[conqa_Answer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Answer.Memo, objqa_Answer_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_AnswerEN objqa_AnswerEN)
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objqa_AnswerEN.sf_UpdFldSetStr = objqa_AnswerEN.getsf_UpdFldSetStr();
clsqa_AnswerWApi.CheckPropertyNew(objqa_AnswerEN); 
bool bolResult = clsqa_AnswerWApi.UpdateRecord(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
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
 /// 检查唯一性(Uniqueness)--qa_Answer(答疑回答), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_AnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_AnswerId(this clsqa_AnswerEN objqa_AnswerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_AnswerEN == null) return "";
if (objqa_AnswerEN.AnswerId == null || objqa_AnswerEN.AnswerId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerId = '{0}'", objqa_AnswerEN.AnswerId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerId !=  '{0}'", objqa_AnswerEN.AnswerId);
 sbCondition.AppendFormat(" and AnswerId = '{0}'", objqa_AnswerEN.AnswerId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_AnswerEN objqa_AnswerEN)
{
try
{
 if (string.IsNullOrEmpty(objqa_AnswerEN.AnswerId) == true || clsqa_AnswerWApi.IsExist(objqa_AnswerEN.AnswerId) == true)
 {
     objqa_AnswerEN.AnswerId = clsqa_AnswerWApi.GetMaxStrId();
 }
clsqa_AnswerWApi.CheckPropertyNew(objqa_AnswerEN); 
bool bolResult = clsqa_AnswerWApi.AddNewRecord(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
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
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objqa_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsqa_AnswerEN objqa_AnswerEN)
{
try
{
clsqa_AnswerWApi.CheckPropertyNew(objqa_AnswerEN); 
string strAnswerId = clsqa_AnswerWApi.AddNewRecordWithMaxId(objqa_AnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
return strAnswerId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
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
 /// <param name = "objqa_AnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_AnswerEN objqa_AnswerEN, string strWhereCond)
{
try
{
clsqa_AnswerWApi.CheckPropertyNew(objqa_AnswerEN); 
bool bolResult = clsqa_AnswerWApi.UpdateWithCondition(objqa_AnswerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
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
 /// 答疑回答(qa_Answer)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsqa_AnswerWApi
{
private static readonly string mstrApiControllerName = "qa_AnswerApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsqa_AnswerWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsqa_AnswerEN objqa_AnswerEN)
{
if (!Object.Equals(null, objqa_AnswerEN.AnswerId) && GetStrLen(objqa_AnswerEN.AnswerId) > 10)
{
 throw new Exception("字段[回答Id]的长度不能超过10!");
}
if (!Object.Equals(null, objqa_AnswerEN.QuestionsId) && GetStrLen(objqa_AnswerEN.QuestionsId) > 8)
{
 throw new Exception("字段[提问Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_AnswerEN.ScoreType) && GetStrLen(objqa_AnswerEN.ScoreType) > 1)
{
 throw new Exception("字段[评分类型]的长度不能超过1!");
}
if (!Object.Equals(null, objqa_AnswerEN.ParentId) && GetStrLen(objqa_AnswerEN.ParentId) > 10)
{
 throw new Exception("字段[父节点Id]的长度不能超过10!");
}
if (!Object.Equals(null, objqa_AnswerEN.TopicId) && GetStrLen(objqa_AnswerEN.TopicId) > 8)
{
 throw new Exception("字段[主题编号]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_AnswerEN.AnswerTypeId) && GetStrLen(objqa_AnswerEN.AnswerTypeId) > 2)
{
 throw new Exception("字段[答案类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objqa_AnswerEN.CreateDate) && GetStrLen(objqa_AnswerEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_AnswerEN.id_CurrEduCls) && GetStrLen(objqa_AnswerEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_AnswerEN.UpdUser) && GetStrLen(objqa_AnswerEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_AnswerEN.UpdDate) && GetStrLen(objqa_AnswerEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_AnswerEN.Memo) && GetStrLen(objqa_AnswerEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objqa_AnswerEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_AnswerEN GetObjByAnswerId(string strAnswerId)
{
string strAction = "GetObjByAnswerId";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_AnswerEN objqa_AnswerEN = null;
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
objqa_AnswerEN = JsonConvert.DeserializeObject<clsqa_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objqa_AnswerEN;
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
public static clsqa_AnswerEN GetObjByAnswerId_WA_Cache(string strAnswerId, string strTopicId)
{
string strAction = "GetObjByAnswerId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_AnswerEN objqa_AnswerEN = null;
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
objqa_AnswerEN = JsonConvert.DeserializeObject<clsqa_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objqa_AnswerEN;
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
public static clsqa_AnswerEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_AnswerEN objqa_AnswerEN = null;
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
objqa_AnswerEN = JsonConvert.DeserializeObject<clsqa_AnswerEN>((string)jobjReturn["ReturnObj"]);
return objqa_AnswerEN;
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
public static clsqa_AnswerEN GetObjByAnswerId_Cache(string strAnswerId, string strTopicId)
{
if (string.IsNullOrEmpty(strAnswerId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName_S, strTopicId);
List<clsqa_AnswerEN> arrqa_AnswerObjLst_Cache = GetObjLst_Cache(strTopicId);
IEnumerable <clsqa_AnswerEN> arrqa_AnswerObjLst_Sel =
from objqa_AnswerEN in arrqa_AnswerObjLst_Cache
where objqa_AnswerEN.AnswerId == strAnswerId
select objqa_AnswerEN;
if (arrqa_AnswerObjLst_Sel.Count() == 0)
{
   clsqa_AnswerEN obj = clsqa_AnswerWApi.GetObjByAnswerId(strAnswerId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrqa_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLst(string strWhereCond)
{
 List<clsqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerEN> GetObjLstByAnswerIdLst(List<string> arrAnswerId)
{
 List<clsqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsqa_AnswerEN> GetObjLstByAnswerIdLst_Cache(List<string> arrAnswerId, string strTopicId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName_S, strTopicId);
List<clsqa_AnswerEN> arrqa_AnswerObjLst_Cache = GetObjLst_Cache(strTopicId);
IEnumerable <clsqa_AnswerEN> arrqa_AnswerObjLst_Sel =
from objqa_AnswerEN in arrqa_AnswerObjLst_Cache
where arrAnswerId.Contains(objqa_AnswerEN.AnswerId)
select objqa_AnswerEN;
return arrqa_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLstByAnswerIdLst_WA_Cache(List<string> arrAnswerId, string strTopicId)
{
 List<clsqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsqa_AnswerEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strAnswerId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerWApi.GetObjByAnswerId(strAnswerId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strAnswerId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
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
public static int Delqa_Answers(List<string> arrAnswerId)
{
string strAction = "Delqa_Answers";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsqa_AnswerEN objqa_AnswerEN = clsqa_AnswerWApi.GetObjByAnswerId(arrAnswerId[0]);
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
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
public static int Delqa_AnswersByCond(string strWhereCond)
{
string strAction = "Delqa_AnswersByCond";
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
public static bool AddNewRecord(clsqa_AnswerEN objqa_AnswerEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerEN>(objqa_AnswerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
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
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsqa_AnswerEN objqa_AnswerEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerEN>(objqa_AnswerEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerWApi.ReFreshCache(objqa_AnswerEN.TopicId);
var strAnswerId = (string)jobjReturn["ReturnStr"];
return strAnswerId;
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
public static bool UpdateRecord(clsqa_AnswerEN objqa_AnswerEN)
{
if (string.IsNullOrEmpty(objqa_AnswerEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_AnswerEN.AnswerId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerEN>(objqa_AnswerEN);
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
 /// <param name = "objqa_AnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsqa_AnswerEN objqa_AnswerEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objqa_AnswerEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_AnswerEN.AnswerId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_AnswerEN.AnswerId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerEN>(objqa_AnswerEN);
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
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objqa_AnswerENS">源对象</param>
 /// <param name = "objqa_AnswerENT">目标对象</param>
 public static void CopyTo(clsqa_AnswerEN objqa_AnswerENS, clsqa_AnswerEN objqa_AnswerENT)
{
try
{
objqa_AnswerENT.AnswerId = objqa_AnswerENS.AnswerId; //回答Id
objqa_AnswerENT.QuestionsId = objqa_AnswerENS.QuestionsId; //提问Id
objqa_AnswerENT.AnswerContent = objqa_AnswerENS.AnswerContent; //答案内容
objqa_AnswerENT.score = objqa_AnswerENS.score; //评分
objqa_AnswerENT.ScoreType = objqa_AnswerENS.ScoreType; //评分类型
objqa_AnswerENT.IsRight = objqa_AnswerENS.IsRight; //是否正确
objqa_AnswerENT.ParentId = objqa_AnswerENS.ParentId; //父节点Id
objqa_AnswerENT.VoteCount = objqa_AnswerENS.VoteCount; //点赞计数
objqa_AnswerENT.IsRecommend = objqa_AnswerENS.IsRecommend; //是否推荐
objqa_AnswerENT.TopicId = objqa_AnswerENS.TopicId; //主题编号
objqa_AnswerENT.AnswerTypeId = objqa_AnswerENS.AnswerTypeId; //答案类型ID
objqa_AnswerENT.IsSubmit = objqa_AnswerENS.IsSubmit; //是否提交
objqa_AnswerENT.AppraiseCount = objqa_AnswerENS.AppraiseCount; //评论数
objqa_AnswerENT.StuScore = objqa_AnswerENS.StuScore; //学生平均分
objqa_AnswerENT.TeaScore = objqa_AnswerENS.TeaScore; //教师评分
objqa_AnswerENT.CreateDate = objqa_AnswerENS.CreateDate; //建立日期
objqa_AnswerENT.id_CurrEduCls = objqa_AnswerENS.id_CurrEduCls; //当前教学班流水号
objqa_AnswerENT.UpdUser = objqa_AnswerENS.UpdUser; //修改人
objqa_AnswerENT.UpdDate = objqa_AnswerENS.UpdDate; //修改日期
objqa_AnswerENT.Memo = objqa_AnswerENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsqa_AnswerEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsqa_AnswerEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsqa_AnswerEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsqa_AnswerEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsqa_AnswerEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsqa_AnswerEN.AttributeName)
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
if (clsqa_AnswerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_AnswerWApi没有刷新缓存机制(clsqa_AnswerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerId");
//if (arrqa_AnswerObjLst_Cache == null)
//{
//arrqa_AnswerObjLst_Cache = await clsqa_AnswerWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName_S, strTopicId);
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
public static void ReFreshCache(string strTopicId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsqa_AnswerWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName_S, strTopicId);
CacheHelper.Remove(strKey);
clsqa_AnswerWApi.objCommFun4BL.ReFreshCache(strTopicId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_AnswerEN> GetObjLst_Cache(string strTopicId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsqa_AnswerEN._CurrTabName_S, strTopicId);
List<clsqa_AnswerEN> arrqa_AnswerObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("TopicId='{0}'", strTopicId)); });
return arrqa_AnswerObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsqa_AnswerEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conqa_Answer.AnswerId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.QuestionsId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.AnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.score, Type.GetType("System.Single"));
objDT.Columns.Add(conqa_Answer.ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Answer.ParentId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.VoteCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Answer.IsRecommend, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Answer.TopicId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Answer.AppraiseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Answer.StuScore, Type.GetType("System.Single"));
objDT.Columns.Add(conqa_Answer.TeaScore, Type.GetType("System.Single"));
objDT.Columns.Add(conqa_Answer.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Answer.Memo, Type.GetType("System.String"));
foreach (clsqa_AnswerEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conqa_Answer.AnswerId] = objInFor[conqa_Answer.AnswerId];
objDR[conqa_Answer.QuestionsId] = objInFor[conqa_Answer.QuestionsId];
objDR[conqa_Answer.AnswerContent] = objInFor[conqa_Answer.AnswerContent];
objDR[conqa_Answer.score] = objInFor[conqa_Answer.score];
objDR[conqa_Answer.ScoreType] = objInFor[conqa_Answer.ScoreType];
objDR[conqa_Answer.IsRight] = objInFor[conqa_Answer.IsRight];
objDR[conqa_Answer.ParentId] = objInFor[conqa_Answer.ParentId];
objDR[conqa_Answer.VoteCount] = objInFor[conqa_Answer.VoteCount];
objDR[conqa_Answer.IsRecommend] = objInFor[conqa_Answer.IsRecommend];
objDR[conqa_Answer.TopicId] = objInFor[conqa_Answer.TopicId];
objDR[conqa_Answer.AnswerTypeId] = objInFor[conqa_Answer.AnswerTypeId];
objDR[conqa_Answer.IsSubmit] = objInFor[conqa_Answer.IsSubmit];
objDR[conqa_Answer.AppraiseCount] = objInFor[conqa_Answer.AppraiseCount];
objDR[conqa_Answer.StuScore] = objInFor[conqa_Answer.StuScore];
objDR[conqa_Answer.TeaScore] = objInFor[conqa_Answer.TeaScore];
objDR[conqa_Answer.CreateDate] = objInFor[conqa_Answer.CreateDate];
objDR[conqa_Answer.id_CurrEduCls] = objInFor[conqa_Answer.id_CurrEduCls];
objDR[conqa_Answer.UpdUser] = objInFor[conqa_Answer.UpdUser];
objDR[conqa_Answer.UpdDate] = objInFor[conqa_Answer.UpdDate];
objDR[conqa_Answer.Memo] = objInFor[conqa_Answer.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 答疑回答(qa_Answer)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4qa_Answer : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strTopicId)
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
clsqa_AnswerWApi.ReFreshThisCache(strTopicId);
clsvqa_AnswerWApi.ReFreshThisCache(strTopicId);
}
}

}