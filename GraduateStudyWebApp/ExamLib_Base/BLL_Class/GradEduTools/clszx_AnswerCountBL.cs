
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerCountBL
 表名:zx_AnswerCount(01120785)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clszx_AnswerCountBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_AnswerCountEN GetObj(this K_AnswerCountId_zx_AnswerCount myKey)
{
clszx_AnswerCountEN objzx_AnswerCountEN = clszx_AnswerCountBL.zx_AnswerCountDA.GetObjByAnswerCountId(myKey.Value);
return objzx_AnswerCountEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
if (CheckUniqueness(objzx_AnswerCountEN) == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clszx_AnswerCountBL.AddNewRecord)", objzx_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true || clszx_AnswerCountBL.IsExist(objzx_AnswerCountEN.AnswerCountId) == true)
 {
     objzx_AnswerCountEN.AnswerCountId = clszx_AnswerCountBL.GetMaxStrId_S();
 }
bool bolResult = clszx_AnswerCountBL.zx_AnswerCountDA.AddNewRecordBySQL2(objzx_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_AnswerCountBL.IsExist(objzx_AnswerCountEN.AnswerCountId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_AnswerCountEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_AnswerCountEN.CheckUniqueness() == false)
{
strMsg = string.Format("(AnswerCountId(AnswerCountId)=[{0}])已经存在,不能重复!", objzx_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true || clszx_AnswerCountBL.IsExist(objzx_AnswerCountEN.AnswerCountId) == true)
 {
     objzx_AnswerCountEN.AnswerCountId = clszx_AnswerCountBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_AnswerCountEN.AddNewRecord();
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
if (CheckUniqueness(objzx_AnswerCountEN) == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clszx_AnswerCountBL.AddNewRecordWithMaxId)", objzx_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true || clszx_AnswerCountBL.IsExist(objzx_AnswerCountEN.AnswerCountId) == true)
 {
     objzx_AnswerCountEN.AnswerCountId = clszx_AnswerCountBL.GetMaxStrId_S();
 }
string strAnswerCountId = clszx_AnswerCountBL.zx_AnswerCountDA.AddNewRecordBySQL2WithReturnKey(objzx_AnswerCountEN);
     objzx_AnswerCountEN.AnswerCountId = strAnswerCountId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
if (CheckUniqueness(objzx_AnswerCountEN) == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clszx_AnswerCountBL.AddNewRecordWithReturnKey)", objzx_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true || clszx_AnswerCountBL.IsExist(objzx_AnswerCountEN.AnswerCountId) == true)
 {
     objzx_AnswerCountEN.AnswerCountId = clszx_AnswerCountBL.GetMaxStrId_S();
 }
string strKey = clszx_AnswerCountBL.zx_AnswerCountDA.AddNewRecordBySQL2WithReturnKey(objzx_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetMemo(this clszx_AnswerCountEN objzx_AnswerCountEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_AnswerCount.Memo);
}
objzx_AnswerCountEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.Memo) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.Memo, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.Memo] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetAnswerCountId(this clszx_AnswerCountEN objzx_AnswerCountEN, string strAnswerCountId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerCountId, 10, conzx_AnswerCount.AnswerCountId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerCountId, 10, conzx_AnswerCount.AnswerCountId);
}
objzx_AnswerCountEN.AnswerCountId = strAnswerCountId; //AnswerCountId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.AnswerCountId) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.AnswerCountId, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.AnswerCountId] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetDataUser(this clszx_AnswerCountEN objzx_AnswerCountEN, string strDataUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataUser, 20, conzx_AnswerCount.DataUser);
}
objzx_AnswerCountEN.DataUser = strDataUser; //数据用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.DataUser) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.DataUser, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.DataUser] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetDataAddDate(this clszx_AnswerCountEN objzx_AnswerCountEN, string strDataAddDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataAddDate, 20, conzx_AnswerCount.DataAddDate);
}
objzx_AnswerCountEN.DataAddDate = strDataAddDate; //数据添加日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.DataAddDate) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.DataAddDate, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.DataAddDate] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetMonth(this clszx_AnswerCountEN objzx_AnswerCountEN, int? intMonth, string strComparisonOp="")
	{
objzx_AnswerCountEN.Month = intMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.Month) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.Month, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.Month] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetWeek(this clszx_AnswerCountEN objzx_AnswerCountEN, int? intWeek, string strComparisonOp="")
	{
objzx_AnswerCountEN.Week = intWeek; //周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.Week) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.Week, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.Week] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetWeekTimeRange(this clszx_AnswerCountEN objzx_AnswerCountEN, string strWeekTimeRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWeekTimeRange, 100, conzx_AnswerCount.WeekTimeRange);
}
objzx_AnswerCountEN.WeekTimeRange = strWeekTimeRange; //WeekTimeRange
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.WeekTimeRange) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.WeekTimeRange, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.WeekTimeRange] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetIsRecommend(this clszx_AnswerCountEN objzx_AnswerCountEN, bool bolIsRecommend, string strComparisonOp="")
	{
objzx_AnswerCountEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.IsRecommend) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.IsRecommend, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.IsRecommend] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetzxAnswerId(this clszx_AnswerCountEN objzx_AnswerCountEN, string strzxAnswerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxAnswerId, 10, conzx_AnswerCount.zxAnswerId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxAnswerId, 10, conzx_AnswerCount.zxAnswerId);
}
objzx_AnswerCountEN.zxAnswerId = strzxAnswerId; //回答Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.zxAnswerId) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.zxAnswerId, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.zxAnswerId] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetAnswerTypeId(this clszx_AnswerCountEN objzx_AnswerCountEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conzx_AnswerCount.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conzx_AnswerCount.AnswerTypeId);
}
objzx_AnswerCountEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.AnswerTypeId) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.AnswerTypeId, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.AnswerTypeId] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetzxQuestionsId(this clszx_AnswerCountEN objzx_AnswerCountEN, string strzxQuestionsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxQuestionsId, 8, conzx_AnswerCount.zxQuestionsId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxQuestionsId, 8, conzx_AnswerCount.zxQuestionsId);
}
objzx_AnswerCountEN.zxQuestionsId = strzxQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.zxQuestionsId) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.zxQuestionsId, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.zxQuestionsId] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetGroupTextId(this clszx_AnswerCountEN objzx_AnswerCountEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_AnswerCount.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_AnswerCount.GroupTextId);
}
objzx_AnswerCountEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.GroupTextId) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.GroupTextId, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.GroupTextId] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetTextId(this clszx_AnswerCountEN objzx_AnswerCountEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_AnswerCount.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_AnswerCount.TextId);
}
objzx_AnswerCountEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.TextId) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.TextId, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.TextId] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetIdCurrEduCls(this clszx_AnswerCountEN objzx_AnswerCountEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_AnswerCount.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_AnswerCount.IdCurrEduCls);
}
objzx_AnswerCountEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.IdCurrEduCls) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetAnswerContent(this clszx_AnswerCountEN objzx_AnswerCountEN, string strAnswerContent, string strComparisonOp="")
	{
objzx_AnswerCountEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.AnswerContent) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.AnswerContent, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.AnswerContent] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetScore(this clszx_AnswerCountEN objzx_AnswerCountEN, float? fltScore, string strComparisonOp="")
	{
objzx_AnswerCountEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.Score) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.Score, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.Score] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetScoreType(this clszx_AnswerCountEN objzx_AnswerCountEN, string strScoreType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreType, 1, conzx_AnswerCount.ScoreType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strScoreType, 1, conzx_AnswerCount.ScoreType);
}
objzx_AnswerCountEN.ScoreType = strScoreType; //评分类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.ScoreType) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.ScoreType, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.ScoreType] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetUpdUser(this clszx_AnswerCountEN objzx_AnswerCountEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_AnswerCount.UpdUser);
}
objzx_AnswerCountEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.UpdUser) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.UpdUser, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.UpdUser] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetUpdDate(this clszx_AnswerCountEN objzx_AnswerCountEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_AnswerCount.UpdDate);
}
objzx_AnswerCountEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.UpdDate) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.UpdDate, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.UpdDate] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_AnswerCountEN SetUserName(this clszx_AnswerCountEN objzx_AnswerCountEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, conzx_AnswerCount.UserName);
}
objzx_AnswerCountEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_AnswerCountEN.dicFldComparisonOp.ContainsKey(conzx_AnswerCount.UserName) == false)
{
objzx_AnswerCountEN.dicFldComparisonOp.Add(conzx_AnswerCount.UserName, strComparisonOp);
}
else
{
objzx_AnswerCountEN.dicFldComparisonOp[conzx_AnswerCount.UserName] = strComparisonOp;
}
}
return objzx_AnswerCountEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_AnswerCountEN.CheckPropertyNew();
clszx_AnswerCountEN objzx_AnswerCountCond = new clszx_AnswerCountEN();
string strCondition = objzx_AnswerCountCond
.SetAnswerCountId(objzx_AnswerCountEN.AnswerCountId, "<>")
.SetAnswerCountId(objzx_AnswerCountEN.AnswerCountId, "=")
.GetCombineCondition();
objzx_AnswerCountEN._IsCheckProperty = true;
bool bolIsExist = clszx_AnswerCountBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AnswerCountId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_AnswerCountEN.Update();
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
 /// <param name = "objzx_AnswerCount">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_AnswerCountEN objzx_AnswerCount)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_AnswerCountEN objzx_AnswerCountCond = new clszx_AnswerCountEN();
