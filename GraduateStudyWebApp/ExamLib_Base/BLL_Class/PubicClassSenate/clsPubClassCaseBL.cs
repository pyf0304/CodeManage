
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseBL
 表名:PubClassCase(01120385)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsPubClassCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseEN GetObj(this K_IdPubClassCase_PubClassCase myKey)
{
clsPubClassCaseEN objPubClassCaseEN = clsPubClassCaseBL.PubClassCaseDA.GetObjByIdPubClassCase(myKey.Value);
return objPubClassCaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCaseEN objPubClassCaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseBL.IsExist(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseEN.IdPubClassCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsPubClassCaseBL.PubClassCaseDA.AddNewRecordBySQL2(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
public static bool AddRecordEx(this clsPubClassCaseEN objPubClassCaseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPubClassCaseBL.IsExist(objPubClassCaseEN.IdPubClassCase))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPubClassCaseEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objPubClassCaseEN.AddNewRecord();
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPubClassCaseEN objPubClassCaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseBL.IsExist(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseEN.IdPubClassCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsPubClassCaseBL.PubClassCaseDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIdPubClassCase(this clsPubClassCaseEN objPubClassCaseEN, string strIdPubClassCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCase, 8, conPubClassCase.IdPubClassCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCase, 8, conPubClassCase.IdPubClassCase);
}
objPubClassCaseEN.IdPubClassCase = strIdPubClassCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IdPubClassCase) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IdPubClassCase, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IdPubClassCase] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseID(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseID, conPubClassCase.PubClassCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseID, 8, conPubClassCase.PubClassCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseID, 8, conPubClassCase.PubClassCaseID);
}
objPubClassCaseEN.PubClassCaseID = strPubClassCaseID; //案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseID) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseID, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseID] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseName(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPubClassCaseName, conPubClassCase.PubClassCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseName, 200, conPubClassCase.PubClassCaseName);
}
objPubClassCaseEN.PubClassCaseName = strPubClassCaseName; //案例课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseName) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseName, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseName] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseExecutor(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseExecutor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseExecutor, 50, conPubClassCase.PubClassCaseExecutor);
}
objPubClassCaseEN.PubClassCaseExecutor = strPubClassCaseExecutor; //案例执教者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseExecutor) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseExecutor, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseExecutor] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetWorkUnit(this clsPubClassCaseEN objPubClassCaseEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conPubClassCase.WorkUnit);
}
objPubClassCaseEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.WorkUnit) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.WorkUnit, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.WorkUnit] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseTheme(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTheme, 500, conPubClassCase.PubClassCaseTheme);
}
objPubClassCaseEN.PubClassCaseTheme = strPubClassCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseTheme) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseTheme, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseTheme] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseBG(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseBG, string strComparisonOp="")
	{
objPubClassCaseEN.PubClassCaseBG = strPubClassCaseBG; //案例背景资料
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseBG) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseBG, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseBG] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseTeachDate(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseTeachDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTeachDate, 8, conPubClassCase.PubClassCaseTeachDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTeachDate, 8, conPubClassCase.PubClassCaseTeachDate);
}
objPubClassCaseEN.PubClassCaseTeachDate = strPubClassCaseTeachDate; //案例授课日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseTeachDate) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseTeachDate, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseTeachDate] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseDateIn(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseDateIn, 8, conPubClassCase.PubClassCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseDateIn, 8, conPubClassCase.PubClassCaseDateIn);
}
objPubClassCaseEN.PubClassCaseDateIn = strPubClassCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseDateIn) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseDateIn, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseDateIn] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIdDiscipline(this clsPubClassCaseEN objPubClassCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, conPubClassCase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, conPubClassCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, conPubClassCase.IdDiscipline);
}
objPubClassCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IdDiscipline) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IdDiscipline, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IdDiscipline] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIdTeachingPlan(this clsPubClassCaseEN objPubClassCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conPubClassCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conPubClassCase.IdTeachingPlan);
}
objPubClassCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IdTeachingPlan) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IdTeachingPlan, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IdTeachingPlan] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetPubClassCaseTimeIn(this clsPubClassCaseEN objPubClassCaseEN, string strPubClassCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPubClassCaseTimeIn, 6, conPubClassCase.PubClassCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPubClassCaseTimeIn, 6, conPubClassCase.PubClassCaseTimeIn);
}
objPubClassCaseEN.PubClassCaseTimeIn = strPubClassCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.PubClassCaseTimeIn) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.PubClassCaseTimeIn, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.PubClassCaseTimeIn] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIdPubClassCaseSenateGaugeVersion(this clsPubClassCaseEN objPubClassCaseEN, string strIdPubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdPubClassCaseSenateGaugeVersion, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateGaugeVersion, 4, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateGaugeVersion, 4, conPubClassCase.IdPubClassCaseSenateGaugeVersion);
}
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IdPubClassCaseSenateGaugeVersion) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IdPubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IdPubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetBrowseCount(this clsPubClassCaseEN objPubClassCaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objPubClassCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.BrowseCount) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.BrowseCount, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.BrowseCount] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIdPubCaseType(this clsPubClassCaseEN objPubClassCaseEN, string strIdPubCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubCaseType, 4, conPubClassCase.IdPubCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubCaseType, 4, conPubClassCase.IdPubCaseType);
}
objPubClassCaseEN.IdPubCaseType = strIdPubCaseType; //公开课案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IdPubCaseType) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IdPubCaseType, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IdPubCaseType] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIdStudyLevel(this clsPubClassCaseEN objPubClassCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conPubClassCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conPubClassCase.IdStudyLevel);
}
objPubClassCaseEN.IdStudyLevel = strIdStudyLevel; //学段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IdStudyLevel) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IdStudyLevel, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IdStudyLevel] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetCDID(this clsPubClassCaseEN objPubClassCaseEN, string strCDID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCDID, 50, conPubClassCase.CDID);
}
objPubClassCaseEN.CDID = strCDID; //光盘编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.CDID) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.CDID, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.CDID] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIntroduction(this clsPubClassCaseEN objPubClassCaseEN, string strIntroduction, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIntroduction, 4000, conPubClassCase.Introduction);
}
objPubClassCaseEN.Introduction = strIntroduction; //简要介绍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.Introduction) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.Introduction, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.Introduction] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIsVisible(this clsPubClassCaseEN objPubClassCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objPubClassCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IsVisible) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IsVisible, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IsVisible] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetIsDualVideo(this clsPubClassCaseEN objPubClassCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objPubClassCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.IsDualVideo) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.IsDualVideo, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.IsDualVideo] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetRecommendedDegreeId(this clsPubClassCaseEN objPubClassCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conPubClassCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conPubClassCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conPubClassCase.RecommendedDegreeId);
}
objPubClassCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.RecommendedDegreeId) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetftpFileType(this clsPubClassCaseEN objPubClassCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conPubClassCase.ftpFileType);
}
objPubClassCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.ftpFileType) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.ftpFileType, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.ftpFileType] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetVideoUrl(this clsPubClassCaseEN objPubClassCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conPubClassCase.VideoUrl);
}
objPubClassCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.VideoUrl) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.VideoUrl, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.VideoUrl] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetVideoPath(this clsPubClassCaseEN objPubClassCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conPubClassCase.VideoPath);
}
objPubClassCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.VideoPath) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.VideoPath, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.VideoPath] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetResErrMsg(this clsPubClassCaseEN objPubClassCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conPubClassCase.ResErrMsg);
}
objPubClassCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.ResErrMsg) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.ResErrMsg, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.ResErrMsg] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetUpdDate(this clsPubClassCaseEN objPubClassCaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conPubClassCase.UpdDate);
}
objPubClassCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.UpdDate) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.UpdDate, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.UpdDate] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetUpdUserId(this clsPubClassCaseEN objPubClassCaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conPubClassCase.UpdUserId);
}
objPubClassCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.UpdUserId) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.UpdUserId, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.UpdUserId] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseEN SetMemo(this clsPubClassCaseEN objPubClassCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conPubClassCase.Memo);
}
objPubClassCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseEN.dicFldComparisonOp.ContainsKey(conPubClassCase.Memo) == false)
{
objPubClassCaseEN.dicFldComparisonOp.Add(conPubClassCase.Memo, strComparisonOp);
}
else
{
objPubClassCaseEN.dicFldComparisonOp[conPubClassCase.Memo] = strComparisonOp;
}
}
return objPubClassCaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPubClassCaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPubClassCaseEN objPubClassCaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPubClassCaseEN.CheckPropertyNew();
clsPubClassCaseEN objPubClassCaseCond = new clsPubClassCaseEN();
string strCondition = objPubClassCaseCond
.SetIdPubClassCase(objPubClassCaseEN.IdPubClassCase, "=")
.GetCombineCondition();
objPubClassCaseEN._IsCheckProperty = true;
bool bolIsExist = clsPubClassCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPubClassCaseEN.Update();
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseEN objPubClassCaseEN)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseBL.PubClassCaseDA.UpdateBySql2(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseEN objPubClassCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseBL.PubClassCaseDA.UpdateBySql2(objPubClassCaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseEN objPubClassCaseEN, string strWhereCond)
{
try
{
bool bolResult = clsPubClassCaseBL.PubClassCaseDA.UpdateBySqlWithCondition(objPubClassCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseEN objPubClassCaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPubClassCaseBL.PubClassCaseDA.UpdateBySqlWithConditionTransaction(objPubClassCaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPubClassCaseEN objPubClassCaseEN)
{
try
{
int intRecNum = clsPubClassCaseBL.PubClassCaseDA.DelRecord(objPubClassCaseEN.IdPubClassCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseENS">源对象</param>
 /// <param name = "objPubClassCaseENT">目标对象</param>
 public static void CopyTo(this clsPubClassCaseEN objPubClassCaseENS, clsPubClassCaseEN objPubClassCaseENT)
{
try
{
objPubClassCaseENT.IdPubClassCase = objPubClassCaseENS.IdPubClassCase; //案例流水号
objPubClassCaseENT.PubClassCaseID = objPubClassCaseENS.PubClassCaseID; //案例ID
objPubClassCaseENT.PubClassCaseName = objPubClassCaseENS.PubClassCaseName; //案例课题名称
objPubClassCaseENT.PubClassCaseExecutor = objPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objPubClassCaseENT.WorkUnit = objPubClassCaseENS.WorkUnit; //工作单位
objPubClassCaseENT.PubClassCaseTheme = objPubClassCaseENS.PubClassCaseTheme; //案例主题词
objPubClassCaseENT.PubClassCaseBG = objPubClassCaseENS.PubClassCaseBG; //案例背景资料
objPubClassCaseENT.PubClassCaseTeachDate = objPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objPubClassCaseENT.PubClassCaseDateIn = objPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objPubClassCaseENT.IdDiscipline = objPubClassCaseENS.IdDiscipline; //学科流水号
objPubClassCaseENT.IdTeachingPlan = objPubClassCaseENS.IdTeachingPlan; //教案流水号
objPubClassCaseENT.PubClassCaseTimeIn = objPubClassCaseENS.PubClassCaseTimeIn; //案例入库时间
objPubClassCaseENT.IdPubClassCaseSenateGaugeVersion = objPubClassCaseENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objPubClassCaseENT.BrowseCount = objPubClassCaseENS.BrowseCount; //浏览次数
objPubClassCaseENT.IdPubCaseType = objPubClassCaseENS.IdPubCaseType; //公开课案例类型流水号
objPubClassCaseENT.IdStudyLevel = objPubClassCaseENS.IdStudyLevel; //学段流水号
objPubClassCaseENT.CDID = objPubClassCaseENS.CDID; //光盘编号
objPubClassCaseENT.Introduction = objPubClassCaseENS.Introduction; //简要介绍
objPubClassCaseENT.IsVisible = objPubClassCaseENS.IsVisible; //是否显示
objPubClassCaseENT.IsDualVideo = objPubClassCaseENS.IsDualVideo; //是否双视频
objPubClassCaseENT.RecommendedDegreeId = objPubClassCaseENS.RecommendedDegreeId; //推荐度Id
objPubClassCaseENT.ftpFileType = objPubClassCaseENS.ftpFileType; //ftp文件类型
objPubClassCaseENT.VideoUrl = objPubClassCaseENS.VideoUrl; //视频Url
objPubClassCaseENT.VideoPath = objPubClassCaseENS.VideoPath; //视频目录
objPubClassCaseENT.ResErrMsg = objPubClassCaseENS.ResErrMsg; //资源错误信息
objPubClassCaseENT.UpdDate = objPubClassCaseENS.UpdDate; //修改日期
objPubClassCaseENT.UpdUserId = objPubClassCaseENS.UpdUserId; //修改用户Id
objPubClassCaseENT.Memo = objPubClassCaseENS.Memo; //备注
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
 /// <param name = "objPubClassCaseENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCaseEN:objPubClassCaseENT</returns>
 public static clsPubClassCaseEN CopyTo(this clsPubClassCaseEN objPubClassCaseENS)
{
try
{
 clsPubClassCaseEN objPubClassCaseENT = new clsPubClassCaseEN()
{
IdPubClassCase = objPubClassCaseENS.IdPubClassCase, //案例流水号
PubClassCaseID = objPubClassCaseENS.PubClassCaseID, //案例ID
PubClassCaseName = objPubClassCaseENS.PubClassCaseName, //案例课题名称
PubClassCaseExecutor = objPubClassCaseENS.PubClassCaseExecutor, //案例执教者
WorkUnit = objPubClassCaseENS.WorkUnit, //工作单位
PubClassCaseTheme = objPubClassCaseENS.PubClassCaseTheme, //案例主题词
PubClassCaseBG = objPubClassCaseENS.PubClassCaseBG, //案例背景资料
PubClassCaseTeachDate = objPubClassCaseENS.PubClassCaseTeachDate, //案例授课日期
PubClassCaseDateIn = objPubClassCaseENS.PubClassCaseDateIn, //案例入库日期
IdDiscipline = objPubClassCaseENS.IdDiscipline, //学科流水号
IdTeachingPlan = objPubClassCaseENS.IdTeachingPlan, //教案流水号
PubClassCaseTimeIn = objPubClassCaseENS.PubClassCaseTimeIn, //案例入库时间
IdPubClassCaseSenateGaugeVersion = objPubClassCaseENS.IdPubClassCaseSenateGaugeVersion, //公开课量表版本流水号
BrowseCount = objPubClassCaseENS.BrowseCount, //浏览次数
IdPubCaseType = objPubClassCaseENS.IdPubCaseType, //公开课案例类型流水号
IdStudyLevel = objPubClassCaseENS.IdStudyLevel, //学段流水号
CDID = objPubClassCaseENS.CDID, //光盘编号
Introduction = objPubClassCaseENS.Introduction, //简要介绍
IsVisible = objPubClassCaseENS.IsVisible, //是否显示
IsDualVideo = objPubClassCaseENS.IsDualVideo, //是否双视频
RecommendedDegreeId = objPubClassCaseENS.RecommendedDegreeId, //推荐度Id
ftpFileType = objPubClassCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objPubClassCaseENS.VideoUrl, //视频Url
VideoPath = objPubClassCaseENS.VideoPath, //视频目录
ResErrMsg = objPubClassCaseENS.ResErrMsg, //资源错误信息
UpdDate = objPubClassCaseENS.UpdDate, //修改日期
UpdUserId = objPubClassCaseENS.UpdUserId, //修改用户Id
Memo = objPubClassCaseENS.Memo, //备注
};
 return objPubClassCaseENT;
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
public static void CheckPropertyNew(this clsPubClassCaseEN objPubClassCaseEN)
{
 clsPubClassCaseBL.PubClassCaseDA.CheckPropertyNew(objPubClassCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPubClassCaseEN objPubClassCaseEN)
{
 clsPubClassCaseBL.PubClassCaseDA.CheckProperty4Condition(objPubClassCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCaseEN objPubClassCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IdPubClassCase) == true)
{
string strComparisonOpIdPubClassCase = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.IdPubClassCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.IdPubClassCase, objPubClassCaseCond.IdPubClassCase, strComparisonOpIdPubClassCase);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.PubClassCaseID) == true)
{
string strComparisonOpPubClassCaseID = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.PubClassCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseID, objPubClassCaseCond.PubClassCaseID, strComparisonOpPubClassCaseID);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.PubClassCaseName) == true)
{
string strComparisonOpPubClassCaseName = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.PubClassCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseName, objPubClassCaseCond.PubClassCaseName, strComparisonOpPubClassCaseName);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.PubClassCaseExecutor) == true)
{
string strComparisonOpPubClassCaseExecutor = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.PubClassCaseExecutor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseExecutor, objPubClassCaseCond.PubClassCaseExecutor, strComparisonOpPubClassCaseExecutor);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.WorkUnit, objPubClassCaseCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.PubClassCaseTheme) == true)
{
string strComparisonOpPubClassCaseTheme = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.PubClassCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseTheme, objPubClassCaseCond.PubClassCaseTheme, strComparisonOpPubClassCaseTheme);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objPubClassCaseCond.IsUpdated(conPubClassCase.PubClassCaseTeachDate) == true)
{
string strComparisonOpPubClassCaseTeachDate = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.PubClassCaseTeachDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseTeachDate, objPubClassCaseCond.PubClassCaseTeachDate, strComparisonOpPubClassCaseTeachDate);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.PubClassCaseDateIn) == true)
{
string strComparisonOpPubClassCaseDateIn = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.PubClassCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseDateIn, objPubClassCaseCond.PubClassCaseDateIn, strComparisonOpPubClassCaseDateIn);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.IdDiscipline, objPubClassCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.IdTeachingPlan, objPubClassCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.PubClassCaseTimeIn) == true)
{
string strComparisonOpPubClassCaseTimeIn = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.PubClassCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.PubClassCaseTimeIn, objPubClassCaseCond.PubClassCaseTimeIn, strComparisonOpPubClassCaseTimeIn);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IdPubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOpIdPubClassCaseSenateGaugeVersion = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.IdPubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.IdPubClassCaseSenateGaugeVersion, objPubClassCaseCond.IdPubClassCaseSenateGaugeVersion, strComparisonOpIdPubClassCaseSenateGaugeVersion);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCase.BrowseCount, objPubClassCaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IdPubCaseType) == true)
{
string strComparisonOpIdPubCaseType = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.IdPubCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.IdPubCaseType, objPubClassCaseCond.IdPubCaseType, strComparisonOpIdPubCaseType);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.IdStudyLevel, objPubClassCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.CDID) == true)
{
string strComparisonOpCDID = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.CDID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.CDID, objPubClassCaseCond.CDID, strComparisonOpCDID);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.Introduction) == true)
{
string strComparisonOpIntroduction = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.Introduction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.Introduction, objPubClassCaseCond.Introduction, strComparisonOpIntroduction);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IsVisible) == true)
{
if (objPubClassCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCase.IsVisible);
}
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.IsDualVideo) == true)
{
if (objPubClassCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCase.IsDualVideo);
}
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.RecommendedDegreeId, objPubClassCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.ftpFileType, objPubClassCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.VideoUrl, objPubClassCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.VideoPath, objPubClassCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.ResErrMsg, objPubClassCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.UpdDate) == true)
{
string strComparisonOpUpdDate = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.UpdDate, objPubClassCaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.UpdUserId, objPubClassCaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objPubClassCaseCond.IsUpdated(conPubClassCase.Memo) == true)
{
string strComparisonOpMemo = objPubClassCaseCond.dicFldComparisonOp[conPubClassCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCase.Memo, objPubClassCaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PubClassCase
{
public virtual bool UpdRelaTabDate(string strIdPubClassCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 公开课案例(PubClassCase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCaseBL
{
public static RelatedActions_PubClassCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPubClassCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPubClassCaseDA PubClassCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPubClassCaseDA();
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
 public clsPubClassCaseBL()
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
if (string.IsNullOrEmpty(clsPubClassCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseEN._ConnectString);
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
public static DataTable GetDataTable_PubClassCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PubClassCaseDA.GetDataTable_PubClassCase(strWhereCond);
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
objDT = PubClassCaseDA.GetDataTable(strWhereCond);
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
objDT = PubClassCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PubClassCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PubClassCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PubClassCaseDA.GetDataTable_Top(objTopPara);
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
objDT = PubClassCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PubClassCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PubClassCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLstByIdPubClassCaseLst(List<string> arrIdPubClassCaseLst)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseLst, true);
 string strWhereCond = string.Format("IdPubClassCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPubClassCaseEN> GetObjLstByIdPubClassCaseLstCache(List<string> arrIdPubClassCaseLst)
{
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName);
List<clsPubClassCaseEN> arrPubClassCaseObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel =
arrPubClassCaseObjLstCache
.Where(x => arrIdPubClassCaseLst.Contains(x.IdPubClassCase));
return arrPubClassCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLst(string strWhereCond)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
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
public static List<clsPubClassCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPubClassCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPubClassCaseEN> GetSubObjLstCache(clsPubClassCaseEN objPubClassCaseCond)
{
List<clsPubClassCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCase.AttributeName)
{
if (objPubClassCaseCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseCond[strFldName].ToString());
}
else
{
if (objPubClassCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseCond[strFldName]));
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
public static List<clsPubClassCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
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
public static List<clsPubClassCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
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
List<clsPubClassCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPubClassCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPubClassCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
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
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
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
public static List<clsPubClassCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPubClassCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
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
public static List<clsPubClassCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPubClassCaseEN> arrObjLst = new List<clsPubClassCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseEN objPubClassCaseEN = new clsPubClassCaseEN();
try
{
objPubClassCaseEN.IdPubClassCase = objRow[conPubClassCase.IdPubClassCase].ToString().Trim(); //案例流水号
objPubClassCaseEN.PubClassCaseID = objRow[conPubClassCase.PubClassCaseID].ToString().Trim(); //案例ID
objPubClassCaseEN.PubClassCaseName = objRow[conPubClassCase.PubClassCaseName].ToString().Trim(); //案例课题名称
objPubClassCaseEN.PubClassCaseExecutor = objRow[conPubClassCase.PubClassCaseExecutor] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objPubClassCaseEN.WorkUnit = objRow[conPubClassCase.WorkUnit] == DBNull.Value ? null : objRow[conPubClassCase.WorkUnit].ToString().Trim(); //工作单位
objPubClassCaseEN.PubClassCaseTheme = objRow[conPubClassCase.PubClassCaseTheme] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTheme].ToString().Trim(); //案例主题词
objPubClassCaseEN.PubClassCaseBG = objRow[conPubClassCase.PubClassCaseBG] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseBG].ToString().Trim(); //案例背景资料
objPubClassCaseEN.PubClassCaseTeachDate = objRow[conPubClassCase.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objPubClassCaseEN.PubClassCaseDateIn = objRow[conPubClassCase.PubClassCaseDateIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objPubClassCaseEN.IdDiscipline = objRow[conPubClassCase.IdDiscipline].ToString().Trim(); //学科流水号
objPubClassCaseEN.IdTeachingPlan = objRow[conPubClassCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conPubClassCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objPubClassCaseEN.PubClassCaseTimeIn = objRow[conPubClassCase.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[conPubClassCase.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCase.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseEN.BrowseCount = objRow[conPubClassCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCase.BrowseCount].ToString().Trim()); //浏览次数
objPubClassCaseEN.IdPubCaseType = objRow[conPubClassCase.IdPubCaseType] == DBNull.Value ? null : objRow[conPubClassCase.IdPubCaseType].ToString().Trim(); //公开课案例类型流水号
objPubClassCaseEN.IdStudyLevel = objRow[conPubClassCase.IdStudyLevel] == DBNull.Value ? null : objRow[conPubClassCase.IdStudyLevel].ToString().Trim(); //学段流水号
objPubClassCaseEN.CDID = objRow[conPubClassCase.CDID] == DBNull.Value ? null : objRow[conPubClassCase.CDID].ToString().Trim(); //光盘编号
objPubClassCaseEN.Introduction = objRow[conPubClassCase.Introduction] == DBNull.Value ? null : objRow[conPubClassCase.Introduction].ToString().Trim(); //简要介绍
objPubClassCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsVisible].ToString().Trim()); //是否显示
objPubClassCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCase.IsDualVideo].ToString().Trim()); //是否双视频
objPubClassCaseEN.RecommendedDegreeId = objRow[conPubClassCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objPubClassCaseEN.ftpFileType = objRow[conPubClassCase.ftpFileType] == DBNull.Value ? null : objRow[conPubClassCase.ftpFileType].ToString().Trim(); //ftp文件类型
objPubClassCaseEN.VideoUrl = objRow[conPubClassCase.VideoUrl] == DBNull.Value ? null : objRow[conPubClassCase.VideoUrl].ToString().Trim(); //视频Url
objPubClassCaseEN.VideoPath = objRow[conPubClassCase.VideoPath] == DBNull.Value ? null : objRow[conPubClassCase.VideoPath].ToString().Trim(); //视频目录
objPubClassCaseEN.ResErrMsg = objRow[conPubClassCase.ResErrMsg] == DBNull.Value ? null : objRow[conPubClassCase.ResErrMsg].ToString().Trim(); //资源错误信息
objPubClassCaseEN.UpdDate = objRow[conPubClassCase.UpdDate] == DBNull.Value ? null : objRow[conPubClassCase.UpdDate].ToString().Trim(); //修改日期
objPubClassCaseEN.UpdUserId = objRow[conPubClassCase.UpdUserId] == DBNull.Value ? null : objRow[conPubClassCase.UpdUserId].ToString().Trim(); //修改用户Id
objPubClassCaseEN.Memo = objRow[conPubClassCase.Memo] == DBNull.Value ? null : objRow[conPubClassCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseEN.IdPubClassCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPubClassCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPubClassCase(ref clsPubClassCaseEN objPubClassCaseEN)
{
bool bolResult = PubClassCaseDA.GetPubClassCase(ref objPubClassCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseEN GetObjByIdPubClassCase(string strIdPubClassCase)
{
if (strIdPubClassCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdPubClassCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdPubClassCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdPubClassCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPubClassCaseEN objPubClassCaseEN = PubClassCaseDA.GetObjByIdPubClassCase(strIdPubClassCase);
return objPubClassCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPubClassCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPubClassCaseEN objPubClassCaseEN = PubClassCaseDA.GetFirstObj(strWhereCond);
 return objPubClassCaseEN;
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
public static clsPubClassCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPubClassCaseEN objPubClassCaseEN = PubClassCaseDA.GetObjByDataRow(objRow);
 return objPubClassCaseEN;
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
public static clsPubClassCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPubClassCaseEN objPubClassCaseEN = PubClassCaseDA.GetObjByDataRow(objRow);
 return objPubClassCaseEN;
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
 /// <param name = "strIdPubClassCase">所给的关键字</param>
 /// <param name = "lstPubClassCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseEN GetObjByIdPubClassCaseFromList(string strIdPubClassCase, List<clsPubClassCaseEN> lstPubClassCaseObjLst)
{
foreach (clsPubClassCaseEN objPubClassCaseEN in lstPubClassCaseObjLst)
{
if (objPubClassCaseEN.IdPubClassCase == strIdPubClassCase)
{
return objPubClassCaseEN;
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
 string strIdPubClassCase;
 try
 {
 strIdPubClassCase = new clsPubClassCaseDA().GetFirstID(strWhereCond);
 return strIdPubClassCase;
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
 arrList = PubClassCaseDA.GetID(strWhereCond);
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
bool bolIsExist = PubClassCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdPubClassCase)
{
if (string.IsNullOrEmpty(strIdPubClassCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdPubClassCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PubClassCaseDA.IsExist(strIdPubClassCase);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdPubClassCase">案例流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdPubClassCase, string strOpUser)
{
clsPubClassCaseEN objPubClassCaseEN = clsPubClassCaseBL.GetObjByIdPubClassCase(strIdPubClassCase);
objPubClassCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objPubClassCaseEN.UpdUserId = strOpUser;
return clsPubClassCaseBL.UpdateBySql2(objPubClassCaseEN);
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
 bolIsExist = clsPubClassCaseDA.IsExistTable();
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
 bolIsExist = PubClassCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPubClassCaseEN objPubClassCaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseBL.IsExist(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseEN.IdPubClassCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = PubClassCaseDA.AddNewRecordBySQL2(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPubClassCaseEN objPubClassCaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseBL.IsExist(objPubClassCaseEN.IdPubClassCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseEN.IdPubClassCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = PubClassCaseDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPubClassCaseEN objPubClassCaseEN)
{
try
{
bool bolResult = PubClassCaseDA.Update(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "objPubClassCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPubClassCaseEN objPubClassCaseEN)
{
 if (string.IsNullOrEmpty(objPubClassCaseEN.IdPubClassCase) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PubClassCaseDA.UpdateBySql2(objPubClassCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseBL.ReFreshCache();

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
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
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdPubClassCase)
{
try
{
 clsPubClassCaseEN objPubClassCaseEN = clsPubClassCaseBL.GetObjByIdPubClassCase(strIdPubClassCase);

if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(objPubClassCaseEN.IdPubClassCase, objPubClassCaseEN.UpdUserId);
}
if (objPubClassCaseEN != null)
{
int intRecNum = PubClassCaseDA.DelRecord(strIdPubClassCase);
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
/// <param name="strIdPubClassCase">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdPubClassCase )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
//删除与表:[PubClassCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPubClassCase.IdPubClassCase,
//strIdPubClassCase);
//        clsPubClassCaseBL.DelPubClassCasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseBL.DelRecord(strIdPubClassCase, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdPubClassCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdPubClassCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdPubClassCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPubClassCaseBL.relatedActions != null)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(strIdPubClassCase, "UpdRelaTabDate");
}
bool bolResult = PubClassCaseDA.DelRecord(strIdPubClassCase,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdPubClassCaseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPubClassCases(List<string> arrIdPubClassCaseLst)
{
if (arrIdPubClassCaseLst.Count == 0) return 0;
try
{
if (clsPubClassCaseBL.relatedActions != null)
{
foreach (var strIdPubClassCase in arrIdPubClassCaseLst)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(strIdPubClassCase, "UpdRelaTabDate");
}
}
int intDelRecNum = PubClassCaseDA.DelPubClassCase(arrIdPubClassCaseLst);
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
public static int DelPubClassCasesByCond(string strWhereCond)
{
try
{
if (clsPubClassCaseBL.relatedActions != null)
{
List<string> arrIdPubClassCase = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPubClassCase in arrIdPubClassCase)
{
clsPubClassCaseBL.relatedActions.UpdRelaTabDate(strIdPubClassCase, "UpdRelaTabDate");
}
}
int intRecNum = PubClassCaseDA.DelPubClassCase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PubClassCase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdPubClassCase">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdPubClassCase)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseDA.GetSpecSQLObj();
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
//删除与表:[PubClassCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseBL.DelRecord(strIdPubClassCase, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdPubClassCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPubClassCaseENS">源对象</param>
 /// <param name = "objPubClassCaseENT">目标对象</param>
 public static void CopyTo(clsPubClassCaseEN objPubClassCaseENS, clsPubClassCaseEN objPubClassCaseENT)
{
try
{
objPubClassCaseENT.IdPubClassCase = objPubClassCaseENS.IdPubClassCase; //案例流水号
objPubClassCaseENT.PubClassCaseID = objPubClassCaseENS.PubClassCaseID; //案例ID
objPubClassCaseENT.PubClassCaseName = objPubClassCaseENS.PubClassCaseName; //案例课题名称
objPubClassCaseENT.PubClassCaseExecutor = objPubClassCaseENS.PubClassCaseExecutor; //案例执教者
objPubClassCaseENT.WorkUnit = objPubClassCaseENS.WorkUnit; //工作单位
objPubClassCaseENT.PubClassCaseTheme = objPubClassCaseENS.PubClassCaseTheme; //案例主题词
objPubClassCaseENT.PubClassCaseBG = objPubClassCaseENS.PubClassCaseBG; //案例背景资料
objPubClassCaseENT.PubClassCaseTeachDate = objPubClassCaseENS.PubClassCaseTeachDate; //案例授课日期
objPubClassCaseENT.PubClassCaseDateIn = objPubClassCaseENS.PubClassCaseDateIn; //案例入库日期
objPubClassCaseENT.IdDiscipline = objPubClassCaseENS.IdDiscipline; //学科流水号
objPubClassCaseENT.IdTeachingPlan = objPubClassCaseENS.IdTeachingPlan; //教案流水号
objPubClassCaseENT.PubClassCaseTimeIn = objPubClassCaseENS.PubClassCaseTimeIn; //案例入库时间
objPubClassCaseENT.IdPubClassCaseSenateGaugeVersion = objPubClassCaseENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objPubClassCaseENT.BrowseCount = objPubClassCaseENS.BrowseCount; //浏览次数
objPubClassCaseENT.IdPubCaseType = objPubClassCaseENS.IdPubCaseType; //公开课案例类型流水号
objPubClassCaseENT.IdStudyLevel = objPubClassCaseENS.IdStudyLevel; //学段流水号
objPubClassCaseENT.CDID = objPubClassCaseENS.CDID; //光盘编号
objPubClassCaseENT.Introduction = objPubClassCaseENS.Introduction; //简要介绍
objPubClassCaseENT.IsVisible = objPubClassCaseENS.IsVisible; //是否显示
objPubClassCaseENT.IsDualVideo = objPubClassCaseENS.IsDualVideo; //是否双视频
objPubClassCaseENT.RecommendedDegreeId = objPubClassCaseENS.RecommendedDegreeId; //推荐度Id
objPubClassCaseENT.ftpFileType = objPubClassCaseENS.ftpFileType; //ftp文件类型
objPubClassCaseENT.VideoUrl = objPubClassCaseENS.VideoUrl; //视频Url
objPubClassCaseENT.VideoPath = objPubClassCaseENS.VideoPath; //视频目录
objPubClassCaseENT.ResErrMsg = objPubClassCaseENS.ResErrMsg; //资源错误信息
objPubClassCaseENT.UpdDate = objPubClassCaseENS.UpdDate; //修改日期
objPubClassCaseENT.UpdUserId = objPubClassCaseENS.UpdUserId; //修改用户Id
objPubClassCaseENT.Memo = objPubClassCaseENS.Memo; //备注
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
 /// <param name = "objPubClassCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsPubClassCaseEN objPubClassCaseEN)
{
try
{
objPubClassCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPubClassCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPubClassCase.IdPubClassCase, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IdPubClassCase = objPubClassCaseEN.IdPubClassCase; //案例流水号
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseID = objPubClassCaseEN.PubClassCaseID; //案例ID
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseName = objPubClassCaseEN.PubClassCaseName; //案例课题名称
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseExecutor, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseExecutor = objPubClassCaseEN.PubClassCaseExecutor == "[null]" ? null :  objPubClassCaseEN.PubClassCaseExecutor; //案例执教者
}
if (arrFldSet.Contains(conPubClassCase.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.WorkUnit = objPubClassCaseEN.WorkUnit == "[null]" ? null :  objPubClassCaseEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseTheme = objPubClassCaseEN.PubClassCaseTheme == "[null]" ? null :  objPubClassCaseEN.PubClassCaseTheme; //案例主题词
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseBG, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseBG = objPubClassCaseEN.PubClassCaseBG == "[null]" ? null :  objPubClassCaseEN.PubClassCaseBG; //案例背景资料
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseTeachDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseTeachDate = objPubClassCaseEN.PubClassCaseTeachDate == "[null]" ? null :  objPubClassCaseEN.PubClassCaseTeachDate; //案例授课日期
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseDateIn = objPubClassCaseEN.PubClassCaseDateIn == "[null]" ? null :  objPubClassCaseEN.PubClassCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(conPubClassCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IdDiscipline = objPubClassCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(conPubClassCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IdTeachingPlan = objPubClassCaseEN.IdTeachingPlan == "[null]" ? null :  objPubClassCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conPubClassCase.PubClassCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.PubClassCaseTimeIn = objPubClassCaseEN.PubClassCaseTimeIn == "[null]" ? null :  objPubClassCaseEN.PubClassCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(conPubClassCase.IdPubClassCaseSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion = objPubClassCaseEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
}
if (arrFldSet.Contains(conPubClassCase.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.BrowseCount = objPubClassCaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conPubClassCase.IdPubCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IdPubCaseType = objPubClassCaseEN.IdPubCaseType == "[null]" ? null :  objPubClassCaseEN.IdPubCaseType; //公开课案例类型流水号
}
if (arrFldSet.Contains(conPubClassCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IdStudyLevel = objPubClassCaseEN.IdStudyLevel == "[null]" ? null :  objPubClassCaseEN.IdStudyLevel; //学段流水号
}
if (arrFldSet.Contains(conPubClassCase.CDID, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.CDID = objPubClassCaseEN.CDID == "[null]" ? null :  objPubClassCaseEN.CDID; //光盘编号
}
if (arrFldSet.Contains(conPubClassCase.Introduction, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.Introduction = objPubClassCaseEN.Introduction == "[null]" ? null :  objPubClassCaseEN.Introduction; //简要介绍
}
if (arrFldSet.Contains(conPubClassCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IsVisible = objPubClassCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conPubClassCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.IsDualVideo = objPubClassCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(conPubClassCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.RecommendedDegreeId = objPubClassCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(conPubClassCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.ftpFileType = objPubClassCaseEN.ftpFileType == "[null]" ? null :  objPubClassCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(conPubClassCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.VideoUrl = objPubClassCaseEN.VideoUrl == "[null]" ? null :  objPubClassCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(conPubClassCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.VideoPath = objPubClassCaseEN.VideoPath == "[null]" ? null :  objPubClassCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(conPubClassCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.ResErrMsg = objPubClassCaseEN.ResErrMsg == "[null]" ? null :  objPubClassCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(conPubClassCase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.UpdDate = objPubClassCaseEN.UpdDate == "[null]" ? null :  objPubClassCaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conPubClassCase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.UpdUserId = objPubClassCaseEN.UpdUserId == "[null]" ? null :  objPubClassCaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conPubClassCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseEN.Memo = objPubClassCaseEN.Memo == "[null]" ? null :  objPubClassCaseEN.Memo; //备注
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
 /// <param name = "objPubClassCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsPubClassCaseEN objPubClassCaseEN)
{
try
{
if (objPubClassCaseEN.PubClassCaseExecutor == "[null]") objPubClassCaseEN.PubClassCaseExecutor = null; //案例执教者
if (objPubClassCaseEN.WorkUnit == "[null]") objPubClassCaseEN.WorkUnit = null; //工作单位
if (objPubClassCaseEN.PubClassCaseTheme == "[null]") objPubClassCaseEN.PubClassCaseTheme = null; //案例主题词
if (objPubClassCaseEN.PubClassCaseBG == "[null]") objPubClassCaseEN.PubClassCaseBG = null; //案例背景资料
if (objPubClassCaseEN.PubClassCaseTeachDate == "[null]") objPubClassCaseEN.PubClassCaseTeachDate = null; //案例授课日期
if (objPubClassCaseEN.PubClassCaseDateIn == "[null]") objPubClassCaseEN.PubClassCaseDateIn = null; //案例入库日期
if (objPubClassCaseEN.IdTeachingPlan == "[null]") objPubClassCaseEN.IdTeachingPlan = null; //教案流水号
if (objPubClassCaseEN.PubClassCaseTimeIn == "[null]") objPubClassCaseEN.PubClassCaseTimeIn = null; //案例入库时间
if (objPubClassCaseEN.IdPubCaseType == "[null]") objPubClassCaseEN.IdPubCaseType = null; //公开课案例类型流水号
if (objPubClassCaseEN.IdStudyLevel == "[null]") objPubClassCaseEN.IdStudyLevel = null; //学段流水号
if (objPubClassCaseEN.CDID == "[null]") objPubClassCaseEN.CDID = null; //光盘编号
if (objPubClassCaseEN.Introduction == "[null]") objPubClassCaseEN.Introduction = null; //简要介绍
if (objPubClassCaseEN.ftpFileType == "[null]") objPubClassCaseEN.ftpFileType = null; //ftp文件类型
if (objPubClassCaseEN.VideoUrl == "[null]") objPubClassCaseEN.VideoUrl = null; //视频Url
if (objPubClassCaseEN.VideoPath == "[null]") objPubClassCaseEN.VideoPath = null; //视频目录
if (objPubClassCaseEN.ResErrMsg == "[null]") objPubClassCaseEN.ResErrMsg = null; //资源错误信息
if (objPubClassCaseEN.UpdDate == "[null]") objPubClassCaseEN.UpdDate = null; //修改日期
if (objPubClassCaseEN.UpdUserId == "[null]") objPubClassCaseEN.UpdUserId = null; //修改用户Id
if (objPubClassCaseEN.Memo == "[null]") objPubClassCaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsPubClassCaseEN objPubClassCaseEN)
{
 PubClassCaseDA.CheckPropertyNew(objPubClassCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPubClassCaseEN objPubClassCaseEN)
{
 PubClassCaseDA.CheckProperty4Condition(objPubClassCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdPubClassCaseCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[公开课案例]...","0");
List<clsPubClassCaseEN> arrPubClassCaseObjLst = GetAllPubClassCaseObjLstCache(); 
objDDL.DataValueField = conPubClassCase.IdPubClassCase;
objDDL.DataTextField = conPubClassCase.PubClassCaseName;
objDDL.DataSource = arrPubClassCaseObjLst;
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
if (clsPubClassCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseBL没有刷新缓存机制(clsPubClassCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCase");
//if (arrPubClassCaseObjLstCache == null)
//{
//arrPubClassCaseObjLstCache = PubClassCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseEN GetObjByIdPubClassCaseCache(string strIdPubClassCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName);
List<clsPubClassCaseEN> arrPubClassCaseObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseEN> arrPubClassCaseObjLst_Sel =
arrPubClassCaseObjLstCache
.Where(x=> x.IdPubClassCase == strIdPubClassCase 
);
if (arrPubClassCaseObjLst_Sel.Count() == 0)
{
   clsPubClassCaseEN obj = clsPubClassCaseBL.GetObjByIdPubClassCase(strIdPubClassCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPubClassCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetPubClassCaseNameByIdPubClassCaseCache(string strIdPubClassCase)
{
if (string.IsNullOrEmpty(strIdPubClassCase) == true) return "";
//获取缓存中的对象列表
clsPubClassCaseEN objPubClassCase = GetObjByIdPubClassCaseCache(strIdPubClassCase);
if (objPubClassCase == null) return "";
return objPubClassCase.PubClassCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdPubClassCaseCache(string strIdPubClassCase)
{
if (string.IsNullOrEmpty(strIdPubClassCase) == true) return "";
//获取缓存中的对象列表
clsPubClassCaseEN objPubClassCase = GetObjByIdPubClassCaseCache(strIdPubClassCase);
if (objPubClassCase == null) return "";
return objPubClassCase.PubClassCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseEN> GetAllPubClassCaseObjLstCache()
{
//获取缓存中的对象列表
List<clsPubClassCaseEN> arrPubClassCaseObjLstCache = GetObjLstCache(); 
return arrPubClassCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName);
List<clsPubClassCaseEN> arrPubClassCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCaseObjLstCache;
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
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPubClassCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPubClassCaseEN._RefreshTimeLst.Count == 0) return "";
return clsPubClassCaseEN._RefreshTimeLst[clsPubClassCaseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPubClassCaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPubClassCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPubClassCaseBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdPubClassCase)
{
if (strInFldName != conPubClassCase.IdPubClassCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPubClassCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPubClassCase.AttributeName));
throw new Exception(strMsg);
}
var objPubClassCase = clsPubClassCaseBL.GetObjByIdPubClassCaseCache(strIdPubClassCase);
if (objPubClassCase == null) return "";
return objPubClassCase[strOutFldName].ToString();
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
int intRecCount = clsPubClassCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsPubClassCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPubClassCaseDA.GetRecCount();
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
int intRecCount = clsPubClassCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPubClassCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPubClassCaseEN objPubClassCaseCond)
{
List<clsPubClassCaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCase.AttributeName)
{
if (objPubClassCaseCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseCond[strFldName].ToString());
}
else
{
if (objPubClassCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseCond[strFldName]));
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
 List<string> arrList = clsPubClassCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PubClassCaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseDA.SetFldValue(clsPubClassCaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PubClassCaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PubClassCase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdPubClassCase char(8) primary key, "); 
 // /**案例ID*/ 
 strCreateTabCode.Append(" PubClassCaseID char(8) not Null, "); 
 // /**案例课题名称*/ 
 strCreateTabCode.Append(" PubClassCaseName varchar(200) not Null, "); 
 // /**案例执教者*/ 
 strCreateTabCode.Append(" PubClassCaseExecutor varchar(50) Null, "); 
 // /**工作单位*/ 
 strCreateTabCode.Append(" WorkUnit varchar(100) Null, "); 
 // /**案例主题词*/ 
 strCreateTabCode.Append(" PubClassCaseTheme varchar(500) Null, "); 
 // /**案例背景资料*/ 
 strCreateTabCode.Append(" PubClassCaseBG text Null, "); 
 // /**案例授课日期*/ 
 strCreateTabCode.Append(" PubClassCaseTeachDate char(8) Null, "); 
 // /**案例入库日期*/ 
 strCreateTabCode.Append(" PubClassCaseDateIn char(8) Null, "); 
 // /**学科流水号*/ 
 strCreateTabCode.Append(" IdDiscipline char(4) not Null, "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) Null, "); 
 // /**案例入库时间*/ 
 strCreateTabCode.Append(" PubClassCaseTimeIn char(6) Null, "); 
 // /**公开课量表版本流水号*/ 
 strCreateTabCode.Append(" IdPubClassCaseSenateGaugeVersion char(4) not Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**公开课案例类型流水号*/ 
 strCreateTabCode.Append(" IdPubCaseType char(4) Null, "); 
 // /**学段流水号*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) Null, "); 
 // /**光盘编号*/ 
 strCreateTabCode.Append(" CDID varchar(50) Null, "); 
 // /**简要介绍*/ 
 strCreateTabCode.Append(" Introduction varchar(4000) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**是否双视频*/ 
 strCreateTabCode.Append(" IsDualVideo bit Null, "); 
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
 /// 公开课案例(PubClassCase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PubClassCase : clsCommFun4BL
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
clsPubClassCaseBL.ReFreshThisCache();
}
}

}