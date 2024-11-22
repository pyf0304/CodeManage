﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswerBL
 表名:Answer(01120002)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
public static class  clsAnswerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswerEN GetObj(this K_AnswerId_Answer myKey)
{
clsAnswerEN objAnswerEN = clsAnswerBL.AnswerDA.GetObjByAnswerId(myKey.Value);
return objAnswerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAnswerEN objAnswerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],问答序号 = [{1}]的数据已经存在!(in clsAnswerBL.AddNewRecord)", objAnswerEN.QuestionId,objAnswerEN.AnswerIndex);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsAnswerBL.AnswerDA.AddNewRecordBySQL2(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
public static bool AddRecordEx(this clsAnswerEN objAnswerEN, bool bolIsNeedCheckUniqueness = true)
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
objAnswerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objAnswerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目Id(QuestionId)=[{0}],问答序号(AnswerIndex)=[{1}])已经存在,不能重复!", objAnswerEN.QuestionId, objAnswerEN.AnswerIndex);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objAnswerEN.AddNewRecord();
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAnswerEN objAnswerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objAnswerEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],问答序号 = [{1}]的数据已经存在!(in clsAnswerBL.AddNewRecordWithReturnKey)", objAnswerEN.QuestionId,objAnswerEN.AnswerIndex);
throw new Exception(strMsg);
}
try
{
string strKey = clsAnswerBL.AnswerDA.AddNewRecordBySQL2WithReturnKey(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetAnswerId(this clsAnswerEN objAnswerEN, long lngAnswerId, string strComparisonOp="")
	{
objAnswerEN.AnswerId = lngAnswerId; //问答ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerId) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerId, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerId] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetQuestionId(this clsAnswerEN objAnswerEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, conAnswer.QuestionId);
objAnswerEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.QuestionId) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.QuestionId, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.QuestionId] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetAnswerIndex(this clsAnswerEN objAnswerEN, int intAnswerIndex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAnswerIndex, conAnswer.AnswerIndex);
objAnswerEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerIndex) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerIndex, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerIndex] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetAnswerOptionId(this clsAnswerEN objAnswerEN, string strAnswerOptionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, conAnswer.AnswerOptionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, conAnswer.AnswerOptionId);
}
objAnswerEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerOptionId) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerOptionId, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerOptionId] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetAnswerMultiOptions(this clsAnswerEN objAnswerEN, string strAnswerMultiOptions, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerMultiOptions, 300, conAnswer.AnswerMultiOptions);
}
objAnswerEN.AnswerMultiOptions = strAnswerMultiOptions; //多选项答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerMultiOptions) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerMultiOptions, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerMultiOptions] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetAnswerFillInBlank(this clsAnswerEN objAnswerEN, string strAnswerFillInBlank, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerFillInBlank, 1000, conAnswer.AnswerFillInBlank);
}
objAnswerEN.AnswerFillInBlank = strAnswerFillInBlank; //填空题答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerFillInBlank) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerFillInBlank, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerFillInBlank] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetAnswerTrueOrFalse(this clsAnswerEN objAnswerEN, bool bolAnswerTrueOrFalse, string strComparisonOp="")
	{
objAnswerEN.AnswerTrueOrFalse = bolAnswerTrueOrFalse; //判断题答案
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerTrueOrFalse) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerTrueOrFalse, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerTrueOrFalse] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetAnswerContent(this clsAnswerEN objAnswerEN, string strAnswerContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerContent, 8000, conAnswer.AnswerContent);
}
objAnswerEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.AnswerContent) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.AnswerContent, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.AnswerContent] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetIsAutoCorrect(this clsAnswerEN objAnswerEN, bool bolIsAutoCorrect, string strComparisonOp="")
	{
objAnswerEN.IsAutoCorrect = bolIsAutoCorrect; //是否支持自动批改
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.IsAutoCorrect) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.IsAutoCorrect, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.IsAutoCorrect] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetProvider(this clsAnswerEN objAnswerEN, string strProvider, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProvider, 18, conAnswer.Provider);
}
objAnswerEN.Provider = strProvider; //提供者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.Provider) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.Provider, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.Provider] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetScore(this clsAnswerEN objAnswerEN, double dblScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(dblScore, conAnswer.Score);
objAnswerEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.Score) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.Score, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.Score] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetIsShow(this clsAnswerEN objAnswerEN, bool bolIsShow, string strComparisonOp="")
	{
objAnswerEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.IsShow) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.IsShow, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.IsShow] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetCourseId(this clsAnswerEN objAnswerEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conAnswer.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conAnswer.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conAnswer.CourseId);
}
objAnswerEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.CourseId) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.CourseId, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.CourseId] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetUpdDate(this clsAnswerEN objAnswerEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conAnswer.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAnswer.UpdDate);
}
objAnswerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.UpdDate) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.UpdDate, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.UpdDate] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetUpdUser(this clsAnswerEN objAnswerEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conAnswer.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conAnswer.UpdUser);
}
objAnswerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.UpdUser) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.UpdUser, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.UpdUser] = strComparisonOp;
}
}
return objAnswerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAnswerEN SetMemo(this clsAnswerEN objAnswerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAnswer.Memo);
}
objAnswerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswerEN.dicFldComparisonOp.ContainsKey(conAnswer.Memo) == false)
{
objAnswerEN.dicFldComparisonOp.Add(conAnswer.Memo, strComparisonOp);
}
else
{
objAnswerEN.dicFldComparisonOp[conAnswer.Memo] = strComparisonOp;
}
}
return objAnswerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAnswerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAnswerEN objAnswerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAnswerEN.CheckPropertyNew();
clsAnswerEN objAnswerCond = new clsAnswerEN();
string strCondition = objAnswerCond
.SetAnswerId(objAnswerEN.AnswerId, "<>")
.SetQuestionId(objAnswerEN.QuestionId, "=")
.SetAnswerIndex(objAnswerEN.AnswerIndex, "=")
.GetCombineCondition();
objAnswerEN._IsCheckProperty = true;
bool bolIsExist = clsAnswerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AnswerID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAnswerEN.Update();
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
 /// <param name = "objAnswer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsAnswerEN objAnswer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsAnswerEN objAnswerCond = new clsAnswerEN();
