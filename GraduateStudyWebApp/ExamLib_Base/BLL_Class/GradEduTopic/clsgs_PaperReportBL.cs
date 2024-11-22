
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperReportBL
 表名:gs_PaperReport(01120772)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsgs_PaperReportBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strReportId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperReportEN GetObj(this K_ReportId_gs_PaperReport myKey)
{
clsgs_PaperReportEN objgs_PaperReportEN = clsgs_PaperReportBL.gs_PaperReportDA.GetObjByReportId(myKey.Value);
return objgs_PaperReportEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_PaperReportEN objgs_PaperReportEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperReportEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],汇报用户 = [{1}],汇报日期 = [{2}]的数据已经存在!(in clsgs_PaperReportBL.AddNewRecord)", objgs_PaperReportEN.TopicId,objgs_PaperReportEN.ReportUser,objgs_PaperReportEN.ReportDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true || clsgs_PaperReportBL.IsExist(objgs_PaperReportEN.ReportId) == true)
 {
     objgs_PaperReportEN.ReportId = clsgs_PaperReportBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_PaperReportBL.gs_PaperReportDA.AddNewRecordBySQL2(objgs_PaperReportEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsgs_PaperReportEN objgs_PaperReportEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_PaperReportBL.IsExist(objgs_PaperReportEN.ReportId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_PaperReportEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_PaperReportEN.CheckUniqueness() == false)
{
strMsg = string.Format("(主题Id(TopicId)=[{0}],汇报用户(ReportUser)=[{1}],汇报日期(ReportDate)=[{2}])已经存在,不能重复!", objgs_PaperReportEN.TopicId, objgs_PaperReportEN.ReportUser, objgs_PaperReportEN.ReportDate);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true || clsgs_PaperReportBL.IsExist(objgs_PaperReportEN.ReportId) == true)
 {
     objgs_PaperReportEN.ReportId = clsgs_PaperReportBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_PaperReportEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_PaperReportEN objgs_PaperReportEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperReportEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],汇报用户 = [{1}],汇报日期 = [{2}]的数据已经存在!(in clsgs_PaperReportBL.AddNewRecordWithMaxId)", objgs_PaperReportEN.TopicId,objgs_PaperReportEN.ReportUser,objgs_PaperReportEN.ReportDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true || clsgs_PaperReportBL.IsExist(objgs_PaperReportEN.ReportId) == true)
 {
     objgs_PaperReportEN.ReportId = clsgs_PaperReportBL.GetMaxStrId_S();
 }
string strReportId = clsgs_PaperReportBL.gs_PaperReportDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperReportEN);
     objgs_PaperReportEN.ReportId = strReportId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return strReportId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_PaperReportEN objgs_PaperReportEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperReportEN) == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],汇报用户 = [{1}],汇报日期 = [{2}]的数据已经存在!(in clsgs_PaperReportBL.AddNewRecordWithReturnKey)", objgs_PaperReportEN.TopicId,objgs_PaperReportEN.ReportUser,objgs_PaperReportEN.ReportDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true || clsgs_PaperReportBL.IsExist(objgs_PaperReportEN.ReportId) == true)
 {
     objgs_PaperReportEN.ReportId = clsgs_PaperReportBL.GetMaxStrId_S();
 }
