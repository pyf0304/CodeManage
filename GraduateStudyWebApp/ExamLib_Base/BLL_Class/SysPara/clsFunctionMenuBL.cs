
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionMenuBL
 表名:FunctionMenu(01120475)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsFunctionMenuBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFunctionMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionMenuEN GetObj(this K_FunctionMenuId_FunctionMenu myKey)
{
clsFunctionMenuEN objFunctionMenuEN = clsFunctionMenuBL.FunctionMenuDA.GetObjByFunctionMenuId(myKey.Value);
return objFunctionMenuEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionMenuEN objFunctionMenuEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true || clsFunctionMenuBL.IsExist(objFunctionMenuEN.FunctionMenuId) == true)
 {
     objFunctionMenuEN.FunctionMenuId = clsFunctionMenuBL.GetMaxStrId_S();
 }
bool bolResult = clsFunctionMenuBL.FunctionMenuDA.AddNewRecordBySQL2(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
public static bool AddRecordEx(this clsFunctionMenuEN objFunctionMenuEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFunctionMenuBL.IsExist(objFunctionMenuEN.FunctionMenuId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFunctionMenuEN.CheckPropertyNew();
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true || clsFunctionMenuBL.IsExist(objFunctionMenuEN.FunctionMenuId) == true)
 {
     objFunctionMenuEN.FunctionMenuId = clsFunctionMenuBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFunctionMenuEN.AddNewRecord();
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionMenuEN objFunctionMenuEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true || clsFunctionMenuBL.IsExist(objFunctionMenuEN.FunctionMenuId) == true)
 {
     objFunctionMenuEN.FunctionMenuId = clsFunctionMenuBL.GetMaxStrId_S();
 }
string strFunctionMenuId = clsFunctionMenuBL.FunctionMenuDA.AddNewRecordBySQL2WithReturnKey(objFunctionMenuEN);
     objFunctionMenuEN.FunctionMenuId = strFunctionMenuId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
}
return strFunctionMenuId;
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunctionMenuEN objFunctionMenuEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true || clsFunctionMenuBL.IsExist(objFunctionMenuEN.FunctionMenuId) == true)
 {
     objFunctionMenuEN.FunctionMenuId = clsFunctionMenuBL.GetMaxStrId_S();
 }
