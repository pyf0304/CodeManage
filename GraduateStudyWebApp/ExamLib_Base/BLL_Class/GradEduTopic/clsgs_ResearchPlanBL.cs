
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_ResearchPlanBL
 表名:gs_ResearchPlan(01120663)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:20
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
public static class  clsgs_ResearchPlanBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ResearchPlanEN GetObj(this K_PlanId_gs_ResearchPlan myKey)
{
clsgs_ResearchPlanEN objgs_ResearchPlanEN = clsgs_ResearchPlanBL.gs_ResearchPlanDA.GetObjByPlanId(myKey.Value);
return objgs_ResearchPlanEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}]的数据已经存在!(in clsgs_ResearchPlanBL.AddNewRecord)", objgs_ResearchPlanEN.PlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true || clsgs_ResearchPlanBL.IsExist(objgs_ResearchPlanEN.PlanId) == true)
 {
     objgs_ResearchPlanEN.PlanId = clsgs_ResearchPlanBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_ResearchPlanBL.gs_ResearchPlanDA.AddNewRecordBySQL2(objgs_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
public static bool AddRecordEx(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_ResearchPlanBL.IsExist(objgs_ResearchPlanEN.PlanId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_ResearchPlanEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_ResearchPlanEN.CheckUniqueness() == false)
{
strMsg = string.Format("(计划Id(PlanId)=[{0}])已经存在,不能重复!", objgs_ResearchPlanEN.PlanId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true || clsgs_ResearchPlanBL.IsExist(objgs_ResearchPlanEN.PlanId) == true)
 {
     objgs_ResearchPlanEN.PlanId = clsgs_ResearchPlanBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_ResearchPlanEN.AddNewRecord();
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}]的数据已经存在!(in clsgs_ResearchPlanBL.AddNewRecordWithMaxId)", objgs_ResearchPlanEN.PlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true || clsgs_ResearchPlanBL.IsExist(objgs_ResearchPlanEN.PlanId) == true)
 {
     objgs_ResearchPlanEN.PlanId = clsgs_ResearchPlanBL.GetMaxStrId_S();
 }
string strPlanId = clsgs_ResearchPlanBL.gs_ResearchPlanDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchPlanEN);
     objgs_ResearchPlanEN.PlanId = strPlanId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
}
return strPlanId;
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_ResearchPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}]的数据已经存在!(in clsgs_ResearchPlanBL.AddNewRecordWithReturnKey)", objgs_ResearchPlanEN.PlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true || clsgs_ResearchPlanBL.IsExist(objgs_ResearchPlanEN.PlanId) == true)
 {
     objgs_ResearchPlanEN.PlanId = clsgs_ResearchPlanBL.GetMaxStrId_S();
 }
