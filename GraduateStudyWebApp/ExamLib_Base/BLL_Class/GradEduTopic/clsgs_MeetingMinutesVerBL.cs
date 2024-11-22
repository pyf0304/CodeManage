
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_MeetingMinutesVerBL
 表名:gs_MeetingMinutesVer(01120769)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:58
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
public static class  clsgs_MeetingMinutesVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngMeetingVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_MeetingMinutesVerEN GetObj(this K_MeetingVId_gs_MeetingMinutesVer myKey)
{
clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.GetObjByMeetingVId(myKey.Value);
return objgs_MeetingMinutesVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_MeetingMinutesVerEN) == false)
{
var strMsg = string.Format("记录已经存在!MeetingVId = [{0}]的数据已经存在!(in clsgs_MeetingMinutesVerBL.AddNewRecord)", objgs_MeetingMinutesVerEN.MeetingVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.AddNewRecordBySQL2(objgs_MeetingMinutesVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objgs_MeetingMinutesVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_MeetingMinutesVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(MeetingVId(MeetingVId)=[{0}])已经存在,不能重复!", objgs_MeetingMinutesVerEN.MeetingVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_MeetingMinutesVerEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_MeetingMinutesVerEN) == false)
{
var strMsg = string.Format("记录已经存在!MeetingVId = [{0}]的数据已经存在!(in clsgs_MeetingMinutesVerBL.AddNewRecordWithReturnKey)", objgs_MeetingMinutesVerEN.MeetingVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.AddNewRecordBySQL2WithReturnKey(objgs_MeetingMinutesVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetMeetingVId(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, long lngMeetingVId, string strComparisonOp="")
	{
objgs_MeetingMinutesVerEN.MeetingVId = lngMeetingVId; //MeetingVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.MeetingVId) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.MeetingVId, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.MeetingVId] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetMeetingId(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strMeetingId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMeetingId, congs_MeetingMinutesVer.MeetingId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeetingId, 10, congs_MeetingMinutesVer.MeetingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMeetingId, 10, congs_MeetingMinutesVer.MeetingId);
}
objgs_MeetingMinutesVerEN.MeetingId = strMeetingId; //会议Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.MeetingId) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.MeetingId, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.MeetingId] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetTopicId(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_MeetingMinutesVer.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_MeetingMinutesVer.TopicId);
}
objgs_MeetingMinutesVerEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.TopicId) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.TopicId, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.TopicId] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetIsSubmit(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objgs_MeetingMinutesVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.IsSubmit) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.IsSubmit, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.IsSubmit] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetMeetingContent(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strMeetingContent, string strComparisonOp="")
	{
objgs_MeetingMinutesVerEN.MeetingContent = strMeetingContent; //会议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.MeetingContent) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.MeetingContent, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.MeetingContent] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetMeetingDate(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strMeetingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeetingDate, 20, congs_MeetingMinutesVer.MeetingDate);
}
objgs_MeetingMinutesVerEN.MeetingDate = strMeetingDate; //会议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.MeetingDate) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.MeetingDate, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.MeetingDate] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetUpdDate(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_MeetingMinutesVer.UpdDate);
}
objgs_MeetingMinutesVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.UpdDate) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.UpdDate, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.UpdDate] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetUpdUser(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_MeetingMinutesVer.UpdUser);
}
objgs_MeetingMinutesVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.UpdUser) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.UpdUser, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.UpdUser] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetYear(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, congs_MeetingMinutesVer.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, congs_MeetingMinutesVer.Year);
}
objgs_MeetingMinutesVerEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.Year) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.Year, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.Year] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetMonth(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, congs_MeetingMinutesVer.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, congs_MeetingMinutesVer.Month);
}
objgs_MeetingMinutesVerEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.Month) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.Month, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.Month] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetMemo(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_MeetingMinutesVer.Memo);
}
objgs_MeetingMinutesVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.Memo) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.Memo, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.Memo] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_MeetingMinutesVerEN SetParticipants(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strParticipants, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipants, 500, congs_MeetingMinutesVer.Participants);
}
objgs_MeetingMinutesVerEN.Participants = strParticipants; //参会者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_MeetingMinutesVerEN.dicFldComparisonOp.ContainsKey(congs_MeetingMinutesVer.Participants) == false)
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp.Add(congs_MeetingMinutesVer.Participants, strComparisonOp);
}
else
{
objgs_MeetingMinutesVerEN.dicFldComparisonOp[congs_MeetingMinutesVer.Participants] = strComparisonOp;
}
}
return objgs_MeetingMinutesVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_MeetingMinutesVerEN.CheckPropertyNew();
clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerCond = new clsgs_MeetingMinutesVerEN();
string strCondition = objgs_MeetingMinutesVerCond
.SetMeetingVId(objgs_MeetingMinutesVerEN.MeetingVId, "<>")
.SetMeetingVId(objgs_MeetingMinutesVerEN.MeetingVId, "=")
.GetCombineCondition();
objgs_MeetingMinutesVerEN._IsCheckProperty = true;
bool bolIsExist = clsgs_MeetingMinutesVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(MeetingVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_MeetingMinutesVerEN.Update();
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
 /// <param name = "objgs_MeetingMinutesVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerCond = new clsgs_MeetingMinutesVerEN();
string strCondition = objgs_MeetingMinutesVerCond
.SetMeetingVId(objgs_MeetingMinutesVer.MeetingVId, "=")
.GetCombineCondition();
objgs_MeetingMinutesVer._IsCheckProperty = true;
bool bolIsExist = clsgs_MeetingMinutesVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_MeetingMinutesVer.MeetingVId = clsgs_MeetingMinutesVerBL.GetFirstID_S(strCondition);
objgs_MeetingMinutesVer.UpdateWithCondition(strCondition);
}
else
{
objgs_MeetingMinutesVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
 if (objgs_MeetingMinutesVerEN.MeetingVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.UpdateBySql2(objgs_MeetingMinutesVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_MeetingMinutesVerEN.MeetingVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.UpdateBySql2(objgs_MeetingMinutesVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.UpdateBySqlWithCondition(objgs_MeetingMinutesVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.UpdateBySqlWithConditionTransaction(objgs_MeetingMinutesVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "lngMeetingVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
try
{
int intRecNum = clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.DelRecord(objgs_MeetingMinutesVerEN.MeetingVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerENS">源对象</param>
 /// <param name = "objgs_MeetingMinutesVerENT">目标对象</param>
 public static void CopyTo(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerENS, clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerENT)
{
try
{
objgs_MeetingMinutesVerENT.MeetingVId = objgs_MeetingMinutesVerENS.MeetingVId; //MeetingVId
objgs_MeetingMinutesVerENT.MeetingId = objgs_MeetingMinutesVerENS.MeetingId; //会议Id
objgs_MeetingMinutesVerENT.TopicId = objgs_MeetingMinutesVerENS.TopicId; //主题Id
objgs_MeetingMinutesVerENT.IsSubmit = objgs_MeetingMinutesVerENS.IsSubmit; //是否提交
objgs_MeetingMinutesVerENT.MeetingContent = objgs_MeetingMinutesVerENS.MeetingContent; //会议内容
objgs_MeetingMinutesVerENT.MeetingDate = objgs_MeetingMinutesVerENS.MeetingDate; //会议日期
objgs_MeetingMinutesVerENT.UpdDate = objgs_MeetingMinutesVerENS.UpdDate; //修改日期
objgs_MeetingMinutesVerENT.UpdUser = objgs_MeetingMinutesVerENS.UpdUser; //修改人
objgs_MeetingMinutesVerENT.Year = objgs_MeetingMinutesVerENS.Year; //年
objgs_MeetingMinutesVerENT.Month = objgs_MeetingMinutesVerENS.Month; //月
objgs_MeetingMinutesVerENT.Memo = objgs_MeetingMinutesVerENS.Memo; //备注
objgs_MeetingMinutesVerENT.Participants = objgs_MeetingMinutesVerENS.Participants; //参会者
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
 /// <param name = "objgs_MeetingMinutesVerENS">源对象</param>
 /// <returns>目标对象=>clsgs_MeetingMinutesVerEN:objgs_MeetingMinutesVerENT</returns>
 public static clsgs_MeetingMinutesVerEN CopyTo(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerENS)
{
try
{
 clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerENT = new clsgs_MeetingMinutesVerEN()
{
MeetingVId = objgs_MeetingMinutesVerENS.MeetingVId, //MeetingVId
MeetingId = objgs_MeetingMinutesVerENS.MeetingId, //会议Id
TopicId = objgs_MeetingMinutesVerENS.TopicId, //主题Id
IsSubmit = objgs_MeetingMinutesVerENS.IsSubmit, //是否提交
MeetingContent = objgs_MeetingMinutesVerENS.MeetingContent, //会议内容
MeetingDate = objgs_MeetingMinutesVerENS.MeetingDate, //会议日期
UpdDate = objgs_MeetingMinutesVerENS.UpdDate, //修改日期
UpdUser = objgs_MeetingMinutesVerENS.UpdUser, //修改人
Year = objgs_MeetingMinutesVerENS.Year, //年
Month = objgs_MeetingMinutesVerENS.Month, //月
Memo = objgs_MeetingMinutesVerENS.Memo, //备注
Participants = objgs_MeetingMinutesVerENS.Participants, //参会者
};
 return objgs_MeetingMinutesVerENT;
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
public static void CheckPropertyNew(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
 clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.CheckPropertyNew(objgs_MeetingMinutesVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
 clsgs_MeetingMinutesVerBL.gs_MeetingMinutesVerDA.CheckProperty4Condition(objgs_MeetingMinutesVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.MeetingVId) == true)
{
string strComparisonOpMeetingVId = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.MeetingVId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_MeetingMinutesVer.MeetingVId, objgs_MeetingMinutesVerCond.MeetingVId, strComparisonOpMeetingVId);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.MeetingId) == true)
{
string strComparisonOpMeetingId = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.MeetingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.MeetingId, objgs_MeetingMinutesVerCond.MeetingId, strComparisonOpMeetingId);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.TopicId) == true)
{
string strComparisonOpTopicId = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.TopicId, objgs_MeetingMinutesVerCond.TopicId, strComparisonOpTopicId);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.IsSubmit) == true)
{
if (objgs_MeetingMinutesVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_MeetingMinutesVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_MeetingMinutesVer.IsSubmit);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.MeetingDate) == true)
{
string strComparisonOpMeetingDate = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.MeetingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.MeetingDate, objgs_MeetingMinutesVerCond.MeetingDate, strComparisonOpMeetingDate);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.UpdDate, objgs_MeetingMinutesVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.UpdUser, objgs_MeetingMinutesVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.Year) == true)
{
string strComparisonOpYear = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.Year, objgs_MeetingMinutesVerCond.Year, strComparisonOpYear);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.Month) == true)
{
string strComparisonOpMonth = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.Month, objgs_MeetingMinutesVerCond.Month, strComparisonOpMonth);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.Memo) == true)
{
string strComparisonOpMemo = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.Memo, objgs_MeetingMinutesVerCond.Memo, strComparisonOpMemo);
}
if (objgs_MeetingMinutesVerCond.IsUpdated(congs_MeetingMinutesVer.Participants) == true)
{
string strComparisonOpParticipants = objgs_MeetingMinutesVerCond.dicFldComparisonOp[congs_MeetingMinutesVer.Participants];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_MeetingMinutesVer.Participants, objgs_MeetingMinutesVerCond.Participants, strComparisonOpParticipants);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_MeetingMinutesVer(会议纪要历史版), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:MeetingVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_MeetingMinutesVerEN == null) return true;
if (objgs_MeetingMinutesVerEN.MeetingVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MeetingVId = '{0}'", objgs_MeetingMinutesVerEN.MeetingVId);
if (clsgs_MeetingMinutesVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("MeetingVId !=  {0}", objgs_MeetingMinutesVerEN.MeetingVId);
 sbCondition.AppendFormat(" and MeetingVId = '{0}'", objgs_MeetingMinutesVerEN.MeetingVId);
if (clsgs_MeetingMinutesVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_MeetingMinutesVer(会议纪要历史版), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:MeetingVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_MeetingMinutesVerEN == null) return "";
if (objgs_MeetingMinutesVerEN.MeetingVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and MeetingVId = '{0}'", objgs_MeetingMinutesVerEN.MeetingVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MeetingVId !=  {0}", objgs_MeetingMinutesVerEN.MeetingVId);
 sbCondition.AppendFormat(" and MeetingVId = '{0}'", objgs_MeetingMinutesVerEN.MeetingVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_MeetingMinutesVer
{
public virtual bool UpdRelaTabDate(long lngMeetingVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 会议纪要历史版(gs_MeetingMinutesVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_MeetingMinutesVerBL
{
public static RelatedActions_gs_MeetingMinutesVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_MeetingMinutesVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_MeetingMinutesVerDA gs_MeetingMinutesVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_MeetingMinutesVerDA();
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
 public clsgs_MeetingMinutesVerBL()
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
if (string.IsNullOrEmpty(clsgs_MeetingMinutesVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_MeetingMinutesVerEN._ConnectString);
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
public static DataTable GetDataTable_gs_MeetingMinutesVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_MeetingMinutesVerDA.GetDataTable_gs_MeetingMinutesVer(strWhereCond);
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
objDT = gs_MeetingMinutesVerDA.GetDataTable(strWhereCond);
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
objDT = gs_MeetingMinutesVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_MeetingMinutesVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_MeetingMinutesVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_MeetingMinutesVerDA.GetDataTable_Top(objTopPara);
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
objDT = gs_MeetingMinutesVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_MeetingMinutesVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_MeetingMinutesVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMeetingVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_MeetingMinutesVerEN> GetObjLstByMeetingVIdLst(List<long> arrMeetingVIdLst)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMeetingVIdLst);
 string strWhereCond = string.Format("MeetingVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMeetingVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_MeetingMinutesVerEN> GetObjLstByMeetingVIdLstCache(List<long> arrMeetingVIdLst)
{
string strKey = string.Format("{0}", clsgs_MeetingMinutesVerEN._CurrTabName);
List<clsgs_MeetingMinutesVerEN> arrgs_MeetingMinutesVerObjLstCache = GetObjLstCache();
IEnumerable <clsgs_MeetingMinutesVerEN> arrgs_MeetingMinutesVerObjLst_Sel =
arrgs_MeetingMinutesVerObjLstCache
.Where(x => arrMeetingVIdLst.Contains(x.MeetingVId));
return arrgs_MeetingMinutesVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_MeetingMinutesVerEN> GetObjLst(string strWhereCond)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
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
public static List<clsgs_MeetingMinutesVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_MeetingMinutesVerEN> GetSubObjLstCache(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerCond)
{
List<clsgs_MeetingMinutesVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_MeetingMinutesVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_MeetingMinutesVer.AttributeName)
{
if (objgs_MeetingMinutesVerCond.IsUpdated(strFldName) == false) continue;
if (objgs_MeetingMinutesVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_MeetingMinutesVerCond[strFldName].ToString());
}
else
{
if (objgs_MeetingMinutesVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_MeetingMinutesVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_MeetingMinutesVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_MeetingMinutesVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_MeetingMinutesVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_MeetingMinutesVerCond[strFldName]));
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
public static List<clsgs_MeetingMinutesVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
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
public static List<clsgs_MeetingMinutesVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
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
List<clsgs_MeetingMinutesVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_MeetingMinutesVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_MeetingMinutesVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_MeetingMinutesVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
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
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
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
public static List<clsgs_MeetingMinutesVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_MeetingMinutesVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_MeetingMinutesVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
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
public static List<clsgs_MeetingMinutesVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_MeetingMinutesVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_MeetingMinutesVerEN> arrObjLst = new List<clsgs_MeetingMinutesVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = new clsgs_MeetingMinutesVerEN();
try
{
objgs_MeetingMinutesVerEN.MeetingVId = Int32.Parse(objRow[congs_MeetingMinutesVer.MeetingVId].ToString().Trim()); //MeetingVId
objgs_MeetingMinutesVerEN.MeetingId = objRow[congs_MeetingMinutesVer.MeetingId].ToString().Trim(); //会议Id
objgs_MeetingMinutesVerEN.TopicId = objRow[congs_MeetingMinutesVer.TopicId] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.TopicId].ToString().Trim(); //主题Id
objgs_MeetingMinutesVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_MeetingMinutesVer.IsSubmit].ToString().Trim()); //是否提交
objgs_MeetingMinutesVerEN.MeetingContent = objRow[congs_MeetingMinutesVer.MeetingContent] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingContent].ToString().Trim(); //会议内容
objgs_MeetingMinutesVerEN.MeetingDate = objRow[congs_MeetingMinutesVer.MeetingDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.MeetingDate].ToString().Trim(); //会议日期
objgs_MeetingMinutesVerEN.UpdDate = objRow[congs_MeetingMinutesVer.UpdDate] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdDate].ToString().Trim(); //修改日期
objgs_MeetingMinutesVerEN.UpdUser = objRow[congs_MeetingMinutesVer.UpdUser] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.UpdUser].ToString().Trim(); //修改人
objgs_MeetingMinutesVerEN.Year = objRow[congs_MeetingMinutesVer.Year] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Year].ToString().Trim(); //年
objgs_MeetingMinutesVerEN.Month = objRow[congs_MeetingMinutesVer.Month] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Month].ToString().Trim(); //月
objgs_MeetingMinutesVerEN.Memo = objRow[congs_MeetingMinutesVer.Memo] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Memo].ToString().Trim(); //备注
objgs_MeetingMinutesVerEN.Participants = objRow[congs_MeetingMinutesVer.Participants] == DBNull.Value ? null : objRow[congs_MeetingMinutesVer.Participants].ToString().Trim(); //参会者
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_MeetingMinutesVerEN.MeetingVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_MeetingMinutesVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_MeetingMinutesVer(ref clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
bool bolResult = gs_MeetingMinutesVerDA.Getgs_MeetingMinutesVer(ref objgs_MeetingMinutesVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngMeetingVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_MeetingMinutesVerEN GetObjByMeetingVId(long lngMeetingVId)
{
clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = gs_MeetingMinutesVerDA.GetObjByMeetingVId(lngMeetingVId);
return objgs_MeetingMinutesVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_MeetingMinutesVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = gs_MeetingMinutesVerDA.GetFirstObj(strWhereCond);
 return objgs_MeetingMinutesVerEN;
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
public static clsgs_MeetingMinutesVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = gs_MeetingMinutesVerDA.GetObjByDataRow(objRow);
 return objgs_MeetingMinutesVerEN;
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
public static clsgs_MeetingMinutesVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = gs_MeetingMinutesVerDA.GetObjByDataRow(objRow);
 return objgs_MeetingMinutesVerEN;
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
 /// <param name = "lngMeetingVId">所给的关键字</param>
 /// <param name = "lstgs_MeetingMinutesVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_MeetingMinutesVerEN GetObjByMeetingVIdFromList(long lngMeetingVId, List<clsgs_MeetingMinutesVerEN> lstgs_MeetingMinutesVerObjLst)
{
foreach (clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN in lstgs_MeetingMinutesVerObjLst)
{
if (objgs_MeetingMinutesVerEN.MeetingVId == lngMeetingVId)
{
return objgs_MeetingMinutesVerEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngMeetingVId;
 try
 {
 lngMeetingVId = new clsgs_MeetingMinutesVerDA().GetFirstID(strWhereCond);
 return lngMeetingVId;
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
 arrList = gs_MeetingMinutesVerDA.GetID(strWhereCond);
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
bool bolIsExist = gs_MeetingMinutesVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngMeetingVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngMeetingVId)
{
//检测记录是否存在
bool bolIsExist = gs_MeetingMinutesVerDA.IsExist(lngMeetingVId);
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
 bolIsExist = clsgs_MeetingMinutesVerDA.IsExistTable();
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
 bolIsExist = gs_MeetingMinutesVerDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_MeetingMinutesVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!MeetingVId = [{0}]的数据已经存在!(in clsgs_MeetingMinutesVerBL.AddNewRecordBySql2)", objgs_MeetingMinutesVerEN.MeetingVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_MeetingMinutesVerDA.AddNewRecordBySQL2(objgs_MeetingMinutesVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_MeetingMinutesVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!MeetingVId = [{0}]的数据已经存在!(in clsgs_MeetingMinutesVerBL.AddNewRecordBySql2WithReturnKey)", objgs_MeetingMinutesVerEN.MeetingVId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_MeetingMinutesVerDA.AddNewRecordBySQL2WithReturnKey(objgs_MeetingMinutesVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
try
{
bool bolResult = gs_MeetingMinutesVerDA.Update(objgs_MeetingMinutesVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "objgs_MeetingMinutesVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
 if (objgs_MeetingMinutesVerEN.MeetingVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_MeetingMinutesVerDA.UpdateBySql2(objgs_MeetingMinutesVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_MeetingMinutesVerBL.ReFreshCache();

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
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
 /// <param name = "lngMeetingVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngMeetingVId)
{
try
{
 clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN = clsgs_MeetingMinutesVerBL.GetObjByMeetingVId(lngMeetingVId);

if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(objgs_MeetingMinutesVerEN.MeetingVId, "SetUpdDate");
}
if (objgs_MeetingMinutesVerEN != null)
{
int intRecNum = gs_MeetingMinutesVerDA.DelRecord(lngMeetingVId);
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
/// <param name="lngMeetingVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngMeetingVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_MeetingMinutesVerDA.GetSpecSQLObj();
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
//删除与表:[gs_MeetingMinutesVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_MeetingMinutesVer.MeetingVId,
//lngMeetingVId);
//        clsgs_MeetingMinutesVerBL.Delgs_MeetingMinutesVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_MeetingMinutesVerBL.DelRecord(lngMeetingVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_MeetingMinutesVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngMeetingVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngMeetingVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngMeetingVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(lngMeetingVId, "UpdRelaTabDate");
}
bool bolResult = gs_MeetingMinutesVerDA.DelRecord(lngMeetingVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrMeetingVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_MeetingMinutesVers(List<string> arrMeetingVIdLst)
{
if (arrMeetingVIdLst.Count == 0) return 0;
try
{
if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
foreach (var strMeetingVId in arrMeetingVIdLst)
{
long lngMeetingVId = long.Parse(strMeetingVId);
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(lngMeetingVId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_MeetingMinutesVerDA.Delgs_MeetingMinutesVer(arrMeetingVIdLst);
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
public static int Delgs_MeetingMinutesVersByCond(string strWhereCond)
{
try
{
if (clsgs_MeetingMinutesVerBL.relatedActions != null)
{
List<string> arrMeetingVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strMeetingVId in arrMeetingVId)
{
long lngMeetingVId = long.Parse(strMeetingVId);
clsgs_MeetingMinutesVerBL.relatedActions.UpdRelaTabDate(lngMeetingVId, "UpdRelaTabDate");
}
}
int intRecNum = gs_MeetingMinutesVerDA.Delgs_MeetingMinutesVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_MeetingMinutesVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngMeetingVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngMeetingVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_MeetingMinutesVerDA.GetSpecSQLObj();
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
//删除与表:[gs_MeetingMinutesVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_MeetingMinutesVerBL.DelRecord(lngMeetingVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_MeetingMinutesVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngMeetingVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_MeetingMinutesVerENS">源对象</param>
 /// <param name = "objgs_MeetingMinutesVerENT">目标对象</param>
 public static void CopyTo(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerENS, clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerENT)
{
try
{
objgs_MeetingMinutesVerENT.MeetingVId = objgs_MeetingMinutesVerENS.MeetingVId; //MeetingVId
objgs_MeetingMinutesVerENT.MeetingId = objgs_MeetingMinutesVerENS.MeetingId; //会议Id
objgs_MeetingMinutesVerENT.TopicId = objgs_MeetingMinutesVerENS.TopicId; //主题Id
objgs_MeetingMinutesVerENT.IsSubmit = objgs_MeetingMinutesVerENS.IsSubmit; //是否提交
objgs_MeetingMinutesVerENT.MeetingContent = objgs_MeetingMinutesVerENS.MeetingContent; //会议内容
objgs_MeetingMinutesVerENT.MeetingDate = objgs_MeetingMinutesVerENS.MeetingDate; //会议日期
objgs_MeetingMinutesVerENT.UpdDate = objgs_MeetingMinutesVerENS.UpdDate; //修改日期
objgs_MeetingMinutesVerENT.UpdUser = objgs_MeetingMinutesVerENS.UpdUser; //修改人
objgs_MeetingMinutesVerENT.Year = objgs_MeetingMinutesVerENS.Year; //年
objgs_MeetingMinutesVerENT.Month = objgs_MeetingMinutesVerENS.Month; //月
objgs_MeetingMinutesVerENT.Memo = objgs_MeetingMinutesVerENS.Memo; //备注
objgs_MeetingMinutesVerENT.Participants = objgs_MeetingMinutesVerENS.Participants; //参会者
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
 /// <param name = "objgs_MeetingMinutesVerEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
try
{
objgs_MeetingMinutesVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_MeetingMinutesVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_MeetingMinutesVer.MeetingVId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.MeetingVId = objgs_MeetingMinutesVerEN.MeetingVId; //MeetingVId
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.MeetingId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.MeetingId = objgs_MeetingMinutesVerEN.MeetingId; //会议Id
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.TopicId = objgs_MeetingMinutesVerEN.TopicId == "[null]" ? null :  objgs_MeetingMinutesVerEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.IsSubmit = objgs_MeetingMinutesVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.MeetingContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.MeetingContent = objgs_MeetingMinutesVerEN.MeetingContent == "[null]" ? null :  objgs_MeetingMinutesVerEN.MeetingContent; //会议内容
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.MeetingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.MeetingDate = objgs_MeetingMinutesVerEN.MeetingDate == "[null]" ? null :  objgs_MeetingMinutesVerEN.MeetingDate; //会议日期
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.UpdDate = objgs_MeetingMinutesVerEN.UpdDate == "[null]" ? null :  objgs_MeetingMinutesVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.UpdUser = objgs_MeetingMinutesVerEN.UpdUser == "[null]" ? null :  objgs_MeetingMinutesVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.Year = objgs_MeetingMinutesVerEN.Year == "[null]" ? null :  objgs_MeetingMinutesVerEN.Year; //年
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.Month = objgs_MeetingMinutesVerEN.Month == "[null]" ? null :  objgs_MeetingMinutesVerEN.Month; //月
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.Memo = objgs_MeetingMinutesVerEN.Memo == "[null]" ? null :  objgs_MeetingMinutesVerEN.Memo; //备注
}
if (arrFldSet.Contains(congs_MeetingMinutesVer.Participants, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_MeetingMinutesVerEN.Participants = objgs_MeetingMinutesVerEN.Participants == "[null]" ? null :  objgs_MeetingMinutesVerEN.Participants; //参会者
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
 /// <param name = "objgs_MeetingMinutesVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
try
{
if (objgs_MeetingMinutesVerEN.TopicId == "[null]") objgs_MeetingMinutesVerEN.TopicId = null; //主题Id
if (objgs_MeetingMinutesVerEN.MeetingContent == "[null]") objgs_MeetingMinutesVerEN.MeetingContent = null; //会议内容
if (objgs_MeetingMinutesVerEN.MeetingDate == "[null]") objgs_MeetingMinutesVerEN.MeetingDate = null; //会议日期
if (objgs_MeetingMinutesVerEN.UpdDate == "[null]") objgs_MeetingMinutesVerEN.UpdDate = null; //修改日期
if (objgs_MeetingMinutesVerEN.UpdUser == "[null]") objgs_MeetingMinutesVerEN.UpdUser = null; //修改人
if (objgs_MeetingMinutesVerEN.Year == "[null]") objgs_MeetingMinutesVerEN.Year = null; //年
if (objgs_MeetingMinutesVerEN.Month == "[null]") objgs_MeetingMinutesVerEN.Month = null; //月
if (objgs_MeetingMinutesVerEN.Memo == "[null]") objgs_MeetingMinutesVerEN.Memo = null; //备注
if (objgs_MeetingMinutesVerEN.Participants == "[null]") objgs_MeetingMinutesVerEN.Participants = null; //参会者
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
public static void CheckPropertyNew(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
 gs_MeetingMinutesVerDA.CheckPropertyNew(objgs_MeetingMinutesVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
 gs_MeetingMinutesVerDA.CheckProperty4Condition(objgs_MeetingMinutesVerEN);
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
if (clsgs_MeetingMinutesVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_MeetingMinutesVerBL没有刷新缓存机制(clsgs_MeetingMinutesVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MeetingVId");
//if (arrgs_MeetingMinutesVerObjLstCache == null)
//{
//arrgs_MeetingMinutesVerObjLstCache = gs_MeetingMinutesVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngMeetingVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_MeetingMinutesVerEN GetObjByMeetingVIdCache(long lngMeetingVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_MeetingMinutesVerEN._CurrTabName);
List<clsgs_MeetingMinutesVerEN> arrgs_MeetingMinutesVerObjLstCache = GetObjLstCache();
IEnumerable <clsgs_MeetingMinutesVerEN> arrgs_MeetingMinutesVerObjLst_Sel =
arrgs_MeetingMinutesVerObjLstCache
.Where(x=> x.MeetingVId == lngMeetingVId 
);
if (arrgs_MeetingMinutesVerObjLst_Sel.Count() == 0)
{
   clsgs_MeetingMinutesVerEN obj = clsgs_MeetingMinutesVerBL.GetObjByMeetingVId(lngMeetingVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_MeetingMinutesVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_MeetingMinutesVerEN> GetAllgs_MeetingMinutesVerObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_MeetingMinutesVerEN> arrgs_MeetingMinutesVerObjLstCache = GetObjLstCache(); 
return arrgs_MeetingMinutesVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_MeetingMinutesVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_MeetingMinutesVerEN._CurrTabName);
List<clsgs_MeetingMinutesVerEN> arrgs_MeetingMinutesVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_MeetingMinutesVerObjLstCache;
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
string strKey = string.Format("{0}", clsgs_MeetingMinutesVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_MeetingMinutesVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_MeetingMinutesVerEN._RefreshTimeLst.Count == 0) return "";
return clsgs_MeetingMinutesVerEN._RefreshTimeLst[clsgs_MeetingMinutesVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_MeetingMinutesVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_MeetingMinutesVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_MeetingMinutesVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_MeetingMinutesVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_MeetingMinutesVer(会议纪要历史版)
 /// 唯一性条件:MeetingVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerEN)
{
//检测记录是否存在
string strResult = gs_MeetingMinutesVerDA.GetUniCondStr(objgs_MeetingMinutesVerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngMeetingVId)
{
if (strInFldName != congs_MeetingMinutesVer.MeetingVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_MeetingMinutesVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_MeetingMinutesVer.AttributeName));
throw new Exception(strMsg);
}
var objgs_MeetingMinutesVer = clsgs_MeetingMinutesVerBL.GetObjByMeetingVIdCache(lngMeetingVId);
if (objgs_MeetingMinutesVer == null) return "";
return objgs_MeetingMinutesVer[strOutFldName].ToString();
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
int intRecCount = clsgs_MeetingMinutesVerDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_MeetingMinutesVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_MeetingMinutesVerDA.GetRecCount();
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
int intRecCount = clsgs_MeetingMinutesVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_MeetingMinutesVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_MeetingMinutesVerEN objgs_MeetingMinutesVerCond)
{
List<clsgs_MeetingMinutesVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_MeetingMinutesVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_MeetingMinutesVer.AttributeName)
{
if (objgs_MeetingMinutesVerCond.IsUpdated(strFldName) == false) continue;
if (objgs_MeetingMinutesVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_MeetingMinutesVerCond[strFldName].ToString());
}
else
{
if (objgs_MeetingMinutesVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_MeetingMinutesVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_MeetingMinutesVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_MeetingMinutesVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_MeetingMinutesVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_MeetingMinutesVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_MeetingMinutesVerCond[strFldName]));
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
 List<string> arrList = clsgs_MeetingMinutesVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_MeetingMinutesVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_MeetingMinutesVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_MeetingMinutesVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_MeetingMinutesVerDA.SetFldValue(clsgs_MeetingMinutesVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_MeetingMinutesVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_MeetingMinutesVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_MeetingMinutesVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_MeetingMinutesVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_MeetingMinutesVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**MeetingVId*/ 
 strCreateTabCode.Append(" MeetingVId bigint primary key identity, "); 
 // /**会议Id*/ 
 strCreateTabCode.Append(" MeetingId char(10) not Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**会议内容*/ 
 strCreateTabCode.Append(" MeetingContent text Null, "); 
 // /**会议日期*/ 
 strCreateTabCode.Append(" MeetingDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**年*/ 
 strCreateTabCode.Append(" Year char(4) Null, "); 
 // /**月*/ 
 strCreateTabCode.Append(" Month char(2) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**参会者*/ 
 strCreateTabCode.Append(" Participants varchar(500) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 会议纪要历史版(gs_MeetingMinutesVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_MeetingMinutesVer : clsCommFun4BL
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
clsgs_MeetingMinutesVerBL.ReFreshThisCache();
}
}

}