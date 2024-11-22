
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ResearchPlanBL
 表名:zx_ResearchPlan(01120729)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学小组课文(zxGroupText)
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
public static class  clszx_ResearchPlanBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ResearchPlanEN GetObj(this K_zxPlanId_zx_ResearchPlan myKey)
{
clszx_ResearchPlanEN objzx_ResearchPlanEN = clszx_ResearchPlanBL.zx_ResearchPlanDA.GetObjByzxPlanId(myKey.Value);
return objzx_ResearchPlanEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
if (CheckUniqueness(objzx_ResearchPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ResearchPlanBL.AddNewRecord)", objzx_ResearchPlanEN.zxPlanId,objzx_ResearchPlanEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true || clszx_ResearchPlanBL.IsExist(objzx_ResearchPlanEN.zxPlanId) == true)
 {
     objzx_ResearchPlanEN.zxPlanId = clszx_ResearchPlanBL.GetMaxStrId_S();
 }
bool bolResult = clszx_ResearchPlanBL.zx_ResearchPlanDA.AddNewRecordBySQL2(objzx_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_ResearchPlanBL.IsExist(objzx_ResearchPlanEN.zxPlanId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_ResearchPlanEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ResearchPlanEN.CheckUniqueness() == false)
{
strMsg = string.Format("(计划Id(zxPlanId)=[{0}],小组Id(GroupTextId)=[{1}])已经存在,不能重复!", objzx_ResearchPlanEN.zxPlanId, objzx_ResearchPlanEN.GroupTextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true || clszx_ResearchPlanBL.IsExist(objzx_ResearchPlanEN.zxPlanId) == true)
 {
     objzx_ResearchPlanEN.zxPlanId = clszx_ResearchPlanBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_ResearchPlanEN.AddNewRecord();
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
if (CheckUniqueness(objzx_ResearchPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ResearchPlanBL.AddNewRecordWithMaxId)", objzx_ResearchPlanEN.zxPlanId,objzx_ResearchPlanEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true || clszx_ResearchPlanBL.IsExist(objzx_ResearchPlanEN.zxPlanId) == true)
 {
     objzx_ResearchPlanEN.zxPlanId = clszx_ResearchPlanBL.GetMaxStrId_S();
 }
string strzxPlanId = clszx_ResearchPlanBL.zx_ResearchPlanDA.AddNewRecordBySQL2WithReturnKey(objzx_ResearchPlanEN);
     objzx_ResearchPlanEN.zxPlanId = strzxPlanId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
}
return strzxPlanId;
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
if (CheckUniqueness(objzx_ResearchPlanEN) == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ResearchPlanBL.AddNewRecordWithReturnKey)", objzx_ResearchPlanEN.zxPlanId,objzx_ResearchPlanEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true || clszx_ResearchPlanBL.IsExist(objzx_ResearchPlanEN.zxPlanId) == true)
 {
     objzx_ResearchPlanEN.zxPlanId = clszx_ResearchPlanBL.GetMaxStrId_S();
 }
string strKey = clszx_ResearchPlanBL.zx_ResearchPlanDA.AddNewRecordBySQL2WithReturnKey(objzx_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetzxPlanId(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strzxPlanId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxPlanId, 8, conzx_ResearchPlan.zxPlanId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxPlanId, 8, conzx_ResearchPlan.zxPlanId);
}
objzx_ResearchPlanEN.zxPlanId = strzxPlanId; //计划Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.zxPlanId) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.zxPlanId, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.zxPlanId] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetzxStatusId(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strzxStatusId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxStatusId, conzx_ResearchPlan.zxStatusId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxStatusId, 2, conzx_ResearchPlan.zxStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxStatusId, 2, conzx_ResearchPlan.zxStatusId);
}
objzx_ResearchPlanEN.zxStatusId = strzxStatusId; //状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.zxStatusId) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.zxStatusId, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.zxStatusId] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetPlanContent(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strPlanContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanContent, 1000, conzx_ResearchPlan.PlanContent);
}
objzx_ResearchPlanEN.PlanContent = strPlanContent; //计划内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.PlanContent) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.PlanContent, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.PlanContent] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetResponsibleUser(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strResponsibleUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResponsibleUser, 50, conzx_ResearchPlan.ResponsibleUser);
}
objzx_ResearchPlanEN.ResponsibleUser = strResponsibleUser; //负责人/小组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.ResponsibleUser) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.ResponsibleUser, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.ResponsibleUser] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetStartDate(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strStartDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartDate, 20, conzx_ResearchPlan.StartDate);
}
objzx_ResearchPlanEN.StartDate = strStartDate; //开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.StartDate) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.StartDate, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.StartDate] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetEndDate(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndDate, 20, conzx_ResearchPlan.EndDate);
}
objzx_ResearchPlanEN.EndDate = strEndDate; //截止日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.EndDate) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.EndDate, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.EndDate] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetActualFinishingDate(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strActualFinishingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strActualFinishingDate, 20, conzx_ResearchPlan.ActualFinishingDate);
}
objzx_ResearchPlanEN.ActualFinishingDate = strActualFinishingDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.ActualFinishingDate) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.ActualFinishingDate, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.ActualFinishingDate] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetAcceptanceUser(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strAcceptanceUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAcceptanceUser, 50, conzx_ResearchPlan.AcceptanceUser);
}
objzx_ResearchPlanEN.AcceptanceUser = strAcceptanceUser; //验收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.AcceptanceUser) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.AcceptanceUser, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.AcceptanceUser] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetIsSubmit(this clszx_ResearchPlanEN objzx_ResearchPlanEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_ResearchPlanEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.IsSubmit) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.IsSubmit, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.IsSubmit] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetUpdUser(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_ResearchPlan.UpdUser);
}
objzx_ResearchPlanEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.UpdUser) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.UpdUser, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.UpdUser] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetUpdDate(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ResearchPlan.UpdDate);
}
objzx_ResearchPlanEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.UpdDate) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.UpdDate, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.UpdDate] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetMemo(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ResearchPlan.Memo);
}
objzx_ResearchPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.Memo) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.Memo, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.Memo] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetPlanTypeId(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strPlanTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanTypeId, 2, conzx_ResearchPlan.PlanTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPlanTypeId, 2, conzx_ResearchPlan.PlanTypeId);
}
objzx_ResearchPlanEN.PlanTypeId = strPlanTypeId; //计划类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.PlanTypeId) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.PlanTypeId, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.PlanTypeId] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ResearchPlanEN SetGroupTextId(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_ResearchPlan.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_ResearchPlan.GroupTextId);
}
objzx_ResearchPlanEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(conzx_ResearchPlan.GroupTextId) == false)
{
objzx_ResearchPlanEN.dicFldComparisonOp.Add(conzx_ResearchPlan.GroupTextId, strComparisonOp);
}
else
{
objzx_ResearchPlanEN.dicFldComparisonOp[conzx_ResearchPlan.GroupTextId] = strComparisonOp;
}
}
return objzx_ResearchPlanEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ResearchPlanEN.CheckPropertyNew();
clszx_ResearchPlanEN objzx_ResearchPlanCond = new clszx_ResearchPlanEN();
string strCondition = objzx_ResearchPlanCond
.SetzxPlanId(objzx_ResearchPlanEN.zxPlanId, "<>")
.SetzxPlanId(objzx_ResearchPlanEN.zxPlanId, "=")
.SetGroupTextId(objzx_ResearchPlanEN.GroupTextId, "=")
.GetCombineCondition();
objzx_ResearchPlanEN._IsCheckProperty = true;
bool bolIsExist = clszx_ResearchPlanBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxPlanId_GroupTextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ResearchPlanEN.Update();
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
 /// <param name = "objzx_ResearchPlan">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ResearchPlanEN objzx_ResearchPlan)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ResearchPlanEN objzx_ResearchPlanCond = new clszx_ResearchPlanEN();
