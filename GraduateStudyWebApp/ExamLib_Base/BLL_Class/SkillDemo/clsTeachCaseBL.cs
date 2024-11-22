
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachCaseBL
 表名:TeachCase(01120383)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
public static class  clsTeachCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachCaseEN GetObj(this K_IdTeachCase_TeachCase myKey)
{
clsTeachCaseEN objTeachCaseEN = clsTeachCaseBL.TeachCaseDA.GetObjByIdTeachCase(myKey.Value);
return objTeachCaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachCaseEN objTeachCaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachCaseBL.IsExist(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTeachCaseEN.IdTeachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsTeachCaseBL.TeachCaseDA.AddNewRecordBySQL2(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
public static bool AddRecordEx(this clsTeachCaseEN objTeachCaseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsTeachCaseBL.IsExist(objTeachCaseEN.IdTeachCase))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objTeachCaseEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objTeachCaseEN.AddNewRecord();
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTeachCaseEN objTeachCaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachCaseBL.IsExist(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTeachCaseEN.IdTeachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsTeachCaseBL.TeachCaseDA.AddNewRecordBySQL2WithReturnKey(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIdTeachCase(this clsTeachCaseEN objTeachCaseEN, string strIdTeachCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachCase, 8, conTeachCase.IdTeachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachCase, 8, conTeachCase.IdTeachCase);
}
objTeachCaseEN.IdTeachCase = strIdTeachCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IdTeachCase) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IdTeachCase, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IdTeachCase] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseID(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseID, conTeachCase.TeachCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseID, 8, conTeachCase.TeachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseID, 8, conTeachCase.TeachCaseID);
}
objTeachCaseEN.TeachCaseID = strTeachCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseID) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseID, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseID] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseName(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachCaseName, conTeachCase.TeachCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseName, 200, conTeachCase.TeachCaseName);
}
objTeachCaseEN.TeachCaseName = strTeachCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseName) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseName, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseName] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseExecutor(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseExecutor, 50, conTeachCase.TeachCaseExecutor);
}
objTeachCaseEN.TeachCaseExecutor = strTeachCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseExecutor) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseExecutor, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseExecutor] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseTheme(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseTheme, 200, conTeachCase.TeachCaseTheme);
}
objTeachCaseEN.TeachCaseTheme = strTeachCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseTheme) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseTheme, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseTheme] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseTeachDate(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseTeachDate, 8, conTeachCase.TeachCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseTeachDate, 8, conTeachCase.TeachCaseTeachDate);
}
objTeachCaseEN.TeachCaseTeachDate = strTeachCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseTeachDate) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseTeachDate, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseTeachDate] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseBG(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseBG, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseBG, 8000, conTeachCase.TeachCaseBG);
}
objTeachCaseEN.TeachCaseBG = strTeachCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseBG) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseBG, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseBG] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIdTeachSkill(this clsTeachCaseEN objTeachCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, conTeachCase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, conTeachCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, conTeachCase.IdTeachSkill);
}
objTeachCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IdTeachSkill) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IdTeachSkill, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IdTeachSkill] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIdDiscipline(this clsTeachCaseEN objTeachCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, conTeachCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, conTeachCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, conTeachCase.IdDiscipline);
}
objTeachCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IdDiscipline) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IdDiscipline, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IdDiscipline] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIdStudyLevel(this clsTeachCaseEN objTeachCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudyLevel, conTeachCase.IdStudyLevel);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conTeachCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conTeachCase.IdStudyLevel);
}
objTeachCaseEN.IdStudyLevel = strIdStudyLevel; //学段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IdStudyLevel) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IdStudyLevel, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IdStudyLevel] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseDateIn(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseDateIn, 8, conTeachCase.TeachCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseDateIn, 8, conTeachCase.TeachCaseDateIn);
}
objTeachCaseEN.TeachCaseDateIn = strTeachCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseDateIn) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseDateIn, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseDateIn] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIdTeachingPlan(this clsTeachCaseEN objTeachCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conTeachCase.IdTeachingPlan);
}
objTeachCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IdTeachingPlan) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IdTeachingPlan, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IdTeachingPlan] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetTeachCaseTimeIn(this clsTeachCaseEN objTeachCaseEN, string strTeachCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachCaseTimeIn, 6, conTeachCase.TeachCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachCaseTimeIn, 6, conTeachCase.TeachCaseTimeIn);
}
objTeachCaseEN.TeachCaseTimeIn = strTeachCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.TeachCaseTimeIn) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.TeachCaseTimeIn, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.TeachCaseTimeIn] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetWorkUnit(this clsTeachCaseEN objTeachCaseEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conTeachCase.WorkUnit);
}
objTeachCaseEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.WorkUnit) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.WorkUnit, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.WorkUnit] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetCDID(this clsTeachCaseEN objTeachCaseEN, string strCDID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCDID, 50, conTeachCase.CDID);
}
objTeachCaseEN.CDID = strCDID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.CDID) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.CDID, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.CDID] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetBrowseCount(this clsTeachCaseEN objTeachCaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objTeachCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.BrowseCount) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.BrowseCount, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.BrowseCount] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIsVisible(this clsTeachCaseEN objTeachCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objTeachCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IsVisible) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IsVisible, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IsVisible] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIsDualVideo(this clsTeachCaseEN objTeachCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objTeachCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IsDualVideo) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IsDualVideo, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IsDualVideo] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetIdXzCollege(this clsTeachCaseEN objTeachCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conTeachCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conTeachCase.IdXzCollege);
}
objTeachCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.IdXzCollege) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.IdXzCollege, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.IdXzCollege] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetRecommendedDegreeId(this clsTeachCaseEN objTeachCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conTeachCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conTeachCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conTeachCase.RecommendedDegreeId);
}
objTeachCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.RecommendedDegreeId) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetftpFileType(this clsTeachCaseEN objTeachCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conTeachCase.ftpFileType);
}
objTeachCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.ftpFileType) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.ftpFileType, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.ftpFileType] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetVideoUrl(this clsTeachCaseEN objTeachCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conTeachCase.VideoUrl);
}
objTeachCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.VideoUrl) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.VideoUrl, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.VideoUrl] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetVideoPath(this clsTeachCaseEN objTeachCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conTeachCase.VideoPath);
}
objTeachCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.VideoPath) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.VideoPath, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.VideoPath] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetResErrMsg(this clsTeachCaseEN objTeachCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conTeachCase.ResErrMsg);
}
objTeachCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.ResErrMsg) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.ResErrMsg, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.ResErrMsg] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetUpdDate(this clsTeachCaseEN objTeachCaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachCase.UpdDate);
}
objTeachCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.UpdDate) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.UpdDate, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.UpdDate] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetUpdUserId(this clsTeachCaseEN objTeachCaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachCase.UpdUserId);
}
objTeachCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.UpdUserId) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.UpdUserId, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.UpdUserId] = strComparisonOp;
}
}
return objTeachCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTeachCaseEN SetMemo(this clsTeachCaseEN objTeachCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachCase.Memo);
}
objTeachCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachCaseEN.dicFldComparisonOp.ContainsKey(conTeachCase.Memo) == false)
{
objTeachCaseEN.dicFldComparisonOp.Add(conTeachCase.Memo, strComparisonOp);
}
else
{
objTeachCaseEN.dicFldComparisonOp[conTeachCase.Memo] = strComparisonOp;
}
}
return objTeachCaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objTeachCaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsTeachCaseEN objTeachCaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objTeachCaseEN.CheckPropertyNew();
clsTeachCaseEN objTeachCaseCond = new clsTeachCaseEN();
string strCondition = objTeachCaseCond
.SetIdTeachCase(objTeachCaseEN.IdTeachCase, "=")
.GetCombineCondition();
objTeachCaseEN._IsCheckProperty = true;
bool bolIsExist = clsTeachCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objTeachCaseEN.Update();
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachCaseEN objTeachCaseEN)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachCaseBL.TeachCaseDA.UpdateBySql2(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachCaseEN objTeachCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTeachCaseBL.TeachCaseDA.UpdateBySql2(objTeachCaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachCaseEN objTeachCaseEN, string strWhereCond)
{
try
{
bool bolResult = clsTeachCaseBL.TeachCaseDA.UpdateBySqlWithCondition(objTeachCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachCaseEN objTeachCaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTeachCaseBL.TeachCaseDA.UpdateBySqlWithConditionTransaction(objTeachCaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTeachCaseEN objTeachCaseEN)
{
try
{
int intRecNum = clsTeachCaseBL.TeachCaseDA.DelRecord(objTeachCaseEN.IdTeachCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseENS">源对象</param>
 /// <param name = "objTeachCaseENT">目标对象</param>
 public static void CopyTo(this clsTeachCaseEN objTeachCaseENS, clsTeachCaseEN objTeachCaseENT)
{
try
{
objTeachCaseENT.IdTeachCase = objTeachCaseENS.IdTeachCase; //案例流水号
objTeachCaseENT.TeachCaseID = objTeachCaseENS.TeachCaseID; //案例ID
objTeachCaseENT.TeachCaseName = objTeachCaseENS.TeachCaseName; //案例名称
objTeachCaseENT.TeachCaseExecutor = objTeachCaseENS.TeachCaseExecutor; //案例执教者
objTeachCaseENT.TeachCaseTheme = objTeachCaseENS.TeachCaseTheme; //案例主题词
objTeachCaseENT.TeachCaseTeachDate = objTeachCaseENS.TeachCaseTeachDate; //案例授课日期
objTeachCaseENT.TeachCaseBG = objTeachCaseENS.TeachCaseBG; //案例背景资料
objTeachCaseENT.IdTeachSkill = objTeachCaseENS.IdTeachSkill; //教学技能流水号
objTeachCaseENT.IdDiscipline = objTeachCaseENS.IdDiscipline; //学科流水号
objTeachCaseENT.IdStudyLevel = objTeachCaseENS.IdStudyLevel; //学段流水号
objTeachCaseENT.TeachCaseDateIn = objTeachCaseENS.TeachCaseDateIn; //案例入库日期
objTeachCaseENT.IdTeachingPlan = objTeachCaseENS.IdTeachingPlan; //教案流水号
objTeachCaseENT.TeachCaseTimeIn = objTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objTeachCaseENT.WorkUnit = objTeachCaseENS.WorkUnit; //工作单位
objTeachCaseENT.CDID = objTeachCaseENS.CDID; //光盘编号
objTeachCaseENT.BrowseCount = objTeachCaseENS.BrowseCount; //浏览次数
objTeachCaseENT.IsVisible = objTeachCaseENS.IsVisible; //是否显示
objTeachCaseENT.IsDualVideo = objTeachCaseENS.IsDualVideo; //是否双视频
objTeachCaseENT.IdXzCollege = objTeachCaseENS.IdXzCollege; //学院流水号
objTeachCaseENT.RecommendedDegreeId = objTeachCaseENS.RecommendedDegreeId; //推荐度Id
objTeachCaseENT.ftpFileType = objTeachCaseENS.ftpFileType; //ftp文件类型
objTeachCaseENT.VideoUrl = objTeachCaseENS.VideoUrl; //视频Url
objTeachCaseENT.VideoPath = objTeachCaseENS.VideoPath; //视频目录
objTeachCaseENT.ResErrMsg = objTeachCaseENS.ResErrMsg; //资源错误信息
objTeachCaseENT.UpdDate = objTeachCaseENS.UpdDate; //修改日期
objTeachCaseENT.UpdUserId = objTeachCaseENS.UpdUserId; //修改用户Id
objTeachCaseENT.Memo = objTeachCaseENS.Memo; //备注
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
 /// <param name = "objTeachCaseENS">源对象</param>
 /// <returns>目标对象=>clsTeachCaseEN:objTeachCaseENT</returns>
 public static clsTeachCaseEN CopyTo(this clsTeachCaseEN objTeachCaseENS)
{
try
{
 clsTeachCaseEN objTeachCaseENT = new clsTeachCaseEN()
{
IdTeachCase = objTeachCaseENS.IdTeachCase, //案例流水号
TeachCaseID = objTeachCaseENS.TeachCaseID, //案例ID
TeachCaseName = objTeachCaseENS.TeachCaseName, //案例名称
TeachCaseExecutor = objTeachCaseENS.TeachCaseExecutor, //案例执教者
TeachCaseTheme = objTeachCaseENS.TeachCaseTheme, //案例主题词
TeachCaseTeachDate = objTeachCaseENS.TeachCaseTeachDate, //案例授课日期
TeachCaseBG = objTeachCaseENS.TeachCaseBG, //案例背景资料
IdTeachSkill = objTeachCaseENS.IdTeachSkill, //教学技能流水号
IdDiscipline = objTeachCaseENS.IdDiscipline, //学科流水号
IdStudyLevel = objTeachCaseENS.IdStudyLevel, //学段流水号
TeachCaseDateIn = objTeachCaseENS.TeachCaseDateIn, //案例入库日期
IdTeachingPlan = objTeachCaseENS.IdTeachingPlan, //教案流水号
TeachCaseTimeIn = objTeachCaseENS.TeachCaseTimeIn, //案例入库时间
WorkUnit = objTeachCaseENS.WorkUnit, //工作单位
CDID = objTeachCaseENS.CDID, //光盘编号
BrowseCount = objTeachCaseENS.BrowseCount, //浏览次数
IsVisible = objTeachCaseENS.IsVisible, //是否显示
IsDualVideo = objTeachCaseENS.IsDualVideo, //是否双视频
IdXzCollege = objTeachCaseENS.IdXzCollege, //学院流水号
RecommendedDegreeId = objTeachCaseENS.RecommendedDegreeId, //推荐度Id
ftpFileType = objTeachCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objTeachCaseENS.VideoUrl, //视频Url
VideoPath = objTeachCaseENS.VideoPath, //视频目录
ResErrMsg = objTeachCaseENS.ResErrMsg, //资源错误信息
UpdDate = objTeachCaseENS.UpdDate, //修改日期
UpdUserId = objTeachCaseENS.UpdUserId, //修改用户Id
Memo = objTeachCaseENS.Memo, //备注
};
 return objTeachCaseENT;
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
public static void CheckPropertyNew(this clsTeachCaseEN objTeachCaseEN)
{
 clsTeachCaseBL.TeachCaseDA.CheckPropertyNew(objTeachCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTeachCaseEN objTeachCaseEN)
{
 clsTeachCaseBL.TeachCaseDA.CheckProperty4Condition(objTeachCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachCaseEN objTeachCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachCaseCond.IsUpdated(conTeachCase.IdTeachCase) == true)
{
string strComparisonOpIdTeachCase = objTeachCaseCond.dicFldComparisonOp[conTeachCase.IdTeachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.IdTeachCase, objTeachCaseCond.IdTeachCase, strComparisonOpIdTeachCase);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseID) == true)
{
string strComparisonOpTeachCaseID = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseID, objTeachCaseCond.TeachCaseID, strComparisonOpTeachCaseID);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseName) == true)
{
string strComparisonOpTeachCaseName = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseName, objTeachCaseCond.TeachCaseName, strComparisonOpTeachCaseName);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseExecutor) == true)
{
string strComparisonOpTeachCaseExecutor = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseExecutor, objTeachCaseCond.TeachCaseExecutor, strComparisonOpTeachCaseExecutor);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseTheme) == true)
{
string strComparisonOpTeachCaseTheme = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseTheme, objTeachCaseCond.TeachCaseTheme, strComparisonOpTeachCaseTheme);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseTeachDate) == true)
{
string strComparisonOpTeachCaseTeachDate = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseTeachDate, objTeachCaseCond.TeachCaseTeachDate, strComparisonOpTeachCaseTeachDate);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseBG) == true)
{
string strComparisonOpTeachCaseBG = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseBG];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseBG, objTeachCaseCond.TeachCaseBG, strComparisonOpTeachCaseBG);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objTeachCaseCond.dicFldComparisonOp[conTeachCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.IdTeachSkill, objTeachCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objTeachCaseCond.dicFldComparisonOp[conTeachCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.IdDiscipline, objTeachCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objTeachCaseCond.dicFldComparisonOp[conTeachCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.IdStudyLevel, objTeachCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseDateIn) == true)
{
string strComparisonOpTeachCaseDateIn = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseDateIn, objTeachCaseCond.TeachCaseDateIn, strComparisonOpTeachCaseDateIn);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objTeachCaseCond.dicFldComparisonOp[conTeachCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.IdTeachingPlan, objTeachCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.TeachCaseTimeIn) == true)
{
string strComparisonOpTeachCaseTimeIn = objTeachCaseCond.dicFldComparisonOp[conTeachCase.TeachCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.TeachCaseTimeIn, objTeachCaseCond.TeachCaseTimeIn, strComparisonOpTeachCaseTimeIn);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objTeachCaseCond.dicFldComparisonOp[conTeachCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.WorkUnit, objTeachCaseCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.CDID) == true)
{
string strComparisonOpCDID = objTeachCaseCond.dicFldComparisonOp[conTeachCase.CDID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.CDID, objTeachCaseCond.CDID, strComparisonOpCDID);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objTeachCaseCond.dicFldComparisonOp[conTeachCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conTeachCase.BrowseCount, objTeachCaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.IsVisible) == true)
{
if (objTeachCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachCase.IsVisible);
}
}
if (objTeachCaseCond.IsUpdated(conTeachCase.IsDualVideo) == true)
{
if (objTeachCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conTeachCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conTeachCase.IsDualVideo);
}
}
if (objTeachCaseCond.IsUpdated(conTeachCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objTeachCaseCond.dicFldComparisonOp[conTeachCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.IdXzCollege, objTeachCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objTeachCaseCond.dicFldComparisonOp[conTeachCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.RecommendedDegreeId, objTeachCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objTeachCaseCond.dicFldComparisonOp[conTeachCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.ftpFileType, objTeachCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objTeachCaseCond.dicFldComparisonOp[conTeachCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.VideoUrl, objTeachCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objTeachCaseCond.dicFldComparisonOp[conTeachCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.VideoPath, objTeachCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objTeachCaseCond.dicFldComparisonOp[conTeachCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.ResErrMsg, objTeachCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.UpdDate) == true)
{
string strComparisonOpUpdDate = objTeachCaseCond.dicFldComparisonOp[conTeachCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.UpdDate, objTeachCaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objTeachCaseCond.dicFldComparisonOp[conTeachCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.UpdUserId, objTeachCaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objTeachCaseCond.IsUpdated(conTeachCase.Memo) == true)
{
string strComparisonOpMemo = objTeachCaseCond.dicFldComparisonOp[conTeachCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachCase.Memo, objTeachCaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TeachCase
{
public virtual bool UpdRelaTabDate(string strIdTeachCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例(TeachCase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTeachCaseBL
{
public static RelatedActions_TeachCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTeachCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTeachCaseDA TeachCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTeachCaseDA();
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
 public clsTeachCaseBL()
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
if (string.IsNullOrEmpty(clsTeachCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachCaseEN._ConnectString);
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
public static DataTable GetDataTable_TeachCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TeachCaseDA.GetDataTable_TeachCase(strWhereCond);
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
objDT = TeachCaseDA.GetDataTable(strWhereCond);
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
objDT = TeachCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TeachCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TeachCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TeachCaseDA.GetDataTable_Top(objTopPara);
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
objDT = TeachCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TeachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TeachCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdTeachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTeachCaseEN> GetObjLstByIdTeachCaseLst(List<string> arrIdTeachCaseLst)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdTeachCaseLst, true);
 string strWhereCond = string.Format("IdTeachCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdTeachCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTeachCaseEN> GetObjLstByIdTeachCaseLstCache(List<string> arrIdTeachCaseLst)
{
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName);
List<clsTeachCaseEN> arrTeachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCaseEN> arrTeachCaseObjLst_Sel =
arrTeachCaseObjLstCache
.Where(x => arrIdTeachCaseLst.Contains(x.IdTeachCase));
return arrTeachCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCaseEN> GetObjLst(string strWhereCond)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
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
public static List<clsTeachCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTeachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTeachCaseEN> GetSubObjLstCache(clsTeachCaseEN objTeachCaseCond)
{
List<clsTeachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachCase.AttributeName)
{
if (objTeachCaseCond.IsUpdated(strFldName) == false) continue;
if (objTeachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCaseCond[strFldName].ToString());
}
else
{
if (objTeachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachCaseCond[strFldName]));
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
public static List<clsTeachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
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
public static List<clsTeachCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
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
List<clsTeachCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTeachCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTeachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
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
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
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
public static List<clsTeachCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTeachCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTeachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
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
public static List<clsTeachCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTeachCaseEN> arrObjLst = new List<clsTeachCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachCaseEN objTeachCaseEN = new clsTeachCaseEN();
try
{
objTeachCaseEN.IdTeachCase = objRow[conTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objTeachCaseEN.TeachCaseID = objRow[conTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objTeachCaseEN.TeachCaseName = objRow[conTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objTeachCaseEN.TeachCaseExecutor = objRow[conTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objTeachCaseEN.TeachCaseTheme = objRow[conTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objTeachCaseEN.TeachCaseTeachDate = objRow[conTeachCase.TeachCaseTeachDate] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTeachDate].ToString().Trim(); //案例授课日期
objTeachCaseEN.TeachCaseBG = objRow[conTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objTeachCaseEN.IdTeachSkill = objRow[conTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachCaseEN.IdDiscipline = objRow[conTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachCaseEN.IdStudyLevel = objRow[conTeachCase.IdStudyLevel].ToString().Trim(); //学段流水号
objTeachCaseEN.TeachCaseDateIn = objRow[conTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objTeachCaseEN.IdTeachingPlan = objRow[conTeachCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachCaseEN.TeachCaseTimeIn = objRow[conTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[conTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachCaseEN.WorkUnit = objRow[conTeachCase.WorkUnit] == DBNull.Value ? null : objRow[conTeachCase.WorkUnit].ToString().Trim(); //工作单位
objTeachCaseEN.CDID = objRow[conTeachCase.CDID] == DBNull.Value ? null : objRow[conTeachCase.CDID].ToString().Trim(); //光盘编号
objTeachCaseEN.BrowseCount = objRow[conTeachCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsVisible].ToString().Trim()); //是否显示
objTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachCaseEN.IdXzCollege = objRow[conTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[conTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachCaseEN.RecommendedDegreeId = objRow[conTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachCaseEN.ftpFileType = objRow[conTeachCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachCaseEN.VideoUrl = objRow[conTeachCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachCase.VideoUrl].ToString().Trim(); //视频Url
objTeachCaseEN.VideoPath = objRow[conTeachCase.VideoPath] == DBNull.Value ? null : objRow[conTeachCase.VideoPath].ToString().Trim(); //视频目录
objTeachCaseEN.ResErrMsg = objRow[conTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachCaseEN.UpdDate = objRow[conTeachCase.UpdDate] == DBNull.Value ? null : objRow[conTeachCase.UpdDate].ToString().Trim(); //修改日期
objTeachCaseEN.UpdUserId = objRow[conTeachCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachCaseEN.Memo = objRow[conTeachCase.Memo] == DBNull.Value ? null : objRow[conTeachCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTeachCaseEN.IdTeachCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTeachCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTeachCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTeachCase(ref clsTeachCaseEN objTeachCaseEN)
{
bool bolResult = TeachCaseDA.GetTeachCase(ref objTeachCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdTeachCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachCaseEN GetObjByIdTeachCase(string strIdTeachCase)
{
if (strIdTeachCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdTeachCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdTeachCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdTeachCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsTeachCaseEN objTeachCaseEN = TeachCaseDA.GetObjByIdTeachCase(strIdTeachCase);
return objTeachCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTeachCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTeachCaseEN objTeachCaseEN = TeachCaseDA.GetFirstObj(strWhereCond);
 return objTeachCaseEN;
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
public static clsTeachCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTeachCaseEN objTeachCaseEN = TeachCaseDA.GetObjByDataRow(objRow);
 return objTeachCaseEN;
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
public static clsTeachCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTeachCaseEN objTeachCaseEN = TeachCaseDA.GetObjByDataRow(objRow);
 return objTeachCaseEN;
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
 /// <param name = "strIdTeachCase">所给的关键字</param>
 /// <param name = "lstTeachCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachCaseEN GetObjByIdTeachCaseFromList(string strIdTeachCase, List<clsTeachCaseEN> lstTeachCaseObjLst)
{
foreach (clsTeachCaseEN objTeachCaseEN in lstTeachCaseObjLst)
{
if (objTeachCaseEN.IdTeachCase == strIdTeachCase)
{
return objTeachCaseEN;
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
 string strIdTeachCase;
 try
 {
 strIdTeachCase = new clsTeachCaseDA().GetFirstID(strWhereCond);
 return strIdTeachCase;
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
 arrList = TeachCaseDA.GetID(strWhereCond);
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
bool bolIsExist = TeachCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdTeachCase)
{
if (string.IsNullOrEmpty(strIdTeachCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdTeachCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = TeachCaseDA.IsExist(strIdTeachCase);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdTeachCase">案例流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdTeachCase, string strOpUser)
{
clsTeachCaseEN objTeachCaseEN = clsTeachCaseBL.GetObjByIdTeachCase(strIdTeachCase);
objTeachCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objTeachCaseEN.UpdUserId = strOpUser;
return clsTeachCaseBL.UpdateBySql2(objTeachCaseEN);
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
 bolIsExist = clsTeachCaseDA.IsExistTable();
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
 bolIsExist = TeachCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTeachCaseEN objTeachCaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachCaseBL.IsExist(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTeachCaseEN.IdTeachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = TeachCaseDA.AddNewRecordBySQL2(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTeachCaseEN objTeachCaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachCaseBL.IsExist(objTeachCaseEN.IdTeachCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objTeachCaseEN.IdTeachCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = TeachCaseDA.AddNewRecordBySQL2WithReturnKey(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTeachCaseEN objTeachCaseEN)
{
try
{
bool bolResult = TeachCaseDA.Update(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "objTeachCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTeachCaseEN objTeachCaseEN)
{
 if (string.IsNullOrEmpty(objTeachCaseEN.IdTeachCase) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TeachCaseDA.UpdateBySql2(objTeachCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachCaseBL.ReFreshCache();

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
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
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdTeachCase)
{
try
{
 clsTeachCaseEN objTeachCaseEN = clsTeachCaseBL.GetObjByIdTeachCase(strIdTeachCase);

if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(objTeachCaseEN.IdTeachCase, objTeachCaseEN.UpdUserId);
}
if (objTeachCaseEN != null)
{
int intRecNum = TeachCaseDA.DelRecord(strIdTeachCase);
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
/// <param name="strIdTeachCase">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdTeachCase )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
//删除与表:[TeachCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTeachCase.IdTeachCase,
//strIdTeachCase);
//        clsTeachCaseBL.DelTeachCasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachCaseBL.DelRecord(strIdTeachCase, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachCaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeachCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdTeachCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTeachCaseBL.relatedActions != null)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(strIdTeachCase, "UpdRelaTabDate");
}
bool bolResult = TeachCaseDA.DelRecord(strIdTeachCase,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdTeachCaseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTeachCases(List<string> arrIdTeachCaseLst)
{
if (arrIdTeachCaseLst.Count == 0) return 0;
try
{
if (clsTeachCaseBL.relatedActions != null)
{
foreach (var strIdTeachCase in arrIdTeachCaseLst)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(strIdTeachCase, "UpdRelaTabDate");
}
}
int intDelRecNum = TeachCaseDA.DelTeachCase(arrIdTeachCaseLst);
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
public static int DelTeachCasesByCond(string strWhereCond)
{
try
{
if (clsTeachCaseBL.relatedActions != null)
{
List<string> arrIdTeachCase = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdTeachCase in arrIdTeachCase)
{
clsTeachCaseBL.relatedActions.UpdRelaTabDate(strIdTeachCase, "UpdRelaTabDate");
}
}
int intRecNum = TeachCaseDA.DelTeachCase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TeachCase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdTeachCase">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdTeachCase)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTeachCaseDA.GetSpecSQLObj();
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
//删除与表:[TeachCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTeachCaseBL.DelRecord(strIdTeachCase, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTeachCaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdTeachCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTeachCaseENS">源对象</param>
 /// <param name = "objTeachCaseENT">目标对象</param>
 public static void CopyTo(clsTeachCaseEN objTeachCaseENS, clsTeachCaseEN objTeachCaseENT)
{
try
{
objTeachCaseENT.IdTeachCase = objTeachCaseENS.IdTeachCase; //案例流水号
objTeachCaseENT.TeachCaseID = objTeachCaseENS.TeachCaseID; //案例ID
objTeachCaseENT.TeachCaseName = objTeachCaseENS.TeachCaseName; //案例名称
objTeachCaseENT.TeachCaseExecutor = objTeachCaseENS.TeachCaseExecutor; //案例执教者
objTeachCaseENT.TeachCaseTheme = objTeachCaseENS.TeachCaseTheme; //案例主题词
objTeachCaseENT.TeachCaseTeachDate = objTeachCaseENS.TeachCaseTeachDate; //案例授课日期
objTeachCaseENT.TeachCaseBG = objTeachCaseENS.TeachCaseBG; //案例背景资料
objTeachCaseENT.IdTeachSkill = objTeachCaseENS.IdTeachSkill; //教学技能流水号
objTeachCaseENT.IdDiscipline = objTeachCaseENS.IdDiscipline; //学科流水号
objTeachCaseENT.IdStudyLevel = objTeachCaseENS.IdStudyLevel; //学段流水号
objTeachCaseENT.TeachCaseDateIn = objTeachCaseENS.TeachCaseDateIn; //案例入库日期
objTeachCaseENT.IdTeachingPlan = objTeachCaseENS.IdTeachingPlan; //教案流水号
objTeachCaseENT.TeachCaseTimeIn = objTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objTeachCaseENT.WorkUnit = objTeachCaseENS.WorkUnit; //工作单位
objTeachCaseENT.CDID = objTeachCaseENS.CDID; //光盘编号
objTeachCaseENT.BrowseCount = objTeachCaseENS.BrowseCount; //浏览次数
objTeachCaseENT.IsVisible = objTeachCaseENS.IsVisible; //是否显示
objTeachCaseENT.IsDualVideo = objTeachCaseENS.IsDualVideo; //是否双视频
objTeachCaseENT.IdXzCollege = objTeachCaseENS.IdXzCollege; //学院流水号
objTeachCaseENT.RecommendedDegreeId = objTeachCaseENS.RecommendedDegreeId; //推荐度Id
objTeachCaseENT.ftpFileType = objTeachCaseENS.ftpFileType; //ftp文件类型
objTeachCaseENT.VideoUrl = objTeachCaseENS.VideoUrl; //视频Url
objTeachCaseENT.VideoPath = objTeachCaseENS.VideoPath; //视频目录
objTeachCaseENT.ResErrMsg = objTeachCaseENS.ResErrMsg; //资源错误信息
objTeachCaseENT.UpdDate = objTeachCaseENS.UpdDate; //修改日期
objTeachCaseENT.UpdUserId = objTeachCaseENS.UpdUserId; //修改用户Id
objTeachCaseENT.Memo = objTeachCaseENS.Memo; //备注
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
 /// <param name = "objTeachCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsTeachCaseEN objTeachCaseEN)
{
try
{
objTeachCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTeachCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTeachCase.IdTeachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IdTeachCase = objTeachCaseEN.IdTeachCase; //案例流水号
}
if (arrFldSet.Contains(conTeachCase.TeachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseID = objTeachCaseEN.TeachCaseID; //案例ID
}
if (arrFldSet.Contains(conTeachCase.TeachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseName = objTeachCaseEN.TeachCaseName; //案例名称
}
if (arrFldSet.Contains(conTeachCase.TeachCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseExecutor = objTeachCaseEN.TeachCaseExecutor == "[null]" ? null :  objTeachCaseEN.TeachCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(conTeachCase.TeachCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseTheme = objTeachCaseEN.TeachCaseTheme == "[null]" ? null :  objTeachCaseEN.TeachCaseTheme; //案例主题词
}
if (arrFldSet.Contains(conTeachCase.TeachCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseTeachDate = objTeachCaseEN.TeachCaseTeachDate == "[null]" ? null :  objTeachCaseEN.TeachCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(conTeachCase.TeachCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseBG = objTeachCaseEN.TeachCaseBG == "[null]" ? null :  objTeachCaseEN.TeachCaseBG; //案例背景资料
}
if (arrFldSet.Contains(conTeachCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IdTeachSkill = objTeachCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(conTeachCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IdDiscipline = objTeachCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(conTeachCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IdStudyLevel = objTeachCaseEN.IdStudyLevel; //学段流水号
}
if (arrFldSet.Contains(conTeachCase.TeachCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseDateIn = objTeachCaseEN.TeachCaseDateIn == "[null]" ? null :  objTeachCaseEN.TeachCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(conTeachCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IdTeachingPlan = objTeachCaseEN.IdTeachingPlan == "[null]" ? null :  objTeachCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conTeachCase.TeachCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.TeachCaseTimeIn = objTeachCaseEN.TeachCaseTimeIn == "[null]" ? null :  objTeachCaseEN.TeachCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(conTeachCase.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.WorkUnit = objTeachCaseEN.WorkUnit == "[null]" ? null :  objTeachCaseEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(conTeachCase.CDID, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.CDID = objTeachCaseEN.CDID == "[null]" ? null :  objTeachCaseEN.CDID; //光盘编号
}
if (arrFldSet.Contains(conTeachCase.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.BrowseCount = objTeachCaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conTeachCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IsVisible = objTeachCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conTeachCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IsDualVideo = objTeachCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(conTeachCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.IdXzCollege = objTeachCaseEN.IdXzCollege == "[null]" ? null :  objTeachCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conTeachCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.RecommendedDegreeId = objTeachCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(conTeachCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.ftpFileType = objTeachCaseEN.ftpFileType == "[null]" ? null :  objTeachCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(conTeachCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.VideoUrl = objTeachCaseEN.VideoUrl == "[null]" ? null :  objTeachCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(conTeachCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.VideoPath = objTeachCaseEN.VideoPath == "[null]" ? null :  objTeachCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(conTeachCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.ResErrMsg = objTeachCaseEN.ResErrMsg == "[null]" ? null :  objTeachCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(conTeachCase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.UpdDate = objTeachCaseEN.UpdDate == "[null]" ? null :  objTeachCaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conTeachCase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.UpdUserId = objTeachCaseEN.UpdUserId == "[null]" ? null :  objTeachCaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conTeachCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTeachCaseEN.Memo = objTeachCaseEN.Memo == "[null]" ? null :  objTeachCaseEN.Memo; //备注
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
 /// <param name = "objTeachCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsTeachCaseEN objTeachCaseEN)
{
try
{
if (objTeachCaseEN.TeachCaseExecutor == "[null]") objTeachCaseEN.TeachCaseExecutor = null; //案例执教者
if (objTeachCaseEN.TeachCaseTheme == "[null]") objTeachCaseEN.TeachCaseTheme = null; //案例主题词
if (objTeachCaseEN.TeachCaseTeachDate == "[null]") objTeachCaseEN.TeachCaseTeachDate = null; //案例授课日期
if (objTeachCaseEN.TeachCaseBG == "[null]") objTeachCaseEN.TeachCaseBG = null; //案例背景资料
if (objTeachCaseEN.TeachCaseDateIn == "[null]") objTeachCaseEN.TeachCaseDateIn = null; //案例入库日期
if (objTeachCaseEN.IdTeachingPlan == "[null]") objTeachCaseEN.IdTeachingPlan = null; //教案流水号
if (objTeachCaseEN.TeachCaseTimeIn == "[null]") objTeachCaseEN.TeachCaseTimeIn = null; //案例入库时间
if (objTeachCaseEN.WorkUnit == "[null]") objTeachCaseEN.WorkUnit = null; //工作单位
if (objTeachCaseEN.CDID == "[null]") objTeachCaseEN.CDID = null; //光盘编号
if (objTeachCaseEN.IdXzCollege == "[null]") objTeachCaseEN.IdXzCollege = null; //学院流水号
if (objTeachCaseEN.ftpFileType == "[null]") objTeachCaseEN.ftpFileType = null; //ftp文件类型
if (objTeachCaseEN.VideoUrl == "[null]") objTeachCaseEN.VideoUrl = null; //视频Url
if (objTeachCaseEN.VideoPath == "[null]") objTeachCaseEN.VideoPath = null; //视频目录
if (objTeachCaseEN.ResErrMsg == "[null]") objTeachCaseEN.ResErrMsg = null; //资源错误信息
if (objTeachCaseEN.UpdDate == "[null]") objTeachCaseEN.UpdDate = null; //修改日期
if (objTeachCaseEN.UpdUserId == "[null]") objTeachCaseEN.UpdUserId = null; //修改用户Id
if (objTeachCaseEN.Memo == "[null]") objTeachCaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsTeachCaseEN objTeachCaseEN)
{
 TeachCaseDA.CheckPropertyNew(objTeachCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTeachCaseEN objTeachCaseEN)
{
 TeachCaseDA.CheckProperty4Condition(objTeachCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdTeachCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[案例]...","0");
List<clsTeachCaseEN> arrTeachCaseObjLst = GetAllTeachCaseObjLstCache(); 
objDDL.DataValueField = conTeachCase.IdTeachCase;
objDDL.DataTextField = conTeachCase.TeachCaseName;
objDDL.DataSource = arrTeachCaseObjLst;
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
if (clsTeachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachCaseBL没有刷新缓存机制(clsTeachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdTeachCase");
//if (arrTeachCaseObjLstCache == null)
//{
//arrTeachCaseObjLstCache = TeachCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTeachCaseEN GetObjByIdTeachCaseCache(string strIdTeachCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName);
List<clsTeachCaseEN> arrTeachCaseObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCaseEN> arrTeachCaseObjLst_Sel =
arrTeachCaseObjLstCache
.Where(x=> x.IdTeachCase == strIdTeachCase 
);
if (arrTeachCaseObjLst_Sel.Count() == 0)
{
   clsTeachCaseEN obj = clsTeachCaseBL.GetObjByIdTeachCase(strIdTeachCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTeachCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachCaseNameByIdTeachCaseCache(string strIdTeachCase)
{
if (string.IsNullOrEmpty(strIdTeachCase) == true) return "";
//获取缓存中的对象列表
clsTeachCaseEN objTeachCase = GetObjByIdTeachCaseCache(strIdTeachCase);
if (objTeachCase == null) return "";
return objTeachCase.TeachCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdTeachCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdTeachCaseCache(string strIdTeachCase)
{
if (string.IsNullOrEmpty(strIdTeachCase) == true) return "";
//获取缓存中的对象列表
clsTeachCaseEN objTeachCase = GetObjByIdTeachCaseCache(strIdTeachCase);
if (objTeachCase == null) return "";
return objTeachCase.TeachCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachCaseEN> GetAllTeachCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsTeachCaseEN> arrTeachCaseObjLstCache = GetObjLstCache(); 
return arrTeachCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName);
List<clsTeachCaseEN> arrTeachCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeachCaseObjLstCache;
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
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTeachCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsTeachCaseEN._RefreshTimeLst.Count == 0) return "";
return clsTeachCaseEN._RefreshTimeLst[clsTeachCaseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsTeachCaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeachCaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTeachCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsTeachCaseBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdTeachCase)
{
if (strInFldName != conTeachCase.IdTeachCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTeachCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTeachCase.AttributeName));
throw new Exception(strMsg);
}
var objTeachCase = clsTeachCaseBL.GetObjByIdTeachCaseCache(strIdTeachCase);
if (objTeachCase == null) return "";
return objTeachCase[strOutFldName].ToString();
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
int intRecCount = clsTeachCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsTeachCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTeachCaseDA.GetRecCount();
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
int intRecCount = clsTeachCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTeachCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTeachCaseEN objTeachCaseCond)
{
List<clsTeachCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTeachCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTeachCase.AttributeName)
{
if (objTeachCaseCond.IsUpdated(strFldName) == false) continue;
if (objTeachCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCaseCond[strFldName].ToString());
}
else
{
if (objTeachCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTeachCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTeachCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTeachCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTeachCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTeachCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTeachCaseCond[strFldName]));
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
 List<string> arrList = clsTeachCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TeachCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TeachCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TeachCaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachCaseDA.SetFldValue(clsTeachCaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TeachCaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachCaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTeachCaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTeachCaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TeachCase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdTeachCase char(8) primary key, "); 
 // /**案例ID*/ 
 strCreateTabCode.Append(" TeachCaseID char(8) not Null, "); 
 // /**案例名称*/ 
 strCreateTabCode.Append(" TeachCaseName varchar(200) not Null, "); 
 // /**案例执教者*/ 
 strCreateTabCode.Append(" TeachCaseExecutor varchar(50) Null, "); 
 // /**案例主题词*/ 
 strCreateTabCode.Append(" TeachCaseTheme varchar(200) Null, "); 
 // /**案例授课日期*/ 
 strCreateTabCode.Append(" TeachCaseTeachDate char(8) Null, "); 
 // /**案例背景资料*/ 
 strCreateTabCode.Append(" TeachCaseBG varchar(8000) Null, "); 
 // /**教学技能流水号*/ 
 strCreateTabCode.Append(" IdTeachSkill char(8) not Null, "); 
 // /**学科流水号*/ 
 strCreateTabCode.Append(" IdDiscipline char(4) not Null, "); 
 // /**学段流水号*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) not Null, "); 
 // /**案例入库日期*/ 
 strCreateTabCode.Append(" TeachCaseDateIn char(8) Null, "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) Null, "); 
 // /**案例入库时间*/ 
 strCreateTabCode.Append(" TeachCaseTimeIn char(6) Null, "); 
 // /**工作单位*/ 
 strCreateTabCode.Append(" WorkUnit varchar(100) Null, "); 
 // /**光盘编号*/ 
 strCreateTabCode.Append(" CDID varchar(50) Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**是否双视频*/ 
 strCreateTabCode.Append(" IsDualVideo bit Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
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
 /// 案例(TeachCase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TeachCase : clsCommFun4BL
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
clsTeachCaseBL.ReFreshThisCache();
}
}

}