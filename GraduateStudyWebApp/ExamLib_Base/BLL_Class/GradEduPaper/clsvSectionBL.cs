
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSectionBL
 表名:vSection(01120559)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:56:49
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
public static class  clsvSectionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSectionEN GetObj(this K_SectionId_vSection myKey)
{
clsvSectionEN objvSectionEN = clsvSectionBL.vSectionDA.GetObjBySectionId(myKey.Value);
return objvSectionEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetSectionId(this clsvSectionEN objvSectionEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convSection.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convSection.SectionId);
}
objvSectionEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.SectionId) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.SectionId, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.SectionId] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetSectionName(this clsvSectionEN objvSectionEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convSection.SectionName);
}
objvSectionEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.SectionName) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.SectionName, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.SectionName] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetPaperId(this clsvSectionEN objvSectionEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convSection.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convSection.PaperId);
}
objvSectionEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.PaperId) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.PaperId, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.PaperId] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetOrderNum(this clsvSectionEN objvSectionEN, int? intOrderNum, string strComparisonOp="")
	{
objvSectionEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.OrderNum) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.OrderNum, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.OrderNum] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetUpdDate(this clsvSectionEN objvSectionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSection.UpdDate);
}
objvSectionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.UpdDate) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.UpdDate, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.UpdDate] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetUpdUser(this clsvSectionEN objvSectionEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convSection.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convSection.UpdUser);
}
objvSectionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.UpdUser) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.UpdUser, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.UpdUser] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetMemo(this clsvSectionEN objvSectionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convSection.Memo);
}
objvSectionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.Memo) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.Memo, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.Memo] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetPaperTitle(this clsvSectionEN objvSectionEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convSection.PaperTitle);
}
objvSectionEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.PaperTitle) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.PaperTitle, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.PaperTitle] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetAuthor(this clsvSectionEN objvSectionEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convSection.Author);
}
objvSectionEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.Author) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.Author, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.Author] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetResearchQuestion(this clsvSectionEN objvSectionEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convSection.ResearchQuestion);
}
objvSectionEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.ResearchQuestion) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.ResearchQuestion, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.ResearchQuestion] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetKeyword(this clsvSectionEN objvSectionEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convSection.Keyword);
}
objvSectionEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.Keyword) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.Keyword, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.Keyword] = strComparisonOp;
}
}
return objvSectionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSectionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSectionEN SetParentId(this clsvSectionEN objvSectionEN, string strParentId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, convSection.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, convSection.ParentId);
}
objvSectionEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSectionEN.dicFldComparisonOp.ContainsKey(convSection.ParentId) == false)
{
objvSectionEN.dicFldComparisonOp.Add(convSection.ParentId, strComparisonOp);
}
else
{
objvSectionEN.dicFldComparisonOp[convSection.ParentId] = strComparisonOp;
}
}
return objvSectionEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSectionENS">源对象</param>
 /// <param name = "objvSectionENT">目标对象</param>
 public static void CopyTo(this clsvSectionEN objvSectionENS, clsvSectionEN objvSectionENT)
{
try
{
objvSectionENT.SectionId = objvSectionENS.SectionId; //节Id
objvSectionENT.SectionName = objvSectionENS.SectionName; //节名
objvSectionENT.PaperId = objvSectionENS.PaperId; //论文Id
objvSectionENT.OrderNum = objvSectionENS.OrderNum; //序号
objvSectionENT.UpdDate = objvSectionENS.UpdDate; //修改日期
objvSectionENT.UpdUser = objvSectionENS.UpdUser; //修改人
objvSectionENT.Memo = objvSectionENS.Memo; //备注
objvSectionENT.PaperTitle = objvSectionENS.PaperTitle; //论文标题
objvSectionENT.Author = objvSectionENS.Author; //作者
objvSectionENT.ResearchQuestion = objvSectionENS.ResearchQuestion; //研究问题
objvSectionENT.Keyword = objvSectionENS.Keyword; //关键字
objvSectionENT.ParentId = objvSectionENS.ParentId; //父节点Id
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
 /// <param name = "objvSectionENS">源对象</param>
 /// <returns>目标对象=>clsvSectionEN:objvSectionENT</returns>
 public static clsvSectionEN CopyTo(this clsvSectionEN objvSectionENS)
{
try
{
 clsvSectionEN objvSectionENT = new clsvSectionEN()
{
SectionId = objvSectionENS.SectionId, //节Id
SectionName = objvSectionENS.SectionName, //节名
PaperId = objvSectionENS.PaperId, //论文Id
OrderNum = objvSectionENS.OrderNum, //序号
UpdDate = objvSectionENS.UpdDate, //修改日期
UpdUser = objvSectionENS.UpdUser, //修改人
Memo = objvSectionENS.Memo, //备注
PaperTitle = objvSectionENS.PaperTitle, //论文标题
Author = objvSectionENS.Author, //作者
ResearchQuestion = objvSectionENS.ResearchQuestion, //研究问题
Keyword = objvSectionENS.Keyword, //关键字
ParentId = objvSectionENS.ParentId, //父节点Id
};
 return objvSectionENT;
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
public static void CheckProperty4Condition(this clsvSectionEN objvSectionEN)
{
 clsvSectionBL.vSectionDA.CheckProperty4Condition(objvSectionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSectionEN objvSectionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSectionCond.IsUpdated(convSection.SectionId) == true)
{
string strComparisonOpSectionId = objvSectionCond.dicFldComparisonOp[convSection.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.SectionId, objvSectionCond.SectionId, strComparisonOpSectionId);
}
if (objvSectionCond.IsUpdated(convSection.SectionName) == true)
{
string strComparisonOpSectionName = objvSectionCond.dicFldComparisonOp[convSection.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.SectionName, objvSectionCond.SectionName, strComparisonOpSectionName);
}
if (objvSectionCond.IsUpdated(convSection.PaperId) == true)
{
string strComparisonOpPaperId = objvSectionCond.dicFldComparisonOp[convSection.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.PaperId, objvSectionCond.PaperId, strComparisonOpPaperId);
}
if (objvSectionCond.IsUpdated(convSection.OrderNum) == true)
{
string strComparisonOpOrderNum = objvSectionCond.dicFldComparisonOp[convSection.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSection.OrderNum, objvSectionCond.OrderNum, strComparisonOpOrderNum);
}
if (objvSectionCond.IsUpdated(convSection.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSectionCond.dicFldComparisonOp[convSection.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.UpdDate, objvSectionCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSectionCond.IsUpdated(convSection.UpdUser) == true)
{
string strComparisonOpUpdUser = objvSectionCond.dicFldComparisonOp[convSection.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.UpdUser, objvSectionCond.UpdUser, strComparisonOpUpdUser);
}
if (objvSectionCond.IsUpdated(convSection.Memo) == true)
{
string strComparisonOpMemo = objvSectionCond.dicFldComparisonOp[convSection.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.Memo, objvSectionCond.Memo, strComparisonOpMemo);
}
if (objvSectionCond.IsUpdated(convSection.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvSectionCond.dicFldComparisonOp[convSection.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.PaperTitle, objvSectionCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvSectionCond.IsUpdated(convSection.Author) == true)
{
string strComparisonOpAuthor = objvSectionCond.dicFldComparisonOp[convSection.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.Author, objvSectionCond.Author, strComparisonOpAuthor);
}
if (objvSectionCond.IsUpdated(convSection.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objvSectionCond.dicFldComparisonOp[convSection.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.ResearchQuestion, objvSectionCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objvSectionCond.IsUpdated(convSection.Keyword) == true)
{
string strComparisonOpKeyword = objvSectionCond.dicFldComparisonOp[convSection.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.Keyword, objvSectionCond.Keyword, strComparisonOpKeyword);
}
if (objvSectionCond.IsUpdated(convSection.ParentId) == true)
{
string strComparisonOpParentId = objvSectionCond.dicFldComparisonOp[convSection.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSection.ParentId, objvSectionCond.ParentId, strComparisonOpParentId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSection
{
public virtual bool UpdRelaTabDate(string strSectionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文节视图(vSection)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSectionBL
{
public static RelatedActions_vSection relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSectionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSectionDA vSectionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSectionDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSectionBL()
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
if (string.IsNullOrEmpty(clsvSectionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSectionEN._ConnectString);
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
public static DataTable GetDataTable_vSection(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSectionDA.GetDataTable_vSection(strWhereCond);
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
objDT = vSectionDA.GetDataTable(strWhereCond);
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
objDT = vSectionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSectionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSectionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSectionDA.GetDataTable_Top(objTopPara);
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
objDT = vSectionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSectionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSectionEN> GetObjLstBySectionIdLst(List<string> arrSectionIdLst)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSectionIdLst, true);
 string strWhereCond = string.Format("SectionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSectionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSectionEN> GetObjLstBySectionIdLstCache(List<string> arrSectionIdLst)
{
string strKey = string.Format("{0}", clsvSectionEN._CurrTabName);
List<clsvSectionEN> arrvSectionObjLstCache = GetObjLstCache();
IEnumerable <clsvSectionEN> arrvSectionObjLst_Sel =
arrvSectionObjLstCache
.Where(x => arrSectionIdLst.Contains(x.SectionId));
return arrvSectionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSectionEN> GetObjLst(string strWhereCond)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
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
public static List<clsvSectionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSectionEN> GetSubObjLstCache(clsvSectionEN objvSectionCond)
{
List<clsvSectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSection.AttributeName)
{
if (objvSectionCond.IsUpdated(strFldName) == false) continue;
if (objvSectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSectionCond[strFldName].ToString());
}
else
{
if (objvSectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSectionCond[strFldName]));
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
public static List<clsvSectionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
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
public static List<clsvSectionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
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
List<clsvSectionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSectionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSectionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSectionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
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
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
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
public static List<clsvSectionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSectionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
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
public static List<clsvSectionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSectionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSectionEN> arrObjLst = new List<clsvSectionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSectionEN objvSectionEN = new clsvSectionEN();
try
{
objvSectionEN.SectionId = objRow[convSection.SectionId].ToString().Trim(); //节Id
objvSectionEN.SectionName = objRow[convSection.SectionName] == DBNull.Value ? null : objRow[convSection.SectionName].ToString().Trim(); //节名
objvSectionEN.PaperId = objRow[convSection.PaperId] == DBNull.Value ? null : objRow[convSection.PaperId].ToString().Trim(); //论文Id
objvSectionEN.OrderNum = objRow[convSection.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSection.OrderNum].ToString().Trim()); //序号
objvSectionEN.UpdDate = objRow[convSection.UpdDate] == DBNull.Value ? null : objRow[convSection.UpdDate].ToString().Trim(); //修改日期
objvSectionEN.UpdUser = objRow[convSection.UpdUser].ToString().Trim(); //修改人
objvSectionEN.Memo = objRow[convSection.Memo] == DBNull.Value ? null : objRow[convSection.Memo].ToString().Trim(); //备注
objvSectionEN.PaperTitle = objRow[convSection.PaperTitle] == DBNull.Value ? null : objRow[convSection.PaperTitle].ToString().Trim(); //论文标题
objvSectionEN.Author = objRow[convSection.Author] == DBNull.Value ? null : objRow[convSection.Author].ToString().Trim(); //作者
objvSectionEN.ResearchQuestion = objRow[convSection.ResearchQuestion] == DBNull.Value ? null : objRow[convSection.ResearchQuestion].ToString().Trim(); //研究问题
objvSectionEN.Keyword = objRow[convSection.Keyword] == DBNull.Value ? null : objRow[convSection.Keyword].ToString().Trim(); //关键字
objvSectionEN.ParentId = objRow[convSection.ParentId] == DBNull.Value ? null : objRow[convSection.ParentId].ToString().Trim(); //父节点Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSectionEN.SectionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSectionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSectionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSection(ref clsvSectionEN objvSectionEN)
{
bool bolResult = vSectionDA.GetvSection(ref objvSectionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSectionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSectionEN GetObjBySectionId(string strSectionId)
{
if (strSectionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSectionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSectionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSectionEN objvSectionEN = vSectionDA.GetObjBySectionId(strSectionId);
return objvSectionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSectionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSectionEN objvSectionEN = vSectionDA.GetFirstObj(strWhereCond);
 return objvSectionEN;
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
public static clsvSectionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSectionEN objvSectionEN = vSectionDA.GetObjByDataRow(objRow);
 return objvSectionEN;
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
public static clsvSectionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSectionEN objvSectionEN = vSectionDA.GetObjByDataRow(objRow);
 return objvSectionEN;
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
 /// <param name = "strSectionId">所给的关键字</param>
 /// <param name = "lstvSectionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSectionEN GetObjBySectionIdFromList(string strSectionId, List<clsvSectionEN> lstvSectionObjLst)
{
foreach (clsvSectionEN objvSectionEN in lstvSectionObjLst)
{
if (objvSectionEN.SectionId == strSectionId)
{
return objvSectionEN;
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
 string strMaxSectionId;
 try
 {
 strMaxSectionId = clsvSectionDA.GetMaxStrId();
 return strMaxSectionId;
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
 string strSectionId;
 try
 {
 strSectionId = new clsvSectionDA().GetFirstID(strWhereCond);
 return strSectionId;
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
 arrList = vSectionDA.GetID(strWhereCond);
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
bool bolIsExist = vSectionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSectionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSectionId)
{
if (string.IsNullOrEmpty(strSectionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSectionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSectionDA.IsExist(strSectionId);
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
 bolIsExist = clsvSectionDA.IsExistTable();
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
 bolIsExist = vSectionDA.IsExistTable(strTabName);
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
 /// <param name = "objvSectionENS">源对象</param>
 /// <param name = "objvSectionENT">目标对象</param>
 public static void CopyTo(clsvSectionEN objvSectionENS, clsvSectionEN objvSectionENT)
{
try
{
objvSectionENT.SectionId = objvSectionENS.SectionId; //节Id
objvSectionENT.SectionName = objvSectionENS.SectionName; //节名
objvSectionENT.PaperId = objvSectionENS.PaperId; //论文Id
objvSectionENT.OrderNum = objvSectionENS.OrderNum; //序号
objvSectionENT.UpdDate = objvSectionENS.UpdDate; //修改日期
objvSectionENT.UpdUser = objvSectionENS.UpdUser; //修改人
objvSectionENT.Memo = objvSectionENS.Memo; //备注
objvSectionENT.PaperTitle = objvSectionENS.PaperTitle; //论文标题
objvSectionENT.Author = objvSectionENS.Author; //作者
objvSectionENT.ResearchQuestion = objvSectionENS.ResearchQuestion; //研究问题
objvSectionENT.Keyword = objvSectionENS.Keyword; //关键字
objvSectionENT.ParentId = objvSectionENS.ParentId; //父节点Id
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
 /// <param name = "objvSectionEN">源简化对象</param>
 public static void SetUpdFlag(clsvSectionEN objvSectionEN)
{
try
{
objvSectionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSectionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSection.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.SectionId = objvSectionEN.SectionId; //节Id
}
if (arrFldSet.Contains(convSection.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.SectionName = objvSectionEN.SectionName == "[null]" ? null :  objvSectionEN.SectionName; //节名
}
if (arrFldSet.Contains(convSection.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.PaperId = objvSectionEN.PaperId == "[null]" ? null :  objvSectionEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convSection.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.OrderNum = objvSectionEN.OrderNum; //序号
}
if (arrFldSet.Contains(convSection.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.UpdDate = objvSectionEN.UpdDate == "[null]" ? null :  objvSectionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSection.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.UpdUser = objvSectionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convSection.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.Memo = objvSectionEN.Memo == "[null]" ? null :  objvSectionEN.Memo; //备注
}
if (arrFldSet.Contains(convSection.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.PaperTitle = objvSectionEN.PaperTitle == "[null]" ? null :  objvSectionEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convSection.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.Author = objvSectionEN.Author == "[null]" ? null :  objvSectionEN.Author; //作者
}
if (arrFldSet.Contains(convSection.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.ResearchQuestion = objvSectionEN.ResearchQuestion == "[null]" ? null :  objvSectionEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(convSection.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.Keyword = objvSectionEN.Keyword == "[null]" ? null :  objvSectionEN.Keyword; //关键字
}
if (arrFldSet.Contains(convSection.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSectionEN.ParentId = objvSectionEN.ParentId == "[null]" ? null :  objvSectionEN.ParentId; //父节点Id
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
 /// <param name = "objvSectionEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSectionEN objvSectionEN)
{
try
{
if (objvSectionEN.SectionName == "[null]") objvSectionEN.SectionName = null; //节名
if (objvSectionEN.PaperId == "[null]") objvSectionEN.PaperId = null; //论文Id
if (objvSectionEN.UpdDate == "[null]") objvSectionEN.UpdDate = null; //修改日期
if (objvSectionEN.Memo == "[null]") objvSectionEN.Memo = null; //备注
if (objvSectionEN.PaperTitle == "[null]") objvSectionEN.PaperTitle = null; //论文标题
if (objvSectionEN.Author == "[null]") objvSectionEN.Author = null; //作者
if (objvSectionEN.ResearchQuestion == "[null]") objvSectionEN.ResearchQuestion = null; //研究问题
if (objvSectionEN.Keyword == "[null]") objvSectionEN.Keyword = null; //关键字
if (objvSectionEN.ParentId == "[null]") objvSectionEN.ParentId = null; //父节点Id
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
public static void CheckProperty4Condition(clsvSectionEN objvSectionEN)
{
 vSectionDA.CheckProperty4Condition(objvSectionEN);
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SectionId");
//if (arrvSectionObjLstCache == null)
//{
//arrvSectionObjLstCache = vSectionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSectionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSectionEN GetObjBySectionIdCache(string strSectionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSectionEN._CurrTabName);
List<clsvSectionEN> arrvSectionObjLstCache = GetObjLstCache();
IEnumerable <clsvSectionEN> arrvSectionObjLst_Sel =
arrvSectionObjLstCache
.Where(x=> x.SectionId == strSectionId 
);
if (arrvSectionObjLst_Sel.Count() == 0)
{
   clsvSectionEN obj = clsvSectionBL.GetObjBySectionId(strSectionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSectionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSectionEN> GetAllvSectionObjLstCache()
{
//获取缓存中的对象列表
List<clsvSectionEN> arrvSectionObjLstCache = GetObjLstCache(); 
return arrvSectionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSectionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSectionEN._CurrTabName);
List<clsvSectionEN> arrvSectionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSectionObjLstCache;
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
string strKey = string.Format("{0}", clsvSectionEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strSectionId)
{
if (strInFldName != convSection.SectionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSection.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSection.AttributeName));
throw new Exception(strMsg);
}
var objvSection = clsvSectionBL.GetObjBySectionIdCache(strSectionId);
if (objvSection == null) return "";
return objvSection[strOutFldName].ToString();
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
int intRecCount = clsvSectionDA.GetRecCount(strTabName);
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
int intRecCount = clsvSectionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSectionDA.GetRecCount();
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
int intRecCount = clsvSectionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSectionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSectionEN objvSectionCond)
{
List<clsvSectionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSectionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSection.AttributeName)
{
if (objvSectionCond.IsUpdated(strFldName) == false) continue;
if (objvSectionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSectionCond[strFldName].ToString());
}
else
{
if (objvSectionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSectionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSectionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSectionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSectionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSectionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSectionCond[strFldName]));
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
 List<string> arrList = clsvSectionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSectionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSectionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数


 #region 排序相关函数


 #endregion 排序相关函数
}
}