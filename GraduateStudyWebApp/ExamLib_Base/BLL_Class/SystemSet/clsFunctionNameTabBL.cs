
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionNameTabBL
 表名:FunctionNameTab(01120204)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:09:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
public static class  clsFunctionNameTabBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionNameTabEN GetObj(this K_FunctionId_FunctionNameTab myKey)
{
clsFunctionNameTabEN objFunctionNameTabEN = clsFunctionNameTabBL.FunctionNameTabDA.GetObjByFunctionId(myKey.Value);
return objFunctionNameTabEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true || clsFunctionNameTabBL.IsExist(objFunctionNameTabEN.FunctionId) == true)
 {
     objFunctionNameTabEN.FunctionId = clsFunctionNameTabBL.GetMaxStrId_S();
 }
bool bolResult = clsFunctionNameTabBL.FunctionNameTabDA.AddNewRecordBySQL2(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
public static bool AddRecordEx(this clsFunctionNameTabEN objFunctionNameTabEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsFunctionNameTabBL.IsExist(objFunctionNameTabEN.FunctionId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objFunctionNameTabEN.CheckPropertyNew();
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true || clsFunctionNameTabBL.IsExist(objFunctionNameTabEN.FunctionId) == true)
 {
     objFunctionNameTabEN.FunctionId = clsFunctionNameTabBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objFunctionNameTabEN.AddNewRecord();
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true || clsFunctionNameTabBL.IsExist(objFunctionNameTabEN.FunctionId) == true)
 {
     objFunctionNameTabEN.FunctionId = clsFunctionNameTabBL.GetMaxStrId_S();
 }
string strFunctionId = clsFunctionNameTabBL.FunctionNameTabDA.AddNewRecordBySQL2WithReturnKey(objFunctionNameTabEN);
     objFunctionNameTabEN.FunctionId = strFunctionId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
}
return strFunctionId;
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true || clsFunctionNameTabBL.IsExist(objFunctionNameTabEN.FunctionId) == true)
 {
     objFunctionNameTabEN.FunctionId = clsFunctionNameTabBL.GetMaxStrId_S();
 }
