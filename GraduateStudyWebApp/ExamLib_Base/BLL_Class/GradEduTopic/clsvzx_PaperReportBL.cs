
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_PaperReportBL
 表名:vzx_PaperReport(01120832)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:53
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
public static class  clsvzx_PaperReportBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxReportId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_PaperReportEN GetObj(this K_zxReportId_vzx_PaperReport myKey)
{
clsvzx_PaperReportEN objvzx_PaperReportEN = clsvzx_PaperReportBL.vzx_PaperReportDA.GetObjByzxReportId(myKey.Value);
return objvzx_PaperReportEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetTextTitle(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strTextTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, convzx_PaperReport.TextTitle);
}
objvzx_PaperReportEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.TextTitle) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.TextTitle, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.TextTitle] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetGroupTextName(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_PaperReport.GroupTextName);
}
objvzx_PaperReportEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.GroupTextName) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.GroupTextName, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.GroupTextName] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetIdCurrEduCls(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_PaperReport.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_PaperReport.IdCurrEduCls);
}
objvzx_PaperReportEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.IdCurrEduCls) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetzxReportId(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strzxReportId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxReportId, 10, convzx_PaperReport.zxReportId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxReportId, 10, convzx_PaperReport.zxReportId);
}
objvzx_PaperReportEN.zxReportId = strzxReportId; //汇报Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.zxReportId) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.zxReportId, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.zxReportId] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetGroupTextId(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_PaperReport.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_PaperReport.GroupTextId);
}
objvzx_PaperReportEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.GroupTextId) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.GroupTextId, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.GroupTextId] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetUpdDate(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_PaperReport.UpdDate);
}
objvzx_PaperReportEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.UpdDate) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.UpdDate, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.UpdDate] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetPDFUrl(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strPDFUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPDFUrl, 500, convzx_PaperReport.PDFUrl);
}
objvzx_PaperReportEN.PDFUrl = strPDFUrl; //PDFUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.PDFUrl) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.PDFUrl, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.PDFUrl] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetTeaScore(this clsvzx_PaperReportEN objvzx_PaperReportEN, float? fltTeaScore, string strComparisonOp="")
	{
objvzx_PaperReportEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.TeaScore) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.TeaScore, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.TeaScore] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetStuScore(this clsvzx_PaperReportEN objvzx_PaperReportEN, float? fltStuScore, string strComparisonOp="")
	{
objvzx_PaperReportEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.StuScore) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.StuScore, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.StuScore] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetScore(this clsvzx_PaperReportEN objvzx_PaperReportEN, float? fltScore, string strComparisonOp="")
	{
objvzx_PaperReportEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.Score) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.Score, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.Score] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetOkCount(this clsvzx_PaperReportEN objvzx_PaperReportEN, int? intOkCount, string strComparisonOp="")
	{
objvzx_PaperReportEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.OkCount) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.OkCount, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.OkCount] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetVersionCount(this clsvzx_PaperReportEN objvzx_PaperReportEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_PaperReportEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.VersionCount) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.VersionCount, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.VersionCount] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetUpdUser(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_PaperReport.UpdUser);
}
objvzx_PaperReportEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.UpdUser) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.UpdUser, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.UpdUser] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetReportContent(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strReportContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportContent, 5000, convzx_PaperReport.ReportContent);
}
objvzx_PaperReportEN.ReportContent = strReportContent; //汇报内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.ReportContent) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.ReportContent, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.ReportContent] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetTextId(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, convzx_PaperReport.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, convzx_PaperReport.TextId);
}
objvzx_PaperReportEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.TextId) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.TextId, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.TextId] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetIsSubmit(this clsvzx_PaperReportEN objvzx_PaperReportEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_PaperReportEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.IsSubmit) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.IsSubmit, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.IsSubmit] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetReportUser(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strReportUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportUser, 500, convzx_PaperReport.ReportUser);
}
objvzx_PaperReportEN.ReportUser = strReportUser; //汇报用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.ReportUser) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.ReportUser, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.ReportUser] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetReportDate(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strReportDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportDate, 20, convzx_PaperReport.ReportDate);
}
objvzx_PaperReportEN.ReportDate = strReportDate; //汇报日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.ReportDate) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.ReportDate, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.ReportDate] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetPPTUrl(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strPPTUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPPTUrl, 500, convzx_PaperReport.PPTUrl);
}
objvzx_PaperReportEN.PPTUrl = strPPTUrl; //PPTUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.PPTUrl) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.PPTUrl, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.PPTUrl] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetMemo(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_PaperReport.Memo);
}
objvzx_PaperReportEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.Memo) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.Memo, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.Memo] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetMonth(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, convzx_PaperReport.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, convzx_PaperReport.Month);
}
objvzx_PaperReportEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.Month) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.Month, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.Month] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetWeek(this clsvzx_PaperReportEN objvzx_PaperReportEN, int? intWeek, string strComparisonOp="")
	{
objvzx_PaperReportEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.Week) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.Week, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.Week] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetYear(this clsvzx_PaperReportEN objvzx_PaperReportEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, convzx_PaperReport.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, convzx_PaperReport.Year);
}
objvzx_PaperReportEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.Year) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.Year, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.Year] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_PaperReportEN SetAppraiseCount(this clsvzx_PaperReportEN objvzx_PaperReportEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvzx_PaperReportEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_PaperReportEN.dicFldComparisonOp.ContainsKey(convzx_PaperReport.AppraiseCount) == false)
{
objvzx_PaperReportEN.dicFldComparisonOp.Add(convzx_PaperReport.AppraiseCount, strComparisonOp);
}
else
{
objvzx_PaperReportEN.dicFldComparisonOp[convzx_PaperReport.AppraiseCount] = strComparisonOp;
}
}
return objvzx_PaperReportEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_PaperReportENS">源对象</param>
 /// <param name = "objvzx_PaperReportENT">目标对象</param>
 public static void CopyTo(this clsvzx_PaperReportEN objvzx_PaperReportENS, clsvzx_PaperReportEN objvzx_PaperReportENT)
{
try
{
objvzx_PaperReportENT.TextTitle = objvzx_PaperReportENS.TextTitle; //TextTitle
objvzx_PaperReportENT.GroupTextName = objvzx_PaperReportENS.GroupTextName; //小组名称
objvzx_PaperReportENT.IdCurrEduCls = objvzx_PaperReportENS.IdCurrEduCls; //教学班流水号
objvzx_PaperReportENT.zxReportId = objvzx_PaperReportENS.zxReportId; //汇报Id
objvzx_PaperReportENT.GroupTextId = objvzx_PaperReportENS.GroupTextId; //小组Id
objvzx_PaperReportENT.UpdDate = objvzx_PaperReportENS.UpdDate; //修改日期
objvzx_PaperReportENT.PDFUrl = objvzx_PaperReportENS.PDFUrl; //PDFUrl
objvzx_PaperReportENT.TeaScore = objvzx_PaperReportENS.TeaScore; //教师评分
objvzx_PaperReportENT.StuScore = objvzx_PaperReportENS.StuScore; //学生平均分
objvzx_PaperReportENT.Score = objvzx_PaperReportENS.Score; //评分
objvzx_PaperReportENT.OkCount = objvzx_PaperReportENS.OkCount; //点赞统计
objvzx_PaperReportENT.VersionCount = objvzx_PaperReportENS.VersionCount; //版本统计
objvzx_PaperReportENT.UpdUser = objvzx_PaperReportENS.UpdUser; //修改人
objvzx_PaperReportENT.ReportContent = objvzx_PaperReportENS.ReportContent; //汇报内容
objvzx_PaperReportENT.TextId = objvzx_PaperReportENS.TextId; //课件Id
objvzx_PaperReportENT.IsSubmit = objvzx_PaperReportENS.IsSubmit; //是否提交
objvzx_PaperReportENT.ReportUser = objvzx_PaperReportENS.ReportUser; //汇报用户
objvzx_PaperReportENT.ReportDate = objvzx_PaperReportENS.ReportDate; //汇报日期
objvzx_PaperReportENT.PPTUrl = objvzx_PaperReportENS.PPTUrl; //PPTUrl
objvzx_PaperReportENT.Memo = objvzx_PaperReportENS.Memo; //备注
objvzx_PaperReportENT.Month = objvzx_PaperReportENS.Month; //月
objvzx_PaperReportENT.Week = objvzx_PaperReportENS.Week; //周
objvzx_PaperReportENT.Year = objvzx_PaperReportENS.Year; //年
objvzx_PaperReportENT.AppraiseCount = objvzx_PaperReportENS.AppraiseCount; //评论数
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
 /// <param name = "objvzx_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clsvzx_PaperReportEN:objvzx_PaperReportENT</returns>
 public static clsvzx_PaperReportEN CopyTo(this clsvzx_PaperReportEN objvzx_PaperReportENS)
{
try
{
 clsvzx_PaperReportEN objvzx_PaperReportENT = new clsvzx_PaperReportEN()
{
TextTitle = objvzx_PaperReportENS.TextTitle, //TextTitle
GroupTextName = objvzx_PaperReportENS.GroupTextName, //小组名称
IdCurrEduCls = objvzx_PaperReportENS.IdCurrEduCls, //教学班流水号
zxReportId = objvzx_PaperReportENS.zxReportId, //汇报Id
GroupTextId = objvzx_PaperReportENS.GroupTextId, //小组Id
UpdDate = objvzx_PaperReportENS.UpdDate, //修改日期
PDFUrl = objvzx_PaperReportENS.PDFUrl, //PDFUrl
TeaScore = objvzx_PaperReportENS.TeaScore, //教师评分
StuScore = objvzx_PaperReportENS.StuScore, //学生平均分
Score = objvzx_PaperReportENS.Score, //评分
OkCount = objvzx_PaperReportENS.OkCount, //点赞统计
VersionCount = objvzx_PaperReportENS.VersionCount, //版本统计
UpdUser = objvzx_PaperReportENS.UpdUser, //修改人
ReportContent = objvzx_PaperReportENS.ReportContent, //汇报内容
TextId = objvzx_PaperReportENS.TextId, //课件Id
IsSubmit = objvzx_PaperReportENS.IsSubmit, //是否提交
ReportUser = objvzx_PaperReportENS.ReportUser, //汇报用户
ReportDate = objvzx_PaperReportENS.ReportDate, //汇报日期
PPTUrl = objvzx_PaperReportENS.PPTUrl, //PPTUrl
Memo = objvzx_PaperReportENS.Memo, //备注
Month = objvzx_PaperReportENS.Month, //月
Week = objvzx_PaperReportENS.Week, //周
Year = objvzx_PaperReportENS.Year, //年
AppraiseCount = objvzx_PaperReportENS.AppraiseCount, //评论数
};
 return objvzx_PaperReportENT;
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
public static void CheckProperty4Condition(this clsvzx_PaperReportEN objvzx_PaperReportEN)
{
 clsvzx_PaperReportBL.vzx_PaperReportDA.CheckProperty4Condition(objvzx_PaperReportEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_PaperReportEN objvzx_PaperReportCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.TextTitle) == true)
{
string strComparisonOpTextTitle = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.TextTitle, objvzx_PaperReportCond.TextTitle, strComparisonOpTextTitle);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.GroupTextName, objvzx_PaperReportCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.IdCurrEduCls, objvzx_PaperReportCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.zxReportId) == true)
{
string strComparisonOpzxReportId = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.zxReportId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.zxReportId, objvzx_PaperReportCond.zxReportId, strComparisonOpzxReportId);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.GroupTextId, objvzx_PaperReportCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.UpdDate, objvzx_PaperReportCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.PDFUrl) == true)
{
string strComparisonOpPDFUrl = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.PDFUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.PDFUrl, objvzx_PaperReportCond.PDFUrl, strComparisonOpPDFUrl);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.TeaScore) == true)
{
string strComparisonOpTeaScore = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperReport.TeaScore, objvzx_PaperReportCond.TeaScore, strComparisonOpTeaScore);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.StuScore) == true)
{
string strComparisonOpStuScore = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperReport.StuScore, objvzx_PaperReportCond.StuScore, strComparisonOpStuScore);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.Score) == true)
{
string strComparisonOpScore = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperReport.Score, objvzx_PaperReportCond.Score, strComparisonOpScore);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.OkCount) == true)
{
string strComparisonOpOkCount = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperReport.OkCount, objvzx_PaperReportCond.OkCount, strComparisonOpOkCount);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperReport.VersionCount, objvzx_PaperReportCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.UpdUser, objvzx_PaperReportCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.ReportContent) == true)
{
string strComparisonOpReportContent = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.ReportContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.ReportContent, objvzx_PaperReportCond.ReportContent, strComparisonOpReportContent);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.TextId) == true)
{
string strComparisonOpTextId = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.TextId, objvzx_PaperReportCond.TextId, strComparisonOpTextId);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.IsSubmit) == true)
{
if (objvzx_PaperReportCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_PaperReport.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_PaperReport.IsSubmit);
}
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.ReportUser) == true)
{
string strComparisonOpReportUser = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.ReportUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.ReportUser, objvzx_PaperReportCond.ReportUser, strComparisonOpReportUser);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.ReportDate) == true)
{
string strComparisonOpReportDate = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.ReportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.ReportDate, objvzx_PaperReportCond.ReportDate, strComparisonOpReportDate);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.PPTUrl) == true)
{
string strComparisonOpPPTUrl = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.PPTUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.PPTUrl, objvzx_PaperReportCond.PPTUrl, strComparisonOpPPTUrl);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.Memo) == true)
{
string strComparisonOpMemo = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.Memo, objvzx_PaperReportCond.Memo, strComparisonOpMemo);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.Month) == true)
{
string strComparisonOpMonth = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.Month, objvzx_PaperReportCond.Month, strComparisonOpMonth);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.Week) == true)
{
string strComparisonOpWeek = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.Week];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperReport.Week, objvzx_PaperReportCond.Week, strComparisonOpWeek);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.Year) == true)
{
string strComparisonOpYear = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_PaperReport.Year, objvzx_PaperReportCond.Year, strComparisonOpYear);
}
if (objvzx_PaperReportCond.IsUpdated(convzx_PaperReport.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvzx_PaperReportCond.dicFldComparisonOp[convzx_PaperReport.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_PaperReport.AppraiseCount, objvzx_PaperReportCond.AppraiseCount, strComparisonOpAppraiseCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_PaperReport
{
public virtual bool UpdRelaTabDate(string strzxReportId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_PaperReport(vzx_PaperReport)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_PaperReportBL
{
public static RelatedActions_vzx_PaperReport relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_PaperReportDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_PaperReportDA vzx_PaperReportDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_PaperReportDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_PaperReportBL()
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
if (string.IsNullOrEmpty(clsvzx_PaperReportEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_PaperReportEN._ConnectString);
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
public static DataTable GetDataTable_vzx_PaperReport(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_PaperReportDA.GetDataTable_vzx_PaperReport(strWhereCond);
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
objDT = vzx_PaperReportDA.GetDataTable(strWhereCond);
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
objDT = vzx_PaperReportDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_PaperReportDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_PaperReportDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_PaperReportDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_PaperReportDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_PaperReportDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_PaperReportDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxReportIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_PaperReportEN> GetObjLstByZxReportIdLst(List<string> arrZxReportIdLst)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxReportIdLst, true);
 string strWhereCond = string.Format("zxReportId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxReportIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_PaperReportEN> GetObjLstByZxReportIdLstCache(List<string> arrZxReportIdLst)
{
string strKey = string.Format("{0}", clsvzx_PaperReportEN._CurrTabName);
List<clsvzx_PaperReportEN> arrvzx_PaperReportObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperReportEN> arrvzx_PaperReportObjLst_Sel =
arrvzx_PaperReportObjLstCache
.Where(x => arrZxReportIdLst.Contains(x.zxReportId));
return arrvzx_PaperReportObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperReportEN> GetObjLst(string strWhereCond)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
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
public static List<clsvzx_PaperReportEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_PaperReportCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_PaperReportEN> GetSubObjLstCache(clsvzx_PaperReportEN objvzx_PaperReportCond)
{
List<clsvzx_PaperReportEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperReportEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_PaperReport.AttributeName)
{
if (objvzx_PaperReportCond.IsUpdated(strFldName) == false) continue;
if (objvzx_PaperReportCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperReportCond[strFldName].ToString());
}
else
{
if (objvzx_PaperReportCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_PaperReportCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperReportCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_PaperReportCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_PaperReportCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_PaperReportCond[strFldName]));
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
public static List<clsvzx_PaperReportEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
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
public static List<clsvzx_PaperReportEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
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
List<clsvzx_PaperReportEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_PaperReportEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperReportEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_PaperReportEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
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
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
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
public static List<clsvzx_PaperReportEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_PaperReportEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_PaperReportEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
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
public static List<clsvzx_PaperReportEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_PaperReportEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_PaperReportEN> arrObjLst = new List<clsvzx_PaperReportEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_PaperReportEN objvzx_PaperReportEN = new clsvzx_PaperReportEN();
try
{
objvzx_PaperReportEN.TextTitle = objRow[convzx_PaperReport.TextTitle] == DBNull.Value ? null : objRow[convzx_PaperReport.TextTitle].ToString().Trim(); //TextTitle
objvzx_PaperReportEN.GroupTextName = objRow[convzx_PaperReport.GroupTextName] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextName].ToString().Trim(); //小组名称
objvzx_PaperReportEN.IdCurrEduCls = objRow[convzx_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_PaperReportEN.zxReportId = objRow[convzx_PaperReport.zxReportId].ToString().Trim(); //汇报Id
objvzx_PaperReportEN.GroupTextId = objRow[convzx_PaperReport.GroupTextId] == DBNull.Value ? null : objRow[convzx_PaperReport.GroupTextId].ToString().Trim(); //小组Id
objvzx_PaperReportEN.UpdDate = objRow[convzx_PaperReport.UpdDate] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdDate].ToString().Trim(); //修改日期
objvzx_PaperReportEN.PDFUrl = objRow[convzx_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objvzx_PaperReportEN.TeaScore = objRow[convzx_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.TeaScore].ToString().Trim()); //教师评分
objvzx_PaperReportEN.StuScore = objRow[convzx_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.StuScore].ToString().Trim()); //学生平均分
objvzx_PaperReportEN.Score = objRow[convzx_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_PaperReport.Score].ToString().Trim()); //评分
objvzx_PaperReportEN.OkCount = objRow[convzx_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.OkCount].ToString().Trim()); //点赞统计
objvzx_PaperReportEN.VersionCount = objRow[convzx_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.VersionCount].ToString().Trim()); //版本统计
objvzx_PaperReportEN.UpdUser = objRow[convzx_PaperReport.UpdUser] == DBNull.Value ? null : objRow[convzx_PaperReport.UpdUser].ToString().Trim(); //修改人
objvzx_PaperReportEN.ReportContent = objRow[convzx_PaperReport.ReportContent] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objvzx_PaperReportEN.TextId = objRow[convzx_PaperReport.TextId] == DBNull.Value ? null : objRow[convzx_PaperReport.TextId].ToString().Trim(); //课件Id
objvzx_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objvzx_PaperReportEN.ReportUser = objRow[convzx_PaperReport.ReportUser] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objvzx_PaperReportEN.ReportDate = objRow[convzx_PaperReport.ReportDate] == DBNull.Value ? null : objRow[convzx_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objvzx_PaperReportEN.PPTUrl = objRow[convzx_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[convzx_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objvzx_PaperReportEN.Memo = objRow[convzx_PaperReport.Memo] == DBNull.Value ? null : objRow[convzx_PaperReport.Memo].ToString().Trim(); //备注
objvzx_PaperReportEN.Month = objRow[convzx_PaperReport.Month] == DBNull.Value ? null : objRow[convzx_PaperReport.Month].ToString().Trim(); //月
objvzx_PaperReportEN.Week = objRow[convzx_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.Week].ToString().Trim()); //周
objvzx_PaperReportEN.Year = objRow[convzx_PaperReport.Year] == DBNull.Value ? null : objRow[convzx_PaperReport.Year].ToString().Trim(); //年
objvzx_PaperReportEN.AppraiseCount = objRow[convzx_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_PaperReport.AppraiseCount].ToString().Trim()); //评论数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_PaperReportEN.zxReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_PaperReportEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_PaperReportEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_PaperReport(ref clsvzx_PaperReportEN objvzx_PaperReportEN)
{
bool bolResult = vzx_PaperReportDA.Getvzx_PaperReport(ref objvzx_PaperReportEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxReportId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_PaperReportEN GetObjByzxReportId(string strzxReportId)
{
if (strzxReportId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxReportId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxReportId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxReportId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_PaperReportEN objvzx_PaperReportEN = vzx_PaperReportDA.GetObjByzxReportId(strzxReportId);
return objvzx_PaperReportEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_PaperReportEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_PaperReportEN objvzx_PaperReportEN = vzx_PaperReportDA.GetFirstObj(strWhereCond);
 return objvzx_PaperReportEN;
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
public static clsvzx_PaperReportEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_PaperReportEN objvzx_PaperReportEN = vzx_PaperReportDA.GetObjByDataRow(objRow);
 return objvzx_PaperReportEN;
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
public static clsvzx_PaperReportEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_PaperReportEN objvzx_PaperReportEN = vzx_PaperReportDA.GetObjByDataRow(objRow);
 return objvzx_PaperReportEN;
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
 /// <param name = "strzxReportId">所给的关键字</param>
 /// <param name = "lstvzx_PaperReportObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_PaperReportEN GetObjByzxReportIdFromList(string strzxReportId, List<clsvzx_PaperReportEN> lstvzx_PaperReportObjLst)
{
foreach (clsvzx_PaperReportEN objvzx_PaperReportEN in lstvzx_PaperReportObjLst)
{
if (objvzx_PaperReportEN.zxReportId == strzxReportId)
{
return objvzx_PaperReportEN;
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
 string strMaxZxReportId;
 try
 {
 strMaxZxReportId = clsvzx_PaperReportDA.GetMaxStrId();
 return strMaxZxReportId;
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
 string strzxReportId;
 try
 {
 strzxReportId = new clsvzx_PaperReportDA().GetFirstID(strWhereCond);
 return strzxReportId;
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
 arrList = vzx_PaperReportDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_PaperReportDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxReportId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxReportId)
{
if (string.IsNullOrEmpty(strzxReportId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxReportId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_PaperReportDA.IsExist(strzxReportId);
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
 bolIsExist = clsvzx_PaperReportDA.IsExistTable();
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
 bolIsExist = vzx_PaperReportDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_PaperReportENS">源对象</param>
 /// <param name = "objvzx_PaperReportENT">目标对象</param>
 public static void CopyTo(clsvzx_PaperReportEN objvzx_PaperReportENS, clsvzx_PaperReportEN objvzx_PaperReportENT)
{
try
{
objvzx_PaperReportENT.TextTitle = objvzx_PaperReportENS.TextTitle; //TextTitle
objvzx_PaperReportENT.GroupTextName = objvzx_PaperReportENS.GroupTextName; //小组名称
objvzx_PaperReportENT.IdCurrEduCls = objvzx_PaperReportENS.IdCurrEduCls; //教学班流水号
objvzx_PaperReportENT.zxReportId = objvzx_PaperReportENS.zxReportId; //汇报Id
objvzx_PaperReportENT.GroupTextId = objvzx_PaperReportENS.GroupTextId; //小组Id
objvzx_PaperReportENT.UpdDate = objvzx_PaperReportENS.UpdDate; //修改日期
objvzx_PaperReportENT.PDFUrl = objvzx_PaperReportENS.PDFUrl; //PDFUrl
objvzx_PaperReportENT.TeaScore = objvzx_PaperReportENS.TeaScore; //教师评分
objvzx_PaperReportENT.StuScore = objvzx_PaperReportENS.StuScore; //学生平均分
objvzx_PaperReportENT.Score = objvzx_PaperReportENS.Score; //评分
objvzx_PaperReportENT.OkCount = objvzx_PaperReportENS.OkCount; //点赞统计
objvzx_PaperReportENT.VersionCount = objvzx_PaperReportENS.VersionCount; //版本统计
objvzx_PaperReportENT.UpdUser = objvzx_PaperReportENS.UpdUser; //修改人
objvzx_PaperReportENT.ReportContent = objvzx_PaperReportENS.ReportContent; //汇报内容
objvzx_PaperReportENT.TextId = objvzx_PaperReportENS.TextId; //课件Id
objvzx_PaperReportENT.IsSubmit = objvzx_PaperReportENS.IsSubmit; //是否提交
objvzx_PaperReportENT.ReportUser = objvzx_PaperReportENS.ReportUser; //汇报用户
objvzx_PaperReportENT.ReportDate = objvzx_PaperReportENS.ReportDate; //汇报日期
objvzx_PaperReportENT.PPTUrl = objvzx_PaperReportENS.PPTUrl; //PPTUrl
objvzx_PaperReportENT.Memo = objvzx_PaperReportENS.Memo; //备注
objvzx_PaperReportENT.Month = objvzx_PaperReportENS.Month; //月
objvzx_PaperReportENT.Week = objvzx_PaperReportENS.Week; //周
objvzx_PaperReportENT.Year = objvzx_PaperReportENS.Year; //年
objvzx_PaperReportENT.AppraiseCount = objvzx_PaperReportENS.AppraiseCount; //评论数
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
 /// <param name = "objvzx_PaperReportEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_PaperReportEN objvzx_PaperReportEN)
{
try
{
objvzx_PaperReportEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_PaperReportEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_PaperReport.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.TextTitle = objvzx_PaperReportEN.TextTitle == "[null]" ? null :  objvzx_PaperReportEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(convzx_PaperReport.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.GroupTextName = objvzx_PaperReportEN.GroupTextName == "[null]" ? null :  objvzx_PaperReportEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_PaperReport.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.IdCurrEduCls = objvzx_PaperReportEN.IdCurrEduCls == "[null]" ? null :  objvzx_PaperReportEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_PaperReport.zxReportId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.zxReportId = objvzx_PaperReportEN.zxReportId; //汇报Id
}
if (arrFldSet.Contains(convzx_PaperReport.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.GroupTextId = objvzx_PaperReportEN.GroupTextId == "[null]" ? null :  objvzx_PaperReportEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_PaperReport.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.UpdDate = objvzx_PaperReportEN.UpdDate == "[null]" ? null :  objvzx_PaperReportEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_PaperReport.PDFUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.PDFUrl = objvzx_PaperReportEN.PDFUrl == "[null]" ? null :  objvzx_PaperReportEN.PDFUrl; //PDFUrl
}
if (arrFldSet.Contains(convzx_PaperReport.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.TeaScore = objvzx_PaperReportEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convzx_PaperReport.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.StuScore = objvzx_PaperReportEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convzx_PaperReport.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.Score = objvzx_PaperReportEN.Score; //评分
}
if (arrFldSet.Contains(convzx_PaperReport.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.OkCount = objvzx_PaperReportEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convzx_PaperReport.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.VersionCount = objvzx_PaperReportEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_PaperReport.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.UpdUser = objvzx_PaperReportEN.UpdUser == "[null]" ? null :  objvzx_PaperReportEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_PaperReport.ReportContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.ReportContent = objvzx_PaperReportEN.ReportContent == "[null]" ? null :  objvzx_PaperReportEN.ReportContent; //汇报内容
}
if (arrFldSet.Contains(convzx_PaperReport.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.TextId = objvzx_PaperReportEN.TextId == "[null]" ? null :  objvzx_PaperReportEN.TextId; //课件Id
}
if (arrFldSet.Contains(convzx_PaperReport.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.IsSubmit = objvzx_PaperReportEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_PaperReport.ReportUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.ReportUser = objvzx_PaperReportEN.ReportUser == "[null]" ? null :  objvzx_PaperReportEN.ReportUser; //汇报用户
}
if (arrFldSet.Contains(convzx_PaperReport.ReportDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.ReportDate = objvzx_PaperReportEN.ReportDate == "[null]" ? null :  objvzx_PaperReportEN.ReportDate; //汇报日期
}
if (arrFldSet.Contains(convzx_PaperReport.PPTUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.PPTUrl = objvzx_PaperReportEN.PPTUrl == "[null]" ? null :  objvzx_PaperReportEN.PPTUrl; //PPTUrl
}
if (arrFldSet.Contains(convzx_PaperReport.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.Memo = objvzx_PaperReportEN.Memo == "[null]" ? null :  objvzx_PaperReportEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_PaperReport.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.Month = objvzx_PaperReportEN.Month == "[null]" ? null :  objvzx_PaperReportEN.Month; //月
}
if (arrFldSet.Contains(convzx_PaperReport.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.Week = objvzx_PaperReportEN.Week; //周
}
if (arrFldSet.Contains(convzx_PaperReport.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.Year = objvzx_PaperReportEN.Year == "[null]" ? null :  objvzx_PaperReportEN.Year; //年
}
if (arrFldSet.Contains(convzx_PaperReport.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_PaperReportEN.AppraiseCount = objvzx_PaperReportEN.AppraiseCount; //评论数
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
 /// <param name = "objvzx_PaperReportEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_PaperReportEN objvzx_PaperReportEN)
{
try
{
if (objvzx_PaperReportEN.TextTitle == "[null]") objvzx_PaperReportEN.TextTitle = null; //TextTitle
if (objvzx_PaperReportEN.GroupTextName == "[null]") objvzx_PaperReportEN.GroupTextName = null; //小组名称
if (objvzx_PaperReportEN.IdCurrEduCls == "[null]") objvzx_PaperReportEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_PaperReportEN.GroupTextId == "[null]") objvzx_PaperReportEN.GroupTextId = null; //小组Id
if (objvzx_PaperReportEN.UpdDate == "[null]") objvzx_PaperReportEN.UpdDate = null; //修改日期
if (objvzx_PaperReportEN.PDFUrl == "[null]") objvzx_PaperReportEN.PDFUrl = null; //PDFUrl
if (objvzx_PaperReportEN.UpdUser == "[null]") objvzx_PaperReportEN.UpdUser = null; //修改人
if (objvzx_PaperReportEN.ReportContent == "[null]") objvzx_PaperReportEN.ReportContent = null; //汇报内容
if (objvzx_PaperReportEN.TextId == "[null]") objvzx_PaperReportEN.TextId = null; //课件Id
if (objvzx_PaperReportEN.ReportUser == "[null]") objvzx_PaperReportEN.ReportUser = null; //汇报用户
if (objvzx_PaperReportEN.ReportDate == "[null]") objvzx_PaperReportEN.ReportDate = null; //汇报日期
if (objvzx_PaperReportEN.PPTUrl == "[null]") objvzx_PaperReportEN.PPTUrl = null; //PPTUrl
if (objvzx_PaperReportEN.Memo == "[null]") objvzx_PaperReportEN.Memo = null; //备注
if (objvzx_PaperReportEN.Month == "[null]") objvzx_PaperReportEN.Month = null; //月
if (objvzx_PaperReportEN.Year == "[null]") objvzx_PaperReportEN.Year = null; //年
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
public static void CheckProperty4Condition(clsvzx_PaperReportEN objvzx_PaperReportEN)
{
 vzx_PaperReportDA.CheckProperty4Condition(objvzx_PaperReportEN);
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
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_GroupTextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextBL没有刷新缓存机制(clszx_GroupTextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_PaperReportBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_PaperReportBL没有刷新缓存机制(clszx_PaperReportBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxReportId");
//if (arrvzx_PaperReportObjLstCache == null)
//{
//arrvzx_PaperReportObjLstCache = vzx_PaperReportDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxReportId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_PaperReportEN GetObjByzxReportIdCache(string strzxReportId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_PaperReportEN._CurrTabName);
List<clsvzx_PaperReportEN> arrvzx_PaperReportObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperReportEN> arrvzx_PaperReportObjLst_Sel =
arrvzx_PaperReportObjLstCache
.Where(x=> x.zxReportId == strzxReportId 
);
if (arrvzx_PaperReportObjLst_Sel.Count() == 0)
{
   clsvzx_PaperReportEN obj = clsvzx_PaperReportBL.GetObjByzxReportId(strzxReportId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_PaperReportObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_PaperReportEN> GetAllvzx_PaperReportObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_PaperReportEN> arrvzx_PaperReportObjLstCache = GetObjLstCache(); 
return arrvzx_PaperReportObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_PaperReportEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_PaperReportEN._CurrTabName);
List<clsvzx_PaperReportEN> arrvzx_PaperReportObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_PaperReportObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_PaperReportEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxReportId)
{
if (strInFldName != convzx_PaperReport.zxReportId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_PaperReport.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_PaperReport.AttributeName));
throw new Exception(strMsg);
}
var objvzx_PaperReport = clsvzx_PaperReportBL.GetObjByzxReportIdCache(strzxReportId);
if (objvzx_PaperReport == null) return "";
return objvzx_PaperReport[strOutFldName].ToString();
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
int intRecCount = clsvzx_PaperReportDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_PaperReportDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_PaperReportDA.GetRecCount();
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
int intRecCount = clsvzx_PaperReportDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_PaperReportCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_PaperReportEN objvzx_PaperReportCond)
{
List<clsvzx_PaperReportEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_PaperReportEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_PaperReport.AttributeName)
{
if (objvzx_PaperReportCond.IsUpdated(strFldName) == false) continue;
if (objvzx_PaperReportCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperReportCond[strFldName].ToString());
}
else
{
if (objvzx_PaperReportCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_PaperReportCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_PaperReportCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_PaperReportCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_PaperReportCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_PaperReportCond[strFldName]));
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
 List<string> arrList = clsvzx_PaperReportDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_PaperReportDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_PaperReportDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}