
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ResearchPlanBL
 表名:vzx_ResearchPlan(01120733)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:03
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
public static class  clsvzx_ResearchPlanBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ResearchPlanEN GetObj(this K_zxPlanId_vzx_ResearchPlan myKey)
{
clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = clsvzx_ResearchPlanBL.vzx_ResearchPlanDA.GetObjByzxPlanId(myKey.Value);
return objvzx_ResearchPlanEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetzxPlanId(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strzxPlanId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxPlanId, 8, convzx_ResearchPlan.zxPlanId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxPlanId, 8, convzx_ResearchPlan.zxPlanId);
}
objvzx_ResearchPlanEN.zxPlanId = strzxPlanId; //计划Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.zxPlanId) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.zxPlanId, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.zxPlanId] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetPlanTypeId(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strPlanTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanTypeId, 2, convzx_ResearchPlan.PlanTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPlanTypeId, 2, convzx_ResearchPlan.PlanTypeId);
}
objvzx_ResearchPlanEN.PlanTypeId = strPlanTypeId; //计划类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.PlanTypeId) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.PlanTypeId, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.PlanTypeId] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetMemo(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_ResearchPlan.Memo);
}
objvzx_ResearchPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.Memo) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.Memo, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.Memo] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetUpdDate(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_ResearchPlan.UpdDate);
}
objvzx_ResearchPlanEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.UpdDate) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.UpdDate, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.UpdDate] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetUpdUser(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_ResearchPlan.UpdUser);
}
objvzx_ResearchPlanEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.UpdUser) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.UpdUser, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.UpdUser] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetIsSubmit(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_ResearchPlanEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.IsSubmit) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.IsSubmit, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.IsSubmit] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetAcceptanceUser(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strAcceptanceUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAcceptanceUser, 50, convzx_ResearchPlan.AcceptanceUser);
}
objvzx_ResearchPlanEN.AcceptanceUser = strAcceptanceUser; //验收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.AcceptanceUser) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.AcceptanceUser, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.AcceptanceUser] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetActualFinishingDate(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strActualFinishingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strActualFinishingDate, 20, convzx_ResearchPlan.ActualFinishingDate);
}
objvzx_ResearchPlanEN.ActualFinishingDate = strActualFinishingDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.ActualFinishingDate) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.ActualFinishingDate, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.ActualFinishingDate] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetEndDate(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndDate, 20, convzx_ResearchPlan.EndDate);
}
objvzx_ResearchPlanEN.EndDate = strEndDate; //截止日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.EndDate) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.EndDate, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.EndDate] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetStartDate(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strStartDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartDate, 20, convzx_ResearchPlan.StartDate);
}
objvzx_ResearchPlanEN.StartDate = strStartDate; //开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.StartDate) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.StartDate, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.StartDate] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetResponsibleUser(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strResponsibleUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResponsibleUser, 50, convzx_ResearchPlan.ResponsibleUser);
}
objvzx_ResearchPlanEN.ResponsibleUser = strResponsibleUser; //负责人/小组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.ResponsibleUser) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.ResponsibleUser, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.ResponsibleUser] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetPlanContent(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strPlanContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanContent, 1000, convzx_ResearchPlan.PlanContent);
}
objvzx_ResearchPlanEN.PlanContent = strPlanContent; //计划内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.PlanContent) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.PlanContent, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.PlanContent] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetzxStatusId(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strzxStatusId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxStatusId, convzx_ResearchPlan.zxStatusId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxStatusId, 2, convzx_ResearchPlan.zxStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxStatusId, 2, convzx_ResearchPlan.zxStatusId);
}
objvzx_ResearchPlanEN.zxStatusId = strzxStatusId; //状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.zxStatusId) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.zxStatusId, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.zxStatusId] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetStatusName(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strStatusName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatusName, 100, convzx_ResearchPlan.StatusName);
}
objvzx_ResearchPlanEN.StatusName = strStatusName; //状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.StatusName) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.StatusName, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.StatusName] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_ResearchPlanEN SetGroupTextId(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN, string strGroupTextId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGroupTextId, convzx_ResearchPlan.GroupTextId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_ResearchPlan.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_ResearchPlan.GroupTextId);
}
objvzx_ResearchPlanEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convzx_ResearchPlan.GroupTextId) == false)
{
objvzx_ResearchPlanEN.dicFldComparisonOp.Add(convzx_ResearchPlan.GroupTextId, strComparisonOp);
}
else
{
objvzx_ResearchPlanEN.dicFldComparisonOp[convzx_ResearchPlan.GroupTextId] = strComparisonOp;
}
}
return objvzx_ResearchPlanEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanENS">源对象</param>
 /// <param name = "objvzx_ResearchPlanENT">目标对象</param>
 public static void CopyTo(this clsvzx_ResearchPlanEN objvzx_ResearchPlanENS, clsvzx_ResearchPlanEN objvzx_ResearchPlanENT)
{
try
{
objvzx_ResearchPlanENT.zxPlanId = objvzx_ResearchPlanENS.zxPlanId; //计划Id
objvzx_ResearchPlanENT.PlanTypeId = objvzx_ResearchPlanENS.PlanTypeId; //计划类型
objvzx_ResearchPlanENT.Memo = objvzx_ResearchPlanENS.Memo; //备注
objvzx_ResearchPlanENT.UpdDate = objvzx_ResearchPlanENS.UpdDate; //修改日期
objvzx_ResearchPlanENT.UpdUser = objvzx_ResearchPlanENS.UpdUser; //修改人
objvzx_ResearchPlanENT.IsSubmit = objvzx_ResearchPlanENS.IsSubmit; //是否提交
objvzx_ResearchPlanENT.AcceptanceUser = objvzx_ResearchPlanENS.AcceptanceUser; //验收用户
objvzx_ResearchPlanENT.ActualFinishingDate = objvzx_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objvzx_ResearchPlanENT.EndDate = objvzx_ResearchPlanENS.EndDate; //截止日期
objvzx_ResearchPlanENT.StartDate = objvzx_ResearchPlanENS.StartDate; //开始日期
objvzx_ResearchPlanENT.ResponsibleUser = objvzx_ResearchPlanENS.ResponsibleUser; //负责人/小组
objvzx_ResearchPlanENT.PlanContent = objvzx_ResearchPlanENS.PlanContent; //计划内容
objvzx_ResearchPlanENT.zxStatusId = objvzx_ResearchPlanENS.zxStatusId; //状态Id
objvzx_ResearchPlanENT.StatusName = objvzx_ResearchPlanENS.StatusName; //状态名称
objvzx_ResearchPlanENT.GroupTextId = objvzx_ResearchPlanENS.GroupTextId; //小组Id
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
 /// <param name = "objvzx_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clsvzx_ResearchPlanEN:objvzx_ResearchPlanENT</returns>
 public static clsvzx_ResearchPlanEN CopyTo(this clsvzx_ResearchPlanEN objvzx_ResearchPlanENS)
{
try
{
 clsvzx_ResearchPlanEN objvzx_ResearchPlanENT = new clsvzx_ResearchPlanEN()
{
zxPlanId = objvzx_ResearchPlanENS.zxPlanId, //计划Id
PlanTypeId = objvzx_ResearchPlanENS.PlanTypeId, //计划类型
Memo = objvzx_ResearchPlanENS.Memo, //备注
UpdDate = objvzx_ResearchPlanENS.UpdDate, //修改日期
UpdUser = objvzx_ResearchPlanENS.UpdUser, //修改人
IsSubmit = objvzx_ResearchPlanENS.IsSubmit, //是否提交
AcceptanceUser = objvzx_ResearchPlanENS.AcceptanceUser, //验收用户
ActualFinishingDate = objvzx_ResearchPlanENS.ActualFinishingDate, //实际完成日期
EndDate = objvzx_ResearchPlanENS.EndDate, //截止日期
StartDate = objvzx_ResearchPlanENS.StartDate, //开始日期
ResponsibleUser = objvzx_ResearchPlanENS.ResponsibleUser, //负责人/小组
PlanContent = objvzx_ResearchPlanENS.PlanContent, //计划内容
zxStatusId = objvzx_ResearchPlanENS.zxStatusId, //状态Id
StatusName = objvzx_ResearchPlanENS.StatusName, //状态名称
GroupTextId = objvzx_ResearchPlanENS.GroupTextId, //小组Id
};
 return objvzx_ResearchPlanENT;
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
public static void CheckProperty4Condition(this clsvzx_ResearchPlanEN objvzx_ResearchPlanEN)
{
 clsvzx_ResearchPlanBL.vzx_ResearchPlanDA.CheckProperty4Condition(objvzx_ResearchPlanEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_ResearchPlanEN objvzx_ResearchPlanCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.zxPlanId) == true)
{
string strComparisonOpzxPlanId = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.zxPlanId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.zxPlanId, objvzx_ResearchPlanCond.zxPlanId, strComparisonOpzxPlanId);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.PlanTypeId) == true)
{
string strComparisonOpPlanTypeId = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.PlanTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.PlanTypeId, objvzx_ResearchPlanCond.PlanTypeId, strComparisonOpPlanTypeId);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.Memo) == true)
{
string strComparisonOpMemo = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.Memo, objvzx_ResearchPlanCond.Memo, strComparisonOpMemo);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.UpdDate, objvzx_ResearchPlanCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.UpdUser, objvzx_ResearchPlanCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.IsSubmit) == true)
{
if (objvzx_ResearchPlanCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_ResearchPlan.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_ResearchPlan.IsSubmit);
}
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.AcceptanceUser) == true)
{
string strComparisonOpAcceptanceUser = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.AcceptanceUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.AcceptanceUser, objvzx_ResearchPlanCond.AcceptanceUser, strComparisonOpAcceptanceUser);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.ActualFinishingDate) == true)
{
string strComparisonOpActualFinishingDate = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.ActualFinishingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.ActualFinishingDate, objvzx_ResearchPlanCond.ActualFinishingDate, strComparisonOpActualFinishingDate);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.EndDate) == true)
{
string strComparisonOpEndDate = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.EndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.EndDate, objvzx_ResearchPlanCond.EndDate, strComparisonOpEndDate);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.StartDate) == true)
{
string strComparisonOpStartDate = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.StartDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.StartDate, objvzx_ResearchPlanCond.StartDate, strComparisonOpStartDate);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.ResponsibleUser) == true)
{
string strComparisonOpResponsibleUser = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.ResponsibleUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.ResponsibleUser, objvzx_ResearchPlanCond.ResponsibleUser, strComparisonOpResponsibleUser);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.PlanContent) == true)
{
string strComparisonOpPlanContent = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.PlanContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.PlanContent, objvzx_ResearchPlanCond.PlanContent, strComparisonOpPlanContent);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.zxStatusId) == true)
{
string strComparisonOpzxStatusId = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.zxStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.zxStatusId, objvzx_ResearchPlanCond.zxStatusId, strComparisonOpzxStatusId);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.StatusName) == true)
{
string strComparisonOpStatusName = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.StatusName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.StatusName, objvzx_ResearchPlanCond.StatusName, strComparisonOpStatusName);
}
if (objvzx_ResearchPlanCond.IsUpdated(convzx_ResearchPlan.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_ResearchPlanCond.dicFldComparisonOp[convzx_ResearchPlan.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_ResearchPlan.GroupTextId, objvzx_ResearchPlanCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_ResearchPlan
{
public virtual bool UpdRelaTabDate(string strzxPlanId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_ResearchPlan(vzx_ResearchPlan)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_ResearchPlanBL
{
public static RelatedActions_vzx_ResearchPlan relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_ResearchPlanDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_ResearchPlanDA vzx_ResearchPlanDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_ResearchPlanDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_ResearchPlanBL()
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
if (string.IsNullOrEmpty(clsvzx_ResearchPlanEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_ResearchPlanEN._ConnectString);
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
public static DataTable GetDataTable_vzx_ResearchPlan(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_ResearchPlanDA.GetDataTable_vzx_ResearchPlan(strWhereCond);
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
objDT = vzx_ResearchPlanDA.GetDataTable(strWhereCond);
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
objDT = vzx_ResearchPlanDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_ResearchPlanDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_ResearchPlanDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_ResearchPlanDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_ResearchPlanDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvzx_ResearchPlanEN> GetObjLstByZxPlanIdLst(List<string> arrZxPlanIdLst)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
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
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxPlanIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_ResearchPlanEN> GetObjLstByZxPlanIdLstCache(List<string> arrZxPlanIdLst)
{
string strKey = string.Format("{0}", clsvzx_ResearchPlanEN._CurrTabName);
List<clsvzx_ResearchPlanEN> arrvzx_ResearchPlanObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchPlanEN> arrvzx_ResearchPlanObjLst_Sel =
arrvzx_ResearchPlanObjLstCache
.Where(x => arrZxPlanIdLst.Contains(x.zxPlanId));
return arrvzx_ResearchPlanObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ResearchPlanEN> GetObjLst(string strWhereCond)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
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
public static List<clsvzx_ResearchPlanEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_ResearchPlanEN> GetSubObjLstCache(clsvzx_ResearchPlanEN objvzx_ResearchPlanCond)
{
List<clsvzx_ResearchPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_ResearchPlan.AttributeName)
{
if (objvzx_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objvzx_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchPlanCond[strFldName]));
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
public static List<clsvzx_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
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
public static List<clsvzx_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
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
List<clsvzx_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ResearchPlanEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
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
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
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
public static List<clsvzx_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_ResearchPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
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
public static List<clsvzx_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_ResearchPlanEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_ResearchPlanEN> arrObjLst = new List<clsvzx_ResearchPlanEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = new clsvzx_ResearchPlanEN();
try
{
objvzx_ResearchPlanEN.zxPlanId = objRow[convzx_ResearchPlan.zxPlanId].ToString().Trim(); //计划Id
objvzx_ResearchPlanEN.PlanTypeId = objRow[convzx_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
objvzx_ResearchPlanEN.Memo = objRow[convzx_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convzx_ResearchPlan.Memo].ToString().Trim(); //备注
objvzx_ResearchPlanEN.UpdDate = objRow[convzx_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvzx_ResearchPlanEN.UpdUser = objRow[convzx_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvzx_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvzx_ResearchPlanEN.AcceptanceUser = objRow[convzx_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvzx_ResearchPlanEN.ActualFinishingDate = objRow[convzx_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvzx_ResearchPlanEN.EndDate = objRow[convzx_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvzx_ResearchPlanEN.StartDate = objRow[convzx_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvzx_ResearchPlanEN.ResponsibleUser = objRow[convzx_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convzx_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvzx_ResearchPlanEN.PlanContent = objRow[convzx_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convzx_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvzx_ResearchPlanEN.zxStatusId = objRow[convzx_ResearchPlan.zxStatusId].ToString().Trim(); //状态Id
objvzx_ResearchPlanEN.StatusName = objRow[convzx_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convzx_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvzx_ResearchPlanEN.GroupTextId = objRow[convzx_ResearchPlan.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_ResearchPlanEN.zxPlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_ResearchPlanEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_ResearchPlan(ref clsvzx_ResearchPlanEN objvzx_ResearchPlanEN)
{
bool bolResult = vzx_ResearchPlanDA.Getvzx_ResearchPlan(ref objvzx_ResearchPlanEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_ResearchPlanEN GetObjByzxPlanId(string strzxPlanId)
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
clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = vzx_ResearchPlanDA.GetObjByzxPlanId(strzxPlanId);
return objvzx_ResearchPlanEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_ResearchPlanEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = vzx_ResearchPlanDA.GetFirstObj(strWhereCond);
 return objvzx_ResearchPlanEN;
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
public static clsvzx_ResearchPlanEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = vzx_ResearchPlanDA.GetObjByDataRow(objRow);
 return objvzx_ResearchPlanEN;
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
public static clsvzx_ResearchPlanEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_ResearchPlanEN objvzx_ResearchPlanEN = vzx_ResearchPlanDA.GetObjByDataRow(objRow);
 return objvzx_ResearchPlanEN;
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
 /// <param name = "lstvzx_ResearchPlanObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ResearchPlanEN GetObjByzxPlanIdFromList(string strzxPlanId, List<clsvzx_ResearchPlanEN> lstvzx_ResearchPlanObjLst)
{
foreach (clsvzx_ResearchPlanEN objvzx_ResearchPlanEN in lstvzx_ResearchPlanObjLst)
{
if (objvzx_ResearchPlanEN.zxPlanId == strzxPlanId)
{
return objvzx_ResearchPlanEN;
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
 strMaxZxPlanId = clsvzx_ResearchPlanDA.GetMaxStrId();
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
 strzxPlanId = new clsvzx_ResearchPlanDA().GetFirstID(strWhereCond);
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
 arrList = vzx_ResearchPlanDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_ResearchPlanDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vzx_ResearchPlanDA.IsExist(strzxPlanId);
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
 bolIsExist = clsvzx_ResearchPlanDA.IsExistTable();
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
 bolIsExist = vzx_ResearchPlanDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_ResearchPlanENS">源对象</param>
 /// <param name = "objvzx_ResearchPlanENT">目标对象</param>
 public static void CopyTo(clsvzx_ResearchPlanEN objvzx_ResearchPlanENS, clsvzx_ResearchPlanEN objvzx_ResearchPlanENT)
{
try
{
objvzx_ResearchPlanENT.zxPlanId = objvzx_ResearchPlanENS.zxPlanId; //计划Id
objvzx_ResearchPlanENT.PlanTypeId = objvzx_ResearchPlanENS.PlanTypeId; //计划类型
objvzx_ResearchPlanENT.Memo = objvzx_ResearchPlanENS.Memo; //备注
objvzx_ResearchPlanENT.UpdDate = objvzx_ResearchPlanENS.UpdDate; //修改日期
objvzx_ResearchPlanENT.UpdUser = objvzx_ResearchPlanENS.UpdUser; //修改人
objvzx_ResearchPlanENT.IsSubmit = objvzx_ResearchPlanENS.IsSubmit; //是否提交
objvzx_ResearchPlanENT.AcceptanceUser = objvzx_ResearchPlanENS.AcceptanceUser; //验收用户
objvzx_ResearchPlanENT.ActualFinishingDate = objvzx_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objvzx_ResearchPlanENT.EndDate = objvzx_ResearchPlanENS.EndDate; //截止日期
objvzx_ResearchPlanENT.StartDate = objvzx_ResearchPlanENS.StartDate; //开始日期
objvzx_ResearchPlanENT.ResponsibleUser = objvzx_ResearchPlanENS.ResponsibleUser; //负责人/小组
objvzx_ResearchPlanENT.PlanContent = objvzx_ResearchPlanENS.PlanContent; //计划内容
objvzx_ResearchPlanENT.zxStatusId = objvzx_ResearchPlanENS.zxStatusId; //状态Id
objvzx_ResearchPlanENT.StatusName = objvzx_ResearchPlanENS.StatusName; //状态名称
objvzx_ResearchPlanENT.GroupTextId = objvzx_ResearchPlanENS.GroupTextId; //小组Id
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
 /// <param name = "objvzx_ResearchPlanEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_ResearchPlanEN objvzx_ResearchPlanEN)
{
try
{
objvzx_ResearchPlanEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_ResearchPlanEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_ResearchPlan.zxPlanId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.zxPlanId = objvzx_ResearchPlanEN.zxPlanId; //计划Id
}
if (arrFldSet.Contains(convzx_ResearchPlan.PlanTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.PlanTypeId = objvzx_ResearchPlanEN.PlanTypeId == "[null]" ? null :  objvzx_ResearchPlanEN.PlanTypeId; //计划类型
}
if (arrFldSet.Contains(convzx_ResearchPlan.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.Memo = objvzx_ResearchPlanEN.Memo == "[null]" ? null :  objvzx_ResearchPlanEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_ResearchPlan.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.UpdDate = objvzx_ResearchPlanEN.UpdDate == "[null]" ? null :  objvzx_ResearchPlanEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_ResearchPlan.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.UpdUser = objvzx_ResearchPlanEN.UpdUser == "[null]" ? null :  objvzx_ResearchPlanEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_ResearchPlan.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.IsSubmit = objvzx_ResearchPlanEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_ResearchPlan.AcceptanceUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.AcceptanceUser = objvzx_ResearchPlanEN.AcceptanceUser == "[null]" ? null :  objvzx_ResearchPlanEN.AcceptanceUser; //验收用户
}
if (arrFldSet.Contains(convzx_ResearchPlan.ActualFinishingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.ActualFinishingDate = objvzx_ResearchPlanEN.ActualFinishingDate == "[null]" ? null :  objvzx_ResearchPlanEN.ActualFinishingDate; //实际完成日期
}
if (arrFldSet.Contains(convzx_ResearchPlan.EndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.EndDate = objvzx_ResearchPlanEN.EndDate == "[null]" ? null :  objvzx_ResearchPlanEN.EndDate; //截止日期
}
if (arrFldSet.Contains(convzx_ResearchPlan.StartDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.StartDate = objvzx_ResearchPlanEN.StartDate == "[null]" ? null :  objvzx_ResearchPlanEN.StartDate; //开始日期
}
if (arrFldSet.Contains(convzx_ResearchPlan.ResponsibleUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.ResponsibleUser = objvzx_ResearchPlanEN.ResponsibleUser == "[null]" ? null :  objvzx_ResearchPlanEN.ResponsibleUser; //负责人/小组
}
if (arrFldSet.Contains(convzx_ResearchPlan.PlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.PlanContent = objvzx_ResearchPlanEN.PlanContent == "[null]" ? null :  objvzx_ResearchPlanEN.PlanContent; //计划内容
}
if (arrFldSet.Contains(convzx_ResearchPlan.zxStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.zxStatusId = objvzx_ResearchPlanEN.zxStatusId; //状态Id
}
if (arrFldSet.Contains(convzx_ResearchPlan.StatusName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.StatusName = objvzx_ResearchPlanEN.StatusName == "[null]" ? null :  objvzx_ResearchPlanEN.StatusName; //状态名称
}
if (arrFldSet.Contains(convzx_ResearchPlan.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_ResearchPlanEN.GroupTextId = objvzx_ResearchPlanEN.GroupTextId; //小组Id
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
 /// <param name = "objvzx_ResearchPlanEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_ResearchPlanEN objvzx_ResearchPlanEN)
{
try
{
if (objvzx_ResearchPlanEN.PlanTypeId == "[null]") objvzx_ResearchPlanEN.PlanTypeId = null; //计划类型
if (objvzx_ResearchPlanEN.Memo == "[null]") objvzx_ResearchPlanEN.Memo = null; //备注
if (objvzx_ResearchPlanEN.UpdDate == "[null]") objvzx_ResearchPlanEN.UpdDate = null; //修改日期
if (objvzx_ResearchPlanEN.UpdUser == "[null]") objvzx_ResearchPlanEN.UpdUser = null; //修改人
if (objvzx_ResearchPlanEN.AcceptanceUser == "[null]") objvzx_ResearchPlanEN.AcceptanceUser = null; //验收用户
if (objvzx_ResearchPlanEN.ActualFinishingDate == "[null]") objvzx_ResearchPlanEN.ActualFinishingDate = null; //实际完成日期
if (objvzx_ResearchPlanEN.EndDate == "[null]") objvzx_ResearchPlanEN.EndDate = null; //截止日期
if (objvzx_ResearchPlanEN.StartDate == "[null]") objvzx_ResearchPlanEN.StartDate = null; //开始日期
if (objvzx_ResearchPlanEN.ResponsibleUser == "[null]") objvzx_ResearchPlanEN.ResponsibleUser = null; //负责人/小组
if (objvzx_ResearchPlanEN.PlanContent == "[null]") objvzx_ResearchPlanEN.PlanContent = null; //计划内容
if (objvzx_ResearchPlanEN.StatusName == "[null]") objvzx_ResearchPlanEN.StatusName = null; //状态名称
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
public static void CheckProperty4Condition(clsvzx_ResearchPlanEN objvzx_ResearchPlanEN)
{
 vzx_ResearchPlanDA.CheckProperty4Condition(objvzx_ResearchPlanEN);
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
if (clszx_TopicTaskStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TopicTaskStatusBL没有刷新缓存机制(clszx_TopicTaskStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxPlanId");
//if (arrvzx_ResearchPlanObjLstCache == null)
//{
//arrvzx_ResearchPlanObjLstCache = vzx_ResearchPlanDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxPlanId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_ResearchPlanEN GetObjByzxPlanIdCache(string strzxPlanId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_ResearchPlanEN._CurrTabName);
List<clsvzx_ResearchPlanEN> arrvzx_ResearchPlanObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchPlanEN> arrvzx_ResearchPlanObjLst_Sel =
arrvzx_ResearchPlanObjLstCache
.Where(x=> x.zxPlanId == strzxPlanId 
);
if (arrvzx_ResearchPlanObjLst_Sel.Count() == 0)
{
   clsvzx_ResearchPlanEN obj = clsvzx_ResearchPlanBL.GetObjByzxPlanId(strzxPlanId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_ResearchPlanObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ResearchPlanEN> GetAllvzx_ResearchPlanObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_ResearchPlanEN> arrvzx_ResearchPlanObjLstCache = GetObjLstCache(); 
return arrvzx_ResearchPlanObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_ResearchPlanEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_ResearchPlanEN._CurrTabName);
List<clsvzx_ResearchPlanEN> arrvzx_ResearchPlanObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_ResearchPlanObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_ResearchPlanEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxPlanId)
{
if (strInFldName != convzx_ResearchPlan.zxPlanId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_ResearchPlan.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_ResearchPlan.AttributeName));
throw new Exception(strMsg);
}
var objvzx_ResearchPlan = clsvzx_ResearchPlanBL.GetObjByzxPlanIdCache(strzxPlanId);
if (objvzx_ResearchPlan == null) return "";
return objvzx_ResearchPlan[strOutFldName].ToString();
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
int intRecCount = clsvzx_ResearchPlanDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_ResearchPlanDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_ResearchPlanDA.GetRecCount();
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
int intRecCount = clsvzx_ResearchPlanDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_ResearchPlanEN objvzx_ResearchPlanCond)
{
List<clsvzx_ResearchPlanEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_ResearchPlan.AttributeName)
{
if (objvzx_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objvzx_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objvzx_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_ResearchPlanCond[strFldName]));
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
 List<string> arrList = clsvzx_ResearchPlanDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_ResearchPlanDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_ResearchPlanDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}