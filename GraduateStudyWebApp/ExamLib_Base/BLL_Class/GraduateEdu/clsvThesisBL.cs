
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvThesisBL
 表名:vThesis(01120537)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:19:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研究生培养(GraduateEdu)
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
public static class  clsvThesisBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strThesisId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvThesisEN GetObj(this K_ThesisId_vThesis myKey)
{
clsvThesisEN objvThesisEN = clsvThesisBL.vThesisDA.GetObjByThesisId(myKey.Value);
return objvThesisEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetThesisId(this clsvThesisEN objvThesisEN, string strThesisId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThesisId, 8, convThesis.ThesisId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strThesisId, 8, convThesis.ThesisId);
}
objvThesisEN.ThesisId = strThesisId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.ThesisId) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.ThesisId, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.ThesisId] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetThesisTitle(this clsvThesisEN objvThesisEN, string strThesisTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strThesisTitle, convThesis.ThesisTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThesisTitle, 100, convThesis.ThesisTitle);
}
objvThesisEN.ThesisTitle = strThesisTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.ThesisTitle) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.ThesisTitle, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.ThesisTitle] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetThesisName(this clsvThesisEN objvThesisEN, string strThesisName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strThesisName, convThesis.ThesisName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strThesisName, 100, convThesis.ThesisName);
}
objvThesisEN.ThesisName = strThesisName; //主题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.ThesisName) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.ThesisName, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.ThesisName] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetThesisContent(this clsvThesisEN objvThesisEN, string strThesisContent, string strComparisonOp="")
	{
objvThesisEN.ThesisContent = strThesisContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.ThesisContent) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.ThesisContent, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.ThesisContent] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetPeriodical(this clsvThesisEN objvThesisEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convThesis.Periodical);
}
objvThesisEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.Periodical) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.Periodical, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.Periodical] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetAuthor(this clsvThesisEN objvThesisEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convThesis.Author);
}
objvThesisEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.Author) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.Author, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.Author] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetResearchQuestion(this clsvThesisEN objvThesisEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convThesis.ResearchQuestion);
}
objvThesisEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.ResearchQuestion) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.ResearchQuestion, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.ResearchQuestion] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetUpdDate(this clsvThesisEN objvThesisEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convThesis.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convThesis.UpdDate);
}
objvThesisEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.UpdDate) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.UpdDate, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.UpdDate] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetUpdUserId(this clsvThesisEN objvThesisEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convThesis.UpdUserId);
}
objvThesisEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.UpdUserId) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.UpdUserId, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.UpdUserId] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetMemo(this clsvThesisEN objvThesisEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convThesis.Memo);
}
objvThesisEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.Memo) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.Memo, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.Memo] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetOperationTypeId(this clsvThesisEN objvThesisEN, string strOperationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeId, convThesis.OperationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convThesis.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convThesis.OperationTypeId);
}
objvThesisEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.OperationTypeId) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.OperationTypeId, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.OperationTypeId] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetOperationTypeName(this clsvThesisEN objvThesisEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convThesis.OperationTypeName);
}
objvThesisEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.OperationTypeName) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.OperationTypeName, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.OperationTypeName] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetKeyword(this clsvThesisEN objvThesisEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convThesis.Keyword);
}
objvThesisEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.Keyword) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.Keyword, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.Keyword] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetLiteratureLink(this clsvThesisEN objvThesisEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convThesis.LiteratureLink);
}
objvThesisEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.LiteratureLink) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.LiteratureLink, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.LiteratureLink] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetLiteratureSources(this clsvThesisEN objvThesisEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convThesis.LiteratureSources);
}
objvThesisEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.LiteratureSources) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.LiteratureSources, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.LiteratureSources] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetResearcherInformation(this clsvThesisEN objvThesisEN, string strResearcherInformation, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearcherInformation, 200, convThesis.ResearcherInformation);
}
objvThesisEN.ResearcherInformation = strResearcherInformation; //研究者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.ResearcherInformation) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.ResearcherInformation, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.ResearcherInformation] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetUploadfileUrl(this clsvThesisEN objvThesisEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convThesis.UploadfileUrl);
}
objvThesisEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.UploadfileUrl) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.UploadfileUrl, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.UploadfileUrl] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetIsQuotethesis(this clsvThesisEN objvThesisEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objvThesisEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.IsQuotethesis) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.IsQuotethesis, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.IsQuotethesis] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetQuoteId(this clsvThesisEN objvThesisEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, convThesis.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, convThesis.QuoteId);
}
objvThesisEN.QuoteId = strQuoteId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.QuoteId) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.QuoteId, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.QuoteId] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetQuoteThesisContent(this clsvThesisEN objvThesisEN, string strQuoteThesisContent, string strComparisonOp="")
	{
objvThesisEN.QuoteThesisContent = strQuoteThesisContent; //QuoteThesisContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.QuoteThesisContent) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.QuoteThesisContent, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.QuoteThesisContent] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetQuoteThesisName(this clsvThesisEN objvThesisEN, string strQuoteThesisName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteThesisName, 100, convThesis.QuoteThesisName);
}
objvThesisEN.QuoteThesisName = strQuoteThesisName; //QuoteThesisName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.QuoteThesisName) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.QuoteThesisName, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.QuoteThesisName] = strComparisonOp;
}
}
return objvThesisEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvThesisEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvThesisEN SetQuoteThesisTitle(this clsvThesisEN objvThesisEN, string strQuoteThesisTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteThesisTitle, 100, convThesis.QuoteThesisTitle);
}
objvThesisEN.QuoteThesisTitle = strQuoteThesisTitle; //QuoteThesisTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvThesisEN.dicFldComparisonOp.ContainsKey(convThesis.QuoteThesisTitle) == false)
{
objvThesisEN.dicFldComparisonOp.Add(convThesis.QuoteThesisTitle, strComparisonOp);
}
else
{
objvThesisEN.dicFldComparisonOp[convThesis.QuoteThesisTitle] = strComparisonOp;
}
}
return objvThesisEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvThesisENS">源对象</param>
 /// <param name = "objvThesisENT">目标对象</param>
 public static void CopyTo(this clsvThesisEN objvThesisENS, clsvThesisEN objvThesisENT)
{
try
{
objvThesisENT.ThesisId = objvThesisENS.ThesisId; //论文Id
objvThesisENT.ThesisTitle = objvThesisENS.ThesisTitle; //论文标题
objvThesisENT.ThesisName = objvThesisENS.ThesisName; //主题名称
objvThesisENT.ThesisContent = objvThesisENS.ThesisContent; //主题内容
objvThesisENT.Periodical = objvThesisENS.Periodical; //期刊
objvThesisENT.Author = objvThesisENS.Author; //作者
objvThesisENT.ResearchQuestion = objvThesisENS.ResearchQuestion; //研究问题
objvThesisENT.UpdDate = objvThesisENS.UpdDate; //修改日期
objvThesisENT.UpdUserId = objvThesisENS.UpdUserId; //修改用户Id
objvThesisENT.Memo = objvThesisENS.Memo; //备注
objvThesisENT.OperationTypeId = objvThesisENS.OperationTypeId; //操作类型ID
objvThesisENT.OperationTypeName = objvThesisENS.OperationTypeName; //操作类型名
objvThesisENT.Keyword = objvThesisENS.Keyword; //关键字
objvThesisENT.LiteratureLink = objvThesisENS.LiteratureLink; //文献链接
objvThesisENT.LiteratureSources = objvThesisENS.LiteratureSources; //文献来源
objvThesisENT.ResearcherInformation = objvThesisENS.ResearcherInformation; //研究者
objvThesisENT.UploadfileUrl = objvThesisENS.UploadfileUrl; //文件地址
objvThesisENT.IsQuotethesis = objvThesisENS.IsQuotethesis; //是否引用论文
objvThesisENT.QuoteId = objvThesisENS.QuoteId; //引用Id
objvThesisENT.QuoteThesisContent = objvThesisENS.QuoteThesisContent; //QuoteThesisContent
objvThesisENT.QuoteThesisName = objvThesisENS.QuoteThesisName; //QuoteThesisName
objvThesisENT.QuoteThesisTitle = objvThesisENS.QuoteThesisTitle; //QuoteThesisTitle
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
 /// <param name = "objvThesisENS">源对象</param>
 /// <returns>目标对象=>clsvThesisEN:objvThesisENT</returns>
 public static clsvThesisEN CopyTo(this clsvThesisEN objvThesisENS)
{
try
{
 clsvThesisEN objvThesisENT = new clsvThesisEN()
{
ThesisId = objvThesisENS.ThesisId, //论文Id
ThesisTitle = objvThesisENS.ThesisTitle, //论文标题
ThesisName = objvThesisENS.ThesisName, //主题名称
ThesisContent = objvThesisENS.ThesisContent, //主题内容
Periodical = objvThesisENS.Periodical, //期刊
Author = objvThesisENS.Author, //作者
ResearchQuestion = objvThesisENS.ResearchQuestion, //研究问题
UpdDate = objvThesisENS.UpdDate, //修改日期
UpdUserId = objvThesisENS.UpdUserId, //修改用户Id
Memo = objvThesisENS.Memo, //备注
OperationTypeId = objvThesisENS.OperationTypeId, //操作类型ID
OperationTypeName = objvThesisENS.OperationTypeName, //操作类型名
Keyword = objvThesisENS.Keyword, //关键字
LiteratureLink = objvThesisENS.LiteratureLink, //文献链接
LiteratureSources = objvThesisENS.LiteratureSources, //文献来源
ResearcherInformation = objvThesisENS.ResearcherInformation, //研究者
UploadfileUrl = objvThesisENS.UploadfileUrl, //文件地址
IsQuotethesis = objvThesisENS.IsQuotethesis, //是否引用论文
QuoteId = objvThesisENS.QuoteId, //引用Id
QuoteThesisContent = objvThesisENS.QuoteThesisContent, //QuoteThesisContent
QuoteThesisName = objvThesisENS.QuoteThesisName, //QuoteThesisName
QuoteThesisTitle = objvThesisENS.QuoteThesisTitle, //QuoteThesisTitle
};
 return objvThesisENT;
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
public static void CheckProperty4Condition(this clsvThesisEN objvThesisEN)
{
 clsvThesisBL.vThesisDA.CheckProperty4Condition(objvThesisEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvThesisEN objvThesisCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvThesisCond.IsUpdated(convThesis.ThesisId) == true)
{
string strComparisonOpThesisId = objvThesisCond.dicFldComparisonOp[convThesis.ThesisId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.ThesisId, objvThesisCond.ThesisId, strComparisonOpThesisId);
}
if (objvThesisCond.IsUpdated(convThesis.ThesisTitle) == true)
{
string strComparisonOpThesisTitle = objvThesisCond.dicFldComparisonOp[convThesis.ThesisTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.ThesisTitle, objvThesisCond.ThesisTitle, strComparisonOpThesisTitle);
}
if (objvThesisCond.IsUpdated(convThesis.ThesisName) == true)
{
string strComparisonOpThesisName = objvThesisCond.dicFldComparisonOp[convThesis.ThesisName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.ThesisName, objvThesisCond.ThesisName, strComparisonOpThesisName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvThesisCond.IsUpdated(convThesis.Periodical) == true)
{
string strComparisonOpPeriodical = objvThesisCond.dicFldComparisonOp[convThesis.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.Periodical, objvThesisCond.Periodical, strComparisonOpPeriodical);
}
if (objvThesisCond.IsUpdated(convThesis.Author) == true)
{
string strComparisonOpAuthor = objvThesisCond.dicFldComparisonOp[convThesis.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.Author, objvThesisCond.Author, strComparisonOpAuthor);
}
if (objvThesisCond.IsUpdated(convThesis.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvThesisCond.dicFldComparisonOp[convThesis.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.ResearchQuestion, objvThesisCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvThesisCond.IsUpdated(convThesis.UpdDate) == true)
{
string strComparisonOpUpdDate = objvThesisCond.dicFldComparisonOp[convThesis.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.UpdDate, objvThesisCond.UpdDate, strComparisonOpUpdDate);
}
if (objvThesisCond.IsUpdated(convThesis.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvThesisCond.dicFldComparisonOp[convThesis.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.UpdUserId, objvThesisCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvThesisCond.IsUpdated(convThesis.Memo) == true)
{
string strComparisonOpMemo = objvThesisCond.dicFldComparisonOp[convThesis.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.Memo, objvThesisCond.Memo, strComparisonOpMemo);
}
if (objvThesisCond.IsUpdated(convThesis.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvThesisCond.dicFldComparisonOp[convThesis.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.OperationTypeId, objvThesisCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objvThesisCond.IsUpdated(convThesis.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvThesisCond.dicFldComparisonOp[convThesis.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.OperationTypeName, objvThesisCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvThesisCond.IsUpdated(convThesis.Keyword) == true)
{
string strComparisonOpKeyword = objvThesisCond.dicFldComparisonOp[convThesis.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.Keyword, objvThesisCond.Keyword, strComparisonOpKeyword);
}
if (objvThesisCond.IsUpdated(convThesis.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvThesisCond.dicFldComparisonOp[convThesis.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.LiteratureLink, objvThesisCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvThesisCond.IsUpdated(convThesis.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvThesisCond.dicFldComparisonOp[convThesis.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.LiteratureSources, objvThesisCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvThesisCond.IsUpdated(convThesis.ResearcherInformation) == true)
{
string strComparisonOpResearcherInformation = objvThesisCond.dicFldComparisonOp[convThesis.ResearcherInformation];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.ResearcherInformation, objvThesisCond.ResearcherInformation, strComparisonOpResearcherInformation);
}
if (objvThesisCond.IsUpdated(convThesis.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvThesisCond.dicFldComparisonOp[convThesis.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.UploadfileUrl, objvThesisCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvThesisCond.IsUpdated(convThesis.IsQuotethesis) == true)
{
if (objvThesisCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", convThesis.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convThesis.IsQuotethesis);
}
}
if (objvThesisCond.IsUpdated(convThesis.QuoteId) == true)
{
string strComparisonOpQuoteId = objvThesisCond.dicFldComparisonOp[convThesis.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.QuoteId, objvThesisCond.QuoteId, strComparisonOpQuoteId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvThesisCond.IsUpdated(convThesis.QuoteThesisName) == true)
{
string strComparisonOpQuoteThesisName = objvThesisCond.dicFldComparisonOp[convThesis.QuoteThesisName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.QuoteThesisName, objvThesisCond.QuoteThesisName, strComparisonOpQuoteThesisName);
}
if (objvThesisCond.IsUpdated(convThesis.QuoteThesisTitle) == true)
{
string strComparisonOpQuoteThesisTitle = objvThesisCond.dicFldComparisonOp[convThesis.QuoteThesisTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convThesis.QuoteThesisTitle, objvThesisCond.QuoteThesisTitle, strComparisonOpQuoteThesisTitle);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vThesis
{
public virtual bool UpdRelaTabDate(string strThesisId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vThesis(vThesis)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvThesisBL
{
public static RelatedActions_vThesis relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvThesisDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvThesisDA vThesisDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvThesisDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvThesisBL()
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
if (string.IsNullOrEmpty(clsvThesisEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvThesisEN._ConnectString);
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
public static DataTable GetDataTable_vThesis(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vThesisDA.GetDataTable_vThesis(strWhereCond);
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
objDT = vThesisDA.GetDataTable(strWhereCond);
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
objDT = vThesisDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vThesisDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vThesisDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vThesisDA.GetDataTable_Top(objTopPara);
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
objDT = vThesisDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vThesisDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vThesisDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrThesisIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvThesisEN> GetObjLstByThesisIdLst(List<string> arrThesisIdLst)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrThesisIdLst, true);
 string strWhereCond = string.Format("ThesisId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrThesisIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvThesisEN> GetObjLstByThesisIdLstCache(List<string> arrThesisIdLst)
{
string strKey = string.Format("{0}", clsvThesisEN._CurrTabName);
List<clsvThesisEN> arrvThesisObjLstCache = GetObjLstCache();
IEnumerable <clsvThesisEN> arrvThesisObjLst_Sel =
arrvThesisObjLstCache
.Where(x => arrThesisIdLst.Contains(x.ThesisId));
return arrvThesisObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvThesisEN> GetObjLst(string strWhereCond)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
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
public static List<clsvThesisEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvThesisCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvThesisEN> GetSubObjLstCache(clsvThesisEN objvThesisCond)
{
List<clsvThesisEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvThesisEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convThesis.AttributeName)
{
if (objvThesisCond.IsUpdated(strFldName) == false) continue;
if (objvThesisCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvThesisCond[strFldName].ToString());
}
else
{
if (objvThesisCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvThesisCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvThesisCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvThesisCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvThesisCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvThesisCond[strFldName]));
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
public static List<clsvThesisEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
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
public static List<clsvThesisEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
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
List<clsvThesisEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvThesisEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvThesisEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvThesisEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
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
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
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
public static List<clsvThesisEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvThesisEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvThesisEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
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
public static List<clsvThesisEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvThesisEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvThesisEN> arrObjLst = new List<clsvThesisEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvThesisEN objvThesisEN = new clsvThesisEN();
try
{
objvThesisEN.ThesisId = objRow[convThesis.ThesisId].ToString().Trim(); //论文Id
objvThesisEN.ThesisTitle = objRow[convThesis.ThesisTitle].ToString().Trim(); //论文标题
objvThesisEN.ThesisName = objRow[convThesis.ThesisName].ToString().Trim(); //主题名称
objvThesisEN.ThesisContent = objRow[convThesis.ThesisContent] == DBNull.Value ? null : objRow[convThesis.ThesisContent].ToString().Trim(); //主题内容
objvThesisEN.Periodical = objRow[convThesis.Periodical] == DBNull.Value ? null : objRow[convThesis.Periodical].ToString().Trim(); //期刊
objvThesisEN.Author = objRow[convThesis.Author] == DBNull.Value ? null : objRow[convThesis.Author].ToString().Trim(); //作者
objvThesisEN.ResearchQuestion = objRow[convThesis.ResearchQuestion] == DBNull.Value ? null : objRow[convThesis.ResearchQuestion].ToString().Trim(); //研究问题
objvThesisEN.UpdDate = objRow[convThesis.UpdDate].ToString().Trim(); //修改日期
objvThesisEN.UpdUserId = objRow[convThesis.UpdUserId] == DBNull.Value ? null : objRow[convThesis.UpdUserId].ToString().Trim(); //修改用户Id
objvThesisEN.Memo = objRow[convThesis.Memo] == DBNull.Value ? null : objRow[convThesis.Memo].ToString().Trim(); //备注
objvThesisEN.OperationTypeId = objRow[convThesis.OperationTypeId].ToString().Trim(); //操作类型ID
objvThesisEN.OperationTypeName = objRow[convThesis.OperationTypeName] == DBNull.Value ? null : objRow[convThesis.OperationTypeName].ToString().Trim(); //操作类型名
objvThesisEN.Keyword = objRow[convThesis.Keyword] == DBNull.Value ? null : objRow[convThesis.Keyword].ToString().Trim(); //关键字
objvThesisEN.LiteratureLink = objRow[convThesis.LiteratureLink] == DBNull.Value ? null : objRow[convThesis.LiteratureLink].ToString().Trim(); //文献链接
objvThesisEN.LiteratureSources = objRow[convThesis.LiteratureSources] == DBNull.Value ? null : objRow[convThesis.LiteratureSources].ToString().Trim(); //文献来源
objvThesisEN.ResearcherInformation = objRow[convThesis.ResearcherInformation] == DBNull.Value ? null : objRow[convThesis.ResearcherInformation].ToString().Trim(); //研究者
objvThesisEN.UploadfileUrl = objRow[convThesis.UploadfileUrl] == DBNull.Value ? null : objRow[convThesis.UploadfileUrl].ToString().Trim(); //文件地址
objvThesisEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convThesis.IsQuotethesis].ToString().Trim()); //是否引用论文
objvThesisEN.QuoteId = objRow[convThesis.QuoteId] == DBNull.Value ? null : objRow[convThesis.QuoteId].ToString().Trim(); //引用Id
objvThesisEN.QuoteThesisContent = objRow[convThesis.QuoteThesisContent] == DBNull.Value ? null : objRow[convThesis.QuoteThesisContent].ToString().Trim(); //QuoteThesisContent
objvThesisEN.QuoteThesisName = objRow[convThesis.QuoteThesisName] == DBNull.Value ? null : objRow[convThesis.QuoteThesisName].ToString().Trim(); //QuoteThesisName
objvThesisEN.QuoteThesisTitle = objRow[convThesis.QuoteThesisTitle] == DBNull.Value ? null : objRow[convThesis.QuoteThesisTitle].ToString().Trim(); //QuoteThesisTitle
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvThesisEN.ThesisId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvThesisEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvThesisEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvThesis(ref clsvThesisEN objvThesisEN)
{
bool bolResult = vThesisDA.GetvThesis(ref objvThesisEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strThesisId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvThesisEN GetObjByThesisId(string strThesisId)
{
if (strThesisId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strThesisId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strThesisId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strThesisId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvThesisEN objvThesisEN = vThesisDA.GetObjByThesisId(strThesisId);
return objvThesisEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvThesisEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvThesisEN objvThesisEN = vThesisDA.GetFirstObj(strWhereCond);
 return objvThesisEN;
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
public static clsvThesisEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvThesisEN objvThesisEN = vThesisDA.GetObjByDataRow(objRow);
 return objvThesisEN;
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
public static clsvThesisEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvThesisEN objvThesisEN = vThesisDA.GetObjByDataRow(objRow);
 return objvThesisEN;
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
 /// <param name = "strThesisId">所给的关键字</param>
 /// <param name = "lstvThesisObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvThesisEN GetObjByThesisIdFromList(string strThesisId, List<clsvThesisEN> lstvThesisObjLst)
{
foreach (clsvThesisEN objvThesisEN in lstvThesisObjLst)
{
if (objvThesisEN.ThesisId == strThesisId)
{
return objvThesisEN;
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
 string strThesisId;
 try
 {
 strThesisId = new clsvThesisDA().GetFirstID(strWhereCond);
 return strThesisId;
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
 arrList = vThesisDA.GetID(strWhereCond);
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
bool bolIsExist = vThesisDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strThesisId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strThesisId)
{
if (string.IsNullOrEmpty(strThesisId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strThesisId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vThesisDA.IsExist(strThesisId);
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
 bolIsExist = clsvThesisDA.IsExistTable();
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
 bolIsExist = vThesisDA.IsExistTable(strTabName);
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
 /// <param name = "objvThesisENS">源对象</param>
 /// <param name = "objvThesisENT">目标对象</param>
 public static void CopyTo(clsvThesisEN objvThesisENS, clsvThesisEN objvThesisENT)
{
try
{
objvThesisENT.ThesisId = objvThesisENS.ThesisId; //论文Id
objvThesisENT.ThesisTitle = objvThesisENS.ThesisTitle; //论文标题
objvThesisENT.ThesisName = objvThesisENS.ThesisName; //主题名称
objvThesisENT.ThesisContent = objvThesisENS.ThesisContent; //主题内容
objvThesisENT.Periodical = objvThesisENS.Periodical; //期刊
objvThesisENT.Author = objvThesisENS.Author; //作者
objvThesisENT.ResearchQuestion = objvThesisENS.ResearchQuestion; //研究问题
objvThesisENT.UpdDate = objvThesisENS.UpdDate; //修改日期
objvThesisENT.UpdUserId = objvThesisENS.UpdUserId; //修改用户Id
objvThesisENT.Memo = objvThesisENS.Memo; //备注
objvThesisENT.OperationTypeId = objvThesisENS.OperationTypeId; //操作类型ID
objvThesisENT.OperationTypeName = objvThesisENS.OperationTypeName; //操作类型名
objvThesisENT.Keyword = objvThesisENS.Keyword; //关键字
objvThesisENT.LiteratureLink = objvThesisENS.LiteratureLink; //文献链接
objvThesisENT.LiteratureSources = objvThesisENS.LiteratureSources; //文献来源
objvThesisENT.ResearcherInformation = objvThesisENS.ResearcherInformation; //研究者
objvThesisENT.UploadfileUrl = objvThesisENS.UploadfileUrl; //文件地址
objvThesisENT.IsQuotethesis = objvThesisENS.IsQuotethesis; //是否引用论文
objvThesisENT.QuoteId = objvThesisENS.QuoteId; //引用Id
objvThesisENT.QuoteThesisContent = objvThesisENS.QuoteThesisContent; //QuoteThesisContent
objvThesisENT.QuoteThesisName = objvThesisENS.QuoteThesisName; //QuoteThesisName
objvThesisENT.QuoteThesisTitle = objvThesisENS.QuoteThesisTitle; //QuoteThesisTitle
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
 /// <param name = "objvThesisEN">源简化对象</param>
 public static void SetUpdFlag(clsvThesisEN objvThesisEN)
{
try
{
objvThesisEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvThesisEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convThesis.ThesisId, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.ThesisId = objvThesisEN.ThesisId; //论文Id
}
if (arrFldSet.Contains(convThesis.ThesisTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.ThesisTitle = objvThesisEN.ThesisTitle; //论文标题
}
if (arrFldSet.Contains(convThesis.ThesisName, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.ThesisName = objvThesisEN.ThesisName; //主题名称
}
if (arrFldSet.Contains(convThesis.ThesisContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.ThesisContent = objvThesisEN.ThesisContent == "[null]" ? null :  objvThesisEN.ThesisContent; //主题内容
}
if (arrFldSet.Contains(convThesis.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.Periodical = objvThesisEN.Periodical == "[null]" ? null :  objvThesisEN.Periodical; //期刊
}
if (arrFldSet.Contains(convThesis.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.Author = objvThesisEN.Author == "[null]" ? null :  objvThesisEN.Author; //作者
}
if (arrFldSet.Contains(convThesis.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.ResearchQuestion = objvThesisEN.ResearchQuestion == "[null]" ? null :  objvThesisEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convThesis.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.UpdDate = objvThesisEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convThesis.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.UpdUserId = objvThesisEN.UpdUserId == "[null]" ? null :  objvThesisEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convThesis.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.Memo = objvThesisEN.Memo == "[null]" ? null :  objvThesisEN.Memo; //备注
}
if (arrFldSet.Contains(convThesis.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.OperationTypeId = objvThesisEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convThesis.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.OperationTypeName = objvThesisEN.OperationTypeName == "[null]" ? null :  objvThesisEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convThesis.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.Keyword = objvThesisEN.Keyword == "[null]" ? null :  objvThesisEN.Keyword; //关键字
}
if (arrFldSet.Contains(convThesis.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.LiteratureLink = objvThesisEN.LiteratureLink == "[null]" ? null :  objvThesisEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convThesis.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.LiteratureSources = objvThesisEN.LiteratureSources == "[null]" ? null :  objvThesisEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convThesis.ResearcherInformation, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.ResearcherInformation = objvThesisEN.ResearcherInformation == "[null]" ? null :  objvThesisEN.ResearcherInformation; //研究者
}
if (arrFldSet.Contains(convThesis.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.UploadfileUrl = objvThesisEN.UploadfileUrl == "[null]" ? null :  objvThesisEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convThesis.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.IsQuotethesis = objvThesisEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(convThesis.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.QuoteId = objvThesisEN.QuoteId == "[null]" ? null :  objvThesisEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(convThesis.QuoteThesisContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.QuoteThesisContent = objvThesisEN.QuoteThesisContent == "[null]" ? null :  objvThesisEN.QuoteThesisContent; //QuoteThesisContent
}
if (arrFldSet.Contains(convThesis.QuoteThesisName, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.QuoteThesisName = objvThesisEN.QuoteThesisName == "[null]" ? null :  objvThesisEN.QuoteThesisName; //QuoteThesisName
}
if (arrFldSet.Contains(convThesis.QuoteThesisTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvThesisEN.QuoteThesisTitle = objvThesisEN.QuoteThesisTitle == "[null]" ? null :  objvThesisEN.QuoteThesisTitle; //QuoteThesisTitle
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
 /// <param name = "objvThesisEN">源简化对象</param>
 public static void AccessFldValueNull(clsvThesisEN objvThesisEN)
{
try
{
if (objvThesisEN.ThesisContent == "[null]") objvThesisEN.ThesisContent = null; //主题内容
if (objvThesisEN.Periodical == "[null]") objvThesisEN.Periodical = null; //期刊
if (objvThesisEN.Author == "[null]") objvThesisEN.Author = null; //作者
if (objvThesisEN.ResearchQuestion == "[null]") objvThesisEN.ResearchQuestion = null; //研究问题
if (objvThesisEN.UpdUserId == "[null]") objvThesisEN.UpdUserId = null; //修改用户Id
if (objvThesisEN.Memo == "[null]") objvThesisEN.Memo = null; //备注
if (objvThesisEN.OperationTypeName == "[null]") objvThesisEN.OperationTypeName = null; //操作类型名
if (objvThesisEN.Keyword == "[null]") objvThesisEN.Keyword = null; //关键字
if (objvThesisEN.LiteratureLink == "[null]") objvThesisEN.LiteratureLink = null; //文献链接
if (objvThesisEN.LiteratureSources == "[null]") objvThesisEN.LiteratureSources = null; //文献来源
if (objvThesisEN.ResearcherInformation == "[null]") objvThesisEN.ResearcherInformation = null; //研究者
if (objvThesisEN.UploadfileUrl == "[null]") objvThesisEN.UploadfileUrl = null; //文件地址
if (objvThesisEN.QuoteId == "[null]") objvThesisEN.QuoteId = null; //引用Id
if (objvThesisEN.QuoteThesisContent == "[null]") objvThesisEN.QuoteThesisContent = null; //QuoteThesisContent
if (objvThesisEN.QuoteThesisName == "[null]") objvThesisEN.QuoteThesisName = null; //QuoteThesisName
if (objvThesisEN.QuoteThesisTitle == "[null]") objvThesisEN.QuoteThesisTitle = null; //QuoteThesisTitle
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
public static void CheckProperty4Condition(clsvThesisEN objvThesisEN)
{
 vThesisDA.CheckProperty4Condition(objvThesisEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_ThesisId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convThesis.ThesisId); 
List<clsvThesisEN> arrObjLst = clsvThesisBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvThesisEN objvThesisEN = new clsvThesisEN()
{
ThesisId = "0",
OperationTypeName = "选[vThesis]..."
};
arrObjLst.Insert(0, objvThesisEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convThesis.ThesisId;
objComboBox.DisplayMember = convThesis.OperationTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_ThesisId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vThesis]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convThesis.ThesisId); 
IEnumerable<clsvThesisEN> arrObjLst = clsvThesisBL.GetObjLst(strCondition);
objDDL.DataValueField = convThesis.ThesisId;
objDDL.DataTextField = convThesis.OperationTypeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ThesisIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vThesis]...","0");
List<clsvThesisEN> arrvThesisObjLst = GetAllvThesisObjLstCache(); 
objDDL.DataValueField = convThesis.ThesisId;
objDDL.DataTextField = convThesis.OperationTypeName;
objDDL.DataSource = arrvThesisObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsOperationTypeBL没有刷新缓存机制(clsOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ThesisId");
//if (arrvThesisObjLstCache == null)
//{
//arrvThesisObjLstCache = vThesisDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strThesisId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvThesisEN GetObjByThesisIdCache(string strThesisId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvThesisEN._CurrTabName);
List<clsvThesisEN> arrvThesisObjLstCache = GetObjLstCache();
IEnumerable <clsvThesisEN> arrvThesisObjLst_Sel =
arrvThesisObjLstCache
.Where(x=> x.ThesisId == strThesisId 
);
if (arrvThesisObjLst_Sel.Count() == 0)
{
   clsvThesisEN obj = clsvThesisBL.GetObjByThesisId(strThesisId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvThesisObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strThesisId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOperationTypeNameByThesisIdCache(string strThesisId)
{
if (string.IsNullOrEmpty(strThesisId) == true) return "";
//获取缓存中的对象列表
clsvThesisEN objvThesis = GetObjByThesisIdCache(strThesisId);
if (objvThesis == null) return "";
return objvThesis.OperationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strThesisId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByThesisIdCache(string strThesisId)
{
if (string.IsNullOrEmpty(strThesisId) == true) return "";
//获取缓存中的对象列表
clsvThesisEN objvThesis = GetObjByThesisIdCache(strThesisId);
if (objvThesis == null) return "";
return objvThesis.OperationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvThesisEN> GetAllvThesisObjLstCache()
{
//获取缓存中的对象列表
List<clsvThesisEN> arrvThesisObjLstCache = GetObjLstCache(); 
return arrvThesisObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvThesisEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvThesisEN._CurrTabName);
List<clsvThesisEN> arrvThesisObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvThesisObjLstCache;
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
string strKey = string.Format("{0}", clsvThesisEN._CurrTabName);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strThesisId)
{
if (strInFldName != convThesis.ThesisId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convThesis.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convThesis.AttributeName));
throw new Exception(strMsg);
}
var objvThesis = clsvThesisBL.GetObjByThesisIdCache(strThesisId);
if (objvThesis == null) return "";
return objvThesis[strOutFldName].ToString();
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
int intRecCount = clsvThesisDA.GetRecCount(strTabName);
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
int intRecCount = clsvThesisDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvThesisDA.GetRecCount();
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
int intRecCount = clsvThesisDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvThesisCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvThesisEN objvThesisCond)
{
List<clsvThesisEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvThesisEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convThesis.AttributeName)
{
if (objvThesisCond.IsUpdated(strFldName) == false) continue;
if (objvThesisCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvThesisCond[strFldName].ToString());
}
else
{
if (objvThesisCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvThesisCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvThesisCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvThesisCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvThesisCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvThesisCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvThesisCond[strFldName]));
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
 List<string> arrList = clsvThesisDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vThesisDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vThesisDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}