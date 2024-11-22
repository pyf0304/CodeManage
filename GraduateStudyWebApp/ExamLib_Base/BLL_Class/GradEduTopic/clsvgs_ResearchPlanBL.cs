
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_ResearchPlanBL
 表名:vgs_ResearchPlan(01120662)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:01:37
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
public static class  clsvgs_ResearchPlanBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_ResearchPlanEN GetObj(this K_PlanId_vgs_ResearchPlan myKey)
{
clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = clsvgs_ResearchPlanBL.vgs_ResearchPlanDA.GetObjByPlanId(myKey.Value);
return objvgs_ResearchPlanEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetPlanId(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strPlanId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanId, 8, convgs_ResearchPlan.PlanId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPlanId, 8, convgs_ResearchPlan.PlanId);
}
objvgs_ResearchPlanEN.PlanId = strPlanId; //计划Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.PlanId) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.PlanId, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.PlanId] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetTopicId(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strTopicId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicId, convgs_ResearchPlan.TopicId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convgs_ResearchPlan.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convgs_ResearchPlan.TopicId);
}
objvgs_ResearchPlanEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.TopicId) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.TopicId, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.TopicId] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetTopicName(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convgs_ResearchPlan.TopicName);
}
objvgs_ResearchPlanEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.TopicName) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.TopicName, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.TopicName] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetIdCurrEduCls(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_ResearchPlan.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_ResearchPlan.IdCurrEduCls);
}
objvgs_ResearchPlanEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.IdCurrEduCls) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetStatusId(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strStatusId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStatusId, convgs_ResearchPlan.StatusId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatusId, 2, convgs_ResearchPlan.StatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStatusId, 2, convgs_ResearchPlan.StatusId);
}
objvgs_ResearchPlanEN.StatusId = strStatusId; //状态Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.StatusId) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.StatusId, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.StatusId] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetStatusName(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strStatusName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStatusName, 100, convgs_ResearchPlan.StatusName);
}
objvgs_ResearchPlanEN.StatusName = strStatusName; //状态名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.StatusName) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.StatusName, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.StatusName] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetPlanContent(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strPlanContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanContent, 1000, convgs_ResearchPlan.PlanContent);
}
objvgs_ResearchPlanEN.PlanContent = strPlanContent; //计划内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.PlanContent) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.PlanContent, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.PlanContent] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetResponsibleUser(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strResponsibleUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResponsibleUser, 50, convgs_ResearchPlan.ResponsibleUser);
}
objvgs_ResearchPlanEN.ResponsibleUser = strResponsibleUser; //负责人/小组
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.ResponsibleUser) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.ResponsibleUser, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.ResponsibleUser] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetStartDate(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strStartDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartDate, 20, convgs_ResearchPlan.StartDate);
}
objvgs_ResearchPlanEN.StartDate = strStartDate; //开始日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.StartDate) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.StartDate, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.StartDate] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetEndDate(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strEndDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEndDate, 20, convgs_ResearchPlan.EndDate);
}
objvgs_ResearchPlanEN.EndDate = strEndDate; //截止日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.EndDate) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.EndDate, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.EndDate] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetActualFinishingDate(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strActualFinishingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strActualFinishingDate, 20, convgs_ResearchPlan.ActualFinishingDate);
}
objvgs_ResearchPlanEN.ActualFinishingDate = strActualFinishingDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.ActualFinishingDate) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.ActualFinishingDate, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.ActualFinishingDate] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetAcceptanceUser(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strAcceptanceUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAcceptanceUser, 50, convgs_ResearchPlan.AcceptanceUser);
}
objvgs_ResearchPlanEN.AcceptanceUser = strAcceptanceUser; //验收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.AcceptanceUser) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.AcceptanceUser, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.AcceptanceUser] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetIsSubmit(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_ResearchPlanEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.IsSubmit) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.IsSubmit, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.IsSubmit] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetUpdUser(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_ResearchPlan.UpdUser);
}
objvgs_ResearchPlanEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.UpdUser) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.UpdUser, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.UpdUser] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetUpdDate(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_ResearchPlan.UpdDate);
}
objvgs_ResearchPlanEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.UpdDate) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.UpdDate, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.UpdDate] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetMemo(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_ResearchPlan.Memo);
}
objvgs_ResearchPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.Memo) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.Memo, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.Memo] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_ResearchPlanEN SetPlanTypeId(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN, string strPlanTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPlanTypeId, 2, convgs_ResearchPlan.PlanTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPlanTypeId, 2, convgs_ResearchPlan.PlanTypeId);
}
objvgs_ResearchPlanEN.PlanTypeId = strPlanTypeId; //计划类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_ResearchPlanEN.dicFldComparisonOp.ContainsKey(convgs_ResearchPlan.PlanTypeId) == false)
{
objvgs_ResearchPlanEN.dicFldComparisonOp.Add(convgs_ResearchPlan.PlanTypeId, strComparisonOp);
}
else
{
objvgs_ResearchPlanEN.dicFldComparisonOp[convgs_ResearchPlan.PlanTypeId] = strComparisonOp;
}
}
return objvgs_ResearchPlanEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanENS">源对象</param>
 /// <param name = "objvgs_ResearchPlanENT">目标对象</param>
 public static void CopyTo(this clsvgs_ResearchPlanEN objvgs_ResearchPlanENS, clsvgs_ResearchPlanEN objvgs_ResearchPlanENT)
{
try
{
objvgs_ResearchPlanENT.PlanId = objvgs_ResearchPlanENS.PlanId; //计划Id
objvgs_ResearchPlanENT.TopicId = objvgs_ResearchPlanENS.TopicId; //主题Id
objvgs_ResearchPlanENT.TopicName = objvgs_ResearchPlanENS.TopicName; //栏目主题
objvgs_ResearchPlanENT.IdCurrEduCls = objvgs_ResearchPlanENS.IdCurrEduCls; //教学班流水号
objvgs_ResearchPlanENT.StatusId = objvgs_ResearchPlanENS.StatusId; //状态Id
objvgs_ResearchPlanENT.StatusName = objvgs_ResearchPlanENS.StatusName; //状态名称
objvgs_ResearchPlanENT.PlanContent = objvgs_ResearchPlanENS.PlanContent; //计划内容
objvgs_ResearchPlanENT.ResponsibleUser = objvgs_ResearchPlanENS.ResponsibleUser; //负责人/小组
objvgs_ResearchPlanENT.StartDate = objvgs_ResearchPlanENS.StartDate; //开始日期
objvgs_ResearchPlanENT.EndDate = objvgs_ResearchPlanENS.EndDate; //截止日期
objvgs_ResearchPlanENT.ActualFinishingDate = objvgs_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objvgs_ResearchPlanENT.AcceptanceUser = objvgs_ResearchPlanENS.AcceptanceUser; //验收用户
objvgs_ResearchPlanENT.IsSubmit = objvgs_ResearchPlanENS.IsSubmit; //是否提交
objvgs_ResearchPlanENT.UpdUser = objvgs_ResearchPlanENS.UpdUser; //修改人
objvgs_ResearchPlanENT.UpdDate = objvgs_ResearchPlanENS.UpdDate; //修改日期
objvgs_ResearchPlanENT.Memo = objvgs_ResearchPlanENS.Memo; //备注
objvgs_ResearchPlanENT.PlanTypeId = objvgs_ResearchPlanENS.PlanTypeId; //计划类型
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
 /// <param name = "objvgs_ResearchPlanENS">源对象</param>
 /// <returns>目标对象=>clsvgs_ResearchPlanEN:objvgs_ResearchPlanENT</returns>
 public static clsvgs_ResearchPlanEN CopyTo(this clsvgs_ResearchPlanEN objvgs_ResearchPlanENS)
{
try
{
 clsvgs_ResearchPlanEN objvgs_ResearchPlanENT = new clsvgs_ResearchPlanEN()
{
PlanId = objvgs_ResearchPlanENS.PlanId, //计划Id
TopicId = objvgs_ResearchPlanENS.TopicId, //主题Id
TopicName = objvgs_ResearchPlanENS.TopicName, //栏目主题
IdCurrEduCls = objvgs_ResearchPlanENS.IdCurrEduCls, //教学班流水号
StatusId = objvgs_ResearchPlanENS.StatusId, //状态Id
StatusName = objvgs_ResearchPlanENS.StatusName, //状态名称
PlanContent = objvgs_ResearchPlanENS.PlanContent, //计划内容
ResponsibleUser = objvgs_ResearchPlanENS.ResponsibleUser, //负责人/小组
StartDate = objvgs_ResearchPlanENS.StartDate, //开始日期
EndDate = objvgs_ResearchPlanENS.EndDate, //截止日期
ActualFinishingDate = objvgs_ResearchPlanENS.ActualFinishingDate, //实际完成日期
AcceptanceUser = objvgs_ResearchPlanENS.AcceptanceUser, //验收用户
IsSubmit = objvgs_ResearchPlanENS.IsSubmit, //是否提交
UpdUser = objvgs_ResearchPlanENS.UpdUser, //修改人
UpdDate = objvgs_ResearchPlanENS.UpdDate, //修改日期
Memo = objvgs_ResearchPlanENS.Memo, //备注
PlanTypeId = objvgs_ResearchPlanENS.PlanTypeId, //计划类型
};
 return objvgs_ResearchPlanENT;
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
public static void CheckProperty4Condition(this clsvgs_ResearchPlanEN objvgs_ResearchPlanEN)
{
 clsvgs_ResearchPlanBL.vgs_ResearchPlanDA.CheckProperty4Condition(objvgs_ResearchPlanEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_ResearchPlanEN objvgs_ResearchPlanCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.PlanId) == true)
{
string strComparisonOpPlanId = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.PlanId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.PlanId, objvgs_ResearchPlanCond.PlanId, strComparisonOpPlanId);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.TopicId) == true)
{
string strComparisonOpTopicId = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.TopicId, objvgs_ResearchPlanCond.TopicId, strComparisonOpTopicId);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.TopicName) == true)
{
string strComparisonOpTopicName = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.TopicName, objvgs_ResearchPlanCond.TopicName, strComparisonOpTopicName);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.IdCurrEduCls, objvgs_ResearchPlanCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.StatusId) == true)
{
string strComparisonOpStatusId = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.StatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.StatusId, objvgs_ResearchPlanCond.StatusId, strComparisonOpStatusId);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.StatusName) == true)
{
string strComparisonOpStatusName = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.StatusName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.StatusName, objvgs_ResearchPlanCond.StatusName, strComparisonOpStatusName);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.PlanContent) == true)
{
string strComparisonOpPlanContent = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.PlanContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.PlanContent, objvgs_ResearchPlanCond.PlanContent, strComparisonOpPlanContent);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.ResponsibleUser) == true)
{
string strComparisonOpResponsibleUser = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.ResponsibleUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.ResponsibleUser, objvgs_ResearchPlanCond.ResponsibleUser, strComparisonOpResponsibleUser);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.StartDate) == true)
{
string strComparisonOpStartDate = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.StartDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.StartDate, objvgs_ResearchPlanCond.StartDate, strComparisonOpStartDate);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.EndDate) == true)
{
string strComparisonOpEndDate = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.EndDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.EndDate, objvgs_ResearchPlanCond.EndDate, strComparisonOpEndDate);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.ActualFinishingDate) == true)
{
string strComparisonOpActualFinishingDate = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.ActualFinishingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.ActualFinishingDate, objvgs_ResearchPlanCond.ActualFinishingDate, strComparisonOpActualFinishingDate);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.AcceptanceUser) == true)
{
string strComparisonOpAcceptanceUser = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.AcceptanceUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.AcceptanceUser, objvgs_ResearchPlanCond.AcceptanceUser, strComparisonOpAcceptanceUser);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.IsSubmit) == true)
{
if (objvgs_ResearchPlanCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_ResearchPlan.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_ResearchPlan.IsSubmit);
}
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.UpdUser, objvgs_ResearchPlanCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.UpdDate, objvgs_ResearchPlanCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.Memo) == true)
{
string strComparisonOpMemo = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.Memo, objvgs_ResearchPlanCond.Memo, strComparisonOpMemo);
}
if (objvgs_ResearchPlanCond.IsUpdated(convgs_ResearchPlan.PlanTypeId) == true)
{
string strComparisonOpPlanTypeId = objvgs_ResearchPlanCond.dicFldComparisonOp[convgs_ResearchPlan.PlanTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_ResearchPlan.PlanTypeId, objvgs_ResearchPlanCond.PlanTypeId, strComparisonOpPlanTypeId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_ResearchPlan
{
public virtual bool UpdRelaTabDate(string strPlanId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 主题研究计划视图(vgs_ResearchPlan)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_ResearchPlanBL
{
public static RelatedActions_vgs_ResearchPlan relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_ResearchPlanDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_ResearchPlanDA vgs_ResearchPlanDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_ResearchPlanDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_ResearchPlanBL()
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
if (string.IsNullOrEmpty(clsvgs_ResearchPlanEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_ResearchPlanEN._ConnectString);
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
public static DataTable GetDataTable_vgs_ResearchPlan(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_ResearchPlanDA.GetDataTable_vgs_ResearchPlan(strWhereCond);
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
objDT = vgs_ResearchPlanDA.GetDataTable(strWhereCond);
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
objDT = vgs_ResearchPlanDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_ResearchPlanDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_ResearchPlanDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_ResearchPlanDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_ResearchPlanDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_ResearchPlanDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvgs_ResearchPlanEN> GetObjLstByPlanIdLst(List<string> arrPlanIdLst)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
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
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPlanIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_ResearchPlanEN> GetObjLstByPlanIdLstCache(List<string> arrPlanIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
List<clsvgs_ResearchPlanEN> arrvgs_ResearchPlanObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_ResearchPlanEN> arrvgs_ResearchPlanObjLst_Sel =
arrvgs_ResearchPlanObjLstCache
.Where(x => arrPlanIdLst.Contains(x.PlanId));
return arrvgs_ResearchPlanObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_ResearchPlanEN> GetObjLst(string strWhereCond)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
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
public static List<clsvgs_ResearchPlanEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_ResearchPlanEN> GetSubObjLstCache(clsvgs_ResearchPlanEN objvgs_ResearchPlanCond)
{
 string strIdCurrEduCls = objvgs_ResearchPlanCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvgs_ResearchPlanBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvgs_ResearchPlanEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_ResearchPlan.AttributeName)
{
if (objvgs_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objvgs_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objvgs_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchPlanCond[strFldName]));
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
public static List<clsvgs_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
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
public static List<clsvgs_ResearchPlanEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
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
List<clsvgs_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_ResearchPlanEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_ResearchPlanEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
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
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
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
public static List<clsvgs_ResearchPlanEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_ResearchPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
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
public static List<clsvgs_ResearchPlanEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_ResearchPlanEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_ResearchPlanEN> arrObjLst = new List<clsvgs_ResearchPlanEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN();
try
{
objvgs_ResearchPlanEN.PlanId = objRow[convgs_ResearchPlan.PlanId].ToString().Trim(); //计划Id
objvgs_ResearchPlanEN.TopicId = objRow[convgs_ResearchPlan.TopicId].ToString().Trim(); //主题Id
objvgs_ResearchPlanEN.TopicName = objRow[convgs_ResearchPlan.TopicName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.TopicName].ToString().Trim(); //栏目主题
objvgs_ResearchPlanEN.IdCurrEduCls = objRow[convgs_ResearchPlan.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_ResearchPlan.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_ResearchPlanEN.StatusId = objRow[convgs_ResearchPlan.StatusId].ToString().Trim(); //状态Id
objvgs_ResearchPlanEN.StatusName = objRow[convgs_ResearchPlan.StatusName] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StatusName].ToString().Trim(); //状态名称
objvgs_ResearchPlanEN.PlanContent = objRow[convgs_ResearchPlan.PlanContent] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanContent].ToString().Trim(); //计划内容
objvgs_ResearchPlanEN.ResponsibleUser = objRow[convgs_ResearchPlan.ResponsibleUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ResponsibleUser].ToString().Trim(); //负责人/小组
objvgs_ResearchPlanEN.StartDate = objRow[convgs_ResearchPlan.StartDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.StartDate].ToString().Trim(); //开始日期
objvgs_ResearchPlanEN.EndDate = objRow[convgs_ResearchPlan.EndDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.EndDate].ToString().Trim(); //截止日期
objvgs_ResearchPlanEN.ActualFinishingDate = objRow[convgs_ResearchPlan.ActualFinishingDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.ActualFinishingDate].ToString().Trim(); //实际完成日期
objvgs_ResearchPlanEN.AcceptanceUser = objRow[convgs_ResearchPlan.AcceptanceUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.AcceptanceUser].ToString().Trim(); //验收用户
objvgs_ResearchPlanEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_ResearchPlan.IsSubmit].ToString().Trim()); //是否提交
objvgs_ResearchPlanEN.UpdUser = objRow[convgs_ResearchPlan.UpdUser] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdUser].ToString().Trim(); //修改人
objvgs_ResearchPlanEN.UpdDate = objRow[convgs_ResearchPlan.UpdDate] == DBNull.Value ? null : objRow[convgs_ResearchPlan.UpdDate].ToString().Trim(); //修改日期
objvgs_ResearchPlanEN.Memo = objRow[convgs_ResearchPlan.Memo] == DBNull.Value ? null : objRow[convgs_ResearchPlan.Memo].ToString().Trim(); //备注
objvgs_ResearchPlanEN.PlanTypeId = objRow[convgs_ResearchPlan.PlanTypeId] == DBNull.Value ? null : objRow[convgs_ResearchPlan.PlanTypeId].ToString().Trim(); //计划类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_ResearchPlanEN.PlanId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_ResearchPlanEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_ResearchPlan(ref clsvgs_ResearchPlanEN objvgs_ResearchPlanEN)
{
bool bolResult = vgs_ResearchPlanDA.Getvgs_ResearchPlan(ref objvgs_ResearchPlanEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPlanId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_ResearchPlanEN GetObjByPlanId(string strPlanId)
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
clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = vgs_ResearchPlanDA.GetObjByPlanId(strPlanId);
return objvgs_ResearchPlanEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_ResearchPlanEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = vgs_ResearchPlanDA.GetFirstObj(strWhereCond);
 return objvgs_ResearchPlanEN;
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
public static clsvgs_ResearchPlanEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = vgs_ResearchPlanDA.GetObjByDataRow(objRow);
 return objvgs_ResearchPlanEN;
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
public static clsvgs_ResearchPlanEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = vgs_ResearchPlanDA.GetObjByDataRow(objRow);
 return objvgs_ResearchPlanEN;
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
 /// <param name = "lstvgs_ResearchPlanObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_ResearchPlanEN GetObjByPlanIdFromList(string strPlanId, List<clsvgs_ResearchPlanEN> lstvgs_ResearchPlanObjLst)
{
foreach (clsvgs_ResearchPlanEN objvgs_ResearchPlanEN in lstvgs_ResearchPlanObjLst)
{
if (objvgs_ResearchPlanEN.PlanId == strPlanId)
{
return objvgs_ResearchPlanEN;
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
 strMaxPlanId = clsvgs_ResearchPlanDA.GetMaxStrId();
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
 strPlanId = new clsvgs_ResearchPlanDA().GetFirstID(strWhereCond);
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
 arrList = vgs_ResearchPlanDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_ResearchPlanDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vgs_ResearchPlanDA.IsExist(strPlanId);
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
 bolIsExist = clsvgs_ResearchPlanDA.IsExistTable();
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
 bolIsExist = vgs_ResearchPlanDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_ResearchPlanENS">源对象</param>
 /// <param name = "objvgs_ResearchPlanENT">目标对象</param>
 public static void CopyTo(clsvgs_ResearchPlanEN objvgs_ResearchPlanENS, clsvgs_ResearchPlanEN objvgs_ResearchPlanENT)
{
try
{
objvgs_ResearchPlanENT.PlanId = objvgs_ResearchPlanENS.PlanId; //计划Id
objvgs_ResearchPlanENT.TopicId = objvgs_ResearchPlanENS.TopicId; //主题Id
objvgs_ResearchPlanENT.TopicName = objvgs_ResearchPlanENS.TopicName; //栏目主题
objvgs_ResearchPlanENT.IdCurrEduCls = objvgs_ResearchPlanENS.IdCurrEduCls; //教学班流水号
objvgs_ResearchPlanENT.StatusId = objvgs_ResearchPlanENS.StatusId; //状态Id
objvgs_ResearchPlanENT.StatusName = objvgs_ResearchPlanENS.StatusName; //状态名称
objvgs_ResearchPlanENT.PlanContent = objvgs_ResearchPlanENS.PlanContent; //计划内容
objvgs_ResearchPlanENT.ResponsibleUser = objvgs_ResearchPlanENS.ResponsibleUser; //负责人/小组
objvgs_ResearchPlanENT.StartDate = objvgs_ResearchPlanENS.StartDate; //开始日期
objvgs_ResearchPlanENT.EndDate = objvgs_ResearchPlanENS.EndDate; //截止日期
objvgs_ResearchPlanENT.ActualFinishingDate = objvgs_ResearchPlanENS.ActualFinishingDate; //实际完成日期
objvgs_ResearchPlanENT.AcceptanceUser = objvgs_ResearchPlanENS.AcceptanceUser; //验收用户
objvgs_ResearchPlanENT.IsSubmit = objvgs_ResearchPlanENS.IsSubmit; //是否提交
objvgs_ResearchPlanENT.UpdUser = objvgs_ResearchPlanENS.UpdUser; //修改人
objvgs_ResearchPlanENT.UpdDate = objvgs_ResearchPlanENS.UpdDate; //修改日期
objvgs_ResearchPlanENT.Memo = objvgs_ResearchPlanENS.Memo; //备注
objvgs_ResearchPlanENT.PlanTypeId = objvgs_ResearchPlanENS.PlanTypeId; //计划类型
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
 /// <param name = "objvgs_ResearchPlanEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_ResearchPlanEN objvgs_ResearchPlanEN)
{
try
{
objvgs_ResearchPlanEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_ResearchPlanEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_ResearchPlan.PlanId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.PlanId = objvgs_ResearchPlanEN.PlanId; //计划Id
}
if (arrFldSet.Contains(convgs_ResearchPlan.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.TopicId = objvgs_ResearchPlanEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convgs_ResearchPlan.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.TopicName = objvgs_ResearchPlanEN.TopicName == "[null]" ? null :  objvgs_ResearchPlanEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convgs_ResearchPlan.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.IdCurrEduCls = objvgs_ResearchPlanEN.IdCurrEduCls == "[null]" ? null :  objvgs_ResearchPlanEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_ResearchPlan.StatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.StatusId = objvgs_ResearchPlanEN.StatusId; //状态Id
}
if (arrFldSet.Contains(convgs_ResearchPlan.StatusName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.StatusName = objvgs_ResearchPlanEN.StatusName == "[null]" ? null :  objvgs_ResearchPlanEN.StatusName; //状态名称
}
if (arrFldSet.Contains(convgs_ResearchPlan.PlanContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.PlanContent = objvgs_ResearchPlanEN.PlanContent == "[null]" ? null :  objvgs_ResearchPlanEN.PlanContent; //计划内容
}
if (arrFldSet.Contains(convgs_ResearchPlan.ResponsibleUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.ResponsibleUser = objvgs_ResearchPlanEN.ResponsibleUser == "[null]" ? null :  objvgs_ResearchPlanEN.ResponsibleUser; //负责人/小组
}
if (arrFldSet.Contains(convgs_ResearchPlan.StartDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.StartDate = objvgs_ResearchPlanEN.StartDate == "[null]" ? null :  objvgs_ResearchPlanEN.StartDate; //开始日期
}
if (arrFldSet.Contains(convgs_ResearchPlan.EndDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.EndDate = objvgs_ResearchPlanEN.EndDate == "[null]" ? null :  objvgs_ResearchPlanEN.EndDate; //截止日期
}
if (arrFldSet.Contains(convgs_ResearchPlan.ActualFinishingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.ActualFinishingDate = objvgs_ResearchPlanEN.ActualFinishingDate == "[null]" ? null :  objvgs_ResearchPlanEN.ActualFinishingDate; //实际完成日期
}
if (arrFldSet.Contains(convgs_ResearchPlan.AcceptanceUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.AcceptanceUser = objvgs_ResearchPlanEN.AcceptanceUser == "[null]" ? null :  objvgs_ResearchPlanEN.AcceptanceUser; //验收用户
}
if (arrFldSet.Contains(convgs_ResearchPlan.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.IsSubmit = objvgs_ResearchPlanEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_ResearchPlan.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.UpdUser = objvgs_ResearchPlanEN.UpdUser == "[null]" ? null :  objvgs_ResearchPlanEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_ResearchPlan.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.UpdDate = objvgs_ResearchPlanEN.UpdDate == "[null]" ? null :  objvgs_ResearchPlanEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_ResearchPlan.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.Memo = objvgs_ResearchPlanEN.Memo == "[null]" ? null :  objvgs_ResearchPlanEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_ResearchPlan.PlanTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_ResearchPlanEN.PlanTypeId = objvgs_ResearchPlanEN.PlanTypeId == "[null]" ? null :  objvgs_ResearchPlanEN.PlanTypeId; //计划类型
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
 /// <param name = "objvgs_ResearchPlanEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_ResearchPlanEN objvgs_ResearchPlanEN)
{
try
{
if (objvgs_ResearchPlanEN.TopicName == "[null]") objvgs_ResearchPlanEN.TopicName = null; //栏目主题
if (objvgs_ResearchPlanEN.IdCurrEduCls == "[null]") objvgs_ResearchPlanEN.IdCurrEduCls = null; //教学班流水号
if (objvgs_ResearchPlanEN.StatusName == "[null]") objvgs_ResearchPlanEN.StatusName = null; //状态名称
if (objvgs_ResearchPlanEN.PlanContent == "[null]") objvgs_ResearchPlanEN.PlanContent = null; //计划内容
if (objvgs_ResearchPlanEN.ResponsibleUser == "[null]") objvgs_ResearchPlanEN.ResponsibleUser = null; //负责人/小组
if (objvgs_ResearchPlanEN.StartDate == "[null]") objvgs_ResearchPlanEN.StartDate = null; //开始日期
if (objvgs_ResearchPlanEN.EndDate == "[null]") objvgs_ResearchPlanEN.EndDate = null; //截止日期
if (objvgs_ResearchPlanEN.ActualFinishingDate == "[null]") objvgs_ResearchPlanEN.ActualFinishingDate = null; //实际完成日期
if (objvgs_ResearchPlanEN.AcceptanceUser == "[null]") objvgs_ResearchPlanEN.AcceptanceUser = null; //验收用户
if (objvgs_ResearchPlanEN.UpdUser == "[null]") objvgs_ResearchPlanEN.UpdUser = null; //修改人
if (objvgs_ResearchPlanEN.UpdDate == "[null]") objvgs_ResearchPlanEN.UpdDate = null; //修改日期
if (objvgs_ResearchPlanEN.Memo == "[null]") objvgs_ResearchPlanEN.Memo = null; //备注
if (objvgs_ResearchPlanEN.PlanTypeId == "[null]") objvgs_ResearchPlanEN.PlanTypeId = null; //计划类型
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
public static void CheckProperty4Condition(clsvgs_ResearchPlanEN objvgs_ResearchPlanEN)
{
 vgs_ResearchPlanDA.CheckProperty4Condition(objvgs_ResearchPlanEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_StatusId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convgs_ResearchPlan.StatusId); 
List<clsvgs_ResearchPlanEN> arrObjLst = clsvgs_ResearchPlanBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvgs_ResearchPlanEN objvgs_ResearchPlanEN = new clsvgs_ResearchPlanEN()
{
StatusId = "0",
StatusName = "选[主题研究计划视图]..."
};
arrObjLst.Insert(0, objvgs_ResearchPlanEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convgs_ResearchPlan.StatusId;
objComboBox.DisplayMember = convgs_ResearchPlan.StatusName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_StatusId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[主题研究计划视图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convgs_ResearchPlan.StatusId); 
IEnumerable<clsvgs_ResearchPlanEN> arrObjLst = clsvgs_ResearchPlanBL.GetObjLst(strCondition);
objDDL.DataValueField = convgs_ResearchPlan.StatusId;
objDDL.DataTextField = convgs_ResearchPlan.StatusName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_PlanIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[主题研究计划视图]...","0");
List<clsvgs_ResearchPlanEN> arrvgs_ResearchPlanObjLst = GetAllvgs_ResearchPlanObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = convgs_ResearchPlan.PlanId;
objDDL.DataTextField = convgs_ResearchPlan.StatusName;
objDDL.DataSource = arrvgs_ResearchPlanObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_ResearchPlanBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_ResearchPlanBL没有刷新缓存机制(clsgs_ResearchPlanBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_TopicTaskStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TopicTaskStatusBL没有刷新缓存机制(clsgs_TopicTaskStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PlanId");
//if (arrvgs_ResearchPlanObjLstCache == null)
//{
//arrvgs_ResearchPlanObjLstCache = vgs_ResearchPlanDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPlanId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_ResearchPlanEN GetObjByPlanIdCache(string strPlanId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
List<clsvgs_ResearchPlanEN> arrvgs_ResearchPlanObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_ResearchPlanEN> arrvgs_ResearchPlanObjLst_Sel =
arrvgs_ResearchPlanObjLstCache
.Where(x=> x.PlanId == strPlanId 
);
if (arrvgs_ResearchPlanObjLst_Sel.Count() == 0)
{
   clsvgs_ResearchPlanEN obj = clsvgs_ResearchPlanBL.GetObjByPlanId(strPlanId);
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
return arrvgs_ResearchPlanObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPlanId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetStatusNameByPlanIdCache(string strPlanId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strPlanId) == true) return "";
//获取缓存中的对象列表
clsvgs_ResearchPlanEN objvgs_ResearchPlan = GetObjByPlanIdCache(strPlanId, strIdCurrEduCls);
if (objvgs_ResearchPlan == null) return "";
return objvgs_ResearchPlan.StatusName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strPlanId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByPlanIdCache(string strPlanId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strPlanId) == true) return "";
//获取缓存中的对象列表
clsvgs_ResearchPlanEN objvgs_ResearchPlan = GetObjByPlanIdCache(strPlanId, strIdCurrEduCls);
if (objvgs_ResearchPlan == null) return "";
return objvgs_ResearchPlan.StatusName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_ResearchPlanEN> GetAllvgs_ResearchPlanObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvgs_ResearchPlanEN> arrvgs_ResearchPlanObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvgs_ResearchPlanObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_ResearchPlanEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvgs_ResearchPlanEN> arrvgs_ResearchPlanObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvgs_ResearchPlanObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvgs_ResearchPlanEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strPlanId, string strIdCurrEduCls)
{
if (strInFldName != convgs_ResearchPlan.PlanId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_ResearchPlan.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_ResearchPlan.AttributeName));
throw new Exception(strMsg);
}
var objvgs_ResearchPlan = clsvgs_ResearchPlanBL.GetObjByPlanIdCache(strPlanId, strIdCurrEduCls);
if (objvgs_ResearchPlan == null) return "";
return objvgs_ResearchPlan[strOutFldName].ToString();
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
int intRecCount = clsvgs_ResearchPlanDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_ResearchPlanDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_ResearchPlanDA.GetRecCount();
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
int intRecCount = clsvgs_ResearchPlanDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_ResearchPlanCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_ResearchPlanEN objvgs_ResearchPlanCond)
{
 string strIdCurrEduCls = objvgs_ResearchPlanCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvgs_ResearchPlanBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvgs_ResearchPlanEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvgs_ResearchPlanEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_ResearchPlan.AttributeName)
{
if (objvgs_ResearchPlanCond.IsUpdated(strFldName) == false) continue;
if (objvgs_ResearchPlanCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchPlanCond[strFldName].ToString());
}
else
{
if (objvgs_ResearchPlanCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_ResearchPlanCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_ResearchPlanCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_ResearchPlanCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_ResearchPlanCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchPlanCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_ResearchPlanCond[strFldName]));
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
 List<string> arrList = clsvgs_ResearchPlanDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_ResearchPlanDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_ResearchPlanDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}