string strKey = clsFunctionNameTabBL.FunctionNameTabDA.AddNewRecordBySQL2WithReturnKey(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetFunctionId(this clsFunctionNameTabEN objFunctionNameTabEN, string strFunctionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionId, 4, conFunctionNameTab.FunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionId, 4, conFunctionNameTab.FunctionId);
}
objFunctionNameTabEN.FunctionId = strFunctionId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.FunctionId) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.FunctionId, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.FunctionId] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetFunctionName(this clsFunctionNameTabEN objFunctionNameTabEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionName, conFunctionNameTab.FunctionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionName, 100, conFunctionNameTab.FunctionName);
}
objFunctionNameTabEN.FunctionName = strFunctionName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.FunctionName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.FunctionName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.FunctionName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetFunctionNameCH(this clsFunctionNameTabEN objFunctionNameTabEN, string strFunctionNameCH, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionNameCH, 255, conFunctionNameTab.FunctionNameCH);
}
objFunctionNameTabEN.FunctionNameCH = strFunctionNameCH; //功能中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.FunctionNameCH) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.FunctionNameCH, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.FunctionNameCH] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetModuleName(this clsFunctionNameTabEN objFunctionNameTabEN, string strModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModuleName, 255, conFunctionNameTab.ModuleName);
}
objFunctionNameTabEN.ModuleName = strModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.ModuleName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.ModuleName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.ModuleName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetIsStudent(this clsFunctionNameTabEN objFunctionNameTabEN, bool bolIsStudent, string strComparisonOp="")
	{
objFunctionNameTabEN.IsStudent = bolIsStudent; //是否学生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.IsStudent) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.IsStudent, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.IsStudent] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetIsTeacher(this clsFunctionNameTabEN objFunctionNameTabEN, bool bolIsTeacher, string strComparisonOp="")
	{
objFunctionNameTabEN.IsTeacher = bolIsTeacher; //是否教师
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.IsTeacher) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.IsTeacher, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.IsTeacher] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetIsQuestion(this clsFunctionNameTabEN objFunctionNameTabEN, bool bolIsQuestion, string strComparisonOp="")
	{
objFunctionNameTabEN.IsQuestion = bolIsQuestion; //是否题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.IsQuestion) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.IsQuestion, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.IsQuestion] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetConstName(this clsFunctionNameTabEN objFunctionNameTabEN, string strConstName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConstName, 255, conFunctionNameTab.ConstName);
}
objFunctionNameTabEN.ConstName = strConstName; //常量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.ConstName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.ConstName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.ConstName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetPagePath(this clsFunctionNameTabEN objFunctionNameTabEN, string strPagePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPagePath, 50, conFunctionNameTab.PagePath);
}
objFunctionNameTabEN.PagePath = strPagePath; //页面路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.PagePath) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.PagePath, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.PagePath] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetPageName(this clsFunctionNameTabEN objFunctionNameTabEN, string strPageName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPageName, 100, conFunctionNameTab.PageName);
}
objFunctionNameTabEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.PageName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.PageName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.PageName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetOrderNum(this clsFunctionNameTabEN objFunctionNameTabEN, int? intOrderNum, string strComparisonOp="")
	{
objFunctionNameTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.OrderNum) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.OrderNum, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.OrderNum] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetUpdDate(this clsFunctionNameTabEN objFunctionNameTabEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionNameTab.UpdDate);
}
objFunctionNameTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.UpdDate) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.UpdDate, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.UpdDate] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetUpdUser(this clsFunctionNameTabEN objFunctionNameTabEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunctionNameTab.UpdUser);
}
objFunctionNameTabEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.UpdUser) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.UpdUser, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.UpdUser] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionNameTabEN SetMemo(this clsFunctionNameTabEN objFunctionNameTabEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionNameTab.Memo);
}
objFunctionNameTabEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.Memo) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.Memo, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.Memo] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionNameTabEN objFunctionNameTabEN)
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionNameTabBL.FunctionNameTabDA.UpdateBySql2(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionNameTabEN objFunctionNameTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionNameTabBL.FunctionNameTabDA.UpdateBySql2(objFunctionNameTabEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionNameTabEN objFunctionNameTabEN, string strWhereCond)
{
try
{
bool bolResult = clsFunctionNameTabBL.FunctionNameTabDA.UpdateBySqlWithCondition(objFunctionNameTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionNameTabEN objFunctionNameTabEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunctionNameTabBL.FunctionNameTabDA.UpdateBySqlWithConditionTransaction(objFunctionNameTabEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
int intRecNum = clsFunctionNameTabBL.FunctionNameTabDA.DelRecord(objFunctionNameTabEN.FunctionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabENS">源对象</param>
 /// <param name = "objFunctionNameTabENT">目标对象</param>
 public static void CopyTo(this clsFunctionNameTabEN objFunctionNameTabENS, clsFunctionNameTabEN objFunctionNameTabENT)
{
try
{
objFunctionNameTabENT.FunctionId = objFunctionNameTabENS.FunctionId; //功能Id
objFunctionNameTabENT.FunctionName = objFunctionNameTabENS.FunctionName; //函数名
objFunctionNameTabENT.FunctionNameCH = objFunctionNameTabENS.FunctionNameCH; //功能中文名
objFunctionNameTabENT.ModuleName = objFunctionNameTabENS.ModuleName; //模块名
objFunctionNameTabENT.IsStudent = objFunctionNameTabENS.IsStudent; //是否学生
objFunctionNameTabENT.IsTeacher = objFunctionNameTabENS.IsTeacher; //是否教师
objFunctionNameTabENT.IsQuestion = objFunctionNameTabENS.IsQuestion; //是否题目
objFunctionNameTabENT.ConstName = objFunctionNameTabENS.ConstName; //常量名
objFunctionNameTabENT.PagePath = objFunctionNameTabENS.PagePath; //页面路径
objFunctionNameTabENT.PageName = objFunctionNameTabENS.PageName; //页面名称
objFunctionNameTabENT.OrderNum = objFunctionNameTabENS.OrderNum; //序号
objFunctionNameTabENT.UpdDate = objFunctionNameTabENS.UpdDate; //修改日期
objFunctionNameTabENT.UpdUser = objFunctionNameTabENS.UpdUser; //修改人
objFunctionNameTabENT.Memo = objFunctionNameTabENS.Memo; //备注
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
 /// <param name = "objFunctionNameTabENS">源对象</param>
 /// <returns>目标对象=>clsFunctionNameTabEN:objFunctionNameTabENT</returns>
 public static clsFunctionNameTabEN CopyTo(this clsFunctionNameTabEN objFunctionNameTabENS)
{
try
{
 clsFunctionNameTabEN objFunctionNameTabENT = new clsFunctionNameTabEN()
{
FunctionId = objFunctionNameTabENS.FunctionId, //功能Id
FunctionName = objFunctionNameTabENS.FunctionName, //函数名
FunctionNameCH = objFunctionNameTabENS.FunctionNameCH, //功能中文名
ModuleName = objFunctionNameTabENS.ModuleName, //模块名
IsStudent = objFunctionNameTabENS.IsStudent, //是否学生
IsTeacher = objFunctionNameTabENS.IsTeacher, //是否教师
IsQuestion = objFunctionNameTabENS.IsQuestion, //是否题目
ConstName = objFunctionNameTabENS.ConstName, //常量名
PagePath = objFunctionNameTabENS.PagePath, //页面路径
PageName = objFunctionNameTabENS.PageName, //页面名称
OrderNum = objFunctionNameTabENS.OrderNum, //序号
UpdDate = objFunctionNameTabENS.UpdDate, //修改日期
UpdUser = objFunctionNameTabENS.UpdUser, //修改人
Memo = objFunctionNameTabENS.Memo, //备注
};
 return objFunctionNameTabENT;
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
public static void CheckPropertyNew(this clsFunctionNameTabEN objFunctionNameTabEN)
{
 clsFunctionNameTabBL.FunctionNameTabDA.CheckPropertyNew(objFunctionNameTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunctionNameTabEN objFunctionNameTabEN)
{
 clsFunctionNameTabBL.FunctionNameTabDA.CheckProperty4Condition(objFunctionNameTabEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionNameTabEN objFunctionNameTabCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.FunctionId) == true)
{
string strComparisonOpFunctionId = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.FunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.FunctionId, objFunctionNameTabCond.FunctionId, strComparisonOpFunctionId);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.FunctionName) == true)
{
string strComparisonOpFunctionName = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.FunctionName, objFunctionNameTabCond.FunctionName, strComparisonOpFunctionName);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.FunctionNameCH) == true)
{
string strComparisonOpFunctionNameCH = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.FunctionNameCH];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.FunctionNameCH, objFunctionNameTabCond.FunctionNameCH, strComparisonOpFunctionNameCH);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.ModuleName) == true)
{
string strComparisonOpModuleName = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.ModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.ModuleName, objFunctionNameTabCond.ModuleName, strComparisonOpModuleName);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.IsStudent) == true)
{
if (objFunctionNameTabCond.IsStudent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionNameTab.IsStudent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionNameTab.IsStudent);
}
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.IsTeacher) == true)
{
if (objFunctionNameTabCond.IsTeacher == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionNameTab.IsTeacher);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionNameTab.IsTeacher);
}
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.IsQuestion) == true)
{
if (objFunctionNameTabCond.IsQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionNameTab.IsQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionNameTab.IsQuestion);
}
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.ConstName) == true)
{
string strComparisonOpConstName = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.ConstName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.ConstName, objFunctionNameTabCond.ConstName, strComparisonOpConstName);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.PagePath) == true)
{
string strComparisonOpPagePath = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.PagePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.PagePath, objFunctionNameTabCond.PagePath, strComparisonOpPagePath);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.PageName) == true)
{
string strComparisonOpPageName = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.PageName, objFunctionNameTabCond.PageName, strComparisonOpPageName);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.OrderNum) == true)
{
string strComparisonOpOrderNum = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFunctionNameTab.OrderNum, objFunctionNameTabCond.OrderNum, strComparisonOpOrderNum);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.UpdDate, objFunctionNameTabCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.UpdUser, objFunctionNameTabCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunctionNameTabCond.IsUpdated(conFunctionNameTab.Memo) == true)
{
string strComparisonOpMemo = objFunctionNameTabCond.dicFldComparisonOp[conFunctionNameTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.Memo, objFunctionNameTabCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FunctionNameTab
{
public virtual bool UpdRelaTabDate(string strFunctionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数名表(FunctionNameTab)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunctionNameTabBL
{
public static RelatedActions_FunctionNameTab relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunctionNameTabDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunctionNameTabDA FunctionNameTabDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunctionNameTabDA();
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
 public clsFunctionNameTabBL()
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
if (string.IsNullOrEmpty(clsFunctionNameTabEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionNameTabEN._ConnectString);
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
public static DataTable GetDataTable_FunctionNameTab(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FunctionNameTabDA.GetDataTable_FunctionNameTab(strWhereCond);
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
objDT = FunctionNameTabDA.GetDataTable(strWhereCond);
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
objDT = FunctionNameTabDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FunctionNameTabDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FunctionNameTabDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FunctionNameTabDA.GetDataTable_Top(objTopPara);
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
objDT = FunctionNameTabDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FunctionNameTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FunctionNameTabDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLstByFunctionIdLst(List<string> arrFunctionIdLst)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFunctionIdLst, true);
 string strWhereCond = string.Format("FunctionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFunctionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunctionNameTabEN> GetObjLstByFunctionIdLstCache(List<string> arrFunctionIdLst)
{
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel =
arrFunctionNameTabObjLstCache
.Where(x => arrFunctionIdLst.Contains(x.FunctionId));
return arrFunctionNameTabObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLst(string strWhereCond)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
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
public static List<clsFunctionNameTabEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunctionNameTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunctionNameTabEN> GetSubObjLstCache(clsFunctionNameTabEN objFunctionNameTabCond)
{
List<clsFunctionNameTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionNameTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionNameTab.AttributeName)
{
if (objFunctionNameTabCond.IsUpdated(strFldName) == false) continue;
if (objFunctionNameTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionNameTabCond[strFldName].ToString());
}
else
{
if (objFunctionNameTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionNameTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionNameTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionNameTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionNameTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionNameTabCond[strFldName]));
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
public static List<clsFunctionNameTabEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
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
public static List<clsFunctionNameTabEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
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
List<clsFunctionNameTabEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunctionNameTabEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionNameTabEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunctionNameTabEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
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
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
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
public static List<clsFunctionNameTabEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunctionNameTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
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
public static List<clsFunctionNameTabEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunctionNameTabEN> arrObjLst = new List<clsFunctionNameTabEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN();
try
{
objFunctionNameTabEN.FunctionId = objRow[conFunctionNameTab.FunctionId].ToString().Trim(); //功能Id
objFunctionNameTabEN.FunctionName = objRow[conFunctionNameTab.FunctionName].ToString().Trim(); //函数名
objFunctionNameTabEN.FunctionNameCH = objRow[conFunctionNameTab.FunctionNameCH] == DBNull.Value ? null : objRow[conFunctionNameTab.FunctionNameCH].ToString().Trim(); //功能中文名
objFunctionNameTabEN.ModuleName = objRow[conFunctionNameTab.ModuleName] == DBNull.Value ? null : objRow[conFunctionNameTab.ModuleName].ToString().Trim(); //模块名
objFunctionNameTabEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsStudent].ToString().Trim()); //是否学生
objFunctionNameTabEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsTeacher].ToString().Trim()); //是否教师
objFunctionNameTabEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[conFunctionNameTab.IsQuestion].ToString().Trim()); //是否题目
objFunctionNameTabEN.ConstName = objRow[conFunctionNameTab.ConstName] == DBNull.Value ? null : objRow[conFunctionNameTab.ConstName].ToString().Trim(); //常量名
objFunctionNameTabEN.PagePath = objRow[conFunctionNameTab.PagePath] == DBNull.Value ? null : objRow[conFunctionNameTab.PagePath].ToString().Trim(); //页面路径
objFunctionNameTabEN.PageName = objRow[conFunctionNameTab.PageName] == DBNull.Value ? null : objRow[conFunctionNameTab.PageName].ToString().Trim(); //页面名称
objFunctionNameTabEN.OrderNum = objRow[conFunctionNameTab.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunctionNameTab.OrderNum].ToString().Trim()); //序号
objFunctionNameTabEN.UpdDate = objRow[conFunctionNameTab.UpdDate] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdDate].ToString().Trim(); //修改日期
objFunctionNameTabEN.UpdUser = objRow[conFunctionNameTab.UpdUser] == DBNull.Value ? null : objRow[conFunctionNameTab.UpdUser].ToString().Trim(); //修改人
objFunctionNameTabEN.Memo = objRow[conFunctionNameTab.Memo] == DBNull.Value ? null : objRow[conFunctionNameTab.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionNameTabEN.FunctionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionNameTabEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunctionNameTab(ref clsFunctionNameTabEN objFunctionNameTabEN)
{
bool bolResult = FunctionNameTabDA.GetFunctionNameTab(ref objFunctionNameTabEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionNameTabEN GetObjByFunctionId(string strFunctionId)
{
if (strFunctionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFunctionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFunctionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsFunctionNameTabEN objFunctionNameTabEN = FunctionNameTabDA.GetObjByFunctionId(strFunctionId);
return objFunctionNameTabEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunctionNameTabEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunctionNameTabEN objFunctionNameTabEN = FunctionNameTabDA.GetFirstObj(strWhereCond);
 return objFunctionNameTabEN;
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
public static clsFunctionNameTabEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunctionNameTabEN objFunctionNameTabEN = FunctionNameTabDA.GetObjByDataRow(objRow);
 return objFunctionNameTabEN;
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
public static clsFunctionNameTabEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunctionNameTabEN objFunctionNameTabEN = FunctionNameTabDA.GetObjByDataRow(objRow);
 return objFunctionNameTabEN;
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
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <param name = "lstFunctionNameTabObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionNameTabEN GetObjByFunctionIdFromList(string strFunctionId, List<clsFunctionNameTabEN> lstFunctionNameTabObjLst)
{
foreach (clsFunctionNameTabEN objFunctionNameTabEN in lstFunctionNameTabObjLst)
{
if (objFunctionNameTabEN.FunctionId == strFunctionId)
{
return objFunctionNameTabEN;
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
 string strMaxFunctionId;
 try
 {
 strMaxFunctionId = clsFunctionNameTabDA.GetMaxStrId();
 return strMaxFunctionId;
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
 string strFunctionId;
 try
 {
 strFunctionId = new clsFunctionNameTabDA().GetFirstID(strWhereCond);
 return strFunctionId;
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
 arrList = FunctionNameTabDA.GetID(strWhereCond);
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
bool bolIsExist = FunctionNameTabDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFunctionId)
{
if (string.IsNullOrEmpty(strFunctionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFunctionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = FunctionNameTabDA.IsExist(strFunctionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strFunctionId">功能Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strFunctionId, string strOpUser)
{
clsFunctionNameTabEN objFunctionNameTabEN = clsFunctionNameTabBL.GetObjByFunctionId(strFunctionId);
objFunctionNameTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFunctionNameTabEN.UpdUser = strOpUser;
return clsFunctionNameTabBL.UpdateBySql2(objFunctionNameTabEN);
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
 bolIsExist = clsFunctionNameTabDA.IsExistTable();
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
 bolIsExist = FunctionNameTabDA.IsExistTable(strTabName);
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true || clsFunctionNameTabBL.IsExist(objFunctionNameTabEN.FunctionId) == true)
 {
     objFunctionNameTabEN.FunctionId = clsFunctionNameTabBL.GetMaxStrId_S();
 }
bool bolResult = FunctionNameTabDA.AddNewRecordBySQL2(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true || clsFunctionNameTabBL.IsExist(objFunctionNameTabEN.FunctionId) == true)
 {
     objFunctionNameTabEN.FunctionId = clsFunctionNameTabBL.GetMaxStrId_S();
 }
string strKey = FunctionNameTabDA.AddNewRecordBySQL2WithReturnKey(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
bool bolResult = FunctionNameTabDA.Update(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunctionNameTabEN objFunctionNameTabEN)
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FunctionNameTabDA.UpdateBySql2(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabBL.ReFreshCache();

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
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
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strFunctionId)
{
try
{
 clsFunctionNameTabEN objFunctionNameTabEN = clsFunctionNameTabBL.GetObjByFunctionId(strFunctionId);

if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(objFunctionNameTabEN.FunctionId, objFunctionNameTabEN.UpdUser);
}
if (objFunctionNameTabEN != null)
{
int intRecNum = FunctionNameTabDA.DelRecord(strFunctionId);
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
/// <param name="strFunctionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strFunctionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
//删除与表:[FunctionNameTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunctionNameTab.FunctionId,
//strFunctionId);
//        clsFunctionNameTabBL.DelFunctionNameTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionNameTabBL.DelRecord(strFunctionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionNameTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFunctionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strFunctionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strFunctionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsFunctionNameTabBL.relatedActions != null)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(strFunctionId, "UpdRelaTabDate");
}
bool bolResult = FunctionNameTabDA.DelRecord(strFunctionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrFunctionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelFunctionNameTabs(List<string> arrFunctionIdLst)
{
if (arrFunctionIdLst.Count == 0) return 0;
try
{
if (clsFunctionNameTabBL.relatedActions != null)
{
foreach (var strFunctionId in arrFunctionIdLst)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(strFunctionId, "UpdRelaTabDate");
}
}
int intDelRecNum = FunctionNameTabDA.DelFunctionNameTab(arrFunctionIdLst);
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
public static int DelFunctionNameTabsByCond(string strWhereCond)
{
try
{
if (clsFunctionNameTabBL.relatedActions != null)
{
List<string> arrFunctionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strFunctionId in arrFunctionId)
{
clsFunctionNameTabBL.relatedActions.UpdRelaTabDate(strFunctionId, "UpdRelaTabDate");
}
}
int intRecNum = FunctionNameTabDA.DelFunctionNameTab(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FunctionNameTab]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strFunctionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strFunctionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionNameTabDA.GetSpecSQLObj();
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
//删除与表:[FunctionNameTab]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionNameTabBL.DelRecord(strFunctionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionNameTabBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strFunctionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objFunctionNameTabENS">源对象</param>
 /// <param name = "objFunctionNameTabENT">目标对象</param>
 public static void CopyTo(clsFunctionNameTabEN objFunctionNameTabENS, clsFunctionNameTabEN objFunctionNameTabENT)
{
try
{
objFunctionNameTabENT.FunctionId = objFunctionNameTabENS.FunctionId; //功能Id
objFunctionNameTabENT.FunctionName = objFunctionNameTabENS.FunctionName; //函数名
objFunctionNameTabENT.FunctionNameCH = objFunctionNameTabENS.FunctionNameCH; //功能中文名
objFunctionNameTabENT.ModuleName = objFunctionNameTabENS.ModuleName; //模块名
objFunctionNameTabENT.IsStudent = objFunctionNameTabENS.IsStudent; //是否学生
objFunctionNameTabENT.IsTeacher = objFunctionNameTabENS.IsTeacher; //是否教师
objFunctionNameTabENT.IsQuestion = objFunctionNameTabENS.IsQuestion; //是否题目
objFunctionNameTabENT.ConstName = objFunctionNameTabENS.ConstName; //常量名
objFunctionNameTabENT.PagePath = objFunctionNameTabENS.PagePath; //页面路径
objFunctionNameTabENT.PageName = objFunctionNameTabENS.PageName; //页面名称
objFunctionNameTabENT.OrderNum = objFunctionNameTabENS.OrderNum; //序号
objFunctionNameTabENT.UpdDate = objFunctionNameTabENS.UpdDate; //修改日期
objFunctionNameTabENT.UpdUser = objFunctionNameTabENS.UpdUser; //修改人
objFunctionNameTabENT.Memo = objFunctionNameTabENS.Memo; //备注
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
 /// <param name = "objFunctionNameTabEN">源简化对象</param>
 public static void SetUpdFlag(clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
objFunctionNameTabEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunctionNameTabEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunctionNameTab.FunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.FunctionId = objFunctionNameTabEN.FunctionId; //功能Id
}
if (arrFldSet.Contains(conFunctionNameTab.FunctionName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.FunctionName = objFunctionNameTabEN.FunctionName; //函数名
}
if (arrFldSet.Contains(conFunctionNameTab.FunctionNameCH, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.FunctionNameCH = objFunctionNameTabEN.FunctionNameCH == "[null]" ? null :  objFunctionNameTabEN.FunctionNameCH; //功能中文名
}
if (arrFldSet.Contains(conFunctionNameTab.ModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.ModuleName = objFunctionNameTabEN.ModuleName == "[null]" ? null :  objFunctionNameTabEN.ModuleName; //模块名
}
if (arrFldSet.Contains(conFunctionNameTab.IsStudent, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.IsStudent = objFunctionNameTabEN.IsStudent; //是否学生
}
if (arrFldSet.Contains(conFunctionNameTab.IsTeacher, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.IsTeacher = objFunctionNameTabEN.IsTeacher; //是否教师
}
if (arrFldSet.Contains(conFunctionNameTab.IsQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.IsQuestion = objFunctionNameTabEN.IsQuestion; //是否题目
}
if (arrFldSet.Contains(conFunctionNameTab.ConstName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.ConstName = objFunctionNameTabEN.ConstName == "[null]" ? null :  objFunctionNameTabEN.ConstName; //常量名
}
if (arrFldSet.Contains(conFunctionNameTab.PagePath, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.PagePath = objFunctionNameTabEN.PagePath == "[null]" ? null :  objFunctionNameTabEN.PagePath; //页面路径
}
if (arrFldSet.Contains(conFunctionNameTab.PageName, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.PageName = objFunctionNameTabEN.PageName == "[null]" ? null :  objFunctionNameTabEN.PageName; //页面名称
}
if (arrFldSet.Contains(conFunctionNameTab.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.OrderNum = objFunctionNameTabEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFunctionNameTab.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.UpdDate = objFunctionNameTabEN.UpdDate == "[null]" ? null :  objFunctionNameTabEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFunctionNameTab.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.UpdUser = objFunctionNameTabEN.UpdUser == "[null]" ? null :  objFunctionNameTabEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conFunctionNameTab.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionNameTabEN.Memo = objFunctionNameTabEN.Memo == "[null]" ? null :  objFunctionNameTabEN.Memo; //备注
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
 /// <param name = "objFunctionNameTabEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
if (objFunctionNameTabEN.FunctionNameCH == "[null]") objFunctionNameTabEN.FunctionNameCH = null; //功能中文名
if (objFunctionNameTabEN.ModuleName == "[null]") objFunctionNameTabEN.ModuleName = null; //模块名
if (objFunctionNameTabEN.ConstName == "[null]") objFunctionNameTabEN.ConstName = null; //常量名
if (objFunctionNameTabEN.PagePath == "[null]") objFunctionNameTabEN.PagePath = null; //页面路径
if (objFunctionNameTabEN.PageName == "[null]") objFunctionNameTabEN.PageName = null; //页面名称
if (objFunctionNameTabEN.UpdDate == "[null]") objFunctionNameTabEN.UpdDate = null; //修改日期
if (objFunctionNameTabEN.UpdUser == "[null]") objFunctionNameTabEN.UpdUser = null; //修改人
if (objFunctionNameTabEN.Memo == "[null]") objFunctionNameTabEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsFunctionNameTabEN objFunctionNameTabEN)
{
 FunctionNameTabDA.CheckPropertyNew(objFunctionNameTabEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunctionNameTabEN objFunctionNameTabEN)
{
 FunctionNameTabDA.CheckProperty4Condition(objFunctionNameTabEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunctionNameTab.FunctionId); 
List<clsFunctionNameTabEN> arrObjLst = clsFunctionNameTabBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN()
{
FunctionId = "0",
FunctionName = "选[函数名表]..."
};
arrObjLst.Insert(0, objFunctionNameTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunctionNameTab.FunctionId;
objComboBox.DisplayMember = conFunctionNameTab.FunctionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FunctionId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数名表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conFunctionNameTab.FunctionId); 
IEnumerable<clsFunctionNameTabEN> arrObjLst = clsFunctionNameTabBL.GetObjLst(strCondition);
objDDL.DataValueField = conFunctionNameTab.FunctionId;
objDDL.DataTextField = conFunctionNameTab.FunctionName;
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
public static void BindDdl_FunctionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数名表]...","0");
List<clsFunctionNameTabEN> arrFunctionNameTabObjLst = GetAllFunctionNameTabObjLstCache(); 
objDDL.DataValueField = conFunctionNameTab.FunctionId;
objDDL.DataTextField = conFunctionNameTab.FunctionName;
objDDL.DataSource = arrFunctionNameTabObjLst;
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
if (clsFunctionNameTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionNameTabBL没有刷新缓存机制(clsFunctionNameTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FunctionId");
//if (arrFunctionNameTabObjLstCache == null)
//{
//arrFunctionNameTabObjLstCache = FunctionNameTabDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionNameTabEN GetObjByFunctionIdCache(string strFunctionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel =
arrFunctionNameTabObjLstCache
.Where(x=> x.FunctionId == strFunctionId 
);
if (arrFunctionNameTabObjLst_Sel.Count() == 0)
{
   clsFunctionNameTabEN obj = clsFunctionNameTabBL.GetObjByFunctionId(strFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunctionNameTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionNameByFunctionIdCache(string strFunctionId)
{
if (string.IsNullOrEmpty(strFunctionId) == true) return "";
//获取缓存中的对象列表
clsFunctionNameTabEN objFunctionNameTab = GetObjByFunctionIdCache(strFunctionId);
if (objFunctionNameTab == null) return "";
return objFunctionNameTab.FunctionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFunctionIdCache(string strFunctionId)
{
if (string.IsNullOrEmpty(strFunctionId) == true) return "";
//获取缓存中的对象列表
clsFunctionNameTabEN objFunctionNameTab = GetObjByFunctionIdCache(strFunctionId);
if (objFunctionNameTab == null) return "";
return objFunctionNameTab.FunctionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionNameTabEN> GetAllFunctionNameTabObjLstCache()
{
//获取缓存中的对象列表
List<clsFunctionNameTabEN> arrFunctionNameTabObjLstCache = GetObjLstCache(); 
return arrFunctionNameTabObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionNameTabObjLstCache;
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
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName);
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
if (clsFunctionNameTabBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionNameTabBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strFunctionId)
{
if (strInFldName != conFunctionNameTab.FunctionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunctionNameTab.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunctionNameTab.AttributeName));
throw new Exception(strMsg);
}
var objFunctionNameTab = clsFunctionNameTabBL.GetObjByFunctionIdCache(strFunctionId);
if (objFunctionNameTab == null) return "";
return objFunctionNameTab[strOutFldName].ToString();
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
int intRecCount = clsFunctionNameTabDA.GetRecCount(strTabName);
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
int intRecCount = clsFunctionNameTabDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunctionNameTabDA.GetRecCount();
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
int intRecCount = clsFunctionNameTabDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunctionNameTabCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunctionNameTabEN objFunctionNameTabCond)
{
List<clsFunctionNameTabEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionNameTabEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionNameTab.AttributeName)
{
if (objFunctionNameTabCond.IsUpdated(strFldName) == false) continue;
if (objFunctionNameTabCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionNameTabCond[strFldName].ToString());
}
else
{
if (objFunctionNameTabCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionNameTabCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionNameTabCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionNameTabCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionNameTabCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionNameTabCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionNameTabCond[strFldName]));
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
 List<string> arrList = clsFunctionNameTabDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FunctionNameTabDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FunctionNameTabDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FunctionNameTabDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionNameTabDA.SetFldValue(clsFunctionNameTabEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FunctionNameTabDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionNameTabDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionNameTabDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionNameTabDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FunctionNameTab] "); 
 strCreateTabCode.Append(" ( "); 
 // /**功能Id*/ 
 strCreateTabCode.Append(" FunctionId char(4) primary key, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FunctionName varchar(100) not Null, "); 
 // /**功能中文名*/ 
 strCreateTabCode.Append(" FunctionNameCH varchar(255) Null, "); 
 // /**模块名*/ 
 strCreateTabCode.Append(" ModuleName varchar(255) Null, "); 
 // /**是否学生*/ 
 strCreateTabCode.Append(" IsStudent bit Null, "); 
 // /**是否教师*/ 
 strCreateTabCode.Append(" IsTeacher bit Null, "); 
 // /**是否题目*/ 
 strCreateTabCode.Append(" IsQuestion bit Null, "); 
 // /**常量名*/ 
 strCreateTabCode.Append(" ConstName varchar(255) Null, "); 
 // /**页面路径*/ 
 strCreateTabCode.Append(" PagePath varchar(50) Null, "); 
 // /**页面名称*/ 
 strCreateTabCode.Append(" PageName varchar(100) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 函数名表(FunctionNameTab)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FunctionNameTab : clsCommFun4BL
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
clsFunctionNameTabBL.ReFreshThisCache();
}
}

}