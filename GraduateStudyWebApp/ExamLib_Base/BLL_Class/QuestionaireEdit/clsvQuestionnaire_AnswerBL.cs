
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_AnswerBL
 表名:vQuestionnaire_Answer(01120020)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvQuestionnaire_AnswerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_AnswerEN GetObj(this K_QuestionId_vQuestionnaire_Answer myKey)
{
clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = clsvQuestionnaire_AnswerBL.vQuestionnaire_AnswerDA.GetObjByQuestionId(myKey.Value);
return objvQuestionnaire_AnswerEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, long lngQuestionId, string strComparisonOp="")
	{
objvQuestionnaire_AnswerEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.QuestionId) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.QuestionId, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.QuestionId] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetAnswerIndex(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, int? intAnswerIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetProvider(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strProvider, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProvider, 18, convQuestionnaire_Answer.Provider);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetScore(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, double? dblScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionIndex(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionName(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionName, convQuestionnaire_Answer.QuestionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionnaire_Answer.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetChapterId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire_Answer.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire_Answer.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetSectionId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convQuestionnaire_Answer.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convQuestionnaire_Answer.SectionId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetChapterName(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire_Answer.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetSectionName(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convQuestionnaire_Answer.SectionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetChapterNameSim(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convQuestionnaire_Answer.ChapterNameSim);
}
objvQuestionnaire_AnswerEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.ChapterNameSim) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.ChapterNameSim, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.ChapterNameSim] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetSectionNameSim(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strSectionNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionNameSim, 10, convQuestionnaire_Answer.SectionNameSim);
}
objvQuestionnaire_AnswerEN.SectionNameSim = strSectionNameSim; //节名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_AnswerEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Answer.SectionNameSim) == false)
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp.Add(convQuestionnaire_Answer.SectionNameSim, strComparisonOp);
}
else
{
objvQuestionnaire_AnswerEN.dicFldComparisonOp[convQuestionnaire_Answer.SectionNameSim] = strComparisonOp;
}
}
return objvQuestionnaire_AnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetQuestionTypeId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire_Answer.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire_Answer.QuestionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetGridTitle(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convQuestionnaire_Answer.GridTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_AnswerEN SetAnswerModeId(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convQuestionnaire_Answer.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convQuestionnaire_Answer.AnswerModeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerENS">源对象</param>
 /// <param name = "objvQuestionnaire_AnswerENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENS, clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENT)
{
try
{
objvQuestionnaire_AnswerENT.QuestionId = objvQuestionnaire_AnswerENS.QuestionId; //题目Id
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
objvQuestionnaire_AnswerENT.ChapterNameSim = objvQuestionnaire_AnswerENS.ChapterNameSim; //章名简称
objvQuestionnaire_AnswerENT.SectionNameSim = objvQuestionnaire_AnswerENS.SectionNameSim; //节名简称
objvQuestionnaire_AnswerENT.QuestionTypeId = objvQuestionnaire_AnswerENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_AnswerENT.GridTitle = objvQuestionnaire_AnswerENS.GridTitle; //表格标题
objvQuestionnaire_AnswerENT.AnswerModeId = objvQuestionnaire_AnswerENS.AnswerModeId; //答案模式Id
objvQuestionnaire_AnswerENT.IsShow = objvQuestionnaire_AnswerENS.IsShow; //是否启用
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
 /// <param name = "objvQuestionnaire_AnswerENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_AnswerEN:objvQuestionnaire_AnswerENT</returns>
 public static clsvQuestionnaire_AnswerEN CopyTo(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENS)
{
try
{
 clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENT = new clsvQuestionnaire_AnswerEN()
{
QuestionId = objvQuestionnaire_AnswerENS.QuestionId, //题目Id
AnswerIndex = objvQuestionnaire_AnswerENS.AnswerIndex, //问答序号
AnswerContent = objvQuestionnaire_AnswerENS.AnswerContent, //答案内容
Provider = objvQuestionnaire_AnswerENS.Provider, //提供者
Score = objvQuestionnaire_AnswerENS.Score, //得分
QuestionIndex = objvQuestionnaire_AnswerENS.QuestionIndex, //题目序号
QuestionName = objvQuestionnaire_AnswerENS.QuestionName, //题目名称
ChapterId = objvQuestionnaire_AnswerENS.ChapterId, //章Id
SectionId = objvQuestionnaire_AnswerENS.SectionId, //节Id
ChapterName = objvQuestionnaire_AnswerENS.ChapterName, //章名
SectionName = objvQuestionnaire_AnswerENS.SectionName, //节名
ChapterNameSim = objvQuestionnaire_AnswerENS.ChapterNameSim, //章名简称
SectionNameSim = objvQuestionnaire_AnswerENS.SectionNameSim, //节名简称
QuestionTypeId = objvQuestionnaire_AnswerENS.QuestionTypeId, //题目类型Id
GridTitle = objvQuestionnaire_AnswerENS.GridTitle, //表格标题
AnswerModeId = objvQuestionnaire_AnswerENS.AnswerModeId, //答案模式Id
IsShow = objvQuestionnaire_AnswerENS.IsShow, //是否启用
};
 return objvQuestionnaire_AnswerENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN)
{
 clsvQuestionnaire_AnswerBL.vQuestionnaire_AnswerDA.CheckProperty4Condition(objvQuestionnaire_AnswerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.QuestionId) == true)
{
string strComparisonOpQuestionId = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Answer.QuestionId, objvQuestionnaire_AnswerCond.QuestionId, strComparisonOpQuestionId);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Answer.AnswerIndex, objvQuestionnaire_AnswerCond.AnswerIndex, strComparisonOpAnswerIndex);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.Provider) == true)
{
string strComparisonOpProvider = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.Provider];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.Provider, objvQuestionnaire_AnswerCond.Provider, strComparisonOpProvider);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.Score) == true)
{
string strComparisonOpScore = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Answer.Score, objvQuestionnaire_AnswerCond.Score, strComparisonOpScore);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Answer.QuestionIndex, objvQuestionnaire_AnswerCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.QuestionName, objvQuestionnaire_AnswerCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.ChapterId) == true)
{
string strComparisonOpChapterId = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.ChapterId, objvQuestionnaire_AnswerCond.ChapterId, strComparisonOpChapterId);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.SectionId) == true)
{
string strComparisonOpSectionId = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.SectionId, objvQuestionnaire_AnswerCond.SectionId, strComparisonOpSectionId);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.ChapterName) == true)
{
string strComparisonOpChapterName = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.ChapterName, objvQuestionnaire_AnswerCond.ChapterName, strComparisonOpChapterName);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.SectionName) == true)
{
string strComparisonOpSectionName = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.SectionName, objvQuestionnaire_AnswerCond.SectionName, strComparisonOpSectionName);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.ChapterNameSim, objvQuestionnaire_AnswerCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.SectionNameSim) == true)
{
string strComparisonOpSectionNameSim = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.SectionNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.SectionNameSim, objvQuestionnaire_AnswerCond.SectionNameSim, strComparisonOpSectionNameSim);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.QuestionTypeId, objvQuestionnaire_AnswerCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.GridTitle) == true)
{
string strComparisonOpGridTitle = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.GridTitle, objvQuestionnaire_AnswerCond.GridTitle, strComparisonOpGridTitle);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvQuestionnaire_AnswerCond.dicFldComparisonOp[convQuestionnaire_Answer.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Answer.AnswerModeId, objvQuestionnaire_AnswerCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvQuestionnaire_AnswerCond.IsUpdated(convQuestionnaire_Answer.IsShow) == true)
{
if (objvQuestionnaire_AnswerCond.IsShow == true)
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
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaire_Answer
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vQuestionnaire_Answer(vQuestionnaire_Answer)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire_AnswerBL
{
public static RelatedActions_vQuestionnaire_Answer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaire_AnswerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaire_AnswerDA vQuestionnaire_AnswerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaire_AnswerDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaire_AnswerBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaire_AnswerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire_AnswerEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaire_Answer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaire_AnswerDA.GetDataTable_vQuestionnaire_Answer(strWhereCond);
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
objDT = vQuestionnaire_AnswerDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaire_AnswerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaire_AnswerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaire_AnswerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaire_AnswerDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaire_AnswerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaire_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaire_AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionIdLst);
 string strWhereCond = string.Format("QuestionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaire_AnswerEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst)
{
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName);
List<clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLst_Sel =
arrvQuestionnaire_AnswerObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrvQuestionnaire_AnswerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaire_AnswerEN> GetSubObjLstCache(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerCond)
{
List<clsvQuestionnaire_AnswerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire_Answer.AttributeName)
{
if (objvQuestionnaire_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_AnswerCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_AnswerCond[strFldName]));
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
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
List<clsvQuestionnaire_AnswerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaire_AnswerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaire_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
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
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
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
public static List<clsvQuestionnaire_AnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
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
public static List<clsvQuestionnaire_AnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaire_AnswerEN> arrObjLst = new List<clsvQuestionnaire_AnswerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = new clsvQuestionnaire_AnswerEN();
try
{
objvQuestionnaire_AnswerEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Answer.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_AnswerEN.AnswerIndex = objRow[convQuestionnaire_Answer.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.AnswerIndex].ToString().Trim()); //问答序号
objvQuestionnaire_AnswerEN.AnswerContent = objRow[convQuestionnaire_Answer.AnswerContent] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerContent].ToString().Trim(); //答案内容
objvQuestionnaire_AnswerEN.Provider = objRow[convQuestionnaire_Answer.Provider] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.Provider].ToString().Trim(); //提供者
objvQuestionnaire_AnswerEN.Score = objRow[convQuestionnaire_Answer.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionnaire_Answer.Score].ToString().Trim()); //得分
objvQuestionnaire_AnswerEN.QuestionIndex = objRow[convQuestionnaire_Answer.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Answer.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_AnswerEN.QuestionName = objRow[convQuestionnaire_Answer.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_AnswerEN.ChapterId = objRow[convQuestionnaire_Answer.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire_AnswerEN.SectionId = objRow[convQuestionnaire_Answer.SectionId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionId].ToString().Trim(); //节Id
objvQuestionnaire_AnswerEN.ChapterName = objRow[convQuestionnaire_Answer.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterName].ToString().Trim(); //章名
objvQuestionnaire_AnswerEN.SectionName = objRow[convQuestionnaire_Answer.SectionName] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionName].ToString().Trim(); //节名
objvQuestionnaire_AnswerEN.ChapterNameSim = objRow[convQuestionnaire_Answer.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire_AnswerEN.SectionNameSim = objRow[convQuestionnaire_Answer.SectionNameSim] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.SectionNameSim].ToString().Trim(); //节名简称
objvQuestionnaire_AnswerEN.QuestionTypeId = objRow[convQuestionnaire_Answer.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_AnswerEN.GridTitle = objRow[convQuestionnaire_Answer.GridTitle] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.GridTitle].ToString().Trim(); //表格标题
objvQuestionnaire_AnswerEN.AnswerModeId = objRow[convQuestionnaire_Answer.AnswerModeId] == DBNull.Value ? null : objRow[convQuestionnaire_Answer.AnswerModeId].ToString().Trim(); //答案模式Id
objvQuestionnaire_AnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Answer.IsShow].ToString().Trim()); //是否启用
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_AnswerEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_AnswerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaire_Answer(ref clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN)
{
bool bolResult = vQuestionnaire_AnswerDA.GetvQuestionnaire_Answer(ref objvQuestionnaire_AnswerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_AnswerEN GetObjByQuestionId(long lngQuestionId)
{
clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = vQuestionnaire_AnswerDA.GetObjByQuestionId(lngQuestionId);
return objvQuestionnaire_AnswerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaire_AnswerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = vQuestionnaire_AnswerDA.GetFirstObj(strWhereCond);
 return objvQuestionnaire_AnswerEN;
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
public static clsvQuestionnaire_AnswerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = vQuestionnaire_AnswerDA.GetObjByDataRow(objRow);
 return objvQuestionnaire_AnswerEN;
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
public static clsvQuestionnaire_AnswerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN = vQuestionnaire_AnswerDA.GetObjByDataRow(objRow);
 return objvQuestionnaire_AnswerEN;
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
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "lstvQuestionnaire_AnswerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire_AnswerEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsvQuestionnaire_AnswerEN> lstvQuestionnaire_AnswerObjLst)
{
foreach (clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN in lstvQuestionnaire_AnswerObjLst)
{
if (objvQuestionnaire_AnswerEN.QuestionId == lngQuestionId)
{
return objvQuestionnaire_AnswerEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngQuestionId;
 try
 {
 lngQuestionId = new clsvQuestionnaire_AnswerDA().GetFirstID(strWhereCond);
 return lngQuestionId;
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
 arrList = vQuestionnaire_AnswerDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaire_AnswerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngQuestionId)
{
//检测记录是否存在
bool bolIsExist = vQuestionnaire_AnswerDA.IsExist(lngQuestionId);
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
 bolIsExist = clsvQuestionnaire_AnswerDA.IsExistTable();
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
 bolIsExist = vQuestionnaire_AnswerDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaire_AnswerENS">源对象</param>
 /// <param name = "objvQuestionnaire_AnswerENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENS, clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerENT)
{
try
{
objvQuestionnaire_AnswerENT.QuestionId = objvQuestionnaire_AnswerENS.QuestionId; //题目Id
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
objvQuestionnaire_AnswerENT.ChapterNameSim = objvQuestionnaire_AnswerENS.ChapterNameSim; //章名简称
objvQuestionnaire_AnswerENT.SectionNameSim = objvQuestionnaire_AnswerENS.SectionNameSim; //节名简称
objvQuestionnaire_AnswerENT.QuestionTypeId = objvQuestionnaire_AnswerENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_AnswerENT.GridTitle = objvQuestionnaire_AnswerENS.GridTitle; //表格标题
objvQuestionnaire_AnswerENT.AnswerModeId = objvQuestionnaire_AnswerENS.AnswerModeId; //答案模式Id
objvQuestionnaire_AnswerENT.IsShow = objvQuestionnaire_AnswerENS.IsShow; //是否启用
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
 /// <param name = "objvQuestionnaire_AnswerEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN)
{
try
{
objvQuestionnaire_AnswerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaire_AnswerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaire_Answer.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.QuestionId = objvQuestionnaire_AnswerEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convQuestionnaire_Answer.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.AnswerIndex = objvQuestionnaire_AnswerEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(convQuestionnaire_Answer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.AnswerContent = objvQuestionnaire_AnswerEN.AnswerContent == "[null]" ? null :  objvQuestionnaire_AnswerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(convQuestionnaire_Answer.Provider, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.Provider = objvQuestionnaire_AnswerEN.Provider == "[null]" ? null :  objvQuestionnaire_AnswerEN.Provider; //提供者
}
if (arrFldSet.Contains(convQuestionnaire_Answer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.Score = objvQuestionnaire_AnswerEN.Score; //得分
}
if (arrFldSet.Contains(convQuestionnaire_Answer.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.QuestionIndex = objvQuestionnaire_AnswerEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convQuestionnaire_Answer.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.QuestionName = objvQuestionnaire_AnswerEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionnaire_Answer.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.ChapterId = objvQuestionnaire_AnswerEN.ChapterId == "[null]" ? null :  objvQuestionnaire_AnswerEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convQuestionnaire_Answer.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.SectionId = objvQuestionnaire_AnswerEN.SectionId == "[null]" ? null :  objvQuestionnaire_AnswerEN.SectionId; //节Id
}
if (arrFldSet.Contains(convQuestionnaire_Answer.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.ChapterName = objvQuestionnaire_AnswerEN.ChapterName == "[null]" ? null :  objvQuestionnaire_AnswerEN.ChapterName; //章名
}
if (arrFldSet.Contains(convQuestionnaire_Answer.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.SectionName = objvQuestionnaire_AnswerEN.SectionName == "[null]" ? null :  objvQuestionnaire_AnswerEN.SectionName; //节名
}
if (arrFldSet.Contains(convQuestionnaire_Answer.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.ChapterNameSim = objvQuestionnaire_AnswerEN.ChapterNameSim == "[null]" ? null :  objvQuestionnaire_AnswerEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convQuestionnaire_Answer.SectionNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.SectionNameSim = objvQuestionnaire_AnswerEN.SectionNameSim == "[null]" ? null :  objvQuestionnaire_AnswerEN.SectionNameSim; //节名简称
}
if (arrFldSet.Contains(convQuestionnaire_Answer.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.QuestionTypeId = objvQuestionnaire_AnswerEN.QuestionTypeId == "[null]" ? null :  objvQuestionnaire_AnswerEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionnaire_Answer.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.GridTitle = objvQuestionnaire_AnswerEN.GridTitle == "[null]" ? null :  objvQuestionnaire_AnswerEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convQuestionnaire_Answer.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.AnswerModeId = objvQuestionnaire_AnswerEN.AnswerModeId == "[null]" ? null :  objvQuestionnaire_AnswerEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convQuestionnaire_Answer.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_AnswerEN.IsShow = objvQuestionnaire_AnswerEN.IsShow; //是否启用
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
 /// <param name = "objvQuestionnaire_AnswerEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN)
{
try
{
if (objvQuestionnaire_AnswerEN.AnswerContent == "[null]") objvQuestionnaire_AnswerEN.AnswerContent = null; //答案内容
if (objvQuestionnaire_AnswerEN.Provider == "[null]") objvQuestionnaire_AnswerEN.Provider = null; //提供者
if (objvQuestionnaire_AnswerEN.ChapterId == "[null]") objvQuestionnaire_AnswerEN.ChapterId = null; //章Id
if (objvQuestionnaire_AnswerEN.SectionId == "[null]") objvQuestionnaire_AnswerEN.SectionId = null; //节Id
if (objvQuestionnaire_AnswerEN.ChapterName == "[null]") objvQuestionnaire_AnswerEN.ChapterName = null; //章名
if (objvQuestionnaire_AnswerEN.SectionName == "[null]") objvQuestionnaire_AnswerEN.SectionName = null; //节名
if (objvQuestionnaire_AnswerEN.ChapterNameSim == "[null]") objvQuestionnaire_AnswerEN.ChapterNameSim = null; //章名简称
if (objvQuestionnaire_AnswerEN.SectionNameSim == "[null]") objvQuestionnaire_AnswerEN.SectionNameSim = null; //节名简称
if (objvQuestionnaire_AnswerEN.QuestionTypeId == "[null]") objvQuestionnaire_AnswerEN.QuestionTypeId = null; //题目类型Id
if (objvQuestionnaire_AnswerEN.GridTitle == "[null]") objvQuestionnaire_AnswerEN.GridTitle = null; //表格标题
if (objvQuestionnaire_AnswerEN.AnswerModeId == "[null]") objvQuestionnaire_AnswerEN.AnswerModeId = null; //答案模式Id
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
public static void CheckProperty4Condition(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerEN)
{
 vQuestionnaire_AnswerDA.CheckProperty4Condition(objvQuestionnaire_AnswerEN);
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
if (clsAnswerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerBL没有刷新缓存机制(clsAnswerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeBL没有刷新缓存机制(clscc_ExamGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrvQuestionnaire_AnswerObjLstCache == null)
//{
//arrvQuestionnaire_AnswerObjLstCache = vQuestionnaire_AnswerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire_AnswerEN GetObjByQuestionIdCache(long lngQuestionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName);
List<clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLst_Sel =
arrvQuestionnaire_AnswerObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrvQuestionnaire_AnswerObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire_AnswerEN obj = clsvQuestionnaire_AnswerBL.GetObjByQuestionId(lngQuestionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionnaire_AnswerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetAllvQuestionnaire_AnswerObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLstCache = GetObjLstCache(); 
return arrvQuestionnaire_AnswerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire_AnswerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName);
List<clsvQuestionnaire_AnswerEN> arrvQuestionnaire_AnswerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionnaire_AnswerObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvQuestionnaire_AnswerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvQuestionnaire_AnswerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvQuestionnaire_AnswerEN._RefreshTimeLst.Count == 0) return "";
return clsvQuestionnaire_AnswerEN._RefreshTimeLst[clsvQuestionnaire_AnswerEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngQuestionId)
{
if (strInFldName != convQuestionnaire_Answer.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaire_Answer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaire_Answer.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaire_Answer = clsvQuestionnaire_AnswerBL.GetObjByQuestionIdCache(lngQuestionId);
if (objvQuestionnaire_Answer == null) return "";
return objvQuestionnaire_Answer[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaire_AnswerDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaire_AnswerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaire_AnswerDA.GetRecCount();
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
int intRecCount = clsvQuestionnaire_AnswerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaire_AnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaire_AnswerEN objvQuestionnaire_AnswerCond)
{
List<clsvQuestionnaire_AnswerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_AnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire_Answer.AttributeName)
{
if (objvQuestionnaire_AnswerCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire_AnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_AnswerCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire_AnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire_AnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_AnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire_AnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire_AnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_AnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_AnswerCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaire_AnswerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire_AnswerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire_AnswerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}