string strCondition = objAnswerCond
.SetQuestionId(objAnswer.QuestionId, "=")
.SetAnswerIndex(objAnswer.AnswerIndex, "=")
.GetCombineCondition();
objAnswer._IsCheckProperty = true;
bool bolIsExist = clsAnswerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objAnswer.AnswerId = clsAnswerBL.GetFirstID_S(strCondition);
objAnswer.UpdateWithCondition(strCondition);
}
else
{
objAnswer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAnswerEN objAnswerEN)
{
 if (objAnswerEN.AnswerId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAnswerBL.AnswerDA.UpdateBySql2(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAnswerEN objAnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAnswerEN.AnswerId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAnswerBL.AnswerDA.UpdateBySql2(objAnswerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAnswerEN objAnswerEN, string strWhereCond)
{
try
{
bool bolResult = clsAnswerBL.AnswerDA.UpdateBySqlWithCondition(objAnswerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAnswerEN objAnswerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAnswerBL.AnswerDA.UpdateBySqlWithConditionTransaction(objAnswerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsAnswerEN objAnswerEN)
{
try
{
int intRecNum = clsAnswerBL.AnswerDA.DelRecord(objAnswerEN.AnswerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerENS">源对象</param>
 /// <param name = "objAnswerENT">目标对象</param>
 public static void CopyTo(this clsAnswerEN objAnswerENS, clsAnswerEN objAnswerENT)
{
try
{
objAnswerENT.AnswerId = objAnswerENS.AnswerId; //问答ID
objAnswerENT.QuestionId = objAnswerENS.QuestionId; //题目Id
objAnswerENT.AnswerIndex = objAnswerENS.AnswerIndex; //问答序号
objAnswerENT.AnswerOptionId = objAnswerENS.AnswerOptionId; //回答选项Id
objAnswerENT.AnswerMultiOptions = objAnswerENS.AnswerMultiOptions; //多选项答案
objAnswerENT.AnswerFillInBlank = objAnswerENS.AnswerFillInBlank; //填空题答案
objAnswerENT.AnswerTrueOrFalse = objAnswerENS.AnswerTrueOrFalse; //判断题答案
objAnswerENT.AnswerContent = objAnswerENS.AnswerContent; //答案内容
objAnswerENT.IsAutoCorrect = objAnswerENS.IsAutoCorrect; //是否支持自动批改
objAnswerENT.Provider = objAnswerENS.Provider; //提供者
objAnswerENT.Score = objAnswerENS.Score; //得分
objAnswerENT.IsShow = objAnswerENS.IsShow; //是否启用
objAnswerENT.CourseId = objAnswerENS.CourseId; //课程Id
objAnswerENT.UpdDate = objAnswerENS.UpdDate; //修改日期
objAnswerENT.UpdUser = objAnswerENS.UpdUser; //修改人
objAnswerENT.Memo = objAnswerENS.Memo; //备注
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
 /// <param name = "objAnswerENS">源对象</param>
 /// <returns>目标对象=>clsAnswerEN:objAnswerENT</returns>
 public static clsAnswerEN CopyTo(this clsAnswerEN objAnswerENS)
{
try
{
 clsAnswerEN objAnswerENT = new clsAnswerEN()
{
AnswerId = objAnswerENS.AnswerId, //问答ID
QuestionId = objAnswerENS.QuestionId, //题目Id
AnswerIndex = objAnswerENS.AnswerIndex, //问答序号
AnswerOptionId = objAnswerENS.AnswerOptionId, //回答选项Id
AnswerMultiOptions = objAnswerENS.AnswerMultiOptions, //多选项答案
AnswerFillInBlank = objAnswerENS.AnswerFillInBlank, //填空题答案
AnswerTrueOrFalse = objAnswerENS.AnswerTrueOrFalse, //判断题答案
AnswerContent = objAnswerENS.AnswerContent, //答案内容
IsAutoCorrect = objAnswerENS.IsAutoCorrect, //是否支持自动批改
Provider = objAnswerENS.Provider, //提供者
Score = objAnswerENS.Score, //得分
IsShow = objAnswerENS.IsShow, //是否启用
CourseId = objAnswerENS.CourseId, //课程Id
UpdDate = objAnswerENS.UpdDate, //修改日期
UpdUser = objAnswerENS.UpdUser, //修改人
Memo = objAnswerENS.Memo, //备注
};
 return objAnswerENT;
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
public static void CheckPropertyNew(this clsAnswerEN objAnswerEN)
{
 clsAnswerBL.AnswerDA.CheckPropertyNew(objAnswerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAnswerEN objAnswerEN)
{
 clsAnswerBL.AnswerDA.CheckProperty4Condition(objAnswerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAnswerEN objAnswerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAnswerCond.IsUpdated(conAnswer.AnswerId) == true)
{
string strComparisonOpAnswerId = objAnswerCond.dicFldComparisonOp[conAnswer.AnswerId];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer.AnswerId, objAnswerCond.AnswerId, strComparisonOpAnswerId);
}
if (objAnswerCond.IsUpdated(conAnswer.QuestionId) == true)
{
string strComparisonOpQuestionId = objAnswerCond.dicFldComparisonOp[conAnswer.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer.QuestionId, objAnswerCond.QuestionId, strComparisonOpQuestionId);
}
if (objAnswerCond.IsUpdated(conAnswer.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objAnswerCond.dicFldComparisonOp[conAnswer.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer.AnswerIndex, objAnswerCond.AnswerIndex, strComparisonOpAnswerIndex);
}
if (objAnswerCond.IsUpdated(conAnswer.AnswerOptionId) == true)
{
string strComparisonOpAnswerOptionId = objAnswerCond.dicFldComparisonOp[conAnswer.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerOptionId, objAnswerCond.AnswerOptionId, strComparisonOpAnswerOptionId);
}
if (objAnswerCond.IsUpdated(conAnswer.AnswerMultiOptions) == true)
{
string strComparisonOpAnswerMultiOptions = objAnswerCond.dicFldComparisonOp[conAnswer.AnswerMultiOptions];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerMultiOptions, objAnswerCond.AnswerMultiOptions, strComparisonOpAnswerMultiOptions);
}
if (objAnswerCond.IsUpdated(conAnswer.AnswerFillInBlank) == true)
{
string strComparisonOpAnswerFillInBlank = objAnswerCond.dicFldComparisonOp[conAnswer.AnswerFillInBlank];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerFillInBlank, objAnswerCond.AnswerFillInBlank, strComparisonOpAnswerFillInBlank);
}
if (objAnswerCond.IsUpdated(conAnswer.AnswerTrueOrFalse) == true)
{
if (objAnswerCond.AnswerTrueOrFalse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer.AnswerTrueOrFalse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer.AnswerTrueOrFalse);
}
}
if (objAnswerCond.IsUpdated(conAnswer.AnswerContent) == true)
{
string strComparisonOpAnswerContent = objAnswerCond.dicFldComparisonOp[conAnswer.AnswerContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.AnswerContent, objAnswerCond.AnswerContent, strComparisonOpAnswerContent);
}
if (objAnswerCond.IsUpdated(conAnswer.IsAutoCorrect) == true)
{
if (objAnswerCond.IsAutoCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer.IsAutoCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer.IsAutoCorrect);
}
}
if (objAnswerCond.IsUpdated(conAnswer.Provider) == true)
{
string strComparisonOpProvider = objAnswerCond.dicFldComparisonOp[conAnswer.Provider];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.Provider, objAnswerCond.Provider, strComparisonOpProvider);
}
if (objAnswerCond.IsUpdated(conAnswer.Score) == true)
{
string strComparisonOpScore = objAnswerCond.dicFldComparisonOp[conAnswer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer.Score, objAnswerCond.Score, strComparisonOpScore);
}
if (objAnswerCond.IsUpdated(conAnswer.IsShow) == true)
{
if (objAnswerCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer.IsShow);
}
}
if (objAnswerCond.IsUpdated(conAnswer.CourseId) == true)
{
string strComparisonOpCourseId = objAnswerCond.dicFldComparisonOp[conAnswer.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.CourseId, objAnswerCond.CourseId, strComparisonOpCourseId);
}
if (objAnswerCond.IsUpdated(conAnswer.UpdDate) == true)
{
string strComparisonOpUpdDate = objAnswerCond.dicFldComparisonOp[conAnswer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.UpdDate, objAnswerCond.UpdDate, strComparisonOpUpdDate);
}
if (objAnswerCond.IsUpdated(conAnswer.UpdUser) == true)
{
string strComparisonOpUpdUser = objAnswerCond.dicFldComparisonOp[conAnswer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.UpdUser, objAnswerCond.UpdUser, strComparisonOpUpdUser);
}
if (objAnswerCond.IsUpdated(conAnswer.Memo) == true)
{
string strComparisonOpMemo = objAnswerCond.dicFldComparisonOp[conAnswer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer.Memo, objAnswerCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Answer(答案), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AnswerIndex_QuestionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objAnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsAnswerEN objAnswerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objAnswerEN == null) return true;
if (objAnswerEN.AnswerId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objAnswerEN.QuestionId);
 sbCondition.AppendFormat(" and AnswerIndex = '{0}'", objAnswerEN.AnswerIndex);
if (clsAnswerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("AnswerId !=  {0}", objAnswerEN.AnswerId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objAnswerEN.QuestionId);
 sbCondition.AppendFormat(" and AnswerIndex = '{0}'", objAnswerEN.AnswerIndex);
if (clsAnswerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Answer(答案), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AnswerIndex_QuestionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsAnswerEN objAnswerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAnswerEN == null) return "";
if (objAnswerEN.AnswerId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objAnswerEN.QuestionId);
 sbCondition.AppendFormat(" and AnswerIndex = '{0}'", objAnswerEN.AnswerIndex);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("AnswerId !=  {0}", objAnswerEN.AnswerId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objAnswerEN.QuestionId);
 sbCondition.AppendFormat(" and AnswerIndex = '{0}'", objAnswerEN.AnswerIndex);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Answer
{
public virtual bool UpdRelaTabDate(long lngAnswerId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 答案(Answer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAnswerBL
{
public static RelatedActions_Answer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAnswerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAnswerDA AnswerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAnswerDA();
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
 public clsAnswerBL()
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
if (string.IsNullOrEmpty(clsAnswerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAnswerEN._ConnectString);
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
public static DataTable GetDataTable_Answer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = AnswerDA.GetDataTable_Answer(strWhereCond);
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
objDT = AnswerDA.GetDataTable(strWhereCond);
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
objDT = AnswerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = AnswerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = AnswerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = AnswerDA.GetDataTable_Top(objTopPara);
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
objDT = AnswerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = AnswerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsAnswerEN> GetObjLstByAnswerIdLst(List<long> arrAnswerIdLst)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrAnswerIdLst);
 string strWhereCond = string.Format("AnswerId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrAnswerIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsAnswerEN> GetObjLstByAnswerIdLstCache(List<long> arrAnswerIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName, strCourseId);
List<clsAnswerEN> arrAnswerObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsAnswerEN> arrAnswerObjLst_Sel =
arrAnswerObjLstCache
.Where(x => arrAnswerIdLst.Contains(x.AnswerId));
return arrAnswerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswerEN> GetObjLst(string strWhereCond)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
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
public static List<clsAnswerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objAnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsAnswerEN> GetSubObjLstCache(clsAnswerEN objAnswerCond)
{
 string strCourseId = objAnswerCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsAnswerBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsAnswerEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsAnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAnswer.AttributeName)
{
if (objAnswerCond.IsUpdated(strFldName) == false) continue;
if (objAnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswerCond[strFldName].ToString());
}
else
{
if (objAnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAnswerCond[strFldName]));
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
public static List<clsAnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
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
public static List<clsAnswerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
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
List<clsAnswerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAnswerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
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
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
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
public static List<clsAnswerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAnswerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
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
public static List<clsAnswerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAnswerEN> arrObjLst = new List<clsAnswerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAnswerEN objAnswerEN = new clsAnswerEN();
try
{
objAnswerEN.AnswerId = Int32.Parse(objRow[conAnswer.AnswerId].ToString().Trim()); //问答ID
objAnswerEN.QuestionId = Int32.Parse(objRow[conAnswer.QuestionId].ToString().Trim()); //题目Id
objAnswerEN.AnswerIndex = Int32.Parse(objRow[conAnswer.AnswerIndex].ToString().Trim()); //问答序号
objAnswerEN.AnswerOptionId = objRow[conAnswer.AnswerOptionId] == DBNull.Value ? null : objRow[conAnswer.AnswerOptionId].ToString().Trim(); //回答选项Id
objAnswerEN.AnswerMultiOptions = objRow[conAnswer.AnswerMultiOptions] == DBNull.Value ? null : objRow[conAnswer.AnswerMultiOptions].ToString().Trim(); //多选项答案
objAnswerEN.AnswerFillInBlank = objRow[conAnswer.AnswerFillInBlank] == DBNull.Value ? null : objRow[conAnswer.AnswerFillInBlank].ToString().Trim(); //填空题答案
objAnswerEN.AnswerTrueOrFalse = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.AnswerTrueOrFalse].ToString().Trim()); //判断题答案
objAnswerEN.AnswerContent = objRow[conAnswer.AnswerContent] == DBNull.Value ? null : objRow[conAnswer.AnswerContent].ToString().Trim(); //答案内容
objAnswerEN.IsAutoCorrect = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsAutoCorrect].ToString().Trim()); //是否支持自动批改
objAnswerEN.Provider = objRow[conAnswer.Provider] == DBNull.Value ? null : objRow[conAnswer.Provider].ToString().Trim(); //提供者
objAnswerEN.Score = Double.Parse(objRow[conAnswer.Score].ToString().Trim()); //得分
objAnswerEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conAnswer.IsShow].ToString().Trim()); //是否启用
objAnswerEN.CourseId = objRow[conAnswer.CourseId].ToString().Trim(); //课程Id
objAnswerEN.UpdDate = objRow[conAnswer.UpdDate].ToString().Trim(); //修改日期
objAnswerEN.UpdUser = objRow[conAnswer.UpdUser].ToString().Trim(); //修改人
objAnswerEN.Memo = objRow[conAnswer.Memo] == DBNull.Value ? null : objRow[conAnswer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAnswerEN.AnswerId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAnswerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAnswerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAnswer(ref clsAnswerEN objAnswerEN)
{
bool bolResult = AnswerDA.GetAnswer(ref objAnswerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswerEN GetObjByAnswerId(long lngAnswerId)
{
clsAnswerEN objAnswerEN = AnswerDA.GetObjByAnswerId(lngAnswerId);
return objAnswerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAnswerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAnswerEN objAnswerEN = AnswerDA.GetFirstObj(strWhereCond);
 return objAnswerEN;
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
public static clsAnswerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAnswerEN objAnswerEN = AnswerDA.GetObjByDataRow(objRow);
 return objAnswerEN;
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
public static clsAnswerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAnswerEN objAnswerEN = AnswerDA.GetObjByDataRow(objRow);
 return objAnswerEN;
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
 /// <param name = "lngAnswerId">所给的关键字</param>
 /// <param name = "lstAnswerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAnswerEN GetObjByAnswerIdFromList(long lngAnswerId, List<clsAnswerEN> lstAnswerObjLst)
{
foreach (clsAnswerEN objAnswerEN in lstAnswerObjLst)
{
if (objAnswerEN.AnswerId == lngAnswerId)
{
return objAnswerEN;
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
 long lngAnswerId;
 try
 {
 lngAnswerId = new clsAnswerDA().GetFirstID(strWhereCond);
 return lngAnswerId;
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
 arrList = AnswerDA.GetID(strWhereCond);
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
bool bolIsExist = AnswerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngAnswerId)
{
//检测记录是否存在
bool bolIsExist = AnswerDA.IsExist(lngAnswerId);
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
 bolIsExist = clsAnswerDA.IsExistTable();
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
 bolIsExist = AnswerDA.IsExistTable(strTabName);
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAnswerEN objAnswerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAnswerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],问答序号 = [{1}]的数据已经存在!(in clsAnswerBL.AddNewRecordBySql2)", objAnswerEN.QuestionId,objAnswerEN.AnswerIndex);
throw new Exception(strMsg);
}
try
{
bool bolResult = AnswerDA.AddNewRecordBySQL2(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAnswerEN objAnswerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objAnswerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],问答序号 = [{1}]的数据已经存在!(in clsAnswerBL.AddNewRecordBySql2WithReturnKey)", objAnswerEN.QuestionId,objAnswerEN.AnswerIndex);
throw new Exception(strMsg);
}
try
{
string strKey = AnswerDA.AddNewRecordBySQL2WithReturnKey(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAnswerEN objAnswerEN)
{
try
{
bool bolResult = AnswerDA.Update(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "objAnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAnswerEN objAnswerEN)
{
 if (objAnswerEN.AnswerId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = AnswerDA.UpdateBySql2(objAnswerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswerBL.ReFreshCache(objAnswerEN.CourseId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
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
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngAnswerId)
{
try
{
 clsAnswerEN objAnswerEN = clsAnswerBL.GetObjByAnswerId(lngAnswerId);

if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(objAnswerEN.AnswerId, "SetUpdDate");
}
if (objAnswerEN != null)
{
int intRecNum = AnswerDA.DelRecord(lngAnswerId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objAnswerEN.CourseId);
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
/// <param name="lngAnswerId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngAnswerId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAnswerDA.GetSpecSQLObj();
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
//删除与表:[Answer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAnswer.AnswerId,
//lngAnswerId);
//        clsAnswerBL.DelAnswersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAnswerBL.DelRecord(lngAnswerId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAnswerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngAnswerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngAnswerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngAnswerId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsAnswerBL.relatedActions != null)
{
clsAnswerBL.relatedActions.UpdRelaTabDate(lngAnswerId, "UpdRelaTabDate");
}
bool bolResult = AnswerDA.DelRecord(lngAnswerId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrAnswerIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelAnswers(List<string> arrAnswerIdLst)
{
if (arrAnswerIdLst.Count == 0) return 0;
try
{
if (clsAnswerBL.relatedActions != null)
{
foreach (var strAnswerId in arrAnswerIdLst)
{
long lngAnswerId = long.Parse(strAnswerId);
clsAnswerBL.relatedActions.UpdRelaTabDate(lngAnswerId, "UpdRelaTabDate");
}
}
 clsAnswerEN objAnswerEN = clsAnswerBL.GetObjByAnswerId(long.Parse(arrAnswerIdLst[0]));
int intDelRecNum = AnswerDA.DelAnswer(arrAnswerIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objAnswerEN.CourseId);
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
public static int DelAnswersByCond(string strWhereCond)
{
try
{
if (clsAnswerBL.relatedActions != null)
{
List<string> arrAnswerId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strAnswerId in arrAnswerId)
{
long lngAnswerId = long.Parse(strAnswerId);
clsAnswerBL.relatedActions.UpdRelaTabDate(lngAnswerId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conAnswer.CourseId, strWhereCond);
int intRecNum = AnswerDA.DelAnswer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Answer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngAnswerId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngAnswerId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAnswerDA.GetSpecSQLObj();
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
//删除与表:[Answer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAnswerBL.DelRecord(lngAnswerId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAnswerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngAnswerId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objAnswerENS">源对象</param>
 /// <param name = "objAnswerENT">目标对象</param>
 public static void CopyTo(clsAnswerEN objAnswerENS, clsAnswerEN objAnswerENT)
{
try
{
objAnswerENT.AnswerId = objAnswerENS.AnswerId; //问答ID
objAnswerENT.QuestionId = objAnswerENS.QuestionId; //题目Id
objAnswerENT.AnswerIndex = objAnswerENS.AnswerIndex; //问答序号
objAnswerENT.AnswerOptionId = objAnswerENS.AnswerOptionId; //回答选项Id
objAnswerENT.AnswerMultiOptions = objAnswerENS.AnswerMultiOptions; //多选项答案
objAnswerENT.AnswerFillInBlank = objAnswerENS.AnswerFillInBlank; //填空题答案
objAnswerENT.AnswerTrueOrFalse = objAnswerENS.AnswerTrueOrFalse; //判断题答案
objAnswerENT.AnswerContent = objAnswerENS.AnswerContent; //答案内容
objAnswerENT.IsAutoCorrect = objAnswerENS.IsAutoCorrect; //是否支持自动批改
objAnswerENT.Provider = objAnswerENS.Provider; //提供者
objAnswerENT.Score = objAnswerENS.Score; //得分
objAnswerENT.IsShow = objAnswerENS.IsShow; //是否启用
objAnswerENT.CourseId = objAnswerENS.CourseId; //课程Id
objAnswerENT.UpdDate = objAnswerENS.UpdDate; //修改日期
objAnswerENT.UpdUser = objAnswerENS.UpdUser; //修改人
objAnswerENT.Memo = objAnswerENS.Memo; //备注
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
 /// <param name = "objAnswerEN">源简化对象</param>
 public static void SetUpdFlag(clsAnswerEN objAnswerEN)
{
try
{
objAnswerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objAnswerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAnswer.AnswerId, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.AnswerId = objAnswerEN.AnswerId; //问答ID
}
if (arrFldSet.Contains(conAnswer.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.QuestionId = objAnswerEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conAnswer.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.AnswerIndex = objAnswerEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(conAnswer.AnswerOptionId, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.AnswerOptionId = objAnswerEN.AnswerOptionId == "[null]" ? null :  objAnswerEN.AnswerOptionId; //回答选项Id
}
if (arrFldSet.Contains(conAnswer.AnswerMultiOptions, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.AnswerMultiOptions = objAnswerEN.AnswerMultiOptions == "[null]" ? null :  objAnswerEN.AnswerMultiOptions; //多选项答案
}
if (arrFldSet.Contains(conAnswer.AnswerFillInBlank, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.AnswerFillInBlank = objAnswerEN.AnswerFillInBlank == "[null]" ? null :  objAnswerEN.AnswerFillInBlank; //填空题答案
}
if (arrFldSet.Contains(conAnswer.AnswerTrueOrFalse, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.AnswerTrueOrFalse = objAnswerEN.AnswerTrueOrFalse; //判断题答案
}
if (arrFldSet.Contains(conAnswer.AnswerContent, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.AnswerContent = objAnswerEN.AnswerContent == "[null]" ? null :  objAnswerEN.AnswerContent; //答案内容
}
if (arrFldSet.Contains(conAnswer.IsAutoCorrect, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.IsAutoCorrect = objAnswerEN.IsAutoCorrect; //是否支持自动批改
}
if (arrFldSet.Contains(conAnswer.Provider, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.Provider = objAnswerEN.Provider == "[null]" ? null :  objAnswerEN.Provider; //提供者
}
if (arrFldSet.Contains(conAnswer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.Score = objAnswerEN.Score; //得分
}
if (arrFldSet.Contains(conAnswer.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.IsShow = objAnswerEN.IsShow; //是否启用
}
if (arrFldSet.Contains(conAnswer.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.CourseId = objAnswerEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conAnswer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.UpdDate = objAnswerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conAnswer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.UpdUser = objAnswerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conAnswer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objAnswerEN.Memo = objAnswerEN.Memo == "[null]" ? null :  objAnswerEN.Memo; //备注
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
 /// <param name = "objAnswerEN">源简化对象</param>
 public static void AccessFldValueNull(clsAnswerEN objAnswerEN)
{
try
{
if (objAnswerEN.AnswerOptionId == "[null]") objAnswerEN.AnswerOptionId = null; //回答选项Id
if (objAnswerEN.AnswerMultiOptions == "[null]") objAnswerEN.AnswerMultiOptions = null; //多选项答案
if (objAnswerEN.AnswerFillInBlank == "[null]") objAnswerEN.AnswerFillInBlank = null; //填空题答案
if (objAnswerEN.AnswerContent == "[null]") objAnswerEN.AnswerContent = null; //答案内容
if (objAnswerEN.Provider == "[null]") objAnswerEN.Provider = null; //提供者
if (objAnswerEN.Memo == "[null]") objAnswerEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsAnswerEN objAnswerEN)
{
 AnswerDA.CheckPropertyNew(objAnswerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAnswerEN objAnswerEN)
{
 AnswerDA.CheckProperty4Condition(objAnswerEN);
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
if (clsAnswerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerBL没有刷新缓存机制(clsAnswerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by AnswerId");
//if (arrAnswerObjLstCache == null)
//{
//arrAnswerObjLstCache = AnswerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngAnswerId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAnswerEN GetObjByAnswerIdCache(long lngAnswerId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName, strCourseId);
List<clsAnswerEN> arrAnswerObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsAnswerEN> arrAnswerObjLst_Sel =
arrAnswerObjLstCache
.Where(x=> x.AnswerId == lngAnswerId 
);
if (arrAnswerObjLst_Sel.Count() == 0)
{
   clsAnswerEN obj = clsAnswerBL.GetObjByAnswerId(lngAnswerId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngAnswerId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrAnswerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAnswerEN> GetAllAnswerObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsAnswerEN> arrAnswerObjLstCache = GetObjLstCache(strCourseId); 
return arrAnswerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAnswerEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsAnswerEN> arrAnswerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrAnswerObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsAnswerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsAnswerEN._RefreshTimeLst.Count == 0) return "";
return clsAnswerEN._RefreshTimeLst[clsAnswerEN._RefreshTimeLst.Count - 1];
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
if (clsAnswerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsAnswerEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsAnswerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsAnswerBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Answer(答案)
 /// 唯一性条件:AnswerIndex_QuestionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAnswerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsAnswerEN objAnswerEN)
{
//检测记录是否存在
string strResult = AnswerDA.GetUniCondStr(objAnswerEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngAnswerId, string strCourseId)
{
if (strInFldName != conAnswer.AnswerId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conAnswer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conAnswer.AttributeName));
throw new Exception(strMsg);
}
var objAnswer = clsAnswerBL.GetObjByAnswerIdCache(lngAnswerId, strCourseId);
if (objAnswer == null) return "";
return objAnswer[strOutFldName].ToString();
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
int intRecCount = clsAnswerDA.GetRecCount(strTabName);
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
int intRecCount = clsAnswerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAnswerDA.GetRecCount();
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
int intRecCount = clsAnswerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objAnswerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsAnswerEN objAnswerCond)
{
 string strCourseId = objAnswerCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsAnswerBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsAnswerEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsAnswerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAnswer.AttributeName)
{
if (objAnswerCond.IsUpdated(strFldName) == false) continue;
if (objAnswerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswerCond[strFldName].ToString());
}
else
{
if (objAnswerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAnswerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAnswerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAnswerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAnswerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAnswerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAnswerCond[strFldName]));
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
 List<string> arrList = clsAnswerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = AnswerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = AnswerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = AnswerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAnswerDA.SetFldValue(clsAnswerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = AnswerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAnswerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAnswerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAnswerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Answer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**问答ID*/ 
 strCreateTabCode.Append(" AnswerId bigint primary key identity, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**问答序号*/ 
 strCreateTabCode.Append(" AnswerIndex int not Null, "); 
 // /**回答选项Id*/ 
 strCreateTabCode.Append(" AnswerOptionId char(8) Null, "); 
 // /**多选项答案*/ 
 strCreateTabCode.Append(" AnswerMultiOptions varchar(300) Null, "); 
 // /**填空题答案*/ 
 strCreateTabCode.Append(" AnswerFillInBlank varchar(1000) Null, "); 
 // /**判断题答案*/ 
 strCreateTabCode.Append(" AnswerTrueOrFalse bit Null, "); 
 // /**答案内容*/ 
 strCreateTabCode.Append(" AnswerContent varchar(8000) Null, "); 
 // /**是否支持自动批改*/ 
 strCreateTabCode.Append(" IsAutoCorrect bit Null, "); 
 // /**提供者*/ 
 strCreateTabCode.Append(" Provider varchar(18) Null, "); 
 // /**得分*/ 
 strCreateTabCode.Append(" Score decimal(6,1) not Null, "); 
 // /**是否启用*/ 
 strCreateTabCode.Append(" IsShow bit Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**题目名称*/ 
 strCreateTabCode.Append(" QuestionName varchar(500) not Null, "); 
 // /**选项名称*/ 
 strCreateTabCode.Append(" OptionName varchar(4000) not Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="lngQuestionId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(long lngQuestionId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAnswer.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by AnswerIndex ");
List<clsAnswerEN> arrAnswerObjList = new clsAnswerDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAnswerEN objAnswer in arrAnswerObjList)
{
objAnswer.AnswerIndex = intIndex;
UpdateBySql2(objAnswer);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngAnswerId">所给的关键字</param>
/// <param name="lngQuestionId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, long lngAnswerId ,long lngQuestionId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[AnswerId],获取相应的序号[AnswerIndex]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字AnswerId
//5、把当前关键字AnswerId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字AnswerId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevAnswerId = 0;    //上一条序号的关键字AnswerId
long lngNextAnswerId = 0;    //下一条序号的关键字AnswerId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[AnswerId],获取相应的序号[AnswerIndex]。

clsAnswerEN objAnswer = clsAnswerBL.GetObjByAnswerId(lngAnswerId);

intOrderNum = objAnswer.AnswerIndex;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAnswer.QuestionId, lngQuestionId);
intTabRecNum = clsAnswerBL.GetRecCountByCond(clsAnswerEN._CurrTabName, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conAnswer.AnswerIndex, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conAnswer.QuestionId, lngQuestionId);
//4、获取上一个序号字段的关键字AnswerId
lngPrevAnswerId = clsAnswerBL.GetFirstID_S(sbCondition.ToString());
if (lngPrevAnswerId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字AnswerId所对应记录的序号减1
//6、把下(上)一个序号关键字AnswerId所对应的记录序号加1
clsAnswerBL.SetFldValue(clsAnswerEN._CurrTabName, conAnswer.AnswerIndex,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conAnswer.AnswerId, lngAnswerId));
clsAnswerBL.SetFldValue(clsAnswerEN._CurrTabName, conAnswer.AnswerIndex,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conAnswer.AnswerId, lngPrevAnswerId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字AnswerId
sbCondition.AppendFormat(" {0} = {1} ", conAnswer.AnswerIndex, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conAnswer.QuestionId, lngQuestionId);

lngNextAnswerId = clsAnswerBL.GetFirstID_S(sbCondition.ToString());
if (lngNextAnswerId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字AnswerId所对应记录的序号加1
//6、把下(上)一个序号关键字AnswerId所对应的记录序号减1
clsAnswerBL.SetFldValue(clsAnswerEN._CurrTabName, conAnswer.AnswerIndex,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conAnswer.AnswerId, lngAnswerId));
clsAnswerBL.SetFldValue(clsAnswerEN._CurrTabName, conAnswer.AnswerIndex,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conAnswer.AnswerId, lngNextAnswerId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId ,long lngQuestionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conAnswer.AnswerId, strKeyList);
List<clsAnswerEN> arrAnswerLst = GetObjLst(strCondition);
foreach (clsAnswerEN objAnswer in arrAnswerLst)
{
objAnswer.AnswerIndex = objAnswer.AnswerIndex + 10000;
UpdateBySql2(objAnswer);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAnswer.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by AnswerIndex ");
List<clsAnswerEN> arrAnswerObjList = new clsAnswerDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAnswerEN objAnswer in arrAnswerObjList)
{
objAnswer.AnswerIndex = intIndex;
UpdateBySql2(objAnswer);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：QuestionId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="lngQuestionId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId ,long lngQuestionId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conAnswer.AnswerId, strKeyList);
List<clsAnswerEN> arrAnswerLst = GetObjLst(strCondition);
foreach (clsAnswerEN objAnswer in arrAnswerLst)
{
objAnswer.AnswerIndex = objAnswer.AnswerIndex - 10000;
UpdateBySql2(objAnswer);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conAnswer.QuestionId, lngQuestionId);
 strCondition += string.Format(" order by AnswerIndex ");
List<clsAnswerEN> arrAnswerObjList = new clsAnswerDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAnswerEN objAnswer in arrAnswerObjList)
{
objAnswer.AnswerIndex = intIndex;
UpdateBySql2(objAnswer);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 答案(Answer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Answer : clsCommFun4BLV2
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
clsAnswerBL.ReFreshThisCache(strCourseId);
}
}

}