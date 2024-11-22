
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCourseLearningCaseBL
 表名:CourseLearningCase(01120274)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsCourseLearningCaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCourseLearningCaseEN GetObj(this K_IdCourseLearningCase_CourseLearningCase myKey)
{
clsCourseLearningCaseEN objCourseLearningCaseEN = clsCourseLearningCaseBL.CourseLearningCaseDA.GetObjByIdCourseLearningCase(myKey.Value);
return objCourseLearningCaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCourseLearningCaseEN) == false)
{
var strMsg = string.Format("记录已经存在!课程学习案例ID = [{0}]的数据已经存在!(in clsCourseLearningCaseBL.AddNewRecord)", objCourseLearningCaseEN.CourseLearningCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true || clsCourseLearningCaseBL.IsExist(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
     objCourseLearningCaseEN.IdCourseLearningCase = clsCourseLearningCaseBL.GetMaxStrId_S();
 }
bool bolResult = clsCourseLearningCaseBL.CourseLearningCaseDA.AddNewRecordBySQL2(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
public static bool AddRecordEx(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsCourseLearningCaseBL.IsExist(objCourseLearningCaseEN.IdCourseLearningCase))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objCourseLearningCaseEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCourseLearningCaseEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课程学习案例ID(CourseLearningCaseID)=[{0}])已经存在,不能重复!", objCourseLearningCaseEN.CourseLearningCaseID);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true || clsCourseLearningCaseBL.IsExist(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
     objCourseLearningCaseEN.IdCourseLearningCase = clsCourseLearningCaseBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objCourseLearningCaseEN.AddNewRecord();
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCourseLearningCaseEN) == false)
{
var strMsg = string.Format("记录已经存在!课程学习案例ID = [{0}]的数据已经存在!(in clsCourseLearningCaseBL.AddNewRecordWithMaxId)", objCourseLearningCaseEN.CourseLearningCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true || clsCourseLearningCaseBL.IsExist(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
     objCourseLearningCaseEN.IdCourseLearningCase = clsCourseLearningCaseBL.GetMaxStrId_S();
 }
string strIdCourseLearningCase = clsCourseLearningCaseBL.CourseLearningCaseDA.AddNewRecordBySQL2WithReturnKey(objCourseLearningCaseEN);
     objCourseLearningCaseEN.IdCourseLearningCase = strIdCourseLearningCase;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
}
return strIdCourseLearningCase;
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCourseLearningCaseEN) == false)
{
var strMsg = string.Format("记录已经存在!课程学习案例ID = [{0}]的数据已经存在!(in clsCourseLearningCaseBL.AddNewRecordWithReturnKey)", objCourseLearningCaseEN.CourseLearningCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true || clsCourseLearningCaseBL.IsExist(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
     objCourseLearningCaseEN.IdCourseLearningCase = clsCourseLearningCaseBL.GetMaxStrId_S();
 }
string strKey = clsCourseLearningCaseBL.CourseLearningCaseDA.AddNewRecordBySQL2WithReturnKey(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdCourseLearningCase(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, conCourseLearningCase.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, conCourseLearningCase.IdCourseLearningCase);
}
objCourseLearningCaseEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdCourseLearningCase) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdCourseLearningCase, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdCourseLearningCase] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseID(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseID, conCourseLearningCase.CourseLearningCaseID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, conCourseLearningCase.CourseLearningCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, conCourseLearningCase.CourseLearningCaseID);
}
objCourseLearningCaseEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseID) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseID, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseID] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseName(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, conCourseLearningCase.CourseLearningCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, conCourseLearningCase.CourseLearningCaseName);
}
objCourseLearningCaseEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseName) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseName, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseName] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseText(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseText, 8000, conCourseLearningCase.CourseLearningCaseText);
}
objCourseLearningCaseEN.CourseLearningCaseText = strCourseLearningCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseText) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseText, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseText] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseTheme(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTheme, 200, conCourseLearningCase.CourseLearningCaseTheme);
}
objCourseLearningCaseEN.CourseLearningCaseTheme = strCourseLearningCaseTheme; //课程学习案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseTheme) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseTheme, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTheme] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseDate(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDate, 8, conCourseLearningCase.CourseLearningCaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDate, 8, conCourseLearningCase.CourseLearningCaseDate);
}
objCourseLearningCaseEN.CourseLearningCaseDate = strCourseLearningCaseDate; //课程学习日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseDate) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseDate, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDate] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseTime(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTime, 6, conCourseLearningCase.CourseLearningCaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTime, 6, conCourseLearningCase.CourseLearningCaseTime);
}
objCourseLearningCaseEN.CourseLearningCaseTime = strCourseLearningCaseTime; //课程学习时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseTime) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseTime, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTime] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseDateIn(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseDateIn, 8, conCourseLearningCase.CourseLearningCaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseDateIn, 8, conCourseLearningCase.CourseLearningCaseDateIn);
}
objCourseLearningCaseEN.CourseLearningCaseDateIn = strCourseLearningCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseDateIn) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseDateIn, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDateIn] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseLearningCaseTimeIn(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseLearningCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseTimeIn, 6, conCourseLearningCase.CourseLearningCaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseTimeIn, 6, conCourseLearningCase.CourseLearningCaseTimeIn);
}
objCourseLearningCaseEN.CourseLearningCaseTimeIn = strCourseLearningCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseLearningCaseTimeIn) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseLearningCaseTimeIn, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTimeIn] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdCaseType(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, conCourseLearningCase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, conCourseLearningCase.IdCaseType);
}
objCourseLearningCaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdCaseType) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdCaseType, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdCaseType] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdCourseLearningCaseType(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdCourseLearningCaseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCourseLearningCaseType, conCourseLearningCase.IdCourseLearningCaseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCaseType, 4, conCourseLearningCase.IdCourseLearningCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCaseType, 4, conCourseLearningCase.IdCourseLearningCaseType);
}
objCourseLearningCaseEN.IdCourseLearningCaseType = strIdCourseLearningCaseType; //课程学习案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdCourseLearningCaseType) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdCourseLearningCaseType, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdCourseLearningCaseType] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetOwnerId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conCourseLearningCase.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCourseLearningCase.OwnerId);
}
objCourseLearningCaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.OwnerId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.OwnerId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.OwnerId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdStudyLevel(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conCourseLearningCase.IdStudyLevel);
}
objCourseLearningCaseEN.IdStudyLevel = strIdStudyLevel; //学段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdStudyLevel) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdStudyLevel, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdStudyLevel] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdTeachingPlan(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conCourseLearningCase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conCourseLearningCase.IdTeachingPlan);
}
objCourseLearningCaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdTeachingPlan) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdTeachingPlan, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdTeachingPlan] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdDiscipline(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdDiscipline, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, conCourseLearningCase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, conCourseLearningCase.IdDiscipline);
}
objCourseLearningCaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdDiscipline) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdDiscipline, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdDiscipline] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetBrowseCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.BrowseCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.BrowseCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.BrowseCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdSenateGaugeVersion(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, conCourseLearningCase.IdSenateGaugeVersion);
}
objCourseLearningCaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdSenateGaugeVersion) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdTeachSkill(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, conCourseLearningCase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, conCourseLearningCase.IdTeachSkill);
}
objCourseLearningCaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdTeachSkill) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdTeachSkill, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdTeachSkill] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCaseLevelId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conCourseLearningCase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conCourseLearningCase.CaseLevelId);
}
objCourseLearningCaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CaseLevelId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CaseLevelId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CaseLevelId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetDocFile(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, conCourseLearningCase.DocFile);
}
objCourseLearningCaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.DocFile) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.DocFile, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.DocFile] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsNeedGeneWord(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsNeedGeneWord) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsNeedGeneWord, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsNeedGeneWord] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetWordCreateDate(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conCourseLearningCase.WordCreateDate);
}
objCourseLearningCaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.WordCreateDate) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.WordCreateDate, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.WordCreateDate] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsVisible(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsVisible) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsVisible, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsVisible] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsDualVideo(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsDualVideo) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsDualVideo, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsDualVideo] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdXzCollege(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conCourseLearningCase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conCourseLearningCase.IdXzCollege);
}
objCourseLearningCaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdXzCollege) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdXzCollege, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdXzCollege] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIdXzMajor(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strIdXzMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conCourseLearningCase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conCourseLearningCase.IdXzMajor);
}
objCourseLearningCaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IdXzMajor) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IdXzMajor, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IdXzMajor] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conCourseLearningCase.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCourseLearningCase.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCourseLearningCase.CourseId);
}
objCourseLearningCaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetTeachingSolutionId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strTeachingSolutionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, conCourseLearningCase.TeachingSolutionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, conCourseLearningCase.TeachingSolutionId);
}
objCourseLearningCaseEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.TeachingSolutionId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.TeachingSolutionId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.TeachingSolutionId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCourseChapterId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conCourseLearningCase.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conCourseLearningCase.CourseChapterId);
}
objCourseLearningCaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CourseChapterId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CourseChapterId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CourseChapterId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetViewCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, int? intViewCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ViewCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ViewCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ViewCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetIsShow(this clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsShow, string strComparisonOp="")
	{
objCourseLearningCaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.IsShow) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.IsShow, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.IsShow] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetDownloadNumber(this clsCourseLearningCaseEN objCourseLearningCaseEN, int? intDownloadNumber, string strComparisonOp="")
	{
objCourseLearningCaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.DownloadNumber) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.DownloadNumber, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.DownloadNumber] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetFileIntegration(this clsCourseLearningCaseEN objCourseLearningCaseEN, int? intFileIntegration, string strComparisonOp="")
	{
objCourseLearningCaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.FileIntegration) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.FileIntegration, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.FileIntegration] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetLikeCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.LikeCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.LikeCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.LikeCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetCollectionCount(this clsCourseLearningCaseEN objCourseLearningCaseEN, long? lngCollectionCount, string strComparisonOp="")
	{
objCourseLearningCaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.CollectionCount) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.CollectionCount, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.CollectionCount] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetRecommendedDegreeId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conCourseLearningCase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conCourseLearningCase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conCourseLearningCase.RecommendedDegreeId);
}
objCourseLearningCaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.RecommendedDegreeId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.RecommendedDegreeId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.RecommendedDegreeId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetftpFileType(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conCourseLearningCase.ftpFileType);
}
objCourseLearningCaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ftpFileType) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ftpFileType, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ftpFileType] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetVideoUrl(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conCourseLearningCase.VideoUrl);
}
objCourseLearningCaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.VideoUrl) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.VideoUrl, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.VideoUrl] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetVideoPath(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conCourseLearningCase.VideoPath);
}
objCourseLearningCaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.VideoPath) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.VideoPath, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.VideoPath] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetImageUrl(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strImageUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strImageUrl, 100, conCourseLearningCase.ImageUrl);
}
objCourseLearningCaseEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ImageUrl) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ImageUrl, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ImageUrl] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetResErrMsg(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conCourseLearningCase.ResErrMsg);
}
objCourseLearningCaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.ResErrMsg) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.ResErrMsg, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.ResErrMsg] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetOrderNum(this clsCourseLearningCaseEN objCourseLearningCaseEN, int? intOrderNum, string strComparisonOp="")
	{
objCourseLearningCaseEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.OrderNum) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.OrderNum, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.OrderNum] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetUpdDate(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCourseLearningCase.UpdDate);
}
objCourseLearningCaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.UpdDate) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.UpdDate, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.UpdDate] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetUpdUserId(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCourseLearningCase.UpdUserId);
}
objCourseLearningCaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.UpdUserId) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.UpdUserId, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.UpdUserId] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCourseLearningCaseEN SetMemo(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCourseLearningCase.Memo);
}
objCourseLearningCaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCourseLearningCaseEN.dicFldComparisonOp.ContainsKey(conCourseLearningCase.Memo) == false)
{
objCourseLearningCaseEN.dicFldComparisonOp.Add(conCourseLearningCase.Memo, strComparisonOp);
}
else
{
objCourseLearningCaseEN.dicFldComparisonOp[conCourseLearningCase.Memo] = strComparisonOp;
}
}
return objCourseLearningCaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCourseLearningCaseEN.CheckPropertyNew();
clsCourseLearningCaseEN objCourseLearningCaseCond = new clsCourseLearningCaseEN();
string strCondition = objCourseLearningCaseCond
.SetIdCourseLearningCase(objCourseLearningCaseEN.IdCourseLearningCase, "<>")
.SetCourseLearningCaseID(objCourseLearningCaseEN.CourseLearningCaseID, "=")
.GetCombineCondition();
objCourseLearningCaseEN._IsCheckProperty = true;
bool bolIsExist = clsCourseLearningCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseLearningCaseID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCourseLearningCaseEN.Update();
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
 /// <param name = "objCourseLearningCase">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCourseLearningCaseEN objCourseLearningCase)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCourseLearningCaseEN objCourseLearningCaseCond = new clsCourseLearningCaseEN();
