
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TopicObjectiveBL
 表名:vzx_TopicObjective(01120855)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:25
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
public static class  clsvzx_TopicObjectiveBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TopicObjectiveEN GetObj(this K_zxTopicObjectiveId_vzx_TopicObjective myKey)
{
clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = clsvzx_TopicObjectiveBL.vzx_TopicObjectiveDA.GetObjByzxTopicObjectiveId(myKey.Value);
return objvzx_TopicObjectiveEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetzxTopicObjectiveId(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strzxTopicObjectiveId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxTopicObjectiveId, 8, convzx_TopicObjective.zxTopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxTopicObjectiveId, 8, convzx_TopicObjective.zxTopicObjectiveId);
}
objvzx_TopicObjectiveEN.zxTopicObjectiveId = strzxTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.zxTopicObjectiveId) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.zxTopicObjectiveId, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.zxTopicObjectiveId] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetObjectiveName(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, convzx_TopicObjective.ObjectiveName);
}
objvzx_TopicObjectiveEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.ObjectiveName) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.ObjectiveName, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.ObjectiveName] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetObjectiveContent(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strObjectiveContent, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.ObjectiveContent) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.ObjectiveContent, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.ObjectiveContent] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetObjectiveType(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, convzx_TopicObjective.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, convzx_TopicObjective.ObjectiveType);
}
objvzx_TopicObjectiveEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.ObjectiveType) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.ObjectiveType, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.ObjectiveType] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetConclusion(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strConclusion, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.Conclusion) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.Conclusion, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.Conclusion] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetTextId(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_TopicObjective.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_TopicObjective.TextId);
}
objvzx_TopicObjectiveEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.TextId) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.TextId, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.TextId] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetIsSubmit(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.IsSubmit) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.IsSubmit, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.IsSubmit] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetVoteCount(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.VoteCount) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.VoteCount, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.VoteCount] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetAppraiseCount(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.AppraiseCount) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.AppraiseCount, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.AppraiseCount] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetScore(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, float? fltScore, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.Score) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.Score, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.Score] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetStuScore(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.StuScore) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.StuScore, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.StuScore] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetTeaScore(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.TeaScore) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.TeaScore, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.TeaScore] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetIdCurrEduCls(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_TopicObjective.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_TopicObjective.IdCurrEduCls);
}
objvzx_TopicObjectiveEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.IdCurrEduCls) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetPdfContent(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_TopicObjective.PdfContent);
}
objvzx_TopicObjectiveEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.PdfContent) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.PdfContent, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.PdfContent] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetPdfPageNum(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.PdfPageNum) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.PdfPageNum, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.PdfPageNum] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetCitationCount(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, int? intCitationCount, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.CitationCount) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.CitationCount, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.CitationCount] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetVersionCount(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.VersionCount) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.VersionCount, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.VersionCount] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetzxShareId(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_TopicObjective.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_TopicObjective.zxShareId);
}
objvzx_TopicObjectiveEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.zxShareId) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.zxShareId, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.zxShareId] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetCreateDate(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_TopicObjective.CreateDate);
}
objvzx_TopicObjectiveEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.CreateDate) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.CreateDate, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.CreateDate] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetUpdDate(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_TopicObjective.UpdDate);
}
objvzx_TopicObjectiveEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.UpdDate) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.UpdDate, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.UpdDate] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetUpdUser(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_TopicObjective.UpdUser);
}
objvzx_TopicObjectiveEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.UpdUser) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.UpdUser, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.UpdUser] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetMemo(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_TopicObjective.Memo);
}
objvzx_TopicObjectiveEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.Memo) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.Memo, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.Memo] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetPdfDivLet(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_TopicObjective.PdfDivLet);
}
objvzx_TopicObjectiveEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.PdfDivLet) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.PdfDivLet, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.PdfDivLet] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetPdfDivTop(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_TopicObjective.PdfDivTop);
}
objvzx_TopicObjectiveEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.PdfDivTop) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.PdfDivTop, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.PdfDivTop] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetPdfPageNumIn(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_TopicObjective.PdfPageNumIn);
}
objvzx_TopicObjectiveEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.PdfPageNumIn) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetPdfPageTop(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.PdfPageTop) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.PdfPageTop, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.PdfPageTop] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetPdfZoom(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_TopicObjective.PdfZoom);
}
objvzx_TopicObjectiveEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.PdfZoom) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.PdfZoom, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.PdfZoom] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetGroupTextId(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_TopicObjective.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_TopicObjective.GroupTextId);
}
objvzx_TopicObjectiveEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.GroupTextId) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.GroupTextId, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.GroupTextId] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetTextTitle(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_TopicObjective.TextTitle);
}
objvzx_TopicObjectiveEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.TextTitle) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.TextTitle, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.TextTitle] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetTextContent(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strTextContent, string strComparisonOp="")
	{
objvzx_TopicObjectiveEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.TextContent) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.TextContent, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.TextContent] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetAuthor(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_TopicObjective.Author);
}
objvzx_TopicObjectiveEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.Author) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.Author, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.Author] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TopicObjectiveEN SetKeyword(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convzx_TopicObjective.Keyword);
}
objvzx_TopicObjectiveEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TopicObjectiveEN.dicFldComparisonOp.ContainsKey(convzx_TopicObjective.Keyword) == false)
{
objvzx_TopicObjectiveEN.dicFldComparisonOp.Add(convzx_TopicObjective.Keyword, strComparisonOp);
}
else
{
objvzx_TopicObjectiveEN.dicFldComparisonOp[convzx_TopicObjective.Keyword] = strComparisonOp;
}
}
return objvzx_TopicObjectiveEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveENS">源对象</param>
 /// <param name = "objvzx_TopicObjectiveENT">目标对象</param>
 public static void CopyTo(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENS, clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENT)
{
try
{
objvzx_TopicObjectiveENT.zxTopicObjectiveId = objvzx_TopicObjectiveENS.zxTopicObjectiveId; //客观Id
objvzx_TopicObjectiveENT.ObjectiveName = objvzx_TopicObjectiveENS.ObjectiveName; //客观名称
objvzx_TopicObjectiveENT.ObjectiveContent = objvzx_TopicObjectiveENS.ObjectiveContent; //客观内容
objvzx_TopicObjectiveENT.ObjectiveType = objvzx_TopicObjectiveENS.ObjectiveType; //客观类型
objvzx_TopicObjectiveENT.Conclusion = objvzx_TopicObjectiveENS.Conclusion; //结论
objvzx_TopicObjectiveENT.TextId = objvzx_TopicObjectiveENS.TextId; //课件Id
objvzx_TopicObjectiveENT.IsSubmit = objvzx_TopicObjectiveENS.IsSubmit; //是否提交
objvzx_TopicObjectiveENT.VoteCount = objvzx_TopicObjectiveENS.VoteCount; //点赞计数
objvzx_TopicObjectiveENT.AppraiseCount = objvzx_TopicObjectiveENS.AppraiseCount; //评论数
objvzx_TopicObjectiveENT.Score = objvzx_TopicObjectiveENS.Score; //评分
objvzx_TopicObjectiveENT.StuScore = objvzx_TopicObjectiveENS.StuScore; //学生平均分
objvzx_TopicObjectiveENT.TeaScore = objvzx_TopicObjectiveENS.TeaScore; //教师评分
objvzx_TopicObjectiveENT.IdCurrEduCls = objvzx_TopicObjectiveENS.IdCurrEduCls; //教学班流水号
objvzx_TopicObjectiveENT.PdfContent = objvzx_TopicObjectiveENS.PdfContent; //Pdf内容
objvzx_TopicObjectiveENT.PdfPageNum = objvzx_TopicObjectiveENS.PdfPageNum; //Pdf页码
objvzx_TopicObjectiveENT.CitationCount = objvzx_TopicObjectiveENS.CitationCount; //引用统计
objvzx_TopicObjectiveENT.VersionCount = objvzx_TopicObjectiveENS.VersionCount; //版本统计
objvzx_TopicObjectiveENT.zxShareId = objvzx_TopicObjectiveENS.zxShareId; //分享Id
objvzx_TopicObjectiveENT.CreateDate = objvzx_TopicObjectiveENS.CreateDate; //建立日期
objvzx_TopicObjectiveENT.UpdDate = objvzx_TopicObjectiveENS.UpdDate; //修改日期
objvzx_TopicObjectiveENT.UpdUser = objvzx_TopicObjectiveENS.UpdUser; //修改人
objvzx_TopicObjectiveENT.Memo = objvzx_TopicObjectiveENS.Memo; //备注
objvzx_TopicObjectiveENT.PdfDivLet = objvzx_TopicObjectiveENS.PdfDivLet; //PdfDivLet
objvzx_TopicObjectiveENT.PdfDivTop = objvzx_TopicObjectiveENS.PdfDivTop; //PdfDivTop
objvzx_TopicObjectiveENT.PdfPageNumIn = objvzx_TopicObjectiveENS.PdfPageNumIn; //PdfPageNumIn
objvzx_TopicObjectiveENT.PdfPageTop = objvzx_TopicObjectiveENS.PdfPageTop; //pdf页面顶部位置
objvzx_TopicObjectiveENT.PdfZoom = objvzx_TopicObjectiveENS.PdfZoom; //PdfZoom
objvzx_TopicObjectiveENT.GroupTextId = objvzx_TopicObjectiveENS.GroupTextId; //小组Id
objvzx_TopicObjectiveENT.TextTitle = objvzx_TopicObjectiveENS.TextTitle; //TextTitle
objvzx_TopicObjectiveENT.TextContent = objvzx_TopicObjectiveENS.TextContent; //TextContent
objvzx_TopicObjectiveENT.Author = objvzx_TopicObjectiveENS.Author; //作者
objvzx_TopicObjectiveENT.Keyword = objvzx_TopicObjectiveENS.Keyword; //关键字
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
 /// <param name = "objvzx_TopicObjectiveENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TopicObjectiveEN:objvzx_TopicObjectiveENT</returns>
 public static clsvzx_TopicObjectiveEN CopyTo(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENS)
{
try
{
 clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENT = new clsvzx_TopicObjectiveEN()
{
zxTopicObjectiveId = objvzx_TopicObjectiveENS.zxTopicObjectiveId, //客观Id
ObjectiveName = objvzx_TopicObjectiveENS.ObjectiveName, //客观名称
ObjectiveContent = objvzx_TopicObjectiveENS.ObjectiveContent, //客观内容
ObjectiveType = objvzx_TopicObjectiveENS.ObjectiveType, //客观类型
Conclusion = objvzx_TopicObjectiveENS.Conclusion, //结论
TextId = objvzx_TopicObjectiveENS.TextId, //课件Id
IsSubmit = objvzx_TopicObjectiveENS.IsSubmit, //是否提交
VoteCount = objvzx_TopicObjectiveENS.VoteCount, //点赞计数
AppraiseCount = objvzx_TopicObjectiveENS.AppraiseCount, //评论数
Score = objvzx_TopicObjectiveENS.Score, //评分
StuScore = objvzx_TopicObjectiveENS.StuScore, //学生平均分
TeaScore = objvzx_TopicObjectiveENS.TeaScore, //教师评分
IdCurrEduCls = objvzx_TopicObjectiveENS.IdCurrEduCls, //教学班流水号
PdfContent = objvzx_TopicObjectiveENS.PdfContent, //Pdf内容
PdfPageNum = objvzx_TopicObjectiveENS.PdfPageNum, //Pdf页码
CitationCount = objvzx_TopicObjectiveENS.CitationCount, //引用统计
VersionCount = objvzx_TopicObjectiveENS.VersionCount, //版本统计
zxShareId = objvzx_TopicObjectiveENS.zxShareId, //分享Id
CreateDate = objvzx_TopicObjectiveENS.CreateDate, //建立日期
UpdDate = objvzx_TopicObjectiveENS.UpdDate, //修改日期
UpdUser = objvzx_TopicObjectiveENS.UpdUser, //修改人
Memo = objvzx_TopicObjectiveENS.Memo, //备注
PdfDivLet = objvzx_TopicObjectiveENS.PdfDivLet, //PdfDivLet
PdfDivTop = objvzx_TopicObjectiveENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objvzx_TopicObjectiveENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objvzx_TopicObjectiveENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objvzx_TopicObjectiveENS.PdfZoom, //PdfZoom
GroupTextId = objvzx_TopicObjectiveENS.GroupTextId, //小组Id
TextTitle = objvzx_TopicObjectiveENS.TextTitle, //TextTitle
TextContent = objvzx_TopicObjectiveENS.TextContent, //TextContent
Author = objvzx_TopicObjectiveENS.Author, //作者
Keyword = objvzx_TopicObjectiveENS.Keyword, //关键字
};
 return objvzx_TopicObjectiveENT;
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
public static void CheckProperty4Condition(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN)
{
 clsvzx_TopicObjectiveBL.vzx_TopicObjectiveDA.CheckProperty4Condition(objvzx_TopicObjectiveEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_TopicObjectiveEN objvzx_TopicObjectiveCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.zxTopicObjectiveId) == true)
{
string strComparisonOpzxTopicObjectiveId = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.zxTopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.zxTopicObjectiveId, objvzx_TopicObjectiveCond.zxTopicObjectiveId, strComparisonOpzxTopicObjectiveId);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.ObjectiveName, objvzx_TopicObjectiveCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.ObjectiveType, objvzx_TopicObjectiveCond.ObjectiveType, strComparisonOpObjectiveType);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.TextId) == true)
{
string strComparisonOpTextId = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.TextId, objvzx_TopicObjectiveCond.TextId, strComparisonOpTextId);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.IsSubmit) == true)
{
if (objvzx_TopicObjectiveCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_TopicObjective.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_TopicObjective.IsSubmit);
}
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.VoteCount, objvzx_TopicObjectiveCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.AppraiseCount, objvzx_TopicObjectiveCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.Score) == true)
{
string strComparisonOpScore = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.Score, objvzx_TopicObjectiveCond.Score, strComparisonOpScore);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.StuScore, objvzx_TopicObjectiveCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.TeaScore, objvzx_TopicObjectiveCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.IdCurrEduCls, objvzx_TopicObjectiveCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.PdfContent, objvzx_TopicObjectiveCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.PdfPageNum, objvzx_TopicObjectiveCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.CitationCount) == true)
{
string strComparisonOpCitationCount = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.CitationCount, objvzx_TopicObjectiveCond.CitationCount, strComparisonOpCitationCount);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.VersionCount, objvzx_TopicObjectiveCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.zxShareId, objvzx_TopicObjectiveCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.CreateDate, objvzx_TopicObjectiveCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.UpdDate, objvzx_TopicObjectiveCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.UpdUser, objvzx_TopicObjectiveCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.Memo) == true)
{
string strComparisonOpMemo = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.Memo, objvzx_TopicObjectiveCond.Memo, strComparisonOpMemo);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.PdfDivLet, objvzx_TopicObjectiveCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.PdfDivTop, objvzx_TopicObjectiveCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.PdfPageNumIn, objvzx_TopicObjectiveCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TopicObjective.PdfPageTop, objvzx_TopicObjectiveCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.PdfZoom, objvzx_TopicObjectiveCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.GroupTextId, objvzx_TopicObjectiveCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.TextTitle, objvzx_TopicObjectiveCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.Author) == true)
{
string strComparisonOpAuthor = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.Author, objvzx_TopicObjectiveCond.Author, strComparisonOpAuthor);
}
if (objvzx_TopicObjectiveCond.IsUpdated(convzx_TopicObjective.Keyword) == true)
{
string strComparisonOpKeyword = objvzx_TopicObjectiveCond.dicFldComparisonOp[convzx_TopicObjective.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TopicObjective.Keyword, objvzx_TopicObjectiveCond.Keyword, strComparisonOpKeyword);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_TopicObjective
{
public virtual bool UpdRelaTabDate(string strzxTopicObjectiveId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_TopicObjective(vzx_TopicObjective)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_TopicObjectiveBL
{
public static RelatedActions_vzx_TopicObjective relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_TopicObjectiveDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_TopicObjectiveDA vzx_TopicObjectiveDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_TopicObjectiveDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_TopicObjectiveBL()
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
if (string.IsNullOrEmpty(clsvzx_TopicObjectiveEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TopicObjectiveEN._ConnectString);
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
public static DataTable GetDataTable_vzx_TopicObjective(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_TopicObjectiveDA.GetDataTable_vzx_TopicObjective(strWhereCond);
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
objDT = vzx_TopicObjectiveDA.GetDataTable(strWhereCond);
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
objDT = vzx_TopicObjectiveDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_TopicObjectiveDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_TopicObjectiveDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_TopicObjectiveDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_TopicObjectiveDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_TopicObjectiveDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_TopicObjectiveDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxTopicObjectiveIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_TopicObjectiveEN> GetObjLstByZxTopicObjectiveIdLst(List<string> arrZxTopicObjectiveIdLst)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxTopicObjectiveIdLst, true);
 string strWhereCond = string.Format("zxTopicObjectiveId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxTopicObjectiveIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_TopicObjectiveEN> GetObjLstByZxTopicObjectiveIdLstCache(List<string> arrZxTopicObjectiveIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TopicObjectiveEN> arrvzx_TopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TopicObjectiveEN> arrvzx_TopicObjectiveObjLst_Sel =
arrvzx_TopicObjectiveObjLstCache
.Where(x => arrZxTopicObjectiveIdLst.Contains(x.zxTopicObjectiveId));
return arrvzx_TopicObjectiveObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TopicObjectiveEN> GetObjLst(string strWhereCond)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
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
public static List<clsvzx_TopicObjectiveEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_TopicObjectiveEN> GetSubObjLstCache(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveCond)
{
 string strIdCurrEduCls = objvzx_TopicObjectiveCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_TopicObjectiveBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_TopicObjectiveEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TopicObjectiveEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TopicObjective.AttributeName)
{
if (objvzx_TopicObjectiveCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TopicObjectiveCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TopicObjectiveCond[strFldName].ToString());
}
else
{
if (objvzx_TopicObjectiveCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TopicObjectiveCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TopicObjectiveCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TopicObjectiveCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TopicObjectiveCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TopicObjectiveCond[strFldName]));
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
public static List<clsvzx_TopicObjectiveEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
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
public static List<clsvzx_TopicObjectiveEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
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
List<clsvzx_TopicObjectiveEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_TopicObjectiveEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TopicObjectiveEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_TopicObjectiveEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
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
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
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
public static List<clsvzx_TopicObjectiveEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_TopicObjectiveEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_TopicObjectiveEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
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
public static List<clsvzx_TopicObjectiveEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TopicObjectiveEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_TopicObjectiveEN> arrObjLst = new List<clsvzx_TopicObjectiveEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = new clsvzx_TopicObjectiveEN();
try
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objRow[convzx_TopicObjective.zxTopicObjectiveId].ToString().Trim(); //客观Id
objvzx_TopicObjectiveEN.ObjectiveName = objRow[convzx_TopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvzx_TopicObjectiveEN.ObjectiveContent = objRow[convzx_TopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvzx_TopicObjectiveEN.ObjectiveType = objRow[convzx_TopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convzx_TopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvzx_TopicObjectiveEN.Conclusion = objRow[convzx_TopicObjective.Conclusion] == DBNull.Value ? null : objRow[convzx_TopicObjective.Conclusion].ToString().Trim(); //结论
objvzx_TopicObjectiveEN.TextId = objRow[convzx_TopicObjective.TextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextId].ToString().Trim(); //课件Id
objvzx_TopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvzx_TopicObjectiveEN.VoteCount = objRow[convzx_TopicObjective.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VoteCount].ToString().Trim()); //点赞计数
objvzx_TopicObjectiveEN.AppraiseCount = objRow[convzx_TopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvzx_TopicObjectiveEN.Score = objRow[convzx_TopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.Score].ToString().Trim()); //评分
objvzx_TopicObjectiveEN.StuScore = objRow[convzx_TopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.StuScore].ToString().Trim()); //学生平均分
objvzx_TopicObjectiveEN.TeaScore = objRow[convzx_TopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_TopicObjective.TeaScore].ToString().Trim()); //教师评分
objvzx_TopicObjectiveEN.IdCurrEduCls = objRow[convzx_TopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TopicObjectiveEN.PdfContent = objRow[convzx_TopicObjective.PdfContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvzx_TopicObjectiveEN.PdfPageNum = objRow[convzx_TopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_TopicObjectiveEN.CitationCount = objRow[convzx_TopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.CitationCount].ToString().Trim()); //引用统计
objvzx_TopicObjectiveEN.VersionCount = objRow[convzx_TopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.VersionCount].ToString().Trim()); //版本统计
objvzx_TopicObjectiveEN.zxShareId = objRow[convzx_TopicObjective.zxShareId] == DBNull.Value ? null : objRow[convzx_TopicObjective.zxShareId].ToString().Trim(); //分享Id
objvzx_TopicObjectiveEN.CreateDate = objRow[convzx_TopicObjective.CreateDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.CreateDate].ToString().Trim(); //建立日期
objvzx_TopicObjectiveEN.UpdDate = objRow[convzx_TopicObjective.UpdDate] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdDate].ToString().Trim(); //修改日期
objvzx_TopicObjectiveEN.UpdUser = objRow[convzx_TopicObjective.UpdUser] == DBNull.Value ? null : objRow[convzx_TopicObjective.UpdUser].ToString().Trim(); //修改人
objvzx_TopicObjectiveEN.Memo = objRow[convzx_TopicObjective.Memo] == DBNull.Value ? null : objRow[convzx_TopicObjective.Memo].ToString().Trim(); //备注
objvzx_TopicObjectiveEN.PdfDivLet = objRow[convzx_TopicObjective.PdfDivLet] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_TopicObjectiveEN.PdfDivTop = objRow[convzx_TopicObjective.PdfDivTop] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_TopicObjectiveEN.PdfPageNumIn = objRow[convzx_TopicObjective.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_TopicObjectiveEN.PdfPageTop = objRow[convzx_TopicObjective.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TopicObjective.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_TopicObjectiveEN.PdfZoom = objRow[convzx_TopicObjective.PdfZoom] == DBNull.Value ? null : objRow[convzx_TopicObjective.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_TopicObjectiveEN.GroupTextId = objRow[convzx_TopicObjective.GroupTextId] == DBNull.Value ? null : objRow[convzx_TopicObjective.GroupTextId].ToString().Trim(); //小组Id
objvzx_TopicObjectiveEN.TextTitle = objRow[convzx_TopicObjective.TextTitle] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextTitle].ToString().Trim(); //TextTitle
objvzx_TopicObjectiveEN.TextContent = objRow[convzx_TopicObjective.TextContent] == DBNull.Value ? null : objRow[convzx_TopicObjective.TextContent].ToString().Trim(); //TextContent
objvzx_TopicObjectiveEN.Author = objRow[convzx_TopicObjective.Author] == DBNull.Value ? null : objRow[convzx_TopicObjective.Author].ToString().Trim(); //作者
objvzx_TopicObjectiveEN.Keyword = objRow[convzx_TopicObjective.Keyword] == DBNull.Value ? null : objRow[convzx_TopicObjective.Keyword].ToString().Trim(); //关键字
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TopicObjectiveEN.zxTopicObjectiveId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TopicObjectiveEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_TopicObjective(ref clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN)
{
bool bolResult = vzx_TopicObjectiveDA.Getvzx_TopicObjective(ref objvzx_TopicObjectiveEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TopicObjectiveEN GetObjByzxTopicObjectiveId(string strzxTopicObjectiveId)
{
if (strzxTopicObjectiveId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxTopicObjectiveId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxTopicObjectiveId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxTopicObjectiveId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = vzx_TopicObjectiveDA.GetObjByzxTopicObjectiveId(strzxTopicObjectiveId);
return objvzx_TopicObjectiveEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_TopicObjectiveEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = vzx_TopicObjectiveDA.GetFirstObj(strWhereCond);
 return objvzx_TopicObjectiveEN;
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
public static clsvzx_TopicObjectiveEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = vzx_TopicObjectiveDA.GetObjByDataRow(objRow);
 return objvzx_TopicObjectiveEN;
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
public static clsvzx_TopicObjectiveEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN = vzx_TopicObjectiveDA.GetObjByDataRow(objRow);
 return objvzx_TopicObjectiveEN;
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
 /// <param name = "strzxTopicObjectiveId">所给的关键字</param>
 /// <param name = "lstvzx_TopicObjectiveObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TopicObjectiveEN GetObjByzxTopicObjectiveIdFromList(string strzxTopicObjectiveId, List<clsvzx_TopicObjectiveEN> lstvzx_TopicObjectiveObjLst)
{
foreach (clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN in lstvzx_TopicObjectiveObjLst)
{
if (objvzx_TopicObjectiveEN.zxTopicObjectiveId == strzxTopicObjectiveId)
{
return objvzx_TopicObjectiveEN;
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
 string strMaxZxTopicObjectiveId;
 try
 {
 strMaxZxTopicObjectiveId = clsvzx_TopicObjectiveDA.GetMaxStrId();
 return strMaxZxTopicObjectiveId;
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
 string strzxTopicObjectiveId;
 try
 {
 strzxTopicObjectiveId = new clsvzx_TopicObjectiveDA().GetFirstID(strWhereCond);
 return strzxTopicObjectiveId;
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
 arrList = vzx_TopicObjectiveDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_TopicObjectiveDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxTopicObjectiveId)
{
if (string.IsNullOrEmpty(strzxTopicObjectiveId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxTopicObjectiveId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_TopicObjectiveDA.IsExist(strzxTopicObjectiveId);
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
 bolIsExist = clsvzx_TopicObjectiveDA.IsExistTable();
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
 bolIsExist = vzx_TopicObjectiveDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_TopicObjectiveENS">源对象</param>
 /// <param name = "objvzx_TopicObjectiveENT">目标对象</param>
 public static void CopyTo(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENS, clsvzx_TopicObjectiveEN objvzx_TopicObjectiveENT)
{
try
{
objvzx_TopicObjectiveENT.zxTopicObjectiveId = objvzx_TopicObjectiveENS.zxTopicObjectiveId; //客观Id
objvzx_TopicObjectiveENT.ObjectiveName = objvzx_TopicObjectiveENS.ObjectiveName; //客观名称
objvzx_TopicObjectiveENT.ObjectiveContent = objvzx_TopicObjectiveENS.ObjectiveContent; //客观内容
objvzx_TopicObjectiveENT.ObjectiveType = objvzx_TopicObjectiveENS.ObjectiveType; //客观类型
objvzx_TopicObjectiveENT.Conclusion = objvzx_TopicObjectiveENS.Conclusion; //结论
objvzx_TopicObjectiveENT.TextId = objvzx_TopicObjectiveENS.TextId; //课件Id
objvzx_TopicObjectiveENT.IsSubmit = objvzx_TopicObjectiveENS.IsSubmit; //是否提交
objvzx_TopicObjectiveENT.VoteCount = objvzx_TopicObjectiveENS.VoteCount; //点赞计数
objvzx_TopicObjectiveENT.AppraiseCount = objvzx_TopicObjectiveENS.AppraiseCount; //评论数
objvzx_TopicObjectiveENT.Score = objvzx_TopicObjectiveENS.Score; //评分
objvzx_TopicObjectiveENT.StuScore = objvzx_TopicObjectiveENS.StuScore; //学生平均分
objvzx_TopicObjectiveENT.TeaScore = objvzx_TopicObjectiveENS.TeaScore; //教师评分
objvzx_TopicObjectiveENT.IdCurrEduCls = objvzx_TopicObjectiveENS.IdCurrEduCls; //教学班流水号
objvzx_TopicObjectiveENT.PdfContent = objvzx_TopicObjectiveENS.PdfContent; //Pdf内容
objvzx_TopicObjectiveENT.PdfPageNum = objvzx_TopicObjectiveENS.PdfPageNum; //Pdf页码
objvzx_TopicObjectiveENT.CitationCount = objvzx_TopicObjectiveENS.CitationCount; //引用统计
objvzx_TopicObjectiveENT.VersionCount = objvzx_TopicObjectiveENS.VersionCount; //版本统计
objvzx_TopicObjectiveENT.zxShareId = objvzx_TopicObjectiveENS.zxShareId; //分享Id
objvzx_TopicObjectiveENT.CreateDate = objvzx_TopicObjectiveENS.CreateDate; //建立日期
objvzx_TopicObjectiveENT.UpdDate = objvzx_TopicObjectiveENS.UpdDate; //修改日期
objvzx_TopicObjectiveENT.UpdUser = objvzx_TopicObjectiveENS.UpdUser; //修改人
objvzx_TopicObjectiveENT.Memo = objvzx_TopicObjectiveENS.Memo; //备注
objvzx_TopicObjectiveENT.PdfDivLet = objvzx_TopicObjectiveENS.PdfDivLet; //PdfDivLet
objvzx_TopicObjectiveENT.PdfDivTop = objvzx_TopicObjectiveENS.PdfDivTop; //PdfDivTop
objvzx_TopicObjectiveENT.PdfPageNumIn = objvzx_TopicObjectiveENS.PdfPageNumIn; //PdfPageNumIn
objvzx_TopicObjectiveENT.PdfPageTop = objvzx_TopicObjectiveENS.PdfPageTop; //pdf页面顶部位置
objvzx_TopicObjectiveENT.PdfZoom = objvzx_TopicObjectiveENS.PdfZoom; //PdfZoom
objvzx_TopicObjectiveENT.GroupTextId = objvzx_TopicObjectiveENS.GroupTextId; //小组Id
objvzx_TopicObjectiveENT.TextTitle = objvzx_TopicObjectiveENS.TextTitle; //TextTitle
objvzx_TopicObjectiveENT.TextContent = objvzx_TopicObjectiveENS.TextContent; //TextContent
objvzx_TopicObjectiveENT.Author = objvzx_TopicObjectiveENS.Author; //作者
objvzx_TopicObjectiveENT.Keyword = objvzx_TopicObjectiveENS.Keyword; //关键字
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
 /// <param name = "objvzx_TopicObjectiveEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN)
{
try
{
objvzx_TopicObjectiveEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_TopicObjectiveEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_TopicObjective.zxTopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.zxTopicObjectiveId = objvzx_TopicObjectiveEN.zxTopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(convzx_TopicObjective.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.ObjectiveName = objvzx_TopicObjectiveEN.ObjectiveName == "[null]" ? null :  objvzx_TopicObjectiveEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(convzx_TopicObjective.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.ObjectiveContent = objvzx_TopicObjectiveEN.ObjectiveContent == "[null]" ? null :  objvzx_TopicObjectiveEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(convzx_TopicObjective.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.ObjectiveType = objvzx_TopicObjectiveEN.ObjectiveType == "[null]" ? null :  objvzx_TopicObjectiveEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(convzx_TopicObjective.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.Conclusion = objvzx_TopicObjectiveEN.Conclusion == "[null]" ? null :  objvzx_TopicObjectiveEN.Conclusion; //结论
}
if (arrFldSet.Contains(convzx_TopicObjective.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.TextId = objvzx_TopicObjectiveEN.TextId == "[null]" ? null :  objvzx_TopicObjectiveEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_TopicObjective.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.IsSubmit = objvzx_TopicObjectiveEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_TopicObjective.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.VoteCount = objvzx_TopicObjectiveEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_TopicObjective.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.AppraiseCount = objvzx_TopicObjectiveEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_TopicObjective.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.Score = objvzx_TopicObjectiveEN.Score; //评分
}
if (arrFldSet.Contains(convzx_TopicObjective.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.StuScore = objvzx_TopicObjectiveEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_TopicObjective.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.TeaScore = objvzx_TopicObjectiveEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_TopicObjective.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.IdCurrEduCls = objvzx_TopicObjectiveEN.IdCurrEduCls == "[null]" ? null :  objvzx_TopicObjectiveEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_TopicObjective.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.PdfContent = objvzx_TopicObjectiveEN.PdfContent == "[null]" ? null :  objvzx_TopicObjectiveEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_TopicObjective.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.PdfPageNum = objvzx_TopicObjectiveEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_TopicObjective.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.CitationCount = objvzx_TopicObjectiveEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convzx_TopicObjective.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.VersionCount = objvzx_TopicObjectiveEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_TopicObjective.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.zxShareId = objvzx_TopicObjectiveEN.zxShareId == "[null]" ? null :  objvzx_TopicObjectiveEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_TopicObjective.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.CreateDate = objvzx_TopicObjectiveEN.CreateDate == "[null]" ? null :  objvzx_TopicObjectiveEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_TopicObjective.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.UpdDate = objvzx_TopicObjectiveEN.UpdDate == "[null]" ? null :  objvzx_TopicObjectiveEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_TopicObjective.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.UpdUser = objvzx_TopicObjectiveEN.UpdUser == "[null]" ? null :  objvzx_TopicObjectiveEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_TopicObjective.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.Memo = objvzx_TopicObjectiveEN.Memo == "[null]" ? null :  objvzx_TopicObjectiveEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_TopicObjective.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.PdfDivLet = objvzx_TopicObjectiveEN.PdfDivLet == "[null]" ? null :  objvzx_TopicObjectiveEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_TopicObjective.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.PdfDivTop = objvzx_TopicObjectiveEN.PdfDivTop == "[null]" ? null :  objvzx_TopicObjectiveEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_TopicObjective.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.PdfPageNumIn = objvzx_TopicObjectiveEN.PdfPageNumIn == "[null]" ? null :  objvzx_TopicObjectiveEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_TopicObjective.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.PdfPageTop = objvzx_TopicObjectiveEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_TopicObjective.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.PdfZoom = objvzx_TopicObjectiveEN.PdfZoom == "[null]" ? null :  objvzx_TopicObjectiveEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_TopicObjective.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.GroupTextId = objvzx_TopicObjectiveEN.GroupTextId == "[null]" ? null :  objvzx_TopicObjectiveEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_TopicObjective.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.TextTitle = objvzx_TopicObjectiveEN.TextTitle == "[null]" ? null :  objvzx_TopicObjectiveEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_TopicObjective.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.TextContent = objvzx_TopicObjectiveEN.TextContent == "[null]" ? null :  objvzx_TopicObjectiveEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_TopicObjective.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.Author = objvzx_TopicObjectiveEN.Author == "[null]" ? null :  objvzx_TopicObjectiveEN.Author; //作者
}
if (arrFldSet.Contains(convzx_TopicObjective.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TopicObjectiveEN.Keyword = objvzx_TopicObjectiveEN.Keyword == "[null]" ? null :  objvzx_TopicObjectiveEN.Keyword; //关键字
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
 /// <param name = "objvzx_TopicObjectiveEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN)
{
try
{
if (objvzx_TopicObjectiveEN.ObjectiveName == "[null]") objvzx_TopicObjectiveEN.ObjectiveName = null; //客观名称
if (objvzx_TopicObjectiveEN.ObjectiveContent == "[null]") objvzx_TopicObjectiveEN.ObjectiveContent = null; //客观内容
if (objvzx_TopicObjectiveEN.ObjectiveType == "[null]") objvzx_TopicObjectiveEN.ObjectiveType = null; //客观类型
if (objvzx_TopicObjectiveEN.Conclusion == "[null]") objvzx_TopicObjectiveEN.Conclusion = null; //结论
if (objvzx_TopicObjectiveEN.TextId == "[null]") objvzx_TopicObjectiveEN.TextId = null; //课件Id
if (objvzx_TopicObjectiveEN.IdCurrEduCls == "[null]") objvzx_TopicObjectiveEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_TopicObjectiveEN.PdfContent == "[null]") objvzx_TopicObjectiveEN.PdfContent = null; //Pdf内容
if (objvzx_TopicObjectiveEN.zxShareId == "[null]") objvzx_TopicObjectiveEN.zxShareId = null; //分享Id
if (objvzx_TopicObjectiveEN.CreateDate == "[null]") objvzx_TopicObjectiveEN.CreateDate = null; //建立日期
if (objvzx_TopicObjectiveEN.UpdDate == "[null]") objvzx_TopicObjectiveEN.UpdDate = null; //修改日期
if (objvzx_TopicObjectiveEN.UpdUser == "[null]") objvzx_TopicObjectiveEN.UpdUser = null; //修改人
if (objvzx_TopicObjectiveEN.Memo == "[null]") objvzx_TopicObjectiveEN.Memo = null; //备注
if (objvzx_TopicObjectiveEN.PdfDivLet == "[null]") objvzx_TopicObjectiveEN.PdfDivLet = null; //PdfDivLet
if (objvzx_TopicObjectiveEN.PdfDivTop == "[null]") objvzx_TopicObjectiveEN.PdfDivTop = null; //PdfDivTop
if (objvzx_TopicObjectiveEN.PdfPageNumIn == "[null]") objvzx_TopicObjectiveEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_TopicObjectiveEN.PdfZoom == "[null]") objvzx_TopicObjectiveEN.PdfZoom = null; //PdfZoom
if (objvzx_TopicObjectiveEN.GroupTextId == "[null]") objvzx_TopicObjectiveEN.GroupTextId = null; //小组Id
if (objvzx_TopicObjectiveEN.TextTitle == "[null]") objvzx_TopicObjectiveEN.TextTitle = null; //TextTitle
if (objvzx_TopicObjectiveEN.TextContent == "[null]") objvzx_TopicObjectiveEN.TextContent = null; //TextContent
if (objvzx_TopicObjectiveEN.Author == "[null]") objvzx_TopicObjectiveEN.Author = null; //作者
if (objvzx_TopicObjectiveEN.Keyword == "[null]") objvzx_TopicObjectiveEN.Keyword = null; //关键字
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
public static void CheckProperty4Condition(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveEN)
{
 vzx_TopicObjectiveDA.CheckProperty4Condition(objvzx_TopicObjectiveEN);
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
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TopicObjectiveBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TopicObjectiveBL没有刷新缓存机制(clszx_TopicObjectiveBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxTopicObjectiveId");
//if (arrvzx_TopicObjectiveObjLstCache == null)
//{
//arrvzx_TopicObjectiveObjLstCache = vzx_TopicObjectiveDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxTopicObjectiveId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TopicObjectiveEN GetObjByzxTopicObjectiveIdCache(string strzxTopicObjectiveId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_TopicObjectiveEN> arrvzx_TopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TopicObjectiveEN> arrvzx_TopicObjectiveObjLst_Sel =
arrvzx_TopicObjectiveObjLstCache
.Where(x=> x.zxTopicObjectiveId == strzxTopicObjectiveId 
);
if (arrvzx_TopicObjectiveObjLst_Sel.Count() == 0)
{
   clsvzx_TopicObjectiveEN obj = clsvzx_TopicObjectiveBL.GetObjByzxTopicObjectiveId(strzxTopicObjectiveId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxTopicObjectiveId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_TopicObjectiveObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TopicObjectiveEN> GetAllvzx_TopicObjectiveObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_TopicObjectiveEN> arrvzx_TopicObjectiveObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_TopicObjectiveObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TopicObjectiveEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_TopicObjectiveEN> arrvzx_TopicObjectiveObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_TopicObjectiveObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_TopicObjectiveEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strzxTopicObjectiveId, string strIdCurrEduCls)
{
if (strInFldName != convzx_TopicObjective.zxTopicObjectiveId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_TopicObjective.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_TopicObjective.AttributeName));
throw new Exception(strMsg);
}
var objvzx_TopicObjective = clsvzx_TopicObjectiveBL.GetObjByzxTopicObjectiveIdCache(strzxTopicObjectiveId, strIdCurrEduCls);
if (objvzx_TopicObjective == null) return "";
return objvzx_TopicObjective[strOutFldName].ToString();
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
int intRecCount = clsvzx_TopicObjectiveDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_TopicObjectiveDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_TopicObjectiveDA.GetRecCount();
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
int intRecCount = clsvzx_TopicObjectiveDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_TopicObjectiveCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_TopicObjectiveEN objvzx_TopicObjectiveCond)
{
 string strIdCurrEduCls = objvzx_TopicObjectiveCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_TopicObjectiveBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_TopicObjectiveEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_TopicObjectiveEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TopicObjective.AttributeName)
{
if (objvzx_TopicObjectiveCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TopicObjectiveCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TopicObjectiveCond[strFldName].ToString());
}
else
{
if (objvzx_TopicObjectiveCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TopicObjectiveCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TopicObjectiveCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TopicObjectiveCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TopicObjectiveCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TopicObjectiveCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TopicObjectiveCond[strFldName]));
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
 List<string> arrList = clsvzx_TopicObjectiveDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_TopicObjectiveDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_TopicObjectiveDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}