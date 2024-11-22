
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_MeetingMinutesBL
 表名:vgs_MeetingMinutes(01120768)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:38:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvgs_MeetingMinutesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_MeetingMinutesEN GetObj(this K_MeetingId_vgs_MeetingMinutes myKey)
{
clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = clsvgs_MeetingMinutesBL.vgs_MeetingMinutesDA.GetObjByMeetingId(myKey.Value);
return objvgs_MeetingMinutesEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetMeetingId(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strMeetingId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeetingId, 10, convgs_MeetingMinutes.MeetingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMeetingId, 10, convgs_MeetingMinutes.MeetingId);
}
objvgs_MeetingMinutesEN.MeetingId = strMeetingId; //会议Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.MeetingId) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.MeetingId, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.MeetingId] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetTopicId(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convgs_MeetingMinutes.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convgs_MeetingMinutes.TopicId);
}
objvgs_MeetingMinutesEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.TopicId) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.TopicId, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.TopicId] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetIsSubmit(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_MeetingMinutesEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.IsSubmit) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.IsSubmit, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.IsSubmit] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetTopicName(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convgs_MeetingMinutes.TopicName);
}
objvgs_MeetingMinutesEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.TopicName) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.TopicName, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.TopicName] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetMeetingContent(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strMeetingContent, string strComparisonOp="")
	{
objvgs_MeetingMinutesEN.MeetingContent = strMeetingContent; //会议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.MeetingContent) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.MeetingContent, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.MeetingContent] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetMeetingDate(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strMeetingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeetingDate, 20, convgs_MeetingMinutes.MeetingDate);
}
objvgs_MeetingMinutesEN.MeetingDate = strMeetingDate; //会议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.MeetingDate) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.MeetingDate, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.MeetingDate] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetUpdDate(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_MeetingMinutes.UpdDate);
}
objvgs_MeetingMinutesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.UpdDate) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.UpdDate, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.UpdDate] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetUpdUser(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_MeetingMinutes.UpdUser);
}
objvgs_MeetingMinutesEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.UpdUser) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.UpdUser, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.UpdUser] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetYear(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, convgs_MeetingMinutes.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, convgs_MeetingMinutes.Year);
}
objvgs_MeetingMinutesEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.Year) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.Year, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.Year] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetMonth(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, convgs_MeetingMinutes.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, convgs_MeetingMinutes.Month);
}
objvgs_MeetingMinutesEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.Month) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.Month, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.Month] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetMemo(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_MeetingMinutes.Memo);
}
objvgs_MeetingMinutesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.Memo) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.Memo, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.Memo] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetVersionCount(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_MeetingMinutesEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.VersionCount) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.VersionCount, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.VersionCount] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetParticipants(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strParticipants, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipants, 500, convgs_MeetingMinutes.Participants);
}
objvgs_MeetingMinutesEN.Participants = strParticipants; //参会者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.Participants) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.Participants, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.Participants] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_MeetingMinutesEN SetIdCurrEduCls(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_MeetingMinutes.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_MeetingMinutes.IdCurrEduCls);
}
objvgs_MeetingMinutesEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convgs_MeetingMinutes.IdCurrEduCls) == false)
{
objvgs_MeetingMinutesEN.dicFldComparisonOp.Add(convgs_MeetingMinutes.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_MeetingMinutesEN.dicFldComparisonOp[convgs_MeetingMinutes.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_MeetingMinutesEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesENS">源对象</param>
 /// <param name = "objvgs_MeetingMinutesENT">目标对象</param>
 public static void CopyTo(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENS, clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENT)
{
try
{
objvgs_MeetingMinutesENT.MeetingId = objvgs_MeetingMinutesENS.MeetingId; //会议Id
objvgs_MeetingMinutesENT.TopicId = objvgs_MeetingMinutesENS.TopicId; //主题Id
objvgs_MeetingMinutesENT.IsSubmit = objvgs_MeetingMinutesENS.IsSubmit; //是否提交
objvgs_MeetingMinutesENT.TopicName = objvgs_MeetingMinutesENS.TopicName; //栏目主题
objvgs_MeetingMinutesENT.MeetingContent = objvgs_MeetingMinutesENS.MeetingContent; //会议内容
objvgs_MeetingMinutesENT.MeetingDate = objvgs_MeetingMinutesENS.MeetingDate; //会议日期
objvgs_MeetingMinutesENT.UpdDate = objvgs_MeetingMinutesENS.UpdDate; //修改日期
objvgs_MeetingMinutesENT.UpdUser = objvgs_MeetingMinutesENS.UpdUser; //修改人
objvgs_MeetingMinutesENT.Year = objvgs_MeetingMinutesENS.Year; //年
objvgs_MeetingMinutesENT.Month = objvgs_MeetingMinutesENS.Month; //月
objvgs_MeetingMinutesENT.Memo = objvgs_MeetingMinutesENS.Memo; //备注
objvgs_MeetingMinutesENT.VersionCount = objvgs_MeetingMinutesENS.VersionCount; //版本统计
objvgs_MeetingMinutesENT.Participants = objvgs_MeetingMinutesENS.Participants; //参会者
objvgs_MeetingMinutesENT.IdCurrEduCls = objvgs_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvgs_MeetingMinutesENS">源对象</param>
 /// <returns>目标对象=>clsvgs_MeetingMinutesEN:objvgs_MeetingMinutesENT</returns>
 public static clsvgs_MeetingMinutesEN CopyTo(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENS)
{
try
{
 clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENT = new clsvgs_MeetingMinutesEN()
{
MeetingId = objvgs_MeetingMinutesENS.MeetingId, //会议Id
TopicId = objvgs_MeetingMinutesENS.TopicId, //主题Id
IsSubmit = objvgs_MeetingMinutesENS.IsSubmit, //是否提交
TopicName = objvgs_MeetingMinutesENS.TopicName, //栏目主题
MeetingContent = objvgs_MeetingMinutesENS.MeetingContent, //会议内容
MeetingDate = objvgs_MeetingMinutesENS.MeetingDate, //会议日期
UpdDate = objvgs_MeetingMinutesENS.UpdDate, //修改日期
UpdUser = objvgs_MeetingMinutesENS.UpdUser, //修改人
Year = objvgs_MeetingMinutesENS.Year, //年
Month = objvgs_MeetingMinutesENS.Month, //月
Memo = objvgs_MeetingMinutesENS.Memo, //备注
VersionCount = objvgs_MeetingMinutesENS.VersionCount, //版本统计
Participants = objvgs_MeetingMinutesENS.Participants, //参会者
IdCurrEduCls = objvgs_MeetingMinutesENS.IdCurrEduCls, //教学班流水号
};
 return objvgs_MeetingMinutesENT;
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
public static void CheckProperty4Condition(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN)
{
 clsvgs_MeetingMinutesBL.vgs_MeetingMinutesDA.CheckProperty4Condition(objvgs_MeetingMinutesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_MeetingMinutesEN objvgs_MeetingMinutesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.MeetingId) == true)
{
string strComparisonOpMeetingId = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.MeetingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.MeetingId, objvgs_MeetingMinutesCond.MeetingId, strComparisonOpMeetingId);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.TopicId) == true)
{
string strComparisonOpTopicId = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.TopicId, objvgs_MeetingMinutesCond.TopicId, strComparisonOpTopicId);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.IsSubmit) == true)
{
if (objvgs_MeetingMinutesCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_MeetingMinutes.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_MeetingMinutes.IsSubmit);
}
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.TopicName) == true)
{
string strComparisonOpTopicName = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.TopicName, objvgs_MeetingMinutesCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.MeetingDate) == true)
{
string strComparisonOpMeetingDate = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.MeetingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.MeetingDate, objvgs_MeetingMinutesCond.MeetingDate, strComparisonOpMeetingDate);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.UpdDate, objvgs_MeetingMinutesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.UpdUser, objvgs_MeetingMinutesCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.Year) == true)
{
string strComparisonOpYear = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.Year, objvgs_MeetingMinutesCond.Year, strComparisonOpYear);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.Month) == true)
{
string strComparisonOpMonth = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.Month, objvgs_MeetingMinutesCond.Month, strComparisonOpMonth);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.Memo) == true)
{
string strComparisonOpMemo = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.Memo, objvgs_MeetingMinutesCond.Memo, strComparisonOpMemo);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_MeetingMinutes.VersionCount, objvgs_MeetingMinutesCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.Participants) == true)
{
string strComparisonOpParticipants = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.Participants];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.Participants, objvgs_MeetingMinutesCond.Participants, strComparisonOpParticipants);
}
if (objvgs_MeetingMinutesCond.IsUpdated(convgs_MeetingMinutes.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_MeetingMinutesCond.dicFldComparisonOp[convgs_MeetingMinutes.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_MeetingMinutes.IdCurrEduCls, objvgs_MeetingMinutesCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_MeetingMinutes
{
public virtual bool UpdRelaTabDate(string strMeetingId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 会议纪要视图(vgs_MeetingMinutes)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_MeetingMinutesBL
{
public static RelatedActions_vgs_MeetingMinutes relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_MeetingMinutesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_MeetingMinutesDA vgs_MeetingMinutesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_MeetingMinutesDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_MeetingMinutesBL()
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
if (string.IsNullOrEmpty(clsvgs_MeetingMinutesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_MeetingMinutesEN._ConnectString);
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
public static DataTable GetDataTable_vgs_MeetingMinutes(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_MeetingMinutesDA.GetDataTable_vgs_MeetingMinutes(strWhereCond);
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
objDT = vgs_MeetingMinutesDA.GetDataTable(strWhereCond);
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
objDT = vgs_MeetingMinutesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_MeetingMinutesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_MeetingMinutesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_MeetingMinutesDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_MeetingMinutesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_MeetingMinutesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_MeetingMinutesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMeetingIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_MeetingMinutesEN> GetObjLstByMeetingIdLst(List<string> arrMeetingIdLst)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMeetingIdLst, true);
 string strWhereCond = string.Format("MeetingId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMeetingIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_MeetingMinutesEN> GetObjLstByMeetingIdLstCache(List<string> arrMeetingIdLst)
{
string strKey = string.Format("{0}", clsvgs_MeetingMinutesEN._CurrTabName);
List<clsvgs_MeetingMinutesEN> arrvgs_MeetingMinutesObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_MeetingMinutesEN> arrvgs_MeetingMinutesObjLst_Sel =
arrvgs_MeetingMinutesObjLstCache
.Where(x => arrMeetingIdLst.Contains(x.MeetingId));
return arrvgs_MeetingMinutesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_MeetingMinutesEN> GetObjLst(string strWhereCond)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
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
public static List<clsvgs_MeetingMinutesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_MeetingMinutesEN> GetSubObjLstCache(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesCond)
{
List<clsvgs_MeetingMinutesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_MeetingMinutesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_MeetingMinutes.AttributeName)
{
if (objvgs_MeetingMinutesCond.IsUpdated(strFldName) == false) continue;
if (objvgs_MeetingMinutesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_MeetingMinutesCond[strFldName].ToString());
}
else
{
if (objvgs_MeetingMinutesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_MeetingMinutesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_MeetingMinutesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_MeetingMinutesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_MeetingMinutesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_MeetingMinutesCond[strFldName]));
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
public static List<clsvgs_MeetingMinutesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
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
public static List<clsvgs_MeetingMinutesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
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
List<clsvgs_MeetingMinutesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_MeetingMinutesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_MeetingMinutesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_MeetingMinutesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
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
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
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
public static List<clsvgs_MeetingMinutesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_MeetingMinutesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_MeetingMinutesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
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
public static List<clsvgs_MeetingMinutesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_MeetingMinutesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_MeetingMinutesEN> arrObjLst = new List<clsvgs_MeetingMinutesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = new clsvgs_MeetingMinutesEN();
try
{
objvgs_MeetingMinutesEN.MeetingId = objRow[convgs_MeetingMinutes.MeetingId].ToString().Trim(); //会议Id
objvgs_MeetingMinutesEN.TopicId = objRow[convgs_MeetingMinutes.TopicId] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicId].ToString().Trim(); //主题Id
objvgs_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvgs_MeetingMinutesEN.TopicName = objRow[convgs_MeetingMinutes.TopicName] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.TopicName].ToString().Trim(); //栏目主题
objvgs_MeetingMinutesEN.MeetingContent = objRow[convgs_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvgs_MeetingMinutesEN.MeetingDate = objRow[convgs_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvgs_MeetingMinutesEN.UpdDate = objRow[convgs_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvgs_MeetingMinutesEN.UpdUser = objRow[convgs_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvgs_MeetingMinutesEN.Year = objRow[convgs_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Year].ToString().Trim(); //年
objvgs_MeetingMinutesEN.Month = objRow[convgs_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Month].ToString().Trim(); //月
objvgs_MeetingMinutesEN.Memo = objRow[convgs_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Memo].ToString().Trim(); //备注
objvgs_MeetingMinutesEN.VersionCount = objRow[convgs_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvgs_MeetingMinutesEN.Participants = objRow[convgs_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvgs_MeetingMinutesEN.IdCurrEduCls = objRow[convgs_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_MeetingMinutesEN.MeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_MeetingMinutesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_MeetingMinutes(ref clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN)
{
bool bolResult = vgs_MeetingMinutesDA.Getvgs_MeetingMinutes(ref objvgs_MeetingMinutesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_MeetingMinutesEN GetObjByMeetingId(string strMeetingId)
{
if (strMeetingId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strMeetingId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strMeetingId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strMeetingId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = vgs_MeetingMinutesDA.GetObjByMeetingId(strMeetingId);
return objvgs_MeetingMinutesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_MeetingMinutesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = vgs_MeetingMinutesDA.GetFirstObj(strWhereCond);
 return objvgs_MeetingMinutesEN;
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
public static clsvgs_MeetingMinutesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = vgs_MeetingMinutesDA.GetObjByDataRow(objRow);
 return objvgs_MeetingMinutesEN;
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
public static clsvgs_MeetingMinutesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN = vgs_MeetingMinutesDA.GetObjByDataRow(objRow);
 return objvgs_MeetingMinutesEN;
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
 /// <param name = "strMeetingId">所给的关键字</param>
 /// <param name = "lstvgs_MeetingMinutesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_MeetingMinutesEN GetObjByMeetingIdFromList(string strMeetingId, List<clsvgs_MeetingMinutesEN> lstvgs_MeetingMinutesObjLst)
{
foreach (clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN in lstvgs_MeetingMinutesObjLst)
{
if (objvgs_MeetingMinutesEN.MeetingId == strMeetingId)
{
return objvgs_MeetingMinutesEN;
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
 string strMaxMeetingId;
 try
 {
 strMaxMeetingId = clsvgs_MeetingMinutesDA.GetMaxStrId();
 return strMaxMeetingId;
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
 string strMeetingId;
 try
 {
 strMeetingId = new clsvgs_MeetingMinutesDA().GetFirstID(strWhereCond);
 return strMeetingId;
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
 arrList = vgs_MeetingMinutesDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_MeetingMinutesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strMeetingId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strMeetingId)
{
if (string.IsNullOrEmpty(strMeetingId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strMeetingId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vgs_MeetingMinutesDA.IsExist(strMeetingId);
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
 bolIsExist = clsvgs_MeetingMinutesDA.IsExistTable();
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
 bolIsExist = vgs_MeetingMinutesDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_MeetingMinutesENS">源对象</param>
 /// <param name = "objvgs_MeetingMinutesENT">目标对象</param>
 public static void CopyTo(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENS, clsvgs_MeetingMinutesEN objvgs_MeetingMinutesENT)
{
try
{
objvgs_MeetingMinutesENT.MeetingId = objvgs_MeetingMinutesENS.MeetingId; //会议Id
objvgs_MeetingMinutesENT.TopicId = objvgs_MeetingMinutesENS.TopicId; //主题Id
objvgs_MeetingMinutesENT.IsSubmit = objvgs_MeetingMinutesENS.IsSubmit; //是否提交
objvgs_MeetingMinutesENT.TopicName = objvgs_MeetingMinutesENS.TopicName; //栏目主题
objvgs_MeetingMinutesENT.MeetingContent = objvgs_MeetingMinutesENS.MeetingContent; //会议内容
objvgs_MeetingMinutesENT.MeetingDate = objvgs_MeetingMinutesENS.MeetingDate; //会议日期
objvgs_MeetingMinutesENT.UpdDate = objvgs_MeetingMinutesENS.UpdDate; //修改日期
objvgs_MeetingMinutesENT.UpdUser = objvgs_MeetingMinutesENS.UpdUser; //修改人
objvgs_MeetingMinutesENT.Year = objvgs_MeetingMinutesENS.Year; //年
objvgs_MeetingMinutesENT.Month = objvgs_MeetingMinutesENS.Month; //月
objvgs_MeetingMinutesENT.Memo = objvgs_MeetingMinutesENS.Memo; //备注
objvgs_MeetingMinutesENT.VersionCount = objvgs_MeetingMinutesENS.VersionCount; //版本统计
objvgs_MeetingMinutesENT.Participants = objvgs_MeetingMinutesENS.Participants; //参会者
objvgs_MeetingMinutesENT.IdCurrEduCls = objvgs_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvgs_MeetingMinutesEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN)
{
try
{
objvgs_MeetingMinutesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_MeetingMinutesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_MeetingMinutes.MeetingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.MeetingId = objvgs_MeetingMinutesEN.MeetingId; //会议Id
}
if (arrFldSet.Contains(convgs_MeetingMinutes.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.TopicId = objvgs_MeetingMinutesEN.TopicId == "[null]" ? null :  objvgs_MeetingMinutesEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convgs_MeetingMinutes.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.IsSubmit = objvgs_MeetingMinutesEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_MeetingMinutes.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.TopicName = objvgs_MeetingMinutesEN.TopicName == "[null]" ? null :  objvgs_MeetingMinutesEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convgs_MeetingMinutes.MeetingContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.MeetingContent = objvgs_MeetingMinutesEN.MeetingContent == "[null]" ? null :  objvgs_MeetingMinutesEN.MeetingContent; //会议内容
}
if (arrFldSet.Contains(convgs_MeetingMinutes.MeetingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.MeetingDate = objvgs_MeetingMinutesEN.MeetingDate == "[null]" ? null :  objvgs_MeetingMinutesEN.MeetingDate; //会议日期
}
if (arrFldSet.Contains(convgs_MeetingMinutes.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.UpdDate = objvgs_MeetingMinutesEN.UpdDate == "[null]" ? null :  objvgs_MeetingMinutesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_MeetingMinutes.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.UpdUser = objvgs_MeetingMinutesEN.UpdUser == "[null]" ? null :  objvgs_MeetingMinutesEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_MeetingMinutes.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.Year = objvgs_MeetingMinutesEN.Year == "[null]" ? null :  objvgs_MeetingMinutesEN.Year; //年
}
if (arrFldSet.Contains(convgs_MeetingMinutes.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.Month = objvgs_MeetingMinutesEN.Month == "[null]" ? null :  objvgs_MeetingMinutesEN.Month; //月
}
if (arrFldSet.Contains(convgs_MeetingMinutes.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.Memo = objvgs_MeetingMinutesEN.Memo == "[null]" ? null :  objvgs_MeetingMinutesEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_MeetingMinutes.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.VersionCount = objvgs_MeetingMinutesEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_MeetingMinutes.Participants, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.Participants = objvgs_MeetingMinutesEN.Participants == "[null]" ? null :  objvgs_MeetingMinutesEN.Participants; //参会者
}
if (arrFldSet.Contains(convgs_MeetingMinutes.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_MeetingMinutesEN.IdCurrEduCls = objvgs_MeetingMinutesEN.IdCurrEduCls == "[null]" ? null :  objvgs_MeetingMinutesEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvgs_MeetingMinutesEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN)
{
try
{
if (objvgs_MeetingMinutesEN.TopicId == "[null]") objvgs_MeetingMinutesEN.TopicId = null; //主题Id
if (objvgs_MeetingMinutesEN.TopicName == "[null]") objvgs_MeetingMinutesEN.TopicName = null; //栏目主题
if (objvgs_MeetingMinutesEN.MeetingContent == "[null]") objvgs_MeetingMinutesEN.MeetingContent = null; //会议内容
if (objvgs_MeetingMinutesEN.MeetingDate == "[null]") objvgs_MeetingMinutesEN.MeetingDate = null; //会议日期
if (objvgs_MeetingMinutesEN.UpdDate == "[null]") objvgs_MeetingMinutesEN.UpdDate = null; //修改日期
if (objvgs_MeetingMinutesEN.UpdUser == "[null]") objvgs_MeetingMinutesEN.UpdUser = null; //修改人
if (objvgs_MeetingMinutesEN.Year == "[null]") objvgs_MeetingMinutesEN.Year = null; //年
if (objvgs_MeetingMinutesEN.Month == "[null]") objvgs_MeetingMinutesEN.Month = null; //月
if (objvgs_MeetingMinutesEN.Memo == "[null]") objvgs_MeetingMinutesEN.Memo = null; //备注
if (objvgs_MeetingMinutesEN.Participants == "[null]") objvgs_MeetingMinutesEN.Participants = null; //参会者
if (objvgs_MeetingMinutesEN.IdCurrEduCls == "[null]") objvgs_MeetingMinutesEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesEN)
{
 vgs_MeetingMinutesDA.CheckProperty4Condition(objvgs_MeetingMinutesEN);
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
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_MeetingMinutesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_MeetingMinutesBL没有刷新缓存机制(clsgs_MeetingMinutesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MeetingId");
//if (arrvgs_MeetingMinutesObjLstCache == null)
//{
//arrvgs_MeetingMinutesObjLstCache = vgs_MeetingMinutesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strMeetingId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_MeetingMinutesEN GetObjByMeetingIdCache(string strMeetingId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_MeetingMinutesEN._CurrTabName);
List<clsvgs_MeetingMinutesEN> arrvgs_MeetingMinutesObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_MeetingMinutesEN> arrvgs_MeetingMinutesObjLst_Sel =
arrvgs_MeetingMinutesObjLstCache
.Where(x=> x.MeetingId == strMeetingId 
);
if (arrvgs_MeetingMinutesObjLst_Sel.Count() == 0)
{
   clsvgs_MeetingMinutesEN obj = clsvgs_MeetingMinutesBL.GetObjByMeetingId(strMeetingId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_MeetingMinutesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_MeetingMinutesEN> GetAllvgs_MeetingMinutesObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_MeetingMinutesEN> arrvgs_MeetingMinutesObjLstCache = GetObjLstCache(); 
return arrvgs_MeetingMinutesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_MeetingMinutesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_MeetingMinutesEN._CurrTabName);
List<clsvgs_MeetingMinutesEN> arrvgs_MeetingMinutesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_MeetingMinutesObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_MeetingMinutesEN._CurrTabName);
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
 /// 日期:2023-10-08
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strMeetingId)
{
if (strInFldName != convgs_MeetingMinutes.MeetingId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_MeetingMinutes.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_MeetingMinutes.AttributeName));
throw new Exception(strMsg);
}
var objvgs_MeetingMinutes = clsvgs_MeetingMinutesBL.GetObjByMeetingIdCache(strMeetingId);
if (objvgs_MeetingMinutes == null) return "";
return objvgs_MeetingMinutes[strOutFldName].ToString();
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
int intRecCount = clsvgs_MeetingMinutesDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_MeetingMinutesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_MeetingMinutesDA.GetRecCount();
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
int intRecCount = clsvgs_MeetingMinutesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_MeetingMinutesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_MeetingMinutesEN objvgs_MeetingMinutesCond)
{
List<clsvgs_MeetingMinutesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_MeetingMinutesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_MeetingMinutes.AttributeName)
{
if (objvgs_MeetingMinutesCond.IsUpdated(strFldName) == false) continue;
if (objvgs_MeetingMinutesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_MeetingMinutesCond[strFldName].ToString());
}
else
{
if (objvgs_MeetingMinutesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_MeetingMinutesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_MeetingMinutesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_MeetingMinutesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_MeetingMinutesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_MeetingMinutesCond[strFldName]));
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
 List<string> arrList = clsvgs_MeetingMinutesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_MeetingMinutesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_MeetingMinutesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}