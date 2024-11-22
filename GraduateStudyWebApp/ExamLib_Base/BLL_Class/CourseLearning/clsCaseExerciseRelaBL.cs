
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseExerciseRelaBL
 表名:CaseExerciseRela(01120437)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:15
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
public static class  clsCaseExerciseRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseExerciseRelaEN GetObj(this K_IdCaseExerciseRela_CaseExerciseRela myKey)
{
clsCaseExerciseRelaEN objCaseExerciseRelaEN = clsCaseExerciseRelaBL.CaseExerciseRelaDA.GetObjByIdCaseExerciseRela(myKey.Value);
return objCaseExerciseRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCaseExerciseRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],考卷流水号 = [{1}]的数据已经存在!(in clsCaseExerciseRelaBL.AddNewRecord)", objCaseExerciseRelaEN.CaseId,objCaseExerciseRelaEN.CourseExamPaperId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCaseExerciseRelaBL.CaseExerciseRelaDA.AddNewRecordBySQL2(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objCaseExerciseRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCaseExerciseRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(案例Id(CaseId)=[{0}],考卷流水号(CourseExamPaperId)=[{1}])已经存在,不能重复!", objCaseExerciseRelaEN.CaseId, objCaseExerciseRelaEN.CourseExamPaperId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCaseExerciseRelaEN.AddNewRecord();
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCaseExerciseRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],考卷流水号 = [{1}]的数据已经存在!(in clsCaseExerciseRelaBL.AddNewRecordWithReturnKey)", objCaseExerciseRelaEN.CaseId,objCaseExerciseRelaEN.CourseExamPaperId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCaseExerciseRelaBL.CaseExerciseRelaDA.AddNewRecordBySQL2WithReturnKey(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetIdCaseExerciseRela(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, long lngIdCaseExerciseRela, string strComparisonOp="")
	{
objCaseExerciseRelaEN.IdCaseExerciseRela = lngIdCaseExerciseRela; //案例习题关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.IdCaseExerciseRela) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.IdCaseExerciseRela, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.IdCaseExerciseRela] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetFuncModuleId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseExerciseRela.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseExerciseRela.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseExerciseRela.FuncModuleId);
}
objCaseExerciseRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.FuncModuleId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.FuncModuleId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.FuncModuleId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCaseId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseExerciseRela.CaseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseExerciseRela.CaseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseExerciseRela.CaseId);
}
objCaseExerciseRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CaseId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CaseId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CaseId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCaseName(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseExerciseRela.CaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseExerciseRela.CaseName);
}
objCaseExerciseRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CaseName) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CaseName, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CaseName] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetOwnerId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseExerciseRela.OwnerId);
}
objCaseExerciseRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.OwnerId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.OwnerId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.OwnerId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCourseExamPaperId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
}
objCaseExerciseRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CourseExamPaperId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CourseExamPaperId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CourseExamPaperId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCourseId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conCaseExerciseRela.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conCaseExerciseRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCaseExerciseRela.CourseId);
}
objCaseExerciseRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CourseId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CourseId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CourseId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetExamPaperTypeId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, conCaseExerciseRela.ExamPaperTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, conCaseExerciseRela.ExamPaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, conCaseExerciseRela.ExamPaperTypeId);
}
objCaseExerciseRelaEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.ExamPaperTypeId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.ExamPaperTypeId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.ExamPaperTypeId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetBrowseCount(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseExerciseRela.BrowseCount);
objCaseExerciseRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.BrowseCount) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.BrowseCount, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.BrowseCount] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetUpdDate(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseExerciseRela.UpdDate);
}
objCaseExerciseRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.UpdDate) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.UpdDate, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.UpdDate] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetUpdUserId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseExerciseRela.UpdUserId);
}
objCaseExerciseRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.UpdUserId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.UpdUserId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.UpdUserId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCaseExerciseRelaEN SetMemo(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseExerciseRela.Memo);
}
objCaseExerciseRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.Memo) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.Memo, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.Memo] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCaseExerciseRelaEN.CheckPropertyNew();
clsCaseExerciseRelaEN objCaseExerciseRelaCond = new clsCaseExerciseRelaEN();
string strCondition = objCaseExerciseRelaCond
.SetIdCaseExerciseRela(objCaseExerciseRelaEN.IdCaseExerciseRela, "<>")
.SetCaseId(objCaseExerciseRelaEN.CaseId, "=")
.SetCourseExamPaperId(objCaseExerciseRelaEN.CourseExamPaperId, "=")
.GetCombineCondition();
objCaseExerciseRelaEN._IsCheckProperty = true;
bool bolIsExist = clsCaseExerciseRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CaseId_CourseExamPaperId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCaseExerciseRelaEN.Update();
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
 /// <param name = "objCaseExerciseRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCaseExerciseRelaEN objCaseExerciseRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCaseExerciseRelaEN objCaseExerciseRelaCond = new clsCaseExerciseRelaEN();
