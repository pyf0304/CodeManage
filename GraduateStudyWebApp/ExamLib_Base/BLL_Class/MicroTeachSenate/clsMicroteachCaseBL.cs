
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseBL
 表名:MicroteachCase(01120322)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:28
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsMicroteachCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseEN GetObj(this K_IdMicroteachCase_MicroteachCase myKey)
{
clsMicroteachCaseEN objMicroteachCaseEN = clsMicroteachCaseBL.MicroteachCaseDA.GetObjByIdMicroteachCase(myKey.Value);
return objMicroteachCaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseBL.IsExist(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseEN.IdMicroteachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsMicroteachCaseBL.MicroteachCaseDA.AddNewRecordBySQL2(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
public static bool AddRecordEx(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsMicroteachCaseBL.IsExist(objMicroteachCaseEN.IdMicroteachCase))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objMicroteachCaseEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objMicroteachCaseEN.AddNewRecord();
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseBL.IsExist(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseEN.IdMicroteachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsMicroteachCaseBL.MicroteachCaseDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdMicroteachCase(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdMicroteachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, conMicroteachCase.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, conMicroteachCase.IdMicroteachCase);
}
objMicroteachCaseEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdMicroteachCase) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdMicroteachCase, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdMicroteachCase] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseID(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseID, conMicroteachCase.MicroteachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, conMicroteachCase.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, conMicroteachCase.MicroteachCaseID);
}
objMicroteachCaseEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseID) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseID, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseID] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseName(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseName, conMicroteachCase.MicroteachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, conMicroteachCase.MicroteachCaseName);
}
objMicroteachCaseEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseName) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseName, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseName] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseTheme(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTheme, 200, conMicroteachCase.MicroteachCaseTheme);
}
objMicroteachCaseEN.MicroteachCaseTheme = strMicroteachCaseTheme; //微格教学案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseTheme) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseTheme, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTheme] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseDate(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDate, 8, conMicroteachCase.MicroteachCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDate, 8, conMicroteachCase.MicroteachCaseDate);
}
objMicroteachCaseEN.MicroteachCaseDate = strMicroteachCaseDate; //微格教学日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseDate) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseDate, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDate] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseTime(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTime, 6, conMicroteachCase.MicroteachCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTime, 6, conMicroteachCase.MicroteachCaseTime);
}
objMicroteachCaseEN.MicroteachCaseTime = strMicroteachCaseTime; //微格教学时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseTime) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseTime, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTime] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroteachCaseDateIn(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroteachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseDateIn, 8, conMicroteachCase.MicroteachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseDateIn, 8, conMicroteachCase.MicroteachCaseDateIn);
}
objMicroteachCaseEN.MicroteachCaseDateIn = strMicroteachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroteachCaseDateIn) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroteachCaseDateIn, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDateIn] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdStudyLevel(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, conMicroteachCase.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conMicroteachCase.IdStudyLevel);
}
objMicroteachCaseEN.IdStudyLevel = strIdStudyLevel; //学段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdStudyLevel) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdStudyLevel, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdStudyLevel] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdTeachingPlan(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conMicroteachCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conMicroteachCase.IdTeachingPlan);
}
objMicroteachCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdTeachingPlan) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdTeachingPlan, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdTeachingPlan] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMicroTeachCaseTimeIn(this clsMicroteachCaseEN objMicroteachCaseEN, string strMicroTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroTeachCaseTimeIn, 6, conMicroteachCase.MicroTeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseTimeIn, 6, conMicroteachCase.MicroTeachCaseTimeIn);
}
objMicroteachCaseEN.MicroTeachCaseTimeIn = strMicroTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.MicroTeachCaseTimeIn) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.MicroTeachCaseTimeIn, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.MicroTeachCaseTimeIn] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdMicroteachCaseType(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdMicroteachCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCaseType, 4, conMicroteachCase.IdMicroteachCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCaseType, 4, conMicroteachCase.IdMicroteachCaseType);
}
objMicroteachCaseEN.IdMicroteachCaseType = strIdMicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdMicroteachCaseType) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdMicroteachCaseType, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdMicroteachCaseType] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdCaseType(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, conMicroteachCase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, conMicroteachCase.IdCaseType);
}
objMicroteachCaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdCaseType) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdCaseType, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdCaseType] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdDiscipline(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, conMicroteachCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, conMicroteachCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, conMicroteachCase.IdDiscipline);
}
objMicroteachCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdDiscipline) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdDiscipline, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdDiscipline] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetBrowseCount(this clsMicroteachCaseEN objMicroteachCaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objMicroteachCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.BrowseCount) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.BrowseCount, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.BrowseCount] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdSenateGaugeVersion(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, conMicroteachCase.IdSenateGaugeVersion);
}
objMicroteachCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdSenateGaugeVersion) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIdTeachSkill(this clsMicroteachCaseEN objMicroteachCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, conMicroteachCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, conMicroteachCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, conMicroteachCase.IdTeachSkill);
}
objMicroteachCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IdTeachSkill) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IdTeachSkill, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IdTeachSkill] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetCaseLevelId(this clsMicroteachCaseEN objMicroteachCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conMicroteachCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conMicroteachCase.CaseLevelId);
}
objMicroteachCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.CaseLevelId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.CaseLevelId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.CaseLevelId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetDocFile(this clsMicroteachCaseEN objMicroteachCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, conMicroteachCase.DocFile);
}
objMicroteachCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.DocFile) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.DocFile, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.DocFile] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIsNeedGeneWord(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objMicroteachCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IsNeedGeneWord) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetWordCreateDate(this clsMicroteachCaseEN objMicroteachCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conMicroteachCase.WordCreateDate);
}
objMicroteachCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.WordCreateDate) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.WordCreateDate, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.WordCreateDate] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIsVisible(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objMicroteachCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IsVisible) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IsVisible, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IsVisible] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetmicroteachCaseText(this clsMicroteachCaseEN objMicroteachCaseEN, string strmicroteachCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmicroteachCaseText, 8000, conMicroteachCase.microteachCaseText);
}
objMicroteachCaseEN.microteachCaseText = strmicroteachCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.microteachCaseText) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.microteachCaseText, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.microteachCaseText] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetOwnerId(this clsMicroteachCaseEN objMicroteachCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conMicroteachCase.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conMicroteachCase.OwnerId);
}
objMicroteachCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.OwnerId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.OwnerId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.OwnerId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetIsDualVideo(this clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objMicroteachCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.IsDualVideo) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.IsDualVideo, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.IsDualVideo] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetUserKindId(this clsMicroteachCaseEN objMicroteachCaseEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, conMicroteachCase.UserKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, conMicroteachCase.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, conMicroteachCase.UserKindId);
}
objMicroteachCaseEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UserKindId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UserKindId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UserKindId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetUserTypeId(this clsMicroteachCaseEN objMicroteachCaseEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conMicroteachCase.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conMicroteachCase.UserTypeId);
}
objMicroteachCaseEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UserTypeId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UserTypeId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UserTypeId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetRecommendedDegreeId(this clsMicroteachCaseEN objMicroteachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conMicroteachCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conMicroteachCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conMicroteachCase.RecommendedDegreeId);
}
objMicroteachCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.RecommendedDegreeId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetftpFileType(this clsMicroteachCaseEN objMicroteachCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conMicroteachCase.ftpFileType);
}
objMicroteachCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.ftpFileType) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.ftpFileType, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.ftpFileType] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetVideoUrl(this clsMicroteachCaseEN objMicroteachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conMicroteachCase.VideoUrl);
}
objMicroteachCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.VideoUrl) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.VideoUrl, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.VideoUrl] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetVideoPath(this clsMicroteachCaseEN objMicroteachCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conMicroteachCase.VideoPath);
}
objMicroteachCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.VideoPath) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.VideoPath, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.VideoPath] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetResErrMsg(this clsMicroteachCaseEN objMicroteachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conMicroteachCase.ResErrMsg);
}
objMicroteachCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.ResErrMsg) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.ResErrMsg, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.ResErrMsg] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetUpdDate(this clsMicroteachCaseEN objMicroteachCaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMicroteachCase.UpdDate);
}
objMicroteachCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UpdDate) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UpdDate, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UpdDate] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetUpdUserId(this clsMicroteachCaseEN objMicroteachCaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conMicroteachCase.UpdUserId);
}
objMicroteachCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.UpdUserId) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.UpdUserId, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.UpdUserId] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseEN SetMemo(this clsMicroteachCaseEN objMicroteachCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMicroteachCase.Memo);
}
objMicroteachCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseEN.dicFldComparisonOp.ContainsKey(conMicroteachCase.Memo) == false)
{
objMicroteachCaseEN.dicFldComparisonOp.Add(conMicroteachCase.Memo, strComparisonOp);
}
else
{
objMicroteachCaseEN.dicFldComparisonOp[conMicroteachCase.Memo] = strComparisonOp;
}
}
return objMicroteachCaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroteachCaseEN objMicroteachCaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroteachCaseEN.CheckPropertyNew();
clsMicroteachCaseEN objMicroteachCaseCond = new clsMicroteachCaseEN();
string strCondition = objMicroteachCaseCond
.SetIdMicroteachCase(objMicroteachCaseEN.IdMicroteachCase, "=")
.GetCombineCondition();
objMicroteachCaseEN._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroteachCaseEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseEN objMicroteachCaseEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseBL.MicroteachCaseDA.UpdateBySql2(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseEN objMicroteachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseBL.MicroteachCaseDA.UpdateBySql2(objMicroteachCaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseEN objMicroteachCaseEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroteachCaseBL.MicroteachCaseDA.UpdateBySqlWithCondition(objMicroteachCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseEN objMicroteachCaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroteachCaseBL.MicroteachCaseDA.UpdateBySqlWithConditionTransaction(objMicroteachCaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroteachCaseEN objMicroteachCaseEN)
{
try
{
int intRecNum = clsMicroteachCaseBL.MicroteachCaseDA.DelRecord(objMicroteachCaseEN.IdMicroteachCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <param name = "objMicroteachCaseENT">目标对象</param>
 public static void CopyTo(this clsMicroteachCaseEN objMicroteachCaseENS, clsMicroteachCaseEN objMicroteachCaseENT)
{
try
{
objMicroteachCaseENT.IdMicroteachCase = objMicroteachCaseENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCaseENT.MicroteachCaseID = objMicroteachCaseENS.MicroteachCaseID; //微格教学案例ID
objMicroteachCaseENT.MicroteachCaseName = objMicroteachCaseENS.MicroteachCaseName; //微格教学案例名称
objMicroteachCaseENT.MicroteachCaseTheme = objMicroteachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objMicroteachCaseENT.MicroteachCaseDate = objMicroteachCaseENS.MicroteachCaseDate; //微格教学日期
objMicroteachCaseENT.MicroteachCaseTime = objMicroteachCaseENS.MicroteachCaseTime; //微格教学时间
objMicroteachCaseENT.MicroteachCaseDateIn = objMicroteachCaseENS.MicroteachCaseDateIn; //案例入库日期
objMicroteachCaseENT.IdStudyLevel = objMicroteachCaseENS.IdStudyLevel; //学段流水号
objMicroteachCaseENT.IdTeachingPlan = objMicroteachCaseENS.IdTeachingPlan; //教案流水号
objMicroteachCaseENT.MicroTeachCaseTimeIn = objMicroteachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objMicroteachCaseENT.IdMicroteachCaseType = objMicroteachCaseENS.IdMicroteachCaseType; //微格案例类型流水号
objMicroteachCaseENT.IdCaseType = objMicroteachCaseENS.IdCaseType; //案例类型流水号
objMicroteachCaseENT.IdDiscipline = objMicroteachCaseENS.IdDiscipline; //学科流水号
objMicroteachCaseENT.BrowseCount = objMicroteachCaseENS.BrowseCount; //浏览次数
objMicroteachCaseENT.IdSenateGaugeVersion = objMicroteachCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objMicroteachCaseENT.IdTeachSkill = objMicroteachCaseENS.IdTeachSkill; //教学技能流水号
objMicroteachCaseENT.CaseLevelId = objMicroteachCaseENS.CaseLevelId; //课例等级Id
objMicroteachCaseENT.DocFile = objMicroteachCaseENS.DocFile; //生成的Word文件名
objMicroteachCaseENT.IsNeedGeneWord = objMicroteachCaseENS.IsNeedGeneWord; //是否需要生成Word
objMicroteachCaseENT.WordCreateDate = objMicroteachCaseENS.WordCreateDate; //Word生成日期
objMicroteachCaseENT.IsVisible = objMicroteachCaseENS.IsVisible; //是否显示
objMicroteachCaseENT.microteachCaseText = objMicroteachCaseENS.microteachCaseText; //案例文本内容
objMicroteachCaseENT.OwnerId = objMicroteachCaseENS.OwnerId; //拥有者Id
objMicroteachCaseENT.IsDualVideo = objMicroteachCaseENS.IsDualVideo; //是否双视频
objMicroteachCaseENT.UserKindId = objMicroteachCaseENS.UserKindId; //用户类别Id
objMicroteachCaseENT.UserTypeId = objMicroteachCaseENS.UserTypeId; //用户类型Id
objMicroteachCaseENT.RecommendedDegreeId = objMicroteachCaseENS.RecommendedDegreeId; //推荐度Id
objMicroteachCaseENT.ftpFileType = objMicroteachCaseENS.ftpFileType; //ftp文件类型
objMicroteachCaseENT.VideoUrl = objMicroteachCaseENS.VideoUrl; //视频Url
objMicroteachCaseENT.VideoPath = objMicroteachCaseENS.VideoPath; //视频目录
objMicroteachCaseENT.ResErrMsg = objMicroteachCaseENS.ResErrMsg; //资源错误信息
objMicroteachCaseENT.UpdDate = objMicroteachCaseENS.UpdDate; //修改日期
objMicroteachCaseENT.UpdUserId = objMicroteachCaseENS.UpdUserId; //修改用户Id
objMicroteachCaseENT.Memo = objMicroteachCaseENS.Memo; //备注
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
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCaseEN:objMicroteachCaseENT</returns>
 public static clsMicroteachCaseEN CopyTo(this clsMicroteachCaseEN objMicroteachCaseENS)
{
try
{
 clsMicroteachCaseEN objMicroteachCaseENT = new clsMicroteachCaseEN()
{
IdMicroteachCase = objMicroteachCaseENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objMicroteachCaseENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objMicroteachCaseENS.MicroteachCaseName, //微格教学案例名称
MicroteachCaseTheme = objMicroteachCaseENS.MicroteachCaseTheme, //微格教学案例主题词
MicroteachCaseDate = objMicroteachCaseENS.MicroteachCaseDate, //微格教学日期
MicroteachCaseTime = objMicroteachCaseENS.MicroteachCaseTime, //微格教学时间
MicroteachCaseDateIn = objMicroteachCaseENS.MicroteachCaseDateIn, //案例入库日期
IdStudyLevel = objMicroteachCaseENS.IdStudyLevel, //学段流水号
IdTeachingPlan = objMicroteachCaseENS.IdTeachingPlan, //教案流水号
MicroTeachCaseTimeIn = objMicroteachCaseENS.MicroTeachCaseTimeIn, //案例入库时间
IdMicroteachCaseType = objMicroteachCaseENS.IdMicroteachCaseType, //微格案例类型流水号
IdCaseType = objMicroteachCaseENS.IdCaseType, //案例类型流水号
IdDiscipline = objMicroteachCaseENS.IdDiscipline, //学科流水号
BrowseCount = objMicroteachCaseENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objMicroteachCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
IdTeachSkill = objMicroteachCaseENS.IdTeachSkill, //教学技能流水号
CaseLevelId = objMicroteachCaseENS.CaseLevelId, //课例等级Id
DocFile = objMicroteachCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objMicroteachCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objMicroteachCaseENS.WordCreateDate, //Word生成日期
IsVisible = objMicroteachCaseENS.IsVisible, //是否显示
microteachCaseText = objMicroteachCaseENS.microteachCaseText, //案例文本内容
OwnerId = objMicroteachCaseENS.OwnerId, //拥有者Id
IsDualVideo = objMicroteachCaseENS.IsDualVideo, //是否双视频
UserKindId = objMicroteachCaseENS.UserKindId, //用户类别Id
UserTypeId = objMicroteachCaseENS.UserTypeId, //用户类型Id
RecommendedDegreeId = objMicroteachCaseENS.RecommendedDegreeId, //推荐度Id
ftpFileType = objMicroteachCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objMicroteachCaseENS.VideoUrl, //视频Url
VideoPath = objMicroteachCaseENS.VideoPath, //视频目录
ResErrMsg = objMicroteachCaseENS.ResErrMsg, //资源错误信息
UpdDate = objMicroteachCaseENS.UpdDate, //修改日期
UpdUserId = objMicroteachCaseENS.UpdUserId, //修改用户Id
Memo = objMicroteachCaseENS.Memo, //备注
};
 return objMicroteachCaseENT;
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
public static void CheckPropertyNew(this clsMicroteachCaseEN objMicroteachCaseEN)
{
 clsMicroteachCaseBL.MicroteachCaseDA.CheckPropertyNew(objMicroteachCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroteachCaseEN objMicroteachCaseEN)
{
 clsMicroteachCaseBL.MicroteachCaseDA.CheckProperty4Condition(objMicroteachCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseEN objMicroteachCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdMicroteachCase, objMicroteachCaseCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseID, objMicroteachCaseCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseName, objMicroteachCaseCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.MicroteachCaseTheme) == true)
{
string strComparisonOpMicroteachCaseTheme = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseTheme, objMicroteachCaseCond.MicroteachCaseTheme, strComparisonOpMicroteachCaseTheme);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.MicroteachCaseDate) == true)
{
string strComparisonOpMicroteachCaseDate = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseDate, objMicroteachCaseCond.MicroteachCaseDate, strComparisonOpMicroteachCaseDate);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.MicroteachCaseTime) == true)
{
string strComparisonOpMicroteachCaseTime = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseTime, objMicroteachCaseCond.MicroteachCaseTime, strComparisonOpMicroteachCaseTime);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.MicroteachCaseDateIn) == true)
{
string strComparisonOpMicroteachCaseDateIn = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.MicroteachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroteachCaseDateIn, objMicroteachCaseCond.MicroteachCaseDateIn, strComparisonOpMicroteachCaseDateIn);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdStudyLevel, objMicroteachCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdTeachingPlan, objMicroteachCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.MicroTeachCaseTimeIn) == true)
{
string strComparisonOpMicroTeachCaseTimeIn = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.MicroTeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.MicroTeachCaseTimeIn, objMicroteachCaseCond.MicroTeachCaseTimeIn, strComparisonOpMicroTeachCaseTimeIn);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdMicroteachCaseType) == true)
{
string strComparisonOpIdMicroteachCaseType = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdMicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdMicroteachCaseType, objMicroteachCaseCond.IdMicroteachCaseType, strComparisonOpIdMicroteachCaseType);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdCaseType, objMicroteachCaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdDiscipline, objMicroteachCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCase.BrowseCount, objMicroteachCaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdSenateGaugeVersion, objMicroteachCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.IdTeachSkill, objMicroteachCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.CaseLevelId, objMicroteachCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.DocFile) == true)
{
string strComparisonOpDocFile = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.DocFile, objMicroteachCaseCond.DocFile, strComparisonOpDocFile);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IsNeedGeneWord) == true)
{
if (objMicroteachCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase.IsNeedGeneWord);
}
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.WordCreateDate, objMicroteachCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IsVisible) == true)
{
if (objMicroteachCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase.IsVisible);
}
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.microteachCaseText) == true)
{
string strComparisonOpmicroteachCaseText = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.microteachCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.microteachCaseText, objMicroteachCaseCond.microteachCaseText, strComparisonOpmicroteachCaseText);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.OwnerId, objMicroteachCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.IsDualVideo) == true)
{
if (objMicroteachCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCase.IsDualVideo);
}
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.UserKindId) == true)
{
string strComparisonOpUserKindId = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UserKindId, objMicroteachCaseCond.UserKindId, strComparisonOpUserKindId);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UserTypeId, objMicroteachCaseCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.RecommendedDegreeId, objMicroteachCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.ftpFileType, objMicroteachCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.VideoUrl, objMicroteachCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.VideoPath, objMicroteachCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.ResErrMsg, objMicroteachCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.UpdDate) == true)
{
string strComparisonOpUpdDate = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UpdDate, objMicroteachCaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.UpdUserId, objMicroteachCaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objMicroteachCaseCond.IsUpdated(conMicroteachCase.Memo) == true)
{
string strComparisonOpMemo = objMicroteachCaseCond.dicFldComparisonOp[conMicroteachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCase.Memo, objMicroteachCaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroteachCase
{
public virtual bool UpdRelaTabDate(string strIdMicroteachCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格教学案例(MicroteachCase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseBL
{
public static RelatedActions_MicroteachCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroteachCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroteachCaseDA MicroteachCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroteachCaseDA();
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
 public clsMicroteachCaseBL()
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
if (string.IsNullOrEmpty(clsMicroteachCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachCaseEN._ConnectString);
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
public static DataTable GetDataTable_MicroteachCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroteachCaseDA.GetDataTable_MicroteachCase(strWhereCond);
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
objDT = MicroteachCaseDA.GetDataTable(strWhereCond);
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
objDT = MicroteachCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroteachCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroteachCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroteachCaseDA.GetDataTable_Top(objTopPara);
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
objDT = MicroteachCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroteachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroteachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLstByIdMicroteachCaseLst(List<string> arrIdMicroteachCaseLst)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseLst, true);
 string strWhereCond = string.Format("IdMicroteachCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroteachCaseEN> GetObjLstByIdMicroteachCaseLstCache(List<string> arrIdMicroteachCaseLst)
{
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel =
arrMicroteachCaseObjLstCache
.Where(x => arrIdMicroteachCaseLst.Contains(x.IdMicroteachCase));
return arrMicroteachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLst(string strWhereCond)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
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
public static List<clsMicroteachCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroteachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroteachCaseEN> GetSubObjLstCache(clsMicroteachCaseEN objMicroteachCaseCond)
{
List<clsMicroteachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCase.AttributeName)
{
if (objMicroteachCaseCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseCond[strFldName]));
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
public static List<clsMicroteachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
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
public static List<clsMicroteachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
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
List<clsMicroteachCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroteachCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroteachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
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
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
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
public static List<clsMicroteachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroteachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
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
public static List<clsMicroteachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroteachCaseEN> arrObjLst = new List<clsMicroteachCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseEN objMicroteachCaseEN = new clsMicroteachCaseEN();
try
{
objMicroteachCaseEN.IdMicroteachCase = objRow[conMicroteachCase.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objMicroteachCaseEN.MicroteachCaseID = objRow[conMicroteachCase.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objMicroteachCaseEN.MicroteachCaseName = objRow[conMicroteachCase.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objMicroteachCaseEN.MicroteachCaseTheme = objRow[conMicroteachCase.MicroteachCaseTheme] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objMicroteachCaseEN.MicroteachCaseDate = objRow[conMicroteachCase.MicroteachCaseDate] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objMicroteachCaseEN.MicroteachCaseTime = objRow[conMicroteachCase.MicroteachCaseTime] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objMicroteachCaseEN.MicroteachCaseDateIn = objRow[conMicroteachCase.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objMicroteachCaseEN.IdStudyLevel = objRow[conMicroteachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objMicroteachCaseEN.IdTeachingPlan = objRow[conMicroteachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conMicroteachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objMicroteachCaseEN.MicroTeachCaseTimeIn = objRow[conMicroteachCase.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[conMicroteachCase.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objMicroteachCaseEN.IdMicroteachCaseType = objRow[conMicroteachCase.IdMicroteachCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseEN.IdCaseType = objRow[conMicroteachCase.IdCaseType] == DBNull.Value ? null : objRow[conMicroteachCase.IdCaseType].ToString().Trim(); //案例类型流水号
objMicroteachCaseEN.IdDiscipline = objRow[conMicroteachCase.IdDiscipline].ToString().Trim(); //学科流水号
objMicroteachCaseEN.BrowseCount = objRow[conMicroteachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conMicroteachCase.BrowseCount].ToString().Trim()); //浏览次数
objMicroteachCaseEN.IdSenateGaugeVersion = objRow[conMicroteachCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conMicroteachCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objMicroteachCaseEN.IdTeachSkill = objRow[conMicroteachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objMicroteachCaseEN.CaseLevelId = objRow[conMicroteachCase.CaseLevelId] == DBNull.Value ? null : objRow[conMicroteachCase.CaseLevelId].ToString().Trim(); //课例等级Id
objMicroteachCaseEN.DocFile = objRow[conMicroteachCase.DocFile] == DBNull.Value ? null : objRow[conMicroteachCase.DocFile].ToString().Trim(); //生成的Word文件名
objMicroteachCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objMicroteachCaseEN.WordCreateDate = objRow[conMicroteachCase.WordCreateDate] == DBNull.Value ? null : objRow[conMicroteachCase.WordCreateDate].ToString().Trim(); //Word生成日期
objMicroteachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsVisible].ToString().Trim()); //是否显示
objMicroteachCaseEN.microteachCaseText = objRow[conMicroteachCase.microteachCaseText] == DBNull.Value ? null : objRow[conMicroteachCase.microteachCaseText].ToString().Trim(); //案例文本内容
objMicroteachCaseEN.OwnerId = objRow[conMicroteachCase.OwnerId].ToString().Trim(); //拥有者Id
objMicroteachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conMicroteachCase.IsDualVideo].ToString().Trim()); //是否双视频
objMicroteachCaseEN.UserKindId = objRow[conMicroteachCase.UserKindId].ToString().Trim(); //用户类别Id
objMicroteachCaseEN.UserTypeId = objRow[conMicroteachCase.UserTypeId] == DBNull.Value ? null : objRow[conMicroteachCase.UserTypeId].ToString().Trim(); //用户类型Id
objMicroteachCaseEN.RecommendedDegreeId = objRow[conMicroteachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objMicroteachCaseEN.ftpFileType = objRow[conMicroteachCase.ftpFileType] == DBNull.Value ? null : objRow[conMicroteachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objMicroteachCaseEN.VideoUrl = objRow[conMicroteachCase.VideoUrl] == DBNull.Value ? null : objRow[conMicroteachCase.VideoUrl].ToString().Trim(); //视频Url
objMicroteachCaseEN.VideoPath = objRow[conMicroteachCase.VideoPath] == DBNull.Value ? null : objRow[conMicroteachCase.VideoPath].ToString().Trim(); //视频目录
objMicroteachCaseEN.ResErrMsg = objRow[conMicroteachCase.ResErrMsg] == DBNull.Value ? null : objRow[conMicroteachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objMicroteachCaseEN.UpdDate = objRow[conMicroteachCase.UpdDate] == DBNull.Value ? null : objRow[conMicroteachCase.UpdDate].ToString().Trim(); //修改日期
objMicroteachCaseEN.UpdUserId = objRow[conMicroteachCase.UpdUserId] == DBNull.Value ? null : objRow[conMicroteachCase.UpdUserId].ToString().Trim(); //修改用户Id
objMicroteachCaseEN.Memo = objRow[conMicroteachCase.Memo] == DBNull.Value ? null : objRow[conMicroteachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseEN.IdMicroteachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroteachCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroteachCase(ref clsMicroteachCaseEN objMicroteachCaseEN)
{
bool bolResult = MicroteachCaseDA.GetMicroteachCase(ref objMicroteachCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
if (strIdMicroteachCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdMicroteachCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdMicroteachCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsMicroteachCaseEN objMicroteachCaseEN = MicroteachCaseDA.GetObjByIdMicroteachCase(strIdMicroteachCase);
return objMicroteachCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroteachCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroteachCaseEN objMicroteachCaseEN = MicroteachCaseDA.GetFirstObj(strWhereCond);
 return objMicroteachCaseEN;
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
public static clsMicroteachCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroteachCaseEN objMicroteachCaseEN = MicroteachCaseDA.GetObjByDataRow(objRow);
 return objMicroteachCaseEN;
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
public static clsMicroteachCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroteachCaseEN objMicroteachCaseEN = MicroteachCaseDA.GetObjByDataRow(objRow);
 return objMicroteachCaseEN;
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
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <param name = "lstMicroteachCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseEN GetObjByIdMicroteachCaseFromList(string strIdMicroteachCase, List<clsMicroteachCaseEN> lstMicroteachCaseObjLst)
{
foreach (clsMicroteachCaseEN objMicroteachCaseEN in lstMicroteachCaseObjLst)
{
if (objMicroteachCaseEN.IdMicroteachCase == strIdMicroteachCase)
{
return objMicroteachCaseEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdMicroteachCase;
 try
 {
 strIdMicroteachCase = new clsMicroteachCaseDA().GetFirstID(strWhereCond);
 return strIdMicroteachCase;
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
 arrList = MicroteachCaseDA.GetID(strWhereCond);
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
bool bolIsExist = MicroteachCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdMicroteachCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = MicroteachCaseDA.IsExist(strIdMicroteachCase);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdMicroteachCase">微格教学案例流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdMicroteachCase, string strOpUser)
{
clsMicroteachCaseEN objMicroteachCaseEN = clsMicroteachCaseBL.GetObjByIdMicroteachCase(strIdMicroteachCase);
objMicroteachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objMicroteachCaseEN.UpdUserId = strOpUser;
return clsMicroteachCaseBL.UpdateBySql2(objMicroteachCaseEN);
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
 bolIsExist = clsMicroteachCaseDA.IsExistTable();
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
 bolIsExist = MicroteachCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseBL.IsExist(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseEN.IdMicroteachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = MicroteachCaseDA.AddNewRecordBySQL2(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroteachCaseEN objMicroteachCaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseBL.IsExist(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseEN.IdMicroteachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = MicroteachCaseDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroteachCaseEN objMicroteachCaseEN)
{
try
{
bool bolResult = MicroteachCaseDA.Update(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "objMicroteachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroteachCaseEN objMicroteachCaseEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseEN.IdMicroteachCase) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroteachCaseDA.UpdateBySql2(objMicroteachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseBL.ReFreshCache();

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdMicroteachCase)
{
try
{
 clsMicroteachCaseEN objMicroteachCaseEN = clsMicroteachCaseBL.GetObjByIdMicroteachCase(strIdMicroteachCase);

if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(objMicroteachCaseEN.IdMicroteachCase, objMicroteachCaseEN.UpdUserId);
}
if (objMicroteachCaseEN != null)
{
int intRecNum = MicroteachCaseDA.DelRecord(strIdMicroteachCase);
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
/// <param name="strIdMicroteachCase">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdMicroteachCase )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroteachCase.IdMicroteachCase,
//strIdMicroteachCase);
//        clsMicroteachCaseBL.DelMicroteachCasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseBL.DelRecord(strIdMicroteachCase, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdMicroteachCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdMicroteachCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroteachCaseBL.relatedActions != null)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(strIdMicroteachCase, "UpdRelaTabDate");
}
bool bolResult = MicroteachCaseDA.DelRecord(strIdMicroteachCase,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdMicroteachCaseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroteachCases(List<string> arrIdMicroteachCaseLst)
{
if (arrIdMicroteachCaseLst.Count == 0) return 0;
try
{
if (clsMicroteachCaseBL.relatedActions != null)
{
foreach (var strIdMicroteachCase in arrIdMicroteachCaseLst)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(strIdMicroteachCase, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroteachCaseDA.DelMicroteachCase(arrIdMicroteachCaseLst);
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
public static int DelMicroteachCasesByCond(string strWhereCond)
{
try
{
if (clsMicroteachCaseBL.relatedActions != null)
{
List<string> arrIdMicroteachCase = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdMicroteachCase in arrIdMicroteachCase)
{
clsMicroteachCaseBL.relatedActions.UpdRelaTabDate(strIdMicroteachCase, "UpdRelaTabDate");
}
}
int intRecNum = MicroteachCaseDA.DelMicroteachCase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroteachCase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdMicroteachCase">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdMicroteachCase)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseBL.DelRecord(strIdMicroteachCase, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdMicroteachCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroteachCaseENS">源对象</param>
 /// <param name = "objMicroteachCaseENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseEN objMicroteachCaseENS, clsMicroteachCaseEN objMicroteachCaseENT)
{
try
{
objMicroteachCaseENT.IdMicroteachCase = objMicroteachCaseENS.IdMicroteachCase; //微格教学案例流水号
objMicroteachCaseENT.MicroteachCaseID = objMicroteachCaseENS.MicroteachCaseID; //微格教学案例ID
objMicroteachCaseENT.MicroteachCaseName = objMicroteachCaseENS.MicroteachCaseName; //微格教学案例名称
objMicroteachCaseENT.MicroteachCaseTheme = objMicroteachCaseENS.MicroteachCaseTheme; //微格教学案例主题词
objMicroteachCaseENT.MicroteachCaseDate = objMicroteachCaseENS.MicroteachCaseDate; //微格教学日期
objMicroteachCaseENT.MicroteachCaseTime = objMicroteachCaseENS.MicroteachCaseTime; //微格教学时间
objMicroteachCaseENT.MicroteachCaseDateIn = objMicroteachCaseENS.MicroteachCaseDateIn; //案例入库日期
objMicroteachCaseENT.IdStudyLevel = objMicroteachCaseENS.IdStudyLevel; //学段流水号
objMicroteachCaseENT.IdTeachingPlan = objMicroteachCaseENS.IdTeachingPlan; //教案流水号
objMicroteachCaseENT.MicroTeachCaseTimeIn = objMicroteachCaseENS.MicroTeachCaseTimeIn; //案例入库时间
objMicroteachCaseENT.IdMicroteachCaseType = objMicroteachCaseENS.IdMicroteachCaseType; //微格案例类型流水号
objMicroteachCaseENT.IdCaseType = objMicroteachCaseENS.IdCaseType; //案例类型流水号
objMicroteachCaseENT.IdDiscipline = objMicroteachCaseENS.IdDiscipline; //学科流水号
objMicroteachCaseENT.BrowseCount = objMicroteachCaseENS.BrowseCount; //浏览次数
objMicroteachCaseENT.IdSenateGaugeVersion = objMicroteachCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objMicroteachCaseENT.IdTeachSkill = objMicroteachCaseENS.IdTeachSkill; //教学技能流水号
objMicroteachCaseENT.CaseLevelId = objMicroteachCaseENS.CaseLevelId; //课例等级Id
objMicroteachCaseENT.DocFile = objMicroteachCaseENS.DocFile; //生成的Word文件名
objMicroteachCaseENT.IsNeedGeneWord = objMicroteachCaseENS.IsNeedGeneWord; //是否需要生成Word
objMicroteachCaseENT.WordCreateDate = objMicroteachCaseENS.WordCreateDate; //Word生成日期
objMicroteachCaseENT.IsVisible = objMicroteachCaseENS.IsVisible; //是否显示
objMicroteachCaseENT.microteachCaseText = objMicroteachCaseENS.microteachCaseText; //案例文本内容
objMicroteachCaseENT.OwnerId = objMicroteachCaseENS.OwnerId; //拥有者Id
objMicroteachCaseENT.IsDualVideo = objMicroteachCaseENS.IsDualVideo; //是否双视频
objMicroteachCaseENT.UserKindId = objMicroteachCaseENS.UserKindId; //用户类别Id
objMicroteachCaseENT.UserTypeId = objMicroteachCaseENS.UserTypeId; //用户类型Id
objMicroteachCaseENT.RecommendedDegreeId = objMicroteachCaseENS.RecommendedDegreeId; //推荐度Id
objMicroteachCaseENT.ftpFileType = objMicroteachCaseENS.ftpFileType; //ftp文件类型
objMicroteachCaseENT.VideoUrl = objMicroteachCaseENS.VideoUrl; //视频Url
objMicroteachCaseENT.VideoPath = objMicroteachCaseENS.VideoPath; //视频目录
objMicroteachCaseENT.ResErrMsg = objMicroteachCaseENS.ResErrMsg; //资源错误信息
objMicroteachCaseENT.UpdDate = objMicroteachCaseENS.UpdDate; //修改日期
objMicroteachCaseENT.UpdUserId = objMicroteachCaseENS.UpdUserId; //修改用户Id
objMicroteachCaseENT.Memo = objMicroteachCaseENS.Memo; //备注
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
 /// <param name = "objMicroteachCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroteachCaseEN objMicroteachCaseEN)
{
try
{
objMicroteachCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroteachCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroteachCase.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdMicroteachCase = objMicroteachCaseEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(conMicroteachCase.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.MicroteachCaseID = objMicroteachCaseEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(conMicroteachCase.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.MicroteachCaseName = objMicroteachCaseEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(conMicroteachCase.MicroteachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.MicroteachCaseTheme = objMicroteachCaseEN.MicroteachCaseTheme == "[null]" ? null :  objMicroteachCaseEN.MicroteachCaseTheme; //微格教学案例主题词
}
if (arrFldSet.Contains(conMicroteachCase.MicroteachCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.MicroteachCaseDate = objMicroteachCaseEN.MicroteachCaseDate == "[null]" ? null :  objMicroteachCaseEN.MicroteachCaseDate; //微格教学日期
}
if (arrFldSet.Contains(conMicroteachCase.MicroteachCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.MicroteachCaseTime = objMicroteachCaseEN.MicroteachCaseTime == "[null]" ? null :  objMicroteachCaseEN.MicroteachCaseTime; //微格教学时间
}
if (arrFldSet.Contains(conMicroteachCase.MicroteachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.MicroteachCaseDateIn = objMicroteachCaseEN.MicroteachCaseDateIn == "[null]" ? null :  objMicroteachCaseEN.MicroteachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(conMicroteachCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdStudyLevel = objMicroteachCaseEN.IdStudyLevel; //学段流水号
}
if (arrFldSet.Contains(conMicroteachCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdTeachingPlan = objMicroteachCaseEN.IdTeachingPlan == "[null]" ? null :  objMicroteachCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conMicroteachCase.MicroTeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.MicroTeachCaseTimeIn = objMicroteachCaseEN.MicroTeachCaseTimeIn == "[null]" ? null :  objMicroteachCaseEN.MicroTeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(conMicroteachCase.IdMicroteachCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdMicroteachCaseType = objMicroteachCaseEN.IdMicroteachCaseType == "[null]" ? null :  objMicroteachCaseEN.IdMicroteachCaseType; //微格案例类型流水号
}
if (arrFldSet.Contains(conMicroteachCase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdCaseType = objMicroteachCaseEN.IdCaseType == "[null]" ? null :  objMicroteachCaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(conMicroteachCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdDiscipline = objMicroteachCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(conMicroteachCase.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.BrowseCount = objMicroteachCaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conMicroteachCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdSenateGaugeVersion = objMicroteachCaseEN.IdSenateGaugeVersion == "[null]" ? null :  objMicroteachCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(conMicroteachCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IdTeachSkill = objMicroteachCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(conMicroteachCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.CaseLevelId = objMicroteachCaseEN.CaseLevelId == "[null]" ? null :  objMicroteachCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(conMicroteachCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.DocFile = objMicroteachCaseEN.DocFile == "[null]" ? null :  objMicroteachCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(conMicroteachCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IsNeedGeneWord = objMicroteachCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(conMicroteachCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.WordCreateDate = objMicroteachCaseEN.WordCreateDate == "[null]" ? null :  objMicroteachCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(conMicroteachCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IsVisible = objMicroteachCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conMicroteachCase.microteachCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.microteachCaseText = objMicroteachCaseEN.microteachCaseText == "[null]" ? null :  objMicroteachCaseEN.microteachCaseText; //案例文本内容
}
if (arrFldSet.Contains(conMicroteachCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.OwnerId = objMicroteachCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conMicroteachCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.IsDualVideo = objMicroteachCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(conMicroteachCase.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.UserKindId = objMicroteachCaseEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(conMicroteachCase.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.UserTypeId = objMicroteachCaseEN.UserTypeId == "[null]" ? null :  objMicroteachCaseEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(conMicroteachCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.RecommendedDegreeId = objMicroteachCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(conMicroteachCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.ftpFileType = objMicroteachCaseEN.ftpFileType == "[null]" ? null :  objMicroteachCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(conMicroteachCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.VideoUrl = objMicroteachCaseEN.VideoUrl == "[null]" ? null :  objMicroteachCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(conMicroteachCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.VideoPath = objMicroteachCaseEN.VideoPath == "[null]" ? null :  objMicroteachCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(conMicroteachCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.ResErrMsg = objMicroteachCaseEN.ResErrMsg == "[null]" ? null :  objMicroteachCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(conMicroteachCase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.UpdDate = objMicroteachCaseEN.UpdDate == "[null]" ? null :  objMicroteachCaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conMicroteachCase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.UpdUserId = objMicroteachCaseEN.UpdUserId == "[null]" ? null :  objMicroteachCaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conMicroteachCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseEN.Memo = objMicroteachCaseEN.Memo == "[null]" ? null :  objMicroteachCaseEN.Memo; //备注
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
 /// <param name = "objMicroteachCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroteachCaseEN objMicroteachCaseEN)
{
try
{
if (objMicroteachCaseEN.MicroteachCaseTheme == "[null]") objMicroteachCaseEN.MicroteachCaseTheme = null; //微格教学案例主题词
if (objMicroteachCaseEN.MicroteachCaseDate == "[null]") objMicroteachCaseEN.MicroteachCaseDate = null; //微格教学日期
if (objMicroteachCaseEN.MicroteachCaseTime == "[null]") objMicroteachCaseEN.MicroteachCaseTime = null; //微格教学时间
if (objMicroteachCaseEN.MicroteachCaseDateIn == "[null]") objMicroteachCaseEN.MicroteachCaseDateIn = null; //案例入库日期
if (objMicroteachCaseEN.IdTeachingPlan == "[null]") objMicroteachCaseEN.IdTeachingPlan = null; //教案流水号
if (objMicroteachCaseEN.MicroTeachCaseTimeIn == "[null]") objMicroteachCaseEN.MicroTeachCaseTimeIn = null; //案例入库时间
if (objMicroteachCaseEN.IdMicroteachCaseType == "[null]") objMicroteachCaseEN.IdMicroteachCaseType = null; //微格案例类型流水号
if (objMicroteachCaseEN.IdCaseType == "[null]") objMicroteachCaseEN.IdCaseType = null; //案例类型流水号
if (objMicroteachCaseEN.IdSenateGaugeVersion == "[null]") objMicroteachCaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objMicroteachCaseEN.CaseLevelId == "[null]") objMicroteachCaseEN.CaseLevelId = null; //课例等级Id
if (objMicroteachCaseEN.DocFile == "[null]") objMicroteachCaseEN.DocFile = null; //生成的Word文件名
if (objMicroteachCaseEN.WordCreateDate == "[null]") objMicroteachCaseEN.WordCreateDate = null; //Word生成日期
if (objMicroteachCaseEN.microteachCaseText == "[null]") objMicroteachCaseEN.microteachCaseText = null; //案例文本内容
if (objMicroteachCaseEN.UserTypeId == "[null]") objMicroteachCaseEN.UserTypeId = null; //用户类型Id
if (objMicroteachCaseEN.ftpFileType == "[null]") objMicroteachCaseEN.ftpFileType = null; //ftp文件类型
if (objMicroteachCaseEN.VideoUrl == "[null]") objMicroteachCaseEN.VideoUrl = null; //视频Url
if (objMicroteachCaseEN.VideoPath == "[null]") objMicroteachCaseEN.VideoPath = null; //视频目录
if (objMicroteachCaseEN.ResErrMsg == "[null]") objMicroteachCaseEN.ResErrMsg = null; //资源错误信息
if (objMicroteachCaseEN.UpdDate == "[null]") objMicroteachCaseEN.UpdDate = null; //修改日期
if (objMicroteachCaseEN.UpdUserId == "[null]") objMicroteachCaseEN.UpdUserId = null; //修改用户Id
if (objMicroteachCaseEN.Memo == "[null]") objMicroteachCaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsMicroteachCaseEN objMicroteachCaseEN)
{
 MicroteachCaseDA.CheckPropertyNew(objMicroteachCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroteachCaseEN objMicroteachCaseEN)
{
 MicroteachCaseDA.CheckProperty4Condition(objMicroteachCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdMicroteachCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[微格教学案例]...","0");
List<clsMicroteachCaseEN> arrMicroteachCaseObjLst = GetAllMicroteachCaseObjLstCache(); 
objDDL.DataValueField = conMicroteachCase.IdMicroteachCase;
objDDL.DataTextField = conMicroteachCase.MicroteachCaseName;
objDDL.DataSource = arrMicroteachCaseObjLst;
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
if (clsMicroteachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseBL没有刷新缓存机制(clsMicroteachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCase");
//if (arrMicroteachCaseObjLstCache == null)
//{
//arrMicroteachCaseObjLstCache = MicroteachCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseEN GetObjByIdMicroteachCaseCache(string strIdMicroteachCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseEN> arrMicroteachCaseObjLst_Sel =
arrMicroteachCaseObjLstCache
.Where(x=> x.IdMicroteachCase == strIdMicroteachCase 
);
if (arrMicroteachCaseObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseEN obj = clsMicroteachCaseBL.GetObjByIdMicroteachCase(strIdMicroteachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroteachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMicroteachCaseNameByIdMicroteachCaseCache(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return "";
//获取缓存中的对象列表
clsMicroteachCaseEN objMicroteachCase = GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objMicroteachCase == null) return "";
return objMicroteachCase.MicroteachCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdMicroteachCaseCache(string strIdMicroteachCase)
{
if (string.IsNullOrEmpty(strIdMicroteachCase) == true) return "";
//获取缓存中的对象列表
clsMicroteachCaseEN objMicroteachCase = GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objMicroteachCase == null) return "";
return objMicroteachCase.MicroteachCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseEN> GetAllMicroteachCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroteachCaseEN> arrMicroteachCaseObjLstCache = GetObjLstCache(); 
return arrMicroteachCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName);
List<clsMicroteachCaseEN> arrMicroteachCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseObjLstCache;
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
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroteachCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsMicroteachCaseEN._RefreshTimeLst.Count == 0) return "";
return clsMicroteachCaseEN._RefreshTimeLst[clsMicroteachCaseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsMicroteachCaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroteachCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsMicroteachCaseBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strIdMicroteachCase)
{
if (strInFldName != conMicroteachCase.IdMicroteachCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroteachCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroteachCase.AttributeName));
throw new Exception(strMsg);
}
var objMicroteachCase = clsMicroteachCaseBL.GetObjByIdMicroteachCaseCache(strIdMicroteachCase);
if (objMicroteachCase == null) return "";
return objMicroteachCase[strOutFldName].ToString();
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
int intRecCount = clsMicroteachCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroteachCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroteachCaseDA.GetRecCount();
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
int intRecCount = clsMicroteachCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroteachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroteachCaseEN objMicroteachCaseCond)
{
List<clsMicroteachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCase.AttributeName)
{
if (objMicroteachCaseCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseCond[strFldName]));
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
 List<string> arrList = clsMicroteachCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroteachCaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseDA.SetFldValue(clsMicroteachCaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroteachCaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroteachCase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**微格教学案例流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCase char(8) primary key, "); 
 // /**微格教学案例ID*/ 
 strCreateTabCode.Append(" MicroteachCaseID char(8) not Null, "); 
 // /**微格教学案例名称*/ 
 strCreateTabCode.Append(" MicroteachCaseName varchar(100) not Null, "); 
 // /**微格教学案例主题词*/ 
 strCreateTabCode.Append(" MicroteachCaseTheme varchar(200) Null, "); 
 // /**微格教学日期*/ 
 strCreateTabCode.Append(" MicroteachCaseDate char(8) Null, "); 
 // /**微格教学时间*/ 
 strCreateTabCode.Append(" MicroteachCaseTime char(6) Null, "); 
 // /**案例入库日期*/ 
 strCreateTabCode.Append(" MicroteachCaseDateIn char(8) Null, "); 
 // /**学段流水号*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) not Null, "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) Null, "); 
 // /**案例入库时间*/ 
 strCreateTabCode.Append(" MicroTeachCaseTimeIn char(6) Null, "); 
 // /**微格案例类型流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCaseType char(4) Null, "); 
 // /**案例类型流水号*/ 
 strCreateTabCode.Append(" IdCaseType char(4) Null, "); 
 // /**学科流水号*/ 
 strCreateTabCode.Append(" IdDiscipline char(4) not Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**评价量表版本流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeVersion char(4) Null, "); 
 // /**教学技能流水号*/ 
 strCreateTabCode.Append(" IdTeachSkill char(8) not Null, "); 
 // /**课例等级Id*/ 
 strCreateTabCode.Append(" CaseLevelId char(2) Null, "); 
 // /**生成的Word文件名*/ 
 strCreateTabCode.Append(" DocFile varchar(200) Null, "); 
 // /**是否需要生成Word*/ 
 strCreateTabCode.Append(" IsNeedGeneWord bit Null, "); 
 // /**Word生成日期*/ 
 strCreateTabCode.Append(" WordCreateDate varchar(14) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**案例文本内容*/ 
 strCreateTabCode.Append(" microteachCaseText varchar(8000) Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) not Null, "); 
 // /**是否双视频*/ 
 strCreateTabCode.Append(" IsDualVideo bit Null, "); 
 // /**用户类别Id*/ 
 strCreateTabCode.Append(" UserKindId char(2) not Null, "); 
 // /**用户类型Id*/ 
 strCreateTabCode.Append(" UserTypeId char(2) Null, "); 
 // /**推荐度Id*/ 
 strCreateTabCode.Append(" RecommendedDegreeId char(2) not Null, "); 
 // /**ftp文件类型*/ 
 strCreateTabCode.Append(" ftpFileType varchar(30) Null, "); 
 // /**视频Url*/ 
 strCreateTabCode.Append(" VideoUrl varchar(1000) Null, "); 
 // /**视频目录*/ 
 strCreateTabCode.Append(" VideoPath varchar(1000) Null, "); 
 // /**资源错误信息*/ 
 strCreateTabCode.Append(" ResErrMsg varchar(30) Null, "); 
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
 /// 微格教学案例(MicroteachCase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroteachCase : clsCommFun4BL
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
clsMicroteachCaseBL.ReFreshThisCache();
}
}

}