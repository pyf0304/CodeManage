
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PaperReportBL
 表名:vgs_PaperReport(01120771)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:52:48
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
public static class  clsvgs_PaperReportBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strReportId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperReportEN GetObj(this K_ReportId_vgs_PaperReport myKey)
{
clsvgs_PaperReportEN objvgs_PaperReportEN = clsvgs_PaperReportBL.vgs_PaperReportDA.GetObjByReportId(myKey.Value);
return objvgs_PaperReportEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetMemo(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PaperReport.Memo);
}
objvgs_PaperReportEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.Memo) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.Memo, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.Memo] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetReportId(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strReportId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportId, 10, convgs_PaperReport.ReportId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReportId, 10, convgs_PaperReport.ReportId);
}
objvgs_PaperReportEN.ReportId = strReportId; //汇报Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.ReportId) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.ReportId, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.ReportId] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetUpdDate(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PaperReport.UpdDate);
}
objvgs_PaperReportEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.UpdDate) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.UpdDate, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.UpdDate] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetTopicName(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convgs_PaperReport.TopicName);
}
objvgs_PaperReportEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.TopicName) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.TopicName, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.TopicName] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetTopicId(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convgs_PaperReport.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convgs_PaperReport.TopicId);
}
objvgs_PaperReportEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.TopicId) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.TopicId, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.TopicId] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetPaperId(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PaperReport.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PaperReport.PaperId);
}
objvgs_PaperReportEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.PaperId) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.PaperId, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.PaperId] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetPaperTitle(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PaperReport.PaperTitle);
}
objvgs_PaperReportEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.PaperTitle) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.PaperTitle, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.PaperTitle] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetReportContent(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strReportContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportContent, 5000, convgs_PaperReport.ReportContent);
}
objvgs_PaperReportEN.ReportContent = strReportContent; //汇报内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.ReportContent) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.ReportContent, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.ReportContent] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetIdCurrEduCls(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_PaperReport.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_PaperReport.IdCurrEduCls);
}
objvgs_PaperReportEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.IdCurrEduCls) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetIsSubmit(this clsvgs_PaperReportEN objvgs_PaperReportEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_PaperReportEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.IsSubmit) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.IsSubmit, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.IsSubmit] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetReportUser(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strReportUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportUser, 500, convgs_PaperReport.ReportUser);
}
objvgs_PaperReportEN.ReportUser = strReportUser; //汇报用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.ReportUser) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.ReportUser, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.ReportUser] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetReportDate(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strReportDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportDate, 20, convgs_PaperReport.ReportDate);
}
objvgs_PaperReportEN.ReportDate = strReportDate; //汇报日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.ReportDate) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.ReportDate, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.ReportDate] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetUpdUser(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PaperReport.UpdUser);
}
objvgs_PaperReportEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.UpdUser) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.UpdUser, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.UpdUser] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetVersionCount(this clsvgs_PaperReportEN objvgs_PaperReportEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_PaperReportEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.VersionCount) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.VersionCount, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.VersionCount] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetOkCount(this clsvgs_PaperReportEN objvgs_PaperReportEN, int? intOkCount, string strComparisonOp="")
	{
objvgs_PaperReportEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.OkCount) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.OkCount, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.OkCount] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetAppraiseCount(this clsvgs_PaperReportEN objvgs_PaperReportEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvgs_PaperReportEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.AppraiseCount) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.AppraiseCount, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.AppraiseCount] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetScore(this clsvgs_PaperReportEN objvgs_PaperReportEN, float? fltScore, string strComparisonOp="")
	{
objvgs_PaperReportEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.Score) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.Score, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.Score] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetStuScore(this clsvgs_PaperReportEN objvgs_PaperReportEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_PaperReportEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.StuScore) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.StuScore, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.StuScore] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetTeaScore(this clsvgs_PaperReportEN objvgs_PaperReportEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_PaperReportEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.TeaScore) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.TeaScore, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.TeaScore] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetPDFUrl(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strPDFUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPDFUrl, 500, convgs_PaperReport.PDFUrl);
}
objvgs_PaperReportEN.PDFUrl = strPDFUrl; //PDFUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.PDFUrl) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.PDFUrl, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.PDFUrl] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetPPTUrl(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strPPTUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPPTUrl, 500, convgs_PaperReport.PPTUrl);
}
objvgs_PaperReportEN.PPTUrl = strPPTUrl; //PPTUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.PPTUrl) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.PPTUrl, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.PPTUrl] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetMonth(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, convgs_PaperReport.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, convgs_PaperReport.Month);
}
objvgs_PaperReportEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.Month) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.Month, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.Month] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetWeek(this clsvgs_PaperReportEN objvgs_PaperReportEN, int? intWeek, string strComparisonOp="")
	{
objvgs_PaperReportEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.Week) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.Week, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.Week] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PaperReportEN SetYear(this clsvgs_PaperReportEN objvgs_PaperReportEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, convgs_PaperReport.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, convgs_PaperReport.Year);
}
objvgs_PaperReportEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PaperReportEN.dicFldComparisonOp.ContainsKey(convgs_PaperReport.Year) == false)
{
objvgs_PaperReportEN.dicFldComparisonOp.Add(convgs_PaperReport.Year, strComparisonOp);
}
else
{
objvgs_PaperReportEN.dicFldComparisonOp[convgs_PaperReport.Year] = strComparisonOp;
}
}
return objvgs_PaperReportEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PaperReportENS">源对象</param>
 /// <param name = "objvgs_PaperReportENT">目标对象</param>
 public static void CopyTo(this clsvgs_PaperReportEN objvgs_PaperReportENS, clsvgs_PaperReportEN objvgs_PaperReportENT)
{
try
{
objvgs_PaperReportENT.Memo = objvgs_PaperReportENS.Memo; //备注
objvgs_PaperReportENT.ReportId = objvgs_PaperReportENS.ReportId; //汇报Id
objvgs_PaperReportENT.UpdDate = objvgs_PaperReportENS.UpdDate; //修改日期
objvgs_PaperReportENT.TopicName = objvgs_PaperReportENS.TopicName; //栏目主题
objvgs_PaperReportENT.TopicId = objvgs_PaperReportENS.TopicId; //主题Id
objvgs_PaperReportENT.PaperId = objvgs_PaperReportENS.PaperId; //论文Id
objvgs_PaperReportENT.PaperTitle = objvgs_PaperReportENS.PaperTitle; //论文标题
objvgs_PaperReportENT.ReportContent = objvgs_PaperReportENS.ReportContent; //汇报内容
objvgs_PaperReportENT.IdCurrEduCls = objvgs_PaperReportENS.IdCurrEduCls; //教学班流水号
objvgs_PaperReportENT.IsSubmit = objvgs_PaperReportENS.IsSubmit; //是否提交
objvgs_PaperReportENT.ReportUser = objvgs_PaperReportENS.ReportUser; //汇报用户
objvgs_PaperReportENT.ReportDate = objvgs_PaperReportENS.ReportDate; //汇报日期
objvgs_PaperReportENT.UpdUser = objvgs_PaperReportENS.UpdUser; //修改人
objvgs_PaperReportENT.VersionCount = objvgs_PaperReportENS.VersionCount; //版本统计
objvgs_PaperReportENT.OkCount = objvgs_PaperReportENS.OkCount; //点赞统计
objvgs_PaperReportENT.AppraiseCount = objvgs_PaperReportENS.AppraiseCount; //评论数
objvgs_PaperReportENT.Score = objvgs_PaperReportENS.Score; //评分
objvgs_PaperReportENT.StuScore = objvgs_PaperReportENS.StuScore; //学生平均分
objvgs_PaperReportENT.TeaScore = objvgs_PaperReportENS.TeaScore; //教师评分
objvgs_PaperReportENT.PDFUrl = objvgs_PaperReportENS.PDFUrl; //PDFUrl
objvgs_PaperReportENT.PPTUrl = objvgs_PaperReportENS.PPTUrl; //PPTUrl
objvgs_PaperReportENT.Month = objvgs_PaperReportENS.Month; //月
objvgs_PaperReportENT.Week = objvgs_PaperReportENS.Week; //周
objvgs_PaperReportENT.Year = objvgs_PaperReportENS.Year; //年
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
 /// <param name = "objvgs_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PaperReportEN:objvgs_PaperReportENT</returns>
 public static clsvgs_PaperReportEN CopyTo(this clsvgs_PaperReportEN objvgs_PaperReportENS)
{
try
{
 clsvgs_PaperReportEN objvgs_PaperReportENT = new clsvgs_PaperReportEN()
{
Memo = objvgs_PaperReportENS.Memo, //备注
ReportId = objvgs_PaperReportENS.ReportId, //汇报Id
UpdDate = objvgs_PaperReportENS.UpdDate, //修改日期
TopicName = objvgs_PaperReportENS.TopicName, //栏目主题
TopicId = objvgs_PaperReportENS.TopicId, //主题Id
PaperId = objvgs_PaperReportENS.PaperId, //论文Id
PaperTitle = objvgs_PaperReportENS.PaperTitle, //论文标题
ReportContent = objvgs_PaperReportENS.ReportContent, //汇报内容
IdCurrEduCls = objvgs_PaperReportENS.IdCurrEduCls, //教学班流水号
IsSubmit = objvgs_PaperReportENS.IsSubmit, //是否提交
ReportUser = objvgs_PaperReportENS.ReportUser, //汇报用户
ReportDate = objvgs_PaperReportENS.ReportDate, //汇报日期
UpdUser = objvgs_PaperReportENS.UpdUser, //修改人
VersionCount = objvgs_PaperReportENS.VersionCount, //版本统计
OkCount = objvgs_PaperReportENS.OkCount, //点赞统计
AppraiseCount = objvgs_PaperReportENS.AppraiseCount, //评论数
Score = objvgs_PaperReportENS.Score, //评分
StuScore = objvgs_PaperReportENS.StuScore, //学生平均分
TeaScore = objvgs_PaperReportENS.TeaScore, //教师评分
PDFUrl = objvgs_PaperReportENS.PDFUrl, //PDFUrl
PPTUrl = objvgs_PaperReportENS.PPTUrl, //PPTUrl
Month = objvgs_PaperReportENS.Month, //月
Week = objvgs_PaperReportENS.Week, //周
Year = objvgs_PaperReportENS.Year, //年
};
 return objvgs_PaperReportENT;
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
public static void CheckProperty4Condition(this clsvgs_PaperReportEN objvgs_PaperReportEN)
{
 clsvgs_PaperReportBL.vgs_PaperReportDA.CheckProperty4Condition(objvgs_PaperReportEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PaperReportEN objvgs_PaperReportCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.Memo) == true)
{
string strComparisonOpMemo = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.Memo, objvgs_PaperReportCond.Memo, strComparisonOpMemo);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.ReportId) == true)
{
string strComparisonOpReportId = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.ReportId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.ReportId, objvgs_PaperReportCond.ReportId, strComparisonOpReportId);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.UpdDate, objvgs_PaperReportCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.TopicName) == true)
{
string strComparisonOpTopicName = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.TopicName, objvgs_PaperReportCond.TopicName, strComparisonOpTopicName);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.TopicId) == true)
{
string strComparisonOpTopicId = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.TopicId, objvgs_PaperReportCond.TopicId, strComparisonOpTopicId);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.PaperId, objvgs_PaperReportCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.PaperTitle, objvgs_PaperReportCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.ReportContent) == true)
{
string strComparisonOpReportContent = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.ReportContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.ReportContent, objvgs_PaperReportCond.ReportContent, strComparisonOpReportContent);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.IdCurrEduCls, objvgs_PaperReportCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.IsSubmit) == true)
{
if (objvgs_PaperReportCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PaperReport.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PaperReport.IsSubmit);
}
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.ReportUser) == true)
{
string strComparisonOpReportUser = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.ReportUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.ReportUser, objvgs_PaperReportCond.ReportUser, strComparisonOpReportUser);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.ReportDate) == true)
{
string strComparisonOpReportDate = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.ReportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.ReportDate, objvgs_PaperReportCond.ReportDate, strComparisonOpReportDate);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.UpdUser, objvgs_PaperReportCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperReport.VersionCount, objvgs_PaperReportCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.OkCount) == true)
{
string strComparisonOpOkCount = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperReport.OkCount, objvgs_PaperReportCond.OkCount, strComparisonOpOkCount);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperReport.AppraiseCount, objvgs_PaperReportCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.Score) == true)
{
string strComparisonOpScore = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperReport.Score, objvgs_PaperReportCond.Score, strComparisonOpScore);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperReport.StuScore, objvgs_PaperReportCond.StuScore, strComparisonOpStuScore);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperReport.TeaScore, objvgs_PaperReportCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.PDFUrl) == true)
{
string strComparisonOpPDFUrl = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.PDFUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.PDFUrl, objvgs_PaperReportCond.PDFUrl, strComparisonOpPDFUrl);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.PPTUrl) == true)
{
string strComparisonOpPPTUrl = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.PPTUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.PPTUrl, objvgs_PaperReportCond.PPTUrl, strComparisonOpPPTUrl);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.Month) == true)
{
string strComparisonOpMonth = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.Month, objvgs_PaperReportCond.Month, strComparisonOpMonth);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.Week) == true)
{
string strComparisonOpWeek = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.Week];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PaperReport.Week, objvgs_PaperReportCond.Week, strComparisonOpWeek);
}
if (objvgs_PaperReportCond.IsUpdated(convgs_PaperReport.Year) == true)
{
string strComparisonOpYear = objvgs_PaperReportCond.dicFldComparisonOp[convgs_PaperReport.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PaperReport.Year, objvgs_PaperReportCond.Year, strComparisonOpYear);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PaperReport
{
public virtual bool UpdRelaTabDate(string strReportId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文汇报视图(vgs_PaperReport)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PaperReportBL
{
public static RelatedActions_vgs_PaperReport relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PaperReportDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PaperReportDA vgs_PaperReportDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PaperReportDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PaperReportBL()
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
if (string.IsNullOrEmpty(clsvgs_PaperReportEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PaperReportEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PaperReport(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PaperReportDA.GetDataTable_vgs_PaperReport(strWhereCond);
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
objDT = vgs_PaperReportDA.GetDataTable(strWhereCond);
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
objDT = vgs_PaperReportDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PaperReportDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PaperReportDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PaperReportDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PaperReportDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PaperReportDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PaperReportDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrReportIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_PaperReportEN> GetObjLstByReportIdLst(List<string> arrReportIdLst)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrReportIdLst, true);
 string strWhereCond = string.Format("ReportId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrReportIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PaperReportEN> GetObjLstByReportIdLstCache(List<string> arrReportIdLst)
{
string strKey = string.Format("{0}", clsvgs_PaperReportEN._CurrTabName);
List<clsvgs_PaperReportEN> arrvgs_PaperReportObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperReportEN> arrvgs_PaperReportObjLst_Sel =
arrvgs_PaperReportObjLstCache
.Where(x => arrReportIdLst.Contains(x.ReportId));
return arrvgs_PaperReportObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperReportEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
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
public static List<clsvgs_PaperReportEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PaperReportCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PaperReportEN> GetSubObjLstCache(clsvgs_PaperReportEN objvgs_PaperReportCond)
{
List<clsvgs_PaperReportEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperReportEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperReport.AttributeName)
{
if (objvgs_PaperReportCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperReportCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperReportCond[strFldName].ToString());
}
else
{
if (objvgs_PaperReportCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperReportCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperReportCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperReportCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperReportCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperReportCond[strFldName]));
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
public static List<clsvgs_PaperReportEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
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
public static List<clsvgs_PaperReportEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
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
List<clsvgs_PaperReportEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PaperReportEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperReportEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PaperReportEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
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
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
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
public static List<clsvgs_PaperReportEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PaperReportEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PaperReportEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
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
public static List<clsvgs_PaperReportEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PaperReportEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PaperReportEN> arrObjLst = new List<clsvgs_PaperReportEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PaperReportEN objvgs_PaperReportEN = new clsvgs_PaperReportEN();
try
{
objvgs_PaperReportEN.Memo = objRow[convgs_PaperReport.Memo] == DBNull.Value ? null : objRow[convgs_PaperReport.Memo].ToString().Trim(); //备注
objvgs_PaperReportEN.ReportId = objRow[convgs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objvgs_PaperReportEN.UpdDate = objRow[convgs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvgs_PaperReportEN.TopicName = objRow[convgs_PaperReport.TopicName] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicName].ToString().Trim(); //栏目主题
objvgs_PaperReportEN.TopicId = objRow[convgs_PaperReport.TopicId] == DBNull.Value ? null : objRow[convgs_PaperReport.TopicId].ToString().Trim(); //主题Id
objvgs_PaperReportEN.PaperId = objRow[convgs_PaperReport.PaperId] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperId].ToString().Trim(); //论文Id
objvgs_PaperReportEN.PaperTitle = objRow[convgs_PaperReport.PaperTitle] == DBNull.Value ? null : objRow[convgs_PaperReport.PaperTitle].ToString().Trim(); //论文标题
objvgs_PaperReportEN.ReportContent = objRow[convgs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvgs_PaperReportEN.IdCurrEduCls = objRow[convgs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvgs_PaperReportEN.ReportUser = objRow[convgs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvgs_PaperReportEN.ReportDate = objRow[convgs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convgs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvgs_PaperReportEN.UpdUser = objRow[convgs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convgs_PaperReport.UpdUser].ToString().Trim(); //修改人
objvgs_PaperReportEN.VersionCount = objRow[convgs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvgs_PaperReportEN.OkCount = objRow[convgs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvgs_PaperReportEN.AppraiseCount = objRow[convgs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objvgs_PaperReportEN.Score = objRow[convgs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.Score].ToString().Trim()); //评分
objvgs_PaperReportEN.StuScore = objRow[convgs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvgs_PaperReportEN.TeaScore = objRow[convgs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvgs_PaperReportEN.PDFUrl = objRow[convgs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvgs_PaperReportEN.PPTUrl = objRow[convgs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convgs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvgs_PaperReportEN.Month = objRow[convgs_PaperReport.Month] == DBNull.Value ? null : objRow[convgs_PaperReport.Month].ToString().Trim(); //月
objvgs_PaperReportEN.Week = objRow[convgs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PaperReport.Week].ToString().Trim()); //周
objvgs_PaperReportEN.Year = objRow[convgs_PaperReport.Year] == DBNull.Value ? null : objRow[convgs_PaperReport.Year].ToString().Trim(); //年
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PaperReportEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PaperReportEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PaperReport(ref clsvgs_PaperReportEN objvgs_PaperReportEN)
{
bool bolResult = vgs_PaperReportDA.Getvgs_PaperReport(ref objvgs_PaperReportEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strReportId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PaperReportEN GetObjByReportId(string strReportId)
{
if (strReportId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strReportId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strReportId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strReportId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvgs_PaperReportEN objvgs_PaperReportEN = vgs_PaperReportDA.GetObjByReportId(strReportId);
return objvgs_PaperReportEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PaperReportEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PaperReportEN objvgs_PaperReportEN = vgs_PaperReportDA.GetFirstObj(strWhereCond);
 return objvgs_PaperReportEN;
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
public static clsvgs_PaperReportEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PaperReportEN objvgs_PaperReportEN = vgs_PaperReportDA.GetObjByDataRow(objRow);
 return objvgs_PaperReportEN;
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
public static clsvgs_PaperReportEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PaperReportEN objvgs_PaperReportEN = vgs_PaperReportDA.GetObjByDataRow(objRow);
 return objvgs_PaperReportEN;
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
 /// <param name = "strReportId">所给的关键字</param>
 /// <param name = "lstvgs_PaperReportObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperReportEN GetObjByReportIdFromList(string strReportId, List<clsvgs_PaperReportEN> lstvgs_PaperReportObjLst)
{
foreach (clsvgs_PaperReportEN objvgs_PaperReportEN in lstvgs_PaperReportObjLst)
{
if (objvgs_PaperReportEN.ReportId == strReportId)
{
return objvgs_PaperReportEN;
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
 string strReportId;
 try
 {
 strReportId = new clsvgs_PaperReportDA().GetFirstID(strWhereCond);
 return strReportId;
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
 arrList = vgs_PaperReportDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PaperReportDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strReportId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strReportId)
{
if (string.IsNullOrEmpty(strReportId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strReportId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vgs_PaperReportDA.IsExist(strReportId);
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
 bolIsExist = clsvgs_PaperReportDA.IsExistTable();
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
 bolIsExist = vgs_PaperReportDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PaperReportENS">源对象</param>
 /// <param name = "objvgs_PaperReportENT">目标对象</param>
 public static void CopyTo(clsvgs_PaperReportEN objvgs_PaperReportENS, clsvgs_PaperReportEN objvgs_PaperReportENT)
{
try
{
objvgs_PaperReportENT.Memo = objvgs_PaperReportENS.Memo; //备注
objvgs_PaperReportENT.ReportId = objvgs_PaperReportENS.ReportId; //汇报Id
objvgs_PaperReportENT.UpdDate = objvgs_PaperReportENS.UpdDate; //修改日期
objvgs_PaperReportENT.TopicName = objvgs_PaperReportENS.TopicName; //栏目主题
objvgs_PaperReportENT.TopicId = objvgs_PaperReportENS.TopicId; //主题Id
objvgs_PaperReportENT.PaperId = objvgs_PaperReportENS.PaperId; //论文Id
objvgs_PaperReportENT.PaperTitle = objvgs_PaperReportENS.PaperTitle; //论文标题
objvgs_PaperReportENT.ReportContent = objvgs_PaperReportENS.ReportContent; //汇报内容
objvgs_PaperReportENT.IdCurrEduCls = objvgs_PaperReportENS.IdCurrEduCls; //教学班流水号
objvgs_PaperReportENT.IsSubmit = objvgs_PaperReportENS.IsSubmit; //是否提交
objvgs_PaperReportENT.ReportUser = objvgs_PaperReportENS.ReportUser; //汇报用户
objvgs_PaperReportENT.ReportDate = objvgs_PaperReportENS.ReportDate; //汇报日期
objvgs_PaperReportENT.UpdUser = objvgs_PaperReportENS.UpdUser; //修改人
objvgs_PaperReportENT.VersionCount = objvgs_PaperReportENS.VersionCount; //版本统计
objvgs_PaperReportENT.OkCount = objvgs_PaperReportENS.OkCount; //点赞统计
objvgs_PaperReportENT.AppraiseCount = objvgs_PaperReportENS.AppraiseCount; //评论数
objvgs_PaperReportENT.Score = objvgs_PaperReportENS.Score; //评分
objvgs_PaperReportENT.StuScore = objvgs_PaperReportENS.StuScore; //学生平均分
objvgs_PaperReportENT.TeaScore = objvgs_PaperReportENS.TeaScore; //教师评分
objvgs_PaperReportENT.PDFUrl = objvgs_PaperReportENS.PDFUrl; //PDFUrl
objvgs_PaperReportENT.PPTUrl = objvgs_PaperReportENS.PPTUrl; //PPTUrl
objvgs_PaperReportENT.Month = objvgs_PaperReportENS.Month; //月
objvgs_PaperReportENT.Week = objvgs_PaperReportENS.Week; //周
objvgs_PaperReportENT.Year = objvgs_PaperReportENS.Year; //年
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
 /// <param name = "objvgs_PaperReportEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PaperReportEN objvgs_PaperReportEN)
{
try
{
objvgs_PaperReportEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PaperReportEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PaperReport.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.Memo = objvgs_PaperReportEN.Memo == "[null]" ? null :  objvgs_PaperReportEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_PaperReport.ReportId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.ReportId = objvgs_PaperReportEN.ReportId; //汇报Id
}
if (arrFldSet.Contains(convgs_PaperReport.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.UpdDate = objvgs_PaperReportEN.UpdDate == "[null]" ? null :  objvgs_PaperReportEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PaperReport.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.TopicName = objvgs_PaperReportEN.TopicName == "[null]" ? null :  objvgs_PaperReportEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convgs_PaperReport.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.TopicId = objvgs_PaperReportEN.TopicId == "[null]" ? null :  objvgs_PaperReportEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convgs_PaperReport.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.PaperId = objvgs_PaperReportEN.PaperId == "[null]" ? null :  objvgs_PaperReportEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PaperReport.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.PaperTitle = objvgs_PaperReportEN.PaperTitle == "[null]" ? null :  objvgs_PaperReportEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PaperReport.ReportContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.ReportContent = objvgs_PaperReportEN.ReportContent == "[null]" ? null :  objvgs_PaperReportEN.ReportContent; //汇报内容
}
if (arrFldSet.Contains(convgs_PaperReport.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.IdCurrEduCls = objvgs_PaperReportEN.IdCurrEduCls == "[null]" ? null :  objvgs_PaperReportEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_PaperReport.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.IsSubmit = objvgs_PaperReportEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_PaperReport.ReportUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.ReportUser = objvgs_PaperReportEN.ReportUser == "[null]" ? null :  objvgs_PaperReportEN.ReportUser; //汇报用户
}
if (arrFldSet.Contains(convgs_PaperReport.ReportDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.ReportDate = objvgs_PaperReportEN.ReportDate == "[null]" ? null :  objvgs_PaperReportEN.ReportDate; //汇报日期
}
if (arrFldSet.Contains(convgs_PaperReport.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.UpdUser = objvgs_PaperReportEN.UpdUser == "[null]" ? null :  objvgs_PaperReportEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PaperReport.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.VersionCount = objvgs_PaperReportEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_PaperReport.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.OkCount = objvgs_PaperReportEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convgs_PaperReport.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.AppraiseCount = objvgs_PaperReportEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convgs_PaperReport.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.Score = objvgs_PaperReportEN.Score; //评分
}
if (arrFldSet.Contains(convgs_PaperReport.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.StuScore = objvgs_PaperReportEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convgs_PaperReport.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.TeaScore = objvgs_PaperReportEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_PaperReport.PDFUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.PDFUrl = objvgs_PaperReportEN.PDFUrl == "[null]" ? null :  objvgs_PaperReportEN.PDFUrl; //PDFUrl
}
if (arrFldSet.Contains(convgs_PaperReport.PPTUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.PPTUrl = objvgs_PaperReportEN.PPTUrl == "[null]" ? null :  objvgs_PaperReportEN.PPTUrl; //PPTUrl
}
if (arrFldSet.Contains(convgs_PaperReport.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.Month = objvgs_PaperReportEN.Month == "[null]" ? null :  objvgs_PaperReportEN.Month; //月
}
if (arrFldSet.Contains(convgs_PaperReport.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.Week = objvgs_PaperReportEN.Week; //周
}
if (arrFldSet.Contains(convgs_PaperReport.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PaperReportEN.Year = objvgs_PaperReportEN.Year == "[null]" ? null :  objvgs_PaperReportEN.Year; //年
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
 /// <param name = "objvgs_PaperReportEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PaperReportEN objvgs_PaperReportEN)
{
try
{
if (objvgs_PaperReportEN.Memo == "[null]") objvgs_PaperReportEN.Memo = null; //备注
if (objvgs_PaperReportEN.UpdDate == "[null]") objvgs_PaperReportEN.UpdDate = null; //修改日期
if (objvgs_PaperReportEN.TopicName == "[null]") objvgs_PaperReportEN.TopicName = null; //栏目主题
if (objvgs_PaperReportEN.TopicId == "[null]") objvgs_PaperReportEN.TopicId = null; //主题Id
if (objvgs_PaperReportEN.PaperId == "[null]") objvgs_PaperReportEN.PaperId = null; //论文Id
if (objvgs_PaperReportEN.PaperTitle == "[null]") objvgs_PaperReportEN.PaperTitle = null; //论文标题
if (objvgs_PaperReportEN.ReportContent == "[null]") objvgs_PaperReportEN.ReportContent = null; //汇报内容
if (objvgs_PaperReportEN.IdCurrEduCls == "[null]") objvgs_PaperReportEN.IdCurrEduCls = null; //教学班流水号
if (objvgs_PaperReportEN.ReportUser == "[null]") objvgs_PaperReportEN.ReportUser = null; //汇报用户
if (objvgs_PaperReportEN.ReportDate == "[null]") objvgs_PaperReportEN.ReportDate = null; //汇报日期
if (objvgs_PaperReportEN.UpdUser == "[null]") objvgs_PaperReportEN.UpdUser = null; //修改人
if (objvgs_PaperReportEN.PDFUrl == "[null]") objvgs_PaperReportEN.PDFUrl = null; //PDFUrl
if (objvgs_PaperReportEN.PPTUrl == "[null]") objvgs_PaperReportEN.PPTUrl = null; //PPTUrl
if (objvgs_PaperReportEN.Month == "[null]") objvgs_PaperReportEN.Month = null; //月
if (objvgs_PaperReportEN.Year == "[null]") objvgs_PaperReportEN.Year = null; //年
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
public static void CheckProperty4Condition(clsvgs_PaperReportEN objvgs_PaperReportEN)
{
 vgs_PaperReportDA.CheckProperty4Condition(objvgs_PaperReportEN);
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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperReportBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperReportBL没有刷新缓存机制(clsgs_PaperReportBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ReportId");
//if (arrvgs_PaperReportObjLstCache == null)
//{
//arrvgs_PaperReportObjLstCache = vgs_PaperReportDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strReportId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PaperReportEN GetObjByReportIdCache(string strReportId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PaperReportEN._CurrTabName);
List<clsvgs_PaperReportEN> arrvgs_PaperReportObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperReportEN> arrvgs_PaperReportObjLst_Sel =
arrvgs_PaperReportObjLstCache
.Where(x=> x.ReportId == strReportId 
);
if (arrvgs_PaperReportObjLst_Sel.Count() == 0)
{
   clsvgs_PaperReportEN obj = clsvgs_PaperReportBL.GetObjByReportId(strReportId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PaperReportObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperReportEN> GetAllvgs_PaperReportObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PaperReportEN> arrvgs_PaperReportObjLstCache = GetObjLstCache(); 
return arrvgs_PaperReportObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PaperReportEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PaperReportEN._CurrTabName);
List<clsvgs_PaperReportEN> arrvgs_PaperReportObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PaperReportObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PaperReportEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strReportId)
{
if (strInFldName != convgs_PaperReport.ReportId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PaperReport.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PaperReport.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PaperReport = clsvgs_PaperReportBL.GetObjByReportIdCache(strReportId);
if (objvgs_PaperReport == null) return "";
return objvgs_PaperReport[strOutFldName].ToString();
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
int intRecCount = clsvgs_PaperReportDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PaperReportDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PaperReportDA.GetRecCount();
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
int intRecCount = clsvgs_PaperReportDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PaperReportCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PaperReportEN objvgs_PaperReportCond)
{
List<clsvgs_PaperReportEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PaperReportEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PaperReport.AttributeName)
{
if (objvgs_PaperReportCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PaperReportCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperReportCond[strFldName].ToString());
}
else
{
if (objvgs_PaperReportCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PaperReportCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PaperReportCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PaperReportCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PaperReportCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PaperReportCond[strFldName]));
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
 List<string> arrList = clsvgs_PaperReportDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperReportDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PaperReportDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}