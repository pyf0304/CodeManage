
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTopicObjectiveBL
 表名:vTopicObjective(01120617)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsvTopicObjectiveBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTopicObjectiveEN GetObj(this K_TopicObjectiveId_vTopicObjective myKey)
{
clsvTopicObjectiveEN objvTopicObjectiveEN = clsvTopicObjectiveBL.vTopicObjectiveDA.GetObjByTopicObjectiveId(myKey.Value);
return objvTopicObjectiveEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetPaperTitle(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convTopicObjective.PaperTitle);
}
objvTopicObjectiveEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.PaperTitle) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.PaperTitle, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.PaperTitle] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetPaperContent(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strPaperContent, string strComparisonOp="")
	{
objvTopicObjectiveEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.PaperContent) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.PaperContent, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.PaperContent] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetAuthor(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convTopicObjective.Author);
}
objvTopicObjectiveEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.Author) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.Author, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.Author] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetKeyword(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convTopicObjective.Keyword);
}
objvTopicObjectiveEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.Keyword) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.Keyword, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.Keyword] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetTopicObjectiveId(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strTopicObjectiveId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicObjectiveId, 8, convTopicObjective.TopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicObjectiveId, 8, convTopicObjective.TopicObjectiveId);
}
objvTopicObjectiveEN.TopicObjectiveId = strTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.TopicObjectiveId) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.TopicObjectiveId, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.TopicObjectiveId] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetObjectiveName(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, convTopicObjective.ObjectiveName);
}
objvTopicObjectiveEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.ObjectiveName) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.ObjectiveName, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.ObjectiveName] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetObjectiveContent(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strObjectiveContent, string strComparisonOp="")
	{
objvTopicObjectiveEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.ObjectiveContent) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.ObjectiveContent, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.ObjectiveContent] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetObjectiveType(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, convTopicObjective.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, convTopicObjective.ObjectiveType);
}
objvTopicObjectiveEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.ObjectiveType) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.ObjectiveType, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.ObjectiveType] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetSourceId(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strSourceId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceId, 10, convTopicObjective.SourceId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceId, 10, convTopicObjective.SourceId);
}
objvTopicObjectiveEN.SourceId = strSourceId; //来源Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.SourceId) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.SourceId, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.SourceId] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetConclusion(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConclusion, 5000, convTopicObjective.Conclusion);
}
objvTopicObjectiveEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.Conclusion) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.Conclusion, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.Conclusion] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetIsSubmit(this clsvTopicObjectiveEN objvTopicObjectiveEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvTopicObjectiveEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.IsSubmit) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.IsSubmit, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.IsSubmit] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetUpdDate(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTopicObjective.UpdDate);
}
objvTopicObjectiveEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.UpdDate) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.UpdDate, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.UpdDate] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetMemo(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTopicObjective.Memo);
}
objvTopicObjectiveEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.Memo) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.Memo, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.Memo] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetObjectiveTypeName(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strObjectiveTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveTypeName, 8, convTopicObjective.ObjectiveTypeName);
}
objvTopicObjectiveEN.ObjectiveTypeName = strObjectiveTypeName; //ObjectiveTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.ObjectiveTypeName) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.ObjectiveTypeName, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.ObjectiveTypeName] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetCitationCount(this clsvTopicObjectiveEN objvTopicObjectiveEN, int? intCitationCount, string strComparisonOp="")
	{
objvTopicObjectiveEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.CitationCount) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.CitationCount, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.CitationCount] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetAppraiseCount(this clsvTopicObjectiveEN objvTopicObjectiveEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvTopicObjectiveEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.AppraiseCount) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.AppraiseCount, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.AppraiseCount] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetScore(this clsvTopicObjectiveEN objvTopicObjectiveEN, float? fltScore, string strComparisonOp="")
	{
objvTopicObjectiveEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.Score) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.Score, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.Score] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetStuScore(this clsvTopicObjectiveEN objvTopicObjectiveEN, float? fltStuScore, string strComparisonOp="")
	{
objvTopicObjectiveEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.StuScore) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.StuScore, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.StuScore] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetTeaScore(this clsvTopicObjectiveEN objvTopicObjectiveEN, float? fltTeaScore, string strComparisonOp="")
	{
objvTopicObjectiveEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.TeaScore) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.TeaScore, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.TeaScore] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetIdCurrEduCls(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convTopicObjective.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convTopicObjective.IdCurrEduCls);
}
objvTopicObjectiveEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.IdCurrEduCls) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.IdCurrEduCls, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.IdCurrEduCls] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetPdfContent(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convTopicObjective.PdfContent);
}
objvTopicObjectiveEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.PdfContent) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.PdfContent, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.PdfContent] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetPdfPageNum(this clsvTopicObjectiveEN objvTopicObjectiveEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvTopicObjectiveEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.PdfPageNum) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.PdfPageNum, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.PdfPageNum] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetOkCount(this clsvTopicObjectiveEN objvTopicObjectiveEN, int? intOkCount, string strComparisonOp="")
	{
objvTopicObjectiveEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.OkCount) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.OkCount, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.OkCount] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetVersionCount(this clsvTopicObjectiveEN objvTopicObjectiveEN, int? intVersionCount, string strComparisonOp="")
	{
objvTopicObjectiveEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.VersionCount) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.VersionCount, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.VersionCount] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetCreateDate(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convTopicObjective.CreateDate);
}
objvTopicObjectiveEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.CreateDate) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.CreateDate, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.CreateDate] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetShareId(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convTopicObjective.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convTopicObjective.ShareId);
}
objvTopicObjectiveEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.ShareId) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.ShareId, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.ShareId] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvTopicObjectiveEN SetUpdUser(this clsvTopicObjectiveEN objvTopicObjectiveEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTopicObjective.UpdUser);
}
objvTopicObjectiveEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTopicObjectiveEN.dicFldComparisonOp.ContainsKey(convTopicObjective.UpdUser) == false)
{
objvTopicObjectiveEN.dicFldComparisonOp.Add(convTopicObjective.UpdUser, strComparisonOp);
}
else
{
objvTopicObjectiveEN.dicFldComparisonOp[convTopicObjective.UpdUser] = strComparisonOp;
}
}
return objvTopicObjectiveEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvTopicObjectiveENS">源对象</param>
 /// <param name = "objvTopicObjectiveENT">目标对象</param>
 public static void CopyTo(this clsvTopicObjectiveEN objvTopicObjectiveENS, clsvTopicObjectiveEN objvTopicObjectiveENT)
{
try
{
objvTopicObjectiveENT.PaperTitle = objvTopicObjectiveENS.PaperTitle; //论文标题
objvTopicObjectiveENT.PaperContent = objvTopicObjectiveENS.PaperContent; //主题内容
objvTopicObjectiveENT.Author = objvTopicObjectiveENS.Author; //作者
objvTopicObjectiveENT.Keyword = objvTopicObjectiveENS.Keyword; //关键字
objvTopicObjectiveENT.TopicObjectiveId = objvTopicObjectiveENS.TopicObjectiveId; //客观Id
objvTopicObjectiveENT.ObjectiveName = objvTopicObjectiveENS.ObjectiveName; //客观名称
objvTopicObjectiveENT.ObjectiveContent = objvTopicObjectiveENS.ObjectiveContent; //客观内容
objvTopicObjectiveENT.ObjectiveType = objvTopicObjectiveENS.ObjectiveType; //客观类型
objvTopicObjectiveENT.SourceId = objvTopicObjectiveENS.SourceId; //来源Id
objvTopicObjectiveENT.Conclusion = objvTopicObjectiveENS.Conclusion; //结论
objvTopicObjectiveENT.IsSubmit = objvTopicObjectiveENS.IsSubmit; //是否提交
objvTopicObjectiveENT.UpdDate = objvTopicObjectiveENS.UpdDate; //修改日期
objvTopicObjectiveENT.Memo = objvTopicObjectiveENS.Memo; //备注
objvTopicObjectiveENT.ObjectiveTypeName = objvTopicObjectiveENS.ObjectiveTypeName; //ObjectiveTypeName
objvTopicObjectiveENT.CitationCount = objvTopicObjectiveENS.CitationCount; //引用统计
objvTopicObjectiveENT.AppraiseCount = objvTopicObjectiveENS.AppraiseCount; //评论数
objvTopicObjectiveENT.Score = objvTopicObjectiveENS.Score; //评分
objvTopicObjectiveENT.StuScore = objvTopicObjectiveENS.StuScore; //学生平均分
objvTopicObjectiveENT.TeaScore = objvTopicObjectiveENS.TeaScore; //教师评分
objvTopicObjectiveENT.IdCurrEduCls = objvTopicObjectiveENS.IdCurrEduCls; //教学班流水号
objvTopicObjectiveENT.PdfContent = objvTopicObjectiveENS.PdfContent; //Pdf内容
objvTopicObjectiveENT.PdfPageNum = objvTopicObjectiveENS.PdfPageNum; //Pdf页码
objvTopicObjectiveENT.OkCount = objvTopicObjectiveENS.OkCount; //点赞统计
objvTopicObjectiveENT.VersionCount = objvTopicObjectiveENS.VersionCount; //版本统计
objvTopicObjectiveENT.CreateDate = objvTopicObjectiveENS.CreateDate; //建立日期
objvTopicObjectiveENT.ShareId = objvTopicObjectiveENS.ShareId; //分享Id
objvTopicObjectiveENT.UpdUser = objvTopicObjectiveENS.UpdUser; //修改人
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
 /// <param name = "objvTopicObjectiveENS">源对象</param>
 /// <returns>目标对象=>clsvTopicObjectiveEN:objvTopicObjectiveENT</returns>
 public static clsvTopicObjectiveEN CopyTo(this clsvTopicObjectiveEN objvTopicObjectiveENS)
{
try
{
 clsvTopicObjectiveEN objvTopicObjectiveENT = new clsvTopicObjectiveEN()
{
PaperTitle = objvTopicObjectiveENS.PaperTitle, //论文标题
PaperContent = objvTopicObjectiveENS.PaperContent, //主题内容
Author = objvTopicObjectiveENS.Author, //作者
Keyword = objvTopicObjectiveENS.Keyword, //关键字
TopicObjectiveId = objvTopicObjectiveENS.TopicObjectiveId, //客观Id
ObjectiveName = objvTopicObjectiveENS.ObjectiveName, //客观名称
ObjectiveContent = objvTopicObjectiveENS.ObjectiveContent, //客观内容
ObjectiveType = objvTopicObjectiveENS.ObjectiveType, //客观类型
SourceId = objvTopicObjectiveENS.SourceId, //来源Id
Conclusion = objvTopicObjectiveENS.Conclusion, //结论
IsSubmit = objvTopicObjectiveENS.IsSubmit, //是否提交
UpdDate = objvTopicObjectiveENS.UpdDate, //修改日期
Memo = objvTopicObjectiveENS.Memo, //备注
ObjectiveTypeName = objvTopicObjectiveENS.ObjectiveTypeName, //ObjectiveTypeName
CitationCount = objvTopicObjectiveENS.CitationCount, //引用统计
AppraiseCount = objvTopicObjectiveENS.AppraiseCount, //评论数
Score = objvTopicObjectiveENS.Score, //评分
StuScore = objvTopicObjectiveENS.StuScore, //学生平均分
TeaScore = objvTopicObjectiveENS.TeaScore, //教师评分
IdCurrEduCls = objvTopicObjectiveENS.IdCurrEduCls, //教学班流水号
PdfContent = objvTopicObjectiveENS.PdfContent, //Pdf内容
PdfPageNum = objvTopicObjectiveENS.PdfPageNum, //Pdf页码
OkCount = objvTopicObjectiveENS.OkCount, //点赞统计
VersionCount = objvTopicObjectiveENS.VersionCount, //版本统计
CreateDate = objvTopicObjectiveENS.CreateDate, //建立日期
ShareId = objvTopicObjectiveENS.ShareId, //分享Id
UpdUser = objvTopicObjectiveENS.UpdUser, //修改人
};
 return objvTopicObjectiveENT;
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
public static void CheckProperty4Condition(this clsvTopicObjectiveEN objvTopicObjectiveEN)
{
 clsvTopicObjectiveBL.vTopicObjectiveDA.CheckProperty4Condition(objvTopicObjectiveEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTopicObjectiveEN objvTopicObjectiveCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.PaperTitle, objvTopicObjectiveCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.Author) == true)
{
string strComparisonOpAuthor = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.Author, objvTopicObjectiveCond.Author, strComparisonOpAuthor);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.Keyword) == true)
{
string strComparisonOpKeyword = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.Keyword, objvTopicObjectiveCond.Keyword, strComparisonOpKeyword);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.TopicObjectiveId) == true)
{
string strComparisonOpTopicObjectiveId = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.TopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.TopicObjectiveId, objvTopicObjectiveCond.TopicObjectiveId, strComparisonOpTopicObjectiveId);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.ObjectiveName, objvTopicObjectiveCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.ObjectiveType, objvTopicObjectiveCond.ObjectiveType, strComparisonOpObjectiveType);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.SourceId) == true)
{
string strComparisonOpSourceId = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.SourceId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.SourceId, objvTopicObjectiveCond.SourceId, strComparisonOpSourceId);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.Conclusion) == true)
{
string strComparisonOpConclusion = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.Conclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.Conclusion, objvTopicObjectiveCond.Conclusion, strComparisonOpConclusion);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.IsSubmit) == true)
{
if (objvTopicObjectiveCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTopicObjective.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTopicObjective.IsSubmit);
}
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.UpdDate) == true)
{
string strComparisonOpUpdDate = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.UpdDate, objvTopicObjectiveCond.UpdDate, strComparisonOpUpdDate);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.Memo) == true)
{
string strComparisonOpMemo = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.Memo, objvTopicObjectiveCond.Memo, strComparisonOpMemo);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.ObjectiveTypeName) == true)
{
string strComparisonOpObjectiveTypeName = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.ObjectiveTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.ObjectiveTypeName, objvTopicObjectiveCond.ObjectiveTypeName, strComparisonOpObjectiveTypeName);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.CitationCount) == true)
{
string strComparisonOpCitationCount = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.CitationCount, objvTopicObjectiveCond.CitationCount, strComparisonOpCitationCount);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.AppraiseCount, objvTopicObjectiveCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.Score) == true)
{
string strComparisonOpScore = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.Score, objvTopicObjectiveCond.Score, strComparisonOpScore);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.StuScore) == true)
{
string strComparisonOpStuScore = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.StuScore, objvTopicObjectiveCond.StuScore, strComparisonOpStuScore);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.TeaScore) == true)
{
string strComparisonOpTeaScore = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.TeaScore, objvTopicObjectiveCond.TeaScore, strComparisonOpTeaScore);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.IdCurrEduCls, objvTopicObjectiveCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.PdfContent) == true)
{
string strComparisonOpPdfContent = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.PdfContent, objvTopicObjectiveCond.PdfContent, strComparisonOpPdfContent);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.PdfPageNum, objvTopicObjectiveCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.OkCount) == true)
{
string strComparisonOpOkCount = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.OkCount, objvTopicObjectiveCond.OkCount, strComparisonOpOkCount);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.VersionCount) == true)
{
string strComparisonOpVersionCount = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTopicObjective.VersionCount, objvTopicObjectiveCond.VersionCount, strComparisonOpVersionCount);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.CreateDate) == true)
{
string strComparisonOpCreateDate = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.CreateDate, objvTopicObjectiveCond.CreateDate, strComparisonOpCreateDate);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.ShareId) == true)
{
string strComparisonOpShareId = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.ShareId, objvTopicObjectiveCond.ShareId, strComparisonOpShareId);
}
if (objvTopicObjectiveCond.IsUpdated(convTopicObjective.UpdUser) == true)
{
string strComparisonOpUpdUser = objvTopicObjectiveCond.dicFldComparisonOp[convTopicObjective.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTopicObjective.UpdUser, objvTopicObjectiveCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vTopicObjective
{
public virtual bool UpdRelaTabDate(string strTopicObjectiveId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 客观表视图(vTopicObjective)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvTopicObjectiveBL
{
public static RelatedActions_vTopicObjective relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvTopicObjectiveDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvTopicObjectiveDA vTopicObjectiveDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvTopicObjectiveDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvTopicObjectiveBL()
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
if (string.IsNullOrEmpty(clsvTopicObjectiveEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTopicObjectiveEN._ConnectString);
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
public static DataTable GetDataTable_vTopicObjective(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vTopicObjectiveDA.GetDataTable_vTopicObjective(strWhereCond);
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
objDT = vTopicObjectiveDA.GetDataTable(strWhereCond);
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
objDT = vTopicObjectiveDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vTopicObjectiveDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vTopicObjectiveDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vTopicObjectiveDA.GetDataTable_Top(objTopPara);
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
objDT = vTopicObjectiveDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vTopicObjectiveDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vTopicObjectiveDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicObjectiveIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvTopicObjectiveEN> GetObjLstByTopicObjectiveIdLst(List<string> arrTopicObjectiveIdLst)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicObjectiveIdLst, true);
 string strWhereCond = string.Format("TopicObjectiveId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicObjectiveIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvTopicObjectiveEN> GetObjLstByTopicObjectiveIdLstCache(List<string> arrTopicObjectiveIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvTopicObjectiveEN._CurrTabName, strIdCurrEduCls);
List<clsvTopicObjectiveEN> arrvTopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvTopicObjectiveEN> arrvTopicObjectiveObjLst_Sel =
arrvTopicObjectiveObjLstCache
.Where(x => arrTopicObjectiveIdLst.Contains(x.TopicObjectiveId));
return arrvTopicObjectiveObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTopicObjectiveEN> GetObjLst(string strWhereCond)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
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
public static List<clsvTopicObjectiveEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvTopicObjectiveCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvTopicObjectiveEN> GetSubObjLstCache(clsvTopicObjectiveEN objvTopicObjectiveCond)
{
 string strIdCurrEduCls = objvTopicObjectiveCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvTopicObjectiveBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvTopicObjectiveEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvTopicObjectiveEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTopicObjective.AttributeName)
{
if (objvTopicObjectiveCond.IsUpdated(strFldName) == false) continue;
if (objvTopicObjectiveCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTopicObjectiveCond[strFldName].ToString());
}
else
{
if (objvTopicObjectiveCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTopicObjectiveCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTopicObjectiveCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTopicObjectiveCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTopicObjectiveCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTopicObjectiveCond[strFldName]));
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
public static List<clsvTopicObjectiveEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
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
public static List<clsvTopicObjectiveEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
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
List<clsvTopicObjectiveEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvTopicObjectiveEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTopicObjectiveEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvTopicObjectiveEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
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
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
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
public static List<clsvTopicObjectiveEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvTopicObjectiveEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvTopicObjectiveEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
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
public static List<clsvTopicObjectiveEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTopicObjectiveEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvTopicObjectiveEN.TopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvTopicObjectiveEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvTopicObjective(ref clsvTopicObjectiveEN objvTopicObjectiveEN)
{
bool bolResult = vTopicObjectiveDA.GetvTopicObjective(ref objvTopicObjectiveEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTopicObjectiveEN GetObjByTopicObjectiveId(string strTopicObjectiveId)
{
if (strTopicObjectiveId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTopicObjectiveId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicObjectiveId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTopicObjectiveId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvTopicObjectiveEN objvTopicObjectiveEN = vTopicObjectiveDA.GetObjByTopicObjectiveId(strTopicObjectiveId);
return objvTopicObjectiveEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvTopicObjectiveEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvTopicObjectiveEN objvTopicObjectiveEN = vTopicObjectiveDA.GetFirstObj(strWhereCond);
 return objvTopicObjectiveEN;
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
public static clsvTopicObjectiveEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvTopicObjectiveEN objvTopicObjectiveEN = vTopicObjectiveDA.GetObjByDataRow(objRow);
 return objvTopicObjectiveEN;
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
public static clsvTopicObjectiveEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvTopicObjectiveEN objvTopicObjectiveEN = vTopicObjectiveDA.GetObjByDataRow(objRow);
 return objvTopicObjectiveEN;
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
 /// <param name = "strTopicObjectiveId">所给的关键字</param>
 /// <param name = "lstvTopicObjectiveObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTopicObjectiveEN GetObjByTopicObjectiveIdFromList(string strTopicObjectiveId, List<clsvTopicObjectiveEN> lstvTopicObjectiveObjLst)
{
foreach (clsvTopicObjectiveEN objvTopicObjectiveEN in lstvTopicObjectiveObjLst)
{
if (objvTopicObjectiveEN.TopicObjectiveId == strTopicObjectiveId)
{
return objvTopicObjectiveEN;
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
 string strMaxTopicObjectiveId;
 try
 {
 strMaxTopicObjectiveId = clsvTopicObjectiveDA.GetMaxStrId();
 return strMaxTopicObjectiveId;
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
 string strTopicObjectiveId;
 try
 {
 strTopicObjectiveId = new clsvTopicObjectiveDA().GetFirstID(strWhereCond);
 return strTopicObjectiveId;
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
 arrList = vTopicObjectiveDA.GetID(strWhereCond);
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
bool bolIsExist = vTopicObjectiveDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTopicObjectiveId)
{
if (string.IsNullOrEmpty(strTopicObjectiveId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTopicObjectiveId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vTopicObjectiveDA.IsExist(strTopicObjectiveId);
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
 bolIsExist = clsvTopicObjectiveDA.IsExistTable();
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
 bolIsExist = vTopicObjectiveDA.IsExistTable(strTabName);
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
 /// <param name = "objvTopicObjectiveENS">源对象</param>
 /// <param name = "objvTopicObjectiveENT">目标对象</param>
 public static void CopyTo(clsvTopicObjectiveEN objvTopicObjectiveENS, clsvTopicObjectiveEN objvTopicObjectiveENT)
{
try
{
objvTopicObjectiveENT.PaperTitle = objvTopicObjectiveENS.PaperTitle; //论文标题
objvTopicObjectiveENT.PaperContent = objvTopicObjectiveENS.PaperContent; //主题内容
objvTopicObjectiveENT.Author = objvTopicObjectiveENS.Author; //作者
objvTopicObjectiveENT.Keyword = objvTopicObjectiveENS.Keyword; //关键字
objvTopicObjectiveENT.TopicObjectiveId = objvTopicObjectiveENS.TopicObjectiveId; //客观Id
objvTopicObjectiveENT.ObjectiveName = objvTopicObjectiveENS.ObjectiveName; //客观名称
objvTopicObjectiveENT.ObjectiveContent = objvTopicObjectiveENS.ObjectiveContent; //客观内容
objvTopicObjectiveENT.ObjectiveType = objvTopicObjectiveENS.ObjectiveType; //客观类型
objvTopicObjectiveENT.SourceId = objvTopicObjectiveENS.SourceId; //来源Id
objvTopicObjectiveENT.Conclusion = objvTopicObjectiveENS.Conclusion; //结论
objvTopicObjectiveENT.IsSubmit = objvTopicObjectiveENS.IsSubmit; //是否提交
objvTopicObjectiveENT.UpdDate = objvTopicObjectiveENS.UpdDate; //修改日期
objvTopicObjectiveENT.Memo = objvTopicObjectiveENS.Memo; //备注
objvTopicObjectiveENT.ObjectiveTypeName = objvTopicObjectiveENS.ObjectiveTypeName; //ObjectiveTypeName
objvTopicObjectiveENT.CitationCount = objvTopicObjectiveENS.CitationCount; //引用统计
objvTopicObjectiveENT.AppraiseCount = objvTopicObjectiveENS.AppraiseCount; //评论数
objvTopicObjectiveENT.Score = objvTopicObjectiveENS.Score; //评分
objvTopicObjectiveENT.StuScore = objvTopicObjectiveENS.StuScore; //学生平均分
objvTopicObjectiveENT.TeaScore = objvTopicObjectiveENS.TeaScore; //教师评分
objvTopicObjectiveENT.IdCurrEduCls = objvTopicObjectiveENS.IdCurrEduCls; //教学班流水号
objvTopicObjectiveENT.PdfContent = objvTopicObjectiveENS.PdfContent; //Pdf内容
objvTopicObjectiveENT.PdfPageNum = objvTopicObjectiveENS.PdfPageNum; //Pdf页码
objvTopicObjectiveENT.OkCount = objvTopicObjectiveENS.OkCount; //点赞统计
objvTopicObjectiveENT.VersionCount = objvTopicObjectiveENS.VersionCount; //版本统计
objvTopicObjectiveENT.CreateDate = objvTopicObjectiveENS.CreateDate; //建立日期
objvTopicObjectiveENT.ShareId = objvTopicObjectiveENS.ShareId; //分享Id
objvTopicObjectiveENT.UpdUser = objvTopicObjectiveENS.UpdUser; //修改人
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
 /// <param name = "objvTopicObjectiveEN">源简化对象</param>
 public static void SetUpdFlag(clsvTopicObjectiveEN objvTopicObjectiveEN)
{
try
{
objvTopicObjectiveEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvTopicObjectiveEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convTopicObjective.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.PaperTitle = objvTopicObjectiveEN.PaperTitle == "[null]" ? null :  objvTopicObjectiveEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convTopicObjective.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.PaperContent = objvTopicObjectiveEN.PaperContent == "[null]" ? null :  objvTopicObjectiveEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convTopicObjective.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.Author = objvTopicObjectiveEN.Author == "[null]" ? null :  objvTopicObjectiveEN.Author; //作者
}
if (arrFldSet.Contains(convTopicObjective.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.Keyword = objvTopicObjectiveEN.Keyword == "[null]" ? null :  objvTopicObjectiveEN.Keyword; //关键字
}
if (arrFldSet.Contains(convTopicObjective.TopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.TopicObjectiveId = objvTopicObjectiveEN.TopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(convTopicObjective.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.ObjectiveName = objvTopicObjectiveEN.ObjectiveName == "[null]" ? null :  objvTopicObjectiveEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(convTopicObjective.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.ObjectiveContent = objvTopicObjectiveEN.ObjectiveContent == "[null]" ? null :  objvTopicObjectiveEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(convTopicObjective.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.ObjectiveType = objvTopicObjectiveEN.ObjectiveType == "[null]" ? null :  objvTopicObjectiveEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(convTopicObjective.SourceId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.SourceId = objvTopicObjectiveEN.SourceId == "[null]" ? null :  objvTopicObjectiveEN.SourceId; //来源Id
}
if (arrFldSet.Contains(convTopicObjective.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.Conclusion = objvTopicObjectiveEN.Conclusion == "[null]" ? null :  objvTopicObjectiveEN.Conclusion; //结论
}
if (arrFldSet.Contains(convTopicObjective.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.IsSubmit = objvTopicObjectiveEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convTopicObjective.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.UpdDate = objvTopicObjectiveEN.UpdDate == "[null]" ? null :  objvTopicObjectiveEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convTopicObjective.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.Memo = objvTopicObjectiveEN.Memo == "[null]" ? null :  objvTopicObjectiveEN.Memo; //备注
}
if (arrFldSet.Contains(convTopicObjective.ObjectiveTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.ObjectiveTypeName = objvTopicObjectiveEN.ObjectiveTypeName == "[null]" ? null :  objvTopicObjectiveEN.ObjectiveTypeName; //ObjectiveTypeName
}
if (arrFldSet.Contains(convTopicObjective.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.CitationCount = objvTopicObjectiveEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convTopicObjective.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.AppraiseCount = objvTopicObjectiveEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convTopicObjective.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.Score = objvTopicObjectiveEN.Score; //评分
}
if (arrFldSet.Contains(convTopicObjective.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.StuScore = objvTopicObjectiveEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convTopicObjective.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.TeaScore = objvTopicObjectiveEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convTopicObjective.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.IdCurrEduCls = objvTopicObjectiveEN.IdCurrEduCls == "[null]" ? null :  objvTopicObjectiveEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convTopicObjective.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.PdfContent = objvTopicObjectiveEN.PdfContent == "[null]" ? null :  objvTopicObjectiveEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convTopicObjective.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.PdfPageNum = objvTopicObjectiveEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convTopicObjective.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.OkCount = objvTopicObjectiveEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convTopicObjective.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.VersionCount = objvTopicObjectiveEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convTopicObjective.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.CreateDate = objvTopicObjectiveEN.CreateDate == "[null]" ? null :  objvTopicObjectiveEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convTopicObjective.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.ShareId = objvTopicObjectiveEN.ShareId == "[null]" ? null :  objvTopicObjectiveEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convTopicObjective.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvTopicObjectiveEN.UpdUser = objvTopicObjectiveEN.UpdUser == "[null]" ? null :  objvTopicObjectiveEN.UpdUser; //修改人
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
 /// <param name = "objvTopicObjectiveEN">源简化对象</param>
 public static void AccessFldValueNull(clsvTopicObjectiveEN objvTopicObjectiveEN)
{
try
{
if (objvTopicObjectiveEN.PaperTitle == "[null]") objvTopicObjectiveEN.PaperTitle = null; //论文标题
if (objvTopicObjectiveEN.PaperContent == "[null]") objvTopicObjectiveEN.PaperContent = null; //主题内容
if (objvTopicObjectiveEN.Author == "[null]") objvTopicObjectiveEN.Author = null; //作者
if (objvTopicObjectiveEN.Keyword == "[null]") objvTopicObjectiveEN.Keyword = null; //关键字
if (objvTopicObjectiveEN.ObjectiveName == "[null]") objvTopicObjectiveEN.ObjectiveName = null; //客观名称
if (objvTopicObjectiveEN.ObjectiveContent == "[null]") objvTopicObjectiveEN.ObjectiveContent = null; //客观内容
if (objvTopicObjectiveEN.ObjectiveType == "[null]") objvTopicObjectiveEN.ObjectiveType = null; //客观类型
if (objvTopicObjectiveEN.SourceId == "[null]") objvTopicObjectiveEN.SourceId = null; //来源Id
if (objvTopicObjectiveEN.Conclusion == "[null]") objvTopicObjectiveEN.Conclusion = null; //结论
if (objvTopicObjectiveEN.UpdDate == "[null]") objvTopicObjectiveEN.UpdDate = null; //修改日期
if (objvTopicObjectiveEN.Memo == "[null]") objvTopicObjectiveEN.Memo = null; //备注
if (objvTopicObjectiveEN.ObjectiveTypeName == "[null]") objvTopicObjectiveEN.ObjectiveTypeName = null; //ObjectiveTypeName
if (objvTopicObjectiveEN.IdCurrEduCls == "[null]") objvTopicObjectiveEN.IdCurrEduCls = null; //教学班流水号
if (objvTopicObjectiveEN.PdfContent == "[null]") objvTopicObjectiveEN.PdfContent = null; //Pdf内容
if (objvTopicObjectiveEN.CreateDate == "[null]") objvTopicObjectiveEN.CreateDate = null; //建立日期
if (objvTopicObjectiveEN.ShareId == "[null]") objvTopicObjectiveEN.ShareId = null; //分享Id
if (objvTopicObjectiveEN.UpdUser == "[null]") objvTopicObjectiveEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvTopicObjectiveEN objvTopicObjectiveEN)
{
 vTopicObjectiveDA.CheckProperty4Condition(objvTopicObjectiveEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTopicObjectiveBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTopicObjectiveBL没有刷新缓存机制(clsTopicObjectiveBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicObjectiveId");
//if (arrvTopicObjectiveObjLstCache == null)
//{
//arrvTopicObjectiveObjLstCache = vTopicObjectiveDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTopicObjectiveId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTopicObjectiveEN GetObjByTopicObjectiveIdCache(string strTopicObjectiveId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvTopicObjectiveEN._CurrTabName, strIdCurrEduCls);
List<clsvTopicObjectiveEN> arrvTopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvTopicObjectiveEN> arrvTopicObjectiveObjLst_Sel =
arrvTopicObjectiveObjLstCache
.Where(x=> x.TopicObjectiveId == strTopicObjectiveId 
);
if (arrvTopicObjectiveObjLst_Sel.Count() == 0)
{
   clsvTopicObjectiveEN obj = clsvTopicObjectiveBL.GetObjByTopicObjectiveId(strTopicObjectiveId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTopicObjectiveId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvTopicObjectiveObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTopicObjectiveEN> GetAllvTopicObjectiveObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvTopicObjectiveEN> arrvTopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvTopicObjectiveObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvTopicObjectiveEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvTopicObjectiveEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvTopicObjectiveEN> arrvTopicObjectiveObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvTopicObjectiveObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvTopicObjectiveEN._CurrTabName, strIdCurrEduCls);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTopicObjectiveId, string strIdCurrEduCls)
{
if (strInFldName != convTopicObjective.TopicObjectiveId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convTopicObjective.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convTopicObjective.AttributeName));
throw new Exception(strMsg);
}
var objvTopicObjective = clsvTopicObjectiveBL.GetObjByTopicObjectiveIdCache(strTopicObjectiveId, strIdCurrEduCls);
if (objvTopicObjective == null) return "";
return objvTopicObjective[strOutFldName].ToString();
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
int intRecCount = clsvTopicObjectiveDA.GetRecCount(strTabName);
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
int intRecCount = clsvTopicObjectiveDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvTopicObjectiveDA.GetRecCount();
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
int intRecCount = clsvTopicObjectiveDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvTopicObjectiveCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvTopicObjectiveEN objvTopicObjectiveCond)
{
 string strIdCurrEduCls = objvTopicObjectiveCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvTopicObjectiveBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvTopicObjectiveEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvTopicObjectiveEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convTopicObjective.AttributeName)
{
if (objvTopicObjectiveCond.IsUpdated(strFldName) == false) continue;
if (objvTopicObjectiveCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTopicObjectiveCond[strFldName].ToString());
}
else
{
if (objvTopicObjectiveCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvTopicObjectiveCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvTopicObjectiveCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvTopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvTopicObjectiveCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvTopicObjectiveCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvTopicObjectiveCond[strFldName]));
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
 List<string> arrList = clsvTopicObjectiveDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vTopicObjectiveDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vTopicObjectiveDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}