string strKey = clsFunctionMenuBL.FunctionMenuDA.AddNewRecordBySQL2WithReturnKey(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetFunctionMenuId(this clsFunctionMenuEN objFunctionMenuEN, string strFunctionMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionMenuId, 4, conFunctionMenu.FunctionMenuId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionMenuId, 4, conFunctionMenu.FunctionMenuId);
}
objFunctionMenuEN.FunctionMenuId = strFunctionMenuId; //功能菜单ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.FunctionMenuId) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.FunctionMenuId, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.FunctionMenuId] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetFunctionName(this clsFunctionMenuEN objFunctionMenuEN, string strFunctionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 100, conFunctionMenu.FunctionName);
}
objFunctionMenuEN.FunctionName = strFunctionName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.FunctionName) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.FunctionName, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.FunctionName] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetTitleName(this clsFunctionMenuEN objFunctionMenuEN, string strTitleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTitleName, 200, conFunctionMenu.TitleName);
}
objFunctionMenuEN.TitleName = strTitleName; //功能菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.TitleName) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.TitleName, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.TitleName] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetIsVisible(this clsFunctionMenuEN objFunctionMenuEN, bool bolIsVisible, string strComparisonOp="")
	{
objFunctionMenuEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.IsVisible) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.IsVisible, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.IsVisible] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetDispPageMode(this clsFunctionMenuEN objFunctionMenuEN, string strDispPageMode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDispPageMode, 50, conFunctionMenu.DispPageMode);
}
objFunctionMenuEN.DispPageMode = strDispPageMode; //显示页面方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.DispPageMode) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.DispPageMode, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.DispPageMode] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetIsTransUserBySingleSignOn(this clsFunctionMenuEN objFunctionMenuEN, bool bolIsTransUserBySingleSignOn, string strComparisonOp="")
	{
objFunctionMenuEN.IsTransUserBySingleSignOn = bolIsTransUserBySingleSignOn; //是否单点登录传用户信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.IsTransUserBySingleSignOn) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.IsTransUserBySingleSignOn, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.IsTransUserBySingleSignOn] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetIsWithParameter(this clsFunctionMenuEN objFunctionMenuEN, bool bolIsWithParameter, string strComparisonOp="")
	{
objFunctionMenuEN.IsWithParameter = bolIsWithParameter; //是否带参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.IsWithParameter) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.IsWithParameter, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.IsWithParameter] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetHyperLink(this clsFunctionMenuEN objFunctionMenuEN, string strHyperLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHyperLink, 200, conFunctionMenu.HyperLink);
}
objFunctionMenuEN.HyperLink = strHyperLink; //超链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.HyperLink) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.HyperLink, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.HyperLink] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetHyperLink4NoUser(this clsFunctionMenuEN objFunctionMenuEN, string strHyperLink4NoUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strHyperLink4NoUser, 200, conFunctionMenu.HyperLink4NoUser);
}
objFunctionMenuEN.HyperLink4NoUser = strHyperLink4NoUser; //超链接针对无用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.HyperLink4NoUser) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.HyperLink4NoUser, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.HyperLink4NoUser] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetSingleSignOnKey(this clsFunctionMenuEN objFunctionMenuEN, string strSingleSignOnKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSingleSignOnKey, 50, conFunctionMenu.SingleSignOnKey);
}
objFunctionMenuEN.SingleSignOnKey = strSingleSignOnKey; //单点登录关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.SingleSignOnKey) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.SingleSignOnKey, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.SingleSignOnKey] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetSchoolId(this clsFunctionMenuEN objFunctionMenuEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, conFunctionMenu.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, conFunctionMenu.SchoolId);
}
objFunctionMenuEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.SchoolId) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.SchoolId, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.SchoolId] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetUpdDate(this clsFunctionMenuEN objFunctionMenuEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionMenu.UpdDate);
}
objFunctionMenuEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.UpdDate) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.UpdDate, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.UpdDate] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetUpdUserId(this clsFunctionMenuEN objFunctionMenuEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conFunctionMenu.UpdUserId);
}
objFunctionMenuEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.UpdUserId) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.UpdUserId, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.UpdUserId] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionMenuEN SetMemo(this clsFunctionMenuEN objFunctionMenuEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionMenu.Memo);
}
objFunctionMenuEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.Memo) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.Memo, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.Memo] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionMenuEN objFunctionMenuEN)
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionMenuBL.FunctionMenuDA.UpdateBySql2(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionMenuEN objFunctionMenuEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionMenuBL.FunctionMenuDA.UpdateBySql2(objFunctionMenuEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionMenuEN objFunctionMenuEN, string strWhereCond)
{
try
{
bool bolResult = clsFunctionMenuBL.FunctionMenuDA.UpdateBySqlWithCondition(objFunctionMenuEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionMenuEN objFunctionMenuEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunctionMenuBL.FunctionMenuDA.UpdateBySqlWithConditionTransaction(objFunctionMenuEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFunctionMenuEN objFunctionMenuEN)
{
try
{
int intRecNum = clsFunctionMenuBL.FunctionMenuDA.DelRecord(objFunctionMenuEN.FunctionMenuId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuENS">源对象</param>
 /// <param name = "objFunctionMenuENT">目标对象</param>
 public static void CopyTo(this clsFunctionMenuEN objFunctionMenuENS, clsFunctionMenuEN objFunctionMenuENT)
{
try
{
objFunctionMenuENT.FunctionMenuId = objFunctionMenuENS.FunctionMenuId; //功能菜单ID
objFunctionMenuENT.FunctionName = objFunctionMenuENS.FunctionName; //函数名
objFunctionMenuENT.TitleName = objFunctionMenuENS.TitleName; //功能菜单标题
objFunctionMenuENT.IsVisible = objFunctionMenuENS.IsVisible; //是否显示
objFunctionMenuENT.DispPageMode = objFunctionMenuENS.DispPageMode; //显示页面方式
objFunctionMenuENT.IsTransUserBySingleSignOn = objFunctionMenuENS.IsTransUserBySingleSignOn; //是否单点登录传用户信息
objFunctionMenuENT.IsWithParameter = objFunctionMenuENS.IsWithParameter; //是否带参数
objFunctionMenuENT.HyperLink = objFunctionMenuENS.HyperLink; //超链接
objFunctionMenuENT.HyperLink4NoUser = objFunctionMenuENS.HyperLink4NoUser; //超链接针对无用户
objFunctionMenuENT.SingleSignOnKey = objFunctionMenuENS.SingleSignOnKey; //单点登录关键字
objFunctionMenuENT.SchoolId = objFunctionMenuENS.SchoolId; //学校编号
objFunctionMenuENT.UpdDate = objFunctionMenuENS.UpdDate; //修改日期
objFunctionMenuENT.UpdUserId = objFunctionMenuENS.UpdUserId; //修改用户Id
objFunctionMenuENT.Memo = objFunctionMenuENS.Memo; //备注
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
 /// <param name = "objFunctionMenuENS">源对象</param>
 /// <returns>目标对象=>clsFunctionMenuEN:objFunctionMenuENT</returns>
 public static clsFunctionMenuEN CopyTo(this clsFunctionMenuEN objFunctionMenuENS)
{
try
{
 clsFunctionMenuEN objFunctionMenuENT = new clsFunctionMenuEN()
{
FunctionMenuId = objFunctionMenuENS.FunctionMenuId, //功能菜单ID
FunctionName = objFunctionMenuENS.FunctionName, //函数名
TitleName = objFunctionMenuENS.TitleName, //功能菜单标题
IsVisible = objFunctionMenuENS.IsVisible, //是否显示
DispPageMode = objFunctionMenuENS.DispPageMode, //显示页面方式
IsTransUserBySingleSignOn = objFunctionMenuENS.IsTransUserBySingleSignOn, //是否单点登录传用户信息
IsWithParameter = objFunctionMenuENS.IsWithParameter, //是否带参数
HyperLink = objFunctionMenuENS.HyperLink, //超链接
HyperLink4NoUser = objFunctionMenuENS.HyperLink4NoUser, //超链接针对无用户
SingleSignOnKey = objFunctionMenuENS.SingleSignOnKey, //单点登录关键字
SchoolId = objFunctionMenuENS.SchoolId, //学校编号
UpdDate = objFunctionMenuENS.UpdDate, //修改日期
UpdUserId = objFunctionMenuENS.UpdUserId, //修改用户Id
Memo = objFunctionMenuENS.Memo, //备注
};
 return objFunctionMenuENT;
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
public static void CheckPropertyNew(this clsFunctionMenuEN objFunctionMenuEN)
{
 clsFunctionMenuBL.FunctionMenuDA.CheckPropertyNew(objFunctionMenuEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunctionMenuEN objFunctionMenuEN)
{
 clsFunctionMenuBL.FunctionMenuDA.CheckProperty4Condition(objFunctionMenuEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionMenuEN objFunctionMenuCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.FunctionMenuId) == true)
{
string strComparisonOpFunctionMenuId = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.FunctionMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.FunctionMenuId, objFunctionMenuCond.FunctionMenuId, strComparisonOpFunctionMenuId);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.FunctionName) == true)
{
string strComparisonOpFunctionName = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.FunctionName, objFunctionMenuCond.FunctionName, strComparisonOpFunctionName);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.TitleName) == true)
{
string strComparisonOpTitleName = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.TitleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.TitleName, objFunctionMenuCond.TitleName, strComparisonOpTitleName);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.IsVisible) == true)
{
if (objFunctionMenuCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionMenu.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionMenu.IsVisible);
}
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.DispPageMode) == true)
{
string strComparisonOpDispPageMode = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.DispPageMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.DispPageMode, objFunctionMenuCond.DispPageMode, strComparisonOpDispPageMode);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.IsTransUserBySingleSignOn) == true)
{
if (objFunctionMenuCond.IsTransUserBySingleSignOn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionMenu.IsTransUserBySingleSignOn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionMenu.IsTransUserBySingleSignOn);
}
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.IsWithParameter) == true)
{
if (objFunctionMenuCond.IsWithParameter == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionMenu.IsWithParameter);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionMenu.IsWithParameter);
}
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.HyperLink) == true)
{
string strComparisonOpHyperLink = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.HyperLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.HyperLink, objFunctionMenuCond.HyperLink, strComparisonOpHyperLink);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.HyperLink4NoUser) == true)
{
string strComparisonOpHyperLink4NoUser = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.HyperLink4NoUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.HyperLink4NoUser, objFunctionMenuCond.HyperLink4NoUser, strComparisonOpHyperLink4NoUser);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.SingleSignOnKey) == true)
{
string strComparisonOpSingleSignOnKey = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.SingleSignOnKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.SingleSignOnKey, objFunctionMenuCond.SingleSignOnKey, strComparisonOpSingleSignOnKey);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.SchoolId) == true)
{
string strComparisonOpSchoolId = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.SchoolId, objFunctionMenuCond.SchoolId, strComparisonOpSchoolId);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.UpdDate, objFunctionMenuCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.UpdUserId, objFunctionMenuCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objFunctionMenuCond.IsUpdated(conFunctionMenu.Memo) == true)
{
string strComparisonOpMemo = objFunctionMenuCond.dicFldComparisonOp[conFunctionMenu.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.Memo, objFunctionMenuCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FunctionMenu
{
public virtual bool UpdRelaTabDate(string strFunctionMenuId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 功能菜单(FunctionMenu)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunctionMenuBL
{
public static RelatedActions_FunctionMenu relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunctionMenuDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunctionMenuDA FunctionMenuDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunctionMenuDA();
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
 public clsFunctionMenuBL()
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
if (string.IsNullOrEmpty(clsFunctionMenuEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionMenuEN._ConnectString);
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
public static DataTable GetDataTable_FunctionMenu(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FunctionMenuDA.GetDataTable_FunctionMenu(strWhereCond);
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
objDT = FunctionMenuDA.GetDataTable(strWhereCond);
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
objDT = FunctionMenuDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FunctionMenuDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FunctionMenuDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FunctionMenuDA.GetDataTable_Top(objTopPara);
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
objDT = FunctionMenuDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FunctionMenuDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FunctionMenuDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFunctionMenuIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLstByFunctionMenuIdLst(List<string> arrFunctionMenuIdLst)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFunctionMenuIdLst, true);
 string strWhereCond = string.Format("FunctionMenuId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFunctionMenuIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunctionMenuEN> GetObjLstByFunctionMenuIdLstCache(List<string> arrFunctionMenuIdLst)
{
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName);
List<clsFunctionMenuEN> arrFunctionMenuObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionMenuEN> arrFunctionMenuObjLst_Sel =
arrFunctionMenuObjLstCache
.Where(x => arrFunctionMenuIdLst.Contains(x.FunctionMenuId));
return arrFunctionMenuObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLst(string strWhereCond)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
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
public static List<clsFunctionMenuEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunctionMenuCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunctionMenuEN> GetSubObjLstCache(clsFunctionMenuEN objFunctionMenuCond)
{
List<clsFunctionMenuEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionMenuEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionMenu.AttributeName)
{
if (objFunctionMenuCond.IsUpdated(strFldName) == false) continue;
if (objFunctionMenuCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionMenuCond[strFldName].ToString());
}
else
{
if (objFunctionMenuCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionMenuCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionMenuCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionMenuCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionMenuCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionMenuCond[strFldName]));
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
public static List<clsFunctionMenuEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
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
public static List<clsFunctionMenuEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
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
List<clsFunctionMenuEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunctionMenuEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionMenuEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunctionMenuEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
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
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
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
public static List<clsFunctionMenuEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunctionMenuEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
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
public static List<clsFunctionMenuEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunctionMenuEN> arrObjLst = new List<clsFunctionMenuEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionMenuEN objFunctionMenuEN = new clsFunctionMenuEN();
try
{
objFunctionMenuEN.FunctionMenuId = objRow[conFunctionMenu.FunctionMenuId].ToString().Trim(); //功能菜单ID
objFunctionMenuEN.FunctionName = objRow[conFunctionMenu.FunctionName] == DBNull.Value ? null : objRow[conFunctionMenu.FunctionName].ToString().Trim(); //函数名
objFunctionMenuEN.TitleName = objRow[conFunctionMenu.TitleName] == DBNull.Value ? null : objRow[conFunctionMenu.TitleName].ToString().Trim(); //功能菜单标题
objFunctionMenuEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsVisible].ToString().Trim()); //是否显示
objFunctionMenuEN.DispPageMode = objRow[conFunctionMenu.DispPageMode] == DBNull.Value ? null : objRow[conFunctionMenu.DispPageMode].ToString().Trim(); //显示页面方式
objFunctionMenuEN.IsTransUserBySingleSignOn = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsTransUserBySingleSignOn].ToString().Trim()); //是否单点登录传用户信息
objFunctionMenuEN.IsWithParameter = clsEntityBase2.TransNullToBool_S(objRow[conFunctionMenu.IsWithParameter].ToString().Trim()); //是否带参数
objFunctionMenuEN.HyperLink = objRow[conFunctionMenu.HyperLink] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink].ToString().Trim(); //超链接
objFunctionMenuEN.HyperLink4NoUser = objRow[conFunctionMenu.HyperLink4NoUser] == DBNull.Value ? null : objRow[conFunctionMenu.HyperLink4NoUser].ToString().Trim(); //超链接针对无用户
objFunctionMenuEN.SingleSignOnKey = objRow[conFunctionMenu.SingleSignOnKey] == DBNull.Value ? null : objRow[conFunctionMenu.SingleSignOnKey].ToString().Trim(); //单点登录关键字
objFunctionMenuEN.SchoolId = objRow[conFunctionMenu.SchoolId].ToString().Trim(); //学校编号
objFunctionMenuEN.UpdDate = objRow[conFunctionMenu.UpdDate] == DBNull.Value ? null : objRow[conFunctionMenu.UpdDate].ToString().Trim(); //修改日期
objFunctionMenuEN.UpdUserId = objRow[conFunctionMenu.UpdUserId] == DBNull.Value ? null : objRow[conFunctionMenu.UpdUserId].ToString().Trim(); //修改用户Id
objFunctionMenuEN.Memo = objRow[conFunctionMenu.Memo] == DBNull.Value ? null : objRow[conFunctionMenu.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionMenuEN.FunctionMenuId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionMenuEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunctionMenuEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunctionMenu(ref clsFunctionMenuEN objFunctionMenuEN)
{
bool bolResult = FunctionMenuDA.GetFunctionMenu(ref objFunctionMenuEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFunctionMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionMenuEN GetObjByFunctionMenuId(string strFunctionMenuId)
{
if (strFunctionMenuId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFunctionMenuId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFunctionMenuId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFunctionMenuId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFunctionMenuEN objFunctionMenuEN = FunctionMenuDA.GetObjByFunctionMenuId(strFunctionMenuId);
return objFunctionMenuEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunctionMenuEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunctionMenuEN objFunctionMenuEN = FunctionMenuDA.GetFirstObj(strWhereCond);
 return objFunctionMenuEN;
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
public static clsFunctionMenuEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunctionMenuEN objFunctionMenuEN = FunctionMenuDA.GetObjByDataRow(objRow);
 return objFunctionMenuEN;
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
public static clsFunctionMenuEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunctionMenuEN objFunctionMenuEN = FunctionMenuDA.GetObjByDataRow(objRow);
 return objFunctionMenuEN;
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
 /// <param name = "strFunctionMenuId">所给的关键字</param>
 /// <param name = "lstFunctionMenuObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionMenuEN GetObjByFunctionMenuIdFromList(string strFunctionMenuId, List<clsFunctionMenuEN> lstFunctionMenuObjLst)
{
foreach (clsFunctionMenuEN objFunctionMenuEN in lstFunctionMenuObjLst)
{
if (objFunctionMenuEN.FunctionMenuId == strFunctionMenuId)
{
return objFunctionMenuEN;
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
 string strMaxFunctionMenuId;
 try
 {
 strMaxFunctionMenuId = clsFunctionMenuDA.GetMaxStrId();
 return strMaxFunctionMenuId;
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
 string strFunctionMenuId;
 try
 {
 strFunctionMenuId = new clsFunctionMenuDA().GetFirstID(strWhereCond);
 return strFunctionMenuId;
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
 arrList = FunctionMenuDA.GetID(strWhereCond);
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
bool bolIsExist = FunctionMenuDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFunctionMenuId)
{
if (string.IsNullOrEmpty(strFunctionMenuId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFunctionMenuId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FunctionMenuDA.IsExist(strFunctionMenuId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFunctionMenuId">功能菜单ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFunctionMenuId, string strOpUser)
{
clsFunctionMenuEN objFunctionMenuEN = clsFunctionMenuBL.GetObjByFunctionMenuId(strFunctionMenuId);
objFunctionMenuEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFunctionMenuEN.UpdUserId = strOpUser;
return clsFunctionMenuBL.UpdateBySql2(objFunctionMenuEN);
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
 bolIsExist = clsFunctionMenuDA.IsExistTable();
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
 bolIsExist = FunctionMenuDA.IsExistTable(strTabName);
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunctionMenuEN objFunctionMenuEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true || clsFunctionMenuBL.IsExist(objFunctionMenuEN.FunctionMenuId) == true)
 {
     objFunctionMenuEN.FunctionMenuId = clsFunctionMenuBL.GetMaxStrId_S();
 }
bool bolResult = FunctionMenuDA.AddNewRecordBySQL2(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunctionMenuEN objFunctionMenuEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true || clsFunctionMenuBL.IsExist(objFunctionMenuEN.FunctionMenuId) == true)
 {
     objFunctionMenuEN.FunctionMenuId = clsFunctionMenuBL.GetMaxStrId_S();
 }
string strKey = FunctionMenuDA.AddNewRecordBySQL2WithReturnKey(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunctionMenuEN objFunctionMenuEN)
{
try
{
bool bolResult = FunctionMenuDA.Update(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunctionMenuEN objFunctionMenuEN)
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FunctionMenuDA.UpdateBySql2(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuBL.ReFreshCache();

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
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
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFunctionMenuId)
{
try
{
 clsFunctionMenuEN objFunctionMenuEN = clsFunctionMenuBL.GetObjByFunctionMenuId(strFunctionMenuId);

if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(objFunctionMenuEN.FunctionMenuId, objFunctionMenuEN.UpdUserId);
}
if (objFunctionMenuEN != null)
{
int intRecNum = FunctionMenuDA.DelRecord(strFunctionMenuId);
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
/// <param name="strFunctionMenuId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFunctionMenuId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
//删除与表:[FunctionMenu]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunctionMenu.FunctionMenuId,
//strFunctionMenuId);
//        clsFunctionMenuBL.DelFunctionMenusByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionMenuBL.DelRecord(strFunctionMenuId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionMenuBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFunctionMenuId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFunctionMenuId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFunctionMenuId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFunctionMenuBL.relatedActions != null)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(strFunctionMenuId, "UpdRelaTabDate");
}
bool bolResult = FunctionMenuDA.DelRecord(strFunctionMenuId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFunctionMenuIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFunctionMenus(List<string> arrFunctionMenuIdLst)
{
if (arrFunctionMenuIdLst.Count == 0) return 0;
try
{
if (clsFunctionMenuBL.relatedActions != null)
{
foreach (var strFunctionMenuId in arrFunctionMenuIdLst)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(strFunctionMenuId, "UpdRelaTabDate");
}
}
int intDelRecNum = FunctionMenuDA.DelFunctionMenu(arrFunctionMenuIdLst);
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
public static int DelFunctionMenusByCond(string strWhereCond)
{
try
{
if (clsFunctionMenuBL.relatedActions != null)
{
List<string> arrFunctionMenuId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFunctionMenuId in arrFunctionMenuId)
{
clsFunctionMenuBL.relatedActions.UpdRelaTabDate(strFunctionMenuId, "UpdRelaTabDate");
}
}
int intRecNum = FunctionMenuDA.DelFunctionMenu(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FunctionMenu]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFunctionMenuId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFunctionMenuId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionMenuDA.GetSpecSQLObj();
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
//删除与表:[FunctionMenu]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionMenuBL.DelRecord(strFunctionMenuId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionMenuBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFunctionMenuId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFunctionMenuENS">源对象</param>
 /// <param name = "objFunctionMenuENT">目标对象</param>
 public static void CopyTo(clsFunctionMenuEN objFunctionMenuENS, clsFunctionMenuEN objFunctionMenuENT)
{
try
{
objFunctionMenuENT.FunctionMenuId = objFunctionMenuENS.FunctionMenuId; //功能菜单ID
objFunctionMenuENT.FunctionName = objFunctionMenuENS.FunctionName; //函数名
objFunctionMenuENT.TitleName = objFunctionMenuENS.TitleName; //功能菜单标题
objFunctionMenuENT.IsVisible = objFunctionMenuENS.IsVisible; //是否显示
objFunctionMenuENT.DispPageMode = objFunctionMenuENS.DispPageMode; //显示页面方式
objFunctionMenuENT.IsTransUserBySingleSignOn = objFunctionMenuENS.IsTransUserBySingleSignOn; //是否单点登录传用户信息
objFunctionMenuENT.IsWithParameter = objFunctionMenuENS.IsWithParameter; //是否带参数
objFunctionMenuENT.HyperLink = objFunctionMenuENS.HyperLink; //超链接
objFunctionMenuENT.HyperLink4NoUser = objFunctionMenuENS.HyperLink4NoUser; //超链接针对无用户
objFunctionMenuENT.SingleSignOnKey = objFunctionMenuENS.SingleSignOnKey; //单点登录关键字
objFunctionMenuENT.SchoolId = objFunctionMenuENS.SchoolId; //学校编号
objFunctionMenuENT.UpdDate = objFunctionMenuENS.UpdDate; //修改日期
objFunctionMenuENT.UpdUserId = objFunctionMenuENS.UpdUserId; //修改用户Id
objFunctionMenuENT.Memo = objFunctionMenuENS.Memo; //备注
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
 /// <param name = "objFunctionMenuEN">源简化对象</param>
 public static void SetUpdFlag(clsFunctionMenuEN objFunctionMenuEN)
{
try
{
objFunctionMenuEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunctionMenuEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunctionMenu.FunctionMenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.FunctionMenuId = objFunctionMenuEN.FunctionMenuId; //功能菜单ID
}
if (arrFldSet.Contains(conFunctionMenu.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.FunctionName = objFunctionMenuEN.FunctionName == "[null]" ? null :  objFunctionMenuEN.FunctionName; //函数名
}
if (arrFldSet.Contains(conFunctionMenu.TitleName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.TitleName = objFunctionMenuEN.TitleName == "[null]" ? null :  objFunctionMenuEN.TitleName; //功能菜单标题
}
if (arrFldSet.Contains(conFunctionMenu.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.IsVisible = objFunctionMenuEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conFunctionMenu.DispPageMode, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.DispPageMode = objFunctionMenuEN.DispPageMode == "[null]" ? null :  objFunctionMenuEN.DispPageMode; //显示页面方式
}
if (arrFldSet.Contains(conFunctionMenu.IsTransUserBySingleSignOn, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.IsTransUserBySingleSignOn = objFunctionMenuEN.IsTransUserBySingleSignOn; //是否单点登录传用户信息
}
if (arrFldSet.Contains(conFunctionMenu.IsWithParameter, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.IsWithParameter = objFunctionMenuEN.IsWithParameter; //是否带参数
}
if (arrFldSet.Contains(conFunctionMenu.HyperLink, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.HyperLink = objFunctionMenuEN.HyperLink == "[null]" ? null :  objFunctionMenuEN.HyperLink; //超链接
}
if (arrFldSet.Contains(conFunctionMenu.HyperLink4NoUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.HyperLink4NoUser = objFunctionMenuEN.HyperLink4NoUser == "[null]" ? null :  objFunctionMenuEN.HyperLink4NoUser; //超链接针对无用户
}
if (arrFldSet.Contains(conFunctionMenu.SingleSignOnKey, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.SingleSignOnKey = objFunctionMenuEN.SingleSignOnKey == "[null]" ? null :  objFunctionMenuEN.SingleSignOnKey; //单点登录关键字
}
if (arrFldSet.Contains(conFunctionMenu.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.SchoolId = objFunctionMenuEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(conFunctionMenu.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.UpdDate = objFunctionMenuEN.UpdDate == "[null]" ? null :  objFunctionMenuEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFunctionMenu.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.UpdUserId = objFunctionMenuEN.UpdUserId == "[null]" ? null :  objFunctionMenuEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conFunctionMenu.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionMenuEN.Memo = objFunctionMenuEN.Memo == "[null]" ? null :  objFunctionMenuEN.Memo; //备注
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
 /// <param name = "objFunctionMenuEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunctionMenuEN objFunctionMenuEN)
{
try
{
if (objFunctionMenuEN.FunctionName == "[null]") objFunctionMenuEN.FunctionName = null; //函数名
if (objFunctionMenuEN.TitleName == "[null]") objFunctionMenuEN.TitleName = null; //功能菜单标题
if (objFunctionMenuEN.DispPageMode == "[null]") objFunctionMenuEN.DispPageMode = null; //显示页面方式
if (objFunctionMenuEN.HyperLink == "[null]") objFunctionMenuEN.HyperLink = null; //超链接
if (objFunctionMenuEN.HyperLink4NoUser == "[null]") objFunctionMenuEN.HyperLink4NoUser = null; //超链接针对无用户
if (objFunctionMenuEN.SingleSignOnKey == "[null]") objFunctionMenuEN.SingleSignOnKey = null; //单点登录关键字
if (objFunctionMenuEN.UpdDate == "[null]") objFunctionMenuEN.UpdDate = null; //修改日期
if (objFunctionMenuEN.UpdUserId == "[null]") objFunctionMenuEN.UpdUserId = null; //修改用户Id
if (objFunctionMenuEN.Memo == "[null]") objFunctionMenuEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsFunctionMenuEN objFunctionMenuEN)
{
 FunctionMenuDA.CheckPropertyNew(objFunctionMenuEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunctionMenuEN objFunctionMenuEN)
{
 FunctionMenuDA.CheckProperty4Condition(objFunctionMenuEN);
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
if (clsFunctionMenuBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionMenuBL没有刷新缓存机制(clsFunctionMenuBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FunctionMenuId");
//if (arrFunctionMenuObjLstCache == null)
//{
//arrFunctionMenuObjLstCache = FunctionMenuDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFunctionMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionMenuEN GetObjByFunctionMenuIdCache(string strFunctionMenuId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName);
List<clsFunctionMenuEN> arrFunctionMenuObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionMenuEN> arrFunctionMenuObjLst_Sel =
arrFunctionMenuObjLstCache
.Where(x=> x.FunctionMenuId == strFunctionMenuId 
);
if (arrFunctionMenuObjLst_Sel.Count() == 0)
{
   clsFunctionMenuEN obj = clsFunctionMenuBL.GetObjByFunctionMenuId(strFunctionMenuId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunctionMenuObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionMenuEN> GetAllFunctionMenuObjLstCache()
{
//获取缓存中的对象列表
List<clsFunctionMenuEN> arrFunctionMenuObjLstCache = GetObjLstCache(); 
return arrFunctionMenuObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName);
List<clsFunctionMenuEN> arrFunctionMenuObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionMenuObjLstCache;
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
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName);
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
if (clsFunctionMenuBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionMenuBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strFunctionMenuId)
{
if (strInFldName != conFunctionMenu.FunctionMenuId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunctionMenu.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunctionMenu.AttributeName));
throw new Exception(strMsg);
}
var objFunctionMenu = clsFunctionMenuBL.GetObjByFunctionMenuIdCache(strFunctionMenuId);
if (objFunctionMenu == null) return "";
return objFunctionMenu[strOutFldName].ToString();
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
int intRecCount = clsFunctionMenuDA.GetRecCount(strTabName);
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
int intRecCount = clsFunctionMenuDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunctionMenuDA.GetRecCount();
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
int intRecCount = clsFunctionMenuDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunctionMenuCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunctionMenuEN objFunctionMenuCond)
{
List<clsFunctionMenuEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionMenuEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionMenu.AttributeName)
{
if (objFunctionMenuCond.IsUpdated(strFldName) == false) continue;
if (objFunctionMenuCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionMenuCond[strFldName].ToString());
}
else
{
if (objFunctionMenuCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionMenuCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionMenuCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionMenuCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionMenuCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionMenuCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionMenuCond[strFldName]));
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
 List<string> arrList = clsFunctionMenuDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FunctionMenuDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FunctionMenuDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FunctionMenuDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionMenuDA.SetFldValue(clsFunctionMenuEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FunctionMenuDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionMenuDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionMenuDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionMenuDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FunctionMenu] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能菜单ID*/ 
 strCreateTabCode.Append(" FunctionMenuId char(4) primary key, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FunctionName varchar(100) Null, "); 
 // /**功能菜单标题*/ 
 strCreateTabCode.Append(" TitleName varchar(200) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**显示页面方式*/ 
 strCreateTabCode.Append(" DispPageMode varchar(50) Null, "); 
 // /**是否单点登录传用户信息*/ 
 strCreateTabCode.Append(" IsTransUserBySingleSignOn bit Null, "); 
 // /**是否带参数*/ 
 strCreateTabCode.Append(" IsWithParameter bit Null, "); 
 // /**超链接*/ 
 strCreateTabCode.Append(" HyperLink varchar(200) Null, "); 
 // /**超链接针对无用户*/ 
 strCreateTabCode.Append(" HyperLink4NoUser varchar(200) Null, "); 
 // /**单点登录关键字*/ 
 strCreateTabCode.Append(" SingleSignOnKey varchar(50) Null, "); 
 // /**学校编号*/ 
 strCreateTabCode.Append(" SchoolId varchar(10) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 功能菜单(FunctionMenu)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FunctionMenu : clsCommFun4BL
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
clsFunctionMenuBL.ReFreshThisCache();
}
}

}