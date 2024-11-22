
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSimWApi
 表名:vPaperSim(01120597)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:11
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他
 模块英文名:Other
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
public static class clsvPaperSimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetPaperId(this clsvPaperSimEN objvPaperSimEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperSim.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperSim.PaperId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetPaperTitle(this clsvPaperSimEN objvPaperSimEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperTitle, convPaperSim.PaperTitle);
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperSim.PaperTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetPaperName(this clsvPaperSimEN objvPaperSimEN, string strPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperName, convPaperSim.PaperName);
clsCheckSql.CheckFieldLen(strPaperName, 500, convPaperSim.PaperName);
objvPaperSimEN.PaperName = strPaperName; //主题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.PaperName) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.PaperName, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.PaperName] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetPeriodical(this clsvPaperSimEN objvPaperSimEN, string strPeriodical, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPeriodical, 100, convPaperSim.Periodical);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetAuthor(this clsvPaperSimEN objvPaperSimEN, string strAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperSim.Author);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetResearchQuestion(this clsvPaperSimEN objvPaperSimEN, string strResearchQuestion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convPaperSim.ResearchQuestion);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetUpdDate(this clsvPaperSimEN objvPaperSimEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convPaperSim.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSim.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetUserName(this clsvPaperSimEN objvPaperSimEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convPaperSim.UserName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN Setid_XzCollege(this clsvPaperSimEN objvPaperSimEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convPaperSim.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convPaperSim.id_XzCollege);
objvPaperSimEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.id_XzCollege) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.id_XzCollege, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.id_XzCollege] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetCollegeName(this clsvPaperSimEN objvPaperSimEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convPaperSim.CollegeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN Setid_XzMajor(this clsvPaperSimEN objvPaperSimEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convPaperSim.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convPaperSim.id_XzMajor);
objvPaperSimEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.id_XzMajor) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.id_XzMajor, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.id_XzMajor] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetMajorName(this clsvPaperSimEN objvPaperSimEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convPaperSim.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetKeyword(this clsvPaperSimEN objvPaperSimEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperSim.Keyword);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureSources(this clsvPaperSimEN objvPaperSimEN, string strLiteratureSources, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, convPaperSim.LiteratureSources);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureLink(this clsvPaperSimEN objvPaperSimEN, string strLiteratureLink, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, convPaperSim.LiteratureLink);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetUploadfileUrl(this clsvPaperSimEN objvPaperSimEN, string strUploadfileUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, convPaperSim.UploadfileUrl);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetQuoteId(this clsvPaperSimEN objvPaperSimEN, string strQuoteId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuoteId, 8, convPaperSim.QuoteId);
clsCheckSql.CheckFieldForeignKey(strQuoteId, 8, convPaperSim.QuoteId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetChecker(this clsvPaperSimEN objvPaperSimEN, string strChecker, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChecker, 20, convPaperSim.Checker);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureTypeId(this clsvPaperSimEN objvPaperSimEN, string strLiteratureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strLiteratureTypeId, convPaperSim.LiteratureTypeId);
clsCheckSql.CheckFieldLen(strLiteratureTypeId, 2, convPaperSim.LiteratureTypeId);
clsCheckSql.CheckFieldForeignKey(strLiteratureTypeId, 2, convPaperSim.LiteratureTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetBrowseNumber(this clsvPaperSimEN objvPaperSimEN, int intBrowseNumber, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetLiteratureTypeName(this clsvPaperSimEN objvPaperSimEN, string strLiteratureTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLiteratureTypeName, 100, convPaperSim.LiteratureTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetAppraiseCount(this clsvPaperSimEN objvPaperSimEN, int intAppraiseCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetAttachmentCount(this clsvPaperSimEN objvPaperSimEN, int intAttachmentCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetCollectionCount(this clsvPaperSimEN objvPaperSimEN, int intCollectionCount, string strComparisonOp="")
	{
objvPaperSimEN.CollectionCount = intCollectionCount; //收藏数
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetDownloadCount(this clsvPaperSimEN objvPaperSimEN, int intDownloadCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetMemo(this clsvPaperSimEN objvPaperSimEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperSim.Memo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetOkCount(this clsvPaperSimEN objvPaperSimEN, int intOkCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetPcount(this clsvPaperSimEN objvPaperSimEN, int intPcount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN Setscore(this clsvPaperSimEN objvPaperSimEN, float fltscore, string strComparisonOp="")
	{
objvPaperSimEN.score = fltscore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.score) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.score, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.score] = strComparisonOp;
}
}
return objvPaperSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetStuScore(this clsvPaperSimEN objvPaperSimEN, float fltStuScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetTeaScore(this clsvPaperSimEN objvPaperSimEN, float fltTeaScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetPaperQCount(this clsvPaperSimEN objvPaperSimEN, int intPaperQCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetSubVCount(this clsvPaperSimEN objvPaperSimEN, int intSubVCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetTagsCount(this clsvPaperSimEN objvPaperSimEN, int intTagsCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetTeaQCount(this clsvPaperSimEN objvPaperSimEN, int intTeaQCount, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetUpdUser(this clsvPaperSimEN objvPaperSimEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperSim.UpdUser);
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
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSimEN SetIsGSuser(this clsvPaperSimEN objvPaperSimEN, bool bolIsGSuser, string strComparisonOp="")
	{
objvPaperSimEN.IsGSuser = bolIsGSuser; //是否GS用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSimEN.dicFldComparisonOp.ContainsKey(convPaperSim.IsGSuser) == false)
{
objvPaperSimEN.dicFldComparisonOp.Add(convPaperSim.IsGSuser, strComparisonOp);
}
else
{
objvPaperSimEN.dicFldComparisonOp[convPaperSim.IsGSuser] = strComparisonOp;
}
}
return objvPaperSimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSimEN objvPaperSim_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSim_Cond.IsUpdated(convPaperSim.PaperId) == true)
{
string strComparisonOp_PaperId = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.PaperId, objvPaperSim_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.PaperTitle, objvPaperSim_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.PaperName) == true)
{
string strComparisonOp_PaperName = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.PaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.PaperName, objvPaperSim_Cond.PaperName, strComparisonOp_PaperName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPaperSim_Cond.IsUpdated(convPaperSim.Periodical) == true)
{
string strComparisonOp_Periodical = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.Periodical];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Periodical, objvPaperSim_Cond.Periodical, strComparisonOp_Periodical);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.Author) == true)
{
string strComparisonOp_Author = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Author, objvPaperSim_Cond.Author, strComparisonOp_Author);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.ResearchQuestion) == true)
{
string strComparisonOp_ResearchQuestion = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.ResearchQuestion, objvPaperSim_Cond.ResearchQuestion, strComparisonOp_ResearchQuestion);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UpdDate, objvPaperSim_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.UserName) == true)
{
string strComparisonOp_UserName = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UserName, objvPaperSim_Cond.UserName, strComparisonOp_UserName);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.id_XzCollege, objvPaperSim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.CollegeName, objvPaperSim_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.id_XzMajor, objvPaperSim_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.MajorName) == true)
{
string strComparisonOp_MajorName = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.MajorName, objvPaperSim_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.Keyword) == true)
{
string strComparisonOp_Keyword = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Keyword, objvPaperSim_Cond.Keyword, strComparisonOp_Keyword);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.LiteratureSources) == true)
{
string strComparisonOp_LiteratureSources = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureSources, objvPaperSim_Cond.LiteratureSources, strComparisonOp_LiteratureSources);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.LiteratureLink) == true)
{
string strComparisonOp_LiteratureLink = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureLink, objvPaperSim_Cond.LiteratureLink, strComparisonOp_LiteratureLink);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.UploadfileUrl) == true)
{
string strComparisonOp_UploadfileUrl = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UploadfileUrl, objvPaperSim_Cond.UploadfileUrl, strComparisonOp_UploadfileUrl);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.IsQuotethesis) == true)
{
if (objvPaperSim_Cond.IsQuotethesis == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSim.IsQuotethesis);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSim.IsQuotethesis);
}
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.QuoteId) == true)
{
string strComparisonOp_QuoteId = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.QuoteId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.QuoteId, objvPaperSim_Cond.QuoteId, strComparisonOp_QuoteId);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.Checker) == true)
{
string strComparisonOp_Checker = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Checker, objvPaperSim_Cond.Checker, strComparisonOp_Checker);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.IsChecked) == true)
{
if (objvPaperSim_Cond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSim.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSim.IsChecked);
}
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.LiteratureTypeId) == true)
{
string strComparisonOp_LiteratureTypeId = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.LiteratureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureTypeId, objvPaperSim_Cond.LiteratureTypeId, strComparisonOp_LiteratureTypeId);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.BrowseNumber) == true)
{
string strComparisonOp_BrowseNumber = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.BrowseNumber, objvPaperSim_Cond.BrowseNumber, strComparisonOp_BrowseNumber);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.LiteratureTypeName) == true)
{
string strComparisonOp_LiteratureTypeName = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.LiteratureTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.LiteratureTypeName, objvPaperSim_Cond.LiteratureTypeName, strComparisonOp_LiteratureTypeName);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.IsSubmit) == true)
{
if (objvPaperSim_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSim.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSim.IsSubmit);
}
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.AppraiseCount) == true)
{
string strComparisonOp_AppraiseCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.AppraiseCount, objvPaperSim_Cond.AppraiseCount, strComparisonOp_AppraiseCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.AttachmentCount) == true)
{
string strComparisonOp_AttachmentCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.AttachmentCount, objvPaperSim_Cond.AttachmentCount, strComparisonOp_AttachmentCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.CollectionCount) == true)
{
string strComparisonOp_CollectionCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.CollectionCount, objvPaperSim_Cond.CollectionCount, strComparisonOp_CollectionCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.DownloadCount) == true)
{
string strComparisonOp_DownloadCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.DownloadCount, objvPaperSim_Cond.DownloadCount, strComparisonOp_DownloadCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.Memo) == true)
{
string strComparisonOp_Memo = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.Memo, objvPaperSim_Cond.Memo, strComparisonOp_Memo);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.OkCount) == true)
{
string strComparisonOp_OkCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.OkCount, objvPaperSim_Cond.OkCount, strComparisonOp_OkCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.Pcount) == true)
{
string strComparisonOp_Pcount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.Pcount, objvPaperSim_Cond.Pcount, strComparisonOp_Pcount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.score) == true)
{
string strComparisonOp_score = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.score];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.score, objvPaperSim_Cond.score, strComparisonOp_score);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.StuScore) == true)
{
string strComparisonOp_StuScore = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.StuScore, objvPaperSim_Cond.StuScore, strComparisonOp_StuScore);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.TeaScore) == true)
{
string strComparisonOp_TeaScore = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.TeaScore, objvPaperSim_Cond.TeaScore, strComparisonOp_TeaScore);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.PaperQCount) == true)
{
string strComparisonOp_PaperQCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.PaperQCount, objvPaperSim_Cond.PaperQCount, strComparisonOp_PaperQCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.SubVCount) == true)
{
string strComparisonOp_SubVCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.SubVCount, objvPaperSim_Cond.SubVCount, strComparisonOp_SubVCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.TagsCount) == true)
{
string strComparisonOp_TagsCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.TagsCount, objvPaperSim_Cond.TagsCount, strComparisonOp_TagsCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.TeaQCount) == true)
{
string strComparisonOp_TeaQCount = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSim.TeaQCount, objvPaperSim_Cond.TeaQCount, strComparisonOp_TeaQCount);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvPaperSim_Cond.dicFldComparisonOp[convPaperSim.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSim.UpdUser, objvPaperSim_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvPaperSim_Cond.IsUpdated(convPaperSim.IsGSuser) == true)
{
if (objvPaperSim_Cond.IsGSuser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSim.IsGSuser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSim.IsGSuser);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// 论文简化视图(vPaperSim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSimWApi
{
private static readonly string mstrApiControllerName = "vPaperSimApi";

 public clsvPaperSimWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSimEN GetObjByPaperId(string strPaperId)
{
string strAction = "GetObjByPaperId";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSimEN objvPaperSimEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperId"] = strPaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperSimEN = JsonConvert.DeserializeObject<clsvPaperSimEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSimEN;
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
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSimEN GetObjByPaperId_WA_Cache(string strPaperId)
{
string strAction = "GetObjByPaperId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSimEN objvPaperSimEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperId"] = strPaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperSimEN = JsonConvert.DeserializeObject<clsvPaperSimEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSimEN;
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
public static clsvPaperSimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSimEN objvPaperSimEN = null;
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
objvPaperSimEN = JsonConvert.DeserializeObject<clsvPaperSimEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSimEN;
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
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSimEN GetObjByPaperId_Cache(string strPaperId)
{
if (string.IsNullOrEmpty(strPaperId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName_S);
List<clsvPaperSimEN> arrvPaperSimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperSimEN> arrvPaperSimObjLst_Sel =
from objvPaperSimEN in arrvPaperSimObjLst_Cache
where objvPaperSimEN.PaperId == strPaperId
select objvPaperSimEN;
if (arrvPaperSimObjLst_Sel.Count() == 0)
{
   clsvPaperSimEN obj = clsvPaperSimWApi.GetObjByPaperId(strPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPaperSimObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSimEN> GetObjLst(string strWhereCond)
{
 List<clsvPaperSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSimEN> GetObjLstByPaperIdLst(List<string> arrPaperId)
{
 List<clsvPaperSimEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPaperSimEN> GetObjLstByPaperIdLst_Cache(List<string> arrPaperId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName_S);
List<clsvPaperSimEN> arrvPaperSimObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperSimEN> arrvPaperSimObjLst_Sel =
from objvPaperSimEN in arrvPaperSimObjLst_Cache
where arrPaperId.Contains(objvPaperSimEN.PaperId)
select objvPaperSimEN;
return arrvPaperSimObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSimEN> GetObjLstByPaperIdLst_WA_Cache(List<string> arrPaperId)
{
 List<clsvPaperSimEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPaperSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPaperSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPaperSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSimEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPaperSimEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSimEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strPaperId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperId"] = strPaperId
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
 /// <param name = "objvPaperSimENS">源对象</param>
 /// <param name = "objvPaperSimENT">目标对象</param>
 public static void CopyTo(clsvPaperSimEN objvPaperSimENS, clsvPaperSimEN objvPaperSimENT)
{
try
{
objvPaperSimENT.PaperId = objvPaperSimENS.PaperId; //论文Id
objvPaperSimENT.PaperTitle = objvPaperSimENS.PaperTitle; //论文标题
objvPaperSimENT.PaperName = objvPaperSimENS.PaperName; //主题名称
objvPaperSimENT.PaperContent = objvPaperSimENS.PaperContent; //主题内容
objvPaperSimENT.Periodical = objvPaperSimENS.Periodical; //期刊
objvPaperSimENT.Author = objvPaperSimENS.Author; //作者
objvPaperSimENT.ResearchQuestion = objvPaperSimENS.ResearchQuestion; //研究问题
objvPaperSimENT.UpdDate = objvPaperSimENS.UpdDate; //修改日期
objvPaperSimENT.UserName = objvPaperSimENS.UserName; //用户名
objvPaperSimENT.id_XzCollege = objvPaperSimENS.id_XzCollege; //学院流水号
objvPaperSimENT.CollegeName = objvPaperSimENS.CollegeName; //学院名称
objvPaperSimENT.id_XzMajor = objvPaperSimENS.id_XzMajor; //专业流水号
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
objvPaperSimENT.CollectionCount = objvPaperSimENS.CollectionCount; //收藏数
objvPaperSimENT.DownloadCount = objvPaperSimENS.DownloadCount; //下载数
objvPaperSimENT.Memo = objvPaperSimENS.Memo; //备注
objvPaperSimENT.OkCount = objvPaperSimENS.OkCount; //点赞统计
objvPaperSimENT.Pcount = objvPaperSimENS.Pcount; //读写数
objvPaperSimENT.score = objvPaperSimENS.score; //评分
objvPaperSimENT.StuScore = objvPaperSimENS.StuScore; //学生平均分
objvPaperSimENT.TeaScore = objvPaperSimENS.TeaScore; //教师评分
objvPaperSimENT.PaperQCount = objvPaperSimENS.PaperQCount; //论文答疑数
objvPaperSimENT.SubVCount = objvPaperSimENS.SubVCount; //论文子观点数
objvPaperSimENT.TagsCount = objvPaperSimENS.TagsCount; //论文标注数
objvPaperSimENT.TeaQCount = objvPaperSimENS.TeaQCount; //教师提问数
objvPaperSimENT.UpdUser = objvPaperSimENS.UpdUser; //修改人
objvPaperSimENT.IsGSuser = objvPaperSimENS.IsGSuser; //是否GS用户
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
public static DataTable ToDataTable(List<clsvPaperSimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPaperSimEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPaperSimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPaperSimEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPaperSimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPaperSimEN.AttributeName)
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
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsLiteratureTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsLiteratureTypeWApi没有刷新缓存机制(clsLiteratureTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperId");
//if (arrvPaperSimObjLst_Cache == null)
//{
//arrvPaperSimObjLst_Cache = await clsvPaperSimWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName_S);
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
public static List<clsvPaperSimEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPaperSimEN._CurrTabName_S);
List<clsvPaperSimEN> arrvPaperSimObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperSimObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPaperSimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPaperSim.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.PaperName, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.PaperContent, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.Periodical, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.Author, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.ResearchQuestion, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.LiteratureSources, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.LiteratureLink, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.UploadfileUrl, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.IsQuotethesis, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPaperSim.QuoteId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.Checker, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPaperSim.LiteratureTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.BrowseNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.LiteratureTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(convPaperSim.AppraiseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.AttachmentCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.CollectionCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.DownloadCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.OkCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.Pcount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.score, Type.GetType("System.Single"));
objDT.Columns.Add(convPaperSim.StuScore, Type.GetType("System.Single"));
objDT.Columns.Add(convPaperSim.TeaScore, Type.GetType("System.Single"));
objDT.Columns.Add(convPaperSim.PaperQCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.SubVCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.TagsCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.TeaQCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperSim.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSim.IsGSuser, Type.GetType("System.Boolean"));
foreach (clsvPaperSimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPaperSim.PaperId] = objInFor[convPaperSim.PaperId];
objDR[convPaperSim.PaperTitle] = objInFor[convPaperSim.PaperTitle];
objDR[convPaperSim.PaperName] = objInFor[convPaperSim.PaperName];
objDR[convPaperSim.PaperContent] = objInFor[convPaperSim.PaperContent];
objDR[convPaperSim.Periodical] = objInFor[convPaperSim.Periodical];
objDR[convPaperSim.Author] = objInFor[convPaperSim.Author];
objDR[convPaperSim.ResearchQuestion] = objInFor[convPaperSim.ResearchQuestion];
objDR[convPaperSim.UpdDate] = objInFor[convPaperSim.UpdDate];
objDR[convPaperSim.UserName] = objInFor[convPaperSim.UserName];
objDR[convPaperSim.id_XzCollege] = objInFor[convPaperSim.id_XzCollege];
objDR[convPaperSim.CollegeName] = objInFor[convPaperSim.CollegeName];
objDR[convPaperSim.id_XzMajor] = objInFor[convPaperSim.id_XzMajor];
objDR[convPaperSim.MajorName] = objInFor[convPaperSim.MajorName];
objDR[convPaperSim.Keyword] = objInFor[convPaperSim.Keyword];
objDR[convPaperSim.LiteratureSources] = objInFor[convPaperSim.LiteratureSources];
objDR[convPaperSim.LiteratureLink] = objInFor[convPaperSim.LiteratureLink];
objDR[convPaperSim.UploadfileUrl] = objInFor[convPaperSim.UploadfileUrl];
objDR[convPaperSim.IsQuotethesis] = objInFor[convPaperSim.IsQuotethesis];
objDR[convPaperSim.QuoteId] = objInFor[convPaperSim.QuoteId];
objDR[convPaperSim.Checker] = objInFor[convPaperSim.Checker];
objDR[convPaperSim.IsChecked] = objInFor[convPaperSim.IsChecked];
objDR[convPaperSim.LiteratureTypeId] = objInFor[convPaperSim.LiteratureTypeId];
objDR[convPaperSim.BrowseNumber] = objInFor[convPaperSim.BrowseNumber];
objDR[convPaperSim.LiteratureTypeName] = objInFor[convPaperSim.LiteratureTypeName];
objDR[convPaperSim.IsSubmit] = objInFor[convPaperSim.IsSubmit];
objDR[convPaperSim.AppraiseCount] = objInFor[convPaperSim.AppraiseCount];
objDR[convPaperSim.AttachmentCount] = objInFor[convPaperSim.AttachmentCount];
objDR[convPaperSim.CollectionCount] = objInFor[convPaperSim.CollectionCount];
objDR[convPaperSim.DownloadCount] = objInFor[convPaperSim.DownloadCount];
objDR[convPaperSim.Memo] = objInFor[convPaperSim.Memo];
objDR[convPaperSim.OkCount] = objInFor[convPaperSim.OkCount];
objDR[convPaperSim.Pcount] = objInFor[convPaperSim.Pcount];
objDR[convPaperSim.score] = objInFor[convPaperSim.score];
objDR[convPaperSim.StuScore] = objInFor[convPaperSim.StuScore];
objDR[convPaperSim.TeaScore] = objInFor[convPaperSim.TeaScore];
objDR[convPaperSim.PaperQCount] = objInFor[convPaperSim.PaperQCount];
objDR[convPaperSim.SubVCount] = objInFor[convPaperSim.SubVCount];
objDR[convPaperSim.TagsCount] = objInFor[convPaperSim.TagsCount];
objDR[convPaperSim.TeaQCount] = objInFor[convPaperSim.TeaQCount];
objDR[convPaperSim.UpdUser] = objInFor[convPaperSim.UpdUser];
objDR[convPaperSim.IsGSuser] = objInFor[convPaperSim.IsGSuser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}