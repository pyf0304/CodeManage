
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_ResearchResultBL
 表名:vgs_ResearchResult(01120778)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:38:13
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
public static class  clsvgs_ResearchResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_ResearchResultEN GetObj(this K_ResultId_vgs_ResearchResult myKey)
{
clsvgs_ResearchResultEN objvgs_ResearchResultEN = clsvgs_ResearchResultBL.vgs_ResearchResultDA.GetObjByResultId(myKey.Value);
return objvgs_ResearchResultEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetResultId(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strResultId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultId, 10, convgs_ResearchResult.ResultId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResultId, 10, convgs_ResearchResult.ResultId);
}
objvgs_ResearchResultEN.ResultId = strResultId; //成果Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.ResultId) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.ResultId, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.ResultId] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetTopicId(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convgs_ResearchResult.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convgs_ResearchResult.TopicId);
}
objvgs_ResearchResultEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.TopicId) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.TopicId, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.TopicId] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetTopicName(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convgs_ResearchResult.TopicName);
}
objvgs_ResearchResultEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.TopicName) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.TopicName, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.TopicName] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetPaperId(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_ResearchResult.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_ResearchResult.PaperId);
}
objvgs_ResearchResultEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.PaperId) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.PaperId, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.PaperId] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetIdCurrEduCls(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_ResearchResult.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_ResearchResult.IdCurrEduCls);
}
objvgs_ResearchResultEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.IdCurrEduCls) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetResultTypeId(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strResultTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultTypeId, 2, convgs_ResearchResult.ResultTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResultTypeId, 2, convgs_ResearchResult.ResultTypeId);
}
objvgs_ResearchResultEN.ResultTypeId = strResultTypeId; //成果类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.ResultTypeId) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.ResultTypeId, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.ResultTypeId] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetResultName(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strResultName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultName, 500, convgs_ResearchResult.ResultName);
}
objvgs_ResearchResultEN.ResultName = strResultName; //成果名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.ResultName) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.ResultName, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.ResultName] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetResultContent(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strResultContent, string strComparisonOp="")
	{
objvgs_ResearchResultEN.ResultContent = strResultContent; //成果内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.ResultContent) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.ResultContent, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.ResultContent] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetAuthor(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convgs_ResearchResult.Author);
}
objvgs_ResearchResultEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.Author) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.Author, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.Author] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetDivision(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strDivision, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDivision, 500, convgs_ResearchResult.Division);
}
objvgs_ResearchResultEN.Division = strDivision; //分工
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.Division) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.Division, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.Division] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetVersionCount(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_ResearchResultEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.VersionCount) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.VersionCount, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.VersionCount] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetOkCount(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, int? intOkCount, string strComparisonOp="")
	{
objvgs_ResearchResultEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.OkCount) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.OkCount, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.OkCount] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetAppraiseCount(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvgs_ResearchResultEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.AppraiseCount) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.AppraiseCount, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.AppraiseCount] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetScore(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, float? fltScore, string strComparisonOp="")
	{
objvgs_ResearchResultEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.Score) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.Score, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.Score] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetStuScore(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_ResearchResultEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.StuScore) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.StuScore, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.StuScore] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetTeaScore(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_ResearchResultEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.TeaScore) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.TeaScore, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.TeaScore] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetUpdDate(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_ResearchResult.UpdDate);
}
objvgs_ResearchResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.UpdDate) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.UpdDate, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.UpdDate] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetUpdUser(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_ResearchResult.UpdUser);
}
objvgs_ResearchResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.UpdUser) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.UpdUser, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.UpdUser] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchResultEN SetMemo(this clsvgs_ResearchResultEN objvgs_ResearchResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_ResearchResult.Memo);
}
objvgs_ResearchResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchResultEN.dicFldComparisonOp.ContainsKey(convgs_ResearchResult.Memo) == false)
{
objvgs_ResearchResultEN.dicFldComparisonOp.Add(convgs_ResearchResult.Memo, strComparisonOp);
}
else
{
objvgs_ResearchResultEN.dicFldComparisonOp[convgs_ResearchResult.Memo] = strComparisonOp;
}
}
return objvgs_ResearchResultEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_ResearchResultENS">源对象</param>
 /// <param name = "objvgs_ResearchResultENT">目标对象</param>
 public static void CopyTo(this clsvgs_ResearchResultEN objvgs_ResearchResultENS, clsvgs_ResearchResultEN objvgs_ResearchResultENT)
{
try
{
objvgs_ResearchResultENT.ResultId = objvgs_ResearchResultENS.ResultId; //成果Id
objvgs_ResearchResultENT.TopicId = objvgs_ResearchResultENS.TopicId; //主题Id
objvgs_ResearchResultENT.TopicName = objvgs_ResearchResultENS.TopicName; //栏目主题
objvgs_ResearchResultENT.PaperId = objvgs_ResearchResultENS.PaperId; //论文Id
objvgs_ResearchResultENT.IdCurrEduCls = objvgs_ResearchResultENS.IdCurrEduCls; //教学班流水号
objvgs_ResearchResultENT.ResultTypeId = objvgs_ResearchResultENS.ResultTypeId; //成果类型Id
objvgs_ResearchResultENT.ResultName = objvgs_ResearchResultENS.ResultName; //成果名称
objvgs_ResearchResultENT.ResultContent = objvgs_ResearchResultENS.ResultContent; //成果内容
objvgs_ResearchResultENT.Author = objvgs_ResearchResultENS.Author; //作者
objvgs_ResearchResultENT.Division = objvgs_ResearchResultENS.Division; //分工
objvgs_ResearchResultENT.VersionCount = objvgs_ResearchResultENS.VersionCount; //版本统计
objvgs_ResearchResultENT.OkCount = objvgs_ResearchResultENS.OkCount; //点赞统计
objvgs_ResearchResultENT.AppraiseCount = objvgs_ResearchResultENS.AppraiseCount; //评论数
objvgs_ResearchResultENT.Score = objvgs_ResearchResultENS.Score; //评分
objvgs_ResearchResultENT.StuScore = objvgs_ResearchResultENS.StuScore; //学生平均分
objvgs_ResearchResultENT.TeaScore = objvgs_ResearchResultENS.TeaScore; //教师评分
objvgs_ResearchResultENT.UpdDate = objvgs_ResearchResultENS.UpdDate; //修改日期
objvgs_ResearchResultENT.UpdUser = objvgs_ResearchResultENS.UpdUser; //修改人
objvgs_ResearchResultENT.Memo = objvgs_ResearchResultENS.Memo; //备注
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
 /// <param name = "objvgs_ResearchResultENS">源对象</param>
 /// <returns>目标对象=>clsvgs_ResearchResultEN:objvgs_ResearchResultENT</returns>
 public static clsvgs_ResearchResultEN CopyTo(this clsvgs_ResearchResultEN objvgs_ResearchResultENS)
{
try
{
 clsvgs_ResearchResultEN objvgs_ResearchResultENT = new clsvgs_ResearchResultEN()
{
ResultId = objvgs_ResearchResultENS.ResultId, //成果Id
TopicId = objvgs_ResearchResultENS.TopicId, //主题Id
TopicName = objvgs_ResearchResultENS.TopicName, //栏目主题
PaperId = objvgs_ResearchResultENS.PaperId, //论文Id
IdCurrEduCls = objvgs_ResearchResultENS.IdCurrEduCls, //教学班流水号
ResultTypeId = objvgs_ResearchResultENS.ResultTypeId, //成果类型Id
ResultName = objvgs_ResearchResultENS.ResultName, //成果名称
ResultContent = objvgs_ResearchResultENS.ResultContent, //成果内容
Author = objvgs_ResearchResultENS.Author, //作者
Division = objvgs_ResearchResultENS.Division, //分工
VersionCount = objvgs_ResearchResultENS.VersionCount, //版本统计
OkCount = objvgs_ResearchResultENS.OkCount, //点赞统计
AppraiseCount = objvgs_ResearchResultENS.AppraiseCount, //评论数
Score = objvgs_ResearchResultENS.Score, //评分
StuScore = objvgs_ResearchResultENS.StuScore, //学生平均分
TeaScore = objvgs_ResearchResultENS.TeaScore, //教师评分
UpdDate = objvgs_ResearchResultENS.UpdDate, //修改日期
UpdUser = objvgs_ResearchResultENS.UpdUser, //修改人
Memo = objvgs_ResearchResultENS.Memo, //备注
};
 return objvgs_ResearchResultENT;
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
public static void CheckProperty4Condition(this clsvgs_ResearchResultEN objvgs_ResearchResultEN)
{
 clsvgs_ResearchResultBL.vgs_ResearchResultDA.CheckProperty4Condition(objvgs_ResearchResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_ResearchResultEN objvgs_ResearchResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.ResultId) == true)
{
string strComparisonOpResultId = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.ResultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.ResultId, objvgs_ResearchResultCond.ResultId, strComparisonOpResultId);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.TopicId) == true)
{
string strComparisonOpTopicId = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.TopicId, objvgs_ResearchResultCond.TopicId, strComparisonOpTopicId);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.TopicName) == true)
{
string strComparisonOpTopicName = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.TopicName, objvgs_ResearchResultCond.TopicName, strComparisonOpTopicName);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.PaperId, objvgs_ResearchResultCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.IdCurrEduCls, objvgs_ResearchResultCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.ResultTypeId) == true)
{
string strComparisonOpResultTypeId = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.ResultTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.ResultTypeId, objvgs_ResearchResultCond.ResultTypeId, strComparisonOpResultTypeId);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.ResultName) == true)
{
string strComparisonOpResultName = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.ResultName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.ResultName, objvgs_ResearchResultCond.ResultName, strComparisonOpResultName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.Author) == true)
{
string strComparisonOpAuthor = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.Author, objvgs_ResearchResultCond.Author, strComparisonOpAuthor);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.Division) == true)
{
string strComparisonOpDivision = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.Division];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.Division, objvgs_ResearchResultCond.Division, strComparisonOpDivision);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_ResearchResult.VersionCount, objvgs_ResearchResultCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.OkCount) == true)
{
string strComparisonOpOkCount = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_ResearchResult.OkCount, objvgs_ResearchResultCond.OkCount, strComparisonOpOkCount);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_ResearchResult.AppraiseCount, objvgs_ResearchResultCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.Score) == true)
{
string strComparisonOpScore = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_ResearchResult.Score, objvgs_ResearchResultCond.Score, strComparisonOpScore);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_ResearchResult.StuScore, objvgs_ResearchResultCond.StuScore, strComparisonOpStuScore);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_ResearchResult.TeaScore, objvgs_ResearchResultCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.UpdDate, objvgs_ResearchResultCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.UpdUser, objvgs_ResearchResultCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_ResearchResultCond.IsUpdated(convgs_ResearchResult.Memo) == true)
{
string strComparisonOpMemo = objvgs_ResearchResultCond.dicFldComparisonOp[convgs_ResearchResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchResult.Memo, objvgs_ResearchResultCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_ResearchResult
{
public virtual bool UpdRelaTabDate(string strResultId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 研究成果视图(vgs_ResearchResult)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_ResearchResultBL
{
public static RelatedActions_vgs_ResearchResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_ResearchResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_ResearchResultDA vgs_ResearchResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_ResearchResultDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_ResearchResultBL()
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
if (string.IsNullOrEmpty(clsvgs_ResearchResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_ResearchResultEN._ConnectString);
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
public static DataTable GetDataTable_vgs_ResearchResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_ResearchResultDA.GetDataTable_vgs_ResearchResult(strWhereCond);
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
objDT = vgs_ResearchResultDA.GetDataTable(strWhereCond);
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
objDT = vgs_ResearchResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_ResearchResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_ResearchResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_ResearchResultDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_ResearchResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_ResearchResultEN> GetObjLstByResultIdLst(List<string> arrResultIdLst)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrResultIdLst, true);
 string strWhereCond = string.Format("ResultId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_ResearchResultEN> GetObjLstByResultIdLstCache(List<string> arrResultIdLst)
{
string strKey = string.Format("{0}", clsvgs_ResearchResultEN._CurrTabName);
List<clsvgs_ResearchResultEN> arrvgs_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_ResearchResultEN> arrvgs_ResearchResultObjLst_Sel =
arrvgs_ResearchResultObjLstCache
.Where(x => arrResultIdLst.Contains(x.ResultId));
return arrvgs_ResearchResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_ResearchResultEN> GetObjLst(string strWhereCond)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
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
public static List<clsvgs_ResearchResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_ResearchResultEN> GetSubObjLstCache(clsvgs_ResearchResultEN objvgs_ResearchResultCond)
{
List<clsvgs_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_ResearchResult.AttributeName)
{
if (objvgs_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objvgs_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchResultCond[strFldName].ToString());
}
else
{
if (objvgs_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchResultCond[strFldName]));
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
public static List<clsvgs_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
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
public static List<clsvgs_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
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
List<clsvgs_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_ResearchResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
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
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
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
public static List<clsvgs_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_ResearchResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
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
public static List<clsvgs_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_ResearchResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_ResearchResultEN> arrObjLst = new List<clsvgs_ResearchResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchResultEN objvgs_ResearchResultEN = new clsvgs_ResearchResultEN();
try
{
objvgs_ResearchResultEN.ResultId = objRow[convgs_ResearchResult.ResultId].ToString().Trim(); //成果Id
objvgs_ResearchResultEN.TopicId = objRow[convgs_ResearchResult.TopicId] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchResultEN.TopicName = objRow[convgs_ResearchResult.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchResult.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchResultEN.PaperId = objRow[convgs_ResearchResult.PaperId] == DBNull.Value ? null : objRow[convgs_ResearchResult.PaperId].ToString().Trim(); //论文Id
objvgs_ResearchResultEN.IdCurrEduCls = objRow[convgs_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchResultEN.ResultTypeId = objRow[convgs_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvgs_ResearchResultEN.ResultName = objRow[convgs_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvgs_ResearchResultEN.ResultContent = objRow[convgs_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convgs_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvgs_ResearchResultEN.Author = objRow[convgs_ResearchResult.Author] == DBNull.Value ? null : objRow[convgs_ResearchResult.Author].ToString().Trim(); //作者
objvgs_ResearchResultEN.Division = objRow[convgs_ResearchResult.Division] == DBNull.Value ? null : objRow[convgs_ResearchResult.Division].ToString().Trim(); //分工
objvgs_ResearchResultEN.VersionCount = objRow[convgs_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvgs_ResearchResultEN.OkCount = objRow[convgs_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvgs_ResearchResultEN.AppraiseCount = objRow[convgs_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvgs_ResearchResultEN.Score = objRow[convgs_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.Score].ToString().Trim()); //评分
objvgs_ResearchResultEN.StuScore = objRow[convgs_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvgs_ResearchResultEN.TeaScore = objRow[convgs_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvgs_ResearchResultEN.UpdDate = objRow[convgs_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchResultEN.UpdUser = objRow[convgs_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchResultEN.Memo = objRow[convgs_ResearchResult.Memo] == DBNull.Value ? null : objRow[convgs_ResearchResult.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchResultEN.ResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_ResearchResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_ResearchResult(ref clsvgs_ResearchResultEN objvgs_ResearchResultEN)
{
bool bolResult = vgs_ResearchResultDA.Getvgs_ResearchResult(ref objvgs_ResearchResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_ResearchResultEN GetObjByResultId(string strResultId)
{
if (strResultId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strResultId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strResultId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strResultId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvgs_ResearchResultEN objvgs_ResearchResultEN = vgs_ResearchResultDA.GetObjByResultId(strResultId);
return objvgs_ResearchResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_ResearchResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_ResearchResultEN objvgs_ResearchResultEN = vgs_ResearchResultDA.GetFirstObj(strWhereCond);
 return objvgs_ResearchResultEN;
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
public static clsvgs_ResearchResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_ResearchResultEN objvgs_ResearchResultEN = vgs_ResearchResultDA.GetObjByDataRow(objRow);
 return objvgs_ResearchResultEN;
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
public static clsvgs_ResearchResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_ResearchResultEN objvgs_ResearchResultEN = vgs_ResearchResultDA.GetObjByDataRow(objRow);
 return objvgs_ResearchResultEN;
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
 /// <param name = "strResultId">所给的关键字</param>
 /// <param name = "lstvgs_ResearchResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_ResearchResultEN GetObjByResultIdFromList(string strResultId, List<clsvgs_ResearchResultEN> lstvgs_ResearchResultObjLst)
{
foreach (clsvgs_ResearchResultEN objvgs_ResearchResultEN in lstvgs_ResearchResultObjLst)
{
if (objvgs_ResearchResultEN.ResultId == strResultId)
{
return objvgs_ResearchResultEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strResultId;
 try
 {
 strResultId = new clsvgs_ResearchResultDA().GetFirstID(strWhereCond);
 return strResultId;
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
 arrList = vgs_ResearchResultDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_ResearchResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strResultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strResultId)
{
if (string.IsNullOrEmpty(strResultId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strResultId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vgs_ResearchResultDA.IsExist(strResultId);
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
 bolIsExist = clsvgs_ResearchResultDA.IsExistTable();
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
 bolIsExist = vgs_ResearchResultDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_ResearchResultENS">源对象</param>
 /// <param name = "objvgs_ResearchResultENT">目标对象</param>
 public static void CopyTo(clsvgs_ResearchResultEN objvgs_ResearchResultENS, clsvgs_ResearchResultEN objvgs_ResearchResultENT)
{
try
{
objvgs_ResearchResultENT.ResultId = objvgs_ResearchResultENS.ResultId; //成果Id
objvgs_ResearchResultENT.TopicId = objvgs_ResearchResultENS.TopicId; //主题Id
objvgs_ResearchResultENT.TopicName = objvgs_ResearchResultENS.TopicName; //栏目主题
objvgs_ResearchResultENT.PaperId = objvgs_ResearchResultENS.PaperId; //论文Id
objvgs_ResearchResultENT.IdCurrEduCls = objvgs_ResearchResultENS.IdCurrEduCls; //教学班流水号
objvgs_ResearchResultENT.ResultTypeId = objvgs_ResearchResultENS.ResultTypeId; //成果类型Id
objvgs_ResearchResultENT.ResultName = objvgs_ResearchResultENS.ResultName; //成果名称
objvgs_ResearchResultENT.ResultContent = objvgs_ResearchResultENS.ResultContent; //成果内容
objvgs_ResearchResultENT.Author = objvgs_ResearchResultENS.Author; //作者
objvgs_ResearchResultENT.Division = objvgs_ResearchResultENS.Division; //分工
objvgs_ResearchResultENT.VersionCount = objvgs_ResearchResultENS.VersionCount; //版本统计
objvgs_ResearchResultENT.OkCount = objvgs_ResearchResultENS.OkCount; //点赞统计
objvgs_ResearchResultENT.AppraiseCount = objvgs_ResearchResultENS.AppraiseCount; //评论数
objvgs_ResearchResultENT.Score = objvgs_ResearchResultENS.Score; //评分
objvgs_ResearchResultENT.StuScore = objvgs_ResearchResultENS.StuScore; //学生平均分
objvgs_ResearchResultENT.TeaScore = objvgs_ResearchResultENS.TeaScore; //教师评分
objvgs_ResearchResultENT.UpdDate = objvgs_ResearchResultENS.UpdDate; //修改日期
objvgs_ResearchResultENT.UpdUser = objvgs_ResearchResultENS.UpdUser; //修改人
objvgs_ResearchResultENT.Memo = objvgs_ResearchResultENS.Memo; //备注
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
 /// <param name = "objvgs_ResearchResultEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_ResearchResultEN objvgs_ResearchResultEN)
{
try
{
objvgs_ResearchResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_ResearchResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_ResearchResult.ResultId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.ResultId = objvgs_ResearchResultEN.ResultId; //成果Id
}
if (arrFldSet.Contains(convgs_ResearchResult.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.TopicId = objvgs_ResearchResultEN.TopicId == "[null]" ? null :  objvgs_ResearchResultEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convgs_ResearchResult.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.TopicName = objvgs_ResearchResultEN.TopicName == "[null]" ? null :  objvgs_ResearchResultEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convgs_ResearchResult.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.PaperId = objvgs_ResearchResultEN.PaperId == "[null]" ? null :  objvgs_ResearchResultEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_ResearchResult.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.IdCurrEduCls = objvgs_ResearchResultEN.IdCurrEduCls == "[null]" ? null :  objvgs_ResearchResultEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_ResearchResult.ResultTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.ResultTypeId = objvgs_ResearchResultEN.ResultTypeId == "[null]" ? null :  objvgs_ResearchResultEN.ResultTypeId; //成果类型Id
}
if (arrFldSet.Contains(convgs_ResearchResult.ResultName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.ResultName = objvgs_ResearchResultEN.ResultName == "[null]" ? null :  objvgs_ResearchResultEN.ResultName; //成果名称
}
if (arrFldSet.Contains(convgs_ResearchResult.ResultContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.ResultContent = objvgs_ResearchResultEN.ResultContent == "[null]" ? null :  objvgs_ResearchResultEN.ResultContent; //成果内容
}
if (arrFldSet.Contains(convgs_ResearchResult.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.Author = objvgs_ResearchResultEN.Author == "[null]" ? null :  objvgs_ResearchResultEN.Author; //作者
}
if (arrFldSet.Contains(convgs_ResearchResult.Division, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.Division = objvgs_ResearchResultEN.Division == "[null]" ? null :  objvgs_ResearchResultEN.Division; //分工
}
if (arrFldSet.Contains(convgs_ResearchResult.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.VersionCount = objvgs_ResearchResultEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_ResearchResult.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.OkCount = objvgs_ResearchResultEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convgs_ResearchResult.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.AppraiseCount = objvgs_ResearchResultEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convgs_ResearchResult.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.Score = objvgs_ResearchResultEN.Score; //评分
}
if (arrFldSet.Contains(convgs_ResearchResult.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.StuScore = objvgs_ResearchResultEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convgs_ResearchResult.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.TeaScore = objvgs_ResearchResultEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_ResearchResult.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.UpdDate = objvgs_ResearchResultEN.UpdDate == "[null]" ? null :  objvgs_ResearchResultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_ResearchResult.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.UpdUser = objvgs_ResearchResultEN.UpdUser == "[null]" ? null :  objvgs_ResearchResultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_ResearchResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchResultEN.Memo = objvgs_ResearchResultEN.Memo == "[null]" ? null :  objvgs_ResearchResultEN.Memo; //备注
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
 /// <param name = "objvgs_ResearchResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_ResearchResultEN objvgs_ResearchResultEN)
{
try
{
if (objvgs_ResearchResultEN.TopicId == "[null]") objvgs_ResearchResultEN.TopicId = null; //主题Id
if (objvgs_ResearchResultEN.TopicName == "[null]") objvgs_ResearchResultEN.TopicName = null; //栏目主题
if (objvgs_ResearchResultEN.PaperId == "[null]") objvgs_ResearchResultEN.PaperId = null; //论文Id
if (objvgs_ResearchResultEN.IdCurrEduCls == "[null]") objvgs_ResearchResultEN.IdCurrEduCls = null; //教学班流水号
if (objvgs_ResearchResultEN.ResultTypeId == "[null]") objvgs_ResearchResultEN.ResultTypeId = null; //成果类型Id
if (objvgs_ResearchResultEN.ResultName == "[null]") objvgs_ResearchResultEN.ResultName = null; //成果名称
if (objvgs_ResearchResultEN.ResultContent == "[null]") objvgs_ResearchResultEN.ResultContent = null; //成果内容
if (objvgs_ResearchResultEN.Author == "[null]") objvgs_ResearchResultEN.Author = null; //作者
if (objvgs_ResearchResultEN.Division == "[null]") objvgs_ResearchResultEN.Division = null; //分工
if (objvgs_ResearchResultEN.UpdDate == "[null]") objvgs_ResearchResultEN.UpdDate = null; //修改日期
if (objvgs_ResearchResultEN.UpdUser == "[null]") objvgs_ResearchResultEN.UpdUser = null; //修改人
if (objvgs_ResearchResultEN.Memo == "[null]") objvgs_ResearchResultEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvgs_ResearchResultEN objvgs_ResearchResultEN)
{
 vgs_ResearchResultDA.CheckProperty4Condition(objvgs_ResearchResultEN);
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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_ResearchResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ResearchResultBL没有刷新缓存机制(clsgs_ResearchResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ResultId");
//if (arrvgs_ResearchResultObjLstCache == null)
//{
//arrvgs_ResearchResultObjLstCache = vgs_ResearchResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strResultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_ResearchResultEN GetObjByResultIdCache(string strResultId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_ResearchResultEN._CurrTabName);
List<clsvgs_ResearchResultEN> arrvgs_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_ResearchResultEN> arrvgs_ResearchResultObjLst_Sel =
arrvgs_ResearchResultObjLstCache
.Where(x=> x.ResultId == strResultId 
);
if (arrvgs_ResearchResultObjLst_Sel.Count() == 0)
{
   clsvgs_ResearchResultEN obj = clsvgs_ResearchResultBL.GetObjByResultId(strResultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_ResearchResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_ResearchResultEN> GetAllvgs_ResearchResultObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_ResearchResultEN> arrvgs_ResearchResultObjLstCache = GetObjLstCache(); 
return arrvgs_ResearchResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_ResearchResultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_ResearchResultEN._CurrTabName);
List<clsvgs_ResearchResultEN> arrvgs_ResearchResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_ResearchResultObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_ResearchResultEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strResultId)
{
if (strInFldName != convgs_ResearchResult.ResultId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_ResearchResult.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_ResearchResult.AttributeName));
throw new Exception(strMsg);
}
var objvgs_ResearchResult = clsvgs_ResearchResultBL.GetObjByResultIdCache(strResultId);
if (objvgs_ResearchResult == null) return "";
return objvgs_ResearchResult[strOutFldName].ToString();
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
int intRecCount = clsvgs_ResearchResultDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_ResearchResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_ResearchResultDA.GetRecCount();
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
int intRecCount = clsvgs_ResearchResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_ResearchResultEN objvgs_ResearchResultCond)
{
List<clsvgs_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_ResearchResult.AttributeName)
{
if (objvgs_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objvgs_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchResultCond[strFldName].ToString());
}
else
{
if (objvgs_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchResultCond[strFldName]));
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
 List<string> arrList = clsvgs_ResearchResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_ResearchResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_ResearchResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}