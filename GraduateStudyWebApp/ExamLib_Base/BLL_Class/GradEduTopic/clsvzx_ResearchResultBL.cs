
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ResearchResultBL
 表名:vzx_ResearchResult(01120833)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsvzx_ResearchResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ResearchResultEN GetObj(this K_zxResultId_vzx_ResearchResult myKey)
{
clsvzx_ResearchResultEN objvzx_ResearchResultEN = clsvzx_ResearchResultBL.vzx_ResearchResultDA.GetObjByzxResultId(myKey.Value);
return objvzx_ResearchResultEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetzxResultId(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strzxResultId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxResultId, 10, convzx_ResearchResult.zxResultId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxResultId, 10, convzx_ResearchResult.zxResultId);
}
objvzx_ResearchResultEN.zxResultId = strzxResultId; //成果Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.zxResultId) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.zxResultId, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.zxResultId] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetMemo(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_ResearchResult.Memo);
}
objvzx_ResearchResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.Memo) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.Memo, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.Memo] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetUpdUser(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_ResearchResult.UpdUser);
}
objvzx_ResearchResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.UpdUser) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.UpdUser, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.UpdUser] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetUpdDate(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_ResearchResult.UpdDate);
}
objvzx_ResearchResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.UpdDate) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.UpdDate, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.UpdDate] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetStuScore(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_ResearchResultEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.StuScore) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.StuScore, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.StuScore] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetScore(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, float? fltScore, string strComparisonOp="")
	{
objvzx_ResearchResultEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.Score) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.Score, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.Score] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetOkCount(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, int? intOkCount, string strComparisonOp="")
	{
objvzx_ResearchResultEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.OkCount) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.OkCount, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.OkCount] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetVersionCount(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_ResearchResultEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.VersionCount) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.VersionCount, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.VersionCount] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetResultContent(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strResultContent, string strComparisonOp="")
	{
objvzx_ResearchResultEN.ResultContent = strResultContent; //成果内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.ResultContent) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.ResultContent, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.ResultContent] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetTextId(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_ResearchResult.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_ResearchResult.TextId);
}
objvzx_ResearchResultEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.TextId) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.TextId, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.TextId] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetGroupTextId(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_ResearchResult.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_ResearchResult.GroupTextId);
}
objvzx_ResearchResultEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.GroupTextId) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.GroupTextId, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.GroupTextId] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetResultTypeId(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strResultTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultTypeId, 2, convzx_ResearchResult.ResultTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResultTypeId, 2, convzx_ResearchResult.ResultTypeId);
}
objvzx_ResearchResultEN.ResultTypeId = strResultTypeId; //成果类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.ResultTypeId) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.ResultTypeId, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.ResultTypeId] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetResultName(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strResultName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResultName, 500, convzx_ResearchResult.ResultName);
}
objvzx_ResearchResultEN.ResultName = strResultName; //成果名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.ResultName) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.ResultName, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.ResultName] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetAuthor(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, convzx_ResearchResult.Author);
}
objvzx_ResearchResultEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.Author) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.Author, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.Author] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetDivision(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strDivision, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDivision, 500, convzx_ResearchResult.Division);
}
objvzx_ResearchResultEN.Division = strDivision; //分工
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.Division) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.Division, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.Division] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetAppraiseCount(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_ResearchResultEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.AppraiseCount) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.AppraiseCount, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.AppraiseCount] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetTeaScore(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_ResearchResultEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.TeaScore) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.TeaScore, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.TeaScore] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetGroupTextName(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_ResearchResult.GroupTextName);
}
objvzx_ResearchResultEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.GroupTextName) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.GroupTextName, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.GroupTextName] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetIdCurrEduCls(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_ResearchResult.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_ResearchResult.IdCurrEduCls);
}
objvzx_ResearchResultEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.IdCurrEduCls) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchResultEN SetzxShareId(this clsvzx_ResearchResultEN objvzx_ResearchResultEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_ResearchResult.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_ResearchResult.zxShareId);
}
objvzx_ResearchResultEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchResultEN.dicFldComparisonOp.ContainsKey(convzx_ResearchResult.zxShareId) == false)
{
objvzx_ResearchResultEN.dicFldComparisonOp.Add(convzx_ResearchResult.zxShareId, strComparisonOp);
}
else
{
objvzx_ResearchResultEN.dicFldComparisonOp[convzx_ResearchResult.zxShareId] = strComparisonOp;
}
}
return objvzx_ResearchResultEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_ResearchResultENS">源对象</param>
 /// <param name = "objvzx_ResearchResultENT">目标对象</param>
 public static void CopyTo(this clsvzx_ResearchResultEN objvzx_ResearchResultENS, clsvzx_ResearchResultEN objvzx_ResearchResultENT)
{
try
{
objvzx_ResearchResultENT.zxResultId = objvzx_ResearchResultENS.zxResultId; //成果Id
objvzx_ResearchResultENT.Memo = objvzx_ResearchResultENS.Memo; //备注
objvzx_ResearchResultENT.UpdUser = objvzx_ResearchResultENS.UpdUser; //修改人
objvzx_ResearchResultENT.UpdDate = objvzx_ResearchResultENS.UpdDate; //修改日期
objvzx_ResearchResultENT.StuScore = objvzx_ResearchResultENS.StuScore; //学生平均分
objvzx_ResearchResultENT.Score = objvzx_ResearchResultENS.Score; //评分
objvzx_ResearchResultENT.OkCount = objvzx_ResearchResultENS.OkCount; //点赞统计
objvzx_ResearchResultENT.VersionCount = objvzx_ResearchResultENS.VersionCount; //版本统计
objvzx_ResearchResultENT.ResultContent = objvzx_ResearchResultENS.ResultContent; //成果内容
objvzx_ResearchResultENT.TextId = objvzx_ResearchResultENS.TextId; //课件Id
objvzx_ResearchResultENT.GroupTextId = objvzx_ResearchResultENS.GroupTextId; //小组Id
objvzx_ResearchResultENT.ResultTypeId = objvzx_ResearchResultENS.ResultTypeId; //成果类型Id
objvzx_ResearchResultENT.ResultName = objvzx_ResearchResultENS.ResultName; //成果名称
objvzx_ResearchResultENT.Author = objvzx_ResearchResultENS.Author; //作者
objvzx_ResearchResultENT.Division = objvzx_ResearchResultENS.Division; //分工
objvzx_ResearchResultENT.AppraiseCount = objvzx_ResearchResultENS.AppraiseCount; //评论数
objvzx_ResearchResultENT.TeaScore = objvzx_ResearchResultENS.TeaScore; //教师评分
objvzx_ResearchResultENT.GroupTextName = objvzx_ResearchResultENS.GroupTextName; //小组名称
objvzx_ResearchResultENT.IdCurrEduCls = objvzx_ResearchResultENS.IdCurrEduCls; //教学班流水号
objvzx_ResearchResultENT.zxShareId = objvzx_ResearchResultENS.zxShareId; //分享Id
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
 /// <param name = "objvzx_ResearchResultENS">源对象</param>
 /// <returns>目标对象=>clsvzx_ResearchResultEN:objvzx_ResearchResultENT</returns>
 public static clsvzx_ResearchResultEN CopyTo(this clsvzx_ResearchResultEN objvzx_ResearchResultENS)
{
try
{
 clsvzx_ResearchResultEN objvzx_ResearchResultENT = new clsvzx_ResearchResultEN()
{
zxResultId = objvzx_ResearchResultENS.zxResultId, //成果Id
Memo = objvzx_ResearchResultENS.Memo, //备注
UpdUser = objvzx_ResearchResultENS.UpdUser, //修改人
UpdDate = objvzx_ResearchResultENS.UpdDate, //修改日期
StuScore = objvzx_ResearchResultENS.StuScore, //学生平均分
Score = objvzx_ResearchResultENS.Score, //评分
OkCount = objvzx_ResearchResultENS.OkCount, //点赞统计
VersionCount = objvzx_ResearchResultENS.VersionCount, //版本统计
ResultContent = objvzx_ResearchResultENS.ResultContent, //成果内容
TextId = objvzx_ResearchResultENS.TextId, //课件Id
GroupTextId = objvzx_ResearchResultENS.GroupTextId, //小组Id
ResultTypeId = objvzx_ResearchResultENS.ResultTypeId, //成果类型Id
ResultName = objvzx_ResearchResultENS.ResultName, //成果名称
Author = objvzx_ResearchResultENS.Author, //作者
Division = objvzx_ResearchResultENS.Division, //分工
AppraiseCount = objvzx_ResearchResultENS.AppraiseCount, //评论数
TeaScore = objvzx_ResearchResultENS.TeaScore, //教师评分
GroupTextName = objvzx_ResearchResultENS.GroupTextName, //小组名称
IdCurrEduCls = objvzx_ResearchResultENS.IdCurrEduCls, //教学班流水号
zxShareId = objvzx_ResearchResultENS.zxShareId, //分享Id
};
 return objvzx_ResearchResultENT;
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
public static void CheckProperty4Condition(this clsvzx_ResearchResultEN objvzx_ResearchResultEN)
{
 clsvzx_ResearchResultBL.vzx_ResearchResultDA.CheckProperty4Condition(objvzx_ResearchResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_ResearchResultEN objvzx_ResearchResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.zxResultId) == true)
{
string strComparisonOpzxResultId = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.zxResultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.zxResultId, objvzx_ResearchResultCond.zxResultId, strComparisonOpzxResultId);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.Memo) == true)
{
string strComparisonOpMemo = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.Memo, objvzx_ResearchResultCond.Memo, strComparisonOpMemo);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.UpdUser, objvzx_ResearchResultCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.UpdDate, objvzx_ResearchResultCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_ResearchResult.StuScore, objvzx_ResearchResultCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.Score) == true)
{
string strComparisonOpScore = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_ResearchResult.Score, objvzx_ResearchResultCond.Score, strComparisonOpScore);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.OkCount) == true)
{
string strComparisonOpOkCount = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_ResearchResult.OkCount, objvzx_ResearchResultCond.OkCount, strComparisonOpOkCount);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_ResearchResult.VersionCount, objvzx_ResearchResultCond.VersionCount, strComparisonOpVersionCount);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.TextId) == true)
{
string strComparisonOpTextId = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.TextId, objvzx_ResearchResultCond.TextId, strComparisonOpTextId);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.GroupTextId, objvzx_ResearchResultCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.ResultTypeId) == true)
{
string strComparisonOpResultTypeId = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.ResultTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.ResultTypeId, objvzx_ResearchResultCond.ResultTypeId, strComparisonOpResultTypeId);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.ResultName) == true)
{
string strComparisonOpResultName = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.ResultName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.ResultName, objvzx_ResearchResultCond.ResultName, strComparisonOpResultName);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.Author) == true)
{
string strComparisonOpAuthor = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.Author, objvzx_ResearchResultCond.Author, strComparisonOpAuthor);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.Division) == true)
{
string strComparisonOpDivision = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.Division];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.Division, objvzx_ResearchResultCond.Division, strComparisonOpDivision);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_ResearchResult.AppraiseCount, objvzx_ResearchResultCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_ResearchResult.TeaScore, objvzx_ResearchResultCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.GroupTextName, objvzx_ResearchResultCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.IdCurrEduCls, objvzx_ResearchResultCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_ResearchResultCond.IsUpdated(convzx_ResearchResult.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_ResearchResultCond.dicFldComparisonOp[convzx_ResearchResult.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchResult.zxShareId, objvzx_ResearchResultCond.zxShareId, strComparisonOpzxShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_ResearchResult
{
public virtual bool UpdRelaTabDate(string strzxResultId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_ResearchResult(vzx_ResearchResult)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_ResearchResultBL
{
public static RelatedActions_vzx_ResearchResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_ResearchResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_ResearchResultDA vzx_ResearchResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_ResearchResultDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_ResearchResultBL()
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
if (string.IsNullOrEmpty(clsvzx_ResearchResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_ResearchResultEN._ConnectString);
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
public static DataTable GetDataTable_vzx_ResearchResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_ResearchResultDA.GetDataTable_vzx_ResearchResult(strWhereCond);
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
objDT = vzx_ResearchResultDA.GetDataTable(strWhereCond);
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
objDT = vzx_ResearchResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_ResearchResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_ResearchResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_ResearchResultDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_ResearchResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_ResearchResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_ResearchResultEN> GetObjLstByZxResultIdLst(List<string> arrZxResultIdLst)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxResultIdLst, true);
 string strWhereCond = string.Format("zxResultId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxResultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_ResearchResultEN> GetObjLstByZxResultIdLstCache(List<string> arrZxResultIdLst)
{
string strKey = string.Format("{0}", clsvzx_ResearchResultEN._CurrTabName);
List<clsvzx_ResearchResultEN> arrvzx_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchResultEN> arrvzx_ResearchResultObjLst_Sel =
arrvzx_ResearchResultObjLstCache
.Where(x => arrZxResultIdLst.Contains(x.zxResultId));
return arrvzx_ResearchResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ResearchResultEN> GetObjLst(string strWhereCond)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
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
public static List<clsvzx_ResearchResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_ResearchResultEN> GetSubObjLstCache(clsvzx_ResearchResultEN objvzx_ResearchResultCond)
{
List<clsvzx_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_ResearchResult.AttributeName)
{
if (objvzx_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchResultCond[strFldName].ToString());
}
else
{
if (objvzx_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchResultCond[strFldName]));
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
public static List<clsvzx_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
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
public static List<clsvzx_ResearchResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
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
List<clsvzx_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_ResearchResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ResearchResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
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
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
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
public static List<clsvzx_ResearchResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_ResearchResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
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
public static List<clsvzx_ResearchResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ResearchResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_ResearchResultEN> arrObjLst = new List<clsvzx_ResearchResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchResultEN objvzx_ResearchResultEN = new clsvzx_ResearchResultEN();
try
{
objvzx_ResearchResultEN.zxResultId = objRow[convzx_ResearchResult.zxResultId].ToString().Trim(); //成果Id
objvzx_ResearchResultEN.Memo = objRow[convzx_ResearchResult.Memo] == DBNull.Value ? null : objRow[convzx_ResearchResult.Memo].ToString().Trim(); //备注
objvzx_ResearchResultEN.UpdUser = objRow[convzx_ResearchResult.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchResultEN.UpdDate = objRow[convzx_ResearchResult.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchResult.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchResultEN.StuScore = objRow[convzx_ResearchResult.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.StuScore].ToString().Trim()); //学生平均分
objvzx_ResearchResultEN.Score = objRow[convzx_ResearchResult.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.Score].ToString().Trim()); //评分
objvzx_ResearchResultEN.OkCount = objRow[convzx_ResearchResult.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.OkCount].ToString().Trim()); //点赞统计
objvzx_ResearchResultEN.VersionCount = objRow[convzx_ResearchResult.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.VersionCount].ToString().Trim()); //版本统计
objvzx_ResearchResultEN.ResultContent = objRow[convzx_ResearchResult.ResultContent] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultContent].ToString().Trim(); //成果内容
objvzx_ResearchResultEN.TextId = objRow[convzx_ResearchResult.TextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.TextId].ToString().Trim(); //课件Id
objvzx_ResearchResultEN.GroupTextId = objRow[convzx_ResearchResult.GroupTextId] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextId].ToString().Trim(); //小组Id
objvzx_ResearchResultEN.ResultTypeId = objRow[convzx_ResearchResult.ResultTypeId] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultTypeId].ToString().Trim(); //成果类型Id
objvzx_ResearchResultEN.ResultName = objRow[convzx_ResearchResult.ResultName] == DBNull.Value ? null : objRow[convzx_ResearchResult.ResultName].ToString().Trim(); //成果名称
objvzx_ResearchResultEN.Author = objRow[convzx_ResearchResult.Author] == DBNull.Value ? null : objRow[convzx_ResearchResult.Author].ToString().Trim(); //作者
objvzx_ResearchResultEN.Division = objRow[convzx_ResearchResult.Division] == DBNull.Value ? null : objRow[convzx_ResearchResult.Division].ToString().Trim(); //分工
objvzx_ResearchResultEN.AppraiseCount = objRow[convzx_ResearchResult.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_ResearchResult.AppraiseCount].ToString().Trim()); //评论数
objvzx_ResearchResultEN.TeaScore = objRow[convzx_ResearchResult.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_ResearchResult.TeaScore].ToString().Trim()); //教师评分
objvzx_ResearchResultEN.GroupTextName = objRow[convzx_ResearchResult.GroupTextName] == DBNull.Value ? null : objRow[convzx_ResearchResult.GroupTextName].ToString().Trim(); //小组名称
objvzx_ResearchResultEN.IdCurrEduCls = objRow[convzx_ResearchResult.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_ResearchResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ResearchResultEN.zxShareId = objRow[convzx_ResearchResult.zxShareId] == DBNull.Value ? null : objRow[convzx_ResearchResult.zxShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchResultEN.zxResultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_ResearchResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_ResearchResult(ref clsvzx_ResearchResultEN objvzx_ResearchResultEN)
{
bool bolResult = vzx_ResearchResultDA.Getvzx_ResearchResult(ref objvzx_ResearchResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxResultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ResearchResultEN GetObjByzxResultId(string strzxResultId)
{
if (strzxResultId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxResultId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxResultId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxResultId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_ResearchResultEN objvzx_ResearchResultEN = vzx_ResearchResultDA.GetObjByzxResultId(strzxResultId);
return objvzx_ResearchResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_ResearchResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_ResearchResultEN objvzx_ResearchResultEN = vzx_ResearchResultDA.GetFirstObj(strWhereCond);
 return objvzx_ResearchResultEN;
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
public static clsvzx_ResearchResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_ResearchResultEN objvzx_ResearchResultEN = vzx_ResearchResultDA.GetObjByDataRow(objRow);
 return objvzx_ResearchResultEN;
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
public static clsvzx_ResearchResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_ResearchResultEN objvzx_ResearchResultEN = vzx_ResearchResultDA.GetObjByDataRow(objRow);
 return objvzx_ResearchResultEN;
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
 /// <param name = "strzxResultId">所给的关键字</param>
 /// <param name = "lstvzx_ResearchResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ResearchResultEN GetObjByzxResultIdFromList(string strzxResultId, List<clsvzx_ResearchResultEN> lstvzx_ResearchResultObjLst)
{
foreach (clsvzx_ResearchResultEN objvzx_ResearchResultEN in lstvzx_ResearchResultObjLst)
{
if (objvzx_ResearchResultEN.zxResultId == strzxResultId)
{
return objvzx_ResearchResultEN;
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
 string strMaxZxResultId;
 try
 {
 strMaxZxResultId = clsvzx_ResearchResultDA.GetMaxStrId();
 return strMaxZxResultId;
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
 string strzxResultId;
 try
 {
 strzxResultId = new clsvzx_ResearchResultDA().GetFirstID(strWhereCond);
 return strzxResultId;
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
 arrList = vzx_ResearchResultDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_ResearchResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxResultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxResultId)
{
if (string.IsNullOrEmpty(strzxResultId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxResultId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_ResearchResultDA.IsExist(strzxResultId);
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
 bolIsExist = clsvzx_ResearchResultDA.IsExistTable();
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
 bolIsExist = vzx_ResearchResultDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_ResearchResultENS">源对象</param>
 /// <param name = "objvzx_ResearchResultENT">目标对象</param>
 public static void CopyTo(clsvzx_ResearchResultEN objvzx_ResearchResultENS, clsvzx_ResearchResultEN objvzx_ResearchResultENT)
{
try
{
objvzx_ResearchResultENT.zxResultId = objvzx_ResearchResultENS.zxResultId; //成果Id
objvzx_ResearchResultENT.Memo = objvzx_ResearchResultENS.Memo; //备注
objvzx_ResearchResultENT.UpdUser = objvzx_ResearchResultENS.UpdUser; //修改人
objvzx_ResearchResultENT.UpdDate = objvzx_ResearchResultENS.UpdDate; //修改日期
objvzx_ResearchResultENT.StuScore = objvzx_ResearchResultENS.StuScore; //学生平均分
objvzx_ResearchResultENT.Score = objvzx_ResearchResultENS.Score; //评分
objvzx_ResearchResultENT.OkCount = objvzx_ResearchResultENS.OkCount; //点赞统计
objvzx_ResearchResultENT.VersionCount = objvzx_ResearchResultENS.VersionCount; //版本统计
objvzx_ResearchResultENT.ResultContent = objvzx_ResearchResultENS.ResultContent; //成果内容
objvzx_ResearchResultENT.TextId = objvzx_ResearchResultENS.TextId; //课件Id
objvzx_ResearchResultENT.GroupTextId = objvzx_ResearchResultENS.GroupTextId; //小组Id
objvzx_ResearchResultENT.ResultTypeId = objvzx_ResearchResultENS.ResultTypeId; //成果类型Id
objvzx_ResearchResultENT.ResultName = objvzx_ResearchResultENS.ResultName; //成果名称
objvzx_ResearchResultENT.Author = objvzx_ResearchResultENS.Author; //作者
objvzx_ResearchResultENT.Division = objvzx_ResearchResultENS.Division; //分工
objvzx_ResearchResultENT.AppraiseCount = objvzx_ResearchResultENS.AppraiseCount; //评论数
objvzx_ResearchResultENT.TeaScore = objvzx_ResearchResultENS.TeaScore; //教师评分
objvzx_ResearchResultENT.GroupTextName = objvzx_ResearchResultENS.GroupTextName; //小组名称
objvzx_ResearchResultENT.IdCurrEduCls = objvzx_ResearchResultENS.IdCurrEduCls; //教学班流水号
objvzx_ResearchResultENT.zxShareId = objvzx_ResearchResultENS.zxShareId; //分享Id
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
 /// <param name = "objvzx_ResearchResultEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_ResearchResultEN objvzx_ResearchResultEN)
{
try
{
objvzx_ResearchResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_ResearchResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_ResearchResult.zxResultId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.zxResultId = objvzx_ResearchResultEN.zxResultId; //成果Id
}
if (arrFldSet.Contains(convzx_ResearchResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.Memo = objvzx_ResearchResultEN.Memo == "[null]" ? null :  objvzx_ResearchResultEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_ResearchResult.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.UpdUser = objvzx_ResearchResultEN.UpdUser == "[null]" ? null :  objvzx_ResearchResultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_ResearchResult.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.UpdDate = objvzx_ResearchResultEN.UpdDate == "[null]" ? null :  objvzx_ResearchResultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_ResearchResult.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.StuScore = objvzx_ResearchResultEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_ResearchResult.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.Score = objvzx_ResearchResultEN.Score; //评分
}
if (arrFldSet.Contains(convzx_ResearchResult.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.OkCount = objvzx_ResearchResultEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convzx_ResearchResult.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.VersionCount = objvzx_ResearchResultEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_ResearchResult.ResultContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.ResultContent = objvzx_ResearchResultEN.ResultContent == "[null]" ? null :  objvzx_ResearchResultEN.ResultContent; //成果内容
}
if (arrFldSet.Contains(convzx_ResearchResult.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.TextId = objvzx_ResearchResultEN.TextId == "[null]" ? null :  objvzx_ResearchResultEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_ResearchResult.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.GroupTextId = objvzx_ResearchResultEN.GroupTextId == "[null]" ? null :  objvzx_ResearchResultEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_ResearchResult.ResultTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.ResultTypeId = objvzx_ResearchResultEN.ResultTypeId == "[null]" ? null :  objvzx_ResearchResultEN.ResultTypeId; //成果类型Id
}
if (arrFldSet.Contains(convzx_ResearchResult.ResultName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.ResultName = objvzx_ResearchResultEN.ResultName == "[null]" ? null :  objvzx_ResearchResultEN.ResultName; //成果名称
}
if (arrFldSet.Contains(convzx_ResearchResult.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.Author = objvzx_ResearchResultEN.Author == "[null]" ? null :  objvzx_ResearchResultEN.Author; //作者
}
if (arrFldSet.Contains(convzx_ResearchResult.Division, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.Division = objvzx_ResearchResultEN.Division == "[null]" ? null :  objvzx_ResearchResultEN.Division; //分工
}
if (arrFldSet.Contains(convzx_ResearchResult.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.AppraiseCount = objvzx_ResearchResultEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convzx_ResearchResult.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.TeaScore = objvzx_ResearchResultEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_ResearchResult.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.GroupTextName = objvzx_ResearchResultEN.GroupTextName == "[null]" ? null :  objvzx_ResearchResultEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_ResearchResult.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.IdCurrEduCls = objvzx_ResearchResultEN.IdCurrEduCls == "[null]" ? null :  objvzx_ResearchResultEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_ResearchResult.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchResultEN.zxShareId = objvzx_ResearchResultEN.zxShareId == "[null]" ? null :  objvzx_ResearchResultEN.zxShareId; //分享Id
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
 /// <param name = "objvzx_ResearchResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_ResearchResultEN objvzx_ResearchResultEN)
{
try
{
if (objvzx_ResearchResultEN.Memo == "[null]") objvzx_ResearchResultEN.Memo = null; //备注
if (objvzx_ResearchResultEN.UpdUser == "[null]") objvzx_ResearchResultEN.UpdUser = null; //修改人
if (objvzx_ResearchResultEN.UpdDate == "[null]") objvzx_ResearchResultEN.UpdDate = null; //修改日期
if (objvzx_ResearchResultEN.ResultContent == "[null]") objvzx_ResearchResultEN.ResultContent = null; //成果内容
if (objvzx_ResearchResultEN.TextId == "[null]") objvzx_ResearchResultEN.TextId = null; //课件Id
if (objvzx_ResearchResultEN.GroupTextId == "[null]") objvzx_ResearchResultEN.GroupTextId = null; //小组Id
if (objvzx_ResearchResultEN.ResultTypeId == "[null]") objvzx_ResearchResultEN.ResultTypeId = null; //成果类型Id
if (objvzx_ResearchResultEN.ResultName == "[null]") objvzx_ResearchResultEN.ResultName = null; //成果名称
if (objvzx_ResearchResultEN.Author == "[null]") objvzx_ResearchResultEN.Author = null; //作者
if (objvzx_ResearchResultEN.Division == "[null]") objvzx_ResearchResultEN.Division = null; //分工
if (objvzx_ResearchResultEN.GroupTextName == "[null]") objvzx_ResearchResultEN.GroupTextName = null; //小组名称
if (objvzx_ResearchResultEN.IdCurrEduCls == "[null]") objvzx_ResearchResultEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_ResearchResultEN.zxShareId == "[null]") objvzx_ResearchResultEN.zxShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvzx_ResearchResultEN objvzx_ResearchResultEN)
{
 vzx_ResearchResultDA.CheckProperty4Condition(objvzx_ResearchResultEN);
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
if (clszx_GroupTextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextBL没有刷新缓存机制(clszx_GroupTextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ResearchResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ResearchResultBL没有刷新缓存机制(clszx_ResearchResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxResultId");
//if (arrvzx_ResearchResultObjLstCache == null)
//{
//arrvzx_ResearchResultObjLstCache = vzx_ResearchResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxResultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ResearchResultEN GetObjByzxResultIdCache(string strzxResultId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_ResearchResultEN._CurrTabName);
List<clsvzx_ResearchResultEN> arrvzx_ResearchResultObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchResultEN> arrvzx_ResearchResultObjLst_Sel =
arrvzx_ResearchResultObjLstCache
.Where(x=> x.zxResultId == strzxResultId 
);
if (arrvzx_ResearchResultObjLst_Sel.Count() == 0)
{
   clsvzx_ResearchResultEN obj = clsvzx_ResearchResultBL.GetObjByzxResultId(strzxResultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_ResearchResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ResearchResultEN> GetAllvzx_ResearchResultObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_ResearchResultEN> arrvzx_ResearchResultObjLstCache = GetObjLstCache(); 
return arrvzx_ResearchResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ResearchResultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_ResearchResultEN._CurrTabName);
List<clsvzx_ResearchResultEN> arrvzx_ResearchResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_ResearchResultObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_ResearchResultEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxResultId)
{
if (strInFldName != convzx_ResearchResult.zxResultId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_ResearchResult.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_ResearchResult.AttributeName));
throw new Exception(strMsg);
}
var objvzx_ResearchResult = clsvzx_ResearchResultBL.GetObjByzxResultIdCache(strzxResultId);
if (objvzx_ResearchResult == null) return "";
return objvzx_ResearchResult[strOutFldName].ToString();
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
int intRecCount = clsvzx_ResearchResultDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_ResearchResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_ResearchResultDA.GetRecCount();
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
int intRecCount = clsvzx_ResearchResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_ResearchResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_ResearchResultEN objvzx_ResearchResultCond)
{
List<clsvzx_ResearchResultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_ResearchResult.AttributeName)
{
if (objvzx_ResearchResultCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ResearchResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchResultCond[strFldName].ToString());
}
else
{
if (objvzx_ResearchResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ResearchResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ResearchResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ResearchResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchResultCond[strFldName]));
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
 List<string> arrList = clsvzx_ResearchResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_ResearchResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_ResearchResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}