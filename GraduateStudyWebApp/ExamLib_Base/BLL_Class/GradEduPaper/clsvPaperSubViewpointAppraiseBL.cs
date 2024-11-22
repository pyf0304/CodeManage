
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointAppraiseBL
 表名:vPaperSubViewpointAppraise(01120562)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:31
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
public static class  clsvPaperSubViewpointAppraiseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetObj(this K_PaperSubViewpointAppraiseId_vPaperSubViewpointAppraise myKey)
{
clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = clsvPaperSubViewpointAppraiseBL.vPaperSubViewpointAppraiseDA.GetObjByPaperSubViewpointAppraiseId(myKey.Value);
return objvPaperSubViewpointAppraiseEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetPaperSubViewpointAppraiseId(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, long lngPaperSubViewpointAppraiseId, string strComparisonOp="")
	{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = lngPaperSubViewpointAppraiseId; //子观点评价Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetSubViewpointId(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, long lngSubViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngSubViewpointId, convPaperSubViewpointAppraise.SubViewpointId);
objvPaperSubViewpointAppraiseEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.SubViewpointId) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.SubViewpointId, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.SubViewpointId] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetAppraiseScore(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, float? fltAppraiseScore, string strComparisonOp="")
	{
objvPaperSubViewpointAppraiseEN.AppraiseScore = fltAppraiseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.AppraiseScore) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.AppraiseScore, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseScore] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetAppraiseContent(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convPaperSubViewpointAppraise.AppraiseContent);
}
objvPaperSubViewpointAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.AppraiseContent) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetUpdDate(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSubViewpointAppraise.UpdDate);
}
objvPaperSubViewpointAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.UpdDate) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.UpdDate, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdDate] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetMeno(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strMeno, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeno, 2000, convPaperSubViewpointAppraise.Meno);
}
objvPaperSubViewpointAppraiseEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.Meno) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.Meno, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.Meno] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetRWTitle(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strRWTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRWTitle, 50, convPaperSubViewpointAppraise.RWTitle);
}
objvPaperSubViewpointAppraiseEN.RWTitle = strRWTitle; //读写标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.RWTitle) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.RWTitle, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.RWTitle] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetSubViewpointContent(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strSubViewpointContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointContent, 500, convPaperSubViewpointAppraise.SubViewpointContent);
}
objvPaperSubViewpointAppraiseEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.SubViewpointContent) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.SubViewpointContent, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.SubViewpointContent] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetExplainContent(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strExplainContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, convPaperSubViewpointAppraise.ExplainContent);
}
objvPaperSubViewpointAppraiseEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.ExplainContent) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.ExplainContent, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.ExplainContent] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetPaperRWId(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, convPaperSubViewpointAppraise.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, convPaperSubViewpointAppraise.PaperRWId);
}
objvPaperSubViewpointAppraiseEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.PaperRWId) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.PaperRWId, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperRWId] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetUpdUser(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperSubViewpointAppraise.UpdUser);
}
objvPaperSubViewpointAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.UpdUser) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.UpdUser, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdUser] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseENS">源对象</param>
 /// <param name = "objvPaperSubViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENS, clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENT)
{
try
{
objvPaperSubViewpointAppraiseENT.PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId; //子观点评价Id
objvPaperSubViewpointAppraiseENT.SubViewpointId = objvPaperSubViewpointAppraiseENS.SubViewpointId; //子观点Id
objvPaperSubViewpointAppraiseENT.AppraiseScore = objvPaperSubViewpointAppraiseENS.AppraiseScore; //打分
objvPaperSubViewpointAppraiseENT.AppraiseContent = objvPaperSubViewpointAppraiseENS.AppraiseContent; //评议内容
objvPaperSubViewpointAppraiseENT.UpdDate = objvPaperSubViewpointAppraiseENS.UpdDate; //修改日期
objvPaperSubViewpointAppraiseENT.Meno = objvPaperSubViewpointAppraiseENS.Meno; //备注
objvPaperSubViewpointAppraiseENT.RWTitle = objvPaperSubViewpointAppraiseENS.RWTitle; //读写标题
objvPaperSubViewpointAppraiseENT.SubViewpointContent = objvPaperSubViewpointAppraiseENS.SubViewpointContent; //详情内容
objvPaperSubViewpointAppraiseENT.ExplainContent = objvPaperSubViewpointAppraiseENS.ExplainContent; //说明内容
objvPaperSubViewpointAppraiseENT.PaperRWId = objvPaperSubViewpointAppraiseENS.PaperRWId; //课文阅读
objvPaperSubViewpointAppraiseENT.UpdUser = objvPaperSubViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objvPaperSubViewpointAppraiseENS">源对象</param>
 /// <returns>目标对象=>clsvPaperSubViewpointAppraiseEN:objvPaperSubViewpointAppraiseENT</returns>
 public static clsvPaperSubViewpointAppraiseEN CopyTo(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENS)
{
try
{
 clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENT = new clsvPaperSubViewpointAppraiseEN()
{
PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId, //子观点评价Id
SubViewpointId = objvPaperSubViewpointAppraiseENS.SubViewpointId, //子观点Id
AppraiseScore = objvPaperSubViewpointAppraiseENS.AppraiseScore, //打分
AppraiseContent = objvPaperSubViewpointAppraiseENS.AppraiseContent, //评议内容
UpdDate = objvPaperSubViewpointAppraiseENS.UpdDate, //修改日期
Meno = objvPaperSubViewpointAppraiseENS.Meno, //备注
RWTitle = objvPaperSubViewpointAppraiseENS.RWTitle, //读写标题
SubViewpointContent = objvPaperSubViewpointAppraiseENS.SubViewpointContent, //详情内容
ExplainContent = objvPaperSubViewpointAppraiseENS.ExplainContent, //说明内容
PaperRWId = objvPaperSubViewpointAppraiseENS.PaperRWId, //课文阅读
UpdUser = objvPaperSubViewpointAppraiseENS.UpdUser, //修改人
};
 return objvPaperSubViewpointAppraiseENT;
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
public static void CheckProperty4Condition(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN)
{
 clsvPaperSubViewpointAppraiseBL.vPaperSubViewpointAppraiseDA.CheckProperty4Condition(objvPaperSubViewpointAppraiseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == true)
{
string strComparisonOpPaperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, objvPaperSubViewpointAppraiseCond.PaperSubViewpointAppraiseId, strComparisonOpPaperSubViewpointAppraiseId);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointAppraise.SubViewpointId, objvPaperSubViewpointAppraiseCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.AppraiseScore) == true)
{
string strComparisonOpAppraiseScore = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointAppraise.AppraiseScore, objvPaperSubViewpointAppraiseCond.AppraiseScore, strComparisonOpAppraiseScore);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.AppraiseContent, objvPaperSubViewpointAppraiseCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.UpdDate, objvPaperSubViewpointAppraiseCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.Meno) == true)
{
string strComparisonOpMeno = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.Meno, objvPaperSubViewpointAppraiseCond.Meno, strComparisonOpMeno);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.RWTitle) == true)
{
string strComparisonOpRWTitle = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.RWTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.RWTitle, objvPaperSubViewpointAppraiseCond.RWTitle, strComparisonOpRWTitle);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.SubViewpointContent) == true)
{
string strComparisonOpSubViewpointContent = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.SubViewpointContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.SubViewpointContent, objvPaperSubViewpointAppraiseCond.SubViewpointContent, strComparisonOpSubViewpointContent);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.ExplainContent) == true)
{
string strComparisonOpExplainContent = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.ExplainContent, objvPaperSubViewpointAppraiseCond.ExplainContent, strComparisonOpExplainContent);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.PaperRWId, objvPaperSubViewpointAppraiseCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objvPaperSubViewpointAppraiseCond.IsUpdated(convPaperSubViewpointAppraise.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.UpdUser, objvPaperSubViewpointAppraiseCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperSubViewpointAppraise
{
public virtual bool UpdRelaTabDate(long lngPaperSubViewpointAppraiseId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v子观点评论表(vPaperSubViewpointAppraise)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSubViewpointAppraiseBL
{
public static RelatedActions_vPaperSubViewpointAppraise relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperSubViewpointAppraiseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperSubViewpointAppraiseDA vPaperSubViewpointAppraiseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperSubViewpointAppraiseDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperSubViewpointAppraiseBL()
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
if (string.IsNullOrEmpty(clsvPaperSubViewpointAppraiseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSubViewpointAppraiseEN._ConnectString);
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
public static DataTable GetDataTable_vPaperSubViewpointAppraise(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperSubViewpointAppraiseDA.GetDataTable_vPaperSubViewpointAppraise(strWhereCond);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTable(strWhereCond);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperSubViewpointAppraiseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPaperSubViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst(List<long> arrPaperSubViewpointAppraiseIdLst)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPaperSubViewpointAppraiseIdLst);
 string strWhereCond = string.Format("PaperSubViewpointAppraiseId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPaperSubViewpointAppraiseIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLstCache(List<long> arrPaperSubViewpointAppraiseIdLst)
{
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName);
List<clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLst_Sel =
arrvPaperSubViewpointAppraiseObjLstCache
.Where(x => arrPaperSubViewpointAppraiseIdLst.Contains(x.PaperSubViewpointAppraiseId));
return arrvPaperSubViewpointAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLst(string strWhereCond)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperSubViewpointAppraiseEN> GetSubObjLstCache(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseCond)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubViewpointAppraise.AttributeName)
{
if (objvPaperSubViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objvPaperSubViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointAppraiseCond[strFldName]));
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
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
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperSubViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
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
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLst = new List<clsvPaperSubViewpointAppraiseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN();
try
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = Int32.Parse(objRow[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId].ToString().Trim()); //子观点评价Id
objvPaperSubViewpointAppraiseEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpointAppraise.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointAppraiseEN.AppraiseScore = objRow[convPaperSubViewpointAppraise.AppraiseScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpointAppraise.AppraiseScore].ToString().Trim()); //打分
objvPaperSubViewpointAppraiseEN.AppraiseContent = objRow[convPaperSubViewpointAppraise.AppraiseContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.AppraiseContent].ToString().Trim(); //评议内容
objvPaperSubViewpointAppraiseEN.UpdDate = objRow[convPaperSubViewpointAppraise.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointAppraiseEN.Meno = objRow[convPaperSubViewpointAppraise.Meno] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.Meno].ToString().Trim(); //备注
objvPaperSubViewpointAppraiseEN.RWTitle = objRow[convPaperSubViewpointAppraise.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objRow[convPaperSubViewpointAppraise.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointAppraiseEN.ExplainContent = objRow[convPaperSubViewpointAppraise.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointAppraiseEN.PaperRWId = objRow[convPaperSubViewpointAppraise.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointAppraiseEN.UpdUser = objRow[convPaperSubViewpointAppraise.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpointAppraise.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointAppraiseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperSubViewpointAppraise(ref clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN)
{
bool bolResult = vPaperSubViewpointAppraiseDA.GetvPaperSubViewpointAppraise(ref objvPaperSubViewpointAppraiseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId(long lngPaperSubViewpointAppraiseId)
{
clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = vPaperSubViewpointAppraiseDA.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
return objvPaperSubViewpointAppraiseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = vPaperSubViewpointAppraiseDA.GetFirstObj(strWhereCond);
 return objvPaperSubViewpointAppraiseEN;
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
public static clsvPaperSubViewpointAppraiseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = vPaperSubViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objvPaperSubViewpointAppraiseEN;
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
public static clsvPaperSubViewpointAppraiseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = vPaperSubViewpointAppraiseDA.GetObjByDataRow(objRow);
 return objvPaperSubViewpointAppraiseEN;
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
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <param name = "lstvPaperSubViewpointAppraiseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseIdFromList(long lngPaperSubViewpointAppraiseId, List<clsvPaperSubViewpointAppraiseEN> lstvPaperSubViewpointAppraiseObjLst)
{
foreach (clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN in lstvPaperSubViewpointAppraiseObjLst)
{
if (objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId)
{
return objvPaperSubViewpointAppraiseEN;
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
 long lngPaperSubViewpointAppraiseId;
 try
 {
 lngPaperSubViewpointAppraiseId = new clsvPaperSubViewpointAppraiseDA().GetFirstID(strWhereCond);
 return lngPaperSubViewpointAppraiseId;
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
 arrList = vPaperSubViewpointAppraiseDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperSubViewpointAppraiseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngPaperSubViewpointAppraiseId)
{
//检测记录是否存在
bool bolIsExist = vPaperSubViewpointAppraiseDA.IsExist(lngPaperSubViewpointAppraiseId);
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
 bolIsExist = clsvPaperSubViewpointAppraiseDA.IsExistTable();
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
 bolIsExist = vPaperSubViewpointAppraiseDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperSubViewpointAppraiseENS">源对象</param>
 /// <param name = "objvPaperSubViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENS, clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENT)
{
try
{
objvPaperSubViewpointAppraiseENT.PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId; //子观点评价Id
objvPaperSubViewpointAppraiseENT.SubViewpointId = objvPaperSubViewpointAppraiseENS.SubViewpointId; //子观点Id
objvPaperSubViewpointAppraiseENT.AppraiseScore = objvPaperSubViewpointAppraiseENS.AppraiseScore; //打分
objvPaperSubViewpointAppraiseENT.AppraiseContent = objvPaperSubViewpointAppraiseENS.AppraiseContent; //评议内容
objvPaperSubViewpointAppraiseENT.UpdDate = objvPaperSubViewpointAppraiseENS.UpdDate; //修改日期
objvPaperSubViewpointAppraiseENT.Meno = objvPaperSubViewpointAppraiseENS.Meno; //备注
objvPaperSubViewpointAppraiseENT.RWTitle = objvPaperSubViewpointAppraiseENS.RWTitle; //读写标题
objvPaperSubViewpointAppraiseENT.SubViewpointContent = objvPaperSubViewpointAppraiseENS.SubViewpointContent; //详情内容
objvPaperSubViewpointAppraiseENT.ExplainContent = objvPaperSubViewpointAppraiseENS.ExplainContent; //说明内容
objvPaperSubViewpointAppraiseENT.PaperRWId = objvPaperSubViewpointAppraiseENS.PaperRWId; //课文阅读
objvPaperSubViewpointAppraiseENT.UpdUser = objvPaperSubViewpointAppraiseENS.UpdUser; //修改人
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
 /// <param name = "objvPaperSubViewpointAppraiseEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN)
{
try
{
objvPaperSubViewpointAppraiseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperSubViewpointAppraiseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId; //子观点评价Id
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.SubViewpointId = objvPaperSubViewpointAppraiseEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.AppraiseScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.AppraiseScore = objvPaperSubViewpointAppraiseEN.AppraiseScore; //打分
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.AppraiseContent = objvPaperSubViewpointAppraiseEN.AppraiseContent == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.UpdDate = objvPaperSubViewpointAppraiseEN.UpdDate == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.Meno, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.Meno = objvPaperSubViewpointAppraiseEN.Meno == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.Meno; //备注
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.RWTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.RWTitle = objvPaperSubViewpointAppraiseEN.RWTitle == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.RWTitle; //读写标题
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.SubViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.SubViewpointContent = objvPaperSubViewpointAppraiseEN.SubViewpointContent == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.SubViewpointContent; //详情内容
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.ExplainContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.ExplainContent = objvPaperSubViewpointAppraiseEN.ExplainContent == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.ExplainContent; //说明内容
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.PaperRWId = objvPaperSubViewpointAppraiseEN.PaperRWId == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(convPaperSubViewpointAppraise.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointAppraiseEN.UpdUser = objvPaperSubViewpointAppraiseEN.UpdUser == "[null]" ? null :  objvPaperSubViewpointAppraiseEN.UpdUser; //修改人
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
 /// <param name = "objvPaperSubViewpointAppraiseEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN)
{
try
{
if (objvPaperSubViewpointAppraiseEN.AppraiseContent == "[null]") objvPaperSubViewpointAppraiseEN.AppraiseContent = null; //评议内容
if (objvPaperSubViewpointAppraiseEN.UpdDate == "[null]") objvPaperSubViewpointAppraiseEN.UpdDate = null; //修改日期
if (objvPaperSubViewpointAppraiseEN.Meno == "[null]") objvPaperSubViewpointAppraiseEN.Meno = null; //备注
if (objvPaperSubViewpointAppraiseEN.RWTitle == "[null]") objvPaperSubViewpointAppraiseEN.RWTitle = null; //读写标题
if (objvPaperSubViewpointAppraiseEN.SubViewpointContent == "[null]") objvPaperSubViewpointAppraiseEN.SubViewpointContent = null; //详情内容
if (objvPaperSubViewpointAppraiseEN.ExplainContent == "[null]") objvPaperSubViewpointAppraiseEN.ExplainContent = null; //说明内容
if (objvPaperSubViewpointAppraiseEN.PaperRWId == "[null]") objvPaperSubViewpointAppraiseEN.PaperRWId = null; //课文阅读
if (objvPaperSubViewpointAppraiseEN.UpdUser == "[null]") objvPaperSubViewpointAppraiseEN.UpdUser = null; //修改人
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
public static void CheckProperty4Condition(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN)
{
 vPaperSubViewpointAppraiseDA.CheckProperty4Condition(objvPaperSubViewpointAppraiseEN);
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
if (clsPaperSubViewpointAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointAppraiseBL没有刷新缓存机制(clsPaperSubViewpointAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubViewpointAppraiseId");
//if (arrvPaperSubViewpointAppraiseObjLstCache == null)
//{
//arrvPaperSubViewpointAppraiseObjLstCache = vPaperSubViewpointAppraiseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseIdCache(long lngPaperSubViewpointAppraiseId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName);
List<clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLst_Sel =
arrvPaperSubViewpointAppraiseObjLstCache
.Where(x=> x.PaperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId 
);
if (arrvPaperSubViewpointAppraiseObjLst_Sel.Count() == 0)
{
   clsvPaperSubViewpointAppraiseEN obj = clsvPaperSubViewpointAppraiseBL.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPaperSubViewpointAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetAllvPaperSubViewpointAppraiseObjLstCache()
{
//获取缓存中的对象列表
List<clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLstCache = GetObjLstCache(); 
return arrvPaperSubViewpointAppraiseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName);
List<clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperSubViewpointAppraiseObjLstCache;
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
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngPaperSubViewpointAppraiseId)
{
if (strInFldName != convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperSubViewpointAppraise.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperSubViewpointAppraise.AttributeName));
throw new Exception(strMsg);
}
var objvPaperSubViewpointAppraise = clsvPaperSubViewpointAppraiseBL.GetObjByPaperSubViewpointAppraiseIdCache(lngPaperSubViewpointAppraiseId);
if (objvPaperSubViewpointAppraise == null) return "";
return objvPaperSubViewpointAppraise[strOutFldName].ToString();
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
int intRecCount = clsvPaperSubViewpointAppraiseDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperSubViewpointAppraiseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperSubViewpointAppraiseDA.GetRecCount();
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
int intRecCount = clsvPaperSubViewpointAppraiseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseCond)
{
List<clsvPaperSubViewpointAppraiseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPaperSubViewpointAppraiseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubViewpointAppraise.AttributeName)
{
if (objvPaperSubViewpointAppraiseCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubViewpointAppraiseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else
{
if (objvPaperSubViewpointAppraiseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubViewpointAppraiseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointAppraiseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubViewpointAppraiseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubViewpointAppraiseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointAppraiseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointAppraiseCond[strFldName]));
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
 List<string> arrList = clsvPaperSubViewpointAppraiseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubViewpointAppraiseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubViewpointAppraiseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}