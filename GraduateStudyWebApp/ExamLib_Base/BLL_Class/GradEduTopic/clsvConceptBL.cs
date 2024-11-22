
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConceptBL
 表名:vConcept(01120619)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:27
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
public static class  clsvConceptBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConceptEN GetObj(this K_ConceptId_vConcept myKey)
{
clsvConceptEN objvConceptEN = clsvConceptBL.vConceptDA.GetObjByConceptId(myKey.Value);
return objvConceptEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetConceptContent(this clsvConceptEN objvConceptEN, string strConceptContent, string strComparisonOp="")
	{
objvConceptEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.ConceptContent) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.ConceptContent, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.ConceptContent] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetConceptName(this clsvConceptEN objvConceptEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, convConcept.ConceptName);
}
objvConceptEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.ConceptName) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.ConceptName, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.ConceptName] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetIsSubmit(this clsvConceptEN objvConceptEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvConceptEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.IsSubmit) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.IsSubmit, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.IsSubmit] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetConceptId(this clsvConceptEN objvConceptEN, string strConceptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, convConcept.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, convConcept.ConceptId);
}
objvConceptEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.ConceptId) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.ConceptId, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.ConceptId] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetUpdDate(this clsvConceptEN objvConceptEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convConcept.UpdDate);
}
objvConceptEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.UpdDate) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.UpdDate, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.UpdDate] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetMemo(this clsvConceptEN objvConceptEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convConcept.Memo);
}
objvConceptEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.Memo) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.Memo, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.Memo] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetAuthor(this clsvConceptEN objvConceptEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convConcept.Author);
}
objvConceptEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.Author) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.Author, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.Author] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetCitationId(this clsvConceptEN objvConceptEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, convConcept.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, convConcept.CitationId);
}
objvConceptEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.CitationId) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.CitationId, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.CitationId] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetKeyword(this clsvConceptEN objvConceptEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convConcept.Keyword);
}
objvConceptEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.Keyword) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.Keyword, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.Keyword] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetPaperTitle(this clsvConceptEN objvConceptEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convConcept.PaperTitle);
}
objvConceptEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.PaperTitle) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.PaperTitle, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.PaperTitle] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetPeriodical(this clsvConceptEN objvConceptEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convConcept.Periodical);
}
objvConceptEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.Periodical) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.Periodical, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.Periodical] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetResearchQuestion(this clsvConceptEN objvConceptEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convConcept.ResearchQuestion);
}
objvConceptEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.ResearchQuestion) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.ResearchQuestion, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.ResearchQuestion] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetCitationCount(this clsvConceptEN objvConceptEN, int? intCitationCount, string strComparisonOp="")
	{
objvConceptEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.CitationCount) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.CitationCount, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.CitationCount] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetAppraiseCount(this clsvConceptEN objvConceptEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvConceptEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.AppraiseCount) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.AppraiseCount, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.AppraiseCount] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetScore(this clsvConceptEN objvConceptEN, float? fltScore, string strComparisonOp="")
	{
objvConceptEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.Score) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.Score, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.Score] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetStuScore(this clsvConceptEN objvConceptEN, float? fltStuScore, string strComparisonOp="")
	{
objvConceptEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.StuScore) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.StuScore, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.StuScore] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetTeaScore(this clsvConceptEN objvConceptEN, float? fltTeaScore, string strComparisonOp="")
	{
objvConceptEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.TeaScore) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.TeaScore, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.TeaScore] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetIdCurrEduCls(this clsvConceptEN objvConceptEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convConcept.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convConcept.IdCurrEduCls);
}
objvConceptEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.IdCurrEduCls) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.IdCurrEduCls, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.IdCurrEduCls] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetPdfPageNum(this clsvConceptEN objvConceptEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvConceptEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.PdfPageNum) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.PdfPageNum, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.PdfPageNum] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetOkCount(this clsvConceptEN objvConceptEN, int? intOkCount, string strComparisonOp="")
	{
objvConceptEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.OkCount) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.OkCount, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.OkCount] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetVersionCount(this clsvConceptEN objvConceptEN, int? intVersionCount, string strComparisonOp="")
	{
objvConceptEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.VersionCount) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.VersionCount, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.VersionCount] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetCreateDate(this clsvConceptEN objvConceptEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convConcept.CreateDate);
}
objvConceptEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.CreateDate) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.CreateDate, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.CreateDate] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetShareId(this clsvConceptEN objvConceptEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, convConcept.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convConcept.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convConcept.ShareId);
}
objvConceptEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.ShareId) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.ShareId, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.ShareId] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetUpdUser(this clsvConceptEN objvConceptEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convConcept.UpdUser);
}
objvConceptEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.UpdUser) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.UpdUser, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.UpdUser] = strComparisonOp;
}
}
return objvConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptEN SetPdfContent(this clsvConceptEN objvConceptEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convConcept.PdfContent);
}
objvConceptEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptEN.dicFldComparisonOp.ContainsKey(convConcept.PdfContent) == false)
{
objvConceptEN.dicFldComparisonOp.Add(convConcept.PdfContent, strComparisonOp);
}
else
{
objvConceptEN.dicFldComparisonOp[convConcept.PdfContent] = strComparisonOp;
}
}
return objvConceptEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvConceptENS">源对象</param>
 /// <param name = "objvConceptENT">目标对象</param>
 public static void CopyTo(this clsvConceptEN objvConceptENS, clsvConceptEN objvConceptENT)
{
try
{
objvConceptENT.ConceptContent = objvConceptENS.ConceptContent; //概念内容
objvConceptENT.ConceptName = objvConceptENS.ConceptName; //概念名称
objvConceptENT.IsSubmit = objvConceptENS.IsSubmit; //是否提交
objvConceptENT.ConceptId = objvConceptENS.ConceptId; //概念Id
objvConceptENT.UpdDate = objvConceptENS.UpdDate; //修改日期
objvConceptENT.Memo = objvConceptENS.Memo; //备注
objvConceptENT.Author = objvConceptENS.Author; //作者
objvConceptENT.CitationId = objvConceptENS.CitationId; //引用Id
objvConceptENT.Keyword = objvConceptENS.Keyword; //关键字
objvConceptENT.PaperTitle = objvConceptENS.PaperTitle; //论文标题
objvConceptENT.Periodical = objvConceptENS.Periodical; //期刊
objvConceptENT.ResearchQuestion = objvConceptENS.ResearchQuestion; //研究问题
objvConceptENT.CitationCount = objvConceptENS.CitationCount; //引用统计
objvConceptENT.AppraiseCount = objvConceptENS.AppraiseCount; //评论数
objvConceptENT.Score = objvConceptENS.Score; //评分
objvConceptENT.StuScore = objvConceptENS.StuScore; //学生平均分
objvConceptENT.TeaScore = objvConceptENS.TeaScore; //教师评分
objvConceptENT.IdCurrEduCls = objvConceptENS.IdCurrEduCls; //教学班流水号
objvConceptENT.PdfPageNum = objvConceptENS.PdfPageNum; //Pdf页码
objvConceptENT.OkCount = objvConceptENS.OkCount; //点赞统计
objvConceptENT.VersionCount = objvConceptENS.VersionCount; //版本统计
objvConceptENT.CreateDate = objvConceptENS.CreateDate; //建立日期
objvConceptENT.ShareId = objvConceptENS.ShareId; //分享Id
objvConceptENT.UpdUser = objvConceptENS.UpdUser; //修改人
objvConceptENT.PdfContent = objvConceptENS.PdfContent; //Pdf内容
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
 /// <param name = "objvConceptENS">源对象</param>
 /// <returns>目标对象=>clsvConceptEN:objvConceptENT</returns>
 public static clsvConceptEN CopyTo(this clsvConceptEN objvConceptENS)
{
try
{
 clsvConceptEN objvConceptENT = new clsvConceptEN()
{
ConceptContent = objvConceptENS.ConceptContent, //概念内容
ConceptName = objvConceptENS.ConceptName, //概念名称
IsSubmit = objvConceptENS.IsSubmit, //是否提交
ConceptId = objvConceptENS.ConceptId, //概念Id
UpdDate = objvConceptENS.UpdDate, //修改日期
Memo = objvConceptENS.Memo, //备注
Author = objvConceptENS.Author, //作者
CitationId = objvConceptENS.CitationId, //引用Id
Keyword = objvConceptENS.Keyword, //关键字
PaperTitle = objvConceptENS.PaperTitle, //论文标题
Periodical = objvConceptENS.Periodical, //期刊
ResearchQuestion = objvConceptENS.ResearchQuestion, //研究问题
CitationCount = objvConceptENS.CitationCount, //引用统计
AppraiseCount = objvConceptENS.AppraiseCount, //评论数
Score = objvConceptENS.Score, //评分
StuScore = objvConceptENS.StuScore, //学生平均分
TeaScore = objvConceptENS.TeaScore, //教师评分
IdCurrEduCls = objvConceptENS.IdCurrEduCls, //教学班流水号
PdfPageNum = objvConceptENS.PdfPageNum, //Pdf页码
OkCount = objvConceptENS.OkCount, //点赞统计
VersionCount = objvConceptENS.VersionCount, //版本统计
CreateDate = objvConceptENS.CreateDate, //建立日期
ShareId = objvConceptENS.ShareId, //分享Id
UpdUser = objvConceptENS.UpdUser, //修改人
PdfContent = objvConceptENS.PdfContent, //Pdf内容
};
 return objvConceptENT;
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
public static void CheckProperty4Condition(this clsvConceptEN objvConceptEN)
{
 clsvConceptBL.vConceptDA.CheckProperty4Condition(objvConceptEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvConceptEN objvConceptCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvConceptCond.IsUpdated(convConcept.ConceptName) == true)
{
string strComparisonOpConceptName = objvConceptCond.dicFldComparisonOp[convConcept.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.ConceptName, objvConceptCond.ConceptName, strComparisonOpConceptName);
}
if (objvConceptCond.IsUpdated(convConcept.IsSubmit) == true)
{
if (objvConceptCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convConcept.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convConcept.IsSubmit);
}
}
if (objvConceptCond.IsUpdated(convConcept.ConceptId) == true)
{
string strComparisonOpConceptId = objvConceptCond.dicFldComparisonOp[convConcept.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.ConceptId, objvConceptCond.ConceptId, strComparisonOpConceptId);
}
if (objvConceptCond.IsUpdated(convConcept.UpdDate) == true)
{
string strComparisonOpUpdDate = objvConceptCond.dicFldComparisonOp[convConcept.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.UpdDate, objvConceptCond.UpdDate, strComparisonOpUpdDate);
}
if (objvConceptCond.IsUpdated(convConcept.Memo) == true)
{
string strComparisonOpMemo = objvConceptCond.dicFldComparisonOp[convConcept.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.Memo, objvConceptCond.Memo, strComparisonOpMemo);
}
if (objvConceptCond.IsUpdated(convConcept.Author) == true)
{
string strComparisonOpAuthor = objvConceptCond.dicFldComparisonOp[convConcept.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.Author, objvConceptCond.Author, strComparisonOpAuthor);
}
if (objvConceptCond.IsUpdated(convConcept.CitationId) == true)
{
string strComparisonOpCitationId = objvConceptCond.dicFldComparisonOp[convConcept.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.CitationId, objvConceptCond.CitationId, strComparisonOpCitationId);
}
if (objvConceptCond.IsUpdated(convConcept.Keyword) == true)
{
string strComparisonOpKeyword = objvConceptCond.dicFldComparisonOp[convConcept.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.Keyword, objvConceptCond.Keyword, strComparisonOpKeyword);
}
if (objvConceptCond.IsUpdated(convConcept.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvConceptCond.dicFldComparisonOp[convConcept.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.PaperTitle, objvConceptCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvConceptCond.IsUpdated(convConcept.Periodical) == true)
{
string strComparisonOpPeriodical = objvConceptCond.dicFldComparisonOp[convConcept.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.Periodical, objvConceptCond.Periodical, strComparisonOpPeriodical);
}
if (objvConceptCond.IsUpdated(convConcept.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvConceptCond.dicFldComparisonOp[convConcept.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.ResearchQuestion, objvConceptCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvConceptCond.IsUpdated(convConcept.CitationCount) == true)
{
string strComparisonOpCitationCount = objvConceptCond.dicFldComparisonOp[convConcept.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.CitationCount, objvConceptCond.CitationCount, strComparisonOpCitationCount);
}
if (objvConceptCond.IsUpdated(convConcept.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvConceptCond.dicFldComparisonOp[convConcept.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.AppraiseCount, objvConceptCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvConceptCond.IsUpdated(convConcept.Score) == true)
{
string strComparisonOpScore = objvConceptCond.dicFldComparisonOp[convConcept.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.Score, objvConceptCond.Score, strComparisonOpScore);
}
if (objvConceptCond.IsUpdated(convConcept.StuScore) == true)
{
string strComparisonOpStuScore = objvConceptCond.dicFldComparisonOp[convConcept.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.StuScore, objvConceptCond.StuScore, strComparisonOpStuScore);
}
if (objvConceptCond.IsUpdated(convConcept.TeaScore) == true)
{
string strComparisonOpTeaScore = objvConceptCond.dicFldComparisonOp[convConcept.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.TeaScore, objvConceptCond.TeaScore, strComparisonOpTeaScore);
}
if (objvConceptCond.IsUpdated(convConcept.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvConceptCond.dicFldComparisonOp[convConcept.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.IdCurrEduCls, objvConceptCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvConceptCond.IsUpdated(convConcept.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvConceptCond.dicFldComparisonOp[convConcept.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.PdfPageNum, objvConceptCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvConceptCond.IsUpdated(convConcept.OkCount) == true)
{
string strComparisonOpOkCount = objvConceptCond.dicFldComparisonOp[convConcept.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.OkCount, objvConceptCond.OkCount, strComparisonOpOkCount);
}
if (objvConceptCond.IsUpdated(convConcept.VersionCount) == true)
{
string strComparisonOpVersionCount = objvConceptCond.dicFldComparisonOp[convConcept.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convConcept.VersionCount, objvConceptCond.VersionCount, strComparisonOpVersionCount);
}
if (objvConceptCond.IsUpdated(convConcept.CreateDate) == true)
{
string strComparisonOpCreateDate = objvConceptCond.dicFldComparisonOp[convConcept.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.CreateDate, objvConceptCond.CreateDate, strComparisonOpCreateDate);
}
if (objvConceptCond.IsUpdated(convConcept.ShareId) == true)
{
string strComparisonOpShareId = objvConceptCond.dicFldComparisonOp[convConcept.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.ShareId, objvConceptCond.ShareId, strComparisonOpShareId);
}
if (objvConceptCond.IsUpdated(convConcept.UpdUser) == true)
{
string strComparisonOpUpdUser = objvConceptCond.dicFldComparisonOp[convConcept.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.UpdUser, objvConceptCond.UpdUser, strComparisonOpUpdUser);
}
if (objvConceptCond.IsUpdated(convConcept.PdfContent) == true)
{
string strComparisonOpPdfContent = objvConceptCond.dicFldComparisonOp[convConcept.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConcept.PdfContent, objvConceptCond.PdfContent, strComparisonOpPdfContent);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vConcept
{
public virtual bool UpdRelaTabDate(string strConceptId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 概念视图(vConcept)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvConceptBL
{
public static RelatedActions_vConcept relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvConceptDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvConceptDA vConceptDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvConceptDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvConceptBL()
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
if (string.IsNullOrEmpty(clsvConceptEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvConceptEN._ConnectString);
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
public static DataTable GetDataTable_vConcept(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vConceptDA.GetDataTable_vConcept(strWhereCond);
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
objDT = vConceptDA.GetDataTable(strWhereCond);
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
objDT = vConceptDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vConceptDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vConceptDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vConceptDA.GetDataTable_Top(objTopPara);
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
objDT = vConceptDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvConceptEN> GetObjLstByConceptIdLst(List<string> arrConceptIdLst)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConceptIdLst, true);
 string strWhereCond = string.Format("ConceptId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvConceptEN> GetObjLstByConceptIdLstCache(List<string> arrConceptIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvConceptEN._CurrTabName, strIdCurrEduCls);
List<clsvConceptEN> arrvConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptEN> arrvConceptObjLst_Sel =
arrvConceptObjLstCache
.Where(x => arrConceptIdLst.Contains(x.ConceptId));
return arrvConceptObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptEN> GetObjLst(string strWhereCond)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
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
public static List<clsvConceptEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvConceptEN> GetSubObjLstCache(clsvConceptEN objvConceptCond)
{
 string strIdCurrEduCls = objvConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvConceptBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConcept.AttributeName)
{
if (objvConceptCond.IsUpdated(strFldName) == false) continue;
if (objvConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCond[strFldName].ToString());
}
else
{
if (objvConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConceptCond[strFldName]));
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
public static List<clsvConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
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
public static List<clsvConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
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
List<clsvConceptEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvConceptEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
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
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
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
public static List<clsvConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvConceptEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
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
public static List<clsvConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvConceptEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvConcept(ref clsvConceptEN objvConceptEN)
{
bool bolResult = vConceptDA.GetvConcept(ref objvConceptEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConceptEN GetObjByConceptId(string strConceptId)
{
if (strConceptId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strConceptId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strConceptId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvConceptEN objvConceptEN = vConceptDA.GetObjByConceptId(strConceptId);
return objvConceptEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvConceptEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvConceptEN objvConceptEN = vConceptDA.GetFirstObj(strWhereCond);
 return objvConceptEN;
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
public static clsvConceptEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvConceptEN objvConceptEN = vConceptDA.GetObjByDataRow(objRow);
 return objvConceptEN;
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
public static clsvConceptEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvConceptEN objvConceptEN = vConceptDA.GetObjByDataRow(objRow);
 return objvConceptEN;
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
 /// <param name = "strConceptId">所给的关键字</param>
 /// <param name = "lstvConceptObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConceptEN GetObjByConceptIdFromList(string strConceptId, List<clsvConceptEN> lstvConceptObjLst)
{
foreach (clsvConceptEN objvConceptEN in lstvConceptObjLst)
{
if (objvConceptEN.ConceptId == strConceptId)
{
return objvConceptEN;
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
 string strMaxConceptId;
 try
 {
 strMaxConceptId = clsvConceptDA.GetMaxStrId();
 return strMaxConceptId;
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
 string strConceptId;
 try
 {
 strConceptId = new clsvConceptDA().GetFirstID(strWhereCond);
 return strConceptId;
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
 arrList = vConceptDA.GetID(strWhereCond);
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
bool bolIsExist = vConceptDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strConceptId)
{
if (string.IsNullOrEmpty(strConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strConceptId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vConceptDA.IsExist(strConceptId);
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
 bolIsExist = clsvConceptDA.IsExistTable();
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
 bolIsExist = vConceptDA.IsExistTable(strTabName);
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
 /// <param name = "objvConceptENS">源对象</param>
 /// <param name = "objvConceptENT">目标对象</param>
 public static void CopyTo(clsvConceptEN objvConceptENS, clsvConceptEN objvConceptENT)
{
try
{
objvConceptENT.ConceptContent = objvConceptENS.ConceptContent; //概念内容
objvConceptENT.ConceptName = objvConceptENS.ConceptName; //概念名称
objvConceptENT.IsSubmit = objvConceptENS.IsSubmit; //是否提交
objvConceptENT.ConceptId = objvConceptENS.ConceptId; //概念Id
objvConceptENT.UpdDate = objvConceptENS.UpdDate; //修改日期
objvConceptENT.Memo = objvConceptENS.Memo; //备注
objvConceptENT.Author = objvConceptENS.Author; //作者
objvConceptENT.CitationId = objvConceptENS.CitationId; //引用Id
objvConceptENT.Keyword = objvConceptENS.Keyword; //关键字
objvConceptENT.PaperTitle = objvConceptENS.PaperTitle; //论文标题
objvConceptENT.Periodical = objvConceptENS.Periodical; //期刊
objvConceptENT.ResearchQuestion = objvConceptENS.ResearchQuestion; //研究问题
objvConceptENT.CitationCount = objvConceptENS.CitationCount; //引用统计
objvConceptENT.AppraiseCount = objvConceptENS.AppraiseCount; //评论数
objvConceptENT.Score = objvConceptENS.Score; //评分
objvConceptENT.StuScore = objvConceptENS.StuScore; //学生平均分
objvConceptENT.TeaScore = objvConceptENS.TeaScore; //教师评分
objvConceptENT.IdCurrEduCls = objvConceptENS.IdCurrEduCls; //教学班流水号
objvConceptENT.PdfPageNum = objvConceptENS.PdfPageNum; //Pdf页码
objvConceptENT.OkCount = objvConceptENS.OkCount; //点赞统计
objvConceptENT.VersionCount = objvConceptENS.VersionCount; //版本统计
objvConceptENT.CreateDate = objvConceptENS.CreateDate; //建立日期
objvConceptENT.ShareId = objvConceptENS.ShareId; //分享Id
objvConceptENT.UpdUser = objvConceptENS.UpdUser; //修改人
objvConceptENT.PdfContent = objvConceptENS.PdfContent; //Pdf内容
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
 /// <param name = "objvConceptEN">源简化对象</param>
 public static void SetUpdFlag(clsvConceptEN objvConceptEN)
{
try
{
objvConceptEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvConceptEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convConcept.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.ConceptContent = objvConceptEN.ConceptContent == "[null]" ? null :  objvConceptEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(convConcept.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.ConceptName = objvConceptEN.ConceptName == "[null]" ? null :  objvConceptEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(convConcept.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.IsSubmit = objvConceptEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convConcept.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.ConceptId = objvConceptEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(convConcept.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.UpdDate = objvConceptEN.UpdDate == "[null]" ? null :  objvConceptEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convConcept.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.Memo = objvConceptEN.Memo == "[null]" ? null :  objvConceptEN.Memo; //备注
}
if (arrFldSet.Contains(convConcept.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.Author = objvConceptEN.Author == "[null]" ? null :  objvConceptEN.Author; //作者
}
if (arrFldSet.Contains(convConcept.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.CitationId = objvConceptEN.CitationId == "[null]" ? null :  objvConceptEN.CitationId; //引用Id
}
if (arrFldSet.Contains(convConcept.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.Keyword = objvConceptEN.Keyword == "[null]" ? null :  objvConceptEN.Keyword; //关键字
}
if (arrFldSet.Contains(convConcept.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.PaperTitle = objvConceptEN.PaperTitle == "[null]" ? null :  objvConceptEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convConcept.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.Periodical = objvConceptEN.Periodical == "[null]" ? null :  objvConceptEN.Periodical; //期刊
}
if (arrFldSet.Contains(convConcept.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.ResearchQuestion = objvConceptEN.ResearchQuestion == "[null]" ? null :  objvConceptEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convConcept.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.CitationCount = objvConceptEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convConcept.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.AppraiseCount = objvConceptEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convConcept.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.Score = objvConceptEN.Score; //评分
}
if (arrFldSet.Contains(convConcept.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.StuScore = objvConceptEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convConcept.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.TeaScore = objvConceptEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convConcept.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.IdCurrEduCls = objvConceptEN.IdCurrEduCls == "[null]" ? null :  objvConceptEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convConcept.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.PdfPageNum = objvConceptEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convConcept.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.OkCount = objvConceptEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convConcept.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.VersionCount = objvConceptEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convConcept.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.CreateDate = objvConceptEN.CreateDate == "[null]" ? null :  objvConceptEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convConcept.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.ShareId = objvConceptEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convConcept.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.UpdUser = objvConceptEN.UpdUser == "[null]" ? null :  objvConceptEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convConcept.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptEN.PdfContent = objvConceptEN.PdfContent == "[null]" ? null :  objvConceptEN.PdfContent; //Pdf内容
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
 /// <param name = "objvConceptEN">源简化对象</param>
 public static void AccessFldValueNull(clsvConceptEN objvConceptEN)
{
try
{
if (objvConceptEN.ConceptContent == "[null]") objvConceptEN.ConceptContent = null; //概念内容
if (objvConceptEN.ConceptName == "[null]") objvConceptEN.ConceptName = null; //概念名称
if (objvConceptEN.UpdDate == "[null]") objvConceptEN.UpdDate = null; //修改日期
if (objvConceptEN.Memo == "[null]") objvConceptEN.Memo = null; //备注
if (objvConceptEN.Author == "[null]") objvConceptEN.Author = null; //作者
if (objvConceptEN.CitationId == "[null]") objvConceptEN.CitationId = null; //引用Id
if (objvConceptEN.Keyword == "[null]") objvConceptEN.Keyword = null; //关键字
if (objvConceptEN.PaperTitle == "[null]") objvConceptEN.PaperTitle = null; //论文标题
if (objvConceptEN.Periodical == "[null]") objvConceptEN.Periodical = null; //期刊
if (objvConceptEN.ResearchQuestion == "[null]") objvConceptEN.ResearchQuestion = null; //研究问题
if (objvConceptEN.IdCurrEduCls == "[null]") objvConceptEN.IdCurrEduCls = null; //教学班流水号
if (objvConceptEN.CreateDate == "[null]") objvConceptEN.CreateDate = null; //建立日期
if (objvConceptEN.UpdUser == "[null]") objvConceptEN.UpdUser = null; //修改人
if (objvConceptEN.PdfContent == "[null]") objvConceptEN.PdfContent = null; //Pdf内容
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
public static void CheckProperty4Condition(clsvConceptEN objvConceptEN)
{
 vConceptDA.CheckProperty4Condition(objvConceptEN);
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
if (clsConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptBL没有刷新缓存机制(clsConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConceptId");
//if (arrvConceptObjLstCache == null)
//{
//arrvConceptObjLstCache = vConceptDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strConceptId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConceptEN GetObjByConceptIdCache(string strConceptId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvConceptEN._CurrTabName, strIdCurrEduCls);
List<clsvConceptEN> arrvConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptEN> arrvConceptObjLst_Sel =
arrvConceptObjLstCache
.Where(x=> x.ConceptId == strConceptId 
);
if (arrvConceptObjLst_Sel.Count() == 0)
{
   clsvConceptEN obj = clsvConceptBL.GetObjByConceptId(strConceptId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strConceptId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvConceptObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConceptEN> GetAllvConceptObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvConceptEN> arrvConceptObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvConceptObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConceptEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvConceptEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvConceptEN> arrvConceptObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvConceptObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvConceptEN._CurrTabName, strIdCurrEduCls);
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
 /// 日期:2023-10-08
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strConceptId, string strIdCurrEduCls)
{
if (strInFldName != convConcept.ConceptId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convConcept.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convConcept.AttributeName));
throw new Exception(strMsg);
}
var objvConcept = clsvConceptBL.GetObjByConceptIdCache(strConceptId, strIdCurrEduCls);
if (objvConcept == null) return "";
return objvConcept[strOutFldName].ToString();
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
int intRecCount = clsvConceptDA.GetRecCount(strTabName);
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
int intRecCount = clsvConceptDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvConceptDA.GetRecCount();
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
int intRecCount = clsvConceptDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvConceptEN objvConceptCond)
{
 string strIdCurrEduCls = objvConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvConceptBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConcept.AttributeName)
{
if (objvConceptCond.IsUpdated(strFldName) == false) continue;
if (objvConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCond[strFldName].ToString());
}
else
{
if (objvConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConceptCond[strFldName]));
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
 List<string> arrList = clsvConceptDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vConceptDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vConceptDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}