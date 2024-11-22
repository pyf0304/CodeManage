
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PConceptRelaBL
 表名:vgs_PConceptRela(01120668)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:14
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsvgs_PConceptRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PConceptRelaEN GetObj(this K_mId_vgs_PConceptRela myKey)
{
clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = clsvgs_PConceptRelaBL.vgs_PConceptRelaDA.GetObjBymId(myKey.Value);
return objvgs_PConceptRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetmId(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, long lngmId, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.mId) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.mId, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.mId] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetPaperId(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, convgs_PConceptRela.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PConceptRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PConceptRela.PaperId);
}
objvgs_PConceptRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.PaperId) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.PaperId, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.PaperId] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetPaperTitle(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PConceptRela.PaperTitle);
}
objvgs_PConceptRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.PaperTitle) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.PaperTitle, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.PaperTitle] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetPaperTypeId(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convgs_PConceptRela.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convgs_PConceptRela.PaperTypeId);
}
objvgs_PConceptRelaEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.PaperTypeId) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.PaperTypeId, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.PaperTypeId] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetSectionId(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convgs_PConceptRela.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convgs_PConceptRela.SectionId);
}
objvgs_PConceptRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.SectionId) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.SectionId, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.SectionId] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetSectionName(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convgs_PConceptRela.SectionName);
}
objvgs_PConceptRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.SectionName) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.SectionName, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.SectionName] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetConceptId(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConceptId, convgs_PConceptRela.ConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, convgs_PConceptRela.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, convgs_PConceptRela.ConceptId);
}
objvgs_PConceptRelaEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.ConceptId) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.ConceptId, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.ConceptId] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetConceptName(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, convgs_PConceptRela.ConceptName);
}
objvgs_PConceptRelaEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.ConceptName) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.ConceptName, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.ConceptName] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetConceptContent(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strConceptContent, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.ConceptContent) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.ConceptContent, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.ConceptContent] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetIsSubmit(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.IsSubmit) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.IsSubmit, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.IsSubmit] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetTeaScore(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.TeaScore) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.TeaScore, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.TeaScore] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetStuScore(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.StuScore) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.StuScore, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.StuScore] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetScore(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, float? fltScore, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.Score) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.Score, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.Score] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetAppraiseCount(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.AppraiseCount) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.AppraiseCount, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.AppraiseCount] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetOkCount(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.OkCount) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.OkCount, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.OkCount] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetVersionCount(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.VersionCount) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.VersionCount, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.VersionCount] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetCitationCount(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvgs_PConceptRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.CitationCount) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.CitationCount, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.CitationCount] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetUpdDate(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PConceptRela.UpdDate);
}
objvgs_PConceptRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.UpdDate) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.UpdDate, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.UpdDate] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetUpdUser(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PConceptRela.UpdUser);
}
objvgs_PConceptRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.UpdUser) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.UpdUser, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.UpdUser] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetMemo(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PConceptRela.Memo);
}
objvgs_PConceptRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.Memo) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.Memo, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.Memo] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetConcepUserId(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strConcepUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConcepUserId, 50, convgs_PConceptRela.ConcepUserId);
}
objvgs_PConceptRelaEN.ConcepUserId = strConcepUserId; //ConcepUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.ConcepUserId) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.ConcepUserId, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.ConcepUserId] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetConcepDate(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strConcepDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConcepDate, 20, convgs_PConceptRela.ConcepDate);
}
objvgs_PConceptRelaEN.ConcepDate = strConcepDate; //ConcepDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.ConcepDate) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.ConcepDate, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.ConcepDate] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetCreateDate(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convgs_PConceptRela.CreateDate);
}
objvgs_PConceptRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.CreateDate) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.CreateDate, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.CreateDate] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PConceptRelaEN SetShareId(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_PConceptRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_PConceptRela.ShareId);
}
objvgs_PConceptRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PConceptRelaEN.dicFldComparisonOp.ContainsKey(convgs_PConceptRela.ShareId) == false)
{
objvgs_PConceptRelaEN.dicFldComparisonOp.Add(convgs_PConceptRela.ShareId, strComparisonOp);
}
else
{
objvgs_PConceptRelaEN.dicFldComparisonOp[convgs_PConceptRela.ShareId] = strComparisonOp;
}
}
return objvgs_PConceptRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaENS">源对象</param>
 /// <param name = "objvgs_PConceptRelaENT">目标对象</param>
 public static void CopyTo(this clsvgs_PConceptRelaEN objvgs_PConceptRelaENS, clsvgs_PConceptRelaEN objvgs_PConceptRelaENT)
{
try
{
objvgs_PConceptRelaENT.mId = objvgs_PConceptRelaENS.mId; //mId
objvgs_PConceptRelaENT.PaperId = objvgs_PConceptRelaENS.PaperId; //论文Id
objvgs_PConceptRelaENT.PaperTitle = objvgs_PConceptRelaENS.PaperTitle; //论文标题
objvgs_PConceptRelaENT.PaperTypeId = objvgs_PConceptRelaENS.PaperTypeId; //论文类型Id
objvgs_PConceptRelaENT.SectionId = objvgs_PConceptRelaENS.SectionId; //节Id
objvgs_PConceptRelaENT.SectionName = objvgs_PConceptRelaENS.SectionName; //节名
objvgs_PConceptRelaENT.ConceptId = objvgs_PConceptRelaENS.ConceptId; //概念Id
objvgs_PConceptRelaENT.ConceptName = objvgs_PConceptRelaENS.ConceptName; //概念名称
objvgs_PConceptRelaENT.ConceptContent = objvgs_PConceptRelaENS.ConceptContent; //概念内容
objvgs_PConceptRelaENT.IsSubmit = objvgs_PConceptRelaENS.IsSubmit; //是否提交
objvgs_PConceptRelaENT.TeaScore = objvgs_PConceptRelaENS.TeaScore; //教师评分
objvgs_PConceptRelaENT.StuScore = objvgs_PConceptRelaENS.StuScore; //学生平均分
objvgs_PConceptRelaENT.Score = objvgs_PConceptRelaENS.Score; //评分
objvgs_PConceptRelaENT.AppraiseCount = objvgs_PConceptRelaENS.AppraiseCount; //评论数
objvgs_PConceptRelaENT.OkCount = objvgs_PConceptRelaENS.OkCount; //点赞统计
objvgs_PConceptRelaENT.VersionCount = objvgs_PConceptRelaENS.VersionCount; //版本统计
objvgs_PConceptRelaENT.CitationCount = objvgs_PConceptRelaENS.CitationCount; //引用统计
objvgs_PConceptRelaENT.UpdDate = objvgs_PConceptRelaENS.UpdDate; //修改日期
objvgs_PConceptRelaENT.UpdUser = objvgs_PConceptRelaENS.UpdUser; //修改人
objvgs_PConceptRelaENT.Memo = objvgs_PConceptRelaENS.Memo; //备注
objvgs_PConceptRelaENT.ConcepUserId = objvgs_PConceptRelaENS.ConcepUserId; //ConcepUserId
objvgs_PConceptRelaENT.ConcepDate = objvgs_PConceptRelaENS.ConcepDate; //ConcepDate
objvgs_PConceptRelaENT.CreateDate = objvgs_PConceptRelaENS.CreateDate; //建立日期
objvgs_PConceptRelaENT.ShareId = objvgs_PConceptRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PConceptRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PConceptRelaEN:objvgs_PConceptRelaENT</returns>
 public static clsvgs_PConceptRelaEN CopyTo(this clsvgs_PConceptRelaEN objvgs_PConceptRelaENS)
{
try
{
 clsvgs_PConceptRelaEN objvgs_PConceptRelaENT = new clsvgs_PConceptRelaEN()
{
mId = objvgs_PConceptRelaENS.mId, //mId
PaperId = objvgs_PConceptRelaENS.PaperId, //论文Id
PaperTitle = objvgs_PConceptRelaENS.PaperTitle, //论文标题
PaperTypeId = objvgs_PConceptRelaENS.PaperTypeId, //论文类型Id
SectionId = objvgs_PConceptRelaENS.SectionId, //节Id
SectionName = objvgs_PConceptRelaENS.SectionName, //节名
ConceptId = objvgs_PConceptRelaENS.ConceptId, //概念Id
ConceptName = objvgs_PConceptRelaENS.ConceptName, //概念名称
ConceptContent = objvgs_PConceptRelaENS.ConceptContent, //概念内容
IsSubmit = objvgs_PConceptRelaENS.IsSubmit, //是否提交
TeaScore = objvgs_PConceptRelaENS.TeaScore, //教师评分
StuScore = objvgs_PConceptRelaENS.StuScore, //学生平均分
Score = objvgs_PConceptRelaENS.Score, //评分
AppraiseCount = objvgs_PConceptRelaENS.AppraiseCount, //评论数
OkCount = objvgs_PConceptRelaENS.OkCount, //点赞统计
VersionCount = objvgs_PConceptRelaENS.VersionCount, //版本统计
CitationCount = objvgs_PConceptRelaENS.CitationCount, //引用统计
UpdDate = objvgs_PConceptRelaENS.UpdDate, //修改日期
UpdUser = objvgs_PConceptRelaENS.UpdUser, //修改人
Memo = objvgs_PConceptRelaENS.Memo, //备注
ConcepUserId = objvgs_PConceptRelaENS.ConcepUserId, //ConcepUserId
ConcepDate = objvgs_PConceptRelaENS.ConcepDate, //ConcepDate
CreateDate = objvgs_PConceptRelaENS.CreateDate, //建立日期
ShareId = objvgs_PConceptRelaENS.ShareId, //分享Id
};
 return objvgs_PConceptRelaENT;
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
public static void CheckProperty4Condition(this clsvgs_PConceptRelaEN objvgs_PConceptRelaEN)
{
 clsvgs_PConceptRelaBL.vgs_PConceptRelaDA.CheckProperty4Condition(objvgs_PConceptRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PConceptRelaEN objvgs_PConceptRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.mId) == true)
{
string strComparisonOpmId = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.mId, objvgs_PConceptRelaCond.mId, strComparisonOpmId);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.PaperId, objvgs_PConceptRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.PaperTitle, objvgs_PConceptRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.PaperTypeId, objvgs_PConceptRelaCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.SectionId) == true)
{
string strComparisonOpSectionId = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.SectionId, objvgs_PConceptRelaCond.SectionId, strComparisonOpSectionId);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.SectionName) == true)
{
string strComparisonOpSectionName = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.SectionName, objvgs_PConceptRelaCond.SectionName, strComparisonOpSectionName);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.ConceptId) == true)
{
string strComparisonOpConceptId = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.ConceptId, objvgs_PConceptRelaCond.ConceptId, strComparisonOpConceptId);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.ConceptName) == true)
{
string strComparisonOpConceptName = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.ConceptName, objvgs_PConceptRelaCond.ConceptName, strComparisonOpConceptName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.IsSubmit) == true)
{
if (objvgs_PConceptRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PConceptRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PConceptRela.IsSubmit);
}
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.TeaScore, objvgs_PConceptRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.StuScore, objvgs_PConceptRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.Score) == true)
{
string strComparisonOpScore = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.Score, objvgs_PConceptRelaCond.Score, strComparisonOpScore);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.AppraiseCount, objvgs_PConceptRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.OkCount) == true)
{
string strComparisonOpOkCount = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.OkCount, objvgs_PConceptRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.VersionCount, objvgs_PConceptRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PConceptRela.CitationCount, objvgs_PConceptRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.UpdDate, objvgs_PConceptRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.UpdUser, objvgs_PConceptRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.Memo) == true)
{
string strComparisonOpMemo = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.Memo, objvgs_PConceptRelaCond.Memo, strComparisonOpMemo);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.ConcepUserId) == true)
{
string strComparisonOpConcepUserId = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.ConcepUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.ConcepUserId, objvgs_PConceptRelaCond.ConcepUserId, strComparisonOpConcepUserId);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.ConcepDate) == true)
{
string strComparisonOpConcepDate = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.ConcepDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.ConcepDate, objvgs_PConceptRelaCond.ConcepDate, strComparisonOpConcepDate);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.CreateDate, objvgs_PConceptRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvgs_PConceptRelaCond.IsUpdated(convgs_PConceptRela.ShareId) == true)
{
string strComparisonOpShareId = objvgs_PConceptRelaCond.dicFldComparisonOp[convgs_PConceptRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PConceptRela.ShareId, objvgs_PConceptRelaCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PConceptRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文概念关系视图(vgs_PConceptRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PConceptRelaBL
{
public static RelatedActions_vgs_PConceptRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PConceptRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PConceptRelaDA vgs_PConceptRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PConceptRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PConceptRelaBL()
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
if (string.IsNullOrEmpty(clsvgs_PConceptRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PConceptRelaEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PConceptRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PConceptRelaDA.GetDataTable_vgs_PConceptRela(strWhereCond);
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
objDT = vgs_PConceptRelaDA.GetDataTable(strWhereCond);
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
objDT = vgs_PConceptRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PConceptRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PConceptRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PConceptRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PConceptRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PConceptRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PConceptRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_PConceptRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PConceptRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvgs_PConceptRelaEN._CurrTabName);
List<clsvgs_PConceptRelaEN> arrvgs_PConceptRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PConceptRelaEN> arrvgs_PConceptRelaObjLst_Sel =
arrvgs_PConceptRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_PConceptRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PConceptRelaEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
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
public static List<clsvgs_PConceptRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PConceptRelaEN> GetSubObjLstCache(clsvgs_PConceptRelaEN objvgs_PConceptRelaCond)
{
List<clsvgs_PConceptRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PConceptRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PConceptRela.AttributeName)
{
if (objvgs_PConceptRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PConceptRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PConceptRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PConceptRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PConceptRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PConceptRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PConceptRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PConceptRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PConceptRelaCond[strFldName]));
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
public static List<clsvgs_PConceptRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
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
public static List<clsvgs_PConceptRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
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
List<clsvgs_PConceptRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PConceptRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PConceptRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PConceptRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
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
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
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
public static List<clsvgs_PConceptRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PConceptRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PConceptRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
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
public static List<clsvgs_PConceptRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PConceptRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PConceptRelaEN> arrObjLst = new List<clsvgs_PConceptRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = new clsvgs_PConceptRelaEN();
try
{
objvgs_PConceptRelaEN.mId = Int32.Parse(objRow[convgs_PConceptRela.mId].ToString().Trim()); //mId
objvgs_PConceptRelaEN.PaperId = objRow[convgs_PConceptRela.PaperId].ToString().Trim(); //论文Id
objvgs_PConceptRelaEN.PaperTitle = objRow[convgs_PConceptRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PConceptRelaEN.PaperTypeId = objRow[convgs_PConceptRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PConceptRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PConceptRelaEN.SectionId = objRow[convgs_PConceptRela.SectionId] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionId].ToString().Trim(); //节Id
objvgs_PConceptRelaEN.SectionName = objRow[convgs_PConceptRela.SectionName] == DBNull.Value ? null : objRow[convgs_PConceptRela.SectionName].ToString().Trim(); //节名
objvgs_PConceptRelaEN.ConceptId = objRow[convgs_PConceptRela.ConceptId].ToString().Trim(); //概念Id
objvgs_PConceptRelaEN.ConceptName = objRow[convgs_PConceptRela.ConceptName] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptName].ToString().Trim(); //概念名称
objvgs_PConceptRelaEN.ConceptContent = objRow[convgs_PConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvgs_PConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PConceptRelaEN.TeaScore = objRow[convgs_PConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PConceptRelaEN.StuScore = objRow[convgs_PConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PConceptRelaEN.Score = objRow[convgs_PConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PConceptRela.Score].ToString().Trim()); //评分
objvgs_PConceptRelaEN.AppraiseCount = objRow[convgs_PConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PConceptRelaEN.OkCount = objRow[convgs_PConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PConceptRelaEN.VersionCount = objRow[convgs_PConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PConceptRelaEN.CitationCount = objRow[convgs_PConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PConceptRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PConceptRelaEN.UpdDate = objRow[convgs_PConceptRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PConceptRelaEN.UpdUser = objRow[convgs_PConceptRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PConceptRela.UpdUser].ToString().Trim(); //修改人
objvgs_PConceptRelaEN.Memo = objRow[convgs_PConceptRela.Memo] == DBNull.Value ? null : objRow[convgs_PConceptRela.Memo].ToString().Trim(); //备注
objvgs_PConceptRelaEN.ConcepUserId = objRow[convgs_PConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvgs_PConceptRelaEN.ConcepDate = objRow[convgs_PConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvgs_PConceptRelaEN.CreateDate = objRow[convgs_PConceptRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PConceptRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PConceptRelaEN.ShareId = objRow[convgs_PConceptRela.ShareId] == DBNull.Value ? null : objRow[convgs_PConceptRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PConceptRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PConceptRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PConceptRela(ref clsvgs_PConceptRelaEN objvgs_PConceptRelaEN)
{
bool bolResult = vgs_PConceptRelaDA.Getvgs_PConceptRela(ref objvgs_PConceptRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PConceptRelaEN GetObjBymId(long lngmId)
{
clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = vgs_PConceptRelaDA.GetObjBymId(lngmId);
return objvgs_PConceptRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PConceptRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = vgs_PConceptRelaDA.GetFirstObj(strWhereCond);
 return objvgs_PConceptRelaEN;
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
public static clsvgs_PConceptRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = vgs_PConceptRelaDA.GetObjByDataRow(objRow);
 return objvgs_PConceptRelaEN;
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
public static clsvgs_PConceptRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PConceptRelaEN objvgs_PConceptRelaEN = vgs_PConceptRelaDA.GetObjByDataRow(objRow);
 return objvgs_PConceptRelaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvgs_PConceptRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PConceptRelaEN GetObjBymIdFromList(long lngmId, List<clsvgs_PConceptRelaEN> lstvgs_PConceptRelaObjLst)
{
foreach (clsvgs_PConceptRelaEN objvgs_PConceptRelaEN in lstvgs_PConceptRelaObjLst)
{
if (objvgs_PConceptRelaEN.mId == lngmId)
{
return objvgs_PConceptRelaEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvgs_PConceptRelaDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vgs_PConceptRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PConceptRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vgs_PConceptRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_PConceptRelaDA.IsExistTable();
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
 bolIsExist = vgs_PConceptRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PConceptRelaENS">源对象</param>
 /// <param name = "objvgs_PConceptRelaENT">目标对象</param>
 public static void CopyTo(clsvgs_PConceptRelaEN objvgs_PConceptRelaENS, clsvgs_PConceptRelaEN objvgs_PConceptRelaENT)
{
try
{
objvgs_PConceptRelaENT.mId = objvgs_PConceptRelaENS.mId; //mId
objvgs_PConceptRelaENT.PaperId = objvgs_PConceptRelaENS.PaperId; //论文Id
objvgs_PConceptRelaENT.PaperTitle = objvgs_PConceptRelaENS.PaperTitle; //论文标题
objvgs_PConceptRelaENT.PaperTypeId = objvgs_PConceptRelaENS.PaperTypeId; //论文类型Id
objvgs_PConceptRelaENT.SectionId = objvgs_PConceptRelaENS.SectionId; //节Id
objvgs_PConceptRelaENT.SectionName = objvgs_PConceptRelaENS.SectionName; //节名
objvgs_PConceptRelaENT.ConceptId = objvgs_PConceptRelaENS.ConceptId; //概念Id
objvgs_PConceptRelaENT.ConceptName = objvgs_PConceptRelaENS.ConceptName; //概念名称
objvgs_PConceptRelaENT.ConceptContent = objvgs_PConceptRelaENS.ConceptContent; //概念内容
objvgs_PConceptRelaENT.IsSubmit = objvgs_PConceptRelaENS.IsSubmit; //是否提交
objvgs_PConceptRelaENT.TeaScore = objvgs_PConceptRelaENS.TeaScore; //教师评分
objvgs_PConceptRelaENT.StuScore = objvgs_PConceptRelaENS.StuScore; //学生平均分
objvgs_PConceptRelaENT.Score = objvgs_PConceptRelaENS.Score; //评分
objvgs_PConceptRelaENT.AppraiseCount = objvgs_PConceptRelaENS.AppraiseCount; //评论数
objvgs_PConceptRelaENT.OkCount = objvgs_PConceptRelaENS.OkCount; //点赞统计
objvgs_PConceptRelaENT.VersionCount = objvgs_PConceptRelaENS.VersionCount; //版本统计
objvgs_PConceptRelaENT.CitationCount = objvgs_PConceptRelaENS.CitationCount; //引用统计
objvgs_PConceptRelaENT.UpdDate = objvgs_PConceptRelaENS.UpdDate; //修改日期
objvgs_PConceptRelaENT.UpdUser = objvgs_PConceptRelaENS.UpdUser; //修改人
objvgs_PConceptRelaENT.Memo = objvgs_PConceptRelaENS.Memo; //备注
objvgs_PConceptRelaENT.ConcepUserId = objvgs_PConceptRelaENS.ConcepUserId; //ConcepUserId
objvgs_PConceptRelaENT.ConcepDate = objvgs_PConceptRelaENS.ConcepDate; //ConcepDate
objvgs_PConceptRelaENT.CreateDate = objvgs_PConceptRelaENS.CreateDate; //建立日期
objvgs_PConceptRelaENT.ShareId = objvgs_PConceptRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PConceptRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PConceptRelaEN objvgs_PConceptRelaEN)
{
try
{
objvgs_PConceptRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PConceptRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PConceptRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.mId = objvgs_PConceptRelaEN.mId; //mId
}
if (arrFldSet.Contains(convgs_PConceptRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.PaperId = objvgs_PConceptRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PConceptRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.PaperTitle = objvgs_PConceptRelaEN.PaperTitle == "[null]" ? null :  objvgs_PConceptRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PConceptRela.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.PaperTypeId = objvgs_PConceptRelaEN.PaperTypeId == "[null]" ? null :  objvgs_PConceptRelaEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convgs_PConceptRela.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.SectionId = objvgs_PConceptRelaEN.SectionId == "[null]" ? null :  objvgs_PConceptRelaEN.SectionId; //节Id
}
if (arrFldSet.Contains(convgs_PConceptRela.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.SectionName = objvgs_PConceptRelaEN.SectionName == "[null]" ? null :  objvgs_PConceptRelaEN.SectionName; //节名
}
if (arrFldSet.Contains(convgs_PConceptRela.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.ConceptId = objvgs_PConceptRelaEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(convgs_PConceptRela.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.ConceptName = objvgs_PConceptRelaEN.ConceptName == "[null]" ? null :  objvgs_PConceptRelaEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(convgs_PConceptRela.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.ConceptContent = objvgs_PConceptRelaEN.ConceptContent == "[null]" ? null :  objvgs_PConceptRelaEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(convgs_PConceptRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.IsSubmit = objvgs_PConceptRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_PConceptRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.TeaScore = objvgs_PConceptRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_PConceptRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.StuScore = objvgs_PConceptRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convgs_PConceptRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.Score = objvgs_PConceptRelaEN.Score; //评分
}
if (arrFldSet.Contains(convgs_PConceptRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.AppraiseCount = objvgs_PConceptRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convgs_PConceptRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.OkCount = objvgs_PConceptRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convgs_PConceptRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.VersionCount = objvgs_PConceptRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_PConceptRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.CitationCount = objvgs_PConceptRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convgs_PConceptRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.UpdDate = objvgs_PConceptRelaEN.UpdDate == "[null]" ? null :  objvgs_PConceptRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PConceptRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.UpdUser = objvgs_PConceptRelaEN.UpdUser == "[null]" ? null :  objvgs_PConceptRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PConceptRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.Memo = objvgs_PConceptRelaEN.Memo == "[null]" ? null :  objvgs_PConceptRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_PConceptRela.ConcepUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.ConcepUserId = objvgs_PConceptRelaEN.ConcepUserId == "[null]" ? null :  objvgs_PConceptRelaEN.ConcepUserId; //ConcepUserId
}
if (arrFldSet.Contains(convgs_PConceptRela.ConcepDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.ConcepDate = objvgs_PConceptRelaEN.ConcepDate == "[null]" ? null :  objvgs_PConceptRelaEN.ConcepDate; //ConcepDate
}
if (arrFldSet.Contains(convgs_PConceptRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.CreateDate = objvgs_PConceptRelaEN.CreateDate == "[null]" ? null :  objvgs_PConceptRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convgs_PConceptRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PConceptRelaEN.ShareId = objvgs_PConceptRelaEN.ShareId == "[null]" ? null :  objvgs_PConceptRelaEN.ShareId; //分享Id
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
 /// <param name = "objvgs_PConceptRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PConceptRelaEN objvgs_PConceptRelaEN)
{
try
{
if (objvgs_PConceptRelaEN.PaperTitle == "[null]") objvgs_PConceptRelaEN.PaperTitle = null; //论文标题
if (objvgs_PConceptRelaEN.PaperTypeId == "[null]") objvgs_PConceptRelaEN.PaperTypeId = null; //论文类型Id
if (objvgs_PConceptRelaEN.SectionId == "[null]") objvgs_PConceptRelaEN.SectionId = null; //节Id
if (objvgs_PConceptRelaEN.SectionName == "[null]") objvgs_PConceptRelaEN.SectionName = null; //节名
if (objvgs_PConceptRelaEN.ConceptName == "[null]") objvgs_PConceptRelaEN.ConceptName = null; //概念名称
if (objvgs_PConceptRelaEN.ConceptContent == "[null]") objvgs_PConceptRelaEN.ConceptContent = null; //概念内容
if (objvgs_PConceptRelaEN.UpdDate == "[null]") objvgs_PConceptRelaEN.UpdDate = null; //修改日期
if (objvgs_PConceptRelaEN.UpdUser == "[null]") objvgs_PConceptRelaEN.UpdUser = null; //修改人
if (objvgs_PConceptRelaEN.Memo == "[null]") objvgs_PConceptRelaEN.Memo = null; //备注
if (objvgs_PConceptRelaEN.ConcepUserId == "[null]") objvgs_PConceptRelaEN.ConcepUserId = null; //ConcepUserId
if (objvgs_PConceptRelaEN.ConcepDate == "[null]") objvgs_PConceptRelaEN.ConcepDate = null; //ConcepDate
if (objvgs_PConceptRelaEN.CreateDate == "[null]") objvgs_PConceptRelaEN.CreateDate = null; //建立日期
if (objvgs_PConceptRelaEN.ShareId == "[null]") objvgs_PConceptRelaEN.ShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvgs_PConceptRelaEN objvgs_PConceptRelaEN)
{
 vgs_PConceptRelaDA.CheckProperty4Condition(objvgs_PConceptRelaEN);
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
if (clsSectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSectionBL没有刷新缓存机制(clsSectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PConcepRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PConcepRelaBL没有刷新缓存机制(clsgs_PConcepRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptBL没有刷新缓存机制(clsConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_PConceptRelaObjLstCache == null)
//{
//arrvgs_PConceptRelaObjLstCache = vgs_PConceptRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PConceptRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PConceptRelaEN._CurrTabName);
List<clsvgs_PConceptRelaEN> arrvgs_PConceptRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PConceptRelaEN> arrvgs_PConceptRelaObjLst_Sel =
arrvgs_PConceptRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_PConceptRelaObjLst_Sel.Count() == 0)
{
   clsvgs_PConceptRelaEN obj = clsvgs_PConceptRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PConceptRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PConceptRelaEN> GetAllvgs_PConceptRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PConceptRelaEN> arrvgs_PConceptRelaObjLstCache = GetObjLstCache(); 
return arrvgs_PConceptRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PConceptRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PConceptRelaEN._CurrTabName);
List<clsvgs_PConceptRelaEN> arrvgs_PConceptRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PConceptRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PConceptRelaEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convgs_PConceptRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PConceptRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PConceptRela.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PConceptRela = clsvgs_PConceptRelaBL.GetObjBymIdCache(lngmId);
if (objvgs_PConceptRela == null) return "";
return objvgs_PConceptRela[strOutFldName].ToString();
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
int intRecCount = clsvgs_PConceptRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PConceptRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PConceptRelaDA.GetRecCount();
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
int intRecCount = clsvgs_PConceptRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PConceptRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PConceptRelaEN objvgs_PConceptRelaCond)
{
List<clsvgs_PConceptRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PConceptRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PConceptRela.AttributeName)
{
if (objvgs_PConceptRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PConceptRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PConceptRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PConceptRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PConceptRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PConceptRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PConceptRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PConceptRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PConceptRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PConceptRelaCond[strFldName]));
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
 List<string> arrList = clsvgs_PConceptRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PConceptRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PConceptRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}