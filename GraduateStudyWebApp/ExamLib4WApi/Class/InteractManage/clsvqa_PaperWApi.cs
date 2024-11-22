
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PaperWApi
 表名:vqa_Paper(01120637)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:06
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvqa_PaperWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN Setqa_PaperId(this clsvqa_PaperEN objvqa_PaperEN, string strqa_PaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqa_PaperId, 8, convqa_Paper.qa_PaperId);
clsCheckSql.CheckFieldForeignKey(strqa_PaperId, 8, convqa_Paper.qa_PaperId);
objvqa_PaperEN.qa_PaperId = strqa_PaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.qa_PaperId) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.qa_PaperId, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.qa_PaperId] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetPaperId(this clsvqa_PaperEN objvqa_PaperEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Paper.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Paper.PaperId);
objvqa_PaperEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.PaperId) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.PaperId, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.PaperId] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetQuestionsCount(this clsvqa_PaperEN objvqa_PaperEN, int intQuestionsCount, string strComparisonOp="")
	{
objvqa_PaperEN.QuestionsCount = intQuestionsCount; //提问计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.QuestionsCount) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.QuestionsCount, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.QuestionsCount] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetIsDelete(this clsvqa_PaperEN objvqa_PaperEN, bool bolIsDelete, string strComparisonOp="")
	{
objvqa_PaperEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.IsDelete) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.IsDelete, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.IsDelete] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetIsPublic(this clsvqa_PaperEN objvqa_PaperEN, bool bolIsPublic, string strComparisonOp="")
	{
objvqa_PaperEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.IsPublic) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.IsPublic, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.IsPublic] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetIsSubmit(this clsvqa_PaperEN objvqa_PaperEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvqa_PaperEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.IsSubmit) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.IsSubmit, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.IsSubmit] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetUpdUser(this clsvqa_PaperEN objvqa_PaperEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convqa_Paper.UpdUser);
objvqa_PaperEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.UpdUser) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.UpdUser, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.UpdUser] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetUserName(this clsvqa_PaperEN objvqa_PaperEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convqa_Paper.UserName);
objvqa_PaperEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.UserName) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.UserName, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.UserName] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetUpdDate(this clsvqa_PaperEN objvqa_PaperEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Paper.UpdDate);
objvqa_PaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.UpdDate) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.UpdDate, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.UpdDate] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetMemo(this clsvqa_PaperEN objvqa_PaperEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Paper.Memo);
objvqa_PaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.Memo) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.Memo, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.Memo] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetPaperTitle(this clsvqa_PaperEN objvqa_PaperEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Paper.PaperTitle);
objvqa_PaperEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.PaperTitle) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.PaperTitle, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.PaperTitle] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetAttachmentCount(this clsvqa_PaperEN objvqa_PaperEN, int intAttachmentCount, string strComparisonOp="")
	{
objvqa_PaperEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.AttachmentCount) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.AttachmentCount, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.AttachmentCount] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetPaperContent(this clsvqa_PaperEN objvqa_PaperEN, string strPaperContent, string strComparisonOp="")
	{
objvqa_PaperEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.PaperContent) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.PaperContent, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.PaperContent] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetPeriodical(this clsvqa_PaperEN objvqa_PaperEN, string strPeriodical, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convqa_Paper.Periodical);
objvqa_PaperEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.Periodical) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.Periodical, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.Periodical] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetAuthor(this clsvqa_PaperEN objvqa_PaperEN, string strAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuthor, 200, convqa_Paper.Author);
objvqa_PaperEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.Author) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.Author, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.Author] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetResearchQuestion(this clsvqa_PaperEN objvqa_PaperEN, string strResearchQuestion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convqa_Paper.ResearchQuestion);
objvqa_PaperEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.ResearchQuestion) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.ResearchQuestion, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.ResearchQuestion] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetLiteratureSources(this clsvqa_PaperEN objvqa_PaperEN, string strLiteratureSources, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convqa_Paper.LiteratureSources);
objvqa_PaperEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.LiteratureSources) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.LiteratureSources, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.LiteratureSources] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetUploadfileUrl(this clsvqa_PaperEN objvqa_PaperEN, string strUploadfileUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convqa_Paper.UploadfileUrl);
objvqa_PaperEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.UploadfileUrl) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.UploadfileUrl, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.UploadfileUrl] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN Setid_XzMajor(this clsvqa_PaperEN objvqa_PaperEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convqa_Paper.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convqa_Paper.id_XzMajor);
objvqa_PaperEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.id_XzMajor) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.id_XzMajor, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.id_XzMajor] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetMajorName(this clsvqa_PaperEN objvqa_PaperEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convqa_Paper.MajorName);
objvqa_PaperEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.MajorName) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.MajorName, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.MajorName] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN Setid_CurrEduCls(this clsvqa_PaperEN objvqa_PaperEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convqa_Paper.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convqa_Paper.id_CurrEduCls);
objvqa_PaperEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.id_CurrEduCls) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.id_CurrEduCls, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.id_CurrEduCls] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetAnswerCount(this clsvqa_PaperEN objvqa_PaperEN, int intAnswerCount, string strComparisonOp="")
	{
objvqa_PaperEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.AnswerCount) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.AnswerCount, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.AnswerCount] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetShareId(this clsvqa_PaperEN objvqa_PaperEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strShareId, 2, convqa_Paper.ShareId);
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convqa_Paper.ShareId);
objvqa_PaperEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.ShareId) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.ShareId, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.ShareId] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvqa_PaperEN SetTagsCount(this clsvqa_PaperEN objvqa_PaperEN, int intTagsCount, string strComparisonOp="")
	{
objvqa_PaperEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.TagsCount) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.TagsCount, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.TagsCount] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_PaperEN objvqa_Paper_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.qa_PaperId) == true)
{
string strComparisonOp_qa_PaperId = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.qa_PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.qa_PaperId, objvqa_Paper_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.PaperId) == true)
{
string strComparisonOp_PaperId = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.PaperId, objvqa_Paper_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.QuestionsCount) == true)
{
string strComparisonOp_QuestionsCount = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.QuestionsCount, objvqa_Paper_Cond.QuestionsCount, strComparisonOp_QuestionsCount);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.IsDelete) == true)
{
if (objvqa_Paper_Cond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Paper.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Paper.IsDelete);
}
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.IsPublic) == true)
{
if (objvqa_Paper_Cond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Paper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Paper.IsPublic);
}
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.IsSubmit) == true)
{
if (objvqa_Paper_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Paper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Paper.IsSubmit);
}
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UpdUser, objvqa_Paper_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.UserName) == true)
{
string strComparisonOp_UserName = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UserName, objvqa_Paper_Cond.UserName, strComparisonOp_UserName);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UpdDate, objvqa_Paper_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.Memo) == true)
{
string strComparisonOp_Memo = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.Memo, objvqa_Paper_Cond.Memo, strComparisonOp_Memo);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.PaperTitle, objvqa_Paper_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.AttachmentCount) == true)
{
string strComparisonOp_AttachmentCount = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.AttachmentCount, objvqa_Paper_Cond.AttachmentCount, strComparisonOp_AttachmentCount);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.Periodical) == true)
{
string strComparisonOp_Periodical = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.Periodical, objvqa_Paper_Cond.Periodical, strComparisonOp_Periodical);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.Author) == true)
{
string strComparisonOp_Author = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.Author, objvqa_Paper_Cond.Author, strComparisonOp_Author);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.ResearchQuestion) == true)
{
string strComparisonOp_ResearchQuestion = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.ResearchQuestion, objvqa_Paper_Cond.ResearchQuestion, strComparisonOp_ResearchQuestion);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.LiteratureSources) == true)
{
string strComparisonOp_LiteratureSources = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.LiteratureSources, objvqa_Paper_Cond.LiteratureSources, strComparisonOp_LiteratureSources);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.UploadfileUrl) == true)
{
string strComparisonOp_UploadfileUrl = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UploadfileUrl, objvqa_Paper_Cond.UploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.id_XzMajor, objvqa_Paper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.MajorName) == true)
{
string strComparisonOp_MajorName = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.MajorName, objvqa_Paper_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.id_CurrEduCls, objvqa_Paper_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.AnswerCount) == true)
{
string strComparisonOp_AnswerCount = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.AnswerCount, objvqa_Paper_Cond.AnswerCount, strComparisonOp_AnswerCount);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.ShareId) == true)
{
string strComparisonOp_ShareId = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.ShareId, objvqa_Paper_Cond.ShareId, strComparisonOp_ShareId);
}
if (objvqa_Paper_Cond.IsUpdated(convqa_Paper.TagsCount) == true)
{
string strComparisonOp_TagsCount = objvqa_Paper_Cond.dicFldComparisonOp[convqa_Paper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.TagsCount, objvqa_Paper_Cond.TagsCount, strComparisonOp_TagsCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v论文答疑(vqa_Paper)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvqa_PaperWApi
{
private static readonly string mstrApiControllerName = "vqa_PaperApi";

 public clsvqa_PaperWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strqa_PaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PaperEN GetObjByqa_PaperId(string strqa_PaperId)
{
string strAction = "GetObjByqa_PaperId";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_PaperEN objvqa_PaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["qa_PaperId"] = strqa_PaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvqa_PaperEN = JsonConvert.DeserializeObject<clsvqa_PaperEN>((string)jobjReturn["ReturnObj"]);
return objvqa_PaperEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strqa_PaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PaperEN GetObjByqa_PaperId_WA_Cache(string strqa_PaperId, string strid_CurrEduCls)
{
string strAction = "GetObjByqa_PaperId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_PaperEN objvqa_PaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["qa_PaperId"] = strqa_PaperId,
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvqa_PaperEN = JsonConvert.DeserializeObject<clsvqa_PaperEN>((string)jobjReturn["ReturnObj"]);
return objvqa_PaperEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvqa_PaperEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvqa_PaperEN objvqa_PaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvqa_PaperEN = JsonConvert.DeserializeObject<clsvqa_PaperEN>((string)jobjReturn["ReturnObj"]);
return objvqa_PaperEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strqa_PaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_PaperEN GetObjByqa_PaperId_Cache(string strqa_PaperId, string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strqa_PaperId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
List<clsvqa_PaperEN> arrvqa_PaperObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvqa_PaperEN> arrvqa_PaperObjLst_Sel =
from objvqa_PaperEN in arrvqa_PaperObjLst_Cache
where objvqa_PaperEN.qa_PaperId == strqa_PaperId
select objvqa_PaperEN;
if (arrvqa_PaperObjLst_Sel.Count() == 0)
{
   clsvqa_PaperEN obj = clsvqa_PaperWApi.GetObjByqa_PaperId(strqa_PaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvqa_PaperObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLst(string strWhereCond)
{
 List<clsvqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstByQa_PaperIdLst(List<string> arrQa_PaperId)
{
 List<clsvqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLstByQa_PaperIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQa_PaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strqa_PaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvqa_PaperEN> GetObjLstByQa_PaperIdLst_Cache(List<string> arrQa_PaperId, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
List<clsvqa_PaperEN> arrvqa_PaperObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsvqa_PaperEN> arrvqa_PaperObjLst_Sel =
from objvqa_PaperEN in arrvqa_PaperObjLst_Cache
where arrQa_PaperId.Contains(objvqa_PaperEN.qa_PaperId)
select objvqa_PaperEN;
return arrvqa_PaperObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstByQa_PaperIdLst_WA_Cache(List<string> arrQa_PaperId, string strid_CurrEduCls)
{
 List<clsvqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLstByQa_PaperIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQa_PaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvqa_PaperEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strqa_PaperId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["qa_PaperId"] = strqa_PaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvqa_PaperENS">源对象</param>
 /// <param name = "objvqa_PaperENT">目标对象</param>
 public static void CopyTo(clsvqa_PaperEN objvqa_PaperENS, clsvqa_PaperEN objvqa_PaperENT)
{
try
{
objvqa_PaperENT.qa_PaperId = objvqa_PaperENS.qa_PaperId; //论文答疑Id
objvqa_PaperENT.PaperId = objvqa_PaperENS.PaperId; //论文Id
objvqa_PaperENT.QuestionsCount = objvqa_PaperENS.QuestionsCount; //提问计数
objvqa_PaperENT.IsDelete = objvqa_PaperENS.IsDelete; //是否删除
objvqa_PaperENT.IsPublic = objvqa_PaperENS.IsPublic; //是否公开
objvqa_PaperENT.IsSubmit = objvqa_PaperENS.IsSubmit; //是否提交
objvqa_PaperENT.UpdUser = objvqa_PaperENS.UpdUser; //修改人
objvqa_PaperENT.UserName = objvqa_PaperENS.UserName; //用户名
objvqa_PaperENT.UpdDate = objvqa_PaperENS.UpdDate; //修改日期
objvqa_PaperENT.Memo = objvqa_PaperENS.Memo; //备注
objvqa_PaperENT.PaperTitle = objvqa_PaperENS.PaperTitle; //论文标题
objvqa_PaperENT.AttachmentCount = objvqa_PaperENS.AttachmentCount; //附件计数
objvqa_PaperENT.PaperContent = objvqa_PaperENS.PaperContent; //主题内容
objvqa_PaperENT.Periodical = objvqa_PaperENS.Periodical; //期刊
objvqa_PaperENT.Author = objvqa_PaperENS.Author; //作者
objvqa_PaperENT.ResearchQuestion = objvqa_PaperENS.ResearchQuestion; //研究问题
objvqa_PaperENT.LiteratureSources = objvqa_PaperENS.LiteratureSources; //文献来源
objvqa_PaperENT.UploadfileUrl = objvqa_PaperENS.UploadfileUrl; //文件地址
objvqa_PaperENT.id_XzMajor = objvqa_PaperENS.id_XzMajor; //专业流水号
objvqa_PaperENT.MajorName = objvqa_PaperENS.MajorName; //专业名称
objvqa_PaperENT.id_CurrEduCls = objvqa_PaperENS.id_CurrEduCls; //当前教学班流水号
objvqa_PaperENT.AnswerCount = objvqa_PaperENS.AnswerCount; //回答计数
objvqa_PaperENT.ShareId = objvqa_PaperENS.ShareId; //分享Id
objvqa_PaperENT.TagsCount = objvqa_PaperENS.TagsCount; //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvqa_PaperEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvqa_PaperEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvqa_PaperEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvqa_PaperEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvqa_PaperEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvqa_PaperEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsqa_PaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PaperWApi没有刷新缓存机制(clsqa_PaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by qa_PaperId");
//if (arrvqa_PaperObjLst_Cache == null)
//{
//arrvqa_PaperObjLst_Cache = await clsvqa_PaperWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strid_CurrEduCls = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
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

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
List<clsvqa_PaperEN> arrvqa_PaperObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrvqa_PaperObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvqa_PaperEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convqa_Paper.qa_PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.QuestionsCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Paper.IsDelete, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Paper.IsPublic, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Paper.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convqa_Paper.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.AttachmentCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Paper.PaperContent, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.Periodical, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.Author, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.ResearchQuestion, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.LiteratureSources, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.UploadfileUrl, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.AnswerCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convqa_Paper.ShareId, Type.GetType("System.String"));
objDT.Columns.Add(convqa_Paper.TagsCount, Type.GetType("System.Int32"));
foreach (clsvqa_PaperEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convqa_Paper.qa_PaperId] = objInFor[convqa_Paper.qa_PaperId];
objDR[convqa_Paper.PaperId] = objInFor[convqa_Paper.PaperId];
objDR[convqa_Paper.QuestionsCount] = objInFor[convqa_Paper.QuestionsCount];
objDR[convqa_Paper.IsDelete] = objInFor[convqa_Paper.IsDelete];
objDR[convqa_Paper.IsPublic] = objInFor[convqa_Paper.IsPublic];
objDR[convqa_Paper.IsSubmit] = objInFor[convqa_Paper.IsSubmit];
objDR[convqa_Paper.UpdUser] = objInFor[convqa_Paper.UpdUser];
objDR[convqa_Paper.UserName] = objInFor[convqa_Paper.UserName];
objDR[convqa_Paper.UpdDate] = objInFor[convqa_Paper.UpdDate];
objDR[convqa_Paper.Memo] = objInFor[convqa_Paper.Memo];
objDR[convqa_Paper.PaperTitle] = objInFor[convqa_Paper.PaperTitle];
objDR[convqa_Paper.AttachmentCount] = objInFor[convqa_Paper.AttachmentCount];
objDR[convqa_Paper.PaperContent] = objInFor[convqa_Paper.PaperContent];
objDR[convqa_Paper.Periodical] = objInFor[convqa_Paper.Periodical];
objDR[convqa_Paper.Author] = objInFor[convqa_Paper.Author];
objDR[convqa_Paper.ResearchQuestion] = objInFor[convqa_Paper.ResearchQuestion];
objDR[convqa_Paper.LiteratureSources] = objInFor[convqa_Paper.LiteratureSources];
objDR[convqa_Paper.UploadfileUrl] = objInFor[convqa_Paper.UploadfileUrl];
objDR[convqa_Paper.id_XzMajor] = objInFor[convqa_Paper.id_XzMajor];
objDR[convqa_Paper.MajorName] = objInFor[convqa_Paper.MajorName];
objDR[convqa_Paper.id_CurrEduCls] = objInFor[convqa_Paper.id_CurrEduCls];
objDR[convqa_Paper.AnswerCount] = objInFor[convqa_Paper.AnswerCount];
objDR[convqa_Paper.ShareId] = objInFor[convqa_Paper.ShareId];
objDR[convqa_Paper.TagsCount] = objInFor[convqa_Paper.TagsCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}