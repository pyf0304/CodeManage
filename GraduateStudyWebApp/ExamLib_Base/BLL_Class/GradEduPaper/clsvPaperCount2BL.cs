
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperCount2BL
 表名:vPaperCount2(01120596)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:16
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
public static class  clsvPaperCount2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCount2EN GetObj(this K_PaperId_vPaperCount2 myKey)
{
clsvPaperCount2EN objvPaperCount2EN = clsvPaperCount2BL.vPaperCount2DA.GetObjByPaperId(myKey.Value);
return objvPaperCount2EN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetPaperId(this clsvPaperCount2EN objvPaperCount2EN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperCount2.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperCount2.PaperId);
}
objvPaperCount2EN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.PaperId) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.PaperId, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.PaperId] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetPcount(this clsvPaperCount2EN objvPaperCount2EN, int? intPcount, string strComparisonOp="")
	{
objvPaperCount2EN.Pcount = intPcount; //读写数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.Pcount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.Pcount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.Pcount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetOkCount(this clsvPaperCount2EN objvPaperCount2EN, int? intOkCount, string strComparisonOp="")
	{
objvPaperCount2EN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.OkCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.OkCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.OkCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetAppraiseCount(this clsvPaperCount2EN objvPaperCount2EN, int? intAppraiseCount, string strComparisonOp="")
	{
objvPaperCount2EN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.AppraiseCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.AppraiseCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.AppraiseCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetCollectionCount(this clsvPaperCount2EN objvPaperCount2EN, long? lngCollectionCount, string strComparisonOp="")
	{
objvPaperCount2EN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.CollectionCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.CollectionCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.CollectionCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetDownloadCount(this clsvPaperCount2EN objvPaperCount2EN, int? intDownloadCount, string strComparisonOp="")
	{
objvPaperCount2EN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.DownloadCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.DownloadCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.DownloadCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetScore(this clsvPaperCount2EN objvPaperCount2EN, float? fltScore, string strComparisonOp="")
	{
objvPaperCount2EN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.Score) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.Score, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.Score] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetAttachmentCount(this clsvPaperCount2EN objvPaperCount2EN, int? intAttachmentCount, string strComparisonOp="")
	{
objvPaperCount2EN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.AttachmentCount) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.AttachmentCount, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.AttachmentCount] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperCount2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperCount2EN SetUpdUser(this clsvPaperCount2EN objvPaperCount2EN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperCount2.UpdUser);
}
objvPaperCount2EN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperCount2EN.dicFldComparisonOp.ContainsKey(convPaperCount2.UpdUser) == false)
{
objvPaperCount2EN.dicFldComparisonOp.Add(convPaperCount2.UpdUser, strComparisonOp);
}
else
{
objvPaperCount2EN.dicFldComparisonOp[convPaperCount2.UpdUser] = strComparisonOp;
}
}
return objvPaperCount2EN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperCount2ENS">源对象</param>
 /// <param name = "objvPaperCount2ENT">目标对象</param>
 public static void CopyTo(this clsvPaperCount2EN objvPaperCount2ENS, clsvPaperCount2EN objvPaperCount2ENT)
{
try
{
objvPaperCount2ENT.PaperId = objvPaperCount2ENS.PaperId; //论文Id
objvPaperCount2ENT.Pcount = objvPaperCount2ENS.Pcount; //读写数
objvPaperCount2ENT.OkCount = objvPaperCount2ENS.OkCount; //点赞统计
objvPaperCount2ENT.AppraiseCount = objvPaperCount2ENS.AppraiseCount; //评论数
objvPaperCount2ENT.CollectionCount = objvPaperCount2ENS.CollectionCount; //收藏数量
objvPaperCount2ENT.DownloadCount = objvPaperCount2ENS.DownloadCount; //下载数
objvPaperCount2ENT.Score = objvPaperCount2ENS.Score; //评分
objvPaperCount2ENT.AttachmentCount = objvPaperCount2ENS.AttachmentCount; //附件计数
objvPaperCount2ENT.UpdUser = objvPaperCount2ENS.UpdUser; //修改人
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
 /// <param name = "objvPaperCount2ENS">源对象</param>
 /// <returns>目标对象=>clsvPaperCount2EN:objvPaperCount2ENT</returns>
 public static clsvPaperCount2EN CopyTo(this clsvPaperCount2EN objvPaperCount2ENS)
{
try
{
 clsvPaperCount2EN objvPaperCount2ENT = new clsvPaperCount2EN()
{
PaperId = objvPaperCount2ENS.PaperId, //论文Id
Pcount = objvPaperCount2ENS.Pcount, //读写数
OkCount = objvPaperCount2ENS.OkCount, //点赞统计
AppraiseCount = objvPaperCount2ENS.AppraiseCount, //评论数
CollectionCount = objvPaperCount2ENS.CollectionCount, //收藏数量
DownloadCount = objvPaperCount2ENS.DownloadCount, //下载数
Score = objvPaperCount2ENS.Score, //评分
AttachmentCount = objvPaperCount2ENS.AttachmentCount, //附件计数
UpdUser = objvPaperCount2ENS.UpdUser, //修改人
};
 return objvPaperCount2ENT;
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
public static void CheckProperty4Condition(this clsvPaperCount2EN objvPaperCount2EN)
{
 clsvPaperCount2BL.vPaperCount2DA.CheckProperty4Condition(objvPaperCount2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperCount2EN objvPaperCount2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount2.PaperId, objvPaperCount2Cond.PaperId, strComparisonOpPaperId);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.Pcount) == true)
{
string strComparisonOpPcount = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.Pcount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.Pcount, objvPaperCount2Cond.Pcount, strComparisonOpPcount);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.OkCount) == true)
{
string strComparisonOpOkCount = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.OkCount, objvPaperCount2Cond.OkCount, strComparisonOpOkCount);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.AppraiseCount, objvPaperCount2Cond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.CollectionCount, objvPaperCount2Cond.CollectionCount, strComparisonOpCollectionCount);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.DownloadCount, objvPaperCount2Cond.DownloadCount, strComparisonOpDownloadCount);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.Score) == true)
{
string strComparisonOpScore = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.Score, objvPaperCount2Cond.Score, strComparisonOpScore);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperCount2.AttachmentCount, objvPaperCount2Cond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objvPaperCount2Cond.IsUpdated(convPaperCount2.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperCount2Cond.dicFldComparisonOp[convPaperCount2.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperCount2.UpdUser, objvPaperCount2Cond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperCount2
{
public virtual bool UpdRelaTabDate(string strPaperId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPaperCount2(vPaperCount2)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperCount2BL
{
public static RelatedActions_vPaperCount2 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperCount2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperCount2DA vPaperCount2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperCount2DA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperCount2BL()
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
if (string.IsNullOrEmpty(clsvPaperCount2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperCount2EN._ConnectString);
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
public static DataTable GetDataTable_vPaperCount2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperCount2DA.GetDataTable_vPaperCount2(strWhereCond);
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
objDT = vPaperCount2DA.GetDataTable(strWhereCond);
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
objDT = vPaperCount2DA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperCount2DA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperCount2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperCount2DA.GetDataTable_Top(objTopPara);
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
objDT = vPaperCount2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperCount2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperCount2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPaperCount2EN> GetObjLstByPaperIdLst(List<string> arrPaperIdLst)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
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
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperCount2EN> GetObjLstByPaperIdLstCache(List<string> arrPaperIdLst)
{
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName);
List<clsvPaperCount2EN> arrvPaperCount2ObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCount2EN> arrvPaperCount2ObjLst_Sel =
arrvPaperCount2ObjLstCache
.Where(x => arrPaperIdLst.Contains(x.PaperId));
return arrvPaperCount2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCount2EN> GetObjLst(string strWhereCond)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
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
public static List<clsvPaperCount2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperCount2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperCount2EN> GetSubObjLstCache(clsvPaperCount2EN objvPaperCount2Cond)
{
List<clsvPaperCount2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCount2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperCount2.AttributeName)
{
if (objvPaperCount2Cond.IsUpdated(strFldName) == false) continue;
if (objvPaperCount2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCount2Cond[strFldName].ToString());
}
else
{
if (objvPaperCount2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCount2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCount2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCount2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCount2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCount2Cond[strFldName]));
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
public static List<clsvPaperCount2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
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
public static List<clsvPaperCount2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
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
List<clsvPaperCount2EN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperCount2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCount2EN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperCount2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
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
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
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
public static List<clsvPaperCount2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperCount2EN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperCount2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
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
public static List<clsvPaperCount2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperCount2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperCount2EN> arrObjLst = new List<clsvPaperCount2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperCount2EN objvPaperCount2EN = new clsvPaperCount2EN();
try
{
objvPaperCount2EN.PaperId = objRow[convPaperCount2.PaperId].ToString().Trim(); //论文Id
objvPaperCount2EN.Pcount = objRow[convPaperCount2.Pcount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.Pcount].ToString().Trim()); //读写数
objvPaperCount2EN.OkCount = objRow[convPaperCount2.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.OkCount].ToString().Trim()); //点赞统计
objvPaperCount2EN.AppraiseCount = objRow[convPaperCount2.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AppraiseCount].ToString().Trim()); //评论数
objvPaperCount2EN.CollectionCount = objRow[convPaperCount2.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.CollectionCount].ToString().Trim()); //收藏数量
objvPaperCount2EN.DownloadCount = objRow[convPaperCount2.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.DownloadCount].ToString().Trim()); //下载数
objvPaperCount2EN.Score = objRow[convPaperCount2.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperCount2.Score].ToString().Trim()); //评分
objvPaperCount2EN.AttachmentCount = objRow[convPaperCount2.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperCount2.AttachmentCount].ToString().Trim()); //附件计数
objvPaperCount2EN.UpdUser = objRow[convPaperCount2.UpdUser] == DBNull.Value ? null : objRow[convPaperCount2.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperCount2EN.PaperId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperCount2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperCount2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperCount2(ref clsvPaperCount2EN objvPaperCount2EN)
{
bool bolResult = vPaperCount2DA.GetvPaperCount2(ref objvPaperCount2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperCount2EN GetObjByPaperId(string strPaperId)
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
clsvPaperCount2EN objvPaperCount2EN = vPaperCount2DA.GetObjByPaperId(strPaperId);
return objvPaperCount2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperCount2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperCount2EN objvPaperCount2EN = vPaperCount2DA.GetFirstObj(strWhereCond);
 return objvPaperCount2EN;
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
public static clsvPaperCount2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperCount2EN objvPaperCount2EN = vPaperCount2DA.GetObjByDataRow(objRow);
 return objvPaperCount2EN;
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
public static clsvPaperCount2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperCount2EN objvPaperCount2EN = vPaperCount2DA.GetObjByDataRow(objRow);
 return objvPaperCount2EN;
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
 /// <param name = "lstvPaperCount2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperCount2EN GetObjByPaperIdFromList(string strPaperId, List<clsvPaperCount2EN> lstvPaperCount2ObjLst)
{
foreach (clsvPaperCount2EN objvPaperCount2EN in lstvPaperCount2ObjLst)
{
if (objvPaperCount2EN.PaperId == strPaperId)
{
return objvPaperCount2EN;
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
 strPaperId = new clsvPaperCount2DA().GetFirstID(strWhereCond);
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
 arrList = vPaperCount2DA.GetID(strWhereCond);
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
bool bolIsExist = vPaperCount2DA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPaperCount2DA.IsExist(strPaperId);
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
 bolIsExist = clsvPaperCount2DA.IsExistTable();
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
 bolIsExist = vPaperCount2DA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperCount2ENS">源对象</param>
 /// <param name = "objvPaperCount2ENT">目标对象</param>
 public static void CopyTo(clsvPaperCount2EN objvPaperCount2ENS, clsvPaperCount2EN objvPaperCount2ENT)
{
try
{
objvPaperCount2ENT.PaperId = objvPaperCount2ENS.PaperId; //论文Id
objvPaperCount2ENT.Pcount = objvPaperCount2ENS.Pcount; //读写数
objvPaperCount2ENT.OkCount = objvPaperCount2ENS.OkCount; //点赞统计
objvPaperCount2ENT.AppraiseCount = objvPaperCount2ENS.AppraiseCount; //评论数
objvPaperCount2ENT.CollectionCount = objvPaperCount2ENS.CollectionCount; //收藏数量
objvPaperCount2ENT.DownloadCount = objvPaperCount2ENS.DownloadCount; //下载数
objvPaperCount2ENT.Score = objvPaperCount2ENS.Score; //评分
objvPaperCount2ENT.AttachmentCount = objvPaperCount2ENS.AttachmentCount; //附件计数
objvPaperCount2ENT.UpdUser = objvPaperCount2ENS.UpdUser; //修改人
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
 /// <param name = "objvPaperCount2EN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperCount2EN objvPaperCount2EN)
{
try
{
objvPaperCount2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperCount2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperCount2.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.PaperId = objvPaperCount2EN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperCount2.Pcount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.Pcount = objvPaperCount2EN.Pcount; //读写数
}
if (arrFldSet.Contains(convPaperCount2.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.OkCount = objvPaperCount2EN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convPaperCount2.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.AppraiseCount = objvPaperCount2EN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convPaperCount2.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.CollectionCount = objvPaperCount2EN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(convPaperCount2.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.DownloadCount = objvPaperCount2EN.DownloadCount; //下载数
}
if (arrFldSet.Contains(convPaperCount2.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.Score = objvPaperCount2EN.Score; //评分
}
if (arrFldSet.Contains(convPaperCount2.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.AttachmentCount = objvPaperCount2EN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(convPaperCount2.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperCount2EN.UpdUser = objvPaperCount2EN.UpdUser == "[null]" ? null :  objvPaperCount2EN.UpdUser; //修改人
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
 /// <param name = "objvPaperCount2EN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperCount2EN objvPaperCount2EN)
{
try
{
if (objvPaperCount2EN.UpdUser == "[null]") objvPaperCount2EN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvPaperCount2EN objvPaperCount2EN)
{
 vPaperCount2DA.CheckProperty4Condition(objvPaperCount2EN);
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperId");
//if (arrvPaperCount2ObjLstCache == null)
//{
//arrvPaperCount2ObjLstCache = vPaperCount2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperCount2EN GetObjByPaperIdCache(string strPaperId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName);
List<clsvPaperCount2EN> arrvPaperCount2ObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCount2EN> arrvPaperCount2ObjLst_Sel =
arrvPaperCount2ObjLstCache
.Where(x=> x.PaperId == strPaperId 
);
if (arrvPaperCount2ObjLst_Sel.Count() == 0)
{
   clsvPaperCount2EN obj = clsvPaperCount2BL.GetObjByPaperId(strPaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperCount2ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperCount2EN> GetAllvPaperCount2ObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperCount2EN> arrvPaperCount2ObjLstCache = GetObjLstCache(); 
return arrvPaperCount2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperCount2EN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName);
List<clsvPaperCount2EN> arrvPaperCount2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperCount2ObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperCount2EN._CurrTabName);
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
if (strInFldName != convPaperCount2.PaperId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperCount2.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperCount2.AttributeName));
throw new Exception(strMsg);
}
var objvPaperCount2 = clsvPaperCount2BL.GetObjByPaperIdCache(strPaperId);
if (objvPaperCount2 == null) return "";
return objvPaperCount2[strOutFldName].ToString();
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
int intRecCount = clsvPaperCount2DA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperCount2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperCount2DA.GetRecCount();
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
int intRecCount = clsvPaperCount2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperCount2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperCount2EN objvPaperCount2Cond)
{
List<clsvPaperCount2EN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperCount2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperCount2.AttributeName)
{
if (objvPaperCount2Cond.IsUpdated(strFldName) == false) continue;
if (objvPaperCount2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCount2Cond[strFldName].ToString());
}
else
{
if (objvPaperCount2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperCount2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperCount2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperCount2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperCount2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperCount2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperCount2Cond[strFldName]));
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
 List<string> arrList = clsvPaperCount2DA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperCount2DA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperCount2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}