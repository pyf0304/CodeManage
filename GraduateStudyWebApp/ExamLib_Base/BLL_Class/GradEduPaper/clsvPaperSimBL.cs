
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSimBL
 表名:vPaperSim(01120597)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:27
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
public static class  clsvPaperSimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSimEN GetObj(this K_PaperId_vPaperSim myKey)
{
clsvPaperSimEN objvPaperSimEN = clsvPaperSimBL.vPaperSimDA.GetObjByPaperId(myKey.Value);
return objvPaperSimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetPaperId(this clsvPaperSimEN objvPaperSimEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperSim.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperSim.PaperId);
}
objvPaperSimEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.PaperId) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.PaperId, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.PaperId] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetPaperTitle(this clsvPaperSimEN objvPaperSimEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convPaperSim.PaperTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperSim.PaperTitle);
}
objvPaperSimEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.PaperTitle) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.PaperTitle, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.PaperTitle] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetPaperContent(this clsvPaperSimEN objvPaperSimEN, string strPaperContent, string strComparisonOp="")
	{
objvPaperSimEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.PaperContent) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.PaperContent, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.PaperContent] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetPeriodical(this clsvPaperSimEN objvPaperSimEN, string strPeriodical, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convPaperSim.Periodical);
}
objvPaperSimEN.Periodical = strPeriodical; //期刊
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.Periodical) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.Periodical, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.Periodical] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetAuthor(this clsvPaperSimEN objvPaperSimEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperSim.Author);
}
objvPaperSimEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.Author) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.Author, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.Author] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetResearchQuestion(this clsvPaperSimEN objvPaperSimEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convPaperSim.ResearchQuestion);
}
objvPaperSimEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.ResearchQuestion) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.ResearchQuestion, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.ResearchQuestion] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetUpdDate(this clsvPaperSimEN objvPaperSimEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convPaperSim.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSim.UpdDate);
}
objvPaperSimEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.UpdDate) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.UpdDate, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.UpdDate] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetUserName(this clsvPaperSimEN objvPaperSimEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convPaperSim.UserName);
}
objvPaperSimEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.UserName) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.UserName, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.UserName] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetIdXzCollege(this clsvPaperSimEN objvPaperSimEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convPaperSim.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convPaperSim.IdXzCollege);
}
objvPaperSimEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.IdXzCollege) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.IdXzCollege, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.IdXzCollege] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetCollegeName(this clsvPaperSimEN objvPaperSimEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convPaperSim.CollegeName);
}
objvPaperSimEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.CollegeName) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.CollegeName, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.CollegeName] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetIdXzMajor(this clsvPaperSimEN objvPaperSimEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convPaperSim.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convPaperSim.IdXzMajor);
}
objvPaperSimEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.IdXzMajor) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.IdXzMajor, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.IdXzMajor] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetMajorName(this clsvPaperSimEN objvPaperSimEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convPaperSim.MajorName);
}
objvPaperSimEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.MajorName) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.MajorName, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.MajorName] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetKeyword(this clsvPaperSimEN objvPaperSimEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperSim.Keyword);
}
objvPaperSimEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.Keyword) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.Keyword, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.Keyword] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureSources(this clsvPaperSimEN objvPaperSimEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convPaperSim.LiteratureSources);
}
objvPaperSimEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.LiteratureSources) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.LiteratureSources, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.LiteratureSources] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureLink(this clsvPaperSimEN objvPaperSimEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convPaperSim.LiteratureLink);
}
objvPaperSimEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.LiteratureLink) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.LiteratureLink, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.LiteratureLink] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetUploadfileUrl(this clsvPaperSimEN objvPaperSimEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convPaperSim.UploadfileUrl);
}
objvPaperSimEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.UploadfileUrl) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.UploadfileUrl, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.UploadfileUrl] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetIsQuotethesis(this clsvPaperSimEN objvPaperSimEN, bool bolIsQuotethesis, string strComparisonOp="")
	{
objvPaperSimEN.IsQuotethesis = bolIsQuotethesis; //是否引用论文
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.IsQuotethesis) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.IsQuotethesis, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.IsQuotethesis] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetQuoteId(this clsvPaperSimEN objvPaperSimEN, string strQuoteId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuoteId, 8, convPaperSim.QuoteId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, convPaperSim.QuoteId);
}
objvPaperSimEN.QuoteId = strQuoteId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.QuoteId) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.QuoteId, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.QuoteId] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetChecker(this clsvPaperSimEN objvPaperSimEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, convPaperSim.Checker);
}
objvPaperSimEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.Checker) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.Checker, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.Checker] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetIsChecked(this clsvPaperSimEN objvPaperSimEN, bool bolIsChecked, string strComparisonOp="")
	{
objvPaperSimEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.IsChecked) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.IsChecked, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.IsChecked] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureTypeId(this clsvPaperSimEN objvPaperSimEN, string strLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLiteratureTypeId, convPaperSim.LiteratureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, convPaperSim.LiteratureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, convPaperSim.LiteratureTypeId);
}
objvPaperSimEN.LiteratureTypeId = strLiteratureTypeId; //作文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.LiteratureTypeId) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.LiteratureTypeId, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.LiteratureTypeId] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetBrowseNumber(this clsvPaperSimEN objvPaperSimEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvPaperSimEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.BrowseNumber) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.BrowseNumber, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.BrowseNumber] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureTypeName(this clsvPaperSimEN objvPaperSimEN, string strLiteratureTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureTypeName, 100, convPaperSim.LiteratureTypeName);
}
objvPaperSimEN.LiteratureTypeName = strLiteratureTypeName; //作文类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.LiteratureTypeName) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.LiteratureTypeName, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.LiteratureTypeName] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetIsSubmit(this clsvPaperSimEN objvPaperSimEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvPaperSimEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.IsSubmit) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.IsSubmit, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.IsSubmit] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetAppraiseCount(this clsvPaperSimEN objvPaperSimEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvPaperSimEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.AppraiseCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.AppraiseCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.AppraiseCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetAttachmentCount(this clsvPaperSimEN objvPaperSimEN, int? intAttachmentCount, string strComparisonOp="")
	{
objvPaperSimEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.AttachmentCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.AttachmentCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.AttachmentCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetCollectionCount(this clsvPaperSimEN objvPaperSimEN, long? lngCollectionCount, string strComparisonOp="")
	{
objvPaperSimEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.CollectionCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.CollectionCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.CollectionCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetDownloadCount(this clsvPaperSimEN objvPaperSimEN, int? intDownloadCount, string strComparisonOp="")
	{
objvPaperSimEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.DownloadCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.DownloadCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.DownloadCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetMemo(this clsvPaperSimEN objvPaperSimEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperSim.Memo);
}
objvPaperSimEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.Memo) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.Memo, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.Memo] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetOkCount(this clsvPaperSimEN objvPaperSimEN, int? intOkCount, string strComparisonOp="")
	{
objvPaperSimEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.OkCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.OkCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.OkCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetPcount(this clsvPaperSimEN objvPaperSimEN, int? intPcount, string strComparisonOp="")
	{
objvPaperSimEN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.Pcount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.Pcount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.Pcount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetScore(this clsvPaperSimEN objvPaperSimEN, float? fltScore, string strComparisonOp="")
	{
objvPaperSimEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.Score) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.Score, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.Score] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetStuScore(this clsvPaperSimEN objvPaperSimEN, float? fltStuScore, string strComparisonOp="")
	{
objvPaperSimEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.StuScore) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.StuScore, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.StuScore] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetTeaScore(this clsvPaperSimEN objvPaperSimEN, float? fltTeaScore, string strComparisonOp="")
	{
objvPaperSimEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.TeaScore) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.TeaScore, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.TeaScore] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetPaperQCount(this clsvPaperSimEN objvPaperSimEN, int? intPaperQCount, string strComparisonOp="")
	{
objvPaperSimEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.PaperQCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.PaperQCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.PaperQCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetSubVCount(this clsvPaperSimEN objvPaperSimEN, int? intSubVCount, string strComparisonOp="")
	{
objvPaperSimEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.SubVCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.SubVCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.SubVCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetTagsCount(this clsvPaperSimEN objvPaperSimEN, int? intTagsCount, string strComparisonOp="")
	{
objvPaperSimEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.TagsCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.TagsCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.TagsCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetTeaQCount(this clsvPaperSimEN objvPaperSimEN, int? intTeaQCount, string strComparisonOp="")
	{
objvPaperSimEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.TeaQCount) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.TeaQCount, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.TeaQCount] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSimEN SetUpdUser(this clsvPaperSimEN objvPaperSimEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperSim.UpdUser);
}
objvPaperSimEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.UpdUser) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.UpdUser, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.UpdUser] = strComparisonOp;
}
}
return objvPaperSimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperSimENS">源对象</param>
 /// <param name = "objvPaperSimENT">目标对象</param>
 public static void CopyTo(this clsvPaperSimEN objvPaperSimENS, clsvPaperSimEN objvPaperSimENT)
{
try
{
objvPaperSimENT.PaperId = objvPaperSimENS.PaperId; //论文Id
objvPaperSimENT.PaperTitle = objvPaperSimENS.PaperTitle; //论文标题
objvPaperSimENT.PaperContent = objvPaperSimENS.PaperContent; //主题内容
objvPaperSimENT.Periodical = objvPaperSimENS.Periodical; //期刊
objvPaperSimENT.Author = objvPaperSimENS.Author; //作者
objvPaperSimENT.ResearchQuestion = objvPaperSimENS.ResearchQuestion; //研究问题
objvPaperSimENT.UpdDate = objvPaperSimENS.UpdDate; //修改日期
objvPaperSimENT.UserName = objvPaperSimENS.UserName; //用户名
objvPaperSimENT.IdXzCollege = objvPaperSimENS.IdXzCollege; //学院流水号
objvPaperSimENT.CollegeName = objvPaperSimENS.CollegeName; //学院名称
objvPaperSimENT.IdXzMajor = objvPaperSimENS.IdXzMajor; //专业流水号
objvPaperSimENT.MajorName = objvPaperSimENS.MajorName; //专业名称
objvPaperSimENT.Keyword = objvPaperSimENS.Keyword; //关键字
objvPaperSimENT.LiteratureSources = objvPaperSimENS.LiteratureSources; //文献来源
objvPaperSimENT.LiteratureLink = objvPaperSimENS.LiteratureLink; //文献链接
objvPaperSimENT.UploadfileUrl = objvPaperSimENS.UploadfileUrl; //文件地址
objvPaperSimENT.IsQuotethesis = objvPaperSimENS.IsQuotethesis; //是否引用论文
objvPaperSimENT.QuoteId = objvPaperSimENS.QuoteId; //引用Id
objvPaperSimENT.Checker = objvPaperSimENS.Checker; //审核人
objvPaperSimENT.IsChecked = objvPaperSimENS.IsChecked; //是否检查
objvPaperSimENT.LiteratureTypeId = objvPaperSimENS.LiteratureTypeId; //作文类型Id
objvPaperSimENT.BrowseNumber = objvPaperSimENS.BrowseNumber; //浏览量
objvPaperSimENT.LiteratureTypeName = objvPaperSimENS.LiteratureTypeName; //作文类型名
objvPaperSimENT.IsSubmit = objvPaperSimENS.IsSubmit; //是否提交
objvPaperSimENT.AppraiseCount = objvPaperSimENS.AppraiseCount; //评论数
objvPaperSimENT.AttachmentCount = objvPaperSimENS.AttachmentCount; //附件计数
objvPaperSimENT.CollectionCount = objvPaperSimENS.CollectionCount; //收藏数量
objvPaperSimENT.DownloadCount = objvPaperSimENS.DownloadCount; //下载数
objvPaperSimENT.Memo = objvPaperSimENS.Memo; //备注
objvPaperSimENT.OkCount = objvPaperSimENS.OkCount; //点赞统计
objvPaperSimENT.Pcount = objvPaperSimENS.Pcount; //读写数
objvPaperSimENT.Score = objvPaperSimENS.Score; //评分
objvPaperSimENT.StuScore = objvPaperSimENS.StuScore; //学生平均分
objvPaperSimENT.TeaScore = objvPaperSimENS.TeaScore; //教师评分
objvPaperSimENT.PaperQCount = objvPaperSimENS.PaperQCount; //论文答疑数
objvPaperSimENT.SubVCount = objvPaperSimENS.SubVCount; //论文子观点数
objvPaperSimENT.TagsCount = objvPaperSimENS.TagsCount; //论文标注数
objvPaperSimENT.TeaQCount = objvPaperSimENS.TeaQCount; //教师提问数
objvPaperSimENT.UpdUser = objvPaperSimENS.UpdUser; //修改人
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
 /// <param name = "objvPaperSimENS">源对象</param>
 /// <returns>目标对象=>clsvPaperSimEN:objvPaperSimENT</returns>
 public static clsvPaperSimEN CopyTo(this clsvPaperSimEN objvPaperSimENS)
{
try
{
 clsvPaperSimEN objvPaperSimENT = new clsvPaperSimEN()
{
PaperId = objvPaperSimENS.PaperId, //论文Id
PaperTitle = objvPaperSimENS.PaperTitle, //论文标题
PaperContent = objvPaperSimENS.PaperContent, //主题内容
Periodical = objvPaperSimENS.Periodical, //期刊
Author = objvPaperSimENS.Author, //作者
ResearchQuestion = objvPaperSimENS.ResearchQuestion, //研究问题
UpdDate = objvPaperSimENS.UpdDate, //修改日期
UserName = objvPaperSimENS.UserName, //用户名
IdXzCollege = objvPaperSimENS.IdXzCollege, //学院流水号
CollegeName = objvPaperSimENS.CollegeName, //学院名称
IdXzMajor = objvPaperSimENS.IdXzMajor, //专业流水号
MajorName = objvPaperSimENS.MajorName, //专业名称
Keyword = objvPaperSimENS.Keyword, //关键字
LiteratureSources = objvPaperSimENS.LiteratureSources, //文献来源
LiteratureLink = objvPaperSimENS.LiteratureLink, //文献链接
UploadfileUrl = objvPaperSimENS.UploadfileUrl, //文件地址
IsQuotethesis = objvPaperSimENS.IsQuotethesis, //是否引用论文
QuoteId = objvPaperSimENS.QuoteId, //引用Id
Checker = objvPaperSimENS.Checker, //审核人
IsChecked = objvPaperSimENS.IsChecked, //是否检查
LiteratureTypeId = objvPaperSimENS.LiteratureTypeId, //作文类型Id
BrowseNumber = objvPaperSimENS.BrowseNumber, //浏览量
LiteratureTypeName = objvPaperSimENS.LiteratureTypeName, //作文类型名
IsSubmit = objvPaperSimENS.IsSubmit, //是否提交
AppraiseCount = objvPaperSimENS.AppraiseCount, //评论数
AttachmentCount = objvPaperSimENS.AttachmentCount, //附件计数
CollectionCount = objvPaperSimENS.CollectionCount, //收藏数量
DownloadCount = objvPaperSimENS.DownloadCount, //下载数
Memo = objvPaperSimENS.Memo, //备注
OkCount = objvPaperSimENS.OkCount, //点赞统计
Pcount = objvPaperSimENS.Pcount, //读写数
Score = objvPaperSimENS.Score, //评分
StuScore = objvPaperSimENS.StuScore, //学生平均分
TeaScore = objvPaperSimENS.TeaScore, //教师评分
PaperQCount = objvPaperSimENS.PaperQCount, //论文答疑数
SubVCount = objvPaperSimENS.SubVCount, //论文子观点数
TagsCount = objvPaperSimENS.TagsCount, //论文标注数
TeaQCount = objvPaperSimENS.TeaQCount, //教师提问数
UpdUser = objvPaperSimENS.UpdUser, //修改人
};
 return objvPaperSimENT;
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
public static void CheckProperty4Condition(this clsvPaperSimEN objvPaperSimEN)
{
 clsvPaperSimBL.vPaperSimDA.CheckProperty4Condition(objvPaperSimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSimEN objvPaperSimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSimCond.IsUpdated(convPaperSim.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperSimCond.dicFldComparisonOp[convPaperSim.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.PaperId, objvPaperSimCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperSimCond.dicFldComparisonOp[convPaperSim.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.PaperTitle, objvPaperSimCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvPaperSimCond.IsUpdated(convPaperSim.Periodical) == true)
{
string strComparisonOpPeriodical = objvPaperSimCond.dicFldComparisonOp[convPaperSim.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Periodical, objvPaperSimCond.Periodical, strComparisonOpPeriodical);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.Author) == true)
{
string strComparisonOpAuthor = objvPaperSimCond.dicFldComparisonOp[convPaperSim.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Author, objvPaperSimCond.Author, strComparisonOpAuthor);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvPaperSimCond.dicFldComparisonOp[convPaperSim.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.ResearchQuestion, objvPaperSimCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperSimCond.dicFldComparisonOp[convPaperSim.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UpdDate, objvPaperSimCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.UserName) == true)
{
string strComparisonOpUserName = objvPaperSimCond.dicFldComparisonOp[convPaperSim.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UserName, objvPaperSimCond.UserName, strComparisonOpUserName);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvPaperSimCond.dicFldComparisonOp[convPaperSim.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.IdXzCollege, objvPaperSimCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.CollegeName) == true)
{
string strComparisonOpCollegeName = objvPaperSimCond.dicFldComparisonOp[convPaperSim.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.CollegeName, objvPaperSimCond.CollegeName, strComparisonOpCollegeName);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvPaperSimCond.dicFldComparisonOp[convPaperSim.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.IdXzMajor, objvPaperSimCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.MajorName) == true)
{
string strComparisonOpMajorName = objvPaperSimCond.dicFldComparisonOp[convPaperSim.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.MajorName, objvPaperSimCond.MajorName, strComparisonOpMajorName);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.Keyword) == true)
{
string strComparisonOpKeyword = objvPaperSimCond.dicFldComparisonOp[convPaperSim.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Keyword, objvPaperSimCond.Keyword, strComparisonOpKeyword);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objvPaperSimCond.dicFldComparisonOp[convPaperSim.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureSources, objvPaperSimCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objvPaperSimCond.dicFldComparisonOp[convPaperSim.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureLink, objvPaperSimCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objvPaperSimCond.dicFldComparisonOp[convPaperSim.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UploadfileUrl, objvPaperSimCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.IsQuotethesis) == true)
{
if (objvPaperSimCond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSim.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSim.IsQuotethesis);
}
}
if (objvPaperSimCond.IsUpdated(convPaperSim.QuoteId) == true)
{
string strComparisonOpQuoteId = objvPaperSimCond.dicFldComparisonOp[convPaperSim.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.QuoteId, objvPaperSimCond.QuoteId, strComparisonOpQuoteId);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.Checker) == true)
{
string strComparisonOpChecker = objvPaperSimCond.dicFldComparisonOp[convPaperSim.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Checker, objvPaperSimCond.Checker, strComparisonOpChecker);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.IsChecked) == true)
{
if (objvPaperSimCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSim.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSim.IsChecked);
}
}
if (objvPaperSimCond.IsUpdated(convPaperSim.LiteratureTypeId) == true)
{
string strComparisonOpLiteratureTypeId = objvPaperSimCond.dicFldComparisonOp[convPaperSim.LiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureTypeId, objvPaperSimCond.LiteratureTypeId, strComparisonOpLiteratureTypeId);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvPaperSimCond.dicFldComparisonOp[convPaperSim.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.BrowseNumber, objvPaperSimCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.LiteratureTypeName) == true)
{
string strComparisonOpLiteratureTypeName = objvPaperSimCond.dicFldComparisonOp[convPaperSim.LiteratureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureTypeName, objvPaperSimCond.LiteratureTypeName, strComparisonOpLiteratureTypeName);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.IsSubmit) == true)
{
if (objvPaperSimCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSim.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSim.IsSubmit);
}
}
if (objvPaperSimCond.IsUpdated(convPaperSim.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.AppraiseCount, objvPaperSimCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.AttachmentCount, objvPaperSimCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.CollectionCount, objvPaperSimCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.DownloadCount, objvPaperSimCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.Memo) == true)
{
string strComparisonOpMemo = objvPaperSimCond.dicFldComparisonOp[convPaperSim.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Memo, objvPaperSimCond.Memo, strComparisonOpMemo);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.OkCount) == true)
{
string strComparisonOpOkCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.OkCount, objvPaperSimCond.OkCount, strComparisonOpOkCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.Pcount) == true)
{
string strComparisonOpPcount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.Pcount, objvPaperSimCond.Pcount, strComparisonOpPcount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.Score) == true)
{
string strComparisonOpScore = objvPaperSimCond.dicFldComparisonOp[convPaperSim.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.Score, objvPaperSimCond.Score, strComparisonOpScore);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.StuScore) == true)
{
string strComparisonOpStuScore = objvPaperSimCond.dicFldComparisonOp[convPaperSim.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.StuScore, objvPaperSimCond.StuScore, strComparisonOpStuScore);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.TeaScore) == true)
{
string strComparisonOpTeaScore = objvPaperSimCond.dicFldComparisonOp[convPaperSim.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.TeaScore, objvPaperSimCond.TeaScore, strComparisonOpTeaScore);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.PaperQCount, objvPaperSimCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.SubVCount) == true)
{
string strComparisonOpSubVCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.SubVCount, objvPaperSimCond.SubVCount, strComparisonOpSubVCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.TagsCount) == true)
{
string strComparisonOpTagsCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.TagsCount, objvPaperSimCond.TagsCount, strComparisonOpTagsCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objvPaperSimCond.dicFldComparisonOp[convPaperSim.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.TeaQCount, objvPaperSimCond.TeaQCount, strComparisonOpTeaQCount);
}
if (objvPaperSimCond.IsUpdated(convPaperSim.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperSimCond.dicFldComparisonOp[convPaperSim.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UpdUser, objvPaperSimCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperSim
{
public virtual bool UpdRelaTabDate(string strPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文简化视图(vPaperSim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSimBL
{
public static RelatedActions_vPaperSim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperSimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperSimDA vPaperSimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperSimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperSimBL()
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
if (string.IsNullOrEmpty(clsvPaperSimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSimEN._ConnectString);
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
public static DataTable GetDataTable_vPaperSim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperSimDA.GetDataTable_vPaperSim(strWhereCond);
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
objDT = vPaperSimDA.GetDataTable(strWhereCond);
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
objDT = vPaperSimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperSimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperSimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperSimDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperSimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperSimEN> GetObjLstByPaperIdLst(List<string> arrPaperIdLst)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperIdLst, true);
 string strWhereCond = string.Format("PaperId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperSimEN> GetObjLstByPaperIdLstCache(List<string> arrPaperIdLst)
{
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName);
List<clsvPaperSimEN> arrvPaperSimObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSimEN> arrvPaperSimObjLst_Sel =
arrvPaperSimObjLstCache
.Where(x => arrPaperIdLst.Contains(x.PaperId));
return arrvPaperSimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSimEN> GetObjLst(string strWhereCond)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
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
public static List<clsvPaperSimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperSimEN> GetSubObjLstCache(clsvPaperSimEN objvPaperSimCond)
{
List<clsvPaperSimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSim.AttributeName)
{
if (objvPaperSimCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSimCond[strFldName].ToString());
}
else
{
if (objvPaperSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSimCond[strFldName]));
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
public static List<clsvPaperSimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
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
public static List<clsvPaperSimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
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
List<clsvPaperSimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperSimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperSimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
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
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
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
public static List<clsvPaperSimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperSimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
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
public static List<clsvPaperSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperSimEN> arrObjLst = new List<clsvPaperSimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSimEN objvPaperSimEN = new clsvPaperSimEN();
try
{
objvPaperSimEN.PaperId = objRow[convPaperSim.PaperId].ToString().Trim(); //论文Id
objvPaperSimEN.PaperTitle = objRow[convPaperSim.PaperTitle].ToString().Trim(); //论文标题
objvPaperSimEN.PaperContent = objRow[convPaperSim.PaperContent] == DBNull.Value ? null : objRow[convPaperSim.PaperContent].ToString().Trim(); //主题内容
objvPaperSimEN.Periodical = objRow[convPaperSim.Periodical] == DBNull.Value ? null : objRow[convPaperSim.Periodical].ToString().Trim(); //期刊
objvPaperSimEN.Author = objRow[convPaperSim.Author] == DBNull.Value ? null : objRow[convPaperSim.Author].ToString().Trim(); //作者
objvPaperSimEN.ResearchQuestion = objRow[convPaperSim.ResearchQuestion] == DBNull.Value ? null : objRow[convPaperSim.ResearchQuestion].ToString().Trim(); //研究问题
objvPaperSimEN.UpdDate = objRow[convPaperSim.UpdDate].ToString().Trim(); //修改日期
objvPaperSimEN.UserName = objRow[convPaperSim.UserName] == DBNull.Value ? null : objRow[convPaperSim.UserName].ToString().Trim(); //用户名
objvPaperSimEN.IdXzCollege = objRow[convPaperSim.IdXzCollege] == DBNull.Value ? null : objRow[convPaperSim.IdXzCollege].ToString().Trim(); //学院流水号
objvPaperSimEN.CollegeName = objRow[convPaperSim.CollegeName] == DBNull.Value ? null : objRow[convPaperSim.CollegeName].ToString().Trim(); //学院名称
objvPaperSimEN.IdXzMajor = objRow[convPaperSim.IdXzMajor] == DBNull.Value ? null : objRow[convPaperSim.IdXzMajor].ToString().Trim(); //专业流水号
objvPaperSimEN.MajorName = objRow[convPaperSim.MajorName] == DBNull.Value ? null : objRow[convPaperSim.MajorName].ToString().Trim(); //专业名称
objvPaperSimEN.Keyword = objRow[convPaperSim.Keyword] == DBNull.Value ? null : objRow[convPaperSim.Keyword].ToString().Trim(); //关键字
objvPaperSimEN.LiteratureSources = objRow[convPaperSim.LiteratureSources] == DBNull.Value ? null : objRow[convPaperSim.LiteratureSources].ToString().Trim(); //文献来源
objvPaperSimEN.LiteratureLink = objRow[convPaperSim.LiteratureLink] == DBNull.Value ? null : objRow[convPaperSim.LiteratureLink].ToString().Trim(); //文献链接
objvPaperSimEN.UploadfileUrl = objRow[convPaperSim.UploadfileUrl] == DBNull.Value ? null : objRow[convPaperSim.UploadfileUrl].ToString().Trim(); //文件地址
objvPaperSimEN.IsQuotethesis = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsQuotethesis].ToString().Trim()); //是否引用论文
objvPaperSimEN.QuoteId = objRow[convPaperSim.QuoteId] == DBNull.Value ? null : objRow[convPaperSim.QuoteId].ToString().Trim(); //引用Id
objvPaperSimEN.Checker = objRow[convPaperSim.Checker] == DBNull.Value ? null : objRow[convPaperSim.Checker].ToString().Trim(); //审核人
objvPaperSimEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsChecked].ToString().Trim()); //是否检查
objvPaperSimEN.LiteratureTypeId = objRow[convPaperSim.LiteratureTypeId].ToString().Trim(); //作文类型Id
objvPaperSimEN.BrowseNumber = objRow[convPaperSim.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.BrowseNumber].ToString().Trim()); //浏览量
objvPaperSimEN.LiteratureTypeName = objRow[convPaperSim.LiteratureTypeName] == DBNull.Value ? null : objRow[convPaperSim.LiteratureTypeName].ToString().Trim(); //作文类型名
objvPaperSimEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSim.IsSubmit].ToString().Trim()); //是否提交
objvPaperSimEN.AppraiseCount = objRow[convPaperSim.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AppraiseCount].ToString().Trim()); //评论数
objvPaperSimEN.AttachmentCount = objRow[convPaperSim.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.AttachmentCount].ToString().Trim()); //附件计数
objvPaperSimEN.CollectionCount = objRow[convPaperSim.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.CollectionCount].ToString().Trim()); //收藏数量
objvPaperSimEN.DownloadCount = objRow[convPaperSim.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.DownloadCount].ToString().Trim()); //下载数
objvPaperSimEN.Memo = objRow[convPaperSim.Memo] == DBNull.Value ? null : objRow[convPaperSim.Memo].ToString().Trim(); //备注
objvPaperSimEN.OkCount = objRow[convPaperSim.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.OkCount].ToString().Trim()); //点赞统计
objvPaperSimEN.Pcount = objRow[convPaperSim.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.Pcount].ToString().Trim()); //读写数
objvPaperSimEN.Score = objRow[convPaperSim.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.Score].ToString().Trim()); //评分
objvPaperSimEN.StuScore = objRow[convPaperSim.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.StuScore].ToString().Trim()); //学生平均分
objvPaperSimEN.TeaScore = objRow[convPaperSim.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSim.TeaScore].ToString().Trim()); //教师评分
objvPaperSimEN.PaperQCount = objRow[convPaperSim.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.PaperQCount].ToString().Trim()); //论文答疑数
objvPaperSimEN.SubVCount = objRow[convPaperSim.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.SubVCount].ToString().Trim()); //论文子观点数
objvPaperSimEN.TagsCount = objRow[convPaperSim.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TagsCount].ToString().Trim()); //论文标注数
objvPaperSimEN.TeaQCount = objRow[convPaperSim.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSim.TeaQCount].ToString().Trim()); //教师提问数
objvPaperSimEN.UpdUser = objRow[convPaperSim.UpdUser] == DBNull.Value ? null : objRow[convPaperSim.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSimEN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperSimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperSim(ref clsvPaperSimEN objvPaperSimEN)
{
bool bolResult = vPaperSimDA.GetvPaperSim(ref objvPaperSimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSimEN GetObjByPaperId(string strPaperId)
{
if (strPaperId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPaperId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPaperId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPaperSimEN objvPaperSimEN = vPaperSimDA.GetObjByPaperId(strPaperId);
return objvPaperSimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperSimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperSimEN objvPaperSimEN = vPaperSimDA.GetFirstObj(strWhereCond);
 return objvPaperSimEN;
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
public static clsvPaperSimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperSimEN objvPaperSimEN = vPaperSimDA.GetObjByDataRow(objRow);
 return objvPaperSimEN;
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
public static clsvPaperSimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperSimEN objvPaperSimEN = vPaperSimDA.GetObjByDataRow(objRow);
 return objvPaperSimEN;
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
 /// <param name = "strPaperId">所给的关键字</param>
 /// <param name = "lstvPaperSimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSimEN GetObjByPaperIdFromList(string strPaperId, List<clsvPaperSimEN> lstvPaperSimObjLst)
{
foreach (clsvPaperSimEN objvPaperSimEN in lstvPaperSimObjLst)
{
if (objvPaperSimEN.PaperId == strPaperId)
{
return objvPaperSimEN;
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
 string strPaperId;
 try
 {
 strPaperId = new clsvPaperSimDA().GetFirstID(strWhereCond);
 return strPaperId;
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
 arrList = vPaperSimDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperSimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPaperId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPaperId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPaperSimDA.IsExist(strPaperId);
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
 bolIsExist = clsvPaperSimDA.IsExistTable();
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
 bolIsExist = vPaperSimDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperSimENS">源对象</param>
 /// <param name = "objvPaperSimENT">目标对象</param>
 public static void CopyTo(clsvPaperSimEN objvPaperSimENS, clsvPaperSimEN objvPaperSimENT)
{
try
{
objvPaperSimENT.PaperId = objvPaperSimENS.PaperId; //论文Id
objvPaperSimENT.PaperTitle = objvPaperSimENS.PaperTitle; //论文标题
objvPaperSimENT.PaperContent = objvPaperSimENS.PaperContent; //主题内容
objvPaperSimENT.Periodical = objvPaperSimENS.Periodical; //期刊
objvPaperSimENT.Author = objvPaperSimENS.Author; //作者
objvPaperSimENT.ResearchQuestion = objvPaperSimENS.ResearchQuestion; //研究问题
objvPaperSimENT.UpdDate = objvPaperSimENS.UpdDate; //修改日期
objvPaperSimENT.UserName = objvPaperSimENS.UserName; //用户名
objvPaperSimENT.IdXzCollege = objvPaperSimENS.IdXzCollege; //学院流水号
objvPaperSimENT.CollegeName = objvPaperSimENS.CollegeName; //学院名称
objvPaperSimENT.IdXzMajor = objvPaperSimENS.IdXzMajor; //专业流水号
objvPaperSimENT.MajorName = objvPaperSimENS.MajorName; //专业名称
objvPaperSimENT.Keyword = objvPaperSimENS.Keyword; //关键字
objvPaperSimENT.LiteratureSources = objvPaperSimENS.LiteratureSources; //文献来源
objvPaperSimENT.LiteratureLink = objvPaperSimENS.LiteratureLink; //文献链接
objvPaperSimENT.UploadfileUrl = objvPaperSimENS.UploadfileUrl; //文件地址
objvPaperSimENT.IsQuotethesis = objvPaperSimENS.IsQuotethesis; //是否引用论文
objvPaperSimENT.QuoteId = objvPaperSimENS.QuoteId; //引用Id
objvPaperSimENT.Checker = objvPaperSimENS.Checker; //审核人
objvPaperSimENT.IsChecked = objvPaperSimENS.IsChecked; //是否检查
objvPaperSimENT.LiteratureTypeId = objvPaperSimENS.LiteratureTypeId; //作文类型Id
objvPaperSimENT.BrowseNumber = objvPaperSimENS.BrowseNumber; //浏览量
objvPaperSimENT.LiteratureTypeName = objvPaperSimENS.LiteratureTypeName; //作文类型名
objvPaperSimENT.IsSubmit = objvPaperSimENS.IsSubmit; //是否提交
objvPaperSimENT.AppraiseCount = objvPaperSimENS.AppraiseCount; //评论数
objvPaperSimENT.AttachmentCount = objvPaperSimENS.AttachmentCount; //附件计数
objvPaperSimENT.CollectionCount = objvPaperSimENS.CollectionCount; //收藏数量
objvPaperSimENT.DownloadCount = objvPaperSimENS.DownloadCount; //下载数
objvPaperSimENT.Memo = objvPaperSimENS.Memo; //备注
objvPaperSimENT.OkCount = objvPaperSimENS.OkCount; //点赞统计
objvPaperSimENT.Pcount = objvPaperSimENS.Pcount; //读写数
objvPaperSimENT.Score = objvPaperSimENS.Score; //评分
objvPaperSimENT.StuScore = objvPaperSimENS.StuScore; //学生平均分
objvPaperSimENT.TeaScore = objvPaperSimENS.TeaScore; //教师评分
objvPaperSimENT.PaperQCount = objvPaperSimENS.PaperQCount; //论文答疑数
objvPaperSimENT.SubVCount = objvPaperSimENS.SubVCount; //论文子观点数
objvPaperSimENT.TagsCount = objvPaperSimENS.TagsCount; //论文标注数
objvPaperSimENT.TeaQCount = objvPaperSimENS.TeaQCount; //教师提问数
objvPaperSimENT.UpdUser = objvPaperSimENS.UpdUser; //修改人
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
 /// <param name = "objvPaperSimEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperSimEN objvPaperSimEN)
{
try
{
objvPaperSimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperSimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperSim.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.PaperId = objvPaperSimEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperSim.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.PaperTitle = objvPaperSimEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperSim.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.PaperContent = objvPaperSimEN.PaperContent == "[null]" ? null :  objvPaperSimEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convPaperSim.Periodical, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.Periodical = objvPaperSimEN.Periodical == "[null]" ? null :  objvPaperSimEN.Periodical; //期刊
}
if (arrFldSet.Contains(convPaperSim.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.Author = objvPaperSimEN.Author == "[null]" ? null :  objvPaperSimEN.Author; //作者
}
if (arrFldSet.Contains(convPaperSim.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.ResearchQuestion = objvPaperSimEN.ResearchQuestion == "[null]" ? null :  objvPaperSimEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convPaperSim.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.UpdDate = objvPaperSimEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperSim.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.UserName = objvPaperSimEN.UserName == "[null]" ? null :  objvPaperSimEN.UserName; //用户名
}
if (arrFldSet.Contains(convPaperSim.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.IdXzCollege = objvPaperSimEN.IdXzCollege == "[null]" ? null :  objvPaperSimEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convPaperSim.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.CollegeName = objvPaperSimEN.CollegeName == "[null]" ? null :  objvPaperSimEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convPaperSim.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.IdXzMajor = objvPaperSimEN.IdXzMajor == "[null]" ? null :  objvPaperSimEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convPaperSim.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.MajorName = objvPaperSimEN.MajorName == "[null]" ? null :  objvPaperSimEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convPaperSim.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.Keyword = objvPaperSimEN.Keyword == "[null]" ? null :  objvPaperSimEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPaperSim.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.LiteratureSources = objvPaperSimEN.LiteratureSources == "[null]" ? null :  objvPaperSimEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(convPaperSim.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.LiteratureLink = objvPaperSimEN.LiteratureLink == "[null]" ? null :  objvPaperSimEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(convPaperSim.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.UploadfileUrl = objvPaperSimEN.UploadfileUrl == "[null]" ? null :  objvPaperSimEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(convPaperSim.IsQuotethesis, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.IsQuotethesis = objvPaperSimEN.IsQuotethesis; //是否引用论文
}
if (arrFldSet.Contains(convPaperSim.QuoteId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.QuoteId = objvPaperSimEN.QuoteId == "[null]" ? null :  objvPaperSimEN.QuoteId; //引用Id
}
if (arrFldSet.Contains(convPaperSim.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.Checker = objvPaperSimEN.Checker == "[null]" ? null :  objvPaperSimEN.Checker; //审核人
}
if (arrFldSet.Contains(convPaperSim.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.IsChecked = objvPaperSimEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(convPaperSim.LiteratureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.LiteratureTypeId = objvPaperSimEN.LiteratureTypeId; //作文类型Id
}
if (arrFldSet.Contains(convPaperSim.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.BrowseNumber = objvPaperSimEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(convPaperSim.LiteratureTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.LiteratureTypeName = objvPaperSimEN.LiteratureTypeName == "[null]" ? null :  objvPaperSimEN.LiteratureTypeName; //作文类型名
}
if (arrFldSet.Contains(convPaperSim.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.IsSubmit = objvPaperSimEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convPaperSim.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.AppraiseCount = objvPaperSimEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convPaperSim.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.AttachmentCount = objvPaperSimEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convPaperSim.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.CollectionCount = objvPaperSimEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convPaperSim.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.DownloadCount = objvPaperSimEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convPaperSim.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.Memo = objvPaperSimEN.Memo == "[null]" ? null :  objvPaperSimEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperSim.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.OkCount = objvPaperSimEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convPaperSim.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.Pcount = objvPaperSimEN.Pcount; //读写数
}
if (arrFldSet.Contains(convPaperSim.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.Score = objvPaperSimEN.Score; //评分
}
if (arrFldSet.Contains(convPaperSim.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.StuScore = objvPaperSimEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convPaperSim.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.TeaScore = objvPaperSimEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convPaperSim.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.PaperQCount = objvPaperSimEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(convPaperSim.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.SubVCount = objvPaperSimEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(convPaperSim.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.TagsCount = objvPaperSimEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(convPaperSim.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.TeaQCount = objvPaperSimEN.TeaQCount; //教师提问数
}
if (arrFldSet.Contains(convPaperSim.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSimEN.UpdUser = objvPaperSimEN.UpdUser == "[null]" ? null :  objvPaperSimEN.UpdUser; //修改人
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
 /// <param name = "objvPaperSimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperSimEN objvPaperSimEN)
{
try
{
if (objvPaperSimEN.PaperContent == "[null]") objvPaperSimEN.PaperContent = null; //主题内容
if (objvPaperSimEN.Periodical == "[null]") objvPaperSimEN.Periodical = null; //期刊
if (objvPaperSimEN.Author == "[null]") objvPaperSimEN.Author = null; //作者
if (objvPaperSimEN.ResearchQuestion == "[null]") objvPaperSimEN.ResearchQuestion = null; //研究问题
if (objvPaperSimEN.UserName == "[null]") objvPaperSimEN.UserName = null; //用户名
if (objvPaperSimEN.IdXzCollege == "[null]") objvPaperSimEN.IdXzCollege = null; //学院流水号
if (objvPaperSimEN.CollegeName == "[null]") objvPaperSimEN.CollegeName = null; //学院名称
if (objvPaperSimEN.IdXzMajor == "[null]") objvPaperSimEN.IdXzMajor = null; //专业流水号
if (objvPaperSimEN.MajorName == "[null]") objvPaperSimEN.MajorName = null; //专业名称
if (objvPaperSimEN.Keyword == "[null]") objvPaperSimEN.Keyword = null; //关键字
if (objvPaperSimEN.LiteratureSources == "[null]") objvPaperSimEN.LiteratureSources = null; //文献来源
if (objvPaperSimEN.LiteratureLink == "[null]") objvPaperSimEN.LiteratureLink = null; //文献链接
if (objvPaperSimEN.UploadfileUrl == "[null]") objvPaperSimEN.UploadfileUrl = null; //文件地址
if (objvPaperSimEN.QuoteId == "[null]") objvPaperSimEN.QuoteId = null; //引用Id
if (objvPaperSimEN.Checker == "[null]") objvPaperSimEN.Checker = null; //审核人
if (objvPaperSimEN.LiteratureTypeName == "[null]") objvPaperSimEN.LiteratureTypeName = null; //作文类型名
if (objvPaperSimEN.Memo == "[null]") objvPaperSimEN.Memo = null; //备注
if (objvPaperSimEN.UpdUser == "[null]") objvPaperSimEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvPaperSimEN objvPaperSimEN)
{
 vPaperSimDA.CheckProperty4Condition(objvPaperSimEN);
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
//string strWhereCond = string.Format("1 = 1 order by PaperId");
//if (arrvPaperSimObjLstCache == null)
//{
//arrvPaperSimObjLstCache = vPaperSimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSimEN GetObjByPaperIdCache(string strPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName);
List<clsvPaperSimEN> arrvPaperSimObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSimEN> arrvPaperSimObjLst_Sel =
arrvPaperSimObjLstCache
.Where(x=> x.PaperId == strPaperId 
);
if (arrvPaperSimObjLst_Sel.Count() == 0)
{
   clsvPaperSimEN obj = clsvPaperSimBL.GetObjByPaperId(strPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperSimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSimEN> GetAllvPaperSimObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperSimEN> arrvPaperSimObjLstCache = GetObjLstCache(); 
return arrvPaperSimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName);
List<clsvPaperSimEN> arrvPaperSimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperSimObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strPaperId)
{
if (strInFldName != convPaperSim.PaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperSim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperSim.AttributeName));
throw new Exception(strMsg);
}
var objvPaperSim = clsvPaperSimBL.GetObjByPaperIdCache(strPaperId);
if (objvPaperSim == null) return "";
return objvPaperSim[strOutFldName].ToString();
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
int intRecCount = clsvPaperSimDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperSimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperSimDA.GetRecCount();
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
int intRecCount = clsvPaperSimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperSimEN objvPaperSimCond)
{
List<clsvPaperSimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSim.AttributeName)
{
if (objvPaperSimCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSimCond[strFldName].ToString());
}
else
{
if (objvPaperSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSimCond[strFldName]));
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
 List<string> arrList = clsvPaperSimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperSimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperSimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}