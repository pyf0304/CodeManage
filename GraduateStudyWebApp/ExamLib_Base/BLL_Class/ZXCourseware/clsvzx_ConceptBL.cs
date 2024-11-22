
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ConceptBL
 表名:vzx_Concept(01120830)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:45
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
public static class  clsvzx_ConceptBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ConceptEN GetObj(this K_zxConceptId_vzx_Concept myKey)
{
clsvzx_ConceptEN objvzx_ConceptEN = clsvzx_ConceptBL.vzx_ConceptDA.GetObjByzxConceptId(myKey.Value);
return objvzx_ConceptEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetzxConceptId(this clsvzx_ConceptEN objvzx_ConceptEN, string strzxConceptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxConceptId, 8, convzx_Concept.zxConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxConceptId, 8, convzx_Concept.zxConceptId);
}
objvzx_ConceptEN.zxConceptId = strzxConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.zxConceptId) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.zxConceptId, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.zxConceptId] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetConceptName(this clsvzx_ConceptEN objvzx_ConceptEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, convzx_Concept.ConceptName);
}
objvzx_ConceptEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.ConceptName) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.ConceptName, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.ConceptName] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetConceptContent(this clsvzx_ConceptEN objvzx_ConceptEN, string strConceptContent, string strComparisonOp="")
	{
objvzx_ConceptEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.ConceptContent) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.ConceptContent, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.ConceptContent] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetTextId(this clsvzx_ConceptEN objvzx_ConceptEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_Concept.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_Concept.TextId);
}
objvzx_ConceptEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.TextId) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.TextId, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.TextId] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetVoteCount(this clsvzx_ConceptEN objvzx_ConceptEN, int? intVoteCount, string strComparisonOp="")
	{
objvzx_ConceptEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.VoteCount) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.VoteCount, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.VoteCount] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetIsSubmit(this clsvzx_ConceptEN objvzx_ConceptEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_ConceptEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.IsSubmit) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.IsSubmit, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.IsSubmit] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetAppraiseCount(this clsvzx_ConceptEN objvzx_ConceptEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_ConceptEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.AppraiseCount) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.AppraiseCount, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.AppraiseCount] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetScore(this clsvzx_ConceptEN objvzx_ConceptEN, float? fltScore, string strComparisonOp="")
	{
objvzx_ConceptEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.Score) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.Score, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.Score] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetStuScore(this clsvzx_ConceptEN objvzx_ConceptEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_ConceptEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.StuScore) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.StuScore, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.StuScore] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetTeaScore(this clsvzx_ConceptEN objvzx_ConceptEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_ConceptEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.TeaScore) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.TeaScore, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.TeaScore] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetCreateDate(this clsvzx_ConceptEN objvzx_ConceptEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convzx_Concept.CreateDate);
}
objvzx_ConceptEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.CreateDate) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.CreateDate, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.CreateDate] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetUpdDate(this clsvzx_ConceptEN objvzx_ConceptEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Concept.UpdDate);
}
objvzx_ConceptEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.UpdDate) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.UpdDate, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.UpdDate] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetUpdUser(this clsvzx_ConceptEN objvzx_ConceptEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Concept.UpdUser);
}
objvzx_ConceptEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.UpdUser) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.UpdUser, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.UpdUser] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetIdCurrEduCls(this clsvzx_ConceptEN objvzx_ConceptEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_Concept.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_Concept.IdCurrEduCls);
}
objvzx_ConceptEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.IdCurrEduCls) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetPdfContent(this clsvzx_ConceptEN objvzx_ConceptEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convzx_Concept.PdfContent);
}
objvzx_ConceptEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.PdfContent) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.PdfContent, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.PdfContent] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetPdfPageNum(this clsvzx_ConceptEN objvzx_ConceptEN, int? intPdfPageNum, string strComparisonOp="")
	{
objvzx_ConceptEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.PdfPageNum) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.PdfPageNum, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.PdfPageNum] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetCitationCount(this clsvzx_ConceptEN objvzx_ConceptEN, int? intCitationCount, string strComparisonOp="")
	{
objvzx_ConceptEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.CitationCount) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.CitationCount, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.CitationCount] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetVersionCount(this clsvzx_ConceptEN objvzx_ConceptEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_ConceptEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.VersionCount) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.VersionCount, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.VersionCount] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetzxShareId(this clsvzx_ConceptEN objvzx_ConceptEN, string strzxShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxShareId, convzx_Concept.zxShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_Concept.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_Concept.zxShareId);
}
objvzx_ConceptEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.zxShareId) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.zxShareId, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.zxShareId] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetMemo(this clsvzx_ConceptEN objvzx_ConceptEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Concept.Memo);
}
objvzx_ConceptEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.Memo) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.Memo, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.Memo] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetPdfDivLet(this clsvzx_ConceptEN objvzx_ConceptEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, convzx_Concept.PdfDivLet);
}
objvzx_ConceptEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.PdfDivLet) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.PdfDivLet, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.PdfDivLet] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetPdfDivTop(this clsvzx_ConceptEN objvzx_ConceptEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, convzx_Concept.PdfDivTop);
}
objvzx_ConceptEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.PdfDivTop) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.PdfDivTop, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.PdfDivTop] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetPdfPageNumIn(this clsvzx_ConceptEN objvzx_ConceptEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, convzx_Concept.PdfPageNumIn);
}
objvzx_ConceptEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.PdfPageNumIn) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.PdfPageNumIn, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.PdfPageNumIn] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetPdfPageTop(this clsvzx_ConceptEN objvzx_ConceptEN, int? intPdfPageTop, string strComparisonOp="")
	{
objvzx_ConceptEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.PdfPageTop) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.PdfPageTop, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.PdfPageTop] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetPdfZoom(this clsvzx_ConceptEN objvzx_ConceptEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, convzx_Concept.PdfZoom);
}
objvzx_ConceptEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.PdfZoom) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.PdfZoom, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.PdfZoom] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetGroupTextId(this clsvzx_ConceptEN objvzx_ConceptEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_Concept.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_Concept.GroupTextId);
}
objvzx_ConceptEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.GroupTextId) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.GroupTextId, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.GroupTextId] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetTextTitle(this clsvzx_ConceptEN objvzx_ConceptEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_Concept.TextTitle);
}
objvzx_ConceptEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.TextTitle) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.TextTitle, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.TextTitle] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetAuthor(this clsvzx_ConceptEN objvzx_ConceptEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_Concept.Author);
}
objvzx_ConceptEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.Author) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.Author, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.Author] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetResearchQuestion(this clsvzx_ConceptEN objvzx_ConceptEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convzx_Concept.ResearchQuestion);
}
objvzx_ConceptEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.ResearchQuestion) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.ResearchQuestion, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.ResearchQuestion] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetKeyword(this clsvzx_ConceptEN objvzx_ConceptEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convzx_Concept.Keyword);
}
objvzx_ConceptEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.Keyword) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.Keyword, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.Keyword] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ConceptEN SetEdition(this clsvzx_ConceptEN objvzx_ConceptEN, string strEdition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEdition, 100, convzx_Concept.Edition);
}
objvzx_ConceptEN.Edition = strEdition; //Edition
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ConceptEN.dicFldComparisonOp.ContainsKey(convzx_Concept.Edition) == false)
{
objvzx_ConceptEN.dicFldComparisonOp.Add(convzx_Concept.Edition, strComparisonOp);
}
else
{
objvzx_ConceptEN.dicFldComparisonOp[convzx_Concept.Edition] = strComparisonOp;
}
}
return objvzx_ConceptEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_ConceptENS">源对象</param>
 /// <param name = "objvzx_ConceptENT">目标对象</param>
 public static void CopyTo(this clsvzx_ConceptEN objvzx_ConceptENS, clsvzx_ConceptEN objvzx_ConceptENT)
{
try
{
objvzx_ConceptENT.zxConceptId = objvzx_ConceptENS.zxConceptId; //概念Id
objvzx_ConceptENT.ConceptName = objvzx_ConceptENS.ConceptName; //概念名称
objvzx_ConceptENT.ConceptContent = objvzx_ConceptENS.ConceptContent; //概念内容
objvzx_ConceptENT.TextId = objvzx_ConceptENS.TextId; //课件Id
objvzx_ConceptENT.VoteCount = objvzx_ConceptENS.VoteCount; //点赞计数
objvzx_ConceptENT.IsSubmit = objvzx_ConceptENS.IsSubmit; //是否提交
objvzx_ConceptENT.AppraiseCount = objvzx_ConceptENS.AppraiseCount; //评论数
objvzx_ConceptENT.Score = objvzx_ConceptENS.Score; //评分
objvzx_ConceptENT.StuScore = objvzx_ConceptENS.StuScore; //学生平均分
objvzx_ConceptENT.TeaScore = objvzx_ConceptENS.TeaScore; //教师评分
objvzx_ConceptENT.CreateDate = objvzx_ConceptENS.CreateDate; //建立日期
objvzx_ConceptENT.UpdDate = objvzx_ConceptENS.UpdDate; //修改日期
objvzx_ConceptENT.UpdUser = objvzx_ConceptENS.UpdUser; //修改人
objvzx_ConceptENT.IdCurrEduCls = objvzx_ConceptENS.IdCurrEduCls; //教学班流水号
objvzx_ConceptENT.PdfContent = objvzx_ConceptENS.PdfContent; //Pdf内容
objvzx_ConceptENT.PdfPageNum = objvzx_ConceptENS.PdfPageNum; //Pdf页码
objvzx_ConceptENT.CitationCount = objvzx_ConceptENS.CitationCount; //引用统计
objvzx_ConceptENT.VersionCount = objvzx_ConceptENS.VersionCount; //版本统计
objvzx_ConceptENT.zxShareId = objvzx_ConceptENS.zxShareId; //分享Id
objvzx_ConceptENT.Memo = objvzx_ConceptENS.Memo; //备注
objvzx_ConceptENT.PdfDivLet = objvzx_ConceptENS.PdfDivLet; //PdfDivLet
objvzx_ConceptENT.PdfDivTop = objvzx_ConceptENS.PdfDivTop; //PdfDivTop
objvzx_ConceptENT.PdfPageNumIn = objvzx_ConceptENS.PdfPageNumIn; //PdfPageNumIn
objvzx_ConceptENT.PdfPageTop = objvzx_ConceptENS.PdfPageTop; //pdf页面顶部位置
objvzx_ConceptENT.PdfZoom = objvzx_ConceptENS.PdfZoom; //PdfZoom
objvzx_ConceptENT.GroupTextId = objvzx_ConceptENS.GroupTextId; //小组Id
objvzx_ConceptENT.TextTitle = objvzx_ConceptENS.TextTitle; //TextTitle
objvzx_ConceptENT.Author = objvzx_ConceptENS.Author; //作者
objvzx_ConceptENT.ResearchQuestion = objvzx_ConceptENS.ResearchQuestion; //研究问题
objvzx_ConceptENT.Keyword = objvzx_ConceptENS.Keyword; //关键字
objvzx_ConceptENT.Edition = objvzx_ConceptENS.Edition; //Edition
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
 /// <param name = "objvzx_ConceptENS">源对象</param>
 /// <returns>目标对象=>clsvzx_ConceptEN:objvzx_ConceptENT</returns>
 public static clsvzx_ConceptEN CopyTo(this clsvzx_ConceptEN objvzx_ConceptENS)
{
try
{
 clsvzx_ConceptEN objvzx_ConceptENT = new clsvzx_ConceptEN()
{
zxConceptId = objvzx_ConceptENS.zxConceptId, //概念Id
ConceptName = objvzx_ConceptENS.ConceptName, //概念名称
ConceptContent = objvzx_ConceptENS.ConceptContent, //概念内容
TextId = objvzx_ConceptENS.TextId, //课件Id
VoteCount = objvzx_ConceptENS.VoteCount, //点赞计数
IsSubmit = objvzx_ConceptENS.IsSubmit, //是否提交
AppraiseCount = objvzx_ConceptENS.AppraiseCount, //评论数
Score = objvzx_ConceptENS.Score, //评分
StuScore = objvzx_ConceptENS.StuScore, //学生平均分
TeaScore = objvzx_ConceptENS.TeaScore, //教师评分
CreateDate = objvzx_ConceptENS.CreateDate, //建立日期
UpdDate = objvzx_ConceptENS.UpdDate, //修改日期
UpdUser = objvzx_ConceptENS.UpdUser, //修改人
IdCurrEduCls = objvzx_ConceptENS.IdCurrEduCls, //教学班流水号
PdfContent = objvzx_ConceptENS.PdfContent, //Pdf内容
PdfPageNum = objvzx_ConceptENS.PdfPageNum, //Pdf页码
CitationCount = objvzx_ConceptENS.CitationCount, //引用统计
VersionCount = objvzx_ConceptENS.VersionCount, //版本统计
zxShareId = objvzx_ConceptENS.zxShareId, //分享Id
Memo = objvzx_ConceptENS.Memo, //备注
PdfDivLet = objvzx_ConceptENS.PdfDivLet, //PdfDivLet
PdfDivTop = objvzx_ConceptENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objvzx_ConceptENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objvzx_ConceptENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objvzx_ConceptENS.PdfZoom, //PdfZoom
GroupTextId = objvzx_ConceptENS.GroupTextId, //小组Id
TextTitle = objvzx_ConceptENS.TextTitle, //TextTitle
Author = objvzx_ConceptENS.Author, //作者
ResearchQuestion = objvzx_ConceptENS.ResearchQuestion, //研究问题
Keyword = objvzx_ConceptENS.Keyword, //关键字
Edition = objvzx_ConceptENS.Edition, //Edition
};
 return objvzx_ConceptENT;
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
public static void CheckProperty4Condition(this clsvzx_ConceptEN objvzx_ConceptEN)
{
 clsvzx_ConceptBL.vzx_ConceptDA.CheckProperty4Condition(objvzx_ConceptEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_ConceptEN objvzx_ConceptCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.zxConceptId) == true)
{
string strComparisonOpzxConceptId = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.zxConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.zxConceptId, objvzx_ConceptCond.zxConceptId, strComparisonOpzxConceptId);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.ConceptName) == true)
{
string strComparisonOpConceptName = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.ConceptName, objvzx_ConceptCond.ConceptName, strComparisonOpConceptName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.TextId) == true)
{
string strComparisonOpTextId = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.TextId, objvzx_ConceptCond.TextId, strComparisonOpTextId);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.VoteCount) == true)
{
string strComparisonOpVoteCount = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.VoteCount, objvzx_ConceptCond.VoteCount, strComparisonOpVoteCount);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.IsSubmit) == true)
{
if (objvzx_ConceptCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_Concept.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_Concept.IsSubmit);
}
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.AppraiseCount, objvzx_ConceptCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.Score) == true)
{
string strComparisonOpScore = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.Score, objvzx_ConceptCond.Score, strComparisonOpScore);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.StuScore, objvzx_ConceptCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.TeaScore, objvzx_ConceptCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.CreateDate) == true)
{
string strComparisonOpCreateDate = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.CreateDate, objvzx_ConceptCond.CreateDate, strComparisonOpCreateDate);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.UpdDate, objvzx_ConceptCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.UpdUser, objvzx_ConceptCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.IdCurrEduCls, objvzx_ConceptCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.PdfContent) == true)
{
string strComparisonOpPdfContent = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.PdfContent, objvzx_ConceptCond.PdfContent, strComparisonOpPdfContent);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.PdfPageNum, objvzx_ConceptCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.CitationCount) == true)
{
string strComparisonOpCitationCount = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.CitationCount, objvzx_ConceptCond.CitationCount, strComparisonOpCitationCount);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.VersionCount, objvzx_ConceptCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.zxShareId, objvzx_ConceptCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.Memo) == true)
{
string strComparisonOpMemo = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.Memo, objvzx_ConceptCond.Memo, strComparisonOpMemo);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.PdfDivLet, objvzx_ConceptCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.PdfDivTop, objvzx_ConceptCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.PdfPageNumIn, objvzx_ConceptCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Concept.PdfPageTop, objvzx_ConceptCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.PdfZoom, objvzx_ConceptCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.GroupTextId, objvzx_ConceptCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.TextTitle, objvzx_ConceptCond.TextTitle, strComparisonOpTextTitle);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.Author) == true)
{
string strComparisonOpAuthor = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.Author, objvzx_ConceptCond.Author, strComparisonOpAuthor);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.ResearchQuestion, objvzx_ConceptCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.Keyword) == true)
{
string strComparisonOpKeyword = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.Keyword, objvzx_ConceptCond.Keyword, strComparisonOpKeyword);
}
if (objvzx_ConceptCond.IsUpdated(convzx_Concept.Edition) == true)
{
string strComparisonOpEdition = objvzx_ConceptCond.dicFldComparisonOp[convzx_Concept.Edition];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Concept.Edition, objvzx_ConceptCond.Edition, strComparisonOpEdition);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Concept
{
public virtual bool UpdRelaTabDate(string strzxConceptId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Concept(vzx_Concept)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_ConceptBL
{
public static RelatedActions_vzx_Concept relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_ConceptDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_ConceptDA vzx_ConceptDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_ConceptDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_ConceptBL()
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
if (string.IsNullOrEmpty(clsvzx_ConceptEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_ConceptEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Concept(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_ConceptDA.GetDataTable_vzx_Concept(strWhereCond);
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
objDT = vzx_ConceptDA.GetDataTable(strWhereCond);
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
objDT = vzx_ConceptDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_ConceptDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_ConceptDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_ConceptDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_ConceptDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_ConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_ConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_ConceptEN> GetObjLstByZxConceptIdLst(List<string> arrZxConceptIdLst)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxConceptIdLst, true);
 string strWhereCond = string.Format("zxConceptId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_ConceptEN> GetObjLstByZxConceptIdLstCache(List<string> arrZxConceptIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvzx_ConceptEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_ConceptEN> arrvzx_ConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ConceptEN> arrvzx_ConceptObjLst_Sel =
arrvzx_ConceptObjLstCache
.Where(x => arrZxConceptIdLst.Contains(x.zxConceptId));
return arrvzx_ConceptObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ConceptEN> GetObjLst(string strWhereCond)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
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
public static List<clsvzx_ConceptEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_ConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_ConceptEN> GetSubObjLstCache(clsvzx_ConceptEN objvzx_ConceptCond)
{
 string strIdCurrEduCls = objvzx_ConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvzx_ConceptBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvzx_ConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Concept.AttributeName)
{
if (objvzx_ConceptCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ConceptCond[strFldName].ToString());
}
else
{
if (objvzx_ConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ConceptCond[strFldName]));
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
public static List<clsvzx_ConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
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
public static List<clsvzx_ConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
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
List<clsvzx_ConceptEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_ConceptEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ConceptEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_ConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
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
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
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
public static List<clsvzx_ConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_ConceptEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_ConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
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
public static List<clsvzx_ConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ConceptEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ConceptEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Concept(ref clsvzx_ConceptEN objvzx_ConceptEN)
{
bool bolResult = vzx_ConceptDA.Getvzx_Concept(ref objvzx_ConceptEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ConceptEN GetObjByzxConceptId(string strzxConceptId)
{
if (strzxConceptId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxConceptId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxConceptId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_ConceptEN objvzx_ConceptEN = vzx_ConceptDA.GetObjByzxConceptId(strzxConceptId);
return objvzx_ConceptEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_ConceptEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_ConceptEN objvzx_ConceptEN = vzx_ConceptDA.GetFirstObj(strWhereCond);
 return objvzx_ConceptEN;
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
public static clsvzx_ConceptEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_ConceptEN objvzx_ConceptEN = vzx_ConceptDA.GetObjByDataRow(objRow);
 return objvzx_ConceptEN;
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
public static clsvzx_ConceptEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_ConceptEN objvzx_ConceptEN = vzx_ConceptDA.GetObjByDataRow(objRow);
 return objvzx_ConceptEN;
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
 /// <param name = "strzxConceptId">所给的关键字</param>
 /// <param name = "lstvzx_ConceptObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ConceptEN GetObjByzxConceptIdFromList(string strzxConceptId, List<clsvzx_ConceptEN> lstvzx_ConceptObjLst)
{
foreach (clsvzx_ConceptEN objvzx_ConceptEN in lstvzx_ConceptObjLst)
{
if (objvzx_ConceptEN.zxConceptId == strzxConceptId)
{
return objvzx_ConceptEN;
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
 string strMaxZxConceptId;
 try
 {
 strMaxZxConceptId = clsvzx_ConceptDA.GetMaxStrId();
 return strMaxZxConceptId;
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
 string strzxConceptId;
 try
 {
 strzxConceptId = new clsvzx_ConceptDA().GetFirstID(strWhereCond);
 return strzxConceptId;
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
 arrList = vzx_ConceptDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_ConceptDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxConceptId)
{
if (string.IsNullOrEmpty(strzxConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxConceptId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_ConceptDA.IsExist(strzxConceptId);
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
 bolIsExist = clsvzx_ConceptDA.IsExistTable();
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
 bolIsExist = vzx_ConceptDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_ConceptENS">源对象</param>
 /// <param name = "objvzx_ConceptENT">目标对象</param>
 public static void CopyTo(clsvzx_ConceptEN objvzx_ConceptENS, clsvzx_ConceptEN objvzx_ConceptENT)
{
try
{
objvzx_ConceptENT.zxConceptId = objvzx_ConceptENS.zxConceptId; //概念Id
objvzx_ConceptENT.ConceptName = objvzx_ConceptENS.ConceptName; //概念名称
objvzx_ConceptENT.ConceptContent = objvzx_ConceptENS.ConceptContent; //概念内容
objvzx_ConceptENT.TextId = objvzx_ConceptENS.TextId; //课件Id
objvzx_ConceptENT.VoteCount = objvzx_ConceptENS.VoteCount; //点赞计数
objvzx_ConceptENT.IsSubmit = objvzx_ConceptENS.IsSubmit; //是否提交
objvzx_ConceptENT.AppraiseCount = objvzx_ConceptENS.AppraiseCount; //评论数
objvzx_ConceptENT.Score = objvzx_ConceptENS.Score; //评分
objvzx_ConceptENT.StuScore = objvzx_ConceptENS.StuScore; //学生平均分
objvzx_ConceptENT.TeaScore = objvzx_ConceptENS.TeaScore; //教师评分
objvzx_ConceptENT.CreateDate = objvzx_ConceptENS.CreateDate; //建立日期
objvzx_ConceptENT.UpdDate = objvzx_ConceptENS.UpdDate; //修改日期
objvzx_ConceptENT.UpdUser = objvzx_ConceptENS.UpdUser; //修改人
objvzx_ConceptENT.IdCurrEduCls = objvzx_ConceptENS.IdCurrEduCls; //教学班流水号
objvzx_ConceptENT.PdfContent = objvzx_ConceptENS.PdfContent; //Pdf内容
objvzx_ConceptENT.PdfPageNum = objvzx_ConceptENS.PdfPageNum; //Pdf页码
objvzx_ConceptENT.CitationCount = objvzx_ConceptENS.CitationCount; //引用统计
objvzx_ConceptENT.VersionCount = objvzx_ConceptENS.VersionCount; //版本统计
objvzx_ConceptENT.zxShareId = objvzx_ConceptENS.zxShareId; //分享Id
objvzx_ConceptENT.Memo = objvzx_ConceptENS.Memo; //备注
objvzx_ConceptENT.PdfDivLet = objvzx_ConceptENS.PdfDivLet; //PdfDivLet
objvzx_ConceptENT.PdfDivTop = objvzx_ConceptENS.PdfDivTop; //PdfDivTop
objvzx_ConceptENT.PdfPageNumIn = objvzx_ConceptENS.PdfPageNumIn; //PdfPageNumIn
objvzx_ConceptENT.PdfPageTop = objvzx_ConceptENS.PdfPageTop; //pdf页面顶部位置
objvzx_ConceptENT.PdfZoom = objvzx_ConceptENS.PdfZoom; //PdfZoom
objvzx_ConceptENT.GroupTextId = objvzx_ConceptENS.GroupTextId; //小组Id
objvzx_ConceptENT.TextTitle = objvzx_ConceptENS.TextTitle; //TextTitle
objvzx_ConceptENT.Author = objvzx_ConceptENS.Author; //作者
objvzx_ConceptENT.ResearchQuestion = objvzx_ConceptENS.ResearchQuestion; //研究问题
objvzx_ConceptENT.Keyword = objvzx_ConceptENS.Keyword; //关键字
objvzx_ConceptENT.Edition = objvzx_ConceptENS.Edition; //Edition
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
 /// <param name = "objvzx_ConceptEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_ConceptEN objvzx_ConceptEN)
{
try
{
objvzx_ConceptEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_ConceptEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Concept.zxConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.zxConceptId = objvzx_ConceptEN.zxConceptId; //概念Id
}
if (arrFldSet.Contains(convzx_Concept.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.ConceptName = objvzx_ConceptEN.ConceptName == "[null]" ? null :  objvzx_ConceptEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(convzx_Concept.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.ConceptContent = objvzx_ConceptEN.ConceptContent == "[null]" ? null :  objvzx_ConceptEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(convzx_Concept.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.TextId = objvzx_ConceptEN.TextId == "[null]" ? null :  objvzx_ConceptEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_Concept.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.VoteCount = objvzx_ConceptEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(convzx_Concept.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.IsSubmit = objvzx_ConceptEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_Concept.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.AppraiseCount = objvzx_ConceptEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_Concept.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.Score = objvzx_ConceptEN.Score; //评分
}
if (arrFldSet.Contains(convzx_Concept.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.StuScore = objvzx_ConceptEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_Concept.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.TeaScore = objvzx_ConceptEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_Concept.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.CreateDate = objvzx_ConceptEN.CreateDate == "[null]" ? null :  objvzx_ConceptEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convzx_Concept.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.UpdDate = objvzx_ConceptEN.UpdDate == "[null]" ? null :  objvzx_ConceptEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Concept.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.UpdUser = objvzx_ConceptEN.UpdUser == "[null]" ? null :  objvzx_ConceptEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Concept.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.IdCurrEduCls = objvzx_ConceptEN.IdCurrEduCls == "[null]" ? null :  objvzx_ConceptEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_Concept.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.PdfContent = objvzx_ConceptEN.PdfContent == "[null]" ? null :  objvzx_ConceptEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convzx_Concept.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.PdfPageNum = objvzx_ConceptEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(convzx_Concept.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.CitationCount = objvzx_ConceptEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convzx_Concept.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.VersionCount = objvzx_ConceptEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_Concept.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.zxShareId = objvzx_ConceptEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_Concept.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.Memo = objvzx_ConceptEN.Memo == "[null]" ? null :  objvzx_ConceptEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Concept.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.PdfDivLet = objvzx_ConceptEN.PdfDivLet == "[null]" ? null :  objvzx_ConceptEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(convzx_Concept.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.PdfDivTop = objvzx_ConceptEN.PdfDivTop == "[null]" ? null :  objvzx_ConceptEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(convzx_Concept.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.PdfPageNumIn = objvzx_ConceptEN.PdfPageNumIn == "[null]" ? null :  objvzx_ConceptEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(convzx_Concept.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.PdfPageTop = objvzx_ConceptEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(convzx_Concept.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.PdfZoom = objvzx_ConceptEN.PdfZoom == "[null]" ? null :  objvzx_ConceptEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(convzx_Concept.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.GroupTextId = objvzx_ConceptEN.GroupTextId == "[null]" ? null :  objvzx_ConceptEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_Concept.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.TextTitle = objvzx_ConceptEN.TextTitle == "[null]" ? null :  objvzx_ConceptEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_Concept.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.Author = objvzx_ConceptEN.Author == "[null]" ? null :  objvzx_ConceptEN.Author; //作者
}
if (arrFldSet.Contains(convzx_Concept.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.ResearchQuestion = objvzx_ConceptEN.ResearchQuestion == "[null]" ? null :  objvzx_ConceptEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convzx_Concept.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.Keyword = objvzx_ConceptEN.Keyword == "[null]" ? null :  objvzx_ConceptEN.Keyword; //关键字
}
if (arrFldSet.Contains(convzx_Concept.Edition, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ConceptEN.Edition = objvzx_ConceptEN.Edition == "[null]" ? null :  objvzx_ConceptEN.Edition; //Edition
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
 /// <param name = "objvzx_ConceptEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_ConceptEN objvzx_ConceptEN)
{
try
{
if (objvzx_ConceptEN.ConceptName == "[null]") objvzx_ConceptEN.ConceptName = null; //概念名称
if (objvzx_ConceptEN.ConceptContent == "[null]") objvzx_ConceptEN.ConceptContent = null; //概念内容
if (objvzx_ConceptEN.TextId == "[null]") objvzx_ConceptEN.TextId = null; //课件Id
if (objvzx_ConceptEN.CreateDate == "[null]") objvzx_ConceptEN.CreateDate = null; //建立日期
if (objvzx_ConceptEN.UpdDate == "[null]") objvzx_ConceptEN.UpdDate = null; //修改日期
if (objvzx_ConceptEN.UpdUser == "[null]") objvzx_ConceptEN.UpdUser = null; //修改人
if (objvzx_ConceptEN.IdCurrEduCls == "[null]") objvzx_ConceptEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_ConceptEN.PdfContent == "[null]") objvzx_ConceptEN.PdfContent = null; //Pdf内容
if (objvzx_ConceptEN.Memo == "[null]") objvzx_ConceptEN.Memo = null; //备注
if (objvzx_ConceptEN.PdfDivLet == "[null]") objvzx_ConceptEN.PdfDivLet = null; //PdfDivLet
if (objvzx_ConceptEN.PdfDivTop == "[null]") objvzx_ConceptEN.PdfDivTop = null; //PdfDivTop
if (objvzx_ConceptEN.PdfPageNumIn == "[null]") objvzx_ConceptEN.PdfPageNumIn = null; //PdfPageNumIn
if (objvzx_ConceptEN.PdfZoom == "[null]") objvzx_ConceptEN.PdfZoom = null; //PdfZoom
if (objvzx_ConceptEN.GroupTextId == "[null]") objvzx_ConceptEN.GroupTextId = null; //小组Id
if (objvzx_ConceptEN.TextTitle == "[null]") objvzx_ConceptEN.TextTitle = null; //TextTitle
if (objvzx_ConceptEN.Author == "[null]") objvzx_ConceptEN.Author = null; //作者
if (objvzx_ConceptEN.ResearchQuestion == "[null]") objvzx_ConceptEN.ResearchQuestion = null; //研究问题
if (objvzx_ConceptEN.Keyword == "[null]") objvzx_ConceptEN.Keyword = null; //关键字
if (objvzx_ConceptEN.Edition == "[null]") objvzx_ConceptEN.Edition = null; //Edition
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
public static void CheckProperty4Condition(clsvzx_ConceptEN objvzx_ConceptEN)
{
 vzx_ConceptDA.CheckProperty4Condition(objvzx_ConceptEN);
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
if (clszx_ConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ConceptBL没有刷新缓存机制(clszx_ConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxConceptId");
//if (arrvzx_ConceptObjLstCache == null)
//{
//arrvzx_ConceptObjLstCache = vzx_ConceptDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxConceptId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ConceptEN GetObjByzxConceptIdCache(string strzxConceptId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_ConceptEN._CurrTabName, strIdCurrEduCls);
List<clsvzx_ConceptEN> arrvzx_ConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ConceptEN> arrvzx_ConceptObjLst_Sel =
arrvzx_ConceptObjLstCache
.Where(x=> x.zxConceptId == strzxConceptId 
);
if (arrvzx_ConceptObjLst_Sel.Count() == 0)
{
   clsvzx_ConceptEN obj = clsvzx_ConceptBL.GetObjByzxConceptId(strzxConceptId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxConceptId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvzx_ConceptObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ConceptEN> GetAllvzx_ConceptObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvzx_ConceptEN> arrvzx_ConceptObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvzx_ConceptObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ConceptEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvzx_ConceptEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvzx_ConceptEN> arrvzx_ConceptObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvzx_ConceptObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvzx_ConceptEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strzxConceptId, string strIdCurrEduCls)
{
if (strInFldName != convzx_Concept.zxConceptId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Concept.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Concept.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Concept = clsvzx_ConceptBL.GetObjByzxConceptIdCache(strzxConceptId, strIdCurrEduCls);
if (objvzx_Concept == null) return "";
return objvzx_Concept[strOutFldName].ToString();
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
int intRecCount = clsvzx_ConceptDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_ConceptDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_ConceptDA.GetRecCount();
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
int intRecCount = clsvzx_ConceptDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_ConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_ConceptEN objvzx_ConceptCond)
{
 string strIdCurrEduCls = objvzx_ConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvzx_ConceptBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvzx_ConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvzx_ConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Concept.AttributeName)
{
if (objvzx_ConceptCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ConceptCond[strFldName].ToString());
}
else
{
if (objvzx_ConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ConceptCond[strFldName]));
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
 List<string> arrList = clsvzx_ConceptDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_ConceptDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_ConceptDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}