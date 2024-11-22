
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvqa_PaperBL
 表名:vqa_Paper(01120637)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:26
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
public static class  clsvqa_PaperBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PaperEN GetObj(this K_QaPaperId_vqa_Paper myKey)
{
clsvqa_PaperEN objvqa_PaperEN = clsvqa_PaperBL.vqa_PaperDA.GetObjByQaPaperId(myKey.Value);
return objvqa_PaperEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetQaPaperId(this clsvqa_PaperEN objvqa_PaperEN, string strQaPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQaPaperId, 8, convqa_Paper.QaPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQaPaperId, 8, convqa_Paper.QaPaperId);
}
objvqa_PaperEN.QaPaperId = strQaPaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.QaPaperId) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.QaPaperId, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.QaPaperId] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetPaperId(this clsvqa_PaperEN objvqa_PaperEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convqa_Paper.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convqa_Paper.PaperId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetQuestionsCount(this clsvqa_PaperEN objvqa_PaperEN, int? intQuestionsCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetUpdUser(this clsvqa_PaperEN objvqa_PaperEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convqa_Paper.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetUserName(this clsvqa_PaperEN objvqa_PaperEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convqa_Paper.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetUpdDate(this clsvqa_PaperEN objvqa_PaperEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convqa_Paper.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetMemo(this clsvqa_PaperEN objvqa_PaperEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convqa_Paper.Memo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetPaperTitle(this clsvqa_PaperEN objvqa_PaperEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convqa_Paper.PaperTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetAttachmentCount(this clsvqa_PaperEN objvqa_PaperEN, int? intAttachmentCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetPeriodical(this clsvqa_PaperEN objvqa_PaperEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convqa_Paper.Periodical);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetAuthor(this clsvqa_PaperEN objvqa_PaperEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convqa_Paper.Author);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetResearchQuestion(this clsvqa_PaperEN objvqa_PaperEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convqa_Paper.ResearchQuestion);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetLiteratureSources(this clsvqa_PaperEN objvqa_PaperEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convqa_Paper.LiteratureSources);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetUploadfileUrl(this clsvqa_PaperEN objvqa_PaperEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convqa_Paper.UploadfileUrl);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetIdXzMajor(this clsvqa_PaperEN objvqa_PaperEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convqa_Paper.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convqa_Paper.IdXzMajor);
}
objvqa_PaperEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.IdXzMajor) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.IdXzMajor, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.IdXzMajor] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetMajorName(this clsvqa_PaperEN objvqa_PaperEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convqa_Paper.MajorName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetIdCurrEduCls(this clsvqa_PaperEN objvqa_PaperEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convqa_Paper.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convqa_Paper.IdCurrEduCls);
}
objvqa_PaperEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvqa_PaperEN.dicFldComparisonOp.ContainsKey(convqa_Paper.IdCurrEduCls) == false)
{
objvqa_PaperEN.dicFldComparisonOp.Add(convqa_Paper.IdCurrEduCls, strComparisonOp);
}
else
{
objvqa_PaperEN.dicFldComparisonOp[convqa_Paper.IdCurrEduCls] = strComparisonOp;
}
}
return objvqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetAnswerCount(this clsvqa_PaperEN objvqa_PaperEN, int? intAnswerCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetShareId(this clsvqa_PaperEN objvqa_PaperEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convqa_Paper.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convqa_Paper.ShareId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvqa_PaperEN SetTagsCount(this clsvqa_PaperEN objvqa_PaperEN, int? intTagsCount, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvqa_PaperENS">源对象</param>
 /// <param name = "objvqa_PaperENT">目标对象</param>
 public static void CopyTo(this clsvqa_PaperEN objvqa_PaperENS, clsvqa_PaperEN objvqa_PaperENT)
{
try
{
objvqa_PaperENT.QaPaperId = objvqa_PaperENS.QaPaperId; //论文答疑Id
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
objvqa_PaperENT.IdXzMajor = objvqa_PaperENS.IdXzMajor; //专业流水号
objvqa_PaperENT.MajorName = objvqa_PaperENS.MajorName; //专业名称
objvqa_PaperENT.IdCurrEduCls = objvqa_PaperENS.IdCurrEduCls; //教学班流水号
objvqa_PaperENT.AnswerCount = objvqa_PaperENS.AnswerCount; //回答计数
objvqa_PaperENT.ShareId = objvqa_PaperENS.ShareId; //分享Id
objvqa_PaperENT.TagsCount = objvqa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objvqa_PaperENS">源对象</param>
 /// <returns>目标对象=>clsvqa_PaperEN:objvqa_PaperENT</returns>
 public static clsvqa_PaperEN CopyTo(this clsvqa_PaperEN objvqa_PaperENS)
{
try
{
 clsvqa_PaperEN objvqa_PaperENT = new clsvqa_PaperEN()
{
QaPaperId = objvqa_PaperENS.QaPaperId, //论文答疑Id
PaperId = objvqa_PaperENS.PaperId, //论文Id
QuestionsCount = objvqa_PaperENS.QuestionsCount, //提问计数
IsDelete = objvqa_PaperENS.IsDelete, //是否删除
IsPublic = objvqa_PaperENS.IsPublic, //是否公开
IsSubmit = objvqa_PaperENS.IsSubmit, //是否提交
UpdUser = objvqa_PaperENS.UpdUser, //修改人
UserName = objvqa_PaperENS.UserName, //用户名
UpdDate = objvqa_PaperENS.UpdDate, //修改日期
Memo = objvqa_PaperENS.Memo, //备注
PaperTitle = objvqa_PaperENS.PaperTitle, //论文标题
AttachmentCount = objvqa_PaperENS.AttachmentCount, //附件计数
PaperContent = objvqa_PaperENS.PaperContent, //主题内容
Periodical = objvqa_PaperENS.Periodical, //期刊
Author = objvqa_PaperENS.Author, //作者
ResearchQuestion = objvqa_PaperENS.ResearchQuestion, //研究问题
LiteratureSources = objvqa_PaperENS.LiteratureSources, //文献来源
UploadfileUrl = objvqa_PaperENS.UploadfileUrl, //文件地址
IdXzMajor = objvqa_PaperENS.IdXzMajor, //专业流水号
MajorName = objvqa_PaperENS.MajorName, //专业名称
IdCurrEduCls = objvqa_PaperENS.IdCurrEduCls, //教学班流水号
AnswerCount = objvqa_PaperENS.AnswerCount, //回答计数
ShareId = objvqa_PaperENS.ShareId, //分享Id
TagsCount = objvqa_PaperENS.TagsCount, //论文标注数
};
 return objvqa_PaperENT;
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
public static void CheckProperty4Condition(this clsvqa_PaperEN objvqa_PaperEN)
{
 clsvqa_PaperBL.vqa_PaperDA.CheckProperty4Condition(objvqa_PaperEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvqa_PaperEN objvqa_PaperCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvqa_PaperCond.IsUpdated(convqa_Paper.QaPaperId) == true)
{
string strComparisonOpQaPaperId = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.QaPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.QaPaperId, objvqa_PaperCond.QaPaperId, strComparisonOpQaPaperId);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.PaperId) == true)
{
string strComparisonOpPaperId = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.PaperId, objvqa_PaperCond.PaperId, strComparisonOpPaperId);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.QuestionsCount) == true)
{
string strComparisonOpQuestionsCount = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.QuestionsCount, objvqa_PaperCond.QuestionsCount, strComparisonOpQuestionsCount);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.IsDelete) == true)
{
if (objvqa_PaperCond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Paper.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Paper.IsDelete);
}
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.IsPublic) == true)
{
if (objvqa_PaperCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Paper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Paper.IsPublic);
}
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.IsSubmit) == true)
{
if (objvqa_PaperCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convqa_Paper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convqa_Paper.IsSubmit);
}
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.UpdUser) == true)
{
string strComparisonOpUpdUser = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UpdUser, objvqa_PaperCond.UpdUser, strComparisonOpUpdUser);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.UserName) == true)
{
string strComparisonOpUserName = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UserName, objvqa_PaperCond.UserName, strComparisonOpUserName);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.UpdDate) == true)
{
string strComparisonOpUpdDate = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UpdDate, objvqa_PaperCond.UpdDate, strComparisonOpUpdDate);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.Memo) == true)
{
string strComparisonOpMemo = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.Memo, objvqa_PaperCond.Memo, strComparisonOpMemo);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.PaperTitle, objvqa_PaperCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.AttachmentCount, objvqa_PaperCond.AttachmentCount, strComparisonOpAttachmentCount);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvqa_PaperCond.IsUpdated(convqa_Paper.Periodical) == true)
{
string strComparisonOpPeriodical = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.Periodical, objvqa_PaperCond.Periodical, strComparisonOpPeriodical);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.Author) == true)
{
string strComparisonOpAuthor = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.Author, objvqa_PaperCond.Author, strComparisonOpAuthor);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.ResearchQuestion, objvqa_PaperCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.LiteratureSources, objvqa_PaperCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.UploadfileUrl, objvqa_PaperCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.IdXzMajor, objvqa_PaperCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.MajorName) == true)
{
string strComparisonOpMajorName = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.MajorName, objvqa_PaperCond.MajorName, strComparisonOpMajorName);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.IdCurrEduCls, objvqa_PaperCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.AnswerCount) == true)
{
string strComparisonOpAnswerCount = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.AnswerCount, objvqa_PaperCond.AnswerCount, strComparisonOpAnswerCount);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.ShareId) == true)
{
string strComparisonOpShareId = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convqa_Paper.ShareId, objvqa_PaperCond.ShareId, strComparisonOpShareId);
}
if (objvqa_PaperCond.IsUpdated(convqa_Paper.TagsCount) == true)
{
string strComparisonOpTagsCount = objvqa_PaperCond.dicFldComparisonOp[convqa_Paper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convqa_Paper.TagsCount, objvqa_PaperCond.TagsCount, strComparisonOpTagsCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vqa_Paper
{
public virtual bool UpdRelaTabDate(string strQaPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v论文答疑(vqa_Paper)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvqa_PaperBL
{
public static RelatedActions_vqa_Paper relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvqa_PaperDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvqa_PaperDA vqa_PaperDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvqa_PaperDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvqa_PaperBL()
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
if (string.IsNullOrEmpty(clsvqa_PaperEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvqa_PaperEN._ConnectString);
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
public static DataTable GetDataTable_vqa_Paper(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vqa_PaperDA.GetDataTable_vqa_Paper(strWhereCond);
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
objDT = vqa_PaperDA.GetDataTable(strWhereCond);
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
objDT = vqa_PaperDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vqa_PaperDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vqa_PaperDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vqa_PaperDA.GetDataTable_Top(objTopPara);
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
objDT = vqa_PaperDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vqa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vqa_PaperDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstByQaPaperIdLst(List<string> arrQaPaperIdLst)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQaPaperIdLst, true);
 string strWhereCond = string.Format("QaPaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQaPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvqa_PaperEN> GetObjLstByQaPaperIdLstCache(List<string> arrQaPaperIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strIdCurrEduCls);
List<clsvqa_PaperEN> arrvqa_PaperObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvqa_PaperEN> arrvqa_PaperObjLst_Sel =
arrvqa_PaperObjLstCache
.Where(x => arrQaPaperIdLst.Contains(x.QaPaperId));
return arrvqa_PaperObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLst(string strWhereCond)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
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
public static List<clsvqa_PaperEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvqa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvqa_PaperEN> GetSubObjLstCache(clsvqa_PaperEN objvqa_PaperCond)
{
 string strIdCurrEduCls = objvqa_PaperCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvqa_PaperBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvqa_PaperEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvqa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Paper.AttributeName)
{
if (objvqa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objvqa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PaperCond[strFldName].ToString());
}
else
{
if (objvqa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_PaperCond[strFldName]));
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
public static List<clsvqa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
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
public static List<clsvqa_PaperEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
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
List<clsvqa_PaperEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvqa_PaperEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvqa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
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
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
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
public static List<clsvqa_PaperEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvqa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
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
public static List<clsvqa_PaperEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvqa_PaperEN> arrObjLst = new List<clsvqa_PaperEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvqa_PaperEN objvqa_PaperEN = new clsvqa_PaperEN();
try
{
objvqa_PaperEN.QaPaperId = objRow[convqa_Paper.QaPaperId].ToString().Trim(); //论文答疑Id
objvqa_PaperEN.PaperId = objRow[convqa_Paper.PaperId] == DBNull.Value ? null : objRow[convqa_Paper.PaperId].ToString().Trim(); //论文Id
objvqa_PaperEN.QuestionsCount = objRow[convqa_Paper.QuestionsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.QuestionsCount].ToString().Trim()); //提问计数
objvqa_PaperEN.IsDelete = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsDelete].ToString().Trim()); //是否删除
objvqa_PaperEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsPublic].ToString().Trim()); //是否公开
objvqa_PaperEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convqa_Paper.IsSubmit].ToString().Trim()); //是否提交
objvqa_PaperEN.UpdUser = objRow[convqa_Paper.UpdUser] == DBNull.Value ? null : objRow[convqa_Paper.UpdUser].ToString().Trim(); //修改人
objvqa_PaperEN.UserName = objRow[convqa_Paper.UserName] == DBNull.Value ? null : objRow[convqa_Paper.UserName].ToString().Trim(); //用户名
objvqa_PaperEN.UpdDate = objRow[convqa_Paper.UpdDate] == DBNull.Value ? null : objRow[convqa_Paper.UpdDate].ToString().Trim(); //修改日期
objvqa_PaperEN.Memo = objRow[convqa_Paper.Memo] == DBNull.Value ? null : objRow[convqa_Paper.Memo].ToString().Trim(); //备注
objvqa_PaperEN.PaperTitle = objRow[convqa_Paper.PaperTitle] == DBNull.Value ? null : objRow[convqa_Paper.PaperTitle].ToString().Trim(); //论文标题
objvqa_PaperEN.AttachmentCount = objRow[convqa_Paper.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AttachmentCount].ToString().Trim()); //附件计数
objvqa_PaperEN.PaperContent = objRow[convqa_Paper.PaperContent] == DBNull.Value ? null : objRow[convqa_Paper.PaperContent].ToString().Trim(); //主题内容
objvqa_PaperEN.Periodical = objRow[convqa_Paper.Periodical] == DBNull.Value ? null : objRow[convqa_Paper.Periodical].ToString().Trim(); //期刊
objvqa_PaperEN.Author = objRow[convqa_Paper.Author] == DBNull.Value ? null : objRow[convqa_Paper.Author].ToString().Trim(); //作者
objvqa_PaperEN.ResearchQuestion = objRow[convqa_Paper.ResearchQuestion] == DBNull.Value ? null : objRow[convqa_Paper.ResearchQuestion].ToString().Trim(); //研究问题
objvqa_PaperEN.LiteratureSources = objRow[convqa_Paper.LiteratureSources] == DBNull.Value ? null : objRow[convqa_Paper.LiteratureSources].ToString().Trim(); //文献来源
objvqa_PaperEN.UploadfileUrl = objRow[convqa_Paper.UploadfileUrl] == DBNull.Value ? null : objRow[convqa_Paper.UploadfileUrl].ToString().Trim(); //文件地址
objvqa_PaperEN.IdXzMajor = objRow[convqa_Paper.IdXzMajor] == DBNull.Value ? null : objRow[convqa_Paper.IdXzMajor].ToString().Trim(); //专业流水号
objvqa_PaperEN.MajorName = objRow[convqa_Paper.MajorName] == DBNull.Value ? null : objRow[convqa_Paper.MajorName].ToString().Trim(); //专业名称
objvqa_PaperEN.IdCurrEduCls = objRow[convqa_Paper.IdCurrEduCls] == DBNull.Value ? null : objRow[convqa_Paper.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvqa_PaperEN.AnswerCount = objRow[convqa_Paper.AnswerCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.AnswerCount].ToString().Trim()); //回答计数
objvqa_PaperEN.ShareId = objRow[convqa_Paper.ShareId] == DBNull.Value ? null : objRow[convqa_Paper.ShareId].ToString().Trim(); //分享Id
objvqa_PaperEN.TagsCount = objRow[convqa_Paper.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convqa_Paper.TagsCount].ToString().Trim()); //论文标注数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvqa_PaperEN.QaPaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvqa_PaperEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvqa_PaperEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvqa_Paper(ref clsvqa_PaperEN objvqa_PaperEN)
{
bool bolResult = vqa_PaperDA.Getvqa_Paper(ref objvqa_PaperEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQaPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvqa_PaperEN GetObjByQaPaperId(string strQaPaperId)
{
if (strQaPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQaPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQaPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvqa_PaperEN objvqa_PaperEN = vqa_PaperDA.GetObjByQaPaperId(strQaPaperId);
return objvqa_PaperEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvqa_PaperEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvqa_PaperEN objvqa_PaperEN = vqa_PaperDA.GetFirstObj(strWhereCond);
 return objvqa_PaperEN;
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
public static clsvqa_PaperEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvqa_PaperEN objvqa_PaperEN = vqa_PaperDA.GetObjByDataRow(objRow);
 return objvqa_PaperEN;
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
public static clsvqa_PaperEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvqa_PaperEN objvqa_PaperEN = vqa_PaperDA.GetObjByDataRow(objRow);
 return objvqa_PaperEN;
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
 /// <param name = "strQaPaperId">所给的关键字</param>
 /// <param name = "lstvqa_PaperObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_PaperEN GetObjByQaPaperIdFromList(string strQaPaperId, List<clsvqa_PaperEN> lstvqa_PaperObjLst)
{
foreach (clsvqa_PaperEN objvqa_PaperEN in lstvqa_PaperObjLst)
{
if (objvqa_PaperEN.QaPaperId == strQaPaperId)
{
return objvqa_PaperEN;
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
 string strQaPaperId;
 try
 {
 strQaPaperId = new clsvqa_PaperDA().GetFirstID(strWhereCond);
 return strQaPaperId;
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
 arrList = vqa_PaperDA.GetID(strWhereCond);
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
bool bolIsExist = vqa_PaperDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQaPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQaPaperId)
{
if (string.IsNullOrEmpty(strQaPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQaPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vqa_PaperDA.IsExist(strQaPaperId);
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
 bolIsExist = clsvqa_PaperDA.IsExistTable();
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
 bolIsExist = vqa_PaperDA.IsExistTable(strTabName);
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
 /// <param name = "objvqa_PaperENS">源对象</param>
 /// <param name = "objvqa_PaperENT">目标对象</param>
 public static void CopyTo(clsvqa_PaperEN objvqa_PaperENS, clsvqa_PaperEN objvqa_PaperENT)
{
try
{
objvqa_PaperENT.QaPaperId = objvqa_PaperENS.QaPaperId; //论文答疑Id
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
objvqa_PaperENT.IdXzMajor = objvqa_PaperENS.IdXzMajor; //专业流水号
objvqa_PaperENT.MajorName = objvqa_PaperENS.MajorName; //专业名称
objvqa_PaperENT.IdCurrEduCls = objvqa_PaperENS.IdCurrEduCls; //教学班流水号
objvqa_PaperENT.AnswerCount = objvqa_PaperENS.AnswerCount; //回答计数
objvqa_PaperENT.ShareId = objvqa_PaperENS.ShareId; //分享Id
objvqa_PaperENT.TagsCount = objvqa_PaperENS.TagsCount; //论文标注数
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
 /// <param name = "objvqa_PaperEN">源简化对象</param>
 public static void SetUpdFlag(clsvqa_PaperEN objvqa_PaperEN)
{
try
{
objvqa_PaperEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvqa_PaperEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convqa_Paper.QaPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.QaPaperId = objvqa_PaperEN.QaPaperId; //论文答疑Id
}
if (arrFldSet.Contains(convqa_Paper.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.PaperId = objvqa_PaperEN.PaperId == "[null]" ? null :  objvqa_PaperEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convqa_Paper.QuestionsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.QuestionsCount = objvqa_PaperEN.QuestionsCount; //提问计数
}
if (arrFldSet.Contains(convqa_Paper.IsDelete, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.IsDelete = objvqa_PaperEN.IsDelete; //是否删除
}
if (arrFldSet.Contains(convqa_Paper.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.IsPublic = objvqa_PaperEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convqa_Paper.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.IsSubmit = objvqa_PaperEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convqa_Paper.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.UpdUser = objvqa_PaperEN.UpdUser == "[null]" ? null :  objvqa_PaperEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convqa_Paper.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.UserName = objvqa_PaperEN.UserName == "[null]" ? null :  objvqa_PaperEN.UserName; //用户名
}
if (arrFldSet.Contains(convqa_Paper.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.UpdDate = objvqa_PaperEN.UpdDate == "[null]" ? null :  objvqa_PaperEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convqa_Paper.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.Memo = objvqa_PaperEN.Memo == "[null]" ? null :  objvqa_PaperEN.Memo; //备注
}
if (arrFldSet.Contains(convqa_Paper.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.PaperTitle = objvqa_PaperEN.PaperTitle == "[null]" ? null :  objvqa_PaperEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convqa_Paper.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.AttachmentCount = objvqa_PaperEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convqa_Paper.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.PaperContent = objvqa_PaperEN.PaperContent == "[null]" ? null :  objvqa_PaperEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convqa_Paper.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.Periodical = objvqa_PaperEN.Periodical == "[null]" ? null :  objvqa_PaperEN.Periodical; //期刊
}
if (arrFldSet.Contains(convqa_Paper.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.Author = objvqa_PaperEN.Author == "[null]" ? null :  objvqa_PaperEN.Author; //作者
}
if (arrFldSet.Contains(convqa_Paper.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.ResearchQuestion = objvqa_PaperEN.ResearchQuestion == "[null]" ? null :  objvqa_PaperEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convqa_Paper.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.LiteratureSources = objvqa_PaperEN.LiteratureSources == "[null]" ? null :  objvqa_PaperEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convqa_Paper.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.UploadfileUrl = objvqa_PaperEN.UploadfileUrl == "[null]" ? null :  objvqa_PaperEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convqa_Paper.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.IdXzMajor = objvqa_PaperEN.IdXzMajor == "[null]" ? null :  objvqa_PaperEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convqa_Paper.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.MajorName = objvqa_PaperEN.MajorName == "[null]" ? null :  objvqa_PaperEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convqa_Paper.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.IdCurrEduCls = objvqa_PaperEN.IdCurrEduCls == "[null]" ? null :  objvqa_PaperEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convqa_Paper.AnswerCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.AnswerCount = objvqa_PaperEN.AnswerCount; //回答计数
}
if (arrFldSet.Contains(convqa_Paper.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.ShareId = objvqa_PaperEN.ShareId == "[null]" ? null :  objvqa_PaperEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convqa_Paper.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvqa_PaperEN.TagsCount = objvqa_PaperEN.TagsCount; //论文标注数
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
 /// <param name = "objvqa_PaperEN">源简化对象</param>
 public static void AccessFldValueNull(clsvqa_PaperEN objvqa_PaperEN)
{
try
{
if (objvqa_PaperEN.PaperId == "[null]") objvqa_PaperEN.PaperId = null; //论文Id
if (objvqa_PaperEN.UpdUser == "[null]") objvqa_PaperEN.UpdUser = null; //修改人
if (objvqa_PaperEN.UserName == "[null]") objvqa_PaperEN.UserName = null; //用户名
if (objvqa_PaperEN.UpdDate == "[null]") objvqa_PaperEN.UpdDate = null; //修改日期
if (objvqa_PaperEN.Memo == "[null]") objvqa_PaperEN.Memo = null; //备注
if (objvqa_PaperEN.PaperTitle == "[null]") objvqa_PaperEN.PaperTitle = null; //论文标题
if (objvqa_PaperEN.PaperContent == "[null]") objvqa_PaperEN.PaperContent = null; //主题内容
if (objvqa_PaperEN.Periodical == "[null]") objvqa_PaperEN.Periodical = null; //期刊
if (objvqa_PaperEN.Author == "[null]") objvqa_PaperEN.Author = null; //作者
if (objvqa_PaperEN.ResearchQuestion == "[null]") objvqa_PaperEN.ResearchQuestion = null; //研究问题
if (objvqa_PaperEN.LiteratureSources == "[null]") objvqa_PaperEN.LiteratureSources = null; //文献来源
if (objvqa_PaperEN.UploadfileUrl == "[null]") objvqa_PaperEN.UploadfileUrl = null; //文件地址
if (objvqa_PaperEN.IdXzMajor == "[null]") objvqa_PaperEN.IdXzMajor = null; //专业流水号
if (objvqa_PaperEN.MajorName == "[null]") objvqa_PaperEN.MajorName = null; //专业名称
if (objvqa_PaperEN.IdCurrEduCls == "[null]") objvqa_PaperEN.IdCurrEduCls = null; //教学班流水号
if (objvqa_PaperEN.ShareId == "[null]") objvqa_PaperEN.ShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvqa_PaperEN objvqa_PaperEN)
{
 vqa_PaperDA.CheckProperty4Condition(objvqa_PaperEN);
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
if (clsqa_PaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PaperBL没有刷新缓存机制(clsqa_PaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by QaPaperId");
//if (arrvqa_PaperObjLstCache == null)
//{
//arrvqa_PaperObjLstCache = vqa_PaperDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQaPaperId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvqa_PaperEN GetObjByQaPaperIdCache(string strQaPaperId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strIdCurrEduCls);
List<clsvqa_PaperEN> arrvqa_PaperObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvqa_PaperEN> arrvqa_PaperObjLst_Sel =
arrvqa_PaperObjLstCache
.Where(x=> x.QaPaperId == strQaPaperId 
);
if (arrvqa_PaperObjLst_Sel.Count() == 0)
{
   clsvqa_PaperEN obj = clsvqa_PaperBL.GetObjByQaPaperId(strQaPaperId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strQaPaperId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvqa_PaperObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_PaperEN> GetAllvqa_PaperObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvqa_PaperEN> arrvqa_PaperObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvqa_PaperObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvqa_PaperEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvqa_PaperEN> arrvqa_PaperObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvqa_PaperObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvqa_PaperEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, string strQaPaperId, string strIdCurrEduCls)
{
if (strInFldName != convqa_Paper.QaPaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convqa_Paper.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convqa_Paper.AttributeName));
throw new Exception(strMsg);
}
var objvqa_Paper = clsvqa_PaperBL.GetObjByQaPaperIdCache(strQaPaperId, strIdCurrEduCls);
if (objvqa_Paper == null) return "";
return objvqa_Paper[strOutFldName].ToString();
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
int intRecCount = clsvqa_PaperDA.GetRecCount(strTabName);
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
int intRecCount = clsvqa_PaperDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvqa_PaperDA.GetRecCount();
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
int intRecCount = clsvqa_PaperDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvqa_PaperCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvqa_PaperEN objvqa_PaperCond)
{
 string strIdCurrEduCls = objvqa_PaperCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvqa_PaperBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvqa_PaperEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvqa_PaperEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convqa_Paper.AttributeName)
{
if (objvqa_PaperCond.IsUpdated(strFldName) == false) continue;
if (objvqa_PaperCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PaperCond[strFldName].ToString());
}
else
{
if (objvqa_PaperCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvqa_PaperCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvqa_PaperCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvqa_PaperCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvqa_PaperCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvqa_PaperCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvqa_PaperCond[strFldName]));
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
 List<string> arrList = clsvqa_PaperDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vqa_PaperDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vqa_PaperDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}