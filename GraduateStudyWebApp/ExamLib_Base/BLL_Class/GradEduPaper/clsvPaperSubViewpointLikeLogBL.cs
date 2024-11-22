
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointLikeLogBL
 表名:vPaperSubViewpointLikeLog(01120563)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvPaperSubViewpointLikeLogBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetObj(this K_PaperSubViewpointLikeLogId_vPaperSubViewpointLikeLog myKey)
{
clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = clsvPaperSubViewpointLikeLogBL.vPaperSubViewpointLikeLogDA.GetObjByPaperSubViewpointLikeLogId(myKey.Value);
return objvPaperSubViewpointLikeLogEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetPaperSubViewpointLikeLogId(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, long lngPaperSubViewpointLikeLogId, string strComparisonOp="")
	{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = lngPaperSubViewpointLikeLogId; //点赞Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetSubViewpointId(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, long lngSubViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngSubViewpointId, convPaperSubViewpointLikeLog.SubViewpointId);
objvPaperSubViewpointLikeLogEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.SubViewpointId) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.SubViewpointId, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.SubViewpointId] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetUpdDate(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSubViewpointLikeLog.UpdDate);
}
objvPaperSubViewpointLikeLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.UpdDate) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.UpdDate, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdDate] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetMemo(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperSubViewpointLikeLog.Memo);
}
objvPaperSubViewpointLikeLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.Memo) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.Memo, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.Memo] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetRWTitle(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strRWTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRWTitle, 50, convPaperSubViewpointLikeLog.RWTitle);
}
objvPaperSubViewpointLikeLogEN.RWTitle = strRWTitle; //读写标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.RWTitle) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.RWTitle, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.RWTitle] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetSubViewpointContent(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strSubViewpointContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointContent, 500, convPaperSubViewpointLikeLog.SubViewpointContent);
}
objvPaperSubViewpointLikeLogEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.SubViewpointContent) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.SubViewpointContent, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.SubViewpointContent] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetExplainContent(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strExplainContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, convPaperSubViewpointLikeLog.ExplainContent);
}
objvPaperSubViewpointLikeLogEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.ExplainContent) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.ExplainContent, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.ExplainContent] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetPaperRWId(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, convPaperSubViewpointLikeLog.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, convPaperSubViewpointLikeLog.PaperRWId);
}
objvPaperSubViewpointLikeLogEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.PaperRWId) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.PaperRWId, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperRWId] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointLikeLogEN SetUpdUser(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperSubViewpointLikeLog.UpdUser);
}
objvPaperSubViewpointLikeLogEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointLikeLog.UpdUser) == false)
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp.Add(convPaperSubViewpointLikeLog.UpdUser, strComparisonOp);
}
else
{
objvPaperSubViewpointLikeLogEN.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdUser] = strComparisonOp;
}
}
return objvPaperSubViewpointLikeLogEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogENS">源对象</param>
 /// <param name = "objvPaperSubViewpointLikeLogENT">目标对象</param>
 public static void CopyTo(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENS, clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENT)
{
try
{
objvPaperSubViewpointLikeLogENT.PaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogENS.PaperSubViewpointLikeLogId; //点赞Id
objvPaperSubViewpointLikeLogENT.SubViewpointId = objvPaperSubViewpointLikeLogENS.SubViewpointId; //子观点Id
objvPaperSubViewpointLikeLogENT.UpdDate = objvPaperSubViewpointLikeLogENS.UpdDate; //修改日期
objvPaperSubViewpointLikeLogENT.Memo = objvPaperSubViewpointLikeLogENS.Memo; //备注
objvPaperSubViewpointLikeLogENT.RWTitle = objvPaperSubViewpointLikeLogENS.RWTitle; //读写标题
objvPaperSubViewpointLikeLogENT.SubViewpointContent = objvPaperSubViewpointLikeLogENS.SubViewpointContent; //详情内容
objvPaperSubViewpointLikeLogENT.ExplainContent = objvPaperSubViewpointLikeLogENS.ExplainContent; //说明内容
objvPaperSubViewpointLikeLogENT.PaperRWId = objvPaperSubViewpointLikeLogENS.PaperRWId; //课文阅读
objvPaperSubViewpointLikeLogENT.UpdUser = objvPaperSubViewpointLikeLogENS.UpdUser; //修改人
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
 /// <param name = "objvPaperSubViewpointLikeLogENS">源对象</param>
 /// <returns>目标对象=>clsvPaperSubViewpointLikeLogEN:objvPaperSubViewpointLikeLogENT</returns>
 public static clsvPaperSubViewpointLikeLogEN CopyTo(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENS)
{
try
{
 clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENT = new clsvPaperSubViewpointLikeLogEN()
{
PaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogENS.PaperSubViewpointLikeLogId, //点赞Id
SubViewpointId = objvPaperSubViewpointLikeLogENS.SubViewpointId, //子观点Id
UpdDate = objvPaperSubViewpointLikeLogENS.UpdDate, //修改日期
Memo = objvPaperSubViewpointLikeLogENS.Memo, //备注
RWTitle = objvPaperSubViewpointLikeLogENS.RWTitle, //读写标题
SubViewpointContent = objvPaperSubViewpointLikeLogENS.SubViewpointContent, //详情内容
ExplainContent = objvPaperSubViewpointLikeLogENS.ExplainContent, //说明内容
PaperRWId = objvPaperSubViewpointLikeLogENS.PaperRWId, //课文阅读
UpdUser = objvPaperSubViewpointLikeLogENS.UpdUser, //修改人
};
 return objvPaperSubViewpointLikeLogENT;
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
public static void CheckProperty4Condition(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN)
{
 clsvPaperSubViewpointLikeLogBL.vPaperSubViewpointLikeLogDA.CheckProperty4Condition(objvPaperSubViewpointLikeLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId) == true)
{
string strComparisonOpPaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, objvPaperSubViewpointLikeLogCond.PaperSubViewpointLikeLogId, strComparisonOpPaperSubViewpointLikeLogId);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointLikeLog.SubViewpointId, objvPaperSubViewpointLikeLogCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.UpdDate, objvPaperSubViewpointLikeLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.Memo) == true)
{
string strComparisonOpMemo = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.Memo, objvPaperSubViewpointLikeLogCond.Memo, strComparisonOpMemo);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.RWTitle) == true)
{
string strComparisonOpRWTitle = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.RWTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.RWTitle, objvPaperSubViewpointLikeLogCond.RWTitle, strComparisonOpRWTitle);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.SubViewpointContent) == true)
{
string strComparisonOpSubViewpointContent = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.SubViewpointContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.SubViewpointContent, objvPaperSubViewpointLikeLogCond.SubViewpointContent, strComparisonOpSubViewpointContent);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.ExplainContent) == true)
{
string strComparisonOpExplainContent = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.ExplainContent, objvPaperSubViewpointLikeLogCond.ExplainContent, strComparisonOpExplainContent);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.PaperRWId, objvPaperSubViewpointLikeLogCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objvPaperSubViewpointLikeLogCond.IsUpdated(convPaperSubViewpointLikeLog.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[convPaperSubViewpointLikeLog.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointLikeLog.UpdUser, objvPaperSubViewpointLikeLogCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperSubViewpointLikeLog
{
public virtual bool UpdRelaTabDate(long lngPaperSubViewpointLikeLogId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v子观点点赞表(vPaperSubViewpointLikeLog)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSubViewpointLikeLogBL
{
public static RelatedActions_vPaperSubViewpointLikeLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperSubViewpointLikeLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperSubViewpointLikeLogDA vPaperSubViewpointLikeLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperSubViewpointLikeLogDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperSubViewpointLikeLogBL()
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
if (string.IsNullOrEmpty(clsvPaperSubViewpointLikeLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSubViewpointLikeLogEN._ConnectString);
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
public static DataTable GetDataTable_vPaperSubViewpointLikeLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperSubViewpointLikeLogDA.GetDataTable_vPaperSubViewpointLikeLog(strWhereCond);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTable(strWhereCond);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperSubViewpointLikeLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperSubViewpointLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPaperSubViewpointLikeLogIdLst(List<long> arrPaperSubViewpointLikeLogIdLst)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperSubViewpointLikeLogIdLst);
 string strWhereCond = string.Format("PaperSubViewpointLikeLogId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperSubViewpointLikeLogIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperSubViewpointLikeLogEN> GetObjLstByPaperSubViewpointLikeLogIdLstCache(List<long> arrPaperSubViewpointLikeLogIdLst)
{
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName);
List<clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLst_Sel =
arrvPaperSubViewpointLikeLogObjLstCache
.Where(x => arrPaperSubViewpointLikeLogIdLst.Contains(x.PaperSubViewpointLikeLogId));
return arrvPaperSubViewpointLikeLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLst(string strWhereCond)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperSubViewpointLikeLogEN> GetSubObjLstCache(clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogCond)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubViewpointLikeLog.AttributeName)
{
if (objvPaperSubViewpointLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubViewpointLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointLikeLogCond[strFldName].ToString());
}
else
{
if (objvPaperSubViewpointLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubViewpointLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointLikeLogCond[strFldName]));
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
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
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperSubViewpointLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
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
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
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
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLst = new List<clsvPaperSubViewpointLikeLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = new clsvPaperSubViewpointLikeLogEN();
try
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId].ToString().Trim()); //点赞Id
objvPaperSubViewpointLikeLogEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointLikeLog.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointLikeLogEN.UpdDate = objRow[convPaperSubViewpointLikeLog.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointLikeLogEN.Memo = objRow[convPaperSubViewpointLikeLog.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.Memo].ToString().Trim(); //备注
objvPaperSubViewpointLikeLogEN.RWTitle = objRow[convPaperSubViewpointLikeLog.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objRow[convPaperSubViewpointLikeLog.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointLikeLogEN.ExplainContent = objRow[convPaperSubViewpointLikeLog.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointLikeLogEN.PaperRWId = objRow[convPaperSubViewpointLikeLog.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointLikeLogEN.UpdUser = objRow[convPaperSubViewpointLikeLog.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointLikeLog.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointLikeLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperSubViewpointLikeLog(ref clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN)
{
bool bolResult = vPaperSubViewpointLikeLogDA.GetvPaperSubViewpointLikeLog(ref objvPaperSubViewpointLikeLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetObjByPaperSubViewpointLikeLogId(long lngPaperSubViewpointLikeLogId)
{
clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = vPaperSubViewpointLikeLogDA.GetObjByPaperSubViewpointLikeLogId(lngPaperSubViewpointLikeLogId);
return objvPaperSubViewpointLikeLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = vPaperSubViewpointLikeLogDA.GetFirstObj(strWhereCond);
 return objvPaperSubViewpointLikeLogEN;
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
public static clsvPaperSubViewpointLikeLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = vPaperSubViewpointLikeLogDA.GetObjByDataRow(objRow);
 return objvPaperSubViewpointLikeLogEN;
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
public static clsvPaperSubViewpointLikeLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN = vPaperSubViewpointLikeLogDA.GetObjByDataRow(objRow);
 return objvPaperSubViewpointLikeLogEN;
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
 /// <param name = "lngPaperSubViewpointLikeLogId">所给的关键字</param>
 /// <param name = "lstvPaperSubViewpointLikeLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetObjByPaperSubViewpointLikeLogIdFromList(long lngPaperSubViewpointLikeLogId, List<clsvPaperSubViewpointLikeLogEN> lstvPaperSubViewpointLikeLogObjLst)
{
foreach (clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN in lstvPaperSubViewpointLikeLogObjLst)
{
if (objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId)
{
return objvPaperSubViewpointLikeLogEN;
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
 long lngPaperSubViewpointLikeLogId;
 try
 {
 lngPaperSubViewpointLikeLogId = new clsvPaperSubViewpointLikeLogDA().GetFirstID(strWhereCond);
 return lngPaperSubViewpointLikeLogId;
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
 arrList = vPaperSubViewpointLikeLogDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperSubViewpointLikeLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperSubViewpointLikeLogId)
{
//检测记录是否存在
bool bolIsExist = vPaperSubViewpointLikeLogDA.IsExist(lngPaperSubViewpointLikeLogId);
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
 bolIsExist = clsvPaperSubViewpointLikeLogDA.IsExistTable();
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
 bolIsExist = vPaperSubViewpointLikeLogDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperSubViewpointLikeLogENS">源对象</param>
 /// <param name = "objvPaperSubViewpointLikeLogENT">目标对象</param>
 public static void CopyTo(clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENS, clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogENT)
{
try
{
objvPaperSubViewpointLikeLogENT.PaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogENS.PaperSubViewpointLikeLogId; //点赞Id
objvPaperSubViewpointLikeLogENT.SubViewpointId = objvPaperSubViewpointLikeLogENS.SubViewpointId; //子观点Id
objvPaperSubViewpointLikeLogENT.UpdDate = objvPaperSubViewpointLikeLogENS.UpdDate; //修改日期
objvPaperSubViewpointLikeLogENT.Memo = objvPaperSubViewpointLikeLogENS.Memo; //备注
objvPaperSubViewpointLikeLogENT.RWTitle = objvPaperSubViewpointLikeLogENS.RWTitle; //读写标题
objvPaperSubViewpointLikeLogENT.SubViewpointContent = objvPaperSubViewpointLikeLogENS.SubViewpointContent; //详情内容
objvPaperSubViewpointLikeLogENT.ExplainContent = objvPaperSubViewpointLikeLogENS.ExplainContent; //说明内容
objvPaperSubViewpointLikeLogENT.PaperRWId = objvPaperSubViewpointLikeLogENS.PaperRWId; //课文阅读
objvPaperSubViewpointLikeLogENT.UpdUser = objvPaperSubViewpointLikeLogENS.UpdUser; //修改人
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
 /// <param name = "objvPaperSubViewpointLikeLogEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN)
{
try
{
objvPaperSubViewpointLikeLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperSubViewpointLikeLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId = objvPaperSubViewpointLikeLogEN.PaperSubViewpointLikeLogId; //点赞Id
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.SubViewpointId = objvPaperSubViewpointLikeLogEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.UpdDate = objvPaperSubViewpointLikeLogEN.UpdDate == "[null]" ? null :  objvPaperSubViewpointLikeLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.Memo = objvPaperSubViewpointLikeLogEN.Memo == "[null]" ? null :  objvPaperSubViewpointLikeLogEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.RWTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.RWTitle = objvPaperSubViewpointLikeLogEN.RWTitle == "[null]" ? null :  objvPaperSubViewpointLikeLogEN.RWTitle; //读写标题
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.SubViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.SubViewpointContent = objvPaperSubViewpointLikeLogEN.SubViewpointContent == "[null]" ? null :  objvPaperSubViewpointLikeLogEN.SubViewpointContent; //详情内容
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.ExplainContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.ExplainContent = objvPaperSubViewpointLikeLogEN.ExplainContent == "[null]" ? null :  objvPaperSubViewpointLikeLogEN.ExplainContent; //说明内容
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.PaperRWId = objvPaperSubViewpointLikeLogEN.PaperRWId == "[null]" ? null :  objvPaperSubViewpointLikeLogEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(convPaperSubViewpointLikeLog.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointLikeLogEN.UpdUser = objvPaperSubViewpointLikeLogEN.UpdUser == "[null]" ? null :  objvPaperSubViewpointLikeLogEN.UpdUser; //修改人
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
 /// <param name = "objvPaperSubViewpointLikeLogEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN)
{
try
{
if (objvPaperSubViewpointLikeLogEN.UpdDate == "[null]") objvPaperSubViewpointLikeLogEN.UpdDate = null; //修改日期
if (objvPaperSubViewpointLikeLogEN.Memo == "[null]") objvPaperSubViewpointLikeLogEN.Memo = null; //备注
if (objvPaperSubViewpointLikeLogEN.RWTitle == "[null]") objvPaperSubViewpointLikeLogEN.RWTitle = null; //读写标题
if (objvPaperSubViewpointLikeLogEN.SubViewpointContent == "[null]") objvPaperSubViewpointLikeLogEN.SubViewpointContent = null; //详情内容
if (objvPaperSubViewpointLikeLogEN.ExplainContent == "[null]") objvPaperSubViewpointLikeLogEN.ExplainContent = null; //说明内容
if (objvPaperSubViewpointLikeLogEN.PaperRWId == "[null]") objvPaperSubViewpointLikeLogEN.PaperRWId = null; //课文阅读
if (objvPaperSubViewpointLikeLogEN.UpdUser == "[null]") objvPaperSubViewpointLikeLogEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogEN)
{
 vPaperSubViewpointLikeLogDA.CheckProperty4Condition(objvPaperSubViewpointLikeLogEN);
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
if (clsPaperSubViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointBL没有刷新缓存机制(clsPaperSubViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperSubViewpointLikeLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointLikeLogBL没有刷新缓存机制(clsPaperSubViewpointLikeLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubViewpointLikeLogId");
//if (arrvPaperSubViewpointLikeLogObjLstCache == null)
//{
//arrvPaperSubViewpointLikeLogObjLstCache = vPaperSubViewpointLikeLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubViewpointLikeLogId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointLikeLogEN GetObjByPaperSubViewpointLikeLogIdCache(long lngPaperSubViewpointLikeLogId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName);
List<clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLst_Sel =
arrvPaperSubViewpointLikeLogObjLstCache
.Where(x=> x.PaperSubViewpointLikeLogId == lngPaperSubViewpointLikeLogId 
);
if (arrvPaperSubViewpointLikeLogObjLst_Sel.Count() == 0)
{
   clsvPaperSubViewpointLikeLogEN obj = clsvPaperSubViewpointLikeLogBL.GetObjByPaperSubViewpointLikeLogId(lngPaperSubViewpointLikeLogId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperSubViewpointLikeLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetAllvPaperSubViewpointLikeLogObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLstCache = GetObjLstCache(); 
return arrvPaperSubViewpointLikeLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubViewpointLikeLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName);
List<clsvPaperSubViewpointLikeLogEN> arrvPaperSubViewpointLikeLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperSubViewpointLikeLogObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperSubViewpointLikeLogEN._CurrTabName);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngPaperSubViewpointLikeLogId)
{
if (strInFldName != convPaperSubViewpointLikeLog.PaperSubViewpointLikeLogId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperSubViewpointLikeLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperSubViewpointLikeLog.AttributeName));
throw new Exception(strMsg);
}
var objvPaperSubViewpointLikeLog = clsvPaperSubViewpointLikeLogBL.GetObjByPaperSubViewpointLikeLogIdCache(lngPaperSubViewpointLikeLogId);
if (objvPaperSubViewpointLikeLog == null) return "";
return objvPaperSubViewpointLikeLog[strOutFldName].ToString();
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
int intRecCount = clsvPaperSubViewpointLikeLogDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperSubViewpointLikeLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperSubViewpointLikeLogDA.GetRecCount();
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
int intRecCount = clsvPaperSubViewpointLikeLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperSubViewpointLikeLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperSubViewpointLikeLogEN objvPaperSubViewpointLikeLogCond)
{
List<clsvPaperSubViewpointLikeLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointLikeLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubViewpointLikeLog.AttributeName)
{
if (objvPaperSubViewpointLikeLogCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubViewpointLikeLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointLikeLogCond[strFldName].ToString());
}
else
{
if (objvPaperSubViewpointLikeLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubViewpointLikeLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointLikeLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubViewpointLikeLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubViewpointLikeLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointLikeLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointLikeLogCond[strFldName]));
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
 List<string> arrList = clsvPaperSubViewpointLikeLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubViewpointLikeLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubViewpointLikeLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}