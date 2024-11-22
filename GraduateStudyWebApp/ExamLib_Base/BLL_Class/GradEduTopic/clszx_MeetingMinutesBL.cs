
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_MeetingMinutesBL
 表名:zx_MeetingMinutes(01120799)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:33
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
public static class  clszx_MeetingMinutesBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_MeetingMinutesEN GetObj(this K_zxMeetingId_zx_MeetingMinutes myKey)
{
clszx_MeetingMinutesEN objzx_MeetingMinutesEN = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.GetObjByzxMeetingId(myKey.Value);
return objzx_MeetingMinutesEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
if (CheckUniqueness(objzx_MeetingMinutesEN) == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_MeetingMinutesBL.AddNewRecord)", objzx_MeetingMinutesEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true || clszx_MeetingMinutesBL.IsExist(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
     objzx_MeetingMinutesEN.zxMeetingId = clszx_MeetingMinutesBL.GetMaxStrId_S();
 }
bool bolResult = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.AddNewRecordBySQL2(objzx_MeetingMinutesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_MeetingMinutesBL.IsExist(objzx_MeetingMinutesEN.zxMeetingId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_MeetingMinutesEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_MeetingMinutesEN.CheckUniqueness() == false)
{
strMsg = string.Format("(小组Id(GroupTextId)=[{0}])已经存在,不能重复!", objzx_MeetingMinutesEN.GroupTextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true || clszx_MeetingMinutesBL.IsExist(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
     objzx_MeetingMinutesEN.zxMeetingId = clszx_MeetingMinutesBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_MeetingMinutesEN.AddNewRecord();
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
if (CheckUniqueness(objzx_MeetingMinutesEN) == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_MeetingMinutesBL.AddNewRecordWithMaxId)", objzx_MeetingMinutesEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true || clszx_MeetingMinutesBL.IsExist(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
     objzx_MeetingMinutesEN.zxMeetingId = clszx_MeetingMinutesBL.GetMaxStrId_S();
 }
string strzxMeetingId = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.AddNewRecordBySQL2WithReturnKey(objzx_MeetingMinutesEN);
     objzx_MeetingMinutesEN.zxMeetingId = strzxMeetingId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
}
return strzxMeetingId;
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
if (CheckUniqueness(objzx_MeetingMinutesEN) == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_MeetingMinutesBL.AddNewRecordWithReturnKey)", objzx_MeetingMinutesEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true || clszx_MeetingMinutesBL.IsExist(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
     objzx_MeetingMinutesEN.zxMeetingId = clszx_MeetingMinutesBL.GetMaxStrId_S();
 }
string strKey = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.AddNewRecordBySQL2WithReturnKey(objzx_MeetingMinutesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetzxMeetingId(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strzxMeetingId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxMeetingId, 10, conzx_MeetingMinutes.zxMeetingId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxMeetingId, 10, conzx_MeetingMinutes.zxMeetingId);
}
objzx_MeetingMinutesEN.zxMeetingId = strzxMeetingId; //会议Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.zxMeetingId) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.zxMeetingId, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.zxMeetingId] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetGroupTextId(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_MeetingMinutes.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_MeetingMinutes.GroupTextId);
}
objzx_MeetingMinutesEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.GroupTextId) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.GroupTextId, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.GroupTextId] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetIsSubmit(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_MeetingMinutesEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.IsSubmit) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.IsSubmit, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.IsSubmit] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetMeetingContent(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strMeetingContent, string strComparisonOp="")
	{
objzx_MeetingMinutesEN.MeetingContent = strMeetingContent; //会议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.MeetingContent) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.MeetingContent, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.MeetingContent] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetMeetingDate(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strMeetingDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMeetingDate, 20, conzx_MeetingMinutes.MeetingDate);
}
objzx_MeetingMinutesEN.MeetingDate = strMeetingDate; //会议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.MeetingDate) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.MeetingDate, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.MeetingDate] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetUpdDate(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_MeetingMinutes.UpdDate);
}
objzx_MeetingMinutesEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.UpdDate) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.UpdDate, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.UpdDate] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetUpdUser(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_MeetingMinutes.UpdUser);
}
objzx_MeetingMinutesEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.UpdUser) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.UpdUser, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.UpdUser] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetYear(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, conzx_MeetingMinutes.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, conzx_MeetingMinutes.Year);
}
objzx_MeetingMinutesEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.Year) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.Year, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.Year] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetMonth(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, conzx_MeetingMinutes.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, conzx_MeetingMinutes.Month);
}
objzx_MeetingMinutesEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.Month) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.Month, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.Month] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetMemo(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_MeetingMinutes.Memo);
}
objzx_MeetingMinutesEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.Memo) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.Memo, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.Memo] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetVersionCount(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_MeetingMinutesEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.VersionCount) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.VersionCount, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.VersionCount] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetParticipants(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strParticipants, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipants, 500, conzx_MeetingMinutes.Participants);
}
objzx_MeetingMinutesEN.Participants = strParticipants; //参会者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.Participants) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.Participants, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.Participants] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_MeetingMinutesEN SetIdCurrEduCls(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, conzx_MeetingMinutes.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_MeetingMinutes.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_MeetingMinutes.IdCurrEduCls);
}
objzx_MeetingMinutesEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_MeetingMinutesEN.dicFldComparisonOp.ContainsKey(conzx_MeetingMinutes.IdCurrEduCls) == false)
{
objzx_MeetingMinutesEN.dicFldComparisonOp.Add(conzx_MeetingMinutes.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_MeetingMinutesEN.dicFldComparisonOp[conzx_MeetingMinutes.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_MeetingMinutesEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_MeetingMinutesEN.CheckPropertyNew();
clszx_MeetingMinutesEN objzx_MeetingMinutesCond = new clszx_MeetingMinutesEN();
string strCondition = objzx_MeetingMinutesCond
.SetzxMeetingId(objzx_MeetingMinutesEN.zxMeetingId, "<>")
.SetGroupTextId(objzx_MeetingMinutesEN.GroupTextId, "=")
.GetCombineCondition();
objzx_MeetingMinutesEN._IsCheckProperty = true;
bool bolIsExist = clszx_MeetingMinutesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(GroupTextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_MeetingMinutesEN.Update();
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
 /// <param name = "objzx_MeetingMinutes">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_MeetingMinutesEN objzx_MeetingMinutes)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_MeetingMinutesEN objzx_MeetingMinutesCond = new clszx_MeetingMinutesEN();
string strCondition = objzx_MeetingMinutesCond
.SetGroupTextId(objzx_MeetingMinutes.GroupTextId, "=")
.GetCombineCondition();
objzx_MeetingMinutes._IsCheckProperty = true;
bool bolIsExist = clszx_MeetingMinutesBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_MeetingMinutes.zxMeetingId = clszx_MeetingMinutesBL.GetFirstID_S(strCondition);
objzx_MeetingMinutes.UpdateWithCondition(strCondition);
}
else
{
objzx_MeetingMinutes.zxMeetingId = clszx_MeetingMinutesBL.GetMaxStrId_S();
objzx_MeetingMinutes.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.UpdateBySql2(objzx_MeetingMinutesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.UpdateBySql2(objzx_MeetingMinutesEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strWhereCond)
{
try
{
bool bolResult = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.UpdateBySqlWithCondition(objzx_MeetingMinutesEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.UpdateBySqlWithConditionTransaction(objzx_MeetingMinutesEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
try
{
int intRecNum = clszx_MeetingMinutesBL.zx_MeetingMinutesDA.DelRecord(objzx_MeetingMinutesEN.zxMeetingId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesENS">源对象</param>
 /// <param name = "objzx_MeetingMinutesENT">目标对象</param>
 public static void CopyTo(this clszx_MeetingMinutesEN objzx_MeetingMinutesENS, clszx_MeetingMinutesEN objzx_MeetingMinutesENT)
{
try
{
objzx_MeetingMinutesENT.zxMeetingId = objzx_MeetingMinutesENS.zxMeetingId; //会议Id
objzx_MeetingMinutesENT.GroupTextId = objzx_MeetingMinutesENS.GroupTextId; //小组Id
objzx_MeetingMinutesENT.IsSubmit = objzx_MeetingMinutesENS.IsSubmit; //是否提交
objzx_MeetingMinutesENT.MeetingContent = objzx_MeetingMinutesENS.MeetingContent; //会议内容
objzx_MeetingMinutesENT.MeetingDate = objzx_MeetingMinutesENS.MeetingDate; //会议日期
objzx_MeetingMinutesENT.UpdDate = objzx_MeetingMinutesENS.UpdDate; //修改日期
objzx_MeetingMinutesENT.UpdUser = objzx_MeetingMinutesENS.UpdUser; //修改人
objzx_MeetingMinutesENT.Year = objzx_MeetingMinutesENS.Year; //年
objzx_MeetingMinutesENT.Month = objzx_MeetingMinutesENS.Month; //月
objzx_MeetingMinutesENT.Memo = objzx_MeetingMinutesENS.Memo; //备注
objzx_MeetingMinutesENT.VersionCount = objzx_MeetingMinutesENS.VersionCount; //版本统计
objzx_MeetingMinutesENT.Participants = objzx_MeetingMinutesENS.Participants; //参会者
objzx_MeetingMinutesENT.IdCurrEduCls = objzx_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_MeetingMinutesENS">源对象</param>
 /// <returns>目标对象=>clszx_MeetingMinutesEN:objzx_MeetingMinutesENT</returns>
 public static clszx_MeetingMinutesEN CopyTo(this clszx_MeetingMinutesEN objzx_MeetingMinutesENS)
{
try
{
 clszx_MeetingMinutesEN objzx_MeetingMinutesENT = new clszx_MeetingMinutesEN()
{
zxMeetingId = objzx_MeetingMinutesENS.zxMeetingId, //会议Id
GroupTextId = objzx_MeetingMinutesENS.GroupTextId, //小组Id
IsSubmit = objzx_MeetingMinutesENS.IsSubmit, //是否提交
MeetingContent = objzx_MeetingMinutesENS.MeetingContent, //会议内容
MeetingDate = objzx_MeetingMinutesENS.MeetingDate, //会议日期
UpdDate = objzx_MeetingMinutesENS.UpdDate, //修改日期
UpdUser = objzx_MeetingMinutesENS.UpdUser, //修改人
Year = objzx_MeetingMinutesENS.Year, //年
Month = objzx_MeetingMinutesENS.Month, //月
Memo = objzx_MeetingMinutesENS.Memo, //备注
VersionCount = objzx_MeetingMinutesENS.VersionCount, //版本统计
Participants = objzx_MeetingMinutesENS.Participants, //参会者
IdCurrEduCls = objzx_MeetingMinutesENS.IdCurrEduCls, //教学班流水号
};
 return objzx_MeetingMinutesENT;
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
public static void CheckPropertyNew(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 clszx_MeetingMinutesBL.zx_MeetingMinutesDA.CheckPropertyNew(objzx_MeetingMinutesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 clszx_MeetingMinutesBL.zx_MeetingMinutesDA.CheckProperty4Condition(objzx_MeetingMinutesEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_MeetingMinutesEN objzx_MeetingMinutesCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.zxMeetingId) == true)
{
string strComparisonOpzxMeetingId = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.zxMeetingId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.zxMeetingId, objzx_MeetingMinutesCond.zxMeetingId, strComparisonOpzxMeetingId);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.GroupTextId, objzx_MeetingMinutesCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.IsSubmit) == true)
{
if (objzx_MeetingMinutesCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_MeetingMinutes.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_MeetingMinutes.IsSubmit);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.MeetingDate) == true)
{
string strComparisonOpMeetingDate = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.MeetingDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.MeetingDate, objzx_MeetingMinutesCond.MeetingDate, strComparisonOpMeetingDate);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.UpdDate, objzx_MeetingMinutesCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.UpdUser, objzx_MeetingMinutesCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.Year) == true)
{
string strComparisonOpYear = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.Year, objzx_MeetingMinutesCond.Year, strComparisonOpYear);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.Month) == true)
{
string strComparisonOpMonth = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.Month, objzx_MeetingMinutesCond.Month, strComparisonOpMonth);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.Memo) == true)
{
string strComparisonOpMemo = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.Memo, objzx_MeetingMinutesCond.Memo, strComparisonOpMemo);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_MeetingMinutes.VersionCount, objzx_MeetingMinutesCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.Participants) == true)
{
string strComparisonOpParticipants = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.Participants];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.Participants, objzx_MeetingMinutesCond.Participants, strComparisonOpParticipants);
}
if (objzx_MeetingMinutesCond.IsUpdated(conzx_MeetingMinutes.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_MeetingMinutesCond.dicFldComparisonOp[conzx_MeetingMinutes.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_MeetingMinutes.IdCurrEduCls, objzx_MeetingMinutesCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_MeetingMinutes(中学会议纪要), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_MeetingMinutesEN == null) return true;
if (objzx_MeetingMinutesEN.zxMeetingId == null || objzx_MeetingMinutesEN.zxMeetingId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_MeetingMinutesEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_MeetingMinutesEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_MeetingMinutesEN.GroupTextId);
}
if (clszx_MeetingMinutesBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxMeetingId !=  '{0}'", objzx_MeetingMinutesEN.zxMeetingId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_MeetingMinutesEN.GroupTextId);
if (clszx_MeetingMinutesBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_MeetingMinutes(中学会议纪要), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_MeetingMinutesEN == null) return "";
if (objzx_MeetingMinutesEN.zxMeetingId == null || objzx_MeetingMinutesEN.zxMeetingId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_MeetingMinutesEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_MeetingMinutesEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_MeetingMinutesEN.GroupTextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxMeetingId !=  '{0}'", objzx_MeetingMinutesEN.zxMeetingId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_MeetingMinutesEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_MeetingMinutes
{
public virtual bool UpdRelaTabDate(string strzxMeetingId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学会议纪要(zx_MeetingMinutes)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_MeetingMinutesBL
{
public static RelatedActions_zx_MeetingMinutes relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_MeetingMinutesDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_MeetingMinutesDA zx_MeetingMinutesDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_MeetingMinutesDA();
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
 public clszx_MeetingMinutesBL()
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
if (string.IsNullOrEmpty(clszx_MeetingMinutesEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_MeetingMinutesEN._ConnectString);
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
public static DataTable GetDataTable_zx_MeetingMinutes(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_MeetingMinutesDA.GetDataTable_zx_MeetingMinutes(strWhereCond);
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
objDT = zx_MeetingMinutesDA.GetDataTable(strWhereCond);
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
objDT = zx_MeetingMinutesDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_MeetingMinutesDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_MeetingMinutesDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_MeetingMinutesDA.GetDataTable_Top(objTopPara);
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
objDT = zx_MeetingMinutesDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_MeetingMinutesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_MeetingMinutesDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clszx_MeetingMinutesEN> GetObjLstByZxMeetingIdLst(List<string> arrZxMeetingIdLst)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
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
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxMeetingIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_MeetingMinutesEN> GetObjLstByZxMeetingIdLstCache(List<string> arrZxMeetingIdLst)
{
string strKey = string.Format("{0}", clszx_MeetingMinutesEN._CurrTabName);
List<clszx_MeetingMinutesEN> arrzx_MeetingMinutesObjLstCache = GetObjLstCache();
IEnumerable <clszx_MeetingMinutesEN> arrzx_MeetingMinutesObjLst_Sel =
arrzx_MeetingMinutesObjLstCache
.Where(x => arrZxMeetingIdLst.Contains(x.zxMeetingId));
return arrzx_MeetingMinutesObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_MeetingMinutesEN> GetObjLst(string strWhereCond)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
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
public static List<clszx_MeetingMinutesEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_MeetingMinutesEN> GetSubObjLstCache(clszx_MeetingMinutesEN objzx_MeetingMinutesCond)
{
List<clszx_MeetingMinutesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_MeetingMinutesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_MeetingMinutes.AttributeName)
{
if (objzx_MeetingMinutesCond.IsUpdated(strFldName) == false) continue;
if (objzx_MeetingMinutesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_MeetingMinutesCond[strFldName].ToString());
}
else
{
if (objzx_MeetingMinutesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_MeetingMinutesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_MeetingMinutesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_MeetingMinutesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_MeetingMinutesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_MeetingMinutesCond[strFldName]));
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
public static List<clszx_MeetingMinutesEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
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
public static List<clszx_MeetingMinutesEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
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
List<clszx_MeetingMinutesEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_MeetingMinutesEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_MeetingMinutesEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_MeetingMinutesEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
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
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
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
public static List<clszx_MeetingMinutesEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_MeetingMinutesEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_MeetingMinutesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
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
public static List<clszx_MeetingMinutesEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_MeetingMinutesEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_MeetingMinutesEN> arrObjLst = new List<clszx_MeetingMinutesEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_MeetingMinutesEN objzx_MeetingMinutesEN = new clszx_MeetingMinutesEN();
try
{
objzx_MeetingMinutesEN.zxMeetingId = objRow[conzx_MeetingMinutes.zxMeetingId].ToString().Trim(); //会议Id
objzx_MeetingMinutesEN.GroupTextId = objRow[conzx_MeetingMinutes.GroupTextId] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.GroupTextId].ToString().Trim(); //小组Id
objzx_MeetingMinutesEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_MeetingMinutes.IsSubmit].ToString().Trim()); //是否提交
objzx_MeetingMinutesEN.MeetingContent = objRow[conzx_MeetingMinutes.MeetingContent] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingContent].ToString().Trim(); //会议内容
objzx_MeetingMinutesEN.MeetingDate = objRow[conzx_MeetingMinutes.MeetingDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.MeetingDate].ToString().Trim(); //会议日期
objzx_MeetingMinutesEN.UpdDate = objRow[conzx_MeetingMinutes.UpdDate] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdDate].ToString().Trim(); //修改日期
objzx_MeetingMinutesEN.UpdUser = objRow[conzx_MeetingMinutes.UpdUser] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.UpdUser].ToString().Trim(); //修改人
objzx_MeetingMinutesEN.Year = objRow[conzx_MeetingMinutes.Year] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Year].ToString().Trim(); //年
objzx_MeetingMinutesEN.Month = objRow[conzx_MeetingMinutes.Month] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Month].ToString().Trim(); //月
objzx_MeetingMinutesEN.Memo = objRow[conzx_MeetingMinutes.Memo] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Memo].ToString().Trim(); //备注
objzx_MeetingMinutesEN.VersionCount = objRow[conzx_MeetingMinutes.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_MeetingMinutes.VersionCount].ToString().Trim()); //版本统计
objzx_MeetingMinutesEN.Participants = objRow[conzx_MeetingMinutes.Participants] == DBNull.Value ? null : objRow[conzx_MeetingMinutes.Participants].ToString().Trim(); //参会者
objzx_MeetingMinutesEN.IdCurrEduCls = objRow[conzx_MeetingMinutes.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_MeetingMinutesEN.zxMeetingId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_MeetingMinutesEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_MeetingMinutes(ref clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
bool bolResult = zx_MeetingMinutesDA.Getzx_MeetingMinutes(ref objzx_MeetingMinutesEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxMeetingId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_MeetingMinutesEN GetObjByzxMeetingId(string strzxMeetingId)
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
clszx_MeetingMinutesEN objzx_MeetingMinutesEN = zx_MeetingMinutesDA.GetObjByzxMeetingId(strzxMeetingId);
return objzx_MeetingMinutesEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_MeetingMinutesEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_MeetingMinutesEN objzx_MeetingMinutesEN = zx_MeetingMinutesDA.GetFirstObj(strWhereCond);
 return objzx_MeetingMinutesEN;
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
public static clszx_MeetingMinutesEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_MeetingMinutesEN objzx_MeetingMinutesEN = zx_MeetingMinutesDA.GetObjByDataRow(objRow);
 return objzx_MeetingMinutesEN;
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
public static clszx_MeetingMinutesEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_MeetingMinutesEN objzx_MeetingMinutesEN = zx_MeetingMinutesDA.GetObjByDataRow(objRow);
 return objzx_MeetingMinutesEN;
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
 /// <param name = "lstzx_MeetingMinutesObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_MeetingMinutesEN GetObjByzxMeetingIdFromList(string strzxMeetingId, List<clszx_MeetingMinutesEN> lstzx_MeetingMinutesObjLst)
{
foreach (clszx_MeetingMinutesEN objzx_MeetingMinutesEN in lstzx_MeetingMinutesObjLst)
{
if (objzx_MeetingMinutesEN.zxMeetingId == strzxMeetingId)
{
return objzx_MeetingMinutesEN;
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
 strMaxZxMeetingId = clszx_MeetingMinutesDA.GetMaxStrId();
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
 strzxMeetingId = new clszx_MeetingMinutesDA().GetFirstID(strWhereCond);
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
 arrList = zx_MeetingMinutesDA.GetID(strWhereCond);
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
bool bolIsExist = zx_MeetingMinutesDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = zx_MeetingMinutesDA.IsExist(strzxMeetingId);
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
 bolIsExist = clszx_MeetingMinutesDA.IsExistTable();
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
 bolIsExist = zx_MeetingMinutesDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
if (objzx_MeetingMinutesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_MeetingMinutesBL.AddNewRecordBySql2)", objzx_MeetingMinutesEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true || clszx_MeetingMinutesBL.IsExist(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
     objzx_MeetingMinutesEN.zxMeetingId = clszx_MeetingMinutesBL.GetMaxStrId_S();
 }
bool bolResult = zx_MeetingMinutesDA.AddNewRecordBySQL2(objzx_MeetingMinutesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
if (objzx_MeetingMinutesEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!小组Id = [{0}]的数据已经存在!(in clszx_MeetingMinutesBL.AddNewRecordBySql2WithReturnKey)", objzx_MeetingMinutesEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true || clszx_MeetingMinutesBL.IsExist(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
     objzx_MeetingMinutesEN.zxMeetingId = clszx_MeetingMinutesBL.GetMaxStrId_S();
 }
string strKey = zx_MeetingMinutesDA.AddNewRecordBySQL2WithReturnKey(objzx_MeetingMinutesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
try
{
bool bolResult = zx_MeetingMinutesDA.Update(objzx_MeetingMinutesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "objzx_MeetingMinutesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 if (string.IsNullOrEmpty(objzx_MeetingMinutesEN.zxMeetingId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_MeetingMinutesDA.UpdateBySql2(objzx_MeetingMinutesEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_MeetingMinutesBL.ReFreshCache();

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
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
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxMeetingId)
{
try
{
 clszx_MeetingMinutesEN objzx_MeetingMinutesEN = clszx_MeetingMinutesBL.GetObjByzxMeetingId(strzxMeetingId);

if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(objzx_MeetingMinutesEN.zxMeetingId, "SetUpdDate");
}
if (objzx_MeetingMinutesEN != null)
{
int intRecNum = zx_MeetingMinutesDA.DelRecord(strzxMeetingId);
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
/// <param name="strzxMeetingId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxMeetingId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
//删除与表:[zx_MeetingMinutes]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_MeetingMinutes.zxMeetingId,
//strzxMeetingId);
//        clszx_MeetingMinutesBL.Delzx_MeetingMinutessByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_MeetingMinutesBL.DelRecord(strzxMeetingId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_MeetingMinutesBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxMeetingId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxMeetingId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxMeetingId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_MeetingMinutesBL.relatedActions != null)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(strzxMeetingId, "UpdRelaTabDate");
}
bool bolResult = zx_MeetingMinutesDA.DelRecord(strzxMeetingId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxMeetingIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_MeetingMinutess(List<string> arrzxMeetingIdLst)
{
if (arrzxMeetingIdLst.Count == 0) return 0;
try
{
if (clszx_MeetingMinutesBL.relatedActions != null)
{
foreach (var strzxMeetingId in arrzxMeetingIdLst)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(strzxMeetingId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_MeetingMinutesDA.Delzx_MeetingMinutes(arrzxMeetingIdLst);
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
public static int Delzx_MeetingMinutessByCond(string strWhereCond)
{
try
{
if (clszx_MeetingMinutesBL.relatedActions != null)
{
List<string> arrzxMeetingId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxMeetingId in arrzxMeetingId)
{
clszx_MeetingMinutesBL.relatedActions.UpdRelaTabDate(strzxMeetingId, "UpdRelaTabDate");
}
}
int intRecNum = zx_MeetingMinutesDA.Delzx_MeetingMinutes(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_MeetingMinutes]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxMeetingId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxMeetingId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_MeetingMinutesDA.GetSpecSQLObj();
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
//删除与表:[zx_MeetingMinutes]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_MeetingMinutesBL.DelRecord(strzxMeetingId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_MeetingMinutesBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxMeetingId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_MeetingMinutesENS">源对象</param>
 /// <param name = "objzx_MeetingMinutesENT">目标对象</param>
 public static void CopyTo(clszx_MeetingMinutesEN objzx_MeetingMinutesENS, clszx_MeetingMinutesEN objzx_MeetingMinutesENT)
{
try
{
objzx_MeetingMinutesENT.zxMeetingId = objzx_MeetingMinutesENS.zxMeetingId; //会议Id
objzx_MeetingMinutesENT.GroupTextId = objzx_MeetingMinutesENS.GroupTextId; //小组Id
objzx_MeetingMinutesENT.IsSubmit = objzx_MeetingMinutesENS.IsSubmit; //是否提交
objzx_MeetingMinutesENT.MeetingContent = objzx_MeetingMinutesENS.MeetingContent; //会议内容
objzx_MeetingMinutesENT.MeetingDate = objzx_MeetingMinutesENS.MeetingDate; //会议日期
objzx_MeetingMinutesENT.UpdDate = objzx_MeetingMinutesENS.UpdDate; //修改日期
objzx_MeetingMinutesENT.UpdUser = objzx_MeetingMinutesENS.UpdUser; //修改人
objzx_MeetingMinutesENT.Year = objzx_MeetingMinutesENS.Year; //年
objzx_MeetingMinutesENT.Month = objzx_MeetingMinutesENS.Month; //月
objzx_MeetingMinutesENT.Memo = objzx_MeetingMinutesENS.Memo; //备注
objzx_MeetingMinutesENT.VersionCount = objzx_MeetingMinutesENS.VersionCount; //版本统计
objzx_MeetingMinutesENT.Participants = objzx_MeetingMinutesENS.Participants; //参会者
objzx_MeetingMinutesENT.IdCurrEduCls = objzx_MeetingMinutesENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_MeetingMinutesEN">源简化对象</param>
 public static void SetUpdFlag(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
try
{
objzx_MeetingMinutesEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_MeetingMinutesEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_MeetingMinutes.zxMeetingId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.zxMeetingId = objzx_MeetingMinutesEN.zxMeetingId; //会议Id
}
if (arrFldSet.Contains(conzx_MeetingMinutes.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.GroupTextId = objzx_MeetingMinutesEN.GroupTextId == "[null]" ? null :  objzx_MeetingMinutesEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(conzx_MeetingMinutes.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.IsSubmit = objzx_MeetingMinutesEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_MeetingMinutes.MeetingContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.MeetingContent = objzx_MeetingMinutesEN.MeetingContent == "[null]" ? null :  objzx_MeetingMinutesEN.MeetingContent; //会议内容
}
if (arrFldSet.Contains(conzx_MeetingMinutes.MeetingDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.MeetingDate = objzx_MeetingMinutesEN.MeetingDate == "[null]" ? null :  objzx_MeetingMinutesEN.MeetingDate; //会议日期
}
if (arrFldSet.Contains(conzx_MeetingMinutes.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.UpdDate = objzx_MeetingMinutesEN.UpdDate == "[null]" ? null :  objzx_MeetingMinutesEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_MeetingMinutes.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.UpdUser = objzx_MeetingMinutesEN.UpdUser == "[null]" ? null :  objzx_MeetingMinutesEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_MeetingMinutes.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.Year = objzx_MeetingMinutesEN.Year == "[null]" ? null :  objzx_MeetingMinutesEN.Year; //年
}
if (arrFldSet.Contains(conzx_MeetingMinutes.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.Month = objzx_MeetingMinutesEN.Month == "[null]" ? null :  objzx_MeetingMinutesEN.Month; //月
}
if (arrFldSet.Contains(conzx_MeetingMinutes.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.Memo = objzx_MeetingMinutesEN.Memo == "[null]" ? null :  objzx_MeetingMinutesEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_MeetingMinutes.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.VersionCount = objzx_MeetingMinutesEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_MeetingMinutes.Participants, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.Participants = objzx_MeetingMinutesEN.Participants == "[null]" ? null :  objzx_MeetingMinutesEN.Participants; //参会者
}
if (arrFldSet.Contains(conzx_MeetingMinutes.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_MeetingMinutesEN.IdCurrEduCls = objzx_MeetingMinutesEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objzx_MeetingMinutesEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
try
{
if (objzx_MeetingMinutesEN.GroupTextId == "[null]") objzx_MeetingMinutesEN.GroupTextId = null; //小组Id
if (objzx_MeetingMinutesEN.MeetingContent == "[null]") objzx_MeetingMinutesEN.MeetingContent = null; //会议内容
if (objzx_MeetingMinutesEN.MeetingDate == "[null]") objzx_MeetingMinutesEN.MeetingDate = null; //会议日期
if (objzx_MeetingMinutesEN.UpdDate == "[null]") objzx_MeetingMinutesEN.UpdDate = null; //修改日期
if (objzx_MeetingMinutesEN.UpdUser == "[null]") objzx_MeetingMinutesEN.UpdUser = null; //修改人
if (objzx_MeetingMinutesEN.Year == "[null]") objzx_MeetingMinutesEN.Year = null; //年
if (objzx_MeetingMinutesEN.Month == "[null]") objzx_MeetingMinutesEN.Month = null; //月
if (objzx_MeetingMinutesEN.Memo == "[null]") objzx_MeetingMinutesEN.Memo = null; //备注
if (objzx_MeetingMinutesEN.Participants == "[null]") objzx_MeetingMinutesEN.Participants = null; //参会者
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
public static void CheckPropertyNew(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 zx_MeetingMinutesDA.CheckPropertyNew(objzx_MeetingMinutesEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
 zx_MeetingMinutesDA.CheckProperty4Condition(objzx_MeetingMinutesEN);
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
if (clszx_MeetingMinutesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_MeetingMinutesBL没有刷新缓存机制(clszx_MeetingMinutesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxMeetingId");
//if (arrzx_MeetingMinutesObjLstCache == null)
//{
//arrzx_MeetingMinutesObjLstCache = zx_MeetingMinutesDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxMeetingId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_MeetingMinutesEN GetObjByzxMeetingIdCache(string strzxMeetingId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_MeetingMinutesEN._CurrTabName);
List<clszx_MeetingMinutesEN> arrzx_MeetingMinutesObjLstCache = GetObjLstCache();
IEnumerable <clszx_MeetingMinutesEN> arrzx_MeetingMinutesObjLst_Sel =
arrzx_MeetingMinutesObjLstCache
.Where(x=> x.zxMeetingId == strzxMeetingId 
);
if (arrzx_MeetingMinutesObjLst_Sel.Count() == 0)
{
   clszx_MeetingMinutesEN obj = clszx_MeetingMinutesBL.GetObjByzxMeetingId(strzxMeetingId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_MeetingMinutesObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_MeetingMinutesEN> GetAllzx_MeetingMinutesObjLstCache()
{
//获取缓存中的对象列表
List<clszx_MeetingMinutesEN> arrzx_MeetingMinutesObjLstCache = GetObjLstCache(); 
return arrzx_MeetingMinutesObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_MeetingMinutesEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_MeetingMinutesEN._CurrTabName);
List<clszx_MeetingMinutesEN> arrzx_MeetingMinutesObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_MeetingMinutesObjLstCache;
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
string strKey = string.Format("{0}", clszx_MeetingMinutesEN._CurrTabName);
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
if (clszx_MeetingMinutesBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_MeetingMinutesEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_MeetingMinutesBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_MeetingMinutes(中学会议纪要)
 /// 唯一性条件:GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_MeetingMinutesEN objzx_MeetingMinutesEN)
{
//检测记录是否存在
string strResult = zx_MeetingMinutesDA.GetUniCondStr(objzx_MeetingMinutesEN);
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
public static string Func(string strInFldName, string strOutFldName, string strzxMeetingId)
{
if (strInFldName != conzx_MeetingMinutes.zxMeetingId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_MeetingMinutes.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_MeetingMinutes.AttributeName));
throw new Exception(strMsg);
}
var objzx_MeetingMinutes = clszx_MeetingMinutesBL.GetObjByzxMeetingIdCache(strzxMeetingId);
if (objzx_MeetingMinutes == null) return "";
return objzx_MeetingMinutes[strOutFldName].ToString();
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
int intRecCount = clszx_MeetingMinutesDA.GetRecCount(strTabName);
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
int intRecCount = clszx_MeetingMinutesDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_MeetingMinutesDA.GetRecCount();
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
int intRecCount = clszx_MeetingMinutesDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_MeetingMinutesCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_MeetingMinutesEN objzx_MeetingMinutesCond)
{
List<clszx_MeetingMinutesEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_MeetingMinutesEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_MeetingMinutes.AttributeName)
{
if (objzx_MeetingMinutesCond.IsUpdated(strFldName) == false) continue;
if (objzx_MeetingMinutesCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_MeetingMinutesCond[strFldName].ToString());
}
else
{
if (objzx_MeetingMinutesCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_MeetingMinutesCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_MeetingMinutesCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_MeetingMinutesCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_MeetingMinutesCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_MeetingMinutesCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_MeetingMinutesCond[strFldName]));
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
 List<string> arrList = clszx_MeetingMinutesDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_MeetingMinutesDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_MeetingMinutesDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_MeetingMinutesDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_MeetingMinutesDA.SetFldValue(clszx_MeetingMinutesEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_MeetingMinutesDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_MeetingMinutesDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_MeetingMinutesDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_MeetingMinutesDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_MeetingMinutes] "); 
 strCreateTabCode.Append(" ( "); 
 // /**会议Id*/ 
 strCreateTabCode.Append(" zxMeetingId char(10) primary key, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null, "); 
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
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**参会者*/ 
 strCreateTabCode.Append(" Participants varchar(500) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学会议纪要(zx_MeetingMinutes)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_MeetingMinutes : clsCommFun4BL
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
clszx_MeetingMinutesBL.ReFreshThisCache();
}
}

}