string strCondition = objCaseExerciseRelaCond
.SetCaseId(objCaseExerciseRela.CaseId, "=")
.SetCourseExamPaperId(objCaseExerciseRela.CourseExamPaperId, "=")
.GetCombineCondition();
objCaseExerciseRela._IsCheckProperty = true;
bool bolIsExist = clsCaseExerciseRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCaseExerciseRela.IdCaseExerciseRela = clsCaseExerciseRelaBL.GetFirstID_S(strCondition);
objCaseExerciseRela.UpdateWithCondition(strCondition);
}
else
{
objCaseExerciseRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 if (objCaseExerciseRelaEN.IdCaseExerciseRela == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseExerciseRelaBL.CaseExerciseRelaDA.UpdateBySql2(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCaseExerciseRelaEN.IdCaseExerciseRela == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCaseExerciseRelaBL.CaseExerciseRelaDA.UpdateBySql2(objCaseExerciseRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsCaseExerciseRelaBL.CaseExerciseRelaDA.UpdateBySqlWithCondition(objCaseExerciseRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCaseExerciseRelaBL.CaseExerciseRelaDA.UpdateBySqlWithConditionTransaction(objCaseExerciseRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
try
{
int intRecNum = clsCaseExerciseRelaBL.CaseExerciseRelaDA.DelRecord(objCaseExerciseRelaEN.IdCaseExerciseRela);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <param name = "objCaseExerciseRelaENT">目标对象</param>
 public static void CopyTo(this clsCaseExerciseRelaEN objCaseExerciseRelaENS, clsCaseExerciseRelaEN objCaseExerciseRelaENT)
{
try
{
objCaseExerciseRelaENT.IdCaseExerciseRela = objCaseExerciseRelaENS.IdCaseExerciseRela; //案例习题关系流水号
objCaseExerciseRelaENT.FuncModuleId = objCaseExerciseRelaENS.FuncModuleId; //功能模块Id
objCaseExerciseRelaENT.CaseId = objCaseExerciseRelaENS.CaseId; //案例Id
objCaseExerciseRelaENT.CaseName = objCaseExerciseRelaENS.CaseName; //案例名称
objCaseExerciseRelaENT.OwnerId = objCaseExerciseRelaENS.OwnerId; //拥有者Id
objCaseExerciseRelaENT.CourseExamPaperId = objCaseExerciseRelaENS.CourseExamPaperId; //考卷流水号
objCaseExerciseRelaENT.CourseId = objCaseExerciseRelaENS.CourseId; //课程Id
objCaseExerciseRelaENT.ExamPaperTypeId = objCaseExerciseRelaENS.ExamPaperTypeId; //试卷类型Id
objCaseExerciseRelaENT.BrowseCount = objCaseExerciseRelaENS.BrowseCount; //浏览次数
objCaseExerciseRelaENT.UpdDate = objCaseExerciseRelaENS.UpdDate; //修改日期
objCaseExerciseRelaENT.UpdUserId = objCaseExerciseRelaENS.UpdUserId; //修改用户Id
objCaseExerciseRelaENT.Memo = objCaseExerciseRelaENS.Memo; //备注
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
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <returns>目标对象=>clsCaseExerciseRelaEN:objCaseExerciseRelaENT</returns>
 public static clsCaseExerciseRelaEN CopyTo(this clsCaseExerciseRelaEN objCaseExerciseRelaENS)
{
try
{
 clsCaseExerciseRelaEN objCaseExerciseRelaENT = new clsCaseExerciseRelaEN()
{
IdCaseExerciseRela = objCaseExerciseRelaENS.IdCaseExerciseRela, //案例习题关系流水号
FuncModuleId = objCaseExerciseRelaENS.FuncModuleId, //功能模块Id
CaseId = objCaseExerciseRelaENS.CaseId, //案例Id
CaseName = objCaseExerciseRelaENS.CaseName, //案例名称
OwnerId = objCaseExerciseRelaENS.OwnerId, //拥有者Id
CourseExamPaperId = objCaseExerciseRelaENS.CourseExamPaperId, //考卷流水号
CourseId = objCaseExerciseRelaENS.CourseId, //课程Id
ExamPaperTypeId = objCaseExerciseRelaENS.ExamPaperTypeId, //试卷类型Id
BrowseCount = objCaseExerciseRelaENS.BrowseCount, //浏览次数
UpdDate = objCaseExerciseRelaENS.UpdDate, //修改日期
UpdUserId = objCaseExerciseRelaENS.UpdUserId, //修改用户Id
Memo = objCaseExerciseRelaENS.Memo, //备注
};
 return objCaseExerciseRelaENT;
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
public static void CheckPropertyNew(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 clsCaseExerciseRelaBL.CaseExerciseRelaDA.CheckPropertyNew(objCaseExerciseRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 clsCaseExerciseRelaBL.CaseExerciseRelaDA.CheckProperty4Condition(objCaseExerciseRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseExerciseRelaEN objCaseExerciseRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.IdCaseExerciseRela) == true)
{
string strComparisonOpIdCaseExerciseRela = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.IdCaseExerciseRela];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseExerciseRela.IdCaseExerciseRela, objCaseExerciseRelaCond.IdCaseExerciseRela, strComparisonOpIdCaseExerciseRela);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.FuncModuleId, objCaseExerciseRelaCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.CaseId) == true)
{
string strComparisonOpCaseId = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CaseId, objCaseExerciseRelaCond.CaseId, strComparisonOpCaseId);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.CaseName) == true)
{
string strComparisonOpCaseName = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CaseName, objCaseExerciseRelaCond.CaseName, strComparisonOpCaseName);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.OwnerId) == true)
{
string strComparisonOpOwnerId = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.OwnerId, objCaseExerciseRelaCond.OwnerId, strComparisonOpOwnerId);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CourseExamPaperId, objCaseExerciseRelaCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.CourseId) == true)
{
string strComparisonOpCourseId = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CourseId, objCaseExerciseRelaCond.CourseId, strComparisonOpCourseId);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.ExamPaperTypeId) == true)
{
string strComparisonOpExamPaperTypeId = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.ExamPaperTypeId, objCaseExerciseRelaCond.ExamPaperTypeId, strComparisonOpExamPaperTypeId);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.BrowseCount) == true)
{
string strComparisonOpBrowseCount = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseExerciseRela.BrowseCount, objCaseExerciseRelaCond.BrowseCount, strComparisonOpBrowseCount);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.UpdDate, objCaseExerciseRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.UpdUserId, objCaseExerciseRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objCaseExerciseRelaCond.IsUpdated(conCaseExerciseRela.Memo) == true)
{
string strComparisonOpMemo = objCaseExerciseRelaCond.dicFldComparisonOp[conCaseExerciseRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.Memo, objCaseExerciseRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CaseExerciseRela(案例习题关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CaseId_CourseExamPaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCaseExerciseRelaEN == null) return true;
if (objCaseExerciseRelaEN.IdCaseExerciseRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseExerciseRelaEN.CaseId);
 if (objCaseExerciseRelaEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objCaseExerciseRelaEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objCaseExerciseRelaEN.CourseExamPaperId);
}
if (clsCaseExerciseRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdCaseExerciseRela !=  {0}", objCaseExerciseRelaEN.IdCaseExerciseRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseExerciseRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objCaseExerciseRelaEN.CourseExamPaperId);
if (clsCaseExerciseRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CaseExerciseRela(案例习题关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CaseId_CourseExamPaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseExerciseRelaEN == null) return "";
if (objCaseExerciseRelaEN.IdCaseExerciseRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseExerciseRelaEN.CaseId);
 if (objCaseExerciseRelaEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objCaseExerciseRelaEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objCaseExerciseRelaEN.CourseExamPaperId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdCaseExerciseRela !=  {0}", objCaseExerciseRelaEN.IdCaseExerciseRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseExerciseRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objCaseExerciseRelaEN.CourseExamPaperId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CaseExerciseRela
{
public virtual bool UpdRelaTabDate(long lngIdCaseExerciseRela, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 案例习题关系(CaseExerciseRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCaseExerciseRelaBL
{
public static RelatedActions_CaseExerciseRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCaseExerciseRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCaseExerciseRelaDA CaseExerciseRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCaseExerciseRelaDA();
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
 public clsCaseExerciseRelaBL()
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
if (string.IsNullOrEmpty(clsCaseExerciseRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseExerciseRelaEN._ConnectString);
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
public static DataTable GetDataTable_CaseExerciseRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CaseExerciseRelaDA.GetDataTable_CaseExerciseRela(strWhereCond);
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
objDT = CaseExerciseRelaDA.GetDataTable(strWhereCond);
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
objDT = CaseExerciseRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CaseExerciseRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CaseExerciseRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CaseExerciseRelaDA.GetDataTable_Top(objTopPara);
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
objDT = CaseExerciseRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CaseExerciseRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CaseExerciseRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdCaseExerciseRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLstByIdCaseExerciseRelaLst(List<long> arrIdCaseExerciseRelaLst)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCaseExerciseRelaLst);
 string strWhereCond = string.Format("IdCaseExerciseRela in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCaseExerciseRelaLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCaseExerciseRelaEN> GetObjLstByIdCaseExerciseRelaLstCache(List<long> arrIdCaseExerciseRelaLst)
{
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName);
List<clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLst_Sel =
arrCaseExerciseRelaObjLstCache
.Where(x => arrIdCaseExerciseRelaLst.Contains(x.IdCaseExerciseRela));
return arrCaseExerciseRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLst(string strWhereCond)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
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
public static List<clsCaseExerciseRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCaseExerciseRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCaseExerciseRelaEN> GetSubObjLstCache(clsCaseExerciseRelaEN objCaseExerciseRelaCond)
{
List<clsCaseExerciseRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseExerciseRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseExerciseRela.AttributeName)
{
if (objCaseExerciseRelaCond.IsUpdated(strFldName) == false) continue;
if (objCaseExerciseRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseExerciseRelaCond[strFldName].ToString());
}
else
{
if (objCaseExerciseRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseExerciseRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseExerciseRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseExerciseRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseExerciseRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseExerciseRelaCond[strFldName]));
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
public static List<clsCaseExerciseRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
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
public static List<clsCaseExerciseRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
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
List<clsCaseExerciseRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCaseExerciseRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCaseExerciseRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
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
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
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
public static List<clsCaseExerciseRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCaseExerciseRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
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
public static List<clsCaseExerciseRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCaseExerciseRelaEN> arrObjLst = new List<clsCaseExerciseRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseExerciseRelaEN objCaseExerciseRelaEN = new clsCaseExerciseRelaEN();
try
{
objCaseExerciseRelaEN.IdCaseExerciseRela = Int32.Parse(objRow[conCaseExerciseRela.IdCaseExerciseRela].ToString().Trim()); //案例习题关系流水号
objCaseExerciseRelaEN.FuncModuleId = objRow[conCaseExerciseRela.FuncModuleId].ToString().Trim(); //功能模块Id
objCaseExerciseRelaEN.CaseId = objRow[conCaseExerciseRela.CaseId].ToString().Trim(); //案例Id
objCaseExerciseRelaEN.CaseName = objRow[conCaseExerciseRela.CaseName].ToString().Trim(); //案例名称
objCaseExerciseRelaEN.OwnerId = objRow[conCaseExerciseRela.OwnerId] == DBNull.Value ? null : objRow[conCaseExerciseRela.OwnerId].ToString().Trim(); //拥有者Id
objCaseExerciseRelaEN.CourseExamPaperId = objRow[conCaseExerciseRela.CourseExamPaperId] == DBNull.Value ? null : objRow[conCaseExerciseRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objCaseExerciseRelaEN.CourseId = objRow[conCaseExerciseRela.CourseId].ToString().Trim(); //课程Id
objCaseExerciseRelaEN.ExamPaperTypeId = objRow[conCaseExerciseRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objCaseExerciseRelaEN.BrowseCount = Int32.Parse(objRow[conCaseExerciseRela.BrowseCount].ToString().Trim()); //浏览次数
objCaseExerciseRelaEN.UpdDate = objRow[conCaseExerciseRela.UpdDate] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdDate].ToString().Trim(); //修改日期
objCaseExerciseRelaEN.UpdUserId = objRow[conCaseExerciseRela.UpdUserId] == DBNull.Value ? null : objRow[conCaseExerciseRela.UpdUserId].ToString().Trim(); //修改用户Id
objCaseExerciseRelaEN.Memo = objRow[conCaseExerciseRela.Memo] == DBNull.Value ? null : objRow[conCaseExerciseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCaseExerciseRelaEN.IdCaseExerciseRela, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCaseExerciseRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCaseExerciseRela(ref clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
bool bolResult = CaseExerciseRelaDA.GetCaseExerciseRela(ref objCaseExerciseRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseExerciseRelaEN GetObjByIdCaseExerciseRela(long lngIdCaseExerciseRela)
{
clsCaseExerciseRelaEN objCaseExerciseRelaEN = CaseExerciseRelaDA.GetObjByIdCaseExerciseRela(lngIdCaseExerciseRela);
return objCaseExerciseRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCaseExerciseRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCaseExerciseRelaEN objCaseExerciseRelaEN = CaseExerciseRelaDA.GetFirstObj(strWhereCond);
 return objCaseExerciseRelaEN;
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
public static clsCaseExerciseRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCaseExerciseRelaEN objCaseExerciseRelaEN = CaseExerciseRelaDA.GetObjByDataRow(objRow);
 return objCaseExerciseRelaEN;
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
public static clsCaseExerciseRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCaseExerciseRelaEN objCaseExerciseRelaEN = CaseExerciseRelaDA.GetObjByDataRow(objRow);
 return objCaseExerciseRelaEN;
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
 /// <param name = "lngIdCaseExerciseRela">所给的关键字</param>
 /// <param name = "lstCaseExerciseRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseExerciseRelaEN GetObjByIdCaseExerciseRelaFromList(long lngIdCaseExerciseRela, List<clsCaseExerciseRelaEN> lstCaseExerciseRelaObjLst)
{
foreach (clsCaseExerciseRelaEN objCaseExerciseRelaEN in lstCaseExerciseRelaObjLst)
{
if (objCaseExerciseRelaEN.IdCaseExerciseRela == lngIdCaseExerciseRela)
{
return objCaseExerciseRelaEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngIdCaseExerciseRela;
 try
 {
 lngIdCaseExerciseRela = new clsCaseExerciseRelaDA().GetFirstID(strWhereCond);
 return lngIdCaseExerciseRela;
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
 arrList = CaseExerciseRelaDA.GetID(strWhereCond);
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
bool bolIsExist = CaseExerciseRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdCaseExerciseRela)
{
//检测记录是否存在
bool bolIsExist = CaseExerciseRelaDA.IsExist(lngIdCaseExerciseRela);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdCaseExerciseRela">案例习题关系流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdCaseExerciseRela, string strOpUser)
{
clsCaseExerciseRelaEN objCaseExerciseRelaEN = clsCaseExerciseRelaBL.GetObjByIdCaseExerciseRela(lngIdCaseExerciseRela);
objCaseExerciseRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objCaseExerciseRelaEN.UpdUserId = strOpUser;
return clsCaseExerciseRelaBL.UpdateBySql2(objCaseExerciseRelaEN);
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
 bolIsExist = clsCaseExerciseRelaDA.IsExistTable();
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
 bolIsExist = CaseExerciseRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCaseExerciseRelaEN objCaseExerciseRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCaseExerciseRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],考卷流水号 = [{1}]的数据已经存在!(in clsCaseExerciseRelaBL.AddNewRecordBySql2)", objCaseExerciseRelaEN.CaseId,objCaseExerciseRelaEN.CourseExamPaperId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CaseExerciseRelaDA.AddNewRecordBySQL2(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCaseExerciseRelaEN objCaseExerciseRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCaseExerciseRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!案例Id = [{0}],考卷流水号 = [{1}]的数据已经存在!(in clsCaseExerciseRelaBL.AddNewRecordBySql2WithReturnKey)", objCaseExerciseRelaEN.CaseId,objCaseExerciseRelaEN.CourseExamPaperId);
throw new Exception(strMsg);
}
try
{
string strKey = CaseExerciseRelaDA.AddNewRecordBySQL2WithReturnKey(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
try
{
bool bolResult = CaseExerciseRelaDA.Update(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 if (objCaseExerciseRelaEN.IdCaseExerciseRela == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CaseExerciseRelaDA.UpdateBySql2(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaBL.ReFreshCache();

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
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
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdCaseExerciseRela)
{
try
{
 clsCaseExerciseRelaEN objCaseExerciseRelaEN = clsCaseExerciseRelaBL.GetObjByIdCaseExerciseRela(lngIdCaseExerciseRela);

if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(objCaseExerciseRelaEN.IdCaseExerciseRela, objCaseExerciseRelaEN.UpdUserId);
}
if (objCaseExerciseRelaEN != null)
{
int intRecNum = CaseExerciseRelaDA.DelRecord(lngIdCaseExerciseRela);
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
/// <param name="lngIdCaseExerciseRela">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdCaseExerciseRela )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
//删除与表:[CaseExerciseRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCaseExerciseRela.IdCaseExerciseRela,
//lngIdCaseExerciseRela);
//        clsCaseExerciseRelaBL.DelCaseExerciseRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseExerciseRelaBL.DelRecord(lngIdCaseExerciseRela, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseExerciseRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseExerciseRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdCaseExerciseRela">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdCaseExerciseRela, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsCaseExerciseRelaBL.relatedActions != null)
{
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseExerciseRela, "UpdRelaTabDate");
}
bool bolResult = CaseExerciseRelaDA.DelRecord(lngIdCaseExerciseRela,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdCaseExerciseRelaLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelCaseExerciseRelas(List<string> arrIdCaseExerciseRelaLst)
{
if (arrIdCaseExerciseRelaLst.Count == 0) return 0;
try
{
if (clsCaseExerciseRelaBL.relatedActions != null)
{
foreach (var strIdCaseExerciseRela in arrIdCaseExerciseRelaLst)
{
long lngIdCaseExerciseRela = long.Parse(strIdCaseExerciseRela);
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseExerciseRela, "UpdRelaTabDate");
}
}
int intDelRecNum = CaseExerciseRelaDA.DelCaseExerciseRela(arrIdCaseExerciseRelaLst);
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
public static int DelCaseExerciseRelasByCond(string strWhereCond)
{
try
{
if (clsCaseExerciseRelaBL.relatedActions != null)
{
List<string> arrIdCaseExerciseRela = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdCaseExerciseRela in arrIdCaseExerciseRela)
{
long lngIdCaseExerciseRela = long.Parse(strIdCaseExerciseRela);
clsCaseExerciseRelaBL.relatedActions.UpdRelaTabDate(lngIdCaseExerciseRela, "UpdRelaTabDate");
}
}
int intRecNum = CaseExerciseRelaDA.DelCaseExerciseRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CaseExerciseRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdCaseExerciseRela">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdCaseExerciseRela)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCaseExerciseRelaDA.GetSpecSQLObj();
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
//删除与表:[CaseExerciseRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCaseExerciseRelaBL.DelRecord(lngIdCaseExerciseRela, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCaseExerciseRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdCaseExerciseRela, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <param name = "objCaseExerciseRelaENT">目标对象</param>
 public static void CopyTo(clsCaseExerciseRelaEN objCaseExerciseRelaENS, clsCaseExerciseRelaEN objCaseExerciseRelaENT)
{
try
{
objCaseExerciseRelaENT.IdCaseExerciseRela = objCaseExerciseRelaENS.IdCaseExerciseRela; //案例习题关系流水号
objCaseExerciseRelaENT.FuncModuleId = objCaseExerciseRelaENS.FuncModuleId; //功能模块Id
objCaseExerciseRelaENT.CaseId = objCaseExerciseRelaENS.CaseId; //案例Id
objCaseExerciseRelaENT.CaseName = objCaseExerciseRelaENS.CaseName; //案例名称
objCaseExerciseRelaENT.OwnerId = objCaseExerciseRelaENS.OwnerId; //拥有者Id
objCaseExerciseRelaENT.CourseExamPaperId = objCaseExerciseRelaENS.CourseExamPaperId; //考卷流水号
objCaseExerciseRelaENT.CourseId = objCaseExerciseRelaENS.CourseId; //课程Id
objCaseExerciseRelaENT.ExamPaperTypeId = objCaseExerciseRelaENS.ExamPaperTypeId; //试卷类型Id
objCaseExerciseRelaENT.BrowseCount = objCaseExerciseRelaENS.BrowseCount; //浏览次数
objCaseExerciseRelaENT.UpdDate = objCaseExerciseRelaENS.UpdDate; //修改日期
objCaseExerciseRelaENT.UpdUserId = objCaseExerciseRelaENS.UpdUserId; //修改用户Id
objCaseExerciseRelaENT.Memo = objCaseExerciseRelaENS.Memo; //备注
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
 /// <param name = "objCaseExerciseRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
try
{
objCaseExerciseRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCaseExerciseRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCaseExerciseRela.IdCaseExerciseRela, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.IdCaseExerciseRela = objCaseExerciseRelaEN.IdCaseExerciseRela; //案例习题关系流水号
}
if (arrFldSet.Contains(conCaseExerciseRela.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.FuncModuleId = objCaseExerciseRelaEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conCaseExerciseRela.CaseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.CaseId = objCaseExerciseRelaEN.CaseId; //案例Id
}
if (arrFldSet.Contains(conCaseExerciseRela.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.CaseName = objCaseExerciseRelaEN.CaseName; //案例名称
}
if (arrFldSet.Contains(conCaseExerciseRela.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.OwnerId = objCaseExerciseRelaEN.OwnerId == "[null]" ? null :  objCaseExerciseRelaEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(conCaseExerciseRela.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.CourseExamPaperId = objCaseExerciseRelaEN.CourseExamPaperId == "[null]" ? null :  objCaseExerciseRelaEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(conCaseExerciseRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.CourseId = objCaseExerciseRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conCaseExerciseRela.ExamPaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.ExamPaperTypeId = objCaseExerciseRelaEN.ExamPaperTypeId; //试卷类型Id
}
if (arrFldSet.Contains(conCaseExerciseRela.BrowseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.BrowseCount = objCaseExerciseRelaEN.BrowseCount; //浏览次数
}
if (arrFldSet.Contains(conCaseExerciseRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.UpdDate = objCaseExerciseRelaEN.UpdDate == "[null]" ? null :  objCaseExerciseRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCaseExerciseRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.UpdUserId = objCaseExerciseRelaEN.UpdUserId == "[null]" ? null :  objCaseExerciseRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conCaseExerciseRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCaseExerciseRelaEN.Memo = objCaseExerciseRelaEN.Memo == "[null]" ? null :  objCaseExerciseRelaEN.Memo; //备注
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
 /// <param name = "objCaseExerciseRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
try
{
if (objCaseExerciseRelaEN.OwnerId == "[null]") objCaseExerciseRelaEN.OwnerId = null; //拥有者Id
if (objCaseExerciseRelaEN.CourseExamPaperId == "[null]") objCaseExerciseRelaEN.CourseExamPaperId = null; //考卷流水号
if (objCaseExerciseRelaEN.UpdDate == "[null]") objCaseExerciseRelaEN.UpdDate = null; //修改日期
if (objCaseExerciseRelaEN.UpdUserId == "[null]") objCaseExerciseRelaEN.UpdUserId = null; //修改用户Id
if (objCaseExerciseRelaEN.Memo == "[null]") objCaseExerciseRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 CaseExerciseRelaDA.CheckPropertyNew(objCaseExerciseRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 CaseExerciseRelaDA.CheckProperty4Condition(objCaseExerciseRelaEN);
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
if (clsCaseExerciseRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseExerciseRelaBL没有刷新缓存机制(clsCaseExerciseRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCaseExerciseRela");
//if (arrCaseExerciseRelaObjLstCache == null)
//{
//arrCaseExerciseRelaObjLstCache = CaseExerciseRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdCaseExerciseRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseExerciseRelaEN GetObjByIdCaseExerciseRelaCache(long lngIdCaseExerciseRela)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName);
List<clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLst_Sel =
arrCaseExerciseRelaObjLstCache
.Where(x=> x.IdCaseExerciseRela == lngIdCaseExerciseRela 
);
if (arrCaseExerciseRelaObjLst_Sel.Count() == 0)
{
   clsCaseExerciseRelaEN obj = clsCaseExerciseRelaBL.GetObjByIdCaseExerciseRela(lngIdCaseExerciseRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCaseExerciseRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetAllCaseExerciseRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLstCache = GetObjLstCache(); 
return arrCaseExerciseRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName);
List<clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseExerciseRelaObjLstCache;
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
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseExerciseRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCaseExerciseRelaEN._RefreshTimeLst.Count == 0) return "";
return clsCaseExerciseRelaEN._RefreshTimeLst[clsCaseExerciseRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCaseExerciseRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCaseExerciseRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCaseExerciseRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CaseExerciseRela(案例习题关系)
 /// 唯一性条件:CaseId_CourseExamPaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//检测记录是否存在
string strResult = CaseExerciseRelaDA.GetUniCondStr(objCaseExerciseRelaEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngIdCaseExerciseRela)
{
if (strInFldName != conCaseExerciseRela.IdCaseExerciseRela)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCaseExerciseRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCaseExerciseRela.AttributeName));
throw new Exception(strMsg);
}
var objCaseExerciseRela = clsCaseExerciseRelaBL.GetObjByIdCaseExerciseRelaCache(lngIdCaseExerciseRela);
if (objCaseExerciseRela == null) return "";
return objCaseExerciseRela[strOutFldName].ToString();
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
int intRecCount = clsCaseExerciseRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsCaseExerciseRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCaseExerciseRelaDA.GetRecCount();
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
int intRecCount = clsCaseExerciseRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCaseExerciseRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCaseExerciseRelaEN objCaseExerciseRelaCond)
{
List<clsCaseExerciseRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCaseExerciseRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCaseExerciseRela.AttributeName)
{
if (objCaseExerciseRelaCond.IsUpdated(strFldName) == false) continue;
if (objCaseExerciseRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseExerciseRelaCond[strFldName].ToString());
}
else
{
if (objCaseExerciseRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCaseExerciseRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCaseExerciseRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCaseExerciseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCaseExerciseRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCaseExerciseRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCaseExerciseRelaCond[strFldName]));
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
 List<string> arrList = clsCaseExerciseRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CaseExerciseRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CaseExerciseRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CaseExerciseRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseExerciseRelaDA.SetFldValue(clsCaseExerciseRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CaseExerciseRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseExerciseRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCaseExerciseRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCaseExerciseRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CaseExerciseRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**案例习题关系流水号*/ 
 strCreateTabCode.Append(" IdCaseExerciseRela bigint primary key identity, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) not Null, "); 
 // /**案例Id*/ 
 strCreateTabCode.Append(" CaseId char(8) not Null, "); 
 // /**案例名称*/ 
 strCreateTabCode.Append(" CaseName varchar(100) not Null, "); 
 // /**拥有者Id*/ 
 strCreateTabCode.Append(" OwnerId varchar(20) Null, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**试卷类型Id*/ 
 strCreateTabCode.Append(" ExamPaperTypeId char(2) not Null, "); 
 // /**浏览次数*/ 
 strCreateTabCode.Append(" BrowseCount int not Null, "); 
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
 /// 案例习题关系(CaseExerciseRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CaseExerciseRela : clsCommFun4BL
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
clsCaseExerciseRelaBL.ReFreshThisCache();
}
}

}