
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserAnswerResultBL
 表名:UserAnswerResult(01120032)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果(QuestionnaireResult)
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
public static class  clsUserAnswerResultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngMinId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserAnswerResultEN GetObj(this K_MinId_UserAnswerResult myKey)
{
clsUserAnswerResultEN objUserAnswerResultEN = clsUserAnswerResultBL.UserAnswerResultDA.GetObjByMinId(myKey.Value);
return objUserAnswerResultEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserAnswerResultEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],题目Id = [{1}],用户ID = [{2}],学生批次号 = [{3}]的数据已经存在!(in clsUserAnswerResultBL.AddNewRecord)", objUserAnswerResultEN.CourseExamPaperId,objUserAnswerResultEN.QuestionId,objUserAnswerResultEN.UserId,objUserAnswerResultEN.ExamBatchNo);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsUserAnswerResultBL.UserAnswerResultDA.AddNewRecordBySQL2(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
public static bool AddRecordEx(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsNeedCheckUniqueness = true)
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
objUserAnswerResultEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objUserAnswerResultEN.CheckUniqueness() == false)
{
strMsg = string.Format("(考卷流水号(CourseExamPaperId)=[{0}],题目Id(QuestionId)=[{1}],用户ID(UserId)=[{2}],学生批次号(ExamBatchNo)=[{3}])已经存在,不能重复!", objUserAnswerResultEN.CourseExamPaperId, objUserAnswerResultEN.QuestionId, objUserAnswerResultEN.UserId, objUserAnswerResultEN.ExamBatchNo);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objUserAnswerResultEN.AddNewRecord();
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objUserAnswerResultEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],题目Id = [{1}],用户ID = [{2}],学生批次号 = [{3}]的数据已经存在!(in clsUserAnswerResultBL.AddNewRecordWithReturnKey)", objUserAnswerResultEN.CourseExamPaperId,objUserAnswerResultEN.QuestionId,objUserAnswerResultEN.UserId,objUserAnswerResultEN.ExamBatchNo);
throw new Exception(strMsg);
}
try
{
string strKey = clsUserAnswerResultBL.UserAnswerResultDA.AddNewRecordBySQL2WithReturnKey(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetMinId(this clsUserAnswerResultEN objUserAnswerResultEN, long lngMinId, string strComparisonOp="")
	{
objUserAnswerResultEN.MinId = lngMinId; //MinId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.MinId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.MinId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.MinId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetQuestionId(this clsUserAnswerResultEN objUserAnswerResultEN, long? lngQuestionId, string strComparisonOp="")
	{
objUserAnswerResultEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.QuestionId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.QuestionId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.QuestionId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetCourseId(this clsUserAnswerResultEN objUserAnswerResultEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conUserAnswerResult.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conUserAnswerResult.CourseId);
}
objUserAnswerResultEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.CourseId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.CourseId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.CourseId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetIdCurrEduCls(this clsUserAnswerResultEN objUserAnswerResultEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conUserAnswerResult.IdCurrEduCls);
}
objUserAnswerResultEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IdCurrEduCls) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IdCurrEduCls, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IdCurrEduCls] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetExamBatchNo(this clsUserAnswerResultEN objUserAnswerResultEN, string strExamBatchNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExamBatchNo, 20, conUserAnswerResult.ExamBatchNo);
}
objUserAnswerResultEN.ExamBatchNo = strExamBatchNo; //学生批次号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.ExamBatchNo) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.ExamBatchNo, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.ExamBatchNo] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetCourseExamPaperId(this clsUserAnswerResultEN objUserAnswerResultEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, conUserAnswerResult.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, conUserAnswerResult.CourseExamPaperId);
}
objUserAnswerResultEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.CourseExamPaperId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.CourseExamPaperId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.CourseExamPaperId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerOptionId(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, conUserAnswerResult.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, conUserAnswerResult.AnswerOptionId);
}
objUserAnswerResultEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerOptionId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerOptionId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerOptionId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetBatchId(this clsUserAnswerResultEN objUserAnswerResultEN, string strBatchId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchId, 4, conUserAnswerResult.BatchId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, conUserAnswerResult.BatchId);
}
objUserAnswerResultEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.BatchId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.BatchId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.BatchId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetUserId(this clsUserAnswerResultEN objUserAnswerResultEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conUserAnswerResult.UserId);
}
objUserAnswerResultEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.UserId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.UserId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.UserId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerText(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerText, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerText, 8000, conUserAnswerResult.AnswerText);
}
objUserAnswerResultEN.AnswerText = strAnswerText; //回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerText) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerText, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerText] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerDate(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, conUserAnswerResult.AnswerDate);
}
objUserAnswerResultEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerDate) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerDate, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerDate] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerTime(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, conUserAnswerResult.AnswerTime);
}
objUserAnswerResultEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerTime) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerTime, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerTime] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerIP(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, conUserAnswerResult.AnswerIP);
}
objUserAnswerResultEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerIP) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerIP, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerIP] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetIsAccess(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsAccess, string strComparisonOp="")
	{
objUserAnswerResultEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsAccess) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsAccess, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsAccess] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetIsAccessC(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsAccessC, string strComparisonOp="")
	{
objUserAnswerResultEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsAccessC) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsAccessC, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsAccessC] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetIdSchool(this clsUserAnswerResultEN objUserAnswerResultEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conUserAnswerResult.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conUserAnswerResult.IdSchool);
}
objUserAnswerResultEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IdSchool) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IdSchool, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IdSchool] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetSchool(this clsUserAnswerResultEN objUserAnswerResultEN, string strSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchool, 50, conUserAnswerResult.School);
}
objUserAnswerResultEN.School = strSchool; //School
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.School) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.School, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.School] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerMode(this clsUserAnswerResultEN objUserAnswerResultEN, int? intAnswerMode, string strComparisonOp="")
	{
objUserAnswerResultEN.AnswerMode = intAnswerMode; //AnswerMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerMode) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerMode, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerMode] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetIsMarking(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsMarking, string strComparisonOp="")
	{
objUserAnswerResultEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsMarking) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsMarking, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsMarking] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetIsRight(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsRight, string strComparisonOp="")
	{
objUserAnswerResultEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsRight) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsRight, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsRight] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetScore(this clsUserAnswerResultEN objUserAnswerResultEN, double? dblScore, string strComparisonOp="")
	{
objUserAnswerResultEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.Score) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.Score, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.Score] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetMarkTime(this clsUserAnswerResultEN objUserAnswerResultEN, string strMarkTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkTime, 14, conUserAnswerResult.MarkTime);
}
objUserAnswerResultEN.MarkTime = strMarkTime; //批改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.MarkTime) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.MarkTime, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.MarkTime] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetMarkerId(this clsUserAnswerResultEN objUserAnswerResultEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, conUserAnswerResult.MarkerId);
}
objUserAnswerResultEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.MarkerId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.MarkerId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.MarkerId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetComment(this clsUserAnswerResultEN objUserAnswerResultEN, string strComment, string strComparisonOp="")
	{
objUserAnswerResultEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.Comment) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.Comment, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.Comment] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetIsAccessKnowledge(this clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objUserAnswerResultEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.IsAccessKnowledge) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.IsAccessKnowledge, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.IsAccessKnowledge] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerId(this clsUserAnswerResultEN objUserAnswerResultEN, long? lngAnswerId, string strComparisonOp="")
	{
objUserAnswerResultEN.AnswerId = lngAnswerId; //问答ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetAnswerMultiOption(this clsUserAnswerResultEN objUserAnswerResultEN, string strAnswerMultiOption, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOption, 300, conUserAnswerResult.AnswerMultiOption);
}
objUserAnswerResultEN.AnswerMultiOption = strAnswerMultiOption; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.AnswerMultiOption) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.AnswerMultiOption, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.AnswerMultiOption] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetUpdDate(this clsUserAnswerResultEN objUserAnswerResultEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conUserAnswerResult.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conUserAnswerResult.UpdDate);
}
objUserAnswerResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.UpdDate) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.UpdDate, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.UpdDate] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetUpdUser(this clsUserAnswerResultEN objUserAnswerResultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conUserAnswerResult.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conUserAnswerResult.UpdUser);
}
objUserAnswerResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.UpdUser) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.UpdUser, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.UpdUser] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetMemo(this clsUserAnswerResultEN objUserAnswerResultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conUserAnswerResult.Memo);
}
objUserAnswerResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.Memo) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.Memo, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.Memo] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsUserAnswerResultEN SetQuestionnaireSetId(this clsUserAnswerResultEN objUserAnswerResultEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conUserAnswerResult.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conUserAnswerResult.QuestionnaireSetId);
}
objUserAnswerResultEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objUserAnswerResultEN.dicFldComparisonOp.ContainsKey(conUserAnswerResult.QuestionnaireSetId) == false)
{
objUserAnswerResultEN.dicFldComparisonOp.Add(conUserAnswerResult.QuestionnaireSetId, strComparisonOp);
}
else
{
objUserAnswerResultEN.dicFldComparisonOp[conUserAnswerResult.QuestionnaireSetId] = strComparisonOp;
}
}
return objUserAnswerResultEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsUserAnswerResultEN objUserAnswerResultEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objUserAnswerResultEN.CheckPropertyNew();
clsUserAnswerResultEN objUserAnswerResultCond = new clsUserAnswerResultEN();
string strCondition = objUserAnswerResultCond
.SetMinId(objUserAnswerResultEN.MinId, "<>")
.SetCourseExamPaperId(objUserAnswerResultEN.CourseExamPaperId, "=")
.SetQuestionId(objUserAnswerResultEN.QuestionId, "=")
.SetUserId(objUserAnswerResultEN.UserId, "=")
.SetExamBatchNo(objUserAnswerResultEN.ExamBatchNo, "=")
.GetCombineCondition();
objUserAnswerResultEN._IsCheckProperty = true;
bool bolIsExist = clsUserAnswerResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionID_UserId_CourseExamPaperId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objUserAnswerResultEN.Update();
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
 /// <param name = "objUserAnswerResult">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsUserAnswerResultEN objUserAnswerResult)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsUserAnswerResultEN objUserAnswerResultCond = new clsUserAnswerResultEN();
