
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCommonBaseBL
 表名:CaseCommonBase(01120343)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:08:50
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
public static class  clsCaseCommonBaseBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCommonBaseEN GetObj(this K_IdCase_CaseCommonBase myKey)
{
clsCaseCommonBaseEN objCaseCommonBaseEN = clsCaseCommonBaseBL.CaseCommonBaseDA.GetObjByIdCase(myKey.Value);
return objCaseCommonBaseEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCaseCommonBaseBL.IsExist(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCaseCommonBaseEN.IdCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsCaseCommonBaseBL.CaseCommonBaseDA.AddNewRecordBySQL2(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
public static bool AddRecordEx(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsCaseCommonBaseBL.IsExist(objCaseCommonBaseEN.IdCase))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objCaseCommonBaseEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objCaseCommonBaseEN.AddNewRecord();
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCaseCommonBaseBL.IsExist(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCaseCommonBaseEN.IdCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsCaseCommonBaseBL.CaseCommonBaseDA.AddNewRecordBySQL2WithReturnKey(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdCase(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCase, 8, conCaseCommonBase.IdCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCase, 8, conCaseCommonBase.IdCase);
}
objCaseCommonBaseEN.IdCase = strIdCase; //案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdCase) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdCase, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdCase] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseCommonBase.CaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseCommonBase.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseCommonBase.CaseId);
}
objCaseCommonBaseEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseName(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseCommonBase.CaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseCommonBase.CaseName);
}
objCaseCommonBaseEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseName) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseName, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseName] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseText(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseText, 8000, conCaseCommonBase.CaseText);
}
objCaseCommonBaseEN.CaseText = strCaseText; //案例文本内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseText) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseText, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseText] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseTheme(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTheme, 200, conCaseCommonBase.CaseTheme);
}
objCaseCommonBaseEN.CaseTheme = strCaseTheme; //案例主题词
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseTheme) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseTheme, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseTheme] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetFuncModuleId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseCommonBase.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseCommonBase.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseCommonBase.FuncModuleId);
}
objCaseCommonBaseEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.FuncModuleId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.FuncModuleId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.FuncModuleId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCourseChapterId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, conCaseCommonBase.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, conCaseCommonBase.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, conCaseCommonBase.CourseChapterId);
}
objCaseCommonBaseEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CourseChapterId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CourseChapterId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CourseChapterId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdCaseType(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType, 4, conCaseCommonBase.IdCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType, 4, conCaseCommonBase.IdCaseType);
}
objCaseCommonBaseEN.IdCaseType = strIdCaseType; //案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdCaseType) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdCaseType, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdCaseType] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseDate(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseDate, 8, conCaseCommonBase.CaseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseDate, 8, conCaseCommonBase.CaseDate);
}
objCaseCommonBaseEN.CaseDate = strCaseDate; //案例建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseDate) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseDate, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseDate] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseTime(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTime, 6, conCaseCommonBase.CaseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseTime, 6, conCaseCommonBase.CaseTime);
}
objCaseCommonBaseEN.CaseTime = strCaseTime; //案例建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseTime) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseTime, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseTime] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseDateIn(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseDateIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseDateIn, 8, conCaseCommonBase.CaseDateIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseDateIn, 8, conCaseCommonBase.CaseDateIn);
}
objCaseCommonBaseEN.CaseDateIn = strCaseDateIn; //案例入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseDateIn) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseDateIn, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseDateIn] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseTimeIn(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseTimeIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseTimeIn, 6, conCaseCommonBase.CaseTimeIn);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseTimeIn, 6, conCaseCommonBase.CaseTimeIn);
}
objCaseCommonBaseEN.CaseTimeIn = strCaseTimeIn; //案例入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseTimeIn) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseTimeIn, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseTimeIn] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetOwnerId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strOwnerId, conCaseCommonBase.OwnerId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseCommonBase.OwnerId);
}
objCaseCommonBaseEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.OwnerId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.OwnerId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.OwnerId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdStudyLevel(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdStudyLevel, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudyLevel, 4, conCaseCommonBase.IdStudyLevel);
}
objCaseCommonBaseEN.IdStudyLevel = strIdStudyLevel; //学段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdStudyLevel) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdStudyLevel, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdStudyLevel] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdTeachingPlan(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdTeachingPlan, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachingPlan, 8, conCaseCommonBase.IdTeachingPlan);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachingPlan, 8, conCaseCommonBase.IdTeachingPlan);
}
objCaseCommonBaseEN.IdTeachingPlan = strIdTeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdTeachingPlan) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdTeachingPlan, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdTeachingPlan] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdDiscipline(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdDiscipline, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdDiscipline, conCaseCommonBase.IdDiscipline);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdDiscipline, 4, conCaseCommonBase.IdDiscipline);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdDiscipline, 4, conCaseCommonBase.IdDiscipline);
}
objCaseCommonBaseEN.IdDiscipline = strIdDiscipline; //学科流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdDiscipline) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdDiscipline, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdDiscipline] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetBrowseCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, int? intBrowseCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.BrowseCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.BrowseCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.BrowseCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdSenateGaugeVersion(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, conCaseCommonBase.IdSenateGaugeVersion);
}
objCaseCommonBaseEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdSenateGaugeVersion) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdTeachSkill(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdTeachSkill, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdTeachSkill, conCaseCommonBase.IdTeachSkill);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdTeachSkill, 8, conCaseCommonBase.IdTeachSkill);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdTeachSkill, 8, conCaseCommonBase.IdTeachSkill);
}
objCaseCommonBaseEN.IdTeachSkill = strIdTeachSkill; //教学技能流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdTeachSkill) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdTeachSkill, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdTeachSkill] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCaseLevelId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCaseLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseLevelId, 2, conCaseCommonBase.CaseLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseLevelId, 2, conCaseCommonBase.CaseLevelId);
}
objCaseCommonBaseEN.CaseLevelId = strCaseLevelId; //课例等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CaseLevelId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CaseLevelId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CaseLevelId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetDocFile(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strDocFile, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDocFile, 200, conCaseCommonBase.DocFile);
}
objCaseCommonBaseEN.DocFile = strDocFile; //生成的Word文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.DocFile) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.DocFile, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.DocFile] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsNeedGeneWord(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsNeedGeneWord, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsNeedGeneWord = bolIsNeedGeneWord; //是否需要生成Word
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsNeedGeneWord) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsNeedGeneWord, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsNeedGeneWord] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetWordCreateDate(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strWordCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWordCreateDate, 14, conCaseCommonBase.WordCreateDate);
}
objCaseCommonBaseEN.WordCreateDate = strWordCreateDate; //Word生成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.WordCreateDate) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.WordCreateDate, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.WordCreateDate] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsVisible(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsVisible, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsVisible) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsVisible, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsVisible] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsDualVideo(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsDualVideo, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsDualVideo = bolIsDualVideo; //是否双视频
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsDualVideo) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsDualVideo, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsDualVideo] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdXzCollege(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, conCaseCommonBase.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conCaseCommonBase.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conCaseCommonBase.IdXzCollege);
}
objCaseCommonBaseEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdXzCollege) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdXzCollege, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdXzCollege] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdXzMajor(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, conCaseCommonBase.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conCaseCommonBase.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conCaseCommonBase.IdXzMajor);
}
objCaseCommonBaseEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdXzMajor) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdXzMajor, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdXzMajor] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetViewCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, int? intViewCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.ViewCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.ViewCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.ViewCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIsShow(this clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsShow, string strComparisonOp="")
	{
objCaseCommonBaseEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IsShow) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IsShow, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IsShow] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetDownloadNumber(this clsCaseCommonBaseEN objCaseCommonBaseEN, int? intDownloadNumber, string strComparisonOp="")
	{
objCaseCommonBaseEN.DownloadNumber = intDownloadNumber; //下载数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.DownloadNumber) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.DownloadNumber, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.DownloadNumber] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetFileIntegration(this clsCaseCommonBaseEN objCaseCommonBaseEN, int? intFileIntegration, string strComparisonOp="")
	{
objCaseCommonBaseEN.FileIntegration = intFileIntegration; //文件积分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.FileIntegration) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.FileIntegration, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.FileIntegration] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetLikeCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, long? lngLikeCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.LikeCount = lngLikeCount; //资源喜欢数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.LikeCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.LikeCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.LikeCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCollectionCount(this clsCaseCommonBaseEN objCaseCommonBaseEN, long? lngCollectionCount, string strComparisonOp="")
	{
objCaseCommonBaseEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CollectionCount) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CollectionCount, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CollectionCount] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetRecommendedDegreeId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strRecommendedDegreeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRecommendedDegreeId, conCaseCommonBase.RecommendedDegreeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRecommendedDegreeId, 2, conCaseCommonBase.RecommendedDegreeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRecommendedDegreeId, 2, conCaseCommonBase.RecommendedDegreeId);
}
objCaseCommonBaseEN.RecommendedDegreeId = strRecommendedDegreeId; //推荐度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.RecommendedDegreeId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.RecommendedDegreeId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.RecommendedDegreeId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetCourseId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conCaseCommonBase.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCaseCommonBase.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCaseCommonBase.CourseId);
}
objCaseCommonBaseEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.CourseId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.CourseId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.CourseId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetIdCaseType4FuncModuleId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strIdCaseType4FuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCaseType4FuncModuleId, 4, conCaseCommonBase.IdCaseType4FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCaseType4FuncModuleId, 4, conCaseCommonBase.IdCaseType4FuncModuleId);
}
objCaseCommonBaseEN.IdCaseType4FuncModuleId = strIdCaseType4FuncModuleId; //案例类型流水号4模块
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.IdCaseType4FuncModuleId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.IdCaseType4FuncModuleId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.IdCaseType4FuncModuleId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetftpFileType(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strftpFileType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strftpFileType, 30, conCaseCommonBase.ftpFileType);
}
objCaseCommonBaseEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.ftpFileType) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.ftpFileType, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.ftpFileType] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetVideoUrl(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strVideoUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoUrl, 1000, conCaseCommonBase.VideoUrl);
}
objCaseCommonBaseEN.VideoUrl = strVideoUrl; //视频Url
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.VideoUrl) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.VideoUrl, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.VideoUrl] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetVideoPath(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strVideoPath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVideoPath, 1000, conCaseCommonBase.VideoPath);
}
objCaseCommonBaseEN.VideoPath = strVideoPath; //视频目录
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.VideoPath) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.VideoPath, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.VideoPath] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetResErrMsg(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strResErrMsg, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResErrMsg, 30, conCaseCommonBase.ResErrMsg);
}
objCaseCommonBaseEN.ResErrMsg = strResErrMsg; //资源错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.ResErrMsg) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.ResErrMsg, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.ResErrMsg] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetUpdDate(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseCommonBase.UpdDate);
}
objCaseCommonBaseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.UpdDate) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.UpdDate, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.UpdDate] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetUpdUserId(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseCommonBase.UpdUserId);
}
objCaseCommonBaseEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.UpdUserId) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.UpdUserId, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.UpdUserId] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseCommonBaseEN SetMemo(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseCommonBase.Memo);
}
objCaseCommonBaseEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCommonBaseEN.dicFldComparisonOp.ContainsKey(conCaseCommonBase.Memo) == false)
{
objCaseCommonBaseEN.dicFldComparisonOp.Add(conCaseCommonBase.Memo, strComparisonOp);
}
else
{
objCaseCommonBaseEN.dicFldComparisonOp[conCaseCommonBase.Memo] = strComparisonOp;
}
}
return objCaseCommonBaseEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCaseCommonBaseEN.CheckPropertyNew();
clsCaseCommonBaseEN objCaseCommonBaseCond = new clsCaseCommonBaseEN();
string strCondition = objCaseCommonBaseCond
.SetIdCase(objCaseCommonBaseEN.IdCase, "=")
.GetCombineCondition();
objCaseCommonBaseEN._IsCheckProperty = true;
bool bolIsExist = clsCaseCommonBaseBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCaseCommonBaseEN.Update();
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseCommonBaseBL.CaseCommonBaseDA.UpdateBySql2(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCommonBaseEN objCaseCommonBaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseCommonBaseBL.CaseCommonBaseDA.UpdateBySql2(objCaseCommonBaseEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strWhereCond)
{
try
{
bool bolResult = clsCaseCommonBaseBL.CaseCommonBaseDA.UpdateBySqlWithCondition(objCaseCommonBaseEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCommonBaseEN objCaseCommonBaseEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCaseCommonBaseBL.CaseCommonBaseDA.UpdateBySqlWithConditionTransaction(objCaseCommonBaseEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
try
{
int intRecNum = clsCaseCommonBaseBL.CaseCommonBaseDA.DelRecord(objCaseCommonBaseEN.IdCase);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseENS">源对象</param>
 /// <param name = "objCaseCommonBaseENT">目标对象</param>
 public static void CopyTo(this clsCaseCommonBaseEN objCaseCommonBaseENS, clsCaseCommonBaseEN objCaseCommonBaseENT)
{
try
{
objCaseCommonBaseENT.IdCase = objCaseCommonBaseENS.IdCase; //案例流水号
objCaseCommonBaseENT.CaseId = objCaseCommonBaseENS.CaseId; //案例Id
objCaseCommonBaseENT.CaseName = objCaseCommonBaseENS.CaseName; //案例名称
objCaseCommonBaseENT.CaseText = objCaseCommonBaseENS.CaseText; //案例文本内容
objCaseCommonBaseENT.CaseTheme = objCaseCommonBaseENS.CaseTheme; //案例主题词
objCaseCommonBaseENT.FuncModuleId = objCaseCommonBaseENS.FuncModuleId; //功能模块Id
objCaseCommonBaseENT.CourseChapterId = objCaseCommonBaseENS.CourseChapterId; //课程章节ID
objCaseCommonBaseENT.IdCaseType = objCaseCommonBaseENS.IdCaseType; //案例类型流水号
objCaseCommonBaseENT.CaseDate = objCaseCommonBaseENS.CaseDate; //案例建立日期
objCaseCommonBaseENT.CaseTime = objCaseCommonBaseENS.CaseTime; //案例建立时间
objCaseCommonBaseENT.CaseDateIn = objCaseCommonBaseENS.CaseDateIn; //案例入库日期
objCaseCommonBaseENT.CaseTimeIn = objCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objCaseCommonBaseENT.OwnerId = objCaseCommonBaseENS.OwnerId; //拥有者Id
objCaseCommonBaseENT.IdStudyLevel = objCaseCommonBaseENS.IdStudyLevel; //学段流水号
objCaseCommonBaseENT.IdTeachingPlan = objCaseCommonBaseENS.IdTeachingPlan; //教案流水号
objCaseCommonBaseENT.IdDiscipline = objCaseCommonBaseENS.IdDiscipline; //学科流水号
objCaseCommonBaseENT.BrowseCount = objCaseCommonBaseENS.BrowseCount; //浏览次数
objCaseCommonBaseENT.IdSenateGaugeVersion = objCaseCommonBaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCaseCommonBaseENT.IdTeachSkill = objCaseCommonBaseENS.IdTeachSkill; //教学技能流水号
objCaseCommonBaseENT.CaseLevelId = objCaseCommonBaseENS.CaseLevelId; //课例等级Id
objCaseCommonBaseENT.DocFile = objCaseCommonBaseENS.DocFile; //生成的Word文件名
objCaseCommonBaseENT.IsNeedGeneWord = objCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objCaseCommonBaseENT.WordCreateDate = objCaseCommonBaseENS.WordCreateDate; //Word生成日期
objCaseCommonBaseENT.IsVisible = objCaseCommonBaseENS.IsVisible; //是否显示
objCaseCommonBaseENT.IsDualVideo = objCaseCommonBaseENS.IsDualVideo; //是否双视频
objCaseCommonBaseENT.IdXzCollege = objCaseCommonBaseENS.IdXzCollege; //学院流水号
objCaseCommonBaseENT.IdXzMajor = objCaseCommonBaseENS.IdXzMajor; //专业流水号
objCaseCommonBaseENT.ViewCount = objCaseCommonBaseENS.ViewCount; //浏览量
objCaseCommonBaseENT.IsShow = objCaseCommonBaseENS.IsShow; //是否启用
objCaseCommonBaseENT.DownloadNumber = objCaseCommonBaseENS.DownloadNumber; //下载数目
objCaseCommonBaseENT.FileIntegration = objCaseCommonBaseENS.FileIntegration; //文件积分
objCaseCommonBaseENT.LikeCount = objCaseCommonBaseENS.LikeCount; //资源喜欢数量
objCaseCommonBaseENT.CollectionCount = objCaseCommonBaseENS.CollectionCount; //收藏数量
objCaseCommonBaseENT.RecommendedDegreeId = objCaseCommonBaseENS.RecommendedDegreeId; //推荐度Id
objCaseCommonBaseENT.CourseId = objCaseCommonBaseENS.CourseId; //课程Id
objCaseCommonBaseENT.IdCaseType4FuncModuleId = objCaseCommonBaseENS.IdCaseType4FuncModuleId; //案例类型流水号4模块
objCaseCommonBaseENT.ftpFileType = objCaseCommonBaseENS.ftpFileType; //ftp文件类型
objCaseCommonBaseENT.VideoUrl = objCaseCommonBaseENS.VideoUrl; //视频Url
objCaseCommonBaseENT.VideoPath = objCaseCommonBaseENS.VideoPath; //视频目录
objCaseCommonBaseENT.ResErrMsg = objCaseCommonBaseENS.ResErrMsg; //资源错误信息
objCaseCommonBaseENT.UpdDate = objCaseCommonBaseENS.UpdDate; //修改日期
objCaseCommonBaseENT.UpdUserId = objCaseCommonBaseENS.UpdUserId; //修改用户Id
objCaseCommonBaseENT.Memo = objCaseCommonBaseENS.Memo; //备注
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
 /// <param name = "objCaseCommonBaseENS">源对象</param>
 /// <returns>目标对象=>clsCaseCommonBaseEN:objCaseCommonBaseENT</returns>
 public static clsCaseCommonBaseEN CopyTo(this clsCaseCommonBaseEN objCaseCommonBaseENS)
{
try
{
 clsCaseCommonBaseEN objCaseCommonBaseENT = new clsCaseCommonBaseEN()
{
IdCase = objCaseCommonBaseENS.IdCase, //案例流水号
CaseId = objCaseCommonBaseENS.CaseId, //案例Id
CaseName = objCaseCommonBaseENS.CaseName, //案例名称
CaseText = objCaseCommonBaseENS.CaseText, //案例文本内容
CaseTheme = objCaseCommonBaseENS.CaseTheme, //案例主题词
FuncModuleId = objCaseCommonBaseENS.FuncModuleId, //功能模块Id
CourseChapterId = objCaseCommonBaseENS.CourseChapterId, //课程章节ID
IdCaseType = objCaseCommonBaseENS.IdCaseType, //案例类型流水号
CaseDate = objCaseCommonBaseENS.CaseDate, //案例建立日期
CaseTime = objCaseCommonBaseENS.CaseTime, //案例建立时间
CaseDateIn = objCaseCommonBaseENS.CaseDateIn, //案例入库日期
CaseTimeIn = objCaseCommonBaseENS.CaseTimeIn, //案例入库时间
OwnerId = objCaseCommonBaseENS.OwnerId, //拥有者Id
IdStudyLevel = objCaseCommonBaseENS.IdStudyLevel, //学段流水号
IdTeachingPlan = objCaseCommonBaseENS.IdTeachingPlan, //教案流水号
IdDiscipline = objCaseCommonBaseENS.IdDiscipline, //学科流水号
BrowseCount = objCaseCommonBaseENS.BrowseCount, //浏览次数
IdSenateGaugeVersion = objCaseCommonBaseENS.IdSenateGaugeVersion, //评价量表版本流水号
IdTeachSkill = objCaseCommonBaseENS.IdTeachSkill, //教学技能流水号
CaseLevelId = objCaseCommonBaseENS.CaseLevelId, //课例等级Id
DocFile = objCaseCommonBaseENS.DocFile, //生成的Word文件名
IsNeedGeneWord = objCaseCommonBaseENS.IsNeedGeneWord, //是否需要生成Word
WordCreateDate = objCaseCommonBaseENS.WordCreateDate, //Word生成日期
IsVisible = objCaseCommonBaseENS.IsVisible, //是否显示
IsDualVideo = objCaseCommonBaseENS.IsDualVideo, //是否双视频
IdXzCollege = objCaseCommonBaseENS.IdXzCollege, //学院流水号
IdXzMajor = objCaseCommonBaseENS.IdXzMajor, //专业流水号
ViewCount = objCaseCommonBaseENS.ViewCount, //浏览量
IsShow = objCaseCommonBaseENS.IsShow, //是否启用
DownloadNumber = objCaseCommonBaseENS.DownloadNumber, //下载数目
FileIntegration = objCaseCommonBaseENS.FileIntegration, //文件积分
LikeCount = objCaseCommonBaseENS.LikeCount, //资源喜欢数量
CollectionCount = objCaseCommonBaseENS.CollectionCount, //收藏数量
RecommendedDegreeId = objCaseCommonBaseENS.RecommendedDegreeId, //推荐度Id
CourseId = objCaseCommonBaseENS.CourseId, //课程Id
IdCaseType4FuncModuleId = objCaseCommonBaseENS.IdCaseType4FuncModuleId, //案例类型流水号4模块
ftpFileType = objCaseCommonBaseENS.ftpFileType, //ftp文件类型
VideoUrl = objCaseCommonBaseENS.VideoUrl, //视频Url
VideoPath = objCaseCommonBaseENS.VideoPath, //视频目录
ResErrMsg = objCaseCommonBaseENS.ResErrMsg, //资源错误信息
UpdDate = objCaseCommonBaseENS.UpdDate, //修改日期
UpdUserId = objCaseCommonBaseENS.UpdUserId, //修改用户Id
Memo = objCaseCommonBaseENS.Memo, //备注
};
 return objCaseCommonBaseENT;
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
public static void CheckPropertyNew(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 clsCaseCommonBaseBL.CaseCommonBaseDA.CheckPropertyNew(objCaseCommonBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 clsCaseCommonBaseBL.CaseCommonBaseDA.CheckProperty4Condition(objCaseCommonBaseEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseCommonBaseEN objCaseCommonBaseCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdCase) == true)
{
string strComparisonOpIdCase = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdCase, objCaseCommonBaseCond.IdCase, strComparisonOpIdCase);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseId) == true)
{
string strComparisonOpCaseId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseId, objCaseCommonBaseCond.CaseId, strComparisonOpCaseId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseName) == true)
{
string strComparisonOpCaseName = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseName, objCaseCommonBaseCond.CaseName, strComparisonOpCaseName);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseText) == true)
{
string strComparisonOpCaseText = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseText, objCaseCommonBaseCond.CaseText, strComparisonOpCaseText);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseTheme) == true)
{
string strComparisonOpCaseTheme = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseTheme, objCaseCommonBaseCond.CaseTheme, strComparisonOpCaseTheme);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.FuncModuleId, objCaseCommonBaseCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CourseChapterId, objCaseCommonBaseCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdCaseType) == true)
{
string strComparisonOpIdCaseType = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdCaseType, objCaseCommonBaseCond.IdCaseType, strComparisonOpIdCaseType);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseDate) == true)
{
string strComparisonOpCaseDate = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseDate, objCaseCommonBaseCond.CaseDate, strComparisonOpCaseDate);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseTime) == true)
{
string strComparisonOpCaseTime = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseTime, objCaseCommonBaseCond.CaseTime, strComparisonOpCaseTime);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseDateIn) == true)
{
string strComparisonOpCaseDateIn = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseDateIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseDateIn, objCaseCommonBaseCond.CaseDateIn, strComparisonOpCaseDateIn);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseTimeIn) == true)
{
string strComparisonOpCaseTimeIn = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseTimeIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseTimeIn, objCaseCommonBaseCond.CaseTimeIn, strComparisonOpCaseTimeIn);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.OwnerId) == true)
{
string strComparisonOpOwnerId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.OwnerId, objCaseCommonBaseCond.OwnerId, strComparisonOpOwnerId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdStudyLevel) == true)
{
string strComparisonOpIdStudyLevel = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdStudyLevel];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdStudyLevel, objCaseCommonBaseCond.IdStudyLevel, strComparisonOpIdStudyLevel);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdTeachingPlan) == true)
{
string strComparisonOpIdTeachingPlan = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdTeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdTeachingPlan, objCaseCommonBaseCond.IdTeachingPlan, strComparisonOpIdTeachingPlan);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdDiscipline) == true)
{
string strComparisonOpIdDiscipline = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdDiscipline];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdDiscipline, objCaseCommonBaseCond.IdDiscipline, strComparisonOpIdDiscipline);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.BrowseCount, objCaseCommonBaseCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdSenateGaugeVersion, objCaseCommonBaseCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdTeachSkill) == true)
{
string strComparisonOpIdTeachSkill = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdTeachSkill];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdTeachSkill, objCaseCommonBaseCond.IdTeachSkill, strComparisonOpIdTeachSkill);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CaseLevelId) == true)
{
string strComparisonOpCaseLevelId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CaseLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CaseLevelId, objCaseCommonBaseCond.CaseLevelId, strComparisonOpCaseLevelId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.DocFile) == true)
{
string strComparisonOpDocFile = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.DocFile];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.DocFile, objCaseCommonBaseCond.DocFile, strComparisonOpDocFile);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IsNeedGeneWord) == true)
{
if (objCaseCommonBaseCond.IsNeedGeneWord == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsNeedGeneWord);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsNeedGeneWord);
}
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.WordCreateDate) == true)
{
string strComparisonOpWordCreateDate = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.WordCreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.WordCreateDate, objCaseCommonBaseCond.WordCreateDate, strComparisonOpWordCreateDate);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IsVisible) == true)
{
if (objCaseCommonBaseCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsVisible);
}
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IsDualVideo) == true)
{
if (objCaseCommonBaseCond.IsDualVideo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsDualVideo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsDualVideo);
}
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdXzCollege, objCaseCommonBaseCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdXzMajor, objCaseCommonBaseCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.ViewCount) == true)
{
string strComparisonOpViewCount = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.ViewCount, objCaseCommonBaseCond.ViewCount, strComparisonOpViewCount);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IsShow) == true)
{
if (objCaseCommonBaseCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCaseCommonBase.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCaseCommonBase.IsShow);
}
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.DownloadNumber) == true)
{
string strComparisonOpDownloadNumber = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.DownloadNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.DownloadNumber, objCaseCommonBaseCond.DownloadNumber, strComparisonOpDownloadNumber);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.FileIntegration) == true)
{
string strComparisonOpFileIntegration = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.FileIntegration];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.FileIntegration, objCaseCommonBaseCond.FileIntegration, strComparisonOpFileIntegration);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.LikeCount) == true)
{
string strComparisonOpLikeCount = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.LikeCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.LikeCount, objCaseCommonBaseCond.LikeCount, strComparisonOpLikeCount);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCommonBase.CollectionCount, objCaseCommonBaseCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.RecommendedDegreeId) == true)
{
string strComparisonOpRecommendedDegreeId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.RecommendedDegreeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.RecommendedDegreeId, objCaseCommonBaseCond.RecommendedDegreeId, strComparisonOpRecommendedDegreeId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.CourseId) == true)
{
string strComparisonOpCourseId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.CourseId, objCaseCommonBaseCond.CourseId, strComparisonOpCourseId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.IdCaseType4FuncModuleId) == true)
{
string strComparisonOpIdCaseType4FuncModuleId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.IdCaseType4FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.IdCaseType4FuncModuleId, objCaseCommonBaseCond.IdCaseType4FuncModuleId, strComparisonOpIdCaseType4FuncModuleId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.ftpFileType) == true)
{
string strComparisonOpftpFileType = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.ftpFileType, objCaseCommonBaseCond.ftpFileType, strComparisonOpftpFileType);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.VideoUrl) == true)
{
string strComparisonOpVideoUrl = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.VideoUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.VideoUrl, objCaseCommonBaseCond.VideoUrl, strComparisonOpVideoUrl);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.VideoPath) == true)
{
string strComparisonOpVideoPath = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.VideoPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.VideoPath, objCaseCommonBaseCond.VideoPath, strComparisonOpVideoPath);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.ResErrMsg) == true)
{
string strComparisonOpResErrMsg = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.ResErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.ResErrMsg, objCaseCommonBaseCond.ResErrMsg, strComparisonOpResErrMsg);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.UpdDate) == true)
{
string strComparisonOpUpdDate = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.UpdDate, objCaseCommonBaseCond.UpdDate, strComparisonOpUpdDate);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.UpdUserId, objCaseCommonBaseCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCaseCommonBaseCond.IsUpdated(conCaseCommonBase.Memo) == true)
{
string strComparisonOpMemo = objCaseCommonBaseCond.dicFldComparisonOp[conCaseCommonBase.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCommonBase.Memo, objCaseCommonBaseCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CaseCommonBase
{
public virtual bool UpdRelaTabDate(string strIdCase, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例公共基类(CaseCommonBase)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCaseCommonBaseBL
{
public static RelatedActions_CaseCommonBase relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCaseCommonBaseDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCaseCommonBaseDA CaseCommonBaseDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCaseCommonBaseDA();
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
 public clsCaseCommonBaseBL()
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
if (string.IsNullOrEmpty(clsCaseCommonBaseEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseCommonBaseEN._ConnectString);
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
public static DataTable GetDataTable_CaseCommonBase(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CaseCommonBaseDA.GetDataTable_CaseCommonBase(strWhereCond);
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
objDT = CaseCommonBaseDA.GetDataTable(strWhereCond);
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
objDT = CaseCommonBaseDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CaseCommonBaseDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CaseCommonBaseDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CaseCommonBaseDA.GetDataTable_Top(objTopPara);
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
objDT = CaseCommonBaseDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CaseCommonBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CaseCommonBaseDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLstByIdCaseLst(List<string> arrIdCaseLst)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseLst, true);
 string strWhereCond = string.Format("IdCase in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCaseCommonBaseEN> GetObjLstByIdCaseLstCache(List<string> arrIdCaseLst)
{
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName);
List<clsCaseCommonBaseEN> arrCaseCommonBaseObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCommonBaseEN> arrCaseCommonBaseObjLst_Sel =
arrCaseCommonBaseObjLstCache
.Where(x => arrIdCaseLst.Contains(x.IdCase));
return arrCaseCommonBaseObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLst(string strWhereCond)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
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
public static List<clsCaseCommonBaseEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCaseCommonBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCaseCommonBaseEN> GetSubObjLstCache(clsCaseCommonBaseEN objCaseCommonBaseCond)
{
List<clsCaseCommonBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCommonBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseCommonBase.AttributeName)
{
if (objCaseCommonBaseCond.IsUpdated(strFldName) == false) continue;
if (objCaseCommonBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCommonBaseCond[strFldName].ToString());
}
else
{
if (objCaseCommonBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseCommonBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCommonBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseCommonBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseCommonBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseCommonBaseCond[strFldName]));
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
public static List<clsCaseCommonBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
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
public static List<clsCaseCommonBaseEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
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
List<clsCaseCommonBaseEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCaseCommonBaseEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCommonBaseEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCaseCommonBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
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
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
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
public static List<clsCaseCommonBaseEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCaseCommonBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
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
public static List<clsCaseCommonBaseEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCaseCommonBaseEN> arrObjLst = new List<clsCaseCommonBaseEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseCommonBaseEN objCaseCommonBaseEN = new clsCaseCommonBaseEN();
try
{
objCaseCommonBaseEN.IdCase = objRow[conCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objCaseCommonBaseEN.CaseId = objRow[conCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objCaseCommonBaseEN.CaseName = objRow[conCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objCaseCommonBaseEN.CaseText = objRow[conCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objCaseCommonBaseEN.CaseTheme = objRow[conCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objCaseCommonBaseEN.FuncModuleId = objRow[conCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseCommonBaseEN.CourseChapterId = objRow[conCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objCaseCommonBaseEN.IdCaseType = objRow[conCaseCommonBase.IdCaseType] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objCaseCommonBaseEN.CaseDate = objRow[conCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objCaseCommonBaseEN.CaseTime = objRow[conCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objCaseCommonBaseEN.CaseDateIn = objRow[conCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objCaseCommonBaseEN.CaseTimeIn = objRow[conCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objCaseCommonBaseEN.OwnerId = objRow[conCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objCaseCommonBaseEN.IdStudyLevel = objRow[conCaseCommonBase.IdStudyLevel] == DBNull.Value ? null : objRow[conCaseCommonBase.IdStudyLevel].ToString().Trim(); //学段流水号
objCaseCommonBaseEN.IdTeachingPlan = objRow[conCaseCommonBase.IdTeachingPlan] == DBNull.Value ? null : objRow[conCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objCaseCommonBaseEN.IdDiscipline = objRow[conCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objCaseCommonBaseEN.BrowseCount = objRow[conCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objCaseCommonBaseEN.IdSenateGaugeVersion = objRow[conCaseCommonBase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objCaseCommonBaseEN.IdTeachSkill = objRow[conCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objCaseCommonBaseEN.CaseLevelId = objRow[conCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[conCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objCaseCommonBaseEN.DocFile = objRow[conCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[conCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objCaseCommonBaseEN.WordCreateDate = objRow[conCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[conCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objCaseCommonBaseEN.IdXzCollege = objRow[conCaseCommonBase.IdXzCollege].ToString().Trim(); //学院流水号
objCaseCommonBaseEN.IdXzMajor = objRow[conCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objCaseCommonBaseEN.ViewCount = objRow[conCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objCaseCommonBaseEN.DownloadNumber = objRow[conCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objCaseCommonBaseEN.FileIntegration = objRow[conCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objCaseCommonBaseEN.LikeCount = objRow[conCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objCaseCommonBaseEN.CollectionCount = objRow[conCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
objCaseCommonBaseEN.RecommendedDegreeId = objRow[conCaseCommonBase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objCaseCommonBaseEN.CourseId = objRow[conCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objRow[conCaseCommonBase.IdCaseType4FuncModuleId] == DBNull.Value ? null : objRow[conCaseCommonBase.IdCaseType4FuncModuleId].ToString().Trim(); //案例类型流水号4模块
objCaseCommonBaseEN.ftpFileType = objRow[conCaseCommonBase.ftpFileType] == DBNull.Value ? null : objRow[conCaseCommonBase.ftpFileType].ToString().Trim(); //ftp文件类型
objCaseCommonBaseEN.VideoUrl = objRow[conCaseCommonBase.VideoUrl] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoUrl].ToString().Trim(); //视频Url
objCaseCommonBaseEN.VideoPath = objRow[conCaseCommonBase.VideoPath] == DBNull.Value ? null : objRow[conCaseCommonBase.VideoPath].ToString().Trim(); //视频目录
objCaseCommonBaseEN.ResErrMsg = objRow[conCaseCommonBase.ResErrMsg] == DBNull.Value ? null : objRow[conCaseCommonBase.ResErrMsg].ToString().Trim(); //资源错误信息
objCaseCommonBaseEN.UpdDate = objRow[conCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objCaseCommonBaseEN.UpdUserId = objRow[conCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[conCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objCaseCommonBaseEN.Memo = objRow[conCaseCommonBase.Memo] == DBNull.Value ? null : objRow[conCaseCommonBase.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseCommonBaseEN.IdCase, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseCommonBaseEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCaseCommonBaseEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCaseCommonBase(ref clsCaseCommonBaseEN objCaseCommonBaseEN)
{
bool bolResult = CaseCommonBaseDA.GetCaseCommonBase(ref objCaseCommonBaseEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCase">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCommonBaseEN GetObjByIdCase(string strIdCase)
{
if (strIdCase.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCase]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCase) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCase]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsCaseCommonBaseEN objCaseCommonBaseEN = CaseCommonBaseDA.GetObjByIdCase(strIdCase);
return objCaseCommonBaseEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCaseCommonBaseEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCaseCommonBaseEN objCaseCommonBaseEN = CaseCommonBaseDA.GetFirstObj(strWhereCond);
 return objCaseCommonBaseEN;
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
public static clsCaseCommonBaseEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCaseCommonBaseEN objCaseCommonBaseEN = CaseCommonBaseDA.GetObjByDataRow(objRow);
 return objCaseCommonBaseEN;
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
public static clsCaseCommonBaseEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCaseCommonBaseEN objCaseCommonBaseEN = CaseCommonBaseDA.GetObjByDataRow(objRow);
 return objCaseCommonBaseEN;
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
 /// <param name = "strIdCase">所给的关键字</param>
 /// <param name = "lstCaseCommonBaseObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCommonBaseEN GetObjByIdCaseFromList(string strIdCase, List<clsCaseCommonBaseEN> lstCaseCommonBaseObjLst)
{
foreach (clsCaseCommonBaseEN objCaseCommonBaseEN in lstCaseCommonBaseObjLst)
{
if (objCaseCommonBaseEN.IdCase == strIdCase)
{
return objCaseCommonBaseEN;
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
 string strIdCase;
 try
 {
 strIdCase = new clsCaseCommonBaseDA().GetFirstID(strWhereCond);
 return strIdCase;
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
 arrList = CaseCommonBaseDA.GetID(strWhereCond);
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
bool bolIsExist = CaseCommonBaseDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCase)
{
if (string.IsNullOrEmpty(strIdCase) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCase]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = CaseCommonBaseDA.IsExist(strIdCase);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdCase">案例流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdCase, string strOpUser)
{
clsCaseCommonBaseEN objCaseCommonBaseEN = clsCaseCommonBaseBL.GetObjByIdCase(strIdCase);
objCaseCommonBaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCaseCommonBaseEN.UpdUserId = strOpUser;
return clsCaseCommonBaseBL.UpdateBySql2(objCaseCommonBaseEN);
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
 bolIsExist = clsCaseCommonBaseDA.IsExistTable();
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
 bolIsExist = CaseCommonBaseDA.IsExistTable(strTabName);
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCaseCommonBaseBL.IsExist(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCaseCommonBaseEN.IdCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = CaseCommonBaseDA.AddNewRecordBySQL2(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCaseCommonBaseEN objCaseCommonBaseEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsCaseCommonBaseBL.IsExist(objCaseCommonBaseEN.IdCase) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objCaseCommonBaseEN.IdCase, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = CaseCommonBaseDA.AddNewRecordBySQL2WithReturnKey(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
try
{
bool bolResult = CaseCommonBaseDA.Update(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "objCaseCommonBaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 if (string.IsNullOrEmpty(objCaseCommonBaseEN.IdCase) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CaseCommonBaseDA.UpdateBySql2(objCaseCommonBaseEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCommonBaseBL.ReFreshCache();

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
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
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdCase)
{
try
{
 clsCaseCommonBaseEN objCaseCommonBaseEN = clsCaseCommonBaseBL.GetObjByIdCase(strIdCase);

if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(objCaseCommonBaseEN.IdCase, objCaseCommonBaseEN.UpdUserId);
}
if (objCaseCommonBaseEN != null)
{
int intRecNum = CaseCommonBaseDA.DelRecord(strIdCase);
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
/// <param name="strIdCase">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdCase )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
//删除与表:[CaseCommonBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCaseCommonBase.IdCase,
//strIdCase);
//        clsCaseCommonBaseBL.DelCaseCommonBasesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseCommonBaseBL.DelRecord(strIdCase, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseCommonBaseBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCaseCommonBaseBL.relatedActions != null)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(strIdCase, "UpdRelaTabDate");
}
bool bolResult = CaseCommonBaseDA.DelRecord(strIdCase,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCaseLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCaseCommonBases(List<string> arrIdCaseLst)
{
if (arrIdCaseLst.Count == 0) return 0;
try
{
if (clsCaseCommonBaseBL.relatedActions != null)
{
foreach (var strIdCase in arrIdCaseLst)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(strIdCase, "UpdRelaTabDate");
}
}
int intDelRecNum = CaseCommonBaseDA.DelCaseCommonBase(arrIdCaseLst);
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
public static int DelCaseCommonBasesByCond(string strWhereCond)
{
try
{
if (clsCaseCommonBaseBL.relatedActions != null)
{
List<string> arrIdCase = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCase in arrIdCase)
{
clsCaseCommonBaseBL.relatedActions.UpdRelaTabDate(strIdCase, "UpdRelaTabDate");
}
}
int intRecNum = CaseCommonBaseDA.DelCaseCommonBase(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CaseCommonBase]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdCase">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdCase)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseCommonBaseDA.GetSpecSQLObj();
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
//删除与表:[CaseCommonBase]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseCommonBaseBL.DelRecord(strIdCase, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseCommonBaseBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdCase, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCaseCommonBaseENS">源对象</param>
 /// <param name = "objCaseCommonBaseENT">目标对象</param>
 public static void CopyTo(clsCaseCommonBaseEN objCaseCommonBaseENS, clsCaseCommonBaseEN objCaseCommonBaseENT)
{
try
{
objCaseCommonBaseENT.IdCase = objCaseCommonBaseENS.IdCase; //案例流水号
objCaseCommonBaseENT.CaseId = objCaseCommonBaseENS.CaseId; //案例Id
objCaseCommonBaseENT.CaseName = objCaseCommonBaseENS.CaseName; //案例名称
objCaseCommonBaseENT.CaseText = objCaseCommonBaseENS.CaseText; //案例文本内容
objCaseCommonBaseENT.CaseTheme = objCaseCommonBaseENS.CaseTheme; //案例主题词
objCaseCommonBaseENT.FuncModuleId = objCaseCommonBaseENS.FuncModuleId; //功能模块Id
objCaseCommonBaseENT.CourseChapterId = objCaseCommonBaseENS.CourseChapterId; //课程章节ID
objCaseCommonBaseENT.IdCaseType = objCaseCommonBaseENS.IdCaseType; //案例类型流水号
objCaseCommonBaseENT.CaseDate = objCaseCommonBaseENS.CaseDate; //案例建立日期
objCaseCommonBaseENT.CaseTime = objCaseCommonBaseENS.CaseTime; //案例建立时间
objCaseCommonBaseENT.CaseDateIn = objCaseCommonBaseENS.CaseDateIn; //案例入库日期
objCaseCommonBaseENT.CaseTimeIn = objCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objCaseCommonBaseENT.OwnerId = objCaseCommonBaseENS.OwnerId; //拥有者Id
objCaseCommonBaseENT.IdStudyLevel = objCaseCommonBaseENS.IdStudyLevel; //学段流水号
objCaseCommonBaseENT.IdTeachingPlan = objCaseCommonBaseENS.IdTeachingPlan; //教案流水号
objCaseCommonBaseENT.IdDiscipline = objCaseCommonBaseENS.IdDiscipline; //学科流水号
objCaseCommonBaseENT.BrowseCount = objCaseCommonBaseENS.BrowseCount; //浏览次数
objCaseCommonBaseENT.IdSenateGaugeVersion = objCaseCommonBaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objCaseCommonBaseENT.IdTeachSkill = objCaseCommonBaseENS.IdTeachSkill; //教学技能流水号
objCaseCommonBaseENT.CaseLevelId = objCaseCommonBaseENS.CaseLevelId; //课例等级Id
objCaseCommonBaseENT.DocFile = objCaseCommonBaseENS.DocFile; //生成的Word文件名
objCaseCommonBaseENT.IsNeedGeneWord = objCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objCaseCommonBaseENT.WordCreateDate = objCaseCommonBaseENS.WordCreateDate; //Word生成日期
objCaseCommonBaseENT.IsVisible = objCaseCommonBaseENS.IsVisible; //是否显示
objCaseCommonBaseENT.IsDualVideo = objCaseCommonBaseENS.IsDualVideo; //是否双视频
objCaseCommonBaseENT.IdXzCollege = objCaseCommonBaseENS.IdXzCollege; //学院流水号
objCaseCommonBaseENT.IdXzMajor = objCaseCommonBaseENS.IdXzMajor; //专业流水号
objCaseCommonBaseENT.ViewCount = objCaseCommonBaseENS.ViewCount; //浏览量
objCaseCommonBaseENT.IsShow = objCaseCommonBaseENS.IsShow; //是否启用
objCaseCommonBaseENT.DownloadNumber = objCaseCommonBaseENS.DownloadNumber; //下载数目
objCaseCommonBaseENT.FileIntegration = objCaseCommonBaseENS.FileIntegration; //文件积分
objCaseCommonBaseENT.LikeCount = objCaseCommonBaseENS.LikeCount; //资源喜欢数量
objCaseCommonBaseENT.CollectionCount = objCaseCommonBaseENS.CollectionCount; //收藏数量
objCaseCommonBaseENT.RecommendedDegreeId = objCaseCommonBaseENS.RecommendedDegreeId; //推荐度Id
objCaseCommonBaseENT.CourseId = objCaseCommonBaseENS.CourseId; //课程Id
objCaseCommonBaseENT.IdCaseType4FuncModuleId = objCaseCommonBaseENS.IdCaseType4FuncModuleId; //案例类型流水号4模块
objCaseCommonBaseENT.ftpFileType = objCaseCommonBaseENS.ftpFileType; //ftp文件类型
objCaseCommonBaseENT.VideoUrl = objCaseCommonBaseENS.VideoUrl; //视频Url
objCaseCommonBaseENT.VideoPath = objCaseCommonBaseENS.VideoPath; //视频目录
objCaseCommonBaseENT.ResErrMsg = objCaseCommonBaseENS.ResErrMsg; //资源错误信息
objCaseCommonBaseENT.UpdDate = objCaseCommonBaseENS.UpdDate; //修改日期
objCaseCommonBaseENT.UpdUserId = objCaseCommonBaseENS.UpdUserId; //修改用户Id
objCaseCommonBaseENT.Memo = objCaseCommonBaseENS.Memo; //备注
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
 /// <param name = "objCaseCommonBaseEN">源简化对象</param>
 public static void SetUpdFlag(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
try
{
objCaseCommonBaseEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCaseCommonBaseEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCaseCommonBase.IdCase, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdCase = objCaseCommonBaseEN.IdCase; //案例流水号
}
if (arrFldSet.Contains(conCaseCommonBase.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseId = objCaseCommonBaseEN.CaseId; //案例Id
}
if (arrFldSet.Contains(conCaseCommonBase.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseName = objCaseCommonBaseEN.CaseName; //案例名称
}
if (arrFldSet.Contains(conCaseCommonBase.CaseText, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseText = objCaseCommonBaseEN.CaseText == "[null]" ? null :  objCaseCommonBaseEN.CaseText; //案例文本内容
}
if (arrFldSet.Contains(conCaseCommonBase.CaseTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseTheme = objCaseCommonBaseEN.CaseTheme == "[null]" ? null :  objCaseCommonBaseEN.CaseTheme; //案例主题词
}
if (arrFldSet.Contains(conCaseCommonBase.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.FuncModuleId = objCaseCommonBaseEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conCaseCommonBase.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CourseChapterId = objCaseCommonBaseEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(conCaseCommonBase.IdCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdCaseType = objCaseCommonBaseEN.IdCaseType == "[null]" ? null :  objCaseCommonBaseEN.IdCaseType; //案例类型流水号
}
if (arrFldSet.Contains(conCaseCommonBase.CaseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseDate = objCaseCommonBaseEN.CaseDate == "[null]" ? null :  objCaseCommonBaseEN.CaseDate; //案例建立日期
}
if (arrFldSet.Contains(conCaseCommonBase.CaseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseTime = objCaseCommonBaseEN.CaseTime == "[null]" ? null :  objCaseCommonBaseEN.CaseTime; //案例建立时间
}
if (arrFldSet.Contains(conCaseCommonBase.CaseDateIn, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseDateIn = objCaseCommonBaseEN.CaseDateIn == "[null]" ? null :  objCaseCommonBaseEN.CaseDateIn; //案例入库日期
}
if (arrFldSet.Contains(conCaseCommonBase.CaseTimeIn, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseTimeIn = objCaseCommonBaseEN.CaseTimeIn == "[null]" ? null :  objCaseCommonBaseEN.CaseTimeIn; //案例入库时间
}
if (arrFldSet.Contains(conCaseCommonBase.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.OwnerId = objCaseCommonBaseEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conCaseCommonBase.IdStudyLevel, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdStudyLevel = objCaseCommonBaseEN.IdStudyLevel == "[null]" ? null :  objCaseCommonBaseEN.IdStudyLevel; //学段流水号
}
if (arrFldSet.Contains(conCaseCommonBase.IdTeachingPlan, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdTeachingPlan = objCaseCommonBaseEN.IdTeachingPlan == "[null]" ? null :  objCaseCommonBaseEN.IdTeachingPlan; //教案流水号
}
if (arrFldSet.Contains(conCaseCommonBase.IdDiscipline, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdDiscipline = objCaseCommonBaseEN.IdDiscipline; //学科流水号
}
if (arrFldSet.Contains(conCaseCommonBase.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.BrowseCount = objCaseCommonBaseEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conCaseCommonBase.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdSenateGaugeVersion = objCaseCommonBaseEN.IdSenateGaugeVersion == "[null]" ? null :  objCaseCommonBaseEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(conCaseCommonBase.IdTeachSkill, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdTeachSkill = objCaseCommonBaseEN.IdTeachSkill; //教学技能流水号
}
if (arrFldSet.Contains(conCaseCommonBase.CaseLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CaseLevelId = objCaseCommonBaseEN.CaseLevelId == "[null]" ? null :  objCaseCommonBaseEN.CaseLevelId; //课例等级Id
}
if (arrFldSet.Contains(conCaseCommonBase.DocFile, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.DocFile = objCaseCommonBaseEN.DocFile == "[null]" ? null :  objCaseCommonBaseEN.DocFile; //生成的Word文件名
}
if (arrFldSet.Contains(conCaseCommonBase.IsNeedGeneWord, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IsNeedGeneWord = objCaseCommonBaseEN.IsNeedGeneWord; //是否需要生成Word
}
if (arrFldSet.Contains(conCaseCommonBase.WordCreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.WordCreateDate = objCaseCommonBaseEN.WordCreateDate == "[null]" ? null :  objCaseCommonBaseEN.WordCreateDate; //Word生成日期
}
if (arrFldSet.Contains(conCaseCommonBase.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IsVisible = objCaseCommonBaseEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conCaseCommonBase.IsDualVideo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IsDualVideo = objCaseCommonBaseEN.IsDualVideo; //是否双视频
}
if (arrFldSet.Contains(conCaseCommonBase.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdXzCollege = objCaseCommonBaseEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conCaseCommonBase.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdXzMajor = objCaseCommonBaseEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conCaseCommonBase.ViewCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.ViewCount = objCaseCommonBaseEN.ViewCount; //浏览量
}
if (arrFldSet.Contains(conCaseCommonBase.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IsShow = objCaseCommonBaseEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conCaseCommonBase.DownloadNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.DownloadNumber = objCaseCommonBaseEN.DownloadNumber; //下载数目
}
if (arrFldSet.Contains(conCaseCommonBase.FileIntegration, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.FileIntegration = objCaseCommonBaseEN.FileIntegration; //文件积分
}
if (arrFldSet.Contains(conCaseCommonBase.LikeCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.LikeCount = objCaseCommonBaseEN.LikeCount; //资源喜欢数量
}
if (arrFldSet.Contains(conCaseCommonBase.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CollectionCount = objCaseCommonBaseEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conCaseCommonBase.RecommendedDegreeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.RecommendedDegreeId = objCaseCommonBaseEN.RecommendedDegreeId; //推荐度Id
}
if (arrFldSet.Contains(conCaseCommonBase.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.CourseId = objCaseCommonBaseEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conCaseCommonBase.IdCaseType4FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.IdCaseType4FuncModuleId = objCaseCommonBaseEN.IdCaseType4FuncModuleId == "[null]" ? null :  objCaseCommonBaseEN.IdCaseType4FuncModuleId; //案例类型流水号4模块
}
if (arrFldSet.Contains(conCaseCommonBase.ftpFileType, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.ftpFileType = objCaseCommonBaseEN.ftpFileType == "[null]" ? null :  objCaseCommonBaseEN.ftpFileType; //ftp文件类型
}
if (arrFldSet.Contains(conCaseCommonBase.VideoUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.VideoUrl = objCaseCommonBaseEN.VideoUrl == "[null]" ? null :  objCaseCommonBaseEN.VideoUrl; //视频Url
}
if (arrFldSet.Contains(conCaseCommonBase.VideoPath, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.VideoPath = objCaseCommonBaseEN.VideoPath == "[null]" ? null :  objCaseCommonBaseEN.VideoPath; //视频目录
}
if (arrFldSet.Contains(conCaseCommonBase.ResErrMsg, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.ResErrMsg = objCaseCommonBaseEN.ResErrMsg == "[null]" ? null :  objCaseCommonBaseEN.ResErrMsg; //资源错误信息
}
if (arrFldSet.Contains(conCaseCommonBase.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.UpdDate = objCaseCommonBaseEN.UpdDate == "[null]" ? null :  objCaseCommonBaseEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCaseCommonBase.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.UpdUserId = objCaseCommonBaseEN.UpdUserId == "[null]" ? null :  objCaseCommonBaseEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conCaseCommonBase.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseCommonBaseEN.Memo = objCaseCommonBaseEN.Memo == "[null]" ? null :  objCaseCommonBaseEN.Memo; //备注
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
 /// <param name = "objCaseCommonBaseEN">源简化对象</param>
 public static void AccessFldValueNull(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
try
{
if (objCaseCommonBaseEN.CaseText == "[null]") objCaseCommonBaseEN.CaseText = null; //案例文本内容
if (objCaseCommonBaseEN.CaseTheme == "[null]") objCaseCommonBaseEN.CaseTheme = null; //案例主题词
if (objCaseCommonBaseEN.IdCaseType == "[null]") objCaseCommonBaseEN.IdCaseType = null; //案例类型流水号
if (objCaseCommonBaseEN.CaseDate == "[null]") objCaseCommonBaseEN.CaseDate = null; //案例建立日期
if (objCaseCommonBaseEN.CaseTime == "[null]") objCaseCommonBaseEN.CaseTime = null; //案例建立时间
if (objCaseCommonBaseEN.CaseDateIn == "[null]") objCaseCommonBaseEN.CaseDateIn = null; //案例入库日期
if (objCaseCommonBaseEN.CaseTimeIn == "[null]") objCaseCommonBaseEN.CaseTimeIn = null; //案例入库时间
if (objCaseCommonBaseEN.IdStudyLevel == "[null]") objCaseCommonBaseEN.IdStudyLevel = null; //学段流水号
if (objCaseCommonBaseEN.IdTeachingPlan == "[null]") objCaseCommonBaseEN.IdTeachingPlan = null; //教案流水号
if (objCaseCommonBaseEN.IdSenateGaugeVersion == "[null]") objCaseCommonBaseEN.IdSenateGaugeVersion = null; //评价量表版本流水号
if (objCaseCommonBaseEN.CaseLevelId == "[null]") objCaseCommonBaseEN.CaseLevelId = null; //课例等级Id
if (objCaseCommonBaseEN.DocFile == "[null]") objCaseCommonBaseEN.DocFile = null; //生成的Word文件名
if (objCaseCommonBaseEN.WordCreateDate == "[null]") objCaseCommonBaseEN.WordCreateDate = null; //Word生成日期
if (objCaseCommonBaseEN.IdCaseType4FuncModuleId == "[null]") objCaseCommonBaseEN.IdCaseType4FuncModuleId = null; //案例类型流水号4模块
if (objCaseCommonBaseEN.ftpFileType == "[null]") objCaseCommonBaseEN.ftpFileType = null; //ftp文件类型
if (objCaseCommonBaseEN.VideoUrl == "[null]") objCaseCommonBaseEN.VideoUrl = null; //视频Url
if (objCaseCommonBaseEN.VideoPath == "[null]") objCaseCommonBaseEN.VideoPath = null; //视频目录
if (objCaseCommonBaseEN.ResErrMsg == "[null]") objCaseCommonBaseEN.ResErrMsg = null; //资源错误信息
if (objCaseCommonBaseEN.UpdDate == "[null]") objCaseCommonBaseEN.UpdDate = null; //修改日期
if (objCaseCommonBaseEN.UpdUserId == "[null]") objCaseCommonBaseEN.UpdUserId = null; //修改用户Id
if (objCaseCommonBaseEN.Memo == "[null]") objCaseCommonBaseEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 CaseCommonBaseDA.CheckPropertyNew(objCaseCommonBaseEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCaseCommonBaseEN objCaseCommonBaseEN)
{
 CaseCommonBaseDA.CheckProperty4Condition(objCaseCommonBaseEN);
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
if (clsCaseCommonBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCommonBaseBL没有刷新缓存机制(clsCaseCommonBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCase");
//if (arrCaseCommonBaseObjLstCache == null)
//{
//arrCaseCommonBaseObjLstCache = CaseCommonBaseDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCase">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCommonBaseEN GetObjByIdCaseCache(string strIdCase)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName);
List<clsCaseCommonBaseEN> arrCaseCommonBaseObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCommonBaseEN> arrCaseCommonBaseObjLst_Sel =
arrCaseCommonBaseObjLstCache
.Where(x=> x.IdCase == strIdCase 
);
if (arrCaseCommonBaseObjLst_Sel.Count() == 0)
{
   clsCaseCommonBaseEN obj = clsCaseCommonBaseBL.GetObjByIdCase(strIdCase);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCaseCommonBaseObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCommonBaseEN> GetAllCaseCommonBaseObjLstCache()
{
//获取缓存中的对象列表
List<clsCaseCommonBaseEN> arrCaseCommonBaseObjLstCache = GetObjLstCache(); 
return arrCaseCommonBaseObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCommonBaseEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName);
List<clsCaseCommonBaseEN> arrCaseCommonBaseObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseCommonBaseObjLstCache;
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
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseCommonBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCaseCommonBaseEN._RefreshTimeLst.Count == 0) return "";
return clsCaseCommonBaseEN._RefreshTimeLst[clsCaseCommonBaseEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCaseCommonBaseBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseCommonBaseEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseCommonBaseEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCaseCommonBaseBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdCase)
{
if (strInFldName != conCaseCommonBase.IdCase)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCaseCommonBase.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCaseCommonBase.AttributeName));
throw new Exception(strMsg);
}
var objCaseCommonBase = clsCaseCommonBaseBL.GetObjByIdCaseCache(strIdCase);
if (objCaseCommonBase == null) return "";
return objCaseCommonBase[strOutFldName].ToString();
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
int intRecCount = clsCaseCommonBaseDA.GetRecCount(strTabName);
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
int intRecCount = clsCaseCommonBaseDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCaseCommonBaseDA.GetRecCount();
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
int intRecCount = clsCaseCommonBaseDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCaseCommonBaseCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCaseCommonBaseEN objCaseCommonBaseCond)
{
List<clsCaseCommonBaseEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseCommonBaseEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseCommonBase.AttributeName)
{
if (objCaseCommonBaseCond.IsUpdated(strFldName) == false) continue;
if (objCaseCommonBaseCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCommonBaseCond[strFldName].ToString());
}
else
{
if (objCaseCommonBaseCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseCommonBaseCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseCommonBaseCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseCommonBaseCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseCommonBaseCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseCommonBaseCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseCommonBaseCond[strFldName]));
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
 List<string> arrList = clsCaseCommonBaseDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CaseCommonBaseDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CaseCommonBaseDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CaseCommonBaseDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseCommonBaseDA.SetFldValue(clsCaseCommonBaseEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CaseCommonBaseDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseCommonBaseDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseCommonBaseDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseCommonBaseDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CaseCommonBase] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例流水号*/ 
 strCreateTabCode.Append(" IdCase char(8) primary key, "); 
 // /**案例Id*/ 
 strCreateTabCode.Append(" CaseId char(8) not Null, "); 
 // /**案例名称*/ 
 strCreateTabCode.Append(" CaseName varchar(100) not Null, "); 
 // /**案例文本内容*/ 
 strCreateTabCode.Append(" CaseText varchar(8000) Null, "); 
 // /**案例主题词*/ 
 strCreateTabCode.Append(" CaseTheme varchar(200) Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) not Null, "); 
 // /**案例类型流水号*/ 
 strCreateTabCode.Append(" IdCaseType char(4) Null, "); 
 // /**案例建立日期*/ 
 strCreateTabCode.Append(" CaseDate char(8) Null, "); 
 // /**案例建立时间*/ 
 strCreateTabCode.Append(" CaseTime char(6) Null, "); 
 // /**案例入库日期*/ 
 strCreateTabCode.Append(" CaseDateIn char(8) Null, "); 
 // /**案例入库时间*/ 
 strCreateTabCode.Append(" CaseTimeIn char(6) Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) not Null, "); 
 // /**学段流水号*/ 
 strCreateTabCode.Append(" IdStudyLevel char(4) Null, "); 
 // /**教案流水号*/ 
 strCreateTabCode.Append(" IdTeachingPlan char(8) Null, "); 
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
 // /**是否双视频*/ 
 strCreateTabCode.Append(" IsDualVideo bit Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) not Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) not Null, "); 
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
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**案例类型流水号4模块*/ 
 strCreateTabCode.Append(" IdCaseType4FuncModuleId char(4) Null, "); 
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
 /// 案例公共基类(CaseCommonBase)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CaseCommonBase : clsCommFun4BL
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
clsCaseCommonBaseBL.ReFreshThisCache();
}
}

}