string strKey = clsgs_PaperReportBL.gs_PaperReportDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperReportEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetReportId(this clsgs_PaperReportEN objgs_PaperReportEN, string strReportId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportId, 10, congs_PaperReport.ReportId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReportId, 10, congs_PaperReport.ReportId);
}
objgs_PaperReportEN.ReportId = strReportId; //汇报Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.ReportId) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.ReportId, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.ReportId] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetTopicId(this clsgs_PaperReportEN objgs_PaperReportEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_PaperReport.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_PaperReport.TopicId);
}
objgs_PaperReportEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.TopicId) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.TopicId, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.TopicId] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetPaperId(this clsgs_PaperReportEN objgs_PaperReportEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_PaperReport.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_PaperReport.PaperId);
}
objgs_PaperReportEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.PaperId) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.PaperId, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.PaperId] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetReportContent(this clsgs_PaperReportEN objgs_PaperReportEN, string strReportContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportContent, 5000, congs_PaperReport.ReportContent);
}
objgs_PaperReportEN.ReportContent = strReportContent; //汇报内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.ReportContent) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.ReportContent, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.ReportContent] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetIsSubmit(this clsgs_PaperReportEN objgs_PaperReportEN, bool bolIsSubmit, string strComparisonOp="")
	{
objgs_PaperReportEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.IsSubmit) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.IsSubmit, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.IsSubmit] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetReportUser(this clsgs_PaperReportEN objgs_PaperReportEN, string strReportUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportUser, 500, congs_PaperReport.ReportUser);
}
objgs_PaperReportEN.ReportUser = strReportUser; //汇报用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.ReportUser) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.ReportUser, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.ReportUser] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetReportDate(this clsgs_PaperReportEN objgs_PaperReportEN, string strReportDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReportDate, 20, congs_PaperReport.ReportDate);
}
objgs_PaperReportEN.ReportDate = strReportDate; //汇报日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.ReportDate) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.ReportDate, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.ReportDate] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetVersionCount(this clsgs_PaperReportEN objgs_PaperReportEN, int? intVersionCount, string strComparisonOp="")
	{
objgs_PaperReportEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.VersionCount) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.VersionCount, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.VersionCount] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetOkCount(this clsgs_PaperReportEN objgs_PaperReportEN, int? intOkCount, string strComparisonOp="")
	{
objgs_PaperReportEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.OkCount) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.OkCount, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.OkCount] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetAppraiseCount(this clsgs_PaperReportEN objgs_PaperReportEN, int? intAppraiseCount, string strComparisonOp="")
	{
objgs_PaperReportEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.AppraiseCount) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.AppraiseCount, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.AppraiseCount] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetScore(this clsgs_PaperReportEN objgs_PaperReportEN, float? fltScore, string strComparisonOp="")
	{
objgs_PaperReportEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.Score) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.Score, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.Score] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetStuScore(this clsgs_PaperReportEN objgs_PaperReportEN, float? fltStuScore, string strComparisonOp="")
	{
objgs_PaperReportEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.StuScore) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.StuScore, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.StuScore] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetTeaScore(this clsgs_PaperReportEN objgs_PaperReportEN, float? fltTeaScore, string strComparisonOp="")
	{
objgs_PaperReportEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.TeaScore) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.TeaScore, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.TeaScore] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetPDFUrl(this clsgs_PaperReportEN objgs_PaperReportEN, string strPDFUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPDFUrl, 500, congs_PaperReport.PDFUrl);
}
objgs_PaperReportEN.PDFUrl = strPDFUrl; //PDFUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.PDFUrl) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.PDFUrl, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.PDFUrl] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetPPTUrl(this clsgs_PaperReportEN objgs_PaperReportEN, string strPPTUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPPTUrl, 500, congs_PaperReport.PPTUrl);
}
objgs_PaperReportEN.PPTUrl = strPPTUrl; //PPTUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.PPTUrl) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.PPTUrl, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.PPTUrl] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetMonth(this clsgs_PaperReportEN objgs_PaperReportEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, congs_PaperReport.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, congs_PaperReport.Month);
}
objgs_PaperReportEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.Month) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.Month, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.Month] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetWeek(this clsgs_PaperReportEN objgs_PaperReportEN, int? intWeek, string strComparisonOp="")
	{
objgs_PaperReportEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.Week) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.Week, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.Week] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetYear(this clsgs_PaperReportEN objgs_PaperReportEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, congs_PaperReport.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, congs_PaperReport.Year);
}
objgs_PaperReportEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.Year) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.Year, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.Year] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetIdCurrEduCls(this clsgs_PaperReportEN objgs_PaperReportEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_PaperReport.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_PaperReport.IdCurrEduCls);
}
objgs_PaperReportEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.IdCurrEduCls) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetUpdUser(this clsgs_PaperReportEN objgs_PaperReportEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_PaperReport.UpdUser);
}
objgs_PaperReportEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.UpdUser) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.UpdUser, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.UpdUser] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetUpdDate(this clsgs_PaperReportEN objgs_PaperReportEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_PaperReport.UpdDate);
}
objgs_PaperReportEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.UpdDate) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.UpdDate, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.UpdDate] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperReportEN SetMemo(this clsgs_PaperReportEN objgs_PaperReportEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_PaperReport.Memo);
}
objgs_PaperReportEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperReportEN.dicFldComparisonOp.ContainsKey(congs_PaperReport.Memo) == false)
{
objgs_PaperReportEN.dicFldComparisonOp.Add(congs_PaperReport.Memo, strComparisonOp);
}
else
{
objgs_PaperReportEN.dicFldComparisonOp[congs_PaperReport.Memo] = strComparisonOp;
}
}
return objgs_PaperReportEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_PaperReportEN objgs_PaperReportEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_PaperReportEN.CheckPropertyNew();
clsgs_PaperReportEN objgs_PaperReportCond = new clsgs_PaperReportEN();
string strCondition = objgs_PaperReportCond
.SetReportId(objgs_PaperReportEN.ReportId, "<>")
.SetTopicId(objgs_PaperReportEN.TopicId, "=")
.SetReportUser(objgs_PaperReportEN.ReportUser, "=")
.SetReportDate(objgs_PaperReportEN.ReportDate, "=")
.GetCombineCondition();
objgs_PaperReportEN._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperReportBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TopicId_ReportUser_ReportDate)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_PaperReportEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objgs_PaperReport">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_PaperReportEN objgs_PaperReport)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_PaperReportEN objgs_PaperReportCond = new clsgs_PaperReportEN();
string strCondition = objgs_PaperReportCond
.SetTopicId(objgs_PaperReport.TopicId, "=")
.SetReportUser(objgs_PaperReport.ReportUser, "=")
.SetReportDate(objgs_PaperReport.ReportDate, "=")
.GetCombineCondition();
objgs_PaperReport._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperReportBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_PaperReport.ReportId = clsgs_PaperReportBL.GetFirstID_S(strCondition);
objgs_PaperReport.UpdateWithCondition(strCondition);
}
else
{
objgs_PaperReport.ReportId = clsgs_PaperReportBL.GetMaxStrId_S();
objgs_PaperReport.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperReportEN objgs_PaperReportEN)
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperReportBL.gs_PaperReportDA.UpdateBySql2(objgs_PaperReportEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperReportEN objgs_PaperReportEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperReportBL.gs_PaperReportDA.UpdateBySql2(objgs_PaperReportEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperReportEN objgs_PaperReportEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_PaperReportBL.gs_PaperReportDA.UpdateBySqlWithCondition(objgs_PaperReportEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperReportEN objgs_PaperReportEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_PaperReportBL.gs_PaperReportDA.UpdateBySqlWithConditionTransaction(objgs_PaperReportEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "strReportId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_PaperReportEN objgs_PaperReportEN)
{
try
{
int intRecNum = clsgs_PaperReportBL.gs_PaperReportDA.DelRecord(objgs_PaperReportEN.ReportId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objgs_PaperReportENS">源对象</param>
 /// <param name = "objgs_PaperReportENT">目标对象</param>
 public static void CopyTo(this clsgs_PaperReportEN objgs_PaperReportENS, clsgs_PaperReportEN objgs_PaperReportENT)
{
try
{
objgs_PaperReportENT.ReportId = objgs_PaperReportENS.ReportId; //汇报Id
objgs_PaperReportENT.TopicId = objgs_PaperReportENS.TopicId; //主题Id
objgs_PaperReportENT.PaperId = objgs_PaperReportENS.PaperId; //论文Id
objgs_PaperReportENT.ReportContent = objgs_PaperReportENS.ReportContent; //汇报内容
objgs_PaperReportENT.IsSubmit = objgs_PaperReportENS.IsSubmit; //是否提交
objgs_PaperReportENT.ReportUser = objgs_PaperReportENS.ReportUser; //汇报用户
objgs_PaperReportENT.ReportDate = objgs_PaperReportENS.ReportDate; //汇报日期
objgs_PaperReportENT.VersionCount = objgs_PaperReportENS.VersionCount; //版本统计
objgs_PaperReportENT.OkCount = objgs_PaperReportENS.OkCount; //点赞统计
objgs_PaperReportENT.AppraiseCount = objgs_PaperReportENS.AppraiseCount; //评论数
objgs_PaperReportENT.Score = objgs_PaperReportENS.Score; //评分
objgs_PaperReportENT.StuScore = objgs_PaperReportENS.StuScore; //学生平均分
objgs_PaperReportENT.TeaScore = objgs_PaperReportENS.TeaScore; //教师评分
objgs_PaperReportENT.PDFUrl = objgs_PaperReportENS.PDFUrl; //PDFUrl
objgs_PaperReportENT.PPTUrl = objgs_PaperReportENS.PPTUrl; //PPTUrl
objgs_PaperReportENT.Month = objgs_PaperReportENS.Month; //月
objgs_PaperReportENT.Week = objgs_PaperReportENS.Week; //周
objgs_PaperReportENT.Year = objgs_PaperReportENS.Year; //年
objgs_PaperReportENT.IdCurrEduCls = objgs_PaperReportENS.IdCurrEduCls; //教学班流水号
objgs_PaperReportENT.UpdUser = objgs_PaperReportENS.UpdUser; //修改人
objgs_PaperReportENT.UpdDate = objgs_PaperReportENS.UpdDate; //修改日期
objgs_PaperReportENT.Memo = objgs_PaperReportENS.Memo; //备注
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
 /// <param name = "objgs_PaperReportENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperReportEN:objgs_PaperReportENT</returns>
 public static clsgs_PaperReportEN CopyTo(this clsgs_PaperReportEN objgs_PaperReportENS)
{
try
{
 clsgs_PaperReportEN objgs_PaperReportENT = new clsgs_PaperReportEN()
{
ReportId = objgs_PaperReportENS.ReportId, //汇报Id
TopicId = objgs_PaperReportENS.TopicId, //主题Id
PaperId = objgs_PaperReportENS.PaperId, //论文Id
ReportContent = objgs_PaperReportENS.ReportContent, //汇报内容
IsSubmit = objgs_PaperReportENS.IsSubmit, //是否提交
ReportUser = objgs_PaperReportENS.ReportUser, //汇报用户
ReportDate = objgs_PaperReportENS.ReportDate, //汇报日期
VersionCount = objgs_PaperReportENS.VersionCount, //版本统计
OkCount = objgs_PaperReportENS.OkCount, //点赞统计
AppraiseCount = objgs_PaperReportENS.AppraiseCount, //评论数
Score = objgs_PaperReportENS.Score, //评分
StuScore = objgs_PaperReportENS.StuScore, //学生平均分
TeaScore = objgs_PaperReportENS.TeaScore, //教师评分
PDFUrl = objgs_PaperReportENS.PDFUrl, //PDFUrl
PPTUrl = objgs_PaperReportENS.PPTUrl, //PPTUrl
Month = objgs_PaperReportENS.Month, //月
Week = objgs_PaperReportENS.Week, //周
Year = objgs_PaperReportENS.Year, //年
IdCurrEduCls = objgs_PaperReportENS.IdCurrEduCls, //教学班流水号
UpdUser = objgs_PaperReportENS.UpdUser, //修改人
UpdDate = objgs_PaperReportENS.UpdDate, //修改日期
Memo = objgs_PaperReportENS.Memo, //备注
};
 return objgs_PaperReportENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsgs_PaperReportEN objgs_PaperReportEN)
{
 clsgs_PaperReportBL.gs_PaperReportDA.CheckPropertyNew(objgs_PaperReportEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_PaperReportEN objgs_PaperReportEN)
{
 clsgs_PaperReportBL.gs_PaperReportDA.CheckProperty4Condition(objgs_PaperReportEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_PaperReportEN objgs_PaperReportCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.ReportId) == true)
{
string strComparisonOpReportId = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.ReportId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.ReportId, objgs_PaperReportCond.ReportId, strComparisonOpReportId);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.TopicId) == true)
{
string strComparisonOpTopicId = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.TopicId, objgs_PaperReportCond.TopicId, strComparisonOpTopicId);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.PaperId) == true)
{
string strComparisonOpPaperId = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.PaperId, objgs_PaperReportCond.PaperId, strComparisonOpPaperId);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.ReportContent) == true)
{
string strComparisonOpReportContent = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.ReportContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.ReportContent, objgs_PaperReportCond.ReportContent, strComparisonOpReportContent);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.IsSubmit) == true)
{
if (objgs_PaperReportCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_PaperReport.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_PaperReport.IsSubmit);
}
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.ReportUser) == true)
{
string strComparisonOpReportUser = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.ReportUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.ReportUser, objgs_PaperReportCond.ReportUser, strComparisonOpReportUser);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.ReportDate) == true)
{
string strComparisonOpReportDate = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.ReportDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.ReportDate, objgs_PaperReportCond.ReportDate, strComparisonOpReportDate);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.VersionCount) == true)
{
string strComparisonOpVersionCount = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperReport.VersionCount, objgs_PaperReportCond.VersionCount, strComparisonOpVersionCount);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.OkCount) == true)
{
string strComparisonOpOkCount = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperReport.OkCount, objgs_PaperReportCond.OkCount, strComparisonOpOkCount);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperReport.AppraiseCount, objgs_PaperReportCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.Score) == true)
{
string strComparisonOpScore = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.Score];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperReport.Score, objgs_PaperReportCond.Score, strComparisonOpScore);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.StuScore) == true)
{
string strComparisonOpStuScore = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperReport.StuScore, objgs_PaperReportCond.StuScore, strComparisonOpStuScore);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.TeaScore) == true)
{
string strComparisonOpTeaScore = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperReport.TeaScore, objgs_PaperReportCond.TeaScore, strComparisonOpTeaScore);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.PDFUrl) == true)
{
string strComparisonOpPDFUrl = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.PDFUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.PDFUrl, objgs_PaperReportCond.PDFUrl, strComparisonOpPDFUrl);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.PPTUrl) == true)
{
string strComparisonOpPPTUrl = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.PPTUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.PPTUrl, objgs_PaperReportCond.PPTUrl, strComparisonOpPPTUrl);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.Month) == true)
{
string strComparisonOpMonth = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.Month, objgs_PaperReportCond.Month, strComparisonOpMonth);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.Week) == true)
{
string strComparisonOpWeek = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.Week];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperReport.Week, objgs_PaperReportCond.Week, strComparisonOpWeek);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.Year) == true)
{
string strComparisonOpYear = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.Year, objgs_PaperReportCond.Year, strComparisonOpYear);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.IdCurrEduCls, objgs_PaperReportCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.UpdUser, objgs_PaperReportCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.UpdDate, objgs_PaperReportCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_PaperReportCond.IsUpdated(congs_PaperReport.Memo) == true)
{
string strComparisonOpMemo = objgs_PaperReportCond.dicFldComparisonOp[congs_PaperReport.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperReport.Memo, objgs_PaperReportCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_PaperReport(论文汇报表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TopicId_ReportUser_ReportDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_PaperReportEN objgs_PaperReportEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperReportEN == null) return true;
if (objgs_PaperReportEN.ReportId == null || objgs_PaperReportEN.ReportId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_PaperReportEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objgs_PaperReportEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_PaperReportEN.TopicId);
}
 if (objgs_PaperReportEN.ReportUser == null)
{
 sbCondition.AppendFormat(" and ReportUser is null", objgs_PaperReportEN.ReportUser);
}
else
{
 sbCondition.AppendFormat(" and ReportUser = '{0}'", objgs_PaperReportEN.ReportUser);
}
 if (objgs_PaperReportEN.ReportDate == null)
{
 sbCondition.AppendFormat(" and ReportDate is null", objgs_PaperReportEN.ReportDate);
}
else
{
 sbCondition.AppendFormat(" and ReportDate = '{0}'", objgs_PaperReportEN.ReportDate);
}
if (clsgs_PaperReportBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ReportId !=  '{0}'", objgs_PaperReportEN.ReportId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_PaperReportEN.TopicId);
 sbCondition.AppendFormat(" and ReportUser = '{0}'", objgs_PaperReportEN.ReportUser);
 sbCondition.AppendFormat(" and ReportDate = '{0}'", objgs_PaperReportEN.ReportDate);
if (clsgs_PaperReportBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--gs_PaperReport(论文汇报表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TopicId_ReportUser_ReportDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_PaperReportEN objgs_PaperReportEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperReportEN == null) return "";
if (objgs_PaperReportEN.ReportId == null || objgs_PaperReportEN.ReportId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_PaperReportEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null", objgs_PaperReportEN.TopicId);
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_PaperReportEN.TopicId);
}
 if (objgs_PaperReportEN.ReportUser == null)
{
 sbCondition.AppendFormat(" and ReportUser is null", objgs_PaperReportEN.ReportUser);
}
else
{
 sbCondition.AppendFormat(" and ReportUser = '{0}'", objgs_PaperReportEN.ReportUser);
}
 if (objgs_PaperReportEN.ReportDate == null)
{
 sbCondition.AppendFormat(" and ReportDate is null", objgs_PaperReportEN.ReportDate);
}
else
{
 sbCondition.AppendFormat(" and ReportDate = '{0}'", objgs_PaperReportEN.ReportDate);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ReportId !=  '{0}'", objgs_PaperReportEN.ReportId);
 sbCondition.AppendFormat(" and TopicId = '{0}'", objgs_PaperReportEN.TopicId);
 sbCondition.AppendFormat(" and ReportUser = '{0}'", objgs_PaperReportEN.ReportUser);
 sbCondition.AppendFormat(" and ReportDate = '{0}'", objgs_PaperReportEN.ReportDate);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_PaperReport
{
public virtual bool UpdRelaTabDate(string strReportId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文汇报表(gs_PaperReport)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_PaperReportBL
{
public static RelatedActions_gs_PaperReport relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_PaperReportDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_PaperReportDA gs_PaperReportDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_PaperReportDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsgs_PaperReportBL()
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
if (string.IsNullOrEmpty(clsgs_PaperReportEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PaperReportEN._ConnectString);
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
public static DataTable GetDataTable_gs_PaperReport(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_PaperReportDA.GetDataTable_gs_PaperReport(strWhereCond);
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
objDT = gs_PaperReportDA.GetDataTable(strWhereCond);
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
objDT = gs_PaperReportDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_PaperReportDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_PaperReportDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_PaperReportDA.GetDataTable_Top(objTopPara);
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
objDT = gs_PaperReportDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_PaperReportDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_PaperReportDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_PaperReportEN> GetObjLstByReportIdLst(List<string> arrReportIdLst)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
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
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrReportIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_PaperReportEN> GetObjLstByReportIdLstCache(List<string> arrReportIdLst)
{
string strKey = string.Format("{0}", clsgs_PaperReportEN._CurrTabName);
List<clsgs_PaperReportEN> arrgs_PaperReportObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperReportEN> arrgs_PaperReportObjLst_Sel =
arrgs_PaperReportObjLstCache
.Where(x => arrReportIdLst.Contains(x.ReportId));
return arrgs_PaperReportObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperReportEN> GetObjLst(string strWhereCond)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
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
public static List<clsgs_PaperReportEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_PaperReportCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_PaperReportEN> GetSubObjLstCache(clsgs_PaperReportEN objgs_PaperReportCond)
{
List<clsgs_PaperReportEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperReportEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperReport.AttributeName)
{
if (objgs_PaperReportCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperReportCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperReportCond[strFldName].ToString());
}
else
{
if (objgs_PaperReportCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperReportCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperReportCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperReportCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperReportCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperReportCond[strFldName]));
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
public static List<clsgs_PaperReportEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
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
public static List<clsgs_PaperReportEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
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
List<clsgs_PaperReportEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_PaperReportEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperReportEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_PaperReportEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
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
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
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
public static List<clsgs_PaperReportEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_PaperReportEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_PaperReportEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
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
public static List<clsgs_PaperReportEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperReportEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_PaperReportEN> arrObjLst = new List<clsgs_PaperReportEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperReportEN objgs_PaperReportEN = new clsgs_PaperReportEN();
try
{
objgs_PaperReportEN.ReportId = objRow[congs_PaperReport.ReportId].ToString().Trim(); //汇报Id
objgs_PaperReportEN.TopicId = objRow[congs_PaperReport.TopicId] == DBNull.Value ? null : objRow[congs_PaperReport.TopicId].ToString().Trim(); //主题Id
objgs_PaperReportEN.PaperId = objRow[congs_PaperReport.PaperId] == DBNull.Value ? null : objRow[congs_PaperReport.PaperId].ToString().Trim(); //论文Id
objgs_PaperReportEN.ReportContent = objRow[congs_PaperReport.ReportContent] == DBNull.Value ? null : objRow[congs_PaperReport.ReportContent].ToString().Trim(); //汇报内容
objgs_PaperReportEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_PaperReport.IsSubmit].ToString().Trim()); //是否提交
objgs_PaperReportEN.ReportUser = objRow[congs_PaperReport.ReportUser] == DBNull.Value ? null : objRow[congs_PaperReport.ReportUser].ToString().Trim(); //汇报用户
objgs_PaperReportEN.ReportDate = objRow[congs_PaperReport.ReportDate] == DBNull.Value ? null : objRow[congs_PaperReport.ReportDate].ToString().Trim(); //汇报日期
objgs_PaperReportEN.VersionCount = objRow[congs_PaperReport.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.VersionCount].ToString().Trim()); //版本统计
objgs_PaperReportEN.OkCount = objRow[congs_PaperReport.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.OkCount].ToString().Trim()); //点赞统计
objgs_PaperReportEN.AppraiseCount = objRow[congs_PaperReport.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.AppraiseCount].ToString().Trim()); //评论数
objgs_PaperReportEN.Score = objRow[congs_PaperReport.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.Score].ToString().Trim()); //评分
objgs_PaperReportEN.StuScore = objRow[congs_PaperReport.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.StuScore].ToString().Trim()); //学生平均分
objgs_PaperReportEN.TeaScore = objRow[congs_PaperReport.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_PaperReport.TeaScore].ToString().Trim()); //教师评分
objgs_PaperReportEN.PDFUrl = objRow[congs_PaperReport.PDFUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PDFUrl].ToString().Trim(); //PDFUrl
objgs_PaperReportEN.PPTUrl = objRow[congs_PaperReport.PPTUrl] == DBNull.Value ? null : objRow[congs_PaperReport.PPTUrl].ToString().Trim(); //PPTUrl
objgs_PaperReportEN.Month = objRow[congs_PaperReport.Month] == DBNull.Value ? null : objRow[congs_PaperReport.Month].ToString().Trim(); //月
objgs_PaperReportEN.Week = objRow[congs_PaperReport.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_PaperReport.Week].ToString().Trim()); //周
objgs_PaperReportEN.Year = objRow[congs_PaperReport.Year] == DBNull.Value ? null : objRow[congs_PaperReport.Year].ToString().Trim(); //年
objgs_PaperReportEN.IdCurrEduCls = objRow[congs_PaperReport.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_PaperReport.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_PaperReportEN.UpdUser = objRow[congs_PaperReport.UpdUser] == DBNull.Value ? null : objRow[congs_PaperReport.UpdUser].ToString().Trim(); //修改人
objgs_PaperReportEN.UpdDate = objRow[congs_PaperReport.UpdDate] == DBNull.Value ? null : objRow[congs_PaperReport.UpdDate].ToString().Trim(); //修改日期
objgs_PaperReportEN.Memo = objRow[congs_PaperReport.Memo] == DBNull.Value ? null : objRow[congs_PaperReport.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperReportEN.ReportId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperReportEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_PaperReport(ref clsgs_PaperReportEN objgs_PaperReportEN)
{
bool bolResult = gs_PaperReportDA.Getgs_PaperReport(ref objgs_PaperReportEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strReportId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperReportEN GetObjByReportId(string strReportId)
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
clsgs_PaperReportEN objgs_PaperReportEN = gs_PaperReportDA.GetObjByReportId(strReportId);
return objgs_PaperReportEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_PaperReportEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_PaperReportEN objgs_PaperReportEN = gs_PaperReportDA.GetFirstObj(strWhereCond);
 return objgs_PaperReportEN;
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
public static clsgs_PaperReportEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_PaperReportEN objgs_PaperReportEN = gs_PaperReportDA.GetObjByDataRow(objRow);
 return objgs_PaperReportEN;
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
public static clsgs_PaperReportEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_PaperReportEN objgs_PaperReportEN = gs_PaperReportDA.GetObjByDataRow(objRow);
 return objgs_PaperReportEN;
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
 /// <param name = "lstgs_PaperReportObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperReportEN GetObjByReportIdFromList(string strReportId, List<clsgs_PaperReportEN> lstgs_PaperReportObjLst)
{
foreach (clsgs_PaperReportEN objgs_PaperReportEN in lstgs_PaperReportObjLst)
{
if (objgs_PaperReportEN.ReportId == strReportId)
{
return objgs_PaperReportEN;
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
 string strMaxReportId;
 try
 {
 strMaxReportId = clsgs_PaperReportDA.GetMaxStrId();
 return strMaxReportId;
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
 string strReportId;
 try
 {
 strReportId = new clsgs_PaperReportDA().GetFirstID(strWhereCond);
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
 arrList = gs_PaperReportDA.GetID(strWhereCond);
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
bool bolIsExist = gs_PaperReportDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_PaperReportDA.IsExist(strReportId);
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
 bolIsExist = clsgs_PaperReportDA.IsExistTable();
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
 bolIsExist = gs_PaperReportDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_PaperReportEN objgs_PaperReportEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperReportEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],汇报用户 = [{1}],汇报日期 = [{2}]的数据已经存在!(in clsgs_PaperReportBL.AddNewRecordBySql2)", objgs_PaperReportEN.TopicId,objgs_PaperReportEN.ReportUser,objgs_PaperReportEN.ReportDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true || clsgs_PaperReportBL.IsExist(objgs_PaperReportEN.ReportId) == true)
 {
     objgs_PaperReportEN.ReportId = clsgs_PaperReportBL.GetMaxStrId_S();
 }
bool bolResult = gs_PaperReportDA.AddNewRecordBySQL2(objgs_PaperReportEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_PaperReportEN objgs_PaperReportEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperReportEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!主题Id = [{0}],汇报用户 = [{1}],汇报日期 = [{2}]的数据已经存在!(in clsgs_PaperReportBL.AddNewRecordBySql2WithReturnKey)", objgs_PaperReportEN.TopicId,objgs_PaperReportEN.ReportUser,objgs_PaperReportEN.ReportDate);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true || clsgs_PaperReportBL.IsExist(objgs_PaperReportEN.ReportId) == true)
 {
     objgs_PaperReportEN.ReportId = clsgs_PaperReportBL.GetMaxStrId_S();
 }
string strKey = gs_PaperReportDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperReportEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_PaperReportEN objgs_PaperReportEN)
{
try
{
bool bolResult = gs_PaperReportDA.Update(objgs_PaperReportEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_PaperReportEN objgs_PaperReportEN)
{
 if (string.IsNullOrEmpty(objgs_PaperReportEN.ReportId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_PaperReportDA.UpdateBySql2(objgs_PaperReportEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshCache();

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "strReportId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strReportId)
{
try
{
 clsgs_PaperReportEN objgs_PaperReportEN = clsgs_PaperReportBL.GetObjByReportId(strReportId);

if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(objgs_PaperReportEN.ReportId, "SetUpdDate");
}
if (objgs_PaperReportEN != null)
{
int intRecNum = gs_PaperReportDA.DelRecord(strReportId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strReportId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strReportId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[gs_PaperReport]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_PaperReport.ReportId,
//strReportId);
//        clsgs_PaperReportBL.Delgs_PaperReportsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperReportBL.DelRecord(strReportId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperReportBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strReportId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "strReportId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strReportId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_PaperReportBL.relatedActions != null)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(strReportId, "UpdRelaTabDate");
}
bool bolResult = gs_PaperReportDA.DelRecord(strReportId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrReportIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_PaperReports(List<string> arrReportIdLst)
{
if (arrReportIdLst.Count == 0) return 0;
try
{
if (clsgs_PaperReportBL.relatedActions != null)
{
foreach (var strReportId in arrReportIdLst)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(strReportId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_PaperReportDA.Delgs_PaperReport(arrReportIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int Delgs_PaperReportsByCond(string strWhereCond)
{
try
{
if (clsgs_PaperReportBL.relatedActions != null)
{
List<string> arrReportId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strReportId in arrReportId)
{
clsgs_PaperReportBL.relatedActions.UpdRelaTabDate(strReportId, "UpdRelaTabDate");
}
}
int intRecNum = gs_PaperReportDA.Delgs_PaperReport(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_PaperReport]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strReportId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strReportId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperReportDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[gs_PaperReport]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperReportBL.DelRecord(strReportId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperReportBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strReportId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objgs_PaperReportENS">源对象</param>
 /// <param name = "objgs_PaperReportENT">目标对象</param>
 public static void CopyTo(clsgs_PaperReportEN objgs_PaperReportENS, clsgs_PaperReportEN objgs_PaperReportENT)
{
try
{
objgs_PaperReportENT.ReportId = objgs_PaperReportENS.ReportId; //汇报Id
objgs_PaperReportENT.TopicId = objgs_PaperReportENS.TopicId; //主题Id
objgs_PaperReportENT.PaperId = objgs_PaperReportENS.PaperId; //论文Id
objgs_PaperReportENT.ReportContent = objgs_PaperReportENS.ReportContent; //汇报内容
objgs_PaperReportENT.IsSubmit = objgs_PaperReportENS.IsSubmit; //是否提交
objgs_PaperReportENT.ReportUser = objgs_PaperReportENS.ReportUser; //汇报用户
objgs_PaperReportENT.ReportDate = objgs_PaperReportENS.ReportDate; //汇报日期
objgs_PaperReportENT.VersionCount = objgs_PaperReportENS.VersionCount; //版本统计
objgs_PaperReportENT.OkCount = objgs_PaperReportENS.OkCount; //点赞统计
objgs_PaperReportENT.AppraiseCount = objgs_PaperReportENS.AppraiseCount; //评论数
objgs_PaperReportENT.Score = objgs_PaperReportENS.Score; //评分
objgs_PaperReportENT.StuScore = objgs_PaperReportENS.StuScore; //学生平均分
objgs_PaperReportENT.TeaScore = objgs_PaperReportENS.TeaScore; //教师评分
objgs_PaperReportENT.PDFUrl = objgs_PaperReportENS.PDFUrl; //PDFUrl
objgs_PaperReportENT.PPTUrl = objgs_PaperReportENS.PPTUrl; //PPTUrl
objgs_PaperReportENT.Month = objgs_PaperReportENS.Month; //月
objgs_PaperReportENT.Week = objgs_PaperReportENS.Week; //周
objgs_PaperReportENT.Year = objgs_PaperReportENS.Year; //年
objgs_PaperReportENT.IdCurrEduCls = objgs_PaperReportENS.IdCurrEduCls; //教学班流水号
objgs_PaperReportENT.UpdUser = objgs_PaperReportENS.UpdUser; //修改人
objgs_PaperReportENT.UpdDate = objgs_PaperReportENS.UpdDate; //修改日期
objgs_PaperReportENT.Memo = objgs_PaperReportENS.Memo; //备注
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
 /// <param name = "objgs_PaperReportEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_PaperReportEN objgs_PaperReportEN)
{
try
{
objgs_PaperReportEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_PaperReportEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_PaperReport.ReportId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.ReportId = objgs_PaperReportEN.ReportId; //汇报Id
}
if (arrFldSet.Contains(congs_PaperReport.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.TopicId = objgs_PaperReportEN.TopicId == "[null]" ? null :  objgs_PaperReportEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_PaperReport.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.PaperId = objgs_PaperReportEN.PaperId == "[null]" ? null :  objgs_PaperReportEN.PaperId; //论文Id
}
if (arrFldSet.Contains(congs_PaperReport.ReportContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.ReportContent = objgs_PaperReportEN.ReportContent == "[null]" ? null :  objgs_PaperReportEN.ReportContent; //汇报内容
}
if (arrFldSet.Contains(congs_PaperReport.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.IsSubmit = objgs_PaperReportEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(congs_PaperReport.ReportUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.ReportUser = objgs_PaperReportEN.ReportUser == "[null]" ? null :  objgs_PaperReportEN.ReportUser; //汇报用户
}
if (arrFldSet.Contains(congs_PaperReport.ReportDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.ReportDate = objgs_PaperReportEN.ReportDate == "[null]" ? null :  objgs_PaperReportEN.ReportDate; //汇报日期
}
if (arrFldSet.Contains(congs_PaperReport.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.VersionCount = objgs_PaperReportEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(congs_PaperReport.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.OkCount = objgs_PaperReportEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(congs_PaperReport.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.AppraiseCount = objgs_PaperReportEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(congs_PaperReport.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.Score = objgs_PaperReportEN.Score; //评分
}
if (arrFldSet.Contains(congs_PaperReport.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.StuScore = objgs_PaperReportEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(congs_PaperReport.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.TeaScore = objgs_PaperReportEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(congs_PaperReport.PDFUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.PDFUrl = objgs_PaperReportEN.PDFUrl == "[null]" ? null :  objgs_PaperReportEN.PDFUrl; //PDFUrl
}
if (arrFldSet.Contains(congs_PaperReport.PPTUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.PPTUrl = objgs_PaperReportEN.PPTUrl == "[null]" ? null :  objgs_PaperReportEN.PPTUrl; //PPTUrl
}
if (arrFldSet.Contains(congs_PaperReport.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.Month = objgs_PaperReportEN.Month == "[null]" ? null :  objgs_PaperReportEN.Month; //月
}
if (arrFldSet.Contains(congs_PaperReport.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.Week = objgs_PaperReportEN.Week; //周
}
if (arrFldSet.Contains(congs_PaperReport.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.Year = objgs_PaperReportEN.Year == "[null]" ? null :  objgs_PaperReportEN.Year; //年
}
if (arrFldSet.Contains(congs_PaperReport.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.IdCurrEduCls = objgs_PaperReportEN.IdCurrEduCls == "[null]" ? null :  objgs_PaperReportEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_PaperReport.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.UpdUser = objgs_PaperReportEN.UpdUser == "[null]" ? null :  objgs_PaperReportEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_PaperReport.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.UpdDate = objgs_PaperReportEN.UpdDate == "[null]" ? null :  objgs_PaperReportEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_PaperReport.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperReportEN.Memo = objgs_PaperReportEN.Memo == "[null]" ? null :  objgs_PaperReportEN.Memo; //备注
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
 /// <param name = "objgs_PaperReportEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_PaperReportEN objgs_PaperReportEN)
{
try
{
if (objgs_PaperReportEN.TopicId == "[null]") objgs_PaperReportEN.TopicId = null; //主题Id
if (objgs_PaperReportEN.PaperId == "[null]") objgs_PaperReportEN.PaperId = null; //论文Id
if (objgs_PaperReportEN.ReportContent == "[null]") objgs_PaperReportEN.ReportContent = null; //汇报内容
if (objgs_PaperReportEN.ReportUser == "[null]") objgs_PaperReportEN.ReportUser = null; //汇报用户
if (objgs_PaperReportEN.ReportDate == "[null]") objgs_PaperReportEN.ReportDate = null; //汇报日期
if (objgs_PaperReportEN.PDFUrl == "[null]") objgs_PaperReportEN.PDFUrl = null; //PDFUrl
if (objgs_PaperReportEN.PPTUrl == "[null]") objgs_PaperReportEN.PPTUrl = null; //PPTUrl
if (objgs_PaperReportEN.Month == "[null]") objgs_PaperReportEN.Month = null; //月
if (objgs_PaperReportEN.Year == "[null]") objgs_PaperReportEN.Year = null; //年
if (objgs_PaperReportEN.IdCurrEduCls == "[null]") objgs_PaperReportEN.IdCurrEduCls = null; //教学班流水号
if (objgs_PaperReportEN.UpdUser == "[null]") objgs_PaperReportEN.UpdUser = null; //修改人
if (objgs_PaperReportEN.UpdDate == "[null]") objgs_PaperReportEN.UpdDate = null; //修改日期
if (objgs_PaperReportEN.Memo == "[null]") objgs_PaperReportEN.Memo = null; //备注
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsgs_PaperReportEN objgs_PaperReportEN)
{
 gs_PaperReportDA.CheckPropertyNew(objgs_PaperReportEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_PaperReportEN objgs_PaperReportEN)
{
 gs_PaperReportDA.CheckProperty4Condition(objgs_PaperReportEN);
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
if (clsgs_PaperReportBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperReportBL没有刷新缓存机制(clsgs_PaperReportBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ReportId");
//if (arrgs_PaperReportObjLstCache == null)
//{
//arrgs_PaperReportObjLstCache = gs_PaperReportDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strReportId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperReportEN GetObjByReportIdCache(string strReportId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_PaperReportEN._CurrTabName);
List<clsgs_PaperReportEN> arrgs_PaperReportObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperReportEN> arrgs_PaperReportObjLst_Sel =
arrgs_PaperReportObjLstCache
.Where(x=> x.ReportId == strReportId 
);
if (arrgs_PaperReportObjLst_Sel.Count() == 0)
{
   clsgs_PaperReportEN obj = clsgs_PaperReportBL.GetObjByReportId(strReportId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_PaperReportObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperReportEN> GetAllgs_PaperReportObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_PaperReportEN> arrgs_PaperReportObjLstCache = GetObjLstCache(); 
return arrgs_PaperReportObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperReportEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_PaperReportEN._CurrTabName);
List<clsgs_PaperReportEN> arrgs_PaperReportObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_PaperReportObjLstCache;
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
string strKey = string.Format("{0}", clsgs_PaperReportEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_PaperReportEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsgs_PaperReportEN._RefreshTimeLst.Count == 0) return "";
return clsgs_PaperReportEN._RefreshTimeLst[clsgs_PaperReportEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_PaperReportBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_PaperReportEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_PaperReportEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_PaperReportBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_PaperReport(论文汇报表)
 /// 唯一性条件:TopicId_ReportUser_ReportDate
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PaperReportEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_PaperReportEN objgs_PaperReportEN)
{
//检测记录是否存在
string strResult = gs_PaperReportDA.GetUniCondStr(objgs_PaperReportEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strReportId)
{
if (strInFldName != congs_PaperReport.ReportId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_PaperReport.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_PaperReport.AttributeName));
throw new Exception(strMsg);
}
var objgs_PaperReport = clsgs_PaperReportBL.GetObjByReportIdCache(strReportId);
if (objgs_PaperReport == null) return "";
return objgs_PaperReport[strOutFldName].ToString();
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
int intRecCount = clsgs_PaperReportDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_PaperReportDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_PaperReportDA.GetRecCount();
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
int intRecCount = clsgs_PaperReportDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_PaperReportCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_PaperReportEN objgs_PaperReportCond)
{
List<clsgs_PaperReportEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperReportEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperReport.AttributeName)
{
if (objgs_PaperReportCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperReportCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperReportCond[strFldName].ToString());
}
else
{
if (objgs_PaperReportCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperReportCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperReportCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperReportCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperReportCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperReportCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperReportCond[strFldName]));
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
 List<string> arrList = clsgs_PaperReportDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperReportDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperReportDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = gs_PaperReportDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperReportDA.SetFldValue(clsgs_PaperReportEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = gs_PaperReportDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperReportDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperReportDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsgs_PaperReportDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[gs_PaperReport] "); 
 strCreateTabCode.Append(" ( "); 
 // /**汇报Id*/ 
 strCreateTabCode.Append(" ReportId char(10) primary key, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**汇报内容*/ 
 strCreateTabCode.Append(" ReportContent varchar(5000) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**汇报用户*/ 
 strCreateTabCode.Append(" ReportUser varchar(500) Null, "); 
 // /**汇报日期*/ 
 strCreateTabCode.Append(" ReportDate varchar(20) Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**PDFUrl*/ 
 strCreateTabCode.Append(" PDFUrl varchar(500) Null, "); 
 // /**PPTUrl*/ 
 strCreateTabCode.Append(" PPTUrl varchar(500) Null, "); 
 // /**月*/ 
 strCreateTabCode.Append(" Month char(2) Null, "); 
 // /**周*/ 
 strCreateTabCode.Append(" Week int Null, "); 
 // /**年*/ 
 strCreateTabCode.Append(" Year char(4) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文汇报表(gs_PaperReport)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_PaperReport : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperReportBL.ReFreshThisCache();
}
}

}