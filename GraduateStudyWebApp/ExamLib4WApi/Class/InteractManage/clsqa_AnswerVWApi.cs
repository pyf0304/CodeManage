
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_AnswerVWApi
 表名:qa_AnswerV(01120756)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:09
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
public static class clsqa_AnswerVWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetAnswerVId(this clsqa_AnswerVEN objqa_AnswerVEN, long lngAnswerVId, string strComparisonOp="")
	{
objqa_AnswerVEN.AnswerVId = lngAnswerVId; //问答历史主键
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.AnswerVId) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.AnswerVId, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.AnswerVId] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetAnswerId(this clsqa_AnswerVEN objqa_AnswerVEN, string strAnswerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerId, conqa_AnswerV.AnswerId);
clsCheckSql.CheckFieldLen(strAnswerId, 10, conqa_AnswerV.AnswerId);
clsCheckSql.CheckFieldForeignKey(strAnswerId, 10, conqa_AnswerV.AnswerId);
objqa_AnswerVEN.AnswerId = strAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.AnswerId) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.AnswerId, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.AnswerId] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetQuestionsId(this clsqa_AnswerVEN objqa_AnswerVEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, conqa_AnswerV.QuestionsId);
clsCheckSql.CheckFieldLen(strQuestionsId, 8, conqa_AnswerV.QuestionsId);
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, conqa_AnswerV.QuestionsId);
objqa_AnswerVEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.QuestionsId) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.QuestionsId, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.QuestionsId] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetAnswerContent(this clsqa_AnswerVEN objqa_AnswerVEN, string strAnswerContent, string strComparisonOp="")
	{
objqa_AnswerVEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.AnswerContent) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.AnswerContent, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.AnswerContent] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN Setscore(this clsqa_AnswerVEN objqa_AnswerVEN, float fltscore, string strComparisonOp="")
	{
objqa_AnswerVEN.score = fltscore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.score) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.score, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.score] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetScoreType(this clsqa_AnswerVEN objqa_AnswerVEN, string strScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strScoreType, 1, conqa_AnswerV.ScoreType);
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, conqa_AnswerV.ScoreType);
objqa_AnswerVEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.ScoreType) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.ScoreType, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.ScoreType] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetIsRight(this clsqa_AnswerVEN objqa_AnswerVEN, bool bolIsRight, string strComparisonOp="")
	{
objqa_AnswerVEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.IsRight) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.IsRight, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.IsRight] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetParentId(this clsqa_AnswerVEN objqa_AnswerVEN, string strParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strParentId, 10, conqa_AnswerV.ParentId);
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conqa_AnswerV.ParentId);
objqa_AnswerVEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.ParentId) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.ParentId, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.ParentId] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetVoteCount(this clsqa_AnswerVEN objqa_AnswerVEN, int intVoteCount, string strComparisonOp="")
	{
objqa_AnswerVEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.VoteCount) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.VoteCount, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.VoteCount] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetIsRecommend(this clsqa_AnswerVEN objqa_AnswerVEN, bool bolIsRecommend, string strComparisonOp="")
	{
objqa_AnswerVEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.IsRecommend) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.IsRecommend, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.IsRecommend] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetTopicId(this clsqa_AnswerVEN objqa_AnswerVEN, string strTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicId, 8, conqa_AnswerV.TopicId);
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, conqa_AnswerV.TopicId);
objqa_AnswerVEN.TopicId = strTopicId; //主题编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.TopicId) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.TopicId, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.TopicId] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetAnswerTypeId(this clsqa_AnswerVEN objqa_AnswerVEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conqa_AnswerV.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conqa_AnswerV.AnswerTypeId);
objqa_AnswerVEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.AnswerTypeId) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.AnswerTypeId, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.AnswerTypeId] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetIsSubmit(this clsqa_AnswerVEN objqa_AnswerVEN, bool bolIsSubmit, string strComparisonOp="")
	{
objqa_AnswerVEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.IsSubmit) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.IsSubmit, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.IsSubmit] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetUpdUser(this clsqa_AnswerVEN objqa_AnswerVEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conqa_AnswerV.UpdUser);
objqa_AnswerVEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.UpdUser) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.UpdUser, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.UpdUser] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetUpdDate(this clsqa_AnswerVEN objqa_AnswerVEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_AnswerV.UpdDate);
objqa_AnswerVEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.UpdDate) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.UpdDate, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.UpdDate] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_AnswerVEN SetMemo(this clsqa_AnswerVEN objqa_AnswerVEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_AnswerV.Memo);
objqa_AnswerVEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_AnswerVEN.dicFldComparisonOp.ContainsKey(conqa_AnswerV.Memo) == false)
{
objqa_AnswerVEN.dicFldComparisonOp.Add(conqa_AnswerV.Memo, strComparisonOp);
}
else
{
objqa_AnswerVEN.dicFldComparisonOp[conqa_AnswerV.Memo] = strComparisonOp;
}
}
return objqa_AnswerVEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_AnswerVEN objqa_AnswerV_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.AnswerVId) == true)
{
string strComparisonOp_AnswerVId = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.AnswerVId];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_AnswerV.AnswerVId, objqa_AnswerV_Cond.AnswerVId, strComparisonOp_AnswerVId);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.AnswerId) == true)
{
string strComparisonOp_AnswerId = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.AnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.AnswerId, objqa_AnswerV_Cond.AnswerId, strComparisonOp_AnswerId);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.QuestionsId) == true)
{
string strComparisonOp_QuestionsId = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.QuestionsId, objqa_AnswerV_Cond.QuestionsId, strComparisonOp_QuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.score) == true)
{
string strComparisonOp_score = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.score];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_AnswerV.score, objqa_AnswerV_Cond.score, strComparisonOp_score);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.ScoreType) == true)
{
string strComparisonOp_ScoreType = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.ScoreType, objqa_AnswerV_Cond.ScoreType, strComparisonOp_ScoreType);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.IsRight) == true)
{
if (objqa_AnswerV_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_AnswerV.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_AnswerV.IsRight);
}
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.ParentId) == true)
{
string strComparisonOp_ParentId = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.ParentId, objqa_AnswerV_Cond.ParentId, strComparisonOp_ParentId);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.VoteCount) == true)
{
string strComparisonOp_VoteCount = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_AnswerV.VoteCount, objqa_AnswerV_Cond.VoteCount, strComparisonOp_VoteCount);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.IsRecommend) == true)
{
if (objqa_AnswerV_Cond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_AnswerV.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_AnswerV.IsRecommend);
}
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.TopicId) == true)
{
string strComparisonOp_TopicId = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.TopicId, objqa_AnswerV_Cond.TopicId, strComparisonOp_TopicId);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.AnswerTypeId, objqa_AnswerV_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.IsSubmit) == true)
{
if (objqa_AnswerV_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_AnswerV.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_AnswerV.IsSubmit);
}
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.UpdUser) == true)
{
string strComparisonOp_UpdUser = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.UpdUser, objqa_AnswerV_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.UpdDate) == true)
{
string strComparisonOp_UpdDate = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.UpdDate, objqa_AnswerV_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objqa_AnswerV_Cond.IsUpdated(conqa_AnswerV.Memo) == true)
{
string strComparisonOp_Memo = objqa_AnswerV_Cond.dicFldComparisonOp[conqa_AnswerV.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_AnswerV.Memo, objqa_AnswerV_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_AnswerVEN objqa_AnswerVEN)
{
 if (objqa_AnswerVEN.AnswerVId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objqa_AnswerVEN.sf_UpdFldSetStr = objqa_AnswerVEN.getsf_UpdFldSetStr();
clsqa_AnswerVWApi.CheckPropertyNew(objqa_AnswerVEN); 
bool bolResult = clsqa_AnswerVWApi.UpdateRecord(objqa_AnswerVEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVWApi.ReFreshCache(objqa_AnswerVEN.TopicId);
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
 /// 检查唯一性(Uniqueness)--qa_AnswerV(答疑回答历史V), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_AnswerVId(this clsqa_AnswerVEN objqa_AnswerVEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_AnswerVEN == null) return "";
if (objqa_AnswerVEN.AnswerVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerVId = '{0}'", objqa_AnswerVEN.AnswerVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerVId !=  {0}", objqa_AnswerVEN.AnswerVId);
 sbCondition.AppendFormat(" and AnswerVId = '{0}'", objqa_AnswerVEN.AnswerVId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_AnswerVEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_AnswerVEN objqa_AnswerVEN)
{
try
{
clsqa_AnswerVWApi.CheckPropertyNew(objqa_AnswerVEN); 
bool bolResult = clsqa_AnswerVWApi.AddNewRecord(objqa_AnswerVEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVWApi.ReFreshCache(objqa_AnswerVEN.TopicId);
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
 /// <param name = "objqa_AnswerVEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_AnswerVEN objqa_AnswerVEN, string strWhereCond)
{
try
{
clsqa_AnswerVWApi.CheckPropertyNew(objqa_AnswerVEN); 
bool bolResult = clsqa_AnswerVWApi.UpdateWithCondition(objqa_AnswerVEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVWApi.ReFreshCache(objqa_AnswerVEN.TopicId);
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
 /// 答疑回答历史V(qa_AnswerV)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsqa_AnswerVWApi
{
private static readonly string mstrApiControllerName = "qa_AnswerVApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsqa_AnswerVWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsqa_AnswerVEN objqa_AnswerVEN)
{
if (!Object.Equals(null, objqa_AnswerVEN.AnswerId) && GetStrLen(objqa_AnswerVEN.AnswerId) > 10)
{
 throw new Exception("字段[回答Id]的长度不能超过10!");
}
if (!Object.Equals(null, objqa_AnswerVEN.QuestionsId) && GetStrLen(objqa_AnswerVEN.QuestionsId) > 8)
{
 throw new Exception("字段[提问Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_AnswerVEN.ScoreType) && GetStrLen(objqa_AnswerVEN.ScoreType) > 1)
{
 throw new Exception("字段[评分类型]的长度不能超过1!");
}
if (!Object.Equals(null, objqa_AnswerVEN.ParentId) && GetStrLen(objqa_AnswerVEN.ParentId) > 10)
{
 throw new Exception("字段[父节点Id]的长度不能超过10!");
}
if (!Object.Equals(null, objqa_AnswerVEN.TopicId) && GetStrLen(objqa_AnswerVEN.TopicId) > 8)
{
 throw new Exception("字段[主题编号]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_AnswerVEN.AnswerTypeId) && GetStrLen(objqa_AnswerVEN.AnswerTypeId) > 2)
{
 throw new Exception("字段[答案类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objqa_AnswerVEN.UpdUser) && GetStrLen(objqa_AnswerVEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_AnswerVEN.UpdDate) && GetStrLen(objqa_AnswerVEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_AnswerVEN.Memo) && GetStrLen(objqa_AnswerVEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objqa_AnswerVEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngAnswerVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_AnswerVEN GetObjByAnswerVId(long lngAnswerVId)
{
string strAction = "GetObjByAnswerVId";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_AnswerVEN objqa_AnswerVEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerVId"] = lngAnswerVId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_AnswerVEN = JsonConvert.DeserializeObject<clsqa_AnswerVEN>((string)jobjReturn["ReturnObj"]);
return objqa_AnswerVEN;
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
 /// <param name = "lngAnswerVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_AnswerVEN GetObjByAnswerVId_WA_Cache(long lngAnswerVId, string strTopicId)
{
string strAction = "GetObjByAnswerVId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_AnswerVEN objqa_AnswerVEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerVId"] = lngAnswerVId.ToString(),
["TopicId"] = strTopicId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_AnswerVEN = JsonConvert.DeserializeObject<clsqa_AnswerVEN>((string)jobjReturn["ReturnObj"]);
return objqa_AnswerVEN;
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
public static clsqa_AnswerVEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_AnswerVEN objqa_AnswerVEN = null;
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
objqa_AnswerVEN = JsonConvert.DeserializeObject<clsqa_AnswerVEN>((string)jobjReturn["ReturnObj"]);
return objqa_AnswerVEN;
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
 /// <param name = "lngAnswerVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_AnswerVEN GetObjByAnswerVId_Cache(long lngAnswerVId, string strTopicId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName_S, strTopicId);
List<clsqa_AnswerVEN> arrqa_AnswerVObjLst_Cache = GetObjLst_Cache(strTopicId);
IEnumerable <clsqa_AnswerVEN> arrqa_AnswerVObjLst_Sel =
from objqa_AnswerVEN in arrqa_AnswerVObjLst_Cache
where objqa_AnswerVEN.AnswerVId == lngAnswerVId
select objqa_AnswerVEN;
if (arrqa_AnswerVObjLst_Sel.Count() == 0)
{
   clsqa_AnswerVEN obj = clsqa_AnswerVWApi.GetObjByAnswerVId(lngAnswerVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrqa_AnswerVObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerVEN> GetObjLst(string strWhereCond)
{
 List<clsqa_AnswerVEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerVEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerVEN> GetObjLstByAnswerVIdLst(List<long> arrAnswerVId)
{
 List<clsqa_AnswerVEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerVIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerVId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerVEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngAnswerVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsqa_AnswerVEN> GetObjLstByAnswerVIdLst_Cache(List<long> arrAnswerVId, string strTopicId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName_S, strTopicId);
List<clsqa_AnswerVEN> arrqa_AnswerVObjLst_Cache = GetObjLst_Cache(strTopicId);
IEnumerable <clsqa_AnswerVEN> arrqa_AnswerVObjLst_Sel =
from objqa_AnswerVEN in arrqa_AnswerVObjLst_Cache
where arrAnswerVId.Contains(objqa_AnswerVEN.AnswerVId)
select objqa_AnswerVEN;
return arrqa_AnswerVObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_AnswerVEN> GetObjLstByAnswerVIdLst_WA_Cache(List<long> arrAnswerVId, string strTopicId)
{
 List<clsqa_AnswerVEN> arrObjLst = null; 
string strAction = "GetObjLstByAnswerVIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TopicId"] = strTopicId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerVId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerVEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerVEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsqa_AnswerVEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerVEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerVEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsqa_AnswerVEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerVEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerVEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsqa_AnswerVEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerVEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_AnswerVEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsqa_AnswerVEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_AnswerVEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngAnswerVId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsqa_AnswerVEN objqa_AnswerVEN = clsqa_AnswerVWApi.GetObjByAnswerVId(lngAnswerVId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngAnswerVId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsqa_AnswerVWApi.ReFreshCache(objqa_AnswerVEN.TopicId);
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
public static int Delqa_AnswerVs(List<string> arrAnswerVId)
{
string strAction = "Delqa_AnswerVs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrAnswerVId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsqa_AnswerVEN objqa_AnswerVEN = clsqa_AnswerVWApi.GetObjByAnswerVId(long.Parse(arrAnswerVId[0]));
clsqa_AnswerVWApi.ReFreshCache(objqa_AnswerVEN.TopicId);
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
public static int Delqa_AnswerVsByCond(string strWhereCond)
{
string strAction = "Delqa_AnswerVsByCond";
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
public static bool AddNewRecord(clsqa_AnswerVEN objqa_AnswerVEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerVEN>(objqa_AnswerVEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVWApi.ReFreshCache(objqa_AnswerVEN.TopicId);
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
 /// <param name = "objqa_AnswerVEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsqa_AnswerVEN objqa_AnswerVEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerVEN>(objqa_AnswerVEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_AnswerVWApi.ReFreshCache(objqa_AnswerVEN.TopicId);
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
public static bool UpdateRecord(clsqa_AnswerVEN objqa_AnswerVEN)
{
if (string.IsNullOrEmpty(objqa_AnswerVEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_AnswerVEN.AnswerVId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerVEN>(objqa_AnswerVEN);
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
 /// <param name = "objqa_AnswerVEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsqa_AnswerVEN objqa_AnswerVEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objqa_AnswerVEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_AnswerVEN.AnswerVId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_AnswerVEN.AnswerVId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_AnswerVEN>(objqa_AnswerVEN);
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
public static bool IsExist(long lngAnswerVId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["AnswerVId"] = lngAnswerVId.ToString()
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
 /// <param name = "objqa_AnswerVENS">源对象</param>
 /// <param name = "objqa_AnswerVENT">目标对象</param>
 public static void CopyTo(clsqa_AnswerVEN objqa_AnswerVENS, clsqa_AnswerVEN objqa_AnswerVENT)
{
try
{
objqa_AnswerVENT.AnswerVId = objqa_AnswerVENS.AnswerVId; //问答历史主键
objqa_AnswerVENT.AnswerId = objqa_AnswerVENS.AnswerId; //回答Id
objqa_AnswerVENT.QuestionsId = objqa_AnswerVENS.QuestionsId; //提问Id
objqa_AnswerVENT.AnswerContent = objqa_AnswerVENS.AnswerContent; //答案内容
objqa_AnswerVENT.score = objqa_AnswerVENS.score; //评分
objqa_AnswerVENT.ScoreType = objqa_AnswerVENS.ScoreType; //评分类型
objqa_AnswerVENT.IsRight = objqa_AnswerVENS.IsRight; //是否正确
objqa_AnswerVENT.ParentId = objqa_AnswerVENS.ParentId; //父节点Id
objqa_AnswerVENT.VoteCount = objqa_AnswerVENS.VoteCount; //点赞计数
objqa_AnswerVENT.IsRecommend = objqa_AnswerVENS.IsRecommend; //是否推荐
objqa_AnswerVENT.TopicId = objqa_AnswerVENS.TopicId; //主题编号
objqa_AnswerVENT.AnswerTypeId = objqa_AnswerVENS.AnswerTypeId; //答案类型ID
objqa_AnswerVENT.IsSubmit = objqa_AnswerVENS.IsSubmit; //是否提交
objqa_AnswerVENT.UpdUser = objqa_AnswerVENS.UpdUser; //修改人
objqa_AnswerVENT.UpdDate = objqa_AnswerVENS.UpdDate; //修改日期
objqa_AnswerVENT.Memo = objqa_AnswerVENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsqa_AnswerVEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsqa_AnswerVEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsqa_AnswerVEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsqa_AnswerVEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsqa_AnswerVEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsqa_AnswerVEN.AttributeName)
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
if (clsqa_AnswerVWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_AnswerVWApi没有刷新缓存机制(clsqa_AnswerVWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerVId");
//if (arrqa_AnswerVObjLst_Cache == null)
//{
//arrqa_AnswerVObjLst_Cache = await clsqa_AnswerVWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName_S, strTopicId);
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
if (clsqa_AnswerVWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName_S, strTopicId);
CacheHelper.Remove(strKey);
clsqa_AnswerVWApi.objCommFun4BL.ReFreshCache(strTopicId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_AnswerVEN> GetObjLst_Cache(string strTopicId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsqa_AnswerVEN._CurrTabName_S, strTopicId);
List<clsqa_AnswerVEN> arrqa_AnswerVObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("TopicId='{0}'", strTopicId)); });
return arrqa_AnswerVObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsqa_AnswerVEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conqa_AnswerV.AnswerVId, Type.GetType("System.Int64"));
objDT.Columns.Add(conqa_AnswerV.AnswerId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.QuestionsId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.AnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.score, Type.GetType("System.Single"));
objDT.Columns.Add(conqa_AnswerV.ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_AnswerV.ParentId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.VoteCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_AnswerV.IsRecommend, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_AnswerV.TopicId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_AnswerV.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_AnswerV.Memo, Type.GetType("System.String"));
foreach (clsqa_AnswerVEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conqa_AnswerV.AnswerVId] = objInFor[conqa_AnswerV.AnswerVId];
objDR[conqa_AnswerV.AnswerId] = objInFor[conqa_AnswerV.AnswerId];
objDR[conqa_AnswerV.QuestionsId] = objInFor[conqa_AnswerV.QuestionsId];
objDR[conqa_AnswerV.AnswerContent] = objInFor[conqa_AnswerV.AnswerContent];
objDR[conqa_AnswerV.score] = objInFor[conqa_AnswerV.score];
objDR[conqa_AnswerV.ScoreType] = objInFor[conqa_AnswerV.ScoreType];
objDR[conqa_AnswerV.IsRight] = objInFor[conqa_AnswerV.IsRight];
objDR[conqa_AnswerV.ParentId] = objInFor[conqa_AnswerV.ParentId];
objDR[conqa_AnswerV.VoteCount] = objInFor[conqa_AnswerV.VoteCount];
objDR[conqa_AnswerV.IsRecommend] = objInFor[conqa_AnswerV.IsRecommend];
objDR[conqa_AnswerV.TopicId] = objInFor[conqa_AnswerV.TopicId];
objDR[conqa_AnswerV.AnswerTypeId] = objInFor[conqa_AnswerV.AnswerTypeId];
objDR[conqa_AnswerV.IsSubmit] = objInFor[conqa_AnswerV.IsSubmit];
objDR[conqa_AnswerV.UpdUser] = objInFor[conqa_AnswerV.UpdUser];
objDR[conqa_AnswerV.UpdDate] = objInFor[conqa_AnswerV.UpdDate];
objDR[conqa_AnswerV.Memo] = objInFor[conqa_AnswerV.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 答疑回答历史V(qa_AnswerV)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4qa_AnswerV : clsCommFun4BLV2
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
clsqa_AnswerVWApi.ReFreshThisCache(strTopicId);
}
}

}