
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_AnswerBL
 表名:vqa_Answer(01120635)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvqa_AnswerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_AnswerEN GetObj(this K_AnswerId_vqa_Answer myKey)
{
clsvqa_AnswerEN objvqa_AnswerEN = clsvqa_AnswerBL.vqa_AnswerDA.GetObjByAnswerId(myKey.Value);
return objvqa_AnswerEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetAnswerId(this clsvqa_AnswerEN objvqa_AnswerEN, string strAnswerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerId, 10, convqa_Answer.AnswerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerId, 10, convqa_Answer.AnswerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsId(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, convqa_Answer.QuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, convqa_Answer.QuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, convqa_Answer.QuestionsId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetScore(this clsvqa_AnswerEN objvqa_AnswerEN, float? fltScore, string strComparisonOp="")
	{
objvqa_AnswerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.Score) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.Score, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.Score] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetScoreType(this clsvqa_AnswerEN objvqa_AnswerEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, convqa_Answer.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, convqa_Answer.ScoreType);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetParentId(this clsvqa_AnswerEN objvqa_AnswerEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, convqa_Answer.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, convqa_Answer.ParentId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetVoteCount(this clsvqa_AnswerEN objvqa_AnswerEN, int? intVoteCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetUpdUser(this clsvqa_AnswerEN objvqa_AnswerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convqa_Answer.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetUserName(this clsvqa_AnswerEN objvqa_AnswerEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convqa_Answer.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetUpdDate(this clsvqa_AnswerEN objvqa_AnswerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Answer.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetMemo(this clsvqa_AnswerEN objvqa_AnswerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Answer.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetQaPaperId(this clsvqa_AnswerEN objvqa_AnswerEN, string strQaPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQaPaperId, 8, convqa_Answer.QaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQaPaperId, 8, convqa_Answer.QaPaperId);
}
objvqa_AnswerEN.QaPaperId = strQaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.QaPaperId) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.QaPaperId, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.QaPaperId] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsContent(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convqa_Answer.QuestionsContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetPaperId(this clsvqa_AnswerEN objvqa_AnswerEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Answer.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Answer.PaperId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsTypeId(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeId, 2, convqa_Answer.QuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsTypeId, 2, convqa_Answer.QuestionsTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestionsTypeName(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestionsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convqa_Answer.QuestionsTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetTopicId(this clsvqa_AnswerEN objvqa_AnswerEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convqa_Answer.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convqa_Answer.TopicId);
}
objvqa_AnswerEN.TopicId = strTopicId; //主题Id
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetAnswerTypeId(this clsvqa_AnswerEN objvqa_AnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convqa_Answer.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convqa_Answer.AnswerTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetAnswerCount(this clsvqa_AnswerEN objvqa_AnswerEN, int? intAnswerCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetPaperTitle(this clsvqa_AnswerEN objvqa_AnswerEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Answer.PaperTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetQuestUserName(this clsvqa_AnswerEN objvqa_AnswerEN, string strQuestUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestUserName, 30, convqa_Answer.QuestUserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetAppraiseCount(this clsvqa_AnswerEN objvqa_AnswerEN, int? intAppraiseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetStuScore(this clsvqa_AnswerEN objvqa_AnswerEN, float? fltStuScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetTeaScore(this clsvqa_AnswerEN objvqa_AnswerEN, float? fltTeaScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetUserId(this clsvqa_AnswerEN objvqa_AnswerEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convqa_Answer.UserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_AnswerEN SetIdCurrEduCls(this clsvqa_AnswerEN objvqa_AnswerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convqa_Answer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convqa_Answer.IdCurrEduCls);
}
objvqa_AnswerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_AnswerEN.dicFldComparisonOp.ContainsKey(convqa_Answer.IdCurrEduCls) == false)
{
objvqa_AnswerEN.dicFldComparisonOp.Add(convqa_Answer.IdCurrEduCls, strComparisonOp);
}
else
{
objvqa_AnswerEN.dicFldComparisonOp[convqa_Answer.IdCurrEduCls] = strComparisonOp;
}
}
return objvqa_AnswerEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvqa_AnswerENS">源对象</param>
 /// <param name = "objvqa_AnswerENT">目标对象</param>
 public static void CopyTo(this clsvqa_AnswerEN objvqa_AnswerENS, clsvqa_AnswerEN objvqa_AnswerENT)
{
try
{
objvqa_AnswerENT.AnswerId = objvqa_AnswerENS.AnswerId; //回答Id
objvqa_AnswerENT.QuestionsId = objvqa_AnswerENS.QuestionsId; //提问Id
objvqa_AnswerENT.AnswerContent = objvqa_AnswerENS.AnswerContent; //答案内容
objvqa_AnswerENT.Score = objvqa_AnswerENS.Score; //评分
objvqa_AnswerENT.ScoreType = objvqa_AnswerENS.ScoreType; //评分类型
objvqa_AnswerENT.IsRight = objvqa_AnswerENS.IsRight; //是否正确
objvqa_AnswerENT.ParentId = objvqa_AnswerENS.ParentId; //父节点Id
objvqa_AnswerENT.VoteCount = objvqa_AnswerENS.VoteCount; //点赞计数
objvqa_AnswerENT.UpdUser = objvqa_AnswerENS.UpdUser; //修改人
objvqa_AnswerENT.UserName = objvqa_AnswerENS.UserName; //用户名
objvqa_AnswerENT.UpdDate = objvqa_AnswerENS.UpdDate; //修改日期
objvqa_AnswerENT.Memo = objvqa_AnswerENS.Memo; //备注
objvqa_AnswerENT.QaPaperId = objvqa_AnswerENS.QaPaperId; //论文答疑Id
objvqa_AnswerENT.QuestionsContent = objvqa_AnswerENS.QuestionsContent; //提问内容
objvqa_AnswerENT.PaperId = objvqa_AnswerENS.PaperId; //论文Id
objvqa_AnswerENT.QuestionsTypeId = objvqa_AnswerENS.QuestionsTypeId; //问题类型Id
objvqa_AnswerENT.QuestionsTypeName = objvqa_AnswerENS.QuestionsTypeName; //问题类型名称
objvqa_AnswerENT.IsRecommend = objvqa_AnswerENS.IsRecommend; //是否推荐
objvqa_AnswerENT.TopicId = objvqa_AnswerENS.TopicId; //主题Id
objvqa_AnswerENT.AnswerTypeId = objvqa_AnswerENS.AnswerTypeId; //答案类型ID
objvqa_AnswerENT.IsSubmit = objvqa_AnswerENS.IsSubmit; //是否提交
objvqa_AnswerENT.AnswerCount = objvqa_AnswerENS.AnswerCount; //回答计数
objvqa_AnswerENT.PaperTitle = objvqa_AnswerENS.PaperTitle; //论文标题
objvqa_AnswerENT.QuestUserName = objvqa_AnswerENS.QuestUserName; //QuestUserName
objvqa_AnswerENT.AppraiseCount = objvqa_AnswerENS.AppraiseCount; //评论数
objvqa_AnswerENT.StuScore = objvqa_AnswerENS.StuScore; //学生平均分
objvqa_AnswerENT.TeaScore = objvqa_AnswerENS.TeaScore; //教师评分
objvqa_AnswerENT.UserId = objvqa_AnswerENS.UserId; //用户ID
objvqa_AnswerENT.IdCurrEduCls = objvqa_AnswerENS.IdCurrEduCls; //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvqa_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsvqa_AnswerEN:objvqa_AnswerENT</returns>
 public static clsvqa_AnswerEN CopyTo(this clsvqa_AnswerEN objvqa_AnswerENS)
{
try
{
 clsvqa_AnswerEN objvqa_AnswerENT = new clsvqa_AnswerEN()
{
AnswerId = objvqa_AnswerENS.AnswerId, //回答Id
QuestionsId = objvqa_AnswerENS.QuestionsId, //提问Id
AnswerContent = objvqa_AnswerENS.AnswerContent, //答案内容
Score = objvqa_AnswerENS.Score, //评分
ScoreType = objvqa_AnswerENS.ScoreType, //评分类型
IsRight = objvqa_AnswerENS.IsRight, //是否正确
ParentId = objvqa_AnswerENS.ParentId, //父节点Id
VoteCount = objvqa_AnswerENS.VoteCount, //点赞计数
UpdUser = objvqa_AnswerENS.UpdUser, //修改人
UserName = objvqa_AnswerENS.UserName, //用户名
UpdDate = objvqa_AnswerENS.UpdDate, //修改日期
Memo = objvqa_AnswerENS.Memo, //备注
QaPaperId = objvqa_AnswerENS.QaPaperId, //论文答疑Id
QuestionsContent = objvqa_AnswerENS.QuestionsContent, //提问内容
PaperId = objvqa_AnswerENS.PaperId, //论文Id
QuestionsTypeId = objvqa_AnswerENS.QuestionsTypeId, //问题类型Id
QuestionsTypeName = objvqa_AnswerENS.QuestionsTypeName, //问题类型名称
IsRecommend = objvqa_AnswerENS.IsRecommend, //是否推荐
TopicId = objvqa_AnswerENS.TopicId, //主题Id
AnswerTypeId = objvqa_AnswerENS.AnswerTypeId, //答案类型ID
IsSubmit = objvqa_AnswerENS.IsSubmit, //是否提交
AnswerCount = objvqa_AnswerENS.AnswerCount, //回答计数
PaperTitle = objvqa_AnswerENS.PaperTitle, //论文标题
QuestUserName = objvqa_AnswerENS.QuestUserName, //QuestUserName
AppraiseCount = objvqa_AnswerENS.AppraiseCount, //评论数
StuScore = objvqa_AnswerENS.StuScore, //学生平均分
TeaScore = objvqa_AnswerENS.TeaScore, //教师评分
UserId = objvqa_AnswerENS.UserId, //用户ID
IdCurrEduCls = objvqa_AnswerENS.IdCurrEduCls, //教学班流水号
};
 return objvqa_AnswerENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvqa_AnswerEN objvqa_AnswerEN)
{
 clsvqa_AnswerBL.vqa_AnswerDA.CheckProperty4Condition(objvqa_AnswerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_AnswerEN objvqa_AnswerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.AnswerId) == true)
{
string strComparisonOpAnswerId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.AnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.AnswerId, objvqa_AnswerCond.AnswerId, strComparisonOpAnswerId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.QuestionsId) == true)
{
string strComparisonOpQuestionsId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsId, objvqa_AnswerCond.QuestionsId, strComparisonOpQuestionsId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.Score) == true)
{
string strComparisonOpScore = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.Score, objvqa_AnswerCond.Score, strComparisonOpScore);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.ScoreType) == true)
{
string strComparisonOpScoreType = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.ScoreType, objvqa_AnswerCond.ScoreType, strComparisonOpScoreType);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.IsRight) == true)
{
if (objvqa_AnswerCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Answer.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Answer.IsRight);
}
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.ParentId) == true)
{
string strComparisonOpParentId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.ParentId, objvqa_AnswerCond.ParentId, strComparisonOpParentId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.VoteCount) == true)
{
string strComparisonOpVoteCount = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.VoteCount, objvqa_AnswerCond.VoteCount, strComparisonOpVoteCount);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.UpdUser) == true)
{
string strComparisonOpUpdUser = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UpdUser, objvqa_AnswerCond.UpdUser, strComparisonOpUpdUser);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.UserName) == true)
{
string strComparisonOpUserName = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UserName, objvqa_AnswerCond.UserName, strComparisonOpUserName);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.UpdDate) == true)
{
string strComparisonOpUpdDate = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UpdDate, objvqa_AnswerCond.UpdDate, strComparisonOpUpdDate);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.Memo) == true)
{
string strComparisonOpMemo = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.Memo, objvqa_AnswerCond.Memo, strComparisonOpMemo);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.QaPaperId) == true)
{
string strComparisonOpQaPaperId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.QaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QaPaperId, objvqa_AnswerCond.QaPaperId, strComparisonOpQaPaperId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsContent, objvqa_AnswerCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.PaperId) == true)
{
string strComparisonOpPaperId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.PaperId, objvqa_AnswerCond.PaperId, strComparisonOpPaperId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.QuestionsTypeId) == true)
{
string strComparisonOpQuestionsTypeId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.QuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsTypeId, objvqa_AnswerCond.QuestionsTypeId, strComparisonOpQuestionsTypeId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestionsTypeName, objvqa_AnswerCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.IsRecommend) == true)
{
if (objvqa_AnswerCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Answer.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Answer.IsRecommend);
}
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.TopicId) == true)
{
string strComparisonOpTopicId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.TopicId, objvqa_AnswerCond.TopicId, strComparisonOpTopicId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.AnswerTypeId, objvqa_AnswerCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.IsSubmit) == true)
{
if (objvqa_AnswerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Answer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Answer.IsSubmit);
}
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.AnswerCount, objvqa_AnswerCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.PaperTitle, objvqa_AnswerCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.QuestUserName) == true)
{
string strComparisonOpQuestUserName = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.QuestUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.QuestUserName, objvqa_AnswerCond.QuestUserName, strComparisonOpQuestUserName);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.AppraiseCount, objvqa_AnswerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.StuScore) == true)
{
string strComparisonOpStuScore = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.StuScore, objvqa_AnswerCond.StuScore, strComparisonOpStuScore);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.TeaScore) == true)
{
string strComparisonOpTeaScore = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Answer.TeaScore, objvqa_AnswerCond.TeaScore, strComparisonOpTeaScore);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.UserId) == true)
{
string strComparisonOpUserId = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.UserId, objvqa_AnswerCond.UserId, strComparisonOpUserId);
}
if (objvqa_AnswerCond.IsUpdated(convqa_Answer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvqa_AnswerCond.dicFldComparisonOp[convqa_Answer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Answer.IdCurrEduCls, objvqa_AnswerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vqa_Answer
{
public virtual bool UpdRelaTabDate(string strAnswerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v答疑回答(vqa_Answer)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvqa_AnswerBL
{
public static RelatedActions_vqa_Answer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvqa_AnswerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvqa_AnswerDA vqa_AnswerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvqa_AnswerDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvqa_AnswerBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvqa_AnswerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_AnswerEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vqa_Answer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTable_vqa_Answer(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vqa_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstByAnswerIdLst(List<string> arrAnswerIdLst)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAnswerIdLst, true);
 string strWhereCond = string.Format("AnswerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvqa_AnswerEN> GetObjLstByAnswerIdLstCache(List<string> arrAnswerIdLst, string strTopicId)
{
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
List<clsvqa_AnswerEN> arrvqa_AnswerObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvqa_AnswerEN> arrvqa_AnswerObjLst_Sel =
arrvqa_AnswerObjLstCache
.Where(x => arrAnswerIdLst.Contains(x.AnswerId));
return arrvqa_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLst(string strWhereCond)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvqa_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvqa_AnswerEN> GetSubObjLstCache(clsvqa_AnswerEN objvqa_AnswerCond)
{
 string strTopicId = objvqa_AnswerCond.TopicId;
 if (string.IsNullOrEmpty(strTopicId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvqa_AnswerBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvqa_AnswerEN> arrObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvqa_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Answer.AttributeName)
{
if (objvqa_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objvqa_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_AnswerCond[strFldName].ToString());
}
else
{
if (objvqa_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_AnswerCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvqa_AnswerEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvqa_AnswerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvqa_AnswerEN> arrObjLst = new List<clsvqa_AnswerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_AnswerEN objvqa_AnswerEN = new clsvqa_AnswerEN();
try
{
objvqa_AnswerEN.AnswerId = objRow[convqa_Answer.AnswerId].ToString().Trim(); //回答Id
objvqa_AnswerEN.QuestionsId = objRow[convqa_Answer.QuestionsId].ToString().Trim(); //提问Id
objvqa_AnswerEN.AnswerContent = objRow[convqa_Answer.AnswerContent] == DBNull.Value ? null : objRow[convqa_Answer.AnswerContent].ToString().Trim(); //答案内容
objvqa_AnswerEN.Score = objRow[convqa_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.Score].ToString().Trim()); //评分
objvqa_AnswerEN.ScoreType = objRow[convqa_Answer.ScoreType] == DBNull.Value ? null : objRow[convqa_Answer.ScoreType].ToString().Trim(); //评分类型
objvqa_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRight].ToString().Trim()); //是否正确
objvqa_AnswerEN.ParentId = objRow[convqa_Answer.ParentId] == DBNull.Value ? null : objRow[convqa_Answer.ParentId].ToString().Trim(); //父节点Id
objvqa_AnswerEN.VoteCount = objRow[convqa_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.VoteCount].ToString().Trim()); //点赞计数
objvqa_AnswerEN.UpdUser = objRow[convqa_Answer.UpdUser] == DBNull.Value ? null : objRow[convqa_Answer.UpdUser].ToString().Trim(); //修改人
objvqa_AnswerEN.UserName = objRow[convqa_Answer.UserName] == DBNull.Value ? null : objRow[convqa_Answer.UserName].ToString().Trim(); //用户名
objvqa_AnswerEN.UpdDate = objRow[convqa_Answer.UpdDate] == DBNull.Value ? null : objRow[convqa_Answer.UpdDate].ToString().Trim(); //修改日期
objvqa_AnswerEN.Memo = objRow[convqa_Answer.Memo] == DBNull.Value ? null : objRow[convqa_Answer.Memo].ToString().Trim(); //备注
objvqa_AnswerEN.QaPaperId = objRow[convqa_Answer.QaPaperId] == DBNull.Value ? null : objRow[convqa_Answer.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_AnswerEN.QuestionsContent = objRow[convqa_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvqa_AnswerEN.PaperId = objRow[convqa_Answer.PaperId] == DBNull.Value ? null : objRow[convqa_Answer.PaperId].ToString().Trim(); //论文Id
objvqa_AnswerEN.QuestionsTypeId = objRow[convqa_Answer.QuestionsTypeId] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeId].ToString().Trim(); //问题类型Id
objvqa_AnswerEN.QuestionsTypeName = objRow[convqa_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convqa_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvqa_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvqa_AnswerEN.TopicId = objRow[convqa_Answer.TopicId] == DBNull.Value ? null : objRow[convqa_Answer.TopicId].ToString().Trim(); //主题Id
objvqa_AnswerEN.AnswerTypeId = objRow[convqa_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convqa_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvqa_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Answer.IsSubmit].ToString().Trim()); //是否提交
objvqa_AnswerEN.AnswerCount = objRow[convqa_Answer.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AnswerCount].ToString().Trim()); //回答计数
objvqa_AnswerEN.PaperTitle = objRow[convqa_Answer.PaperTitle] == DBNull.Value ? null : objRow[convqa_Answer.PaperTitle].ToString().Trim(); //论文标题
objvqa_AnswerEN.QuestUserName = objRow[convqa_Answer.QuestUserName] == DBNull.Value ? null : objRow[convqa_Answer.QuestUserName].ToString().Trim(); //QuestUserName
objvqa_AnswerEN.AppraiseCount = objRow[convqa_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Answer.AppraiseCount].ToString().Trim()); //评论数
objvqa_AnswerEN.StuScore = objRow[convqa_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.StuScore].ToString().Trim()); //学生平均分
objvqa_AnswerEN.TeaScore = objRow[convqa_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convqa_Answer.TeaScore].ToString().Trim()); //教师评分
objvqa_AnswerEN.UserId = objRow[convqa_Answer.UserId] == DBNull.Value ? null : objRow[convqa_Answer.UserId].ToString().Trim(); //用户ID
objvqa_AnswerEN.IdCurrEduCls = objRow[convqa_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_AnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_AnswerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvqa_Answer(ref clsvqa_AnswerEN objvqa_AnswerEN)
{
bool bolResult = vqa_AnswerDA.Getvqa_Answer(ref objvqa_AnswerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_AnswerEN GetObjByAnswerId(string strAnswerId)
{
if (strAnswerId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strAnswerId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strAnswerId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvqa_AnswerEN objvqa_AnswerEN = vqa_AnswerDA.GetObjByAnswerId(strAnswerId);
return objvqa_AnswerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvqa_AnswerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvqa_AnswerEN objvqa_AnswerEN = vqa_AnswerDA.GetFirstObj(strWhereCond);
 return objvqa_AnswerEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvqa_AnswerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvqa_AnswerEN objvqa_AnswerEN = vqa_AnswerDA.GetObjByDataRow(objRow);
 return objvqa_AnswerEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvqa_AnswerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvqa_AnswerEN objvqa_AnswerEN = vqa_AnswerDA.GetObjByDataRow(objRow);
 return objvqa_AnswerEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strAnswerId">所给的关键字</param>
 /// <param name = "lstvqa_AnswerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_AnswerEN GetObjByAnswerIdFromList(string strAnswerId, List<clsvqa_AnswerEN> lstvqa_AnswerObjLst)
{
foreach (clsvqa_AnswerEN objvqa_AnswerEN in lstvqa_AnswerObjLst)
{
if (objvqa_AnswerEN.AnswerId == strAnswerId)
{
return objvqa_AnswerEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxAnswerId;
 try
 {
 strMaxAnswerId = clsvqa_AnswerDA.GetMaxStrId();
 return strMaxAnswerId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strAnswerId;
 try
 {
 strAnswerId = new clsvqa_AnswerDA().GetFirstID(strWhereCond);
 return strAnswerId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vqa_AnswerDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vqa_AnswerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strAnswerId)
{
if (string.IsNullOrEmpty(strAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strAnswerId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vqa_AnswerDA.IsExist(strAnswerId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvqa_AnswerDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vqa_AnswerDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
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
objvqa_AnswerENT.Score = objvqa_AnswerENS.Score; //评分
objvqa_AnswerENT.ScoreType = objvqa_AnswerENS.ScoreType; //评分类型
objvqa_AnswerENT.IsRight = objvqa_AnswerENS.IsRight; //是否正确
objvqa_AnswerENT.ParentId = objvqa_AnswerENS.ParentId; //父节点Id
objvqa_AnswerENT.VoteCount = objvqa_AnswerENS.VoteCount; //点赞计数
objvqa_AnswerENT.UpdUser = objvqa_AnswerENS.UpdUser; //修改人
objvqa_AnswerENT.UserName = objvqa_AnswerENS.UserName; //用户名
objvqa_AnswerENT.UpdDate = objvqa_AnswerENS.UpdDate; //修改日期
objvqa_AnswerENT.Memo = objvqa_AnswerENS.Memo; //备注
objvqa_AnswerENT.QaPaperId = objvqa_AnswerENS.QaPaperId; //论文答疑Id
objvqa_AnswerENT.QuestionsContent = objvqa_AnswerENS.QuestionsContent; //提问内容
objvqa_AnswerENT.PaperId = objvqa_AnswerENS.PaperId; //论文Id
objvqa_AnswerENT.QuestionsTypeId = objvqa_AnswerENS.QuestionsTypeId; //问题类型Id
objvqa_AnswerENT.QuestionsTypeName = objvqa_AnswerENS.QuestionsTypeName; //问题类型名称
objvqa_AnswerENT.IsRecommend = objvqa_AnswerENS.IsRecommend; //是否推荐
objvqa_AnswerENT.TopicId = objvqa_AnswerENS.TopicId; //主题Id
objvqa_AnswerENT.AnswerTypeId = objvqa_AnswerENS.AnswerTypeId; //答案类型ID
objvqa_AnswerENT.IsSubmit = objvqa_AnswerENS.IsSubmit; //是否提交
objvqa_AnswerENT.AnswerCount = objvqa_AnswerENS.AnswerCount; //回答计数
objvqa_AnswerENT.PaperTitle = objvqa_AnswerENS.PaperTitle; //论文标题
objvqa_AnswerENT.QuestUserName = objvqa_AnswerENS.QuestUserName; //QuestUserName
objvqa_AnswerENT.AppraiseCount = objvqa_AnswerENS.AppraiseCount; //评论数
objvqa_AnswerENT.StuScore = objvqa_AnswerENS.StuScore; //学生平均分
objvqa_AnswerENT.TeaScore = objvqa_AnswerENS.TeaScore; //教师评分
objvqa_AnswerENT.UserId = objvqa_AnswerENS.UserId; //用户ID
objvqa_AnswerENT.IdCurrEduCls = objvqa_AnswerENS.IdCurrEduCls; //教学班流水号
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">源简化对象</param>
 public static void SetUpdFlag(clsvqa_AnswerEN objvqa_AnswerEN)
{
try
{
objvqa_AnswerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvqa_AnswerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convqa_Answer.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.AnswerId = objvqa_AnswerEN.AnswerId; //回答Id
}
if (arrFldSet.Contains(convqa_Answer.QuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.QuestionsId = objvqa_AnswerEN.QuestionsId; //提问Id
}
if (arrFldSet.Contains(convqa_Answer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.AnswerContent = objvqa_AnswerEN.AnswerContent == "[null]" ? null :  objvqa_AnswerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(convqa_Answer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.Score = objvqa_AnswerEN.Score; //评分
}
if (arrFldSet.Contains(convqa_Answer.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.ScoreType = objvqa_AnswerEN.ScoreType == "[null]" ? null :  objvqa_AnswerEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(convqa_Answer.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.IsRight = objvqa_AnswerEN.IsRight; //是否正确
}
if (arrFldSet.Contains(convqa_Answer.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.ParentId = objvqa_AnswerEN.ParentId == "[null]" ? null :  objvqa_AnswerEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(convqa_Answer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.VoteCount = objvqa_AnswerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convqa_Answer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.UpdUser = objvqa_AnswerEN.UpdUser == "[null]" ? null :  objvqa_AnswerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convqa_Answer.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.UserName = objvqa_AnswerEN.UserName == "[null]" ? null :  objvqa_AnswerEN.UserName; //用户名
}
if (arrFldSet.Contains(convqa_Answer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.UpdDate = objvqa_AnswerEN.UpdDate == "[null]" ? null :  objvqa_AnswerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convqa_Answer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.Memo = objvqa_AnswerEN.Memo == "[null]" ? null :  objvqa_AnswerEN.Memo; //备注
}
if (arrFldSet.Contains(convqa_Answer.QaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.QaPaperId = objvqa_AnswerEN.QaPaperId == "[null]" ? null :  objvqa_AnswerEN.QaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convqa_Answer.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.QuestionsContent = objvqa_AnswerEN.QuestionsContent == "[null]" ? null :  objvqa_AnswerEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(convqa_Answer.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.PaperId = objvqa_AnswerEN.PaperId == "[null]" ? null :  objvqa_AnswerEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convqa_Answer.QuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.QuestionsTypeId = objvqa_AnswerEN.QuestionsTypeId == "[null]" ? null :  objvqa_AnswerEN.QuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(convqa_Answer.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.QuestionsTypeName = objvqa_AnswerEN.QuestionsTypeName == "[null]" ? null :  objvqa_AnswerEN.QuestionsTypeName; //问题类型名称
}
if (arrFldSet.Contains(convqa_Answer.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.IsRecommend = objvqa_AnswerEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(convqa_Answer.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.TopicId = objvqa_AnswerEN.TopicId == "[null]" ? null :  objvqa_AnswerEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convqa_Answer.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.AnswerTypeId = objvqa_AnswerEN.AnswerTypeId == "[null]" ? null :  objvqa_AnswerEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convqa_Answer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.IsSubmit = objvqa_AnswerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convqa_Answer.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.AnswerCount = objvqa_AnswerEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convqa_Answer.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.PaperTitle = objvqa_AnswerEN.PaperTitle == "[null]" ? null :  objvqa_AnswerEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convqa_Answer.QuestUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.QuestUserName = objvqa_AnswerEN.QuestUserName == "[null]" ? null :  objvqa_AnswerEN.QuestUserName; //QuestUserName
}
if (arrFldSet.Contains(convqa_Answer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.AppraiseCount = objvqa_AnswerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convqa_Answer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.StuScore = objvqa_AnswerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convqa_Answer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.TeaScore = objvqa_AnswerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convqa_Answer.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.UserId = objvqa_AnswerEN.UserId == "[null]" ? null :  objvqa_AnswerEN.UserId; //用户ID
}
if (arrFldSet.Contains(convqa_Answer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_AnswerEN.IdCurrEduCls = objvqa_AnswerEN.IdCurrEduCls == "[null]" ? null :  objvqa_AnswerEN.IdCurrEduCls; //教学班流水号
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvqa_AnswerEN">源简化对象</param>
 public static void AccessFldValueNull(clsvqa_AnswerEN objvqa_AnswerEN)
{
try
{
if (objvqa_AnswerEN.AnswerContent == "[null]") objvqa_AnswerEN.AnswerContent = null; //答案内容
if (objvqa_AnswerEN.ScoreType == "[null]") objvqa_AnswerEN.ScoreType = null; //评分类型
if (objvqa_AnswerEN.ParentId == "[null]") objvqa_AnswerEN.ParentId = null; //父节点Id
if (objvqa_AnswerEN.UpdUser == "[null]") objvqa_AnswerEN.UpdUser = null; //修改人
if (objvqa_AnswerEN.UserName == "[null]") objvqa_AnswerEN.UserName = null; //用户名
if (objvqa_AnswerEN.UpdDate == "[null]") objvqa_AnswerEN.UpdDate = null; //修改日期
if (objvqa_AnswerEN.Memo == "[null]") objvqa_AnswerEN.Memo = null; //备注
if (objvqa_AnswerEN.QaPaperId == "[null]") objvqa_AnswerEN.QaPaperId = null; //论文答疑Id
if (objvqa_AnswerEN.QuestionsContent == "[null]") objvqa_AnswerEN.QuestionsContent = null; //提问内容
if (objvqa_AnswerEN.PaperId == "[null]") objvqa_AnswerEN.PaperId = null; //论文Id
if (objvqa_AnswerEN.QuestionsTypeId == "[null]") objvqa_AnswerEN.QuestionsTypeId = null; //问题类型Id
if (objvqa_AnswerEN.QuestionsTypeName == "[null]") objvqa_AnswerEN.QuestionsTypeName = null; //问题类型名称
if (objvqa_AnswerEN.TopicId == "[null]") objvqa_AnswerEN.TopicId = null; //主题Id
if (objvqa_AnswerEN.AnswerTypeId == "[null]") objvqa_AnswerEN.AnswerTypeId = null; //答案类型ID
if (objvqa_AnswerEN.PaperTitle == "[null]") objvqa_AnswerEN.PaperTitle = null; //论文标题
if (objvqa_AnswerEN.QuestUserName == "[null]") objvqa_AnswerEN.QuestUserName = null; //QuestUserName
if (objvqa_AnswerEN.UserId == "[null]") objvqa_AnswerEN.UserId = null; //用户ID
if (objvqa_AnswerEN.IdCurrEduCls == "[null]") objvqa_AnswerEN.IdCurrEduCls = null; //教学班流水号
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvqa_AnswerEN objvqa_AnswerEN)
{
 vqa_AnswerDA.CheckProperty4Condition(objvqa_AnswerEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_AnswerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_AnswerBL没有刷新缓存机制(clsqa_AnswerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsBL没有刷新缓存机制(clsqa_QuestionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_QuestionsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_QuestionsTypeBL没有刷新缓存机制(clsqa_QuestionsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerId");
//if (arrvqa_AnswerObjLstCache == null)
//{
//arrvqa_AnswerObjLstCache = vqa_AnswerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strAnswerId">所给的关键字</param>
 /// <param name = "strTopicId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_AnswerEN GetObjByAnswerIdCache(string strAnswerId, string strTopicId)
{

if (string.IsNullOrEmpty(strTopicId) == true)
{
  var strMsg = string.Format("参数:[strTopicId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTopicId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确!(In {1})", strTopicId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
List<clsvqa_AnswerEN> arrvqa_AnswerObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvqa_AnswerEN> arrvqa_AnswerObjLst_Sel =
arrvqa_AnswerObjLstCache
.Where(x=> x.AnswerId == strAnswerId 
);
if (arrvqa_AnswerObjLst_Sel.Count() == 0)
{
   clsvqa_AnswerEN obj = clsvqa_AnswerBL.GetObjByAnswerId(strAnswerId);
   if (obj != null)
 {
if (obj.TopicId == strTopicId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strAnswerId, strTopicId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvqa_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_AnswerEN> GetAllvqa_AnswerObjLstCache(string strTopicId)
{
//获取缓存中的对象列表
List<clsvqa_AnswerEN> arrvqa_AnswerObjLstCache = GetObjLstCache(strTopicId); 
return arrvqa_AnswerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_AnswerEN> GetObjLstCache(string strTopicId)
{

if (string.IsNullOrEmpty(strTopicId) == true)
{
  var strMsg = string.Format("参数:[strTopicId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strTopicId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strTopicId]的长度:[{0}]不正确!(In {1})", strTopicId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
string strCondition = string.Format("TopicId='{0}'", strTopicId);
List<clsvqa_AnswerEN> arrvqa_AnswerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvqa_AnswerObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strTopicId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvqa_AnswerEN._CurrTabName, strTopicId);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strTopicId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strAnswerId, string strTopicId)
{
if (strInFldName != convqa_Answer.AnswerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convqa_Answer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convqa_Answer.AttributeName));
throw new Exception(strMsg);
}
var objvqa_Answer = clsvqa_AnswerBL.GetObjByAnswerIdCache(strAnswerId, strTopicId);
if (objvqa_Answer == null) return "";
return objvqa_Answer[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvqa_AnswerDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvqa_AnswerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvqa_AnswerDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvqa_AnswerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvqa_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvqa_AnswerEN objvqa_AnswerCond)
{
 string strTopicId = objvqa_AnswerCond.TopicId;
 if (string.IsNullOrEmpty(strTopicId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvqa_AnswerBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvqa_AnswerEN> arrObjLstCache = GetObjLstCache(strTopicId);
IEnumerable <clsvqa_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Answer.AttributeName)
{
if (objvqa_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objvqa_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_AnswerCond[strFldName].ToString());
}
else
{
if (objvqa_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_AnswerCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvqa_AnswerDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vqa_AnswerDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vqa_AnswerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}