string strKey = clsgs_ResearchPlanBL.gs_ResearchPlanDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetPlanId(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strPlanId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanId, 8, congs_ResearchPlan.PlanId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPlanId, 8, congs_ResearchPlan.PlanId);
}
objgs_ResearchPlanEN.PlanId = strPlanId; //计划Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.PlanId) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.PlanId, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.PlanId] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetTopicId(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicId, congs_ResearchPlan.TopicId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_ResearchPlan.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_ResearchPlan.TopicId);
}
objgs_ResearchPlanEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.TopicId) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.TopicId, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.TopicId] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetStatusId(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strStatusId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatusId, congs_ResearchPlan.StatusId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatusId, 2, congs_ResearchPlan.StatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStatusId, 2, congs_ResearchPlan.StatusId);
}
objgs_ResearchPlanEN.StatusId = strStatusId; //状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.StatusId) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.StatusId, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.StatusId] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetPlanContent(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strPlanContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanContent, 1000, congs_ResearchPlan.PlanContent);
}
objgs_ResearchPlanEN.PlanContent = strPlanContent; //计划内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.PlanContent) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.PlanContent, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.PlanContent] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetResponsibleUser(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strResponsibleUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResponsibleUser, 50, congs_ResearchPlan.ResponsibleUser);
}
objgs_ResearchPlanEN.ResponsibleUser = strResponsibleUser; //负责人/小组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.ResponsibleUser) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.ResponsibleUser, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.ResponsibleUser] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetStartDate(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strStartDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartDate, 20, congs_ResearchPlan.StartDate);
}
objgs_ResearchPlanEN.StartDate = strStartDate; //开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.StartDate) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.StartDate, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.StartDate] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetEndDate(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndDate, 20, congs_ResearchPlan.EndDate);
}
objgs_ResearchPlanEN.EndDate = strEndDate; //截止日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.EndDate) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.EndDate, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.EndDate] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetActualFinishingDate(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strActualFinishingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strActualFinishingDate, 20, congs_ResearchPlan.ActualFinishingDate);
}
objgs_ResearchPlanEN.ActualFinishingDate = strActualFinishingDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.ActualFinishingDate) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.ActualFinishingDate, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.ActualFinishingDate] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetAcceptanceUser(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strAcceptanceUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAcceptanceUser, 50, congs_ResearchPlan.AcceptanceUser);
}
objgs_ResearchPlanEN.AcceptanceUser = strAcceptanceUser; //验收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.AcceptanceUser) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.AcceptanceUser, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.AcceptanceUser] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetIsSubmit(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, bool bolIsSubmit, string strComparisonOp="")
	{
objgs_ResearchPlanEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.IsSubmit) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.IsSubmit, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.IsSubmit] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetUpdUser(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_ResearchPlan.UpdUser);
}
objgs_ResearchPlanEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.UpdUser) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.UpdUser, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.UpdUser] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetUpdDate(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_ResearchPlan.UpdDate);
}
objgs_ResearchPlanEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.UpdDate) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.UpdDate, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.UpdDate] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetMemo(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_ResearchPlan.Memo);
}
objgs_ResearchPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.Memo) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.Memo, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.Memo] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetPlanTypeId(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strPlanTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanTypeId, 2, congs_ResearchPlan.PlanTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPlanTypeId, 2, congs_ResearchPlan.PlanTypeId);
}
objgs_ResearchPlanEN.PlanTypeId = strPlanTypeId; //计划类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.PlanTypeId) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.PlanTypeId, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.PlanTypeId] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_ResearchPlanEN SetIdCurrEduCls(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_ResearchPlan.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_ResearchPlan.IdCurrEduCls);
}
objgs_ResearchPlanEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(congs_ResearchPlan.IdCurrEduCls) == false)
{
objgs_ResearchPlanEN.dicFldComparisonOp.Add(congs_ResearchPlan.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_ResearchPlanEN.dicFldComparisonOp[congs_ResearchPlan.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_ResearchPlanEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_ResearchPlanEN.CheckPropertyNew();
clsgs_ResearchPlanEN objgs_ResearchPlanCond = new clsgs_ResearchPlanEN();
string strCondition = objgs_ResearchPlanCond
.SetPlanId(objgs_ResearchPlanEN.PlanId, "<>")
.SetPlanId(objgs_ResearchPlanEN.PlanId, "=")
.GetCombineCondition();
objgs_ResearchPlanEN._IsCheckProperty = true;
bool bolIsExist = clsgs_ResearchPlanBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(PlanId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_ResearchPlanEN.Update();
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
 /// <param name = "objgs_ResearchPlan">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_ResearchPlanEN objgs_ResearchPlan)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_ResearchPlanEN objgs_ResearchPlanCond = new clsgs_ResearchPlanEN();
string strCondition = objgs_ResearchPlanCond
.SetPlanId(objgs_ResearchPlan.PlanId, "=")
.GetCombineCondition();
objgs_ResearchPlan._IsCheckProperty = true;
bool bolIsExist = clsgs_ResearchPlanBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_ResearchPlan.PlanId = clsgs_ResearchPlanBL.GetFirstID_S(strCondition);
objgs_ResearchPlan.UpdateWithCondition(strCondition);
}
else
{
objgs_ResearchPlan.PlanId = clsgs_ResearchPlanBL.GetMaxStrId_S();
objgs_ResearchPlan.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ResearchPlanBL.gs_ResearchPlanDA.UpdateBySql2(objgs_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_ResearchPlanBL.gs_ResearchPlanDA.UpdateBySql2(objgs_ResearchPlanEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_ResearchPlanBL.gs_ResearchPlanDA.UpdateBySqlWithCondition(objgs_ResearchPlanEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_ResearchPlanEN objgs_ResearchPlanEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_ResearchPlanBL.gs_ResearchPlanDA.UpdateBySqlWithConditionTransaction(objgs_ResearchPlanEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
try
{
int intRecNum = clsgs_ResearchPlanBL.gs_ResearchPlanDA.DelRecord(objgs_ResearchPlanEN.PlanId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanENS">源对象</param>
 /// <param name = "objgs_ResearchPlanENT">目标对象</param>
 public static void CopyTo(this clsgs_ResearchPlanEN objgs_ResearchPlanENS, clsgs_ResearchPlanEN objgs_ResearchPlanENT)
{
try
{
objgs_ResearchPlanENT.PlanId = objgs_ResearchPlanENS.PlanId; //计划Id
objgs_ResearchPlanENT.TopicId = objgs_ResearchPlanENS.TopicId; //主题Id
objgs_ResearchPlanENT.StatusId = objgs_ResearchPlanENS.StatusId; //状态Id
objgs_ResearchPlanENT.PlanContent = objgs_ResearchPlanENS.PlanContent; //计划内容
objgs_ResearchPlanENT.ResponsibleUser = objgs_ResearchPlanENS.ResponsibleUser; //负责人/小组
objgs_ResearchPlanENT.StartDate = objgs_ResearchPlanENS.StartDate; //开始日期
objgs_ResearchPlanENT.EndDate = objgs_ResearchPlanENS.EndDate; //截止日期
objgs_ResearchPlanENT.ActualFinishingDate = objgs_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objgs_ResearchPlanENT.AcceptanceUser = objgs_ResearchPlanENS.AcceptanceUser; //验收用户
objgs_ResearchPlanENT.IsSubmit = objgs_ResearchPlanENS.IsSubmit; //是否提交
objgs_ResearchPlanENT.UpdUser = objgs_ResearchPlanENS.UpdUser; //修改人
objgs_ResearchPlanENT.UpdDate = objgs_ResearchPlanENS.UpdDate; //修改日期
objgs_ResearchPlanENT.Memo = objgs_ResearchPlanENS.Memo; //备注
objgs_ResearchPlanENT.PlanTypeId = objgs_ResearchPlanENS.PlanTypeId; //计划类型
objgs_ResearchPlanENT.IdCurrEduCls = objgs_ResearchPlanENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objgs_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clsgs_ResearchPlanEN:objgs_ResearchPlanENT</returns>
 public static clsgs_ResearchPlanEN CopyTo(this clsgs_ResearchPlanEN objgs_ResearchPlanENS)
{
try
{
 clsgs_ResearchPlanEN objgs_ResearchPlanENT = new clsgs_ResearchPlanEN()
{
PlanId = objgs_ResearchPlanENS.PlanId, //计划Id
TopicId = objgs_ResearchPlanENS.TopicId, //主题Id
StatusId = objgs_ResearchPlanENS.StatusId, //状态Id
PlanContent = objgs_ResearchPlanENS.PlanContent, //计划内容
ResponsibleUser = objgs_ResearchPlanENS.ResponsibleUser, //负责人/小组
StartDate = objgs_ResearchPlanENS.StartDate, //开始日期
EndDate = objgs_ResearchPlanENS.EndDate, //截止日期
ActualFinishingDate = objgs_ResearchPlanENS.ActualFinishingDate, //实际完成日期
AcceptanceUser = objgs_ResearchPlanENS.AcceptanceUser, //验收用户
IsSubmit = objgs_ResearchPlanENS.IsSubmit, //是否提交
UpdUser = objgs_ResearchPlanENS.UpdUser, //修改人
UpdDate = objgs_ResearchPlanENS.UpdDate, //修改日期
Memo = objgs_ResearchPlanENS.Memo, //备注
PlanTypeId = objgs_ResearchPlanENS.PlanTypeId, //计划类型
IdCurrEduCls = objgs_ResearchPlanENS.IdCurrEduCls, //教学班流水号
};
 return objgs_ResearchPlanENT;
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
public static void CheckPropertyNew(this clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 clsgs_ResearchPlanBL.gs_ResearchPlanDA.CheckPropertyNew(objgs_ResearchPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 clsgs_ResearchPlanBL.gs_ResearchPlanDA.CheckProperty4Condition(objgs_ResearchPlanEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_ResearchPlanEN objgs_ResearchPlanCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.PlanId) == true)
{
string strComparisonOpPlanId = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.PlanId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.PlanId, objgs_ResearchPlanCond.PlanId, strComparisonOpPlanId);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.TopicId) == true)
{
string strComparisonOpTopicId = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.TopicId, objgs_ResearchPlanCond.TopicId, strComparisonOpTopicId);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.StatusId) == true)
{
string strComparisonOpStatusId = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.StatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.StatusId, objgs_ResearchPlanCond.StatusId, strComparisonOpStatusId);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.PlanContent) == true)
{
string strComparisonOpPlanContent = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.PlanContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.PlanContent, objgs_ResearchPlanCond.PlanContent, strComparisonOpPlanContent);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.ResponsibleUser) == true)
{
string strComparisonOpResponsibleUser = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.ResponsibleUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.ResponsibleUser, objgs_ResearchPlanCond.ResponsibleUser, strComparisonOpResponsibleUser);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.StartDate) == true)
{
string strComparisonOpStartDate = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.StartDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.StartDate, objgs_ResearchPlanCond.StartDate, strComparisonOpStartDate);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.EndDate) == true)
{
string strComparisonOpEndDate = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.EndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.EndDate, objgs_ResearchPlanCond.EndDate, strComparisonOpEndDate);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.ActualFinishingDate) == true)
{
string strComparisonOpActualFinishingDate = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.ActualFinishingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.ActualFinishingDate, objgs_ResearchPlanCond.ActualFinishingDate, strComparisonOpActualFinishingDate);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.AcceptanceUser) == true)
{
string strComparisonOpAcceptanceUser = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.AcceptanceUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.AcceptanceUser, objgs_ResearchPlanCond.AcceptanceUser, strComparisonOpAcceptanceUser);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.IsSubmit) == true)
{
if (objgs_ResearchPlanCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_ResearchPlan.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_ResearchPlan.IsSubmit);
}
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.UpdUser, objgs_ResearchPlanCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.UpdDate, objgs_ResearchPlanCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.Memo) == true)
{
string strComparisonOpMemo = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.Memo, objgs_ResearchPlanCond.Memo, strComparisonOpMemo);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.PlanTypeId) == true)
{
string strComparisonOpPlanTypeId = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.PlanTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.PlanTypeId, objgs_ResearchPlanCond.PlanTypeId, strComparisonOpPlanTypeId);
}
if (objgs_ResearchPlanCond.IsUpdated(congs_ResearchPlan.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_ResearchPlanCond.dicFldComparisonOp[congs_ResearchPlan.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_ResearchPlan.IdCurrEduCls, objgs_ResearchPlanCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_ResearchPlan(主题研究计划), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:PlanId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_ResearchPlanEN == null) return true;
if (objgs_ResearchPlanEN.PlanId == null || objgs_ResearchPlanEN.PlanId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PlanId = '{0}'", objgs_ResearchPlanEN.PlanId);
if (clsgs_ResearchPlanBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("PlanId !=  '{0}'", objgs_ResearchPlanEN.PlanId);
 sbCondition.AppendFormat(" and PlanId = '{0}'", objgs_ResearchPlanEN.PlanId);
if (clsgs_ResearchPlanBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_ResearchPlan(主题研究计划), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:PlanId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_ResearchPlanEN == null) return "";
if (objgs_ResearchPlanEN.PlanId == null || objgs_ResearchPlanEN.PlanId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PlanId = '{0}'", objgs_ResearchPlanEN.PlanId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PlanId !=  '{0}'", objgs_ResearchPlanEN.PlanId);
 sbCondition.AppendFormat(" and PlanId = '{0}'", objgs_ResearchPlanEN.PlanId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_ResearchPlan
{
public virtual bool UpdRelaTabDate(string strPlanId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题研究计划(gs_ResearchPlan)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_ResearchPlanBL
{
public static RelatedActions_gs_ResearchPlan relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_ResearchPlanDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_ResearchPlanDA gs_ResearchPlanDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_ResearchPlanDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsgs_ResearchPlanBL()
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
if (string.IsNullOrEmpty(clsgs_ResearchPlanEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_ResearchPlanEN._ConnectString);
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
public static DataTable GetDataTable_gs_ResearchPlan(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_ResearchPlanDA.GetDataTable_gs_ResearchPlan(strWhereCond);
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
objDT = gs_ResearchPlanDA.GetDataTable(strWhereCond);
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
objDT = gs_ResearchPlanDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_ResearchPlanDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_ResearchPlanDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_ResearchPlanDA.GetDataTable_Top(objTopPara);
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
objDT = gs_ResearchPlanDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPlanIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_ResearchPlanEN> GetObjLstByPlanIdLst(List<string> arrPlanIdLst)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPlanIdLst, true);
 string strWhereCond = string.Format("PlanId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPlanIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_ResearchPlanEN> GetObjLstByPlanIdLstCache(List<string> arrPlanIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
List<clsgs_ResearchPlanEN> arrgs_ResearchPlanObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_ResearchPlanEN> arrgs_ResearchPlanObjLst_Sel =
arrgs_ResearchPlanObjLstCache
.Where(x => arrPlanIdLst.Contains(x.PlanId));
return arrgs_ResearchPlanObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchPlanEN> GetObjLst(string strWhereCond)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
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
public static List<clsgs_ResearchPlanEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_ResearchPlanEN> GetSubObjLstCache(clsgs_ResearchPlanEN objgs_ResearchPlanCond)
{
 string strIdCurrEduCls = objgs_ResearchPlanCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_ResearchPlanBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_ResearchPlanEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ResearchPlan.AttributeName)
{
if (objgs_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objgs_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objgs_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ResearchPlanCond[strFldName]));
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
public static List<clsgs_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
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
public static List<clsgs_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
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
List<clsgs_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchPlanEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
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
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
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
public static List<clsgs_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_ResearchPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
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
public static List<clsgs_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_ResearchPlanEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_ResearchPlanEN> arrObjLst = new List<clsgs_ResearchPlanEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_ResearchPlanEN objgs_ResearchPlanEN = new clsgs_ResearchPlanEN();
try
{
objgs_ResearchPlanEN.PlanId = objRow[congs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objgs_ResearchPlanEN.TopicId = objRow[congs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objgs_ResearchPlanEN.StatusId = objRow[congs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objgs_ResearchPlanEN.PlanContent = objRow[congs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objgs_ResearchPlanEN.ResponsibleUser = objRow[congs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objgs_ResearchPlanEN.StartDate = objRow[congs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objgs_ResearchPlanEN.EndDate = objRow[congs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objgs_ResearchPlanEN.ActualFinishingDate = objRow[congs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objgs_ResearchPlanEN.AcceptanceUser = objRow[congs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objgs_ResearchPlanEN.UpdUser = objRow[congs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objgs_ResearchPlanEN.UpdDate = objRow[congs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[congs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objgs_ResearchPlanEN.Memo = objRow[congs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[congs_ResearchPlan.Memo].ToString().Trim(); //备注
objgs_ResearchPlanEN.PlanTypeId = objRow[congs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[congs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objgs_ResearchPlanEN.IdCurrEduCls = objRow[congs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_ResearchPlanEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_ResearchPlan(ref clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
bool bolResult = gs_ResearchPlanDA.Getgs_ResearchPlan(ref objgs_ResearchPlanEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_ResearchPlanEN GetObjByPlanId(string strPlanId)
{
if (strPlanId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPlanId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPlanId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPlanId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_ResearchPlanEN objgs_ResearchPlanEN = gs_ResearchPlanDA.GetObjByPlanId(strPlanId);
return objgs_ResearchPlanEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_ResearchPlanEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_ResearchPlanEN objgs_ResearchPlanEN = gs_ResearchPlanDA.GetFirstObj(strWhereCond);
 return objgs_ResearchPlanEN;
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
public static clsgs_ResearchPlanEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_ResearchPlanEN objgs_ResearchPlanEN = gs_ResearchPlanDA.GetObjByDataRow(objRow);
 return objgs_ResearchPlanEN;
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
public static clsgs_ResearchPlanEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_ResearchPlanEN objgs_ResearchPlanEN = gs_ResearchPlanDA.GetObjByDataRow(objRow);
 return objgs_ResearchPlanEN;
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
 /// <param name = "strPlanId">所给的关键字</param>
 /// <param name = "lstgs_ResearchPlanObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ResearchPlanEN GetObjByPlanIdFromList(string strPlanId, List<clsgs_ResearchPlanEN> lstgs_ResearchPlanObjLst)
{
foreach (clsgs_ResearchPlanEN objgs_ResearchPlanEN in lstgs_ResearchPlanObjLst)
{
if (objgs_ResearchPlanEN.PlanId == strPlanId)
{
return objgs_ResearchPlanEN;
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
 string strMaxPlanId;
 try
 {
 strMaxPlanId = clsgs_ResearchPlanDA.GetMaxStrId();
 return strMaxPlanId;
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
 string strPlanId;
 try
 {
 strPlanId = new clsgs_ResearchPlanDA().GetFirstID(strWhereCond);
 return strPlanId;
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
 arrList = gs_ResearchPlanDA.GetID(strWhereCond);
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
bool bolIsExist = gs_ResearchPlanDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPlanId)
{
if (string.IsNullOrEmpty(strPlanId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPlanId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_ResearchPlanDA.IsExist(strPlanId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strPlanId">计划Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strPlanId, string strOpUser)
{
clsgs_ResearchPlanEN objgs_ResearchPlanEN = clsgs_ResearchPlanBL.GetObjByPlanId(strPlanId);
objgs_ResearchPlanEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objgs_ResearchPlanEN.UpdUser = strOpUser;
return clsgs_ResearchPlanBL.UpdateBySql2(objgs_ResearchPlanEN);
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
 bolIsExist = clsgs_ResearchPlanDA.IsExistTable();
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
 bolIsExist = gs_ResearchPlanDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_ResearchPlanEN objgs_ResearchPlanEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ResearchPlanEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}]的数据已经存在!(in clsgs_ResearchPlanBL.AddNewRecordBySql2)", objgs_ResearchPlanEN.PlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true || clsgs_ResearchPlanBL.IsExist(objgs_ResearchPlanEN.PlanId) == true)
 {
     objgs_ResearchPlanEN.PlanId = clsgs_ResearchPlanBL.GetMaxStrId_S();
 }
bool bolResult = gs_ResearchPlanDA.AddNewRecordBySQL2(objgs_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_ResearchPlanEN objgs_ResearchPlanEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_ResearchPlanEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}]的数据已经存在!(in clsgs_ResearchPlanBL.AddNewRecordBySql2WithReturnKey)", objgs_ResearchPlanEN.PlanId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true || clsgs_ResearchPlanBL.IsExist(objgs_ResearchPlanEN.PlanId) == true)
 {
     objgs_ResearchPlanEN.PlanId = clsgs_ResearchPlanBL.GetMaxStrId_S();
 }
string strKey = gs_ResearchPlanDA.AddNewRecordBySQL2WithReturnKey(objgs_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
try
{
bool bolResult = gs_ResearchPlanDA.Update(objgs_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "objgs_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 if (string.IsNullOrEmpty(objgs_ResearchPlanEN.PlanId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_ResearchPlanDA.UpdateBySql2(objgs_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_ResearchPlanBL.ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
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
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strPlanId)
{
try
{
 clsgs_ResearchPlanEN objgs_ResearchPlanEN = clsgs_ResearchPlanBL.GetObjByPlanId(strPlanId);

if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(objgs_ResearchPlanEN.PlanId, objgs_ResearchPlanEN.UpdUser);
}
if (objgs_ResearchPlanEN != null)
{
int intRecNum = gs_ResearchPlanDA.DelRecord(strPlanId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);
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
/// <param name="strPlanId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strPlanId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
//删除与表:[gs_ResearchPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_ResearchPlan.PlanId,
//strPlanId);
//        clsgs_ResearchPlanBL.Delgs_ResearchPlansByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ResearchPlanBL.DelRecord(strPlanId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ResearchPlanBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPlanId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strPlanId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strPlanId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_ResearchPlanBL.relatedActions != null)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(strPlanId, "UpdRelaTabDate");
}
bool bolResult = gs_ResearchPlanDA.DelRecord(strPlanId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
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
 /// <param name = "arrPlanIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_ResearchPlans(List<string> arrPlanIdLst)
{
if (arrPlanIdLst.Count == 0) return 0;
try
{
if (clsgs_ResearchPlanBL.relatedActions != null)
{
foreach (var strPlanId in arrPlanIdLst)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(strPlanId, "UpdRelaTabDate");
}
}
 clsgs_ResearchPlanEN objgs_ResearchPlanEN = clsgs_ResearchPlanBL.GetObjByPlanId(arrPlanIdLst[0]);
int intDelRecNum = gs_ResearchPlanDA.Delgs_ResearchPlan(arrPlanIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_ResearchPlanEN.IdCurrEduCls);
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
public static int Delgs_ResearchPlansByCond(string strWhereCond)
{
try
{
if (clsgs_ResearchPlanBL.relatedActions != null)
{
List<string> arrPlanId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strPlanId in arrPlanId)
{
clsgs_ResearchPlanBL.relatedActions.UpdRelaTabDate(strPlanId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(congs_ResearchPlan.IdCurrEduCls, strWhereCond);
int intRecNum = gs_ResearchPlanDA.Delgs_ResearchPlan(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_ResearchPlan]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strPlanId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strPlanId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_ResearchPlanDA.GetSpecSQLObj();
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
//删除与表:[gs_ResearchPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_ResearchPlanBL.DelRecord(strPlanId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_ResearchPlanBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strPlanId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_ResearchPlanENS">源对象</param>
 /// <param name = "objgs_ResearchPlanENT">目标对象</param>
 public static void CopyTo(clsgs_ResearchPlanEN objgs_ResearchPlanENS, clsgs_ResearchPlanEN objgs_ResearchPlanENT)
{
try
{
objgs_ResearchPlanENT.PlanId = objgs_ResearchPlanENS.PlanId; //计划Id
objgs_ResearchPlanENT.TopicId = objgs_ResearchPlanENS.TopicId; //主题Id
objgs_ResearchPlanENT.StatusId = objgs_ResearchPlanENS.StatusId; //状态Id
objgs_ResearchPlanENT.PlanContent = objgs_ResearchPlanENS.PlanContent; //计划内容
objgs_ResearchPlanENT.ResponsibleUser = objgs_ResearchPlanENS.ResponsibleUser; //负责人/小组
objgs_ResearchPlanENT.StartDate = objgs_ResearchPlanENS.StartDate; //开始日期
objgs_ResearchPlanENT.EndDate = objgs_ResearchPlanENS.EndDate; //截止日期
objgs_ResearchPlanENT.ActualFinishingDate = objgs_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objgs_ResearchPlanENT.AcceptanceUser = objgs_ResearchPlanENS.AcceptanceUser; //验收用户
objgs_ResearchPlanENT.IsSubmit = objgs_ResearchPlanENS.IsSubmit; //是否提交
objgs_ResearchPlanENT.UpdUser = objgs_ResearchPlanENS.UpdUser; //修改人
objgs_ResearchPlanENT.UpdDate = objgs_ResearchPlanENS.UpdDate; //修改日期
objgs_ResearchPlanENT.Memo = objgs_ResearchPlanENS.Memo; //备注
objgs_ResearchPlanENT.PlanTypeId = objgs_ResearchPlanENS.PlanTypeId; //计划类型
objgs_ResearchPlanENT.IdCurrEduCls = objgs_ResearchPlanENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objgs_ResearchPlanEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
try
{
objgs_ResearchPlanEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_ResearchPlanEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_ResearchPlan.PlanId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.PlanId = objgs_ResearchPlanEN.PlanId; //计划Id
}
if (arrFldSet.Contains(congs_ResearchPlan.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.TopicId = objgs_ResearchPlanEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_ResearchPlan.StatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.StatusId = objgs_ResearchPlanEN.StatusId; //状态Id
}
if (arrFldSet.Contains(congs_ResearchPlan.PlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.PlanContent = objgs_ResearchPlanEN.PlanContent == "[null]" ? null :  objgs_ResearchPlanEN.PlanContent; //计划内容
}
if (arrFldSet.Contains(congs_ResearchPlan.ResponsibleUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.ResponsibleUser = objgs_ResearchPlanEN.ResponsibleUser == "[null]" ? null :  objgs_ResearchPlanEN.ResponsibleUser; //负责人/小组
}
if (arrFldSet.Contains(congs_ResearchPlan.StartDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.StartDate = objgs_ResearchPlanEN.StartDate == "[null]" ? null :  objgs_ResearchPlanEN.StartDate; //开始日期
}
if (arrFldSet.Contains(congs_ResearchPlan.EndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.EndDate = objgs_ResearchPlanEN.EndDate == "[null]" ? null :  objgs_ResearchPlanEN.EndDate; //截止日期
}
if (arrFldSet.Contains(congs_ResearchPlan.ActualFinishingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.ActualFinishingDate = objgs_ResearchPlanEN.ActualFinishingDate == "[null]" ? null :  objgs_ResearchPlanEN.ActualFinishingDate; //实际完成日期
}
if (arrFldSet.Contains(congs_ResearchPlan.AcceptanceUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.AcceptanceUser = objgs_ResearchPlanEN.AcceptanceUser == "[null]" ? null :  objgs_ResearchPlanEN.AcceptanceUser; //验收用户
}
if (arrFldSet.Contains(congs_ResearchPlan.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.IsSubmit = objgs_ResearchPlanEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(congs_ResearchPlan.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.UpdUser = objgs_ResearchPlanEN.UpdUser == "[null]" ? null :  objgs_ResearchPlanEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_ResearchPlan.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.UpdDate = objgs_ResearchPlanEN.UpdDate == "[null]" ? null :  objgs_ResearchPlanEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_ResearchPlan.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.Memo = objgs_ResearchPlanEN.Memo == "[null]" ? null :  objgs_ResearchPlanEN.Memo; //备注
}
if (arrFldSet.Contains(congs_ResearchPlan.PlanTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.PlanTypeId = objgs_ResearchPlanEN.PlanTypeId == "[null]" ? null :  objgs_ResearchPlanEN.PlanTypeId; //计划类型
}
if (arrFldSet.Contains(congs_ResearchPlan.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_ResearchPlanEN.IdCurrEduCls = objgs_ResearchPlanEN.IdCurrEduCls == "[null]" ? null :  objgs_ResearchPlanEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objgs_ResearchPlanEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
try
{
if (objgs_ResearchPlanEN.PlanContent == "[null]") objgs_ResearchPlanEN.PlanContent = null; //计划内容
if (objgs_ResearchPlanEN.ResponsibleUser == "[null]") objgs_ResearchPlanEN.ResponsibleUser = null; //负责人/小组
if (objgs_ResearchPlanEN.StartDate == "[null]") objgs_ResearchPlanEN.StartDate = null; //开始日期
if (objgs_ResearchPlanEN.EndDate == "[null]") objgs_ResearchPlanEN.EndDate = null; //截止日期
if (objgs_ResearchPlanEN.ActualFinishingDate == "[null]") objgs_ResearchPlanEN.ActualFinishingDate = null; //实际完成日期
if (objgs_ResearchPlanEN.AcceptanceUser == "[null]") objgs_ResearchPlanEN.AcceptanceUser = null; //验收用户
if (objgs_ResearchPlanEN.UpdUser == "[null]") objgs_ResearchPlanEN.UpdUser = null; //修改人
if (objgs_ResearchPlanEN.UpdDate == "[null]") objgs_ResearchPlanEN.UpdDate = null; //修改日期
if (objgs_ResearchPlanEN.Memo == "[null]") objgs_ResearchPlanEN.Memo = null; //备注
if (objgs_ResearchPlanEN.PlanTypeId == "[null]") objgs_ResearchPlanEN.PlanTypeId = null; //计划类型
if (objgs_ResearchPlanEN.IdCurrEduCls == "[null]") objgs_ResearchPlanEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckPropertyNew(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 gs_ResearchPlanDA.CheckPropertyNew(objgs_ResearchPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
 gs_ResearchPlanDA.CheckProperty4Condition(objgs_ResearchPlanEN);
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
if (clsgs_ResearchPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ResearchPlanBL没有刷新缓存机制(clsgs_ResearchPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PlanId");
//if (arrgs_ResearchPlanObjLstCache == null)
//{
//arrgs_ResearchPlanObjLstCache = gs_ResearchPlanDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPlanId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_ResearchPlanEN GetObjByPlanIdCache(string strPlanId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
List<clsgs_ResearchPlanEN> arrgs_ResearchPlanObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_ResearchPlanEN> arrgs_ResearchPlanObjLst_Sel =
arrgs_ResearchPlanObjLstCache
.Where(x=> x.PlanId == strPlanId 
);
if (arrgs_ResearchPlanObjLst_Sel.Count() == 0)
{
   clsgs_ResearchPlanEN obj = clsgs_ResearchPlanBL.GetObjByPlanId(strPlanId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strPlanId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrgs_ResearchPlanObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ResearchPlanEN> GetAllgs_ResearchPlanObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsgs_ResearchPlanEN> arrgs_ResearchPlanObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrgs_ResearchPlanObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_ResearchPlanEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsgs_ResearchPlanEN> arrgs_ResearchPlanObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_ResearchPlanObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_ResearchPlanEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_ResearchPlanEN._RefreshTimeLst.Count == 0) return "";
return clsgs_ResearchPlanEN._RefreshTimeLst[clsgs_ResearchPlanEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_ResearchPlanBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_ResearchPlanEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_ResearchPlanBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_ResearchPlan(主题研究计划)
 /// 唯一性条件:PlanId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_ResearchPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_ResearchPlanEN objgs_ResearchPlanEN)
{
//检测记录是否存在
string strResult = gs_ResearchPlanDA.GetUniCondStr(objgs_ResearchPlanEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPlanId, string strIdCurrEduCls)
{
if (strInFldName != congs_ResearchPlan.PlanId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_ResearchPlan.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_ResearchPlan.AttributeName));
throw new Exception(strMsg);
}
var objgs_ResearchPlan = clsgs_ResearchPlanBL.GetObjByPlanIdCache(strPlanId, strIdCurrEduCls);
if (objgs_ResearchPlan == null) return "";
return objgs_ResearchPlan[strOutFldName].ToString();
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
int intRecCount = clsgs_ResearchPlanDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_ResearchPlanDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_ResearchPlanDA.GetRecCount();
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
int intRecCount = clsgs_ResearchPlanDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_ResearchPlanEN objgs_ResearchPlanCond)
{
 string strIdCurrEduCls = objgs_ResearchPlanCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_ResearchPlanBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_ResearchPlanEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_ResearchPlan.AttributeName)
{
if (objgs_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objgs_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objgs_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_ResearchPlanCond[strFldName]));
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
 List<string> arrList = clsgs_ResearchPlanDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_ResearchPlanDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_ResearchPlanDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_ResearchPlanDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ResearchPlanDA.SetFldValue(clsgs_ResearchPlanEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_ResearchPlanDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ResearchPlanDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_ResearchPlanDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_ResearchPlanDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_ResearchPlan] "); 
 strCreateTabCode.Append(" ( "); 
 // /**计划Id*/ 
 strCreateTabCode.Append(" PlanId char(8) primary key, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) not Null, "); 
 // /**状态Id*/ 
 strCreateTabCode.Append(" StatusId char(2) not Null, "); 
 // /**计划内容*/ 
 strCreateTabCode.Append(" PlanContent varchar(1000) Null, "); 
 // /**负责人/小组*/ 
 strCreateTabCode.Append(" ResponsibleUser varchar(50) Null, "); 
 // /**开始日期*/ 
 strCreateTabCode.Append(" StartDate varchar(20) Null, "); 
 // /**截止日期*/ 
 strCreateTabCode.Append(" EndDate varchar(20) Null, "); 
 // /**实际完成日期*/ 
 strCreateTabCode.Append(" ActualFinishingDate varchar(20) Null, "); 
 // /**验收用户*/ 
 strCreateTabCode.Append(" AcceptanceUser varchar(50) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**计划类型*/ 
 strCreateTabCode.Append(" PlanTypeId char(2) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 主题研究计划(gs_ResearchPlan)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_ResearchPlan : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
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
clsgs_ResearchPlanBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}