string strCondition = objzx_ResearchPlanCond
.SetzxPlanId(objzx_ResearchPlan.zxPlanId, "=")
.SetGroupTextId(objzx_ResearchPlan.GroupTextId, "=")
.GetCombineCondition();
objzx_ResearchPlan._IsCheckProperty = true;
bool bolIsExist = clszx_ResearchPlanBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ResearchPlan.zxPlanId = clszx_ResearchPlanBL.GetFirstID_S(strCondition);
objzx_ResearchPlan.UpdateWithCondition(strCondition);
}
else
{
objzx_ResearchPlan.zxPlanId = clszx_ResearchPlanBL.GetMaxStrId_S();
objzx_ResearchPlan.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ResearchPlanBL.zx_ResearchPlanDA.UpdateBySql2(objzx_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ResearchPlanEN objzx_ResearchPlanEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ResearchPlanBL.zx_ResearchPlanDA.UpdateBySql2(objzx_ResearchPlanEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ResearchPlanBL.zx_ResearchPlanDA.UpdateBySqlWithCondition(objzx_ResearchPlanEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ResearchPlanEN objzx_ResearchPlanEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ResearchPlanBL.zx_ResearchPlanDA.UpdateBySqlWithConditionTransaction(objzx_ResearchPlanEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
try
{
int intRecNum = clszx_ResearchPlanBL.zx_ResearchPlanDA.DelRecord(objzx_ResearchPlanEN.zxPlanId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanENS">源对象</param>
 /// <param name = "objzx_ResearchPlanENT">目标对象</param>
 public static void CopyTo(this clszx_ResearchPlanEN objzx_ResearchPlanENS, clszx_ResearchPlanEN objzx_ResearchPlanENT)
{
try
{
objzx_ResearchPlanENT.zxPlanId = objzx_ResearchPlanENS.zxPlanId; //计划Id
objzx_ResearchPlanENT.zxStatusId = objzx_ResearchPlanENS.zxStatusId; //状态Id
objzx_ResearchPlanENT.PlanContent = objzx_ResearchPlanENS.PlanContent; //计划内容
objzx_ResearchPlanENT.ResponsibleUser = objzx_ResearchPlanENS.ResponsibleUser; //负责人/小组
objzx_ResearchPlanENT.StartDate = objzx_ResearchPlanENS.StartDate; //开始日期
objzx_ResearchPlanENT.EndDate = objzx_ResearchPlanENS.EndDate; //截止日期
objzx_ResearchPlanENT.ActualFinishingDate = objzx_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objzx_ResearchPlanENT.AcceptanceUser = objzx_ResearchPlanENS.AcceptanceUser; //验收用户
objzx_ResearchPlanENT.IsSubmit = objzx_ResearchPlanENS.IsSubmit; //是否提交
objzx_ResearchPlanENT.UpdUser = objzx_ResearchPlanENS.UpdUser; //修改人
objzx_ResearchPlanENT.UpdDate = objzx_ResearchPlanENS.UpdDate; //修改日期
objzx_ResearchPlanENT.Memo = objzx_ResearchPlanENS.Memo; //备注
objzx_ResearchPlanENT.PlanTypeId = objzx_ResearchPlanENS.PlanTypeId; //计划类型
objzx_ResearchPlanENT.GroupTextId = objzx_ResearchPlanENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clszx_ResearchPlanEN:objzx_ResearchPlanENT</returns>
 public static clszx_ResearchPlanEN CopyTo(this clszx_ResearchPlanEN objzx_ResearchPlanENS)
{
try
{
 clszx_ResearchPlanEN objzx_ResearchPlanENT = new clszx_ResearchPlanEN()
{
zxPlanId = objzx_ResearchPlanENS.zxPlanId, //计划Id
zxStatusId = objzx_ResearchPlanENS.zxStatusId, //状态Id
PlanContent = objzx_ResearchPlanENS.PlanContent, //计划内容
ResponsibleUser = objzx_ResearchPlanENS.ResponsibleUser, //负责人/小组
StartDate = objzx_ResearchPlanENS.StartDate, //开始日期
EndDate = objzx_ResearchPlanENS.EndDate, //截止日期
ActualFinishingDate = objzx_ResearchPlanENS.ActualFinishingDate, //实际完成日期
AcceptanceUser = objzx_ResearchPlanENS.AcceptanceUser, //验收用户
IsSubmit = objzx_ResearchPlanENS.IsSubmit, //是否提交
UpdUser = objzx_ResearchPlanENS.UpdUser, //修改人
UpdDate = objzx_ResearchPlanENS.UpdDate, //修改日期
Memo = objzx_ResearchPlanENS.Memo, //备注
PlanTypeId = objzx_ResearchPlanENS.PlanTypeId, //计划类型
GroupTextId = objzx_ResearchPlanENS.GroupTextId, //小组Id
};
 return objzx_ResearchPlanENT;
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
public static void CheckPropertyNew(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 clszx_ResearchPlanBL.zx_ResearchPlanDA.CheckPropertyNew(objzx_ResearchPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 clszx_ResearchPlanBL.zx_ResearchPlanDA.CheckProperty4Condition(objzx_ResearchPlanEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ResearchPlanEN objzx_ResearchPlanCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.zxPlanId) == true)
{
string strComparisonOpzxPlanId = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.zxPlanId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.zxPlanId, objzx_ResearchPlanCond.zxPlanId, strComparisonOpzxPlanId);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.zxStatusId) == true)
{
string strComparisonOpzxStatusId = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.zxStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.zxStatusId, objzx_ResearchPlanCond.zxStatusId, strComparisonOpzxStatusId);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.PlanContent) == true)
{
string strComparisonOpPlanContent = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.PlanContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.PlanContent, objzx_ResearchPlanCond.PlanContent, strComparisonOpPlanContent);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.ResponsibleUser) == true)
{
string strComparisonOpResponsibleUser = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.ResponsibleUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.ResponsibleUser, objzx_ResearchPlanCond.ResponsibleUser, strComparisonOpResponsibleUser);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.StartDate) == true)
{
string strComparisonOpStartDate = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.StartDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.StartDate, objzx_ResearchPlanCond.StartDate, strComparisonOpStartDate);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.EndDate) == true)
{
string strComparisonOpEndDate = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.EndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.EndDate, objzx_ResearchPlanCond.EndDate, strComparisonOpEndDate);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.ActualFinishingDate) == true)
{
string strComparisonOpActualFinishingDate = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.ActualFinishingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.ActualFinishingDate, objzx_ResearchPlanCond.ActualFinishingDate, strComparisonOpActualFinishingDate);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.AcceptanceUser) == true)
{
string strComparisonOpAcceptanceUser = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.AcceptanceUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.AcceptanceUser, objzx_ResearchPlanCond.AcceptanceUser, strComparisonOpAcceptanceUser);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.IsSubmit) == true)
{
if (objzx_ResearchPlanCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_ResearchPlan.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_ResearchPlan.IsSubmit);
}
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.UpdUser, objzx_ResearchPlanCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.UpdDate, objzx_ResearchPlanCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.Memo) == true)
{
string strComparisonOpMemo = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.Memo, objzx_ResearchPlanCond.Memo, strComparisonOpMemo);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.PlanTypeId) == true)
{
string strComparisonOpPlanTypeId = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.PlanTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.PlanTypeId, objzx_ResearchPlanCond.PlanTypeId, strComparisonOpPlanTypeId);
}
if (objzx_ResearchPlanCond.IsUpdated(conzx_ResearchPlan.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_ResearchPlanCond.dicFldComparisonOp[conzx_ResearchPlan.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ResearchPlan.GroupTextId, objzx_ResearchPlanCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ResearchPlan(中学研究计划), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxPlanId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ResearchPlanEN == null) return true;
if (objzx_ResearchPlanEN.zxPlanId == null || objzx_ResearchPlanEN.zxPlanId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxPlanId = '{0}'", objzx_ResearchPlanEN.zxPlanId);
 if (objzx_ResearchPlanEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ResearchPlanEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchPlanEN.GroupTextId);
}
if (clszx_ResearchPlanBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxPlanId !=  '{0}'", objzx_ResearchPlanEN.zxPlanId);
 sbCondition.AppendFormat(" and zxPlanId = '{0}'", objzx_ResearchPlanEN.zxPlanId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchPlanEN.GroupTextId);
if (clszx_ResearchPlanBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ResearchPlan(中学研究计划), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxPlanId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ResearchPlanEN == null) return "";
if (objzx_ResearchPlanEN.zxPlanId == null || objzx_ResearchPlanEN.zxPlanId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxPlanId = '{0}'", objzx_ResearchPlanEN.zxPlanId);
 if (objzx_ResearchPlanEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ResearchPlanEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchPlanEN.GroupTextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxPlanId !=  '{0}'", objzx_ResearchPlanEN.zxPlanId);
 sbCondition.AppendFormat(" and zxPlanId = '{0}'", objzx_ResearchPlanEN.zxPlanId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ResearchPlanEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ResearchPlan
{
public virtual bool UpdRelaTabDate(string strzxPlanId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学研究计划(zx_ResearchPlan)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ResearchPlanBL
{
public static RelatedActions_zx_ResearchPlan relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ResearchPlanDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ResearchPlanDA zx_ResearchPlanDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ResearchPlanDA();
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
 public clszx_ResearchPlanBL()
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
if (string.IsNullOrEmpty(clszx_ResearchPlanEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ResearchPlanEN._ConnectString);
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
public static DataTable GetDataTable_zx_ResearchPlan(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ResearchPlanDA.GetDataTable_zx_ResearchPlan(strWhereCond);
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
objDT = zx_ResearchPlanDA.GetDataTable(strWhereCond);
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
objDT = zx_ResearchPlanDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ResearchPlanDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ResearchPlanDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ResearchPlanDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ResearchPlanDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxPlanIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ResearchPlanEN> GetObjLstByZxPlanIdLst(List<string> arrZxPlanIdLst)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxPlanIdLst, true);
 string strWhereCond = string.Format("zxPlanId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxPlanIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ResearchPlanEN> GetObjLstByZxPlanIdLstCache(List<string> arrZxPlanIdLst)
{
string strKey = string.Format("{0}", clszx_ResearchPlanEN._CurrTabName);
List<clszx_ResearchPlanEN> arrzx_ResearchPlanObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchPlanEN> arrzx_ResearchPlanObjLst_Sel =
arrzx_ResearchPlanObjLstCache
.Where(x => arrZxPlanIdLst.Contains(x.zxPlanId));
return arrzx_ResearchPlanObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ResearchPlanEN> GetObjLst(string strWhereCond)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
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
public static List<clszx_ResearchPlanEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ResearchPlanEN> GetSubObjLstCache(clszx_ResearchPlanEN objzx_ResearchPlanCond)
{
List<clszx_ResearchPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ResearchPlan.AttributeName)
{
if (objzx_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objzx_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objzx_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ResearchPlanCond[strFldName]));
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
public static List<clszx_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
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
public static List<clszx_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
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
List<clszx_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ResearchPlanEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
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
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
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
public static List<clszx_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ResearchPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
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
public static List<clszx_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ResearchPlanEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ResearchPlanEN> arrObjLst = new List<clszx_ResearchPlanEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ResearchPlanEN objzx_ResearchPlanEN = new clszx_ResearchPlanEN();
try
{
objzx_ResearchPlanEN.zxPlanId = objRow[conzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objzx_ResearchPlanEN.zxStatusId = objRow[conzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objzx_ResearchPlanEN.PlanContent = objRow[conzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objzx_ResearchPlanEN.ResponsibleUser = objRow[conzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objzx_ResearchPlanEN.StartDate = objRow[conzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objzx_ResearchPlanEN.EndDate = objRow[conzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objzx_ResearchPlanEN.ActualFinishingDate = objRow[conzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objzx_ResearchPlanEN.AcceptanceUser = objRow[conzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objzx_ResearchPlanEN.UpdUser = objRow[conzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objzx_ResearchPlanEN.UpdDate = objRow[conzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[conzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objzx_ResearchPlanEN.Memo = objRow[conzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[conzx_ResearchPlan.Memo].ToString().Trim(); //备注
objzx_ResearchPlanEN.PlanTypeId = objRow[conzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objzx_ResearchPlanEN.GroupTextId = objRow[conzx_ResearchPlan.GroupTextId] == DBNull.Value ? null : objRow[conzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ResearchPlanEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ResearchPlan(ref clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
bool bolResult = zx_ResearchPlanDA.Getzx_ResearchPlan(ref objzx_ResearchPlanEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ResearchPlanEN GetObjByzxPlanId(string strzxPlanId)
{
if (strzxPlanId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxPlanId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxPlanId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxPlanId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_ResearchPlanEN objzx_ResearchPlanEN = zx_ResearchPlanDA.GetObjByzxPlanId(strzxPlanId);
return objzx_ResearchPlanEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ResearchPlanEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ResearchPlanEN objzx_ResearchPlanEN = zx_ResearchPlanDA.GetFirstObj(strWhereCond);
 return objzx_ResearchPlanEN;
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
public static clszx_ResearchPlanEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ResearchPlanEN objzx_ResearchPlanEN = zx_ResearchPlanDA.GetObjByDataRow(objRow);
 return objzx_ResearchPlanEN;
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
public static clszx_ResearchPlanEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ResearchPlanEN objzx_ResearchPlanEN = zx_ResearchPlanDA.GetObjByDataRow(objRow);
 return objzx_ResearchPlanEN;
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
 /// <param name = "strzxPlanId">所给的关键字</param>
 /// <param name = "lstzx_ResearchPlanObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ResearchPlanEN GetObjByzxPlanIdFromList(string strzxPlanId, List<clszx_ResearchPlanEN> lstzx_ResearchPlanObjLst)
{
foreach (clszx_ResearchPlanEN objzx_ResearchPlanEN in lstzx_ResearchPlanObjLst)
{
if (objzx_ResearchPlanEN.zxPlanId == strzxPlanId)
{
return objzx_ResearchPlanEN;
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
 string strMaxZxPlanId;
 try
 {
 strMaxZxPlanId = clszx_ResearchPlanDA.GetMaxStrId();
 return strMaxZxPlanId;
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
 string strzxPlanId;
 try
 {
 strzxPlanId = new clszx_ResearchPlanDA().GetFirstID(strWhereCond);
 return strzxPlanId;
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
 arrList = zx_ResearchPlanDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ResearchPlanDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxPlanId)
{
if (string.IsNullOrEmpty(strzxPlanId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxPlanId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_ResearchPlanDA.IsExist(strzxPlanId);
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
 bolIsExist = clszx_ResearchPlanDA.IsExistTable();
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
 bolIsExist = zx_ResearchPlanDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
if (objzx_ResearchPlanEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ResearchPlanBL.AddNewRecordBySql2)", objzx_ResearchPlanEN.zxPlanId,objzx_ResearchPlanEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true || clszx_ResearchPlanBL.IsExist(objzx_ResearchPlanEN.zxPlanId) == true)
 {
     objzx_ResearchPlanEN.zxPlanId = clszx_ResearchPlanBL.GetMaxStrId_S();
 }
bool bolResult = zx_ResearchPlanDA.AddNewRecordBySQL2(objzx_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
if (objzx_ResearchPlanEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!计划Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ResearchPlanBL.AddNewRecordBySql2WithReturnKey)", objzx_ResearchPlanEN.zxPlanId,objzx_ResearchPlanEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true || clszx_ResearchPlanBL.IsExist(objzx_ResearchPlanEN.zxPlanId) == true)
 {
     objzx_ResearchPlanEN.zxPlanId = clszx_ResearchPlanBL.GetMaxStrId_S();
 }
string strKey = zx_ResearchPlanDA.AddNewRecordBySQL2WithReturnKey(objzx_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
try
{
bool bolResult = zx_ResearchPlanDA.Update(objzx_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "objzx_ResearchPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 if (string.IsNullOrEmpty(objzx_ResearchPlanEN.zxPlanId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ResearchPlanDA.UpdateBySql2(objzx_ResearchPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ResearchPlanBL.ReFreshCache();

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
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
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxPlanId)
{
try
{
 clszx_ResearchPlanEN objzx_ResearchPlanEN = clszx_ResearchPlanBL.GetObjByzxPlanId(strzxPlanId);

if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(objzx_ResearchPlanEN.zxPlanId, "SetUpdDate");
}
if (objzx_ResearchPlanEN != null)
{
int intRecNum = zx_ResearchPlanDA.DelRecord(strzxPlanId);
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
/// <param name="strzxPlanId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxPlanId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
//删除与表:[zx_ResearchPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ResearchPlan.zxPlanId,
//strzxPlanId);
//        clszx_ResearchPlanBL.Delzx_ResearchPlansByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ResearchPlanBL.DelRecord(strzxPlanId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ResearchPlanBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxPlanId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxPlanId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxPlanId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ResearchPlanBL.relatedActions != null)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(strzxPlanId, "UpdRelaTabDate");
}
bool bolResult = zx_ResearchPlanDA.DelRecord(strzxPlanId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxPlanIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ResearchPlans(List<string> arrzxPlanIdLst)
{
if (arrzxPlanIdLst.Count == 0) return 0;
try
{
if (clszx_ResearchPlanBL.relatedActions != null)
{
foreach (var strzxPlanId in arrzxPlanIdLst)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(strzxPlanId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ResearchPlanDA.Delzx_ResearchPlan(arrzxPlanIdLst);
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
public static int Delzx_ResearchPlansByCond(string strWhereCond)
{
try
{
if (clszx_ResearchPlanBL.relatedActions != null)
{
List<string> arrzxPlanId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxPlanId in arrzxPlanId)
{
clszx_ResearchPlanBL.relatedActions.UpdRelaTabDate(strzxPlanId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ResearchPlanDA.Delzx_ResearchPlan(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ResearchPlan]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxPlanId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxPlanId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ResearchPlanDA.GetSpecSQLObj();
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
//删除与表:[zx_ResearchPlan]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ResearchPlanBL.DelRecord(strzxPlanId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ResearchPlanBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxPlanId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ResearchPlanENS">源对象</param>
 /// <param name = "objzx_ResearchPlanENT">目标对象</param>
 public static void CopyTo(clszx_ResearchPlanEN objzx_ResearchPlanENS, clszx_ResearchPlanEN objzx_ResearchPlanENT)
{
try
{
objzx_ResearchPlanENT.zxPlanId = objzx_ResearchPlanENS.zxPlanId; //计划Id
objzx_ResearchPlanENT.zxStatusId = objzx_ResearchPlanENS.zxStatusId; //状态Id
objzx_ResearchPlanENT.PlanContent = objzx_ResearchPlanENS.PlanContent; //计划内容
objzx_ResearchPlanENT.ResponsibleUser = objzx_ResearchPlanENS.ResponsibleUser; //负责人/小组
objzx_ResearchPlanENT.StartDate = objzx_ResearchPlanENS.StartDate; //开始日期
objzx_ResearchPlanENT.EndDate = objzx_ResearchPlanENS.EndDate; //截止日期
objzx_ResearchPlanENT.ActualFinishingDate = objzx_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objzx_ResearchPlanENT.AcceptanceUser = objzx_ResearchPlanENS.AcceptanceUser; //验收用户
objzx_ResearchPlanENT.IsSubmit = objzx_ResearchPlanENS.IsSubmit; //是否提交
objzx_ResearchPlanENT.UpdUser = objzx_ResearchPlanENS.UpdUser; //修改人
objzx_ResearchPlanENT.UpdDate = objzx_ResearchPlanENS.UpdDate; //修改日期
objzx_ResearchPlanENT.Memo = objzx_ResearchPlanENS.Memo; //备注
objzx_ResearchPlanENT.PlanTypeId = objzx_ResearchPlanENS.PlanTypeId; //计划类型
objzx_ResearchPlanENT.GroupTextId = objzx_ResearchPlanENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ResearchPlanEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
try
{
objzx_ResearchPlanEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ResearchPlanEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ResearchPlan.zxPlanId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.zxPlanId = objzx_ResearchPlanEN.zxPlanId; //计划Id
}
if (arrFldSet.Contains(conzx_ResearchPlan.zxStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.zxStatusId = objzx_ResearchPlanEN.zxStatusId; //状态Id
}
if (arrFldSet.Contains(conzx_ResearchPlan.PlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.PlanContent = objzx_ResearchPlanEN.PlanContent == "[null]" ? null :  objzx_ResearchPlanEN.PlanContent; //计划内容
}
if (arrFldSet.Contains(conzx_ResearchPlan.ResponsibleUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.ResponsibleUser = objzx_ResearchPlanEN.ResponsibleUser == "[null]" ? null :  objzx_ResearchPlanEN.ResponsibleUser; //负责人/小组
}
if (arrFldSet.Contains(conzx_ResearchPlan.StartDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.StartDate = objzx_ResearchPlanEN.StartDate == "[null]" ? null :  objzx_ResearchPlanEN.StartDate; //开始日期
}
if (arrFldSet.Contains(conzx_ResearchPlan.EndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.EndDate = objzx_ResearchPlanEN.EndDate == "[null]" ? null :  objzx_ResearchPlanEN.EndDate; //截止日期
}
if (arrFldSet.Contains(conzx_ResearchPlan.ActualFinishingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.ActualFinishingDate = objzx_ResearchPlanEN.ActualFinishingDate == "[null]" ? null :  objzx_ResearchPlanEN.ActualFinishingDate; //实际完成日期
}
if (arrFldSet.Contains(conzx_ResearchPlan.AcceptanceUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.AcceptanceUser = objzx_ResearchPlanEN.AcceptanceUser == "[null]" ? null :  objzx_ResearchPlanEN.AcceptanceUser; //验收用户
}
if (arrFldSet.Contains(conzx_ResearchPlan.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.IsSubmit = objzx_ResearchPlanEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_ResearchPlan.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.UpdUser = objzx_ResearchPlanEN.UpdUser == "[null]" ? null :  objzx_ResearchPlanEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_ResearchPlan.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.UpdDate = objzx_ResearchPlanEN.UpdDate == "[null]" ? null :  objzx_ResearchPlanEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ResearchPlan.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.Memo = objzx_ResearchPlanEN.Memo == "[null]" ? null :  objzx_ResearchPlanEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_ResearchPlan.PlanTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.PlanTypeId = objzx_ResearchPlanEN.PlanTypeId == "[null]" ? null :  objzx_ResearchPlanEN.PlanTypeId; //计划类型
}
if (arrFldSet.Contains(conzx_ResearchPlan.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ResearchPlanEN.GroupTextId = objzx_ResearchPlanEN.GroupTextId == "[null]" ? null :  objzx_ResearchPlanEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_ResearchPlanEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
try
{
if (objzx_ResearchPlanEN.PlanContent == "[null]") objzx_ResearchPlanEN.PlanContent = null; //计划内容
if (objzx_ResearchPlanEN.ResponsibleUser == "[null]") objzx_ResearchPlanEN.ResponsibleUser = null; //负责人/小组
if (objzx_ResearchPlanEN.StartDate == "[null]") objzx_ResearchPlanEN.StartDate = null; //开始日期
if (objzx_ResearchPlanEN.EndDate == "[null]") objzx_ResearchPlanEN.EndDate = null; //截止日期
if (objzx_ResearchPlanEN.ActualFinishingDate == "[null]") objzx_ResearchPlanEN.ActualFinishingDate = null; //实际完成日期
if (objzx_ResearchPlanEN.AcceptanceUser == "[null]") objzx_ResearchPlanEN.AcceptanceUser = null; //验收用户
if (objzx_ResearchPlanEN.UpdUser == "[null]") objzx_ResearchPlanEN.UpdUser = null; //修改人
if (objzx_ResearchPlanEN.UpdDate == "[null]") objzx_ResearchPlanEN.UpdDate = null; //修改日期
if (objzx_ResearchPlanEN.Memo == "[null]") objzx_ResearchPlanEN.Memo = null; //备注
if (objzx_ResearchPlanEN.PlanTypeId == "[null]") objzx_ResearchPlanEN.PlanTypeId = null; //计划类型
if (objzx_ResearchPlanEN.GroupTextId == "[null]") objzx_ResearchPlanEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 zx_ResearchPlanDA.CheckPropertyNew(objzx_ResearchPlanEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
 zx_ResearchPlanDA.CheckProperty4Condition(objzx_ResearchPlanEN);
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
if (clszx_ResearchPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ResearchPlanBL没有刷新缓存机制(clszx_ResearchPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxPlanId");
//if (arrzx_ResearchPlanObjLstCache == null)
//{
//arrzx_ResearchPlanObjLstCache = zx_ResearchPlanDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxPlanId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ResearchPlanEN GetObjByzxPlanIdCache(string strzxPlanId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ResearchPlanEN._CurrTabName);
List<clszx_ResearchPlanEN> arrzx_ResearchPlanObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchPlanEN> arrzx_ResearchPlanObjLst_Sel =
arrzx_ResearchPlanObjLstCache
.Where(x=> x.zxPlanId == strzxPlanId 
);
if (arrzx_ResearchPlanObjLst_Sel.Count() == 0)
{
   clszx_ResearchPlanEN obj = clszx_ResearchPlanBL.GetObjByzxPlanId(strzxPlanId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ResearchPlanObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ResearchPlanEN> GetAllzx_ResearchPlanObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ResearchPlanEN> arrzx_ResearchPlanObjLstCache = GetObjLstCache(); 
return arrzx_ResearchPlanObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ResearchPlanEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ResearchPlanEN._CurrTabName);
List<clszx_ResearchPlanEN> arrzx_ResearchPlanObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ResearchPlanObjLstCache;
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
string strKey = string.Format("{0}", clszx_ResearchPlanEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clszx_ResearchPlanBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ResearchPlanEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ResearchPlanBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ResearchPlan(中学研究计划)
 /// 唯一性条件:zxPlanId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ResearchPlanEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ResearchPlanEN objzx_ResearchPlanEN)
{
//检测记录是否存在
string strResult = zx_ResearchPlanDA.GetUniCondStr(objzx_ResearchPlanEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxPlanId)
{
if (strInFldName != conzx_ResearchPlan.zxPlanId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ResearchPlan.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ResearchPlan.AttributeName));
throw new Exception(strMsg);
}
var objzx_ResearchPlan = clszx_ResearchPlanBL.GetObjByzxPlanIdCache(strzxPlanId);
if (objzx_ResearchPlan == null) return "";
return objzx_ResearchPlan[strOutFldName].ToString();
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
int intRecCount = clszx_ResearchPlanDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ResearchPlanDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ResearchPlanDA.GetRecCount();
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
int intRecCount = clszx_ResearchPlanDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ResearchPlanEN objzx_ResearchPlanCond)
{
List<clszx_ResearchPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ResearchPlan.AttributeName)
{
if (objzx_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objzx_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objzx_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ResearchPlanCond[strFldName]));
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
 List<string> arrList = clszx_ResearchPlanDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ResearchPlanDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ResearchPlanDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ResearchPlanDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ResearchPlanDA.SetFldValue(clszx_ResearchPlanEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ResearchPlanDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ResearchPlanDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ResearchPlanDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ResearchPlanDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ResearchPlan] "); 
 strCreateTabCode.Append(" ( "); 
 // /**计划Id*/ 
 strCreateTabCode.Append(" zxPlanId char(8) primary key, "); 
 // /**状态Id*/ 
 strCreateTabCode.Append(" zxStatusId char(2) not Null, "); 
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
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学研究计划(zx_ResearchPlan)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ResearchPlan : clsCommFun4BL
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
clszx_ResearchPlanBL.ReFreshThisCache();
}
}

}