string strCondition = objzx_AnswerCountCond
.SetAnswerCountId(objzx_AnswerCount.AnswerCountId, "=")
.GetCombineCondition();
objzx_AnswerCount._IsCheckProperty = true;
bool bolIsExist = clszx_AnswerCountBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_AnswerCount.AnswerCountId = clszx_AnswerCountBL.GetFirstID_S(strCondition);
objzx_AnswerCount.UpdateWithCondition(strCondition);
}
else
{
objzx_AnswerCount.AnswerCountId = clszx_AnswerCountBL.GetMaxStrId_S();
objzx_AnswerCount.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_AnswerCountBL.zx_AnswerCountDA.UpdateBySql2(objzx_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_AnswerCountEN objzx_AnswerCountEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_AnswerCountBL.zx_AnswerCountDA.UpdateBySql2(objzx_AnswerCountEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_AnswerCountEN objzx_AnswerCountEN, string strWhereCond)
{
try
{
bool bolResult = clszx_AnswerCountBL.zx_AnswerCountDA.UpdateBySqlWithCondition(objzx_AnswerCountEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_AnswerCountEN objzx_AnswerCountEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_AnswerCountBL.zx_AnswerCountDA.UpdateBySqlWithConditionTransaction(objzx_AnswerCountEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
public static int Delete(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
try
{
int intRecNum = clszx_AnswerCountBL.zx_AnswerCountDA.DelRecord(objzx_AnswerCountEN.AnswerCountId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountENS">源对象</param>
 /// <param name = "objzx_AnswerCountENT">目标对象</param>
 public static void CopyTo(this clszx_AnswerCountEN objzx_AnswerCountENS, clszx_AnswerCountEN objzx_AnswerCountENT)
{
try
{
objzx_AnswerCountENT.Memo = objzx_AnswerCountENS.Memo; //备注
objzx_AnswerCountENT.AnswerCountId = objzx_AnswerCountENS.AnswerCountId; //AnswerCountId
objzx_AnswerCountENT.DataUser = objzx_AnswerCountENS.DataUser; //数据用户
objzx_AnswerCountENT.DataAddDate = objzx_AnswerCountENS.DataAddDate; //数据添加日期
objzx_AnswerCountENT.Month = objzx_AnswerCountENS.Month; //月
objzx_AnswerCountENT.Week = objzx_AnswerCountENS.Week; //周
objzx_AnswerCountENT.WeekTimeRange = objzx_AnswerCountENS.WeekTimeRange; //WeekTimeRange
objzx_AnswerCountENT.IsRecommend = objzx_AnswerCountENS.IsRecommend; //是否推荐
objzx_AnswerCountENT.zxAnswerId = objzx_AnswerCountENS.zxAnswerId; //回答Id
objzx_AnswerCountENT.AnswerTypeId = objzx_AnswerCountENS.AnswerTypeId; //答案类型ID
objzx_AnswerCountENT.zxQuestionsId = objzx_AnswerCountENS.zxQuestionsId; //提问Id
objzx_AnswerCountENT.GroupTextId = objzx_AnswerCountENS.GroupTextId; //小组Id
objzx_AnswerCountENT.TextId = objzx_AnswerCountENS.TextId; //课件Id
objzx_AnswerCountENT.IdCurrEduCls = objzx_AnswerCountENS.IdCurrEduCls; //教学班流水号
objzx_AnswerCountENT.AnswerContent = objzx_AnswerCountENS.AnswerContent; //答案内容
objzx_AnswerCountENT.Score = objzx_AnswerCountENS.Score; //评分
objzx_AnswerCountENT.ScoreType = objzx_AnswerCountENS.ScoreType; //评分类型
objzx_AnswerCountENT.UpdUser = objzx_AnswerCountENS.UpdUser; //修改人
objzx_AnswerCountENT.UpdDate = objzx_AnswerCountENS.UpdDate; //修改日期
objzx_AnswerCountENT.UserName = objzx_AnswerCountENS.UserName; //用户名
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
 /// <param name = "objzx_AnswerCountENS">源对象</param>
 /// <returns>目标对象=>clszx_AnswerCountEN:objzx_AnswerCountENT</returns>
 public static clszx_AnswerCountEN CopyTo(this clszx_AnswerCountEN objzx_AnswerCountENS)
{
try
{
 clszx_AnswerCountEN objzx_AnswerCountENT = new clszx_AnswerCountEN()
{
Memo = objzx_AnswerCountENS.Memo, //备注
AnswerCountId = objzx_AnswerCountENS.AnswerCountId, //AnswerCountId
DataUser = objzx_AnswerCountENS.DataUser, //数据用户
DataAddDate = objzx_AnswerCountENS.DataAddDate, //数据添加日期
Month = objzx_AnswerCountENS.Month, //月
Week = objzx_AnswerCountENS.Week, //周
WeekTimeRange = objzx_AnswerCountENS.WeekTimeRange, //WeekTimeRange
IsRecommend = objzx_AnswerCountENS.IsRecommend, //是否推荐
zxAnswerId = objzx_AnswerCountENS.zxAnswerId, //回答Id
AnswerTypeId = objzx_AnswerCountENS.AnswerTypeId, //答案类型ID
zxQuestionsId = objzx_AnswerCountENS.zxQuestionsId, //提问Id
GroupTextId = objzx_AnswerCountENS.GroupTextId, //小组Id
TextId = objzx_AnswerCountENS.TextId, //课件Id
IdCurrEduCls = objzx_AnswerCountENS.IdCurrEduCls, //教学班流水号
AnswerContent = objzx_AnswerCountENS.AnswerContent, //答案内容
Score = objzx_AnswerCountENS.Score, //评分
ScoreType = objzx_AnswerCountENS.ScoreType, //评分类型
UpdUser = objzx_AnswerCountENS.UpdUser, //修改人
UpdDate = objzx_AnswerCountENS.UpdDate, //修改日期
UserName = objzx_AnswerCountENS.UserName, //用户名
};
 return objzx_AnswerCountENT;
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
public static void CheckPropertyNew(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
 clszx_AnswerCountBL.zx_AnswerCountDA.CheckPropertyNew(objzx_AnswerCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
 clszx_AnswerCountBL.zx_AnswerCountDA.CheckProperty4Condition(objzx_AnswerCountEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_AnswerCountEN objzx_AnswerCountCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.Memo) == true)
{
string strComparisonOpMemo = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.Memo, objzx_AnswerCountCond.Memo, strComparisonOpMemo);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.AnswerCountId) == true)
{
string strComparisonOpAnswerCountId = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.AnswerCountId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.AnswerCountId, objzx_AnswerCountCond.AnswerCountId, strComparisonOpAnswerCountId);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.DataUser) == true)
{
string strComparisonOpDataUser = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.DataUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.DataUser, objzx_AnswerCountCond.DataUser, strComparisonOpDataUser);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.DataAddDate) == true)
{
string strComparisonOpDataAddDate = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.DataAddDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.DataAddDate, objzx_AnswerCountCond.DataAddDate, strComparisonOpDataAddDate);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.Month) == true)
{
string strComparisonOpMonth = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.Month];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_AnswerCount.Month, objzx_AnswerCountCond.Month, strComparisonOpMonth);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.Week) == true)
{
string strComparisonOpWeek = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.Week];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_AnswerCount.Week, objzx_AnswerCountCond.Week, strComparisonOpWeek);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.WeekTimeRange) == true)
{
string strComparisonOpWeekTimeRange = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.WeekTimeRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.WeekTimeRange, objzx_AnswerCountCond.WeekTimeRange, strComparisonOpWeekTimeRange);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.IsRecommend) == true)
{
if (objzx_AnswerCountCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_AnswerCount.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_AnswerCount.IsRecommend);
}
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.zxAnswerId) == true)
{
string strComparisonOpzxAnswerId = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.zxAnswerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.zxAnswerId, objzx_AnswerCountCond.zxAnswerId, strComparisonOpzxAnswerId);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.AnswerTypeId, objzx_AnswerCountCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.zxQuestionsId) == true)
{
string strComparisonOpzxQuestionsId = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.zxQuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.zxQuestionsId, objzx_AnswerCountCond.zxQuestionsId, strComparisonOpzxQuestionsId);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.GroupTextId, objzx_AnswerCountCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.TextId) == true)
{
string strComparisonOpTextId = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.TextId, objzx_AnswerCountCond.TextId, strComparisonOpTextId);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.IdCurrEduCls, objzx_AnswerCountCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.Score) == true)
{
string strComparisonOpScore = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_AnswerCount.Score, objzx_AnswerCountCond.Score, strComparisonOpScore);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.ScoreType) == true)
{
string strComparisonOpScoreType = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.ScoreType, objzx_AnswerCountCond.ScoreType, strComparisonOpScoreType);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.UpdUser, objzx_AnswerCountCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.UpdDate, objzx_AnswerCountCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_AnswerCountCond.IsUpdated(conzx_AnswerCount.UserName) == true)
{
string strComparisonOpUserName = objzx_AnswerCountCond.dicFldComparisonOp[conzx_AnswerCount.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_AnswerCount.UserName, objzx_AnswerCountCond.UserName, strComparisonOpUserName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_AnswerCount(z中学问题讨论回答统计), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AnswerCountId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_AnswerCountEN == null) return true;
if (objzx_AnswerCountEN.AnswerCountId == null || objzx_AnswerCountEN.AnswerCountId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objzx_AnswerCountEN.AnswerCountId);
if (clszx_AnswerCountBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("AnswerCountId !=  '{0}'", objzx_AnswerCountEN.AnswerCountId);
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objzx_AnswerCountEN.AnswerCountId);
if (clszx_AnswerCountBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_AnswerCount(z中学问题讨论回答统计), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AnswerCountId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_AnswerCountEN objzx_AnswerCountEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_AnswerCountEN == null) return "";
if (objzx_AnswerCountEN.AnswerCountId == null || objzx_AnswerCountEN.AnswerCountId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objzx_AnswerCountEN.AnswerCountId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerCountId !=  '{0}'", objzx_AnswerCountEN.AnswerCountId);
 sbCondition.AppendFormat(" and AnswerCountId = '{0}'", objzx_AnswerCountEN.AnswerCountId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_AnswerCount
{
public virtual bool UpdRelaTabDate(string strAnswerCountId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// z中学问题讨论回答统计(zx_AnswerCount)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_AnswerCountBL
{
public static RelatedActions_zx_AnswerCount relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_AnswerCountDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_AnswerCountDA zx_AnswerCountDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_AnswerCountDA();
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
 public clszx_AnswerCountBL()
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
if (string.IsNullOrEmpty(clszx_AnswerCountEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_AnswerCountEN._ConnectString);
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
public static DataTable GetDataTable_zx_AnswerCount(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_AnswerCountDA.GetDataTable_zx_AnswerCount(strWhereCond);
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
objDT = zx_AnswerCountDA.GetDataTable(strWhereCond);
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
objDT = zx_AnswerCountDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_AnswerCountDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_AnswerCountDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_AnswerCountDA.GetDataTable_Top(objTopPara);
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
objDT = zx_AnswerCountDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_AnswerCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_AnswerCountDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clszx_AnswerCountEN> GetObjLstByAnswerCountIdLst(List<string> arrAnswerCountIdLst)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
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
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAnswerCountIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_AnswerCountEN> GetObjLstByAnswerCountIdLstCache(List<string> arrAnswerCountIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_AnswerCountEN._CurrTabName, strIdCurrEduCls);
List<clszx_AnswerCountEN> arrzx_AnswerCountObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerCountEN> arrzx_AnswerCountObjLst_Sel =
arrzx_AnswerCountObjLstCache
.Where(x => arrAnswerCountIdLst.Contains(x.AnswerCountId));
return arrzx_AnswerCountObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_AnswerCountEN> GetObjLst(string strWhereCond)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
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
public static List<clszx_AnswerCountEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_AnswerCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_AnswerCountEN> GetSubObjLstCache(clszx_AnswerCountEN objzx_AnswerCountCond)
{
 string strIdCurrEduCls = objzx_AnswerCountCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_AnswerCountBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_AnswerCountEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_AnswerCount.AttributeName)
{
if (objzx_AnswerCountCond.IsUpdated(strFldName) == false) continue;
if (objzx_AnswerCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCountCond[strFldName].ToString());
}
else
{
if (objzx_AnswerCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_AnswerCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_AnswerCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCountCond[strFldName]));
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
public static List<clszx_AnswerCountEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
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
public static List<clszx_AnswerCountEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
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
List<clszx_AnswerCountEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_AnswerCountEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_AnswerCountEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_AnswerCountEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
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
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
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
public static List<clszx_AnswerCountEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_AnswerCountEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_AnswerCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
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
public static List<clszx_AnswerCountEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_AnswerCountEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_AnswerCountEN> arrObjLst = new List<clszx_AnswerCountEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerCountEN objzx_AnswerCountEN = new clszx_AnswerCountEN();
try
{
objzx_AnswerCountEN.Memo = objRow[conzx_AnswerCount.Memo] == DBNull.Value ? null : objRow[conzx_AnswerCount.Memo].ToString().Trim(); //备注
objzx_AnswerCountEN.AnswerCountId = objRow[conzx_AnswerCount.AnswerCountId].ToString().Trim(); //AnswerCountId
objzx_AnswerCountEN.DataUser = objRow[conzx_AnswerCount.DataUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataUser].ToString().Trim(); //数据用户
objzx_AnswerCountEN.DataAddDate = objRow[conzx_AnswerCount.DataAddDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.DataAddDate].ToString().Trim(); //数据添加日期
objzx_AnswerCountEN.Month = objRow[conzx_AnswerCount.Month] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Month].ToString().Trim()); //月
objzx_AnswerCountEN.Week = objRow[conzx_AnswerCount.Week] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_AnswerCount.Week].ToString().Trim()); //周
objzx_AnswerCountEN.WeekTimeRange = objRow[conzx_AnswerCount.WeekTimeRange] == DBNull.Value ? null : objRow[conzx_AnswerCount.WeekTimeRange].ToString().Trim(); //WeekTimeRange
objzx_AnswerCountEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_AnswerCount.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerCountEN.zxAnswerId = objRow[conzx_AnswerCount.zxAnswerId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerCountEN.AnswerTypeId = objRow[conzx_AnswerCount.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerCountEN.zxQuestionsId = objRow[conzx_AnswerCount.zxQuestionsId] == DBNull.Value ? null : objRow[conzx_AnswerCount.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerCountEN.GroupTextId = objRow[conzx_AnswerCount.GroupTextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerCountEN.TextId = objRow[conzx_AnswerCount.TextId] == DBNull.Value ? null : objRow[conzx_AnswerCount.TextId].ToString().Trim(); //课件Id
objzx_AnswerCountEN.IdCurrEduCls = objRow[conzx_AnswerCount.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_AnswerCount.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerCountEN.AnswerContent = objRow[conzx_AnswerCount.AnswerContent] == DBNull.Value ? null : objRow[conzx_AnswerCount.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerCountEN.Score = objRow[conzx_AnswerCount.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_AnswerCount.Score].ToString().Trim()); //评分
objzx_AnswerCountEN.ScoreType = objRow[conzx_AnswerCount.ScoreType] == DBNull.Value ? null : objRow[conzx_AnswerCount.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerCountEN.UpdUser = objRow[conzx_AnswerCount.UpdUser] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdUser].ToString().Trim(); //修改人
objzx_AnswerCountEN.UpdDate = objRow[conzx_AnswerCount.UpdDate] == DBNull.Value ? null : objRow[conzx_AnswerCount.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerCountEN.UserName = objRow[conzx_AnswerCount.UserName] == DBNull.Value ? null : objRow[conzx_AnswerCount.UserName].ToString().Trim(); //用户名
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_AnswerCountEN.AnswerCountId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_AnswerCountEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_AnswerCount(ref clszx_AnswerCountEN objzx_AnswerCountEN)
{
bool bolResult = zx_AnswerCountDA.Getzx_AnswerCount(ref objzx_AnswerCountEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strAnswerCountId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_AnswerCountEN GetObjByAnswerCountId(string strAnswerCountId)
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
clszx_AnswerCountEN objzx_AnswerCountEN = zx_AnswerCountDA.GetObjByAnswerCountId(strAnswerCountId);
return objzx_AnswerCountEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_AnswerCountEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_AnswerCountEN objzx_AnswerCountEN = zx_AnswerCountDA.GetFirstObj(strWhereCond);
 return objzx_AnswerCountEN;
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
public static clszx_AnswerCountEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_AnswerCountEN objzx_AnswerCountEN = zx_AnswerCountDA.GetObjByDataRow(objRow);
 return objzx_AnswerCountEN;
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
public static clszx_AnswerCountEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_AnswerCountEN objzx_AnswerCountEN = zx_AnswerCountDA.GetObjByDataRow(objRow);
 return objzx_AnswerCountEN;
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
 /// <param name = "lstzx_AnswerCountObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_AnswerCountEN GetObjByAnswerCountIdFromList(string strAnswerCountId, List<clszx_AnswerCountEN> lstzx_AnswerCountObjLst)
{
foreach (clszx_AnswerCountEN objzx_AnswerCountEN in lstzx_AnswerCountObjLst)
{
if (objzx_AnswerCountEN.AnswerCountId == strAnswerCountId)
{
return objzx_AnswerCountEN;
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
 strMaxAnswerCountId = clszx_AnswerCountDA.GetMaxStrId();
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
 strAnswerCountId = new clszx_AnswerCountDA().GetFirstID(strWhereCond);
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
 arrList = zx_AnswerCountDA.GetID(strWhereCond);
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
bool bolIsExist = zx_AnswerCountDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = zx_AnswerCountDA.IsExist(strAnswerCountId);
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
 bolIsExist = clszx_AnswerCountDA.IsExistTable();
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
 bolIsExist = zx_AnswerCountDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_AnswerCountEN objzx_AnswerCountEN)
{
if (objzx_AnswerCountEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clszx_AnswerCountBL.AddNewRecordBySql2)", objzx_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true || clszx_AnswerCountBL.IsExist(objzx_AnswerCountEN.AnswerCountId) == true)
 {
     objzx_AnswerCountEN.AnswerCountId = clszx_AnswerCountBL.GetMaxStrId_S();
 }
bool bolResult = zx_AnswerCountDA.AddNewRecordBySQL2(objzx_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_AnswerCountEN objzx_AnswerCountEN)
{
if (objzx_AnswerCountEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!AnswerCountId = [{0}]的数据已经存在!(in clszx_AnswerCountBL.AddNewRecordBySql2WithReturnKey)", objzx_AnswerCountEN.AnswerCountId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true || clszx_AnswerCountBL.IsExist(objzx_AnswerCountEN.AnswerCountId) == true)
 {
     objzx_AnswerCountEN.AnswerCountId = clszx_AnswerCountBL.GetMaxStrId_S();
 }
string strKey = zx_AnswerCountDA.AddNewRecordBySQL2WithReturnKey(objzx_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_AnswerCountEN objzx_AnswerCountEN)
{
try
{
bool bolResult = zx_AnswerCountDA.Update(objzx_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 /// <param name = "objzx_AnswerCountEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_AnswerCountEN objzx_AnswerCountEN)
{
 if (string.IsNullOrEmpty(objzx_AnswerCountEN.AnswerCountId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_AnswerCountDA.UpdateBySql2(objzx_AnswerCountEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_AnswerCountBL.ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
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
 clszx_AnswerCountEN objzx_AnswerCountEN = clszx_AnswerCountBL.GetObjByAnswerCountId(strAnswerCountId);

if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(objzx_AnswerCountEN.AnswerCountId, "SetUpdDate");
}
if (objzx_AnswerCountEN != null)
{
int intRecNum = zx_AnswerCountDA.DelRecord(strAnswerCountId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);
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
objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
//删除与表:[zx_AnswerCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_AnswerCount.AnswerCountId,
//strAnswerCountId);
//        clszx_AnswerCountBL.Delzx_AnswerCountsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_AnswerCountBL.DelRecord(strAnswerCountId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_AnswerCountBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clszx_AnswerCountBL.relatedActions != null)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(strAnswerCountId, "UpdRelaTabDate");
}
bool bolResult = zx_AnswerCountDA.DelRecord(strAnswerCountId,objSqlConnection,objSqlTransaction);
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
public static int Delzx_AnswerCounts(List<string> arrAnswerCountIdLst)
{
if (arrAnswerCountIdLst.Count == 0) return 0;
try
{
if (clszx_AnswerCountBL.relatedActions != null)
{
foreach (var strAnswerCountId in arrAnswerCountIdLst)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(strAnswerCountId, "UpdRelaTabDate");
}
}
 clszx_AnswerCountEN objzx_AnswerCountEN = clszx_AnswerCountBL.GetObjByAnswerCountId(arrAnswerCountIdLst[0]);
int intDelRecNum = zx_AnswerCountDA.Delzx_AnswerCount(arrAnswerCountIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_AnswerCountEN.IdCurrEduCls);
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
public static int Delzx_AnswerCountsByCond(string strWhereCond)
{
try
{
if (clszx_AnswerCountBL.relatedActions != null)
{
List<string> arrAnswerCountId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strAnswerCountId in arrAnswerCountId)
{
clszx_AnswerCountBL.relatedActions.UpdRelaTabDate(strAnswerCountId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_AnswerCount.IdCurrEduCls, strWhereCond);
int intRecNum = zx_AnswerCountDA.Delzx_AnswerCount(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_AnswerCount]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strAnswerCountId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strAnswerCountId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_AnswerCountDA.GetSpecSQLObj();
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
//删除与表:[zx_AnswerCount]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_AnswerCountBL.DelRecord(strAnswerCountId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_AnswerCountBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objzx_AnswerCountENS">源对象</param>
 /// <param name = "objzx_AnswerCountENT">目标对象</param>
 public static void CopyTo(clszx_AnswerCountEN objzx_AnswerCountENS, clszx_AnswerCountEN objzx_AnswerCountENT)
{
try
{
objzx_AnswerCountENT.Memo = objzx_AnswerCountENS.Memo; //备注
objzx_AnswerCountENT.AnswerCountId = objzx_AnswerCountENS.AnswerCountId; //AnswerCountId
objzx_AnswerCountENT.DataUser = objzx_AnswerCountENS.DataUser; //数据用户
objzx_AnswerCountENT.DataAddDate = objzx_AnswerCountENS.DataAddDate; //数据添加日期
objzx_AnswerCountENT.Month = objzx_AnswerCountENS.Month; //月
objzx_AnswerCountENT.Week = objzx_AnswerCountENS.Week; //周
objzx_AnswerCountENT.WeekTimeRange = objzx_AnswerCountENS.WeekTimeRange; //WeekTimeRange
objzx_AnswerCountENT.IsRecommend = objzx_AnswerCountENS.IsRecommend; //是否推荐
objzx_AnswerCountENT.zxAnswerId = objzx_AnswerCountENS.zxAnswerId; //回答Id
objzx_AnswerCountENT.AnswerTypeId = objzx_AnswerCountENS.AnswerTypeId; //答案类型ID
objzx_AnswerCountENT.zxQuestionsId = objzx_AnswerCountENS.zxQuestionsId; //提问Id
objzx_AnswerCountENT.GroupTextId = objzx_AnswerCountENS.GroupTextId; //小组Id
objzx_AnswerCountENT.TextId = objzx_AnswerCountENS.TextId; //课件Id
objzx_AnswerCountENT.IdCurrEduCls = objzx_AnswerCountENS.IdCurrEduCls; //教学班流水号
objzx_AnswerCountENT.AnswerContent = objzx_AnswerCountENS.AnswerContent; //答案内容
objzx_AnswerCountENT.Score = objzx_AnswerCountENS.Score; //评分
objzx_AnswerCountENT.ScoreType = objzx_AnswerCountENS.ScoreType; //评分类型
objzx_AnswerCountENT.UpdUser = objzx_AnswerCountENS.UpdUser; //修改人
objzx_AnswerCountENT.UpdDate = objzx_AnswerCountENS.UpdDate; //修改日期
objzx_AnswerCountENT.UserName = objzx_AnswerCountENS.UserName; //用户名
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
 /// <param name = "objzx_AnswerCountEN">源简化对象</param>
 public static void SetUpdFlag(clszx_AnswerCountEN objzx_AnswerCountEN)
{
try
{
objzx_AnswerCountEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_AnswerCountEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_AnswerCount.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.Memo = objzx_AnswerCountEN.Memo == "[null]" ? null :  objzx_AnswerCountEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_AnswerCount.AnswerCountId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.AnswerCountId = objzx_AnswerCountEN.AnswerCountId; //AnswerCountId
}
if (arrFldSet.Contains(conzx_AnswerCount.DataUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.DataUser = objzx_AnswerCountEN.DataUser == "[null]" ? null :  objzx_AnswerCountEN.DataUser; //数据用户
}
if (arrFldSet.Contains(conzx_AnswerCount.DataAddDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.DataAddDate = objzx_AnswerCountEN.DataAddDate == "[null]" ? null :  objzx_AnswerCountEN.DataAddDate; //数据添加日期
}
if (arrFldSet.Contains(conzx_AnswerCount.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.Month = objzx_AnswerCountEN.Month; //月
}
if (arrFldSet.Contains(conzx_AnswerCount.Week, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.Week = objzx_AnswerCountEN.Week; //周
}
if (arrFldSet.Contains(conzx_AnswerCount.WeekTimeRange, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.WeekTimeRange = objzx_AnswerCountEN.WeekTimeRange == "[null]" ? null :  objzx_AnswerCountEN.WeekTimeRange; //WeekTimeRange
}
if (arrFldSet.Contains(conzx_AnswerCount.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.IsRecommend = objzx_AnswerCountEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(conzx_AnswerCount.zxAnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.zxAnswerId = objzx_AnswerCountEN.zxAnswerId == "[null]" ? null :  objzx_AnswerCountEN.zxAnswerId; //回答Id
}
if (arrFldSet.Contains(conzx_AnswerCount.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.AnswerTypeId = objzx_AnswerCountEN.AnswerTypeId == "[null]" ? null :  objzx_AnswerCountEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(conzx_AnswerCount.zxQuestionsId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.zxQuestionsId = objzx_AnswerCountEN.zxQuestionsId == "[null]" ? null :  objzx_AnswerCountEN.zxQuestionsId; //提问Id
}
if (arrFldSet.Contains(conzx_AnswerCount.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.GroupTextId = objzx_AnswerCountEN.GroupTextId == "[null]" ? null :  objzx_AnswerCountEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(conzx_AnswerCount.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.TextId = objzx_AnswerCountEN.TextId == "[null]" ? null :  objzx_AnswerCountEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_AnswerCount.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.IdCurrEduCls = objzx_AnswerCountEN.IdCurrEduCls == "[null]" ? null :  objzx_AnswerCountEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_AnswerCount.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.AnswerContent = objzx_AnswerCountEN.AnswerContent == "[null]" ? null :  objzx_AnswerCountEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(conzx_AnswerCount.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.Score = objzx_AnswerCountEN.Score; //评分
}
if (arrFldSet.Contains(conzx_AnswerCount.ScoreType, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.ScoreType = objzx_AnswerCountEN.ScoreType == "[null]" ? null :  objzx_AnswerCountEN.ScoreType; //评分类型
}
if (arrFldSet.Contains(conzx_AnswerCount.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.UpdUser = objzx_AnswerCountEN.UpdUser == "[null]" ? null :  objzx_AnswerCountEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_AnswerCount.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.UpdDate = objzx_AnswerCountEN.UpdDate == "[null]" ? null :  objzx_AnswerCountEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_AnswerCount.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_AnswerCountEN.UserName = objzx_AnswerCountEN.UserName == "[null]" ? null :  objzx_AnswerCountEN.UserName; //用户名
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
 /// <param name = "objzx_AnswerCountEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_AnswerCountEN objzx_AnswerCountEN)
{
try
{
if (objzx_AnswerCountEN.Memo == "[null]") objzx_AnswerCountEN.Memo = null; //备注
if (objzx_AnswerCountEN.DataUser == "[null]") objzx_AnswerCountEN.DataUser = null; //数据用户
if (objzx_AnswerCountEN.DataAddDate == "[null]") objzx_AnswerCountEN.DataAddDate = null; //数据添加日期
if (objzx_AnswerCountEN.WeekTimeRange == "[null]") objzx_AnswerCountEN.WeekTimeRange = null; //WeekTimeRange
if (objzx_AnswerCountEN.zxAnswerId == "[null]") objzx_AnswerCountEN.zxAnswerId = null; //回答Id
if (objzx_AnswerCountEN.AnswerTypeId == "[null]") objzx_AnswerCountEN.AnswerTypeId = null; //答案类型ID
if (objzx_AnswerCountEN.zxQuestionsId == "[null]") objzx_AnswerCountEN.zxQuestionsId = null; //提问Id
if (objzx_AnswerCountEN.GroupTextId == "[null]") objzx_AnswerCountEN.GroupTextId = null; //小组Id
if (objzx_AnswerCountEN.TextId == "[null]") objzx_AnswerCountEN.TextId = null; //课件Id
if (objzx_AnswerCountEN.IdCurrEduCls == "[null]") objzx_AnswerCountEN.IdCurrEduCls = null; //教学班流水号
if (objzx_AnswerCountEN.AnswerContent == "[null]") objzx_AnswerCountEN.AnswerContent = null; //答案内容
if (objzx_AnswerCountEN.ScoreType == "[null]") objzx_AnswerCountEN.ScoreType = null; //评分类型
if (objzx_AnswerCountEN.UpdUser == "[null]") objzx_AnswerCountEN.UpdUser = null; //修改人
if (objzx_AnswerCountEN.UpdDate == "[null]") objzx_AnswerCountEN.UpdDate = null; //修改日期
if (objzx_AnswerCountEN.UserName == "[null]") objzx_AnswerCountEN.UserName = null; //用户名
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
public static void CheckPropertyNew(clszx_AnswerCountEN objzx_AnswerCountEN)
{
 zx_AnswerCountDA.CheckPropertyNew(objzx_AnswerCountEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_AnswerCountEN objzx_AnswerCountEN)
{
 zx_AnswerCountDA.CheckProperty4Condition(objzx_AnswerCountEN);
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
if (clszx_AnswerCountBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_AnswerCountBL没有刷新缓存机制(clszx_AnswerCountBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerCountId");
//if (arrzx_AnswerCountObjLstCache == null)
//{
//arrzx_AnswerCountObjLstCache = zx_AnswerCountDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strAnswerCountId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_AnswerCountEN GetObjByAnswerCountIdCache(string strAnswerCountId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_AnswerCountEN._CurrTabName, strIdCurrEduCls);
List<clszx_AnswerCountEN> arrzx_AnswerCountObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerCountEN> arrzx_AnswerCountObjLst_Sel =
arrzx_AnswerCountObjLstCache
.Where(x=> x.AnswerCountId == strAnswerCountId 
);
if (arrzx_AnswerCountObjLst_Sel.Count() == 0)
{
   clszx_AnswerCountEN obj = clszx_AnswerCountBL.GetObjByAnswerCountId(strAnswerCountId);
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
return arrzx_AnswerCountObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_AnswerCountEN> GetAllzx_AnswerCountObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_AnswerCountEN> arrzx_AnswerCountObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_AnswerCountObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_AnswerCountEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_AnswerCountEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_AnswerCountEN> arrzx_AnswerCountObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_AnswerCountObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_AnswerCountEN._CurrTabName, strIdCurrEduCls);
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
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_AnswerCountBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_AnswerCountEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_AnswerCountBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_AnswerCount(z中学问题讨论回答统计)
 /// 唯一性条件:AnswerCountId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_AnswerCountEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_AnswerCountEN objzx_AnswerCountEN)
{
//检测记录是否存在
string strResult = zx_AnswerCountDA.GetUniCondStr(objzx_AnswerCountEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strAnswerCountId, string strIdCurrEduCls)
{
if (strInFldName != conzx_AnswerCount.AnswerCountId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_AnswerCount.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_AnswerCount.AttributeName));
throw new Exception(strMsg);
}
var objzx_AnswerCount = clszx_AnswerCountBL.GetObjByAnswerCountIdCache(strAnswerCountId, strIdCurrEduCls);
if (objzx_AnswerCount == null) return "";
return objzx_AnswerCount[strOutFldName].ToString();
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
int intRecCount = clszx_AnswerCountDA.GetRecCount(strTabName);
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
int intRecCount = clszx_AnswerCountDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_AnswerCountDA.GetRecCount();
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
int intRecCount = clszx_AnswerCountDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_AnswerCountCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_AnswerCountEN objzx_AnswerCountCond)
{
 string strIdCurrEduCls = objzx_AnswerCountCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_AnswerCountBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_AnswerCountEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_AnswerCountEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_AnswerCount.AttributeName)
{
if (objzx_AnswerCountCond.IsUpdated(strFldName) == false) continue;
if (objzx_AnswerCountCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCountCond[strFldName].ToString());
}
else
{
if (objzx_AnswerCountCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_AnswerCountCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_AnswerCountCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_AnswerCountCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_AnswerCountCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCountCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_AnswerCountCond[strFldName]));
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
 List<string> arrList = clszx_AnswerCountDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_AnswerCountDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_AnswerCountDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_AnswerCountDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_AnswerCountDA.SetFldValue(clszx_AnswerCountEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_AnswerCountDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_AnswerCountDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_AnswerCountDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_AnswerCountDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_AnswerCount] "); 
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
 strCreateTabCode.Append(" zxAnswerId char(10) Null, "); 
 // /**答案类型ID*/ 
 strCreateTabCode.Append(" AnswerTypeId char(2) Null, "); 
 // /**提问Id*/ 
 strCreateTabCode.Append(" zxQuestionsId char(8) Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
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
 /// z中学问题讨论回答统计(zx_AnswerCount)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_AnswerCount : clsCommFun4BLV2
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
clszx_AnswerCountBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}