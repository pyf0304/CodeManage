
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCollectionLogBL
 表名:vPaperCollectionLog(01120569)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:00:44
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
public static class  clsvPaperCollectionLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperCollectionLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCollectionLogEN GetObj(this K_PaperCollectionLogId_vPaperCollectionLog myKey)
{
clsvPaperCollectionLogEN objvPaperCollectionLogEN = clsvPaperCollectionLogBL.vPaperCollectionLogDA.GetObjByPaperCollectionLogId(myKey.Value);
return objvPaperCollectionLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetPaperCollectionLogId(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, long lngPaperCollectionLogId, string strComparisonOp="")
	{
objvPaperCollectionLogEN.PaperCollectionLogId = lngPaperCollectionLogId; //论文收藏Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.PaperCollectionLogId) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.PaperCollectionLogId, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.PaperCollectionLogId] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetPaperId(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperCollectionLog.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperCollectionLog.PaperId);
}
objvPaperCollectionLogEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.PaperId) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.PaperId, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.PaperId] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetUpdUser(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convPaperCollectionLog.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperCollectionLog.UpdUser);
}
objvPaperCollectionLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.UpdUser) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.UpdUser, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.UpdUser] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetUpdDate(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperCollectionLog.UpdDate);
}
objvPaperCollectionLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.UpdDate) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.UpdDate, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.UpdDate] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetMeno(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, string strMeno, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeno, 2000, convPaperCollectionLog.Meno);
}
objvPaperCollectionLogEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.Meno) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.Meno, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.Meno] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetPaperTitle(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperCollectionLog.PaperTitle);
}
objvPaperCollectionLogEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.PaperTitle) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.PaperTitle, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.PaperTitle] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetAuthor(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convPaperCollectionLog.Author);
}
objvPaperCollectionLogEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.Author) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.Author, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.Author] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetKeyword(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, convPaperCollectionLog.Keyword);
}
objvPaperCollectionLogEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.Keyword) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.Keyword, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.Keyword] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCollectionLogEN SetBrowseNumber(this clsvPaperCollectionLogEN objvPaperCollectionLogEN, int? intBrowseNumber, string strComparisonOp="")
	{
objvPaperCollectionLogEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCollectionLogEN.dicFldComparisonOp.ContainsKey(convPaperCollectionLog.BrowseNumber) == false)
{
objvPaperCollectionLogEN.dicFldComparisonOp.Add(convPaperCollectionLog.BrowseNumber, strComparisonOp);
}
else
{
objvPaperCollectionLogEN.dicFldComparisonOp[convPaperCollectionLog.BrowseNumber] = strComparisonOp;
}
}
return objvPaperCollectionLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperCollectionLogENS">源对象</param>
 /// <param name = "objvPaperCollectionLogENT">目标对象</param>
 public static void CopyTo(this clsvPaperCollectionLogEN objvPaperCollectionLogENS, clsvPaperCollectionLogEN objvPaperCollectionLogENT)
{
try
{
objvPaperCollectionLogENT.PaperCollectionLogId = objvPaperCollectionLogENS.PaperCollectionLogId; //论文收藏Id
objvPaperCollectionLogENT.PaperId = objvPaperCollectionLogENS.PaperId; //论文Id
objvPaperCollectionLogENT.UpdUser = objvPaperCollectionLogENS.UpdUser; //修改人
objvPaperCollectionLogENT.UpdDate = objvPaperCollectionLogENS.UpdDate; //修改日期
objvPaperCollectionLogENT.Meno = objvPaperCollectionLogENS.Meno; //备注
objvPaperCollectionLogENT.PaperTitle = objvPaperCollectionLogENS.PaperTitle; //论文标题
objvPaperCollectionLogENT.Author = objvPaperCollectionLogENS.Author; //作者
objvPaperCollectionLogENT.Keyword = objvPaperCollectionLogENS.Keyword; //关键字
objvPaperCollectionLogENT.BrowseNumber = objvPaperCollectionLogENS.BrowseNumber; //浏览量
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
 /// <param name = "objvPaperCollectionLogENS">源对象</param>
 /// <returns>目标对象=>clsvPaperCollectionLogEN:objvPaperCollectionLogENT</returns>
 public static clsvPaperCollectionLogEN CopyTo(this clsvPaperCollectionLogEN objvPaperCollectionLogENS)
{
try
{
 clsvPaperCollectionLogEN objvPaperCollectionLogENT = new clsvPaperCollectionLogEN()
{
PaperCollectionLogId = objvPaperCollectionLogENS.PaperCollectionLogId, //论文收藏Id
PaperId = objvPaperCollectionLogENS.PaperId, //论文Id
UpdUser = objvPaperCollectionLogENS.UpdUser, //修改人
UpdDate = objvPaperCollectionLogENS.UpdDate, //修改日期
Meno = objvPaperCollectionLogENS.Meno, //备注
PaperTitle = objvPaperCollectionLogENS.PaperTitle, //论文标题
Author = objvPaperCollectionLogENS.Author, //作者
Keyword = objvPaperCollectionLogENS.Keyword, //关键字
BrowseNumber = objvPaperCollectionLogENS.BrowseNumber, //浏览量
};
 return objvPaperCollectionLogENT;
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
public static void CheckProperty4Condition(this clsvPaperCollectionLogEN objvPaperCollectionLogEN)
{
 clsvPaperCollectionLogBL.vPaperCollectionLogDA.CheckProperty4Condition(objvPaperCollectionLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperCollectionLogEN objvPaperCollectionLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.PaperCollectionLogId) == true)
{
string strComparisonOpPaperCollectionLogId = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.PaperCollectionLogId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCollectionLog.PaperCollectionLogId, objvPaperCollectionLogCond.PaperCollectionLogId, strComparisonOpPaperCollectionLogId);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCollectionLog.PaperId, objvPaperCollectionLogCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCollectionLog.UpdUser, objvPaperCollectionLogCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCollectionLog.UpdDate, objvPaperCollectionLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.Meno) == true)
{
string strComparisonOpMeno = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCollectionLog.Meno, objvPaperCollectionLogCond.Meno, strComparisonOpMeno);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCollectionLog.PaperTitle, objvPaperCollectionLogCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.Author) == true)
{
string strComparisonOpAuthor = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCollectionLog.Author, objvPaperCollectionLogCond.Author, strComparisonOpAuthor);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.Keyword) == true)
{
string strComparisonOpKeyword = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCollectionLog.Keyword, objvPaperCollectionLogCond.Keyword, strComparisonOpKeyword);
}
if (objvPaperCollectionLogCond.IsUpdated(convPaperCollectionLog.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objvPaperCollectionLogCond.dicFldComparisonOp[convPaperCollectionLog.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCollectionLog.BrowseNumber, objvPaperCollectionLogCond.BrowseNumber, strComparisonOpBrowseNumber);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperCollectionLog
{
public virtual bool UpdRelaTabDate(long lngPaperCollectionLogId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v论文收藏(vPaperCollectionLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperCollectionLogBL
{
public static RelatedActions_vPaperCollectionLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperCollectionLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperCollectionLogDA vPaperCollectionLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperCollectionLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperCollectionLogBL()
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
if (string.IsNullOrEmpty(clsvPaperCollectionLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperCollectionLogEN._ConnectString);
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
public static DataTable GetDataTable_vPaperCollectionLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperCollectionLogDA.GetDataTable_vPaperCollectionLog(strWhereCond);
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
objDT = vPaperCollectionLogDA.GetDataTable(strWhereCond);
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
objDT = vPaperCollectionLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperCollectionLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperCollectionLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperCollectionLogDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperCollectionLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperCollectionLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperCollectionLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperCollectionLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperCollectionLogEN> GetObjLstByPaperCollectionLogIdLst(List<long> arrPaperCollectionLogIdLst)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperCollectionLogIdLst);
 string strWhereCond = string.Format("PaperCollectionLogId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperCollectionLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperCollectionLogEN> GetObjLstByPaperCollectionLogIdLstCache(List<long> arrPaperCollectionLogIdLst)
{
string strKey = string.Format("{0}", clsvPaperCollectionLogEN._CurrTabName);
List<clsvPaperCollectionLogEN> arrvPaperCollectionLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCollectionLogEN> arrvPaperCollectionLogObjLst_Sel =
arrvPaperCollectionLogObjLstCache
.Where(x => arrPaperCollectionLogIdLst.Contains(x.PaperCollectionLogId));
return arrvPaperCollectionLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCollectionLogEN> GetObjLst(string strWhereCond)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
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
public static List<clsvPaperCollectionLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperCollectionLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperCollectionLogEN> GetSubObjLstCache(clsvPaperCollectionLogEN objvPaperCollectionLogCond)
{
List<clsvPaperCollectionLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCollectionLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperCollectionLog.AttributeName)
{
if (objvPaperCollectionLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperCollectionLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCollectionLogCond[strFldName].ToString());
}
else
{
if (objvPaperCollectionLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCollectionLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCollectionLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCollectionLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCollectionLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCollectionLogCond[strFldName]));
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
public static List<clsvPaperCollectionLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
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
public static List<clsvPaperCollectionLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
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
List<clsvPaperCollectionLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperCollectionLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCollectionLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperCollectionLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
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
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
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
public static List<clsvPaperCollectionLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperCollectionLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperCollectionLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
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
public static List<clsvPaperCollectionLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCollectionLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperCollectionLogEN> arrObjLst = new List<clsvPaperCollectionLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCollectionLogEN objvPaperCollectionLogEN = new clsvPaperCollectionLogEN();
try
{
objvPaperCollectionLogEN.PaperCollectionLogId = Int32.Parse(objRow[convPaperCollectionLog.PaperCollectionLogId].ToString().Trim()); //论文收藏Id
objvPaperCollectionLogEN.PaperId = objRow[convPaperCollectionLog.PaperId] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperId].ToString().Trim(); //论文Id
objvPaperCollectionLogEN.UpdUser = objRow[convPaperCollectionLog.UpdUser].ToString().Trim(); //修改人
objvPaperCollectionLogEN.UpdDate = objRow[convPaperCollectionLog.UpdDate] == DBNull.Value ? null : objRow[convPaperCollectionLog.UpdDate].ToString().Trim(); //修改日期
objvPaperCollectionLogEN.Meno = objRow[convPaperCollectionLog.Meno] == DBNull.Value ? null : objRow[convPaperCollectionLog.Meno].ToString().Trim(); //备注
objvPaperCollectionLogEN.PaperTitle = objRow[convPaperCollectionLog.PaperTitle] == DBNull.Value ? null : objRow[convPaperCollectionLog.PaperTitle].ToString().Trim(); //论文标题
objvPaperCollectionLogEN.Author = objRow[convPaperCollectionLog.Author] == DBNull.Value ? null : objRow[convPaperCollectionLog.Author].ToString().Trim(); //作者
objvPaperCollectionLogEN.Keyword = objRow[convPaperCollectionLog.Keyword] == DBNull.Value ? null : objRow[convPaperCollectionLog.Keyword].ToString().Trim(); //关键字
objvPaperCollectionLogEN.BrowseNumber = objRow[convPaperCollectionLog.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCollectionLog.BrowseNumber].ToString().Trim()); //浏览量
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCollectionLogEN.PaperCollectionLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCollectionLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperCollectionLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperCollectionLog(ref clsvPaperCollectionLogEN objvPaperCollectionLogEN)
{
bool bolResult = vPaperCollectionLogDA.GetvPaperCollectionLog(ref objvPaperCollectionLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperCollectionLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCollectionLogEN GetObjByPaperCollectionLogId(long lngPaperCollectionLogId)
{
clsvPaperCollectionLogEN objvPaperCollectionLogEN = vPaperCollectionLogDA.GetObjByPaperCollectionLogId(lngPaperCollectionLogId);
return objvPaperCollectionLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperCollectionLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperCollectionLogEN objvPaperCollectionLogEN = vPaperCollectionLogDA.GetFirstObj(strWhereCond);
 return objvPaperCollectionLogEN;
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
public static clsvPaperCollectionLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperCollectionLogEN objvPaperCollectionLogEN = vPaperCollectionLogDA.GetObjByDataRow(objRow);
 return objvPaperCollectionLogEN;
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
public static clsvPaperCollectionLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperCollectionLogEN objvPaperCollectionLogEN = vPaperCollectionLogDA.GetObjByDataRow(objRow);
 return objvPaperCollectionLogEN;
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
 /// <param name = "lngPaperCollectionLogId">所给的关键字</param>
 /// <param name = "lstvPaperCollectionLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperCollectionLogEN GetObjByPaperCollectionLogIdFromList(long lngPaperCollectionLogId, List<clsvPaperCollectionLogEN> lstvPaperCollectionLogObjLst)
{
foreach (clsvPaperCollectionLogEN objvPaperCollectionLogEN in lstvPaperCollectionLogObjLst)
{
if (objvPaperCollectionLogEN.PaperCollectionLogId == lngPaperCollectionLogId)
{
return objvPaperCollectionLogEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngPaperCollectionLogId;
 try
 {
 lngPaperCollectionLogId = new clsvPaperCollectionLogDA().GetFirstID(strWhereCond);
 return lngPaperCollectionLogId;
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
 arrList = vPaperCollectionLogDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperCollectionLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperCollectionLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperCollectionLogId)
{
//检测记录是否存在
bool bolIsExist = vPaperCollectionLogDA.IsExist(lngPaperCollectionLogId);
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
 bolIsExist = clsvPaperCollectionLogDA.IsExistTable();
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
 bolIsExist = vPaperCollectionLogDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperCollectionLogENS">源对象</param>
 /// <param name = "objvPaperCollectionLogENT">目标对象</param>
 public static void CopyTo(clsvPaperCollectionLogEN objvPaperCollectionLogENS, clsvPaperCollectionLogEN objvPaperCollectionLogENT)
{
try
{
objvPaperCollectionLogENT.PaperCollectionLogId = objvPaperCollectionLogENS.PaperCollectionLogId; //论文收藏Id
objvPaperCollectionLogENT.PaperId = objvPaperCollectionLogENS.PaperId; //论文Id
objvPaperCollectionLogENT.UpdUser = objvPaperCollectionLogENS.UpdUser; //修改人
objvPaperCollectionLogENT.UpdDate = objvPaperCollectionLogENS.UpdDate; //修改日期
objvPaperCollectionLogENT.Meno = objvPaperCollectionLogENS.Meno; //备注
objvPaperCollectionLogENT.PaperTitle = objvPaperCollectionLogENS.PaperTitle; //论文标题
objvPaperCollectionLogENT.Author = objvPaperCollectionLogENS.Author; //作者
objvPaperCollectionLogENT.Keyword = objvPaperCollectionLogENS.Keyword; //关键字
objvPaperCollectionLogENT.BrowseNumber = objvPaperCollectionLogENS.BrowseNumber; //浏览量
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
 /// <param name = "objvPaperCollectionLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperCollectionLogEN objvPaperCollectionLogEN)
{
try
{
objvPaperCollectionLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperCollectionLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperCollectionLog.PaperCollectionLogId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.PaperCollectionLogId = objvPaperCollectionLogEN.PaperCollectionLogId; //论文收藏Id
}
if (arrFldSet.Contains(convPaperCollectionLog.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.PaperId = objvPaperCollectionLogEN.PaperId == "[null]" ? null :  objvPaperCollectionLogEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperCollectionLog.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.UpdUser = objvPaperCollectionLogEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaperCollectionLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.UpdDate = objvPaperCollectionLogEN.UpdDate == "[null]" ? null :  objvPaperCollectionLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperCollectionLog.Meno, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.Meno = objvPaperCollectionLogEN.Meno == "[null]" ? null :  objvPaperCollectionLogEN.Meno; //备注
}
if (arrFldSet.Contains(convPaperCollectionLog.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.PaperTitle = objvPaperCollectionLogEN.PaperTitle == "[null]" ? null :  objvPaperCollectionLogEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperCollectionLog.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.Author = objvPaperCollectionLogEN.Author == "[null]" ? null :  objvPaperCollectionLogEN.Author; //作者
}
if (arrFldSet.Contains(convPaperCollectionLog.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.Keyword = objvPaperCollectionLogEN.Keyword == "[null]" ? null :  objvPaperCollectionLogEN.Keyword; //关键字
}
if (arrFldSet.Contains(convPaperCollectionLog.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCollectionLogEN.BrowseNumber = objvPaperCollectionLogEN.BrowseNumber; //浏览量
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
 /// <param name = "objvPaperCollectionLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperCollectionLogEN objvPaperCollectionLogEN)
{
try
{
if (objvPaperCollectionLogEN.PaperId == "[null]") objvPaperCollectionLogEN.PaperId = null; //论文Id
if (objvPaperCollectionLogEN.UpdDate == "[null]") objvPaperCollectionLogEN.UpdDate = null; //修改日期
if (objvPaperCollectionLogEN.Meno == "[null]") objvPaperCollectionLogEN.Meno = null; //备注
if (objvPaperCollectionLogEN.PaperTitle == "[null]") objvPaperCollectionLogEN.PaperTitle = null; //论文标题
if (objvPaperCollectionLogEN.Author == "[null]") objvPaperCollectionLogEN.Author = null; //作者
if (objvPaperCollectionLogEN.Keyword == "[null]") objvPaperCollectionLogEN.Keyword = null; //关键字
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
public static void CheckProperty4Condition(clsvPaperCollectionLogEN objvPaperCollectionLogEN)
{
 vPaperCollectionLogDA.CheckProperty4Condition(objvPaperCollectionLogEN);
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
if (clsPaperCollectionLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperCollectionLogBL没有刷新缓存机制(clsPaperCollectionLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperCollectionLogId");
//if (arrvPaperCollectionLogObjLstCache == null)
//{
//arrvPaperCollectionLogObjLstCache = vPaperCollectionLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperCollectionLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperCollectionLogEN GetObjByPaperCollectionLogIdCache(long lngPaperCollectionLogId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperCollectionLogEN._CurrTabName);
List<clsvPaperCollectionLogEN> arrvPaperCollectionLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCollectionLogEN> arrvPaperCollectionLogObjLst_Sel =
arrvPaperCollectionLogObjLstCache
.Where(x=> x.PaperCollectionLogId == lngPaperCollectionLogId 
);
if (arrvPaperCollectionLogObjLst_Sel.Count() == 0)
{
   clsvPaperCollectionLogEN obj = clsvPaperCollectionLogBL.GetObjByPaperCollectionLogId(lngPaperCollectionLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperCollectionLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperCollectionLogEN> GetAllvPaperCollectionLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperCollectionLogEN> arrvPaperCollectionLogObjLstCache = GetObjLstCache(); 
return arrvPaperCollectionLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperCollectionLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperCollectionLogEN._CurrTabName);
List<clsvPaperCollectionLogEN> arrvPaperCollectionLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperCollectionLogObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperCollectionLogEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperCollectionLogId)
{
if (strInFldName != convPaperCollectionLog.PaperCollectionLogId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperCollectionLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperCollectionLog.AttributeName));
throw new Exception(strMsg);
}
var objvPaperCollectionLog = clsvPaperCollectionLogBL.GetObjByPaperCollectionLogIdCache(lngPaperCollectionLogId);
if (objvPaperCollectionLog == null) return "";
return objvPaperCollectionLog[strOutFldName].ToString();
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
int intRecCount = clsvPaperCollectionLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperCollectionLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperCollectionLogDA.GetRecCount();
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
int intRecCount = clsvPaperCollectionLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperCollectionLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperCollectionLogEN objvPaperCollectionLogCond)
{
List<clsvPaperCollectionLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCollectionLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperCollectionLog.AttributeName)
{
if (objvPaperCollectionLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperCollectionLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCollectionLogCond[strFldName].ToString());
}
else
{
if (objvPaperCollectionLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCollectionLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCollectionLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCollectionLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCollectionLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCollectionLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCollectionLogCond[strFldName]));
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
 List<string> arrList = clsvPaperCollectionLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperCollectionLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperCollectionLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}