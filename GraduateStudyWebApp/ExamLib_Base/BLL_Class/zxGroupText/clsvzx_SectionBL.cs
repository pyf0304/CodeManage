
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_SectionBL
 表名:vzx_Section(01120834)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
public static class  clsvzx_SectionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SectionEN GetObj(this K_zxSectionId_vzx_Section myKey)
{
clsvzx_SectionEN objvzx_SectionEN = clsvzx_SectionBL.vzx_SectionDA.GetObjByzxSectionId(myKey.Value);
return objvzx_SectionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetPaperTitle(this clsvzx_SectionEN objvzx_SectionEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convzx_Section.PaperTitle);
}
objvzx_SectionEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.PaperTitle) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.PaperTitle, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.PaperTitle] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetPaperName(this clsvzx_SectionEN objvzx_SectionEN, string strPaperName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperName, 500, convzx_Section.PaperName);
}
objvzx_SectionEN.PaperName = strPaperName; //主题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.PaperName) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.PaperName, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.PaperName] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetPaperContent(this clsvzx_SectionEN objvzx_SectionEN, string strPaperContent, string strComparisonOp="")
	{
objvzx_SectionEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.PaperContent) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.PaperContent, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.PaperContent] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetAuthor(this clsvzx_SectionEN objvzx_SectionEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_Section.Author);
}
objvzx_SectionEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.Author) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.Author, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.Author] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetKeyword(this clsvzx_SectionEN objvzx_SectionEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convzx_Section.Keyword);
}
objvzx_SectionEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.Keyword) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.Keyword, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.Keyword] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetSectionName(this clsvzx_SectionEN objvzx_SectionEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convzx_Section.SectionName);
}
objvzx_SectionEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.SectionName) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.SectionName, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.SectionName] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetUpdDate(this clsvzx_SectionEN objvzx_SectionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_Section.UpdDate);
}
objvzx_SectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.UpdDate) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.UpdDate, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.UpdDate] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetPaperId(this clsvzx_SectionEN objvzx_SectionEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convzx_Section.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convzx_Section.PaperId);
}
objvzx_SectionEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.PaperId) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.PaperId, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.PaperId] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetzxSectionId(this clsvzx_SectionEN objvzx_SectionEN, string strzxSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSectionId, 8, convzx_Section.zxSectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSectionId, 8, convzx_Section.zxSectionId);
}
objvzx_SectionEN.zxSectionId = strzxSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.zxSectionId) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.zxSectionId, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.zxSectionId] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetUpdUser(this clsvzx_SectionEN objvzx_SectionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_Section.UpdUser);
}
objvzx_SectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.UpdUser) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.UpdUser, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.UpdUser] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetMemo(this clsvzx_SectionEN objvzx_SectionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_Section.Memo);
}
objvzx_SectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.Memo) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.Memo, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.Memo] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetParentId(this clsvzx_SectionEN objvzx_SectionEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, convzx_Section.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, convzx_Section.ParentId);
}
objvzx_SectionEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.ParentId) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.ParentId, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.ParentId] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetOrderNum(this clsvzx_SectionEN objvzx_SectionEN, int? intOrderNum, string strComparisonOp="")
	{
objvzx_SectionEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.OrderNum) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.OrderNum, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.OrderNum] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_SectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_SectionEN SetResearchQuestion(this clsvzx_SectionEN objvzx_SectionEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convzx_Section.ResearchQuestion);
}
objvzx_SectionEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_SectionEN.dicFldComparisonOp.ContainsKey(convzx_Section.ResearchQuestion) == false)
{
objvzx_SectionEN.dicFldComparisonOp.Add(convzx_Section.ResearchQuestion, strComparisonOp);
}
else
{
objvzx_SectionEN.dicFldComparisonOp[convzx_Section.ResearchQuestion] = strComparisonOp;
}
}
return objvzx_SectionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_SectionENS">源对象</param>
 /// <param name = "objvzx_SectionENT">目标对象</param>
 public static void CopyTo(this clsvzx_SectionEN objvzx_SectionENS, clsvzx_SectionEN objvzx_SectionENT)
{
try
{
objvzx_SectionENT.PaperTitle = objvzx_SectionENS.PaperTitle; //论文标题
objvzx_SectionENT.PaperName = objvzx_SectionENS.PaperName; //主题名称
objvzx_SectionENT.PaperContent = objvzx_SectionENS.PaperContent; //主题内容
objvzx_SectionENT.Author = objvzx_SectionENS.Author; //作者
objvzx_SectionENT.Keyword = objvzx_SectionENS.Keyword; //关键字
objvzx_SectionENT.SectionName = objvzx_SectionENS.SectionName; //节名
objvzx_SectionENT.UpdDate = objvzx_SectionENS.UpdDate; //修改日期
objvzx_SectionENT.PaperId = objvzx_SectionENS.PaperId; //论文Id
objvzx_SectionENT.zxSectionId = objvzx_SectionENS.zxSectionId; //节Id
objvzx_SectionENT.UpdUser = objvzx_SectionENS.UpdUser; //修改人
objvzx_SectionENT.Memo = objvzx_SectionENS.Memo; //备注
objvzx_SectionENT.ParentId = objvzx_SectionENS.ParentId; //父节点Id
objvzx_SectionENT.OrderNum = objvzx_SectionENS.OrderNum; //序号
objvzx_SectionENT.ResearchQuestion = objvzx_SectionENS.ResearchQuestion; //研究问题
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
 /// <param name = "objvzx_SectionENS">源对象</param>
 /// <returns>目标对象=>clsvzx_SectionEN:objvzx_SectionENT</returns>
 public static clsvzx_SectionEN CopyTo(this clsvzx_SectionEN objvzx_SectionENS)
{
try
{
 clsvzx_SectionEN objvzx_SectionENT = new clsvzx_SectionEN()
{
PaperTitle = objvzx_SectionENS.PaperTitle, //论文标题
PaperName = objvzx_SectionENS.PaperName, //主题名称
PaperContent = objvzx_SectionENS.PaperContent, //主题内容
Author = objvzx_SectionENS.Author, //作者
Keyword = objvzx_SectionENS.Keyword, //关键字
SectionName = objvzx_SectionENS.SectionName, //节名
UpdDate = objvzx_SectionENS.UpdDate, //修改日期
PaperId = objvzx_SectionENS.PaperId, //论文Id
zxSectionId = objvzx_SectionENS.zxSectionId, //节Id
UpdUser = objvzx_SectionENS.UpdUser, //修改人
Memo = objvzx_SectionENS.Memo, //备注
ParentId = objvzx_SectionENS.ParentId, //父节点Id
OrderNum = objvzx_SectionENS.OrderNum, //序号
ResearchQuestion = objvzx_SectionENS.ResearchQuestion, //研究问题
};
 return objvzx_SectionENT;
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
public static void CheckProperty4Condition(this clsvzx_SectionEN objvzx_SectionEN)
{
 clsvzx_SectionBL.vzx_SectionDA.CheckProperty4Condition(objvzx_SectionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_SectionEN objvzx_SectionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_SectionCond.IsUpdated(convzx_Section.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.PaperTitle, objvzx_SectionCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.PaperName) == true)
{
string strComparisonOpPaperName = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.PaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.PaperName, objvzx_SectionCond.PaperName, strComparisonOpPaperName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_SectionCond.IsUpdated(convzx_Section.Author) == true)
{
string strComparisonOpAuthor = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.Author, objvzx_SectionCond.Author, strComparisonOpAuthor);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.Keyword) == true)
{
string strComparisonOpKeyword = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.Keyword, objvzx_SectionCond.Keyword, strComparisonOpKeyword);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.SectionName) == true)
{
string strComparisonOpSectionName = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.SectionName, objvzx_SectionCond.SectionName, strComparisonOpSectionName);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.UpdDate, objvzx_SectionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.PaperId) == true)
{
string strComparisonOpPaperId = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.PaperId, objvzx_SectionCond.PaperId, strComparisonOpPaperId);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.zxSectionId) == true)
{
string strComparisonOpzxSectionId = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.zxSectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.zxSectionId, objvzx_SectionCond.zxSectionId, strComparisonOpzxSectionId);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.UpdUser, objvzx_SectionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.Memo) == true)
{
string strComparisonOpMemo = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.Memo, objvzx_SectionCond.Memo, strComparisonOpMemo);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.ParentId) == true)
{
string strComparisonOpParentId = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.ParentId, objvzx_SectionCond.ParentId, strComparisonOpParentId);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.OrderNum) == true)
{
string strComparisonOpOrderNum = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_Section.OrderNum, objvzx_SectionCond.OrderNum, strComparisonOpOrderNum);
}
if (objvzx_SectionCond.IsUpdated(convzx_Section.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvzx_SectionCond.dicFldComparisonOp[convzx_Section.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_Section.ResearchQuestion, objvzx_SectionCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_Section
{
public virtual bool UpdRelaTabDate(string strzxSectionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_Section(vzx_Section)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_SectionBL
{
public static RelatedActions_vzx_Section relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_SectionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_SectionDA vzx_SectionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_SectionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_SectionBL()
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
if (string.IsNullOrEmpty(clsvzx_SectionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_SectionEN._ConnectString);
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
public static DataTable GetDataTable_vzx_Section(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_SectionDA.GetDataTable_vzx_Section(strWhereCond);
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
objDT = vzx_SectionDA.GetDataTable(strWhereCond);
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
objDT = vzx_SectionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_SectionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_SectionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_SectionDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_SectionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_SectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_SectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_SectionEN> GetObjLstByZxSectionIdLst(List<string> arrZxSectionIdLst)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxSectionIdLst, true);
 string strWhereCond = string.Format("zxSectionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_SectionEN> GetObjLstByZxSectionIdLstCache(List<string> arrZxSectionIdLst)
{
string strKey = string.Format("{0}", clsvzx_SectionEN._CurrTabName);
List<clsvzx_SectionEN> arrvzx_SectionObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SectionEN> arrvzx_SectionObjLst_Sel =
arrvzx_SectionObjLstCache
.Where(x => arrZxSectionIdLst.Contains(x.zxSectionId));
return arrvzx_SectionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SectionEN> GetObjLst(string strWhereCond)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
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
public static List<clsvzx_SectionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_SectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_SectionEN> GetSubObjLstCache(clsvzx_SectionEN objvzx_SectionCond)
{
List<clsvzx_SectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Section.AttributeName)
{
if (objvzx_SectionCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SectionCond[strFldName].ToString());
}
else
{
if (objvzx_SectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SectionCond[strFldName]));
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
public static List<clsvzx_SectionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
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
public static List<clsvzx_SectionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
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
List<clsvzx_SectionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_SectionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SectionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_SectionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
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
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
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
public static List<clsvzx_SectionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_SectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_SectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
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
public static List<clsvzx_SectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_SectionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_SectionEN> arrObjLst = new List<clsvzx_SectionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_SectionEN objvzx_SectionEN = new clsvzx_SectionEN();
try
{
objvzx_SectionEN.PaperTitle = objRow[convzx_Section.PaperTitle] == DBNull.Value ? null : objRow[convzx_Section.PaperTitle].ToString().Trim(); //论文标题
objvzx_SectionEN.PaperName = objRow[convzx_Section.PaperName] == DBNull.Value ? null : objRow[convzx_Section.PaperName].ToString().Trim(); //主题名称
objvzx_SectionEN.PaperContent = objRow[convzx_Section.PaperContent] == DBNull.Value ? null : objRow[convzx_Section.PaperContent].ToString().Trim(); //主题内容
objvzx_SectionEN.Author = objRow[convzx_Section.Author] == DBNull.Value ? null : objRow[convzx_Section.Author].ToString().Trim(); //作者
objvzx_SectionEN.Keyword = objRow[convzx_Section.Keyword] == DBNull.Value ? null : objRow[convzx_Section.Keyword].ToString().Trim(); //关键字
objvzx_SectionEN.SectionName = objRow[convzx_Section.SectionName] == DBNull.Value ? null : objRow[convzx_Section.SectionName].ToString().Trim(); //节名
objvzx_SectionEN.UpdDate = objRow[convzx_Section.UpdDate] == DBNull.Value ? null : objRow[convzx_Section.UpdDate].ToString().Trim(); //修改日期
objvzx_SectionEN.PaperId = objRow[convzx_Section.PaperId] == DBNull.Value ? null : objRow[convzx_Section.PaperId].ToString().Trim(); //论文Id
objvzx_SectionEN.zxSectionId = objRow[convzx_Section.zxSectionId].ToString().Trim(); //节Id
objvzx_SectionEN.UpdUser = objRow[convzx_Section.UpdUser] == DBNull.Value ? null : objRow[convzx_Section.UpdUser].ToString().Trim(); //修改人
objvzx_SectionEN.Memo = objRow[convzx_Section.Memo] == DBNull.Value ? null : objRow[convzx_Section.Memo].ToString().Trim(); //备注
objvzx_SectionEN.ParentId = objRow[convzx_Section.ParentId] == DBNull.Value ? null : objRow[convzx_Section.ParentId].ToString().Trim(); //父节点Id
objvzx_SectionEN.OrderNum = objRow[convzx_Section.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Section.OrderNum].ToString().Trim()); //序号
objvzx_SectionEN.ResearchQuestion = objRow[convzx_Section.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Section.ResearchQuestion].ToString().Trim(); //研究问题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_SectionEN.zxSectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_SectionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_SectionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_Section(ref clsvzx_SectionEN objvzx_SectionEN)
{
bool bolResult = vzx_SectionDA.Getvzx_Section(ref objvzx_SectionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_SectionEN GetObjByzxSectionId(string strzxSectionId)
{
if (strzxSectionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxSectionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxSectionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_SectionEN objvzx_SectionEN = vzx_SectionDA.GetObjByzxSectionId(strzxSectionId);
return objvzx_SectionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_SectionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_SectionEN objvzx_SectionEN = vzx_SectionDA.GetFirstObj(strWhereCond);
 return objvzx_SectionEN;
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
public static clsvzx_SectionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_SectionEN objvzx_SectionEN = vzx_SectionDA.GetObjByDataRow(objRow);
 return objvzx_SectionEN;
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
public static clsvzx_SectionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_SectionEN objvzx_SectionEN = vzx_SectionDA.GetObjByDataRow(objRow);
 return objvzx_SectionEN;
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
 /// <param name = "strzxSectionId">所给的关键字</param>
 /// <param name = "lstvzx_SectionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SectionEN GetObjByzxSectionIdFromList(string strzxSectionId, List<clsvzx_SectionEN> lstvzx_SectionObjLst)
{
foreach (clsvzx_SectionEN objvzx_SectionEN in lstvzx_SectionObjLst)
{
if (objvzx_SectionEN.zxSectionId == strzxSectionId)
{
return objvzx_SectionEN;
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
 string strMaxZxSectionId;
 try
 {
 strMaxZxSectionId = clsvzx_SectionDA.GetMaxStrId();
 return strMaxZxSectionId;
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
 string strzxSectionId;
 try
 {
 strzxSectionId = new clsvzx_SectionDA().GetFirstID(strWhereCond);
 return strzxSectionId;
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
 arrList = vzx_SectionDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_SectionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxSectionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxSectionId)
{
if (string.IsNullOrEmpty(strzxSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxSectionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_SectionDA.IsExist(strzxSectionId);
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
 bolIsExist = clsvzx_SectionDA.IsExistTable();
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
 bolIsExist = vzx_SectionDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_SectionENS">源对象</param>
 /// <param name = "objvzx_SectionENT">目标对象</param>
 public static void CopyTo(clsvzx_SectionEN objvzx_SectionENS, clsvzx_SectionEN objvzx_SectionENT)
{
try
{
objvzx_SectionENT.PaperTitle = objvzx_SectionENS.PaperTitle; //论文标题
objvzx_SectionENT.PaperName = objvzx_SectionENS.PaperName; //主题名称
objvzx_SectionENT.PaperContent = objvzx_SectionENS.PaperContent; //主题内容
objvzx_SectionENT.Author = objvzx_SectionENS.Author; //作者
objvzx_SectionENT.Keyword = objvzx_SectionENS.Keyword; //关键字
objvzx_SectionENT.SectionName = objvzx_SectionENS.SectionName; //节名
objvzx_SectionENT.UpdDate = objvzx_SectionENS.UpdDate; //修改日期
objvzx_SectionENT.PaperId = objvzx_SectionENS.PaperId; //论文Id
objvzx_SectionENT.zxSectionId = objvzx_SectionENS.zxSectionId; //节Id
objvzx_SectionENT.UpdUser = objvzx_SectionENS.UpdUser; //修改人
objvzx_SectionENT.Memo = objvzx_SectionENS.Memo; //备注
objvzx_SectionENT.ParentId = objvzx_SectionENS.ParentId; //父节点Id
objvzx_SectionENT.OrderNum = objvzx_SectionENS.OrderNum; //序号
objvzx_SectionENT.ResearchQuestion = objvzx_SectionENS.ResearchQuestion; //研究问题
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
 /// <param name = "objvzx_SectionEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_SectionEN objvzx_SectionEN)
{
try
{
objvzx_SectionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_SectionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_Section.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.PaperTitle = objvzx_SectionEN.PaperTitle == "[null]" ? null :  objvzx_SectionEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convzx_Section.PaperName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.PaperName = objvzx_SectionEN.PaperName == "[null]" ? null :  objvzx_SectionEN.PaperName; //主题名称
}
if (arrFldSet.Contains(convzx_Section.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.PaperContent = objvzx_SectionEN.PaperContent == "[null]" ? null :  objvzx_SectionEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convzx_Section.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.Author = objvzx_SectionEN.Author == "[null]" ? null :  objvzx_SectionEN.Author; //作者
}
if (arrFldSet.Contains(convzx_Section.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.Keyword = objvzx_SectionEN.Keyword == "[null]" ? null :  objvzx_SectionEN.Keyword; //关键字
}
if (arrFldSet.Contains(convzx_Section.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.SectionName = objvzx_SectionEN.SectionName == "[null]" ? null :  objvzx_SectionEN.SectionName; //节名
}
if (arrFldSet.Contains(convzx_Section.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.UpdDate = objvzx_SectionEN.UpdDate == "[null]" ? null :  objvzx_SectionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_Section.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.PaperId = objvzx_SectionEN.PaperId == "[null]" ? null :  objvzx_SectionEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convzx_Section.zxSectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.zxSectionId = objvzx_SectionEN.zxSectionId; //节Id
}
if (arrFldSet.Contains(convzx_Section.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.UpdUser = objvzx_SectionEN.UpdUser == "[null]" ? null :  objvzx_SectionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_Section.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.Memo = objvzx_SectionEN.Memo == "[null]" ? null :  objvzx_SectionEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_Section.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.ParentId = objvzx_SectionEN.ParentId == "[null]" ? null :  objvzx_SectionEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(convzx_Section.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.OrderNum = objvzx_SectionEN.OrderNum; //序号
}
if (arrFldSet.Contains(convzx_Section.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_SectionEN.ResearchQuestion = objvzx_SectionEN.ResearchQuestion == "[null]" ? null :  objvzx_SectionEN.ResearchQuestion; //研究问题
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
 /// <param name = "objvzx_SectionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_SectionEN objvzx_SectionEN)
{
try
{
if (objvzx_SectionEN.PaperTitle == "[null]") objvzx_SectionEN.PaperTitle = null; //论文标题
if (objvzx_SectionEN.PaperName == "[null]") objvzx_SectionEN.PaperName = null; //主题名称
if (objvzx_SectionEN.PaperContent == "[null]") objvzx_SectionEN.PaperContent = null; //主题内容
if (objvzx_SectionEN.Author == "[null]") objvzx_SectionEN.Author = null; //作者
if (objvzx_SectionEN.Keyword == "[null]") objvzx_SectionEN.Keyword = null; //关键字
if (objvzx_SectionEN.SectionName == "[null]") objvzx_SectionEN.SectionName = null; //节名
if (objvzx_SectionEN.UpdDate == "[null]") objvzx_SectionEN.UpdDate = null; //修改日期
if (objvzx_SectionEN.PaperId == "[null]") objvzx_SectionEN.PaperId = null; //论文Id
if (objvzx_SectionEN.UpdUser == "[null]") objvzx_SectionEN.UpdUser = null; //修改人
if (objvzx_SectionEN.Memo == "[null]") objvzx_SectionEN.Memo = null; //备注
if (objvzx_SectionEN.ParentId == "[null]") objvzx_SectionEN.ParentId = null; //父节点Id
if (objvzx_SectionEN.ResearchQuestion == "[null]") objvzx_SectionEN.ResearchQuestion = null; //研究问题
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
public static void CheckProperty4Condition(clsvzx_SectionEN objvzx_SectionEN)
{
 vzx_SectionDA.CheckProperty4Condition(objvzx_SectionEN);
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
if (clszx_CompositionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_CompositionBL没有刷新缓存机制(clszx_CompositionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SectionBL没有刷新缓存机制(clszx_SectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxSectionId");
//if (arrvzx_SectionObjLstCache == null)
//{
//arrvzx_SectionObjLstCache = vzx_SectionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxSectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_SectionEN GetObjByzxSectionIdCache(string strzxSectionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_SectionEN._CurrTabName);
List<clsvzx_SectionEN> arrvzx_SectionObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SectionEN> arrvzx_SectionObjLst_Sel =
arrvzx_SectionObjLstCache
.Where(x=> x.zxSectionId == strzxSectionId 
);
if (arrvzx_SectionObjLst_Sel.Count() == 0)
{
   clsvzx_SectionEN obj = clsvzx_SectionBL.GetObjByzxSectionId(strzxSectionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_SectionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SectionEN> GetAllvzx_SectionObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_SectionEN> arrvzx_SectionObjLstCache = GetObjLstCache(); 
return arrvzx_SectionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_SectionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_SectionEN._CurrTabName);
List<clsvzx_SectionEN> arrvzx_SectionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_SectionObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_SectionEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxSectionId)
{
if (strInFldName != convzx_Section.zxSectionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_Section.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_Section.AttributeName));
throw new Exception(strMsg);
}
var objvzx_Section = clsvzx_SectionBL.GetObjByzxSectionIdCache(strzxSectionId);
if (objvzx_Section == null) return "";
return objvzx_Section[strOutFldName].ToString();
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
int intRecCount = clsvzx_SectionDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_SectionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_SectionDA.GetRecCount();
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
int intRecCount = clsvzx_SectionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_SectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_SectionEN objvzx_SectionCond)
{
List<clsvzx_SectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_SectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_Section.AttributeName)
{
if (objvzx_SectionCond.IsUpdated(strFldName) == false) continue;
if (objvzx_SectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SectionCond[strFldName].ToString());
}
else
{
if (objvzx_SectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_SectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_SectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_SectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_SectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_SectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_SectionCond[strFldName]));
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
 List<string> arrList = clsvzx_SectionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_SectionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_SectionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}