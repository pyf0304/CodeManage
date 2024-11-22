
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_AnswerCountBL
 表名:gs_AnswerCount(01120767)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clsgs_AnswerCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_AnswerCountEN GetObj(this K_AnswerCountId_gs_AnswerCount myKey)
{
clsgs_AnswerCountEN objgs_AnswerCountEN = clsgs_AnswerCountBL.gs_AnswerCountDA.GetObjByAnswerCountId(myKey.Value);
return objgs_AnswerCountEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_AnswerCountEN objgs_AnswerCountEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_AnswerCountEN) == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clsgs_AnswerCountBL.AddNewRecord)", objgs_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true || clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId) == true)
 {
     objgs_AnswerCountEN.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_AnswerCountBL.gs_AnswerCountDA.AddNewRecordBySQL2(objgs_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_AnswerCountEN objgs_AnswerCountEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_AnswerCountEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_AnswerCountEN.CheckUniqueness() == false)
{
strMsg = string.Format("(AnswerCountId(AnswerCountId)=[{0}])已经存在,不能重复!", objgs_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true || clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId) == true)
 {
     objgs_AnswerCountEN.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_AnswerCountEN.AddNewRecord();
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_AnswerCountEN objgs_AnswerCountEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_AnswerCountEN) == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clsgs_AnswerCountBL.AddNewRecordWithMaxId)", objgs_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true || clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId) == true)
 {
     objgs_AnswerCountEN.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
 }
string strAnswerCountId = clsgs_AnswerCountBL.gs_AnswerCountDA.AddNewRecordBySQL2WithReturnKey(objgs_AnswerCountEN);
     objgs_AnswerCountEN.AnswerCountId = strAnswerCountId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
}
return strAnswerCountId;
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_AnswerCountEN objgs_AnswerCountEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_AnswerCountEN) == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clsgs_AnswerCountBL.AddNewRecordWithReturnKey)", objgs_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true || clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId) == true)
 {
     objgs_AnswerCountEN.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
 }
string strKey = clsgs_AnswerCountBL.gs_AnswerCountDA.AddNewRecordBySQL2WithReturnKey(objgs_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetMemo(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_AnswerCount.Memo);
}
objgs_AnswerCountEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.Memo) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.Memo, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.Memo] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetAnswerCountId(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strAnswerCountId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerCountId, 10, congs_AnswerCount.AnswerCountId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerCountId, 10, congs_AnswerCount.AnswerCountId);
}
objgs_AnswerCountEN.AnswerCountId = strAnswerCountId; //AnswerCountId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.AnswerCountId) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.AnswerCountId, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.AnswerCountId] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetDataUser(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strDataUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataUser, 20, congs_AnswerCount.DataUser);
}
objgs_AnswerCountEN.DataUser = strDataUser; //数据用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.DataUser) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.DataUser, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.DataUser] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetDataAddDate(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strDataAddDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataAddDate, 20, congs_AnswerCount.DataAddDate);
}
objgs_AnswerCountEN.DataAddDate = strDataAddDate; //数据添加日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.DataAddDate) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.DataAddDate, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.DataAddDate] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetMonth(this clsgs_AnswerCountEN objgs_AnswerCountEN, int? intMonth, string strComparisonOp="")
	{
objgs_AnswerCountEN.Month = intMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.Month) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.Month, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.Month] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetWeek(this clsgs_AnswerCountEN objgs_AnswerCountEN, int? intWeek, string strComparisonOp="")
	{
objgs_AnswerCountEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.Week) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.Week, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.Week] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetWeekTimeRange(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strWeekTimeRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekTimeRange, 100, congs_AnswerCount.WeekTimeRange);
}
objgs_AnswerCountEN.WeekTimeRange = strWeekTimeRange; //WeekTimeRange
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.WeekTimeRange) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.WeekTimeRange, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.WeekTimeRange] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetIsRecommend(this clsgs_AnswerCountEN objgs_AnswerCountEN, bool bolIsRecommend, string strComparisonOp="")
	{
objgs_AnswerCountEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.IsRecommend) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.IsRecommend, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.IsRecommend] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetAnswerId(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strAnswerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerId, 10, congs_AnswerCount.AnswerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerId, 10, congs_AnswerCount.AnswerId);
}
objgs_AnswerCountEN.AnswerId = strAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.AnswerId) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.AnswerId, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.AnswerId] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetAnswerTypeId(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, congs_AnswerCount.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, congs_AnswerCount.AnswerTypeId);
}
objgs_AnswerCountEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.AnswerTypeId) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.AnswerTypeId, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.AnswerTypeId] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetQuestionsId(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strQuestionsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionsId, 8, congs_AnswerCount.QuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, congs_AnswerCount.QuestionsId);
}
objgs_AnswerCountEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.QuestionsId) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.QuestionsId, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.QuestionsId] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetTopicId(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, congs_AnswerCount.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, congs_AnswerCount.TopicId);
}
objgs_AnswerCountEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.TopicId) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.TopicId, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.TopicId] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetPaperId(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_AnswerCount.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_AnswerCount.PaperId);
}
objgs_AnswerCountEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.PaperId) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.PaperId, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.PaperId] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetIdCurrEduCls(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_AnswerCount.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_AnswerCount.IdCurrEduCls);
}
objgs_AnswerCountEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.IdCurrEduCls) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetAnswerContent(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strAnswerContent, string strComparisonOp="")
	{
objgs_AnswerCountEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.AnswerContent) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.AnswerContent, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.AnswerContent] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetScore(this clsgs_AnswerCountEN objgs_AnswerCountEN, float? fltScore, string strComparisonOp="")
	{
objgs_AnswerCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.Score) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.Score, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.Score] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetScoreType(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, congs_AnswerCount.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, congs_AnswerCount.ScoreType);
}
objgs_AnswerCountEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.ScoreType) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.ScoreType, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.ScoreType] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetUpdUser(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_AnswerCount.UpdUser);
}
objgs_AnswerCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.UpdUser) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.UpdUser, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.UpdUser] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetUpdDate(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_AnswerCount.UpdDate);
}
objgs_AnswerCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.UpdDate) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.UpdDate, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.UpdDate] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_AnswerCountEN SetUserName(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, congs_AnswerCount.UserName);
}
objgs_AnswerCountEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_AnswerCountEN.dicFldComparisonOp.ContainsKey(congs_AnswerCount.UserName) == false)
{
objgs_AnswerCountEN.dicFldComparisonOp.Add(congs_AnswerCount.UserName, strComparisonOp);
}
else
{
objgs_AnswerCountEN.dicFldComparisonOp[congs_AnswerCount.UserName] = strComparisonOp;
}
}
return objgs_AnswerCountEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_AnswerCountEN objgs_AnswerCountEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_AnswerCountEN.CheckPropertyNew();
clsgs_AnswerCountEN objgs_AnswerCountCond = new clsgs_AnswerCountEN();
string strCondition = objgs_AnswerCountCond
.SetAnswerCountId(objgs_AnswerCountEN.AnswerCountId, "<>")
.SetAnswerCountId(objgs_AnswerCountEN.AnswerCountId, "=")
.GetCombineCondition();
objgs_AnswerCountEN._IsCheckProperty = true;
bool bolIsExist = clsgs_AnswerCountBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AnswerCountId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_AnswerCountEN.Update();
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
 /// <param name = "objgs_AnswerCount">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_AnswerCountEN objgs_AnswerCount)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_AnswerCountEN objgs_AnswerCountCond = new clsgs_AnswerCountEN();
