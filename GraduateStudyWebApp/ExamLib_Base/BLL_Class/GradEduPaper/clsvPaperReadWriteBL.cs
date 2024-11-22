
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperReadWriteBL
 表名:vPaperReadWrite(01120550)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:04:46
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
public static class  clsvPaperReadWriteBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperRWId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperReadWriteEN GetObj(this K_PaperRWId_vPaperReadWrite myKey)
{
clsvPaperReadWriteEN objvPaperReadWriteEN = clsvPaperReadWriteBL.vPaperReadWriteDA.GetObjByPaperRWId(myKey.Value);
return objvPaperReadWriteEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetPaperRWId(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, convPaperReadWrite.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, convPaperReadWrite.PaperRWId);
}
objvPaperReadWriteEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.PaperRWId) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.PaperRWId, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.PaperRWId] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetReaderId(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strReaderId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReaderId, 20, convPaperReadWrite.ReaderId);
}
objvPaperReadWriteEN.ReaderId = strReaderId; //阅读者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.ReaderId) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.ReaderId, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.ReaderId] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetPaperId(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperReadWrite.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperReadWrite.PaperId);
}
objvPaperReadWriteEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.PaperId) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.PaperId, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.PaperId] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetPaperTitle(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperReadWrite.PaperTitle);
}
objvPaperReadWriteEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.PaperTitle) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.PaperTitle, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.PaperTitle] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetPaperContent(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strPaperContent, string strComparisonOp="")
	{
objvPaperReadWriteEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.PaperContent) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.PaperContent, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.PaperContent] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetPeriodical(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convPaperReadWrite.Periodical);
}
objvPaperReadWriteEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.Periodical) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.Periodical, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.Periodical] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetAuthor(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperReadWrite.Author);
}
objvPaperReadWriteEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.Author) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.Author, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.Author] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetKeyword(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperReadWrite.Keyword);
}
objvPaperReadWriteEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.Keyword) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.Keyword, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.Keyword] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetResearchQuestion(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convPaperReadWrite.ResearchQuestion);
}
objvPaperReadWriteEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.ResearchQuestion) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.ResearchQuestion, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.ResearchQuestion] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetOperationTypeId(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strOperationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeId, convPaperReadWrite.OperationTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convPaperReadWrite.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convPaperReadWrite.OperationTypeId);
}
objvPaperReadWriteEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.OperationTypeId) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.OperationTypeId, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.OperationTypeId] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetOperationTypeName(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strOperationTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOperationTypeName, convPaperReadWrite.OperationTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convPaperReadWrite.OperationTypeName);
}
objvPaperReadWriteEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.OperationTypeName) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.OperationTypeName, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.OperationTypeName] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetUpdDate(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperReadWrite.UpdDate);
}
objvPaperReadWriteEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.UpdDate) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.UpdDate, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.UpdDate] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetMemo(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperReadWrite.Memo);
}
objvPaperReadWriteEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.Memo) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.Memo, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.Memo] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetLiteratureLink(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convPaperReadWrite.LiteratureLink);
}
objvPaperReadWriteEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.LiteratureLink) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.LiteratureLink, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.LiteratureLink] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetLiteratureSources(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convPaperReadWrite.LiteratureSources);
}
objvPaperReadWriteEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.LiteratureSources) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.LiteratureSources, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.LiteratureSources] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetLiteratureTypeId(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strLiteratureTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, convPaperReadWrite.LiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, convPaperReadWrite.LiteratureTypeId);
}
objvPaperReadWriteEN.LiteratureTypeId = strLiteratureTypeId; //作文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.LiteratureTypeId) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.LiteratureTypeId, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.LiteratureTypeId] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetLiteratureTypeName(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strLiteratureTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeName, 100, convPaperReadWrite.LiteratureTypeName);
}
objvPaperReadWriteEN.LiteratureTypeName = strLiteratureTypeName; //作文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.LiteratureTypeName) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.LiteratureTypeName, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.LiteratureTypeName] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetUploadfileUrl(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convPaperReadWrite.UploadfileUrl);
}
objvPaperReadWriteEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.UploadfileUrl) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.UploadfileUrl, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.UploadfileUrl] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetIsPublic(this clsvPaperReadWriteEN objvPaperReadWriteEN, bool bolIsPublic, string strComparisonOp="")
	{
objvPaperReadWriteEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.IsPublic) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.IsPublic, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.IsPublic] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetIsSubmit(this clsvPaperReadWriteEN objvPaperReadWriteEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvPaperReadWriteEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.IsSubmit) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.IsSubmit, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.IsSubmit] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetSubmitter(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strSubmitter, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubmitter, 50, convPaperReadWrite.Submitter);
}
objvPaperReadWriteEN.Submitter = strSubmitter; //提交人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.Submitter) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.Submitter, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.Submitter] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetPcount(this clsvPaperReadWriteEN objvPaperReadWriteEN, int? intPcount, string strComparisonOp="")
	{
objvPaperReadWriteEN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.Pcount) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.Pcount, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.Pcount] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetTeaCount(this clsvPaperReadWriteEN objvPaperReadWriteEN, int? intTeaCount, string strComparisonOp="")
	{
objvPaperReadWriteEN.TeaCount = intTeaCount; //TeaCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.TeaCount) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.TeaCount, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.TeaCount] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetIdCurrEduCls(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convPaperReadWrite.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convPaperReadWrite.IdCurrEduCls);
}
objvPaperReadWriteEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.IdCurrEduCls) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.IdCurrEduCls, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.IdCurrEduCls] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetSubVCount(this clsvPaperReadWriteEN objvPaperReadWriteEN, int? intSubVCount, string strComparisonOp="")
	{
objvPaperReadWriteEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.SubVCount) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.SubVCount, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.SubVCount] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetCreateDate(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convPaperReadWrite.CreateDate);
}
objvPaperReadWriteEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.CreateDate) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.CreateDate, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.CreateDate] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetShareId(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convPaperReadWrite.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convPaperReadWrite.ShareId);
}
objvPaperReadWriteEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.ShareId) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.ShareId, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.ShareId] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperReadWriteEN SetUpdUser(this clsvPaperReadWriteEN objvPaperReadWriteEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperReadWrite.UpdUser);
}
objvPaperReadWriteEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperReadWriteEN.dicFldComparisonOp.ContainsKey(convPaperReadWrite.UpdUser) == false)
{
objvPaperReadWriteEN.dicFldComparisonOp.Add(convPaperReadWrite.UpdUser, strComparisonOp);
}
else
{
objvPaperReadWriteEN.dicFldComparisonOp[convPaperReadWrite.UpdUser] = strComparisonOp;
}
}
return objvPaperReadWriteEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperReadWriteENS">源对象</param>
 /// <param name = "objvPaperReadWriteENT">目标对象</param>
 public static void CopyTo(this clsvPaperReadWriteEN objvPaperReadWriteENS, clsvPaperReadWriteEN objvPaperReadWriteENT)
{
try
{
objvPaperReadWriteENT.PaperRWId = objvPaperReadWriteENS.PaperRWId; //课文阅读
objvPaperReadWriteENT.ReaderId = objvPaperReadWriteENS.ReaderId; //阅读者Id
objvPaperReadWriteENT.PaperId = objvPaperReadWriteENS.PaperId; //论文Id
objvPaperReadWriteENT.PaperTitle = objvPaperReadWriteENS.PaperTitle; //论文标题
objvPaperReadWriteENT.PaperContent = objvPaperReadWriteENS.PaperContent; //主题内容
objvPaperReadWriteENT.Periodical = objvPaperReadWriteENS.Periodical; //期刊
objvPaperReadWriteENT.Author = objvPaperReadWriteENS.Author; //作者
objvPaperReadWriteENT.Keyword = objvPaperReadWriteENS.Keyword; //关键字
objvPaperReadWriteENT.ResearchQuestion = objvPaperReadWriteENS.ResearchQuestion; //研究问题
objvPaperReadWriteENT.OperationTypeId = objvPaperReadWriteENS.OperationTypeId; //操作类型ID
objvPaperReadWriteENT.OperationTypeName = objvPaperReadWriteENS.OperationTypeName; //操作类型名
objvPaperReadWriteENT.UpdDate = objvPaperReadWriteENS.UpdDate; //修改日期
objvPaperReadWriteENT.Memo = objvPaperReadWriteENS.Memo; //备注
objvPaperReadWriteENT.LiteratureLink = objvPaperReadWriteENS.LiteratureLink; //文献链接
objvPaperReadWriteENT.LiteratureSources = objvPaperReadWriteENS.LiteratureSources; //文献来源
objvPaperReadWriteENT.LiteratureTypeId = objvPaperReadWriteENS.LiteratureTypeId; //作文类型Id
objvPaperReadWriteENT.LiteratureTypeName = objvPaperReadWriteENS.LiteratureTypeName; //作文类型名
objvPaperReadWriteENT.UploadfileUrl = objvPaperReadWriteENS.UploadfileUrl; //文件地址
objvPaperReadWriteENT.IsPublic = objvPaperReadWriteENS.IsPublic; //是否公开
objvPaperReadWriteENT.IsSubmit = objvPaperReadWriteENS.IsSubmit; //是否提交
objvPaperReadWriteENT.Submitter = objvPaperReadWriteENS.Submitter; //提交人
objvPaperReadWriteENT.Pcount = objvPaperReadWriteENS.Pcount; //读写数
objvPaperReadWriteENT.TeaCount = objvPaperReadWriteENS.TeaCount; //TeaCount
objvPaperReadWriteENT.IdCurrEduCls = objvPaperReadWriteENS.IdCurrEduCls; //教学班流水号
objvPaperReadWriteENT.SubVCount = objvPaperReadWriteENS.SubVCount; //论文子观点数
objvPaperReadWriteENT.CreateDate = objvPaperReadWriteENS.CreateDate; //建立日期
objvPaperReadWriteENT.ShareId = objvPaperReadWriteENS.ShareId; //分享Id
objvPaperReadWriteENT.UpdUser = objvPaperReadWriteENS.UpdUser; //修改人
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
 /// <param name = "objvPaperReadWriteENS">源对象</param>
 /// <returns>目标对象=>clsvPaperReadWriteEN:objvPaperReadWriteENT</returns>
 public static clsvPaperReadWriteEN CopyTo(this clsvPaperReadWriteEN objvPaperReadWriteENS)
{
try
{
 clsvPaperReadWriteEN objvPaperReadWriteENT = new clsvPaperReadWriteEN()
{
PaperRWId = objvPaperReadWriteENS.PaperRWId, //课文阅读
ReaderId = objvPaperReadWriteENS.ReaderId, //阅读者Id
PaperId = objvPaperReadWriteENS.PaperId, //论文Id
PaperTitle = objvPaperReadWriteENS.PaperTitle, //论文标题
PaperContent = objvPaperReadWriteENS.PaperContent, //主题内容
Periodical = objvPaperReadWriteENS.Periodical, //期刊
Author = objvPaperReadWriteENS.Author, //作者
Keyword = objvPaperReadWriteENS.Keyword, //关键字
ResearchQuestion = objvPaperReadWriteENS.ResearchQuestion, //研究问题
OperationTypeId = objvPaperReadWriteENS.OperationTypeId, //操作类型ID
OperationTypeName = objvPaperReadWriteENS.OperationTypeName, //操作类型名
UpdDate = objvPaperReadWriteENS.UpdDate, //修改日期
Memo = objvPaperReadWriteENS.Memo, //备注
LiteratureLink = objvPaperReadWriteENS.LiteratureLink, //文献链接
LiteratureSources = objvPaperReadWriteENS.LiteratureSources, //文献来源
LiteratureTypeId = objvPaperReadWriteENS.LiteratureTypeId, //作文类型Id
LiteratureTypeName = objvPaperReadWriteENS.LiteratureTypeName, //作文类型名
UploadfileUrl = objvPaperReadWriteENS.UploadfileUrl, //文件地址
IsPublic = objvPaperReadWriteENS.IsPublic, //是否公开
IsSubmit = objvPaperReadWriteENS.IsSubmit, //是否提交
Submitter = objvPaperReadWriteENS.Submitter, //提交人
Pcount = objvPaperReadWriteENS.Pcount, //读写数
TeaCount = objvPaperReadWriteENS.TeaCount, //TeaCount
IdCurrEduCls = objvPaperReadWriteENS.IdCurrEduCls, //教学班流水号
SubVCount = objvPaperReadWriteENS.SubVCount, //论文子观点数
CreateDate = objvPaperReadWriteENS.CreateDate, //建立日期
ShareId = objvPaperReadWriteENS.ShareId, //分享Id
UpdUser = objvPaperReadWriteENS.UpdUser, //修改人
};
 return objvPaperReadWriteENT;
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
public static void CheckProperty4Condition(this clsvPaperReadWriteEN objvPaperReadWriteEN)
{
 clsvPaperReadWriteBL.vPaperReadWriteDA.CheckProperty4Condition(objvPaperReadWriteEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperReadWriteEN objvPaperReadWriteCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.PaperRWId, objvPaperReadWriteCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.ReaderId) == true)
{
string strComparisonOpReaderId = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.ReaderId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.ReaderId, objvPaperReadWriteCond.ReaderId, strComparisonOpReaderId);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.PaperId, objvPaperReadWriteCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.PaperTitle, objvPaperReadWriteCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.Periodical) == true)
{
string strComparisonOpPeriodical = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.Periodical, objvPaperReadWriteCond.Periodical, strComparisonOpPeriodical);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.Author) == true)
{
string strComparisonOpAuthor = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.Author, objvPaperReadWriteCond.Author, strComparisonOpAuthor);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.Keyword) == true)
{
string strComparisonOpKeyword = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.Keyword, objvPaperReadWriteCond.Keyword, strComparisonOpKeyword);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.ResearchQuestion, objvPaperReadWriteCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.OperationTypeId, objvPaperReadWriteCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.OperationTypeName, objvPaperReadWriteCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.UpdDate, objvPaperReadWriteCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.Memo) == true)
{
string strComparisonOpMemo = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.Memo, objvPaperReadWriteCond.Memo, strComparisonOpMemo);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.LiteratureLink, objvPaperReadWriteCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.LiteratureSources, objvPaperReadWriteCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.LiteratureTypeId) == true)
{
string strComparisonOpLiteratureTypeId = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.LiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.LiteratureTypeId, objvPaperReadWriteCond.LiteratureTypeId, strComparisonOpLiteratureTypeId);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.LiteratureTypeName) == true)
{
string strComparisonOpLiteratureTypeName = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.LiteratureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.LiteratureTypeName, objvPaperReadWriteCond.LiteratureTypeName, strComparisonOpLiteratureTypeName);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.UploadfileUrl, objvPaperReadWriteCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.IsPublic) == true)
{
if (objvPaperReadWriteCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperReadWrite.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperReadWrite.IsPublic);
}
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.IsSubmit) == true)
{
if (objvPaperReadWriteCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperReadWrite.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperReadWrite.IsSubmit);
}
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.Submitter) == true)
{
string strComparisonOpSubmitter = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.Submitter];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.Submitter, objvPaperReadWriteCond.Submitter, strComparisonOpSubmitter);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.Pcount) == true)
{
string strComparisonOpPcount = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperReadWrite.Pcount, objvPaperReadWriteCond.Pcount, strComparisonOpPcount);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.TeaCount) == true)
{
string strComparisonOpTeaCount = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.TeaCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperReadWrite.TeaCount, objvPaperReadWriteCond.TeaCount, strComparisonOpTeaCount);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.IdCurrEduCls, objvPaperReadWriteCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.SubVCount) == true)
{
string strComparisonOpSubVCount = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperReadWrite.SubVCount, objvPaperReadWriteCond.SubVCount, strComparisonOpSubVCount);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.CreateDate) == true)
{
string strComparisonOpCreateDate = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.CreateDate, objvPaperReadWriteCond.CreateDate, strComparisonOpCreateDate);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.ShareId) == true)
{
string strComparisonOpShareId = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.ShareId, objvPaperReadWriteCond.ShareId, strComparisonOpShareId);
}
if (objvPaperReadWriteCond.IsUpdated(convPaperReadWrite.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperReadWriteCond.dicFldComparisonOp[convPaperReadWrite.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperReadWrite.UpdUser, objvPaperReadWriteCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperReadWrite
{
public virtual bool UpdRelaTabDate(string strPaperRWId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v论文读写表(vPaperReadWrite)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperReadWriteBL
{
public static RelatedActions_vPaperReadWrite relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperReadWriteDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperReadWriteDA vPaperReadWriteDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperReadWriteDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperReadWriteBL()
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
if (string.IsNullOrEmpty(clsvPaperReadWriteEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperReadWriteEN._ConnectString);
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
public static DataTable GetDataTable_vPaperReadWrite(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperReadWriteDA.GetDataTable_vPaperReadWrite(strWhereCond);
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
objDT = vPaperReadWriteDA.GetDataTable(strWhereCond);
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
objDT = vPaperReadWriteDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperReadWriteDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperReadWriteDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperReadWriteDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperReadWriteDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperReadWriteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperReadWriteDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperRWIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperReadWriteEN> GetObjLstByPaperRWIdLst(List<string> arrPaperRWIdLst)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperRWIdLst, true);
 string strWhereCond = string.Format("PaperRWId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperRWIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperReadWriteEN> GetObjLstByPaperRWIdLstCache(List<string> arrPaperRWIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
List<clsvPaperReadWriteEN> arrvPaperReadWriteObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperReadWriteEN> arrvPaperReadWriteObjLst_Sel =
arrvPaperReadWriteObjLstCache
.Where(x => arrPaperRWIdLst.Contains(x.PaperRWId));
return arrvPaperReadWriteObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperReadWriteEN> GetObjLst(string strWhereCond)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
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
public static List<clsvPaperReadWriteEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperReadWriteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperReadWriteEN> GetSubObjLstCache(clsvPaperReadWriteEN objvPaperReadWriteCond)
{
 string strIdCurrEduCls = objvPaperReadWriteCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPaperReadWriteBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPaperReadWriteEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperReadWriteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperReadWrite.AttributeName)
{
if (objvPaperReadWriteCond.IsUpdated(strFldName) == false) continue;
if (objvPaperReadWriteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperReadWriteCond[strFldName].ToString());
}
else
{
if (objvPaperReadWriteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperReadWriteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperReadWriteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperReadWriteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperReadWriteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperReadWriteCond[strFldName]));
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
public static List<clsvPaperReadWriteEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
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
public static List<clsvPaperReadWriteEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
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
List<clsvPaperReadWriteEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperReadWriteEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperReadWriteEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperReadWriteEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
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
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
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
public static List<clsvPaperReadWriteEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperReadWriteEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperReadWriteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
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
public static List<clsvPaperReadWriteEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperReadWriteEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperReadWriteEN> arrObjLst = new List<clsvPaperReadWriteEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN();
try
{
objvPaperReadWriteEN.PaperRWId = objRow[convPaperReadWrite.PaperRWId].ToString().Trim(); //课文阅读
objvPaperReadWriteEN.ReaderId = objRow[convPaperReadWrite.ReaderId] == DBNull.Value ? null : objRow[convPaperReadWrite.ReaderId].ToString().Trim(); //阅读者Id
objvPaperReadWriteEN.PaperId = objRow[convPaperReadWrite.PaperId] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperId].ToString().Trim(); //论文Id
objvPaperReadWriteEN.PaperTitle = objRow[convPaperReadWrite.PaperTitle] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperTitle].ToString().Trim(); //论文标题
objvPaperReadWriteEN.PaperContent = objRow[convPaperReadWrite.PaperContent] == DBNull.Value ? null : objRow[convPaperReadWrite.PaperContent].ToString().Trim(); //主题内容
objvPaperReadWriteEN.Periodical = objRow[convPaperReadWrite.Periodical] == DBNull.Value ? null : objRow[convPaperReadWrite.Periodical].ToString().Trim(); //期刊
objvPaperReadWriteEN.Author = objRow[convPaperReadWrite.Author] == DBNull.Value ? null : objRow[convPaperReadWrite.Author].ToString().Trim(); //作者
objvPaperReadWriteEN.Keyword = objRow[convPaperReadWrite.Keyword] == DBNull.Value ? null : objRow[convPaperReadWrite.Keyword].ToString().Trim(); //关键字
objvPaperReadWriteEN.ResearchQuestion = objRow[convPaperReadWrite.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperReadWrite.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperReadWriteEN.OperationTypeId = objRow[convPaperReadWrite.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperReadWriteEN.OperationTypeName = objRow[convPaperReadWrite.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperReadWriteEN.UpdDate = objRow[convPaperReadWrite.UpdDate] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdDate].ToString().Trim(); //修改日期
objvPaperReadWriteEN.Memo = objRow[convPaperReadWrite.Memo] == DBNull.Value ? null : objRow[convPaperReadWrite.Memo].ToString().Trim(); //备注
objvPaperReadWriteEN.LiteratureLink = objRow[convPaperReadWrite.LiteratureLink] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureLink].ToString().Trim(); //文献链接
objvPaperReadWriteEN.LiteratureSources = objRow[convPaperReadWrite.LiteratureSources] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureSources].ToString().Trim(); //文献来源
objvPaperReadWriteEN.LiteratureTypeId = objRow[convPaperReadWrite.LiteratureTypeId] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperReadWriteEN.LiteratureTypeName = objRow[convPaperReadWrite.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperReadWrite.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperReadWriteEN.UploadfileUrl = objRow[convPaperReadWrite.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperReadWrite.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperReadWriteEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsPublic].ToString().Trim()); //是否公开
objvPaperReadWriteEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperReadWrite.IsSubmit].ToString().Trim()); //是否提交
objvPaperReadWriteEN.Submitter = objRow[convPaperReadWrite.Submitter] == DBNull.Value ? null : objRow[convPaperReadWrite.Submitter].ToString().Trim(); //提交人
objvPaperReadWriteEN.Pcount = objRow[convPaperReadWrite.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.Pcount].ToString().Trim()); //读写数
objvPaperReadWriteEN.TeaCount = objRow[convPaperReadWrite.TeaCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.TeaCount].ToString().Trim()); //TeaCount
objvPaperReadWriteEN.IdCurrEduCls = objRow[convPaperReadWrite.IdCurrEduCls] == DBNull.Value ? null : objRow[convPaperReadWrite.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperReadWriteEN.SubVCount = objRow[convPaperReadWrite.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperReadWrite.SubVCount].ToString().Trim()); //论文子观点数
objvPaperReadWriteEN.CreateDate = objRow[convPaperReadWrite.CreateDate] == DBNull.Value ? null : objRow[convPaperReadWrite.CreateDate].ToString().Trim(); //建立日期
objvPaperReadWriteEN.ShareId = objRow[convPaperReadWrite.ShareId] == DBNull.Value ? null : objRow[convPaperReadWrite.ShareId].ToString().Trim(); //分享Id
objvPaperReadWriteEN.UpdUser = objRow[convPaperReadWrite.UpdUser] == DBNull.Value ? null : objRow[convPaperReadWrite.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperReadWriteEN.PaperRWId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperReadWriteEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperReadWriteEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperReadWrite(ref clsvPaperReadWriteEN objvPaperReadWriteEN)
{
bool bolResult = vPaperReadWriteDA.GetvPaperReadWrite(ref objvPaperReadWriteEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperRWId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperReadWriteEN GetObjByPaperRWId(string strPaperRWId)
{
if (strPaperRWId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPaperRWId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPaperRWId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPaperRWId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPaperReadWriteEN objvPaperReadWriteEN = vPaperReadWriteDA.GetObjByPaperRWId(strPaperRWId);
return objvPaperReadWriteEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperReadWriteEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperReadWriteEN objvPaperReadWriteEN = vPaperReadWriteDA.GetFirstObj(strWhereCond);
 return objvPaperReadWriteEN;
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
public static clsvPaperReadWriteEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperReadWriteEN objvPaperReadWriteEN = vPaperReadWriteDA.GetObjByDataRow(objRow);
 return objvPaperReadWriteEN;
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
public static clsvPaperReadWriteEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperReadWriteEN objvPaperReadWriteEN = vPaperReadWriteDA.GetObjByDataRow(objRow);
 return objvPaperReadWriteEN;
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
 /// <param name = "strPaperRWId">所给的关键字</param>
 /// <param name = "lstvPaperReadWriteObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperReadWriteEN GetObjByPaperRWIdFromList(string strPaperRWId, List<clsvPaperReadWriteEN> lstvPaperReadWriteObjLst)
{
foreach (clsvPaperReadWriteEN objvPaperReadWriteEN in lstvPaperReadWriteObjLst)
{
if (objvPaperReadWriteEN.PaperRWId == strPaperRWId)
{
return objvPaperReadWriteEN;
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
 string strMaxPaperRWId;
 try
 {
 strMaxPaperRWId = clsvPaperReadWriteDA.GetMaxStrId();
 return strMaxPaperRWId;
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
 string strPaperRWId;
 try
 {
 strPaperRWId = new clsvPaperReadWriteDA().GetFirstID(strWhereCond);
 return strPaperRWId;
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
 arrList = vPaperReadWriteDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperReadWriteDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPaperRWId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPaperRWId)
{
if (string.IsNullOrEmpty(strPaperRWId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPaperRWId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPaperReadWriteDA.IsExist(strPaperRWId);
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
 bolIsExist = clsvPaperReadWriteDA.IsExistTable();
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
 bolIsExist = vPaperReadWriteDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperReadWriteENS">源对象</param>
 /// <param name = "objvPaperReadWriteENT">目标对象</param>
 public static void CopyTo(clsvPaperReadWriteEN objvPaperReadWriteENS, clsvPaperReadWriteEN objvPaperReadWriteENT)
{
try
{
objvPaperReadWriteENT.PaperRWId = objvPaperReadWriteENS.PaperRWId; //课文阅读
objvPaperReadWriteENT.ReaderId = objvPaperReadWriteENS.ReaderId; //阅读者Id
objvPaperReadWriteENT.PaperId = objvPaperReadWriteENS.PaperId; //论文Id
objvPaperReadWriteENT.PaperTitle = objvPaperReadWriteENS.PaperTitle; //论文标题
objvPaperReadWriteENT.PaperContent = objvPaperReadWriteENS.PaperContent; //主题内容
objvPaperReadWriteENT.Periodical = objvPaperReadWriteENS.Periodical; //期刊
objvPaperReadWriteENT.Author = objvPaperReadWriteENS.Author; //作者
objvPaperReadWriteENT.Keyword = objvPaperReadWriteENS.Keyword; //关键字
objvPaperReadWriteENT.ResearchQuestion = objvPaperReadWriteENS.ResearchQuestion; //研究问题
objvPaperReadWriteENT.OperationTypeId = objvPaperReadWriteENS.OperationTypeId; //操作类型ID
objvPaperReadWriteENT.OperationTypeName = objvPaperReadWriteENS.OperationTypeName; //操作类型名
objvPaperReadWriteENT.UpdDate = objvPaperReadWriteENS.UpdDate; //修改日期
objvPaperReadWriteENT.Memo = objvPaperReadWriteENS.Memo; //备注
objvPaperReadWriteENT.LiteratureLink = objvPaperReadWriteENS.LiteratureLink; //文献链接
objvPaperReadWriteENT.LiteratureSources = objvPaperReadWriteENS.LiteratureSources; //文献来源
objvPaperReadWriteENT.LiteratureTypeId = objvPaperReadWriteENS.LiteratureTypeId; //作文类型Id
objvPaperReadWriteENT.LiteratureTypeName = objvPaperReadWriteENS.LiteratureTypeName; //作文类型名
objvPaperReadWriteENT.UploadfileUrl = objvPaperReadWriteENS.UploadfileUrl; //文件地址
objvPaperReadWriteENT.IsPublic = objvPaperReadWriteENS.IsPublic; //是否公开
objvPaperReadWriteENT.IsSubmit = objvPaperReadWriteENS.IsSubmit; //是否提交
objvPaperReadWriteENT.Submitter = objvPaperReadWriteENS.Submitter; //提交人
objvPaperReadWriteENT.Pcount = objvPaperReadWriteENS.Pcount; //读写数
objvPaperReadWriteENT.TeaCount = objvPaperReadWriteENS.TeaCount; //TeaCount
objvPaperReadWriteENT.IdCurrEduCls = objvPaperReadWriteENS.IdCurrEduCls; //教学班流水号
objvPaperReadWriteENT.SubVCount = objvPaperReadWriteENS.SubVCount; //论文子观点数
objvPaperReadWriteENT.CreateDate = objvPaperReadWriteENS.CreateDate; //建立日期
objvPaperReadWriteENT.ShareId = objvPaperReadWriteENS.ShareId; //分享Id
objvPaperReadWriteENT.UpdUser = objvPaperReadWriteENS.UpdUser; //修改人
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
 /// <param name = "objvPaperReadWriteEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperReadWriteEN objvPaperReadWriteEN)
{
try
{
objvPaperReadWriteEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperReadWriteEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperReadWrite.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.PaperRWId = objvPaperReadWriteEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(convPaperReadWrite.ReaderId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.ReaderId = objvPaperReadWriteEN.ReaderId == "[null]" ? null :  objvPaperReadWriteEN.ReaderId; //阅读者Id
}
if (arrFldSet.Contains(convPaperReadWrite.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.PaperId = objvPaperReadWriteEN.PaperId == "[null]" ? null :  objvPaperReadWriteEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperReadWrite.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.PaperTitle = objvPaperReadWriteEN.PaperTitle == "[null]" ? null :  objvPaperReadWriteEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperReadWrite.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.PaperContent = objvPaperReadWriteEN.PaperContent == "[null]" ? null :  objvPaperReadWriteEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convPaperReadWrite.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.Periodical = objvPaperReadWriteEN.Periodical == "[null]" ? null :  objvPaperReadWriteEN.Periodical; //期刊
}
if (arrFldSet.Contains(convPaperReadWrite.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.Author = objvPaperReadWriteEN.Author == "[null]" ? null :  objvPaperReadWriteEN.Author; //作者
}
if (arrFldSet.Contains(convPaperReadWrite.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.Keyword = objvPaperReadWriteEN.Keyword == "[null]" ? null :  objvPaperReadWriteEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPaperReadWrite.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.ResearchQuestion = objvPaperReadWriteEN.ResearchQuestion == "[null]" ? null :  objvPaperReadWriteEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convPaperReadWrite.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.OperationTypeId = objvPaperReadWriteEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convPaperReadWrite.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.OperationTypeName = objvPaperReadWriteEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convPaperReadWrite.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.UpdDate = objvPaperReadWriteEN.UpdDate == "[null]" ? null :  objvPaperReadWriteEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperReadWrite.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.Memo = objvPaperReadWriteEN.Memo == "[null]" ? null :  objvPaperReadWriteEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperReadWrite.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.LiteratureLink = objvPaperReadWriteEN.LiteratureLink == "[null]" ? null :  objvPaperReadWriteEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convPaperReadWrite.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.LiteratureSources = objvPaperReadWriteEN.LiteratureSources == "[null]" ? null :  objvPaperReadWriteEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convPaperReadWrite.LiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.LiteratureTypeId = objvPaperReadWriteEN.LiteratureTypeId == "[null]" ? null :  objvPaperReadWriteEN.LiteratureTypeId; //作文类型Id
}
if (arrFldSet.Contains(convPaperReadWrite.LiteratureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.LiteratureTypeName = objvPaperReadWriteEN.LiteratureTypeName == "[null]" ? null :  objvPaperReadWriteEN.LiteratureTypeName; //作文类型名
}
if (arrFldSet.Contains(convPaperReadWrite.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.UploadfileUrl = objvPaperReadWriteEN.UploadfileUrl == "[null]" ? null :  objvPaperReadWriteEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convPaperReadWrite.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.IsPublic = objvPaperReadWriteEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convPaperReadWrite.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.IsSubmit = objvPaperReadWriteEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convPaperReadWrite.Submitter, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.Submitter = objvPaperReadWriteEN.Submitter == "[null]" ? null :  objvPaperReadWriteEN.Submitter; //提交人
}
if (arrFldSet.Contains(convPaperReadWrite.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.Pcount = objvPaperReadWriteEN.Pcount; //读写数
}
if (arrFldSet.Contains(convPaperReadWrite.TeaCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.TeaCount = objvPaperReadWriteEN.TeaCount; //TeaCount
}
if (arrFldSet.Contains(convPaperReadWrite.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.IdCurrEduCls = objvPaperReadWriteEN.IdCurrEduCls == "[null]" ? null :  objvPaperReadWriteEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convPaperReadWrite.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.SubVCount = objvPaperReadWriteEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convPaperReadWrite.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.CreateDate = objvPaperReadWriteEN.CreateDate == "[null]" ? null :  objvPaperReadWriteEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convPaperReadWrite.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.ShareId = objvPaperReadWriteEN.ShareId == "[null]" ? null :  objvPaperReadWriteEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convPaperReadWrite.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperReadWriteEN.UpdUser = objvPaperReadWriteEN.UpdUser == "[null]" ? null :  objvPaperReadWriteEN.UpdUser; //修改人
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
 /// <param name = "objvPaperReadWriteEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperReadWriteEN objvPaperReadWriteEN)
{
try
{
if (objvPaperReadWriteEN.ReaderId == "[null]") objvPaperReadWriteEN.ReaderId = null; //阅读者Id
if (objvPaperReadWriteEN.PaperId == "[null]") objvPaperReadWriteEN.PaperId = null; //论文Id
if (objvPaperReadWriteEN.PaperTitle == "[null]") objvPaperReadWriteEN.PaperTitle = null; //论文标题
if (objvPaperReadWriteEN.PaperContent == "[null]") objvPaperReadWriteEN.PaperContent = null; //主题内容
if (objvPaperReadWriteEN.Periodical == "[null]") objvPaperReadWriteEN.Periodical = null; //期刊
if (objvPaperReadWriteEN.Author == "[null]") objvPaperReadWriteEN.Author = null; //作者
if (objvPaperReadWriteEN.Keyword == "[null]") objvPaperReadWriteEN.Keyword = null; //关键字
if (objvPaperReadWriteEN.ResearchQuestion == "[null]") objvPaperReadWriteEN.ResearchQuestion = null; //研究问题
if (objvPaperReadWriteEN.UpdDate == "[null]") objvPaperReadWriteEN.UpdDate = null; //修改日期
if (objvPaperReadWriteEN.Memo == "[null]") objvPaperReadWriteEN.Memo = null; //备注
if (objvPaperReadWriteEN.LiteratureLink == "[null]") objvPaperReadWriteEN.LiteratureLink = null; //文献链接
if (objvPaperReadWriteEN.LiteratureSources == "[null]") objvPaperReadWriteEN.LiteratureSources = null; //文献来源
if (objvPaperReadWriteEN.LiteratureTypeId == "[null]") objvPaperReadWriteEN.LiteratureTypeId = null; //作文类型Id
if (objvPaperReadWriteEN.LiteratureTypeName == "[null]") objvPaperReadWriteEN.LiteratureTypeName = null; //作文类型名
if (objvPaperReadWriteEN.UploadfileUrl == "[null]") objvPaperReadWriteEN.UploadfileUrl = null; //文件地址
if (objvPaperReadWriteEN.Submitter == "[null]") objvPaperReadWriteEN.Submitter = null; //提交人
if (objvPaperReadWriteEN.IdCurrEduCls == "[null]") objvPaperReadWriteEN.IdCurrEduCls = null; //教学班流水号
if (objvPaperReadWriteEN.CreateDate == "[null]") objvPaperReadWriteEN.CreateDate = null; //建立日期
if (objvPaperReadWriteEN.ShareId == "[null]") objvPaperReadWriteEN.ShareId = null; //分享Id
if (objvPaperReadWriteEN.UpdUser == "[null]") objvPaperReadWriteEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvPaperReadWriteEN objvPaperReadWriteEN)
{
 vPaperReadWriteDA.CheckProperty4Condition(objvPaperReadWriteEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_PaperRWId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPaperReadWrite.PaperRWId); 
List<clsvPaperReadWriteEN> arrObjLst = clsvPaperReadWriteBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPaperReadWriteEN objvPaperReadWriteEN = new clsvPaperReadWriteEN()
{
PaperRWId = "0",
OperationTypeName = "选[v论文读写表]..."
};
arrObjLst.Insert(0, objvPaperReadWriteEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPaperReadWrite.PaperRWId;
objComboBox.DisplayMember = convPaperReadWrite.OperationTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_PaperRWId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v论文读写表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPaperReadWrite.PaperRWId); 
IEnumerable<clsvPaperReadWriteEN> arrObjLst = clsvPaperReadWriteBL.GetObjLst(strCondition);
objDDL.DataValueField = convPaperReadWrite.PaperRWId;
objDDL.DataTextField = convPaperReadWrite.OperationTypeName;
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
public static void BindDdl_PaperRWIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v论文读写表]...","0");
List<clsvPaperReadWriteEN> arrvPaperReadWriteObjLst = GetAllvPaperReadWriteObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = convPaperReadWrite.PaperRWId;
objDDL.DataTextField = convPaperReadWrite.OperationTypeName;
objDDL.DataSource = arrvPaperReadWriteObjLst;
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
if (clsOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsOperationTypeBL没有刷新缓存机制(clsOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperReadWriteBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperReadWriteBL没有刷新缓存机制(clsPaperReadWriteBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLiteratureTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsLiteratureTypeBL没有刷新缓存机制(clsLiteratureTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperTypeBL没有刷新缓存机制(clsgs_PaperTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperStatusBL没有刷新缓存机制(clsgs_PaperStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperRWId");
//if (arrvPaperReadWriteObjLstCache == null)
//{
//arrvPaperReadWriteObjLstCache = vPaperReadWriteDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperRWId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperReadWriteEN GetObjByPaperRWIdCache(string strPaperRWId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
List<clsvPaperReadWriteEN> arrvPaperReadWriteObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperReadWriteEN> arrvPaperReadWriteObjLst_Sel =
arrvPaperReadWriteObjLstCache
.Where(x=> x.PaperRWId == strPaperRWId 
);
if (arrvPaperReadWriteObjLst_Sel.Count() == 0)
{
   clsvPaperReadWriteEN obj = clsvPaperReadWriteBL.GetObjByPaperRWId(strPaperRWId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strPaperRWId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPaperReadWriteObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPaperRWId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOperationTypeNameByPaperRWIdCache(string strPaperRWId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strPaperRWId) == true) return "";
//获取缓存中的对象列表
clsvPaperReadWriteEN objvPaperReadWrite = GetObjByPaperRWIdCache(strPaperRWId, strIdCurrEduCls);
if (objvPaperReadWrite == null) return "";
return objvPaperReadWrite.OperationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPaperRWId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPaperRWIdCache(string strPaperRWId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strPaperRWId) == true) return "";
//获取缓存中的对象列表
clsvPaperReadWriteEN objvPaperReadWrite = GetObjByPaperRWIdCache(strPaperRWId, strIdCurrEduCls);
if (objvPaperReadWrite == null) return "";
return objvPaperReadWrite.OperationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperReadWriteEN> GetAllvPaperReadWriteObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvPaperReadWriteEN> arrvPaperReadWriteObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvPaperReadWriteObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperReadWriteEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvPaperReadWriteEN> arrvPaperReadWriteObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPaperReadWriteObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvPaperReadWriteEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strPaperRWId, string strIdCurrEduCls)
{
if (strInFldName != convPaperReadWrite.PaperRWId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperReadWrite.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperReadWrite.AttributeName));
throw new Exception(strMsg);
}
var objvPaperReadWrite = clsvPaperReadWriteBL.GetObjByPaperRWIdCache(strPaperRWId, strIdCurrEduCls);
if (objvPaperReadWrite == null) return "";
return objvPaperReadWrite[strOutFldName].ToString();
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
int intRecCount = clsvPaperReadWriteDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperReadWriteDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperReadWriteDA.GetRecCount();
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
int intRecCount = clsvPaperReadWriteDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperReadWriteCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperReadWriteEN objvPaperReadWriteCond)
{
 string strIdCurrEduCls = objvPaperReadWriteCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPaperReadWriteBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPaperReadWriteEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperReadWriteEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperReadWrite.AttributeName)
{
if (objvPaperReadWriteCond.IsUpdated(strFldName) == false) continue;
if (objvPaperReadWriteCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperReadWriteCond[strFldName].ToString());
}
else
{
if (objvPaperReadWriteCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperReadWriteCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperReadWriteCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperReadWriteCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperReadWriteCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperReadWriteCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperReadWriteCond[strFldName]));
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
 List<string> arrList = clsvPaperReadWriteDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperReadWriteDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperReadWriteDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}