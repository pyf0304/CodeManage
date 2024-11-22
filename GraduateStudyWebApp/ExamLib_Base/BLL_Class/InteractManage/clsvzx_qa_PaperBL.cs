
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_qa_PaperBL
 表名:vzx_qa_Paper(01120849)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clsvzx_qa_PaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strZxqaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_qa_PaperEN GetObj(this K_ZxqaPaperId_vzx_qa_Paper myKey)
{
clsvzx_qa_PaperEN objvzx_qa_PaperEN = clsvzx_qa_PaperBL.vzx_qa_PaperDA.GetObjByZxqaPaperId(myKey.Value);
return objvzx_qa_PaperEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetUserName(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convzx_qa_Paper.UserName);
}
objvzx_qa_PaperEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.UserName) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.UserName, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.UserName] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetIdXzMajor(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convzx_qa_Paper.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convzx_qa_Paper.IdXzMajor);
}
objvzx_qa_PaperEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.IdXzMajor) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.IdXzMajor, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.IdXzMajor] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetMajorName(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convzx_qa_Paper.MajorName);
}
objvzx_qa_PaperEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.MajorName) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.MajorName, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.MajorName] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetTextTitle(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_qa_Paper.TextTitle);
}
objvzx_qa_PaperEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.TextTitle) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.TextTitle, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.TextTitle] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetTextContent(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strTextContent, string strComparisonOp="")
	{
objvzx_qa_PaperEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.TextContent) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.TextContent, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.TextContent] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetAuthor(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_qa_Paper.Author);
}
objvzx_qa_PaperEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.Author) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.Author, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.Author] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetResearchQuestion(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convzx_qa_Paper.ResearchQuestion);
}
objvzx_qa_PaperEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.ResearchQuestion) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.ResearchQuestion, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.ResearchQuestion] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetLiteratureSources(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convzx_qa_Paper.LiteratureSources);
}
objvzx_qa_PaperEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.LiteratureSources) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.LiteratureSources, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.LiteratureSources] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetLiteratureLink(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convzx_qa_Paper.LiteratureLink);
}
objvzx_qa_PaperEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.LiteratureLink) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.LiteratureLink, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.LiteratureLink] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetUploadfileUrl(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convzx_qa_Paper.UploadfileUrl);
}
objvzx_qa_PaperEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.UploadfileUrl) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.UploadfileUrl, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.UploadfileUrl] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetAttachmentCount(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvzx_qa_PaperEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.AttachmentCount) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.AttachmentCount, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.AttachmentCount] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetZxqaPaperId(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strZxqaPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strZxqaPaperId, 8, convzx_qa_Paper.ZxqaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strZxqaPaperId, 8, convzx_qa_Paper.ZxqaPaperId);
}
objvzx_qa_PaperEN.ZxqaPaperId = strZxqaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.ZxqaPaperId) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.ZxqaPaperId, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.ZxqaPaperId] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetQuestionsCount(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, int? intQuestionsCount, string strComparisonOp="")
	{
objvzx_qa_PaperEN.QuestionsCount = intQuestionsCount; //提问计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.QuestionsCount) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.QuestionsCount, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.QuestionsCount] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetTextId(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_qa_Paper.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_qa_Paper.TextId);
}
objvzx_qa_PaperEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.TextId) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.TextId, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.TextId] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetIsDelete(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, bool bolIsDelete, string strComparisonOp="")
	{
objvzx_qa_PaperEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.IsDelete) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.IsDelete, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.IsDelete] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetIsPublic(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, bool bolIsPublic, string strComparisonOp="")
	{
objvzx_qa_PaperEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.IsPublic) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.IsPublic, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.IsPublic] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetIsSubmit(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_qa_PaperEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.IsSubmit) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.IsSubmit, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.IsSubmit] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetUpdDate(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_qa_Paper.UpdDate);
}
objvzx_qa_PaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.UpdDate) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.UpdDate, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.UpdDate] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetUpdUser(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_qa_Paper.UpdUser);
}
objvzx_qa_PaperEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.UpdUser) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.UpdUser, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.UpdUser] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetMemo(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_qa_Paper.Memo);
}
objvzx_qa_PaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.Memo) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.Memo, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.Memo] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetIdCurrEduCls(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_qa_Paper.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_qa_Paper.IdCurrEduCls);
}
objvzx_qa_PaperEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.IdCurrEduCls) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetAnswerCount(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, int? intAnswerCount, string strComparisonOp="")
	{
objvzx_qa_PaperEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.AnswerCount) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.AnswerCount, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.AnswerCount] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetzxShareId(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_qa_Paper.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_qa_Paper.zxShareId);
}
objvzx_qa_PaperEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.zxShareId) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.zxShareId, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.zxShareId] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_qa_PaperEN SetTagsCount(this clsvzx_qa_PaperEN objvzx_qa_PaperEN, int? intTagsCount, string strComparisonOp="")
	{
objvzx_qa_PaperEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_qa_PaperEN.dicFldComparisonOp.ContainsKey(convzx_qa_Paper.TagsCount) == false)
{
objvzx_qa_PaperEN.dicFldComparisonOp.Add(convzx_qa_Paper.TagsCount, strComparisonOp);
}
else
{
objvzx_qa_PaperEN.dicFldComparisonOp[convzx_qa_Paper.TagsCount] = strComparisonOp;
}
}
return objvzx_qa_PaperEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_qa_PaperENS">源对象</param>
 /// <param name = "objvzx_qa_PaperENT">目标对象</param>
 public static void CopyTo(this clsvzx_qa_PaperEN objvzx_qa_PaperENS, clsvzx_qa_PaperEN objvzx_qa_PaperENT)
{
try
{
objvzx_qa_PaperENT.UserName = objvzx_qa_PaperENS.UserName; //用户名
objvzx_qa_PaperENT.IdXzMajor = objvzx_qa_PaperENS.IdXzMajor; //专业流水号
objvzx_qa_PaperENT.MajorName = objvzx_qa_PaperENS.MajorName; //专业名称
objvzx_qa_PaperENT.TextTitle = objvzx_qa_PaperENS.TextTitle; //TextTitle
objvzx_qa_PaperENT.TextContent = objvzx_qa_PaperENS.TextContent; //TextContent
objvzx_qa_PaperENT.Author = objvzx_qa_PaperENS.Author; //作者
objvzx_qa_PaperENT.ResearchQuestion = objvzx_qa_PaperENS.ResearchQuestion; //研究问题
objvzx_qa_PaperENT.LiteratureSources = objvzx_qa_PaperENS.LiteratureSources; //文献来源
objvzx_qa_PaperENT.LiteratureLink = objvzx_qa_PaperENS.LiteratureLink; //文献链接
objvzx_qa_PaperENT.UploadfileUrl = objvzx_qa_PaperENS.UploadfileUrl; //文件地址
objvzx_qa_PaperENT.AttachmentCount = objvzx_qa_PaperENS.AttachmentCount; //附件计数
objvzx_qa_PaperENT.ZxqaPaperId = objvzx_qa_PaperENS.ZxqaPaperId; //论文答疑Id
objvzx_qa_PaperENT.QuestionsCount = objvzx_qa_PaperENS.QuestionsCount; //提问计数
objvzx_qa_PaperENT.TextId = objvzx_qa_PaperENS.TextId; //课件Id
objvzx_qa_PaperENT.IsDelete = objvzx_qa_PaperENS.IsDelete; //是否删除
objvzx_qa_PaperENT.IsPublic = objvzx_qa_PaperENS.IsPublic; //是否公开
objvzx_qa_PaperENT.IsSubmit = objvzx_qa_PaperENS.IsSubmit; //是否提交
objvzx_qa_PaperENT.UpdDate = objvzx_qa_PaperENS.UpdDate; //修改日期
objvzx_qa_PaperENT.UpdUser = objvzx_qa_PaperENS.UpdUser; //修改人
objvzx_qa_PaperENT.Memo = objvzx_qa_PaperENS.Memo; //备注
objvzx_qa_PaperENT.IdCurrEduCls = objvzx_qa_PaperENS.IdCurrEduCls; //教学班流水号
objvzx_qa_PaperENT.AnswerCount = objvzx_qa_PaperENS.AnswerCount; //回答计数
objvzx_qa_PaperENT.zxShareId = objvzx_qa_PaperENS.zxShareId; //分享Id
objvzx_qa_PaperENT.TagsCount = objvzx_qa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objvzx_qa_PaperENS">源对象</param>
 /// <returns>目标对象=>clsvzx_qa_PaperEN:objvzx_qa_PaperENT</returns>
 public static clsvzx_qa_PaperEN CopyTo(this clsvzx_qa_PaperEN objvzx_qa_PaperENS)
{
try
{
 clsvzx_qa_PaperEN objvzx_qa_PaperENT = new clsvzx_qa_PaperEN()
{
UserName = objvzx_qa_PaperENS.UserName, //用户名
IdXzMajor = objvzx_qa_PaperENS.IdXzMajor, //专业流水号
MajorName = objvzx_qa_PaperENS.MajorName, //专业名称
TextTitle = objvzx_qa_PaperENS.TextTitle, //TextTitle
TextContent = objvzx_qa_PaperENS.TextContent, //TextContent
Author = objvzx_qa_PaperENS.Author, //作者
ResearchQuestion = objvzx_qa_PaperENS.ResearchQuestion, //研究问题
LiteratureSources = objvzx_qa_PaperENS.LiteratureSources, //文献来源
LiteratureLink = objvzx_qa_PaperENS.LiteratureLink, //文献链接
UploadfileUrl = objvzx_qa_PaperENS.UploadfileUrl, //文件地址
AttachmentCount = objvzx_qa_PaperENS.AttachmentCount, //附件计数
ZxqaPaperId = objvzx_qa_PaperENS.ZxqaPaperId, //论文答疑Id
QuestionsCount = objvzx_qa_PaperENS.QuestionsCount, //提问计数
TextId = objvzx_qa_PaperENS.TextId, //课件Id
IsDelete = objvzx_qa_PaperENS.IsDelete, //是否删除
IsPublic = objvzx_qa_PaperENS.IsPublic, //是否公开
IsSubmit = objvzx_qa_PaperENS.IsSubmit, //是否提交
UpdDate = objvzx_qa_PaperENS.UpdDate, //修改日期
UpdUser = objvzx_qa_PaperENS.UpdUser, //修改人
Memo = objvzx_qa_PaperENS.Memo, //备注
IdCurrEduCls = objvzx_qa_PaperENS.IdCurrEduCls, //教学班流水号
AnswerCount = objvzx_qa_PaperENS.AnswerCount, //回答计数
zxShareId = objvzx_qa_PaperENS.zxShareId, //分享Id
TagsCount = objvzx_qa_PaperENS.TagsCount, //论文标注数
};
 return objvzx_qa_PaperENT;
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
public static void CheckProperty4Condition(this clsvzx_qa_PaperEN objvzx_qa_PaperEN)
{
 clsvzx_qa_PaperBL.vzx_qa_PaperDA.CheckProperty4Condition(objvzx_qa_PaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_qa_PaperEN objvzx_qa_PaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.UserName) == true)
{
string strComparisonOpUserName = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.UserName, objvzx_qa_PaperCond.UserName, strComparisonOpUserName);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.IdXzMajor, objvzx_qa_PaperCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.MajorName) == true)
{
string strComparisonOpMajorName = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.MajorName, objvzx_qa_PaperCond.MajorName, strComparisonOpMajorName);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.TextTitle, objvzx_qa_PaperCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.Author) == true)
{
string strComparisonOpAuthor = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.Author, objvzx_qa_PaperCond.Author, strComparisonOpAuthor);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.ResearchQuestion, objvzx_qa_PaperCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.LiteratureSources, objvzx_qa_PaperCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.LiteratureLink, objvzx_qa_PaperCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.UploadfileUrl, objvzx_qa_PaperCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Paper.AttachmentCount, objvzx_qa_PaperCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.ZxqaPaperId) == true)
{
string strComparisonOpZxqaPaperId = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.ZxqaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.ZxqaPaperId, objvzx_qa_PaperCond.ZxqaPaperId, strComparisonOpZxqaPaperId);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.QuestionsCount) == true)
{
string strComparisonOpQuestionsCount = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Paper.QuestionsCount, objvzx_qa_PaperCond.QuestionsCount, strComparisonOpQuestionsCount);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.TextId) == true)
{
string strComparisonOpTextId = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.TextId, objvzx_qa_PaperCond.TextId, strComparisonOpTextId);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.IsDelete) == true)
{
if (objvzx_qa_PaperCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Paper.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Paper.IsDelete);
}
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.IsPublic) == true)
{
if (objvzx_qa_PaperCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Paper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Paper.IsPublic);
}
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.IsSubmit) == true)
{
if (objvzx_qa_PaperCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_qa_Paper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_qa_Paper.IsSubmit);
}
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.UpdDate, objvzx_qa_PaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.UpdUser, objvzx_qa_PaperCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.Memo) == true)
{
string strComparisonOpMemo = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.Memo, objvzx_qa_PaperCond.Memo, strComparisonOpMemo);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.IdCurrEduCls, objvzx_qa_PaperCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Paper.AnswerCount, objvzx_qa_PaperCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_qa_Paper.zxShareId, objvzx_qa_PaperCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_qa_PaperCond.IsUpdated(convzx_qa_Paper.TagsCount) == true)
{
string strComparisonOpTagsCount = objvzx_qa_PaperCond.dicFldComparisonOp[convzx_qa_Paper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_qa_Paper.TagsCount, objvzx_qa_PaperCond.TagsCount, strComparisonOpTagsCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_qa_Paper
{
public virtual bool UpdRelaTabDate(string strZxqaPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_qa_Paper(vzx_qa_Paper)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_qa_PaperBL
{
public static RelatedActions_vzx_qa_Paper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_qa_PaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_qa_PaperDA vzx_qa_PaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_qa_PaperDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_qa_PaperBL()
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
if (string.IsNullOrEmpty(clsvzx_qa_PaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_qa_PaperEN._ConnectString);
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
public static DataTable GetDataTable_vzx_qa_Paper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_qa_PaperDA.GetDataTable_vzx_qa_Paper(strWhereCond);
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
objDT = vzx_qa_PaperDA.GetDataTable(strWhereCond);
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
objDT = vzx_qa_PaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_qa_PaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_qa_PaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_qa_PaperDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_qa_PaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_qa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_qa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxqaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_qa_PaperEN> GetObjLstByZxqaPaperIdLst(List<string> arrZxqaPaperIdLst)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxqaPaperIdLst, true);
 string strWhereCond = string.Format("ZxqaPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxqaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_qa_PaperEN> GetObjLstByZxqaPaperIdLstCache(List<string> arrZxqaPaperIdLst)
{
string strKey = string.Format("{0}", clsvzx_qa_PaperEN._CurrTabName);
List<clsvzx_qa_PaperEN> arrvzx_qa_PaperObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PaperEN> arrvzx_qa_PaperObjLst_Sel =
arrvzx_qa_PaperObjLstCache
.Where(x => arrZxqaPaperIdLst.Contains(x.ZxqaPaperId));
return arrvzx_qa_PaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_qa_PaperEN> GetObjLst(string strWhereCond)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
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
public static List<clsvzx_qa_PaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_qa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_qa_PaperEN> GetSubObjLstCache(clsvzx_qa_PaperEN objvzx_qa_PaperCond)
{
List<clsvzx_qa_PaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_qa_Paper.AttributeName)
{
if (objvzx_qa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objvzx_qa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PaperCond[strFldName].ToString());
}
else
{
if (objvzx_qa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_qa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_qa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PaperCond[strFldName]));
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
public static List<clsvzx_qa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
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
public static List<clsvzx_qa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
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
List<clsvzx_qa_PaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_qa_PaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_qa_PaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_qa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
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
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
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
public static List<clsvzx_qa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_qa_PaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_qa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
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
public static List<clsvzx_qa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_qa_PaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_qa_PaperEN> arrObjLst = new List<clsvzx_qa_PaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_qa_PaperEN objvzx_qa_PaperEN = new clsvzx_qa_PaperEN();
try
{
objvzx_qa_PaperEN.UserName = objRow[convzx_qa_Paper.UserName] == DBNull.Value ? null : objRow[convzx_qa_Paper.UserName].ToString().Trim(); //用户名
objvzx_qa_PaperEN.IdXzMajor = objRow[convzx_qa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvzx_qa_PaperEN.MajorName = objRow[convzx_qa_Paper.MajorName] == DBNull.Value ? null : objRow[convzx_qa_Paper.MajorName].ToString().Trim(); //专业名称
objvzx_qa_PaperEN.TextTitle = objRow[convzx_qa_Paper.TextTitle] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextTitle].ToString().Trim(); //TextTitle
objvzx_qa_PaperEN.TextContent = objRow[convzx_qa_Paper.TextContent] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextContent].ToString().Trim(); //TextContent
objvzx_qa_PaperEN.Author = objRow[convzx_qa_Paper.Author] == DBNull.Value ? null : objRow[convzx_qa_Paper.Author].ToString().Trim(); //作者
objvzx_qa_PaperEN.ResearchQuestion = objRow[convzx_qa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_qa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_qa_PaperEN.LiteratureSources = objRow[convzx_qa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvzx_qa_PaperEN.LiteratureLink = objRow[convzx_qa_Paper.LiteratureLink] == DBNull.Value ? null : objRow[convzx_qa_Paper.LiteratureLink].ToString().Trim(); //文献链接
objvzx_qa_PaperEN.UploadfileUrl = objRow[convzx_qa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convzx_qa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvzx_qa_PaperEN.AttachmentCount = objRow[convzx_qa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvzx_qa_PaperEN.ZxqaPaperId = objRow[convzx_qa_Paper.ZxqaPaperId].ToString().Trim(); //论文答疑Id
objvzx_qa_PaperEN.QuestionsCount = objRow[convzx_qa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvzx_qa_PaperEN.TextId = objRow[convzx_qa_Paper.TextId] == DBNull.Value ? null : objRow[convzx_qa_Paper.TextId].ToString().Trim(); //课件Id
objvzx_qa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsDelete].ToString().Trim()); //是否删除
objvzx_qa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsPublic].ToString().Trim()); //是否公开
objvzx_qa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_qa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvzx_qa_PaperEN.UpdDate = objRow[convzx_qa_Paper.UpdDate] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdDate].ToString().Trim(); //修改日期
objvzx_qa_PaperEN.UpdUser = objRow[convzx_qa_Paper.UpdUser] == DBNull.Value ? null : objRow[convzx_qa_Paper.UpdUser].ToString().Trim(); //修改人
objvzx_qa_PaperEN.Memo = objRow[convzx_qa_Paper.Memo] == DBNull.Value ? null : objRow[convzx_qa_Paper.Memo].ToString().Trim(); //备注
objvzx_qa_PaperEN.IdCurrEduCls = objRow[convzx_qa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_qa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_qa_PaperEN.AnswerCount = objRow[convzx_qa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvzx_qa_PaperEN.zxShareId = objRow[convzx_qa_Paper.zxShareId] == DBNull.Value ? null : objRow[convzx_qa_Paper.zxShareId].ToString().Trim(); //分享Id
objvzx_qa_PaperEN.TagsCount = objRow[convzx_qa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_qa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_qa_PaperEN.ZxqaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_qa_PaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_qa_PaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_qa_Paper(ref clsvzx_qa_PaperEN objvzx_qa_PaperEN)
{
bool bolResult = vzx_qa_PaperDA.Getvzx_qa_Paper(ref objvzx_qa_PaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strZxqaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_qa_PaperEN GetObjByZxqaPaperId(string strZxqaPaperId)
{
if (strZxqaPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strZxqaPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strZxqaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strZxqaPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_qa_PaperEN objvzx_qa_PaperEN = vzx_qa_PaperDA.GetObjByZxqaPaperId(strZxqaPaperId);
return objvzx_qa_PaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_qa_PaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_qa_PaperEN objvzx_qa_PaperEN = vzx_qa_PaperDA.GetFirstObj(strWhereCond);
 return objvzx_qa_PaperEN;
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
public static clsvzx_qa_PaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_qa_PaperEN objvzx_qa_PaperEN = vzx_qa_PaperDA.GetObjByDataRow(objRow);
 return objvzx_qa_PaperEN;
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
public static clsvzx_qa_PaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_qa_PaperEN objvzx_qa_PaperEN = vzx_qa_PaperDA.GetObjByDataRow(objRow);
 return objvzx_qa_PaperEN;
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
 /// <param name = "strZxqaPaperId">所给的关键字</param>
 /// <param name = "lstvzx_qa_PaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_qa_PaperEN GetObjByZxqaPaperIdFromList(string strZxqaPaperId, List<clsvzx_qa_PaperEN> lstvzx_qa_PaperObjLst)
{
foreach (clsvzx_qa_PaperEN objvzx_qa_PaperEN in lstvzx_qa_PaperObjLst)
{
if (objvzx_qa_PaperEN.ZxqaPaperId == strZxqaPaperId)
{
return objvzx_qa_PaperEN;
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
 string strMaxZxqaPaperId;
 try
 {
 strMaxZxqaPaperId = clsvzx_qa_PaperDA.GetMaxStrId();
 return strMaxZxqaPaperId;
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
 string strZxqaPaperId;
 try
 {
 strZxqaPaperId = new clsvzx_qa_PaperDA().GetFirstID(strWhereCond);
 return strZxqaPaperId;
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
 arrList = vzx_qa_PaperDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_qa_PaperDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strZxqaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strZxqaPaperId)
{
if (string.IsNullOrEmpty(strZxqaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strZxqaPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_qa_PaperDA.IsExist(strZxqaPaperId);
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
 bolIsExist = clsvzx_qa_PaperDA.IsExistTable();
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
 bolIsExist = vzx_qa_PaperDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_qa_PaperENS">源对象</param>
 /// <param name = "objvzx_qa_PaperENT">目标对象</param>
 public static void CopyTo(clsvzx_qa_PaperEN objvzx_qa_PaperENS, clsvzx_qa_PaperEN objvzx_qa_PaperENT)
{
try
{
objvzx_qa_PaperENT.UserName = objvzx_qa_PaperENS.UserName; //用户名
objvzx_qa_PaperENT.IdXzMajor = objvzx_qa_PaperENS.IdXzMajor; //专业流水号
objvzx_qa_PaperENT.MajorName = objvzx_qa_PaperENS.MajorName; //专业名称
objvzx_qa_PaperENT.TextTitle = objvzx_qa_PaperENS.TextTitle; //TextTitle
objvzx_qa_PaperENT.TextContent = objvzx_qa_PaperENS.TextContent; //TextContent
objvzx_qa_PaperENT.Author = objvzx_qa_PaperENS.Author; //作者
objvzx_qa_PaperENT.ResearchQuestion = objvzx_qa_PaperENS.ResearchQuestion; //研究问题
objvzx_qa_PaperENT.LiteratureSources = objvzx_qa_PaperENS.LiteratureSources; //文献来源
objvzx_qa_PaperENT.LiteratureLink = objvzx_qa_PaperENS.LiteratureLink; //文献链接
objvzx_qa_PaperENT.UploadfileUrl = objvzx_qa_PaperENS.UploadfileUrl; //文件地址
objvzx_qa_PaperENT.AttachmentCount = objvzx_qa_PaperENS.AttachmentCount; //附件计数
objvzx_qa_PaperENT.ZxqaPaperId = objvzx_qa_PaperENS.ZxqaPaperId; //论文答疑Id
objvzx_qa_PaperENT.QuestionsCount = objvzx_qa_PaperENS.QuestionsCount; //提问计数
objvzx_qa_PaperENT.TextId = objvzx_qa_PaperENS.TextId; //课件Id
objvzx_qa_PaperENT.IsDelete = objvzx_qa_PaperENS.IsDelete; //是否删除
objvzx_qa_PaperENT.IsPublic = objvzx_qa_PaperENS.IsPublic; //是否公开
objvzx_qa_PaperENT.IsSubmit = objvzx_qa_PaperENS.IsSubmit; //是否提交
objvzx_qa_PaperENT.UpdDate = objvzx_qa_PaperENS.UpdDate; //修改日期
objvzx_qa_PaperENT.UpdUser = objvzx_qa_PaperENS.UpdUser; //修改人
objvzx_qa_PaperENT.Memo = objvzx_qa_PaperENS.Memo; //备注
objvzx_qa_PaperENT.IdCurrEduCls = objvzx_qa_PaperENS.IdCurrEduCls; //教学班流水号
objvzx_qa_PaperENT.AnswerCount = objvzx_qa_PaperENS.AnswerCount; //回答计数
objvzx_qa_PaperENT.zxShareId = objvzx_qa_PaperENS.zxShareId; //分享Id
objvzx_qa_PaperENT.TagsCount = objvzx_qa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objvzx_qa_PaperEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_qa_PaperEN objvzx_qa_PaperEN)
{
try
{
objvzx_qa_PaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_qa_PaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_qa_Paper.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.UserName = objvzx_qa_PaperEN.UserName == "[null]" ? null :  objvzx_qa_PaperEN.UserName; //用户名
}
if (arrFldSet.Contains(convzx_qa_Paper.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.IdXzMajor = objvzx_qa_PaperEN.IdXzMajor == "[null]" ? null :  objvzx_qa_PaperEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convzx_qa_Paper.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.MajorName = objvzx_qa_PaperEN.MajorName == "[null]" ? null :  objvzx_qa_PaperEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convzx_qa_Paper.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.TextTitle = objvzx_qa_PaperEN.TextTitle == "[null]" ? null :  objvzx_qa_PaperEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_qa_Paper.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.TextContent = objvzx_qa_PaperEN.TextContent == "[null]" ? null :  objvzx_qa_PaperEN.TextContent; //TextContent
}
if (arrFldSet.Contains(convzx_qa_Paper.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.Author = objvzx_qa_PaperEN.Author == "[null]" ? null :  objvzx_qa_PaperEN.Author; //作者
}
if (arrFldSet.Contains(convzx_qa_Paper.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.ResearchQuestion = objvzx_qa_PaperEN.ResearchQuestion == "[null]" ? null :  objvzx_qa_PaperEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convzx_qa_Paper.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.LiteratureSources = objvzx_qa_PaperEN.LiteratureSources == "[null]" ? null :  objvzx_qa_PaperEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convzx_qa_Paper.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.LiteratureLink = objvzx_qa_PaperEN.LiteratureLink == "[null]" ? null :  objvzx_qa_PaperEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convzx_qa_Paper.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.UploadfileUrl = objvzx_qa_PaperEN.UploadfileUrl == "[null]" ? null :  objvzx_qa_PaperEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convzx_qa_Paper.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.AttachmentCount = objvzx_qa_PaperEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convzx_qa_Paper.ZxqaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.ZxqaPaperId = objvzx_qa_PaperEN.ZxqaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convzx_qa_Paper.QuestionsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.QuestionsCount = objvzx_qa_PaperEN.QuestionsCount; //提问计数
}
if (arrFldSet.Contains(convzx_qa_Paper.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.TextId = objvzx_qa_PaperEN.TextId == "[null]" ? null :  objvzx_qa_PaperEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_qa_Paper.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.IsDelete = objvzx_qa_PaperEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(convzx_qa_Paper.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.IsPublic = objvzx_qa_PaperEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convzx_qa_Paper.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.IsSubmit = objvzx_qa_PaperEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_qa_Paper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.UpdDate = objvzx_qa_PaperEN.UpdDate == "[null]" ? null :  objvzx_qa_PaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_qa_Paper.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.UpdUser = objvzx_qa_PaperEN.UpdUser == "[null]" ? null :  objvzx_qa_PaperEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_qa_Paper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.Memo = objvzx_qa_PaperEN.Memo == "[null]" ? null :  objvzx_qa_PaperEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_qa_Paper.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.IdCurrEduCls = objvzx_qa_PaperEN.IdCurrEduCls == "[null]" ? null :  objvzx_qa_PaperEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_qa_Paper.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.AnswerCount = objvzx_qa_PaperEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convzx_qa_Paper.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.zxShareId = objvzx_qa_PaperEN.zxShareId == "[null]" ? null :  objvzx_qa_PaperEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_qa_Paper.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_qa_PaperEN.TagsCount = objvzx_qa_PaperEN.TagsCount; //论文标注数
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
 /// <param name = "objvzx_qa_PaperEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_qa_PaperEN objvzx_qa_PaperEN)
{
try
{
if (objvzx_qa_PaperEN.UserName == "[null]") objvzx_qa_PaperEN.UserName = null; //用户名
if (objvzx_qa_PaperEN.IdXzMajor == "[null]") objvzx_qa_PaperEN.IdXzMajor = null; //专业流水号
if (objvzx_qa_PaperEN.MajorName == "[null]") objvzx_qa_PaperEN.MajorName = null; //专业名称
if (objvzx_qa_PaperEN.TextTitle == "[null]") objvzx_qa_PaperEN.TextTitle = null; //TextTitle
if (objvzx_qa_PaperEN.TextContent == "[null]") objvzx_qa_PaperEN.TextContent = null; //TextContent
if (objvzx_qa_PaperEN.Author == "[null]") objvzx_qa_PaperEN.Author = null; //作者
if (objvzx_qa_PaperEN.ResearchQuestion == "[null]") objvzx_qa_PaperEN.ResearchQuestion = null; //研究问题
if (objvzx_qa_PaperEN.LiteratureSources == "[null]") objvzx_qa_PaperEN.LiteratureSources = null; //文献来源
if (objvzx_qa_PaperEN.LiteratureLink == "[null]") objvzx_qa_PaperEN.LiteratureLink = null; //文献链接
if (objvzx_qa_PaperEN.UploadfileUrl == "[null]") objvzx_qa_PaperEN.UploadfileUrl = null; //文件地址
if (objvzx_qa_PaperEN.TextId == "[null]") objvzx_qa_PaperEN.TextId = null; //课件Id
if (objvzx_qa_PaperEN.UpdDate == "[null]") objvzx_qa_PaperEN.UpdDate = null; //修改日期
if (objvzx_qa_PaperEN.UpdUser == "[null]") objvzx_qa_PaperEN.UpdUser = null; //修改人
if (objvzx_qa_PaperEN.Memo == "[null]") objvzx_qa_PaperEN.Memo = null; //备注
if (objvzx_qa_PaperEN.IdCurrEduCls == "[null]") objvzx_qa_PaperEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_qa_PaperEN.zxShareId == "[null]") objvzx_qa_PaperEN.zxShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvzx_qa_PaperEN objvzx_qa_PaperEN)
{
 vzx_qa_PaperDA.CheckProperty4Condition(objvzx_qa_PaperEN);
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
if (clszx_qa_PaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_qa_PaperBL没有刷新缓存机制(clszx_qa_PaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxUserIdentityBL没有刷新缓存机制(clsQxUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ZxqaPaperId");
//if (arrvzx_qa_PaperObjLstCache == null)
//{
//arrvzx_qa_PaperObjLstCache = vzx_qa_PaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strZxqaPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_qa_PaperEN GetObjByZxqaPaperIdCache(string strZxqaPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_qa_PaperEN._CurrTabName);
List<clsvzx_qa_PaperEN> arrvzx_qa_PaperObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PaperEN> arrvzx_qa_PaperObjLst_Sel =
arrvzx_qa_PaperObjLstCache
.Where(x=> x.ZxqaPaperId == strZxqaPaperId 
);
if (arrvzx_qa_PaperObjLst_Sel.Count() == 0)
{
   clsvzx_qa_PaperEN obj = clsvzx_qa_PaperBL.GetObjByZxqaPaperId(strZxqaPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_qa_PaperObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_qa_PaperEN> GetAllvzx_qa_PaperObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_qa_PaperEN> arrvzx_qa_PaperObjLstCache = GetObjLstCache(); 
return arrvzx_qa_PaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_qa_PaperEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_qa_PaperEN._CurrTabName);
List<clsvzx_qa_PaperEN> arrvzx_qa_PaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_qa_PaperObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_qa_PaperEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strZxqaPaperId)
{
if (strInFldName != convzx_qa_Paper.ZxqaPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_qa_Paper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_qa_Paper.AttributeName));
throw new Exception(strMsg);
}
var objvzx_qa_Paper = clsvzx_qa_PaperBL.GetObjByZxqaPaperIdCache(strZxqaPaperId);
if (objvzx_qa_Paper == null) return "";
return objvzx_qa_Paper[strOutFldName].ToString();
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
int intRecCount = clsvzx_qa_PaperDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_qa_PaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_qa_PaperDA.GetRecCount();
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
int intRecCount = clsvzx_qa_PaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_qa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_qa_PaperEN objvzx_qa_PaperCond)
{
List<clsvzx_qa_PaperEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_qa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_qa_Paper.AttributeName)
{
if (objvzx_qa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objvzx_qa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PaperCond[strFldName].ToString());
}
else
{
if (objvzx_qa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_qa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_qa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_qa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_qa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_qa_PaperCond[strFldName]));
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
 List<string> arrList = clsvzx_qa_PaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_qa_PaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_qa_PaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}