string strCondition = objgs_AnswerCountCond
.SetAnswerCountId(objgs_AnswerCount.AnswerCountId, "=")
.GetCombineCondition();
objgs_AnswerCount._IsCheckProperty = true;
bool bolIsExist = clsgs_AnswerCountBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_AnswerCount.AnswerCountId = clsgs_AnswerCountBL.GetFirstID_S(strCondition);
objgs_AnswerCount.UpdateWithCondition(strCondition);
}
else
{
objgs_AnswerCount.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
objgs_AnswerCount.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_AnswerCountBL.gs_AnswerCountDA.UpdateBySql2(objgs_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_AnswerCountEN objgs_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_AnswerCountBL.gs_AnswerCountDA.UpdateBySql2(objgs_AnswerCountEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_AnswerCountBL.gs_AnswerCountDA.UpdateBySqlWithCondition(objgs_AnswerCountEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_AnswerCountEN objgs_AnswerCountEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_AnswerCountBL.gs_AnswerCountDA.UpdateBySqlWithConditionTransaction(objgs_AnswerCountEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_AnswerCountEN objgs_AnswerCountEN)
{
try
{
int intRecNum = clsgs_AnswerCountBL.gs_AnswerCountDA.DelRecord(objgs_AnswerCountEN.AnswerCountId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountENS">源对象</param>
 /// <param name = "objgs_AnswerCountENT">目标对象</param>
 public static void CopyTo(this clsgs_AnswerCountEN objgs_AnswerCountENS, clsgs_AnswerCountEN objgs_AnswerCountENT)
{
try
{
objgs_AnswerCountENT.Memo = objgs_AnswerCountENS.Memo; //备注
objgs_AnswerCountENT.AnswerCountId = objgs_AnswerCountENS.AnswerCountId; //AnswerCountId
objgs_AnswerCountENT.DataUser = objgs_AnswerCountENS.DataUser; //数据用户
objgs_AnswerCountENT.DataAddDate = objgs_AnswerCountENS.DataAddDate; //数据添加日期
objgs_AnswerCountENT.Month = objgs_AnswerCountENS.Month; //月
objgs_AnswerCountENT.Week = objgs_AnswerCountENS.Week; //周
objgs_AnswerCountENT.WeekTimeRange = objgs_AnswerCountENS.WeekTimeRange; //WeekTimeRange
objgs_AnswerCountENT.IsRecommend = objgs_AnswerCountENS.IsRecommend; //是否推荐
objgs_AnswerCountENT.AnswerId = objgs_AnswerCountENS.AnswerId; //回答Id
objgs_AnswerCountENT.AnswerTypeId = objgs_AnswerCountENS.AnswerTypeId; //答案类型ID
objgs_AnswerCountENT.QuestionsId = objgs_AnswerCountENS.QuestionsId; //提问Id
objgs_AnswerCountENT.TopicId = objgs_AnswerCountENS.TopicId; //主题Id
objgs_AnswerCountENT.PaperId = objgs_AnswerCountENS.PaperId; //论文Id
objgs_AnswerCountENT.IdCurrEduCls = objgs_AnswerCountENS.IdCurrEduCls; //教学班流水号
objgs_AnswerCountENT.AnswerContent = objgs_AnswerCountENS.AnswerContent; //答案内容
objgs_AnswerCountENT.Score = objgs_AnswerCountENS.Score; //评分
objgs_AnswerCountENT.ScoreType = objgs_AnswerCountENS.ScoreType; //评分类型
objgs_AnswerCountENT.UpdUser = objgs_AnswerCountENS.UpdUser; //修改人
objgs_AnswerCountENT.UpdDate = objgs_AnswerCountENS.UpdDate; //修改日期
objgs_AnswerCountENT.UserName = objgs_AnswerCountENS.UserName; //用户名
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
 /// <param name = "objgs_AnswerCountENS">源对象</param>
 /// <returns>目标对象=>clsgs_AnswerCountEN:objgs_AnswerCountENT</returns>
 public static clsgs_AnswerCountEN CopyTo(this clsgs_AnswerCountEN objgs_AnswerCountENS)
{
try
{
 clsgs_AnswerCountEN objgs_AnswerCountENT = new clsgs_AnswerCountEN()
{
Memo = objgs_AnswerCountENS.Memo, //备注
AnswerCountId = objgs_AnswerCountENS.AnswerCountId, //AnswerCountId
DataUser = objgs_AnswerCountENS.DataUser, //数据用户
DataAddDate = objgs_AnswerCountENS.DataAddDate, //数据添加日期
Month = objgs_AnswerCountENS.Month, //月
Week = objgs_AnswerCountENS.Week, //周
WeekTimeRange = objgs_AnswerCountENS.WeekTimeRange, //WeekTimeRange
IsRecommend = objgs_AnswerCountENS.IsRecommend, //是否推荐
AnswerId = objgs_AnswerCountENS.AnswerId, //回答Id
AnswerTypeId = objgs_AnswerCountENS.AnswerTypeId, //答案类型ID
QuestionsId = objgs_AnswerCountENS.QuestionsId, //提问Id
TopicId = objgs_AnswerCountENS.TopicId, //主题Id
PaperId = objgs_AnswerCountENS.PaperId, //论文Id
IdCurrEduCls = objgs_AnswerCountENS.IdCurrEduCls, //教学班流水号
AnswerContent = objgs_AnswerCountENS.AnswerContent, //答案内容
Score = objgs_AnswerCountENS.Score, //评分
ScoreType = objgs_AnswerCountENS.ScoreType, //评分类型
UpdUser = objgs_AnswerCountENS.UpdUser, //修改人
UpdDate = objgs_AnswerCountENS.UpdDate, //修改日期
UserName = objgs_AnswerCountENS.UserName, //用户名
};
 return objgs_AnswerCountENT;
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
public static void CheckPropertyNew(this clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 clsgs_AnswerCountBL.gs_AnswerCountDA.CheckPropertyNew(objgs_AnswerCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 clsgs_AnswerCountBL.gs_AnswerCountDA.CheckProperty4Condition(objgs_AnswerCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_AnswerCountEN objgs_AnswerCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.Memo) == true)
{
string strComparisonOpMemo = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.Memo, objgs_AnswerCountCond.Memo, strComparisonOpMemo);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.AnswerCountId) == true)
{
string strComparisonOpAnswerCountId = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.AnswerCountId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.AnswerCountId, objgs_AnswerCountCond.AnswerCountId, strComparisonOpAnswerCountId);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.DataUser) == true)
{
string strComparisonOpDataUser = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.DataUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.DataUser, objgs_AnswerCountCond.DataUser, strComparisonOpDataUser);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.DataAddDate) == true)
{
string strComparisonOpDataAddDate = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.DataAddDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.DataAddDate, objgs_AnswerCountCond.DataAddDate, strComparisonOpDataAddDate);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.Month) == true)
{
string strComparisonOpMonth = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.Month];
strWhereCond += string.Format(" And {0} {2} {1}", congs_AnswerCount.Month, objgs_AnswerCountCond.Month, strComparisonOpMonth);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.Week) == true)
{
string strComparisonOpWeek = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.Week];
strWhereCond += string.Format(" And {0} {2} {1}", congs_AnswerCount.Week, objgs_AnswerCountCond.Week, strComparisonOpWeek);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.WeekTimeRange) == true)
{
string strComparisonOpWeekTimeRange = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.WeekTimeRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.WeekTimeRange, objgs_AnswerCountCond.WeekTimeRange, strComparisonOpWeekTimeRange);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.IsRecommend) == true)
{
if (objgs_AnswerCountCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_AnswerCount.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_AnswerCount.IsRecommend);
}
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.AnswerId) == true)
{
string strComparisonOpAnswerId = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.AnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.AnswerId, objgs_AnswerCountCond.AnswerId, strComparisonOpAnswerId);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.AnswerTypeId, objgs_AnswerCountCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.QuestionsId) == true)
{
string strComparisonOpQuestionsId = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.QuestionsId, objgs_AnswerCountCond.QuestionsId, strComparisonOpQuestionsId);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.TopicId) == true)
{
string strComparisonOpTopicId = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.TopicId, objgs_AnswerCountCond.TopicId, strComparisonOpTopicId);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.PaperId) == true)
{
string strComparisonOpPaperId = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.PaperId, objgs_AnswerCountCond.PaperId, strComparisonOpPaperId);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.IdCurrEduCls, objgs_AnswerCountCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.Score) == true)
{
string strComparisonOpScore = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", congs_AnswerCount.Score, objgs_AnswerCountCond.Score, strComparisonOpScore);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.ScoreType) == true)
{
string strComparisonOpScoreType = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.ScoreType, objgs_AnswerCountCond.ScoreType, strComparisonOpScoreType);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.UpdUser, objgs_AnswerCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.UpdDate, objgs_AnswerCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_AnswerCountCond.IsUpdated(congs_AnswerCount.UserName) == true)
{
string strComparisonOpUserName = objgs_AnswerCountCond.dicFldComparisonOp[congs_AnswerCount.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_AnswerCount.UserName, objgs_AnswerCountCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_AnswerCount(问题讨论回答统计), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AnswerCountId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_AnswerCountEN objgs_AnswerCountEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_AnswerCountEN == null) return true;
if (objgs_AnswerCountEN.AnswerCountId == null || objgs_AnswerCountEN.AnswerCountId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.AnswerCountId);
if (clsgs_AnswerCountBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("AnswerCountId !=  '{0}'", objgs_AnswerCountEN.AnswerCountId);
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.AnswerCountId);
if (clsgs_AnswerCountBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_AnswerCount(问题讨论回答统计), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AnswerCountId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_AnswerCountEN objgs_AnswerCountEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_AnswerCountEN == null) return "";
if (objgs_AnswerCountEN.AnswerCountId == null || objgs_AnswerCountEN.AnswerCountId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.AnswerCountId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerCountId !=  '{0}'", objgs_AnswerCountEN.AnswerCountId);
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.AnswerCountId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_AnswerCount
{
public virtual bool UpdRelaTabDate(string strAnswerCountId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 问题讨论回答统计(gs_AnswerCount)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_AnswerCountBL
{
public static RelatedActions_gs_AnswerCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_AnswerCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_AnswerCountDA gs_AnswerCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_AnswerCountDA();
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
 public clsgs_AnswerCountBL()
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
if (string.IsNullOrEmpty(clsgs_AnswerCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_AnswerCountEN._ConnectString);
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
public static DataTable GetDataTable_gs_AnswerCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_AnswerCountDA.GetDataTable_gs_AnswerCount(strWhereCond);
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
objDT = gs_AnswerCountDA.GetDataTable(strWhereCond);
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
objDT = gs_AnswerCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_AnswerCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_AnswerCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_AnswerCountDA.GetDataTable_Top(objTopPara);
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
objDT = gs_AnswerCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_AnswerCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_AnswerCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrAnswerCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_AnswerCountEN> GetObjLstByAnswerCountIdLst(List<string> arrAnswerCountIdLst)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAnswerCountIdLst, true);
 string strWhereCond = string.Format("AnswerCountId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAnswerCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_AnswerCountEN> GetObjLstByAnswerCountIdLstCache(List<string> arrAnswerCountIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strIdCurrEduCls);
List<clsgs_AnswerCountEN> arrgs_AnswerCountObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_AnswerCountEN> arrgs_AnswerCountObjLst_Sel =
arrgs_AnswerCountObjLstCache
.Where(x => arrAnswerCountIdLst.Contains(x.AnswerCountId));
return arrgs_AnswerCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_AnswerCountEN> GetObjLst(string strWhereCond)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
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
public static List<clsgs_AnswerCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_AnswerCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_AnswerCountEN> GetSubObjLstCache(clsgs_AnswerCountEN objgs_AnswerCountCond)
{
 string strIdCurrEduCls = objgs_AnswerCountCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_AnswerCountBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_AnswerCountEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_AnswerCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_AnswerCount.AttributeName)
{
if (objgs_AnswerCountCond.IsUpdated(strFldName) == false) continue;
if (objgs_AnswerCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_AnswerCountCond[strFldName].ToString());
}
else
{
if (objgs_AnswerCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_AnswerCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_AnswerCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_AnswerCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_AnswerCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_AnswerCountCond[strFldName]));
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
public static List<clsgs_AnswerCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
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
public static List<clsgs_AnswerCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
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
List<clsgs_AnswerCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_AnswerCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_AnswerCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_AnswerCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
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
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
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
public static List<clsgs_AnswerCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_AnswerCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_AnswerCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
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
public static List<clsgs_AnswerCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_AnswerCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_AnswerCountEN> arrObjLst = new List<clsgs_AnswerCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_AnswerCountEN objgs_AnswerCountEN = new clsgs_AnswerCountEN();
try
{
objgs_AnswerCountEN.Memo = objRow[congs_AnswerCount.Memo] == DBNull.Value ? null : objRow[congs_AnswerCount.Memo].ToString().Trim(); //备注
objgs_AnswerCountEN.AnswerCountId = objRow[congs_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objgs_AnswerCountEN.DataUser = objRow[congs_AnswerCount.DataUser] == DBNull.Value ? null : objRow[congs_AnswerCount.DataUser].ToString().Trim(); //数据用户
objgs_AnswerCountEN.DataAddDate = objRow[congs_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[congs_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objgs_AnswerCountEN.Month = objRow[congs_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Month].ToString().Trim()); //月
objgs_AnswerCountEN.Week = objRow[congs_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_AnswerCount.Week].ToString().Trim()); //周
objgs_AnswerCountEN.WeekTimeRange = objRow[congs_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[congs_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objgs_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objgs_AnswerCountEN.AnswerId = objRow[congs_AnswerCount.AnswerId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerId].ToString().Trim(); //回答Id
objgs_AnswerCountEN.AnswerTypeId = objRow[congs_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objgs_AnswerCountEN.QuestionsId = objRow[congs_AnswerCount.QuestionsId] == DBNull.Value ? null : objRow[congs_AnswerCount.QuestionsId].ToString().Trim(); //提问Id
objgs_AnswerCountEN.TopicId = objRow[congs_AnswerCount.TopicId] == DBNull.Value ? null : objRow[congs_AnswerCount.TopicId].ToString().Trim(); //主题Id
objgs_AnswerCountEN.PaperId = objRow[congs_AnswerCount.PaperId] == DBNull.Value ? null : objRow[congs_AnswerCount.PaperId].ToString().Trim(); //论文Id
objgs_AnswerCountEN.IdCurrEduCls = objRow[congs_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_AnswerCountEN.AnswerContent = objRow[congs_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[congs_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objgs_AnswerCountEN.Score = objRow[congs_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[congs_AnswerCount.Score].ToString().Trim()); //评分
objgs_AnswerCountEN.ScoreType = objRow[congs_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[congs_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objgs_AnswerCountEN.UpdUser = objRow[congs_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdUser].ToString().Trim(); //修改人
objgs_AnswerCountEN.UpdDate = objRow[congs_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[congs_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objgs_AnswerCountEN.UserName = objRow[congs_AnswerCount.UserName] == DBNull.Value ? null : objRow[congs_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_AnswerCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_AnswerCount(ref clsgs_AnswerCountEN objgs_AnswerCountEN)
{
bool bolResult = gs_AnswerCountDA.Getgs_AnswerCount(ref objgs_AnswerCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_AnswerCountEN GetObjByAnswerCountId(string strAnswerCountId)
{
if (strAnswerCountId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strAnswerCountId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strAnswerCountId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strAnswerCountId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_AnswerCountEN objgs_AnswerCountEN = gs_AnswerCountDA.GetObjByAnswerCountId(strAnswerCountId);
return objgs_AnswerCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_AnswerCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_AnswerCountEN objgs_AnswerCountEN = gs_AnswerCountDA.GetFirstObj(strWhereCond);
 return objgs_AnswerCountEN;
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
public static clsgs_AnswerCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_AnswerCountEN objgs_AnswerCountEN = gs_AnswerCountDA.GetObjByDataRow(objRow);
 return objgs_AnswerCountEN;
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
public static clsgs_AnswerCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_AnswerCountEN objgs_AnswerCountEN = gs_AnswerCountDA.GetObjByDataRow(objRow);
 return objgs_AnswerCountEN;
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
 /// <param name = "strAnswerCountId">所给的关键字</param>
 /// <param name = "lstgs_AnswerCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_AnswerCountEN GetObjByAnswerCountIdFromList(string strAnswerCountId, List<clsgs_AnswerCountEN> lstgs_AnswerCountObjLst)
{
foreach (clsgs_AnswerCountEN objgs_AnswerCountEN in lstgs_AnswerCountObjLst)
{
if (objgs_AnswerCountEN.AnswerCountId == strAnswerCountId)
{
return objgs_AnswerCountEN;
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
 string strMaxAnswerCountId;
 try
 {
 strMaxAnswerCountId = clsgs_AnswerCountDA.GetMaxStrId();
 return strMaxAnswerCountId;
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
 string strAnswerCountId;
 try
 {
 strAnswerCountId = new clsgs_AnswerCountDA().GetFirstID(strWhereCond);
 return strAnswerCountId;
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
 arrList = gs_AnswerCountDA.GetID(strWhereCond);
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
bool bolIsExist = gs_AnswerCountDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strAnswerCountId)
{
if (string.IsNullOrEmpty(strAnswerCountId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strAnswerCountId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_AnswerCountDA.IsExist(strAnswerCountId);
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
 bolIsExist = clsgs_AnswerCountDA.IsExistTable();
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
 bolIsExist = gs_AnswerCountDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_AnswerCountEN objgs_AnswerCountEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_AnswerCountEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clsgs_AnswerCountBL.AddNewRecordBySql2)", objgs_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true || clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId) == true)
 {
     objgs_AnswerCountEN.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
 }
bool bolResult = gs_AnswerCountDA.AddNewRecordBySQL2(objgs_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_AnswerCountEN objgs_AnswerCountEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_AnswerCountEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clsgs_AnswerCountBL.AddNewRecordBySql2WithReturnKey)", objgs_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true || clsgs_AnswerCountBL.IsExist(objgs_AnswerCountEN.AnswerCountId) == true)
 {
     objgs_AnswerCountEN.AnswerCountId = clsgs_AnswerCountBL.GetMaxStrId_S();
 }
string strKey = gs_AnswerCountDA.AddNewRecordBySQL2WithReturnKey(objgs_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
try
{
bool bolResult = gs_AnswerCountDA.Update(objgs_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objgs_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 if (string.IsNullOrEmpty(objgs_AnswerCountEN.AnswerCountId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_AnswerCountDA.UpdateBySql2(objgs_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_AnswerCountBL.ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strAnswerCountId)
{
try
{
 clsgs_AnswerCountEN objgs_AnswerCountEN = clsgs_AnswerCountBL.GetObjByAnswerCountId(strAnswerCountId);

if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(objgs_AnswerCountEN.AnswerCountId, "SetUpdDate");
}
if (objgs_AnswerCountEN != null)
{
int intRecNum = gs_AnswerCountDA.DelRecord(strAnswerCountId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);
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
/// <param name="strAnswerCountId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strAnswerCountId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
//删除与表:[gs_AnswerCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_AnswerCount.AnswerCountId,
//strAnswerCountId);
//        clsgs_AnswerCountBL.Delgs_AnswerCountsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_AnswerCountBL.DelRecord(strAnswerCountId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_AnswerCountBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strAnswerCountId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strAnswerCountId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strAnswerCountId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_AnswerCountBL.relatedActions != null)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(strAnswerCountId, "UpdRelaTabDate");
}
bool bolResult = gs_AnswerCountDA.DelRecord(strAnswerCountId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrAnswerCountIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_AnswerCounts(List<string> arrAnswerCountIdLst)
{
if (arrAnswerCountIdLst.Count == 0) return 0;
try
{
if (clsgs_AnswerCountBL.relatedActions != null)
{
foreach (var strAnswerCountId in arrAnswerCountIdLst)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(strAnswerCountId, "UpdRelaTabDate");
}
}
 clsgs_AnswerCountEN objgs_AnswerCountEN = clsgs_AnswerCountBL.GetObjByAnswerCountId(arrAnswerCountIdLst[0]);
int intDelRecNum = gs_AnswerCountDA.Delgs_AnswerCount(arrAnswerCountIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_AnswerCountEN.IdCurrEduCls);
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
public static int Delgs_AnswerCountsByCond(string strWhereCond)
{
try
{
if (clsgs_AnswerCountBL.relatedActions != null)
{
List<string> arrAnswerCountId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strAnswerCountId in arrAnswerCountId)
{
clsgs_AnswerCountBL.relatedActions.UpdRelaTabDate(strAnswerCountId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(congs_AnswerCount.IdCurrEduCls, strWhereCond);
int intRecNum = gs_AnswerCountDA.Delgs_AnswerCount(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_AnswerCount]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strAnswerCountId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strAnswerCountId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_AnswerCountDA.GetSpecSQLObj();
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
//删除与表:[gs_AnswerCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_AnswerCountBL.DelRecord(strAnswerCountId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_AnswerCountBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strAnswerCountId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_AnswerCountENS">源对象</param>
 /// <param name = "objgs_AnswerCountENT">目标对象</param>
 public static void CopyTo(clsgs_AnswerCountEN objgs_AnswerCountENS, clsgs_AnswerCountEN objgs_AnswerCountENT)
{
try
{
objgs_AnswerCountENT.Memo = objgs_AnswerCountENS.Memo; //备注
objgs_AnswerCountENT.AnswerCountId = objgs_AnswerCountENS.AnswerCountId; //AnswerCountId
objgs_AnswerCountENT.DataUser = objgs_AnswerCountENS.DataUser; //数据用户
objgs_AnswerCountENT.DataAddDate = objgs_AnswerCountENS.DataAddDate; //数据添加日期
objgs_AnswerCountENT.Month = objgs_AnswerCountENS.Month; //月
objgs_AnswerCountENT.Week = objgs_AnswerCountENS.Week; //周
objgs_AnswerCountENT.WeekTimeRange = objgs_AnswerCountENS.WeekTimeRange; //WeekTimeRange
objgs_AnswerCountENT.IsRecommend = objgs_AnswerCountENS.IsRecommend; //是否推荐
objgs_AnswerCountENT.AnswerId = objgs_AnswerCountENS.AnswerId; //回答Id
objgs_AnswerCountENT.AnswerTypeId = objgs_AnswerCountENS.AnswerTypeId; //答案类型ID
objgs_AnswerCountENT.QuestionsId = objgs_AnswerCountENS.QuestionsId; //提问Id
objgs_AnswerCountENT.TopicId = objgs_AnswerCountENS.TopicId; //主题Id
objgs_AnswerCountENT.PaperId = objgs_AnswerCountENS.PaperId; //论文Id
objgs_AnswerCountENT.IdCurrEduCls = objgs_AnswerCountENS.IdCurrEduCls; //教学班流水号
objgs_AnswerCountENT.AnswerContent = objgs_AnswerCountENS.AnswerContent; //答案内容
objgs_AnswerCountENT.Score = objgs_AnswerCountENS.Score; //评分
objgs_AnswerCountENT.ScoreType = objgs_AnswerCountENS.ScoreType; //评分类型
objgs_AnswerCountENT.UpdUser = objgs_AnswerCountENS.UpdUser; //修改人
objgs_AnswerCountENT.UpdDate = objgs_AnswerCountENS.UpdDate; //修改日期
objgs_AnswerCountENT.UserName = objgs_AnswerCountENS.UserName; //用户名
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
 /// <param name = "objgs_AnswerCountEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
try
{
objgs_AnswerCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_AnswerCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_AnswerCount.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.Memo = objgs_AnswerCountEN.Memo == "[null]" ? null :  objgs_AnswerCountEN.Memo; //备注
}
if (arrFldSet.Contains(congs_AnswerCount.AnswerCountId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.AnswerCountId = objgs_AnswerCountEN.AnswerCountId; //AnswerCountId
}
if (arrFldSet.Contains(congs_AnswerCount.DataUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.DataUser = objgs_AnswerCountEN.DataUser == "[null]" ? null :  objgs_AnswerCountEN.DataUser; //数据用户
}
if (arrFldSet.Contains(congs_AnswerCount.DataAddDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.DataAddDate = objgs_AnswerCountEN.DataAddDate == "[null]" ? null :  objgs_AnswerCountEN.DataAddDate; //数据添加日期
}
if (arrFldSet.Contains(congs_AnswerCount.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.Month = objgs_AnswerCountEN.Month; //月
}
if (arrFldSet.Contains(congs_AnswerCount.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.Week = objgs_AnswerCountEN.Week; //周
}
if (arrFldSet.Contains(congs_AnswerCount.WeekTimeRange, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.WeekTimeRange = objgs_AnswerCountEN.WeekTimeRange == "[null]" ? null :  objgs_AnswerCountEN.WeekTimeRange; //WeekTimeRange
}
if (arrFldSet.Contains(congs_AnswerCount.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.IsRecommend = objgs_AnswerCountEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(congs_AnswerCount.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.AnswerId = objgs_AnswerCountEN.AnswerId == "[null]" ? null :  objgs_AnswerCountEN.AnswerId; //回答Id
}
if (arrFldSet.Contains(congs_AnswerCount.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.AnswerTypeId = objgs_AnswerCountEN.AnswerTypeId == "[null]" ? null :  objgs_AnswerCountEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(congs_AnswerCount.QuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.QuestionsId = objgs_AnswerCountEN.QuestionsId == "[null]" ? null :  objgs_AnswerCountEN.QuestionsId; //提问Id
}
if (arrFldSet.Contains(congs_AnswerCount.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.TopicId = objgs_AnswerCountEN.TopicId == "[null]" ? null :  objgs_AnswerCountEN.TopicId; //主题Id
}
if (arrFldSet.Contains(congs_AnswerCount.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.PaperId = objgs_AnswerCountEN.PaperId == "[null]" ? null :  objgs_AnswerCountEN.PaperId; //论文Id
}
if (arrFldSet.Contains(congs_AnswerCount.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.IdCurrEduCls = objgs_AnswerCountEN.IdCurrEduCls == "[null]" ? null :  objgs_AnswerCountEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_AnswerCount.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.AnswerContent = objgs_AnswerCountEN.AnswerContent == "[null]" ? null :  objgs_AnswerCountEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(congs_AnswerCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.Score = objgs_AnswerCountEN.Score; //评分
}
if (arrFldSet.Contains(congs_AnswerCount.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.ScoreType = objgs_AnswerCountEN.ScoreType == "[null]" ? null :  objgs_AnswerCountEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(congs_AnswerCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.UpdUser = objgs_AnswerCountEN.UpdUser == "[null]" ? null :  objgs_AnswerCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_AnswerCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.UpdDate = objgs_AnswerCountEN.UpdDate == "[null]" ? null :  objgs_AnswerCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_AnswerCount.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_AnswerCountEN.UserName = objgs_AnswerCountEN.UserName == "[null]" ? null :  objgs_AnswerCountEN.UserName; //用户名
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
 /// <param name = "objgs_AnswerCountEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
try
{
if (objgs_AnswerCountEN.Memo == "[null]") objgs_AnswerCountEN.Memo = null; //备注
if (objgs_AnswerCountEN.DataUser == "[null]") objgs_AnswerCountEN.DataUser = null; //数据用户
if (objgs_AnswerCountEN.DataAddDate == "[null]") objgs_AnswerCountEN.DataAddDate = null; //数据添加日期
if (objgs_AnswerCountEN.WeekTimeRange == "[null]") objgs_AnswerCountEN.WeekTimeRange = null; //WeekTimeRange
if (objgs_AnswerCountEN.AnswerId == "[null]") objgs_AnswerCountEN.AnswerId = null; //回答Id
if (objgs_AnswerCountEN.AnswerTypeId == "[null]") objgs_AnswerCountEN.AnswerTypeId = null; //答案类型ID
if (objgs_AnswerCountEN.QuestionsId == "[null]") objgs_AnswerCountEN.QuestionsId = null; //提问Id
if (objgs_AnswerCountEN.TopicId == "[null]") objgs_AnswerCountEN.TopicId = null; //主题Id
if (objgs_AnswerCountEN.PaperId == "[null]") objgs_AnswerCountEN.PaperId = null; //论文Id
if (objgs_AnswerCountEN.IdCurrEduCls == "[null]") objgs_AnswerCountEN.IdCurrEduCls = null; //教学班流水号
if (objgs_AnswerCountEN.AnswerContent == "[null]") objgs_AnswerCountEN.AnswerContent = null; //答案内容
if (objgs_AnswerCountEN.ScoreType == "[null]") objgs_AnswerCountEN.ScoreType = null; //评分类型
if (objgs_AnswerCountEN.UpdUser == "[null]") objgs_AnswerCountEN.UpdUser = null; //修改人
if (objgs_AnswerCountEN.UpdDate == "[null]") objgs_AnswerCountEN.UpdDate = null; //修改日期
if (objgs_AnswerCountEN.UserName == "[null]") objgs_AnswerCountEN.UserName = null; //用户名
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
public static void CheckPropertyNew(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 gs_AnswerCountDA.CheckPropertyNew(objgs_AnswerCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
 gs_AnswerCountDA.CheckProperty4Condition(objgs_AnswerCountEN);
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
if (clsgs_AnswerCountBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_AnswerCountBL没有刷新缓存机制(clsgs_AnswerCountBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerCountId");
//if (arrgs_AnswerCountObjLstCache == null)
//{
//arrgs_AnswerCountObjLstCache = gs_AnswerCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strAnswerCountId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_AnswerCountEN GetObjByAnswerCountIdCache(string strAnswerCountId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strIdCurrEduCls);
List<clsgs_AnswerCountEN> arrgs_AnswerCountObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_AnswerCountEN> arrgs_AnswerCountObjLst_Sel =
arrgs_AnswerCountObjLstCache
.Where(x=> x.AnswerCountId == strAnswerCountId 
);
if (arrgs_AnswerCountObjLst_Sel.Count() == 0)
{
   clsgs_AnswerCountEN obj = clsgs_AnswerCountBL.GetObjByAnswerCountId(strAnswerCountId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strAnswerCountId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrgs_AnswerCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_AnswerCountEN> GetAllgs_AnswerCountObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsgs_AnswerCountEN> arrgs_AnswerCountObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrgs_AnswerCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_AnswerCountEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsgs_AnswerCountEN> arrgs_AnswerCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_AnswerCountObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_AnswerCountEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_AnswerCountEN._RefreshTimeLst.Count == 0) return "";
return clsgs_AnswerCountEN._RefreshTimeLst[clsgs_AnswerCountEN._RefreshTimeLst.Count - 1];
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
if (clsgs_AnswerCountBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_AnswerCountEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsgs_AnswerCountEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_AnswerCountBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_AnswerCount(问题讨论回答统计)
 /// 唯一性条件:AnswerCountId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_AnswerCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_AnswerCountEN objgs_AnswerCountEN)
{
//检测记录是否存在
string strResult = gs_AnswerCountDA.GetUniCondStr(objgs_AnswerCountEN);
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
public static string Func(string strInFldName, string strOutFldName, string strAnswerCountId, string strIdCurrEduCls)
{
if (strInFldName != congs_AnswerCount.AnswerCountId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_AnswerCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_AnswerCount.AttributeName));
throw new Exception(strMsg);
}
var objgs_AnswerCount = clsgs_AnswerCountBL.GetObjByAnswerCountIdCache(strAnswerCountId, strIdCurrEduCls);
if (objgs_AnswerCount == null) return "";
return objgs_AnswerCount[strOutFldName].ToString();
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
int intRecCount = clsgs_AnswerCountDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_AnswerCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_AnswerCountDA.GetRecCount();
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
int intRecCount = clsgs_AnswerCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_AnswerCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_AnswerCountEN objgs_AnswerCountCond)
{
 string strIdCurrEduCls = objgs_AnswerCountCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_AnswerCountBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_AnswerCountEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsgs_AnswerCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_AnswerCount.AttributeName)
{
if (objgs_AnswerCountCond.IsUpdated(strFldName) == false) continue;
if (objgs_AnswerCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_AnswerCountCond[strFldName].ToString());
}
else
{
if (objgs_AnswerCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_AnswerCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_AnswerCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_AnswerCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_AnswerCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_AnswerCountCond[strFldName]));
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
 List<string> arrList = clsgs_AnswerCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_AnswerCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_AnswerCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_AnswerCountDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_AnswerCountDA.SetFldValue(clsgs_AnswerCountEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_AnswerCountDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_AnswerCountDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_AnswerCountDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_AnswerCountDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_AnswerCount] "); 
 strCreateTabCode.Append(" ( "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**AnswerCountId*/ 
 strCreateTabCode.Append(" AnswerCountId char(10) primary key, "); 
 // /**数据用户*/ 
 strCreateTabCode.Append(" DataUser varchar(20) Null, "); 
 // /**数据添加日期*/ 
 strCreateTabCode.Append(" DataAddDate varchar(20) Null, "); 
 // /**月*/ 
 strCreateTabCode.Append(" Month int Null, "); 
 // /**周*/ 
 strCreateTabCode.Append(" Week int Null, "); 
 // /**WeekTimeRange*/ 
 strCreateTabCode.Append(" WeekTimeRange varchar(100) Null, "); 
 // /**是否推荐*/ 
 strCreateTabCode.Append(" IsRecommend bit Null, "); 
 // /**回答Id*/ 
 strCreateTabCode.Append(" AnswerId char(10) Null, "); 
 // /**答案类型ID*/ 
 strCreateTabCode.Append(" AnswerTypeId char(2) Null, "); 
 // /**提问Id*/ 
 strCreateTabCode.Append(" QuestionsId char(8) Null, "); 
 // /**主题Id*/ 
 strCreateTabCode.Append(" TopicId char(8) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**答案内容*/ 
 strCreateTabCode.Append(" AnswerContent text Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**评分类型*/ 
 strCreateTabCode.Append(" ScoreType char(1) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**用户名*/ 
 strCreateTabCode.Append(" UserName varchar(30) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 问题讨论回答统计(gs_AnswerCount)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_AnswerCount : clsCommFun4BLV2
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
clsgs_AnswerCountBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}