string strCondition = objCourseLearningCaseCond
.SetCourseLearningCaseID(objCourseLearningCase.CourseLearningCaseID, "=")
.GetCombineCondition();
objCourseLearningCase._IsCheckProperty = true;
bool bolIsExist = clsCourseLearningCaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCourseLearningCase.IdCourseLearningCase = clsCourseLearningCaseBL.GetFirstID_S(strCondition);
objCourseLearningCase.UpdateWithCondition(strCondition);
}
else
{
objCourseLearningCase.IdCourseLearningCase = clsCourseLearningCaseBL.GetMaxStrId_S();
objCourseLearningCase.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCourseLearningCaseBL.CourseLearningCaseDA.UpdateBySql2(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCourseLearningCaseEN objCourseLearningCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCourseLearningCaseBL.CourseLearningCaseDA.UpdateBySql2(objCourseLearningCaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strWhereCond)
{
try
{
bool bolResult = clsCourseLearningCaseBL.CourseLearningCaseDA.UpdateBySqlWithCondition(objCourseLearningCaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCourseLearningCaseEN objCourseLearningCaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCourseLearningCaseBL.CourseLearningCaseDA.UpdateBySqlWithConditionTransaction(objCourseLearningCaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
try
{
int intRecNum = clsCourseLearningCaseBL.CourseLearningCaseDA.DelRecord(objCourseLearningCaseEN.IdCourseLearningCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseENS">源对象</param>
 /// <param name = "objCourseLearningCaseENT">目标对象</param>
 public static void CopyTo(this clsCourseLearningCaseEN objCourseLearningCaseENS, clsCourseLearningCaseEN objCourseLearningCaseENT)
{
try
{
objCourseLearningCaseENT.IdCourseLearningCase = objCourseLearningCaseENS.IdCourseLearningCase; //课程学习案例流水号
objCourseLearningCaseENT.CourseLearningCaseID = objCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objCourseLearningCaseENT.CourseLearningCaseName = objCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objCourseLearningCaseENT.CourseLearningCaseText = objCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objCourseLearningCaseENT.CourseLearningCaseTheme = objCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objCourseLearningCaseENT.CourseLearningCaseDate = objCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objCourseLearningCaseENT.CourseLearningCaseTime = objCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objCourseLearningCaseENT.CourseLearningCaseDateIn = objCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objCourseLearningCaseENT.CourseLearningCaseTimeIn = objCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objCourseLearningCaseENT.IdCaseType = objCourseLearningCaseENS.IdCaseType; //案例类型流水号
objCourseLearningCaseENT.IdCourseLearningCaseType = objCourseLearningCaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objCourseLearningCaseENT.OwnerId = objCourseLearningCaseENS.OwnerId; //拥有者Id
objCourseLearningCaseENT.IdStudyLevel = objCourseLearningCaseENS.IdStudyLevel; //学段流水号
objCourseLearningCaseENT.IdTeachingPlan = objCourseLearningCaseENS.IdTeachingPlan; //教案流水号
objCourseLearningCaseENT.IdDiscipline = objCourseLearningCaseENS.IdDiscipline; //学科流水号
objCourseLearningCaseENT.BrowseCount = objCourseLearningCaseENS.BrowseCount; //浏览次数
objCourseLearningCaseENT.IdSenateGaugeVersion = objCourseLearningCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCourseLearningCaseENT.IdTeachSkill = objCourseLearningCaseENS.IdTeachSkill; //教学技能流水号
objCourseLearningCaseENT.CaseLevelId = objCourseLearningCaseENS.CaseLevelId; //课例等级Id
objCourseLearningCaseENT.DocFile = objCourseLearningCaseENS.DocFile; //生成的Word文件名
objCourseLearningCaseENT.IsNeedGeneWord = objCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objCourseLearningCaseENT.WordCreateDate = objCourseLearningCaseENS.WordCreateDate; //Word生成日期
objCourseLearningCaseENT.IsVisible = objCourseLearningCaseENS.IsVisible; //是否显示
objCourseLearningCaseENT.IsDualVideo = objCourseLearningCaseENS.IsDualVideo; //是否双视频
objCourseLearningCaseENT.IdXzCollege = objCourseLearningCaseENS.IdXzCollege; //学院流水号
objCourseLearningCaseENT.IdXzMajor = objCourseLearningCaseENS.IdXzMajor; //专业流水号
objCourseLearningCaseENT.CourseId = objCourseLearningCaseENS.CourseId; //课程Id
objCourseLearningCaseENT.TeachingSolutionId = objCourseLearningCaseENS.TeachingSolutionId; //教学方案Id
objCourseLearningCaseENT.CourseChapterId = objCourseLearningCaseENS.CourseChapterId; //课程章节ID
objCourseLearningCaseENT.ViewCount = objCourseLearningCaseENS.ViewCount; //浏览量
objCourseLearningCaseENT.IsShow = objCourseLearningCaseENS.IsShow; //是否启用
objCourseLearningCaseENT.DownloadNumber = objCourseLearningCaseENS.DownloadNumber; //下载数目
objCourseLearningCaseENT.FileIntegration = objCourseLearningCaseENS.FileIntegration; //文件积分
objCourseLearningCaseENT.LikeCount = objCourseLearningCaseENS.LikeCount; //资源喜欢数量
objCourseLearningCaseENT.CollectionCount = objCourseLearningCaseENS.CollectionCount; //收藏数量
objCourseLearningCaseENT.RecommendedDegreeId = objCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objCourseLearningCaseENT.ftpFileType = objCourseLearningCaseENS.ftpFileType; //ftp文件类型
objCourseLearningCaseENT.VideoUrl = objCourseLearningCaseENS.VideoUrl; //视频Url
objCourseLearningCaseENT.VideoPath = objCourseLearningCaseENS.VideoPath; //视频目录
objCourseLearningCaseENT.ImageUrl = objCourseLearningCaseENS.ImageUrl; //ImageUrl
objCourseLearningCaseENT.ResErrMsg = objCourseLearningCaseENS.ResErrMsg; //资源错误信息
objCourseLearningCaseENT.OrderNum = objCourseLearningCaseENS.OrderNum; //序号
objCourseLearningCaseENT.UpdDate = objCourseLearningCaseENS.UpdDate; //修改日期
objCourseLearningCaseENT.UpdUserId = objCourseLearningCaseENS.UpdUserId; //修改用户Id
objCourseLearningCaseENT.Memo = objCourseLearningCaseENS.Memo; //备注
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
 /// <param name = "objCourseLearningCaseENS">源对象</param>
 /// <returns>目标对象=>clsCourseLearningCaseEN:objCourseLearningCaseENT</returns>
 public static clsCourseLearningCaseEN CopyTo(this clsCourseLearningCaseEN objCourseLearningCaseENS)
{
try
{
 clsCourseLearningCaseEN objCourseLearningCaseENT = new clsCourseLearningCaseEN()
{
IdCourseLearningCase = objCourseLearningCaseENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseID = objCourseLearningCaseENS.CourseLearningCaseID, //课程学习案例ID
CourseLearningCaseName = objCourseLearningCaseENS.CourseLearningCaseName, //课程学习案例名称
CourseLearningCaseText = objCourseLearningCaseENS.CourseLearningCaseText, //案例文本内容
CourseLearningCaseTheme = objCourseLearningCaseENS.CourseLearningCaseTheme, //课程学习案例主题词
CourseLearningCaseDate = objCourseLearningCaseENS.CourseLearningCaseDate, //课程学习日期
CourseLearningCaseTime = objCourseLearningCaseENS.CourseLearningCaseTime, //课程学习时间
CourseLearningCaseDateIn = objCourseLearningCaseENS.CourseLearningCaseDateIn, //案例入库日期
CourseLearningCaseTimeIn = objCourseLearningCaseENS.CourseLearningCaseTimeIn, //案例入库时间
IdCaseType = objCourseLearningCaseENS.IdCaseType, //案例类型流水号
IdCourseLearningCaseType = objCourseLearningCaseENS.IdCourseLearningCaseType, //课程学习案例类型流水号
OwnerId = objCourseLearningCaseENS.OwnerId, //拥有者Id
IdStudyLevel = objCourseLearningCaseENS.IdStudyLevel, //学段流水号
IdTeachingPlan = objCourseLearningCaseENS.IdTeachingPlan, //教案流水号
IdDiscipline = objCourseLearningCaseENS.IdDiscipline, //学科流水号
BrowseCount = objCourseLearningCaseENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objCourseLearningCaseENS.IdSenateGaugeVersion, //评价量表版本流水号
IdTeachSkill = objCourseLearningCaseENS.IdTeachSkill, //教学技能流水号
CaseLevelId = objCourseLearningCaseENS.CaseLevelId, //课例等级Id
DocFile = objCourseLearningCaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objCourseLearningCaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objCourseLearningCaseENS.WordCreateDate, //Word生成日期
IsVisible = objCourseLearningCaseENS.IsVisible, //是否显示
IsDualVideo = objCourseLearningCaseENS.IsDualVideo, //是否双视频
IdXzCollege = objCourseLearningCaseENS.IdXzCollege, //学院流水号
IdXzMajor = objCourseLearningCaseENS.IdXzMajor, //专业流水号
CourseId = objCourseLearningCaseENS.CourseId, //课程Id
TeachingSolutionId = objCourseLearningCaseENS.TeachingSolutionId, //教学方案Id
CourseChapterId = objCourseLearningCaseENS.CourseChapterId, //课程章节ID
ViewCount = objCourseLearningCaseENS.ViewCount, //浏览量
IsShow = objCourseLearningCaseENS.IsShow, //是否启用
DownloadNumber = objCourseLearningCaseENS.DownloadNumber, //下载数目
FileIntegration = objCourseLearningCaseENS.FileIntegration, //文件积分
LikeCount = objCourseLearningCaseENS.LikeCount, //资源喜欢数量
CollectionCount = objCourseLearningCaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objCourseLearningCaseENS.RecommendedDegreeId, //推荐度Id
ftpFileType = objCourseLearningCaseENS.ftpFileType, //ftp文件类型
VideoUrl = objCourseLearningCaseENS.VideoUrl, //视频Url
VideoPath = objCourseLearningCaseENS.VideoPath, //视频目录
ImageUrl = objCourseLearningCaseENS.ImageUrl, //ImageUrl
ResErrMsg = objCourseLearningCaseENS.ResErrMsg, //资源错误信息
OrderNum = objCourseLearningCaseENS.OrderNum, //序号
UpdDate = objCourseLearningCaseENS.UpdDate, //修改日期
UpdUserId = objCourseLearningCaseENS.UpdUserId, //修改用户Id
Memo = objCourseLearningCaseENS.Memo, //备注
};
 return objCourseLearningCaseENT;
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
public static void CheckPropertyNew(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 clsCourseLearningCaseBL.CourseLearningCaseDA.CheckPropertyNew(objCourseLearningCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 clsCourseLearningCaseBL.CourseLearningCaseDA.CheckProperty4Condition(objCourseLearningCaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCourseLearningCaseEN objCourseLearningCaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdCourseLearningCase, objCourseLearningCaseCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseID) == true)
{
string strComparisonOpCourseLearningCaseID = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseID, objCourseLearningCaseCond.CourseLearningCaseID, strComparisonOpCourseLearningCaseID);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseName, objCourseLearningCaseCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseText) == true)
{
string strComparisonOpCourseLearningCaseText = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseText, objCourseLearningCaseCond.CourseLearningCaseText, strComparisonOpCourseLearningCaseText);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseTheme) == true)
{
string strComparisonOpCourseLearningCaseTheme = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseTheme, objCourseLearningCaseCond.CourseLearningCaseTheme, strComparisonOpCourseLearningCaseTheme);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseDate) == true)
{
string strComparisonOpCourseLearningCaseDate = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseDate, objCourseLearningCaseCond.CourseLearningCaseDate, strComparisonOpCourseLearningCaseDate);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseTime) == true)
{
string strComparisonOpCourseLearningCaseTime = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseTime, objCourseLearningCaseCond.CourseLearningCaseTime, strComparisonOpCourseLearningCaseTime);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseDateIn) == true)
{
string strComparisonOpCourseLearningCaseDateIn = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseDateIn, objCourseLearningCaseCond.CourseLearningCaseDateIn, strComparisonOpCourseLearningCaseDateIn);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseLearningCaseTimeIn) == true)
{
string strComparisonOpCourseLearningCaseTimeIn = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseLearningCaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseLearningCaseTimeIn, objCourseLearningCaseCond.CourseLearningCaseTimeIn, strComparisonOpCourseLearningCaseTimeIn);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdCaseType, objCourseLearningCaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdCourseLearningCaseType) == true)
{
string strComparisonOpIdCourseLearningCaseType = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdCourseLearningCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdCourseLearningCaseType, objCourseLearningCaseCond.IdCourseLearningCaseType, strComparisonOpIdCourseLearningCaseType);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.OwnerId) == true)
{
string strComparisonOpOwnerId = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.OwnerId, objCourseLearningCaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdStudyLevel, objCourseLearningCaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdTeachingPlan, objCourseLearningCaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdDiscipline, objCourseLearningCaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.BrowseCount, objCourseLearningCaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdSenateGaugeVersion, objCourseLearningCaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdTeachSkill, objCourseLearningCaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CaseLevelId, objCourseLearningCaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.DocFile) == true)
{
string strComparisonOpDocFile = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.DocFile, objCourseLearningCaseCond.DocFile, strComparisonOpDocFile);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IsNeedGeneWord) == true)
{
if (objCourseLearningCaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsNeedGeneWord);
}
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.WordCreateDate, objCourseLearningCaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IsVisible) == true)
{
if (objCourseLearningCaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsVisible);
}
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IsDualVideo) == true)
{
if (objCourseLearningCaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsDualVideo);
}
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdXzCollege, objCourseLearningCaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.IdXzMajor, objCourseLearningCaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseId) == true)
{
string strComparisonOpCourseId = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseId, objCourseLearningCaseCond.CourseId, strComparisonOpCourseId);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.TeachingSolutionId) == true)
{
string strComparisonOpTeachingSolutionId = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.TeachingSolutionId, objCourseLearningCaseCond.TeachingSolutionId, strComparisonOpTeachingSolutionId);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.CourseChapterId, objCourseLearningCaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.ViewCount) == true)
{
string strComparisonOpViewCount = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.ViewCount, objCourseLearningCaseCond.ViewCount, strComparisonOpViewCount);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.IsShow) == true)
{
if (objCourseLearningCaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCourseLearningCase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCourseLearningCase.IsShow);
}
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.DownloadNumber, objCourseLearningCaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.FileIntegration, objCourseLearningCaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.LikeCount) == true)
{
string strComparisonOpLikeCount = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.LikeCount, objCourseLearningCaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.CollectionCount, objCourseLearningCaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.RecommendedDegreeId, objCourseLearningCaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.ftpFileType, objCourseLearningCaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.VideoUrl, objCourseLearningCaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.VideoPath) == true)
{
string strComparisonOpVideoPath = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.VideoPath, objCourseLearningCaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.ImageUrl) == true)
{
string strComparisonOpImageUrl = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.ImageUrl, objCourseLearningCaseCond.ImageUrl, strComparisonOpImageUrl);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.ResErrMsg, objCourseLearningCaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.OrderNum) == true)
{
string strComparisonOpOrderNum = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCourseLearningCase.OrderNum, objCourseLearningCaseCond.OrderNum, strComparisonOpOrderNum);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.UpdDate) == true)
{
string strComparisonOpUpdDate = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.UpdDate, objCourseLearningCaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.UpdUserId, objCourseLearningCaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCourseLearningCaseCond.IsUpdated(conCourseLearningCase.Memo) == true)
{
string strComparisonOpMemo = objCourseLearningCaseCond.dicFldComparisonOp[conCourseLearningCase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCourseLearningCase.Memo, objCourseLearningCaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CourseLearningCase(课程学习案例), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseLearningCaseID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCourseLearningCaseEN == null) return true;
if (objCourseLearningCaseEN.IdCourseLearningCase == null || objCourseLearningCaseEN.IdCourseLearningCase == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseLearningCaseID = '{0}'", objCourseLearningCaseEN.CourseLearningCaseID);
if (clsCourseLearningCaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdCourseLearningCase !=  '{0}'", objCourseLearningCaseEN.IdCourseLearningCase);
 sbCondition.AppendFormat(" and CourseLearningCaseID = '{0}'", objCourseLearningCaseEN.CourseLearningCaseID);
if (clsCourseLearningCaseBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CourseLearningCase(课程学习案例), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseLearningCaseID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCourseLearningCaseEN == null) return "";
if (objCourseLearningCaseEN.IdCourseLearningCase == null || objCourseLearningCaseEN.IdCourseLearningCase == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseLearningCaseID = '{0}'", objCourseLearningCaseEN.CourseLearningCaseID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdCourseLearningCase !=  '{0}'", objCourseLearningCaseEN.IdCourseLearningCase);
 sbCondition.AppendFormat(" and CourseLearningCaseID = '{0}'", objCourseLearningCaseEN.CourseLearningCaseID);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CourseLearningCase
{
public virtual bool UpdRelaTabDate(string strIdCourseLearningCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课程学习案例(CourseLearningCase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCourseLearningCaseBL
{
public static RelatedActions_CourseLearningCase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCourseLearningCaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCourseLearningCaseDA CourseLearningCaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCourseLearningCaseDA();
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
 public clsCourseLearningCaseBL()
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
if (string.IsNullOrEmpty(clsCourseLearningCaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCourseLearningCaseEN._ConnectString);
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
public static DataTable GetDataTable_CourseLearningCase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CourseLearningCaseDA.GetDataTable_CourseLearningCase(strWhereCond);
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
objDT = CourseLearningCaseDA.GetDataTable(strWhereCond);
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
objDT = CourseLearningCaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CourseLearningCaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CourseLearningCaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CourseLearningCaseDA.GetDataTable_Top(objTopPara);
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
objDT = CourseLearningCaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CourseLearningCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CourseLearningCaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLstByIdCourseLearningCaseLst(List<string> arrIdCourseLearningCaseLst)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCourseLearningCaseLst, true);
 string strWhereCond = string.Format("IdCourseLearningCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCourseLearningCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCourseLearningCaseEN> GetObjLstByIdCourseLearningCaseLstCache(List<string> arrIdCourseLearningCaseLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName, strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel =
arrCourseLearningCaseObjLstCache
.Where(x => arrIdCourseLearningCaseLst.Contains(x.IdCourseLearningCase));
return arrCourseLearningCaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLst(string strWhereCond)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
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
public static List<clsCourseLearningCaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCourseLearningCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCourseLearningCaseEN> GetSubObjLstCache(clsCourseLearningCaseEN objCourseLearningCaseCond)
{
 string strCourseId = objCourseLearningCaseCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsCourseLearningCaseBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsCourseLearningCaseEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCourseLearningCase.AttributeName)
{
if (objCourseLearningCaseCond.IsUpdated(strFldName) == false) continue;
if (objCourseLearningCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCourseLearningCaseCond[strFldName].ToString());
}
else
{
if (objCourseLearningCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCourseLearningCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCourseLearningCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCourseLearningCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCourseLearningCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCourseLearningCaseCond[strFldName]));
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
public static List<clsCourseLearningCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
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
public static List<clsCourseLearningCaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
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
List<clsCourseLearningCaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCourseLearningCaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCourseLearningCaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCourseLearningCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
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
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
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
public static List<clsCourseLearningCaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCourseLearningCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
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
public static List<clsCourseLearningCaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCourseLearningCaseEN> arrObjLst = new List<clsCourseLearningCaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN();
try
{
objCourseLearningCaseEN.IdCourseLearningCase = objRow[conCourseLearningCase.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objCourseLearningCaseEN.CourseLearningCaseID = objRow[conCourseLearningCase.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objCourseLearningCaseEN.CourseLearningCaseName = objRow[conCourseLearningCase.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objCourseLearningCaseEN.CourseLearningCaseText = objRow[conCourseLearningCase.CourseLearningCaseText] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objCourseLearningCaseEN.CourseLearningCaseTheme = objRow[conCourseLearningCase.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objCourseLearningCaseEN.CourseLearningCaseDate = objRow[conCourseLearningCase.CourseLearningCaseDate] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objCourseLearningCaseEN.CourseLearningCaseTime = objRow[conCourseLearningCase.CourseLearningCaseTime] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objCourseLearningCaseEN.CourseLearningCaseDateIn = objRow[conCourseLearningCase.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objRow[conCourseLearningCase.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objCourseLearningCaseEN.IdCaseType = objRow[conCourseLearningCase.IdCaseType] == DBNull.Value ? null : objRow[conCourseLearningCase.IdCaseType].ToString().Trim(); //案例类型流水号
objCourseLearningCaseEN.IdCourseLearningCaseType = objRow[conCourseLearningCase.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objCourseLearningCaseEN.OwnerId = objRow[conCourseLearningCase.OwnerId].ToString().Trim(); //拥有者Id
objCourseLearningCaseEN.IdStudyLevel = objRow[conCourseLearningCase.IdStudyLevel] == DBNull.Value ? null : objRow[conCourseLearningCase.IdStudyLevel].ToString().Trim(); //学段流水号
objCourseLearningCaseEN.IdTeachingPlan = objRow[conCourseLearningCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCourseLearningCaseEN.IdDiscipline = objRow[conCourseLearningCase.IdDiscipline] == DBNull.Value ? null : objRow[conCourseLearningCase.IdDiscipline].ToString().Trim(); //学科流水号
objCourseLearningCaseEN.BrowseCount = objRow[conCourseLearningCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.BrowseCount].ToString().Trim()); //浏览次数
objCourseLearningCaseEN.IdSenateGaugeVersion = objRow[conCourseLearningCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCourseLearningCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCourseLearningCaseEN.IdTeachSkill = objRow[conCourseLearningCase.IdTeachSkill] == DBNull.Value ? null : objRow[conCourseLearningCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCourseLearningCaseEN.CaseLevelId = objRow[conCourseLearningCase.CaseLevelId] == DBNull.Value ? null : objRow[conCourseLearningCase.CaseLevelId].ToString().Trim(); //课例等级Id
objCourseLearningCaseEN.DocFile = objRow[conCourseLearningCase.DocFile] == DBNull.Value ? null : objRow[conCourseLearningCase.DocFile].ToString().Trim(); //生成的Word文件名
objCourseLearningCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCourseLearningCaseEN.WordCreateDate = objRow[conCourseLearningCase.WordCreateDate] == DBNull.Value ? null : objRow[conCourseLearningCase.WordCreateDate].ToString().Trim(); //Word生成日期
objCourseLearningCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsVisible].ToString().Trim()); //是否显示
objCourseLearningCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsDualVideo].ToString().Trim()); //是否双视频
objCourseLearningCaseEN.IdXzCollege = objRow[conCourseLearningCase.IdXzCollege] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzCollege].ToString().Trim(); //学院流水号
objCourseLearningCaseEN.IdXzMajor = objRow[conCourseLearningCase.IdXzMajor] == DBNull.Value ? null : objRow[conCourseLearningCase.IdXzMajor].ToString().Trim(); //专业流水号
objCourseLearningCaseEN.CourseId = objRow[conCourseLearningCase.CourseId].ToString().Trim(); //课程Id
objCourseLearningCaseEN.TeachingSolutionId = objRow[conCourseLearningCase.TeachingSolutionId] == DBNull.Value ? null : objRow[conCourseLearningCase.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCourseLearningCaseEN.CourseChapterId = objRow[conCourseLearningCase.CourseChapterId] == DBNull.Value ? null : objRow[conCourseLearningCase.CourseChapterId].ToString().Trim(); //课程章节ID
objCourseLearningCaseEN.ViewCount = objRow[conCourseLearningCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.ViewCount].ToString().Trim()); //浏览量
objCourseLearningCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCourseLearningCase.IsShow].ToString().Trim()); //是否启用
objCourseLearningCaseEN.DownloadNumber = objRow[conCourseLearningCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.DownloadNumber].ToString().Trim()); //下载数目
objCourseLearningCaseEN.FileIntegration = objRow[conCourseLearningCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.FileIntegration].ToString().Trim()); //文件积分
objCourseLearningCaseEN.LikeCount = objRow[conCourseLearningCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.LikeCount].ToString().Trim()); //资源喜欢数量
objCourseLearningCaseEN.CollectionCount = objRow[conCourseLearningCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.CollectionCount].ToString().Trim()); //收藏数量
objCourseLearningCaseEN.RecommendedDegreeId = objRow[conCourseLearningCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCourseLearningCaseEN.ftpFileType = objRow[conCourseLearningCase.ftpFileType] == DBNull.Value ? null : objRow[conCourseLearningCase.ftpFileType].ToString().Trim(); //ftp文件类型
objCourseLearningCaseEN.VideoUrl = objRow[conCourseLearningCase.VideoUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoUrl].ToString().Trim(); //视频Url
objCourseLearningCaseEN.VideoPath = objRow[conCourseLearningCase.VideoPath] == DBNull.Value ? null : objRow[conCourseLearningCase.VideoPath].ToString().Trim(); //视频目录
objCourseLearningCaseEN.ImageUrl = objRow[conCourseLearningCase.ImageUrl] == DBNull.Value ? null : objRow[conCourseLearningCase.ImageUrl].ToString().Trim(); //ImageUrl
objCourseLearningCaseEN.ResErrMsg = objRow[conCourseLearningCase.ResErrMsg] == DBNull.Value ? null : objRow[conCourseLearningCase.ResErrMsg].ToString().Trim(); //资源错误信息
objCourseLearningCaseEN.OrderNum = objRow[conCourseLearningCase.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCourseLearningCase.OrderNum].ToString().Trim()); //序号
objCourseLearningCaseEN.UpdDate = objRow[conCourseLearningCase.UpdDate] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdDate].ToString().Trim(); //修改日期
objCourseLearningCaseEN.UpdUserId = objRow[conCourseLearningCase.UpdUserId] == DBNull.Value ? null : objRow[conCourseLearningCase.UpdUserId].ToString().Trim(); //修改用户Id
objCourseLearningCaseEN.Memo = objRow[conCourseLearningCase.Memo] == DBNull.Value ? null : objRow[conCourseLearningCase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCourseLearningCaseEN.IdCourseLearningCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCourseLearningCaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCourseLearningCase(ref clsCourseLearningCaseEN objCourseLearningCaseEN)
{
bool bolResult = CourseLearningCaseDA.GetCourseLearningCase(ref objCourseLearningCaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCourseLearningCaseEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
if (strIdCourseLearningCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCourseLearningCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCourseLearningCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCourseLearningCaseEN objCourseLearningCaseEN = CourseLearningCaseDA.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
return objCourseLearningCaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCourseLearningCaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCourseLearningCaseEN objCourseLearningCaseEN = CourseLearningCaseDA.GetFirstObj(strWhereCond);
 return objCourseLearningCaseEN;
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
public static clsCourseLearningCaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCourseLearningCaseEN objCourseLearningCaseEN = CourseLearningCaseDA.GetObjByDataRow(objRow);
 return objCourseLearningCaseEN;
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
public static clsCourseLearningCaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCourseLearningCaseEN objCourseLearningCaseEN = CourseLearningCaseDA.GetObjByDataRow(objRow);
 return objCourseLearningCaseEN;
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
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <param name = "lstCourseLearningCaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCourseLearningCaseEN GetObjByIdCourseLearningCaseFromList(string strIdCourseLearningCase, List<clsCourseLearningCaseEN> lstCourseLearningCaseObjLst)
{
foreach (clsCourseLearningCaseEN objCourseLearningCaseEN in lstCourseLearningCaseObjLst)
{
if (objCourseLearningCaseEN.IdCourseLearningCase == strIdCourseLearningCase)
{
return objCourseLearningCaseEN;
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
 string strMaxIdCourseLearningCase;
 try
 {
 strMaxIdCourseLearningCase = clsCourseLearningCaseDA.GetMaxStrId();
 return strMaxIdCourseLearningCase;
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
 string strIdCourseLearningCase;
 try
 {
 strIdCourseLearningCase = new clsCourseLearningCaseDA().GetFirstID(strWhereCond);
 return strIdCourseLearningCase;
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
 arrList = CourseLearningCaseDA.GetID(strWhereCond);
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
bool bolIsExist = CourseLearningCaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCourseLearningCase)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCourseLearningCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CourseLearningCaseDA.IsExist(strIdCourseLearningCase);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdCourseLearningCase">课程学习案例流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdCourseLearningCase, string strOpUser)
{
clsCourseLearningCaseEN objCourseLearningCaseEN = clsCourseLearningCaseBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
objCourseLearningCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCourseLearningCaseEN.UpdUserId = strOpUser;
return clsCourseLearningCaseBL.UpdateBySql2(objCourseLearningCaseEN);
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
 bolIsExist = clsCourseLearningCaseDA.IsExistTable();
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
 bolIsExist = CourseLearningCaseDA.IsExistTable(strTabName);
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCourseLearningCaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程学习案例ID = [{0}]的数据已经存在!(in clsCourseLearningCaseBL.AddNewRecordBySql2)", objCourseLearningCaseEN.CourseLearningCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true || clsCourseLearningCaseBL.IsExist(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
     objCourseLearningCaseEN.IdCourseLearningCase = clsCourseLearningCaseBL.GetMaxStrId_S();
 }
bool bolResult = CourseLearningCaseDA.AddNewRecordBySQL2(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCourseLearningCaseEN objCourseLearningCaseEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCourseLearningCaseEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课程学习案例ID = [{0}]的数据已经存在!(in clsCourseLearningCaseBL.AddNewRecordBySql2WithReturnKey)", objCourseLearningCaseEN.CourseLearningCaseID);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true || clsCourseLearningCaseBL.IsExist(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
     objCourseLearningCaseEN.IdCourseLearningCase = clsCourseLearningCaseBL.GetMaxStrId_S();
 }
string strKey = CourseLearningCaseDA.AddNewRecordBySQL2WithReturnKey(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
try
{
bool bolResult = CourseLearningCaseDA.Update(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "objCourseLearningCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 if (string.IsNullOrEmpty(objCourseLearningCaseEN.IdCourseLearningCase) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CourseLearningCaseDA.UpdateBySql2(objCourseLearningCaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCourseLearningCaseBL.ReFreshCache(objCourseLearningCaseEN.CourseId);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
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
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdCourseLearningCase)
{
try
{
 clsCourseLearningCaseEN objCourseLearningCaseEN = clsCourseLearningCaseBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);

if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(objCourseLearningCaseEN.IdCourseLearningCase, objCourseLearningCaseEN.UpdUserId);
}
if (objCourseLearningCaseEN != null)
{
int intRecNum = CourseLearningCaseDA.DelRecord(strIdCourseLearningCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCourseLearningCaseEN.CourseId);
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
/// <param name="strIdCourseLearningCase">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdCourseLearningCase , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
//删除与表:[CourseLearningCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCourseLearningCase.IdCourseLearningCase,
//strIdCourseLearningCase);
//        clsCourseLearningCaseBL.DelCourseLearningCasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCourseLearningCaseBL.DelRecord(strIdCourseLearningCase, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCourseLearningCaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCourseLearningCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdCourseLearningCase, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCourseLearningCaseBL.relatedActions != null)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(strIdCourseLearningCase, "UpdRelaTabDate");
}
bool bolResult = CourseLearningCaseDA.DelRecord(strIdCourseLearningCase,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrIdCourseLearningCaseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCourseLearningCases(List<string> arrIdCourseLearningCaseLst)
{
if (arrIdCourseLearningCaseLst.Count == 0) return 0;
try
{
if (clsCourseLearningCaseBL.relatedActions != null)
{
foreach (var strIdCourseLearningCase in arrIdCourseLearningCaseLst)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(strIdCourseLearningCase, "UpdRelaTabDate");
}
}
 clsCourseLearningCaseEN objCourseLearningCaseEN = clsCourseLearningCaseBL.GetObjByIdCourseLearningCase(arrIdCourseLearningCaseLst[0]);
int intDelRecNum = CourseLearningCaseDA.DelCourseLearningCase(arrIdCourseLearningCaseLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objCourseLearningCaseEN.CourseId);
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
public static int DelCourseLearningCasesByCond(string strWhereCond)
{
try
{
if (clsCourseLearningCaseBL.relatedActions != null)
{
List<string> arrIdCourseLearningCase = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCourseLearningCase in arrIdCourseLearningCase)
{
clsCourseLearningCaseBL.relatedActions.UpdRelaTabDate(strIdCourseLearningCase, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conCourseLearningCase.CourseId, strWhereCond);
int intRecNum = CourseLearningCaseDA.DelCourseLearningCase(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CourseLearningCase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdCourseLearningCase">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdCourseLearningCase, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCourseLearningCaseDA.GetSpecSQLObj();
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
//删除与表:[CourseLearningCase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCourseLearningCaseBL.DelRecord(strIdCourseLearningCase, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCourseLearningCaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCourseLearningCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCourseLearningCaseENS">源对象</param>
 /// <param name = "objCourseLearningCaseENT">目标对象</param>
 public static void CopyTo(clsCourseLearningCaseEN objCourseLearningCaseENS, clsCourseLearningCaseEN objCourseLearningCaseENT)
{
try
{
objCourseLearningCaseENT.IdCourseLearningCase = objCourseLearningCaseENS.IdCourseLearningCase; //课程学习案例流水号
objCourseLearningCaseENT.CourseLearningCaseID = objCourseLearningCaseENS.CourseLearningCaseID; //课程学习案例ID
objCourseLearningCaseENT.CourseLearningCaseName = objCourseLearningCaseENS.CourseLearningCaseName; //课程学习案例名称
objCourseLearningCaseENT.CourseLearningCaseText = objCourseLearningCaseENS.CourseLearningCaseText; //案例文本内容
objCourseLearningCaseENT.CourseLearningCaseTheme = objCourseLearningCaseENS.CourseLearningCaseTheme; //课程学习案例主题词
objCourseLearningCaseENT.CourseLearningCaseDate = objCourseLearningCaseENS.CourseLearningCaseDate; //课程学习日期
objCourseLearningCaseENT.CourseLearningCaseTime = objCourseLearningCaseENS.CourseLearningCaseTime; //课程学习时间
objCourseLearningCaseENT.CourseLearningCaseDateIn = objCourseLearningCaseENS.CourseLearningCaseDateIn; //案例入库日期
objCourseLearningCaseENT.CourseLearningCaseTimeIn = objCourseLearningCaseENS.CourseLearningCaseTimeIn; //案例入库时间
objCourseLearningCaseENT.IdCaseType = objCourseLearningCaseENS.IdCaseType; //案例类型流水号
objCourseLearningCaseENT.IdCourseLearningCaseType = objCourseLearningCaseENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objCourseLearningCaseENT.OwnerId = objCourseLearningCaseENS.OwnerId; //拥有者Id
objCourseLearningCaseENT.IdStudyLevel = objCourseLearningCaseENS.IdStudyLevel; //学段流水号
objCourseLearningCaseENT.IdTeachingPlan = objCourseLearningCaseENS.IdTeachingPlan; //教案流水号
objCourseLearningCaseENT.IdDiscipline = objCourseLearningCaseENS.IdDiscipline; //学科流水号
objCourseLearningCaseENT.BrowseCount = objCourseLearningCaseENS.BrowseCount; //浏览次数
objCourseLearningCaseENT.IdSenateGaugeVersion = objCourseLearningCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCourseLearningCaseENT.IdTeachSkill = objCourseLearningCaseENS.IdTeachSkill; //教学技能流水号
objCourseLearningCaseENT.CaseLevelId = objCourseLearningCaseENS.CaseLevelId; //课例等级Id
objCourseLearningCaseENT.DocFile = objCourseLearningCaseENS.DocFile; //生成的Word文件名
objCourseLearningCaseENT.IsNeedGeneWord = objCourseLearningCaseENS.IsNeedGeneWord; //是否需要生成Word
objCourseLearningCaseENT.WordCreateDate = objCourseLearningCaseENS.WordCreateDate; //Word生成日期
objCourseLearningCaseENT.IsVisible = objCourseLearningCaseENS.IsVisible; //是否显示
objCourseLearningCaseENT.IsDualVideo = objCourseLearningCaseENS.IsDualVideo; //是否双视频
objCourseLearningCaseENT.IdXzCollege = objCourseLearningCaseENS.IdXzCollege; //学院流水号
objCourseLearningCaseENT.IdXzMajor = objCourseLearningCaseENS.IdXzMajor; //专业流水号
objCourseLearningCaseENT.CourseId = objCourseLearningCaseENS.CourseId; //课程Id
objCourseLearningCaseENT.TeachingSolutionId = objCourseLearningCaseENS.TeachingSolutionId; //教学方案Id
objCourseLearningCaseENT.CourseChapterId = objCourseLearningCaseENS.CourseChapterId; //课程章节ID
objCourseLearningCaseENT.ViewCount = objCourseLearningCaseENS.ViewCount; //浏览量
objCourseLearningCaseENT.IsShow = objCourseLearningCaseENS.IsShow; //是否启用
objCourseLearningCaseENT.DownloadNumber = objCourseLearningCaseENS.DownloadNumber; //下载数目
objCourseLearningCaseENT.FileIntegration = objCourseLearningCaseENS.FileIntegration; //文件积分
objCourseLearningCaseENT.LikeCount = objCourseLearningCaseENS.LikeCount; //资源喜欢数量
objCourseLearningCaseENT.CollectionCount = objCourseLearningCaseENS.CollectionCount; //收藏数量
objCourseLearningCaseENT.RecommendedDegreeId = objCourseLearningCaseENS.RecommendedDegreeId; //推荐度Id
objCourseLearningCaseENT.ftpFileType = objCourseLearningCaseENS.ftpFileType; //ftp文件类型
objCourseLearningCaseENT.VideoUrl = objCourseLearningCaseENS.VideoUrl; //视频Url
objCourseLearningCaseENT.VideoPath = objCourseLearningCaseENS.VideoPath; //视频目录
objCourseLearningCaseENT.ImageUrl = objCourseLearningCaseENS.ImageUrl; //ImageUrl
objCourseLearningCaseENT.ResErrMsg = objCourseLearningCaseENS.ResErrMsg; //资源错误信息
objCourseLearningCaseENT.OrderNum = objCourseLearningCaseENS.OrderNum; //序号
objCourseLearningCaseENT.UpdDate = objCourseLearningCaseENS.UpdDate; //修改日期
objCourseLearningCaseENT.UpdUserId = objCourseLearningCaseENS.UpdUserId; //修改用户Id
objCourseLearningCaseENT.Memo = objCourseLearningCaseENS.Memo; //备注
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
 /// <param name = "objCourseLearningCaseEN">源简化对象</param>
 public static void SetUpdFlag(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
try
{
objCourseLearningCaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCourseLearningCaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCourseLearningCase.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdCourseLearningCase = objCourseLearningCaseEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseID = objCourseLearningCaseEN.CourseLearningCaseID; //课程学习案例ID
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseName = objCourseLearningCaseEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseText = objCourseLearningCaseEN.CourseLearningCaseText == "[null]" ? null :  objCourseLearningCaseEN.CourseLearningCaseText; //案例文本内容
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseTheme = objCourseLearningCaseEN.CourseLearningCaseTheme == "[null]" ? null :  objCourseLearningCaseEN.CourseLearningCaseTheme; //课程学习案例主题词
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseDate = objCourseLearningCaseEN.CourseLearningCaseDate == "[null]" ? null :  objCourseLearningCaseEN.CourseLearningCaseDate; //课程学习日期
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseTime = objCourseLearningCaseEN.CourseLearningCaseTime == "[null]" ? null :  objCourseLearningCaseEN.CourseLearningCaseTime; //课程学习时间
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseDateIn = objCourseLearningCaseEN.CourseLearningCaseDateIn == "[null]" ? null :  objCourseLearningCaseEN.CourseLearningCaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(conCourseLearningCase.CourseLearningCaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseLearningCaseTimeIn = objCourseLearningCaseEN.CourseLearningCaseTimeIn == "[null]" ? null :  objCourseLearningCaseEN.CourseLearningCaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(conCourseLearningCase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdCaseType = objCourseLearningCaseEN.IdCaseType == "[null]" ? null :  objCourseLearningCaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(conCourseLearningCase.IdCourseLearningCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdCourseLearningCaseType = objCourseLearningCaseEN.IdCourseLearningCaseType; //课程学习案例类型流水号
}
if (arrFldSet.Contains(conCourseLearningCase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.OwnerId = objCourseLearningCaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conCourseLearningCase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdStudyLevel = objCourseLearningCaseEN.IdStudyLevel == "[null]" ? null :  objCourseLearningCaseEN.IdStudyLevel; //学段流水号
}
if (arrFldSet.Contains(conCourseLearningCase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdTeachingPlan = objCourseLearningCaseEN.IdTeachingPlan == "[null]" ? null :  objCourseLearningCaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conCourseLearningCase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdDiscipline = objCourseLearningCaseEN.IdDiscipline == "[null]" ? null :  objCourseLearningCaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(conCourseLearningCase.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.BrowseCount = objCourseLearningCaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conCourseLearningCase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdSenateGaugeVersion = objCourseLearningCaseEN.IdSenateGaugeVersion == "[null]" ? null :  objCourseLearningCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(conCourseLearningCase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdTeachSkill = objCourseLearningCaseEN.IdTeachSkill == "[null]" ? null :  objCourseLearningCaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(conCourseLearningCase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CaseLevelId = objCourseLearningCaseEN.CaseLevelId == "[null]" ? null :  objCourseLearningCaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(conCourseLearningCase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.DocFile = objCourseLearningCaseEN.DocFile == "[null]" ? null :  objCourseLearningCaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(conCourseLearningCase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IsNeedGeneWord = objCourseLearningCaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(conCourseLearningCase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.WordCreateDate = objCourseLearningCaseEN.WordCreateDate == "[null]" ? null :  objCourseLearningCaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(conCourseLearningCase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IsVisible = objCourseLearningCaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conCourseLearningCase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IsDualVideo = objCourseLearningCaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(conCourseLearningCase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdXzCollege = objCourseLearningCaseEN.IdXzCollege == "[null]" ? null :  objCourseLearningCaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conCourseLearningCase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IdXzMajor = objCourseLearningCaseEN.IdXzMajor == "[null]" ? null :  objCourseLearningCaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conCourseLearningCase.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseId = objCourseLearningCaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conCourseLearningCase.TeachingSolutionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.TeachingSolutionId = objCourseLearningCaseEN.TeachingSolutionId == "[null]" ? null :  objCourseLearningCaseEN.TeachingSolutionId; //教学方案Id
}
if (arrFldSet.Contains(conCourseLearningCase.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CourseChapterId = objCourseLearningCaseEN.CourseChapterId == "[null]" ? null :  objCourseLearningCaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(conCourseLearningCase.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.ViewCount = objCourseLearningCaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(conCourseLearningCase.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.IsShow = objCourseLearningCaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conCourseLearningCase.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.DownloadNumber = objCourseLearningCaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(conCourseLearningCase.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.FileIntegration = objCourseLearningCaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(conCourseLearningCase.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.LikeCount = objCourseLearningCaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(conCourseLearningCase.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.CollectionCount = objCourseLearningCaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conCourseLearningCase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.RecommendedDegreeId = objCourseLearningCaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(conCourseLearningCase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.ftpFileType = objCourseLearningCaseEN.ftpFileType == "[null]" ? null :  objCourseLearningCaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(conCourseLearningCase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.VideoUrl = objCourseLearningCaseEN.VideoUrl == "[null]" ? null :  objCourseLearningCaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(conCourseLearningCase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.VideoPath = objCourseLearningCaseEN.VideoPath == "[null]" ? null :  objCourseLearningCaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(conCourseLearningCase.ImageUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.ImageUrl = objCourseLearningCaseEN.ImageUrl == "[null]" ? null :  objCourseLearningCaseEN.ImageUrl; //ImageUrl
}
if (arrFldSet.Contains(conCourseLearningCase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.ResErrMsg = objCourseLearningCaseEN.ResErrMsg == "[null]" ? null :  objCourseLearningCaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(conCourseLearningCase.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.OrderNum = objCourseLearningCaseEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCourseLearningCase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.UpdDate = objCourseLearningCaseEN.UpdDate == "[null]" ? null :  objCourseLearningCaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCourseLearningCase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.UpdUserId = objCourseLearningCaseEN.UpdUserId == "[null]" ? null :  objCourseLearningCaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conCourseLearningCase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCourseLearningCaseEN.Memo = objCourseLearningCaseEN.Memo == "[null]" ? null :  objCourseLearningCaseEN.Memo; //备注
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
 /// <param name = "objCourseLearningCaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
try
{
if (objCourseLearningCaseEN.CourseLearningCaseText == "[null]") objCourseLearningCaseEN.CourseLearningCaseText = null; //案例文本内容
if (objCourseLearningCaseEN.CourseLearningCaseTheme == "[null]") objCourseLearningCaseEN.CourseLearningCaseTheme = null; //课程学习案例主题词
if (objCourseLearningCaseEN.CourseLearningCaseDate == "[null]") objCourseLearningCaseEN.CourseLearningCaseDate = null; //课程学习日期
if (objCourseLearningCaseEN.CourseLearningCaseTime == "[null]") objCourseLearningCaseEN.CourseLearningCaseTime = null; //课程学习时间
if (objCourseLearningCaseEN.CourseLearningCaseDateIn == "[null]") objCourseLearningCaseEN.CourseLearningCaseDateIn = null; //案例入库日期
if (objCourseLearningCaseEN.CourseLearningCaseTimeIn == "[null]") objCourseLearningCaseEN.CourseLearningCaseTimeIn = null; //案例入库时间
if (objCourseLearningCaseEN.IdCaseType == "[null]") objCourseLearningCaseEN.IdCaseType = null; //案例类型流水号
if (objCourseLearningCaseEN.IdStudyLevel == "[null]") objCourseLearningCaseEN.IdStudyLevel = null; //学段流水号
if (objCourseLearningCaseEN.IdTeachingPlan == "[null]") objCourseLearningCaseEN.IdTeachingPlan = null; //教案流水号
if (objCourseLearningCaseEN.IdDiscipline == "[null]") objCourseLearningCaseEN.IdDiscipline = null; //学科流水号
if (objCourseLearningCaseEN.IdSenateGaugeVersion == "[null]") objCourseLearningCaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objCourseLearningCaseEN.IdTeachSkill == "[null]") objCourseLearningCaseEN.IdTeachSkill = null; //教学技能流水号
if (objCourseLearningCaseEN.CaseLevelId == "[null]") objCourseLearningCaseEN.CaseLevelId = null; //课例等级Id
if (objCourseLearningCaseEN.DocFile == "[null]") objCourseLearningCaseEN.DocFile = null; //生成的Word文件名
if (objCourseLearningCaseEN.WordCreateDate == "[null]") objCourseLearningCaseEN.WordCreateDate = null; //Word生成日期
if (objCourseLearningCaseEN.IdXzCollege == "[null]") objCourseLearningCaseEN.IdXzCollege = null; //学院流水号
if (objCourseLearningCaseEN.IdXzMajor == "[null]") objCourseLearningCaseEN.IdXzMajor = null; //专业流水号
if (objCourseLearningCaseEN.TeachingSolutionId == "[null]") objCourseLearningCaseEN.TeachingSolutionId = null; //教学方案Id
if (objCourseLearningCaseEN.CourseChapterId == "[null]") objCourseLearningCaseEN.CourseChapterId = null; //课程章节ID
if (objCourseLearningCaseEN.ftpFileType == "[null]") objCourseLearningCaseEN.ftpFileType = null; //ftp文件类型
if (objCourseLearningCaseEN.VideoUrl == "[null]") objCourseLearningCaseEN.VideoUrl = null; //视频Url
if (objCourseLearningCaseEN.VideoPath == "[null]") objCourseLearningCaseEN.VideoPath = null; //视频目录
if (objCourseLearningCaseEN.ImageUrl == "[null]") objCourseLearningCaseEN.ImageUrl = null; //ImageUrl
if (objCourseLearningCaseEN.ResErrMsg == "[null]") objCourseLearningCaseEN.ResErrMsg = null; //资源错误信息
if (objCourseLearningCaseEN.UpdDate == "[null]") objCourseLearningCaseEN.UpdDate = null; //修改日期
if (objCourseLearningCaseEN.UpdUserId == "[null]") objCourseLearningCaseEN.UpdUserId = null; //修改用户Id
if (objCourseLearningCaseEN.Memo == "[null]") objCourseLearningCaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 CourseLearningCaseDA.CheckPropertyNew(objCourseLearningCaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
 CourseLearningCaseDA.CheckProperty4Condition(objCourseLearningCaseEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_IdCourseLearningCase(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conCourseLearningCase.IdCourseLearningCase); 
List<clsCourseLearningCaseEN> arrObjLst = clsCourseLearningCaseBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsCourseLearningCaseEN objCourseLearningCaseEN = new clsCourseLearningCaseEN()
{
IdCourseLearningCase = "0",
CourseLearningCaseName = "选[课程学习案例]..."
};
arrObjLstSel.Insert(0, objCourseLearningCaseEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conCourseLearningCase.IdCourseLearningCase;
objComboBox.DisplayMember = conCourseLearningCase.CourseLearningCaseName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_IdCourseLearningCase(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程学习案例]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conCourseLearningCase.IdCourseLearningCase); 
IEnumerable<clsCourseLearningCaseEN> arrObjLst = clsCourseLearningCaseBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = conCourseLearningCase.IdCourseLearningCase;
objDDL.DataTextField = conCourseLearningCase.CourseLearningCaseName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdCourseLearningCaseCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[课程学习案例]...","0");
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLst = GetAllCourseLearningCaseObjLstCache(strCourseId); 
objDDL.DataValueField = conCourseLearningCase.IdCourseLearningCase;
objDDL.DataTextField = conCourseLearningCase.CourseLearningCaseName;
objDDL.DataSource = arrCourseLearningCaseObjLst;
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
if (clsCourseLearningCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseBL没有刷新缓存机制(clsCourseLearningCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCourseLearningCase");
//if (arrCourseLearningCaseObjLstCache == null)
//{
//arrCourseLearningCaseObjLstCache = CourseLearningCaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCourseLearningCaseEN GetObjByIdCourseLearningCaseCache(string strIdCourseLearningCase, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName, strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrCourseLearningCaseObjLst_Sel =
arrCourseLearningCaseObjLstCache
.Where(x=> x.IdCourseLearningCase == strIdCourseLearningCase 
);
if (arrCourseLearningCaseObjLst_Sel.Count() == 0)
{
   clsCourseLearningCaseEN obj = clsCourseLearningCaseBL.GetObjByIdCourseLearningCase(strIdCourseLearningCase);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strIdCourseLearningCase, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrCourseLearningCaseObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCourseLearningCaseNameByIdCourseLearningCaseCache(string strIdCourseLearningCase, string strCourseId)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true) return "";
//获取缓存中的对象列表
clsCourseLearningCaseEN objCourseLearningCase = GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase, strCourseId);
if (objCourseLearningCase == null) return "";
return objCourseLearningCase.CourseLearningCaseName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdCourseLearningCaseCache(string strIdCourseLearningCase, string strCourseId)
{
if (string.IsNullOrEmpty(strIdCourseLearningCase) == true) return "";
//获取缓存中的对象列表
clsCourseLearningCaseEN objCourseLearningCase = GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase, strCourseId);
if (objCourseLearningCase == null) return "";
return objCourseLearningCase.CourseLearningCaseName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCourseLearningCaseEN> GetAllCourseLearningCaseObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLstCache = GetObjLstCache(strCourseId); 
return arrCourseLearningCaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCourseLearningCaseEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsCourseLearningCaseEN> arrCourseLearningCaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrCourseLearningCaseObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsCourseLearningCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCourseLearningCaseEN._RefreshTimeLst.Count == 0) return "";
return clsCourseLearningCaseEN._RefreshTimeLst[clsCourseLearningCaseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsCourseLearningCaseEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsCourseLearningCaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCourseLearningCaseBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CourseLearningCase(课程学习案例)
 /// 唯一性条件:CourseLearningCaseID
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCourseLearningCaseEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCourseLearningCaseEN objCourseLearningCaseEN)
{
//检测记录是否存在
string strResult = CourseLearningCaseDA.GetUniCondStr(objCourseLearningCaseEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCourseLearningCase, string strCourseId)
{
if (strInFldName != conCourseLearningCase.IdCourseLearningCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCourseLearningCase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCourseLearningCase.AttributeName));
throw new Exception(strMsg);
}
var objCourseLearningCase = clsCourseLearningCaseBL.GetObjByIdCourseLearningCaseCache(strIdCourseLearningCase, strCourseId);
if (objCourseLearningCase == null) return "";
return objCourseLearningCase[strOutFldName].ToString();
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
int intRecCount = clsCourseLearningCaseDA.GetRecCount(strTabName);
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
int intRecCount = clsCourseLearningCaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCourseLearningCaseDA.GetRecCount();
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
int intRecCount = clsCourseLearningCaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCourseLearningCaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCourseLearningCaseEN objCourseLearningCaseCond)
{
 string strCourseId = objCourseLearningCaseCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsCourseLearningCaseBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsCourseLearningCaseEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsCourseLearningCaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCourseLearningCase.AttributeName)
{
if (objCourseLearningCaseCond.IsUpdated(strFldName) == false) continue;
if (objCourseLearningCaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCourseLearningCaseCond[strFldName].ToString());
}
else
{
if (objCourseLearningCaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCourseLearningCaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCourseLearningCaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCourseLearningCaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCourseLearningCaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCourseLearningCaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCourseLearningCaseCond[strFldName]));
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
 List<string> arrList = clsCourseLearningCaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CourseLearningCaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CourseLearningCaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CourseLearningCaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCourseLearningCaseDA.SetFldValue(clsCourseLearningCaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CourseLearningCaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCourseLearningCaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCourseLearningCaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCourseLearningCaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CourseLearningCase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课程学习案例流水号*/ 
 strCreateTabCode.Append(" IdCourseLearningCase char(8) primary key, "); 
 // /**课程学习案例ID*/ 
 strCreateTabCode.Append(" CourseLearningCaseID char(8) not Null, "); 
 // /**课程学习案例名称*/ 
 strCreateTabCode.Append(" CourseLearningCaseName varchar(100) not Null, "); 
 // /**案例文本内容*/ 
 strCreateTabCode.Append(" CourseLearningCaseText varchar(8000) Null, "); 
 // /**课程学习案例主题词*/ 
 strCreateTabCode.Append(" CourseLearningCaseTheme varchar(200) Null, "); 
 // /**课程学习日期*/ 
 strCreateTabCode.Append(" CourseLearningCaseDate char(8) Null, "); 
 // /**课程学习时间*/ 
 strCreateTabCode.Append(" CourseLearningCaseTime char(6) Null, "); 
 // /**案例入库日期*/ 
 strCreateTabCode.Append(" CourseLearningCaseDateIn char(8) Null, "); 
 // /**案例入库时间*/ 
 strCreateTabCode.Append(" CourseLearningCaseTimeIn char(6) Null, "); 
 // /**案例类型流水号*/ 
 strCreateTabCode.Append(" IdCaseType char(4) Null, "); 
 // /**课程学习案例类型流水号*/ 
 strCreateTabCode.Append(" IdCourseLearningCaseType char(4) not Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) not Null, "); 
 // /**学段流水号*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) Null, "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) Null, "); 
 // /**学科流水号*/ 
 strCreateTabCode.Append(" IdDiscipline char(4) Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int Null, "); 
 // /**评价量表版本流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeVersion char(4) Null, "); 
 // /**教学技能流水号*/ 
 strCreateTabCode.Append(" IdTeachSkill char(8) Null, "); 
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
 // /**是否双视频*/ 
 strCreateTabCode.Append(" IsDualVideo bit Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**教学方案Id*/ 
 strCreateTabCode.Append(" TeachingSolutionId char(8) Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" ViewCount int Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**下载数目*/ 
 strCreateTabCode.Append(" DownloadNumber int Null, "); 
 // /**文件积分*/ 
 strCreateTabCode.Append(" FileIntegration int Null, "); 
 // /**资源喜欢数量*/ 
 strCreateTabCode.Append(" LikeCount bigint Null, "); 
 // /**收藏数量*/ 
 strCreateTabCode.Append(" CollectionCount bigint Null, "); 
 // /**推荐度Id*/ 
 strCreateTabCode.Append(" RecommendedDegreeId char(2) not Null, "); 
 // /**ftp文件类型*/ 
 strCreateTabCode.Append(" ftpFileType varchar(30) Null, "); 
 // /**视频Url*/ 
 strCreateTabCode.Append(" VideoUrl varchar(1000) Null, "); 
 // /**视频目录*/ 
 strCreateTabCode.Append(" VideoPath varchar(1000) Null, "); 
 // /**ImageUrl*/ 
 strCreateTabCode.Append(" ImageUrl varchar(100) Null, "); 
 // /**资源错误信息*/ 
 strCreateTabCode.Append(" ResErrMsg varchar(30) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**章名*/ 
 strCreateTabCode.Append(" ChapterName varchar(100) Null, "); 
 // /**案例类型名称*/ 
 strCreateTabCode.Append(" CaseTypeName varchar(50) Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) not Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 课程学习案例(CourseLearningCase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CourseLearningCase : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsCourseLearningCaseBL.ReFreshThisCache(strCourseId);
}
}

}