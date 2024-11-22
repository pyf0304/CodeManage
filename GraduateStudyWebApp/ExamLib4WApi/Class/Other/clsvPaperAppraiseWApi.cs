
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperAppraiseWApi
 表名:vPaperAppraise(01120568)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:08
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
public static class clsvPaperAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperAppraiseId(this clsvPaperAppraiseEN objvPaperAppraiseEN, long lngPaperAppraiseId, string strComparisonOp="")
	{
objvPaperAppraiseEN.PaperAppraiseId = lngPaperAppraiseId; //论文评论Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperAppraiseId) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperAppraiseId, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperAppraiseId] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperAppraiseContent(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strPaperAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperAppraiseContent, 2000, convPaperAppraise.PaperAppraiseContent);
objvPaperAppraiseEN.PaperAppraiseContent = strPaperAppraiseContent; //论文评论内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperAppraiseContent) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperAppraiseContent, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperAppraiseContent] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetAppraiseScore(this clsvPaperAppraiseEN objvPaperAppraiseEN, float fltAppraiseScore, string strComparisonOp="")
	{
objvPaperAppraiseEN.AppraiseScore = fltAppraiseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.AppraiseScore) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.AppraiseScore, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.AppraiseScore] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperId(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperAppraise.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperAppraise.PaperId);
objvPaperAppraiseEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperId) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperId, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperId] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetUpdUser(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperAppraise.UpdUser);
objvPaperAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.UpdUser) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.UpdUser, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.UpdUser] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetUpdDate(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperAppraise.UpdDate);
objvPaperAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.UpdDate) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.UpdDate, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.UpdDate] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetMemo(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperAppraise.Memo);
objvPaperAppraiseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.Memo) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.Memo, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.Memo] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperTitle(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strPaperTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperAppraise.PaperTitle);
objvPaperAppraiseEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperTitle) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperTitle, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperTitle] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetPaperName(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strPaperName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperName, 500, convPaperAppraise.PaperName);
objvPaperAppraiseEN.PaperName = strPaperName; //主题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.PaperName) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.PaperName, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.PaperName] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetResearchQuestion(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strResearchQuestion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, convPaperAppraise.ResearchQuestion);
objvPaperAppraiseEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.ResearchQuestion) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.ResearchQuestion, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.ResearchQuestion] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetAuthor(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperAppraise.Author);
objvPaperAppraiseEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.Author) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.Author, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.Author] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetKeyword(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strKeyword, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperAppraise.Keyword);
objvPaperAppraiseEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.Keyword) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.Keyword, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.Keyword] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetBrowseNumber(this clsvPaperAppraiseEN objvPaperAppraiseEN, int intBrowseNumber, string strComparisonOp="")
	{
objvPaperAppraiseEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.BrowseNumber) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.BrowseNumber, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.BrowseNumber] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperAppraiseEN SetUserName(this clsvPaperAppraiseEN objvPaperAppraiseEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convPaperAppraise.UserName);
objvPaperAppraiseEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperAppraise.UserName) == false)
{
objvPaperAppraiseEN.dicFldComparisonOp.Add(convPaperAppraise.UserName, strComparisonOp);
}
else
{
objvPaperAppraiseEN.dicFldComparisonOp[convPaperAppraise.UserName] = strComparisonOp;
}
}
return objvPaperAppraiseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperAppraiseEN objvPaperAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.PaperAppraiseId) == true)
{
string strComparisonOp_PaperAppraiseId = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.PaperAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperAppraise.PaperAppraiseId, objvPaperAppraise_Cond.PaperAppraiseId, strComparisonOp_PaperAppraiseId);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.PaperAppraiseContent) == true)
{
string strComparisonOp_PaperAppraiseContent = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.PaperAppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.PaperAppraiseContent, objvPaperAppraise_Cond.PaperAppraiseContent, strComparisonOp_PaperAppraiseContent);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.AppraiseScore) == true)
{
string strComparisonOp_AppraiseScore = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.AppraiseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperAppraise.AppraiseScore, objvPaperAppraise_Cond.AppraiseScore, strComparisonOp_AppraiseScore);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.PaperId) == true)
{
string strComparisonOp_PaperId = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.PaperId, objvPaperAppraise_Cond.PaperId, strComparisonOp_PaperId);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.UpdUser, objvPaperAppraise_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.UpdDate, objvPaperAppraise_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.Memo) == true)
{
string strComparisonOp_Memo = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.Memo, objvPaperAppraise_Cond.Memo, strComparisonOp_Memo);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.PaperTitle) == true)
{
string strComparisonOp_PaperTitle = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.PaperTitle, objvPaperAppraise_Cond.PaperTitle, strComparisonOp_PaperTitle);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.PaperName) == true)
{
string strComparisonOp_PaperName = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.PaperName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.PaperName, objvPaperAppraise_Cond.PaperName, strComparisonOp_PaperName);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.ResearchQuestion) == true)
{
string strComparisonOp_ResearchQuestion = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.ResearchQuestion, objvPaperAppraise_Cond.ResearchQuestion, strComparisonOp_ResearchQuestion);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.Author) == true)
{
string strComparisonOp_Author = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.Author, objvPaperAppraise_Cond.Author, strComparisonOp_Author);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.Keyword) == true)
{
string strComparisonOp_Keyword = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.Keyword, objvPaperAppraise_Cond.Keyword, strComparisonOp_Keyword);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.BrowseNumber) == true)
{
string strComparisonOp_BrowseNumber = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperAppraise.BrowseNumber, objvPaperAppraise_Cond.BrowseNumber, strComparisonOp_BrowseNumber);
}
if (objvPaperAppraise_Cond.IsUpdated(convPaperAppraise.UserName) == true)
{
string strComparisonOp_UserName = objvPaperAppraise_Cond.dicFldComparisonOp[convPaperAppraise.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperAppraise.UserName, objvPaperAppraise_Cond.UserName, strComparisonOp_UserName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v论文评论表(vPaperAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPaperAppraiseWApi
{
private static readonly string mstrApiControllerName = "vPaperAppraiseApi";

 public clsvPaperAppraiseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperAppraiseEN GetObjByPaperAppraiseId(long lngPaperAppraiseId)
{
string strAction = "GetObjByPaperAppraiseId";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperAppraiseEN objvPaperAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAppraiseId"] = lngPaperAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperAppraiseEN = JsonConvert.DeserializeObject<clsvPaperAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvPaperAppraiseEN;
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
 /// <param name = "lngPaperAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperAppraiseEN GetObjByPaperAppraiseId_WA_Cache(long lngPaperAppraiseId)
{
string strAction = "GetObjByPaperAppraiseId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperAppraiseEN objvPaperAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAppraiseId"] = lngPaperAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperAppraiseEN = JsonConvert.DeserializeObject<clsvPaperAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvPaperAppraiseEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
public static clsvPaperAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperAppraiseEN objvPaperAppraiseEN = null;
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
objvPaperAppraiseEN = JsonConvert.DeserializeObject<clsvPaperAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvPaperAppraiseEN;
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
 /// <param name = "lngPaperAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperAppraiseEN GetObjByPaperAppraiseId_Cache(long lngPaperAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName_S);
List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperAppraiseEN> arrvPaperAppraiseObjLst_Sel =
from objvPaperAppraiseEN in arrvPaperAppraiseObjLst_Cache
where objvPaperAppraiseEN.PaperAppraiseId == lngPaperAppraiseId
select objvPaperAppraiseEN;
if (arrvPaperAppraiseObjLst_Sel.Count() == 0)
{
   clsvPaperAppraiseEN obj = clsvPaperAppraiseWApi.GetObjByPaperAppraiseId(lngPaperAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPaperAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsvPaperAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperAppraiseEN> GetObjLstByPaperAppraiseIdLst(List<long> arrPaperAppraiseId)
{
 List<clsvPaperAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperAppraiseIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPaperAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPaperAppraiseEN> GetObjLstByPaperAppraiseIdLst_Cache(List<long> arrPaperAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName_S);
List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperAppraiseEN> arrvPaperAppraiseObjLst_Sel =
from objvPaperAppraiseEN in arrvPaperAppraiseObjLst_Cache
where arrPaperAppraiseId.Contains(objvPaperAppraiseEN.PaperAppraiseId)
select objvPaperAppraiseEN;
return arrvPaperAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperAppraiseEN> GetObjLstByPaperAppraiseIdLst_WA_Cache(List<long> arrPaperAppraiseId)
{
 List<clsvPaperAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperAppraiseIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPaperAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPaperAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPaperAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPaperAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngPaperAppraiseId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperAppraiseId"] = lngPaperAppraiseId.ToString()
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
 /// <param name = "objvPaperAppraiseENS">源对象</param>
 /// <param name = "objvPaperAppraiseENT">目标对象</param>
 public static void CopyTo(clsvPaperAppraiseEN objvPaperAppraiseENS, clsvPaperAppraiseEN objvPaperAppraiseENT)
{
try
{
objvPaperAppraiseENT.PaperAppraiseId = objvPaperAppraiseENS.PaperAppraiseId; //论文评论Id
objvPaperAppraiseENT.PaperAppraiseContent = objvPaperAppraiseENS.PaperAppraiseContent; //论文评论内容
objvPaperAppraiseENT.AppraiseScore = objvPaperAppraiseENS.AppraiseScore; //打分
objvPaperAppraiseENT.PaperId = objvPaperAppraiseENS.PaperId; //论文Id
objvPaperAppraiseENT.UpdUser = objvPaperAppraiseENS.UpdUser; //修改人
objvPaperAppraiseENT.UpdDate = objvPaperAppraiseENS.UpdDate; //修改日期
objvPaperAppraiseENT.Memo = objvPaperAppraiseENS.Memo; //备注
objvPaperAppraiseENT.PaperTitle = objvPaperAppraiseENS.PaperTitle; //论文标题
objvPaperAppraiseENT.PaperName = objvPaperAppraiseENS.PaperName; //主题名称
objvPaperAppraiseENT.ResearchQuestion = objvPaperAppraiseENS.ResearchQuestion; //研究问题
objvPaperAppraiseENT.Author = objvPaperAppraiseENS.Author; //作者
objvPaperAppraiseENT.Keyword = objvPaperAppraiseENS.Keyword; //关键字
objvPaperAppraiseENT.BrowseNumber = objvPaperAppraiseENS.BrowseNumber; //浏览量
objvPaperAppraiseENT.UserName = objvPaperAppraiseENS.UserName; //用户名
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
public static DataTable ToDataTable(List<clsvPaperAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPaperAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPaperAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPaperAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPaperAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPaperAppraiseEN.AttributeName)
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
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperWApi没有刷新缓存机制(clsPaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperAppraiseWApi没有刷新缓存机制(clsPaperAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperAppraiseId");
//if (arrvPaperAppraiseObjLst_Cache == null)
//{
//arrvPaperAppraiseObjLst_Cache = await clsvPaperAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName_S);
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
public static List<clsvPaperAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPaperAppraiseEN._CurrTabName_S);
List<clsvPaperAppraiseEN> arrvPaperAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPaperAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPaperAppraise.PaperAppraiseId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPaperAppraise.PaperAppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.AppraiseScore, Type.GetType("System.Single"));
objDT.Columns.Add(convPaperAppraise.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.PaperTitle, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.PaperName, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.ResearchQuestion, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.Author, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.Keyword, Type.GetType("System.String"));
objDT.Columns.Add(convPaperAppraise.BrowseNumber, Type.GetType("System.Int32"));
objDT.Columns.Add(convPaperAppraise.UserName, Type.GetType("System.String"));
foreach (clsvPaperAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPaperAppraise.PaperAppraiseId] = objInFor[convPaperAppraise.PaperAppraiseId];
objDR[convPaperAppraise.PaperAppraiseContent] = objInFor[convPaperAppraise.PaperAppraiseContent];
objDR[convPaperAppraise.AppraiseScore] = objInFor[convPaperAppraise.AppraiseScore];
objDR[convPaperAppraise.PaperId] = objInFor[convPaperAppraise.PaperId];
objDR[convPaperAppraise.UpdUser] = objInFor[convPaperAppraise.UpdUser];
objDR[convPaperAppraise.UpdDate] = objInFor[convPaperAppraise.UpdDate];
objDR[convPaperAppraise.Memo] = objInFor[convPaperAppraise.Memo];
objDR[convPaperAppraise.PaperTitle] = objInFor[convPaperAppraise.PaperTitle];
objDR[convPaperAppraise.PaperName] = objInFor[convPaperAppraise.PaperName];
objDR[convPaperAppraise.ResearchQuestion] = objInFor[convPaperAppraise.ResearchQuestion];
objDR[convPaperAppraise.Author] = objInFor[convPaperAppraise.Author];
objDR[convPaperAppraise.Keyword] = objInFor[convPaperAppraise.Keyword];
objDR[convPaperAppraise.BrowseNumber] = objInFor[convPaperAppraise.BrowseNumber];
objDR[convPaperAppraise.UserName] = objInFor[convPaperAppraise.UserName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}