string strCondition = objUserAnswerResultCond
.SetCourseExamPaperId(objUserAnswerResult.CourseExamPaperId, "=")
.SetQuestionId(objUserAnswerResult.QuestionId, "=")
.SetUserId(objUserAnswerResult.UserId, "=")
.SetExamBatchNo(objUserAnswerResult.ExamBatchNo, "=")
.GetCombineCondition();
objUserAnswerResult._IsCheckProperty = true;
bool bolIsExist = clsUserAnswerResultBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objUserAnswerResult.MinId = clsUserAnswerResultBL.GetFirstID_S(strCondition);
objUserAnswerResult.UpdateWithCondition(strCondition);
}
else
{
objUserAnswerResult.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserAnswerResultEN objUserAnswerResultEN)
{
 if (objUserAnswerResultEN.MinId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserAnswerResultBL.UserAnswerResultDA.UpdateBySql2(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsUserAnswerResultEN objUserAnswerResultEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserAnswerResultEN.MinId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsUserAnswerResultBL.UserAnswerResultDA.UpdateBySql2(objUserAnswerResultEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserAnswerResultEN objUserAnswerResultEN, string strWhereCond)
{
try
{
bool bolResult = clsUserAnswerResultBL.UserAnswerResultDA.UpdateBySqlWithCondition(objUserAnswerResultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsUserAnswerResultEN objUserAnswerResultEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsUserAnswerResultBL.UserAnswerResultDA.UpdateBySqlWithConditionTransaction(objUserAnswerResultEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsUserAnswerResultEN objUserAnswerResultEN)
{
try
{
int intRecNum = clsUserAnswerResultBL.UserAnswerResultDA.DelRecord(objUserAnswerResultEN.MinId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultENS">源对象</param>
 /// <param name = "objUserAnswerResultENT">目标对象</param>
 public static void CopyTo(this clsUserAnswerResultEN objUserAnswerResultENS, clsUserAnswerResultEN objUserAnswerResultENT)
{
try
{
objUserAnswerResultENT.MinId = objUserAnswerResultENS.MinId; //MinId
objUserAnswerResultENT.QuestionId = objUserAnswerResultENS.QuestionId; //题目Id
objUserAnswerResultENT.CourseId = objUserAnswerResultENS.CourseId; //课程Id
objUserAnswerResultENT.IdCurrEduCls = objUserAnswerResultENS.IdCurrEduCls; //教学班流水号
objUserAnswerResultENT.ExamBatchNo = objUserAnswerResultENS.ExamBatchNo; //学生批次号
objUserAnswerResultENT.CourseExamPaperId = objUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objUserAnswerResultENT.AnswerOptionId = objUserAnswerResultENS.AnswerOptionId; //回答选项Id
objUserAnswerResultENT.BatchId = objUserAnswerResultENS.BatchId; //批次ID
objUserAnswerResultENT.UserId = objUserAnswerResultENS.UserId; //用户ID
objUserAnswerResultENT.AnswerText = objUserAnswerResultENS.AnswerText; //回答文本
objUserAnswerResultENT.AnswerDate = objUserAnswerResultENS.AnswerDate; //回答日期
objUserAnswerResultENT.AnswerTime = objUserAnswerResultENS.AnswerTime; //回答时间
objUserAnswerResultENT.AnswerIP = objUserAnswerResultENS.AnswerIP; //回答IP
objUserAnswerResultENT.IsAccess = objUserAnswerResultENS.IsAccess; //IsAccess
objUserAnswerResultENT.IsAccessC = objUserAnswerResultENS.IsAccessC; //IsAccessC
objUserAnswerResultENT.IdSchool = objUserAnswerResultENS.IdSchool; //学校流水号
objUserAnswerResultENT.School = objUserAnswerResultENS.School; //School
objUserAnswerResultENT.AnswerMode = objUserAnswerResultENS.AnswerMode; //AnswerMode
objUserAnswerResultENT.IsMarking = objUserAnswerResultENS.IsMarking; //是否批阅
objUserAnswerResultENT.IsRight = objUserAnswerResultENS.IsRight; //是否正确
objUserAnswerResultENT.Score = objUserAnswerResultENS.Score; //得分
objUserAnswerResultENT.MarkTime = objUserAnswerResultENS.MarkTime; //批改时间
objUserAnswerResultENT.MarkerId = objUserAnswerResultENS.MarkerId; //打分者
objUserAnswerResultENT.Comment = objUserAnswerResultENS.Comment; //批注
objUserAnswerResultENT.IsAccessKnowledge = objUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objUserAnswerResultENT.AnswerId = objUserAnswerResultENS.AnswerId; //问答ID
objUserAnswerResultENT.AnswerMultiOption = objUserAnswerResultENS.AnswerMultiOption; //多选项答案
objUserAnswerResultENT.UpdDate = objUserAnswerResultENS.UpdDate; //修改日期
objUserAnswerResultENT.UpdUser = objUserAnswerResultENS.UpdUser; //修改人
objUserAnswerResultENT.Memo = objUserAnswerResultENS.Memo; //备注
objUserAnswerResultENT.QuestionnaireSetId = objUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
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
 /// <param name = "objUserAnswerResultENS">源对象</param>
 /// <returns>目标对象=>clsUserAnswerResultEN:objUserAnswerResultENT</returns>
 public static clsUserAnswerResultEN CopyTo(this clsUserAnswerResultEN objUserAnswerResultENS)
{
try
{
 clsUserAnswerResultEN objUserAnswerResultENT = new clsUserAnswerResultEN()
{
MinId = objUserAnswerResultENS.MinId, //MinId
QuestionId = objUserAnswerResultENS.QuestionId, //题目Id
CourseId = objUserAnswerResultENS.CourseId, //课程Id
IdCurrEduCls = objUserAnswerResultENS.IdCurrEduCls, //教学班流水号
ExamBatchNo = objUserAnswerResultENS.ExamBatchNo, //学生批次号
CourseExamPaperId = objUserAnswerResultENS.CourseExamPaperId, //考卷流水号
AnswerOptionId = objUserAnswerResultENS.AnswerOptionId, //回答选项Id
BatchId = objUserAnswerResultENS.BatchId, //批次ID
UserId = objUserAnswerResultENS.UserId, //用户ID
AnswerText = objUserAnswerResultENS.AnswerText, //回答文本
AnswerDate = objUserAnswerResultENS.AnswerDate, //回答日期
AnswerTime = objUserAnswerResultENS.AnswerTime, //回答时间
AnswerIP = objUserAnswerResultENS.AnswerIP, //回答IP
IsAccess = objUserAnswerResultENS.IsAccess, //IsAccess
IsAccessC = objUserAnswerResultENS.IsAccessC, //IsAccessC
IdSchool = objUserAnswerResultENS.IdSchool, //学校流水号
School = objUserAnswerResultENS.School, //School
AnswerMode = objUserAnswerResultENS.AnswerMode, //AnswerMode
IsMarking = objUserAnswerResultENS.IsMarking, //是否批阅
IsRight = objUserAnswerResultENS.IsRight, //是否正确
Score = objUserAnswerResultENS.Score, //得分
MarkTime = objUserAnswerResultENS.MarkTime, //批改时间
MarkerId = objUserAnswerResultENS.MarkerId, //打分者
Comment = objUserAnswerResultENS.Comment, //批注
IsAccessKnowledge = objUserAnswerResultENS.IsAccessKnowledge, //是否处理知识点
AnswerId = objUserAnswerResultENS.AnswerId, //问答ID
AnswerMultiOption = objUserAnswerResultENS.AnswerMultiOption, //多选项答案
UpdDate = objUserAnswerResultENS.UpdDate, //修改日期
UpdUser = objUserAnswerResultENS.UpdUser, //修改人
Memo = objUserAnswerResultENS.Memo, //备注
QuestionnaireSetId = objUserAnswerResultENS.QuestionnaireSetId, //问卷集ID
};
 return objUserAnswerResultENT;
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
public static void CheckPropertyNew(this clsUserAnswerResultEN objUserAnswerResultEN)
{
 clsUserAnswerResultBL.UserAnswerResultDA.CheckPropertyNew(objUserAnswerResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsUserAnswerResultEN objUserAnswerResultEN)
{
 clsUserAnswerResultBL.UserAnswerResultDA.CheckProperty4Condition(objUserAnswerResultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsUserAnswerResultEN objUserAnswerResultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.MinId) == true)
{
string strComparisonOpMinId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.MinId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.MinId, objUserAnswerResultCond.MinId, strComparisonOpMinId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.QuestionId) == true)
{
string strComparisonOpQuestionId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.QuestionId, objUserAnswerResultCond.QuestionId, strComparisonOpQuestionId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.CourseId) == true)
{
string strComparisonOpCourseId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.CourseId, objUserAnswerResultCond.CourseId, strComparisonOpCourseId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.IdCurrEduCls, objUserAnswerResultCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.ExamBatchNo) == true)
{
string strComparisonOpExamBatchNo = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.ExamBatchNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.ExamBatchNo, objUserAnswerResultCond.ExamBatchNo, strComparisonOpExamBatchNo);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.CourseExamPaperId, objUserAnswerResultCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerOptionId, objUserAnswerResultCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.BatchId) == true)
{
string strComparisonOpBatchId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.BatchId, objUserAnswerResultCond.BatchId, strComparisonOpBatchId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.UserId) == true)
{
string strComparisonOpUserId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.UserId, objUserAnswerResultCond.UserId, strComparisonOpUserId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerText) == true)
{
string strComparisonOpAnswerText = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerText, objUserAnswerResultCond.AnswerText, strComparisonOpAnswerText);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerDate, objUserAnswerResultCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerTime, objUserAnswerResultCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerIP, objUserAnswerResultCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.IsAccess) == true)
{
if (objUserAnswerResultCond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsAccess);
}
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.IsAccessC) == true)
{
if (objUserAnswerResultCond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsAccessC);
}
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.IdSchool) == true)
{
string strComparisonOpIdSchool = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.IdSchool, objUserAnswerResultCond.IdSchool, strComparisonOpIdSchool);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.School) == true)
{
string strComparisonOpSchool = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.School];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.School, objUserAnswerResultCond.School, strComparisonOpSchool);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerMode) == true)
{
string strComparisonOpAnswerMode = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerMode];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.AnswerMode, objUserAnswerResultCond.AnswerMode, strComparisonOpAnswerMode);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.IsMarking) == true)
{
if (objUserAnswerResultCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsMarking);
}
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.IsRight) == true)
{
if (objUserAnswerResultCond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsRight);
}
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.Score) == true)
{
string strComparisonOpScore = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.Score, objUserAnswerResultCond.Score, strComparisonOpScore);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.MarkTime) == true)
{
string strComparisonOpMarkTime = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.MarkTime, objUserAnswerResultCond.MarkTime, strComparisonOpMarkTime);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.MarkerId) == true)
{
string strComparisonOpMarkerId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.MarkerId, objUserAnswerResultCond.MarkerId, strComparisonOpMarkerId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.IsAccessKnowledge) == true)
{
if (objUserAnswerResultCond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", conUserAnswerResult.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conUserAnswerResult.IsAccessKnowledge);
}
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerId) == true)
{
string strComparisonOpAnswerId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerId];
strWhereCond += string.Format(" And {0} {2} {1}", conUserAnswerResult.AnswerId, objUserAnswerResultCond.AnswerId, strComparisonOpAnswerId);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.AnswerMultiOption) == true)
{
string strComparisonOpAnswerMultiOption = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.AnswerMultiOption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.AnswerMultiOption, objUserAnswerResultCond.AnswerMultiOption, strComparisonOpAnswerMultiOption);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.UpdDate) == true)
{
string strComparisonOpUpdDate = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.UpdDate, objUserAnswerResultCond.UpdDate, strComparisonOpUpdDate);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.UpdUser) == true)
{
string strComparisonOpUpdUser = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.UpdUser, objUserAnswerResultCond.UpdUser, strComparisonOpUpdUser);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.Memo) == true)
{
string strComparisonOpMemo = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.Memo, objUserAnswerResultCond.Memo, strComparisonOpMemo);
}
if (objUserAnswerResultCond.IsUpdated(conUserAnswerResult.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objUserAnswerResultCond.dicFldComparisonOp[conUserAnswerResult.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conUserAnswerResult.QuestionnaireSetId, objUserAnswerResultCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--UserAnswerResult(用户答题结果), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseExamPaperId_ExamBatchNo_QuestionId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsUserAnswerResultEN objUserAnswerResultEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objUserAnswerResultEN == null) return true;
if (objUserAnswerResultEN.MinId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUserAnswerResultEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objUserAnswerResultEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objUserAnswerResultEN.CourseExamPaperId);
}
 if (objUserAnswerResultEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objUserAnswerResultEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objUserAnswerResultEN.QuestionId);
}
 if (objUserAnswerResultEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objUserAnswerResultEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserAnswerResultEN.UserId);
}
 if (objUserAnswerResultEN.ExamBatchNo == null)
{
 sbCondition.AppendFormat(" and ExamBatchNo is null", objUserAnswerResultEN.ExamBatchNo);
}
else
{
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objUserAnswerResultEN.ExamBatchNo);
}
if (clsUserAnswerResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("MinId !=  {0}", objUserAnswerResultEN.MinId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objUserAnswerResultEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objUserAnswerResultEN.QuestionId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserAnswerResultEN.UserId);
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objUserAnswerResultEN.ExamBatchNo);
if (clsUserAnswerResultBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--UserAnswerResult(用户答题结果), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseExamPaperId_ExamBatchNo_QuestionId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsUserAnswerResultEN objUserAnswerResultEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objUserAnswerResultEN == null) return "";
if (objUserAnswerResultEN.MinId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objUserAnswerResultEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objUserAnswerResultEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objUserAnswerResultEN.CourseExamPaperId);
}
 if (objUserAnswerResultEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objUserAnswerResultEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objUserAnswerResultEN.QuestionId);
}
 if (objUserAnswerResultEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objUserAnswerResultEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserAnswerResultEN.UserId);
}
 if (objUserAnswerResultEN.ExamBatchNo == null)
{
 sbCondition.AppendFormat(" and ExamBatchNo is null", objUserAnswerResultEN.ExamBatchNo);
}
else
{
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objUserAnswerResultEN.ExamBatchNo);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("MinId !=  {0}", objUserAnswerResultEN.MinId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objUserAnswerResultEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objUserAnswerResultEN.QuestionId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserAnswerResultEN.UserId);
 sbCondition.AppendFormat(" and ExamBatchNo = '{0}'", objUserAnswerResultEN.ExamBatchNo);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_UserAnswerResult
{
public virtual bool UpdRelaTabDate(long lngMinId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户答题结果(UserAnswerResult)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsUserAnswerResultBL
{
public static RelatedActions_UserAnswerResult relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsUserAnswerResultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsUserAnswerResultDA UserAnswerResultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsUserAnswerResultDA();
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
 public clsUserAnswerResultBL()
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
if (string.IsNullOrEmpty(clsUserAnswerResultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserAnswerResultEN._ConnectString);
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
public static DataTable GetDataTable_UserAnswerResult(string strWhereCond)
{
DataTable objDT;
try
{
objDT = UserAnswerResultDA.GetDataTable_UserAnswerResult(strWhereCond);
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
objDT = UserAnswerResultDA.GetDataTable(strWhereCond);
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
objDT = UserAnswerResultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = UserAnswerResultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = UserAnswerResultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = UserAnswerResultDA.GetDataTable_Top(objTopPara);
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
objDT = UserAnswerResultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = UserAnswerResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = UserAnswerResultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMinIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLstByMinIdLst(List<long> arrMinIdLst)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMinIdLst);
 string strWhereCond = string.Format("MinId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMinIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsUserAnswerResultEN> GetObjLstByMinIdLstCache(List<long> arrMinIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName, strIdCurrEduCls);
List<clsUserAnswerResultEN> arrUserAnswerResultObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsUserAnswerResultEN> arrUserAnswerResultObjLst_Sel =
arrUserAnswerResultObjLstCache
.Where(x => arrMinIdLst.Contains(x.MinId));
return arrUserAnswerResultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLst(string strWhereCond)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
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
public static List<clsUserAnswerResultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objUserAnswerResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsUserAnswerResultEN> GetSubObjLstCache(clsUserAnswerResultEN objUserAnswerResultCond)
{
 string strIdCurrEduCls = objUserAnswerResultCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsUserAnswerResultBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsUserAnswerResultEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsUserAnswerResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserAnswerResult.AttributeName)
{
if (objUserAnswerResultCond.IsUpdated(strFldName) == false) continue;
if (objUserAnswerResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserAnswerResultCond[strFldName].ToString());
}
else
{
if (objUserAnswerResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserAnswerResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserAnswerResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserAnswerResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserAnswerResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserAnswerResultCond[strFldName]));
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
public static List<clsUserAnswerResultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
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
public static List<clsUserAnswerResultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
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
List<clsUserAnswerResultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsUserAnswerResultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserAnswerResultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsUserAnswerResultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
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
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
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
public static List<clsUserAnswerResultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsUserAnswerResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
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
public static List<clsUserAnswerResultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsUserAnswerResultEN> arrObjLst = new List<clsUserAnswerResultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserAnswerResultEN objUserAnswerResultEN = new clsUserAnswerResultEN();
try
{
objUserAnswerResultEN.MinId = Int32.Parse(objRow[conUserAnswerResult.MinId].ToString().Trim()); //MinId
objUserAnswerResultEN.QuestionId = objRow[conUserAnswerResult.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.QuestionId].ToString().Trim()); //题目Id
objUserAnswerResultEN.CourseId = objRow[conUserAnswerResult.CourseId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseId].ToString().Trim(); //课程Id
objUserAnswerResultEN.IdCurrEduCls = objRow[conUserAnswerResult.IdCurrEduCls] == DBNull.Value ? null : objRow[conUserAnswerResult.IdCurrEduCls].ToString().Trim(); //教学班流水号
objUserAnswerResultEN.ExamBatchNo = objRow[conUserAnswerResult.ExamBatchNo] == DBNull.Value ? null : objRow[conUserAnswerResult.ExamBatchNo].ToString().Trim(); //学生批次号
objUserAnswerResultEN.CourseExamPaperId = objRow[conUserAnswerResult.CourseExamPaperId] == DBNull.Value ? null : objRow[conUserAnswerResult.CourseExamPaperId].ToString().Trim(); //考卷流水号
objUserAnswerResultEN.AnswerOptionId = objRow[conUserAnswerResult.AnswerOptionId] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerOptionId].ToString().Trim(); //回答选项Id
objUserAnswerResultEN.BatchId = objRow[conUserAnswerResult.BatchId] == DBNull.Value ? null : objRow[conUserAnswerResult.BatchId].ToString().Trim(); //批次ID
objUserAnswerResultEN.UserId = objRow[conUserAnswerResult.UserId] == DBNull.Value ? null : objRow[conUserAnswerResult.UserId].ToString().Trim(); //用户ID
objUserAnswerResultEN.AnswerText = objRow[conUserAnswerResult.AnswerText] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerText].ToString().Trim(); //回答文本
objUserAnswerResultEN.AnswerDate = objRow[conUserAnswerResult.AnswerDate] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerDate].ToString().Trim(); //回答日期
objUserAnswerResultEN.AnswerTime = objRow[conUserAnswerResult.AnswerTime] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerTime].ToString().Trim(); //回答时间
objUserAnswerResultEN.AnswerIP = objRow[conUserAnswerResult.AnswerIP] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerIP].ToString().Trim(); //回答IP
objUserAnswerResultEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccess].ToString().Trim()); //IsAccess
objUserAnswerResultEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessC].ToString().Trim()); //IsAccessC
objUserAnswerResultEN.IdSchool = objRow[conUserAnswerResult.IdSchool] == DBNull.Value ? null : objRow[conUserAnswerResult.IdSchool].ToString().Trim(); //学校流水号
objUserAnswerResultEN.School = objRow[conUserAnswerResult.School] == DBNull.Value ? null : objRow[conUserAnswerResult.School].ToString().Trim(); //School
objUserAnswerResultEN.AnswerMode = objRow[conUserAnswerResult.AnswerMode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerMode].ToString().Trim()); //AnswerMode
objUserAnswerResultEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsMarking].ToString().Trim()); //是否批阅
objUserAnswerResultEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsRight].ToString().Trim()); //是否正确
objUserAnswerResultEN.Score = objRow[conUserAnswerResult.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conUserAnswerResult.Score].ToString().Trim()); //得分
objUserAnswerResultEN.MarkTime = objRow[conUserAnswerResult.MarkTime] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkTime].ToString().Trim(); //批改时间
objUserAnswerResultEN.MarkerId = objRow[conUserAnswerResult.MarkerId] == DBNull.Value ? null : objRow[conUserAnswerResult.MarkerId].ToString().Trim(); //打分者
objUserAnswerResultEN.Comment = objRow[conUserAnswerResult.Comment] == DBNull.Value ? null : objRow[conUserAnswerResult.Comment].ToString().Trim(); //批注
objUserAnswerResultEN.IsAccessKnowledge = clsEntityBase2.TransNullToBool_S(objRow[conUserAnswerResult.IsAccessKnowledge].ToString().Trim()); //是否处理知识点
objUserAnswerResultEN.AnswerId = objRow[conUserAnswerResult.AnswerId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserAnswerResult.AnswerId].ToString().Trim()); //问答ID
objUserAnswerResultEN.AnswerMultiOption = objRow[conUserAnswerResult.AnswerMultiOption] == DBNull.Value ? null : objRow[conUserAnswerResult.AnswerMultiOption].ToString().Trim(); //多选项答案
objUserAnswerResultEN.UpdDate = objRow[conUserAnswerResult.UpdDate].ToString().Trim(); //修改日期
objUserAnswerResultEN.UpdUser = objRow[conUserAnswerResult.UpdUser].ToString().Trim(); //修改人
objUserAnswerResultEN.Memo = objRow[conUserAnswerResult.Memo] == DBNull.Value ? null : objRow[conUserAnswerResult.Memo].ToString().Trim(); //备注
objUserAnswerResultEN.QuestionnaireSetId = objRow[conUserAnswerResult.QuestionnaireSetId] == DBNull.Value ? null : objRow[conUserAnswerResult.QuestionnaireSetId].ToString().Trim(); //问卷集ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objUserAnswerResultEN.MinId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objUserAnswerResultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetUserAnswerResult(ref clsUserAnswerResultEN objUserAnswerResultEN)
{
bool bolResult = UserAnswerResultDA.GetUserAnswerResult(ref objUserAnswerResultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngMinId">表关键字</param>
 /// <returns>表对象</returns>
public static clsUserAnswerResultEN GetObjByMinId(long lngMinId)
{
clsUserAnswerResultEN objUserAnswerResultEN = UserAnswerResultDA.GetObjByMinId(lngMinId);
return objUserAnswerResultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsUserAnswerResultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsUserAnswerResultEN objUserAnswerResultEN = UserAnswerResultDA.GetFirstObj(strWhereCond);
 return objUserAnswerResultEN;
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
public static clsUserAnswerResultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsUserAnswerResultEN objUserAnswerResultEN = UserAnswerResultDA.GetObjByDataRow(objRow);
 return objUserAnswerResultEN;
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
public static clsUserAnswerResultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsUserAnswerResultEN objUserAnswerResultEN = UserAnswerResultDA.GetObjByDataRow(objRow);
 return objUserAnswerResultEN;
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
 /// <param name = "lngMinId">所给的关键字</param>
 /// <param name = "lstUserAnswerResultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserAnswerResultEN GetObjByMinIdFromList(long lngMinId, List<clsUserAnswerResultEN> lstUserAnswerResultObjLst)
{
foreach (clsUserAnswerResultEN objUserAnswerResultEN in lstUserAnswerResultObjLst)
{
if (objUserAnswerResultEN.MinId == lngMinId)
{
return objUserAnswerResultEN;
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
 long lngMinId;
 try
 {
 lngMinId = new clsUserAnswerResultDA().GetFirstID(strWhereCond);
 return lngMinId;
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
 arrList = UserAnswerResultDA.GetID(strWhereCond);
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
bool bolIsExist = UserAnswerResultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngMinId)
{
//检测记录是否存在
bool bolIsExist = UserAnswerResultDA.IsExist(lngMinId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngMinId">MinId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngMinId, string strOpUser)
{
clsUserAnswerResultEN objUserAnswerResultEN = clsUserAnswerResultBL.GetObjByMinId(lngMinId);
objUserAnswerResultEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objUserAnswerResultEN.UpdUser = strOpUser;
return clsUserAnswerResultBL.UpdateBySql2(objUserAnswerResultEN);
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
 bolIsExist = clsUserAnswerResultDA.IsExistTable();
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
 bolIsExist = UserAnswerResultDA.IsExistTable(strTabName);
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserAnswerResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],题目Id = [{1}],用户ID = [{2}],学生批次号 = [{3}]的数据已经存在!(in clsUserAnswerResultBL.AddNewRecordBySql2)", objUserAnswerResultEN.CourseExamPaperId,objUserAnswerResultEN.QuestionId,objUserAnswerResultEN.UserId,objUserAnswerResultEN.ExamBatchNo);
throw new Exception(strMsg);
}
try
{
bool bolResult = UserAnswerResultDA.AddNewRecordBySQL2(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsUserAnswerResultEN objUserAnswerResultEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objUserAnswerResultEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],题目Id = [{1}],用户ID = [{2}],学生批次号 = [{3}]的数据已经存在!(in clsUserAnswerResultBL.AddNewRecordBySql2WithReturnKey)", objUserAnswerResultEN.CourseExamPaperId,objUserAnswerResultEN.QuestionId,objUserAnswerResultEN.UserId,objUserAnswerResultEN.ExamBatchNo);
throw new Exception(strMsg);
}
try
{
string strKey = UserAnswerResultDA.AddNewRecordBySQL2WithReturnKey(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsUserAnswerResultEN objUserAnswerResultEN)
{
try
{
bool bolResult = UserAnswerResultDA.Update(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "objUserAnswerResultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsUserAnswerResultEN objUserAnswerResultEN)
{
 if (objUserAnswerResultEN.MinId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = UserAnswerResultDA.UpdateBySql2(objUserAnswerResultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsUserAnswerResultBL.ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
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
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngMinId)
{
try
{
 clsUserAnswerResultEN objUserAnswerResultEN = clsUserAnswerResultBL.GetObjByMinId(lngMinId);

if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(objUserAnswerResultEN.MinId, objUserAnswerResultEN.UpdUser);
}
if (objUserAnswerResultEN != null)
{
int intRecNum = UserAnswerResultDA.DelRecord(lngMinId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);
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
/// <param name="lngMinId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngMinId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
//删除与表:[UserAnswerResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conUserAnswerResult.MinId,
//lngMinId);
//        clsUserAnswerResultBL.DelUserAnswerResultsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserAnswerResultBL.DelRecord(lngMinId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserAnswerResultBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngMinId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngMinId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngMinId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsUserAnswerResultBL.relatedActions != null)
{
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(lngMinId, "UpdRelaTabDate");
}
bool bolResult = UserAnswerResultDA.DelRecord(lngMinId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrMinIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelUserAnswerResults(List<string> arrMinIdLst)
{
if (arrMinIdLst.Count == 0) return 0;
try
{
if (clsUserAnswerResultBL.relatedActions != null)
{
foreach (var strMinId in arrMinIdLst)
{
long lngMinId = long.Parse(strMinId);
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(lngMinId, "UpdRelaTabDate");
}
}
 clsUserAnswerResultEN objUserAnswerResultEN = clsUserAnswerResultBL.GetObjByMinId(long.Parse(arrMinIdLst[0]));
int intDelRecNum = UserAnswerResultDA.DelUserAnswerResult(arrMinIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objUserAnswerResultEN.IdCurrEduCls);
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
public static int DelUserAnswerResultsByCond(string strWhereCond)
{
try
{
if (clsUserAnswerResultBL.relatedActions != null)
{
List<string> arrMinId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strMinId in arrMinId)
{
long lngMinId = long.Parse(strMinId);
clsUserAnswerResultBL.relatedActions.UpdRelaTabDate(lngMinId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conUserAnswerResult.IdCurrEduCls, strWhereCond);
int intRecNum = UserAnswerResultDA.DelUserAnswerResult(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[UserAnswerResult]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngMinId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngMinId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsUserAnswerResultDA.GetSpecSQLObj();
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
//删除与表:[UserAnswerResult]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsUserAnswerResultBL.DelRecord(lngMinId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsUserAnswerResultBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngMinId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objUserAnswerResultENS">源对象</param>
 /// <param name = "objUserAnswerResultENT">目标对象</param>
 public static void CopyTo(clsUserAnswerResultEN objUserAnswerResultENS, clsUserAnswerResultEN objUserAnswerResultENT)
{
try
{
objUserAnswerResultENT.MinId = objUserAnswerResultENS.MinId; //MinId
objUserAnswerResultENT.QuestionId = objUserAnswerResultENS.QuestionId; //题目Id
objUserAnswerResultENT.CourseId = objUserAnswerResultENS.CourseId; //课程Id
objUserAnswerResultENT.IdCurrEduCls = objUserAnswerResultENS.IdCurrEduCls; //教学班流水号
objUserAnswerResultENT.ExamBatchNo = objUserAnswerResultENS.ExamBatchNo; //学生批次号
objUserAnswerResultENT.CourseExamPaperId = objUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objUserAnswerResultENT.AnswerOptionId = objUserAnswerResultENS.AnswerOptionId; //回答选项Id
objUserAnswerResultENT.BatchId = objUserAnswerResultENS.BatchId; //批次ID
objUserAnswerResultENT.UserId = objUserAnswerResultENS.UserId; //用户ID
objUserAnswerResultENT.AnswerText = objUserAnswerResultENS.AnswerText; //回答文本
objUserAnswerResultENT.AnswerDate = objUserAnswerResultENS.AnswerDate; //回答日期
objUserAnswerResultENT.AnswerTime = objUserAnswerResultENS.AnswerTime; //回答时间
objUserAnswerResultENT.AnswerIP = objUserAnswerResultENS.AnswerIP; //回答IP
objUserAnswerResultENT.IsAccess = objUserAnswerResultENS.IsAccess; //IsAccess
objUserAnswerResultENT.IsAccessC = objUserAnswerResultENS.IsAccessC; //IsAccessC
objUserAnswerResultENT.IdSchool = objUserAnswerResultENS.IdSchool; //学校流水号
objUserAnswerResultENT.School = objUserAnswerResultENS.School; //School
objUserAnswerResultENT.AnswerMode = objUserAnswerResultENS.AnswerMode; //AnswerMode
objUserAnswerResultENT.IsMarking = objUserAnswerResultENS.IsMarking; //是否批阅
objUserAnswerResultENT.IsRight = objUserAnswerResultENS.IsRight; //是否正确
objUserAnswerResultENT.Score = objUserAnswerResultENS.Score; //得分
objUserAnswerResultENT.MarkTime = objUserAnswerResultENS.MarkTime; //批改时间
objUserAnswerResultENT.MarkerId = objUserAnswerResultENS.MarkerId; //打分者
objUserAnswerResultENT.Comment = objUserAnswerResultENS.Comment; //批注
objUserAnswerResultENT.IsAccessKnowledge = objUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objUserAnswerResultENT.AnswerId = objUserAnswerResultENS.AnswerId; //问答ID
objUserAnswerResultENT.AnswerMultiOption = objUserAnswerResultENS.AnswerMultiOption; //多选项答案
objUserAnswerResultENT.UpdDate = objUserAnswerResultENS.UpdDate; //修改日期
objUserAnswerResultENT.UpdUser = objUserAnswerResultENS.UpdUser; //修改人
objUserAnswerResultENT.Memo = objUserAnswerResultENS.Memo; //备注
objUserAnswerResultENT.QuestionnaireSetId = objUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
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
 /// <param name = "objUserAnswerResultEN">源简化对象</param>
 public static void SetUpdFlag(clsUserAnswerResultEN objUserAnswerResultEN)
{
try
{
objUserAnswerResultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objUserAnswerResultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conUserAnswerResult.MinId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.MinId = objUserAnswerResultEN.MinId; //MinId
}
if (arrFldSet.Contains(conUserAnswerResult.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.QuestionId = objUserAnswerResultEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conUserAnswerResult.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.CourseId = objUserAnswerResultEN.CourseId == "[null]" ? null :  objUserAnswerResultEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conUserAnswerResult.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.IdCurrEduCls = objUserAnswerResultEN.IdCurrEduCls == "[null]" ? null :  objUserAnswerResultEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conUserAnswerResult.ExamBatchNo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.ExamBatchNo = objUserAnswerResultEN.ExamBatchNo == "[null]" ? null :  objUserAnswerResultEN.ExamBatchNo; //学生批次号
}
if (arrFldSet.Contains(conUserAnswerResult.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.CourseExamPaperId = objUserAnswerResultEN.CourseExamPaperId == "[null]" ? null :  objUserAnswerResultEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerOptionId = objUserAnswerResultEN.AnswerOptionId == "[null]" ? null :  objUserAnswerResultEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(conUserAnswerResult.BatchId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.BatchId = objUserAnswerResultEN.BatchId == "[null]" ? null :  objUserAnswerResultEN.BatchId; //批次ID
}
if (arrFldSet.Contains(conUserAnswerResult.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.UserId = objUserAnswerResultEN.UserId == "[null]" ? null :  objUserAnswerResultEN.UserId; //用户ID
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerText, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerText = objUserAnswerResultEN.AnswerText == "[null]" ? null :  objUserAnswerResultEN.AnswerText; //回答文本
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerDate = objUserAnswerResultEN.AnswerDate == "[null]" ? null :  objUserAnswerResultEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerTime = objUserAnswerResultEN.AnswerTime == "[null]" ? null :  objUserAnswerResultEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerIP = objUserAnswerResultEN.AnswerIP == "[null]" ? null :  objUserAnswerResultEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(conUserAnswerResult.IsAccess, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.IsAccess = objUserAnswerResultEN.IsAccess; //IsAccess
}
if (arrFldSet.Contains(conUserAnswerResult.IsAccessC, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.IsAccessC = objUserAnswerResultEN.IsAccessC; //IsAccessC
}
if (arrFldSet.Contains(conUserAnswerResult.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.IdSchool = objUserAnswerResultEN.IdSchool == "[null]" ? null :  objUserAnswerResultEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conUserAnswerResult.School, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.School = objUserAnswerResultEN.School == "[null]" ? null :  objUserAnswerResultEN.School; //School
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerMode, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerMode = objUserAnswerResultEN.AnswerMode; //AnswerMode
}
if (arrFldSet.Contains(conUserAnswerResult.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.IsMarking = objUserAnswerResultEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(conUserAnswerResult.IsRight, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.IsRight = objUserAnswerResultEN.IsRight; //是否正确
}
if (arrFldSet.Contains(conUserAnswerResult.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.Score = objUserAnswerResultEN.Score; //得分
}
if (arrFldSet.Contains(conUserAnswerResult.MarkTime, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.MarkTime = objUserAnswerResultEN.MarkTime == "[null]" ? null :  objUserAnswerResultEN.MarkTime; //批改时间
}
if (arrFldSet.Contains(conUserAnswerResult.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.MarkerId = objUserAnswerResultEN.MarkerId == "[null]" ? null :  objUserAnswerResultEN.MarkerId; //打分者
}
if (arrFldSet.Contains(conUserAnswerResult.Comment, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.Comment = objUserAnswerResultEN.Comment == "[null]" ? null :  objUserAnswerResultEN.Comment; //批注
}
if (arrFldSet.Contains(conUserAnswerResult.IsAccessKnowledge, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.IsAccessKnowledge = objUserAnswerResultEN.IsAccessKnowledge; //是否处理知识点
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerId = objUserAnswerResultEN.AnswerId; //问答ID
}
if (arrFldSet.Contains(conUserAnswerResult.AnswerMultiOption, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.AnswerMultiOption = objUserAnswerResultEN.AnswerMultiOption == "[null]" ? null :  objUserAnswerResultEN.AnswerMultiOption; //多选项答案
}
if (arrFldSet.Contains(conUserAnswerResult.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.UpdDate = objUserAnswerResultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conUserAnswerResult.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.UpdUser = objUserAnswerResultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conUserAnswerResult.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.Memo = objUserAnswerResultEN.Memo == "[null]" ? null :  objUserAnswerResultEN.Memo; //备注
}
if (arrFldSet.Contains(conUserAnswerResult.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objUserAnswerResultEN.QuestionnaireSetId = objUserAnswerResultEN.QuestionnaireSetId == "[null]" ? null :  objUserAnswerResultEN.QuestionnaireSetId; //问卷集ID
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
 /// <param name = "objUserAnswerResultEN">源简化对象</param>
 public static void AccessFldValueNull(clsUserAnswerResultEN objUserAnswerResultEN)
{
try
{
if (objUserAnswerResultEN.CourseId == "[null]") objUserAnswerResultEN.CourseId = null; //课程Id
if (objUserAnswerResultEN.IdCurrEduCls == "[null]") objUserAnswerResultEN.IdCurrEduCls = null; //教学班流水号
if (objUserAnswerResultEN.ExamBatchNo == "[null]") objUserAnswerResultEN.ExamBatchNo = null; //学生批次号
if (objUserAnswerResultEN.CourseExamPaperId == "[null]") objUserAnswerResultEN.CourseExamPaperId = null; //考卷流水号
if (objUserAnswerResultEN.AnswerOptionId == "[null]") objUserAnswerResultEN.AnswerOptionId = null; //回答选项Id
if (objUserAnswerResultEN.BatchId == "[null]") objUserAnswerResultEN.BatchId = null; //批次ID
if (objUserAnswerResultEN.UserId == "[null]") objUserAnswerResultEN.UserId = null; //用户ID
if (objUserAnswerResultEN.AnswerText == "[null]") objUserAnswerResultEN.AnswerText = null; //回答文本
if (objUserAnswerResultEN.AnswerDate == "[null]") objUserAnswerResultEN.AnswerDate = null; //回答日期
if (objUserAnswerResultEN.AnswerTime == "[null]") objUserAnswerResultEN.AnswerTime = null; //回答时间
if (objUserAnswerResultEN.AnswerIP == "[null]") objUserAnswerResultEN.AnswerIP = null; //回答IP
if (objUserAnswerResultEN.IdSchool == "[null]") objUserAnswerResultEN.IdSchool = null; //学校流水号
if (objUserAnswerResultEN.School == "[null]") objUserAnswerResultEN.School = null; //School
if (objUserAnswerResultEN.MarkTime == "[null]") objUserAnswerResultEN.MarkTime = null; //批改时间
if (objUserAnswerResultEN.MarkerId == "[null]") objUserAnswerResultEN.MarkerId = null; //打分者
if (objUserAnswerResultEN.Comment == "[null]") objUserAnswerResultEN.Comment = null; //批注
if (objUserAnswerResultEN.AnswerMultiOption == "[null]") objUserAnswerResultEN.AnswerMultiOption = null; //多选项答案
if (objUserAnswerResultEN.Memo == "[null]") objUserAnswerResultEN.Memo = null; //备注
if (objUserAnswerResultEN.QuestionnaireSetId == "[null]") objUserAnswerResultEN.QuestionnaireSetId = null; //问卷集ID
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
public static void CheckPropertyNew(clsUserAnswerResultEN objUserAnswerResultEN)
{
 UserAnswerResultDA.CheckPropertyNew(objUserAnswerResultEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsUserAnswerResultEN objUserAnswerResultEN)
{
 UserAnswerResultDA.CheckProperty4Condition(objUserAnswerResultEN);
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
if (clsUserAnswerResultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserAnswerResultBL没有刷新缓存机制(clsUserAnswerResultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by MinId");
//if (arrUserAnswerResultObjLstCache == null)
//{
//arrUserAnswerResultObjLstCache = UserAnswerResultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngMinId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsUserAnswerResultEN GetObjByMinIdCache(long lngMinId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName, strIdCurrEduCls);
List<clsUserAnswerResultEN> arrUserAnswerResultObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsUserAnswerResultEN> arrUserAnswerResultObjLst_Sel =
arrUserAnswerResultObjLstCache
.Where(x=> x.MinId == lngMinId 
);
if (arrUserAnswerResultObjLst_Sel.Count() == 0)
{
   clsUserAnswerResultEN obj = clsUserAnswerResultBL.GetObjByMinId(lngMinId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngMinId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrUserAnswerResultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserAnswerResultEN> GetAllUserAnswerResultObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsUserAnswerResultEN> arrUserAnswerResultObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrUserAnswerResultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsUserAnswerResultEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsUserAnswerResultEN> arrUserAnswerResultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrUserAnswerResultObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsUserAnswerResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsUserAnswerResultEN._RefreshTimeLst.Count == 0) return "";
return clsUserAnswerResultEN._RefreshTimeLst[clsUserAnswerResultEN._RefreshTimeLst.Count - 1];
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
if (clsUserAnswerResultBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsUserAnswerResultEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsUserAnswerResultEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsUserAnswerResultBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--UserAnswerResult(用户答题结果)
 /// 唯一性条件:CourseExamPaperId_ExamBatchNo_QuestionId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserAnswerResultEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsUserAnswerResultEN objUserAnswerResultEN)
{
//检测记录是否存在
string strResult = UserAnswerResultDA.GetUniCondStr(objUserAnswerResultEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngMinId, string strIdCurrEduCls)
{
if (strInFldName != conUserAnswerResult.MinId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conUserAnswerResult.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conUserAnswerResult.AttributeName));
throw new Exception(strMsg);
}
var objUserAnswerResult = clsUserAnswerResultBL.GetObjByMinIdCache(lngMinId, strIdCurrEduCls);
if (objUserAnswerResult == null) return "";
return objUserAnswerResult[strOutFldName].ToString();
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
int intRecCount = clsUserAnswerResultDA.GetRecCount(strTabName);
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
int intRecCount = clsUserAnswerResultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsUserAnswerResultDA.GetRecCount();
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
int intRecCount = clsUserAnswerResultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objUserAnswerResultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsUserAnswerResultEN objUserAnswerResultCond)
{
 string strIdCurrEduCls = objUserAnswerResultCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsUserAnswerResultBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsUserAnswerResultEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsUserAnswerResultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conUserAnswerResult.AttributeName)
{
if (objUserAnswerResultCond.IsUpdated(strFldName) == false) continue;
if (objUserAnswerResultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserAnswerResultCond[strFldName].ToString());
}
else
{
if (objUserAnswerResultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objUserAnswerResultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objUserAnswerResultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objUserAnswerResultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objUserAnswerResultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objUserAnswerResultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objUserAnswerResultCond[strFldName]));
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
 List<string> arrList = clsUserAnswerResultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = UserAnswerResultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = UserAnswerResultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = UserAnswerResultDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserAnswerResultDA.SetFldValue(clsUserAnswerResultEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = UserAnswerResultDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserAnswerResultDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsUserAnswerResultDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsUserAnswerResultDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[UserAnswerResult] "); 
 strCreateTabCode.Append(" ( "); 
 // /**MinId*/ 
 strCreateTabCode.Append(" MinId bigint primary key identity, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**学生批次号*/ 
 strCreateTabCode.Append(" ExamBatchNo varchar(20) Null, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) Null, "); 
 // /**回答选项Id*/ 
 strCreateTabCode.Append(" AnswerOptionId char(8) Null, "); 
 // /**批次ID*/ 
 strCreateTabCode.Append(" BatchId char(4) Null, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**回答文本*/ 
 strCreateTabCode.Append(" AnswerText varchar(8000) Null, "); 
 // /**回答日期*/ 
 strCreateTabCode.Append(" AnswerDate varchar(8) Null, "); 
 // /**回答时间*/ 
 strCreateTabCode.Append(" AnswerTime varchar(10) Null, "); 
 // /**回答IP*/ 
 strCreateTabCode.Append(" AnswerIP varchar(30) Null, "); 
 // /**IsAccess*/ 
 strCreateTabCode.Append(" IsAccess bit Null, "); 
 // /**IsAccessC*/ 
 strCreateTabCode.Append(" IsAccessC bit Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**School*/ 
 strCreateTabCode.Append(" School varchar(50) Null, "); 
 // /**AnswerMode*/ 
 strCreateTabCode.Append(" AnswerMode int Null, "); 
 // /**是否批阅*/ 
 strCreateTabCode.Append(" IsMarking bit Null, "); 
 // /**是否正确*/ 
 strCreateTabCode.Append(" IsRight bit Null, "); 
 // /**得分*/ 
 strCreateTabCode.Append(" Score decimal(6,1) Null, "); 
 // /**批改时间*/ 
 strCreateTabCode.Append(" MarkTime varchar(14) Null, "); 
 // /**打分者*/ 
 strCreateTabCode.Append(" MarkerId varchar(20) Null, "); 
 // /**批注*/ 
 strCreateTabCode.Append(" Comment text Null, "); 
 // /**是否处理知识点*/ 
 strCreateTabCode.Append(" IsAccessKnowledge bit Null, "); 
 // /**问答ID*/ 
 strCreateTabCode.Append(" AnswerId bigint Null, "); 
 // /**多选项答案*/ 
 strCreateTabCode.Append(" AnswerMultiOption varchar(300) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**问卷集ID*/ 
 strCreateTabCode.Append(" QuestionnaireSetId char(4) Null, "); 
 // /**考卷名称*/ 
 strCreateTabCode.Append(" ExamPaperName varchar(500) not Null, "); 
 // /**题目名称*/ 
 strCreateTabCode.Append(" QuestionName varchar(500) not Null, "); 
 // /**选项名称*/ 
 strCreateTabCode.Append(" OptionName varchar(4000) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 用户答题结果(UserAnswerResult)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4UserAnswerResult : clsCommFun4BLV2
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
clsUserAnswerResultBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}