
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_AnswerBL
 表名:vzx_Answer(01120847)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clsvzx_AnswerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_AnswerEN GetObj(this K_zxAnswerId_vzx_Answer myKey)
{
clsvzx_AnswerEN objvzx_AnswerEN = clsvzx_AnswerBL.vzx_AnswerDA.GetObjByzxAnswerId(myKey.Value);
return objvzx_AnswerEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetAnswerContent(this clsvzx_AnswerEN objvzx_AnswerEN, string strAnswerContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerContent, 8000, convzx_Answer.AnswerContent);
}
objvzx_AnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.AnswerContent) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.AnswerContent, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.AnswerContent] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetzxAnswerId(this clsvzx_AnswerEN objvzx_AnswerEN, string strzxAnswerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxAnswerId, 10, convzx_Answer.zxAnswerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxAnswerId, 10, convzx_Answer.zxAnswerId);
}
objvzx_AnswerEN.zxAnswerId = strzxAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.zxAnswerId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.zxAnswerId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.zxAnswerId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetzxQuestionsId(this clsvzx_AnswerEN objvzx_AnswerEN, string strzxQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxQuestionsId, convzx_Answer.zxQuestionsId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsId, 8, convzx_Answer.zxQuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsId, 8, convzx_Answer.zxQuestionsId);
}
objvzx_AnswerEN.zxQuestionsId = strzxQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.zxQuestionsId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.zxQuestionsId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.zxQuestionsId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetQuestionsTypeName(this clsvzx_AnswerEN objvzx_AnswerEN, string strQuestionsTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsTypeName, 50, convzx_Answer.QuestionsTypeName);
}
objvzx_AnswerEN.QuestionsTypeName = strQuestionsTypeName; //问题类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.QuestionsTypeName) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.QuestionsTypeName, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.QuestionsTypeName] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetTextTitle(this clsvzx_AnswerEN objvzx_AnswerEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_Answer.TextTitle);
}
objvzx_AnswerEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.TextTitle) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.TextTitle, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.TextTitle] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetQuestionsContent(this clsvzx_AnswerEN objvzx_AnswerEN, string strQuestionsContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsContent, 1000, convzx_Answer.QuestionsContent);
}
objvzx_AnswerEN.QuestionsContent = strQuestionsContent; //提问内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.QuestionsContent) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.QuestionsContent, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.QuestionsContent] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetzxQuestionsTypeId(this clsvzx_AnswerEN objvzx_AnswerEN, string strzxQuestionsTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsTypeId, 2, convzx_Answer.zxQuestionsTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsTypeId, 2, convzx_Answer.zxQuestionsTypeId);
}
objvzx_AnswerEN.zxQuestionsTypeId = strzxQuestionsTypeId; //问题类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.zxQuestionsTypeId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.zxQuestionsTypeId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.zxQuestionsTypeId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetUserId(this clsvzx_AnswerEN objvzx_AnswerEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convzx_Answer.UserId);
}
objvzx_AnswerEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.UserId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.UserId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.UserId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetScore(this clsvzx_AnswerEN objvzx_AnswerEN, float? fltScore, string strComparisonOp="")
	{
objvzx_AnswerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.Score) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.Score, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.Score] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetScoreType(this clsvzx_AnswerEN objvzx_AnswerEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, convzx_Answer.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, convzx_Answer.ScoreType);
}
objvzx_AnswerEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.ScoreType) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.ScoreType, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.ScoreType] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetIsRight(this clsvzx_AnswerEN objvzx_AnswerEN, bool bolIsRight, string strComparisonOp="")
	{
objvzx_AnswerEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.IsRight) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.IsRight, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.IsRight] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetParentId(this clsvzx_AnswerEN objvzx_AnswerEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, convzx_Answer.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, convzx_Answer.ParentId);
}
objvzx_AnswerEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.ParentId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.ParentId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.ParentId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetVoteCount(this clsvzx_AnswerEN objvzx_AnswerEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_AnswerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.VoteCount) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.VoteCount, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.VoteCount] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetUpdUser(this clsvzx_AnswerEN objvzx_AnswerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Answer.UpdUser);
}
objvzx_AnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.UpdUser) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.UpdUser, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.UpdUser] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetUserName(this clsvzx_AnswerEN objvzx_AnswerEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_Answer.UserName);
}
objvzx_AnswerEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.UserName) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.UserName, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.UserName] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetUpdDate(this clsvzx_AnswerEN objvzx_AnswerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Answer.UpdDate);
}
objvzx_AnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.UpdDate) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.UpdDate, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.UpdDate] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetMemo(this clsvzx_AnswerEN objvzx_AnswerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Answer.Memo);
}
objvzx_AnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.Memo) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.Memo, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.Memo] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetIsPublic(this clsvzx_AnswerEN objvzx_AnswerEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_AnswerEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.IsPublic) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.IsPublic, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.IsPublic] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetIsRecommend(this clsvzx_AnswerEN objvzx_AnswerEN, bool bolIsRecommend, string strComparisonOp="")
	{
objvzx_AnswerEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.IsRecommend) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.IsRecommend, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.IsRecommend] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetGroupTextId(this clsvzx_AnswerEN objvzx_AnswerEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, convzx_Answer.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_Answer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_Answer.GroupTextId);
}
objvzx_AnswerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.GroupTextId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.GroupTextId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.GroupTextId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetIsSubmit(this clsvzx_AnswerEN objvzx_AnswerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_AnswerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.IsSubmit) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.IsSubmit, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.IsSubmit] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetAppraiseCount(this clsvzx_AnswerEN objvzx_AnswerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_AnswerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.AppraiseCount) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.AppraiseCount, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.AppraiseCount] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetStuScore(this clsvzx_AnswerEN objvzx_AnswerEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_AnswerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.StuScore) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.StuScore, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.StuScore] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetTeaScore(this clsvzx_AnswerEN objvzx_AnswerEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_AnswerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.TeaScore) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.TeaScore, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.TeaScore] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetTextId(this clsvzx_AnswerEN objvzx_AnswerEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_Answer.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_Answer.TextId);
}
objvzx_AnswerEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.TextId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.TextId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.TextId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetAnswerTypeId(this clsvzx_AnswerEN objvzx_AnswerEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convzx_Answer.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convzx_Answer.AnswerTypeId);
}
objvzx_AnswerEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.AnswerTypeId) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.AnswerTypeId, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.AnswerTypeId] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetIdCurrEduCls(this clsvzx_AnswerEN objvzx_AnswerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_Answer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_Answer.IdCurrEduCls);
}
objvzx_AnswerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.IdCurrEduCls) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetCreateDate(this clsvzx_AnswerEN objvzx_AnswerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_Answer.CreateDate);
}
objvzx_AnswerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.CreateDate) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.CreateDate, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.CreateDate] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_AnswerEN SetQuestUserName(this clsvzx_AnswerEN objvzx_AnswerEN, string strQuestUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestUserName, 30, convzx_Answer.QuestUserName);
}
objvzx_AnswerEN.QuestUserName = strQuestUserName; //QuestUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_AnswerEN.dicFldComparisonOp.ContainsKey(convzx_Answer.QuestUserName) == false)
{
objvzx_AnswerEN.dicFldComparisonOp.Add(convzx_Answer.QuestUserName, strComparisonOp);
}
else
{
objvzx_AnswerEN.dicFldComparisonOp[convzx_Answer.QuestUserName] = strComparisonOp;
}
}
return objvzx_AnswerEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_AnswerENS">源对象</param>
 /// <param name = "objvzx_AnswerENT">目标对象</param>
 public static void CopyTo(this clsvzx_AnswerEN objvzx_AnswerENS, clsvzx_AnswerEN objvzx_AnswerENT)
{
try
{
objvzx_AnswerENT.AnswerContent = objvzx_AnswerENS.AnswerContent; //答案内容
objvzx_AnswerENT.zxAnswerId = objvzx_AnswerENS.zxAnswerId; //回答Id
objvzx_AnswerENT.zxQuestionsId = objvzx_AnswerENS.zxQuestionsId; //提问Id
objvzx_AnswerENT.QuestionsTypeName = objvzx_AnswerENS.QuestionsTypeName; //问题类型名称
objvzx_AnswerENT.TextTitle = objvzx_AnswerENS.TextTitle; //TextTitle
objvzx_AnswerENT.QuestionsContent = objvzx_AnswerENS.QuestionsContent; //提问内容
objvzx_AnswerENT.zxQuestionsTypeId = objvzx_AnswerENS.zxQuestionsTypeId; //问题类型Id
objvzx_AnswerENT.UserId = objvzx_AnswerENS.UserId; //用户ID
objvzx_AnswerENT.Score = objvzx_AnswerENS.Score; //评分
objvzx_AnswerENT.ScoreType = objvzx_AnswerENS.ScoreType; //评分类型
objvzx_AnswerENT.IsRight = objvzx_AnswerENS.IsRight; //是否正确
objvzx_AnswerENT.ParentId = objvzx_AnswerENS.ParentId; //父节点Id
objvzx_AnswerENT.VoteCount = objvzx_AnswerENS.VoteCount; //点赞计数
objvzx_AnswerENT.UpdUser = objvzx_AnswerENS.UpdUser; //修改人
objvzx_AnswerENT.UserName = objvzx_AnswerENS.UserName; //用户名
objvzx_AnswerENT.UpdDate = objvzx_AnswerENS.UpdDate; //修改日期
objvzx_AnswerENT.Memo = objvzx_AnswerENS.Memo; //备注
objvzx_AnswerENT.IsPublic = objvzx_AnswerENS.IsPublic; //是否公开
objvzx_AnswerENT.IsRecommend = objvzx_AnswerENS.IsRecommend; //是否推荐
objvzx_AnswerENT.GroupTextId = objvzx_AnswerENS.GroupTextId; //小组Id
objvzx_AnswerENT.IsSubmit = objvzx_AnswerENS.IsSubmit; //是否提交
objvzx_AnswerENT.AppraiseCount = objvzx_AnswerENS.AppraiseCount; //评论数
objvzx_AnswerENT.StuScore = objvzx_AnswerENS.StuScore; //学生平均分
objvzx_AnswerENT.TeaScore = objvzx_AnswerENS.TeaScore; //教师评分
objvzx_AnswerENT.TextId = objvzx_AnswerENS.TextId; //课件Id
objvzx_AnswerENT.AnswerTypeId = objvzx_AnswerENS.AnswerTypeId; //答案类型ID
objvzx_AnswerENT.IdCurrEduCls = objvzx_AnswerENS.IdCurrEduCls; //教学班流水号
objvzx_AnswerENT.CreateDate = objvzx_AnswerENS.CreateDate; //建立日期
objvzx_AnswerENT.QuestUserName = objvzx_AnswerENS.QuestUserName; //QuestUserName
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
 /// <param name = "objvzx_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsvzx_AnswerEN:objvzx_AnswerENT</returns>
 public static clsvzx_AnswerEN CopyTo(this clsvzx_AnswerEN objvzx_AnswerENS)
{
try
{
 clsvzx_AnswerEN objvzx_AnswerENT = new clsvzx_AnswerEN()
{
AnswerContent = objvzx_AnswerENS.AnswerContent, //答案内容
zxAnswerId = objvzx_AnswerENS.zxAnswerId, //回答Id
zxQuestionsId = objvzx_AnswerENS.zxQuestionsId, //提问Id
QuestionsTypeName = objvzx_AnswerENS.QuestionsTypeName, //问题类型名称
TextTitle = objvzx_AnswerENS.TextTitle, //TextTitle
QuestionsContent = objvzx_AnswerENS.QuestionsContent, //提问内容
zxQuestionsTypeId = objvzx_AnswerENS.zxQuestionsTypeId, //问题类型Id
UserId = objvzx_AnswerENS.UserId, //用户ID
Score = objvzx_AnswerENS.Score, //评分
ScoreType = objvzx_AnswerENS.ScoreType, //评分类型
IsRight = objvzx_AnswerENS.IsRight, //是否正确
ParentId = objvzx_AnswerENS.ParentId, //父节点Id
VoteCount = objvzx_AnswerENS.VoteCount, //点赞计数
UpdUser = objvzx_AnswerENS.UpdUser, //修改人
UserName = objvzx_AnswerENS.UserName, //用户名
UpdDate = objvzx_AnswerENS.UpdDate, //修改日期
Memo = objvzx_AnswerENS.Memo, //备注
IsPublic = objvzx_AnswerENS.IsPublic, //是否公开
IsRecommend = objvzx_AnswerENS.IsRecommend, //是否推荐
GroupTextId = objvzx_AnswerENS.GroupTextId, //小组Id
IsSubmit = objvzx_AnswerENS.IsSubmit, //是否提交
AppraiseCount = objvzx_AnswerENS.AppraiseCount, //评论数
StuScore = objvzx_AnswerENS.StuScore, //学生平均分
TeaScore = objvzx_AnswerENS.TeaScore, //教师评分
TextId = objvzx_AnswerENS.TextId, //课件Id
AnswerTypeId = objvzx_AnswerENS.AnswerTypeId, //答案类型ID
IdCurrEduCls = objvzx_AnswerENS.IdCurrEduCls, //教学班流水号
CreateDate = objvzx_AnswerENS.CreateDate, //建立日期
QuestUserName = objvzx_AnswerENS.QuestUserName, //QuestUserName
};
 return objvzx_AnswerENT;
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
public static void CheckProperty4Condition(this clsvzx_AnswerEN objvzx_AnswerEN)
{
 clsvzx_AnswerBL.vzx_AnswerDA.CheckProperty4Condition(objvzx_AnswerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_AnswerEN objvzx_AnswerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.AnswerContent) == true)
{
string strComparisonOpAnswerContent = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.AnswerContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.AnswerContent, objvzx_AnswerCond.AnswerContent, strComparisonOpAnswerContent);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.zxAnswerId) == true)
{
string strComparisonOpzxAnswerId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.zxAnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.zxAnswerId, objvzx_AnswerCond.zxAnswerId, strComparisonOpzxAnswerId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.zxQuestionsId) == true)
{
string strComparisonOpzxQuestionsId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.zxQuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.zxQuestionsId, objvzx_AnswerCond.zxQuestionsId, strComparisonOpzxQuestionsId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.QuestionsTypeName) == true)
{
string strComparisonOpQuestionsTypeName = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.QuestionsTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.QuestionsTypeName, objvzx_AnswerCond.QuestionsTypeName, strComparisonOpQuestionsTypeName);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.TextTitle, objvzx_AnswerCond.TextTitle, strComparisonOpTextTitle);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.QuestionsContent) == true)
{
string strComparisonOpQuestionsContent = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.QuestionsContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.QuestionsContent, objvzx_AnswerCond.QuestionsContent, strComparisonOpQuestionsContent);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.zxQuestionsTypeId) == true)
{
string strComparisonOpzxQuestionsTypeId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.zxQuestionsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.zxQuestionsTypeId, objvzx_AnswerCond.zxQuestionsTypeId, strComparisonOpzxQuestionsTypeId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.UserId) == true)
{
string strComparisonOpUserId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.UserId, objvzx_AnswerCond.UserId, strComparisonOpUserId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.Score) == true)
{
string strComparisonOpScore = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Answer.Score, objvzx_AnswerCond.Score, strComparisonOpScore);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.ScoreType) == true)
{
string strComparisonOpScoreType = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.ScoreType, objvzx_AnswerCond.ScoreType, strComparisonOpScoreType);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.IsRight) == true)
{
if (objvzx_AnswerCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Answer.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Answer.IsRight);
}
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.ParentId) == true)
{
string strComparisonOpParentId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.ParentId, objvzx_AnswerCond.ParentId, strComparisonOpParentId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Answer.VoteCount, objvzx_AnswerCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.UpdUser, objvzx_AnswerCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.UserName) == true)
{
string strComparisonOpUserName = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.UserName, objvzx_AnswerCond.UserName, strComparisonOpUserName);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.UpdDate, objvzx_AnswerCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.Memo) == true)
{
string strComparisonOpMemo = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.Memo, objvzx_AnswerCond.Memo, strComparisonOpMemo);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.IsPublic) == true)
{
if (objvzx_AnswerCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Answer.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Answer.IsPublic);
}
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.IsRecommend) == true)
{
if (objvzx_AnswerCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Answer.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Answer.IsRecommend);
}
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.GroupTextId, objvzx_AnswerCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.IsSubmit) == true)
{
if (objvzx_AnswerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Answer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Answer.IsSubmit);
}
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Answer.AppraiseCount, objvzx_AnswerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Answer.StuScore, objvzx_AnswerCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Answer.TeaScore, objvzx_AnswerCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.TextId) == true)
{
string strComparisonOpTextId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.TextId, objvzx_AnswerCond.TextId, strComparisonOpTextId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.AnswerTypeId, objvzx_AnswerCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.IdCurrEduCls, objvzx_AnswerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.CreateDate, objvzx_AnswerCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_AnswerCond.IsUpdated(convzx_Answer.QuestUserName) == true)
{
string strComparisonOpQuestUserName = objvzx_AnswerCond.dicFldComparisonOp[convzx_Answer.QuestUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Answer.QuestUserName, objvzx_AnswerCond.QuestUserName, strComparisonOpQuestUserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Answer
{
public virtual bool UpdRelaTabDate(string strzxAnswerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Answer(vzx_Answer)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_AnswerBL
{
public static RelatedActions_vzx_Answer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_AnswerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_AnswerDA vzx_AnswerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_AnswerDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_AnswerBL()
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
if (string.IsNullOrEmpty(clsvzx_AnswerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_AnswerEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Answer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_AnswerDA.GetDataTable_vzx_Answer(strWhereCond);
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
objDT = vzx_AnswerDA.GetDataTable(strWhereCond);
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
objDT = vzx_AnswerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_AnswerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_AnswerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_AnswerDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_AnswerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_AnswerEN> GetObjLstByZxAnswerIdLst(List<string> arrZxAnswerIdLst)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxAnswerIdLst, true);
 string strWhereCond = string.Format("zxAnswerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_AnswerEN> GetObjLstByZxAnswerIdLstCache(List<string> arrZxAnswerIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_AnswerEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_AnswerEN> arrvzx_AnswerObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_AnswerEN> arrvzx_AnswerObjLst_Sel =
arrvzx_AnswerObjLstCache
.Where(x => arrZxAnswerIdLst.Contains(x.zxAnswerId));
return arrvzx_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_AnswerEN> GetObjLst(string strWhereCond)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
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
public static List<clsvzx_AnswerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_AnswerEN> GetSubObjLstCache(clsvzx_AnswerEN objvzx_AnswerCond)
{
 string strIdCurrEduCls = objvzx_AnswerCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_AnswerBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_AnswerEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Answer.AttributeName)
{
if (objvzx_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objvzx_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_AnswerCond[strFldName].ToString());
}
else
{
if (objvzx_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_AnswerCond[strFldName]));
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
public static List<clsvzx_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
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
public static List<clsvzx_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
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
List<clsvzx_AnswerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_AnswerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
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
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
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
public static List<clsvzx_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
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
public static List<clsvzx_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_AnswerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_AnswerEN.zxAnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_AnswerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Answer(ref clsvzx_AnswerEN objvzx_AnswerEN)
{
bool bolResult = vzx_AnswerDA.Getvzx_Answer(ref objvzx_AnswerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_AnswerEN GetObjByzxAnswerId(string strzxAnswerId)
{
if (strzxAnswerId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxAnswerId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxAnswerId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_AnswerEN objvzx_AnswerEN = vzx_AnswerDA.GetObjByzxAnswerId(strzxAnswerId);
return objvzx_AnswerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_AnswerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_AnswerEN objvzx_AnswerEN = vzx_AnswerDA.GetFirstObj(strWhereCond);
 return objvzx_AnswerEN;
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
public static clsvzx_AnswerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_AnswerEN objvzx_AnswerEN = vzx_AnswerDA.GetObjByDataRow(objRow);
 return objvzx_AnswerEN;
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
public static clsvzx_AnswerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_AnswerEN objvzx_AnswerEN = vzx_AnswerDA.GetObjByDataRow(objRow);
 return objvzx_AnswerEN;
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
 /// <param name = "strzxAnswerId">所给的关键字</param>
 /// <param name = "lstvzx_AnswerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_AnswerEN GetObjByzxAnswerIdFromList(string strzxAnswerId, List<clsvzx_AnswerEN> lstvzx_AnswerObjLst)
{
foreach (clsvzx_AnswerEN objvzx_AnswerEN in lstvzx_AnswerObjLst)
{
if (objvzx_AnswerEN.zxAnswerId == strzxAnswerId)
{
return objvzx_AnswerEN;
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
 string strMaxZxAnswerId;
 try
 {
 strMaxZxAnswerId = clsvzx_AnswerDA.GetMaxStrId();
 return strMaxZxAnswerId;
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
 string strzxAnswerId;
 try
 {
 strzxAnswerId = new clsvzx_AnswerDA().GetFirstID(strWhereCond);
 return strzxAnswerId;
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
 arrList = vzx_AnswerDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_AnswerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxAnswerId)
{
if (string.IsNullOrEmpty(strzxAnswerId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxAnswerId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_AnswerDA.IsExist(strzxAnswerId);
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
 bolIsExist = clsvzx_AnswerDA.IsExistTable();
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
 bolIsExist = vzx_AnswerDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_AnswerENS">源对象</param>
 /// <param name = "objvzx_AnswerENT">目标对象</param>
 public static void CopyTo(clsvzx_AnswerEN objvzx_AnswerENS, clsvzx_AnswerEN objvzx_AnswerENT)
{
try
{
objvzx_AnswerENT.AnswerContent = objvzx_AnswerENS.AnswerContent; //答案内容
objvzx_AnswerENT.zxAnswerId = objvzx_AnswerENS.zxAnswerId; //回答Id
objvzx_AnswerENT.zxQuestionsId = objvzx_AnswerENS.zxQuestionsId; //提问Id
objvzx_AnswerENT.QuestionsTypeName = objvzx_AnswerENS.QuestionsTypeName; //问题类型名称
objvzx_AnswerENT.TextTitle = objvzx_AnswerENS.TextTitle; //TextTitle
objvzx_AnswerENT.QuestionsContent = objvzx_AnswerENS.QuestionsContent; //提问内容
objvzx_AnswerENT.zxQuestionsTypeId = objvzx_AnswerENS.zxQuestionsTypeId; //问题类型Id
objvzx_AnswerENT.UserId = objvzx_AnswerENS.UserId; //用户ID
objvzx_AnswerENT.Score = objvzx_AnswerENS.Score; //评分
objvzx_AnswerENT.ScoreType = objvzx_AnswerENS.ScoreType; //评分类型
objvzx_AnswerENT.IsRight = objvzx_AnswerENS.IsRight; //是否正确
objvzx_AnswerENT.ParentId = objvzx_AnswerENS.ParentId; //父节点Id
objvzx_AnswerENT.VoteCount = objvzx_AnswerENS.VoteCount; //点赞计数
objvzx_AnswerENT.UpdUser = objvzx_AnswerENS.UpdUser; //修改人
objvzx_AnswerENT.UserName = objvzx_AnswerENS.UserName; //用户名
objvzx_AnswerENT.UpdDate = objvzx_AnswerENS.UpdDate; //修改日期
objvzx_AnswerENT.Memo = objvzx_AnswerENS.Memo; //备注
objvzx_AnswerENT.IsPublic = objvzx_AnswerENS.IsPublic; //是否公开
objvzx_AnswerENT.IsRecommend = objvzx_AnswerENS.IsRecommend; //是否推荐
objvzx_AnswerENT.GroupTextId = objvzx_AnswerENS.GroupTextId; //小组Id
objvzx_AnswerENT.IsSubmit = objvzx_AnswerENS.IsSubmit; //是否提交
objvzx_AnswerENT.AppraiseCount = objvzx_AnswerENS.AppraiseCount; //评论数
objvzx_AnswerENT.StuScore = objvzx_AnswerENS.StuScore; //学生平均分
objvzx_AnswerENT.TeaScore = objvzx_AnswerENS.TeaScore; //教师评分
objvzx_AnswerENT.TextId = objvzx_AnswerENS.TextId; //课件Id
objvzx_AnswerENT.AnswerTypeId = objvzx_AnswerENS.AnswerTypeId; //答案类型ID
objvzx_AnswerENT.IdCurrEduCls = objvzx_AnswerENS.IdCurrEduCls; //教学班流水号
objvzx_AnswerENT.CreateDate = objvzx_AnswerENS.CreateDate; //建立日期
objvzx_AnswerENT.QuestUserName = objvzx_AnswerENS.QuestUserName; //QuestUserName
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
 /// <param name = "objvzx_AnswerEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_AnswerEN objvzx_AnswerEN)
{
try
{
objvzx_AnswerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_AnswerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Answer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.AnswerContent = objvzx_AnswerEN.AnswerContent == "[null]" ? null :  objvzx_AnswerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(convzx_Answer.zxAnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.zxAnswerId = objvzx_AnswerEN.zxAnswerId; //回答Id
}
if (arrFldSet.Contains(convzx_Answer.zxQuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.zxQuestionsId = objvzx_AnswerEN.zxQuestionsId; //提问Id
}
if (arrFldSet.Contains(convzx_Answer.QuestionsTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.QuestionsTypeName = objvzx_AnswerEN.QuestionsTypeName == "[null]" ? null :  objvzx_AnswerEN.QuestionsTypeName; //问题类型名称
}
if (arrFldSet.Contains(convzx_Answer.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.TextTitle = objvzx_AnswerEN.TextTitle == "[null]" ? null :  objvzx_AnswerEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_Answer.QuestionsContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.QuestionsContent = objvzx_AnswerEN.QuestionsContent == "[null]" ? null :  objvzx_AnswerEN.QuestionsContent; //提问内容
}
if (arrFldSet.Contains(convzx_Answer.zxQuestionsTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.zxQuestionsTypeId = objvzx_AnswerEN.zxQuestionsTypeId == "[null]" ? null :  objvzx_AnswerEN.zxQuestionsTypeId; //问题类型Id
}
if (arrFldSet.Contains(convzx_Answer.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.UserId = objvzx_AnswerEN.UserId == "[null]" ? null :  objvzx_AnswerEN.UserId; //用户ID
}
if (arrFldSet.Contains(convzx_Answer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.Score = objvzx_AnswerEN.Score; //评分
}
if (arrFldSet.Contains(convzx_Answer.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.ScoreType = objvzx_AnswerEN.ScoreType == "[null]" ? null :  objvzx_AnswerEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(convzx_Answer.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.IsRight = objvzx_AnswerEN.IsRight; //是否正确
}
if (arrFldSet.Contains(convzx_Answer.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.ParentId = objvzx_AnswerEN.ParentId == "[null]" ? null :  objvzx_AnswerEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(convzx_Answer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.VoteCount = objvzx_AnswerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_Answer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.UpdUser = objvzx_AnswerEN.UpdUser == "[null]" ? null :  objvzx_AnswerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Answer.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.UserName = objvzx_AnswerEN.UserName == "[null]" ? null :  objvzx_AnswerEN.UserName; //用户名
}
if (arrFldSet.Contains(convzx_Answer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.UpdDate = objvzx_AnswerEN.UpdDate == "[null]" ? null :  objvzx_AnswerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Answer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.Memo = objvzx_AnswerEN.Memo == "[null]" ? null :  objvzx_AnswerEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Answer.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.IsPublic = objvzx_AnswerEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_Answer.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.IsRecommend = objvzx_AnswerEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(convzx_Answer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.GroupTextId = objvzx_AnswerEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_Answer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.IsSubmit = objvzx_AnswerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_Answer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.AppraiseCount = objvzx_AnswerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_Answer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.StuScore = objvzx_AnswerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_Answer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.TeaScore = objvzx_AnswerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_Answer.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.TextId = objvzx_AnswerEN.TextId == "[null]" ? null :  objvzx_AnswerEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_Answer.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.AnswerTypeId = objvzx_AnswerEN.AnswerTypeId == "[null]" ? null :  objvzx_AnswerEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convzx_Answer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.IdCurrEduCls = objvzx_AnswerEN.IdCurrEduCls == "[null]" ? null :  objvzx_AnswerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_Answer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.CreateDate = objvzx_AnswerEN.CreateDate == "[null]" ? null :  objvzx_AnswerEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_Answer.QuestUserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_AnswerEN.QuestUserName = objvzx_AnswerEN.QuestUserName == "[null]" ? null :  objvzx_AnswerEN.QuestUserName; //QuestUserName
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
 /// <param name = "objvzx_AnswerEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_AnswerEN objvzx_AnswerEN)
{
try
{
if (objvzx_AnswerEN.AnswerContent == "[null]") objvzx_AnswerEN.AnswerContent = null; //答案内容
if (objvzx_AnswerEN.QuestionsTypeName == "[null]") objvzx_AnswerEN.QuestionsTypeName = null; //问题类型名称
if (objvzx_AnswerEN.TextTitle == "[null]") objvzx_AnswerEN.TextTitle = null; //TextTitle
if (objvzx_AnswerEN.QuestionsContent == "[null]") objvzx_AnswerEN.QuestionsContent = null; //提问内容
if (objvzx_AnswerEN.zxQuestionsTypeId == "[null]") objvzx_AnswerEN.zxQuestionsTypeId = null; //问题类型Id
if (objvzx_AnswerEN.UserId == "[null]") objvzx_AnswerEN.UserId = null; //用户ID
if (objvzx_AnswerEN.ScoreType == "[null]") objvzx_AnswerEN.ScoreType = null; //评分类型
if (objvzx_AnswerEN.ParentId == "[null]") objvzx_AnswerEN.ParentId = null; //父节点Id
if (objvzx_AnswerEN.UpdUser == "[null]") objvzx_AnswerEN.UpdUser = null; //修改人
if (objvzx_AnswerEN.UserName == "[null]") objvzx_AnswerEN.UserName = null; //用户名
if (objvzx_AnswerEN.UpdDate == "[null]") objvzx_AnswerEN.UpdDate = null; //修改日期
if (objvzx_AnswerEN.Memo == "[null]") objvzx_AnswerEN.Memo = null; //备注
if (objvzx_AnswerEN.TextId == "[null]") objvzx_AnswerEN.TextId = null; //课件Id
if (objvzx_AnswerEN.AnswerTypeId == "[null]") objvzx_AnswerEN.AnswerTypeId = null; //答案类型ID
if (objvzx_AnswerEN.IdCurrEduCls == "[null]") objvzx_AnswerEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_AnswerEN.CreateDate == "[null]") objvzx_AnswerEN.CreateDate = null; //建立日期
if (objvzx_AnswerEN.QuestUserName == "[null]") objvzx_AnswerEN.QuestUserName = null; //QuestUserName
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
public static void CheckProperty4Condition(clsvzx_AnswerEN objvzx_AnswerEN)
{
 vzx_AnswerDA.CheckProperty4Condition(objvzx_AnswerEN);
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
if (clszx_AnswerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_AnswerBL没有刷新缓存机制(clszx_AnswerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_QuestionsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_QuestionsBL没有刷新缓存机制(clszx_QuestionsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_QuestionsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_QuestionsTypeBL没有刷新缓存机制(clszx_QuestionsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxAnswerId");
//if (arrvzx_AnswerObjLstCache == null)
//{
//arrvzx_AnswerObjLstCache = vzx_AnswerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxAnswerId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_AnswerEN GetObjByzxAnswerIdCache(string strzxAnswerId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvzx_AnswerEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_AnswerEN> arrvzx_AnswerObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_AnswerEN> arrvzx_AnswerObjLst_Sel =
arrvzx_AnswerObjLstCache
.Where(x=> x.zxAnswerId == strzxAnswerId 
);
if (arrvzx_AnswerObjLst_Sel.Count() == 0)
{
   clsvzx_AnswerEN obj = clsvzx_AnswerBL.GetObjByzxAnswerId(strzxAnswerId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxAnswerId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_AnswerEN> GetAllvzx_AnswerObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_AnswerEN> arrvzx_AnswerObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_AnswerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_AnswerEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvzx_AnswerEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_AnswerEN> arrvzx_AnswerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_AnswerObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvzx_AnswerEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxAnswerId, string strIdCurrEduCls)
{
if (strInFldName != convzx_Answer.zxAnswerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Answer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Answer.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Answer = clsvzx_AnswerBL.GetObjByzxAnswerIdCache(strzxAnswerId, strIdCurrEduCls);
if (objvzx_Answer == null) return "";
return objvzx_Answer[strOutFldName].ToString();
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
int intRecCount = clsvzx_AnswerDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_AnswerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_AnswerDA.GetRecCount();
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
int intRecCount = clsvzx_AnswerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_AnswerEN objvzx_AnswerCond)
{
 string strIdCurrEduCls = objvzx_AnswerCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_AnswerBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_AnswerEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Answer.AttributeName)
{
if (objvzx_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objvzx_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_AnswerCond[strFldName].ToString());
}
else
{
if (objvzx_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_AnswerCond[strFldName]));
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
 List<string> arrList = clsvzx_AnswerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_AnswerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_AnswerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}