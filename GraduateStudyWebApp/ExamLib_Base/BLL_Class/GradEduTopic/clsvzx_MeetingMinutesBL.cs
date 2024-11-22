
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_MeetingMinutesBL
 表名:vzx_MeetingMinutes(01120831)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:13:51
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
public static class  clsvzx_MeetingMinutesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_MeetingMinutesEN GetObj(this K_zxMeetingId_vzx_MeetingMinutes myKey)
{
clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = clsvzx_MeetingMinutesBL.vzx_MeetingMinutesDA.GetObjByzxMeetingId(myKey.Value);
return objvzx_MeetingMinutesEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetGroupTextName(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_MeetingMinutes.GroupTextName);
}
objvzx_MeetingMinutesEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.GroupTextName) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.GroupTextName, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.GroupTextName] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetzxMeetingId(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strzxMeetingId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxMeetingId, 10, convzx_MeetingMinutes.zxMeetingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxMeetingId, 10, convzx_MeetingMinutes.zxMeetingId);
}
objvzx_MeetingMinutesEN.zxMeetingId = strzxMeetingId; //会议Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.zxMeetingId) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.zxMeetingId, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.zxMeetingId] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetGroupTextId(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_MeetingMinutes.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_MeetingMinutes.GroupTextId);
}
objvzx_MeetingMinutesEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.GroupTextId) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.GroupTextId, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.GroupTextId] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetIsSubmit(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_MeetingMinutesEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.IsSubmit) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.IsSubmit, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.IsSubmit] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetMeetingContent(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strMeetingContent, string strComparisonOp="")
	{
objvzx_MeetingMinutesEN.MeetingContent = strMeetingContent; //会议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.MeetingContent) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.MeetingContent, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.MeetingContent] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetMeetingDate(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strMeetingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeetingDate, 20, convzx_MeetingMinutes.MeetingDate);
}
objvzx_MeetingMinutesEN.MeetingDate = strMeetingDate; //会议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.MeetingDate) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.MeetingDate, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.MeetingDate] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetUpdDate(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_MeetingMinutes.UpdDate);
}
objvzx_MeetingMinutesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.UpdDate) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.UpdDate, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.UpdDate] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetUpdUser(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_MeetingMinutes.UpdUser);
}
objvzx_MeetingMinutesEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.UpdUser) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.UpdUser, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.UpdUser] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetYear(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, convzx_MeetingMinutes.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, convzx_MeetingMinutes.Year);
}
objvzx_MeetingMinutesEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.Year) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.Year, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.Year] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetMonth(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, convzx_MeetingMinutes.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, convzx_MeetingMinutes.Month);
}
objvzx_MeetingMinutesEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.Month) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.Month, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.Month] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetMemo(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_MeetingMinutes.Memo);
}
objvzx_MeetingMinutesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.Memo) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.Memo, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.Memo] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetVersionCount(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_MeetingMinutesEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.VersionCount) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.VersionCount, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.VersionCount] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetParticipants(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strParticipants, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipants, 500, convzx_MeetingMinutes.Participants);
}
objvzx_MeetingMinutesEN.Participants = strParticipants; //参会者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.Participants) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.Participants, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.Participants] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_MeetingMinutesEN SetIdCurrEduCls(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_MeetingMinutes.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_MeetingMinutes.IdCurrEduCls);
}
objvzx_MeetingMinutesEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(convzx_MeetingMinutes.IdCurrEduCls) == false)
{
objvzx_MeetingMinutesEN.dicFldComparisonOp.Add(convzx_MeetingMinutes.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_MeetingMinutesEN.dicFldComparisonOp[convzx_MeetingMinutes.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_MeetingMinutesEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesENS">源对象</param>
 /// <param name = "objvzx_MeetingMinutesENT">目标对象</param>
 public static void CopyTo(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesENS, clsvzx_MeetingMinutesEN objvzx_MeetingMinutesENT)
{
try
{
objvzx_MeetingMinutesENT.GroupTextName = objvzx_MeetingMinutesENS.GroupTextName; //小组名称
objvzx_MeetingMinutesENT.zxMeetingId = objvzx_MeetingMinutesENS.zxMeetingId; //会议Id
objvzx_MeetingMinutesENT.GroupTextId = objvzx_MeetingMinutesENS.GroupTextId; //小组Id
objvzx_MeetingMinutesENT.IsSubmit = objvzx_MeetingMinutesENS.IsSubmit; //是否提交
objvzx_MeetingMinutesENT.MeetingContent = objvzx_MeetingMinutesENS.MeetingContent; //会议内容
objvzx_MeetingMinutesENT.MeetingDate = objvzx_MeetingMinutesENS.MeetingDate; //会议日期
objvzx_MeetingMinutesENT.UpdDate = objvzx_MeetingMinutesENS.UpdDate; //修改日期
objvzx_MeetingMinutesENT.UpdUser = objvzx_MeetingMinutesENS.UpdUser; //修改人
objvzx_MeetingMinutesENT.Year = objvzx_MeetingMinutesENS.Year; //年
objvzx_MeetingMinutesENT.Month = objvzx_MeetingMinutesENS.Month; //月
objvzx_MeetingMinutesENT.Memo = objvzx_MeetingMinutesENS.Memo; //备注
objvzx_MeetingMinutesENT.VersionCount = objvzx_MeetingMinutesENS.VersionCount; //版本统计
objvzx_MeetingMinutesENT.Participants = objvzx_MeetingMinutesENS.Participants; //参会者
objvzx_MeetingMinutesENT.IdCurrEduCls = objvzx_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvzx_MeetingMinutesENS">源对象</param>
 /// <returns>目标对象=>clsvzx_MeetingMinutesEN:objvzx_MeetingMinutesENT</returns>
 public static clsvzx_MeetingMinutesEN CopyTo(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesENS)
{
try
{
 clsvzx_MeetingMinutesEN objvzx_MeetingMinutesENT = new clsvzx_MeetingMinutesEN()
{
GroupTextName = objvzx_MeetingMinutesENS.GroupTextName, //小组名称
zxMeetingId = objvzx_MeetingMinutesENS.zxMeetingId, //会议Id
GroupTextId = objvzx_MeetingMinutesENS.GroupTextId, //小组Id
IsSubmit = objvzx_MeetingMinutesENS.IsSubmit, //是否提交
MeetingContent = objvzx_MeetingMinutesENS.MeetingContent, //会议内容
MeetingDate = objvzx_MeetingMinutesENS.MeetingDate, //会议日期
UpdDate = objvzx_MeetingMinutesENS.UpdDate, //修改日期
UpdUser = objvzx_MeetingMinutesENS.UpdUser, //修改人
Year = objvzx_MeetingMinutesENS.Year, //年
Month = objvzx_MeetingMinutesENS.Month, //月
Memo = objvzx_MeetingMinutesENS.Memo, //备注
VersionCount = objvzx_MeetingMinutesENS.VersionCount, //版本统计
Participants = objvzx_MeetingMinutesENS.Participants, //参会者
IdCurrEduCls = objvzx_MeetingMinutesENS.IdCurrEduCls, //教学班流水号
};
 return objvzx_MeetingMinutesENT;
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
public static void CheckProperty4Condition(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN)
{
 clsvzx_MeetingMinutesBL.vzx_MeetingMinutesDA.CheckProperty4Condition(objvzx_MeetingMinutesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_MeetingMinutesEN objvzx_MeetingMinutesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.GroupTextName, objvzx_MeetingMinutesCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.zxMeetingId) == true)
{
string strComparisonOpzxMeetingId = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.zxMeetingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.zxMeetingId, objvzx_MeetingMinutesCond.zxMeetingId, strComparisonOpzxMeetingId);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.GroupTextId, objvzx_MeetingMinutesCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.IsSubmit) == true)
{
if (objvzx_MeetingMinutesCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_MeetingMinutes.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_MeetingMinutes.IsSubmit);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.MeetingDate) == true)
{
string strComparisonOpMeetingDate = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.MeetingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.MeetingDate, objvzx_MeetingMinutesCond.MeetingDate, strComparisonOpMeetingDate);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.UpdDate, objvzx_MeetingMinutesCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.UpdUser, objvzx_MeetingMinutesCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.Year) == true)
{
string strComparisonOpYear = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.Year, objvzx_MeetingMinutesCond.Year, strComparisonOpYear);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.Month) == true)
{
string strComparisonOpMonth = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.Month, objvzx_MeetingMinutesCond.Month, strComparisonOpMonth);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.Memo) == true)
{
string strComparisonOpMemo = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.Memo, objvzx_MeetingMinutesCond.Memo, strComparisonOpMemo);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_MeetingMinutes.VersionCount, objvzx_MeetingMinutesCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.Participants) == true)
{
string strComparisonOpParticipants = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.Participants];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.Participants, objvzx_MeetingMinutesCond.Participants, strComparisonOpParticipants);
}
if (objvzx_MeetingMinutesCond.IsUpdated(convzx_MeetingMinutes.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_MeetingMinutesCond.dicFldComparisonOp[convzx_MeetingMinutes.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_MeetingMinutes.IdCurrEduCls, objvzx_MeetingMinutesCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_MeetingMinutes
{
public virtual bool UpdRelaTabDate(string strzxMeetingId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_MeetingMinutes(vzx_MeetingMinutes)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_MeetingMinutesBL
{
public static RelatedActions_vzx_MeetingMinutes relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_MeetingMinutesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_MeetingMinutesDA vzx_MeetingMinutesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_MeetingMinutesDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_MeetingMinutesBL()
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
if (string.IsNullOrEmpty(clsvzx_MeetingMinutesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_MeetingMinutesEN._ConnectString);
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
public static DataTable GetDataTable_vzx_MeetingMinutes(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_MeetingMinutesDA.GetDataTable_vzx_MeetingMinutes(strWhereCond);
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
objDT = vzx_MeetingMinutesDA.GetDataTable(strWhereCond);
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
objDT = vzx_MeetingMinutesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_MeetingMinutesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_MeetingMinutesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_MeetingMinutesDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_MeetingMinutesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_MeetingMinutesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_MeetingMinutesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxMeetingIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvzx_MeetingMinutesEN> GetObjLstByZxMeetingIdLst(List<string> arrZxMeetingIdLst)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxMeetingIdLst, true);
 string strWhereCond = string.Format("zxMeetingId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxMeetingIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_MeetingMinutesEN> GetObjLstByZxMeetingIdLstCache(List<string> arrZxMeetingIdLst)
{
string strKey = string.Format("{0}", clsvzx_MeetingMinutesEN._CurrTabName);
List<clsvzx_MeetingMinutesEN> arrvzx_MeetingMinutesObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_MeetingMinutesEN> arrvzx_MeetingMinutesObjLst_Sel =
arrvzx_MeetingMinutesObjLstCache
.Where(x => arrZxMeetingIdLst.Contains(x.zxMeetingId));
return arrvzx_MeetingMinutesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_MeetingMinutesEN> GetObjLst(string strWhereCond)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
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
public static List<clsvzx_MeetingMinutesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_MeetingMinutesEN> GetSubObjLstCache(clsvzx_MeetingMinutesEN objvzx_MeetingMinutesCond)
{
List<clsvzx_MeetingMinutesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_MeetingMinutesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_MeetingMinutes.AttributeName)
{
if (objvzx_MeetingMinutesCond.IsUpdated(strFldName) == false) continue;
if (objvzx_MeetingMinutesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_MeetingMinutesCond[strFldName].ToString());
}
else
{
if (objvzx_MeetingMinutesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_MeetingMinutesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_MeetingMinutesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_MeetingMinutesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_MeetingMinutesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_MeetingMinutesCond[strFldName]));
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
public static List<clsvzx_MeetingMinutesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
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
public static List<clsvzx_MeetingMinutesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
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
List<clsvzx_MeetingMinutesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_MeetingMinutesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_MeetingMinutesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_MeetingMinutesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
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
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
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
public static List<clsvzx_MeetingMinutesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_MeetingMinutesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_MeetingMinutesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
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
public static List<clsvzx_MeetingMinutesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_MeetingMinutesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_MeetingMinutesEN> arrObjLst = new List<clsvzx_MeetingMinutesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = new clsvzx_MeetingMinutesEN();
try
{
objvzx_MeetingMinutesEN.GroupTextName = objRow[convzx_MeetingMinutes.GroupTextName] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextName].ToString().Trim(); //小组名称
objvzx_MeetingMinutesEN.zxMeetingId = objRow[convzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objvzx_MeetingMinutesEN.GroupTextId = objRow[convzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objvzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objvzx_MeetingMinutesEN.MeetingContent = objRow[convzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objvzx_MeetingMinutesEN.MeetingDate = objRow[convzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objvzx_MeetingMinutesEN.UpdDate = objRow[convzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objvzx_MeetingMinutesEN.UpdUser = objRow[convzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objvzx_MeetingMinutesEN.Year = objRow[convzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Year].ToString().Trim(); //年
objvzx_MeetingMinutesEN.Month = objRow[convzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Month].ToString().Trim(); //月
objvzx_MeetingMinutesEN.Memo = objRow[convzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objvzx_MeetingMinutesEN.VersionCount = objRow[convzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objvzx_MeetingMinutesEN.Participants = objRow[convzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objvzx_MeetingMinutesEN.IdCurrEduCls = objRow[convzx_MeetingMinutes.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_MeetingMinutesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_MeetingMinutes(ref clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN)
{
bool bolResult = vzx_MeetingMinutesDA.Getvzx_MeetingMinutes(ref objvzx_MeetingMinutesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_MeetingMinutesEN GetObjByzxMeetingId(string strzxMeetingId)
{
if (strzxMeetingId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxMeetingId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxMeetingId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxMeetingId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = vzx_MeetingMinutesDA.GetObjByzxMeetingId(strzxMeetingId);
return objvzx_MeetingMinutesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_MeetingMinutesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = vzx_MeetingMinutesDA.GetFirstObj(strWhereCond);
 return objvzx_MeetingMinutesEN;
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
public static clsvzx_MeetingMinutesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = vzx_MeetingMinutesDA.GetObjByDataRow(objRow);
 return objvzx_MeetingMinutesEN;
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
public static clsvzx_MeetingMinutesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN = vzx_MeetingMinutesDA.GetObjByDataRow(objRow);
 return objvzx_MeetingMinutesEN;
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
 /// <param name = "strzxMeetingId">所给的关键字</param>
 /// <param name = "lstvzx_MeetingMinutesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_MeetingMinutesEN GetObjByzxMeetingIdFromList(string strzxMeetingId, List<clsvzx_MeetingMinutesEN> lstvzx_MeetingMinutesObjLst)
{
foreach (clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN in lstvzx_MeetingMinutesObjLst)
{
if (objvzx_MeetingMinutesEN.zxMeetingId == strzxMeetingId)
{
return objvzx_MeetingMinutesEN;
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
 string strMaxZxMeetingId;
 try
 {
 strMaxZxMeetingId = clsvzx_MeetingMinutesDA.GetMaxStrId();
 return strMaxZxMeetingId;
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
 string strzxMeetingId;
 try
 {
 strzxMeetingId = new clsvzx_MeetingMinutesDA().GetFirstID(strWhereCond);
 return strzxMeetingId;
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
 arrList = vzx_MeetingMinutesDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_MeetingMinutesDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxMeetingId)
{
if (string.IsNullOrEmpty(strzxMeetingId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxMeetingId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vzx_MeetingMinutesDA.IsExist(strzxMeetingId);
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
 bolIsExist = clsvzx_MeetingMinutesDA.IsExistTable();
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
 bolIsExist = vzx_MeetingMinutesDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_MeetingMinutesENS">源对象</param>
 /// <param name = "objvzx_MeetingMinutesENT">目标对象</param>
 public static void CopyTo(clsvzx_MeetingMinutesEN objvzx_MeetingMinutesENS, clsvzx_MeetingMinutesEN objvzx_MeetingMinutesENT)
{
try
{
objvzx_MeetingMinutesENT.GroupTextName = objvzx_MeetingMinutesENS.GroupTextName; //小组名称
objvzx_MeetingMinutesENT.zxMeetingId = objvzx_MeetingMinutesENS.zxMeetingId; //会议Id
objvzx_MeetingMinutesENT.GroupTextId = objvzx_MeetingMinutesENS.GroupTextId; //小组Id
objvzx_MeetingMinutesENT.IsSubmit = objvzx_MeetingMinutesENS.IsSubmit; //是否提交
objvzx_MeetingMinutesENT.MeetingContent = objvzx_MeetingMinutesENS.MeetingContent; //会议内容
objvzx_MeetingMinutesENT.MeetingDate = objvzx_MeetingMinutesENS.MeetingDate; //会议日期
objvzx_MeetingMinutesENT.UpdDate = objvzx_MeetingMinutesENS.UpdDate; //修改日期
objvzx_MeetingMinutesENT.UpdUser = objvzx_MeetingMinutesENS.UpdUser; //修改人
objvzx_MeetingMinutesENT.Year = objvzx_MeetingMinutesENS.Year; //年
objvzx_MeetingMinutesENT.Month = objvzx_MeetingMinutesENS.Month; //月
objvzx_MeetingMinutesENT.Memo = objvzx_MeetingMinutesENS.Memo; //备注
objvzx_MeetingMinutesENT.VersionCount = objvzx_MeetingMinutesENS.VersionCount; //版本统计
objvzx_MeetingMinutesENT.Participants = objvzx_MeetingMinutesENS.Participants; //参会者
objvzx_MeetingMinutesENT.IdCurrEduCls = objvzx_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvzx_MeetingMinutesEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN)
{
try
{
objvzx_MeetingMinutesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_MeetingMinutesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_MeetingMinutes.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.GroupTextName = objvzx_MeetingMinutesEN.GroupTextName == "[null]" ? null :  objvzx_MeetingMinutesEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_MeetingMinutes.zxMeetingId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.zxMeetingId = objvzx_MeetingMinutesEN.zxMeetingId; //会议Id
}
if (arrFldSet.Contains(convzx_MeetingMinutes.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.GroupTextId = objvzx_MeetingMinutesEN.GroupTextId == "[null]" ? null :  objvzx_MeetingMinutesEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_MeetingMinutes.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.IsSubmit = objvzx_MeetingMinutesEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_MeetingMinutes.MeetingContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.MeetingContent = objvzx_MeetingMinutesEN.MeetingContent == "[null]" ? null :  objvzx_MeetingMinutesEN.MeetingContent; //会议内容
}
if (arrFldSet.Contains(convzx_MeetingMinutes.MeetingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.MeetingDate = objvzx_MeetingMinutesEN.MeetingDate == "[null]" ? null :  objvzx_MeetingMinutesEN.MeetingDate; //会议日期
}
if (arrFldSet.Contains(convzx_MeetingMinutes.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.UpdDate = objvzx_MeetingMinutesEN.UpdDate == "[null]" ? null :  objvzx_MeetingMinutesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_MeetingMinutes.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.UpdUser = objvzx_MeetingMinutesEN.UpdUser == "[null]" ? null :  objvzx_MeetingMinutesEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_MeetingMinutes.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.Year = objvzx_MeetingMinutesEN.Year == "[null]" ? null :  objvzx_MeetingMinutesEN.Year; //年
}
if (arrFldSet.Contains(convzx_MeetingMinutes.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.Month = objvzx_MeetingMinutesEN.Month == "[null]" ? null :  objvzx_MeetingMinutesEN.Month; //月
}
if (arrFldSet.Contains(convzx_MeetingMinutes.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.Memo = objvzx_MeetingMinutesEN.Memo == "[null]" ? null :  objvzx_MeetingMinutesEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_MeetingMinutes.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.VersionCount = objvzx_MeetingMinutesEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_MeetingMinutes.Participants, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.Participants = objvzx_MeetingMinutesEN.Participants == "[null]" ? null :  objvzx_MeetingMinutesEN.Participants; //参会者
}
if (arrFldSet.Contains(convzx_MeetingMinutes.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_MeetingMinutesEN.IdCurrEduCls = objvzx_MeetingMinutesEN.IdCurrEduCls == "[null]" ? null :  objvzx_MeetingMinutesEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvzx_MeetingMinutesEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN)
{
try
{
if (objvzx_MeetingMinutesEN.GroupTextName == "[null]") objvzx_MeetingMinutesEN.GroupTextName = null; //小组名称
if (objvzx_MeetingMinutesEN.GroupTextId == "[null]") objvzx_MeetingMinutesEN.GroupTextId = null; //小组Id
if (objvzx_MeetingMinutesEN.MeetingContent == "[null]") objvzx_MeetingMinutesEN.MeetingContent = null; //会议内容
if (objvzx_MeetingMinutesEN.MeetingDate == "[null]") objvzx_MeetingMinutesEN.MeetingDate = null; //会议日期
if (objvzx_MeetingMinutesEN.UpdDate == "[null]") objvzx_MeetingMinutesEN.UpdDate = null; //修改日期
if (objvzx_MeetingMinutesEN.UpdUser == "[null]") objvzx_MeetingMinutesEN.UpdUser = null; //修改人
if (objvzx_MeetingMinutesEN.Year == "[null]") objvzx_MeetingMinutesEN.Year = null; //年
if (objvzx_MeetingMinutesEN.Month == "[null]") objvzx_MeetingMinutesEN.Month = null; //月
if (objvzx_MeetingMinutesEN.Memo == "[null]") objvzx_MeetingMinutesEN.Memo = null; //备注
if (objvzx_MeetingMinutesEN.Participants == "[null]") objvzx_MeetingMinutesEN.Participants = null; //参会者
if (objvzx_MeetingMinutesEN.IdCurrEduCls == "[null]") objvzx_MeetingMinutesEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvzx_MeetingMinutesEN objvzx_MeetingMinutesEN)
{
 vzx_MeetingMinutesDA.CheckProperty4Condition(objvzx_MeetingMinutesEN);
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
if (clszx_MeetingMinutesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_MeetingMinutesBL没有刷新缓存机制(clszx_MeetingMinutesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxMeetingId");
//if (arrvzx_MeetingMinutesObjLstCache == null)
//{
//arrvzx_MeetingMinutesObjLstCache = vzx_MeetingMinutesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxMeetingId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_MeetingMinutesEN GetObjByzxMeetingIdCache(string strzxMeetingId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_MeetingMinutesEN._CurrTabName);
List<clsvzx_MeetingMinutesEN> arrvzx_MeetingMinutesObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_MeetingMinutesEN> arrvzx_MeetingMinutesObjLst_Sel =
arrvzx_MeetingMinutesObjLstCache
.Where(x=> x.zxMeetingId == strzxMeetingId 
);
if (arrvzx_MeetingMinutesObjLst_Sel.Count() == 0)
{
   clsvzx_MeetingMinutesEN obj = clsvzx_MeetingMinutesBL.GetObjByzxMeetingId(strzxMeetingId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_MeetingMinutesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_MeetingMinutesEN> GetAllvzx_MeetingMinutesObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_MeetingMinutesEN> arrvzx_MeetingMinutesObjLstCache = GetObjLstCache(); 
return arrvzx_MeetingMinutesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_MeetingMinutesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_MeetingMinutesEN._CurrTabName);
List<clsvzx_MeetingMinutesEN> arrvzx_MeetingMinutesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_MeetingMinutesObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_MeetingMinutesEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strzxMeetingId)
{
if (strInFldName != convzx_MeetingMinutes.zxMeetingId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_MeetingMinutes.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_MeetingMinutes.AttributeName));
throw new Exception(strMsg);
}
var objvzx_MeetingMinutes = clsvzx_MeetingMinutesBL.GetObjByzxMeetingIdCache(strzxMeetingId);
if (objvzx_MeetingMinutes == null) return "";
return objvzx_MeetingMinutes[strOutFldName].ToString();
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
int intRecCount = clsvzx_MeetingMinutesDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_MeetingMinutesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_MeetingMinutesDA.GetRecCount();
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
int intRecCount = clsvzx_MeetingMinutesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_MeetingMinutesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_MeetingMinutesEN objvzx_MeetingMinutesCond)
{
List<clsvzx_MeetingMinutesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_MeetingMinutesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_MeetingMinutes.AttributeName)
{
if (objvzx_MeetingMinutesCond.IsUpdated(strFldName) == false) continue;
if (objvzx_MeetingMinutesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_MeetingMinutesCond[strFldName].ToString());
}
else
{
if (objvzx_MeetingMinutesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_MeetingMinutesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_MeetingMinutesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_MeetingMinutesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_MeetingMinutesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_MeetingMinutesCond[strFldName]));
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
 List<string> arrList = clsvzx_MeetingMinutesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_MeetingMinutesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_MeetingMinutesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}